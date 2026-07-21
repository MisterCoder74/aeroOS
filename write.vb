Imports System.IO

Public Class write
    Declare Function GetKeyState Lib "user32" Alias "GetKeyState" (ByVal ByValnVirtKey As Int32) As Int16

    Private Const VK_CAPSLOCK = &H14
    Private Const VK_NUMLOCK = &H90
    Dim c As Integer = 0


    Private Sub write_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 100
        Timer1.Enabled = True

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



        Label1.Text = "Character count: 0"
        Label2.Text = "Word count: 0"
        If stack.TextBox2.Text <> "" Then
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.FileName = stack.TextBox2.Text
            RichTextBox1.LoadFile(dlg.FileName)
        End If

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        Try
            Dim dlg As OpenFileDialog = New OpenFileDialog
            dlg.Title = "Open"
            dlg.Filter = "Rich text files (*.rtf)|*.rtf"
            If dlg.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.LoadFile(dlg.FileName)

            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        RichTextBox1.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()


    End Sub

    Private Sub RedoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub


    Private Sub FontsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontsToolStripMenuItem.Click
        Try
            Dim dlgfont As FontDialog = New FontDialog
            dlgfont.Font = RichTextBox1.Font
            If dlgfont.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionFont = dlgfont.Font
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click


        Dim dlg As New SaveFileDialog, fName As String = String.Empty
        Do
            With dlg
                .Title = "Salva File"
                .Filter = "Rich text files (*.rtf)|*.rtf"
                .AddExtension = True
                .DefaultExt = "rtf"
                .InitialDirectory = My.Settings.loggedindocsurl
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    If Not .FileName.StartsWith(.InitialDirectory) Then
                        MessageBox.Show( _
                          "Non è possibile cambiare la cartella di destinazione del file",
                          "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ElseIf .ShowDialog = Windows.Forms.DialogResult.Cancel Then
                        Exit Do
                    Else
                        ' la cartella è quella giusta. Si procede
                        fName = .FileName
                        RichTextBox1.SaveFile(fName, RichTextBoxStreamType.RichText)
                        Exit Do
                    End If
                Else
                    ' non OK. Si esce dalla procedura
                    Exit Sub
                End If
            End With
        Loop

    End Sub


    Private Sub ColorsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorsToolStripMenuItem.Click
        Try
            Dim dlgcol As ColorDialog = New ColorDialog
            dlgcol.Color = RichTextBox1.ForeColor
            If dlgcol.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.SelectionColor = dlgcol.Color

            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub LeftToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeftToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CenterToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RightToolStripMenuItem.Click
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Dim strfind As String
        Dim pos As Integer
        strfind = InputBox("Insert string to find:", "Find")
        If strfind = "" Then
            Exit Sub
        End If
        pos = RichTextBox1.Find(strfind)
        If pos = -1 Then
            MsgBox("String not found")
        End If
    End Sub



    Private Sub write_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.wrButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.wrButtonsmall.Visible = False
        End If
    End Sub




    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(RichTextBox1.Text, RichTextBox1.Font, Brushes.Black, 100, 100)
    End Sub




    Private Sub PrintToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDocument1.PrinterSettings.Copies = 1
        PrintDocument1.Print()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged
        c = 0
        Dim words() As String = Split(RichTextBox1.Text, " ")
        Label2.Text = "Word count: " & CStr((words.Length) - 1)
        For x As Integer = 1 To RichTextBox1.Text.Length
            Dim y As String = Mid(RichTextBox1.Text, x, 1)
            If y <> vbLf AndAlso y <> vbTab Then
                c += 1
            End If
            If y = vbCr Then
                c += 1
            End If
        Next
        Label1.Text = "Character count: " & c.ToString
    End Sub

    Private Sub write_FormClosed(sender As System.Object, e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        stack.TextBox2.Text = ""
    End Sub

    Private Sub BullettListToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BullettListToolStripMenuItem.Click
        If RichTextBox1.SelectionBullet = True Then
            RichTextBox1.SelectionBullet = False
            RichTextBox1.SelectionIndent = 0
            RichTextBox1.SelectionHangingIndent = 0
            RichTextBox1.SelectionRightIndent = 0
        ElseIf RichTextBox1.SelectionBullet = False Then
            RichTextBox1.SelectionBullet = True
            RichTextBox1.SelectionIndent = 8
            RichTextBox1.SelectionHangingIndent = 3
            RichTextBox1.SelectionRightIndent = 12
        End If
    End Sub

    Private Sub RichTextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Tab Then
            RichTextBox1.SelectedText = vbTab

        End If
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImageToolStripMenuItem.Click
        ' Crea una nuova istanza della Classe OpenFileDialog
        Dim ofd As New OpenFileDialog
        ' Se viene selezionata un immagine
        ofd.Filter = "Image files (*.jpg,gif,bmp)|*.jpg;*.gif;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            ' Percorso selezionato contenente l'immagine da incollare
            ' all'interno della RichTextBox
            Dim picFile As String = ofd.FileName
            ' incapsula una bitmap
            Dim pic As New Bitmap(picFile)
            ' Copia l'immagine negli appunti di sistema
            Clipboard.SetDataObject(pic)
        End If
        ' Recupera il formato dell'oggetto memorizzato
        Dim fmt As DataFormats.Format = DataFormats.GetFormat(DataFormats.Bitmap)
        ' Verifica se il formato e corretto per essere incollato
        ' all'interno della RichTextBox
        If RichTextBox1.CanPaste(fmt) Then
            ' Incolla l'immagine selezionata all'interno della RichTextBox
            RichTextBox1.Paste(fmt)
        End If
    End Sub

    Private Sub TimestampToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TimestampToolStripMenuItem.Click
        RichTextBox1.SelectedText = Date.Now.ToString
    End Sub

    Private Sub ManageClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManageClipboardToolStripMenuItem.Click
        clipmanager.Show()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If GetKeyState(VK_CAPSLOCK) = 1 And GetKeyState(VK_NUMLOCK) = 1 Then

            Label3.Text = "CAPS LOCK + NUM ON"

        ElseIf GetKeyState(VK_CAPSLOCK) = 1 And GetKeyState(VK_NUMLOCK) <> 1 Then

            Label3.Text = "CAPS LOCK ON"
        ElseIf GetKeyState(VK_CAPSLOCK) <> 1 And GetKeyState(VK_NUMLOCK) = 1 Then

            Label3.Text = "NUM LOCK ON"
        Else

            Label3.Text = ""
        End If

    End Sub

    Private Sub write_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
    End Sub
End Class
