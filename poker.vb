Imports System.Threading.Thread
Imports System.IO

Class poker
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Dim Valid As Boolean = True
    Dim Flag As Boolean = False
    Dim CardShown(9) As Byte
    Dim SoundDirPath As String
    'inizializzazione dell'array dei tag delle carte
    Dim CardsTag() As String = {"1P", "2P", "3P", "4P", "5P", "6P", "7P", "8P", "9P", "DP", "JP", "QP", "KP", _
                                 "1F", "2F", "3F", "4F", "5F", "6F", "7F", "8F", "9F", "DF", "JF", "QF", "KF", _
                                 "1Q", "2Q", "3Q", "4Q", "5Q", "6Q", "7Q", "8Q", "9Q", "DQ", "JQ", "QQ", "KQ", _
                                 "1C", "2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "DC", "JC", "QC", "KC"}
    Dim DummyImg(5) As Image
    Const _WinRoyalFlush As Byte = 250
    Const _StraightFlush As Byte = 50
    Const _FourOfAKind As Byte = 25
    Const _FullHouse As Byte = 9
    Const _Flush As Byte = 6
    Const _Straight As Byte = 4
    Const _ThreeOfAKind As Byte = 3
    Const _TwoPairs As Byte = 2
    Const _Pairv As Byte = 1
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


        SoundDirPath = System.AppDomain.CurrentDomain.BaseDirectory() & "Sounds\"
        lbl1.Text = _WinRoyalFlush
        lbl2.Text = _StraightFlush
        lbl3.Text = _FourOfAKind
        lbl4.Text = _FullHouse
        lbl5.Text = _Flush
        lbl6.Text = _Straight
        lbl7.Text = _ThreeOfAKind
        lbl8.Text = _TwoPairs
        lbl9.Text = _Pairv
        ResetCards()
        CardsDefaultBack()
        EnabDisabPlayPushButton(False)

    End Sub
    Sub ResetCards()

        For k As Byte = 0 To 9
            CardShown(k) = False
        Next

    End Sub
    Sub CardsDefaultBack()

        Card1.Image = IL1.Images(52)
        Card2.Image = IL1.Images(52)
        Card3.Image = IL1.Images(52)
        Card4.Image = IL1.Images(52)
        Card5.Image = IL1.Images(52)

    End Sub
    Sub ResetChangeCardOption()

        m1.Checked = False
        m2.Checked = False
        m3.Checked = False
        m4.Checked = False
        m5.Checked = False

    End Sub
    Function CheckCards(ByVal Which) As Boolean

        CheckCards = False
        For k As Byte = 0 To 9
            If CardShown(k) = Which Then
                CheckCards = True
            End If
        Next

    End Function
    Sub EnabDisabPlayPushButton(ByVal YesNot As Boolean)

        m1.Visible = YesNot
        m2.Visible = YesNot
        m3.Visible = YesNot
        m4.Visible = YesNot
        m5.Visible = YesNot

    End Sub
    Sub ShowCard(ByVal MyCheck As CheckBox, ByVal Pic As PictureBox, ByVal Index As Byte, ByVal Volta As Byte)

        Dim carta As Byte

        If MyCheck.Checked OrElse Volta = 2 Then
            If Volta = 1 Then
                Pic.Image = Nothing
                Application.DoEvents()
            End If
            Do
                'genero una nuova generazione di numeri randomici
                Randomize()
                'genero un indice randomico
                carta = Int((51 + 1) * Rnd())
                Application.DoEvents()
            Loop While CheckCards(carta)
            'salvo l'indice della carta
            CardShown(Index) = carta
            'presento la carta
            Pic.Image = IL1.Images(carta)
            'taggo la carta presentata
            Pic.Image.Tag = CardsTag(carta)
            Application.DoEvents()
            Flag = False
            Sound.RunWorkerAsync()
            Do
                Application.DoEvents()
            Loop While Flag = False
        End If

    End Sub
    Sub CheckWin()

        ResetChangeCardOption()
        'controllo se ho vinto
        If RoyalFlush() Then
            SetWinMoney("RoyalFlush")
        ElseIf StraightFlush() Then
            SetWinMoney("StraightFlush")
        ElseIf FourOfAKind() Then
            SetWinMoney("FourOfAKind")
        ElseIf FullHouse() Then
            SetWinMoney("FullHouse")
        ElseIf Flush() Then
            SetWinMoney("Flush")
        ElseIf Straight() Then
            SetWinMoney("Straight")
        ElseIf ThreeOfAKind() Then
            SetWinMoney("ThreeOfAKind")
        ElseIf TwoPairs() Then
            SetWinMoney("TwoPairs")
        ElseIf Pair() Then
            SetWinMoney("Pair")
        End If
        IncrPunt.Enabled = True
        DecrPunt.Enabled = True

    End Sub
    Sub SetWinMoney(ByVal Who As String)

        Select Case Who
            Case "Pair"
                WinBonus(1, "a pair")
            Case "TwoPairs"
                WinBonus(2, "two pairs")
            Case "ThreeOfAKind"
                WinBonus(3, "three of a kind")
            Case "Straight"
                WinBonus(4, "straight")
            Case "Flush"
                WinBonus(6, "flush")
            Case "FullHouse"
                WinBonus(9, "fullhouse")
            Case "FourOfAKind"
                WinBonus(25, "poker")
            Case "StraightFlush"
                WinBonus(50, "straight flush")
            Case "RoyalFlush"
                WinBonus(250, "royal flush")
        End Select

    End Sub
    Sub WinBonus(ByVal Par As Byte, ByVal Str As String)

        Vincita.Text = Convert.ToInt32(Puntata.Text) * Par
        Bonus.Text = Convert.ToInt32(Bonus.Text) + Convert.ToInt32(Vincita.Text)
        MsgBox("Good job dude! You scored " & Str & "! You won a " & Vincita.Text & " bonus!")

    End Sub
    Function RoyalFlush() As Boolean

        Dim colori As String

        RoyalFlush = False
        colori = Mid(Card1.Image.Tag, 2, 1) & _
                 Mid(Card2.Image.Tag, 2, 1) & _
                 Mid(Card3.Image.Tag, 2, 1) & _
                 Mid(Card4.Image.Tag, 2, 1) & _
                 Mid(Card5.Image.Tag, 2, 1)
        If (colori = "PPPPP" OrElse colori = "FFFFF" OrElse colori = "QQQQQ" OrElse colori = "CCCCC") AndAlso _
            ((Card1.Image.Tag = "1P" AndAlso Card2.Image.Tag = "KP" AndAlso Card3.Image.Tag = "QP" AndAlso Card4.Image.Tag = "JP" AndAlso Card5.Image.Tag = "DP") OrElse _
             (Card1.Image.Tag = "1F" AndAlso Card2.Image.Tag = "KF" AndAlso Card3.Image.Tag = "QF" AndAlso Card4.Image.Tag = "JF" AndAlso Card5.Image.Tag = "DF") OrElse _
             (Card1.Image.Tag = "1Q" AndAlso Card2.Image.Tag = "KQ" AndAlso Card3.Image.Tag = "QQ" AndAlso Card4.Image.Tag = "JQ" AndAlso Card5.Image.Tag = "DQ") OrElse _
             (Card1.Image.Tag = "1C" AndAlso Card2.Image.Tag = "KC" AndAlso Card3.Image.Tag = "QC" AndAlso Card4.Image.Tag = "JC" AndAlso Card5.Image.Tag = "DC")) Then
            RoyalFlush = True
        End If

    End Function
    Function StraightFlush() As Boolean

        Dim colori As String

        StraightFlush = False
        colori = Mid(Card1.Image.Tag, 2, 1) & Mid(Card2.Image.Tag, 2, 1) & Mid(Card3.Image.Tag, 2, 1) & Mid(Card4.Image.Tag, 2, 1) & Mid(Card5.Image.Tag, 2, 1)
        If colori = "PPPPP" OrElse colori = "FFFFF" OrElse colori = "QQQQQ" OrElse colori = "CCCCC" Then
            If CheckStraight() Then
                Return True
            End If
        End If

    End Function
    Function FourOfAKind() As Boolean

        FourOfAKind = False

        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card2.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) OrElse _
           (Mid(Card1.Image.Tag, 1, 1) = Mid(Card2.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) OrElse _
           (Mid(Card1.Image.Tag, 1, 1) = Mid(Card2.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) OrElse _
           (Mid(Card1.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1) AndAlso Mid(Card1.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) OrElse _
           (Mid(Card2.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1) AndAlso Mid(Card2.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1) AndAlso Mid(Card2.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) Then
            Return True
        End If

    End Function
    Function FullHouse() As Boolean

        Dim Uno, Due As String
        Dim A, B, C, D, E As String

        FullHouse = False
        Uno = ""
        Due = ""
        A = Mid(Card1.Image.Tag, 1, 1)
        B = Mid(Card2.Image.Tag, 1, 1)
        C = Mid(Card3.Image.Tag, 1, 1)
        D = Mid(Card4.Image.Tag, 1, 1)
        E = Mid(Card5.Image.Tag, 1, 1)

        '    1   2           2   3  
        If ((A = B) AndAlso (B = C)) Then
            Uno = Mid(Card4.Image.Tag, 1, 1)
            Due = Mid(Card5.Image.Tag, 1, 1)
        Else
            '    1   2           2   4  
            If ((A = B) AndAlso (B = D)) Then
                Uno = Mid(Card3.Image.Tag, 1, 1)
                Due = Mid(Card5.Image.Tag, 1, 1)
            Else
                '    1   2           2   5  
                If ((A = B) AndAlso (B = E)) Then
                    Uno = Mid(Card3.Image.Tag, 1, 1)
                    Due = Mid(Card4.Image.Tag, 1, 1)
                Else
                    '    1   3           3   4  
                    If ((A = C) AndAlso (C = D)) Then
                        Uno = Mid(Card2.Image.Tag, 1, 1)
                        Due = Mid(Card5.Image.Tag, 1, 1)
                    Else
                        '    1   3           3   5  
                        If ((A = C) AndAlso (C = E)) Then
                            Uno = Mid(Card2.Image.Tag, 1, 1)
                            Due = Mid(Card4.Image.Tag, 1, 1)
                        Else
                            '    1   4           4   5  
                            If ((A = D) AndAlso (D = E)) Then
                                Uno = Mid(Card2.Image.Tag, 1, 1)
                                Due = Mid(Card3.Image.Tag, 1, 1)
                            Else
                                '    2   3           3   4  
                                If ((B = C) AndAlso (C = D)) Then
                                    Uno = Mid(Card1.Image.Tag, 1, 1)
                                    Due = Mid(Card5.Image.Tag, 1, 1)
                                Else
                                    '    2   3           3   5  
                                    If ((B = C) AndAlso (C = E)) Then
                                        Uno = Mid(Card1.Image.Tag, 1, 1)
                                        Due = Mid(Card4.Image.Tag, 1, 1)
                                    Else
                                        '    2   4           4   5  
                                        If ((B = D) AndAlso (D = E)) Then
                                            Uno = Mid(Card1.Image.Tag, 1, 1)
                                            Due = Mid(Card3.Image.Tag, 1, 1)
                                            If (C = D) AndAlso (D = E) Then
                                                Uno = Mid(Card1.Image.Tag, 1, 1)
                                                Due = Mid(Card2.Image.Tag, 1, 1)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        'se c'è un tris controllo se c'è una coppia
        If Uno <> "" AndAlso Due <> "" Then
            If Uno = Due Then
                Return True
            End If
        End If

    End Function
    Function Flush() As Boolean

        Flush = False
        Dim colori As String

        colori = Mid(Card1.Image.Tag, 2, 1) & _
                 Mid(Card2.Image.Tag, 2, 1) & _
                 Mid(Card3.Image.Tag, 2, 1) & _
                 Mid(Card4.Image.Tag, 2, 1) & _
                 Mid(Card5.Image.Tag, 2, 1)
        If colori = "PPPPP" OrElse colori = "FFFFF" OrElse colori = "QQQQQ" OrElse colori = "CCCCC" Then
            Flush = True
        End If

    End Function
    Function Straight() As Boolean

        Straight = False
        If CheckStraight() Then
            Return True
        End If

    End Function
    Function ThreeOfAKind() As Boolean

        Dim A, B, C, D, E As String

        ThreeOfAKind = False
        A = Mid(Card1.Image.Tag, 1, 1)
        B = Mid(Card2.Image.Tag, 1, 1)
        C = Mid(Card3.Image.Tag, 1, 1)
        D = Mid(Card4.Image.Tag, 1, 1)
        E = Mid(Card5.Image.Tag, 1, 1)
        If ((A = B) AndAlso (B = C)) OrElse ((A = B) AndAlso (B = D)) OrElse ((A = B) AndAlso (B = E)) Then
            Return True
        End If
        If ((A = C) AndAlso (C = D)) OrElse ((A = C) AndAlso (C = E)) OrElse ((A = D) AndAlso (D = E)) Then
            Return True
        End If
        If ((B = C) AndAlso (C = D)) OrElse ((B = C) AndAlso (C = E)) OrElse ((B = D) AndAlso (D = E)) Then
            Return True
        End If
        If (C = D) AndAlso (D = E) Then
            Return True
        End If

    End Function
    Function TwoPairs() As Boolean

        Dim Uno, Due, Tre As String

        TwoPairs = False
        Uno = ""
        Due = ""
        Tre = ""
        'controllo la prima coppia. Salvo l numeri delle carte da controllare per la seconda coppia
        '1 E 2 UGUALI
        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card2.Image.Tag, 1, 1)) Then
            Uno = Card3.Image.Tag
            Due = Card4.Image.Tag
            Tre = Card5.Image.Tag
        Else
            '1 E 3 UGUALI
            If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1)) Then
                Uno = Card2.Image.Tag
                Due = Card4.Image.Tag
                Tre = Card5.Image.Tag
            Else
                '1 E 4 UGUALI
                If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) Then
                    Uno = Card2.Image.Tag
                    Due = Card3.Image.Tag
                    Tre = Card5.Image.Tag
                Else
                    '1 E 5 UGUALI
                    If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) Then
                        Uno = Card2.Image.Tag
                        Due = Card3.Image.Tag
                        Tre = Card4.Image.Tag
                    Else
                        '2 E 3 UGUALI
                        If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1)) Then
                            Uno = Card1.Image.Tag
                            Due = Card4.Image.Tag
                            Tre = Card5.Image.Tag
                        Else
                            '2 E 4 UGUALI
                            If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) Then
                                Uno = Card1.Image.Tag
                                Due = Card3.Image.Tag
                                Tre = Card5.Image.Tag
                            Else
                                '2 E 5 UGUALI
                                If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) Then
                                    Uno = Card1.Image.Tag
                                    Due = Card3.Image.Tag
                                    Tre = Card4.Image.Tag
                                Else
                                    '3 E 4 UGUALI
                                    If (Mid(Card3.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) Then
                                        Uno = Card1.Image.Tag
                                        Due = Card2.Image.Tag
                                        Tre = Card5.Image.Tag
                                    Else
                                        '3 E 5 UGUALI
                                        If (Mid(Card3.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) Then
                                            Uno = Card1.Image.Tag
                                            Due = Card2.Image.Tag
                                            Tre = Card4.Image.Tag
                                        Else
                                            '4 E 5 UGUALI
                                            If (Mid(Card4.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) Then
                                                Uno = Card1.Image.Tag
                                                Due = Card2.Image.Tag
                                                Tre = Card3.Image.Tag
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        'se c'è una coppia controllo se ce n'è un' altra
        If Uno <> "" AndAlso Due <> "" AndAlso Tre <> "" Then
            If Mid(Uno, 1, 1) = Mid(Due, 1, 1) OrElse Mid(Due, 1, 1) = Mid(Tre, 1, 1) OrElse Mid(Uno, 1, 1) = Mid(Tre, 1, 1) Then
                Return True
            End If
        End If

    End Function
    Function Pair() As Boolean

        Pair = False

        'COPPIA 1 E 2 UGUALI E VESTITA
        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card2.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card1.Image.Tag, 1, 1) = "1" OrElse Mid(Card1.Image.Tag, 1, 1) = "J" OrElse Mid(Card1.Image.Tag, 1, 1) = "Q" OrElse Mid(Card1.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card2.Image.Tag, 1, 1) = "1" OrElse Mid(Card2.Image.Tag, 1, 1) = "J" OrElse Mid(Card2.Image.Tag, 1, 1) = "Q" OrElse Mid(Card2.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 1 E 3 UGUALI E VESTITA
        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card1.Image.Tag, 1, 1) = "1" OrElse Mid(Card1.Image.Tag, 1, 1) = "J" OrElse Mid(Card1.Image.Tag, 1, 1) = "Q" OrElse Mid(Card1.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card3.Image.Tag, 1, 1) = "1" OrElse Mid(Card3.Image.Tag, 1, 1) = "J" OrElse Mid(Card3.Image.Tag, 1, 1) = "Q" OrElse Mid(Card3.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 1 E 4 UGUALI E VESTITA
        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card1.Image.Tag, 1, 1) = "1" OrElse Mid(Card1.Image.Tag, 1, 1) = "J" OrElse Mid(Card1.Image.Tag, 1, 1) = "Q" OrElse Mid(Card1.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card4.Image.Tag, 1, 1) = "1" OrElse Mid(Card4.Image.Tag, 1, 1) = "J" OrElse Mid(Card4.Image.Tag, 1, 1) = "Q" OrElse Mid(Card4.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 1 E 5 UGUALI E VESTITA
        If (Mid(Card1.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card1.Image.Tag, 1, 1) = "1" OrElse Mid(Card1.Image.Tag, 1, 1) = "J" OrElse Mid(Card1.Image.Tag, 1, 1) = "Q" OrElse Mid(Card1.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card5.Image.Tag, 1, 1) = "1" OrElse Mid(Card5.Image.Tag, 1, 1) = "J" OrElse Mid(Card5.Image.Tag, 1, 1) = "Q" OrElse Mid(Card5.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        '-----------------------------------
        'COPPIA 2 E 3 UGUALI E VESTITA
        If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card3.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card2.Image.Tag, 1, 1) = "1" OrElse Mid(Card2.Image.Tag, 1, 1) = "J" OrElse Mid(Card2.Image.Tag, 1, 1) = "Q" OrElse Mid(Card2.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card3.Image.Tag, 1, 1) = "1" OrElse Mid(Card3.Image.Tag, 1, 1) = "J" OrElse Mid(Card3.Image.Tag, 1, 1) = "Q" OrElse Mid(Card3.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 2 E 4 UGUALI E VESTITA
        If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card2.Image.Tag, 1, 1) = "1" OrElse Mid(Card2.Image.Tag, 1, 1) = "J" OrElse Mid(Card2.Image.Tag, 1, 1) = "Q" OrElse Mid(Card2.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card4.Image.Tag, 1, 1) = "1" OrElse Mid(Card4.Image.Tag, 1, 1) = "J" OrElse Mid(Card4.Image.Tag, 1, 1) = "Q" OrElse Mid(Card4.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 2 E 5 UGUALI E VESTITA
        If (Mid(Card2.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card2.Image.Tag, 1, 1) = "1" OrElse Mid(Card2.Image.Tag, 1, 1) = "J" OrElse Mid(Card2.Image.Tag, 1, 1) = "Q" OrElse Mid(Card2.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card5.Image.Tag, 1, 1) = "1" OrElse Mid(Card5.Image.Tag, 1, 1) = "J" OrElse Mid(Card5.Image.Tag, 1, 1) = "Q" OrElse Mid(Card5.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        '-----------------------------------
        'COPPIA 3 E 4 UGUALI E VESTITA
        If (Mid(Card3.Image.Tag, 1, 1) = Mid(Card4.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card3.Image.Tag, 1, 1) = "1" OrElse Mid(Card3.Image.Tag, 1, 1) = "J" OrElse Mid(Card3.Image.Tag, 1, 1) = "Q" OrElse Mid(Card3.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card4.Image.Tag, 1, 1) = "1" OrElse Mid(Card4.Image.Tag, 1, 1) = "J" OrElse Mid(Card4.Image.Tag, 1, 1) = "Q" OrElse Mid(Card4.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        'COPPIA 3 E 5 UGUALI E VESTITA
        If (Mid(Card3.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card3.Image.Tag, 1, 1) = "1" OrElse Mid(Card3.Image.Tag, 1, 1) = "J" OrElse Mid(Card3.Image.Tag, 1, 1) = "Q" OrElse Mid(Card3.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card5.Image.Tag, 1, 1) = "1" OrElse Mid(Card5.Image.Tag, 1, 1) = "J" OrElse Mid(Card5.Image.Tag, 1, 1) = "Q" OrElse Mid(Card5.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If
        '-----------------------------------
        'COPPIA 4 E 5 UGUALI E VESTITA
        If (Mid(Card4.Image.Tag, 1, 1) = Mid(Card5.Image.Tag, 1, 1)) AndAlso _
           (Mid(Card4.Image.Tag, 1, 1) = "1" OrElse Mid(Card4.Image.Tag, 1, 1) = "J" OrElse Mid(Card4.Image.Tag, 1, 1) = "Q" OrElse Mid(Card4.Image.Tag, 1, 1) = "K") AndAlso _
           (Mid(Card5.Image.Tag, 1, 1) = "1" OrElse Mid(Card5.Image.Tag, 1, 1) = "J" OrElse Mid(Card5.Image.Tag, 1, 1) = "Q" OrElse Mid(Card5.Image.Tag, 1, 1) = "K") Then
            Return (True)
        End If

    End Function
    Sub SwapImage(ByVal Chkbx As CheckBox, ByVal Crd As PictureBox, ByVal Index As Byte)

        If Valid Then
            If Chkbx.Checked Then
                DummyImg(Index) = Crd.Image
                DummyImg(Index).Tag = "Retro"
                Crd.Image = IL1.Images(52)
                Crd.Image.Tag = "Retro"
            Else
                Crd.Image = DummyImg(Index)
                Crd.Image.Tag = CardsTag(Index)
            End If
            'se tutte le carte non hanno immagine del retro
            If Card1.Image.Tag <> "Retro" AndAlso _
               Card2.Image.Tag <> "Retro" AndAlso _
               Card3.Image.Tag <> "Retro" AndAlso _
               Card4.Image.Tag <> "Retro" AndAlso _
               Card5.Image.Tag <> "Retro" Then
                ScartaTutte.Enabled = True
            Else
                ScartaTutte.Enabled = False
            End If
        End If

    End Sub
    Sub MAKESOUND()

        My.Computer.Audio.Play(SoundDirPath & "laser.wav", AudioPlayMode.WaitToComplete)

    End Sub
    Private Sub Sound_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles Sound.DoWork

        MAKESOUND()

    End Sub
    Private Sub Sound_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles Sound.RunWorkerCompleted

        Flag = True

    End Sub
    Private Sub sound1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles sound1.DoWork

        MAKESOUND()

    End Sub
    Private Sub sound2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles sound2.DoWork

        MAKESOUND()

    End Sub
    Private Sub sound3_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles sound3.DoWork

        MAKESOUND()

    End Sub
    Private Sub sound4_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles sound4.DoWork

        MAKESOUND()

    End Sub
    Private Sub sound1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles sound1.RunWorkerCompleted

        Flag = True

    End Sub
    Private Sub sound2_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles sound2.RunWorkerCompleted

        Flag = True

    End Sub
    Private Sub sound3_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles sound3.RunWorkerCompleted

        Flag = True

    End Sub
    Private Sub sound4_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles sound4.RunWorkerCompleted

        Flag = True

    End Sub
    Function CheckStraight() As Boolean

        Dim Num(4) As Byte
        Dim app As String

        app = Mid(Card1.Image.Tag, 1, 1)
        If app = "1" Then app = 14
        If app = "D" Then app = 10
        If app = "J" Then app = 11
        If app = "Q" Then app = 12
        If app = "K" Then app = 13
        Num(0) = Convert.ToByte(app)
        app = Mid(Card2.Image.Tag, 1, 1)
        If app = "1" Then app = 14
        If app = "D" Then app = 10
        If app = "J" Then app = 11
        If app = "Q" Then app = 12
        If app = "K" Then app = 13
        Num(1) = Convert.ToByte(app)
        app = Mid(Card3.Image.Tag, 1, 1)
        If app = "1" Then app = 14
        If app = "D" Then app = 10
        If app = "J" Then app = 11
        If app = "Q" Then app = 12
        If app = "K" Then app = 13
        Num(2) = Convert.ToByte(app)
        app = Mid(Card4.Image.Tag, 1, 1)
        If app = "1" Then app = 14
        If app = "D" Then app = 10
        If app = "J" Then app = 11
        If app = "Q" Then app = 12
        If app = "K" Then app = 13
        Num(3) = Convert.ToByte(app)
        app = Mid(Card5.Image.Tag, 1, 1)
        If app = "1" Then app = 14
        If app = "D" Then app = 10
        If app = "J" Then app = 11
        If app = "Q" Then app = 12
        If app = "K" Then app = 13
        Num(4) = Convert.ToByte(app)
        Array.Sort(Num)
        If Num(0) + 1 = Num(1) Then
            If Num(1) + 1 = Num(2) Then
                If Num(2) + 1 = Num(3) Then
                    If Num(3) + 1 = Num(4) Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False

    End Function
    Private Sub ScartaTutte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScartaTutte.Click

        m1.Checked = True
        m2.Checked = True
        m3.Checked = True
        m4.Checked = True
        m5.Checked = True
        ScartaTutte.Enabled = False

    End Sub
    Private Sub Uscita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Uscita.Click

        Me.Close()

    End Sub
    Private Sub IncrPunt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IncrPunt.Click

        If ((Convert.ToInt32(Puntata.Text) + 1) <= (Convert.ToInt32(Bonus.Text))) AndAlso (Convert.ToInt32(Puntata.Text + 1) <= 100) Then
            Puntata.Text = Convert.ToInt32(Puntata.Text) + 1
        Else
            MsgBox("This is maximum deal!")
        End If

    End Sub
    Private Sub DecrPunt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DecrPunt.Click

        If Convert.ToInt32(Puntata.Text - 1) > 0 Then
            Puntata.Text = Convert.ToInt32(Puntata.Text) - 1
        Else
            MsgBox("This is minimum deal!")
        End If

    End Sub
    Private Sub m1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m1.CheckedChanged

        SwapImage(m1, Card1, 0)

    End Sub
    Private Sub m2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m2.CheckedChanged

        SwapImage(m2, Card2, 1)

    End Sub
    Private Sub m3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m3.CheckedChanged

        SwapImage(m3, Card3, 2)

    End Sub
    Private Sub m4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m4.CheckedChanged

        SwapImage(m4, Card4, 3)

    End Sub
    Private Sub m5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles m5.CheckedChanged

        SwapImage(m5, Card5, 4)

    End Sub
    Private Sub PlayCards_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlayCards.Click

        Static Flag1 As Byte = 1

        Vincita.Text = 0
        If Convert.ToInt32(Puntata.Text) <= Convert.ToInt32(Bonus.Text) Then
            If Convert.ToInt32(Puntata.Text) > 0 Then
                PlayCards.Enabled = False
                'IncrPunt.Enabled = False
                'DecrPunt.Enabled = False
                If Flag1 = 1 Then
                    Bonus.Text = Convert.ToInt32(Bonus.Text) - Convert.ToInt32(Puntata.Text)
                    Valid = True
                    Flag1 = 2
                    ResetCards()
                    Application.DoEvents()
                    CardsDefaultBack()
                    Application.DoEvents()
                    Sleep(1000)
                    ResetChangeCardOption()
                Else
                    PlayCards.Enabled = False
                    Valid = False
                    Flag1 = 1
                    EnabDisabPlayPushButton(False)
                End If
                ShowCard(m1, Card1, IIf(Flag1 = 2, 0, 5), Flag1)
                ShowCard(m2, Card2, IIf(Flag1 = 2, 1, 6), Flag1)
                ShowCard(m3, Card3, IIf(Flag1 = 2, 2, 7), Flag1)
                ShowCard(m4, Card4, IIf(Flag1 = 2, 3, 8), Flag1)
                ShowCard(m5, Card5, IIf(Flag1 = 2, 4, 9), Flag1)
                'se sto nel secondo giro
                If Flag1 = 1 Then
                    CheckWin()
                Else
                    EnabDisabPlayPushButton(True)
                    ScartaTutte.Enabled = True
                End If
            Else
                MsgBox("Watch out!! The deal must be  > 0!")
            End If
            PlayCards.Enabled = True
        Else
            MsgBox("Bonus is not enough for this deal!")
        End If

    End Sub
    '********************************************************
    '* Solo per scopi di test. Rendere visibile il Button 1 * 
    '********************************************************
    Private Sub Test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Test.Click

        Dim u As Byte = 1
        Dim d As Byte = 2
        Dim t As Byte = 14
        Dim q As Byte = 15
        Dim c As Byte = 27

        Card1.Image = IL1.Images(u)
        Card2.Image = IL1.Images(d)
        Card3.Image = IL1.Images(t)
        Card4.Image = IL1.Images(q)
        Card5.Image = IL1.Images(c)

        Card1.Image.Tag = CardsTag(u)
        Card2.Image.Tag = CardsTag(d)
        Card3.Image.Tag = CardsTag(t)
        Card4.Image.Tag = CardsTag(q)
        Card5.Image.Tag = CardsTag(c)
        Application.DoEvents()
        CheckWin()

    End Sub

    Private Sub poker_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.pokerButtonSmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.pokerButtonSmall.Visible = False
        End If
    End Sub
End Class
