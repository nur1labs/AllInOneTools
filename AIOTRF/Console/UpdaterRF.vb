Public Class UpdaterRF

#Region "load"
    Dim bool As Boolean
    Private Sub loadtime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadtime.Tick
        barload.Value += 2

        If barload.Value <= 10 Then

            lblload.Text = "Initialization......."

        ElseIf barload.Value <= 20 Then

            lblload.Text = "Load Http........"

        ElseIf barload.Value <= 30 Then

            lblload.Text = "Load Https........"

        ElseIf barload.Value <= 40 Then

            lblload.Text = "Secure Port........"

        ElseIf barload.Value <= 50 Then

            lblload.Text = "Looking Up Ftp Port........"

        ElseIf barload.Value <= 60 Then

            lblload.Text = "Checking Files ........"
            MessageBox.Show("Missing Update.o2up", "Failure!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            BtnOk.Text = "Failure"

        ElseIf barload.Value <= 70 Then

            lblload.Text = "Read Data Updater.exe....."

        ElseIf barload.Value <= 80 Then

            lblload.Text = "Ready For Patch ^_^"

        End If
        If barload.Value = 99 Then
            BtnOk.Text = "Patch"
        End If
        If barload.Value = 100 Then
            loadtime.Dispose()
        End If
    End Sub

    Sub timepatch()

    End Sub

#End Region

#Region "command"
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If BtnOk.Text = "Patch" Then
            updatertime.Enabled = True
            timepatch()
            AIOTFRF.AllInOneTools.ShowBalloonTip(500, "Patching", "Patching On Progress", ToolTipIcon.Info)
        ElseIf BtnOk.Text = "Ok" Then
            MessageBox.Show("Update Already Finished", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
            AIOTFRF.AllInOneTools.ShowBalloonTip(500, "Ready", "Ready For Patch", ToolTipIcon.Info)
        Else
            MessageBox.Show("Update Failure", "Failure!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
            AIOTFRF.AllInOneTools.ShowBalloonTip(500, "Warning", "Some Missing File System Try Update Programs", ToolTipIcon.Info)
        End If
    End Sub

    Private Sub Updater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BtnOk.Text = "Ok"
    End Sub
#End Region

End Class