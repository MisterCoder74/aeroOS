Imports System.IO

Public Class saveform
    Private Sub DriveListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DriveListBox1.SelectedIndexChanged
        DirListBox1.Path = Microsoft.VisualBasic.Left(DriveListBox1.Drive, 2)

    End Sub

    Private Sub DirListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DirListBox1.SelectedIndexChanged

        FileListBox1.Path = DirListBox1.Path
        FileListBox1.Pattern = "*.txt"
    End Sub

    Private Sub FileListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles FileListBox1.SelectedIndexChanged
        On Error Resume Next

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim spath As String
        spath = FileListBox1.Path & "\" & TextBox1.Text & ".txt"
        My.Computer.FileSystem.WriteAllText(spath, note.TextBox1.Text, False)
        Me.Close()
    End Sub

    Private Sub saveform_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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


    End Sub
End Class