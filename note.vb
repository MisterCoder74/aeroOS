Public Class note

    'Declare the variables
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub



    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        'If drag is set to true then move the form accordingly.
        If drag Then

            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub


    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        If Me.TextBox1.Text.Length > 0 Then
            Me.TextBox1.Copy()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        If Clipboard.GetDataObject.GetDataPresent(DataFormats.Text) Then
            Me.TextBox1.Paste()
        End If
    End Sub

    Private Sub SaveNoteToAFileToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SaveNoteToAFileToolStripMenuItem.Click
        saveform.Show()
    End Sub



    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
