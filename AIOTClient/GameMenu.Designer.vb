<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameMenu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.csslinks = New System.Windows.Forms.PictureBox()
        Me.pwlinks = New System.Windows.Forms.PictureBox()
        Me.rflinks = New System.Windows.Forms.PictureBox()
        Me.btnclosed = New System.Windows.Forms.Button()
        CType(Me.csslinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pwlinks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rflinks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose Sevice"
        '
        'csslinks
        '
        Me.csslinks.BackgroundImage = CType(resources.GetObject("csslinks.BackgroundImage"), System.Drawing.Image)
        Me.csslinks.Location = New System.Drawing.Point(234, 25)
        Me.csslinks.Name = "csslinks"
        Me.csslinks.Size = New System.Drawing.Size(67, 58)
        Me.csslinks.TabIndex = 4
        Me.csslinks.TabStop = False
        '
        'pwlinks
        '
        Me.pwlinks.BackgroundImage = CType(resources.GetObject("pwlinks.BackgroundImage"), System.Drawing.Image)
        Me.pwlinks.Location = New System.Drawing.Point(88, 25)
        Me.pwlinks.Name = "pwlinks"
        Me.pwlinks.Size = New System.Drawing.Size(140, 33)
        Me.pwlinks.TabIndex = 2
        Me.pwlinks.TabStop = False
        '
        'rflinks
        '
        Me.rflinks.BackgroundImage = CType(resources.GetObject("rflinks.BackgroundImage"), System.Drawing.Image)
        Me.rflinks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rflinks.Location = New System.Drawing.Point(12, 25)
        Me.rflinks.Name = "rflinks"
        Me.rflinks.Size = New System.Drawing.Size(70, 70)
        Me.rflinks.TabIndex = 1
        Me.rflinks.TabStop = False
        '
        'btnclosed
        '
        Me.btnclosed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclosed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclosed.Location = New System.Drawing.Point(121, 101)
        Me.btnclosed.Name = "btnclosed"
        Me.btnclosed.Size = New System.Drawing.Size(75, 23)
        Me.btnclosed.TabIndex = 5
        Me.btnclosed.Text = "Close"
        Me.btnclosed.UseVisualStyleBackColor = True
        '
        'GameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclosed)
        Me.Controls.Add(Me.csslinks)
        Me.Controls.Add(Me.pwlinks)
        Me.Controls.Add(Me.rflinks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GameMenu"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameMenu"
        CType(Me.csslinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pwlinks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rflinks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rflinks As System.Windows.Forms.PictureBox
    Friend WithEvents pwlinks As System.Windows.Forms.PictureBox
    Friend WithEvents csslinks As System.Windows.Forms.PictureBox
    Friend WithEvents btnclosed As System.Windows.Forms.Button
End Class
