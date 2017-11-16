Imports System.ComponentModel
Imports System.IO
Imports System.Net.Sockets

Public Class frmMain
    'Inherits Forms.MetroForm
    Dim qgFunc As New qgFunctions

    Private Sub RunPlink(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
                         strScript As String, ByVal ProcessToRun As String, ByVal exeToCall As String,
                         ByVal hostPort As String, ByVal listboxControl As Object, ByVal outputlog As Object)
        ' SAMPLE strscript = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        'Dim strScript As String = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        qgFunc.KillAllProcessesByName(ProcessToRun)

        If My.Computer.FileSystem.FileExists(strScript) Then
            'this
            Dim text1 As String = File.ReadAllText(strScript)
            Dim index As Integer = text1.IndexOf("reboot")

            If index >= 0 Then

                '#########################################
                '# REBOOT  EXISTS                        #
                '#########################################


                Dim strConn As String
                Select Case listboxControl.SelectedIndex
                    Case 0
                        strConn = "-ssh"
                    Case 1
                        strConn = "-telnet"
                    Case 2
                        strConn = "-P " & hostPort
                    Case Else
                        MsgBox("Using Custom Port with no Protocol", MsgBoxStyle.OkOnly, "OK!")
                        strConn = "-P " & hostPort
                End Select

                Try

                    'Create Process

                    Dim conProcess As New Process
                    Dim conInfo As New System.Diagnostics.ProcessStartInfo()

                    conInfo.FileName = exeToCall
                    conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " -m " & strScript
                    conInfo.RedirectStandardInput = True
                    conInfo.RedirectStandardOutput = True
                    conInfo.UseShellExecute = False
                    conInfo.CreateNoWindow = True
                    conInfo.WindowStyle = ProcessWindowStyle.Hidden

                    conProcess.StartInfo = conInfo
                    outputlog.AppendText("Reboot Command Detected!" + vbNewLine +
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
                Select Case listboxControl.SelectedIndex
                    Case 0
                        strConn = "-ssh"
                    Case 1
                        strConn = "-telnet"
                    Case 2
                        strConn = "-P " & hostPort
                    Case Else
                        MsgBox("Using Custom Port with no Protocol", MsgBoxStyle.OkOnly, "OK!")
                        strConn = "-P " & hostPort
                End Select

                Try

                    'Create Process

                    Dim conProcess As New Process
                    Dim conInfo As New System.Diagnostics.ProcessStartInfo()

                    conInfo.FileName = exeToCall
                    conInfo.Arguments = strConn & " " & strServ & " -l " & strUser & " -pw " & strPass & " -m " & strScript
                    conInfo.RedirectStandardInput = True
                    conInfo.RedirectStandardOutput = True
                    conInfo.UseShellExecute = False
                    conInfo.CreateNoWindow = True
                    conInfo.WindowStyle = ProcessWindowStyle.Hidden

                    conProcess.StartInfo = conInfo
                    outputlog.AppendText("Command Sent!" + vbNewLine)
                    conProcess.Start()

                    ''Read Response
                    Try
                        Dim Reader As System.IO.StreamReader = conProcess.StandardOutput
                        Try
                            outputlog.AppendText(Reader.ReadToEnd() + vbNewLine)
                            outputlog.AppendText("<--LOG FINISHED" + vbNewLine)
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

    Private Sub MonitorStart(ByVal host As String, ByVal lblControl As Object, ByVal ImageControl As Object,
                             ByVal ImageResourceUp As Bitmap, ByVal ImageResourceDown As Bitmap,
                             ByVal ImageResourceShut As Bitmap, ByVal LogOutput As Object,
                             Optional ByVal verboseName As String = "Hostname")
        If verboseName = "" Then
            LogOutput.AppendText("Hostname not specified, using default" + vbNewLine)
            verboseName = "Hostname not specified"
        End If
        Try
            If host IsNot "" Then
                If My.Computer.Network.Ping(host, 1000) Then
                    lblControl.ForeColor = Color.Green
                    ImageControl.Image = ImageResourceUp
                    LogOutput.AppendText(host + " is responding" + vbNewLine)
                Else
                    lblControl.ForeColor = Color.Red
                    ImageControl.Image = ImageResourceDown
                    LogOutput.AppendText(host + " is not responding" + vbNewLine)
                End If
            Else
                LogOutput.AppendText("Specify IP for " + verboseName + vbNewLine)
                'MsgBox("Specify IP for Host1: " + My.Settings.stgHost1)
                lblControl.ForeColor = Color.Orange
                ImageControl.Image = ImageResourceShut
            End If

        Catch ex As Exception
            LogOutput.AppendText("Error trying to ping host -> " + verboseName + " on IP -> " + host + vbNewLine + "Error Message: " + ex.Message + vbNewLine)
            lblControl.ForeColor = Color.Orange
            ImageControl.Image = ImageResourceShut
        End Try
    End Sub

    Private Sub btnPingHost_Click(sender As Object, e As EventArgs) Handles btnPingHost.Click

        If My.Computer.Network.Ping(My.Settings.stgHost, 1000) Then
            txtOutput.AppendText("Server is alive!" + vbNewLine)
        Else
            txtOutput.AppendText("Server is offline or rebooting!" + vbNewLine)
        End If

    End Sub

    Private Sub RebootServer(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
                               ByVal customPort As String, ByVal comConType As Object, ByVal logoutput As Object)

        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & customPort
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & customPort
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
            logoutput.AppendText("Reboot Command Sent!" + vbNewLine + "Use monitor controls to confirm action" + vbNewLine +
                                 "======================================" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            logoutput.AppendText("Error: " + ex.Message)

        End Try

    End Sub

    Private Sub ShutdownServer(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
                               ByVal customPort As String, ByVal comConType As Object, ByVal logoutput As Object)

        Dim strConn As String
        Select Case comConType.SelectedIndex
            Case 0
                strConn = "-ssh"
            Case 1
                strConn = "-telnet"
            Case 2
                strConn = "-P " & customPort
            Case Else
                MsgBox("Using Custom Port", MsgBoxStyle.OkOnly, "OK!")
                strConn = "-P " & customPort
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
            logoutput.AppendText("Shutdown Command Sent!" + vbNewLine + "Use monitor controls to confirm action" + vbNewLine +
                                 "======================================" + vbNewLine)
            conProcess.Start()
            conProcess.Close()

        Catch ex As Exception

            logoutput.AppendText("Error: " + ex.Message)

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

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        RunPlink(My.Settings.stgHost, My.Settings.stgUser, My.Settings.stgPass,
                 My.Settings.stgScriptLocation + My.Settings.stgScriptName,
                 "plink", "plink.exe", My.Settings.stgPort, comConType, txtOutput)

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

    Private Sub HostsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HostsListToolStripMenuItem.Click
        frmHostList.Show()
    End Sub

    Private Sub btnMonitorStart_Click(sender As Object, e As EventArgs) Handles btnMonitorStart.Click

        MonitorStart(My.Settings.stgHostIP1, lblServer1, pctSrv1, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost1)
        MonitorStart(My.Settings.stgHostIP2, lblServer2, pctSrv2, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost2)
        MonitorStart(My.Settings.stgHostIP3, lblServer3, pctSrv3, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost3)

    End Sub

    Private Sub btnSrv1Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv1Reboot.Click

        RebootServer(My.Settings.stgHostIP1, My.Settings.stgHostRoot1, My.Settings.stgHostPass1, My.Settings.stgHostPort1, comConType, txtOutput)

    End Sub

    Private Sub btnSrv2Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv2Reboot.Click

        RebootServer(My.Settings.stgHostIP2, My.Settings.stgHostRoot2, My.Settings.stgHostPass2, My.Settings.stgHostPort2, comConType, txtOutput)

    End Sub

    Private Sub btnSrv3Reboot_Click(sender As Object, e As EventArgs) Handles btnSrv3Reboot.Click
        RebootServer(My.Settings.stgHostIP3, My.Settings.stgHostRoot3, My.Settings.stgHostPass3, My.Settings.stgHostPort3, comConType, txtOutput)
    End Sub

    Private Sub btnSrv1Shut_Click(sender As Object, e As EventArgs) Handles btnSrv1Shut.Click

        ShutdownServer(My.Settings.stgHostIP1, My.Settings.stgHostRoot1, My.Settings.stgHostPass1, My.Settings.stgHostPort1, comConType, txtOutput)

    End Sub

    Private Sub btnSrv2Shut_Click(sender As Object, e As EventArgs) Handles btnSrv2Shut.Click

        ShutdownServer(My.Settings.stgHostIP2, My.Settings.stgHostRoot2, My.Settings.stgHostPass2, My.Settings.stgHostPort2, comConType, txtOutput)

    End Sub

    Private Sub btnSrv3Shut_Click(sender As Object, e As EventArgs) Handles btnSrv3Shut.Click

        ShutdownServer(My.Settings.stgHostIP3, My.Settings.stgHostRoot3, My.Settings.stgHostPass3, My.Settings.stgHostPort3, comConType, txtOutput)

    End Sub

    Private Sub btnCheckPorts_Click(sender As Object, e As EventArgs) Handles btnCheckPorts.Click
        checkport(My.Settings.stgHostIP1, My.Settings.stgHostPort1, pctPort1, My.Resources.greenport, My.Resources.redport, txtOutput)
        checkport(My.Settings.stgHostIP2, My.Settings.stgHostPort2, pctPort2, My.Resources.greenport, My.Resources.redport, txtOutput)
        checkport(My.Settings.stgHostIP3, My.Settings.stgHostPort3, pctPort3, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort1_Click(sender As Object, e As EventArgs) Handles pctPort1.Click
        checkport(My.Settings.stgHostIP1, My.Settings.stgHostPort1, pctPort1, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort2_Click(sender As Object, e As EventArgs) Handles pctPort2.Click
        checkport(My.Settings.stgHostIP2, My.Settings.stgHostPort2, pctPort2, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctPort3_Click(sender As Object, e As EventArgs) Handles pctPort3.Click
        checkport(My.Settings.stgHostIP3, My.Settings.stgHostPort3, pctPort3, My.Resources.greenport, My.Resources.redport, txtOutput)
    End Sub

    Private Sub pctSrv1_Click(sender As Object, e As EventArgs) Handles pctSrv1.Click
        MonitorStart(My.Settings.stgHostIP1, lblServer1, pctSrv1, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost1)
    End Sub

    Private Sub pctSrv2_Click(sender As Object, e As EventArgs) Handles pctSrv2.Click
        MonitorStart(My.Settings.stgHostIP2, lblServer2, pctSrv2, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost2)
    End Sub

    Private Sub pctSrv3_Click(sender As Object, e As EventArgs) Handles pctSrv3.Click
        MonitorStart(My.Settings.stgHostIP3, lblServer3, pctSrv3, My.Resources.green, My.Resources.red, My.Resources.orange, txtOutput, My.Settings.stgHost3)
    End Sub
End Class
