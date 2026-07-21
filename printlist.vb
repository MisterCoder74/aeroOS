Imports System.Drawing.Printing
Imports System.IO

Public Class printlist
    Dim prtdoc As New PrintDocument
    Dim strDefaultPrinter As String = prtdoc.PrinterSettings.PrinterName
    Private Sub printlist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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


        Dim pkInstalledPrinters As String

        For Each pkInstalledPrinters In _
            PrinterSettings.InstalledPrinters
            ListBox1.Items.Add(pkInstalledPrinters)
        Next pkInstalledPrinters
        ListBox1.SelectedIndex = 0
        Label1.Text = "Default printer: " & strDefaultPrinter.ToString
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Dim PrintDoc As New PrintDocument
            AddHandler PrintDoc.PrintPage, AddressOf Me.PrintText
            PrintDoc.Print()
        Catch ex As Exception
            MessageBox.Show("Print test failed: ", ex.ToString())
        End Try

    End Sub
    Private Sub PrintText(ByVal sender As Object, ByVal ev As PrintPageEventArgs)
        ev.Graphics.DrawString("Testing Printer", New Font("Arial", 11, FontStyle.Regular), Brushes.Black, 120, 120)
        ev.HasMorePages = False
    End Sub

End Class