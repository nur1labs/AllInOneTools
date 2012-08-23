<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mail
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
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAttachment = New System.Windows.Forms.TextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.GroupLogin = New System.Windows.Forms.GroupBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lblsubject = New System.Windows.Forms.Label()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.GroupLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(70, 119)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 26)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtAttachment
        '
        Me.txtAttachment.Location = New System.Drawing.Point(3, 93)
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(179, 20)
        Me.txtAttachment.TabIndex = 16
        '
        'Send
        '
        Me.Send.Location = New System.Drawing.Point(259, 199)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 17
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(259, 1)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(137, 20)
        Me.txtFrom.TabIndex = 18
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(259, 27)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(137, 20)
        Me.txtTo.TabIndex = 19
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(259, 53)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(194, 20)
        Me.txtSubject.TabIndex = 20
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(259, 79)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(200, 114)
        Me.txtMessage.TabIndex = 21
        Me.txtMessage.Text = ""
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(67, 16)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtUserName.TabIndex = 22
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(67, 42)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 23
        '
        'GroupLogin
        '
        Me.GroupLogin.Controls.Add(Me.lblpass)
        Me.GroupLogin.Controls.Add(Me.lbluser)
        Me.GroupLogin.Controls.Add(Me.txtUserName)
        Me.GroupLogin.Controls.Add(Me.txtPass)
        Me.GroupLogin.Location = New System.Drawing.Point(3, 4)
        Me.GroupLogin.Name = "GroupLogin"
        Me.GroupLogin.Size = New System.Drawing.Size(179, 83)
        Me.GroupLogin.TabIndex = 24
        Me.GroupLogin.TabStop = False
        Me.GroupLogin.Text = "Login"
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(6, 45)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(53, 13)
        Me.lblpass.TabIndex = 25
        Me.lblpass.Text = "Password"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Location = New System.Drawing.Point(6, 19)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(55, 13)
        Me.lbluser.TabIndex = 25
        Me.lbluser.Text = "Username"
        '
        'lblfrom
        '
        Me.lblfrom.AutoSize = True
        Me.lblfrom.Location = New System.Drawing.Point(193, 4)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(30, 13)
        Me.lblfrom.TabIndex = 25
        Me.lblfrom.Text = "From"
        '
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Location = New System.Drawing.Point(193, 30)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(20, 13)
        Me.lblto.TabIndex = 26
        Me.lblto.Text = "To"
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Location = New System.Drawing.Point(193, 60)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(43, 13)
        Me.lblsubject.TabIndex = 27
        Me.lblsubject.Text = "Subject"
        '
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(193, 82)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(50, 13)
        Me.lblmsg.TabIndex = 28
        Me.lblmsg.Text = "Message"
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(340, 199)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 55
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 225)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.GroupLogin)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.txtAttachment)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Mail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mail To Other Player(Still Beta)"
        Me.GroupLogin.ResumeLayout(False)
        Me.GroupLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents GroupLogin As System.Windows.Forms.GroupBox
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lblsubject As System.Windows.Forms.Label
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents btnclose As System.Windows.Forms.Button
End Class
