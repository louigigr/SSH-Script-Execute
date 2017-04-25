<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblHost = New System.Windows.Forms.Label()
        Me.lblScriptLocation = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblScriptName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.txtScriptLocation = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtScriptName = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnEditScript = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblPortNumber = New System.Windows.Forms.Label()
        Me.txtPortNumber = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectScript = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHost
        '
        Me.lblHost.Location = New System.Drawing.Point(7, 12)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(85, 20)
        Me.lblHost.TabIndex = 0
        Me.lblHost.Text = "Host"
        Me.lblHost.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScriptLocation
        '
        Me.lblScriptLocation.Location = New System.Drawing.Point(7, 64)
        Me.lblScriptLocation.Name = "lblScriptLocation"
        Me.lblScriptLocation.Size = New System.Drawing.Size(85, 20)
        Me.lblScriptLocation.TabIndex = 4
        Me.lblScriptLocation.Text = "Script Location"
        Me.lblScriptLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUsername
        '
        Me.lblUsername.Location = New System.Drawing.Point(7, 38)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(85, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblScriptName
        '
        Me.lblScriptName.Location = New System.Drawing.Point(7, 90)
        Me.lblScriptName.Name = "lblScriptName"
        Me.lblScriptName.Size = New System.Drawing.Size(85, 20)
        Me.lblScriptName.TabIndex = 6
        Me.lblScriptName.Text = "Script Name"
        Me.lblScriptName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(275, 39)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(55, 20)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(98, 12)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(172, 20)
        Me.txtHost.TabIndex = 1
        '
        'txtScriptLocation
        '
        Me.txtScriptLocation.Location = New System.Drawing.Point(98, 64)
        Me.txtScriptLocation.Name = "txtScriptLocation"
        Me.txtScriptLocation.Size = New System.Drawing.Size(359, 20)
        Me.txtScriptLocation.TabIndex = 5
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(98, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(172, 20)
        Me.txtUsername.TabIndex = 3
        '
        'txtScriptName
        '
        Me.txtScriptName.Location = New System.Drawing.Point(98, 90)
        Me.txtScriptName.Name = "txtScriptName"
        Me.txtScriptName.Size = New System.Drawing.Size(359, 20)
        Me.txtScriptName.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(336, 39)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(121, 20)
        Me.txtPassword.TabIndex = 4
        '
        'btnEditScript
        '
        Me.btnEditScript.BackColor = System.Drawing.Color.Green
        Me.btnEditScript.FlatAppearance.BorderSize = 0
        Me.btnEditScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditScript.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditScript.Location = New System.Drawing.Point(463, 90)
        Me.btnEditScript.Name = "btnEditScript"
        Me.btnEditScript.Size = New System.Drawing.Size(63, 20)
        Me.btnEditScript.TabIndex = 7
        Me.btnEditScript.Text = "Edit Script"
        Me.btnEditScript.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(98, 116)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(172, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save and Close"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(285, 116)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(172, 23)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblPortNumber
        '
        Me.lblPortNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.lblPortNumber.Location = New System.Drawing.Point(276, 13)
        Me.lblPortNumber.Name = "lblPortNumber"
        Me.lblPortNumber.Size = New System.Drawing.Size(54, 20)
        Me.lblPortNumber.TabIndex = 2
        Me.lblPortNumber.Text = "Port:"
        Me.lblPortNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPortNumber
        '
        Me.txtPortNumber.Location = New System.Drawing.Point(336, 14)
        Me.txtPortNumber.Name = "txtPortNumber"
        Me.txtPortNumber.Size = New System.Drawing.Size(121, 20)
        Me.txtPortNumber.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectScript
        '
        Me.btnSelectScript.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSelectScript.FlatAppearance.BorderSize = 0
        Me.btnSelectScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectScript.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.btnSelectScript.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSelectScript.Location = New System.Drawing.Point(463, 64)
        Me.btnSelectScript.Name = "btnSelectScript"
        Me.btnSelectScript.Size = New System.Drawing.Size(63, 20)
        Me.btnSelectScript.TabIndex = 5
        Me.btnSelectScript.Text = "..."
        Me.btnSelectScript.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 151)
        Me.Controls.Add(Me.btnSelectScript)
        Me.Controls.Add(Me.txtPortNumber)
        Me.Controls.Add(Me.lblPortNumber)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnEditScript)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtScriptName)
        Me.Controls.Add(Me.txtScriptLocation)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblScriptName)
        Me.Controls.Add(Me.lblScriptLocation)
        Me.Controls.Add(Me.lblHost)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(551, 190)
        Me.MinimumSize = New System.Drawing.Size(551, 190)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHost As Label
    Friend WithEvents lblScriptLocation As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblScriptName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtHost As TextBox
    Friend WithEvents txtScriptLocation As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtScriptName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnEditScript As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblPortNumber As Label
    Friend WithEvents txtPortNumber As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSelectScript As Button
End Class
