Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.InteropServices
Imports AxAXVLC

Public Class aero
    'definizione variabili globali
    Dim drag As Boolean
    Dim ignoreclick As Boolean = True
    Dim mousex As Integer
    Dim mousey As Integer
    Dim NewMagnet As PictureBox
    Dim newvmagnet As AxAXVLC.AxVLCPlugin2
    Dim magnetheight As Integer
    Dim magnetwidth As Integer
    Dim magnetratio As Integer
    Dim newpanel As Panel
    Dim newvpanel As Panel
    Dim newlabel As Label
   
    Dim buttText As String
    Dim buttProcess As String
    Dim dict As New Dictionary(Of String, String)



    'gestisce apertura e chiusura del pannelo menu a scomparsa
    Private Sub openpanelbutton_Click(sender As System.Object, e As System.EventArgs) Handles openpanelbutton.Click
        menupanel01.Visible = True
        openpanelbutton.Visible = False
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)

    End Sub

    Private Sub closepanelbutton_Click(sender As System.Object, e As System.EventArgs) Handles closepanelbutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = False
        officepanel.Visible = False
        gamespanel.Visible = False
        systempanel.Visible = False
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub

    'i seguenti eventi gestiscono il passaggio del mouse sui menu
    Private Sub mediabutton_MouseHover(sender As System.Object, e As System.EventArgs) Handles mediabutton.MouseHover
        grouplabel.Text = "Aero Media"
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
    End Sub
    Private Sub mediabutton_MouseLeave(sender As System.Object, e As System.EventArgs) Handles mediabutton.MouseLeave
        grouplabel.Text = ""
    End Sub
    Private Sub netbutton_MouseHover(sender As System.Object, e As System.EventArgs) Handles netbutton.MouseHover
        grouplabel.Text = "Aero Networking"
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
    End Sub
    Private Sub netbutton_MouseLeave(sender As System.Object, e As System.EventArgs) Handles netbutton.MouseLeave
        grouplabel.Text = ""
    End Sub
    Private Sub officebutton_MouseHover(sender As System.Object, e As System.EventArgs) Handles officebutton.MouseHover
        grouplabel.Text = "Aero Tools"
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
    End Sub
    Private Sub officebutton_MouseLeave(sender As System.Object, e As System.EventArgs) Handles officebutton.MouseLeave
        grouplabel.Text = ""
    End Sub
    Private Sub gamesbutton_MouseHover(sender As System.Object, e As System.EventArgs) Handles gamesbutton.MouseHover
        grouplabel.Text = "Aero Games"
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
    End Sub
    Private Sub gamesbutton_MouseLeave(sender As System.Object, e As System.EventArgs) Handles gamesbutton.MouseLeave
        grouplabel.Text = ""
    End Sub
    Private Sub systembutton_MouseHover(sender As System.Object, e As System.EventArgs) Handles systembutton.MouseHover
        grouplabel.Text = "Aero System tools"
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
    End Sub
    Private Sub systembutton_MouseLeave(sender As System.Object, e As System.EventArgs) Handles systembutton.MouseLeave
        grouplabel.Text = ""
    End Sub

    'i prossimi eventi gestiscono il lancio dei singoli pannelli di lancio applicazioni
    Private Sub mediabutton_Click(sender As System.Object, e As System.EventArgs) Handles mediabutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = True
        netpanel.Visible = False
        officepanel.Visible = False
        gamespanel.Visible = False
        systempanel.Visible = False
    End Sub

    Private Sub netbutton_Click(sender As System.Object, e As System.EventArgs) Handles netbutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = True
        officepanel.Visible = False
        gamespanel.Visible = False
        systempanel.Visible = False
    End Sub

    Private Sub officebutton_Click(sender As System.Object, e As System.EventArgs) Handles officebutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = False
        officepanel.Visible = True
        gamespanel.Visible = False
        systempanel.Visible = False
    End Sub

    Private Sub gamesbutton_Click(sender As System.Object, e As System.EventArgs) Handles gamesbutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = False
        officepanel.Visible = False
        gamespanel.Visible = True
        systempanel.Visible = False
    End Sub

    Private Sub systembutton_Click(sender As System.Object, e As System.EventArgs) Handles systembutton.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = False
        officepanel.Visible = False
        gamespanel.Visible = False
        systempanel.Visible = True
    End Sub

    'gestisce il click sul desktop per chiudere i pannelli di lancio applicazioni
    Private Sub aero_Click(sender As System.Object, e As System.EventArgs) Handles MyBase.Click
        menupanel01.Visible = False
        openpanelbutton.Visible = True
        mediapanel.Visible = False
        netpanel.Visible = False
        officepanel.Visible = False
        gamespanel.Visible = False
        systempanel.Visible = False
    End Sub
    'timer che mostra data e ora
    Private Sub Timerclock_Tick(sender As System.Object, e As System.EventArgs) Handles Timerclock.Tick
        timelabel.Text = Now
    End Sub

    'caricamento di aero - identificazione utente e ruolo
    Private Sub aero_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Computer.Network.IsAvailable = True Then
            WebBrowsermeteo.Navigate("https://www.google.it/search?hl=en&output=search&sclient=psy-ab&q=weather&oq=weather&gs_l=hp.3..0l4.625.1527.0.1660.7.4.0.3.3.1.285.1061.2-4.4.0....0...1c.1.23.psy-ab..1.6.801.-zxBfQ8sKjM&pbx=1&bav=on.2,or.r_cp.r_qf.&bvm=bv.49967636,d.aWc&biw=1366&bih=581&cad=h")
        Else
            temperaturelabel.Text = "Meteo OFF"
            '            MsgBox("WARNING: Internet connection is not available." & vbCrLf & "Aero2018 may not work properly")
            Timermeteo.Start()
        End If

        Dim gpath As String = My.Settings.rootdir & "\users\users.txt"
        Dim nsg As StreamReader = File.OpenText(gpath)
        Dim gs As String
        Do While nsg.Peek() >= 0
            gs = nsg.ReadLine()
            Dim params(2) As String
            params = gs.Split("^"c)
            If params(0) = My.Settings.loggedinuser Then
                Dim role As String = params(1)
                My.Settings.loggedrole = role
            End If
        Loop
        nsg.Close()
        presentuser.Text = "User: " & My.Settings.loggedinuser

        'caricamento di aero - caricamento impostazioni
        Try
            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sr As StreamReader = File.OpenText(path)
            Dim s As String

            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero Alternative Yellow"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black
                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black

                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black

                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero 2018 Base"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.alternative2" Then
                    Me.BackgroundImage = My.Resources.alternative2
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero Alternative Red"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.alternative3" Then
                    Me.BackgroundImage = My.Resources.alternative3
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero Alternative Green"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.alternative4" Then
                    Me.BackgroundImage = My.Resources.alternative4
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero Alternative Violet"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.alternative5" Then
                    Me.BackgroundImage = My.Resources.alternative5
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "None"
                    settings.Label13.Text = "Desktop: Aero Alternative Smoke"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources._02" Then
                    Me.BackgroundImage = My.Resources._02
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Red
                    wcustombuttssmall.ForeColor = Color.Red
                    openaeromediaButton.ForeColor = Color.Red
                    magbutton.ForeColor = Color.Red
                    vmagbutton.ForeColor = Color.Red
                    notesbutton.ForeColor = Color.Red
                    settings.Label11.Text = "Explosion"
                    settings.Label13.Text = "Desktop: Themepack"
                    'logolabel.ForeColor = Color.Red
                    timelabel.ForeColor = Color.Red
                    scpopenbutton.ForeColor = Color.Red
                    scpclosebutton.ForeColor = Color.Red
                    grouplabel.ForeColor = Color.Red

                    openpanelbutton.ForeColor = Color.Red
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Red
                    stoppanelmediaButton.ForeColor = Color.Red
                    hidepanelButton.ForeColor = Color.Red
                    hidepanelButton.ForeColor = Color.Red
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Red
                    ylabel.ForeColor = Color.Red
                    createiconbutton.ForeColor = Color.Red
                    ipcbutton.ForeColor = Color.Red
                    aeromenulabel.ForeColor = Color.Red
                    calendarclosebutton.ForeColor = Color.Red
                    inamelabel.ForeColor = Color.Red
                    iprocesslabel.ForeColor = Color.Red
                    alarmbutton.BackColor = Color.Red
                    presentuser.ForeColor = Color.Red
                    temperaturelabel.ForeColor = Color.Red
                    Skylabel.ForeColor = Color.Red
                    locationlabel.ForeColor = Color.Red
                    scpclosebutton.ForeColor = Color.Red
                    closepanelbutton.ForeColor = Color.Red
                    pausepanelmediabutton.ForeColor = Color.Red
                    playpanelmediabutton.ForeColor = Color.Red
                    Label2.ForeColor = Color.Red
                    Label3.ForeColor = Color.Red
                    Label4.ForeColor = Color.Red
                    Label4.ForeColor = Color.Red
                ElseIf s = "My.Resources.storm1" Then
                    Me.BackgroundImage = My.Resources.storm1
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    'logolabel.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    settings.Label11.Text = "Storm"
                    settings.Label13.Text = "Desktop: Themepack"
                    stormplayer.URL = My.Settings.rootdir & "\Sounds\stormsound.mp3"
                    stormplayer.settings.setMode("loop", True)
                    scpopenbutton.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.White

                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.White
                    iprocesslabel.ForeColor = Color.White
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                ElseIf s = "My.Resources.forest" Then
                    Me.BackgroundImage = My.Resources.forest
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    settings.Label11.Text = "Forest"
                    settings.Label13.Text = "Desktop: Themepack"
                    stormplayer.URL = My.Settings.rootdir & "\Sounds\forest.mp3"
                    stormplayer.settings.setMode("loop", True)
                    scpopenbutton.ForeColor = Color.White
                    grouplabel.ForeColor = Color.White
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White

                ElseIf s = "My.Resources._01" Then
                    Me.BackgroundImage = My.Resources._01
                    Me.BackgroundImageLayout = ImageLayout.Stretch

                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "Elegant"
                    settings.Label13.Text = "Desktop: Themepack"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.White
                    closepanelbutton.BackColor = Color.White
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = My.Resources.aeromenu04turned
                    mediapanel.BackgroundImage = My.Resources.aeromenu04turned
                    netpanel.BackgroundImage = My.Resources.aeromenu04turned
                    gamespanel.BackgroundImage = My.Resources.aeromenu04turned
                    systempanel.BackgroundImage = My.Resources.aeromenu04turned
                    menupanel01.BackgroundImage = My.Resources.aeromenu04
                    calendarpanel.BackgroundImage = My.Resources.aeromenu04mirror
                    shortcutpanel.BackgroundImage = My.Resources.aeromenu04mirror
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.White
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                ElseIf s = "My.Resources._03" Then
                    Me.BackgroundImage = My.Resources._03
                    Me.BackgroundImageLayout = ImageLayout.Stretch


                    wcustombutts.ForeColor = Color.Black
                    wcustombuttssmall.ForeColor = Color.Black
                    openaeromediaButton.ForeColor = Color.Black
                    magbutton.ForeColor = Color.Black
                    vmagbutton.ForeColor = Color.Black
                    notesbutton.ForeColor = Color.Black
                    scpopenbutton.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    settings.Label11.Text = "Delicate"
                    settings.Label13.Text = "Desktop: Themepack"
                    timelabel.ForeColor = Color.Black
                    grouplabel.ForeColor = Color.Black

                    openpanelbutton.ForeColor = Color.Black
                    openpanelbutton.BackColor = Color.Transparent
                    closepanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.Black
                    stoppanelmediaButton.ForeColor = Color.Black
                    hidepanelButton.ForeColor = Color.Black
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Black
                    upbutton.BackColor = Color.Black
                    mutebutton.BackColor = Color.Black
                    xlabel.ForeColor = Color.Black
                    ylabel.ForeColor = Color.Black
                    createiconbutton.ForeColor = Color.Black
                    ipcbutton.ForeColor = Color.Black
                    aeromenulabel.ForeColor = Color.Black
                    calendarclosebutton.ForeColor = Color.Black
                    inamelabel.ForeColor = Color.Black
                    iprocesslabel.ForeColor = Color.Black
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.Black
                    temperaturelabel.ForeColor = Color.Black
                    Skylabel.ForeColor = Color.Black
                    locationlabel.ForeColor = Color.Black
                    scpclosebutton.ForeColor = Color.Black
                    closepanelbutton.ForeColor = Color.Black
                    pausepanelmediabutton.ForeColor = Color.Black
                    playpanelmediabutton.ForeColor = Color.Black
                    Label2.ForeColor = Color.Black
                    Label3.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                    Label4.ForeColor = Color.Black
                ElseIf s = "My.Resources.meditate1" Then
                    Me.BackgroundImage = My.Resources.meditate1
                    Me.BackgroundImageLayout = ImageLayout.Stretch


                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    settings.Label11.Text = "Meditation"
                    settings.Label13.Text = "Desktop: Themepack"
                    stormplayer.URL = My.Settings.rootdir & "\Sounds\chillout.mp3"
                    stormplayer.settings.setMode("loop", True)
                    scpopenbutton.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    grouplabel.ForeColor = Color.White

                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Transparent
                    upbutton.BackColor = Color.Transparent
                    mutebutton.BackColor = Color.Transparent
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.White
                    iprocesslabel.ForeColor = Color.White
                    alarmbutton.BackColor = Color.Transparent
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White

                ElseIf s = "My.Resources.Cosmo1" Then
                    Me.BackgroundImage = My.Resources.Cosmo1
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    'logolabel.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    settings.Label11.Text = "Cosmo 1"
                    settings.Label13.Text = "Desktop: Themepack"
                    scpopenbutton.ForeColor = Color.White
                    grouplabel.ForeColor = Color.White
                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Transparent
                    upbutton.BackColor = Color.Transparent
                    mutebutton.BackColor = Color.Transparent
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.White
                    iprocesslabel.ForeColor = Color.White
                    alarmbutton.BackColor = Color.White
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                ElseIf s = "My.Resources.dna1" Then
                    Me.BackgroundImage = My.Resources.dna1
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    'logolabel.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    settings.Label11.Text = "DNA 1"
                    settings.Label13.Text = "Desktop: Themepack"

                    scpopenbutton.ForeColor = Color.White
                    grouplabel.ForeColor = Color.White

                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Transparent
                    upbutton.BackColor = Color.Transparent
                    mutebutton.BackColor = Color.Transparent
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.White
                    iprocesslabel.ForeColor = Color.White
                    alarmbutton.BackColor = Color.White
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                ElseIf s = "My.Resources.ra1" Then
                    Me.BackgroundImage = My.Resources.ra1
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                    wcustombutts.ForeColor = Color.White
                    wcustombuttssmall.ForeColor = Color.White
                    openaeromediaButton.ForeColor = Color.White
                    magbutton.ForeColor = Color.White
                    vmagbutton.ForeColor = Color.White
                    notesbutton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    dmopenbutton.ForeColor = Color.White
                    'logolabel.ForeColor = Color.White
                    timelabel.ForeColor = Color.White
                    openpanelbutton.ForeColor = Color.White
                    openpanelbutton.BackColor = Color.Transparent
                    dmopenbutton.ForeColor = Color.White
                    stoppanelmediaButton.ForeColor = Color.White
                    hidepanelButton.ForeColor = Color.White
                    settings.Label11.Text = "Ra 1"
                    settings.Label13.Text = "Desktop: Themepack"

                    scpopenbutton.ForeColor = Color.White
                    grouplabel.ForeColor = Color.White

                    officepanel.BackgroundImage = Nothing
                    mediapanel.BackgroundImage = Nothing
                    netpanel.BackgroundImage = Nothing
                    gamespanel.BackgroundImage = Nothing
                    systempanel.BackgroundImage = Nothing
                    menupanel01.BackgroundImage = Nothing
                    calendarpanel.BackgroundImage = Nothing
                    shortcutpanel.BackgroundImage = Nothing
                    downbutton.BackColor = Color.Transparent
                    upbutton.BackColor = Color.Transparent
                    mutebutton.BackColor = Color.Transparent
                    xlabel.ForeColor = Color.White
                    ylabel.ForeColor = Color.White
                    createiconbutton.ForeColor = Color.White
                    ipcbutton.ForeColor = Color.White
                    aeromenulabel.ForeColor = Color.White
                    calendarclosebutton.ForeColor = Color.White
                    inamelabel.ForeColor = Color.White
                    iprocesslabel.ForeColor = Color.White
                    alarmbutton.BackColor = Color.White
                    presentuser.ForeColor = Color.White
                    temperaturelabel.ForeColor = Color.White
                    Skylabel.ForeColor = Color.White
                    locationlabel.ForeColor = Color.White
                    scpclosebutton.ForeColor = Color.White
                    closepanelbutton.ForeColor = Color.White
                    pausepanelmediabutton.ForeColor = Color.White
                    playpanelmediabutton.ForeColor = Color.White
                    Label2.ForeColor = Color.White
                    Label3.ForeColor = Color.White
                    Label4.ForeColor = Color.White
                    Label4.ForeColor = Color.White

                End If
            Loop
            sr.Close()
        Catch ex As Exception
        End Try

        For fadein = 0 To 1 Step 0.1
            Me.Opacity = fadein
            Me.Refresh()
            Threading.Thread.Sleep(2)
        Next
        My.Settings.environment = "aero"
        My.Settings.Save()
        My.Settings.Reload()

        'caricamento aero - inizia caricamento bottoni icona
        Try
            Dim npath As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "custombuttons.txt"
            Dim nsr As StreamReader = File.OpenText(npath)
            Dim ls As String
            Do While nsr.Peek() >= 0
                ls = nsr.ReadLine()
                Dim params(6) As String
                params = ls.Split("^"c)

                Dim NewButton As New Button
                Dim myToolTip As New ToolTip()

                'definisce le proprietà del nuovo bottone icona
                With NewButton
                    .Visible = True
                    .Width = CInt(params(0))
                    .Height = CInt(params(1))
                    .BackColor = Color.Transparent
                    .BackgroundImage = My.Resources.App_icon
                    .BackgroundImageLayout = ImageLayout.Zoom
                    .FlatStyle = FlatStyle.Popup
                    '.Text = params(2)
                    .Font = New Font("Kokila", 14, FontStyle.Bold, GraphicsUnit.Pixel)
                    '.Top = CInt(params(4))
                    '.Left = CInt(params(3))
                    myToolTip.SetToolTip(NewButton, "Hover on a border edge until it turns red, then click and drag to move the icon")
                    .Tag = params(6)
                    My.Settings.butttext = params(2)
                End With
                newpanel = New Panel
                newlabel = New Label
                newpanel.Top = CInt(params(4))
                newpanel.Left = CInt(params(3))
                newlabel.Parent = newpanel
                NewButton.Parent = newpanel
                newpanel.Width = NewButton.Width + 26
                newpanel.Height = NewButton.Height + 32
                newlabel.Top = NewButton.Bottom + 4
                newlabel.Text = My.Settings.butttext
                newlabel.Font = New Font("Agate-Normal", 12, FontStyle.Bold, GraphicsUnit.Pixel)
                NewButton.Left = CInt((newpanel.Width \ 2) - (NewButton.Width \ 2))
                newlabel.Left = CInt((newpanel.Width \ 2) - (newlabel.Width \ 2) + 25)
                newpanel.BackColor = Color.Transparent
                newpanel.BorderStyle = BorderStyle.FixedSingle

                Me.Controls.Add(newpanel)
                AddHandler NewButton.Click, AddressOf newbutton_Click
                AddHandler newpanel.MouseUp, AddressOf newpanel_MouseUp
                AddHandler newpanel.MouseDown, AddressOf newpanel_MouseDown
                AddHandler newpanel.MouseMove, AddressOf newpanel_MouseMove
                AddHandler newpanel.MouseHover, AddressOf newpanel_MouseHover
                AddHandler newpanel.MouseLeave, AddressOf newpanel_MouseLeave
            Loop
            nsr.Close()
            'fine caricamento bottoni

        Catch ex As Exception
            'do nothing
        End Try


    End Sub



    'gestisce chiusura di tutto l' ambiente
    Private Sub closebutton_Click(sender As System.Object, e As System.EventArgs) Handles closebutton.Click
        For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 2 Step -1
            Dim form As Form = System.Windows.Forms.Application.OpenForms(i)
            form.Close()
        Next i
        Me.Close()
        loginregister.Close()
    End Sub

    'chiusura di tutte le applicazioni
    Private Sub closeappsbutton_Click(sender As System.Object, e As System.EventArgs) Handles closeappsbutton.Click
        For i = System.Windows.Forms.Application.OpenForms.Count - 1 To 2 Step -1
            Dim form As Form = System.Windows.Forms.Application.OpenForms(i)
            form.Close()
        Next i
    End Sub

    'switch utenti
    Private Sub swithcbutton_Click(sender As System.Object, e As System.EventArgs) Handles swithcbutton.Click
      
        My.Settings.Reload()
        loginregister.Height = 280
        loginregister.logintimer.Enabled = False
        loginregister.useridtext.Text = ""
        loginregister.useridlabel.Text = "UserID:"
        loginregister.passtext.Text = ""
        loginregister.passlabel.Text = "Pass:"
        loginregister.registerbutton.Visible = False
        loginregister.ProgressBar1.Visible = False
        loginregister.ProgressBar1.Value = 0
        loginregister.statuslabel.Visible = False
        loginregister.useridlabel.Visible = True
        loginregister.passlabel.Visible = True
        loginregister.useridtext.Visible = True

        If My.Settings.rootdir = "" Then
            loginregister.loginokbutton.Enabled = False
            loginregister.registerokbutton.Enabled = False
            loginregister.rootbox.Visible = True
            loginregister.rootbutton.Visible = True
            loginregister.rootlabel.Visible = True
        End If
        loginregister.Show()
        Me.Close()
    End Sub

    'i prossimi eventi gestiscono il lancio delle singole applicazioni
    Private Sub mediaplayerbutton_Click(sender As System.Object, e As System.EventArgs) Handles mediaplayerbutton.Click
        mediapanel.Visible = False
        media.Show()
    End Sub
    Private Sub imagebutton_Click(sender As System.Object, e As System.EventArgs) Handles steganobutton.Click
        mediapanel.Visible = False
        stegano.Show()
    End Sub

    Private Sub browserbutton_Click(sender As System.Object, e As System.EventArgs) Handles browserbutton.Click
        netpanel.Visible = False
        browser.Show()
    End Sub
    Private Sub socialButton_Click(sender As System.Object, e As System.EventArgs) Handles socialButton.Click
        netpanel.Visible = False
        socialmanager.Show()
    End Sub
    Private Sub filetransbutton_Click(sender As System.Object, e As System.EventArgs) Handles filetransbutton.Click
        netpanel.Visible = False
        filetransfer.Show()
    End Sub
    Private Sub SpeakButton_Click(sender As System.Object, e As System.EventArgs) Handles SpeakButton.Click
        officepanel.Visible = False
        speak.Show()
    End Sub
    
    Private Sub htmlbutton_Click_1(sender As System.Object, e As System.EventArgs) Handles htmlbutton.Click
        officepanel.Visible = False
        html.Show()
    End Sub
    Private Sub clipmanbutton_Click(sender As System.Object, e As System.EventArgs) Handles clipmanbutton.Click
        clipmanager.Show()
        systempanel.Visible = False
    End Sub
    Private Sub mailbutton_Click(sender As System.Object, e As System.EventArgs) Handles mailbutton.Click
        netpanel.Visible = False
        emailer.Show()
    End Sub
    Private Sub cserverbutton_Click(sender As System.Object, e As System.EventArgs) Handles cserverbutton.Click
        netpanel.Visible = False
        cserve.Show()
    End Sub
    Private Sub cclientbutton_Click(sender As System.Object, e As System.EventArgs) Handles cclientbutton.Click
        netpanel.Visible = False
        cclient.Show()
    End Sub
    Private Sub wordbutton_Click(sender As System.Object, e As System.EventArgs) Handles wordbutton.Click
        officepanel.Visible = False
        write.Show()
    End Sub
    Private Sub calcbutton_Click(sender As System.Object, e As System.EventArgs) Handles calcbutton.Click
        officepanel.Visible = False
        calc.Show()
    End Sub
    Private Sub mapsbutton_Click(sender As System.Object, e As System.EventArgs) Handles mapsbutton.Click
        officepanel.Visible = False
        maps.Show()
    End Sub
    Private Sub breakoutbutton_Click(sender As System.Object, e As System.EventArgs) Handles breakoutbutton.Click
        gamespanel.Visible = False
        breakout.Show()
    End Sub
    
    Private Sub imgcrawlbutton_Click(sender As System.Object, e As System.EventArgs) Handles imgcrawlbutton.Click
        netpanel.Visible = False
        mediacrawler.show()
    End Sub
    Private Sub settingsbutton_Click(sender As System.Object, e As System.EventArgs) Handles settingsbutton.Click
        systempanel.Visible = False
        settings.Show()
    End Sub
    Private Sub djButton_Click(sender As System.Object, e As System.EventArgs) Handles djButton.Click
        mediapanel.Visible = False
        DJconsolePro.Show()
    End Sub
    Private Sub foldersbutton_Click(sender As System.Object, e As System.EventArgs) Handles foldersbutton.Click
        systempanel.Visible = False
        explorer.Show()
    End Sub
    Private Sub notesbutton_Click(sender As System.Object, e As System.EventArgs) Handles notesbutton.Click
        Dim n As New note
        n.Show()
    End Sub
    Private Sub meteobutton_Click(sender As System.Object, e As System.EventArgs) Handles meteobutton.Click
        officepanel.Visible = False
        meteoform.Show()
    End Sub
    Private Sub pokerbutton_Click(sender As System.Object, e As System.EventArgs) Handles pokerbutton.Click
        gamespanel.Visible = False
        poker.Show()
    End Sub
    Private Sub pacmanbutton_Click(sender As System.Object, e As System.EventArgs) Handles pacmanbutton.Click
        gamespanel.Visible = False
        pacman.Show()
    End Sub



    Private Sub dictbutton_Click(sender As System.Object, e As System.EventArgs) Handles dictbutton.Click
        aero_dictionary.Show()
    End Sub

    Private Sub performbutton_Click(sender As System.Object, e As System.EventArgs) Handles performbutton.Click
        systempanel.Visible = False
        performance.Show()

    End Sub
    Private Sub adminbutton_Click(sender As System.Object, e As System.EventArgs) Handles adminbutton.Click
        systempanel.Visible = False
        usersadmin.Show()
    End Sub
    Private Sub paintbutton_Click(sender As System.Object, e As System.EventArgs) Handles paintbutton.Click
        mediapanel.Visible = False
        painter.Show()
    End Sub


    Private Sub alarmbutton_Click(sender As System.Object, e As System.EventArgs) Handles alarmbutton.Click
        alarmclock.Show()
    End Sub
    Private Sub soundrecbutton_Click(sender As System.Object, e As System.EventArgs) Handles soundrecbutton.Click
        mediapanel.Visible = False
        frmSoundRecorder.Show()
    End Sub
    Private Sub reversibutton_Click(sender As System.Object, e As System.EventArgs) Handles reversibutton.Click
        gamespanel.Visible = False
        reversi.Show()
    End Sub
    Private Sub imgbrsbutton_Click(sender As System.Object, e As System.EventArgs) Handles imgbrsbutton.Click
        mediapanel.Visible = False
        imgbrowser.Show()
    End Sub
    Private Sub logolabel_Click(sender As System.Object, e As System.EventArgs)
        aboutbox.Show()
    End Sub
    Private Sub screencaptbutton_Click(sender As System.Object, e As System.EventArgs) Handles screencaptbutton.Click
        mediapanel.Visible = False
        screencapturer.Show()
    End Sub
    Private Sub Stackbutton_Click(sender As System.Object, e As System.EventArgs) Handles Stackbutton.Click
        systempanel.Visible = False
        stack.Show()
    End Sub
    Private Sub wcustombutts_Click(sender As System.Object, e As System.EventArgs) Handles wcustombutts.Click
        externalprogs.Show()
    End Sub
    Private Sub speedtestbutton_Click(sender As System.Object, e As System.EventArgs) Handles speedtestbutton.Click
        speedtest.Show()
        systempanel.Visible = False
    End Sub


    Private Sub calendarclosebutton_Click(sender As System.Object, e As System.EventArgs) Handles calendarclosebutton.Click
        calendarpanel.Visible = False
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub

    'i seguenti eventi gestiscono il ripristino da icona
    Private Sub wbButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles wbButtonsmall.Click
        browser.WindowState = FormWindowState.Normal
        wbButtonsmall.Visible = False
    End Sub
    Private Sub socialButtonSmall_Click(sender As System.Object, e As System.EventArgs) Handles socialButtonSmall.Click
        socialmanager.WindowState = FormWindowState.Normal
        socialButtonSmall.Visible = False
    End Sub
    Private Sub wmButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles wmButtonsmall.Click
        emailer.WindowState = FormWindowState.Normal
        wmButtonsmall.Visible = False
    End Sub
    Private Sub csButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles csButtonsmall.Click
        cserve.WindowState = FormWindowState.Normal
        csButtonsmall.Visible = False
    End Sub
    Private Sub ccButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles ccButtonsmall.Click
        cclient.WindowState = FormWindowState.Normal
        ccButtonsmall.Visible = False
    End Sub
    Private Sub wrButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles wrButtonsmall.Click
        write.WindowState = FormWindowState.Normal
        wrButtonsmall.Visible = False
    End Sub
    Private Sub clButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles clButtonsmall.Click
        calc.WindowState = FormWindowState.Normal
        clButtonsmall.Visible = False
    End Sub
    Private Sub imgcrawlbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles imgcrawlbuttonsmall.Click
        mediacrawler.WindowState = FormWindowState.Normal
        imgcrawlbuttonsmall.Visible = False
    End Sub
    Private Sub mpButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles mpButtonsmall.Click
        media.WindowState = FormWindowState.Normal
        mpButtonsmall.Visible = False
    End Sub
    Private Sub sfButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles sfButtonsmall.Click
        explorer.WindowState = FormWindowState.Normal
        sfButtonsmall.Visible = False
    End Sub
    Private Sub steganoButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles steganoButtonsmall.Click
        stegano.WindowState = FormWindowState.Normal
        steganoButtonsmall.Visible = False
    End Sub
    Private Sub cpButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles cpButtonsmall.Click
        settings.WindowState = FormWindowState.Normal
        cpButtonsmall.Visible = False
    End Sub

    Private Sub brkButtonsmall_Click(sender As System.Object, e As System.EventArgs) Handles brkButtonsmall.Click
        breakout.WindowState = FormWindowState.Normal
        brkButtonsmall.Visible = False
    End Sub
    Private Sub djButtonSmall_Click(sender As System.Object, e As System.EventArgs) Handles djButtonSmall.Click
        DJconsolePro.WindowState = FormWindowState.Normal
        djButtonSmall.Visible = False
    End Sub
    

    Private Sub pokerButtonSmall_Click(sender As System.Object, e As System.EventArgs) Handles pokerButtonSmall.Click
        poker.WindowState = FormWindowState.Normal
        pokerButtonSmall.Visible = False
    End Sub
    Private Sub wcustombuttssmall_Click(sender As System.Object, e As System.EventArgs) Handles wcustombuttssmall.Click
        externalprogs.WindowState = FormWindowState.Normal
        wcustombuttssmall.Visible = False
    End Sub
    Private Sub meteobuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles meteobuttonsmall.Click
        meteoform.WindowState = FormWindowState.Normal
        meteobuttonsmall.Visible = False
    End Sub
    Private Sub performbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles performbuttonsmall.Click
        performance.WindowState = FormWindowState.Normal
        performbuttonsmall.Visible = False
    End Sub
    Private Sub filetransbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles filetransbuttonsmall.Click
        filetransfer.WindowState = FormWindowState.Normal
        filetransbuttonsmall.Visible = False
    End Sub
    Private Sub htmlbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles htmlbuttonsmall.Click
        html.WindowState = FormWindowState.Normal
        htmlbuttonsmall.Visible = False
    End Sub
    Private Sub speakbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles speakbuttonsmall.Click
        speak.WindowState = FormWindowState.Normal
        speakbuttonsmall.Visible = False
    End Sub
    
    Private Sub pacmanbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles pacmanbuttonsmall.Click
        pacman.WindowState = FormWindowState.Normal
        pacmanbuttonsmall.Visible = False
    End Sub
    Private Sub dictbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles dictbuttonsmall.Click
        aero_dictionary.WindowState = FormWindowState.Normal
        dictbuttonsmall.Visible = False
    End Sub
    Private Sub adminbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles adminbuttonsmall.Click
        usersadmin.WindowState = FormWindowState.Normal
        adminbuttonsmall.Visible = False
    End Sub
    Private Sub paintbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles paintbuttonsmall.Click
        painter.WindowState = FormWindowState.Normal
        paintbuttonsmall.Visible = False
    End Sub


    Private Sub reversibuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles reversibuttonsmall.Click
        reversi.WindowState = FormWindowState.Normal
        reversibuttonsmall.Visible = False
    End Sub
    Private Sub soundrecbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles soundrecbuttonsmall.Click
        frmSoundRecorder.WindowState = FormWindowState.Normal
        soundrecbuttonsmall.Visible = False
    End Sub
    Private Sub imgbrsbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles imgbrsbuttonsmall.Click
        imgbrowser.WindowState = FormWindowState.Normal
        imgbrsbuttonsmall.Visible = False
    End Sub
    Private Sub screencaptbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles screencaptbuttonsmall.Click
        screencapturer.WindowState = FormWindowState.Normal
        screencaptbuttonsmall.Visible = False
    End Sub

    Private Sub stackbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles stackbuttonsmall.Click
        stack.WindowState = FormWindowState.Normal
        stackbuttonsmall.Visible = False
    End Sub
    Private Sub mapsbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles mapsbuttonsmall.Click
        maps.WindowState = FormWindowState.Normal
        mapsbuttonsmall.Visible = False
    End Sub
    Private Sub speedtestbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles speedtestbuttonsmall.Click
        speedtest.WindowState = FormWindowState.Normal
        speedtestbuttonsmall.Visible = False
    End Sub
    Private Sub clipmanbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles clipmanbuttonsmall.Click
        clipmanager.WindowState = FormWindowState.Normal
        clipmanbuttonsmall.Visible = False
    End Sub
    Private Sub recentbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles recentbuttonsmall.Click
        recent.WindowState = FormWindowState.Normal
        recent.Visible = False
    End Sub

    'gestione tasti volume desktop
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    Const APPCOMMAND_VOLUME_DOWN As UInteger = &H9
    Const APPCOMMAND_VOLUME_MUTE As UInteger = &H8
    Private Sub upbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upbutton.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_UP * &H10000)
    End Sub
    Private Sub downbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles downbutton.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H30292, APPCOMMAND_VOLUME_DOWN * &H10000)
    End Sub
    Private Sub mutebutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mutebutton.Click
        SendMessage(Me.Handle, WM_APPCOMMAND, &H200EB0, APPCOMMAND_VOLUME_MUTE * &H10000)
    End Sub

    'gestisce il media player on desktop
    Private Sub dmopenbutton_Click(sender As System.Object, e As System.EventArgs) Handles dmopenbutton.Click
        OpenFileDialog1.Filter = "Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav|Audio (*.wma)|*.wma|Audio (*.m4a)|*.m4a"
        OpenFileDialog1.ShowDialog()
        dplayingsongtext.Text = OpenFileDialog1.FileName
        AxWindowsMediaPlayer1.URL = dplayingsongtext.Text
    End Sub
    Private Sub openaeromediabutton_Click(sender As System.Object, e As System.EventArgs) Handles openaeromediaButton.Click
        aeromediapanel.Visible = True
        openaeromediaButton.Visible = False
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub
    Private Sub hidepanelButton_Click(sender As System.Object, e As System.EventArgs) Handles hidepanelButton.Click
        aeromediapanel.Visible = False
        openaeromediaButton.Visible = True
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub
    Private Sub stoppanelmediaButton_Click(sender As System.Object, e As System.EventArgs) Handles stoppanelmediaButton.Click
        AxWindowsMediaPlayer1.URL = ""
    End Sub
    Private Sub AxWindowsMediaPlayer1_PlayStateChange(sender As System.Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles AxWindowsMediaPlayer1.PlayStateChange
        If (AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying) Then
            hiphoplady.Visible = True
            buddydancer.Visible = True
        Else
            hiphoplady.Visible = False
            buddydancer.Visible = False
        End If
    End Sub

    'gestione avatar danzanti
    Private Sub buddydancer_Click(sender As System.Object, e As System.EventArgs) Handles buddydancer.Click
        dancersetup.Show()
    End Sub
    Private Sub hiphoplady_DoubleClick(sender As System.Object, e As System.EventArgs) Handles hiphoplady.DoubleClick
        dancerladysetup.Show()
    End Sub
    Private Sub hiphoplady_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles hiphoplady.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub

    Private Sub hiphoplady_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles hiphoplady.MouseMove
        If drag Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub hiphoplady_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles hiphoplady.MouseUp
        drag = False
    End Sub

    'i seguenti eventi gestiscono il menu tasto destro di aero

    Private Sub SpeakToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SpeakToolStripMenuItem.Click
        speak.Show()
    End Sub
    Private Sub PlayBreakoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayBreakoutToolStripMenuItem.Click
        breakout.Show()
    End Sub
    Private Sub PlayPokerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PlayPokerToolStripMenuItem.Click
        poker.Show()
    End Sub

    Private Sub SetAlarmToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SetAlarmToolStripMenuItem.Click
        alarmclock.Show()
    End Sub
    Private Sub FastSettingsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FastSettingsToolStripMenuItem.Click
        settings.Show()
    End Sub
    Private Sub BrowseInternetToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles BrowseInternetToolStripMenuItem.Click
        browser.Show()
    End Sub
    Private Sub SendEmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SendEmailToolStripMenuItem.Click
        emailer.Show()
    End Sub
    Private Sub WriteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WriteToolStripMenuItem.Click
        write.Show()
    End Sub
    
    Private Sub LaunchMediaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LaunchMediaToolStripMenuItem.Click
        media.Show()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        aboutbox.Show()
    End Sub

    Private Sub ThemeMusicStopToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ThemeMusicStopToolStripMenuItem.Click
        stormplayer.settings.setMode("loop", False)
        stormplayer.Ctlcontrols.stop()
    End Sub
    Private Sub ThemeMusicPlayToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ThemeMusicPlayToolStripMenuItem.Click
        stormplayer.settings.setMode("loop", True)
        stormplayer.Ctlcontrols.play()
    End Sub

    'gestione magnets image
    Private Sub magbutton_Click(sender As System.Object, e As System.EventArgs) Handles magbutton.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Image files (*.jpg,gif,bmp)|*.jpg;*.gif;*.bmp"
        If ofd.ShowDialog() = DialogResult.OK Then
            Dim picFile As String = ofd.FileName
            Dim pic As New Bitmap(picFile)
            NewMagnet = New PictureBox
            NewMagnet.Parent = Me
            NewMagnet.Location = New Point(400, 150)
            If pic.Width > 300 Then
                MsgBox("Image too big, it will be rescaled")
            End If
            magnetratio = (pic.Width / pic.Height)
            magnetwidth = 300
            magnetheight = Int(magnetwidth / magnetratio)
            NewMagnet.BackColor = Color.Transparent
            NewMagnet.BorderStyle = BorderStyle.FixedSingle
            NewMagnet.Image = pic
            NewMagnet.Width = magnetwidth
            NewMagnet.Height = magnetheight
            NewMagnet.SizeMode = PictureBoxSizeMode.Zoom

            Me.Controls.Add(NewMagnet)
            AddHandler NewMagnet.MouseUp, AddressOf PictureBox_MouseUp
            AddHandler NewMagnet.MouseDown, AddressOf PictureBox_MouseDown
            AddHandler NewMagnet.MouseMove, AddressOf PictureBox_MouseMove
            AddHandler NewMagnet.DoubleClick, AddressOf PictureBox_DoubleClick
        End If

    End Sub
    Private Sub PictureBox_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub
    Private Sub PictureBox_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub
    Private Sub PictureBox_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub PictureBox_DoubleClick(sender As Object, e As MouseEventArgs)
        Me.Controls.Remove(sender)
    End Sub
    'gestisce il pannello per l' aggiunta icone nel desktop
    Private Sub scpopenbutton_Click(sender As System.Object, e As System.EventArgs) Handles scpopenbutton.Click
        shortcutpanel.Visible = True
        scpopenbutton.Visible = False
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub

    Private Sub scpclosebutton_Click(sender As System.Object, e As System.EventArgs) Handles scpclosebutton.Click
        shortcutpanel.Visible = False
        scpopenbutton.Visible = True
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub

    Private Sub ipcbutton_Click(sender As System.Object, e As System.EventArgs) Handles ipcbutton.Click
        Dim ofd As New OpenFileDialog With {.Filter = "Supported Files|*.exe"}
        On Error Resume Next
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            iconprocesstext.Text = ofd.FileName
        End If
    End Sub
    'salva nome e processo in un file e definisce il bottone icona
    Private Sub createiconbutton_Click(sender As System.Object, e As System.EventArgs) Handles createiconbutton.Click
        My.Settings.butttext = iconnametext.Text
        My.Settings.buttprocess = iconprocesstext.Text
        My.Settings.Save()
        My.Settings.Reload()

        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "custombuttons.txt"
        Dim sw As StreamWriter

        If File.Exists(path) = False Then
            sw = File.CreateText(path)
            sw.WriteLine("65^65^" & iconnametext.Text & "^" & iconYtext.Text & "^" & iconXtext.Text & "^" & iconnametext.Text & "^" & iconprocesstext.Text)
            sw.Flush()
            sw.Close()
        Else
            sw = File.AppendText(path)
            sw.WriteLine("65^65^" & iconnametext.Text & "^" & iconYtext.Text & "^" & iconXtext.Text & "^" & iconnametext.Text & "^" & iconprocesstext.Text)
            sw.Flush()
            sw.Close()
        End If

        Dim NewButton As New Button
        Dim myToolTip As New ToolTip()
        Dim newpanel As New Panel
        Dim newlabel As New Label
        'definisce le proprietà del nuovo bottone icona
        With NewButton
            .Width = 65
            .Height = 65
            .BackColor = Color.Transparent
            .FlatStyle = FlatStyle.Popup
            .BackgroundImage = My.Resources.App_icon
            .BackgroundImageLayout = ImageLayout.Zoom
            .Font = New Font("Agate", 11, FontStyle.Bold, GraphicsUnit.Pixel)
            myToolTip.SetToolTip(NewButton, "Hover on a border edge until it flashes red, then click and drag to move the icon")
            .Tag = My.Settings.buttprocess
        End With

        newpanel = New Panel
        newlabel = New Label
        newpanel.Top = CInt(iconYtext.Text)
        newpanel.Left = CInt(iconXtext.Text)
        newlabel.Parent = newpanel
        NewButton.Parent = newpanel
        newpanel.Width = NewButton.Width + 26
        newpanel.Height = NewButton.Height + 32
        newlabel.Top = NewButton.Bottom + 4
        newlabel.Text = My.Settings.butttext
        newlabel.Font = New Font("Agate-Normal", 12, FontStyle.Bold, GraphicsUnit.Pixel)
        NewButton.Left = CInt((newpanel.Width \ 2) - (NewButton.Width \ 2))
        newlabel.Left = CInt((newpanel.Width \ 2) - (newlabel.Width \ 2) + 25)
        newpanel.BackColor = Color.Transparent
        newpanel.BorderStyle = BorderStyle.FixedSingle

        Me.Controls.Add(newpanel)
        My.Computer.Audio.Play(My.Resources.HitWall, AudioPlayMode.Background)
        AddHandler NewButton.Click, AddressOf newbutton_Click
        AddHandler newpanel.MouseUp, AddressOf newpanel_MouseUp
        AddHandler newpanel.MouseDown, AddressOf newpanel_MouseDown
        AddHandler newpanel.MouseMove, AddressOf newpanel_MouseMove
        AddHandler newpanel.MouseHover, AddressOf newpanel_MouseHover
        AddHandler newpanel.MouseLeave, AddressOf newpanel_MouseLeave

    End Sub
    Friend Sub newbutton_Click(sender As Object, e As MouseEventArgs)
        Try
            Process.Start(sender.tag)
        Catch ex As Exception
            MsgBox("Cannot start process - check definition: " & My.Settings.buttprocess & " -- " & My.Settings.butttext)
        End Try
        dict.Clear()
    End Sub
    Private Sub newbutton_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub
    Private Sub newbutton_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False

    End Sub
    Private Sub newbutton_MouseMove(sender As Object, e As MouseEventArgs)
        If drag = True Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub newpanel_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub
    Private Sub newpanel_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub
    Private Sub newpanel_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub newpanel_MouseHover(sender As Object, e As System.EventArgs)
        sender.backcolor = Color.Red
    End Sub
    Private Sub newpanel_MouseLeave(sender As Object, e As System.EventArgs)
        sender.backcolor = Color.Transparent
    End Sub
    'gestisce il dizionario
    Private Sub LeggiDizionario(sender As Object, FullPathFileName As String)
        Dim lines As String() = IO.File.ReadAllLines(FullPathFileName)
        For Each line As String In lines
            Dim kv As KeyValuePair(Of String, String) = ToKeyValuePair(line)
            dict.Add(kv.Key, kv.Value)
            If kv.Key = sender.text Then
                My.Settings.buttprocess = kv.Value
            End If
        Next
    End Sub
    Public Function ToKeyValuePair(pair As String) As KeyValuePair(Of String, String)
        Dim two As String() = pair.Split("^")
        Return New KeyValuePair(Of String, String)(two(0), two(1))
    End Function


    'gestisce i video magnet
   
    Private Sub vmagbutton_Click(sender As System.Object, e As System.EventArgs) Handles vmagbutton.Click
        Dim url As String = InputBox("Insert video URL:")
        Dim myvtooltip As New ToolTip()
        newvpanel = New Panel
        newvmagnet = New AxAXVLC.AxVLCPlugin2
        newvpanel.Top = 150
        newvpanel.Left = 400
        newvmagnet.Parent = newvpanel
        newvmagnet.Width = 400
        newvmagnet.Height = 250
        newvpanel.Width = newvmagnet.Width + 30
        newvpanel.Height = newvmagnet.Height + 30
        newvmagnet.Left = CInt((newvpanel.Width \ 2) - (newvmagnet.Width \ 2))
        newvpanel.BackColor = Color.Transparent
        newvpanel.BorderStyle = BorderStyle.FixedSingle
        myvtooltip.SetToolTip(newvpanel, "Click on the red edge and drag to move - double click to close")
        Me.Controls.Add(newvpanel)
        newvmagnet.playlist.stop()
        newvmagnet.playlist.items.clear()

        If url <> "" Then
            newvmagnet.playlist.add(url)
            newvmagnet.playlist.play()
        Else
            Me.Controls.Remove(newvpanel)
        End If

        AddHandler newvpanel.DoubleClick, AddressOf newvpanel_DoubleClick
        AddHandler newvpanel.MouseUp, AddressOf newvpanel_MouseUp
        AddHandler newvpanel.MouseDown, AddressOf newvpanel_MouseDown
        AddHandler newvpanel.MouseMove, AddressOf newvpanel_MouseMove
        AddHandler newvpanel.MouseHover, AddressOf newvpanel_MouseHover
        AddHandler newvpanel.MouseLeave, AddressOf newvpanel_MouseLeave
    
    End Sub
    Private Sub newvpanel_MouseDown(sender As Object, e As MouseEventArgs)
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - sender.Left
        mousey = Windows.Forms.Cursor.Position.Y - sender.Top
    End Sub
    Private Sub newvpanel_MouseUp(sender As Object, e As MouseEventArgs)
        drag = False
    End Sub
    Private Sub newvpanel_MouseMove(sender As Object, e As MouseEventArgs)
        If drag Then
            sender.Top = Windows.Forms.Cursor.Position.Y - mousey
            sender.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Private Sub newvpanel_MouseHover(sender As Object, e As System.EventArgs)
        sender.backcolor = Color.Red
    End Sub
    Private Sub newvpanel_MouseLeave(sender As Object, e As System.EventArgs)
        sender.backcolor = Color.Transparent
    End Sub
    Private Sub newvpanel_DoubleClick(sender As Object, e As MouseEventArgs)
        sender.newvmagnet.playlist.stop()
        Me.Controls.Remove(sender)
    End Sub

   

    Private Sub ManageClipboardToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ManageClipboardToolStripMenuItem.Click
        clipmanager.Show()
    End Sub

    Private Sub DiskExplorerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DiskExplorerToolStripMenuItem.Click
        explorer.Show()
    End Sub



    Private Sub notepadbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles notepadbuttonsmall.Click
        notepad.WindowState = FormWindowState.Normal
        notepadbuttonsmall.Visible = False
    End Sub

    Private Sub notepadbutton_Click(sender As System.Object, e As System.EventArgs) Handles notepadbutton.Click
        notepad.Show()
        officepanel.Visible = False
    End Sub

    Private Sub volbutton_Click(sender As System.Object, e As System.EventArgs) Handles volbutton.Click
        If volpanel.Visible = True Then
            volpanel.Visible = False
        ElseIf volpanel.Visible = False Then
            volpanel.Visible = True
        End If
    End Sub



    Private Sub scanbutton_Click(sender As System.Object, e As System.EventArgs) Handles scanbutton.Click
        scanner.Show()
        mediapanel.Visible = False
    End Sub

    Private Sub scanbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles scanbuttonsmall.Click
        scanner.WindowState = FormWindowState.Normal
        scanbuttonsmall.Visible = False
    End Sub

    Private Sub cdburnerbutton_Click(sender As System.Object, e As System.EventArgs) Handles cdburnerbutton.Click
        systempanel.Visible = False
        cdburner.Show()
    End Sub



    Private Sub cdburnerbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles cdburnerbuttonsmall.Click
        cdburner.WindowState = FormWindowState.Normal
        cdburnerbuttonsmall.Visible = False
    End Sub



    Private Sub spaceinvbutton_Click(sender As System.Object, e As System.EventArgs) Handles spaceinvbutton.Click
        gamespanel.Visible = False
        SPACEINVADERS.Show()
    End Sub

    Private Sub spaceinvbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles spaceinvbuttonsmall.Click
        SPACEINVADERS.WindowState = FormWindowState.Normal
        spaceinvbuttonsmall.Visible = False
    End Sub

    Private Sub RunWindowsProgramToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RunWindowsProgramToolStripMenuItem.Click
        runwindows.Show()
    End Sub

    Private Sub recentbutton_Click(sender As System.Object, e As System.EventArgs) Handles recentbutton.Click
        recent.Show()
    End Sub


    Private Sub RDserver_Click(sender As System.Object, e As System.EventArgs) Handles RDserver.Click
        desktopclient.Show()
    End Sub

    Private Sub RDclient_Click(sender As System.Object, e As System.EventArgs) Handles RDclient.Click
        mServer.Show()
    End Sub

    Private Sub MapsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MapsToolStripMenuItem.Click
        maps.Show()
    End Sub

    Private Sub RecentFilesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RecentFilesToolStripMenuItem.Click
        recent.Show()
    End Sub


    Private Sub flistbutton_Click(sender As System.Object, e As System.EventArgs) Handles flistbutton.Click
        officepanel.Visible = False
        friendlist.Show()
    End Sub

    Private Sub flistbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles flistbuttonsmall.Click
        friendlist.WindowState = FormWindowState.Normal
        flistbuttonsmall.Visible = False
    End Sub

    Private Sub magnibutton_Click(sender As System.Object, e As System.EventArgs) Handles magnibutton.Click
        frmStart.Show()
        systempanel.Visible = False
    End Sub

    Private Sub magnifbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles magnifbuttonsmall.Click
        frmStart.WindowState = FormWindowState.Normal
        magnifbuttonsmall.Visible = False
    End Sub

    Private Sub MagnifierToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MagnifierToolStripMenuItem.Click
        frmStart.Show()
    End Sub

    Private Sub rssbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles rssbuttonsmall.Click
        RSSfeed.WindowState = FormWindowState.Normal
        magnifbuttonsmall.Visible = False
    End Sub

    Private Sub rssbutton_Click(sender As System.Object, e As System.EventArgs) Handles rssbutton.Click
        RSSfeed.Show()
        officepanel.Visible = False
    End Sub

    Private Sub Flashbutton_Click(sender As System.Object, e As System.EventArgs) Handles Flashbutton.Click
        flashgames.Show()
        gamespanel.Visible = False
    End Sub

    Private Sub flashbuttonsmall_Click(sender As System.Object, e As System.EventArgs) Handles flashbuttonsmall.Click
        flashgames.WindowState = FormWindowState.Normal
        flashbuttonsmall.Visible = False
    End Sub

    Private Sub pausepanelmediabutton_Click(sender As System.Object, e As System.EventArgs) Handles pausepanelmediabutton.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub playpanelmediabutton_Click(sender As System.Object, e As System.EventArgs)
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Timermeteo_Tick(sender As System.Object, e As System.EventArgs) Handles Timermeteo.Tick
        If My.Computer.Network.IsAvailable = True Then

            'WebBrowsermeteo.Refresh()
            Call RefreshWeather()
        Else
            temperaturelabel.Text = "Meteo OFF"
            MsgBox("WARNING: Internet connection is not available." & vbCrLf & "Aero2018 maynot work properly")
        End If


    End Sub
    'routine di aggiornamento meteo dal timer
    Sub RefreshWeather()
        Try
            WebBrowsermeteo.Navigate("https://www.google.it/search?hl=en&output=search&sclient=psy-ab&q=weather&oq=weather&gs_l=hp.3..0l4.625.1527.0.1660.7.4.0.3.3.1.285.1061.2-4.4.0....0...1c.1.23.psy-ab..1.6.801.-zxBfQ8sKjM&pbx=1&bav=on.2,or.r_cp.r_qf.&bvm=bv.49967636,d.aWc&biw=1366&bih=581&cad=h")


        Catch ex As Exception
        End Try
    End Sub


    Private Sub timelabel_Click(sender As System.Object, e As System.EventArgs) Handles timelabel.Click
        calendarpanel.Visible = True
        My.Computer.Audio.Play(My.Resources.HitHardBrick, AudioPlayMode.Background)
    End Sub

    'primo caricamento del meteo sul desktop
    Private Sub WebBrowsermeteo_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowsermeteo.DocumentCompleted


        Try
            temperaturelabel.Text = WebBrowsermeteo.Document.GetElementById("wob_tm").GetAttribute("innerText") & "°C"
            Skylabel.Text = WebBrowsermeteo.Document.GetElementById("wob_dc").GetAttribute("innerText")
            locationlabel.Text = WebBrowsermeteo.Document.GetElementById("wob_loc").GetAttribute("innerText")
            If Skylabel.Text.Contains("Haze") Then
                PictureMeteo.Image = My.Resources.fog
            End If
            If Skylabel.Text.Contains("Overcast") Then
                PictureMeteo.Image = My.Resources.cloudy
            End If
            If Skylabel.Text.Contains("Cloud") Then
                PictureMeteo.Image = My.Resources.partly_cloudy
            End If
            If Skylabel.Text.Contains("Clear") Or Skylabel.Text.Contains("Sunny") Then
                PictureMeteo.Image = My.Resources.sunny
            End If
            If Skylabel.Text.Contains("Fog") Then
                PictureMeteo.Image = My.Resources.fog
            End If
            If Skylabel.Text.Contains("Storm") Then
                PictureMeteo.Image = My.Resources.rain_s_cloudy
            End If
            If Skylabel.Text.Contains("rain") Or Skylabel.Text.Contains("Rain") Then
                PictureMeteo.Image = My.Resources.rain_light
            End If


        Catch ex As Exception
        End Try
        'Timermeteo.Start()
    End Sub


    Private Sub PictureMeteo_Click(sender As System.Object, e As System.EventArgs) Handles PictureMeteo.Click
        meteoform.Show()
    End Sub

  
End Class