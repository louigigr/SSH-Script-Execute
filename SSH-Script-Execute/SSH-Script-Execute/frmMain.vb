Imports OMBKey

Public Class frmMain

    Dim qgFunc As New qgFunctions
    Public _MyCompanyKey As Byte() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Public _MyCompanyIV As Byte() = {1, 2, 3, 4, 5, 6, 7, 8}

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Dim d As Boolean = My.Computer.Network.Ping(My.Settings.stgHost, 1000)
        If d = True Then
            txtOutput.AppendText("Server is alive!" + vbNewLine)
            qgFunc.RunPlink(My.Settings.stgHost, My.Settings.stgUser, My.Settings.stgPass,
                 My.Settings.stgScriptLocation + My.Settings.stgScriptName,
                 "plink", "plink.exe", My.Settings.stgPort, comConType, txtOutput)
        Else
            txtOutput.AppendText("Server is offline or rebooting!" + vbNewLine + "Script won't execute" + vbNewLine)
        End If


    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    'Show/Hide Connection Bar
    'Private Sub mnuShowConnectionBar_Click(sender As Object, e As EventArgs) Handles mnuShowConnectionBar.Click
    '    Me.ConnectionBar.Visible = Me.mnuShowConnectionBar.Checked
    'End Sub

    'Show/Hide Status Bar

    Private Sub mnuShowStatusBar_Click(sender As Object, e As EventArgs) Handles mnuShowStatusBar.Click
        Me.StatusBar.Visible = Me.mnuShowStatusBar.Checked
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

        If My.Settings.stgRunCount = 0 Then
            txtOutput.AppendText("This is your first run, define your settings by going to" + vbNewLine +
                   "Menu -> Edit -> Setup" + vbNewLine + "Menu -> Edit -> Host List" + vbNewLine +
                   vbNewLine + "Also Make sure you grab the ssh keys each time you make" + vbNewLine +
                   "changes to the Host List panel" + vbNewLine +
                   "Make sure you set the password right or the program will fail" + vbNewLine)
            Try
                My.Computer.Registry.CurrentUser.CreateSubKey("QGSSHRUN")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "Company", "Quadrant Global Ltd")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "ProductSerial", qgFunc.AES_Encrypt(qgFunc.RandomString(160), "2133550"))
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "CustomerName", "")
                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "RegKey", "")



            Catch ex As Exception

            End Try
            'frmSettings.Show()
            My.Settings.stgRunCount = My.Settings.stgRunCount + 1
        Else
            My.Settings.stgRunCount = My.Settings.stgRunCount + 1
        End If


        If My.Settings.stgHost1 IsNot "" Then
            lblServer1.Text = My.Settings.stgHost1
        Else
            lblServer1.Text = "Name is Empty"

        End If

        If My.Settings.stgHost2 IsNot "" Then
            lblServer2.Text = My.Settings.stgHost2
        Else
            lblServer2.Text = "Server Name is Empty"
        End If

        If My.Settings.stgHost3 IsNot "" Then
            lblServer3.Text = My.Settings.stgHost3
        Else
            lblServer3.Text = "Server Name is Empty"
        End If

        comConType.SelectedItem = "Conect Using Custom Port"

        ' LICENSE CHECK
        Dim keyvalue = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "Regkey", Nothing)
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "Regkey", Nothing) Is Nothing Then
            MsgBox("No REGISTRATION FOUND")
            frmLicSplash.Show()
            Me.Opacity = 0

        Else
            Try
                Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)
                Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey("The Great Hello World Software Company",
                                                                                                   "1234567891234567", My.Settings.stgClientName,
                                                                                                   qgFunc.AES_Decrypt(keyvalue, "2133"))
                MsgBox("licence pass")
            Catch ex As Exception
                MsgBox("licence fail")
                frmLicSplash.Show()
                Me.Opacity = 0
            End Try



        End If


        'If My.Settings.stgClientName = "" Or My.Settings.stgSerial = "" Then
        '    MsgBox("Software needs registration")
        'Else
        '    Try
        '        ' Create the key consuming/buying object
        '        Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)

        '        ' Validate the key, if its valid then the feature set it unlocks will be returned, if invalid then various errors are thrown

        '        Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey("The Great Hello World Software Company", "1234567891234567", My.Settings.stgClientName, My.Settings.stgSerial)

        '        'Me.Hide()
        '        'frmMain.Show()
        '        ' Clear sell side of the demo form
        '        'lblSellStatus.Text = ""
        '        'lblSellFeature.Text = ""
        '        'txtSellCustomerName.Text = ""
        '        'txtSellKey.Text = ""
        '    Catch ex As Exception
        '        Me.Opacity = 0
        '        frmLicSplash.Show()


        '        'lblBuyStatus.Text = ex.Message
        '        'lblBuyFeature.Text = ""
        '        'txtBuyKey.Text = ""
        '        'txtBuyCustomerName.Text = ""
        '    End Try
        'End If

    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) Handles SetupToolStripMenuItem.Click

        frmSettings.Show()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        qgFunc.KillAllProcessesByName("plink")

    End Sub

    Private Sub HostsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostsListToolStripMenuItem.Click
        frmHostList.Show()
    End Sub

    Private Sub btnMonitorStart_Click(sender As Object, e As EventArgs) Handles btnMonitorStart.Click

        qgFunc.MonitorStart(My.Settings.stgHostIP1, lblServer1, pctSrv1, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost1)
        qgFunc.MonitorStart(My.Settings.stgHostIP2, lblServer2, pctSrv2, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost2)
        qgFunc.MonitorStart(My.Settings.stgHostIP3, lblServer3, pctSrv3, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost3)

    End Sub

    Private Sub btnPingHost_Click(sender As Object, e As EventArgs) Handles btnPingHost.Click

        If My.Computer.Network.Ping(My.Settings.stgHost, 1000) Then
            txtOutput.AppendText("Server is alive!" + vbNewLine)
        Else
            txtOutput.AppendText("Server is offline or rebooting!" + vbNewLine)
        End If

    End Sub

    Private Sub btnSrv1Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv1Reboot.Click
        qgFunc.RebootServer(My.Settings.stgHostIP1, My.Settings.stgHostRoot1, My.Settings.stgHostPass1, My.Settings.stgHostPort1, comConType, txtOutput)
        'RebootServer(My.Settings.stgHostIP1, My.Settings.stgHostRoot1, My.Settings.stgHostPass1, My.Settings.stgHostPort1, comConType, txtOutput)

    End Sub

    Private Sub btnSrv2Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv2Reboot.Click

        qgFunc.RebootServer(My.Settings.stgHostIP2, My.Settings.stgHostRoot2, My.Settings.stgHostPass2, My.Settings.stgHostPort2, comConType, txtOutput)

    End Sub

    Private Sub btnSrv3Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv3Reboot.Click
        qgFunc.RebootServer(My.Settings.stgHostIP3, My.Settings.stgHostRoot3, My.Settings.stgHostPass3, My.Settings.stgHostPort3, comConType, txtOutput)
    End Sub

    Private Sub btnSrv1Shut_Click(sender As Object, e As EventArgs) Handles btnSrv1Shut.Click

        qgFunc.ShutdownServer(My.Settings.stgHostIP1, My.Settings.stgHostRoot1, My.Settings.stgHostPass1, My.Settings.stgHostPort1, comConType, txtOutput)

    End Sub

    Private Sub btnSrv2Shut_Click(sender As Object, e As EventArgs) Handles btnSrv2Shut.Click

        qgFunc.ShutdownServer(My.Settings.stgHostIP2, My.Settings.stgHostRoot2, My.Settings.stgHostPass2, My.Settings.stgHostPort2, comConType, txtOutput)

    End Sub

    Private Sub btnSrv3Shut_Click(sender As Object, e As EventArgs) Handles btnSrv3Shut.Click

        qgFunc.ShutdownServer(My.Settings.stgHostIP3, My.Settings.stgHostRoot3, My.Settings.stgHostPass3, My.Settings.stgHostPort3, comConType, txtOutput)

    End Sub

    Private Sub btnCheckPorts_Click(sender As Object, e As EventArgs) Handles btnCheckPorts.Click
        qgFunc.checkport(My.Settings.stgHostIP1, My.Settings.stgHostPort1, pctPort1, My.Resources.greenport, My.Resources.redport, txtOutput)
        qgFunc.checkport(My.Settings.stgHostIP2, My.Settings.stgHostPort2, pctPort2, My.Resources.greenport, My.Resources.redport, txtOutput)
        qgFunc.checkport(My.Settings.stgHostIP3, My.Settings.stgHostPort3, pctPort3, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort1_Click(sender As Object, e As EventArgs) Handles pctPort1.Click
        qgFunc.checkport(My.Settings.stgHostIP1, My.Settings.stgHostPort1, pctPort1, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort2_Click(sender As Object, e As EventArgs) Handles pctPort2.Click
        qgFunc.checkport(My.Settings.stgHostIP2, My.Settings.stgHostPort2, pctPort2, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort3_Click(sender As Object, e As EventArgs) Handles pctPort3.Click
        qgFunc.checkport(My.Settings.stgHostIP3, My.Settings.stgHostPort3, pctPort3, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctSrv1_Click(sender As Object, e As EventArgs) Handles pctSrv1.Click
        qgFunc.MonitorStart(My.Settings.stgHostIP1, lblServer1, pctSrv1, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost1)
    End Sub

    Private Sub pctSrv2_Click(sender As Object, e As EventArgs) Handles pctSrv2.Click
        qgFunc.MonitorStart(My.Settings.stgHostIP2, lblServer2, pctSrv2, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost2)
    End Sub

    Private Sub pctSrv3_Click(sender As Object, e As EventArgs) Handles pctSrv3.Click
        qgFunc.MonitorStart(My.Settings.stgHostIP3, lblServer3, pctSrv3, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost3)
    End Sub

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        txtOutput.Clear()
    End Sub

    Private Sub GetLANIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetLANIPToolStripMenuItem.Click
        txtOutput.AppendText("==== IPv4 - IPv6 Addresses START ====" + vbNewLine + qgFunc.getLanIp() + vbNewLine +
                             "==== IPv4 - IPv6 Addresses END ====" + vbNewLine)
    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        frmLicSplash.Show()
    End Sub

    Private Sub lblServer1_Click(sender As Object, e As EventArgs) Handles lblServer1.Click
        txtOutput.AppendText(qgFunc.getMacAddress())
    End Sub
End Class
