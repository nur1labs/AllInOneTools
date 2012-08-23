<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdaterRF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdaterRF))
        Me.lblload = New System.Windows.Forms.Label()
        Me.updatertime = New System.Windows.Forms.Timer(Me.components)
        Me.loadtime = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.barload = New System.Windows.Forms.ProgressBar()
        Me.barupdater = New System.Windows.Forms.ProgressBar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblload
        '
        Me.lblload.AutoSize = True
        Me.lblload.Location = New System.Drawing.Point(3, 176)
        Me.lblload.Name = "lblload"
        Me.lblload.Size = New System.Drawing.Size(39, 13)
        Me.lblload.TabIndex = 9
        Me.lblload.Text = "Label1"
        '
        'updatertime
        '
        Me.updatertime.Interval = 200
        '
        'loadtime
        '
        Me.loadtime.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(279, 166)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnOk
        '
        Me.BtnOk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOk.Location = New System.Drawing.Point(99, 233)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(75, 23)
        Me.BtnOk.TabIndex = 7
        Me.BtnOk.Text = "ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'barload
        '
        Me.barload.Location = New System.Drawing.Point(3, 192)
        Me.barload.Name = "barload"
        Me.barload.Size = New System.Drawing.Size(279, 14)
        Me.barload.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.barload.TabIndex = 6
        '
        'barupdater
        '
        Me.barupdater.Location = New System.Drawing.Point(3, 212)
        Me.barupdater.Name = "barupdater"
        Me.barupdater.Size = New System.Drawing.Size(279, 15)
        Me.barupdater.TabIndex = 5
        '
        'UpdaterRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblload)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.barload)
        Me.Controls.Add(Me.barupdater)
        Me.Name = "UpdaterRF"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblload As System.Windows.Forms.Label
    Friend WithEvents updatertime As System.Windows.Forms.Timer
    Friend WithEvents loadtime As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents barload As System.Windows.Forms.ProgressBar
    Friend WithEvents barupdater As System.Windows.Forms.ProgressBar
End Class
