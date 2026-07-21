Public Class breakout
    Dim vspeed As Single = -4
    Dim hspeed As Single = -4
    Dim life As Single = 3
    Dim rows As Integer = 8
    Dim cols As Integer = 10
    Dim toprow As Single = 0.1
    Dim rowheight As Single = 0.05
    Dim score As Integer = 0
    Dim level As Integer = 1
    Dim Start As Boolean = False
    Dim countdown As Integer = cols * rows
    Private Sub breakout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Makebricks()
        Game()
    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If ball.Top < 35 Then
            vspeed = -vspeed
        End If
        If ball.Left < 0 Then
            hspeed = -hspeed
        End If
        If ball.Bottom > Me.ClientRectangle.Height Then
            Timer2.Enabled = False
            life -= 1
            If life > 0 Then
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.LostBall, AudioPlayMode.Background)
                MsgBox("YOU HAVE LOST ONE LIFE! - You only have " & life & " left!")
                'Makebricks()
                Game()
            Else
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.Ball_Blasta, AudioPlayMode.Background)
                MsgBox("GAME OVER!")
                My.Computer.Audio.Stop()
                Me.Close()
            End If
        End If
        If ball.Right > Me.ClientRectangle.Width Then
            hspeed = -hspeed

        End If

        For Each cnt As Control In Me.Controls
            If cnt.Name = "Brick" Then
                CheckBrick(cnt, ball)
            End If

        Next


        Dim c As Single = ball.Left + ball.Width / 2
        If c > bat.Left And c < bat.Right And vspeed > 0 And ball.Bottom > bat.Top And ball.Top < bat.Top Then
            vspeed = -vspeed
            My.Computer.Audio.Play(My.Resources.HitBrick, AudioPlayMode.Background)
            Dim offset As Single = (ball.Left + ball.Width / 2) - (bat.Left + bat.Width / 2)
            Dim ratio As Single = offset / (bat.Width / 2)
            hspeed += 3 * ratio
        End If
        ball.Left += hspeed
        ball.Top += vspeed

    End Sub
    Private Sub Makebricks()

        For i As Integer = Me.Controls.Count - 1 To 0 - 1
            If Me.Controls(i).Name = "Brick" Then
                Me.Controls.RemoveAt(i)
            End If
        Next


        For r As Integer = 0 To rows - 1
            For c As Integer = 0 To cols - 1
                Dim B As New Button
                Me.Controls.Add(B)

                B.Visible = True
                B.Name = "Brick"
                B.Tag = rows - r

                B.Width = Me.ClientRectangle.Width / cols
                B.Height = Me.ClientRectangle.Height * rowheight
                B.Left = c * B.Width
                B.Top = Me.ClientRectangle.Height * (toprow + r * rowheight) + 20

                If level = 1 Then
                    If r Mod 2 Then
                        B.BackgroundImage = My.Resources.brick01
                    Else
                        B.BackgroundImage = My.Resources.brick02
                    End If
                    If r * c Mod 2 Then
                        B.BackgroundImage = My.Resources.brick03

                    End If
                ElseIf level = 2 Then
                    If r Mod 2 Then
                        B.BackgroundImage = My.Resources.brick02
                    Else
                        B.BackgroundImage = My.Resources.brick03
                    End If
                    If r * c Mod 2 Then
                        B.BackgroundImage = My.Resources.brick04

                    End If
                ElseIf level = 3 Then
                    If r Mod 2 Then
                        B.BackgroundImage = My.Resources.brick03
                    Else
                        B.BackgroundImage = My.Resources.brick04
                    End If
                    If r * c Mod 2 Then
                        B.BackgroundImage = My.Resources.brick01

                    End If
                End If

            Next

        Next
        countdown = rows * cols

        Label2.Text = "BRICKS LEFT: " & countdown.ToString
    End Sub

    Private Sub Game()
        With ball
            .Left = Me.ClientRectangle.Width / 2
            .Top = Me.ClientRectangle.Height * 0.9
            vspeed = -2
            hspeed = 2
        End With
        Timer2.Enabled = True
        For i As Integer = Me.Controls.Count - 1 To 0 - 1
            If Me.Controls(i).Name = "Brick" Then
                countdown = Me.Controls.Count
            End If
        Next

        Label2.Text = "BRICKS LEFT: " & countdown.ToString
        Label3.Text = "BALLS LEFT: " & life.ToString
        Label4.Text = "LEVEL: " & level.ToString
    End Sub
    Private Sub CheckBrick(ByVal Brick As Button, ByVal Ball As Button)

        If Brick.Visible Then
            Dim hit As Boolean = False
            Dim cl As Single = Ball.Left + Ball.Width / 2
            Dim ch As Single = Ball.Top + Ball.Height / 2

            If vspeed < 0 And cl > Brick.Left And cl < Brick.Right And Ball.Top < Brick.Bottom And Ball.Bottom > Brick.Bottom Then
                vspeed = -vspeed
                hit = True
                'score += 1
                'bat.Text = "SCORE: " & score
            End If
            If vspeed > 0 And cl > Brick.Left And cl < Brick.Right And Ball.Bottom > Brick.Top And Ball.Top < Brick.Top Then
                vspeed = -vspeed
                hit = True
                'score += 1
                'bat.Text = "SCORE: " & score
            End If
            If hspeed > 0 And ch > Brick.Top And ch < Brick.Bottom And Ball.Right > Brick.Left And Ball.Left < Brick.Left Then
                hspeed = -hspeed
                hit = True
                'score += 1
                'bat.Text = "SCORE: " & score
            End If
            If hspeed < 0 And ch > Brick.Top And ch < Brick.Bottom And Ball.Left < Brick.Right And Ball.Right > Brick.Right Then
                hspeed = -hspeed
                hit = True
                'score += 1
                'bat.Text = "SCORE: " & score
            End If
            If hit Then
                My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
                Brick.Visible = False
                countdown -= 1
                Label2.Text = "BRICKS LEFT: " & countdown.ToString
                score += Brick.Tag
                Label1.Text = "YOUR SCORE: " & score.ToString

                If countdown = 0 Then
                    Timer2.Enabled = False
                    My.Computer.Audio.Stop()
                    My.Computer.Audio.Play(My.Resources.Ball_Blasta, AudioPlayMode.Background)
                    MsgBox("CONGRATULATIONS! - You have cleared the scheme!!")
                    My.Computer.Audio.Stop()
                    level += 1
                    If level = 2 Then
                        PictureBox1.Image = My.Resources.BB02

                    ElseIf level = 3 Then
                        PictureBox1.Image = My.Resources.BB03

                    ElseIf level > 3 Then
                        PictureBox1.Image = My.Resources.BB01

                    End If
                    If level > 3 Then
                        MsgBox("GAME OVER! - You have finished all the 3 schemes")
                        Me.Close()
                    Else
                        Makebricks()
                        Game()
                    End If
                End If
            End If

        End If

    End Sub
    Private Sub breakout_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove

        bat.Top = 0.9 * Me.ClientRectangle.Height
        bat.Left = e.X - (0.15 * Me.ClientRectangle.Width)
        If bat.Left < Me.ClientRectangle.Left Then
            bat.Left = Me.ClientRectangle.Left
        ElseIf bat.Left > Me.ClientRectangle.Width - 190 Then
            bat.Left = Me.ClientRectangle.Width - 190
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Start = False Then
            'Button was labelled "Start" or "Resume" => Start or resume
            Button2.Text = "Pause"
        Else
            'Button was labelled "Pause" => Pause timer
            Button2.Text = "Resume"
        End If
        Start = Not (Start) 'Invert boolean variable
        Timer2.Enabled = Start
    End Sub


    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub breakout_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.brkButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.brkButtonsmall.Visible = False
        End If
    End Sub


End Class
