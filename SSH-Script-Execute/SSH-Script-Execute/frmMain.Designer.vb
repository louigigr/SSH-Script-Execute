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
        Me.lblCustomScript = New System.Windows.Forms.Label()
        Me.btnPingHost = New System.Windows.Forms.Button()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.comConType = New System.Windows.Forms.ComboBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HostsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuShowConnectionBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShowStatusBar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pctPort3 = New System.Windows.Forms.PictureBox()
        Me.pctPort2 = New System.Windows.Forms.PictureBox()
        Me.pctPort1 = New System.Windows.Forms.PictureBox()
        Me.pctSrv3 = New System.Windows.Forms.PictureBox()
        Me.pctSrv2 = New System.Windows.Forms.PictureBox()
        Me.pctSrv1 = New System.Windows.Forms.PictureBox()
        Me.lblCustomServerMonitor = New System.Windows.Forms.Label()
        Me.btnMonitorStart = New System.Windows.Forms.Button()
        Me.btnSrv3Shut = New System.Windows.Forms.Button()
        Me.btnSrv2Shut = New System.Windows.Forms.Button()
        Me.btnSrv3Reboot = New System.Windows.Forms.Button()
        Me.btnSrv2Reboot = New System.Windows.Forms.Button()
        Me.lblServer3 = New System.Windows.Forms.Label()
        Me.lblServer2 = New System.Windows.Forms.Label()
        Me.btnSrv1Shut = New System.Windows.Forms.Button()
        Me.btnSrv1Reboot = New System.Windows.Forms.Button()
        Me.lblServer1 = New System.Windows.Forms.Label()
        Me.btnCheckPorts = New System.Windows.Forms.Button()
        Me.lblPortStatus = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ConnectionBar.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pctPort3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPort2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctPort1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSrv3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSrv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctSrv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConnectionBar
        '
        Me.ConnectionBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConnectionBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConnectionBar.Controls.Add(Me.lblCustomScript)
        Me.ConnectionBar.Controls.Add(Me.btnPingHost)
        Me.ConnectionBar.Controls.Add(Me.btnConnect)
        Me.ConnectionBar.Controls.Add(Me.comConType)
        Me.ConnectionBar.Location = New System.Drawing.Point(7, 27)
        Me.ConnectionBar.Name = "ConnectionBar"
        Me.ConnectionBar.Size = New System.Drawing.Size(436, 79)
        Me.ConnectionBar.TabIndex = 1
        '
        'lblCustomScript
        '
        Me.lblCustomScript.AutoSize = True
        Me.lblCustomScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCustomScript.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomScript.ForeColor = System.Drawing.Color.Green
        Me.lblCustomScript.Location = New System.Drawing.Point(147, 4)
        Me.lblCustomScript.Name = "lblCustomScript"
        Me.lblCustomScript.Size = New System.Drawing.Size(148, 17)
        Me.lblCustomScript.TabIndex = 11
        Me.lblCustomScript.Text = "Run Script Operations"
        '
        'btnPingHost
        '
        Me.btnPingHost.BackColor = System.Drawing.Color.OrangeRed
        Me.btnPingHost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPingHost.FlatAppearance.BorderSize = 0
        Me.btnPingHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPingHost.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPingHost.Location = New System.Drawing.Point(313, 41)
        Me.btnPingHost.Name = "btnPingHost"
        Me.btnPingHost.Size = New System.Drawing.Size(118, 24)
        Me.btnPingHost.TabIndex = 2
        Me.btnPingHost.Text = "Ping Host"
        Me.btnPingHost.UseVisualStyleBackColor = False
        '
        'btnConnect
        '
        Me.btnConnect.BackColor = System.Drawing.Color.Green
        Me.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnect.FlatAppearance.BorderSize = 0
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConnect.Location = New System.Drawing.Point(194, 41)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(113, 24)
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
        Me.comConType.Location = New System.Drawing.Point(12, 41)
        Me.comConType.Name = "comConType"
        Me.comConType.Size = New System.Drawing.Size(176, 21)
        Me.comConType.TabIndex = 0
        Me.comConType.Text = "Select A Connection Method"
        '
        'txtOutput
        '
        Me.txtOutput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutput.BackColor = System.Drawing.Color.White
        Me.txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOutput.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(7, 309)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(436, 174)
        Me.txtOutput.TabIndex = 2
        Me.txtOutput.TabStop = False
        '
        'StatusBar
        '
        Me.StatusBar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusBar.Location = New System.Drawing.Point(0, 486)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(455, 22)
        Me.StatusBar.SizingGrip = False
        Me.StatusBar.TabIndex = 3
        Me.StatusBar.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(182, 17)
        Me.ToolStripStatusLabel1.Text = "Software by Quadrant Global LTD"
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
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.HostsListToolStripMenuItem, Me.ToolStripSeparator1, Me.mnuShowConnectionBar, Me.mnuShowStatusBar})
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
        'HostsListToolStripMenuItem
        '
        Me.HostsListToolStripMenuItem.Name = "HostsListToolStripMenuItem"
        Me.HostsListToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.HostsListToolStripMenuItem.Text = "Host List"
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
        Me.mnuShowConnectionBar.Enabled = False
        Me.mnuShowConnectionBar.Name = "mnuShowConnectionBar"
        Me.mnuShowConnectionBar.Size = New System.Drawing.Size(188, 22)
        Me.mnuShowConnectionBar.Text = "Show Connection Bar"
        Me.mnuShowConnectionBar.Visible = False
        '
        'mnuShowStatusBar
        '
        Me.mnuShowStatusBar.Checked = True
        Me.mnuShowStatusBar.CheckOnClick = True
        Me.mnuShowStatusBar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuShowStatusBar.Name = "mnuShowStatusBar"
        Me.mnuShowStatusBar.Size = New System.Drawing.Size(188, 22)
        Me.mnuShowStatusBar.Text = "Show Info Bar"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(455, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblPortStatus)
        Me.Panel1.Controls.Add(Me.btnCheckPorts)
        Me.Panel1.Controls.Add(Me.pctPort3)
        Me.Panel1.Controls.Add(Me.pctPort2)
        Me.Panel1.Controls.Add(Me.pctPort1)
        Me.Panel1.Controls.Add(Me.pctSrv3)
        Me.Panel1.Controls.Add(Me.pctSrv2)
        Me.Panel1.Controls.Add(Me.pctSrv1)
        Me.Panel1.Controls.Add(Me.lblCustomServerMonitor)
        Me.Panel1.Controls.Add(Me.btnMonitorStart)
        Me.Panel1.Controls.Add(Me.btnSrv3Shut)
        Me.Panel1.Controls.Add(Me.btnSrv2Shut)
        Me.Panel1.Controls.Add(Me.btnSrv3Reboot)
        Me.Panel1.Controls.Add(Me.btnSrv2Reboot)
        Me.Panel1.Controls.Add(Me.lblServer3)
        Me.Panel1.Controls.Add(Me.lblServer2)
        Me.Panel1.Controls.Add(Me.btnSrv1Shut)
        Me.Panel1.Controls.Add(Me.btnSrv1Reboot)
        Me.Panel1.Controls.Add(Me.lblServer1)
        Me.Panel1.Location = New System.Drawing.Point(7, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 191)
        Me.Panel1.TabIndex = 4
        '
        'pctPort3
        '
        Me.pctPort3.Image = Global.SSHScriptExecute.My.Resources.Resources.redport
        Me.pctPort3.Location = New System.Drawing.Point(165, 157)
        Me.pctPort3.Name = "pctPort3"
        Me.pctPort3.Size = New System.Drawing.Size(23, 18)
        Me.pctPort3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPort3.TabIndex = 16
        Me.pctPort3.TabStop = False
        '
        'pctPort2
        '
        Me.pctPort2.Image = Global.SSHScriptExecute.My.Resources.Resources.redport
        Me.pctPort2.Location = New System.Drawing.Point(165, 128)
        Me.pctPort2.Name = "pctPort2"
        Me.pctPort2.Size = New System.Drawing.Size(23, 18)
        Me.pctPort2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPort2.TabIndex = 15
        Me.pctPort2.TabStop = False
        '
        'pctPort1
        '
        Me.pctPort1.Image = Global.SSHScriptExecute.My.Resources.Resources.redport
        Me.pctPort1.Location = New System.Drawing.Point(165, 98)
        Me.pctPort1.Name = "pctPort1"
        Me.pctPort1.Size = New System.Drawing.Size(23, 18)
        Me.pctPort1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctPort1.TabIndex = 14
        Me.pctPort1.TabStop = False
        '
        'pctSrv3
        '
        Me.pctSrv3.Image = Global.SSHScriptExecute.My.Resources.Resources.orange
        Me.pctSrv3.Location = New System.Drawing.Point(229, 157)
        Me.pctSrv3.Name = "pctSrv3"
        Me.pctSrv3.Size = New System.Drawing.Size(23, 18)
        Me.pctSrv3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSrv3.TabIndex = 13
        Me.pctSrv3.TabStop = False
        '
        'pctSrv2
        '
        Me.pctSrv2.Image = Global.SSHScriptExecute.My.Resources.Resources.red
        Me.pctSrv2.Location = New System.Drawing.Point(229, 128)
        Me.pctSrv2.Name = "pctSrv2"
        Me.pctSrv2.Size = New System.Drawing.Size(23, 18)
        Me.pctSrv2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSrv2.TabIndex = 12
        Me.pctSrv2.TabStop = False
        '
        'pctSrv1
        '
        Me.pctSrv1.Image = Global.SSHScriptExecute.My.Resources.Resources.green
        Me.pctSrv1.Location = New System.Drawing.Point(229, 98)
        Me.pctSrv1.Name = "pctSrv1"
        Me.pctSrv1.Size = New System.Drawing.Size(23, 18)
        Me.pctSrv1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctSrv1.TabIndex = 11
        Me.pctSrv1.TabStop = False
        '
        'lblCustomServerMonitor
        '
        Me.lblCustomServerMonitor.AutoSize = True
        Me.lblCustomServerMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCustomServerMonitor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomServerMonitor.ForeColor = System.Drawing.Color.Green
        Me.lblCustomServerMonitor.Location = New System.Drawing.Point(146, 7)
        Me.lblCustomServerMonitor.Name = "lblCustomServerMonitor"
        Me.lblCustomServerMonitor.Size = New System.Drawing.Size(164, 17)
        Me.lblCustomServerMonitor.TabIndex = 10
        Me.lblCustomServerMonitor.Text = "Quick Server Operations"
        '
        'btnMonitorStart
        '
        Me.btnMonitorStart.BackColor = System.Drawing.Color.Green
        Me.btnMonitorStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonitorStart.FlatAppearance.BorderSize = 0
        Me.btnMonitorStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonitorStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMonitorStart.Location = New System.Drawing.Point(12, 29)
        Me.btnMonitorStart.Name = "btnMonitorStart"
        Me.btnMonitorStart.Size = New System.Drawing.Size(201, 24)
        Me.btnMonitorStart.TabIndex = 9
        Me.btnMonitorStart.Text = "Check Servers Status"
        Me.btnMonitorStart.UseVisualStyleBackColor = False
        '
        'btnSrv3Shut
        '
        Me.btnSrv3Shut.BackColor = System.Drawing.Color.IndianRed
        Me.btnSrv3Shut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv3Shut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv3Shut.Location = New System.Drawing.Point(356, 152)
        Me.btnSrv3Shut.Name = "btnSrv3Shut"
        Me.btnSrv3Shut.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv3Shut.TabIndex = 8
        Me.btnSrv3Shut.Text = "Shutdown"
        Me.btnSrv3Shut.UseVisualStyleBackColor = False
        '
        'btnSrv2Shut
        '
        Me.btnSrv2Shut.BackColor = System.Drawing.Color.IndianRed
        Me.btnSrv2Shut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv2Shut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv2Shut.Location = New System.Drawing.Point(356, 123)
        Me.btnSrv2Shut.Name = "btnSrv2Shut"
        Me.btnSrv2Shut.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv2Shut.TabIndex = 7
        Me.btnSrv2Shut.Text = "Shutdown"
        Me.btnSrv2Shut.UseVisualStyleBackColor = False
        '
        'btnSrv3Reboot
        '
        Me.btnSrv3Reboot.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSrv3Reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv3Reboot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv3Reboot.Location = New System.Drawing.Point(275, 152)
        Me.btnSrv3Reboot.Name = "btnSrv3Reboot"
        Me.btnSrv3Reboot.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv3Reboot.TabIndex = 6
        Me.btnSrv3Reboot.Text = "Reboot"
        Me.btnSrv3Reboot.UseVisualStyleBackColor = False
        '
        'btnSrv2Reboot
        '
        Me.btnSrv2Reboot.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSrv2Reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv2Reboot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv2Reboot.Location = New System.Drawing.Point(275, 123)
        Me.btnSrv2Reboot.Name = "btnSrv2Reboot"
        Me.btnSrv2Reboot.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv2Reboot.TabIndex = 5
        Me.btnSrv2Reboot.Text = "Reboot"
        Me.btnSrv2Reboot.UseVisualStyleBackColor = False
        '
        'lblServer3
        '
        Me.lblServer3.AutoSize = True
        Me.lblServer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblServer3.Location = New System.Drawing.Point(9, 157)
        Me.lblServer3.Name = "lblServer3"
        Me.lblServer3.Size = New System.Drawing.Size(53, 13)
        Me.lblServer3.TabIndex = 4
        Me.lblServer3.Text = "Server - 3"
        Me.lblServer3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblServer2
        '
        Me.lblServer2.AutoSize = True
        Me.lblServer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblServer2.Location = New System.Drawing.Point(9, 128)
        Me.lblServer2.Name = "lblServer2"
        Me.lblServer2.Size = New System.Drawing.Size(53, 13)
        Me.lblServer2.TabIndex = 3
        Me.lblServer2.Text = "Server - 2"
        Me.lblServer2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSrv1Shut
        '
        Me.btnSrv1Shut.BackColor = System.Drawing.Color.IndianRed
        Me.btnSrv1Shut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv1Shut.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv1Shut.Location = New System.Drawing.Point(356, 93)
        Me.btnSrv1Shut.Name = "btnSrv1Shut"
        Me.btnSrv1Shut.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv1Shut.TabIndex = 2
        Me.btnSrv1Shut.Text = "Shutdown"
        Me.btnSrv1Shut.UseVisualStyleBackColor = False
        '
        'btnSrv1Reboot
        '
        Me.btnSrv1Reboot.BackColor = System.Drawing.Color.OrangeRed
        Me.btnSrv1Reboot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSrv1Reboot.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSrv1Reboot.Location = New System.Drawing.Point(275, 93)
        Me.btnSrv1Reboot.Name = "btnSrv1Reboot"
        Me.btnSrv1Reboot.Size = New System.Drawing.Size(75, 23)
        Me.btnSrv1Reboot.TabIndex = 1
        Me.btnSrv1Reboot.Text = "Reboot"
        Me.btnSrv1Reboot.UseVisualStyleBackColor = False
        '
        'lblServer1
        '
        Me.lblServer1.AutoSize = True
        Me.lblServer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblServer1.Location = New System.Drawing.Point(9, 98)
        Me.lblServer1.Name = "lblServer1"
        Me.lblServer1.Size = New System.Drawing.Size(53, 13)
        Me.lblServer1.TabIndex = 0
        Me.lblServer1.Text = "Server - 1"
        Me.lblServer1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCheckPorts
        '
        Me.btnCheckPorts.BackColor = System.Drawing.Color.OrangeRed
        Me.btnCheckPorts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckPorts.FlatAppearance.BorderSize = 0
        Me.btnCheckPorts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckPorts.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCheckPorts.Location = New System.Drawing.Point(229, 29)
        Me.btnCheckPorts.Name = "btnCheckPorts"
        Me.btnCheckPorts.Size = New System.Drawing.Size(202, 24)
        Me.btnCheckPorts.TabIndex = 12
        Me.btnCheckPorts.Text = "Check Ports"
        Me.btnCheckPorts.UseVisualStyleBackColor = False
        '
        'lblPortStatus
        '
        Me.lblPortStatus.AutoSize = True
        Me.lblPortStatus.Location = New System.Drawing.Point(139, 60)
        Me.lblPortStatus.Name = "lblPortStatus"
        Me.lblPortStatus.Size = New System.Drawing.Size(59, 13)
        Me.lblPortStatus.TabIndex = 17
        Me.lblPortStatus.Text = "Port Status"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(204, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Ping Status"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.ConnectionBar)
        Me.Controls.Add(Me.StatusBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(471, 547)
        Me.MinimumSize = New System.Drawing.Size(471, 547)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SSH Script Execute"
        Me.ConnectionBar.ResumeLayout(False)
        Me.ConnectionBar.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctPort3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPort2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctPort1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSrv3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSrv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctSrv1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnPingHost As Button
    Friend WithEvents HostsListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSrv1Shut As Button
    Friend WithEvents btnSrv1Reboot As Button
    Friend WithEvents lblServer1 As Label
    Friend WithEvents btnSrv3Shut As Button
    Friend WithEvents btnSrv2Shut As Button
    Friend WithEvents btnSrv3Reboot As Button
    Friend WithEvents btnSrv2Reboot As Button
    Friend WithEvents lblServer3 As Label
    Friend WithEvents lblServer2 As Label
    Friend WithEvents btnMonitorStart As Button
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lblCustomServerMonitor As Label
    Friend WithEvents lblCustomScript As Label
    Friend WithEvents pctSrv1 As PictureBox
    Friend WithEvents pctSrv2 As PictureBox
    Friend WithEvents pctSrv3 As PictureBox
    Friend WithEvents pctPort1 As PictureBox
    Friend WithEvents pctPort3 As PictureBox
    Friend WithEvents pctPort2 As PictureBox
    Friend WithEvents btnCheckPorts As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPortStatus As Label
End Class
