<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutApp))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Version = New System.Windows.Forms.TextBox()
        Me.ProductLabel = New System.Windows.Forms.TextBox()
        Me.AppIcon = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FecharJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(12, 206)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ShortcutsEnabled = False
        Me.TextBox1.Size = New System.Drawing.Size(260, 49)
        Me.TextBox1.TabIndex = 34
        Me.TextBox1.TabStop = False
        Me.TextBox1.Text = "© 2021 Bisneto Inc." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Todos os direitos reservados."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Version
        '
        Me.Version.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Version.BackColor = System.Drawing.Color.White
        Me.Version.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Version.CausesValidation = False
        Me.Version.Font = New System.Drawing.Font("Calibri", 10.0!)
        Me.Version.Location = New System.Drawing.Point(12, 183)
        Me.Version.Name = "Version"
        Me.Version.ReadOnly = True
        Me.Version.ShortcutsEnabled = False
        Me.Version.Size = New System.Drawing.Size(260, 17)
        Me.Version.TabIndex = 33
        Me.Version.TabStop = False
        Me.Version.Text = "Versão 1.0.0.0"
        Me.Version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProductLabel
        '
        Me.ProductLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductLabel.BackColor = System.Drawing.Color.White
        Me.ProductLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProductLabel.CausesValidation = False
        Me.ProductLabel.Font = New System.Drawing.Font("Calibri", 15.0!)
        Me.ProductLabel.Location = New System.Drawing.Point(12, 152)
        Me.ProductLabel.Name = "ProductLabel"
        Me.ProductLabel.ReadOnly = True
        Me.ProductLabel.ShortcutsEnabled = False
        Me.ProductLabel.Size = New System.Drawing.Size(260, 25)
        Me.ProductLabel.TabIndex = 32
        Me.ProductLabel.TabStop = False
        Me.ProductLabel.Text = "FileDownloader"
        Me.ProductLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AppIcon
        '
        Me.AppIcon.Image = CType(resources.GetObject("AppIcon.Image"), System.Drawing.Image)
        Me.AppIcon.Location = New System.Drawing.Point(12, 18)
        Me.AppIcon.Name = "AppIcon"
        Me.AppIcon.Size = New System.Drawing.Size(260, 128)
        Me.AppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AppIcon.TabIndex = 31
        Me.AppIcon.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharJanelaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FecharJanelaToolStripMenuItem
        '
        Me.FecharJanelaToolStripMenuItem.Name = "FecharJanelaToolStripMenuItem"
        Me.FecharJanelaToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.FecharJanelaToolStripMenuItem.Size = New System.Drawing.Size(98, 20)
        Me.FecharJanelaToolStripMenuItem.Text = "Fechar Janela..."
        '
        'AboutApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.ProductLabel)
        Me.Controls.Add(Me.AppIcon)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "AboutApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sobre FileDownloader"
        CType(Me.AppIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Public WithEvents Version As System.Windows.Forms.TextBox
    Public WithEvents ProductLabel As System.Windows.Forms.TextBox
    Friend WithEvents AppIcon As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FecharJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
