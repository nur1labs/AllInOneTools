Public Class FrmSplash

#Region "load"
    Dim bool As Boolean
    Private Sub FrmSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Membuat form transparan
        Dim i As Double
        For i = 0 To 1 Step 0.001
            Me.Opacity = Math.Abs(i)
        Next
    End Sub

    Private Sub frmtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmtimer.Tick
        flashbar.Value += 2

        If flashbar.Value <= 10 Then

            flashlb.Text = "Initialization......."

        ElseIf flashbar.Value <= 20 Then

            flashlb.Text = "Load AIOTC.exe........"

        ElseIf flashbar.Value <= 30 Then

            flashlb.Text = "Load Library........"

        ElseIf flashbar.Value <= 40 Then

            flashlb.Text = "Secure Data........"

        ElseIf flashbar.Value <= 50 Then

            flashlb.Text = "Looking Patcher.exe........"

        ElseIf flashbar.Value <= 60 Then

            flashlb.Text = "Checking Files ........"

        ElseIf flashbar.Value <= 70 Then

            flashlb.Text = "Read Libary....."

        ElseIf flashbar.Value <= 80 Then

            flashlb.Text = "Welcome AIOTClient The Secure Program ^_^"

        End If
        If flashbar.Value = 98 Then
            Agreement.Show()
        End If
        If flashbar.Value = 100 Then
            frmtimer.Dispose()
            Me.Visible = False
        End If
    End Sub
#End Region

End Class
