Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets

Public Class qgFunctions

    Public Sub KillAllProcessesByName(ByVal processName As String)
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName(processName)
            Try
                p.Kill()
                ' possibly with a timeout
                p.WaitForExit()
                ' process was terminating or can't be terminated - deal with it
            Catch winException As Win32Exception
                ' process has already exited - might be able to let this one go
            Catch invalidException As InvalidOperationException
            End Try
        Next
    End Sub

    Public Function getLanIp() As String
        Dim hostIP As IPHostEntry = Dns.GetHostEntry(Dns.GetHostName())
        Dim position As Integer = 0
        Dim ip As String = Nothing

        While position < hostIP.AddressList.Length
            ip += hostIP.AddressList(position).ToString & vbCrLf
            position += 1
        End While
        Return ip
    End Function

    Public Sub RebootServer(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
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
        KillAllProcessesByName("plink")

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

    Public Sub ShutdownServer(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
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
        KillAllProcessesByName("plink")

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

    Public Sub checkport(ByVal host As String, ByVal port As String, ByVal imageport As Object, ByVal trueimage As Object,
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

    Public Sub MonitorStart(ByVal host As String, ByVal lblControl As Object, ByVal ImageControl As Object,
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

    Public Sub RunPlink(ByVal strServ As String, ByVal strUser As String, ByVal strPass As String,
                         strScript As String, ByVal ProcessToRun As String, ByVal exeToCall As String,
                         ByVal hostPort As String, ByVal listboxControl As Object, ByVal outputlog As Object)
        ' SAMPLE strscript = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        'Dim strScript As String = My.Settings.stgScriptLocation + My.Settings.stgScriptName
        KillAllProcessesByName(ProcessToRun)

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
                        'check change
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

    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = System.Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = System.Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Function getMacAddress()
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function


    Public Function RandomString(ByVal length As Integer) As String

        Dim sb As New System.Text.StringBuilder
        Dim chars() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z",
               "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "X",
               "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=", "$", "#"}

        Dim upperBound As Integer = UBound(chars)

        For x As Integer = 1 To length
            sb.Append(chars(Int(Rnd() * upperBound)))
        Next

        Return getMacAddress() + sb.ToString + Now.ToLongTimeString

    End Function

End Class
