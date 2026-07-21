Imports System.Net.Sockets
Imports System.Text.ASCIIEncoding
Imports System.ComponentModel
Imports System.IO

Public Class senderclient

    Private Client, FileSender As TcpClient

    Private NetStream, NetFile As NetworkStream

    Private IP As String

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

    Private Sub cmdConnect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdConnect.Click

        IP = InputBox("Insert server IP:", Me.Text)


        If String.IsNullOrEmpty(IP) Then
            MessageBox.Show("Connection failed", Me.Text, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        Client = New TcpClient

        lblStatus.Text = "Connection requested"
        Client.Connect(IP, 25)

        If Client.Connected Then

            NetStream = Client.GetStream

            lblStatus.Text = "Connessione riuscita!"
        End If
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdBrowse.Click
        Dim Open As New OpenFileDialog
        Open.Filter = "Tutti i file|*.*"
        If Open.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtFile.Text = Open.FileName
        End If
    End Sub

    Private Sub cmdSend_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cmdSend.Click

        If Not IO.File.Exists(txtFile.Text) Then
            MessageBox.Show("File does not exist!", Me.Text, _
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If


        If Client.Connected AndAlso NetStream.CanWrite Then

            Dim Msg As String = _
                String.Format("ConfirmTransfer|{0}|{1}", txtFile.Text, FileLen(txtFile.Text))

            Send(Msg, NetStream)


            tmrGetData.Start()

            cmdSend.Enabled = False
            lblStatus.Text = "In attesa di conferma dal server..."
        End If
    End Sub

    Private Sub tmrGetData_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrGetData.Tick
        If Client.Connected AndAlso Client.Available Then

            tmrGetData.Stop()

            Dim Msg As String = GetMessage(NetStream)


            If Msg.Contains("OK") Then

                FileSender = New TcpClient
                FileSender.Connect(IP, 1001)
                If FileSender.Connected Then

                    NetFile = FileSender.GetStream

                    bgSendFile.RunWorkerAsync(txtFile.Text)
                End If
            ElseIf Msg.Contains("NO") Then
                MessageBox.Show("Transfert denied from server!", Me.Text, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            tmrGetData.Start()
        End If
    End Sub

    Private Sub bgSendFile_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles bgSendFile.DoWork

        Dim FileName As String = e.Argument

        Dim Reader As New IO.FileStream(FileName, IO.FileMode.Open)

        Dim Size As Int64 = FileLen(FileName)

        Dim Bytes(4095) As Byte


        If Size > 4096 Then
            For Block As Int64 = 0 To Size Step 4096

                If Size - Block >= 4096 Then
                    Reader.Read(Bytes, 0, 4096)
                Else

                    Reader.Read(Bytes, 0, Size - Block)
                End If

                NetFile.Write(Bytes, 0, 4096)

                bgSendFile.ReportProgress(Block * 100 / Size)

                Threading.Thread.Sleep(30)
            Next
        Else

            Reader.Read(Bytes, 0, Size)
            NetFile.Write(Bytes, 0, Size)
        End If
        Reader.Close()


        bgSendFile.ReportProgress(100)
        Threading.Thread.Sleep(100)

        NetFile.Write(ASCII.GetBytes("END"), 0, 3)
        MessageBox.Show("File sent successfully!", Me.Text, _
            MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub bgSendFile_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles bgSendFile.ProgressChanged

        prgProgress.Value = e.ProgressPercentage
    End Sub

    Private Sub senderclient_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            filetransfer.Button4.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            filetransfer.Button4.Visible = False
        End If
    End Sub

    Private Sub senderclient_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
