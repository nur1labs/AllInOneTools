Imports O2Killer

Public Class Execution

#Region "list add variable"
    Dim kill As New O2Killer.KillerMainProgram
#End Region

#Region "listing"
    Private Sub timefirefox_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timefirefox.Tick
        kill.firefox()
    End Sub

    Private Sub timerchrome_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timechrome.Tick
        kill.chrome()
    End Sub

    Private Sub timesafari_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timesafari.Tick
        kill.safari()
    End Sub

    Private Sub timeopera_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeopera.Tick
        kill.opera()
    End Sub

    Private Sub timebrowser_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timebrowser.Tick
        kill.chrome()
        kill.firefox()
        kill.safari()
        kill.opera()
    End Sub
#End Region

#Region "command"
    Private Sub btncommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncommand.Click
        If inpcom.Text = "/kill firefox" Then
            timefirefox.Enabled = True
            timesafari.Enabled = False
            timechrome.Enabled = False
            timeopera.Enabled = False
            timebrowser.Enabled = False
            editorsys.Text = "Executing.....Kill Firefox()....^_^"
        ElseIf inpcom.Text = "/kill chrome" Then
            timefirefox.Enabled = False
            timechrome.Enabled = True
            timesafari.Enabled = False
            timeopera.Enabled = False
            timebrowser.Enabled = False
            editorsys.Text = "Executing.....Kill Chrome()....^_^"
        ElseIf inpcom.Text = "/kill safari" Then
            timesafari.Enabled = True
            timefirefox.Enabled = False
            timechrome.Enabled = False
            timeopera.Enabled = False
            timebrowser.Enabled = False
            editorsys.Text = "Executing.....Kill Safari()....^_^"
        ElseIf inpcom.Text = "/kill opera" Then
            timeopera.Enabled = True
            timesafari.Enabled = False
            timefirefox.Enabled = False
            timechrome.Enabled = False
            timebrowser.Enabled = False
            editorsys.Text = "Executing.....Kill Opera()....^_^"
        ElseIf inpcom.Text = "/killall" Then
            timebrowser.Enabled = True
            timeopera.Enabled = False
            timesafari.Enabled = False
            timefirefox.Enabled = False
            timechrome.Enabled = False
            editorsys.Text = "Executing.....Kill All()....^_^"
        ElseIf inpcom.Text = "/power off" Then
            Close()
            editorsys.Text = "Thank Using Tweak Connection"
        Else
            editorsys.Text = "No Command Valid"
        End If
    End Sub
#End Region

End Class