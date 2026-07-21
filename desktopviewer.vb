Imports System.Net.Sockets
Imports System.Threading
Imports System.Net
Imports System.Text
Imports System.IO


Public Class mServer

    Dim mReader As BinaryReader
    Dim mWriter As BinaryWriter = Nothing
    Const ListenPort As Int16 = 9876
    Const RequestPort As Int16 = 6789
    Shared NoofClients As Int16 = 0 'Stores the Number of Image Sender Connected


    Private Sub mServer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        System.Environment.Exit(System.Environment.ExitCode) 'Informs the Senders About the Departure
        End
    End Sub


    Private Sub mServer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Created by: Muhammed Mohiudeen
        'Location :Chennai,India
        'Email ID: mnmm_11@yahoo.co.in,mohy4u@gmail.com

        ' I have got the inspiration for the doing this project from a freeware called
        'Team Viewer(in which you can control the entire remote system).But,here 
        'you can watch the current screen shot of remote system
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
    ''' <summary>
    ''' Listens For All the Incomming Connections,And Store there IpAddress in the ListBox
    ''' </summary>
    ''' <remarks></remarks>
    Sub ListenAlways()

        'Listen 4 InComming Connections
        Dim MyListener As TcpListener
        Dim MyIp As IPAddress = Dns.GetHostAddresses("localhost")(0)
        MyListener = New TcpListener(MyIp, ListenPort)
        MyListener.Start()


        Try
            While (True)

                Application.DoEvents()

                Dim TempClient As TcpClient = MyListener.AcceptTcpClient
                'Accept the Client

                NoofClients += 1

                Dim myEndPoint As IPEndPoint = TempClient.Client.RemoteEndPoint
                AddToListBox(myEndPoint.Address.ToString)
                'Stores it Address in the List Box With a Delegate
                TempClient.Close()
                'Closes the Client

            End While


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Delegate Sub AddItemDelegate(ByVal AddThis As String)

    Sub AddToListBox(ByVal AddThis As String)
        'A Delegate to Store the address of the incomming connection in a listbox
        If Me.lstShowClients.InvokeRequired = True Then
            Dim NewAdd As New AddItemDelegate(AddressOf AddToListBox)
            lstShowClients.Invoke(NewAdd, New Object() {AddThis})
        Else
            lstShowClients.Items.Add(AddThis)
        End If

    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False
        btnStop.Enabled = True
        btnShowImage.Enabled = True
        btnRefresh.Enabled = True
        'Start the Thread to Listen All the Incomming Connections
        Dim ListenThread As New Thread(New ThreadStart(AddressOf ListenAlways))
        ListenThread.Start()

    End Sub


    Private Sub btnShowImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowImage.Click

        Try
            If lstShowClients.SelectedIndex < 0 Then Exit Sub

            Dim FilName As String = Environment.CurrentDirectory & "\" & "Mohy_Screen_shot.jpg"
            Dim fStram As New FileStream(FilName, FileMode.Create)
            'Creates the File Where we are going to receive the File From the Sender

            Dim ImageSenderAddress As IPAddress = Dns.GetHostAddresses(lstShowClients.SelectedItem)(0)
            'Gets the IPAddress Where i have to Connect

            Dim ClientToSee As TcpClient
            Try
                ClientToSee = New TcpClient()
                ClientToSee.Connect(ImageSenderAddress, RequestPort)
                'Connects to the Image Sender

            Catch ex As Exception
                MsgBox("Sorry !!!,Please ReStart the Sender")
                lstShowClients.Items.RemoveAt(lstShowClients.SelectedIndex)
                fStram.Close()
                'Exit Sub
            End Try


            Dim NStream As NetworkStream = New NetworkStream(ClientToSee.Client)
            'Gets the Stream to Communicate

            mReader = New BinaryReader(NStream)
            Dim buffer(1024 - 1) As Byte
            Do While True
                Dim bytesRead As Integer = mReader.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit Do
                fStram.Write(buffer, 0, bytesRead)
                fStram.Flush()
            Loop

            'Gets the Screen Shot and Closes the Stream
            fStram.Close()
            fStram.Dispose()
            fStram = Nothing
            ClientToSee.Close()

            'Finally Showing the Screen Shot in the Picture Box
            Dim fs As New System.IO.FileStream(FilName, IO.FileMode.Open, IO.FileAccess.Read)
            Dim imgCurrentPhoto As Image = Image.FromStream(fs)
            PictureBox1.Image = imgCurrentPhoto
            fs.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnStop_Click(sender As System.Object, e As System.EventArgs) Handles btnStop.Click
        If Timer1.Enabled = True Then
            Timer1.Enabled = False
        End If
        btnStart.Enabled = True
        btnStop.Enabled = False
        btnShowImage.Enabled = False
        btnRefresh.Enabled = False
        'Start the Thread to Listen All the Incomming Connections
        Dim ListenThread As New Thread(New ThreadStart(AddressOf ListenAlways))
        ListenThread.Abort()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Try
            If lstShowClients.SelectedIndex < 0 Then Exit Sub

            Dim FilName As String = Environment.CurrentDirectory & "\" & "Mohy_Screen_shot.jpg"
            Dim fStram As New FileStream(FilName, FileMode.Create)
            'Creates the File Where we are going to receive the File From the Sender

            Dim ImageSenderAddress As IPAddress = Dns.GetHostAddresses(lstShowClients.SelectedItem)(0)
            'Gets the IPAddress Where i have to Connect

            Dim ClientToSee As TcpClient
            Try
                ClientToSee = New TcpClient()
                ClientToSee.Connect(ImageSenderAddress, RequestPort)
                'Connects to the Image Sender

            Catch ex As Exception
                MsgBox("Sorry !!!,Please ReStart the Sender")
                lstShowClients.Items.RemoveAt(lstShowClients.SelectedIndex)
                fStram.Close()
                Exit Sub
            End Try


            Dim NStream As NetworkStream = New NetworkStream(ClientToSee.Client)
            'Gets the Stream to Communicate

            mReader = New BinaryReader(NStream)
            Dim buffer(1024 - 1) As Byte
            Do While True
                Dim bytesRead As Integer = mReader.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then Exit Do
                fStram.Write(buffer, 0, bytesRead)
                fStram.Flush()
            Loop

            'Gets the Screen Shot and Closes the Stream
            fStram.Close()
            fStram.Dispose()
            fStram = Nothing
            ClientToSee.Close()

            'Finally Showing the Screen Shot in the Picture Box
            Dim fs As New System.IO.FileStream(FilName, IO.FileMode.Open, IO.FileAccess.Read)
            Dim imgCurrentPhoto As Image = Image.FromStream(fs)
            PictureBox1.Image = imgCurrentPhoto
            fs.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


   
End Class
