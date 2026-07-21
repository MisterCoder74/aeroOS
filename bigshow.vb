Imports System.IO
Public Class bigshow
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub PictureBoxMain_Click(sender As System.Object, e As System.EventArgs) Handles PictureBoxMain.Click
        Me.Close()
        stack.TextBox1.Text = ""
    End Sub

    Private Sub bigshow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Try
            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
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
        If stack.TextBox1.Text <> "" Then
            PictureBoxMain.Image = Image.FromFile(stack.TextBox1.Text)
        End If
    End Sub

    Private Sub bigshow_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        stack.TextBox1.Text = ""
    End Sub

    Private Sub clipbutton_Click(sender As System.Object, e As System.EventArgs) Handles clipbutton.Click
        Clipboard.SetImage(Me.PictureBoxMain.Image)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles pastbutton.Click
        Me.PictureBoxMain.Image = Clipboard.GetImage()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles savebutton.Click
        'Dim bmp As Bitmap
        'Dim spath As String
        Dim saveimage As New SaveFileDialog
        With saveimage
            .Title = "Salva File"
            .Filter = "Jpeg file (*.jpg)|*.jpg"
            .AddExtension = True
            .DefaultExt = "jpg"
            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Try

                    PictureBoxMain.Image.Save(saveimage.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End With





    End Sub

    Private Sub aquirebutton_Click(sender As System.Object, e As System.EventArgs) Handles aquirebutton.Click
        scanner.Show()
    End Sub
End Class