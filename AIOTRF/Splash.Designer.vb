<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.frmtimer = New System.Windows.Forms.Timer(Me.components)
        Me.flashbar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'frmtimer
        '
        Me.frmtimer.Enabled = True
        '
        'flashbar
        '
        Me.flashbar.Location = New System.Drawing.Point(12, 169)
        Me.flashbar.Name = "flashbar"
        Me.flashbar.Size = New System.Drawing.Size(232, 20)
        Me.flashbar.TabIndex = 2
        Me.flashbar.Visible = False
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(256, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.flashbar)
        Me.Name = "Splash"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frmtimer As System.Windows.Forms.Timer
    Friend WithEvents flashbar As System.Windows.Forms.ProgressBar
End Class
