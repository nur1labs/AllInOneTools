<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserOnlineRF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserOnlineRF))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncls = New System.Windows.Forms.Button()
        Me.OLStat = New System.Windows.Forms.Label()
        Me.LoadOnline = New System.Windows.Forms.Timer(Me.components)
        Me.DtChar = New System.Windows.Forms.DataGridView()
        CType(Me.DtChar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "User Online : "
        '
        'btncls
        '
        Me.btncls.BackgroundImage = CType(resources.GetObject("btncls.BackgroundImage"), System.Drawing.Image)
        Me.btncls.Location = New System.Drawing.Point(99, 217)
        Me.btncls.Name = "btncls"
        Me.btncls.Size = New System.Drawing.Size(81, 33)
        Me.btncls.TabIndex = 6
        Me.btncls.UseVisualStyleBackColor = True
        '
        'OLStat
        '
        Me.OLStat.AutoSize = True
        Me.OLStat.Location = New System.Drawing.Point(107, 189)
        Me.OLStat.Name = "OLStat"
        Me.OLStat.Size = New System.Drawing.Size(39, 13)
        Me.OLStat.TabIndex = 5
        Me.OLStat.Text = "Label1"
        '
        'LoadOnline
        '
        Me.LoadOnline.Enabled = True
        '
        'DtChar
        '
        Me.DtChar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtChar.Location = New System.Drawing.Point(12, 12)
        Me.DtChar.Name = "DtChar"
        Me.DtChar.Size = New System.Drawing.Size(260, 174)
        Me.DtChar.TabIndex = 4
        '
        'UserOnlineRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btncls)
        Me.Controls.Add(Me.OLStat)
        Me.Controls.Add(Me.DtChar)
        Me.Name = "UserOnlineRF"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserOnlineRF"
        CType(Me.DtChar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btncls As System.Windows.Forms.Button
    Friend WithEvents OLStat As System.Windows.Forms.Label
    Friend WithEvents LoadOnline As System.Windows.Forms.Timer
    Friend WithEvents DtChar As System.Windows.Forms.DataGridView
End Class
