Imports System
Imports System.IO
Imports System.Text

Public Class loginregister

    Private Sub loginbutton_Click(sender As System.Object, e As System.EventArgs) Handles loginbutton.Click
        rolebox.Visible = False
        rolelabel.Visible = False
        increasetimer.Enabled = True
        useridlabel.Visible = True
        useridtext.Visible = True
        passtext.Visible = True
        passlabel.Visible = True
        loginokbutton.Visible = True
        registerokbutton.Visible = False
        statuslabel.Visible = False
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub registerbutton_Click(sender As System.Object, e As System.EventArgs) Handles registerbutton.Click
        rolebox.Visible = True
        rolelabel.Visible = True
        increasetimer.Enabled = True
        useridlabel.Visible = True
        useridtext.Visible = True
        passtext.Visible = True
        passlabel.Visible = True
        registerokbutton.Visible = True
        loginokbutton.Visible = False
        statuslabel.Visible = False
        ProgressBar1.Visible = False
        ProgressBar1.Value = 0
    End Sub

    Private Sub increasetimer_Tick(sender As System.Object, e As System.EventArgs) Handles increasetimer.Tick
        Do Until Me.Height = 280
            Me.Height = Me.Height + 4

        Loop
        increasetimer.Enabled = False
    End Sub

    Private Sub loginokbutton_Click(sender As System.Object, e As System.EventArgs) Handles loginokbutton.Click
        Try
            Dim npath As String = My.Settings.rootdir & "\users\users.txt"
            Dim nsr As StreamReader = File.OpenText(npath)
            Dim ls As String
            Do While nsr.Peek() >= 0
                ls = nsr.ReadLine()
                'Label8.Text = ls
                Dim params(2) As String
                params = ls.Split("^"c)
                If params(0) = useridtext.Text Then
                    Dim role As String = params(1)
                    My.Settings.loggedrole = role

                
                End If

            Loop
            nsr.Close()
            If Not Directory.Exists(My.Settings.rootdir & "\users\" & useridtext.Text.ToString & passtext.Text.ToString & My.Settings.loggedrole) Then

                MsgBox("User " & useridtext.Text.ToString & " does not exist or wrong password")

            Else
                statuslabel.Visible = True
                ProgressBar1.Visible = True
                rolelabel.Visible = False
                rolebox.Visible = False
                statuslabel.Text = "Loading profile for " & useridtext.Text
                logintimer.Start()
                My.Settings.loggedinuser = useridtext.Text
                My.Settings.loggedinbaseurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole
                My.Settings.loggedinconfurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\conf"
                My.Settings.loggedinmediaurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\media"
                My.Settings.loggedindocsurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\docs"
                My.Settings.loggedinreceivedurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\received"
                My.Settings.Save()
                My.Settings.Reload()
            End If
        Catch ex As Exception
            MsgBox("Unable to access " & useridtext.Text)
        
        End Try
    End Sub

    Private Sub registerokbutton_Click(sender As System.Object, e As System.EventArgs) Handles registerokbutton.Click
        Try
            ProgressBar1.Value = 0
            Dim role As String
            If rolebox.SelectedItem = "admin" Then
                role = "001"
            ElseIf rolebox.SelectedItem = "super user" Then
                role = "002"
            ElseIf rolebox.SelectedItem = "user" Then
                role = "003"
            End If
            If Not Directory.Exists(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role) Then
                statuslabel.Visible = True
                ProgressBar1.Visible = True
                statuslabel.Text = "Creating profile for " & useridtext.Text


                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role)
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\media")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\docs")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf")
                My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\received")
                My.Settings.Save()
                My.Settings.Reload()
                Dim path As String = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf\" & "configuration.txt"
                Dim sw As StreamWriter
                If File.Exists(path) = False Then
                    sw = File.CreateText(path)
                    'sw.Flush()
                    'sw.Close()
                End If
                path = My.Settings.rootdir & "\users\" & "users.txt"
                If File.Exists(path) = False Then
                    sw = File.CreateText(path)
                    sw.WriteLine(useridtext.Text & "^" & role)
                    sw.Flush()
                    sw.Close()
                Else
                    sw = File.AppendText(path)
                    sw.WriteLine(useridtext.Text & "^" & role)
                    sw.Flush()
                    sw.Close()
                End If
                ProgressBar1.Value = 100
                statuslabel.Text = "User creation complete"
            Else
                MsgBox("User already exists")
            End If
        Catch ex As Exception
            MsgBox("Unable to create profile for " & useridtext.Text & " - " & ex.Message)
        End Try
    End Sub

    Private Sub logintimer_Tick(sender As System.Object, e As System.EventArgs) Handles logintimer.Tick

        If My.Settings.startupsound = "" Then
            My.Settings.startupsound = My.Settings.rootdir & "\Sounds\Ball_Blasta02.wav"
            My.Settings.Save()
            My.Settings.Reload()
        End If

        ProgressBar1.Increment(4)
        If ProgressBar1.Value = 4 Then
            statuslabel.Text = "Validating user credentials"
        ElseIf ProgressBar1.Value = 16 Then
            statuslabel.Text = "Loading user preferences"
        ElseIf ProgressBar1.Value = 28 Then
            statuslabel.Text = "Creating desktop environment"
        ElseIf ProgressBar1.Value = 36 Then
            statuslabel.Text = "Retrieving icons and media"
        ElseIf ProgressBar1.Value = 52 Then
            statuslabel.Text = "Loading used permissions"
        ElseIf ProgressBar1.Value = 68 Then
            statuslabel.Text = "Applying user customized environment"
        ElseIf ProgressBar1.Value = 80 Then
            statuslabel.Text = "Starting Aero session..."
        ElseIf ProgressBar1.Value = ProgressBar1.Maximum Then
            'lancia il form aero
            Me.Hide()
            aero.Show()
            My.Computer.Audio.Play(My.Settings.startupsound, AudioPlayMode.Background)
            logintimer.Stop()
        End If

    End Sub

    Private Sub loginregister_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        Me.Height = 148
        If My.Settings.rootdir = "" Then
            loginokbutton.Enabled = False
            registerokbutton.Enabled = False
            rootbox.Visible = True
            rootbutton.Visible = True
            rootlabel.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles rootbutton.Click
        Dim rootf As New FolderBrowserDialog
        If rootf.ShowDialog = DialogResult.OK Then
            rootbox.Text = rootf.SelectedPath
            My.Settings.rootdir = rootf.SelectedPath
            My.Settings.Save()
            My.Settings.Reload()

        End If
        loginokbutton.Enabled = True
        registerokbutton.Enabled = True
    End Sub

    Private Sub passtext_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles passtext.KeyDown
        If e.KeyCode = Keys.Enter Then
            If loginokbutton.Visible = True Then
                Try
                    Dim npath As String = My.Settings.rootdir & "\users\users.txt"
                    Dim nsr As StreamReader = File.OpenText(npath)
                    Dim ls As String
                    Do While nsr.Peek() >= 0
                        ls = nsr.ReadLine()
                        'Label8.Text = ls
                        Dim params(2) As String
                        params = ls.Split("^"c)
                        If params(0) = useridtext.Text Then
                            Dim role As String = params(1)
                            My.Settings.loggedrole = role


                        End If

                    Loop
                    nsr.Close()
                    If Not Directory.Exists(My.Settings.rootdir & "\users\" & useridtext.Text.ToString & passtext.Text.ToString & My.Settings.loggedrole) Then

                        MsgBox("User " & useridtext.Text.ToString & " does not exist or wrong password")
                    Else
                        statuslabel.Visible = True
                        ProgressBar1.Visible = True
                        rolelabel.Visible = False
                        rolebox.Visible = False
                        statuslabel.Text = "Loading profile for " & useridtext.Text
                        logintimer.Start()
                        My.Settings.loggedinuser = useridtext.Text
                        My.Settings.loggedinbaseurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole
                        My.Settings.loggedinconfurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\conf"
                        My.Settings.loggedinmediaurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\media"
                        My.Settings.loggedindocsurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\docs"
                        My.Settings.loggedinreceivedurl = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & My.Settings.loggedrole & "\received"
                        My.Settings.Save()
                        My.Settings.Reload()
                    End If
                Catch ex As Exception
                    MsgBox("Unable to access " & useridtext.Text)
                End Try
            ElseIf registerokbutton.Visible = True Then
                Try
                    ProgressBar1.Value = 0
                    Dim role As String = ""
                    If rolebox.SelectedText = "admin" Then
                        role = "001"
                    ElseIf rolebox.SelectedText = "super user" Then
                        role = "002"
                    ElseIf rolebox.SelectedText = "user" Then
                        role = "003"
                    End If
                    If Not Directory.Exists(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role) Then
                        statuslabel.Visible = True
                        ProgressBar1.Visible = True
                        statuslabel.Text = "Creating profile for " & useridtext.Text


                        My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role)
                        My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\media")
                        My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\docs")
                        My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf")
                        My.Computer.FileSystem.CreateDirectory(My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\received")
                        My.Settings.Save()
                        My.Settings.Reload()
                        Dim path As String = My.Settings.rootdir & "\users\" & useridtext.Text & passtext.Text & role & "\conf\" & "configuration.txt"
                        Dim sw As StreamWriter
                        If File.Exists(path) = False Then
                            sw = File.CreateText(path)
                            'sw.Flush()
                            'sw.Close()
                        End If
                        path = My.Settings.rootdir & "\users\" & "users.txt"
                        If File.Exists(path) = False Then
                            sw = File.CreateText(path)
                            sw.WriteLine(useridtext.Text & "^" & role)
                            sw.Flush()
                            sw.Close()
                        Else
                            sw = File.AppendText(path)
                            sw.WriteLine(useridtext.Text & "^" & role)
                            sw.Flush()
                            sw.Close()
                        End If
                        ProgressBar1.Value = 100
                        statuslabel.Text = "User creation complete"
                    Else
                        MsgBox("User already exists")
                    End If
                Catch ex As Exception
                    MsgBox("Unable to create profile for " & useridtext.Text & " " & ex.Message)
                End Try
            End If
        End If

    End Sub
End Class
