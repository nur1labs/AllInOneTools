<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Execution
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
        Me.editorsys = New System.Windows.Forms.RichTextBox()
        Me.inpcom = New System.Windows.Forms.TextBox()
        Me.btncommand = New System.Windows.Forms.Button()
        Me.timefirefox = New System.Windows.Forms.Timer(Me.components)
        Me.timechrome = New System.Windows.Forms.Timer(Me.components)
        Me.timesafari = New System.Windows.Forms.Timer(Me.components)
        Me.timeopera = New System.Windows.Forms.Timer(Me.components)
        Me.timebrowser = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'editorsys
        '
        Me.editorsys.Location = New System.Drawing.Point(12, 12)
        Me.editorsys.Name = "editorsys"
        Me.editorsys.Size = New System.Drawing.Size(260, 215)
        Me.editorsys.TabIndex = 0
        Me.editorsys.Text = "execution....ok" & Global.Microsoft.VisualBasic.ChrW(10) & "data read.......ok" & Global.Microsoft.VisualBasic.ChrW(10) & "balance.........ok" & Global.Microsoft.VisualBasic.ChrW(10) & "system dump kill....ok" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Rea" & _
            "d()....100%" & Global.Microsoft.VisualBasic.ChrW(10) & "Opening Application Ready" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Command:_" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Notes:Command In Help Desk"
        '
        'inpcom
        '
        Me.inpcom.Location = New System.Drawing.Point(12, 233)
        Me.inpcom.Name = "inpcom"
        Me.inpcom.Size = New System.Drawing.Size(179, 20)
        Me.inpcom.TabIndex = 1
        '
        'btncommand
        '
        Me.btncommand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncommand.Location = New System.Drawing.Point(197, 233)
        Me.btncommand.Name = "btncommand"
        Me.btncommand.Size = New System.Drawing.Size(75, 23)
        Me.btncommand.TabIndex = 2
        Me.btncommand.Text = "Command"
        Me.btncommand.UseVisualStyleBackColor = True
        '
        'timefirefox
        '
        '
        'timechrome
        '
        '
        'timesafari
        '
        '
        'timeopera
        '
        '
        'timebrowser
        '
        '
        'Execution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncommand)
        Me.Controls.Add(Me.inpcom)
        Me.Controls.Add(Me.editorsys)
        Me.Name = "Execution"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tweak Connection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents editorsys As System.Windows.Forms.RichTextBox
    Friend WithEvents inpcom As System.Windows.Forms.TextBox
    Friend WithEvents btncommand As System.Windows.Forms.Button
    Friend WithEvents timefirefox As System.Windows.Forms.Timer
    Friend WithEvents timechrome As System.Windows.Forms.Timer
    Friend WithEvents timesafari As System.Windows.Forms.Timer
    Friend WithEvents timeopera As System.Windows.Forms.Timer
    Friend WithEvents timebrowser As System.Windows.Forms.Timer
End Class
