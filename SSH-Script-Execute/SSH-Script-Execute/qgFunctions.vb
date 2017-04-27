Imports System.ComponentModel

Public Class qgFunctions

    Public Sub KillAllProcessesByName(ByVal processName As String)
        For Each p As Process In System.Diagnostics.Process.GetProcessesByName(processName)
            Try
                p.Kill()
                ' possibly with a timeout
                p.WaitForExit()
                ' process was terminating or can't be terminated - deal with it
            Catch winException As Win32Exception
                ' process has already exited - might be able to let this one go
            Catch invalidException As InvalidOperationException
            End Try
        Next
    End Sub


End Class
