<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLicSplash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtBuyCustomerName = New System.Windows.Forms.TextBox()
        Me.txtBuySerial = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblBuyStatus = New System.Windows.Forms.Label()
        Me.lblBuyFeature = New System.Windows.Forms.Label()
        Me.txtBuyCompanyName = New System.Windows.Forms.TextBox()
        Me.txtBuyKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBuyCustomerName
        '
        Me.txtBuyCustomerName.Location = New System.Drawing.Point(477, 82)
        Me.txtBuyCustomerName.Name = "txtBuyCustomerName"
        Me.txtBuyCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtBuyCustomerName.TabIndex = 0
        '
        'txtBuySerial
        '
        Me.txtBuySerial.Location = New System.Drawing.Point(238, 12)
        Me.txtBuySerial.Multiline = True
        Me.txtBuySerial.Name = "txtBuySerial"
        Me.txtBuySerial.Size = New System.Drawing.Size(198, 64)
        Me.txtBuySerial.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Tag = "120"
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblBuyStatus
        '
        Me.lblBuyStatus.AutoSize = True
        Me.lblBuyStatus.Location = New System.Drawing.Point(138, 122)
        Me.lblBuyStatus.Name = "lblBuyStatus"
        Me.lblBuyStatus.Size = New System.Drawing.Size(39, 13)
        Me.lblBuyStatus.TabIndex = 3
        Me.lblBuyStatus.Text = "Label1"
        '
        'lblBuyFeature
        '
        Me.lblBuyFeature.AutoSize = True
        Me.lblBuyFeature.Location = New System.Drawing.Point(138, 148)
        Me.lblBuyFeature.Name = "lblBuyFeature"
        Me.lblBuyFeature.Size = New System.Drawing.Size(39, 13)
        Me.lblBuyFeature.TabIndex = 4
        Me.lblBuyFeature.Text = "Label1"
        '
        'txtBuyCompanyName
        '
        Me.txtBuyCompanyName.Location = New System.Drawing.Point(238, 122)
        Me.txtBuyCompanyName.Name = "txtBuyCompanyName"
        Me.txtBuyCompanyName.Size = New System.Drawing.Size(213, 20)
        Me.txtBuyCompanyName.TabIndex = 5
        Me.txtBuyCompanyName.Text = "The Great Hello World Software Company"
        '
        'txtBuyKey
        '
        Me.txtBuyKey.Location = New System.Drawing.Point(477, 122)
        Me.txtBuyKey.Name = "txtBuyKey"
        Me.txtBuyKey.Size = New System.Drawing.Size(317, 20)
        Me.txtBuyKey.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(480, 190)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(294, 238)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(449, 256)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(531, 256)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frmLicSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 293)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuyKey)
        Me.Controls.Add(Me.txtBuyCompanyName)
        Me.Controls.Add(Me.lblBuyFeature)
        Me.Controls.Add(Me.lblBuyStatus)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuySerial)
        Me.Controls.Add(Me.txtBuyCustomerName)
        Me.Name = "frmLicSplash"
        Me.Text = "frmLicSplash"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
