Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Public Class DJconsolePro
    Dim bank As Integer = 1
    Dim FLocation As String
    Dim hh, mm, ss As Integer
    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim OFD1 As New OpenFileDialog
        OFD1.Multiselect = True
        OFD1.Filter = "Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav|Audio (*.wma)|*.wma|All Files (*.*)|*.*"
        If OFD1.ShowDialog = Windows.Forms.DialogResult.OK Then

            For Each File As String In OFD1.FileNames
                ListBox1.Items.Add(File)
            Next

        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Dim OFD2 As New OpenFileDialog
        OFD2.Multiselect = True
        OFD2.Filter = "Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav|Audio (*.wma)|*.wma|All Files (*.*)|*.*"
        If OFD2.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each File As String In OFD2.FileNames
                ListBox2.Items.Add(File)
            Next
        End If
    End Sub

    Private Sub TrackBar3_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar3.Scroll
        If TrackBar3.Value = 10 Then
            mediaout1.settings.rate = 2
        End If
        If TrackBar3.Value = 9 Then
            mediaout1.settings.rate = 1.8
        End If
        If TrackBar3.Value = 8 Then
            mediaout1.settings.rate = 1.6
        End If
        If TrackBar3.Value = 7 Then
            mediaout1.settings.rate = 1.4
        End If
        If TrackBar3.Value = 6 Then
            mediaout1.settings.rate = 1.2
        End If
        If TrackBar3.Value = 5 Then
            mediaout1.settings.rate = 1
        End If
        If TrackBar3.Value = 4 Then
            mediaout1.settings.rate = 0.8
        End If
        If TrackBar3.Value = 3 Then
            mediaout1.settings.rate = 0.6
        End If
        If TrackBar3.Value = 2 Then
            mediaout1.settings.rate = 0.4
        End If
        If TrackBar3.Value = 1 Then
            mediaout1.settings.rate = 0.2
        End If
        If TrackBar3.Value = 0 Then
            mediaout1.settings.rate = 0.1
        End If

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 10 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 9 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 8 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 7 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 6 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 5 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 4 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 3 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 2 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 1 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If
        If TrackBar1.Value = 0 Then
            mediaout1.settings.volume = TrackBar1.Value & "0"
        End If

    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        If TrackBar2.Value = 10 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 9 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 8 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 7 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 6 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 5 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 4 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 3 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 2 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 1 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If
        If TrackBar2.Value = 0 Then
            mediaout2.settings.volume = TrackBar2.Value & "0"
        End If

    End Sub

    Private Sub TrackBar4_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar4.Scroll
        If TrackBar4.Value = 10 Then
            mediaout2.settings.rate = 2
        End If
        If TrackBar4.Value = 9 Then
            mediaout2.settings.rate = 1.8
        End If
        If TrackBar4.Value = 8 Then
            mediaout2.settings.rate = 1.6
        End If
        If TrackBar4.Value = 7 Then
            mediaout2.settings.rate = 1.4
        End If
        If TrackBar4.Value = 6 Then
            mediaout2.settings.rate = 1.2
        End If
        If TrackBar4.Value = 5 Then
            mediaout2.settings.rate = 1
        End If
        If TrackBar4.Value = 4 Then
            mediaout2.settings.rate = 0.8
        End If
        If TrackBar4.Value = 3 Then
            mediaout2.settings.rate = 0.6
        End If
        If TrackBar4.Value = 2 Then
            mediaout2.settings.rate = 0.4
        End If
        If TrackBar4.Value = 1 Then
            mediaout2.settings.rate = 0.2
        End If
        If TrackBar4.Value = 0 Then
            mediaout2.settings.rate = 0.1
        End If

    End Sub

    Private Sub TrackBar5_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar5.Scroll
        If TrackBar5.Value = 10 Then
            mediaout1.settings.volume = 0
            mediaout2.settings.volume = 100
        End If
        If TrackBar5.Value = 9 Then
            mediaout1.settings.volume = 10
            mediaout2.settings.volume = 90
        End If
        If TrackBar5.Value = 8 Then
            mediaout1.settings.volume = 20
            mediaout2.settings.volume = 80
        End If
        If TrackBar5.Value = 7 Then
            mediaout1.settings.volume = 30
            mediaout2.settings.volume = 70
        End If
        If TrackBar5.Value = 6 Then
            mediaout1.settings.volume = 40
            mediaout2.settings.volume = 60
        End If
        If TrackBar5.Value = 5 Then
            mediaout1.settings.volume = 50
            mediaout2.settings.volume = 50
        End If
        If TrackBar5.Value = 4 Then
            mediaout1.settings.volume = 60
            mediaout2.settings.volume = 40
        End If
        If TrackBar5.Value = 3 Then
            mediaout1.settings.volume = 70
            mediaout2.settings.volume = 30
        End If
        If TrackBar5.Value = 2 Then
            mediaout1.settings.volume = 80
            mediaout2.settings.volume = 20
        End If
        If TrackBar5.Value = 1 Then
            mediaout1.settings.volume = 90
            mediaout2.settings.volume = 10
        End If
        If TrackBar5.Value = 0 Then
            mediaout1.settings.volume = 100
            mediaout2.settings.volume = 0
        End If

    End Sub
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        bank = 1
        Button23.Text = "FX bank 1"
        Label11.Text = "Sweeps and Pads"
        Button1.Text = "sweep 01"
        Button2.Text = "sweep 02"
        Button3.Text = "sweep 03"
        Button4.Text = "sweep 04"
        Button5.Text = "sweep 05"
        Button6.Text = "sweep 06"
        Button7.Text = "ambient 01"
        Button8.Text = "ambient 02"
        Button11.Text = "ambient 03"
        Button12.Text = "ambient 04"
        Button13.Text = "synpad 01"
        Button14.Text = "synpad 02"
        Button15.Text = "leadpad"
        Button16.Text = "breathy"
        Button17.Text = "space howl"
        Button18.Text = "7th 01"
        Button19.Text = "7th 02"
        Button20.Text = "alien pad"
        Button21.Text = "newage pad"
        Button22.Text = "athmos"
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        bank += 1
        If bank > 2 Then
            bank = 1
        End If

        If bank = 1 Then
            Button23.Text = "FX bank 1"
            Label11.Text = "sweeps and pads"
            Button1.Text = "sweep 01"
            Button2.Text = "sweep 02"
            Button3.Text = "sweep 03"
            Button4.Text = "sweep 04"
            Button5.Text = "sweep 05"
            Button6.Text = "sweep 06"
            Button7.Text = "ambient 01"
            Button8.Text = "ambient 02"
            Button11.Text = "ambient 03"
            Button12.Text = "ambient 04"
            Button13.Text = "synpad 01"
            Button14.Text = "synpad 02"
            Button15.Text = "leadpad"
            Button16.Text = "breathy"
            Button17.Text = "space howl"
            Button18.Text = "7th 01"
            Button19.Text = "7th 02"
            Button20.Text = "alien pad"
            Button21.Text = "newage pad"
            Button22.Text = "athmos"


        ElseIf bank = 2 Then
            Button23.Text = "FX bank 2"
            Label11.Text = "rumours"
            Button1.Text = "camera"
            Button2.Text = "car crash"
            Button3.Text = "car start"
            Button4.Text = "door creek"
            Button5.Text = "heart beat"
            Button6.Text = "copter"
            Button7.Text = "jet flyby"
            Button8.Text = "kiss"
            Button11.Text = "pew"
            Button12.Text = "scream"
            Button13.Text = "plause"
            Button14.Text = "forest"
            Button15.Text = "ocean"
            Button16.Text = "rain"
            Button17.Text = "thunder 01"
            Button18.Text = "thunder 02"
            Button19.Text = "thunder 03"
            Button20.Text = "thunder 04"
            Button21.Text = "ufo"
            Button22.Text = "wind"

        End If

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep01.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/camera.wav"
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep02.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/carcrash.wav"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep03.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/carstart.wav"
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep04.wav"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/doorcreak.wav"
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep05.wav"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/heartbeat.wav"
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/sweep06.wav"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/helicopter.wav"
        End If
    End Sub


    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/ambient01.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/jetflyby.mp3"
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/ambient02.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/kiss.wav"
        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/ambient03.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/pew.wav"
        End If
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/ambient04.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/scream.wav"
        End If
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/synthpad01.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/applause.wav"
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/synthpad02.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/forest.mp3"
        End If
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/leadpad.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/ocean.mp3"
        End If
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/breathy.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/rain.mp3"
        End If
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/spacehowl.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/thunder01.wav"
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/7th01.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/thunder02.wav"
        End If
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/7th02.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/thunder03.mp3"
        End If
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/alienpad.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/thunder04.mp3"
        End If
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/newagepad.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/ufo.wav"
        End If
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        If bank = 1 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk1/atmosphere.mp3"
        ElseIf bank = 2 Then
            fxmedia.URL = Application.StartupPath & "/fx/bnk2/wind.mp3"
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        mediaout1.URL = ListBox1.SelectedItem
        PictureBox3.Visible = True
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox2.SelectedIndexChanged
        mediaout2.URL = ListBox2.SelectedItem
        PictureBox3.Visible = True
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        mediaout1.Ctlcontrols.play()
        PictureBox3.Visible = True
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        mediaout1.Ctlcontrols.pause()
        If mediaout2.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If

    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        mediaout2.Ctlcontrols.play()
        PictureBox3.Visible = True
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        mediaout2.Ctlcontrols.pause()
        If mediaout1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            PictureBox3.Visible = True
        Else
            PictureBox3.Visible = False
        End If
    End Sub


    <DllImport("winmm.dll")> _
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As StringBuilder, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
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
            tmrDuartion.Start()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        Dim f1 As New SaveFileDialog, flocation As String = String.Empty
        tmrDuartion.Stop()
        btnStop.Enabled = False
        btnStart.Enabled = True
        prgrecording.Visible = False
        Try


            With f1
                .Title = "Save File"
                .Filter = "wave audio files (*.wav)|*.wav"
                .AddExtension = True
                .DefaultExt = "wav"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    flocation = .FileName
                    mciSendString("save capture " & flocation, Nothing, 0, 0)
                    mciSendString("close capture", Nothing, 0, 0)
                    MsgBox("Your mix has been recorded And Stored At " & flocation, MsgBoxStyle.Information, "Mix Recorder")
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

    Private Sub tmrduartion_Tick(sender As System.Object, e As System.EventArgs) Handles tmrduartion.Tick
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

    Private Sub btnPlay_Click(sender As System.Object, e As System.EventArgs) Handles btnPlay.Click
        Dim Sound As New System.Media.SoundPlayer()
        Try
            Sound.SoundLocation = TextBox1.Text
            Sound.Play()
        Catch ex As Exception
            MsgBox("Unable To Play Sound File " & ex.Message, MsgBoxStyle.Exclamation, "Voice Recorder")
        End Try
    End Sub

    Private Sub btnUnplay_Click(sender As System.Object, e As System.EventArgs) Handles btnUnplay.Click
        Dim Sound As New System.Media.SoundPlayer()
        Sound.Stop()
    End Sub

    Private Sub DJconsolePro_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.djButtonSmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.djButtonSmall.Visible = False
        End If
    End Sub
End Class
