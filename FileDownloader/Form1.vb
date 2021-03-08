Public Class Form1

    Public MySystem As MySystem = New MySystem()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppProgressBar.Visible = False
        AppStatus.Visible = False
        MySystem.CheckLocation()
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        MySystem.Downloader()
        If URLComboBox.Text = "" Or String.IsNullOrEmpty(URLComboBox.Text) Then
        Else
            URLComboBox.Items.Add(URLComboBox.Text)
        End If
    End Sub

    Private Sub SobreOFileDownloderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreOFileDownloderToolStripMenuItem.Click
        AboutApp.Show()
    End Sub

    Private Sub EncerrarFileDownloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarFileDownloaderToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
