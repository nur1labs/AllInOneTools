Public Class About

#Region "command"
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Close()
    End Sub

    Private Sub link_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles link.Click
        StaffMakerRF.Show()
        Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        'Jalankan browser web default dan link ke situs web
        System.Diagnostics.Process.Start _
            ("http://www.bbmgc.ru/")
    End Sub
#End Region

End Class