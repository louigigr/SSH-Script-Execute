<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ConnectionBar = New System.Windows.Forms.Panel()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.comConType = New System.Windows.Forms.ComboBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuShowConnectionBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowStatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConnectionBar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConnectionBar
        '
        Me.ConnectionBar.Controls.Add(Me.btnConnect)
        Me.ConnectionBar.Controls.Add(Me.comConType)
        Me.ConnectionBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.ConnectionBar.Location = New System.Drawing.Point(0, 24)
        Me.ConnectionBar.Name = "ConnectionBar"
        Me.ConnectionBar.Size = New System.Drawing.Size(309, 52)
        Me.ConnectionBar.TabIndex = 1
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Green
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.FlatAppearance.BorderSize = 0
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConnect.Location = New System.Drawing.Point(182, 14)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(75, 24)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Text = "Execute"
        Me.btnConnect.UseVisualStyleBackColor = False
        '
        'comConType
        '
        Me.comConType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.comConType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.comConType.FormattingEnabled = True
        Me.comConType.Items.AddRange(New Object() {"Connect Using SSH", "Connect Using Telnet", "Conect Using Custom Port"})
        Me.comConType.Location = New System.Drawing.Point(12, 16)
        Me.comConType.Name = "comConType"
        Me.comConType.Size = New System.Drawing.Size(164, 21)
        Me.comConType.TabIndex = 0
        Me.comConType.Text = "Select A Connection Method"
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.White
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOutput.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(0, 76)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(309, 113)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.TabStop = False
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusBar.Location = New System.Drawing.Point(0, 189)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(309, 22)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 3
        Me.StatusBar.Text = "StatusStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(203, 22)
        Me.mnuClose.Text = "Close SSH Script Execute"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuShowConnectionBar, Me.mnuShowStatusBar})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ViewToolStripMenuItem.Text = "Edit"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'mnuShowConnectionBar
        '
        Me.mnuShowConnectionBar.Checked = True
        Me.mnuShowConnectionBar.CheckOnClick = True
        Me.mnuShowConnectionBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuShowConnectionBar.Name = "mnuShowConnectionBar"
        Me.mnuShowConnectionBar.Size = New System.Drawing.Size(188, 22)
        Me.mnuShowConnectionBar.Text = "Show Connection Bar"
        '
        'mnuShowStatusBar
        '
        Me.mnuShowStatusBar.Checked = True
        Me.mnuShowStatusBar.CheckOnClick = True
        Me.mnuShowStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuShowStatusBar.Name = "mnuShowStatusBar"
        Me.mnuShowStatusBar.Size = New System.Drawing.Size(188, 22)
        Me.mnuShowStatusBar.Text = "Show Status Bar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(309, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 211)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.ConnectionBar)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SSH Script Execute"
        Me.ConnectionBar.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConnectionBar As System.Windows.Forms.Panel
    Friend WithEvents comConType As System.Windows.Forms.ComboBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents StatusBar As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShowConnectionBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuShowStatusBar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SetupToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
