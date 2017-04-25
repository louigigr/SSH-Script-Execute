Imports Renci.SshNet

Public Class frmMain


    Private Sub btnExec_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Create the objects needed to make the connection'
        Dim connInfo As New Renci.SshNet.PasswordConnectionInfo("192.168.2.7", "root", "!A2133-550!a")
        Dim sshClient As New Renci.SshNet.SshClient(connInfo)

        'Need to hold the command'
        Dim cmd As Renci.SshNet.SshCommand


        Using sshClient
            'connect to the server'

            sshClient.Connect()
            cmd = sshClient.RunCommand("reboot")
            sshClient.Dispose()

        End Using
    End Sub
End Class
