Public Class AboutApp

    Private Sub AboutApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Version.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
    End Sub

    Private Sub FecharJanelaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FecharJanelaToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class