Imports System.Net.Sockets
Imports System.Text.ASCIIEncoding
Imports System.ComponentModel
Imports System.IO

Public Class sendserver

    Private Listener, FileListener As TcpListener

    Private Client, FileReceiver As TcpClient

    Private NetStream, NetFile As NetworkStream

    Private FileName As String

    Private FileSize As Int64

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub Send(ByVal Msg As String, ByVal Stream As NetworkStream)

        If Stream.CanWrite Then

            Dim Bytes() As Byte = ASCII.GetBytes(Msg)

            Stream.Write(Bytes, 0, Bytes.Length)
        End If
    End Sub

    Private Function GetMessage(ByVal Stream As NetworkStream) As String

        If Stream.CanRead Then
            Dim Bytes(Client.ReceiveBufferSize) As Byte
            Dim Msg As String

            Stream.Read(Bytes, 0, Bytes.Length)

            Msg = ASCII.GetString(Bytes)

            Return Msg.Normalize
        Else
            Return Nothing
        End If
    End Function

    Private Sub cmdListen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdListen.Click
        If cmdListen.Text = "Accept connections" Then

            Listener = New TcpListener(25)
            Listener.Start()

            tmrControlConnection.Start()

            cmdListen.Text = "Stop"
        Else

            Listener.Stop()

            cmdListen.Text = "Accept connections"
        End If
    End Sub

    Private Sub tmrControlConnection_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrControlConnection.Tick

        If Listener.Pending Then

            tmrControlConnection.Stop()
            lblStatus.Text = "Incoming request"

            If MessageBox.Show("Incoming requesto. Accept?", _
                Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = _
                Windows.Forms.DialogResult.Yes Then

                Client = Listener.AcceptTcpClient

                NetStream = Client.GetStream

                Listener.Stop()

                cmdListen.Enabled = False

                tmrGetData.Start()
                lblStatus.Text = "Connection established"
            Else

                tmrControlConnection.Start()
                lblStatus.Text = "Waiting for connections"
            End If
        End If
    End Sub

    Private Sub tmrControlFile_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrControlFile.Tick

        If FileListener.Pending Then
            tmrControlFile.Stop()
            FileReceiver = FileListener.AcceptTcpClient
            NetFile = FileReceiver.GetStream

            FileListener.Stop()
            lblStatus.Text = "Information flux opened"

            bgReceiveFile.RunWorkerAsync()
        End If
    End Sub

    Private Sub tmrGetData_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrGetData.Tick
        If Client.Connected And Client.Available Then

            tmrGetData.Stop()

            Dim Msg As String = GetMessage(NetStream)

            If Msg.StartsWith("ConfirmTransfer") Then

                Dim Parts() As String = Msg.Split("|")

                Dim File As String = Parts(1)

                Dim Size As Int64 = CType(Parts(2), Int64)

                File = IO.Path.GetFileName(File)

                FileName = My.Settings.loggedinreceivedurl & "\" & File

                FileSize = Size

                If MessageBox.Show(String.Format( _
                "Incoming transfer request for {0} ({1} bytes). Accept?", _
                File, Size), Me.Text, MessageBoxButtons.YesNo, _
                MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                    Send("OK", NetStream)

                    FileListener = New TcpListener(1001)
                    FileListener.Start()

                    tmrControlFile.Start()
                Else

                    Send("NO", NetStream)
                End If
            End If

            tmrGetData.Start()
        End If
    End Sub

    Private Sub bgReceiveFile_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgReceiveFile.DoWork

        Dim Stream As New IO.FileStream(FileName, IO.FileMode.Create)

        Dim Index As Int64 = 0

        lblStatus.Text = "Receiving..."
        Do
            If FileReceiver.Available Then

                Dim Bytes(4096) As Byte
                Dim Msg As String = ASCII.GetString(Bytes)


                If Msg.Contains("END") Or Index >= FileSize Then
                    Exit Do
                End If

                NetFile.Read(Bytes, 0, 4096)

                Stream.Write(Bytes, 0, 4096)

                Index += 4096

                bgReceiveFile.ReportProgress(Index * 100 / FileSize)
            End If
        Loop

        lblStatus.Text = "File received!"
        Stream.Close()
        MessageBox.Show("File successfully received!", Me.Text, _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bgReceiveFile_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles bgReceiveFile.ProgressChanged
        prgProgress.Value = e.ProgressPercentage
    End Sub

    Private Sub sendserver_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            filetransfer.Button3.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            filetransfer.Button3.Visible = False
        End If
    End Sub

    Private Sub sendserver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
End Class