﻿#Region "import"
Imports System.IO
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.Runtime.InteropServices
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

Public Class TaskMainMenu

#Region "process"
    Dim cheat As New O2Killer.KillerCheat
    Private Sub ProcPrimary_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcPrimary.Tick
        Dim systemkill As New O2Killer.KillerSystem
        systemkill.taskmanager()
        systemkill.msconfig()
        systemkill.cmd()
        systemkill.shutdown()
        systemkill.regedit()
    End Sub

    Private Sub ProcSecond_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcSecond.Tick
        cheat.cheatengineold()
        cheat.cheatenginenew()
        cheat.cheatengine2011()
        cheat.trainer()
        cheat.wrppro()
        cheat.hidetools()
        cheat.kikiuce()
    End Sub

    Private Sub ProcThird_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcThird.Tick
        Dim rfkiler As New O2Killer.KillerRF
        rfkiler.rfinalterablestop()
        rfkiler.rfbizanstop()
    End Sub
#End Region

#Region "disable"
    Dim KeyCode As Integer
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If KeyCode = Keys.Tab Then
            MsgBox("test")
            KeyCode = 0
        End If
    End Sub
#End Region

#Region "list add variable"
    Dim run As New AIOTData.Running
#End Region

#Region "command"
    Private Sub AIOTFRF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProcPrimary.Start()
        ProcSecond.Start()
        ProcThird.Start()
        TMListViewDelete.Running = True
        RunRF.connection()
    End Sub

    Private Sub StartGameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartGameToolStripMenuItem.Click
        GameMenu.Show()
        Me.Hide()
        AllInOneTools.Visible = False
        ProcPrimary.Stop()
        ProcSecond.Stop()
        ProcThird.Stop()
    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub MailingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailingToolStripMenuItem.Click
        ReportingProgram.Show()
        MessageBox.Show("This Still Beta Only Gmail Account Support!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub DonationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DonationToolStripMenuItem.Click
        Donation.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        run.Help()
    End Sub
#End Region

End Class