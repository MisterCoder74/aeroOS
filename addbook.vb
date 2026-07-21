Imports System.IO
Public Class addbook

    Private Sub addbookbutton_Click(sender As System.Object, e As System.EventArgs) Handles addbookbutton.Click
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\bookmarks.html"
        Dim sw As StreamWriter
        Dim wb As CustomTabbedBrowser = browser.TabControl1.SelectedTab.Tag
        Try

            If File.Exists(path) = False Then

                MsgBox("Bookmark file does not exist. It will be created.")
                sw = File.CreateText(path)
                sw.WriteLine("<body bgcolor=#33FF66><center><h2>Aero 2018 Browser HTML Bookmarks</h2> <h4>Automatically generated on first use</h4><br width = 40%><TABLE CELLPADDING=3 CELLSPACING=5 BORDER=1 ALIGN=CENTER VALIGN=MIDDLE><TR>	<TD ALIGN=CENTER VALIGN=MIDDLE> <a href=" & wb.Url.ToString & ">" & TextBox1.Text & "</a> </TD></TR></TABLE>")
                sw.Flush()
                sw.Close()
                Label2.Visible = True
            Else
                sw = File.AppendText(path)
                sw.WriteLine("<TABLE CELLPADDING=3 CELLSPACING=5 BORDER=1 ALIGN=CENTER VALIGN=MIDDLE><TR>	<TD ALIGN=CENTER VALIGN=MIDDLE> <a href=" & wb.Url.ToString & ">" & TextBox1.Text & "</a> </TD></TR></TABLE>")
                sw.Flush()
                sw.Close()
                Label2.Visible = True
            End If

        Catch ex As Exception
            MsgBox("Unable to add bookmark to file")
        End Try

    End Sub

    Private Sub addbook_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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