<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AIOTFRF
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AIOTFRF))
        Me.AllInOneTools = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContexAIOT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FeatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestSkyWarsGUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GamingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckingServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BannedCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TweakingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportPlayerCheatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultToAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportProgramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailToPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcPrimary = New System.Windows.Forms.Timer(Me.components)
        Me.ProcSecond = New System.Windows.Forms.Timer(Me.components)
        Me.ProcThird = New System.Windows.Forms.Timer(Me.components)
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.Open = New System.Windows.Forms.OpenFileDialog()
        Me.DatasLoad = New System.Windows.Forms.RichTextBox()
        Me.ContexAIOT.SuspendLayout()
        Me.SuspendLayout()
        '
        'AllInOneTools
        '
        Me.AllInOneTools.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.AllInOneTools.BalloonTipText = "This Is Beta Tools For RF"
        Me.AllInOneTools.BalloonTipTitle = "Notification"
        Me.AllInOneTools.ContextMenuStrip = Me.ContexAIOT
        Me.AllInOneTools.Icon = CType(resources.GetObject("AllInOneTools.Icon"), System.Drawing.Icon)
        Me.AllInOneTools.Text = "AllInOneToolsForRF"
        Me.AllInOneTools.Visible = True
        '
        'ContexAIOT
        '
        Me.ContexAIOT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeatureToolStripMenuItem, Me.StartGameToolStripMenuItem, Me.StopGameToolStripMenuItem, Me.ToolStripSeparator1, Me.UpdateToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContexAIOT.Name = "ContexAIOT"
        Me.ContexAIOT.Size = New System.Drawing.Size(152, 120)
        '
        'FeatureToolStripMenuItem
        '
        Me.FeatureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestSkyWarsGUIToolStripMenuItem, Me.GamingToolStripMenuItem, Me.MaintainingToolStripMenuItem, Me.MailingToolStripMenuItem})
        Me.FeatureToolStripMenuItem.Name = "FeatureToolStripMenuItem"
        Me.FeatureToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FeatureToolStripMenuItem.Text = "Feature"
        '
        'TestSkyWarsGUIToolStripMenuItem
        '
        Me.TestSkyWarsGUIToolStripMenuItem.Name = "TestSkyWarsGUIToolStripMenuItem"
        Me.TestSkyWarsGUIToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.TestSkyWarsGUIToolStripMenuItem.Text = "Test Sky Wars GUI"
        '
        'GamingToolStripMenuItem
        '
        Me.GamingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineStatusToolStripMenuItem, Me.RegisterToolStripMenuItem, Me.CheckingServerToolStripMenuItem, Me.TotalRegisterToolStripMenuItem, Me.BannedCheckToolStripMenuItem})
        Me.GamingToolStripMenuItem.Name = "GamingToolStripMenuItem"
        Me.GamingToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.GamingToolStripMenuItem.Text = "Gaming"
        '
        'OnlineStatusToolStripMenuItem
        '
        Me.OnlineStatusToolStripMenuItem.Name = "OnlineStatusToolStripMenuItem"
        Me.OnlineStatusToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.OnlineStatusToolStripMenuItem.Text = "Online Status"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'CheckingServerToolStripMenuItem
        '
        Me.CheckingServerToolStripMenuItem.Name = "CheckingServerToolStripMenuItem"
        Me.CheckingServerToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CheckingServerToolStripMenuItem.Text = "Checking Server"
        '
        'TotalRegisterToolStripMenuItem
        '
        Me.TotalRegisterToolStripMenuItem.Name = "TotalRegisterToolStripMenuItem"
        Me.TotalRegisterToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.TotalRegisterToolStripMenuItem.Text = "Total Register"
        '
        'BannedCheckToolStripMenuItem
        '
        Me.BannedCheckToolStripMenuItem.Name = "BannedCheckToolStripMenuItem"
        Me.BannedCheckToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.BannedCheckToolStripMenuItem.Text = "Banned Check"
        '
        'MaintainingToolStripMenuItem
        '
        Me.MaintainingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TweakingToolStripMenuItem})
        Me.MaintainingToolStripMenuItem.Name = "MaintainingToolStripMenuItem"
        Me.MaintainingToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MaintainingToolStripMenuItem.Text = "Maintaining"
        '
        'TweakingToolStripMenuItem
        '
        Me.TweakingToolStripMenuItem.Name = "TweakingToolStripMenuItem"
        Me.TweakingToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.TweakingToolStripMenuItem.Text = "Tweaking"
        '
        'MailingToolStripMenuItem
        '
        Me.MailingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportPlayerCheatToolStripMenuItem, Me.ConsultToAdminToolStripMenuItem, Me.ReportProgramsToolStripMenuItem, Me.MailToPlayerToolStripMenuItem})
        Me.MailingToolStripMenuItem.Name = "MailingToolStripMenuItem"
        Me.MailingToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.MailingToolStripMenuItem.Text = "MailingSystem"
        '
        'ReportPlayerCheatToolStripMenuItem
        '
        Me.ReportPlayerCheatToolStripMenuItem.Name = "ReportPlayerCheatToolStripMenuItem"
        Me.ReportPlayerCheatToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ReportPlayerCheatToolStripMenuItem.Text = "Report Player Cheat"
        '
        'ConsultToAdminToolStripMenuItem
        '
        Me.ConsultToAdminToolStripMenuItem.Name = "ConsultToAdminToolStripMenuItem"
        Me.ConsultToAdminToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ConsultToAdminToolStripMenuItem.Text = "Consult To Admin"
        '
        'ReportProgramsToolStripMenuItem
        '
        Me.ReportProgramsToolStripMenuItem.Name = "ReportProgramsToolStripMenuItem"
        Me.ReportProgramsToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.ReportProgramsToolStripMenuItem.Text = "Report Programs"
        '
        'MailToPlayerToolStripMenuItem
        '
        Me.MailToPlayerToolStripMenuItem.Name = "MailToPlayerToolStripMenuItem"
        Me.MailToPlayerToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.MailToPlayerToolStripMenuItem.Text = "Mail To Player"
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.StartGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.StartGameToolStripMenuItem.Text = "Start Game"
        '
        'StopGameToolStripMenuItem
        '
        Me.StopGameToolStripMenuItem.Name = "StopGameToolStripMenuItem"
        Me.StopGameToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.StopGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.StopGameToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.StopGameToolStripMenuItem.Text = "Stop Game"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateClientToolStripMenuItem, Me.UpdateProgramToolStripMenuItem})
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'UpdateClientToolStripMenuItem
        '
        Me.UpdateClientToolStripMenuItem.Name = "UpdateClientToolStripMenuItem"
        Me.UpdateClientToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.UpdateClientToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UpdateClientToolStripMenuItem.Text = "Update Client"
        '
        'UpdateProgramToolStripMenuItem
        '
        Me.UpdateProgramToolStripMenuItem.Name = "UpdateProgramToolStripMenuItem"
        Me.UpdateProgramToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.UpdateProgramToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.UpdateProgramToolStripMenuItem.Text = "Update Program"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ProcPrimary
        '
        Me.ProcPrimary.Enabled = True
        '
        'ProcSecond
        '
        '
        'ProcThird
        '
        '
        'lstProcesses
        '
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.Location = New System.Drawing.Point(12, 12)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(183, 56)
        Me.lstProcesses.TabIndex = 1
        '
        'Open
        '
        Me.Open.FileName = "OpenFileDialog1"
        '
        'DatasLoad
        '
        Me.DatasLoad.Location = New System.Drawing.Point(12, 74)
        Me.DatasLoad.Name = "DatasLoad"
        Me.DatasLoad.Size = New System.Drawing.Size(183, 49)
        Me.DatasLoad.TabIndex = 2
        Me.DatasLoad.Text = ""
        '
        'AIOTFRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(207, 135)
        Me.ContextMenuStrip = Me.ContexAIOT
        Me.ControlBox = False
        Me.Controls.Add(Me.lstProcesses)
        Me.Controls.Add(Me.DatasLoad)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AIOTFRF"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AIOTFRF"
        Me.ContexAIOT.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AllInOneTools As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContexAIOT As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FeatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TestSkyWarsGUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GamingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OnlineStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckingServerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcPrimary As System.Windows.Forms.Timer
    Friend WithEvents ProcSecond As System.Windows.Forms.Timer
    Friend WithEvents ProcThird As System.Windows.Forms.Timer
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
    Friend WithEvents Open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DatasLoad As System.Windows.Forms.RichTextBox
    Friend WithEvents MaintainingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TweakingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportPlayerCheatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultToAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportProgramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailToPlayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BannedCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
