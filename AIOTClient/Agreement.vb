Public Class Agreement

#Region "load"
    Private Sub Agreement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ESP.ForeColor = Color.Green
    End Sub
#End Region

#Region "command"
    Private Sub BtnAgree_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgree.Click
        TaskMainMenu.Show()
        Me.Hide()
        MessageBox.Show("TO Using This Fuction Properly Put Your Game Files To On Category BBMGC/[Game Category] Or You Can't Play", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        End
    End Sub
#End Region
    
End Class