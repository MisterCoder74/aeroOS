Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports System.IO

Public Class painter
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer ' Per impostare lo sfondo del desktop

    Public Image As Bitmap = New Bitmap(600, 400) ' Immagine bitmap

    Private StartPoint As Point ' Punto di inizio oggetto
    Private EndPoint As Point ' Punto di fine oggetto
    Private Drawing As Boolean ' Indica se si sta disegnando
    Private BorderColor As Color = Color.Black ' Colore dei bordi
    Private FillColor As Color = Color.White ' Colore di riempimento

#Region "Strumenti"

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Mode = Tools.Pencil ' Matita
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Mode = Tools.Rubber ' Gomma
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Mode = Tools.Cutter ' Ritaglio
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Mode = Tools.Line ' Linea
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        Mode = Tools.Rectangle ' Rettangolo
    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged
        Mode = Tools.Ellipse ' Ellisse
    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Try
            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative2" Then
                    Me.BackgroundImage = My.Resources.alternative2
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative3" Then
                    Me.BackgroundImage = My.Resources.alternative3
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative4" Then
                    Me.BackgroundImage = My.Resources.alternative4
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative5" Then
                    Me.BackgroundImage = My.Resources.alternative5
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If
            Loop
            sr.Close()
        Catch ex As Exception
        End Try


        SetImageBackground(Color.White) ' Chiama la funzione per impostare lo sfondo dell'immagine
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True) ' Imposta il double buffer
        Me.UpdateStyles()
    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim Rectangle As Rectangle = New Rectangle(0, 0, Me.Width, Me.Height) ' Dimensioni sfondo form
        Dim Brush As LinearGradientBrush = New LinearGradientBrush(Rectangle, Color.LightSkyBlue, Color.LightCyan, LinearGradientMode.BackwardDiagonal) ' Gradiente diagonale

        e.Graphics.FillRectangle(Brush, Rectangle) ' Disegna lo sfondo gradiente del form
        e.Dispose() ' Rilascia le risorse utilizzate

    End Sub



    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        Drawing = True ' Inizio disegno
        StartPoint.X = e.X ' Coordinate mouse
        StartPoint.Y = e.Y
        EndPoint.X = e.X
        EndPoint.Y = e.Y
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        Label1.Text = e.X & "; " & e.Y ' Posizione cursore

        If Not Drawing Then Exit Sub ' Se non si sta disegnando

        EndPoint.X = e.X ' Coordinate mouse
        EndPoint.Y = e.Y

        Select Case Mode
            Case Tools.Pencil ' Matita
                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dall'immagine
                g.DrawLine(New Pen(BorderColor), StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y) ' Disegna una linea
                g.Dispose() ' Rilascia le risorse utilizzate
                StartPoint.X = EndPoint.X
                StartPoint.Y = EndPoint.Y
            Case Tools.Rubber ' Gomma
                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dall'immagine
                g.FillEllipse(Brushes.White, EndPoint.X - 5, EndPoint.Y - 5, 10, 10) ' Disegna un'ellisse con riempimento bianca
                g.Dispose() ' Rilascia le risorse utilizzate
        End Select

        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp

        Drawing = False ' Fine del disegno

        Select Case Mode
            Case Tools.Cutter

                If Not ((EndPoint.X - StartPoint.X) <= 0 Or (EndPoint.Y - StartPoint.Y) <= 0) Then ' In caso il rettangolo non abbia una larghezza o una altezza

                    Dim ImageResize As Bitmap = New Bitmap((EndPoint.X - StartPoint.X), (EndPoint.Y - StartPoint.Y)) ' Immagine ridimensionata
                    Dim g As Graphics = Graphics.FromImage(ImageResize) ' Grafica dell'immagine per disegnare su essa

                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                    g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                    g.DrawImage(Image, 0, 0, New Rectangle(StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y), GraphicsUnit.Pixel) ' Ritaglia parte dell'immagine
                    g.Dispose() ' Rilascia le risorse utilizzate

                    Image = ImageResize ' Aggiorna l'immagine principale
                    PictureBox1.Size = New Point(ImageResize.Width, ImageResize.Height) ' Ridimensiona la picturebox
                    PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

                End If

            Case Tools.Line
                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
                g.DrawLine(New Pen(BorderColor), StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y) ' Disegna la linea
                g.Dispose() ' Rilascia le risorse utilizzate
            Case Tools.Rectangle
                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
                g.FillRectangle(New SolidBrush(FillColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna il riempimento del rettangolo
                g.DrawRectangle(New Pen(BorderColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna i bordi del rettangolo
                g.Dispose() ' Rilascia le risorse utilizzate
            Case Tools.Ellipse
                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
                g.FillEllipse(New SolidBrush(FillColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna il riempimento dell'ellisse
                g.DrawEllipse(New Pen(BorderColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna i bordi dell'ellisse
                g.Dispose() ' Rilascia le risorse utilizzate
        End Select

        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint

        e.Graphics.Clear(PictureBox1.BackColor) ' Pulisce la grafica della picturebox
        e.Graphics.DrawImage(Image, New Point(0, 0)) ' Disegna l'immagine memorizzata

        If Drawing Then ' Se si sta disegnando

            Select Case Mode
                Case Tools.Cutter

                    If Not ((EndPoint.X - StartPoint.X) <= 0 Or (EndPoint.Y - StartPoint.Y) <= 0) Then ' In caso il rettangolo non abbia una larghezza o una altezza

                        Dim CutterPen As New Pen(Color.Violet, 1) ' Penna utilizzata per indicare l'area di ritaglio

                        CutterPen.DashStyle = Drawing2D.DashStyle.Dash ' Stile penna a tratti

                        e.Graphics.DrawRectangle(CutterPen, StartPoint.X, StartPoint.Y, (EndPoint.X - StartPoint.X), (EndPoint.Y - StartPoint.Y)) ' Disegna il rettangolo che indica l'area del ritaglio

                        CutterPen.Dispose() ' Rilascia le risorse utilizzate

                    End If

                Case Tools.Line
                    e.Graphics.DrawLine(New Pen(BorderColor), StartPoint.X, StartPoint.Y, EndPoint.X, EndPoint.Y) ' Disegna la linea
                Case Tools.Rectangle
                    e.Graphics.FillRectangle(New SolidBrush(FillColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna il riempimento del rettangolo
                    e.Graphics.DrawRectangle(New Pen(BorderColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna i bordi del rettangolo
                Case Tools.Ellipse
                    e.Graphics.FillEllipse(New SolidBrush(FillColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna il riempimento dell'ellisse
                    e.Graphics.DrawEllipse(New Pen(BorderColor), Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), Math.Abs(StartPoint.X - EndPoint.X), Math.Abs(StartPoint.Y - EndPoint.Y)) ' Disegna i bordi dell'ellisse
            End Select

        End If

    End Sub

    Private Sub NuovoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuovoToolStripMenuItem.Click
        newimage.ShowDialog() ' Nuova immagine
        newimage.Dispose() ' Rilascia le risorse utilizzate dalla finestra di dialogo
    End Sub

    Private Sub ApriToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApriToolStripMenuItem.Click

        Try

            If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto di aprire un file

                Dim Img As Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName) ' Carica l'immagine
                Image = New Bitmap(Image.Width, Img.Height) ' Crea una nuova immaggine con quella scelta

                Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
                g.DrawImage(Img, 0, 0) ' Disegna l'immagine caricata sulla bitmap
                g.Dispose() ' Rilascia le risorse utilizzate

                PictureBox1.Size = New Point(Image.Width, Image.Height) ' Aggiorna le dimensioni della picturebox
                PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
                OpenFileDialog1.Dispose() ' Rilascia le risorse utilizzate dalla finestra di dialogo

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SalvaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaToolStripMenuItem.Click

        Try

            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto di salvare il file

                Select Case SaveFileDialog1.FilterIndex
                    Case 0 ' Bitmap
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Bmp) ' Salva l'immagine Bitmap
                    Case 1 ' Gif
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Gif) ' Salva l'immagine Gif
                    Case 2 ' Icona
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Icon) ' Salva l'immagine Icona
                    Case 3 ' Jpeg
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Jpeg) ' Salva l'immagine Jpeg
                    Case 4 ' Png
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Png) ' Salva l'immagine Png
                    Case 5 ' Tiff
                        Image.Save(SaveFileDialog1.FileName, ImageFormat.Tiff) ' Salva l'immagine Tiff
                End Select

                SaveFileDialog1.Dispose() ' Rilascia le risorse utilizzate dalla finestra di dialogo

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub AnteprimadiStampaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnteprimadiStampaToolStripMenuItem.Click
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintGraphic
        PrintPreviewDialog1.Document = PrintDocument1 ' Imposta il documento da visualizzare
        PrintPreviewDialog1.ShowDialog() ' Apre la finestra di dialogo
    End Sub

    Private Sub StampaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StampaToolStripMenuItem.Click

        Try

            If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si ha scelto di stampare
                PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings ' Impostazioni di stampa
                AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintGraphic
                PrintDocument1.Print() ' Lancia la stampa
            Else
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ImpostaComeSfondoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImpostaComeSfondoToolStripMenuItem.Click

        Dim ImagePath As String ' Path del file immagine

        Try
            ImagePath = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData, "Temp.bmp")
            Image.Save(ImagePath, ImageFormat.Bmp) ' Salva l'immagine
            SystemParametersInfo(20, 0, ImagePath, &H1) ' Imposta lo sfondo del desktop
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        Application.Exit() ' Esce
    End Sub

    Private Sub TagliaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TagliaToolStripMenuItem.Click

        Try
            Clipboard.SetImage(Image) ' Copia in memoria l'immagine
            Image = New Bitmap(Image.Width, Image.Height) ' Pulisce l'immagine
            PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CopiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiaToolStripMenuItem.Click

        Try
            Clipboard.SetImage(Image) ' Copia in memoria l'immagine
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub IncollaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncollaToolStripMenuItem.Click

        Try

            Dim Img As Image = Nothing ' Immagine da incollare

            If Clipboard.ContainsImage() Then ' Se ci sono delle immagini in memoria
                Img = Clipboard.GetImage() ' Immagine da incollare
            Else
                MessageBox.Show("Nessuna immagine da incollare in memoria!", "Informazioni", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub ' Esce dalla sub
            End If

            If Image.Width < Img.Width Or Image.Height < Img.Height Then ' In caso l'immagine incollata è più grande della immagine su cui stiamo disegnando

                Dim TempImage As Bitmap = Image ' Copia temporanea dell'immagine

                Image = New Bitmap(Img.Width, Img.Height) ' Ridimensiona l'immagine principale
                PictureBox1.Size = New Point(Img.Width, Img.Height) ' Ridimensiona la picturebox

                Dim g1 As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
                g1.DrawImage(TempImage, 0, 0) ' Disegna la copia dell'immagine
                g1.Dispose() ' Rilascia le risorse utilizzate

                TempImage.Dispose() ' Rilascia le risorse utilizzate

            End If

            Dim g2 As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
            g2.DrawImage(Img, 0, 0) ' Incolla l'immagine da incollare
            g2.Dispose() ' Rilascia le risorse utilizzate

            PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub CancellaImmagineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancellaImmagineToolStripMenuItem.Click

        If MessageBox.Show("Sei sicuro di volere cancellare l'immagine?", "Conferma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then ' Chiede conferma
            Image = New Bitmap(Image.Width, Image.Height) ' Pulisce l'immagine
            SetImageBackground(Color.White) ' Chiama la funzione per impostare lo sfondo dell'immagine
            PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
        End If

    End Sub

    Private Sub RidimensionaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RidimensionaToolStripMenuItem.Click
        resizeimage.ShowDialog() ' Apre il form per ridimensionare l'immagine
        resizeimage.Dispose() ' Rilascia le risorse utilizzate
    End Sub

    Private Sub GradiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradiToolStripMenuItem.Click
        Image.RotateFlip(RotateFlipType.Rotate90FlipNone) ' Routa l'immagine di 90 gradi
        PictureBox1.Size = New Point(Image.Width, Image.Height) ' Ridimensiona la picturebox
        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
    End Sub

    Private Sub GradiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradiToolStripMenuItem1.Click
        Image.RotateFlip(RotateFlipType.Rotate180FlipNone) ' Routa l'immagine di 180 gradi
        PictureBox1.Size = New Point(Image.Width, Image.Height) ' Ridimensiona la picturebox
        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
    End Sub

    Private Sub GradiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradiToolStripMenuItem2.Click
        Image.RotateFlip(RotateFlipType.Rotate270FlipNone) ' Routa l'immagine di 270 gradi
        PictureBox1.Size = New Point(Image.Width, Image.Height) ' Ridimensiona la picturebox
        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
    End Sub

    Private Sub OrizzontalmenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrizzontalmenteToolStripMenuItem.Click
        Image.RotateFlip(RotateFlipType.Rotate180FlipY) ' Routa l'immagine di 180 gradi sull'asse Y
        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
    End Sub

    Private Sub VerticalmenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalmenteToolStripMenuItem.Click
        Image.RotateFlip(RotateFlipType.Rotate180FlipX) ' Routa l'immagine di 180 gradi sull'asse X
        PictureBox1.Invalidate() ' Obbliga un refresh della picturebox
    End Sub

    Private Sub FiltroColoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FiltroColoreToolStripMenuItem.Click

        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto un colore

            Dim TransparentBrush As New SolidBrush(Color.FromArgb(100, ColorDialog1.Color)) ' Colore trasparente

            Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
            g.FillRectangle(TransparentBrush, 0, 0, Image.Width, Image.Height) ' Disegna un rettangolo semitrasparente
            g.Dispose() ' Rilascia le risorse utilizzate

            PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

        End If

    End Sub

    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniToolStripMenuItem.Click
        MessageBox.Show("   Mini Paint v2.0" & Chr(10) & Chr(10) & _
                        "Programmazione:   Francesco Bev****o '96" & Chr(10) & _
                        "Progettazione:       Francesco Bev****o '96" & Chr(10) & _
                        "Data di rilascio:      28/10/2009" & Chr(10) & Chr(10) & _
                        "http://arkimedeblog.wordpress.com/", "Informazioni", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then ' Tasto sinistro

            If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto un colore
                Label2.BackColor = ColorDialog1.Color ' Imposta il colore dello sfondo della label
                BorderColor = ColorDialog1.Color ' Imposta il colore dei bordi dell'oggetto
                Label2.Image = Nothing ' Nessuna immagine
            End If

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            BorderColor = Color.Transparent ' Colore dei bordi trasparente
            Label2.Image = ImageList1.Images(0) ' Imposta come immagine un simbolo che indica nessun colore
        End If

    End Sub

    Private Sub Label3_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseClick

        If e.Button = Windows.Forms.MouseButtons.Left Then

            If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto un colore
                Label3.BackColor = ColorDialog1.Color ' Imposta il colore dello sfondo della label
                FillColor = ColorDialog1.Color ' Imposta il colore di riempimento dell'oggetto
                Label3.Image = Nothing ' Nessuna immagine
            End If

        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            FillColor = Color.Transparent ' Colore del riempimento trasparente
            Label3.Image = ImageList1.Images(0) ' Imposta come immagine un simbolo che indica nessun colore
        End If

    End Sub

    Private Sub PrintGraphic(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ev.Graphics.DrawImage(Image, New Point(0, 0)) ' Disegna la grafica dell'immagine
        ev.HasMorePages = False ' Non ci sono altre pagine da stampare
    End Sub

    Public Sub SetImageBackground(ByVal Color As Color)
        Dim g As Graphics = Graphics.FromImage(Image) ' Grafica dell'immagine per disegnare su essa
        g.FillRectangle(New SolidBrush(Color), 0, 0, Image.Width, Image.Height) ' Disegna un rettangolo del colore scelto
        g.Dispose() ' Rilascia le risorse utilizzate
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub painter_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.paintbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.paintbuttonsmall.Visible = False
        End If
    End Sub
End Class