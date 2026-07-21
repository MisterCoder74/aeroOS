Imports System.Drawing.Drawing2D


Public Class frmScreenCopy

    Public OriSize As Integer = 16  ' size of the original rectangle
    Public MagnSize As Integer = 64 ' size of the magnification glass
    Dim bmpOriCopy As Bitmap        ' buffer of the original rectangle on screen
    Dim bmpgrOriCopy As Graphics
    Dim rctOri As Rectangle         ' original rectangle on screen
    Dim rctOriCopy As Rectangle     ' a copy of the original rectangle on screen
    Dim rctMagn As Rectangle        ' rectangle of the magnification glass
    Dim Desktop As Image
    Dim picgr As Graphics

    Dim gpath As GraphicsPath       ' used to make a round circle shaped glass
    Dim rgn As Region
    Dim pn As Pen = New Pen(Color.Silver, 4)

    Private Function CaptureScreen() As Image
        Dim Img As New Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        Dim g As Graphics = Graphics.FromImage(Img)
        g.CopyFromScreen(0, 0, 0, 0, Img.Size)
        g.Dispose()

        Return Img
    End Function

    Private Sub frmScreenCopy_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        ' adjust objects to choosen sizes
        bmpOriCopy = New Bitmap(OriSize, OriSize)
        bmpgrOriCopy = Graphics.FromImage(bmpOriCopy)
        rctOriCopy = New Rectangle(0, 0, OriSize, OriSize)
        rctOri = New Rectangle(0, 0, OriSize, OriSize) 'where on screen
        rctMagn = New Rectangle(0, 0, MagnSize, MagnSize)

        pic.SetBounds(0, 0, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height)
        pic.Image = CaptureScreen()
        Desktop = pic.Image.Clone
        picgr = pic.CreateGraphics
        Cursor.Hide()
        Cursor.Tag = "off"
    End Sub

    Private Sub frmScreenCopy_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        Cursor.Show()
        Cursor.Tag = "on"
    End Sub

    Private Sub frmScreenCopy_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed
        rgn.Dispose()
        gpath.Dispose()
        bmpgrOriCopy.Dispose()
        bmpOriCopy.Dispose()
        Desktop.Dispose()
        picgr.Dispose()
    End Sub

    Private Sub frmScreenCopy_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select e.KeyCode
            Case Keys.Escape
                Me.Close()
                frmStart.Show()
            Case Keys.F2
                If e.Control = False Then
                    Clipboard.SetImage(Desktop)
                Else
                    ' make a copy inluding the glass
                    Dim bmp As Bitmap = pic.Image.Clone
                    Dim bmpgr As Graphics = Graphics.FromImage(bmp)
                    bmpgr.Clip = rgn
                    bmpgr.DrawImage(bmpOriCopy, rctMagn, rctOriCopy, GraphicsUnit.Pixel)
                    bmpgr.DrawEllipse(pn, rctMagn)
                    Clipboard.SetImage(bmp.Clone)
                    bmpgr.Dispose()
                    bmp.Dispose()
                End If
            Case Keys.F4
                If Cursor.Tag = "off" Then
                    Cursor.Show()
                    Cursor.Tag = "on"
                Else
                    Cursor.Hide()
                    Cursor.Tag = "off"
                End If

        End Select
    End Sub

    Private Sub pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles pic.MouseMove
        ' copy part of screen under mouse original size
        rctOri.X = e.X - OriSize \ 2
        rctOri.Y = e.Y - OriSize \ 2
        bmpgrOriCopy.DrawImage(pic.Image, rctOriCopy, rctOri, GraphicsUnit.Pixel)

        'restore background first before putting new magn glass
        picgr.DrawImage(Desktop, rctMagn, rctMagn, GraphicsUnit.Pixel)

        ' putt new magn glass
        rctMagn.X = e.X - MagnSize \ 2
        rctMagn.Y = e.Y - MagnSize \ 2
        gpath = New GraphicsPath
        gpath.AddEllipse(rctMagn)
        rgn = New Region(gpath)
        picgr.Clip = rgn

        picgr.DrawImage(bmpOriCopy, rctMagn, rctOriCopy, GraphicsUnit.Pixel)
        picgr.DrawEllipse(pn, rctMagn)

    End Sub
End Class

