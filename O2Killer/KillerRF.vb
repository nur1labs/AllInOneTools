Public Class KillerRF

#Region "mainkill"
    Sub rfinalterablestop()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "rf" Then
                proc.Kill()
            End If
        Next
    End Sub

    Sub rfbizanstop()
        For Each proc As Process In Process.GetProcesses
            If proc.ProcessName = "bizantium" Then
                proc.Kill()
            End If
        Next
    End Sub
#End Region

End Class
