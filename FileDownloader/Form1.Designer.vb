<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AppProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DownloadButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.URLComboBox = New System.Windows.Forms.ComboBox()
        Me.AppStatus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileDownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreOFileDownloderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncerrarFileDownloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppProgressBar
        '
        Me.AppProgressBar.Location = New System.Drawing.Point(77, 210)
        Me.AppProgressBar.Name = "AppProgressBar"
        Me.AppProgressBar.Size = New System.Drawing.Size(331, 10)
        Me.AppProgressBar.TabIndex = 0
        '
        'DownloadButton
        '
        Me.DownloadButton.Location = New System.Drawing.Point(397, 226)
        Me.DownloadButton.Name = "DownloadButton"
        Me.DownloadButton.Size = New System.Drawing.Size(75, 23)
        Me.DownloadButton.TabIndex = 1
        Me.DownloadButton.Text = "Download..."
        Me.DownloadButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(187, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'URLComboBox
        '
        Me.URLComboBox.FormattingEnabled = True
        Me.URLComboBox.Location = New System.Drawing.Point(77, 183)
        Me.URLComboBox.Name = "URLComboBox"
        Me.URLComboBox.Size = New System.Drawing.Size(331, 21)
        Me.URLComboBox.TabIndex = 3
        '
        'AppStatus
        '
        Me.AppStatus.AutoSize = True
        Me.AppStatus.Location = New System.Drawing.Point(74, 223)
        Me.AppStatus.Name = "AppStatus"
        Me.AppStatus.Size = New System.Drawing.Size(164, 13)
        Me.AppStatus.TabIndex = 4
        Me.AppStatus.Text = "Preparando para baixar arquivo..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Insira a URL do arquivo que deseja baixar:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileDownloaderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileDownloaderToolStripMenuItem
        '
        Me.FileDownloaderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreOFileDownloderToolStripMenuItem, Me.EncerrarFileDownloaderToolStripMenuItem})
        Me.FileDownloaderToolStripMenuItem.Name = "FileDownloaderToolStripMenuItem"
        Me.FileDownloaderToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.FileDownloaderToolStripMenuItem.Text = "FileDownloader"
        '
        'SobreOFileDownloderToolStripMenuItem
        '
        Me.SobreOFileDownloderToolStripMenuItem.Name = "SobreOFileDownloderToolStripMenuItem"
        Me.SobreOFileDownloderToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.SobreOFileDownloderToolStripMenuItem.Text = "Sobre o FileDownloder"
        '
        'EncerrarFileDownloaderToolStripMenuItem
        '
        Me.EncerrarFileDownloaderToolStripMenuItem.Name = "EncerrarFileDownloaderToolStripMenuItem"
        Me.EncerrarFileDownloaderToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.EncerrarFileDownloaderToolStripMenuItem.Text = "Encerrar FileDownloader"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AppStatus)
        Me.Controls.Add(Me.URLComboBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DownloadButton)
        Me.Controls.Add(Me.AppProgressBar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 300)
        Me.MinimumSize = New System.Drawing.Size(500, 300)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileDownloader"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AppProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents DownloadButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents URLComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents AppStatus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileDownloaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreOFileDownloderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncerrarFileDownloaderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
