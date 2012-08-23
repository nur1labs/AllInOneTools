<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaskMainMenu))
        Me.AllInOneTools = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContexAIOT = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeedbackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcPrimary = New System.Windows.Forms.Timer(Me.components)
        Me.lstProcesses = New System.Windows.Forms.ListBox()
        Me.ProcThird = New System.Windows.Forms.Timer(Me.components)
        Me.ProcSecond = New System.Windows.Forms.Timer(Me.components)
        Me.ProcFourth = New System.Windows.Forms.Timer(Me.components)
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
        Me.ContexAIOT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartGameToolStripMenuItem, Me.ToolStripSeparator1, Me.AboutToolStripMenuItem, Me.FeedbackToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.ContexAIOT.Name = "ContexAIOT"
        Me.ContexAIOT.Size = New System.Drawing.Size(211, 98)
        '
        'StartGameToolStripMenuItem
        '
        Me.StartGameToolStripMenuItem.Name = "StartGameToolStripMenuItem"
        Me.StartGameToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.StartGameToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.StartGameToolStripMenuItem.Text = "Open Main Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'FeedbackToolStripMenuItem
        '
        Me.FeedbackToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MailingToolStripMenuItem, Me.DonationToolStripMenuItem})
        Me.FeedbackToolStripMenuItem.Name = "FeedbackToolStripMenuItem"
        Me.FeedbackToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.FeedbackToolStripMenuItem.Text = "Feedback"
        '
        'MailingToolStripMenuItem
        '
        Me.MailingToolStripMenuItem.Name = "MailingToolStripMenuItem"
        Me.MailingToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MailingToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.MailingToolStripMenuItem.Text = "Mailing"
        '
        'DonationToolStripMenuItem
        '
        Me.DonationToolStripMenuItem.Name = "DonationToolStripMenuItem"
        Me.DonationToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DonationToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.DonationToolStripMenuItem.Text = "Donation"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ProcPrimary
        '
        Me.ProcPrimary.Enabled = True
        '
        'lstProcesses
        '
        Me.lstProcesses.FormattingEnabled = True
        Me.lstProcesses.Location = New System.Drawing.Point(12, 12)
        Me.lstProcesses.Name = "lstProcesses"
        Me.lstProcesses.Size = New System.Drawing.Size(183, 108)
        Me.lstProcesses.TabIndex = 2
        '
        'ProcThird
        '
        '
        'ProcSecond
        '
        '
        'ProcFourth
        '
        '
        'TaskMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(204, 133)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstProcesses)
        Me.Name = "TaskMainMenu"
        Me.Opacity = 0.0R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskMainMenu"
        Me.ContexAIOT.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AllInOneTools As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContexAIOT As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents StartGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcPrimary As System.Windows.Forms.Timer
    Friend WithEvents lstProcesses As System.Windows.Forms.ListBox
    Friend WithEvents ProcThird As System.Windows.Forms.Timer
    Friend WithEvents ProcSecond As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeedbackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcFourth As System.Windows.Forms.Timer
End Class
