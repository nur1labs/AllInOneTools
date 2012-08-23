#Region "import"
Imports System.IO
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data
Imports System.Data.OleDb
Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Reflection
Imports Microsoft.Win32.SafeHandles
Imports System.ComponentModel
Imports System.Math
Imports AIOTData
Imports O2Killer
#End Region

Public Class BannedCheckRF

#Region "call"
    Public Sub calldata()
        Dim perintah As SqlClient.SqlCommand
        Dim dt As New DataTable
        Try
            perintah = New SqlCommand("SELECT nAccountSerial from tbl_UserBan", ConnUser.conuserc)
            sdbworld = New SqlClient.SqlDataAdapter(perintah)
            dt.Clear()
            sdbworld.Fill(dt)
            Me.DtChar.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Ada ERROR ")
        End Try
    End Sub

    Public Sub calldata1()
        Dim perintah As SqlClient.SqlCommand
        Dim dt As New DataTable
        Try
            perintah = New SqlCommand("SELECT Name,AccountSerial from tbl_base", ConnWorld.conworldc)
            sdbworld = New SqlClient.SqlDataAdapter(perintah)
            dt.Clear()
            sdbworld.Fill(dt)
            Me.DBase.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, " Ada ERROR ")
        End Try
    End Sub

    Private Sub btncls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncls.Click
        Close()
    End Sub

    Private Sub LoadBanned_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBanned.Tick
        calldata()
        calldata1()
        OLStat.Text = DtChar.Rows.Count
    End Sub
#End Region

End Class