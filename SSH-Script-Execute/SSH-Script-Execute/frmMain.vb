Imports System.IO

Public Class frmMain
    'Inherits Forms.MetroForm


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        Dim strServ As String = My.Settings.stgHost
        Dim strUser As String = My.Settings.stgUser
        Dim strPass As String = My.Settings.stgPass
        Dim strScript As String = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        If My.Computer.FileSystem.FileExists(strScript) Then
            'this
            Dim text1 As String = File.ReadAllText(My.Settings.stgScriptLocation + My.Settings.stgScriptName)
            Dim index As Integer = text1.IndexOf("reboot")
            If index >= 0 Then
                ' String is in file, starting at character "index"
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

                'Prompt For Connection Details
                'Dim strServ As String = InputBox("Enter A Server Name", "Server Login")
                'Dim strUser As String = InputBox("Enter Your Username", "Server Login")
                'Dim strPass As String = InputBox("Enter Your Password", "Server Login")

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

                    ''Execute Commands

                    'Dim Writer As System.IO.StreamWriter = conProcess.StandardInput
                    'Try
                    '    Writer.WriteLine(My.Settings.stgCommand)
                    '    'Writer.WriteLine("sudo /usr/sbin/userdbset -d -u test05 login_time")
                    '    'Writer.WriteLine("sudo /usr/sbin/usermod -p GWwrzWGMPgX3I test05")
                    '    'Writer.WriteLine("sudo /usr/bin/passwd -f test05")
                    '    'Writer.WriteLine("exit")
                    '    Writer.Close()
                    '    conProcess.Close()
                    'Catch ex As Exception
                    '    conProcess.Close()
                    '    MsgBox(ex.Message)
                    'End Try

                    'Disconnect
                    conProcess.Close()

                Catch ex As Exception

                    MsgBox(ex.ToString)
                End Try

            Else

                'no reboot included

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
                            txtOutput.AppendText(Reader.ReadToEnd())
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
            MsgBox("SCRIPT DOES NOT EXIST" + vbNewLine + "Please edit the script from the settings panel!")
        End If




        'Telnet or SSH ?

    End Sub

    'Close CommandPost

    'Close CommandPost
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

    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        frmSettings.Show()
    End Sub
End Class
