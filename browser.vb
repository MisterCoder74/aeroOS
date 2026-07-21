Imports System.IO
Public Class browser
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub


    Public Sub AddTab(ByRef URL As String, ByRef TabControl As TabControl)
        Dim NewBrowser As New CustomTabbedBrowser
        Dim NewTab As New TabPage
        NewBrowser.Tag = NewTab
        NewBrowser.Name = "newbrowser"
        NewBrowser.IsWebBrowserContextMenuEnabled = False
        NewTab.Tag = NewBrowser
        TabControl.TabPages.Add(NewTab)
        NewTab.Controls.Add(NewBrowser)
        NewBrowser.Dock = DockStyle.Fill
        NewBrowser.ContextMenuStrip = ContextMenuStrip1
        NewBrowser.Navigate(URL)


    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

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
        TextBox1.Text = My.Settings.Home
        AddTab("google.com", TabControl1)
        Button8.Enabled = False


    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.GoBack()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.GoForward()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.Navigate(My.Settings.Home)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.Refresh()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AddTab("about:blank", TabControl1)

    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If TabControl1.TabPages.Count = 1 Then
            Me.Close()
        Else
            TabControl1.TabPages.Remove(TabControl1.SelectedTab)

        End If
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
            Dim toUrl As String = ComboBox1.Text.ToString
            wb.Navigate(toUrl)
            ComboBox1.Items.Add(ComboBox1.Text)
        End If
    End Sub


    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        TabControl1.Visible = False
        Button7.Enabled = False
        Button8.Enabled = True

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        TabControl1.Visible = True
        Button7.Enabled = True
        Button8.Enabled = False
    End Sub

    Private Sub browser_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.wbButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.wbButtonsmall.Visible = False
        End If
    End Sub

    Private Sub printpagebutton_Click(sender As System.Object, e As System.EventArgs) Handles printpagebutton.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.ShowPrintDialog()
    End Sub

    Private Sub savepagebutton_Click(sender As System.Object, e As System.EventArgs) Handles savepagebutton.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.ShowSaveAsDialog()
    End Sub

    Private Sub htmlbookaddbutton_Click(sender As System.Object, e As System.EventArgs) Handles htmlbookaddbutton.Click
        addbook.Show()
    End Sub

    Private Sub htmlbookloadbutton_Click(sender As System.Object, e As System.EventArgs) Handles htmlbookloadbutton.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.Navigate("file:///" & My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\bookmarks.html")
    End Sub

    Private Sub Button3_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button3.MouseHover
        Button3.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button4_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button4.MouseHover
        Button4.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button4_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.Black
    End Sub

    Private Sub Button5_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button5.MouseHover
        Button5.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button5_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button5.MouseLeave
        Button5.ForeColor = Color.Black
    End Sub

    Private Sub Button6_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button6.MouseHover
        Button6.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button6_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button6.MouseLeave
        Button6.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button1.MouseHover
        Button1.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button2.MouseHover
        Button2.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button7_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button7.MouseHover
        Button7.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button7.MouseLeave
        Button7.ForeColor = Color.Black
    End Sub

    Private Sub Button8_MouseHover(sender As System.Object, e As System.EventArgs) Handles Button8.MouseHover
        Button8.ForeColor = Color.DarkSeaGreen
    End Sub

    Private Sub Button8_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.Black
    End Sub

    Private Sub chronbutton_Click(sender As System.Object, e As System.EventArgs) Handles chronbutton.Click
        AddTab("file:///" & My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "chronology.html", TabControl1)
        
    End Sub

    Private Sub OpenInNewTabToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenInNewTabToolStripMenuItem.Click
        Try
            Dim NewBrowser As New CustomTabbedBrowser
            NewBrowser.Name = "newbrowser"
            NewBrowser.Url = (New Uri(DirectCast(Me.TabControl1.SelectedTab.Controls("newbrowser"), WebBrowser).Document.ActiveElement.GetAttribute("href")))
            Dim NewTab As New TabPage
            NewBrowser.Tag = NewTab
            NewBrowser.IsWebBrowserContextMenuEnabled = False
            NewTab.Tag = NewBrowser
            TabControl1.TabPages.Add(NewTab)
            NewTab.Controls.Add(NewBrowser)
            NewBrowser.Dock = DockStyle.Fill
            NewBrowser.ContextMenuStrip = ContextMenuStrip1
        Catch ex As Exception
            MsgBox("No link selected or region does not contain links")
        End Try



    End Sub

    Private Sub SavePageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SavePageToolStripMenuItem.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.ShowSaveAsDialog()
    End Sub

    Private Sub PrintPageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PrintPageToolStripMenuItem.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        wb.ShowPrintDialog()
    End Sub

    Private Sub AddToHTMLBookmarksToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AddToHTMLBookmarksToolStripMenuItem.Click
        addbook.Show()
    End Sub

    Private Sub sourcepagebutton_Click(sender As System.Object, e As System.EventArgs) Handles sourcepagebutton.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        Dim htmlSourceCode As String = New System.Net.WebClient().DownloadString(wb.Url)
        notepad.doc.Text = htmlSourceCode
        notepad.Text = "HTML source for: " & wb.DocumentTitle
        notepad.Show()
    End Sub

    Private Sub GetPageSourceToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GetPageSourceToolStripMenuItem.Click
        Dim wb As CustomTabbedBrowser = Me.TabControl1.SelectedTab.Tag
        Dim htmlSourceCode As String = New System.Net.WebClient().DownloadString(wb.Url)
        notepad.doc.Text = htmlSourceCode
        notepad.Text = "HTML source for: " & wb.DocumentTitle
        notepad.Show()

    End Sub
End Class
Public Class CustomTabbedBrowser
    Inherits WebBrowser
    Public Sub New()
        Me.ScriptErrorsSuppressed = True
    End Sub
    Private Sub DocCompleted() Handles Me.DocumentCompleted
        browser.ComboBox1.Text = Me.Url.ToString
        browser.ComboBox1.Items.Add(browser.ComboBox1.Text)
        Dim TP As TabPage = Me.Tag
        If Me.DocumentTitle.Length > 15 Then
            TP.Text = Me.DocumentTitle.Substring(0, 14) & "..."
        Else
            TP.Text = Me.DocumentTitle
        End If
        'salva nel file chronology

        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "chronology.html"
        Dim sw As StreamWriter
        Dim wb As CustomTabbedBrowser = browser.TabControl1.SelectedTab.Tag
        Try

            If File.Exists(path) = False Then

                MsgBox("Chronology file does not exist. It will be created.")
                sw = File.CreateText(path)
                sw.WriteLine("<body bgcolor=#33FF66><center><h2>Aero 2018 Browser Chronology</h2> <h4>Automatically generated on first use</h4><br width = 40%><TABLE CELLPADDING=3 CELLSPACING=5 BORDER=1 ALIGN=CENTER VALIGN=MIDDLE width = 800><TR> <TD ALIGN=CENTER VALIGN=MIDDLE width = 300>" & Now & "</TD> 	<TD ALIGN=CENTER VALIGN=MIDDLE> <a href=" & wb.Url.ToString & ">" & wb.Document.Title & "</a> </TD></TR></TABLE>")
                sw.Flush()
                sw.Close()

            Else
                sw = File.AppendText(path)
                sw.WriteLine("<TABLE CELLPADDING=3 CELLSPACING=5 BORDER=1 ALIGN=CENTER VALIGN=MIDDLE width=800><TR><TD ALIGN=CENTER VALIGN=MIDDLE width=300>" & Now & "</TD> 	<TD ALIGN=CENTER VALIGN=MIDDLE> <a href=" & wb.Url.ToString & ">" & wb.Document.Title & "</a> </TD></TR></TABLE>")
                sw.Flush()
                sw.Close()

            End If

        Catch ex As Exception
            MsgBox("Unable to add page to chronology file")
        End Try


    End Sub


End Class

