Imports System.IO, System.Diagnostics, System.ComponentModel
Public Class recent
    Dim RecentFolderPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Recent)
    Private Sub recent_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim spath As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(spath)
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

        ListView1.Items.Clear()
        Dim lstitem As New ListViewItem()
        For Each RecentFile1 In Directory.GetFiles(RecentFolderPath)
            lstitem = ListView1.Items.Add(RecentFile1, RecentFile1)
            lstitem.SubItems.Add(New FileInfo(RecentFile1).CreationTime.ToShortDateString() & " @ " & New FileInfo(RecentFile1).CreationTime.ToShortTimeString())
            lstitem.SubItems.Add(Path.GetFileNameWithoutExtension(RecentFile1))
        Next
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        Label1.Text = "File path: " & ListView1.SelectedItems(0).Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start(ListView1.SelectedItems(0).Text)
        Catch m As Win32Exception
        End Try
    End Sub

    Private Sub recent_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.recentbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.recentbuttonsmall.Visible = False
        End If
    End Sub
End Class