Imports System.IO
Public Class clipmanager

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Clipboard.ContainsText Then
            Label1.Visible = False
            Label2.Visible = True
            TextBox1.Text = My.Computer.Clipboard.GetText

        Else
            Label1.Visible = True
            Label2.Visible = False
        End If

    End Sub

    Private Sub clipmanager_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Application_Path As String = Application.ExecutablePath()
        Clipboard.Clear()
        Timer1.Start()
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

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Clipboard.Clear()
        TextBox1.Text = ""
        Timer1.Start()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        ListBox1.Items.Add(My.Computer.Clipboard.GetText)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If (ListBox1.SelectedItem <> "") Then
            TextBox2.Text = ListBox1.SelectedItem
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            Clipboard.SetText(TextBox2.Text)
        Else
            MessageBox.Show("You must select an item")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Using SW As New IO.StreamWriter(Application.StartupPath & "\" & "clipboardhistory.txt", True)
            For Each itm As String In Me.ListBox1.Items
                SW.WriteLine(itm)
            Next
        End Using
    End Sub


    Private Sub clipmanager_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.clipmanbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.clipmanbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub clipmanager_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.6
    End Sub

    Private Sub clipmanager_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub
End Class
