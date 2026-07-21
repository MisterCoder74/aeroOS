Imports System.IO

'By manipulating the bytes in a picture file this program adds strings to the picture file
'Without distorting the image
Public Class stegano
    Dim PicBuffer As System.IO.FileInfo
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        openPic.Title = "Open Picture Files"
        openPic.ShowDialog()
    End Sub

    Private Sub openPic_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles openPic.FileOk
        PictureBox1.Image = Image.FromFile(openPic.FileName)
        PicBuffer = New System.IO.FileInfo(openPic.FileName)
        ResizeFileName(openPic.FileName, PicBuffer.Name)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim Ready As Boolean = True
        Dim PicFileStream As System.IO.FileStream
        Try
            PicFileStream = PicBuffer.OpenRead
        Catch ex As Exception
            Ready = False
            MsgBox("Please load a picture before clicking this button", MsgBoxStyle.Critical, "Error")
        End Try
        If Ready = True Then
            Dim PicBytes As Long = PicFileStream.Length
            Dim PicExt As String = PicBuffer.Extension
            Dim PicByteArray(PicBytes) As Byte
            PicFileStream.Read(PicByteArray, 0, PicBytes)
            Dim SentinelString() As Byte = {73, 116, 83, 116, 97, 114, 116, 115, 72, 101, 114, 101}
            If RadioButton1.Checked = True Then
                Dim PlainText As String = TextBox1.Text
                Dim PlainTextByteArray(PlainText.Length) As Byte
                For i As Integer = 0 To (PlainText.Length - 1)
                    PlainTextByteArray(i) = CByte(AscW(PlainText.Chars(i)))
                    Application.DoEvents()
                Next
                Dim PicAndText(PicBytes + PlainText.Length + SentinelString.Length) As Byte
                For t As Long = 0 To (PicBytes - 1)
                    PicAndText(t) = PicByteArray(t)
                Next
                Dim count As Integer = 0
                For r As Long = PicBytes To (PicBytes + (SentinelString.Length) - 1)
                    PicAndText(r) = SentinelString(count)
                    count += 1
                Next
                count = 0
                For q As Long = (PicBytes + SentinelString.Length) To (PicBytes + SentinelString.Length + PlainText.Length - 1)
                    PicAndText(q) = PlainTextByteArray(count)
                    count += 1
                Next
                buildPic.Filter = "JPEG file (*.jpg)|*.jpg"
                buildPic.ShowDialog()
                Dim NewFileName As String = buildPic.FileName
                My.Computer.FileSystem.WriteAllBytes(NewFileName, PicAndText, False)

            ElseIf RadioButton2.Checked Then
                TextBox3.Clear()
                Dim OutterSearch, InnerSearch, StopSearch As Boolean
                OutterSearch = True
                InnerSearch = True
                StopSearch = False
                Dim count As Long = 0
                Dim leftCounter As Long
                Dim rightCounter As Integer
                leftCounter = 0
                rightCounter = 0
                Do While (count < (PicBytes - SentinelString.Length) And StopSearch = False)
                    If (PicByteArray(count) = SentinelString(0)) Then
                        leftCounter = count + 1
                        rightCounter = 1
                        InnerSearch = True
                        Do While (InnerSearch = True) And (rightCounter < SentinelString.Length) _
                        And (leftCounter < PicByteArray.Length)
                            If (PicByteArray(leftCounter) = SentinelString(rightCounter)) Then
                                rightCounter += 1
                                leftCounter += 1
                                If (rightCounter = (SentinelString.Length - 1)) Then
                                    StopSearch = True
                                End If
                            Else
                                InnerSearch = False
                                count += 1
                            End If
                        Loop
                    Else
                        count += 1
                    End If
                Loop
                If StopSearch = True Then
                    'leftCounter contains the starting string that is being retrieved
                    Do While (leftCounter < PicBytes)
                        'Bytes need to be converted to an integer 
                        'then to an unicode character which will be the plaintext
                        TextBox3.AppendText(ChrW(CInt(PicByteArray(leftCounter))))
                        leftCounter += 1
                    Loop
                Else
                    TextBox3.Text = "The Picture does not contain any text"
                End If

            End If
        End If

    End Sub

    Sub ResizeFileName(ByVal LongFileName As String, ByVal ShortFileName As String)
        If LongFileName.Length > 71 Then
            Dim LongFileNameSize As Integer = LongFileName.Length
            Dim ShortFileNameSize As Integer = ShortFileName.Length
            Dim Cut As Integer = 71 - (5 + ShortFileNameSize)
            Dim i As Integer
            TextBox2.Clear()
            For i = 0 To (Cut) - 1
                TextBox2.AppendText(LongFileName.Chars(i))
            Next
            For i = 0 To 4
                TextBox2.AppendText(".")
            Next
            For i = 0 To (ShortFileNameSize - 1)
                TextBox2.AppendText(ShortFileName(i))
            Next
        Else
            TextBox2.Text = LongFileName
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        TextBox1.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        TextBox1.Enabled = True
    End Sub

    Private Sub stegano_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.steganoButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.steganoButtonsmall.Visible = False
        End If
    End Sub


    Private Sub stegano_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
