<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginregister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginregister))
        Me.useridtext = New System.Windows.Forms.TextBox()
        Me.useridlabel = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.loginokbutton = New System.Windows.Forms.Button()
        Me.registerokbutton = New System.Windows.Forms.Button()
        Me.increasetimer = New System.Windows.Forms.Timer(Me.components)
        Me.statuslabel = New System.Windows.Forms.Label()
        Me.registertimer = New System.Windows.Forms.Timer(Me.components)
        Me.logintimer = New System.Windows.Forms.Timer(Me.components)
        Me.passlabel = New System.Windows.Forms.Label()
        Me.passtext = New System.Windows.Forms.TextBox()
        Me.registerbutton = New System.Windows.Forms.Button()
        Me.loginbutton = New System.Windows.Forms.Button()
        Me.rootbutton = New System.Windows.Forms.Button()
        Me.rootbox = New System.Windows.Forms.TextBox()
        Me.rootlabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rolebox = New System.Windows.Forms.ComboBox()
        Me.rolelabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'useridtext
        '
        Me.useridtext.Location = New System.Drawing.Point(150, 104)
        Me.useridtext.Name = "useridtext"
        Me.useridtext.Size = New System.Drawing.Size(159, 20)
        Me.useridtext.TabIndex = 2
        Me.useridtext.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "insert user ID"
        Me.useridtext.Visible = False
        '
        'useridlabel
        '
        Me.useridlabel.AutoSize = True
        Me.useridlabel.BackColor = System.Drawing.Color.Transparent
        Me.useridlabel.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.useridlabel.ForeColor = System.Drawing.Color.Black
        Me.useridlabel.Location = New System.Drawing.Point(82, 107)
        Me.useridlabel.Name = "useridlabel"
        Me.useridlabel.Size = New System.Drawing.Size(61, 14)
        Me.useridlabel.TabIndex = 8
        Me.useridlabel.Text = "UserID"
        Me.useridlabel.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(76, 217)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(332, 11)
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'loginokbutton
        '
        Me.loginokbutton.BackColor = System.Drawing.Color.Transparent
        Me.loginokbutton.FlatAppearance.BorderSize = 0
        Me.loginokbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginokbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginokbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginokbutton.ForeColor = System.Drawing.Color.Black
        Me.loginokbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginokbutton.Location = New System.Drawing.Point(150, 153)
        Me.loginokbutton.Name = "loginokbutton"
        Me.loginokbutton.Size = New System.Drawing.Size(80, 25)
        Me.loginokbutton.TabIndex = 4
        Me.loginokbutton.Text = "Login"
        Me.loginokbutton.UseVisualStyleBackColor = False
        Me.loginokbutton.Visible = False
        '
        'registerokbutton
        '
        Me.registerokbutton.BackColor = System.Drawing.Color.Transparent
        Me.registerokbutton.FlatAppearance.BorderSize = 0
        Me.registerokbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.registerokbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerokbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerokbutton.ForeColor = System.Drawing.Color.Black
        Me.registerokbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.registerokbutton.Location = New System.Drawing.Point(329, 154)
        Me.registerokbutton.Name = "registerokbutton"
        Me.registerokbutton.Size = New System.Drawing.Size(79, 25)
        Me.registerokbutton.TabIndex = 5
        Me.registerokbutton.Text = "Register"
        Me.registerokbutton.UseVisualStyleBackColor = False
        Me.registerokbutton.Visible = False
        '
        'increasetimer
        '
        Me.increasetimer.Interval = 1
        '
        'statuslabel
        '
        Me.statuslabel.AutoSize = True
        Me.statuslabel.BackColor = System.Drawing.Color.Transparent
        Me.statuslabel.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslabel.ForeColor = System.Drawing.Color.Black
        Me.statuslabel.Location = New System.Drawing.Point(58, 235)
        Me.statuslabel.Name = "statuslabel"
        Me.statuslabel.Size = New System.Drawing.Size(0, 14)
        Me.statuslabel.TabIndex = 9
        Me.statuslabel.Visible = False
        '
        'logintimer
        '
        '
        'passlabel
        '
        Me.passlabel.AutoSize = True
        Me.passlabel.BackColor = System.Drawing.Color.Transparent
        Me.passlabel.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passlabel.ForeColor = System.Drawing.Color.Black
        Me.passlabel.Location = New System.Drawing.Point(99, 131)
        Me.passlabel.Name = "passlabel"
        Me.passlabel.Size = New System.Drawing.Size(45, 14)
        Me.passlabel.TabIndex = 10
        Me.passlabel.Text = "Pass"
        Me.passlabel.Visible = False
        '
        'passtext
        '
        Me.passtext.Location = New System.Drawing.Point(150, 127)
        Me.passtext.Name = "passtext"
        Me.passtext.Size = New System.Drawing.Size(159, 20)
        Me.passtext.TabIndex = 3
        Me.passtext.Text = "password"
        Me.passtext.UseSystemPasswordChar = True
        Me.passtext.Visible = False
        '
        'registerbutton
        '
        Me.registerbutton.BackColor = System.Drawing.Color.Transparent
        Me.registerbutton.FlatAppearance.BorderSize = 0
        Me.registerbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.registerbutton.Font = New System.Drawing.Font("Agate-Normal", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registerbutton.ForeColor = System.Drawing.Color.Black
        Me.registerbutton.Image = CType(resources.GetObject("registerbutton.Image"), System.Drawing.Image)
        Me.registerbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.registerbutton.Location = New System.Drawing.Point(277, 19)
        Me.registerbutton.Name = "registerbutton"
        Me.registerbutton.Size = New System.Drawing.Size(131, 79)
        Me.registerbutton.TabIndex = 1
        Me.registerbutton.Text = "Add User"
        Me.registerbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.registerbutton.UseVisualStyleBackColor = False
        '
        'loginbutton
        '
        Me.loginbutton.BackColor = System.Drawing.Color.Transparent
        Me.loginbutton.FlatAppearance.BorderSize = 0
        Me.loginbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginbutton.Font = New System.Drawing.Font("Agate-Normal", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginbutton.ForeColor = System.Drawing.Color.Black
        Me.loginbutton.Image = CType(resources.GetObject("loginbutton.Image"), System.Drawing.Image)
        Me.loginbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.loginbutton.Location = New System.Drawing.Point(76, 19)
        Me.loginbutton.Name = "loginbutton"
        Me.loginbutton.Size = New System.Drawing.Size(131, 79)
        Me.loginbutton.TabIndex = 0
        Me.loginbutton.Text = "Login"
        Me.loginbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.loginbutton.UseVisualStyleBackColor = False
        '
        'rootbutton
        '
        Me.rootbutton.BackColor = System.Drawing.Color.Transparent
        Me.rootbutton.FlatAppearance.BorderSize = 0
        Me.rootbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.rootbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rootbutton.Font = New System.Drawing.Font("Agate-Normal", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootbutton.ForeColor = System.Drawing.Color.Black
        Me.rootbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.rootbutton.Location = New System.Drawing.Point(378, 190)
        Me.rootbutton.Name = "rootbutton"
        Me.rootbutton.Size = New System.Drawing.Size(30, 19)
        Me.rootbutton.TabIndex = 11
        Me.rootbutton.Text = "[...]"
        Me.rootbutton.UseVisualStyleBackColor = False
        Me.rootbutton.Visible = False
        '
        'rootbox
        '
        Me.rootbox.Location = New System.Drawing.Point(150, 189)
        Me.rootbox.Name = "rootbox"
        Me.rootbox.Size = New System.Drawing.Size(222, 20)
        Me.rootbox.TabIndex = 12
        Me.rootbox.Visible = False
        '
        'rootlabel
        '
        Me.rootlabel.AutoSize = True
        Me.rootlabel.BackColor = System.Drawing.Color.Transparent
        Me.rootlabel.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootlabel.ForeColor = System.Drawing.Color.Black
        Me.rootlabel.Location = New System.Drawing.Point(73, 192)
        Me.rootlabel.Name = "rootlabel"
        Me.rootlabel.Size = New System.Drawing.Size(70, 14)
        Me.rootlabel.TabIndex = 13
        Me.rootlabel.Text = "Root dir"
        Me.rootlabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(53, 209)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(0, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'rolebox
        '
        Me.rolebox.FormattingEnabled = True
        Me.rolebox.Items.AddRange(New Object() {"admin", "auper user", "user"})
        Me.rolebox.Location = New System.Drawing.Point(329, 127)
        Me.rolebox.Name = "rolebox"
        Me.rolebox.Size = New System.Drawing.Size(79, 21)
        Me.rolebox.TabIndex = 15
        Me.rolebox.Visible = False
        '
        'rolelabel
        '
        Me.rolelabel.AutoSize = True
        Me.rolelabel.BackColor = System.Drawing.Color.Transparent
        Me.rolelabel.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rolelabel.ForeColor = System.Drawing.Color.Black
        Me.rolelabel.Location = New System.Drawing.Point(347, 110)
        Me.rolelabel.Name = "rolelabel"
        Me.rolelabel.Size = New System.Drawing.Size(43, 14)
        Me.rolelabel.TabIndex = 16
        Me.rolelabel.Text = "Role"
        Me.rolelabel.Visible = False
        '
        'loginregister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.base
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(474, 252)
        Me.Controls.Add(Me.rolelabel)
        Me.Controls.Add(Me.rolebox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.rootlabel)
        Me.Controls.Add(Me.rootbox)
        Me.Controls.Add(Me.rootbutton)
        Me.Controls.Add(Me.passlabel)
        Me.Controls.Add(Me.passtext)
        Me.Controls.Add(Me.statuslabel)
        Me.Controls.Add(Me.registerokbutton)
        Me.Controls.Add(Me.loginokbutton)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.useridlabel)
        Me.Controls.Add(Me.useridtext)
        Me.Controls.Add(Me.registerbutton)
        Me.Controls.Add(Me.loginbutton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "loginregister"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aero 2020"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginbutton As System.Windows.Forms.Button
    Friend WithEvents registerbutton As System.Windows.Forms.Button
    Friend WithEvents useridtext As System.Windows.Forms.TextBox
    Friend WithEvents useridlabel As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents loginokbutton As System.Windows.Forms.Button
    Friend WithEvents registerokbutton As System.Windows.Forms.Button
    Friend WithEvents increasetimer As System.Windows.Forms.Timer
    Friend WithEvents statuslabel As System.Windows.Forms.Label
    Friend WithEvents registertimer As System.Windows.Forms.Timer
    Friend WithEvents logintimer As System.Windows.Forms.Timer
    Friend WithEvents passlabel As System.Windows.Forms.Label
    Friend WithEvents passtext As System.Windows.Forms.TextBox
    Friend WithEvents rootbutton As System.Windows.Forms.Button
    Friend WithEvents rootbox As System.Windows.Forms.TextBox
    Friend WithEvents rootlabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents rolebox As System.Windows.Forms.ComboBox
    Friend WithEvents rolelabel As System.Windows.Forms.Label

End Class
