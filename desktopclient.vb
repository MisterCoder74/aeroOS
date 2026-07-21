Imports System.Net.Sockets
Imports System.Net
Imports System.Threading
Imports System.Text
Imports System.IO


Public Class desktopclient

    Const ConnectionPort As Int16 = 9876 'Connection Port Number
    Const RequestPort As Int16 = 6789 'Request Port Number

    Dim ServerIp As String

    Dim NetStream As NetworkStream
    Dim myReader As BinaryReader
    Dim myWriter As BinaryWriter

    Dim Look4Request As Thread = Nothing


    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.NotifyIcon1.Visible = False
        Me.NotifyIcon1.Dispose()
        System.Environment.Exit(System.Environment.ExitCode) ' Informs to the Server When it is Closed
    End Sub


    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'Stores the ImageReceiver Address To Connect
        ServerIp = InputBox("Enter the Image Receiver IPAddress", "Image Receiver IPAddress", "127.0.0.1").Trim
        If ServerIp = "" Then
            MsgBox("Image Receiver IP Can't be Empty", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical)
            Me.Close()
        End If

        'Informs the Image Receiver That it is Connected
        Try
            Dim myClient As New TcpClient
            myClient.Connect(ServerIp, ConnectionPort)
            myClient.Close()
        Catch ex As Exception
            MsgBox("Please Start the Receiver", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly)

            Me.NotifyIcon1.Dispose()
            Me.Close()

        End Try



        'Creates a Thread To Listen 4 the Request of the Receiver 
        Look4Request = New Thread(New ThreadStart(AddressOf WaitForRequest))
        Look4Request.Start()


    End Sub


    Sub WaitForRequest()

        'Gets the Receiver Address
        Dim ServerAddress As IPAddress = Dns.GetHostAddresses(ServerIp)(0)
        Dim myListener As New TcpListener(ServerAddress, RequestPort)
        myListener.Start()

        'If Connected Gets the Client Stream
        Try
            While (True)
                Try
                    Dim myClient As TcpClient = myListener.AcceptTcpClient
                    NetStream = myClient.GetStream
                    Label1.Text = "Client connected"
                    Send_Screen_Shot() 'Sends the Screen Shot of the Desktop
                    myClient.Close()
                Catch ex As Exception
                    Exit While
                End Try

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            myReader.Close()
            NetStream.Close()
            Label1.Text = "No client connected"
        End Try

    End Sub

    Sub Send_Screen_Shot()


        Dim FileName As String = Environment.CurrentDirectory & "\Mohiudeen_Screen.bmp"

        ScreenCapture.CurrentScreen() 'Capture the Current Screen

        If File.Exists(FileName) Then
            File.Delete(FileName)
        End If

        ScreenCapture.oBitMap.Save(FileName) 'Saves it to a File
        ScreenCapture.oBitMap = Nothing

        'Then,Sends the File to the Image Receiver
        Using FStreams As New FileStream(FileName, FileMode.Open)
            Label1.Text = "Sending screenshot to client"
            Dim buffer(1024 - 1) As Byte

            Do While True
                Dim bytesRead As Integer = FStreams.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit Do
                Me.NetStream.Write(buffer, 0, bytesRead)
                NetStream.Flush()
                Label1.Text = "Screenshot sent"
            Loop

            FStreams.Close()
            NetStream.Close()
        End Using
        'Finally Closes
        Label1.Text = "Ready"

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'First Start the Image Receiver by Clicking on the Start Button
    End Sub


End Class
