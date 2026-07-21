Imports System.IO
Imports System.Net.Mail
Public Class emailer
    Dim message As New MailMessage
    Dim smtp As New SmtpClient

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        message.From = New MailAddress(TextBox1.Text)
        message.To.Add(TextBox2.Text)
        message.Body = TextBox3.Text
        message.Subject = TextBox4.Text
        If CheckBox1.Checked = True Then
            Dim files = TextBox5.Text
            message.Attachments.Add(New Attachment(files))
        End If
        smtp.Host = hostTextbox.Text
        If hostTextbox.Text = "" Then
            MsgBox("STMP server not set - please check settings")
        End If
        smtp.Send(message)
        MsgBox("Email sent to: " & TextBox2.Text)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub emailer_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.wmButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.wmButtonsmall.Visible = False
        End If

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox5.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub emailer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        'hostTextbox.Text = My.Settings.mailserve
        If hostTextbox.Text = "" Then
            MsgBox("STMP server not set - please select SMTP server from the Settings application")
        End If
    End Sub
End Class