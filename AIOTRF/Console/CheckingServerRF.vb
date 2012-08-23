Imports System.Data.SqlClient

Public Class CheckingServerRF

#Region "check"
    Sub user()
        Try
            ConnUser.conuserc.Open()
            remacc.Text = "Open"
            remacc.ForeColor = Color.Blue
            ConnUser.conuserc.Close()
        Catch ex As Exception
            remacc.Text = "Closed"
            remacc.ForeColor = Color.Red
        End Try
    End Sub

    Sub billing()
        Try
            ConnBilling.conbillc.Open()
            rembill.Text = "Open"
            rembill.ForeColor = Color.Blue
            ConnBilling.conbillc.Close()
        Catch ex As Exception
            rembill.Text = "Closed"
            rembill.ForeColor = Color.Red
        End Try
    End Sub

    Sub world()
        Try
            ConnWorld.conworldc.Open()
            remworld.Text = "Open"
            remworld.ForeColor = Color.Blue
            ConnWorld.conworldc.Close()
        Catch ex As Exception
            remworld.Text = "Closed"
            remworld.ForeColor = Color.Red
        End Try
    End Sub

    Sub check()
        user()
        billing()
        world()
    End Sub
#End Region

#Region "load"
    Private Sub Checking_Server_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        check()
    End Sub

    Private Sub Checking_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checking.Tick
        Refresh()
        check()
    End Sub
#End Region

#Region "command"
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        Close()
    End Sub
#End Region

End Class