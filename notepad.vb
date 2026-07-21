Imports System.IO
Public Class notepad

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        If doc.Modified = True Then
            Dim x As Integer = MsgBox("Do you want to save the modified document ?", MsgBoxStyle.YesNo)
            If x = vbYes Then
                SaveToolStripMenuItem.PerformClick()
            Else
                Me.Text = "Untitled - Notepad.NET"
                doc.Clear()
            End If
            Me.Text = "Untitled - Notepad.NET"
            doc.Clear()

        End If
    End Sub
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click

        Dim y As New OpenFileDialog
        y.Filter = "Plain Text files(*.txt)|*.txt"

        y.Multiselect = False
        If y.ShowDialog = Windows.Forms.DialogResult.Cancel Then

        Else
            Dim x As String
            Try

                x = My.Computer.FileSystem.ReadAllText(y.FileName)


                doc.Text = x


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Text = Replace(Me.Text, "Untitled", y.FileName)
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        Dim y As New SaveFileDialog
        y.Filter = "Plain Text files(*.txt)|*.txt"


        If y.ShowDialog = Windows.Forms.DialogResult.Cancel Then

        Else
            Try
                Dim x As String = doc.Text

                My.Computer.FileSystem.WriteAllText(y.FileName, x, True)


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

            Me.Text = Replace(Me.Text, "Untitled", y.FileName)

        End If

    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        Dim x As New PageSetupDialog
        x.PageSettings = New Printing.PageSettings
        x.PrinterSettings = New System.Drawing.Printing.PrinterSettings
        x.ShowNetwork = False
        Dim listbox1 As New ListBox
        Dim result As DialogResult = x.ShowDialog
        If (result = DialogResult.OK) Then
            Dim results() As Object = New Object() _
                {x.PageSettings.Margins, _
                 x.PageSettings.PaperSize, _
                 x.PageSettings.Landscape, _
                 x.PrinterSettings.PrinterName, _
                 x.PrinterSettings.PrintRange}
            listbox1.Items.AddRange(results)
        End If

    End Sub


    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        Dim x As New PrintDialog
        x.Document = New Printing.PrintDocument
        x.ShowDialog()

    End Sub

    Private WithEvents docToPrint As New Printing.PrintDocument
    Private Sub document_PrintPage(ByVal sender As Object, _
       ByVal e As System.Drawing.Printing.PrintPageEventArgs) _
           Handles docToPrint.PrintPage
        Dim x As New FontDialog
        x.ShowDialog()

        Dim text As String = doc.Text
        Dim printFont As New System.Drawing.Font(x.Font, x.Font.Style)

        e.Graphics.DrawString(text, printFont, _
            System.Drawing.Brushes.Black, 10, 10)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        doc.Undo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(doc.SelectedText)
        doc.SelectedText = ""
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        My.Computer.Clipboard.SetText(doc.SelectedText)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        doc.SelectedText = My.Computer.Clipboard.GetText

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        doc.SelectedText = ""

    End Sub



    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        doc.SelectAll()

    End Sub

    Private Sub TimeDateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeDateToolStripMenuItem.Click
        doc.SelectedText = Date.Now

    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WordWrapToolStripMenuItem.Click
        doc.WordWrap = True

    End Sub

    Private Sub FontToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem.Click
        Dim x As New FontDialog
        x.ShowDialog()
        doc.Font = x.Font

    End Sub


    Private Sub ReplaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem.Click
        doc.Text = Replace(doc.Text, InputBox("Text to find"), InputBox("Text to replace"))

    End Sub

    Private Sub doc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles doc.TextChanged
        NoteFindDialog.fp.Text = doc.Text
    End Sub


    Private target_pos As Integer
    Dim target As String
    Private Sub FindText(ByVal start_pos As Integer)
        Dim pos As Integer


        pos = InStr(start_pos, doc.Text.ToLower, tf.Text.ToLower)
        If pos > 0 Then
            target_pos = pos
            doc.SelectionStart = target_pos - 1
            doc.SelectionLength = Len(target) - (Len(target) - Len(target))

        Else
            MsgBox("String Not Found")
            target = ""
        End If

    End Sub

    Private Sub FindNextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindNextToolStripMenuItem.Click
        FindText(target_pos + 1)
    End Sub
    Dim x As String
    Private Sub ReplaceToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceToolStripMenuItem1.Click


        target = InputBox("Enter string to find")
        FindText(1)

        If doc.SelectedText <> target Then

        Else
            x = InputBox(String.Format("Selected text is : {0}. Enter text to replace", target))
            doc.SelectedText = x
        End If

    End Sub

    Private Sub ReplaceNextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplaceNextToolStripMenuItem.Click
        FindText(target_pos + 1)
        If doc.SelectedText = "" Then

        Else
            doc.SelectedText = x
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        SaveToolStripMenuItem.PerformClick()

    End Sub

    Private Sub FindToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem1.Click
        FindText(1)
        target = tf.Text

    End Sub

    Private Sub notepad_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        If stack.TextBox2.Text <> "" Then
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.FileName = stack.TextBox2.Text
            Dim x As String
            Try
                x = My.Computer.FileSystem.ReadAllText(dlg.FileName)
                doc.Text = x
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Me.Text = Replace(Me.Text, "Untitled", dlg.FileName)
        Else
            'do nothing
        End If
    End Sub

    Private Sub notepad_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.6
    End Sub

    Private Sub notepad_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub notepad_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.notepadbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.notepadbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub notepad_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        stack.TextBox2.Text = ""
    End Sub
End Class
