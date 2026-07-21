Imports System.IO
Public Class calc
    Dim text1 As Boolean
    Dim text2 As Boolean
    Dim text3 As Boolean
    Dim mem As Integer

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox3.Text = Val(TextBox1.Text) ^ Val(TextBox2.Text)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "1"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "1"
        End If
    End Sub

    Private Sub TextBox1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox1.MouseClick
        text1 = True
        text2 = False
        text3 = False
    End Sub

    Private Sub TextBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TextBox2.MouseClick
        text2 = True
        text1 = False
        text3 = False
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "2"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "2"
        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "3"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "3"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "4"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "4"
        End If
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "5"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "5"
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "6"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "6"
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "7"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "7"
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "8"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "8"
        End If
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "9"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "9"
        End If
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "0"
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "0"
        End If
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub calc_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.clButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.clButtonsmall.Visible = False
        End If
    End Sub

    Private Sub Button17_Click_1(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        If text1 = True Then
            mem = Val(TextBox1.Text)
        End If
        If text2 = True Then
            mem = Val(TextBox2.Text)
        End If
        If text3 = True Then
            mem = Val(TextBox3.Text)
        End If
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        If text1 = True Then
            TextBox1.Text = mem.ToString
        End If
        If text2 = True Then
            TextBox2.Text = mem.ToString
        End If
    End Sub

    Private Sub TextBox3_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TextBox3.MouseClick
        text2 = False
        text1 = False
        text3 = True
    End Sub


    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        If text1 = True Then
            TextBox1.Text = TextBox1.Text & "."
        End If
        If text2 = True Then
            TextBox2.Text = TextBox2.Text & "."
        End If
    End Sub

    Private Sub calc_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Try
            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
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