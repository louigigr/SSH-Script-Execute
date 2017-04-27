Imports System.ComponentModel
Imports System.IO

Public Class frmMain
    'Inherits Forms.MetroForm
    Dim qgFunc As New qgFunctions

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Dim strServ As String = My.Settings.stgHost
        Dim strUser As String = My.Settings.stgUser
        Dim strPass As String = My.Settings.stgPass
        Dim strScript As String = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        qgFunc.KillAllProcessesByName("plink")

        Task.Run(
            Sub()

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
                                    txtOutput.AppendText("<--LOG FINISHED")
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
            End Sub)

    End Sub

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    'Show/Hide Connection Bar
    Private Sub mnuShowConnectionBar_Click(sender As Object, e As EventArgs) Handles mnuShowConnectionBar.Click
        Me.ConnectionBar.Visible = Me.mnuShowConnectionBar.Checked
    End Sub

    'Show/Hide Status Bar
    Private Sub mnuShowStatusBar_Click(sender As Object, e As EventArgs) Handles mnuShowStatusBar.Click
        Me.StatusBar.Visible = Me.mnuShowStatusBar.Checked
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.stgRunCount = 0 Then
            MsgBox("This is your first run, settings will be opened!" + vbNewLine +
                   "Make sure you set the password right or the program will fail")
            frmSettings.Show()
            My.Settings.stgRunCount = My.Settings.stgRunCount + 1
        Else
            My.Settings.stgRunCount = My.Settings.stgRunCount + 1
        End If
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object,
                                             e As EventArgs) Handles SetupToolStripMenuItem.Click

        frmSettings.Show()

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        qgFunc.KillAllProcessesByName("plink")

    End Sub

    Private Sub btnPingHost_Click(sender As Object, e As EventArgs) Handles btnPingHost.Click
        Task.Run(Sub()
                     If My.Computer.Network.Ping(My.Settings.stgHost, 1000) Then
                         txtOutput.AppendText("Server is alive!" + vbNewLine)
                     Else
                         txtOutput.AppendText("Server is offline or rebooting!" + vbNewLine)
                     End If
                 End Sub)

    End Sub
End Class
