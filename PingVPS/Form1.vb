Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Process.Start("cmd", "/k required\PingVPS_batch.bat")
    End Sub
End Class
