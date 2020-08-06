Public Class fSettings
    Private Sub fSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblErrorLogs.Text = "Error Logs: " & My.Computer.FileSystem.GetFiles(RTU2.rtechapp.logsFilePath).Count
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start(RTU2.rtechapp.logsFilePath)
    End Sub
End Class