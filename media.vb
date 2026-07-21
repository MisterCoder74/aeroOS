Imports System.IO
Public Class media
    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        AxVLCPlugin21.playlist.stop()
        AxVLCPlugin21.playlist.clear()
        AxVLCPlugin21.playlist.add(ListBox1.SelectedItem)
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub openvbutt_Click(sender As System.Object, e As System.EventArgs) Handles openvbutt.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog
        ofd.Filter = "Video (*.avi)|*.avi|Video (*.flv)|*.flv|Video (*.mp4)|*.mp4|Video (*.mpg)|*.mpg|Video (*.wmv)|*.wmv|Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav|Audio (*.wma)|*.wma|Audio (*.m4a)|*.m4a|All Files (*.*)|*.*"

        If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim uritext As String
            uritext = "file:///" & ofd.FileName

            AxVLCPlugin21.playlist.stop()
            AxVLCPlugin21.playlist.clear()
            AxVLCPlugin21.playlist.add(uritext)
            AxVLCPlugin21.playlist.play()
            ListBox1.Items.Add(uritext)
        End If

    End Sub

    Private Sub playvbutton_Click(sender As System.Object, e As System.EventArgs) Handles playvbutton.Click
        AxVLCPlugin21.playlist.play()
        AxVLCPlugin21.video.marquee.disable()
    End Sub

    Private Sub stopvbutton_Click(sender As System.Object, e As System.EventArgs) Handles stopvbutton.Click
        AxVLCPlugin21.playlist.stop()
    End Sub
    Private Sub pausevbutton_Click(sender As System.Object, e As System.EventArgs) Handles pausevbutton.Click
        AxVLCPlugin21.playlist.togglePause()
    End Sub

    Private Sub loopvbutton_Click_1(sender As System.Object, e As System.EventArgs) Handles loopvbutton.Click
        If AxVLCPlugin21.AutoLoop = True Then
            AxVLCPlugin21.AutoLoop = False
            Label1.Visible = False
        ElseIf AxVLCPlugin21.AutoLoop = False Then
            AxVLCPlugin21.AutoLoop = True
            Label1.Visible = True
        End If
    End Sub


    Private Sub toolbalvbutt_Click(sender As System.Object, e As System.EventArgs) Handles toolbalvbutt.Click
        If AxVLCPlugin21.Toolbar = False Then
            AxVLCPlugin21.Toolbar = True
        ElseIf AxVLCPlugin21.Toolbar = True Then
            AxVLCPlugin21.Toolbar = False
        End If
    End Sub

    Private Sub media_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.mpButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.mpButtonsmall.Visible = False
        End If
    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub media_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        If stack.TextBox3.Text <> "" Then
            Dim uritext As String
            uritext = "file:///" & stack.TextBox3.Text
            AxVLCPlugin21.playlist.add(uritext)
            AxVLCPlugin21.playlist.play()
            ListBox1.Items.Add(uritext)
        End If
    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String
            Dim i As Integer

            ' Assign the files to an array.
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            ' Loop through the array and add the files to the list.
            For i = 0 To MyFiles.Length - 1
                ListBox1.Items.Add("file:///" & MyFiles(i))
            Next

        End If
        Dim uritext As String
        ListBox1.SelectedItem = ListBox1.Items.Item(0)
        uritext = ListBox1.SelectedItem
        AxVLCPlugin21.playlist.add(uritext)
        AxVLCPlugin21.playlist.play()
    End Sub

    Private Sub ListBox1_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
    End Sub
End Class