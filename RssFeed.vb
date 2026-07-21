Imports System.Xml
Imports System.Xml.XPath
Imports System.Speech
Imports System.IO




Public Class RSSfeed

    ' Current Path to RSS Feed
    Private mRssUrl As String




    ''' <summary>
    ''' Set the RSS URL to an empty
    ''' string on form load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub Form1_Load(ByVal sender As System.Object, _
                           ByVal e As System.EventArgs) Handles MyBase.Load

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

        ' Clear path to RSS Feed
        mRssUrl = tsRssLocation.Text


        Try

            ' set the file path member var
            mRssUrl = Me.tsRssLocation.Text

            ' Clear the treeview.
            ListBox1.Items.Clear()

            ' set the wait cursor
            Me.Cursor = Cursors.WaitCursor

            ' create a new xml doc
            Dim doc As New XmlDocument()

            Try

                ' load the xml doc
                doc.Load(mRssUrl)

                ' return the cursor
                Me.Cursor = Cursors.Default

            Catch ex1 As Exception

                ' return the cursor
                Me.Cursor = Cursors.Default

                ' tell a story
                MessageBox.Show(ex1.Message)
                Return

            End Try



            ' get an xpath navigator   
            Dim navigator As XPathNavigator = doc.CreateNavigator()

            Try

                ' look for the path to the rss item titles navigate
                ' through the nodes to get all titles
                Dim nodes As XPathNodeIterator = navigator.Select("/rss/channel/item/title")

                While nodes.MoveNext

                    ' clean up the text for display
                    Dim node As XPathNavigator = nodes.Current
                    Dim tmp As String = node.Value.Trim()
                    tmp = tmp.Replace(ControlChars.CrLf, "")
                    tmp = tmp.Replace(ControlChars.Lf, "")
                    tmp = tmp.Replace(ControlChars.Cr, "")
                    tmp = tmp.Replace(ControlChars.FormFeed, "")
                    tmp = tmp.Replace(ControlChars.NewLine, "")
                    tmp = tmp.Replace("&nbsp", " ")

                    ' add a new treeview node for this
                    ' news item title
                    If tmp.ToLower.StartsWith("video") Then
                        tmp = ""
                    Else
                        ListBox1.Items.Add(tmp)
                    End If


                End While


                ' set a position counter
                Dim position As Integer = 0

                ' Get the links from the RSS feed



            Catch ex As Exception

                MessageBox.Show(ex.Message, "RSS Feed Load Error")

            End Try


            ' restore the cursor
            Me.Cursor = Cursors.Default

        Catch ex2 As Exception

            ' snitch
            MessageBox.Show(ex2.ToString(), "RSS Feed Initialization Failure")

        End Try

    End Sub



    ''' <summary>
    ''' Pull up an RSS feed and load its headlines
    ''' and links into a treeview control
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>






    ''' <summary>
    ''' Load the selected canned RSS feed into the 
    ''' treeview using the existing methods
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub tsCboFeeds_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsCboFeeds.SelectedIndexChanged

        ' load the text for the selected feed into
        ' the RSS location text box and then use
        ' the existing button click event to launch
        ' the RSS feed into the treeview
        tsRssLocation.Text = tsCboFeeds.SelectedItem.ToString()
        mRssUrl = tsRssLocation.Text


        Try

            ' set the file path member var
            mRssUrl = Me.tsRssLocation.Text

            ' Clear the treeview.
            ListBox1.Items.Clear()

            ' set the wait cursor
            Me.Cursor = Cursors.WaitCursor

            ' create a new xml doc
            Dim doc As New XmlDocument()

            Try

                ' load the xml doc
                doc.Load(mRssUrl)

                ' return the cursor
                Me.Cursor = Cursors.Default

            Catch ex1 As Exception

                ' return the cursor
                Me.Cursor = Cursors.Default

                ' tell a story
                MessageBox.Show(ex1.Message)
                Return

            End Try



            ' get an xpath navigator   
            Dim navigator As XPathNavigator = doc.CreateNavigator()

            Try

                ' look for the path to the rss item titles navigate
                ' through the nodes to get all titles
                Dim nodes As XPathNodeIterator = navigator.Select("/rss/channel/item/title")

                While nodes.MoveNext

                    ' clean up the text for display
                    Dim node As XPathNavigator = nodes.Current
                    Dim tmp As String = node.Value.Trim()
                    tmp = tmp.Replace(ControlChars.CrLf, "")
                    tmp = tmp.Replace(ControlChars.Lf, "")
                    tmp = tmp.Replace(ControlChars.Cr, "")
                    tmp = tmp.Replace(ControlChars.FormFeed, "")
                    tmp = tmp.Replace(ControlChars.NewLine, "")
                    tmp = tmp.Replace("&nbsp", " ")

                    ' add a new treeview node for this
                    ' news item title
                    If tmp.ToLower.StartsWith("video") Then
                        tmp = ""
                    Else
                        ListBox1.Items.Add(tmp)
                    End If


                End While


                ' set a position counter
                Dim position As Integer = 0

                ' Get the links from the RSS feed



            Catch ex As Exception

                MessageBox.Show(ex.Message, "RSS Feed Load Error")

            End Try


            ' restore the cursor
            Me.Cursor = Cursors.Default

        Catch ex2 As Exception

            ' snitch
            MessageBox.Show(ex2.ToString(), "RSS Feed Initialization Failure")

        End Try


    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim answer As String
        For i = 0 To ListBox1.Items.Count - 1
            ListBox1.SelectedIndex = i
            Dim robotvoice = CreateObject("sapi.spvoice")
            answer = ListBox1.Items.Item(i).ToString
            robotvoice.speak(answer)
        Next
    End Sub


    Private Sub frmRss_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        
        Dim rvoice = CreateObject("sapi.spvoice")
        rvoice.speak("Click on the button to read all the news in the listbox")
    End Sub

    Private Sub RSSfeed_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.rssbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.rssbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            Dim answer As String
            Dim robotvoice = CreateObject("sapi.spvoice")
            answer = ListBox1.SelectedItem
            robotvoice.speak(answer)
        Catch ex As Exception

        End Try
    End Sub
End Class
