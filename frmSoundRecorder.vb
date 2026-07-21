Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Public Class frmSoundRecorder
    Dim FLocation As String
    Dim hh, mm, ss As Integer

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    <DllImport("winmm.dll")> _
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As StringBuilder, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStop.Enabled = True
        btnStart.Enabled = False
        Try
            Dim i As Integer
            i = mciSendString("open new type waveaudio alias capture", Nothing, 0, 0)
            Console.WriteLine(i)
            i = mciSendString("record capture", Nothing, 0, 0)
            Console.WriteLine(i)
            prgrecording.Visible = True
            lblDuartion.Text = "00:00:00"
            tmrDuration.Start()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub frmSoundRecorder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        prgrecording.Visible = False
        btnStop.Enabled = False
        btnStart.Enabled = True
    End Sub
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        Dim f1 As New SaveFileDialog, flocation As String = String.Empty
        tmrDuration.Stop()
        btnStop.Enabled = False
        btnStart.Enabled = True
        prgrecording.Visible = False
        Try


            With f1
                .Title = "Salva File"
                .Filter = "wave audio files (*.wav)|*.wav"
                .AddExtension = True
                .DefaultExt = "wav"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    flocation = .FileName
                    mciSendString("save capture " & flocation, Nothing, 0, 0)
                    mciSendString("close capture", Nothing, 0, 0)
                    MsgBox("Your Voice has been recorded And Stored At " & flocation, MsgBoxStyle.Information, "Voice Recorder")
                    TextBox1.Text = flocation

                Else
                    ' non OK. Si esce dalla procedura
                    Exit Sub
                End If
            End With
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        Dim Sound As New System.Media.SoundPlayer()
        Try
            Sound.SoundLocation = TextBox1.Text
            Sound.Play()
        Catch ex As Exception
            MsgBox("Unable To Play Sound File " & ex.Message, MsgBoxStyle.Exclamation, "Voice Recorder")
        End Try
    End Sub
    Private Sub tmrDuration_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDuration.Tick
        Dim shh, smm, sss As String
        ss += 1
        If ss = 59 Then
            ss = 0 : mm += 1
            If mm >= 59 Then
                mm = 0 : hh += 1
            End If
        End If
        If hh < 10 Then shh = "0" & hh Else shh = hh
        If mm < 10 Then smm = "0" & mm Else smm = mm
        If ss < 10 Then sss = "0" & ss Else sss = ss
        lblDuartion.Text = shh & ":" & smm & ":" & sss
    End Sub

    Private Sub lblDuartion_Click(sender As System.Object, e As System.EventArgs) Handles lblDuartion.Click

    End Sub

    Private Sub btnUnplay_Click(sender As System.Object, e As System.EventArgs) Handles btnUnplay.Click
        Dim Sound As New System.Media.SoundPlayer()
        Sound.stop()
    End Sub

    Private Sub frmSoundRecorder_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.soundrecbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.soundrecbuttonsmall.Visible = False
        End If
    End Sub
End Class
