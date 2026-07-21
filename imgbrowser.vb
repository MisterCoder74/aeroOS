Imports System.Threading
Imports System.IO
Public Class imgbrowser
    Dim Files As String
    Dim ofd As New OpenFileDialog With {.Filter = "Supported Files|*.jpg;*.bmp;*.tiff;*.gif"}
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        ofd.Multiselect = True
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FlowLayoutPanel1.Controls.Clear()
            For Each Files As String In ofd.FileNames
                'Application.DoEvents()
                Dim im As New PictureBox
                im.Height = CInt(Val(ComboBox1.SelectedItem))
                im.Width = CInt(Val(ComboBox1.SelectedItem))
                im.SizeMode = PictureBoxSizeMode.Zoom
                im.Image = Image.FromFile(Files)
                Application.DoEvents()
                FlowLayoutPanel1.Controls.Add(im)
                AddHandler im.Click, AddressOf PictureBox_Click
            Next
        End If
    End Sub
    Private Sub PictureBox_Click(sender As System.Object, e As System.Windows.Forms.MouseEventArgs)
        PictureBox1.Image = sender.image
        sender.borderstyle = BorderStyle.FixedSingle
        Thread.Sleep(500)
        sender.borderstyle = BorderStyle.None
    End Sub
    Private Sub imgbrowser_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        Button1.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub imgbrowser_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.imgbrsbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.imgbrsbuttonsmall.Visible = False
        End If
    End Sub

    Private Sub openbigbutton_Click(sender As System.Object, e As System.EventArgs) Handles openbigbutton.Click
        bigshow.PictureBoxMain.Image = PictureBox1.Image
        bigshow.Show()

    End Sub
End Class
