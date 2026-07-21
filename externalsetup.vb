Imports System.IO
Public Class externalsetup
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox1.Text = ofd.FileName

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox2.Text = ofd.FileName
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox3.Text = ofd.FileName
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Devi inserire i nomi per i pulsanti")

        Else
            My.Settings.CButton01 = TextBox1.Text
            My.Settings.CButton01name = TextBox4.Text
            My.Settings.CButton02 = TextBox2.Text
            My.Settings.CButton02name = TextBox5.Text
            My.Settings.CButton03 = TextBox3.Text
            My.Settings.CButton03name = TextBox6.Text
            My.Settings.CButton05 = TextBox10.Text
            My.Settings.CButton05name = TextBox7.Text
            My.Settings.CButton06 = TextBox11.Text
            My.Settings.CButton06name = TextBox8.Text
            My.Settings.CButton07 = TextBox12.Text
            My.Settings.CButton07name = TextBox9.Text
            externalprogs.Button1.Text = My.Settings.CButton01name
            externalprogs.Button2.Text = My.Settings.CButton02name
            externalprogs.Button3.Text = My.Settings.CButton03name
            externalprogs.Button5.Text = My.Settings.CButton05name
            externalprogs.Button6.Text = My.Settings.CButton06name
            externalprogs.Button7.Text = My.Settings.CButton07name
            externalprogs.Button1.Enabled = True
            externalprogs.Button2.Enabled = True
            externalprogs.Button3.Enabled = True
            externalprogs.Button5.Enabled = True
            externalprogs.Button6.Enabled = True
            externalprogs.Button7.Enabled = True
            My.Settings.Save()
            My.Settings.Reload()
            Me.Close()
        End If

    End Sub

    Private Sub externalsetup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        My.Settings.Reload()
        TextBox1.Text = My.Settings.CButton01
        TextBox2.Text = My.Settings.CButton02
        TextBox3.Text = My.Settings.CButton03
        TextBox10.Text = My.Settings.CButton05
        TextBox11.Text = My.Settings.CButton06
        TextBox12.Text = My.Settings.CButton07
        TextBox4.Text = My.Settings.CButton01name
        TextBox5.Text = My.Settings.CButton02name
        TextBox6.Text = My.Settings.CButton03name
        TextBox7.Text = My.Settings.CButton05name
        TextBox8.Text = My.Settings.CButton06name
        TextBox9.Text = My.Settings.CButton07name
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox10.Text = ofd.FileName
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox11.Text = ofd.FileName
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Executables (*.exe)|*.exe"
        ofd.ShowDialog()
        TextBox12.Text = ofd.FileName
    End Sub
End Class