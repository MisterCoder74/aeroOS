Imports System.IO

Public Class resizeimage

    Private BoxSelect As Integer ' Textbox in cui si sta scrivendo

    Private Sub TextBox1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Enter
        BoxSelect = 0 ' Indica che si sta scrivendo nella textbox1
    End Sub

    Private Sub TextBox2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Enter
        BoxSelect = 1 ' Indica che si sta scrivendo nella textbox2
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        If CheckBox1.Checked And BoxSelect = 0 Then ' Se si vogliono proporzionare le dimensioni

            If IsNumeric(TextBox1.Text) Then ' Se il valore è un numero
                TextBox2.Text = CInt(painter.Image.Height * TextBox1.Text / painter.Image.Width) ' Proporziona le dimensioni
            End If

        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        If CheckBox1.Checked And BoxSelect = 1 Then ' Se si vogliono proporzionare le dimensioni

            If IsNumeric(TextBox2.Text) Then ' Se il valore è un numero
                TextBox1.Text = CInt(painter.Image.Width * TextBox2.Text / painter.Image.Height) ' Proporziona le dimensioni
            End If

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then ' Se la checkbox è spuntata

            If IsNumeric(TextBox1.Text) Then ' Se il valore è un numero
                TextBox2.Text = CInt(painter.Image.Height * TextBox1.Text / painter.Image.Width) ' Proporziona le dimensioni
            ElseIf IsNumeric(TextBox2.Text) Then ' Se il valore è un numero
                TextBox1.Text = CInt(painter.Image.Width * TextBox2.Text / painter.Image.Height) ' Proporziona le dimensioni
            End If

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then ' Se contengono numeri

            If TextBox1.Text > 0 And TextBox2.Text > 0 Then ' Se i numeri sono superiori a 0

                Dim ImageResize As New Bitmap(CInt(TextBox1.Text), CInt(TextBox2.Text)) ' Conterrà l'immagine ridimensionata
                Dim g As Graphics = Graphics.FromImage(ImageResize) ' Grafica dell'immagine ridimensionata per disegnare su essa

                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(painter.Image, New Rectangle(0, 0, ImageResize.Width, ImageResize.Height), New Rectangle(0, 0, painter.Image.Width, painter.Image.Height), GraphicsUnit.Pixel) ' Ridimensiona l'immagine
                g.Dispose() ' Rilascia le risorse utilizzate

                painter.Image = ImageResize ' Assegna all'immagine principale l'immagine ridimensionata
                painter.PictureBox1.Size = New Point(ImageResize.Width, ImageResize.Height) ' Ridimensiona la picturebox
                painter.PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

                Me.Close() ' Chiude il form

            Else
                MessageBox.Show("Le dimensioni dell'immagine non possono essere uguali a 0!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Le dimensioni dell'immagine devono essere numeri!", "Avviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close() ' Chiude il form
    End Sub

    Private Sub resizeimage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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


    End Sub
End Class