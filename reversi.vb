Imports System.IO

Public Class reversi
    Public WithEvents gameEngine As New clsGameEngine
    Public newGame As Boolean = True
    Dim typeGame As clsGameEngine.gameType

    Private Sub dimForm()
        Me.Size = New Size((clsGameEngine.CaseSize + clsGameEngine.MarginSize) * gameEngine.gameSize + 6, (clsGameEngine.CaseSize + clsGameEngine.MarginSize) * gameEngine.gameSize)
    End Sub

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub picGame_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picGame.MouseClick

        If (gameEngine.MyTurn And gameEngine.CanPlay) = True Then
            Dim X As Short, Y As Short

            X = Math.Truncate(e.X / (clsGameEngine.CaseSize + clsGameEngine.MarginSize))
            Y = Math.Truncate(e.Y / (clsGameEngine.CaseSize + clsGameEngine.MarginSize))

            If X < gameEngine.gameSize And Y < gameEngine.gameSize Then
                gameEngine.play(X, Y, True)
            End If

        End If

    End Sub

    Private Sub gameUpdate(ByVal bit As Bitmap) Handles gameEngine.boardUpdated

        picGame.Image = bit
        picGame.Refresh()
        If gameEngine.MyTurn Then
            Me.StatusStrip1.BackColor = Color.LightGreen
        Else
            Me.StatusStrip1.BackColor = Color.OrangeRed
        End If

        Me.lblScore.Text = gameEngine.pawnsPlayer.ToString
        Me.lblSCoreAdv.Text = gameEngine.pawnsOpponent.ToString()

        Me.StatusStrip1.Refresh()

    End Sub

    Private Sub frmGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        PictureBox.CheckForIllegalCrossThreadCalls = False
        typeGame = clsGameEngine.gameType.localEasy
        gameEngine.initGame(typeGame)

        If newGame = False Then Exit Sub
        dimForm()
        newGame = False

        If gameEngine.typePartie = clsGameEngine.gameType.localEasy Or gameEngine.typePartie = clsGameEngine.gameType.localHard Then
            gameEngine.startIaGame()
        Else
            If gameEngine.typePartie = clsGameEngine.gameType.remoteHost Then
                Me.StatusStrip1.BackColor = Color.LightGreen
            Else
                Me.StatusStrip1.BackColor = Color.OrangeRed
            End If
            Me.StatusStrip1.Refresh()
        End If
        newGame = True
    End Sub


    Private Sub reversi_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.reversibuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.reversibuttonsmall.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        MessageBox.Show("Thank you for playing SuperOthello =]" & vbCrLf & vbCrLf & "Game programmed by Kite37 (See profile on VBFrance.com for more information)." _
                       & vbCrLf & "A great idea for a new game!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
