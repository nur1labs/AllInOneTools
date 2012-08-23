<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Donation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Donation))
        Me.paypal = New System.Windows.Forms.PictureBox()
        Me.skrill = New System.Windows.Forms.PictureBox()
        Me.lblupper = New System.Windows.Forms.Label()
        Me.lbllocal = New System.Windows.Forms.Label()
        Me.lblbri = New System.Windows.Forms.Label()
        Me.bri = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.paypal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.skrill, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paypal
        '
        Me.paypal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.paypal.Image = CType(resources.GetObject("paypal.Image"), System.Drawing.Image)
        Me.paypal.Location = New System.Drawing.Point(12, 50)
        Me.paypal.Name = "paypal"
        Me.paypal.Size = New System.Drawing.Size(360, 144)
        Me.paypal.TabIndex = 0
        Me.paypal.TabStop = False
        '
        'skrill
        '
        Me.skrill.BackgroundImage = CType(resources.GetObject("skrill.BackgroundImage"), System.Drawing.Image)
        Me.skrill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.skrill.Location = New System.Drawing.Point(378, 50)
        Me.skrill.Name = "skrill"
        Me.skrill.Size = New System.Drawing.Size(329, 142)
        Me.skrill.TabIndex = 1
        Me.skrill.TabStop = False
        '
        'lblupper
        '
        Me.lblupper.AutoSize = True
        Me.lblupper.Font = New System.Drawing.Font("Matura MT Script Capitals", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblupper.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblupper.Location = New System.Drawing.Point(187, 9)
        Me.lblupper.Name = "lblupper"
        Me.lblupper.Size = New System.Drawing.Size(342, 36)
        Me.lblupper.TabIndex = 2
        Me.lblupper.Text = "Choose Electronic Payment"
        '
        'lbllocal
        '
        Me.lbllocal.AutoSize = True
        Me.lbllocal.Font = New System.Drawing.Font("Matura MT Script Capitals", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbllocal.Location = New System.Drawing.Point(241, 195)
        Me.lbllocal.Name = "lbllocal"
        Me.lbllocal.Size = New System.Drawing.Size(255, 36)
        Me.lbllocal.TabIndex = 3
        Me.lbllocal.Text = "Or Local Payment"
        '
        'lblbri
        '
        Me.lblbri.AutoSize = True
        Me.lblbri.Location = New System.Drawing.Point(12, 331)
        Me.lblbri.Name = "lblbri"
        Me.lblbri.Size = New System.Drawing.Size(136, 13)
        Me.lblbri.TabIndex = 4
        Me.lblbri.Text = "BRI:0188 01.049768.50.01"
        '
        'bri
        '
        Me.bri.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bri.Image = CType(resources.GetObject("bri.Image"), System.Drawing.Image)
        Me.bri.Location = New System.Drawing.Point(12, 227)
        Me.bri.Name = "bri"
        Me.bri.Size = New System.Drawing.Size(389, 101)
        Me.bri.TabIndex = 5
        Me.bri.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Location = New System.Drawing.Point(326, 343)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 6
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Donation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 368)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.bri)
        Me.Controls.Add(Me.lblbri)
        Me.Controls.Add(Me.lbllocal)
        Me.Controls.Add(Me.lblupper)
        Me.Controls.Add(Me.skrill)
        Me.Controls.Add(Me.paypal)
        Me.Name = "Donation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Support Us!For Next Feature"
        CType(Me.paypal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.skrill, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paypal As System.Windows.Forms.PictureBox
    Friend WithEvents skrill As System.Windows.Forms.PictureBox
    Friend WithEvents lblupper As System.Windows.Forms.Label
    Friend WithEvents lbllocal As System.Windows.Forms.Label
    Friend WithEvents lblbri As System.Windows.Forms.Label
    Friend WithEvents bri As System.Windows.Forms.PictureBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
