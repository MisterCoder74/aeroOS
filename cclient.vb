Imports System.IO
Imports System.Net.Sockets
Imports System.Text.UTF8Encoding

Public Class cclient
    Dim client As TcpClient
    Dim stream As NetworkStream

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim address As Net.IPAddress
        Net.IPAddress.TryParse(TextBox3.Text, address)
        client = New TcpClient
        client.Connect(address, 8080)
        If client.Connected Then
            stream = client.GetStream
            Timer1.Start()
            TextBox2.Text = TextBox2.Text & "Connessione effettuata a: " & address.ToString & vbCrLf
        Else
            TextBox2.Text = TextBox2.Text & "Impossibile connettere a: " & address.ToString & vbCrLf
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If client.Available > 0 Then
            Dim x(client.Available - 1) As Byte
            stream.Read(x, 0, x.Length)
            Dim text As String = UTF8.GetString(x)
            TextBox2.Text = TextBox2.Text & text & vbCrLf

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim y() As Byte = UTF8.GetBytes("<" & TextBox4.Text & ">" & TextBox1.Text)
        stream.Write(y, 0, y.Length)
        TextBox2.Text = TextBox2.Text & "<" & TextBox4.Text & ">" & TextBox1.Text & vbCrLf
        TextBox1.Text = ""

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim y() As Byte = UTF8.GetBytes("<" & TextBox4.Text & ">" & TextBox1.Text)
            stream.Write(y, 0, y.Length)
            TextBox2.Text = TextBox2.Text & "<" & TextBox4.Text & ">" & TextBox1.Text & vbCrLf
            TextBox1.Text = ""
        End If

    End Sub


    Private Sub cclient_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.ccButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.ccButtonsmall.Visible = False
        End If
    End Sub

    Private Sub cclient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
