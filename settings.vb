Imports System.Net
Imports System.IO
Imports System

Public Class settings
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub


    Private Sub settings_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.cpButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.cpButtonsmall.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'browser.TextBox1.Text = Me.TextBox1.Text
        My.Settings.Home = TextBox1.Text
        My.Settings.mailserve = ComboBox1.SelectedItem
        My.Settings.Save()
        My.Settings.Reload()
        If ComboBox1.SelectedItem = "Alice" Then
            emailer.hostTextbox.Text = "out.alice.it"
        ElseIf ComboBox1.SelectedItem = "LiveMail" Then
            emailer.hostTextbox.Text = "smtp.live.com"
        ElseIf ComboBox1.SelectedItem = "hMail" Then
            emailer.hostTextbox.Text = "mail.hmailserver.com"
        End If
    End Sub

    Private Sub settings_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim gpath As String = My.Settings.rootdir & "\users\users.txt"
        Dim nsg As StreamReader = File.OpenText(gpath)
        Dim gs As String
        Do While nsg.Peek() >= 0
            gs = nsg.ReadLine()
            'Label8.Text = ls
            Dim params(2) As String
            params = gs.Split("^"c)
            If params(0) = My.Settings.loggedinuser Then
                Dim role As String = params(1)
                My.Settings.loggedrole = role


            End If

        Loop
        nsg.Close()

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



        'se l' utente non é Admin disabilita il reset di Aero
        If My.Settings.loggedrole = "003" Then
            Me.Button10.Enabled = False
            Me.Button8.Enabled = False
        ElseIf My.Settings.loggedrole = "002" Then
            Me.Button10.Enabled = False

        End If

        TextBox1.Text = My.Settings.Home
        ComboBox1.Items.Add("Alice")
        ComboBox1.Items.Add("LiveMail")
        ComboBox1.Items.Add("hMail")
        ComboBox1.SelectedItem = My.Settings.mailserve
        If ComboBox1.SelectedItem = "Alice" Then
            emailer.hostTextbox.Text = "out.alice.it"
        ElseIf ComboBox1.SelectedItem = "LiveMail" Then
            emailer.hostTextbox.Text = "smtp.live.com"
        ElseIf ComboBox1.SelectedItem = "hMail" Then
            emailer.hostTextbox.Text = "mail.hmailserver.com"
        End If
        Label10.Text = Screen.PrimaryScreen.Bounds.Width & "x" & Screen.PrimaryScreen.Bounds.Height
        Dim freesysspace As Long
        Dim n As Environment
        freesysspace = My.Computer.FileSystem.GetDriveInfo("C:\").AvailableFreeSpace / 1000000000
        Label3.Text = "System disk free space: " & freesysspace & " GB"
        Label4.Text = "Host name: " & n.MachineName.ToString
        Label5.Text = "Base OS:  " & My.Computer.Info.OSFullName.ToString
        Label14.Text = "Base OS version:  " & My.Computer.Info.OSVersion.ToString
        If My.Settings.loggedrole = "001" Then
            Label15.Text = "Role: Admin"
        ElseIf My.Settings.loggedrole = "002" Then
            Label15.Text = "Role: Super User"
        ElseIf My.Settings.loggedrole = "003" Then
            Label15.Text = "Role: User"
        End If

        Label7.Text = "UserID: " & My.Settings.loggedinuser
        Label8.Text = "User base folder: " & My.Settings.loggedinbaseurl
        If My.Computer.Network.IsAvailable = True Then
            Label6.Text = "Connection status: OK"
        Else
            Label6.Text = "Connection status: Broken"
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        selectbck.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        externalsetup.Show()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        dancersetup.Show()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        startupmusic.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        thememanager.Show()
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        newroot.Show()
    End Sub

    Private Sub GroupBox3_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        devices.Show()
    End Sub
    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        If System.IO.File.Exists(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "custombuttons.txt") = True Then
            iconssetup.Show()
        Else
            MsgBox("No Icons on Desktop or no definition file detected")
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        dancerladysetup.Show()
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        Select Case MsgBox("Resetting Aero will delete ALL your user accounts and personal settings!", MsgBoxStyle.YesNoCancel, "WARNING!")
            Case MsgBoxResult.Yes
                If System.IO.File.Exists(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\chronology.html") = True Then
                    System.IO.File.Delete(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\chronology.html")
                End If
                If System.IO.File.Exists(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\bookmarks.html") = True Then
                    System.IO.File.Delete(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\bookmarks.html")
                End If
                My.Settings.loadeddictionary = String.Empty
                For Each filename As String In IO.Directory.GetFiles(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole, "*.*")
                    IO.File.Delete(filename)
                Next
                My.Computer.FileSystem.DeleteDirectory(My.Settings.rootdir & "\users\", FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
                My.Settings.rootdir = ""
                My.Settings.startupsound = ""
                MessageBox.Show("Aero environment has been reset")
            Case MsgBoxResult.Cancel
                MessageBox.Show("Action Cancelled")
            Case MsgBoxResult.No
                MessageBox.Show("Action Cancelled")
        End Select
    End Sub


 
End Class