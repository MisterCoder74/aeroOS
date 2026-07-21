Imports System.IO
Public Class scanner

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxScanner1.SelectImageSourceByIndex(0)
        AxScanner1.FeederEnabled = True
        AxScanner1.DuplexEnabled = True
        'AxScanner1.DPI = 120
        AxScanner1.PixelType = -1
        AxScanner1.SelectImageSource()

        AxScanner1.SetCaptureArea(0, 0, 0, 0)
        AxScanner1.Scan()
        AxScanner1.View = 9
        AxScanner1.Focus()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim dlg As New SaveFileDialog, fName As String = String.Empty
        Dim bsave As Boolean

        With dlg
            .Title = "Save file to TIFF format"
            .Filter = "TIFF files (*.tiff)|*.tif"
            .AddExtension = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                fName = .FileName
                'RichTextBox1.SaveFile(fName, RichTextBoxStreamType.RichText)
                bsave = AxScanner1.SaveAllPage2TIF(fName, True, 1)

                If bsave Then
                    MsgBox("File saved")
                Else
                    MsgBox("Unable to save")
                End If
            Else

                Exit Sub
            End If
        End With


    End Sub


    Private Sub scanner_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.scanbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.scanbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim dlg As New SaveFileDialog, fName As String = String.Empty
        Dim bsave As Boolean

        With dlg
            .Title = "Save file to PDF format"
            .Filter = "PDF files (*.pdf)|*.pdf"
            .AddExtension = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then

                fName = .FileName

                bsave = AxScanner1.SaveAllPage2PDF(fName, True, 1)

                If bsave Then
                    MsgBox("File saved")
                Else
                    MsgBox("Unable to save")
                End If
            Else

                Exit Sub
            End If
        End With
    End Sub

    Private Sub scanner_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        PictureBox1.Image = AxScanner1.Copy2PictureBox()
        bigshow.PictureBoxMain.Image = Me.PictureBox1.Image
        bigshow.Show()
    End Sub
End Class
