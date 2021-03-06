﻿Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        txtHost.Text = My.Settings.stgHost
        txtScriptLocation.Text = My.Settings.stgScriptLocation
        txtScriptName.Text = My.Settings.stgScriptName
        txtUsername.Text = My.Settings.stgUser
        txtPassword.Text = My.Settings.stgPass
        txtPortNumber.Text = My.Settings.stgPort
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditScript.Click
        Process.Start("notepad.exe", txtScriptLocation.Text + txtScriptName.Text)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.stgHost = txtHost.Text
        My.Settings.stgScriptLocation = txtScriptLocation.Text
        My.Settings.stgScriptName = txtScriptName.Text
        My.Settings.stgUser = txtUsername.Text
        My.Settings.stgPass = txtPassword.Text
        My.Settings.stgPort = txtPortNumber.Text
        Dim d As Boolean = My.Computer.Network.Ping(My.Settings.stgHost, 1000)
        If d = True Then
            frmHostList.RunCommandCom("echo", "y | plink.exe -ssh " + My.Settings.stgHost + " -l " + My.Settings.stgUser +
                                  " -pw " + My.Settings.stgPass + " exit", False)
        Else
            frmMain.txtOutput.AppendText("The host " + My.Settings.stgHost + " appears offline" + vbNewLine)
        End If
        If System.IO.File.Exists(My.Settings.stgScriptLocation + My.Settings.stgScriptName) Then
            frmMain.txtOutput.AppendText("Script selected:" + vbNewLine +
                                     My.Settings.stgScriptLocation + My.Settings.stgScriptName + vbNewLine +
                                     "==== S C R I P T   C O N T E N T S ====" + vbNewLine +
                                     System.IO.File.ReadAllText(My.Settings.stgScriptLocation + My.Settings.stgScriptName) +
                                     vbNewLine + "==== S C R I P T   C O N T E N T S ====" + vbNewLine)
        Else
            frmMain.txtOutput.AppendText("Script file cannot be found!" + vbNewLine)
        End If


        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSelectScript_Click(sender As Object, e As EventArgs) Handles btnSelectScript.Click

        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = My.Settings.stgScriptLocation
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.Filter = "Unix Script(*.sh)|*.sh|All Files|*.*"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            txtScriptName.Text = OpenFileDialog1.SafeFileName
            txtScriptLocation.Text = System.IO.Path.GetDirectoryName(OpenFileDialog1.FileName) + "\"

        End If

    End Sub
End Class