Imports System.Security.Cryptography
Imports System.Text
Imports OMBKey

Public Class frmLicSplash
    Dim s As New qgFunctions
    Public _MyCompanyKey As Byte() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Public _MyCompanyIV As Byte() = {49, 126, 93, 154, 74, 213, 45, 80}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try

            Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)
            Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey(txtBuyCompanyName.Text, txtBuySerial.Text,
                                                                                               txtBuyCustomerName.Text, txtBuyKey.Text)
            lblBuyStatus.Text = "Thank you for purchasing our software, your specific copy of the software is now unlocked"
            lblBuyFeature.Text = "You unlocked this feature or product: " & locFeatureBeingBought.ToString

            My.Computer.Registry.CurrentUser.CreateSubKey("Software\qgrun")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "Company", txtBuyCompanyName.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "Regkey", s.AES_Encrypt(txtBuyKey.Text, "th3seEirialnuNber"))
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "CustomerName", txtBuyCustomerName.Text)
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "FeatureSet", locFeatureBeingBought)

            Me.Hide()

            frmMain.Panel1.Enabled = True
            frmMain.HostsListToolStripMenuItem.Enabled = True
            frmMain.btnPingHost.Enabled = True


        Catch ex As Exception

            lblBuyStatus.Text = ex.Message
            lblBuyFeature.Text = ""

        End Try
        Application.Restart()
    End Sub

    Private Sub frmLicSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim q As New qgFunctions
        txtBuyCustomerName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "CustomerName", Nothing)
        txtBuyCompanyName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "Company", Nothing)
        txtBuySerial.Text = q.AES_Decrypt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "ProductSerial", Nothing), "th3seEirialnuNber")

        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "RegKey", Nothing) = "" Then
            txtBuyKey.Text = "Please type your unlock key"
        Else
            Try
                txtBuyKey.Text = q.AES_Decrypt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "RegKey", Nothing), "th3seEirialnuNber")
            Catch ex As Exception
                txtBuyKey.Text = "SERIAL IS INVALID!!!"
            End Try
        End If

    End Sub


    Private Sub txtBuyKey_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuyKey.MouseClick
        txtBuyKey.SelectAll()
    End Sub

    Private Sub txtBuyCustomerName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuyCustomerName.MouseClick
        txtBuyCompanyName.SelectAll()
    End Sub


    Private Sub txtBuySerial_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuySerial.MouseClick
        txtBuySerial.SelectAll()

        Try
            Clipboard.SetText(txtBuySerial.Text)
            lblBuyFeature.Text = "Copied Serial to Clipboard"
        Catch ex As Exception
            lblBuyFeature.Text = "Cannot copy Serial to Clipboard"
        End Try

    End Sub

    Private Sub btnClearRegistration_Click(sender As Object, e As EventArgs) Handles btnClearRegistration.Click

        Dim qgFunc As New qgFunctions
        Clipboard.SetText(txtBuyKey.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "RegKey", "")
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\qgrun", "FeatureSet", "Single Host")
        txtBuyKey.Clear()
        frmMain.Panel1.Enabled = False
        frmMain.HostsListToolStripMenuItem.Enabled = False
        frmMain.btnPingHost.Enabled = False
        frmMain.ToolStripStatusLabel1.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "FeatureSet", Nothing)

    End Sub

    Private Sub txtBuyCompanyName_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBuyCompanyName.MouseClick
        txtBuyCompanyName.SelectAll()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim q As New qgFunctions
        Dim keyvalue = q.AES_Decrypt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun", "RegKey", Nothing), "th3seEirialnuNber")
        Try

            Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)
            Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun",
                                                                                                                             "Company",
                                                                                                                             Nothing),
                                                                                               q.AES_Decrypt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun",
                                                                                                                                           "ProductSerial",
                                                                                                                                           Nothing), "th3seEirialnuNber"),
                                                                                               My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\qgrun",
                                                                                                                             "CustomerName", Nothing), keyvalue)

            Me.Close()
        Catch ex As Exception
            Dim result As Integer = MessageBox.Show("License is invalid." + vbNewLine + "Try again?", "License Error", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                frmMain.Panel1.Enabled = False
                frmMain.HostsListToolStripMenuItem.Enabled = False
                frmMain.btnPingHost.Enabled = False
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub lblSerialNumber_Click(sender As Object, e As EventArgs) Handles lblSerialNumber.Click
        Dim random As New Random()
        Dim i As Integer
        For i = 0 To 5
            MsgBox(Convert.ToString(Random.Next(10, 20)))
        Next
    End Sub
End Class