Imports System.IO
Imports System.Net
'https: //pbs.twimg.com/profile_images/1346142638974484482/FEtyMv8z_400x400.png
Public Class MySystem
    Public DocumentsPath = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\Bisneto\FileDownloader\"
    Public NomeArquivo = ""
    Public Sub CheckLocation()
        If Directory.Exists(DocumentsPath) Then

        Else
            Directory.CreateDirectory(DocumentsPath)
        End If
        Console.WriteLine(DocumentsPath)
    End Sub
    Public Sub Downloader()
        Form1.URLComboBox.Enabled = False
        Form1.DownloadButton.Enabled = False
        Dim URL As String = Form1.URLComboBox.Text

        Dim Palavras As String() = URL.Split(New Char() {"/"c})
        Dim Palavra As String

        For Each Palavra In Palavras
            Console.WriteLine(Palavra)
        Next

        NomeArquivo = Palavra
        Console.WriteLine("Palavra: " & NomeArquivo)

        Form1.AppProgressBar.Style = ProgressBarStyle.Marquee
        Form1.AppProgressBar.Visible = True
        Form1.AppStatus.Visible = True

        Try
            Dim wc As New WebClient
            AddHandler wc.DownloadProgressChanged, AddressOf DownloadProgressChangedSL
            AddHandler wc.DownloadFileCompleted, AddressOf DownloadFileCompletedSL
            wc.DownloadFileAsync(New System.Uri(URL), DocumentsPath & NomeArquivo)
        Catch ex As Exception
            Form1.AppProgressBar.Value = 0
            Form1.AppProgressBar.Visible = False
            Form1.AppStatus.Visible = False
            Form1.URLComboBox.Enabled = True
            Form1.DownloadButton.Enabled = True
            MessageBox.Show("Não foi possível iniciar o download", "Fala no Download", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub DownloadProgressChangedSL(sender As Object, e As DownloadProgressChangedEventArgs)
        Form1.AppProgressBar.Style = ProgressBarStyle.Continuous
        Dim SizeReceived = e.BytesReceived
        Dim TotalSizeToReceive = e.TotalBytesToReceive
        Dim FileSizeLabel = String.Format("{0} MB", (TotalSizeToReceive / 1024 / 1024).ToString("0.00"))
        Form1.AppProgressBar.Value = e.ProgressPercentage
        Form1.AppStatus.Text = String.Format("Baixando arquivo: {0} MB", (SizeReceived / 1024 / 1024).ToString("0.00")) & " / " & FileSizeLabel & " (" & e.ProgressPercentage & "%)"
    End Sub

    Public Sub DownloadFileCompletedSL(sender As Object, e As EventArgs)
        Form1.AppProgressBar.Value = "0"
        Form1.AppProgressBar.Visible = False
        Form1.AppStatus.Text = "Arquivo baixado com sucesso!"
        Form1.URLComboBox.Text = ""
        Form1.URLComboBox.Enabled = True
        Form1.DownloadButton.Enabled = True
    End Sub
End Class
