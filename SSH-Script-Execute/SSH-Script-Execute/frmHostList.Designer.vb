<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHostList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHostList))
        Me.lblManagedHost1 = New System.Windows.Forms.Label()
        Me.lblManagedHost2 = New System.Windows.Forms.Label()
        Me.lblManagedHost3 = New System.Windows.Forms.Label()
        Me.txtHostname1 = New System.Windows.Forms.TextBox()
        Me.txtHostname2 = New System.Windows.Forms.TextBox()
        Me.txtHostname3 = New System.Windows.Forms.TextBox()
        Me.lblHostnameC = New System.Windows.Forms.Label()
        Me.lblHostIPC = New System.Windows.Forms.Label()
        Me.txtHostIP3 = New System.Windows.Forms.TextBox()
        Me.txtHostIP2 = New System.Windows.Forms.TextBox()
        Me.txtHostIP1 = New System.Windows.Forms.TextBox()
        Me.btnSaveHosts = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtHostRoot3 = New System.Windows.Forms.TextBox()
        Me.txtHostRoot2 = New System.Windows.Forms.TextBox()
        Me.txtHostRoot1 = New System.Windows.Forms.TextBox()
        Me.lblHostRoot = New System.Windows.Forms.Label()
        Me.txtHostPass3 = New System.Windows.Forms.TextBox()
        Me.txtHostPass2 = New System.Windows.Forms.TextBox()
        Me.txtHostPass1 = New System.Windows.Forms.TextBox()
        Me.lblHostPass = New System.Windows.Forms.Label()
        Me.txtHostPort3 = New System.Windows.Forms.TextBox()
        Me.txtHostPort2 = New System.Windows.Forms.TextBox()
        Me.txtHostPort1 = New System.Windows.Forms.TextBox()
        Me.lblCustomPort = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblManagedHost1
        '
        Me.lblManagedHost1.AutoSize = True
        Me.lblManagedHost1.Location = New System.Drawing.Point(7, 28)
        Me.lblManagedHost1.Name = "lblManagedHost1"
        Me.lblManagedHost1.Size = New System.Drawing.Size(92, 13)
        Me.lblManagedHost1.TabIndex = 0
        Me.lblManagedHost1.Text = "Managed Host - 1"
        '
        'lblManagedHost2
        '
        Me.lblManagedHost2.AutoSize = True
        Me.lblManagedHost2.Location = New System.Drawing.Point(6, 54)
        Me.lblManagedHost2.Name = "lblManagedHost2"
        Me.lblManagedHost2.Size = New System.Drawing.Size(92, 13)
        Me.lblManagedHost2.TabIndex = 1
        Me.lblManagedHost2.Text = "Managed Host - 2"
        '
        'lblManagedHost3
        '
        Me.lblManagedHost3.AutoSize = True
        Me.lblManagedHost3.Location = New System.Drawing.Point(7, 80)
        Me.lblManagedHost3.Name = "lblManagedHost3"
        Me.lblManagedHost3.Size = New System.Drawing.Size(92, 13)
        Me.lblManagedHost3.TabIndex = 2
        Me.lblManagedHost3.Text = "Managed Host - 3"
        '
        'txtHostname1
        '
        Me.txtHostname1.Location = New System.Drawing.Point(105, 25)
        Me.txtHostname1.Name = "txtHostname1"
        Me.txtHostname1.Size = New System.Drawing.Size(186, 20)
        Me.txtHostname1.TabIndex = 3
        '
        'txtHostname2
        '
        Me.txtHostname2.Location = New System.Drawing.Point(105, 51)
        Me.txtHostname2.Name = "txtHostname2"
        Me.txtHostname2.Size = New System.Drawing.Size(186, 20)
        Me.txtHostname2.TabIndex = 4
        '
        'txtHostname3
        '
        Me.txtHostname3.Location = New System.Drawing.Point(104, 77)
        Me.txtHostname3.Name = "txtHostname3"
        Me.txtHostname3.Size = New System.Drawing.Size(187, 20)
        Me.txtHostname3.TabIndex = 5
        '
        'lblHostnameC
        '
        Me.lblHostnameC.AutoSize = True
        Me.lblHostnameC.Location = New System.Drawing.Point(102, 9)
        Me.lblHostnameC.Name = "lblHostnameC"
        Me.lblHostnameC.Size = New System.Drawing.Size(55, 13)
        Me.lblHostnameC.TabIndex = 6
        Me.lblHostnameC.Text = "Hostname"
        '
        'lblHostIPC
        '
        Me.lblHostIPC.AutoSize = True
        Me.lblHostIPC.Location = New System.Drawing.Point(294, 9)
        Me.lblHostIPC.Name = "lblHostIPC"
        Me.lblHostIPC.Size = New System.Drawing.Size(83, 13)
        Me.lblHostIPC.TabIndex = 7
        Me.lblHostIPC.Text = "Host IP Address"
        '
        'txtHostIP3
        '
        Me.txtHostIP3.Location = New System.Drawing.Point(296, 77)
        Me.txtHostIP3.Name = "txtHostIP3"
        Me.txtHostIP3.Size = New System.Drawing.Size(187, 20)
        Me.txtHostIP3.TabIndex = 10
        '
        'txtHostIP2
        '
        Me.txtHostIP2.Location = New System.Drawing.Point(297, 51)
        Me.txtHostIP2.Name = "txtHostIP2"
        Me.txtHostIP2.Size = New System.Drawing.Size(186, 20)
        Me.txtHostIP2.TabIndex = 9
        '
        'txtHostIP1
        '
        Me.txtHostIP1.Location = New System.Drawing.Point(297, 25)
        Me.txtHostIP1.Name = "txtHostIP1"
        Me.txtHostIP1.Size = New System.Drawing.Size(186, 20)
        Me.txtHostIP1.TabIndex = 8
        '
        'btnSaveHosts
        '
        Me.btnSaveHosts.BackColor = System.Drawing.Color.Green
        Me.btnSaveHosts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveHosts.FlatAppearance.BorderSize = 0
        Me.btnSaveHosts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveHosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSaveHosts.Location = New System.Drawing.Point(296, 103)
        Me.btnSaveHosts.Name = "btnSaveHosts"
        Me.btnSaveHosts.Size = New System.Drawing.Size(187, 24)
        Me.btnSaveHosts.TabIndex = 11
        Me.btnSaveHosts.Text = "Save"
        Me.btnSaveHosts.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(491, 103)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(186, 24)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'txtHostRoot3
        '
        Me.txtHostRoot3.Location = New System.Drawing.Point(491, 77)
        Me.txtHostRoot3.Name = "txtHostRoot3"
        Me.txtHostRoot3.Size = New System.Drawing.Size(187, 20)
        Me.txtHostRoot3.TabIndex = 16
        '
        'txtHostRoot2
        '
        Me.txtHostRoot2.Location = New System.Drawing.Point(492, 51)
        Me.txtHostRoot2.Name = "txtHostRoot2"
        Me.txtHostRoot2.Size = New System.Drawing.Size(186, 20)
        Me.txtHostRoot2.TabIndex = 15
        '
        'txtHostRoot1
        '
        Me.txtHostRoot1.Location = New System.Drawing.Point(492, 25)
        Me.txtHostRoot1.Name = "txtHostRoot1"
        Me.txtHostRoot1.Size = New System.Drawing.Size(186, 20)
        Me.txtHostRoot1.TabIndex = 14
        '
        'lblHostRoot
        '
        Me.lblHostRoot.AutoSize = True
        Me.lblHostRoot.Location = New System.Drawing.Point(489, 9)
        Me.lblHostRoot.Name = "lblHostRoot"
        Me.lblHostRoot.Size = New System.Drawing.Size(55, 13)
        Me.lblHostRoot.TabIndex = 13
        Me.lblHostRoot.Text = "Host Root"
        '
        'txtHostPass3
        '
        Me.txtHostPass3.Location = New System.Drawing.Point(683, 77)
        Me.txtHostPass3.Name = "txtHostPass3"
        Me.txtHostPass3.Size = New System.Drawing.Size(187, 20)
        Me.txtHostPass3.TabIndex = 20
        '
        'txtHostPass2
        '
        Me.txtHostPass2.Location = New System.Drawing.Point(684, 51)
        Me.txtHostPass2.Name = "txtHostPass2"
        Me.txtHostPass2.Size = New System.Drawing.Size(186, 20)
        Me.txtHostPass2.TabIndex = 19
        '
        'txtHostPass1
        '
        Me.txtHostPass1.Location = New System.Drawing.Point(684, 25)
        Me.txtHostPass1.Name = "txtHostPass1"
        Me.txtHostPass1.Size = New System.Drawing.Size(186, 20)
        Me.txtHostPass1.TabIndex = 18
        '
        'lblHostPass
        '
        Me.lblHostPass.AutoSize = True
        Me.lblHostPass.Location = New System.Drawing.Point(681, 9)
        Me.lblHostPass.Name = "lblHostPass"
        Me.lblHostPass.Size = New System.Drawing.Size(78, 13)
        Me.lblHostPass.TabIndex = 17
        Me.lblHostPass.Text = "Host Password"
        '
        'txtHostPort3
        '
        Me.txtHostPort3.Location = New System.Drawing.Point(875, 77)
        Me.txtHostPort3.Name = "txtHostPort3"
        Me.txtHostPort3.Size = New System.Drawing.Size(62, 20)
        Me.txtHostPort3.TabIndex = 24
        '
        'txtHostPort2
        '
        Me.txtHostPort2.Location = New System.Drawing.Point(876, 51)
        Me.txtHostPort2.Name = "txtHostPort2"
        Me.txtHostPort2.Size = New System.Drawing.Size(61, 20)
        Me.txtHostPort2.TabIndex = 23
        '
        'txtHostPort1
        '
        Me.txtHostPort1.Location = New System.Drawing.Point(876, 25)
        Me.txtHostPort1.Name = "txtHostPort1"
        Me.txtHostPort1.Size = New System.Drawing.Size(61, 20)
        Me.txtHostPort1.TabIndex = 22
        '
        'lblCustomPort
        '
        Me.lblCustomPort.AutoSize = True
        Me.lblCustomPort.Location = New System.Drawing.Point(873, 9)
        Me.lblCustomPort.Name = "lblCustomPort"
        Me.lblCustomPort.Size = New System.Drawing.Size(64, 13)
        Me.lblCustomPort.TabIndex = 21
        Me.lblCustomPort.Text = "Custom Port"
        '
        'frmHostList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 142)
        Me.Controls.Add(Me.txtHostPort3)
        Me.Controls.Add(Me.txtHostPort2)
        Me.Controls.Add(Me.txtHostPort1)
        Me.Controls.Add(Me.lblCustomPort)
        Me.Controls.Add(Me.txtHostPass3)
        Me.Controls.Add(Me.txtHostPass2)
        Me.Controls.Add(Me.txtHostPass1)
        Me.Controls.Add(Me.lblHostPass)
        Me.Controls.Add(Me.txtHostRoot3)
        Me.Controls.Add(Me.txtHostRoot2)
        Me.Controls.Add(Me.txtHostRoot1)
        Me.Controls.Add(Me.lblHostRoot)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSaveHosts)
        Me.Controls.Add(Me.txtHostIP3)
        Me.Controls.Add(Me.txtHostIP2)
        Me.Controls.Add(Me.txtHostIP1)
        Me.Controls.Add(Me.lblHostIPC)
        Me.Controls.Add(Me.lblHostnameC)
        Me.Controls.Add(Me.txtHostname3)
        Me.Controls.Add(Me.txtHostname2)
        Me.Controls.Add(Me.txtHostname1)
        Me.Controls.Add(Me.lblManagedHost3)
        Me.Controls.Add(Me.lblManagedHost2)
        Me.Controls.Add(Me.lblManagedHost1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(961, 181)
        Me.MinimumSize = New System.Drawing.Size(961, 181)
        Me.Name = "frmHostList"
        Me.Text = "Managed Server List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblManagedHost1 As Label
    Friend WithEvents lblManagedHost2 As Label
    Friend WithEvents lblManagedHost3 As Label
    Friend WithEvents txtHostname1 As TextBox
    Friend WithEvents txtHostname2 As TextBox
    Friend WithEvents txtHostname3 As TextBox
    Friend WithEvents lblHostnameC As Label
    Friend WithEvents lblHostIPC As Label
    Friend WithEvents txtHostIP3 As TextBox
    Friend WithEvents txtHostIP2 As TextBox
    Friend WithEvents txtHostIP1 As TextBox
    Friend WithEvents btnSaveHosts As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtHostRoot3 As TextBox
    Friend WithEvents txtHostRoot2 As TextBox
    Friend WithEvents txtHostRoot1 As TextBox
    Friend WithEvents lblHostRoot As Label
    Friend WithEvents txtHostPass3 As TextBox
    Friend WithEvents txtHostPass2 As TextBox
    Friend WithEvents txtHostPass1 As TextBox
    Friend WithEvents lblHostPass As Label
    Friend WithEvents txtHostPort3 As TextBox
    Friend WithEvents txtHostPort2 As TextBox
    Friend WithEvents txtHostPort1 As TextBox
    Friend WithEvents lblCustomPort As Label
End Class
