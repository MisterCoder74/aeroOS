Imports System
Imports System.IO
Imports System.Text
Public Class usersadmin

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim role As String
        If Rolebox.SelectedItem = "admin" Then
            role = "001"
        ElseIf Rolebox.SelectedItem = "super user" Then
            role = "002"
        ElseIf Rolebox.SelectedItem = "user" Then
            role = "003"
        End If

        Try
            If Not Directory.Exists(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole) Then
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role)
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\media")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\docs")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\received")

                Dim path As String = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf\" & "configuration.txt"
                Dim sw As StreamWriter

                If Not File.Exists(path) Then
                    sw = File.CreateText(path)
                    'sw.WriteLine("CONFIGURATION FILE FOR: " & useridtext.Text)
                    'sw.Flush()
                    'sw.Close()
                End If

                path = My.Settings.rootdir & "\users\" & "users.txt"
                If File.Exists(path) = False Then
                    sw = File.CreateText(path)
                    sw.WriteLine(useridtext.Text & "^" & role)
                    sw.Flush()
                    sw.Close()
                    Dim sr As StreamReader = File.OpenText(path)
                    Dim s As String
                    Do While sr.Peek() >= 0
                        s = sr.ReadLine()
                        ListBox1.Items.Add(s)
                    Loop
                    sr.Close()


                Else
                    sw = File.AppendText(path)
                    sw.WriteLine(useridtext.Text & "^" & role)
                    sw.Flush()
                    sw.Close()
                    Dim sr As StreamReader = File.OpenText(path)
                    Dim s As String
                    ListBox1.Items.Clear()
                    Do While sr.Peek() >= 0
                        s = sr.ReadLine()
                        ListBox1.Items.Add(s)
                    Loop
                    sr.Close()

                End If
                useridtext.Text = ""
                passtext.Text = ""
                MsgBox("User account successfully created")

                ' per leggere dal file togliere il commento
                'Dim sr As StreamReader = File.OpenText(path)
                'Dim s As String
                'Do While sr.Peek() >= 0
                's = sr.ReadLine()
                'Console.WriteLine(s)
                'Loop
                'sr.Close()

            Else
                MsgBox("User already exists")
            End If
        Catch ex As Exception
            MsgBox("Unable to create profile for " & useridtext.Text & " " & ex.Message)
        End Try

    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub usersadmin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim upath As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim usr As StreamReader = File.OpenText(upath)
        Dim us As String
        Try
            Do While usr.Peek() >= 0
                us = usr.ReadLine()
                If us = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf us = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf us = "My.Resources.alternative2" Then
                    Me.BackgroundImage = My.Resources.alternative2
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf us = "My.Resources.alternative3" Then
                    Me.BackgroundImage = My.Resources.alternative3
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf us = "My.Resources.alternative4" Then
                    Me.BackgroundImage = My.Resources.alternative4
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf us = "My.Resources.alternative5" Then
                    Me.BackgroundImage = My.Resources.alternative5
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If
            Loop
            usr.Close()
        Catch ex As Exception
        End Try

        If My.Settings.loggedrole = "003" Then
            Me.Button2.Enabled = False
            Rolebox.Items.Clear()
            Rolebox.Items.Add("user")
        ElseIf My.Settings.loggedrole = "002" Then
            Rolebox.Items.Clear()
            Rolebox.Items.Add("super user")
            Rolebox.Items.Add("user")
        ElseIf My.Settings.loggedrole = "001" Then
            Rolebox.Items.Clear()
            Rolebox.Items.Add("admin")
            Rolebox.Items.Add("super user")
            Rolebox.Items.Add("user")
        End If

        Dim path As String = My.Settings.rootdir & "\users\users.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Do While sr.Peek() >= 0
            s = sr.ReadLine()
            ListBox1.Items.Add(s)
        Loop
        sr.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        Dim gs As String = ListBox1.SelectedItem.ToString
        'Label8.Text = ls
        Dim params(2) As String
        params = gs.Split("^"c)

        If Not params(0) = My.Settings.loggedinuser And My.Settings.loggedrole = "001" Then
            Dim path As String = My.Settings.rootdir & "\users\users.txt"



            'Cancella la struttura di directory dell' utente 
            Dim pathstodelete As String() = Directory.GetDirectories(My.Settings.rootdir & "\users\", params(0) & "*")
            Dim pathtodelete As String
            For Each pathtodelete In pathstodelete
                My.Computer.FileSystem.DeleteDirectory(pathtodelete, FileIO.DeleteDirectoryOption.DeleteAllContents)
            Next


            'Elimina il testo dalla listbox e scrive nel file
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            Using Writer = New StreamWriter(path)
                For Each o As Object In ListBox1.Items
                    Writer.WriteLine(o)
                Next
            End Using
            MsgBox("Selected user successfully deleted")
        Else
            MsgBox("Unable to delete selected user - You are trying to delete yor own user or you don't have an adequate role.")

        End If


    End Sub

    Private Sub usersadmin_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.adminbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.adminbuttonsmall.Visible = False
        End If
    End Sub

 
End Class