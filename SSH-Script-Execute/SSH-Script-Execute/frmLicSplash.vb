Imports System.Security.Cryptography
Imports System.Text
Imports OMBKey

Public Class frmLicSplash
    Dim s As New qgFunctions
    Public _MyCompanyKey As Byte() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24}
    Public _MyCompanyIV As Byte() = {1, 2, 3, 4, 5, 6, 7, 8}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            ' Create the key consuming/buying object
            Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)
            ' Validate the key, if its valid then the feature set it unlocks will be returned, if invalid then various errors are thrown
            Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey(txtBuyCompanyName.Text, txtBuySerial.Text,
                                                                                               txtBuyCustomerName.Text, txtBuyKey.Text)
            ' At this point your deployed software should place the feature set code in the registry, your program then checks the registry for this enumerator to determine how/if it should run (dont place the key string itself in the registry as that should only live in the customers hands)
            '    registrykey = locFeatureBeingBought
            ' Thank the customer again and tell them what feature or product their key just unlocked
            lblBuyStatus.Text = "Thank you for purchasing our software, your specific copy of the software is now unlocked"
            lblBuyFeature.Text = "You unlocked this feature or product: " & locFeatureBeingBought.ToString
            Label1.Text = locFeatureBeingBought
            My.Settings.stgClientName = txtBuyCustomerName.Text
            My.Settings.stgSerial = txtBuyKey.Text
            My.Computer.Registry.CurrentUser.CreateSubKey("QGSSHRUN")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "Regkey", s.AES_Encrypt(My.Settings.stgSerial, "2133"))
            Me.Hide()
            frmMain.Opacity = 100
            ' Clear sell side of the demo form
            'lblSellStatus.Text = ""
            'lblSellFeature.Text = ""
            'txtSellCustomerName.Text = ""
            'txtSellKey.Text = ""
        Catch ex As Exception
            lblBuyStatus.Text = ex.Message
            lblBuyFeature.Text = ""
            'txtBuyKey.Text = ""
            'txtBuyCustomerName.Text = ""
        End Try



    End Sub

    'Private Function Encrypt(ByVal Data As String, ByVal Key() As Byte, ByVal IV() As Byte) As Byte()
    '    Dim mStream As New System.IO.MemoryStream
    '    Dim cStream As New CryptoStream(mStream, New TripleDESCryptoServiceProvider().CreateEncryptor(Key, IV), CryptoStreamMode.Write)
    '    Dim toEncrypt As Byte() = New ASCIIEncoding().GetBytes(Data)
    '    cStream.Write(toEncrypt, 0, toEncrypt.Length)
    '    cStream.FlushFinalBlock()
    '    Dim ret As Byte() = mStream.ToArray()
    '    cStream.Close()
    '    mStream.Close()
    '    Return ret
    'End Function



    Private Sub frmLicSplash_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim q As New qgFunctions
        txtBuyCustomerName.Text = My.Settings.stgClientName
        txtBuyCompanyName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "Company", Nothing)
        'My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "ProductSerial", Nothing)
        txtBuySerial.Text = q.AES_Decrypt(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "ProductSerial", Nothing), "2133550")
        txtBuyKey.Text = My.Settings.stgSerial
        'frmMain.Visible = False
        'frmMain.Hide()
        'If My.Settings.stgClientName = "" Or My.Settings.stgSerial = "" Then
        '    MsgBox("Software needs registration")
        'Else
        '    Try
        '        ' Create the key consuming/buying object
        '        Dim locKeyHandler As OMBKeyBuy.KeyBuyer = New OMBKeyBuy.KeyBuyer(_MyCompanyKey, _MyCompanyIV)
        '        ' Validate the key, if its valid then the feature set it unlocks will be returned, if invalid then various errors are thrown
        '        Dim locFeatureBeingBought As Key.ProductOrProductFeatureSet = locKeyHandler.BuyKey("The Great Hello World Software Company", "1234567891234567", My.Settings.stgClientName, My.Settings.stgSerial)
        '        ' At this point your deployed software should place the feature set code in the registry, your program then checks the registry for this enumerator to determine how/if it should run (dont place the key string itself in the registry as that should only live in the customers hands)
        '        '    registrykey = locFeatureBeingBought
        '        ' Thank the customer again and tell them what feature or product their key just unlocked
        '        'lblBuyStatus.Text = "Thank you for purchasing our software, your specific copy of the software is now unlocked"
        '        'lblBuyFeature.Text = "You unlocked this feature or product: " & locFeatureBeingBought.ToString
        '        'Label1.Text = locFeatureBeingBought
        '        Me.Hide()
        '        frmMain.Show()
        '        ' Clear sell side of the demo form
        '        'lblSellStatus.Text = ""
        '        'lblSellFeature.Text = ""
        '        'txtSellCustomerName.Text = ""
        '        'txtSellKey.Text = ""
        '    Catch ex As Exception
        '        'lblBuyStatus.Text = ex.Message
        '        'lblBuyFeature.Text = ""
        '        'txtBuyKey.Text = ""
        '        'txtBuyCustomerName.Text = ""
        '    End Try
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f1 As New qgFunctions
        MsgBox(f1.RandomString(160))
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f As New qgFunctions
        MsgBox(f.AES_Encrypt("HELLO", "2133"))
        MsgBox(f.AES_Decrypt(f.AES_Encrypt("HELLO", "2133"), "2133"))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f As New qgFunctions
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\QGSSHRUN", "Regkey", Nothing) Is Nothing Then
            MsgBox("CREATING VALUE")
            My.Computer.Registry.CurrentUser.CreateSubKey("QGSSHRUN")
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\QGSSHRUN", "Regkey", f.AES_Encrypt(My.Settings.stgSerial, "2133"))

        Else
            MsgBox("Value CREATED")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            My.Computer.Registry.CurrentUser.DeleteSubKey("QGSSHRUN")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtBuySerial_TextChanged(sender As Object, e As EventArgs) Handles txtBuySerial.TextChanged

    End Sub
End Class