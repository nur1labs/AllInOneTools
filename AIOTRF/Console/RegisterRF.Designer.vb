<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterRF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegisterRF))
        Me.btncancel = New System.Windows.Forms.Button()
        Me.nok = New System.Windows.Forms.Button()
        Me.nbirth = New System.Windows.Forms.TextBox()
        Me.npass = New System.Windows.Forms.TextBox()
        Me.nid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackgroundImage = CType(resources.GetObject("btncancel.BackgroundImage"), System.Drawing.Image)
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Location = New System.Drawing.Point(116, 96)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 33)
        Me.btncancel.TabIndex = 19
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'nok
        '
        Me.nok.BackgroundImage = CType(resources.GetObject("nok.BackgroundImage"), System.Drawing.Image)
        Me.nok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nok.Location = New System.Drawing.Point(35, 96)
        Me.nok.Name = "nok"
        Me.nok.Size = New System.Drawing.Size(75, 33)
        Me.nok.TabIndex = 18
        Me.nok.UseVisualStyleBackColor = True
        '
        'nbirth
        '
        Me.nbirth.Location = New System.Drawing.Point(91, 70)
        Me.nbirth.Name = "nbirth"
        Me.nbirth.Size = New System.Drawing.Size(141, 20)
        Me.nbirth.TabIndex = 16
        '
        'npass
        '
        Me.npass.Location = New System.Drawing.Point(91, 37)
        Me.npass.Name = "npass"
        Me.npass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.npass.Size = New System.Drawing.Size(100, 20)
        Me.npass.TabIndex = 15
        '
        'nid
        '
        Me.nid.Location = New System.Drawing.Point(91, 8)
        Me.nid.Name = "nid"
        Me.nid.Size = New System.Drawing.Size(100, 20)
        Me.nid.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Birthdate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Id"
        '
        'RegisterRF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(244, 137)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.nok)
        Me.Controls.Add(Me.nbirth)
        Me.Controls.Add(Me.npass)
        Me.Controls.Add(Me.nid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegisterRF"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterRF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents nok As System.Windows.Forms.Button
    Friend WithEvents nbirth As System.Windows.Forms.TextBox
    Friend WithEvents npass As System.Windows.Forms.TextBox
    Friend WithEvents nid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
