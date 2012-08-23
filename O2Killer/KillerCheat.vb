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
Imports System.ComponentModel
Imports System.Threading
Imports System.Threading.Tasks
Imports AIOTClient
#End Region

Public Class KillerCheat

#Region "cheat"
    Sub cheatenginenew()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "cheatengine-i386" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub cheatengineold()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "Cheat Engine" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub cheatengine2011()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "Cheat_Engine" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub wrppro()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "WPE PRO –Modified" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub trainer()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "Trainer Inalterable" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub hidetools()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "hidetoolz" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub kikiuce()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "Kiki’s UCE" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub olly()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "OLLYDBG" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub rfbonex()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "RF[Bonek_Jancok]" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub rf_online()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "RF_Online" Then
                proc.Kill()
            End If
        Next
    End Sub
#End Region

End Class
