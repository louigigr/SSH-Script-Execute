Imports System.ComponentModel
Imports System.IO
Imports System.Net.Sockets

Public Class frmMain
    'Inherits Forms.MetroForm
    Dim qgFunc As New qgFunctions


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Dim strServ As String = My.Settings.stgHost
        Dim strUser As String = My.Settings.stgUser
        Dim strPass As String = My.Settings.stgPass
        Dim strScript As String = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        qgFunc.KillAllProcessesByName("plink")

        If My.Computer.FileSystem.FileExists(strScript) Then
            'this
            Dim text1 As String = File.ReadAllText(My.Settings.stgScriptLocation +
                                                   My.Settings.stgScriptName)
            Dim index As Integer = text1.IndexOf("reboot")

            If index >= 0 Then

                '#########################################
                '# REBOOT  EXISTS                        #
                '#########################################


                Dim strConn As String
                Select Case comConType.SelectedIndex
                    Case 0
                        strConn = "-ssh"
                    Case 1
                        strConn = "-telnet"
                    Case 2
                        strConn = "-P " & My.Settings.stgPort
                    Case Else
                        MsgBox("Using Custom Port with no Protocol", MsgBoxStyle.OkOnly, "OK!")
                        strConn = "-P " & My.Settings.stgPort
                End Select

                Try

                    'Create Process

                    Dim conProcess As New Process
                    Dim conInfo As New System.Diagnostics.ProcessStartInfo()

                    conInfo.FileName = "plink.exe"
                    conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " -m " & strScript
                    conInfo.RedirectStandardInput = True
                    conInfo.RedirectStandardOutput = True
                    conInfo.UseShellExecute = False
                    conInfo.CreateNoWindow = True
                    conInfo.WindowStyle = ProcessWindowStyle.Hidden

                    conProcess.StartInfo = conInfo
                    txtOutput.AppendText("Reboot Command Detected!" + vbNewLine +
                                              "No Output Will be displayed!")
                    conProcess.Start()

                    conProcess.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString)

                End Try

            Else

                '###################
                'no reboot included
                '###################

                Dim strConn As String
                Select Case comConType.SelectedIndex
                    Case 0
                        strConn = "-ssh"
                    Case 1
                        strConn = "-telnet"
                    Case 2
                        strConn = "-P " & My.Settings.stgPort
                    Case Else
                        MsgBox("Using Custom Port with no Protocol", MsgBoxStyle.OkOnly, "OK!")
                        strConn = "-P " & My.Settings.stgPort
                End Select

                Try

                    'Create Process

                    Dim conProcess As New Process
                    Dim conInfo As New System.Diagnostics.ProcessStartInfo()

                    conInfo.FileName = "plink.exe"
                    conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " -m " & strScript
                    conInfo.RedirectStandardInput = True
                    conInfo.RedirectStandardOutput = True
                    conInfo.UseShellExecute = False
                    conInfo.CreateNoWindow = True
                    conInfo.WindowStyle = ProcessWindowStyle.Hidden

                    conProcess.StartInfo = conInfo
                    txtOutput.AppendText("Command Sent!" + vbNewLine)
                    conProcess.Start()

                    ''Read Response
                    Try
                        Dim Reader As System.IO.StreamReader = conProcess.StandardOutput
                        Try
                            txtOutput.AppendText(Reader.ReadToEnd() + vbNewLine)
                            txtOutput.AppendText("<--LOG FINISHED" + vbNewLine)
                            Reader.Close()
                        Catch ex As Exception
                            conProcess.Close()
                            MsgBox(ex.Message)
                        End Try
                    Catch ex As Exception
                        conProcess.Close()
                        MsgBox(ex.Message)
                    End Try

                    'Disconnect
                    conProcess.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString)
                End Try

            End If
        Else
            'that
            MsgBox("SCRIPT DOES NOT EXIST" + vbNewLine +
                   "Please edit the script from the settings panel!")
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
            MsgBox("This is your first run, settings will be opened!" + vbNewLine +
                   "Make sure you set the password right or the program will fail")
            frmSettings.Show()
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

    End Sub



    Private Sub SetupToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) Handles SetupToolStripMenuItem.Click

        frmSettings.Show()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        qgFunc.KillAllProcessesByName("plink")

    End Sub

    Private Sub btnPingHost_Click(sender As Object, e As EventArgs) Handles btnPingHost.Click

        If My.Computer.Network.Ping(My.Settings.stgHost, 1000) Then
            txtOutput.AppendText("Server is alive!" + vbNewLine)
        Else
            txtOutput.AppendText("Server is offline or rebooting!" + vbNewLine)
        End If


    End Sub

    Private Sub HostsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostsListToolStripMenuItem.Click
        frmHostList.Show()
    End Sub

    Dim i = 11


    Private Sub btnMonitorStart_Click(sender As Object, e As EventArgs) Handles btnMonitorStart.Click
        Try
            If My.Settings.stgHostIP1 IsNot "" Then
                If My.Computer.Network.Ping(My.Settings.stgHostIP1, 1000) Then
                    lblServer1.ForeColor = Color.Green
                    pctSrv1.Image = My.Resources.green
                    txtOutput.AppendText(My.Settings.stgHostIP1 + " is responding" + vbNewLine)
                Else
                    lblServer1.ForeColor = Color.Red
                    pctSrv1.Image = My.Resources.red
                    txtOutput.AppendText(My.Settings.stgHostIP1 + " is not responding" + vbNewLine)
                End If
            Else
                txtOutput.AppendText("Specify IP for Host1: " + My.Settings.stgHost1 + vbNewLine)
                'MsgBox("Specify IP for Host1: " + My.Settings.stgHost1)
                lblServer1.ForeColor = Color.Orange
                pctSrv1.Image = My.Resources.orange
            End If

        Catch ex As Exception
            txtOutput.AppendText("Error trying to ping Server 1 -> " + My.Settings.stgHost1 + vbNewLine + "Error Message: " + ex.Message + vbNewLine)
            lblServer1.ForeColor = Color.Orange
            pctSrv1.Image = My.Resources.orange
        End Try

        Try
            If My.Settings.stgHostIP2 IsNot "" Then
                If My.Computer.Network.Ping(My.Settings.stgHostIP2, 1000) Then
                    lblServer2.ForeColor = Color.Green
                    pctSrv2.Image = My.Resources.green
                    txtOutput.AppendText(My.Settings.stgHostIP2 + " is responding" + vbNewLine)
                Else
                    lblServer2.ForeColor = Color.Red
                    pctSrv2.Image = My.Resources.red
                    txtOutput.AppendText(My.Settings.stgHostIP2 + " is not responding" + vbNewLine)
                End If
            Else
                txtOutput.AppendText("Specify IP for Host2: " + My.Settings.stgHost2 + vbNewLine)
                lblServer2.ForeColor = Color.Orange
                pctSrv2.Image = My.Resources.orange
            End If
        Catch ex As Exception
            txtOutput.AppendText("Error trying to ping Server 2 -> " + My.Settings.stgHost1 + vbNewLine + "Error Message: " + ex.Message + vbNewLine)
            lblServer2.ForeColor = Color.Orange
            pctSrv2.Image = My.Resources.orange
        End Try

        Try
            If My.Settings.stgHostIP3 IsNot "" Then
                If My.Computer.Network.Ping(My.Settings.stgHostIP3, 1000) Then
                    lblServer3.ForeColor = Color.Green
                    pctSrv3.Image = My.Resources.green
                    txtOutput.AppendText(My.Settings.stgHostIP3 + " is responding" + vbNewLine)
                Else
                    lblServer3.ForeColor = Color.Red
                    pctSrv3.Image = My.Resources.red
                    txtOutput.AppendText(My.Settings.stgHostIP3 + " is not responding" + vbNewLine)
                End If
            Else
                txtOutput.AppendText("Specify IP for Host3: " + My.Settings.stgHost3 + vbNewLine)
                lblServer3.ForeColor = Color.Orange
                pctSrv3.Image = My.Resources.orange
            End If
        Catch ex As Exception
            txtOutput.AppendText("Error trying to ping Server 3 -> " + My.Settings.stgHost1 + vbNewLine + "Error Message: " + ex.Message + vbNewLine)
            lblServer3.ForeColor = Color.Orange
            pctSrv3.Image = My.Resources.orange
        End Try



    End Sub

    Private Sub btnSrv1Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv1Reboot.Click
        'plink -ssh -l username -pw password linuxbox.mycompany.com shutdown -h now
        Dim strServ As String = My.Settings.stgHostIP1
        Dim strUser As String = My.Settings.stgHostRoot1
        Dim strPass As String = My.Settings.stgHostPass1
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort1
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort1
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " reboot"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Reboot Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnSrv2Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv2Reboot.Click
        Dim strServ As String = My.Settings.stgHostIP2
        Dim strUser As String = My.Settings.stgHostRoot2
        Dim strPass As String = My.Settings.stgHostPass2
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort2
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort2
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " reboot"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Reboot Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSrv3Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv3Reboot.Click
        Dim strServ As String = My.Settings.stgHostIP3
        Dim strUser As String = My.Settings.stgHostRoot3
        Dim strPass As String = My.Settings.stgHostPass3
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort3
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort3
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " reboot"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Reboot Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSrv1Shut_Click(sender As Object, e As EventArgs) Handles btnSrv1Shut.Click
        Dim strServ As String = My.Settings.stgHostIP1
        Dim strUser As String = My.Settings.stgHostRoot1
        Dim strPass As String = My.Settings.stgHostPass1
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort1
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort1
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " shutdown now"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Shutdown Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSrv2Shut_Click(sender As Object, e As EventArgs) Handles btnSrv2Shut.Click
        Dim strServ As String = My.Settings.stgHostIP2
        Dim strUser As String = My.Settings.stgHostRoot2
        Dim strPass As String = My.Settings.stgHostPass2
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort2
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort2
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " shutdown now"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Shutdown Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnSrv3Shut_Click(sender As Object, e As EventArgs) Handles btnSrv3Shut.Click
        Dim strServ As String = My.Settings.stgHostIP3
        Dim strUser As String = My.Settings.stgHostRoot3
        Dim strPass As String = My.Settings.stgHostPass3
        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & My.Settings.stgHostPort3
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & My.Settings.stgHostPort3
        End Select
        qgFunc.KillAllProcessesByName("plink")

        Try

            Dim conProcess As New Process
            Dim conInfo As New System.Diagnostics.ProcessStartInfo()

            conInfo.FileName = "plink.exe"
            conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " shutdown now"
            conInfo.RedirectStandardInput = True
            conInfo.RedirectStandardOutput = True
            conInfo.UseShellExecute = False
            conInfo.CreateNoWindow = True
            conInfo.WindowStyle = ProcessWindowStyle.Hidden

            conProcess.StartInfo = conInfo
            txtOutput.AppendText("Shutdown Command Detected!" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub checkport(ByVal host As String, ByVal port As String, ByVal imageport As Object, ByVal trueimage As Object,
                         ByVal falseimage As Object, ByVal logoutput As Object)
        Using tcp As New TcpClient()
            Dim ar As IAsyncResult = tcp.BeginConnect(host, port, Nothing, Nothing)
            Dim wh As System.Threading.WaitHandle = ar.AsyncWaitHandle
            Try
                If Not ar.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(1), False) Then
                    tcp.Close()
                    imageport.Image = falseimage
                    logoutput.AppendText("Host " + host + " is not listening on port " + port + vbNewLine)
                    'Throw New TimeoutException()
                Else
                    Try
                        tcp.EndConnect(ar)
                        imageport.Image = trueimage
                        logoutput.AppendText("Host " + host + " is responding on port " + port + vbNewLine)
                    Catch ex As Exception
                        logoutput.AppendText("Error on host " + host + ". " + ex.Message + vbNewLine)
                    End Try

                End If

            Finally
                wh.Close()
            End Try
        End Using

    End Sub

    Private Sub btnCheckPorts_Click(sender As Object, e As EventArgs) Handles btnCheckPorts.Click
        checkport(My.Settings.stgHostIP1, My.Settings.stgHostPort1, pctPort1, My.Resources.greenport, My.Resources.redport, txtOutput)
        checkport(My.Settings.stgHostIP2, My.Settings.stgHostPort2, pctPort2, My.Resources.greenport, My.Resources.redport, txtOutput)
        checkport(My.Settings.stgHostIP3, My.Settings.stgHostPort3, pctPort3, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub
End Class
