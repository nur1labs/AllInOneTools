<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agreement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agreement))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BtnAgree = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.DetectedIp = New System.Windows.Forms.Label()
        Me.ESP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(423, 280)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'BtnAgree
        '
        Me.BtnAgree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgree.Location = New System.Drawing.Point(104, 298)
        Me.BtnAgree.Name = "BtnAgree"
        Me.BtnAgree.Size = New System.Drawing.Size(75, 26)
        Me.BtnAgree.TabIndex = 1
        Me.BtnAgree.Text = "I Agree"
        Me.BtnAgree.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Location = New System.Drawing.Point(205, 298)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(107, 23)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Do Not Agree"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'DetectedIp
        '
        Me.DetectedIp.AutoSize = True
        Me.DetectedIp.Location = New System.Drawing.Point(12, 334)
        Me.DetectedIp.Name = "DetectedIp"
        Me.DetectedIp.Size = New System.Drawing.Size(62, 13)
        Me.DetectedIp.TabIndex = 3
        Me.DetectedIp.Text = "Your IP Is : "
        '
        'ESP
        '
        Me.ESP.AutoSize = True
        Me.ESP.Location = New System.Drawing.Point(299, 334)
        Me.ESP.Name = "ESP"
        Me.ESP.Size = New System.Drawing.Size(136, 13)
        Me.ESP.TabIndex = 4
        Me.ESP.Text = "Enable Software Protection"
        '
        'Agreement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 356)
        Me.ControlBox = False
        Me.Controls.Add(Me.ESP)
        Me.Controls.Add(Me.DetectedIp)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnAgree)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Agreement"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agreement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BtnAgree As System.Windows.Forms.Button
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents DetectedIp As System.Windows.Forms.Label
    Friend WithEvents ESP As System.Windows.Forms.Label
End Class
