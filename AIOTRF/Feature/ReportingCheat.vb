Imports System.Net.Mail
Public Class ReportingCheat

#Region "mail"
    Dim message As System.Net.Mail.MailMessage
    Dim smtp As New System.Net.Mail.SmtpClient("smtp.gmail.com", 587)
    Dim attach As System.Net.Mail.Attachment
#End Region

#Region "command"
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim openDLG As New OpenFileDialog
        openDLG.AddExtension = True
        openDLG.ReadOnlyChecked = True
        openDLG.AddExtension = True
        openDLG.ReadOnlyChecked = True
        openDLG.Title = "Select the file you want added to the message..."

        If openDLG.ShowDialog = Windows.Forms.DialogResult.OK Then

            txtAttachment.Text = openDLG.FileName

            attach = New System.Net.Mail.Attachment(openDLG.FileName)

        End If
    End Sub

    Private Sub Send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Send.Click
        message = New System.Net.Mail.MailMessage(txtFrom.Text, txtTo.Text, txtSubject.Text, txtMessage.Text)
        If My.Computer.FileSystem.FileExists(txtAttachment.Text) Then _
            message.Attachments.Add(attach)
        smtp.EnableSsl = True
        smtp.Credentials = New System.Net.NetworkCredential(txtUserName.Text, txtPass.Text)
        Try
            smtp.Send(message)
            MessageBox.Show("Well, the mail message appears to have been a success!", "  Successful?", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch exc As Net.Mail.SmtpException
            MessageBox.Show(exc.StatusCode.ToString, "  Something Happened?", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnclose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclose.Click
        Close()
    End Sub
#End Region

End Class