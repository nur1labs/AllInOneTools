<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportingCheat
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
        Me.lblsubject = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblto = New System.Windows.Forms.Label()
        Me.lbluser = New System.Windows.Forms.Label()
        Me.lblfrom = New System.Windows.Forms.Label()
        Me.GroupLogin = New System.Windows.Forms.GroupBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblmsg = New System.Windows.Forms.Label()
        Me.txtMessage = New System.Windows.Forms.RichTextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtTo = New System.Windows.Forms.TextBox()
        Me.txtFrom = New System.Windows.Forms.TextBox()
        Me.Send = New System.Windows.Forms.Button()
        Me.txtAttachment = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.promote = New System.Windows.Forms.Label()
        Me.GroupLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'ofd
        '
        Me.ofd.FileName = "OpenFileDialog1"
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Location = New System.Drawing.Point(195, 60)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(43, 13)
        Me.lblsubject.TabIndex = 39
        Me.lblsubject.Text = "Subject"
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
        'lblto
        '
        Me.lblto.AutoSize = True
        Me.lblto.Location = New System.Drawing.Point(195, 30)
        Me.lblto.Name = "lblto"
        Me.lblto.Size = New System.Drawing.Size(20, 13)
        Me.lblto.TabIndex = 38
        Me.lblto.Text = "To"
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
        Me.lblfrom.Location = New System.Drawing.Point(195, 4)
        Me.lblfrom.Name = "lblfrom"
        Me.lblfrom.Size = New System.Drawing.Size(30, 13)
        Me.lblfrom.TabIndex = 37
        Me.lblfrom.Text = "From"
        '
        'GroupLogin
        '
        Me.GroupLogin.Controls.Add(Me.lblpass)
        Me.GroupLogin.Controls.Add(Me.lbluser)
        Me.GroupLogin.Controls.Add(Me.txtUserName)
        Me.GroupLogin.Controls.Add(Me.txtPass)
        Me.GroupLogin.Location = New System.Drawing.Point(5, 3)
        Me.GroupLogin.Name = "GroupLogin"
        Me.GroupLogin.Size = New System.Drawing.Size(179, 83)
        Me.GroupLogin.TabIndex = 36
        Me.GroupLogin.TabStop = False
        Me.GroupLogin.Text = "Login"
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
        'lblmsg
        '
        Me.lblmsg.AutoSize = True
        Me.lblmsg.Location = New System.Drawing.Point(195, 82)
        Me.lblmsg.Name = "lblmsg"
        Me.lblmsg.Size = New System.Drawing.Size(50, 13)
        Me.lblmsg.TabIndex = 40
        Me.lblmsg.Text = "Message"
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(261, 79)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(200, 114)
        Me.txtMessage.TabIndex = 35
        Me.txtMessage.Text = "<example:help i find people using chat on game nick : Test>" & Global.Microsoft.VisualBasic.ChrW(10) & "<For Attach Using Add" & _
            " Button>"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(261, 53)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.ReadOnly = True
        Me.txtSubject.Size = New System.Drawing.Size(193, 20)
        Me.txtSubject.TabIndex = 34
        Me.txtSubject.Text = "Reporting Cheat"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(261, 27)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.ReadOnly = True
        Me.txtTo.Size = New System.Drawing.Size(140, 20)
        Me.txtTo.TabIndex = 33
        Me.txtTo.Text = "crbru.yuthafiga@gmail.com"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(261, 1)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(140, 20)
        Me.txtFrom.TabIndex = 32
        '
        'Send
        '
        Me.Send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Send.Location = New System.Drawing.Point(261, 199)
        Me.Send.Name = "Send"
        Me.Send.Size = New System.Drawing.Size(75, 23)
        Me.Send.TabIndex = 31
        Me.Send.Text = "Send"
        Me.Send.UseVisualStyleBackColor = True
        '
        'txtAttachment
        '
        Me.txtAttachment.Location = New System.Drawing.Point(5, 92)
        Me.txtAttachment.Name = "txtAttachment"
        Me.txtAttachment.Size = New System.Drawing.Size(179, 20)
        Me.txtAttachment.TabIndex = 30
        '
        'btnAdd
        '
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.Location = New System.Drawing.Point(72, 118)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 26)
        Me.btnAdd.TabIndex = 29
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.Location = New System.Drawing.Point(342, 199)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 54
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'promote
        '
        Me.promote.AutoSize = True
        Me.promote.ForeColor = System.Drawing.Color.Red
        Me.promote.Location = New System.Drawing.Point(11, 159)
        Me.promote.Name = "promote"
        Me.promote.Size = New System.Drawing.Size(208, 26)
        Me.promote.TabIndex = 55
        Me.promote.Text = "If You Real Give Us Nick AS Real Cheater" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " I Give You 5000 Gold"
        '
        'ReportingCheat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.promote)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.lblsubject)
        Me.Controls.Add(Me.lblto)
        Me.Controls.Add(Me.lblfrom)
        Me.Controls.Add(Me.GroupLogin)
        Me.Controls.Add(Me.lblmsg)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.Send)
        Me.Controls.Add(Me.txtAttachment)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "ReportingCheat"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheater Reporting"
        Me.GroupLogin.ResumeLayout(False)
        Me.GroupLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblsubject As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents lblto As System.Windows.Forms.Label
    Friend WithEvents lbluser As System.Windows.Forms.Label
    Friend WithEvents lblfrom As System.Windows.Forms.Label
    Friend WithEvents GroupLogin As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblmsg As System.Windows.Forms.Label
    Friend WithEvents txtMessage As System.Windows.Forms.RichTextBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents Send As System.Windows.Forms.Button
    Friend WithEvents txtAttachment As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents promote As System.Windows.Forms.Label
End Class
