Imports Ionic.Zip
Imports System.IO

Public Class zipper

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "All files (*.*)|*.*"
        OpenFileDialog1.ShowDialog()
        Try
            Using zip As ZipFile = New ZipFile
                TextBox1.Text = TextBox1.Text & "----------------" & vbCrLf & "Archive created: " & Now & vbCrLf & "Compressing files:" & vbCrLf

                For Each filename In OpenFileDialog1.FileNames
                    zip.AddFile(filename, "")
                    TextBox1.Text = TextBox1.Text & filename & vbCrLf
                    Application.DoEvents()
                Next
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox2.Text = FolderBrowserDialog1.SelectedPath
                    zip.Save(FolderBrowserDialog1.SelectedPath & "\MyZipFile.zip")
                End If
                TextBox1.Text = TextBox1.Text & "Archive created successfully at: " & FolderBrowserDialog1.SelectedPath & vbCrLf & "----------------" & vbCrLf
                Label1.Text = "Archive created"
            End Using

        Catch ex1 As Exception
            Label1.Text = "exception: {0}" & ex1.ToString
            MsgBox("Could not create archive")
        End Try

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Zip files (*.zip)|*.zip|Rar files (*.rar)|*.rar"
        OpenFileDialog1.ShowDialog()
        Try
            Using zip As ZipFile = ZipFile.Read(OpenFileDialog1.FileName)
                TextBox1.Text = TextBox1.Text & "----------------" & vbCrLf & "Archive extracted: " & Now & vbCrLf
                If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                    TextBox2.Text = FolderBrowserDialog1.SelectedPath
                    zip.ExtractAll(FolderBrowserDialog1.SelectedPath)
                End If
                TextBox1.Text = TextBox1.Text & "Archive extracted successfully at: " & FolderBrowserDialog1.SelectedPath & vbCrLf & "----------------" & vbCrLf
                Label1.Text = "Archive extracted"
            End Using
        Catch ex1 As Exception
            Label1.Text = "exception: {0}" & ex1.ToString
            MsgBox("Could not extract archive")
        End Try
    End Sub

    Private Sub zipper_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        If stack.TextBox6.Text <> "" Then
            Dim filetoextract As String = stack.TextBox6.Text
            Try
                Using zip As ZipFile = ZipFile.Read(filetoextract)
                    TextBox1.Text = TextBox1.Text & "----------------" & vbCrLf & "Archive extracted: " & Now & vbCrLf
                    If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                        TextBox2.Text = FolderBrowserDialog1.SelectedPath
                        zip.ExtractAll(FolderBrowserDialog1.SelectedPath)
                    End If
                    TextBox1.Text = TextBox1.Text & "Archive extracted successfully at: " & FolderBrowserDialog1.SelectedPath & vbCrLf & "----------------" & vbCrLf
                    Label1.Text = "Archive extracted"
                End Using
            Catch ex1 As Exception
                Label1.Text = "exception: {0}" & ex1.ToString
                MsgBox("Could not extract archive")
            End Try

        End If
    End Sub

    Private Sub zipper_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        stack.TextBox6.Text = ""
    End Sub
End Class
