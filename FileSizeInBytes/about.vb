Public Class about
    Private Sub about_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblVersion.Text = System.String.Format(lblVersion.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
    End Sub
End Class