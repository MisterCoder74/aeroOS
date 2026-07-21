Imports System.IO

Public Class speak
    Private animatedImage As Bitmap = Image.FromFile("Mia-talking.gif")
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


        Me.CheckForIllegalCrossThreadCalls = False
        trvolume.Value = 5
        Dim x
        x = CreateObject("SAPI.spvoice")

        Dim arrVoices
        arrVoices = x.GetVoices
        Dim arrLst As New ArrayList
        For i As Integer = 0 To arrVoices.Count - 1
            arrLst.Add(arrVoices.Item(i).GetDescription)
        Next
        voicescombo.DataSource = arrLst
    End Sub
    Private Sub OnFrameChanged(ByVal o As Object, ByVal e As EventArgs)
        'Force a call to the Paint event handler. 
        Me.Invalidate()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ImageAnimator.Animate(animatedImage, New EventHandler(AddressOf Me.OnFrameChanged))
        BackgroundWorker1.RunWorkerAsync()


    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        speakbox.Paste()
    End Sub

    Private Sub speak_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.speakbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.speakbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.Voice = SAPI.GetVoices.Item(voicescombo.SelectedIndex)
        SAPI.Volume = trvolume.Value * 10

        SAPI.speak(speakbox.Text)
        ImageAnimator.StopAnimate(animatedImage, New EventHandler(AddressOf Me.OnFrameChanged))
    End Sub

    Private Sub recordbutton_Click(sender As System.Object, e As System.EventArgs) Handles recordbutton.Click
        frmSoundRecorder.Show()
    End Sub

    Private Sub speak_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        ImageAnimator.UpdateFrames()
        'Draw the next frame in the animation.
        e.Graphics.DrawImage(Me.animatedImage, New Point(12, 8))
    End Sub
End Class
