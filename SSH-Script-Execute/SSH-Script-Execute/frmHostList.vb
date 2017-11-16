Public Class frmHostList
    Private Sub frmHostList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        txtHostname1.Text = My.Settings.stgHost1
        txtHostname2.Text = My.Settings.stgHost2
        txtHostname3.Text = My.Settings.stgHost3
        txtHostIP1.Text = My.Settings.stgHostIP1
        txtHostIP2.Text = My.Settings.stgHostIP2
        txtHostIP3.Text = My.Settings.stgHostIP3
        txtHostRoot1.Text = My.Settings.stgHostRoot1
        txtHostRoot2.Text = My.Settings.stgHostRoot2
        txtHostRoot3.Text = My.Settings.stgHostRoot3
        txtHostPass1.Text = My.Settings.stgHostPass1
        txtHostPass2.Text = My.Settings.stgHostPass2
        txtHostPass3.Text = My.Settings.stgHostPass3
        txtHostPort1.Text = My.Settings.stgHostPort1
        txtHostPort2.Text = My.Settings.stgHostPort2
        txtHostPort3.Text = My.Settings.stgHostPort3
    End Sub

    Private Sub btnSaveHosts_Click(sender As Object, e As EventArgs) Handles btnSaveHosts.Click
        My.Settings.stgHost1 = txtHostname1.Text
        My.Settings.stgHost2 = txtHostname2.Text
        My.Settings.stgHost3 = txtHostname3.Text
        My.Settings.stgHostIP1 = txtHostIP1.Text
        My.Settings.stgHostIP2 = txtHostIP2.Text
        My.Settings.stgHostIP3 = txtHostIP3.Text
        My.Settings.stgHostRoot1 = txtHostRoot1.Text
        My.Settings.stgHostRoot2 = txtHostRoot2.Text
        My.Settings.stgHostRoot3 = txtHostRoot3.Text
        My.Settings.stgHostPass1 = txtHostPass1.Text
        My.Settings.stgHostPass2 = txtHostPass2.Text
        My.Settings.stgHostPass3 = txtHostPass3.Text
        My.Settings.stgHostPort1 = txtHostPort1.Text
        My.Settings.stgHostPort2 = txtHostPort2.Text
        My.Settings.stgHostPort3 = txtHostPort3.Text

        If My.Settings.stgHost1 IsNot "" Then
            frmMain.lblServer1.Text = My.Settings.stgHost1
        Else
            frmMain.lblServer1.Text = "Name is Empty"
        End If

        If My.Settings.stgHost2 IsNot "" Then
            frmMain.lblServer2.Text = My.Settings.stgHost2
        Else
            frmMain.lblServer2.Text = "Server Name is Empty"
        End If

        If My.Settings.stgHost3 IsNot "" Then
            frmMain.lblServer3.Text = My.Settings.stgHost3
        Else
            frmMain.lblServer3.Text = "Server Name is Empty"
        End If
        'frmMain.lblServer1.Text = My.Settings.stgHost1
        'frmMain.lblServer2.Text = My.Settings.stgHost2
        'frmMain.lblServer3.Text = My.Settings.stgHost3
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class