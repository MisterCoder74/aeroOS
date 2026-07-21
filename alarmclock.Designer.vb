<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alarmclock
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(alarmclock))
        Me.alarmname = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.setalarm = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.choose = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.alertlabel = New System.Windows.Forms.Label()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'alarmname
        '
        Me.alarmname.Location = New System.Drawing.Point(187, 71)
        Me.alarmname.Name = "alarmname"
        Me.alarmname.Size = New System.Drawing.Size(163, 20)
        Me.alarmname.TabIndex = 0
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DateTimePicker1.Location = New System.Drawing.Point(248, 107)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.ShowUpDown = True
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alarm name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Alarm time"
        '
        'setalarm
        '
        Me.setalarm.BackColor = System.Drawing.Color.Transparent
        Me.setalarm.FlatAppearance.BorderSize = 0
        Me.setalarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.setalarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.setalarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.setalarm.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.setalarm.Location = New System.Drawing.Point(187, 208)
        Me.setalarm.Name = "setalarm"
        Me.setalarm.Size = New System.Drawing.Size(163, 30)
        Me.setalarm.TabIndex = 8
        Me.setalarm.Text = "Set alarm"
        Me.setalarm.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(187, 148)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(163, 20)
        Me.TextBox1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Alarm music"
        '
        'choose
        '
        Me.choose.BackColor = System.Drawing.Color.Transparent
        Me.choose.FlatAppearance.BorderSize = 0
        Me.choose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.choose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.choose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.choose.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.choose.Location = New System.Drawing.Point(187, 174)
        Me.choose.Name = "choose"
        Me.choose.Size = New System.Drawing.Size(163, 28)
        Me.choose.TabIndex = 27
        Me.choose.Text = "Choose alarm music"
        Me.choose.UseVisualStyleBackColor = False
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(47, 196)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
        Me.AxWindowsMediaPlayer1.TabIndex = 28
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'alertlabel
        '
        Me.alertlabel.AutoSize = True
        Me.alertlabel.BackColor = System.Drawing.Color.Transparent
        Me.alertlabel.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alertlabel.ForeColor = System.Drawing.Color.Black
        Me.alertlabel.Location = New System.Drawing.Point(44, 26)
        Me.alertlabel.Name = "alertlabel"
        Me.alertlabel.Size = New System.Drawing.Size(351, 15)
        Me.alertlabel.TabIndex = 29
        Me.alertlabel.Text = "- CLICK ON 'CLOSE' TO STOP ALARM -"
        Me.alertlabel.Visible = False
        '
        'alarmclock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(428, 250)
        Me.Controls.Add(Me.alertlabel)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.choose)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.setalarm)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.alarmname)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "alarmclock"
        Me.ShowIcon = False
        Me.Text = "Alarm clock"
        Me.TopMost = True
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents alarmname As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents setalarm As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents choose As System.Windows.Forms.Button
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents alertlabel As System.Windows.Forms.Label
End Class
