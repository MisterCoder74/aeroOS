Imports System.IO
Public Class alarmclock

    Dim alarmTime As Date  'The time of the alarm
    Dim alarmNameText As String  'The alarm's name
    Dim alarmIsSet As Boolean = False 'Will determine whether alarm is set or not

    Private Sub setalarm_Click(sender As System.Object, e As System.EventArgs) Handles setalarm.Click
        alarmIsSet = True
        Timer1.Enabled = True
        Me.Visible = False 'Hides the form
        alarmTime = DateTimePicker1.Value
        alarmNameText = alarmname.Text
        'aero.alarmbutton.Image = My.Resources.Time_Alarm_Set_clock_icon
        aero.alarmbutton.BackColor = Color.LightPink
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If My.Computer.Clock.LocalTime.TimeOfDay.ToString.Substring(0, 5) = alarmTime.TimeOfDay.ToString.Substring(0, 5) Then
            AxWindowsMediaPlayer1.URL = TextBox1.Text
            Me.Show()
            alertlabel.Visible = True
            Timer1.Enabled = False
            aero.alarmbutton.Image = My.Resources.Time_Alarm_clock_icon
            aero.alarmbutton.BackColor = Color.Transparent
        End If
    End Sub

    Private Sub choose_Click(sender As System.Object, e As System.EventArgs) Handles choose.Click
        OpenFileDialog1.Filter = "Audio (*.mp3)|*.mp3|Audio (*.wav)|*.wav"
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub alarmclock_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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