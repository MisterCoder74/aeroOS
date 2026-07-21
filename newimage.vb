Imports System.IO
Public Class newimage

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

        If ColorDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then ' Se si è scelto un colore
            Label6.BackColor = ColorDialog1.Color ' Imposta il colore dello sfondo della label
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then ' Se le dimensioni sono numeri

            If TextBox1.Text > 0 And TextBox2.Text > 0 Then ' Se le dimensioni sono inferiori a 0

                painter.Image = New Bitmap(CInt(TextBox1.Text), CInt(TextBox2.Text)) ' Crea una nuova immagine
                painter.PictureBox1.Size = New Point(TextBox1.Text, TextBox2.Text) ' Aggiorna le dimensioni della picturebox
                painter.SetImageBackground(Label6.BackColor) ' Chiama la funzione per impostare lo sfondo dell'immagine
                painter.PictureBox1.Invalidate() ' Obbliga un refresh della picturebox

                Me.Close() ' Chiude il form

            Else
                MessageBox.Show("Image size cannot be 0!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Image size must be numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close() ' Chiude il form
    End Sub

    Private Sub newimage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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