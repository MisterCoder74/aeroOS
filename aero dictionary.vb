Imports System.IO
Imports System
Public Class aero_dictionary


    Dim dict As New Dictionary(Of String, String)
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub button1_Click(sender As System.Object, _
                              e As System.EventArgs) _
                            Handles Button1.Click
        Using OFD As New OpenFileDialog
            With OFD
                .Filter = "Dict files (*.dict)|*.dict"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    LeggiDizionario(.FileName)
                    My.Settings.loadeddictionary = .FileName
                End If
            End With
        End Using
    End Sub

    Private Sub LeggiDizionario(FullPathFileName As String)

        Dim lines As String() = IO.File.ReadAllLines(FullPathFileName)

        For Each line As String In lines
            Dim kv As KeyValuePair(Of String, String) = ToKeyValuePair(line)
            dict.Add(kv.Key, kv.Value)
            ListBox1.Items.Add(kv.Key)

        Next

    End Sub

    Public Function ToKeyValuePair(pair As String) _
                                   As KeyValuePair(Of String, String)

        Dim two As String() = pair.Split("^")
        Return New KeyValuePair(Of String, String)(two(0), two(1))
    End Function
    Private Sub listbox1_Click(sender As Object, _
                                           e As System.EventArgs) _
                                         Handles ListBox1.Click
        Dim lst As ListBox = DirectCast(ListBox1, ListBox)
        TextBox2.Clear()
        TextBox2.SelectedText = dict(lst.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        addword.Show()
    End Sub

    Private Sub FindMyString(ByVal searchString As String)
        ' Ensure we have a proper string to search for.
        If searchString <> String.Empty Then
            ' Find the item in the list and store the index to the item.
            Dim index As Integer = ListBox1.FindString(searchString)
            ' Determine if a valid index is returned. Select the item if it is valid.
            If index <> -1 Then
                ListBox1.SetSelected(index, True)
            Else
                MessageBox.Show("The search string did not match any items in the ListBox")
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FindMyString(TextBox1.Text)
        Dim lst As ListBox = DirectCast(ListBox1, ListBox)
        TextBox2.Clear()
        TextBox2.SelectedText = dict(lst.SelectedItem)
    End Sub

    Private Sub aero_dictionary_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.dictbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.dictbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        dict.Clear()
        ListBox1.Items.Clear()
        TextBox2.Clear()
        LeggiDizionario(My.Settings.loadeddictionary)

    End Sub

    Private Sub aero_dictionary_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
