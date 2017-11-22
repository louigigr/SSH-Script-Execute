<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLicSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLicSplash))
        Me.txtBuyCustomerName = New System.Windows.Forms.TextBox()
        Me.txtBuySerial = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBuyStatus = New System.Windows.Forms.Label()
        Me.lblBuyFeature = New System.Windows.Forms.Label()
        Me.txtBuyCompanyName = New System.Windows.Forms.TextBox()
        Me.txtBuyKey = New System.Windows.Forms.TextBox()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.lblCompanyName = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.lblUnlockKey = New System.Windows.Forms.Label()
        Me.btnClearRegistration = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBuyCustomerName
        '
        Me.txtBuyCustomerName.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtBuyCustomerName.Location = New System.Drawing.Point(91, 85)
        Me.txtBuyCustomerName.Name = "txtBuyCustomerName"
        Me.txtBuyCustomerName.Size = New System.Drawing.Size(731, 20)
        Me.txtBuyCustomerName.TabIndex = 2
        '
        'txtBuySerial
        '
        Me.txtBuySerial.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtBuySerial.Location = New System.Drawing.Point(91, 6)
        Me.txtBuySerial.Multiline = True
        Me.txtBuySerial.Name = "txtBuySerial"
        Me.txtBuySerial.ReadOnly = True
        Me.txtBuySerial.Size = New System.Drawing.Size(731, 47)
        Me.txtBuySerial.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(91, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Tag = "120"
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblBuyStatus
        '
        Me.lblBuyStatus.AutoSize = True
        Me.lblBuyStatus.Location = New System.Drawing.Point(88, 147)
        Me.lblBuyStatus.Name = "lblBuyStatus"
        Me.lblBuyStatus.Size = New System.Drawing.Size(194, 13)
        Me.lblBuyStatus.TabIndex = 8
        Me.lblBuyStatus.Text = "Please enter key to unlock the software"
        '
        'lblBuyFeature
        '
        Me.lblBuyFeature.AutoSize = True
        Me.lblBuyFeature.Location = New System.Drawing.Point(88, 170)
        Me.lblBuyFeature.Name = "lblBuyFeature"
        Me.lblBuyFeature.Size = New System.Drawing.Size(209, 13)
        Me.lblBuyFeature.TabIndex = 7
        Me.lblBuyFeature.Text = "Click the serial number to copy to clipboard"
        '
        'txtBuyCompanyName
        '
        Me.txtBuyCompanyName.Location = New System.Drawing.Point(91, 59)
        Me.txtBuyCompanyName.Name = "txtBuyCompanyName"
        Me.txtBuyCompanyName.Size = New System.Drawing.Size(731, 20)
        Me.txtBuyCompanyName.TabIndex = 1
        '
        'txtBuyKey
        '
        Me.txtBuyKey.AcceptsReturn = True
        Me.txtBuyKey.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.txtBuyKey.Location = New System.Drawing.Point(91, 111)
        Me.txtBuyKey.Name = "txtBuyKey"
        Me.txtBuyKey.Size = New System.Drawing.Size(731, 20)
        Me.txtBuyKey.TabIndex = 3
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblSerialNumber.TabIndex = 12
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'lblCompanyName
        '
        Me.lblCompanyName.AutoSize = True
        Me.lblCompanyName.Location = New System.Drawing.Point(3, 62)
        Me.lblCompanyName.Name = "lblCompanyName"
        Me.lblCompanyName.Size = New System.Drawing.Size(82, 13)
        Me.lblCompanyName.TabIndex = 11
        Me.lblCompanyName.Text = "Company Name"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(3, 88)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 13)
        Me.lblCustomerName.TabIndex = 10
        Me.lblCustomerName.Text = "Customer Name"
        '
        'lblUnlockKey
        '
        Me.lblUnlockKey.AutoSize = True
        Me.lblUnlockKey.Location = New System.Drawing.Point(23, 114)
        Me.lblUnlockKey.Name = "lblUnlockKey"
        Me.lblUnlockKey.Size = New System.Drawing.Size(62, 13)
        Me.lblUnlockKey.TabIndex = 9
        Me.lblUnlockKey.Text = "Unlock Key"
        '
        'btnClearRegistration
        '
        Me.btnClearRegistration.BackColor = System.Drawing.Color.OrangeRed
        Me.btnClearRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearRegistration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClearRegistration.Location = New System.Drawing.Point(348, 192)
        Me.btnClearRegistration.Name = "btnClearRegistration"
        Me.btnClearRegistration.Size = New System.Drawing.Size(212, 23)
        Me.btnClearRegistration.TabIndex = 5
        Me.btnClearRegistration.Text = "Clear Registration"
        Me.btnClearRegistration.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Green
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Location = New System.Drawing.Point(605, 192)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(217, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmLicSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 227)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClearRegistration)
        Me.Controls.Add(Me.lblUnlockKey)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCompanyName)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.txtBuyKey)
        Me.Controls.Add(Me.txtBuyCompanyName)
        Me.Controls.Add(Me.lblBuyFeature)
        Me.Controls.Add(Me.lblBuyStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuySerial)
        Me.Controls.Add(Me.txtBuyCustomerName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(845, 266)
        Me.MinimumSize = New System.Drawing.Size(845, 266)
        Me.Name = "frmLicSplash"
        Me.Text = "Register Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBuyCustomerName As TextBox
    Friend WithEvents txtBuySerial As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblBuyStatus As Label
    Friend WithEvents lblBuyFeature As Label
    Friend WithEvents txtBuyCompanyName As TextBox
    Friend WithEvents txtBuyKey As TextBox
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents lblCompanyName As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblUnlockKey As Label
    Friend WithEvents btnClearRegistration As Button
    Friend WithEvents btnClose As Button
End Class
