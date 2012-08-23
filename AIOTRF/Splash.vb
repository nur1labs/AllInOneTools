Public Class Splash

#Region "load"
    Dim bool As Boolean
    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Membuat form transparan
        Dim i As Double
        For i = 0 To 1 Step 0.001
            Me.Opacity = Math.Abs(i)
        Next
    End Sub

    Private Sub frmtimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frmtimer.Tick
        flashbar.Value += 2
        If flashbar.Value = 98 Then
            AIOTFRF.Show()
        End If
        If flashbar.Value = 100 Then
            frmtimer.Dispose()
            Me.Visible = False
        End If
    End Sub
#End Region
  
End Class