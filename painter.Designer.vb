<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class painter
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(painter))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnteprimadiStampaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StampaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImpostaComeSfondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.EsciToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmagineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncollaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CancellaImmagineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElaboraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RidimensionaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.RuotaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GradiToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CapovolgiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrizzontalmenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalmenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.FiltroColoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformazioniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ImmagineToolStripMenuItem, Me.ElaboraToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuovoToolStripMenuItem, Me.ApriToolStripMenuItem, Me.SalvaToolStripMenuItem, Me.ToolStripSeparator1, Me.AnteprimadiStampaToolStripMenuItem, Me.StampaToolStripMenuItem, Me.ToolStripSeparator2, Me.ImpostaComeSfondoToolStripMenuItem, Me.ToolStripSeparator3, Me.EsciToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NuovoToolStripMenuItem
        '
        Me.NuovoToolStripMenuItem.Name = "NuovoToolStripMenuItem"
        Me.NuovoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.NuovoToolStripMenuItem.Text = "&Nuovo..."
        '
        'ApriToolStripMenuItem
        '
        Me.ApriToolStripMenuItem.Name = "ApriToolStripMenuItem"
        Me.ApriToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ApriToolStripMenuItem.Text = "&Apri..."
        '
        'SalvaToolStripMenuItem
        '
        Me.SalvaToolStripMenuItem.Name = "SalvaToolStripMenuItem"
        Me.SalvaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SalvaToolStripMenuItem.Text = "&Salva..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(209, 6)
        '
        'AnteprimadiStampaToolStripMenuItem
        '
        Me.AnteprimadiStampaToolStripMenuItem.Name = "AnteprimadiStampaToolStripMenuItem"
        Me.AnteprimadiStampaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.AnteprimadiStampaToolStripMenuItem.Text = "Anteprima &di stampa..."
        '
        'StampaToolStripMenuItem
        '
        Me.StampaToolStripMenuItem.Name = "StampaToolStripMenuItem"
        Me.StampaToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.StampaToolStripMenuItem.Text = "S&tampa..."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(209, 6)
        '
        'ImpostaComeSfondoToolStripMenuItem
        '
        Me.ImpostaComeSfondoToolStripMenuItem.Name = "ImpostaComeSfondoToolStripMenuItem"
        Me.ImpostaComeSfondoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ImpostaComeSfondoToolStripMenuItem.Text = "&Imposta come sfondo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'EsciToolStripMenuItem
        '
        Me.EsciToolStripMenuItem.Name = "EsciToolStripMenuItem"
        Me.EsciToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.EsciToolStripMenuItem.Text = "&Esci"
        '
        'ImmagineToolStripMenuItem
        '
        Me.ImmagineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TagliaToolStripMenuItem, Me.CopiaToolStripMenuItem, Me.IncollaToolStripMenuItem, Me.ToolStripSeparator4, Me.CancellaImmagineToolStripMenuItem})
        Me.ImmagineToolStripMenuItem.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ImmagineToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ImmagineToolStripMenuItem.Name = "ImmagineToolStripMenuItem"
        Me.ImmagineToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.ImmagineToolStripMenuItem.Text = "&Immagine"
        '
        'TagliaToolStripMenuItem
        '
        Me.TagliaToolStripMenuItem.Name = "TagliaToolStripMenuItem"
        Me.TagliaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.TagliaToolStripMenuItem.Text = "&Taglia"
        '
        'CopiaToolStripMenuItem
        '
        Me.CopiaToolStripMenuItem.Name = "CopiaToolStripMenuItem"
        Me.CopiaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CopiaToolStripMenuItem.Text = "&Copia"
        '
        'IncollaToolStripMenuItem
        '
        Me.IncollaToolStripMenuItem.Name = "IncollaToolStripMenuItem"
        Me.IncollaToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.IncollaToolStripMenuItem.Text = "I&ncolla"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(191, 6)
        '
        'CancellaImmagineToolStripMenuItem
        '
        Me.CancellaImmagineToolStripMenuItem.Name = "CancellaImmagineToolStripMenuItem"
        Me.CancellaImmagineToolStripMenuItem.Size = New System.Drawing.Size(194, 22)
        Me.CancellaImmagineToolStripMenuItem.Text = "Cancella i&mmagine"
        '
        'ElaboraToolStripMenuItem
        '
        Me.ElaboraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RidimensionaToolStripMenuItem, Me.ToolStripSeparator5, Me.RuotaToolStripMenuItem, Me.CapovolgiToolStripMenuItem, Me.ToolStripSeparator6, Me.FiltroColoreToolStripMenuItem})
        Me.ElaboraToolStripMenuItem.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ElaboraToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ElaboraToolStripMenuItem.Name = "ElaboraToolStripMenuItem"
        Me.ElaboraToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ElaboraToolStripMenuItem.Text = "&Elabora"
        '
        'RidimensionaToolStripMenuItem
        '
        Me.RidimensionaToolStripMenuItem.Name = "RidimensionaToolStripMenuItem"
        Me.RidimensionaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RidimensionaToolStripMenuItem.Text = "&Ridimensiona..."
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'RuotaToolStripMenuItem
        '
        Me.RuotaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GradiToolStripMenuItem, Me.GradiToolStripMenuItem1, Me.GradiToolStripMenuItem2})
        Me.RuotaToolStripMenuItem.Name = "RuotaToolStripMenuItem"
        Me.RuotaToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RuotaToolStripMenuItem.Text = "Ruo&ta"
        '
        'GradiToolStripMenuItem
        '
        Me.GradiToolStripMenuItem.Name = "GradiToolStripMenuItem"
        Me.GradiToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.GradiToolStripMenuItem.Text = "90 Gradi"
        '
        'GradiToolStripMenuItem1
        '
        Me.GradiToolStripMenuItem1.Name = "GradiToolStripMenuItem1"
        Me.GradiToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.GradiToolStripMenuItem1.Text = "180 Gradi"
        '
        'GradiToolStripMenuItem2
        '
        Me.GradiToolStripMenuItem2.Name = "GradiToolStripMenuItem2"
        Me.GradiToolStripMenuItem2.Size = New System.Drawing.Size(133, 22)
        Me.GradiToolStripMenuItem2.Text = "270 Gradi"
        '
        'CapovolgiToolStripMenuItem
        '
        Me.CapovolgiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrizzontalmenteToolStripMenuItem, Me.VerticalmenteToolStripMenuItem})
        Me.CapovolgiToolStripMenuItem.Name = "CapovolgiToolStripMenuItem"
        Me.CapovolgiToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CapovolgiToolStripMenuItem.Text = "&Capovolgi"
        '
        'OrizzontalmenteToolStripMenuItem
        '
        Me.OrizzontalmenteToolStripMenuItem.Name = "OrizzontalmenteToolStripMenuItem"
        Me.OrizzontalmenteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.OrizzontalmenteToolStripMenuItem.Text = "&Orizzontalmente"
        '
        'VerticalmenteToolStripMenuItem
        '
        Me.VerticalmenteToolStripMenuItem.Name = "VerticalmenteToolStripMenuItem"
        Me.VerticalmenteToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VerticalmenteToolStripMenuItem.Text = "&Verticalmente"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(159, 6)
        '
        'FiltroColoreToolStripMenuItem
        '
        Me.FiltroColoreToolStripMenuItem.Name = "FiltroColoreToolStripMenuItem"
        Me.FiltroColoreToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.FiltroColoreToolStripMenuItem.Text = "&Filtro colore..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformazioniToolStripMenuItem})
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(23, 20)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'InformazioniToolStripMenuItem
        '
        Me.InformazioniToolStripMenuItem.Name = "InformazioniToolStripMenuItem"
        Me.InformazioniToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InformazioniToolStripMenuItem.Text = "&Informazioni"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Black
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 24)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(610, 423)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 417)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 463)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "0; 0"
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Checked = True
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton1.Image = CType(resources.GetObject("RadioButton1.Image"), System.Drawing.Image)
        Me.RadioButton1.Location = New System.Drawing.Point(187, 453)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "Pencil")
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton2.Image = CType(resources.GetObject("RadioButton2.Image"), System.Drawing.Image)
        Me.RadioButton2.Location = New System.Drawing.Point(225, 453)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton2.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Rubber")
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton3.Image = CType(resources.GetObject("RadioButton3.Image"), System.Drawing.Image)
        Me.RadioButton3.Location = New System.Drawing.Point(263, 453)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton3.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.RadioButton3, "Trim")
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton4.Image = CType(resources.GetObject("RadioButton4.Image"), System.Drawing.Image)
        Me.RadioButton4.Location = New System.Drawing.Point(301, 453)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton4.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.RadioButton4, "Line")
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'RadioButton5
        '
        Me.RadioButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton5.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton5.Image = CType(resources.GetObject("RadioButton5.Image"), System.Drawing.Image)
        Me.RadioButton5.Location = New System.Drawing.Point(339, 453)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton5.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.RadioButton5, "Rectangle")
        Me.RadioButton5.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Bitmap|*.bmp|Gif|*.gif|Icona|*.ico|Jpeg|*.jpg|Png|*.png|Tiff|*.tiff"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Bitmap|*.bmp|Gif|*.gif|Icona|*.ico|Jpeg|*.jpg|Png|*.png|Tiff|*.tiff"
        '
        'ColorDialog1
        '
        Me.ColorDialog1.FullOpen = True
        Me.ColorDialog1.ShowHelp = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'RadioButton6
        '
        Me.RadioButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton6.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RadioButton6.Image = CType(resources.GetObject("RadioButton6.Image"), System.Drawing.Image)
        Me.RadioButton6.Location = New System.Drawing.Point(377, 453)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(32, 32)
        Me.RadioButton6.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.RadioButton6, "Ellipse")
        Me.RadioButton6.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(487, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 20)
        Me.Label3.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.Label3, "Fill Color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click for 'no color'")
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(461, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 20)
        Me.Label2.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.Label2, "Border color" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Right click for 'no color'")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "colornone.png")
        '
        'painter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(610, 497)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "painter"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mini Paint v2.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ApriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents SalvaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnteprimadiStampaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StampaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EsciToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImmagineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CancellaImmagineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElaboraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FiltroColoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CapovolgiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrizzontalmenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalmenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformazioniToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents ImpostaComeSfondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TagliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncollaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents RidimensionaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RuotaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GradiToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList

End Class
