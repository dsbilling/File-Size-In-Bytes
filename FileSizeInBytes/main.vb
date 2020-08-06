Imports System.Text.RegularExpressions
Public Class main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Title = "Open a file"
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Try
            tsslStatus.Text = ""
            tbFile.Text = OpenFileDialog1.FileName
            Dim fileDetail As IO.FileInfo
            fileDetail = My.Computer.FileSystem.GetFileInfo(tbFile.Text)
            tbB.Text = fileDetail.Length

            If CDbl(tbKB.Text.ToString) > 1 Then
                tbMB.Text = tbKB.Text / 1024
            Else
                tbMB.Text = 0
            End If

            If CDbl(tbMB.Text.ToString) > 1 Then
                tbGB.Text = tbMB.Text / 1024
            Else
                tbGB.Text = 0
            End If

            If CDbl(tbGB.Text.ToString) > 1 Then
                tbTB.Text = tbGB.Text / 1024
            Else
                tbTB.Text = 0
            End If

            Dim sizes As String() = {"B", "KB", "MB", "GB", "TB"}
            Dim len As Double = fileDetail.Length
            Dim order As Integer = 0
            While len >= 1024 AndAlso order + 1 < sizes.Length
                order += 1
                len = len / 1024
            End While
            ' Adjust the format string to your preferences. For example "{0:0.#}{1}" would
            ' show a single decimal place, and no space.
            Dim result As String = [String].Format("{0:0.##} {1}", len, sizes(order))
            Label3.Text = result
        Catch ex As Exception
            RTU2.rtecherror.reportError(ex.Message, ex.ToString, MsgBoxStyle.Critical, False)
        End Try
    End Sub
    Private Sub tbFile_MouseDown(sender As Object, e As MouseEventArgs) Handles tbFile.MouseDown
        btnBrowse.PerformClick()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            tsslStatus.Text = ""
            If tbB.Text <> "" Then
                If Regex.IsMatch(tbB.Text, "^[0-9 ]+$") Then
                    tbKB.Text = tbB.Text / 1024

                    If CDbl(tbKB.Text.ToString) > 1 Then
                        tbMB.Text = tbKB.Text / 1024
                    Else
                        tbMB.Text = 0
                    End If

                    If CDbl(tbMB.Text.ToString) > 1 Then
                        tbGB.Text = tbMB.Text / 1024
                    Else
                        tbGB.Text = 0
                    End If

                    If CDbl(tbGB.Text.ToString) > 1 Then
                        tbTB.Text = tbGB.Text / 1024
                    Else
                        tbTB.Text = 0
                    End If

                    Dim sizes As String() = {"B", "KB", "MB", "GB", "TB"}
                    Dim len As Double = tbB.Text
                    Dim order As Integer = 0
                    While len >= 1024 AndAlso order + 1 < sizes.Length
                        order += 1
                        len = len / 1024
                    End While
                    ' Adjust the format string to your preferences. For example "{0:0.#}{1}" would
                    ' show a single decimal place, and no space.
                    Dim result As String = [String].Format("{0:0.##} {1}", len, sizes(order))
                    Label3.Text = result
                Else
                    tsslStatus.Text = "Text is not allowed."
                End If
            Else
                tsslStatus.Text = "Please enter a number."
            End If
        Catch ex As Exception
            RTU2.rtecherror.reportError(ex.Message, ex.ToString, MsgBoxStyle.Critical, False)
        End Try
    End Sub
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        fSettings.ShowDialog()
    End Sub
    Private Sub CheckForUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdateToolStripMenuItem.Click
        Process.Start("https://github.com/DanielRTRD/FSIB/releases")
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        about.ShowDialog()
    End Sub
    Private Sub ReportABugToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportABugToolStripMenuItem.Click
        Process.Start("https://github.com/DanielRTRD/FSIB/issues/new")
    End Sub
    Private Sub HomepageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomepageToolStripMenuItem.Click
        Process.Start("https://github.com/DanielRTRD/FSIB")
    End Sub
    Private Sub DocumentationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Process.Start("https://github.com/DanielRTRD/FSIB")
    End Sub
    Private Sub SupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupportToolStripMenuItem.Click
        Process.Start("https://infihex.com/")
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        RTU2.rtechapp.ApplicationShutdown()
    End Sub
    Private Sub tsslStatus_Click(sender As Object, e As EventArgs) Handles tsslStatus.Click
        If tsslStatus.IsLink = True Then
            Process.Start("https://github.com/DanielRTRD/FSIB")
        End If
    End Sub
    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel1.Click
        Process.Start("https://infihex.com/")
    End Sub
End Class