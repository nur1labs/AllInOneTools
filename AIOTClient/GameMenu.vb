Public Class GameMenu

#Region "command"
    Private Sub btnclosed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclosed.Click
        TaskMainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub rflinks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rflinks.Click
        Dim AIOTRF As New AIOTData.Running
        AIOTRF.Openinal()
    End Sub
#End Region

End Class