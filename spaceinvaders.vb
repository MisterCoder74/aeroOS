Public Class SPACEINVADERS
    Dim ship As New PictureBox
    Dim moveRight As Boolean = False
    Dim moveLeft As Boolean = False
    Dim maxMissileNumber As Integer = 5
    Dim missileArray(maxMissileNumber) As PictureBox
    Dim missileNumber As Integer = 0
    Dim missileOnScreen(maxMissileNumber) As Boolean
    Dim maxEnemyNumber As Integer = 5
    Dim enemyArray(maxEnemyNumber) As PictureBox
    Dim enemyOnScreen(maxEnemyNumber) As Boolean
    Dim score As Integer = 0
    Dim busted As Integer = 0
    Dim enemySpeed As Single = 5
    Dim Sound As New System.Media.SoundPlayer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Dim i As Integer = 0
        Dim count As Integer = 1
        Select Case e.KeyValue
            Case Keys.P
                If Timer1.Enabled = True Then
                    Timer1.Stop()
                    enemyTimer.Stop()
                    scoreTimer.Stop()
                    pauselabel.Visible = True
                Else
                    Timer1.Start()
                    enemyTimer.Start()
                    scoreTimer.Start()
                    pauselabel.Visible = False
                End If
            Case Keys.Right
                moveRight = True
            Case Keys.Left
                moveLeft = True
            Case Keys.Space
                Sound.SoundLocation = "Sounds\spaceinvaders\shoot.wav"
                Sound.Play()

                For i = 0 To maxMissileNumber
                    If missileOnScreen(i) = True Then
                        count = count + 1
                    End If
                Next

                If count <= maxMissileNumber Then
                    missileOnScreen(missileNumber) = True
                    missileArray(missileNumber).Visible = True
                    missileArray(missileNumber).Top = ship.Top + ship.Height / 2 - missileArray(missileNumber).Height / 2
                    missileArray(missileNumber).Left = ship.Left + ship.Width / 2 - missileArray(missileNumber).Width / 2
                    missileNumber += 1
                    If missileNumber = maxMissileNumber Then missileNumber = 0
                End If

        End Select
    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyValue
            Case Keys.Right
                moveRight = False
            Case Keys.Left
                moveLeft = False
        End Select
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Controls.Add(ship)
        ship.Width = 90
        ship.Height = 40
        ship.BorderStyle = BorderStyle.None
        ship.BackColor = Color.Transparent
        ship.BackgroundImage = My.Resources.Side_Spaceship
        ship.BackgroundImageLayout = ImageLayout.Stretch
        ship.Top = Me.Height - 2 * ship.Height
        ship.Left = Me.Width / 2 - ship.Width
        CreateMissiles(maxMissileNumber)
        CreateEnemies(maxEnemyNumber)
        Randomize() 'initilize random number generator
        'initialise the timers
        Timer1.Start()
        enemyTimer.Start()
        scoreTimer.Start()



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        Dim j As Integer
        If moveRight = True And (ship.Left < Me.Width - 40) Then
            ship.Left += 6
        End If
        If moveLeft = True And (ship.Left > -10) Then
            ship.Left -= 6
        End If
        For i = 0 To maxMissileNumber
            If missileOnScreen(i) = True Then
                missileArray(i).Top -= 4
            End If

            If missileArray(i).Top <= -10 Then
                missileOnScreen(i) = False
            End If

            ' for loop checks for collision between enemies and missiles
            For j = 0 To maxEnemyNumber
                If Collision(missileArray(i), enemyArray(j)) Then
                    ' if there is collision, move the missile back to the top with a random x coordinate.
                    enemyArray(j).Top = 0
                    enemyArray(j).Left = Int(Rnd() * Me.Width)
                    Sound.SoundLocation = "Sounds\spaceinvaders\explode.wav"
                    Sound.Play()
                    busted = busted + 1
                    score = score + 10
                End If
            Next
        Next

    End Sub


    Private Sub CreateMissiles(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim missile As New PictureBox
            Me.Controls.Add(missile)
            missile.Width = 10
            missile.Height = 10
            missile.BorderStyle = BorderStyle.FixedSingle
            missile.BackColor = Color.Blue
            missile.Top = ship.Top + ship.Height / 2 - missile.Height / 2
            missile.Left = ship.Left + ship.Width / 2 - missile.Width / 2
            missile.BringToFront()
            missileArray(i) = missile
            missileArray(i).Visible = False
            missileOnScreen(i) = False
        Next
    End Sub

    Private Sub CreateEnemies(ByVal Number As Integer)
        Dim i As Integer = 0
        For i = 0 To Number
            Dim missile As New PictureBox
            Me.Controls.Add(missile)
            missile.Width = 60
            missile.Height = 30
            missile.BorderStyle = BorderStyle.None
            missile.BackColor = Color.Transparent
            missile.BackgroundImage = My.Resources.alienshipflatpng
            missile.BackgroundImageLayout = ImageLayout.Stretch
            missile.Top = 50
            missile.Left = i * 105 'spread out the enemies 105 pixels apart
            missile.BringToFront()
            enemyArray(i) = missile
            enemyArray(i).Visible = True
            enemyOnScreen(i) = True
        Next

    End Sub

    Private Function Collision(ByVal Object1 As Object, ByVal Object2 As Object) As Boolean
        Dim Collided As Boolean = False
        If Object1.Top + Object1.Height >= Object2.Top And _
            Object2.Top + Object2.Height >= Object1.Top And _
            Object1.Left + Object1.Width >= Object2.Left And _
            Object2.Left + Object2.Width >= Object1.Left And Object1.visible = True And Object2.visible = True Then
            Collided = True
        End If
        Return Collided
    End Function


    'This timer controls the enemies' movement
    Private Sub enemyTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemyTimer.Tick
        Dim i As Integer = 0
        Dim random As Double

        For i = 0 To maxEnemyNumber
            ' the enemy moves towards the bottom of the screen at an increment of 5 units each time the timer ticks.
            enemyArray(i).Top += enemySpeed

            ' if the enemy moves past the bottom boundary of the screen, finish the game.
            If enemyArray(i).Bottom > Me.Height Then
                Timer1.Stop()
                enemyTimer.Stop()
                scoreTimer.Stop()
                'MsgBox("GAME OVER: ")
                gameover.Label2.Text = "Total score: " & score
                gameover.Label3.Text = "Busted aliens: " & busted
                gameover.Show()
            End If


            random = Rnd()
            ' the random number generated decides whether the enemy moves left or right or stays in the same x position.
            If random > 0.66 Then
                enemyArray(i).Left += 6
            ElseIf random < 0.33 Then
                enemyArray(i).Left -= 6
            End If
            'if the enemy moves off the boundary, move them back in
            If enemyArray(i).Left < 5 Then
                enemyArray(i).Left += 10
            End If
            If enemyArray(i).Left > (Me.Width - 60) Then
                enemyArray(i).Left -= 10
            End If

        Next

    End Sub

    Private Sub scoreTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scoreTimer.Tick
        score += 1
        scoreLabel.Text = "Total score: " & score
        bustedlabel.Text = "Busted aliens: " & busted
        If score Mod 10 = 0 Then
            enemySpeed += 0.5
        End If

    End Sub


    Private Sub SPACEINVADERS_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.spaceinvbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.spaceinvbuttonsmall.Visible = False
        End If
    End Sub
End Class
