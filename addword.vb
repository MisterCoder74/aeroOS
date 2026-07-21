Imports System.IO
Public Class addword

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        

                    Try

            Dim path As String = My.Settings.loadeddictionary
                        Dim sw As StreamWriter


                        If File.Exists(path) Then


                            sw = File.AppendText(path)
                            sw.WriteLine(TextBox1.Text & "^" & TextBox2.Text)
                            sw.Flush()
                            sw.Close()
                            TextBox1.Clear()
                            TextBox2.Clear()

                        Else
                            File.Create(path)
                            sw = File.AppendText(path)
                            sw.WriteLine(TextBox1.Text & "^" & TextBox2.Text)
                            sw.Flush()
                            sw.Close()
                            TextBox1.Clear()
                            TextBox2.Clear()
                        End If

                    Catch ex As Exception
                        MsgBox("Unable to save")
                    End Try

              
    End Sub

    Private Sub addword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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