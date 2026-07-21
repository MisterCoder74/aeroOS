<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class poker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(poker))
        Me.IL1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Sound = New System.ComponentModel.BackgroundWorker()
        Me.sound1 = New System.ComponentModel.BackgroundWorker()
        Me.sound2 = New System.ComponentModel.BackgroundWorker()
        Me.sound3 = New System.ComponentModel.BackgroundWorker()
        Me.sound4 = New System.ComponentModel.BackgroundWorker()
        Me.PlayCards = New System.Windows.Forms.Button()
        Me.ScartaTutte = New System.Windows.Forms.Button()
        Me.Card5 = New System.Windows.Forms.PictureBox()
        Me.Uscita = New System.Windows.Forms.Button()
        Me.Test = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DecrPunt = New System.Windows.Forms.Button()
        Me.IncrPunt = New System.Windows.Forms.Button()
        Me.Puntata = New System.Windows.Forms.TextBox()
        Me.Card4 = New System.Windows.Forms.PictureBox()
        Me.Card3 = New System.Windows.Forms.PictureBox()
        Me.Card2 = New System.Windows.Forms.PictureBox()
        Me.Card1 = New System.Windows.Forms.PictureBox()
        Me.m5 = New System.Windows.Forms.CheckBox()
        Me.m4 = New System.Windows.Forms.CheckBox()
        Me.m3 = New System.Windows.Forms.CheckBox()
        Me.m2 = New System.Windows.Forms.CheckBox()
        Me.m1 = New System.Windows.Forms.CheckBox()
        Me.Bonus = New System.Windows.Forms.TextBox()
        Me.Vincita = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'IL1
        '
        Me.IL1.ImageStream = CType(resources.GetObject("IL1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IL1.TransparentColor = System.Drawing.Color.Transparent
        Me.IL1.Images.SetKeyName(0, "1PICCHE.png")
        Me.IL1.Images.SetKeyName(1, "2PICCHE.png")
        Me.IL1.Images.SetKeyName(2, "3picche.png")
        Me.IL1.Images.SetKeyName(3, "4picche.png")
        Me.IL1.Images.SetKeyName(4, "5PICCHE.png")
        Me.IL1.Images.SetKeyName(5, "6picche.png")
        Me.IL1.Images.SetKeyName(6, "7picche.png")
        Me.IL1.Images.SetKeyName(7, "8PICCHE.png")
        Me.IL1.Images.SetKeyName(8, "9PICCHE.png")
        Me.IL1.Images.SetKeyName(9, "dpicche.png")
        Me.IL1.Images.SetKeyName(10, "jpicche.png")
        Me.IL1.Images.SetKeyName(11, "qpicche.png")
        Me.IL1.Images.SetKeyName(12, "kpicche.png")
        Me.IL1.Images.SetKeyName(13, "1fiori.png")
        Me.IL1.Images.SetKeyName(14, "2fiori.png")
        Me.IL1.Images.SetKeyName(15, "3FIORI.png")
        Me.IL1.Images.SetKeyName(16, "4fiori.png")
        Me.IL1.Images.SetKeyName(17, "5FIORI.png")
        Me.IL1.Images.SetKeyName(18, "6fiori.png")
        Me.IL1.Images.SetKeyName(19, "7fiori.png")
        Me.IL1.Images.SetKeyName(20, "8fiori.png")
        Me.IL1.Images.SetKeyName(21, "9fiori.png")
        Me.IL1.Images.SetKeyName(22, "DFIORI.png")
        Me.IL1.Images.SetKeyName(23, "JFIORI.png")
        Me.IL1.Images.SetKeyName(24, "QFIORI.png")
        Me.IL1.Images.SetKeyName(25, "KFIORI.png")
        Me.IL1.Images.SetKeyName(26, "1quadri.png")
        Me.IL1.Images.SetKeyName(27, "2quadri.png")
        Me.IL1.Images.SetKeyName(28, "3quadri.png")
        Me.IL1.Images.SetKeyName(29, "4QUADRI.png")
        Me.IL1.Images.SetKeyName(30, "5QUADRI.png")
        Me.IL1.Images.SetKeyName(31, "6quadri.png")
        Me.IL1.Images.SetKeyName(32, "7QUADRI.png")
        Me.IL1.Images.SetKeyName(33, "8QUADRI.png")
        Me.IL1.Images.SetKeyName(34, "9QUADRI.png")
        Me.IL1.Images.SetKeyName(35, "DQUADRI.png")
        Me.IL1.Images.SetKeyName(36, "JQUADRI.png")
        Me.IL1.Images.SetKeyName(37, "QQUADRI.png")
        Me.IL1.Images.SetKeyName(38, "KQUADRI.png")
        Me.IL1.Images.SetKeyName(39, "1cuori.png")
        Me.IL1.Images.SetKeyName(40, "2CUORI.png")
        Me.IL1.Images.SetKeyName(41, "3cuori.png")
        Me.IL1.Images.SetKeyName(42, "4CUORI.png")
        Me.IL1.Images.SetKeyName(43, "5CUORI.png")
        Me.IL1.Images.SetKeyName(44, "6CUORI.png")
        Me.IL1.Images.SetKeyName(45, "7CUORI.png")
        Me.IL1.Images.SetKeyName(46, "8CUORI.png")
        Me.IL1.Images.SetKeyName(47, "9cuori.png")
        Me.IL1.Images.SetKeyName(48, "DCUORI.png")
        Me.IL1.Images.SetKeyName(49, "JCUORI.png")
        Me.IL1.Images.SetKeyName(50, "QCUORI.png")
        Me.IL1.Images.SetKeyName(51, "kcuori.png")
        Me.IL1.Images.SetKeyName(52, "retro2.png")
        '
        'Sound
        '
        '
        'sound1
        '
        '
        'sound2
        '
        '
        'sound3
        '
        '
        'sound4
        '
        '
        'PlayCards
        '
        Me.PlayCards.BackColor = System.Drawing.Color.Transparent
        Me.PlayCards.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.PlayCards.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PlayCards.Font = New System.Drawing.Font("Agate-Normal", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayCards.ForeColor = System.Drawing.Color.Black
        Me.PlayCards.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PlayCards.Location = New System.Drawing.Point(375, 268)
        Me.PlayCards.Name = "PlayCards"
        Me.PlayCards.Size = New System.Drawing.Size(186, 38)
        Me.PlayCards.TabIndex = 19
        Me.PlayCards.Text = "Play"
        Me.PlayCards.UseVisualStyleBackColor = False
        '
        'ScartaTutte
        '
        Me.ScartaTutte.BackColor = System.Drawing.Color.Transparent
        Me.ScartaTutte.Enabled = False
        Me.ScartaTutte.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.ScartaTutte.FlatAppearance.BorderSize = 3
        Me.ScartaTutte.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ScartaTutte.Font = New System.Drawing.Font("Agate-Normal", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScartaTutte.ForeColor = System.Drawing.Color.Black
        Me.ScartaTutte.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ScartaTutte.Location = New System.Drawing.Point(251, 268)
        Me.ScartaTutte.Name = "ScartaTutte"
        Me.ScartaTutte.Size = New System.Drawing.Size(112, 38)
        Me.ScartaTutte.TabIndex = 27
        Me.ScartaTutte.Text = "Drop all"
        Me.ScartaTutte.UseVisualStyleBackColor = False
        '
        'Card5
        '
        Me.Card5.BackColor = System.Drawing.Color.Transparent
        Me.Card5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Card5.Location = New System.Drawing.Point(607, 12)
        Me.Card5.Name = "Card5"
        Me.Card5.Size = New System.Drawing.Size(79, 104)
        Me.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card5.TabIndex = 38
        Me.Card5.TabStop = False
        '
        'Uscita
        '
        Me.Uscita.BackColor = System.Drawing.Color.Transparent
        Me.Uscita.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Uscita.FlatAppearance.BorderSize = 0
        Me.Uscita.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Uscita.Font = New System.Drawing.Font("Agate-Normal", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Uscita.ForeColor = System.Drawing.Color.Black
        Me.Uscita.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Uscita.Location = New System.Drawing.Point(574, 268)
        Me.Uscita.Name = "Uscita"
        Me.Uscita.Size = New System.Drawing.Size(112, 38)
        Me.Uscita.TabIndex = 23
        Me.Uscita.Text = "Quit"
        Me.Uscita.UseVisualStyleBackColor = False
        '
        'Test
        '
        Me.Test.BackColor = System.Drawing.Color.Blue
        Me.Test.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Test.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Test.ForeColor = System.Drawing.Color.Black
        Me.Test.Image = CType(resources.GetObject("Test.Image"), System.Drawing.Image)
        Me.Test.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Test.Location = New System.Drawing.Point(260, 39)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(51, 59)
        Me.Test.TabIndex = 25
        Me.Test.Text = "Test vincita"
        Me.Test.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Test.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.DecrPunt)
        Me.GroupBox2.Controls.Add(Me.IncrPunt)
        Me.GroupBox2.Controls.Add(Me.Puntata)
        Me.GroupBox2.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(375, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(186, 60)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Deal"
        '
        'DecrPunt
        '
        Me.DecrPunt.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.DecrPunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecrPunt.Image = CType(resources.GetObject("DecrPunt.Image"), System.Drawing.Image)
        Me.DecrPunt.Location = New System.Drawing.Point(148, 23)
        Me.DecrPunt.Name = "DecrPunt"
        Me.DecrPunt.Size = New System.Drawing.Size(33, 30)
        Me.DecrPunt.TabIndex = 19
        Me.DecrPunt.UseVisualStyleBackColor = True
        '
        'IncrPunt
        '
        Me.IncrPunt.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.IncrPunt.FlatAppearance.BorderSize = 0
        Me.IncrPunt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncrPunt.ForeColor = System.Drawing.Color.White
        Me.IncrPunt.Image = CType(resources.GetObject("IncrPunt.Image"), System.Drawing.Image)
        Me.IncrPunt.Location = New System.Drawing.Point(6, 23)
        Me.IncrPunt.Name = "IncrPunt"
        Me.IncrPunt.Size = New System.Drawing.Size(33, 30)
        Me.IncrPunt.TabIndex = 18
        Me.IncrPunt.UseVisualStyleBackColor = True
        '
        'Puntata
        '
        Me.Puntata.BackColor = System.Drawing.SystemColors.InfoText
        Me.Puntata.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Puntata.ForeColor = System.Drawing.Color.Lime
        Me.Puntata.Location = New System.Drawing.Point(47, 27)
        Me.Puntata.Name = "Puntata"
        Me.Puntata.Size = New System.Drawing.Size(93, 22)
        Me.Puntata.TabIndex = 6
        Me.Puntata.Text = "1"
        Me.Puntata.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Card4
        '
        Me.Card4.BackColor = System.Drawing.Color.Transparent
        Me.Card4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Card4.Location = New System.Drawing.Point(518, 12)
        Me.Card4.Name = "Card4"
        Me.Card4.Size = New System.Drawing.Size(79, 104)
        Me.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card4.TabIndex = 37
        Me.Card4.TabStop = False
        '
        'Card3
        '
        Me.Card3.BackColor = System.Drawing.Color.Transparent
        Me.Card3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Card3.Location = New System.Drawing.Point(429, 12)
        Me.Card3.Name = "Card3"
        Me.Card3.Size = New System.Drawing.Size(79, 104)
        Me.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card3.TabIndex = 36
        Me.Card3.TabStop = False
        '
        'Card2
        '
        Me.Card2.BackColor = System.Drawing.Color.Transparent
        Me.Card2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Card2.Location = New System.Drawing.Point(340, 12)
        Me.Card2.Name = "Card2"
        Me.Card2.Size = New System.Drawing.Size(79, 104)
        Me.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card2.TabIndex = 35
        Me.Card2.TabStop = False
        Me.Card2.Tag = ""
        '
        'Card1
        '
        Me.Card1.BackColor = System.Drawing.Color.Transparent
        Me.Card1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Card1.Location = New System.Drawing.Point(251, 12)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(79, 104)
        Me.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Card1.TabIndex = 34
        Me.Card1.TabStop = False
        Me.Card1.Tag = ""
        '
        'm5
        '
        Me.m5.AutoSize = True
        Me.m5.BackColor = System.Drawing.Color.Transparent
        Me.m5.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.m5.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m5.ForeColor = System.Drawing.Color.Black
        Me.m5.Location = New System.Drawing.Point(614, 124)
        Me.m5.Name = "m5"
        Me.m5.Size = New System.Drawing.Size(53, 33)
        Me.m5.TabIndex = 33
        Me.m5.Text = "Drop"
        Me.m5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m5.UseVisualStyleBackColor = False
        '
        'm4
        '
        Me.m4.AutoSize = True
        Me.m4.BackColor = System.Drawing.Color.Transparent
        Me.m4.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.m4.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m4.ForeColor = System.Drawing.Color.Black
        Me.m4.Location = New System.Drawing.Point(526, 124)
        Me.m4.Name = "m4"
        Me.m4.Size = New System.Drawing.Size(53, 33)
        Me.m4.TabIndex = 32
        Me.m4.Text = "Drop"
        Me.m4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m4.UseVisualStyleBackColor = False
        '
        'm3
        '
        Me.m3.AutoSize = True
        Me.m3.BackColor = System.Drawing.Color.Transparent
        Me.m3.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.m3.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m3.ForeColor = System.Drawing.Color.Black
        Me.m3.Location = New System.Drawing.Point(437, 124)
        Me.m3.Name = "m3"
        Me.m3.Size = New System.Drawing.Size(53, 33)
        Me.m3.TabIndex = 31
        Me.m3.Text = "Drop"
        Me.m3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m3.UseVisualStyleBackColor = False
        '
        'm2
        '
        Me.m2.AutoSize = True
        Me.m2.BackColor = System.Drawing.Color.Transparent
        Me.m2.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.m2.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m2.ForeColor = System.Drawing.Color.Black
        Me.m2.Location = New System.Drawing.Point(348, 124)
        Me.m2.Name = "m2"
        Me.m2.Size = New System.Drawing.Size(53, 33)
        Me.m2.TabIndex = 30
        Me.m2.Text = "Drop"
        Me.m2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m2.UseVisualStyleBackColor = False
        '
        'm1
        '
        Me.m1.AutoSize = True
        Me.m1.BackColor = System.Drawing.Color.Transparent
        Me.m1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.m1.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m1.ForeColor = System.Drawing.Color.Black
        Me.m1.Location = New System.Drawing.Point(260, 124)
        Me.m1.Name = "m1"
        Me.m1.Size = New System.Drawing.Size(53, 33)
        Me.m1.TabIndex = 29
        Me.m1.Text = "Drop"
        Me.m1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.m1.UseVisualStyleBackColor = False
        '
        'Bonus
        '
        Me.Bonus.BackColor = System.Drawing.SystemColors.InfoText
        Me.Bonus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bonus.ForeColor = System.Drawing.Color.Lime
        Me.Bonus.Location = New System.Drawing.Point(6, 27)
        Me.Bonus.Name = "Bonus"
        Me.Bonus.ReadOnly = True
        Me.Bonus.Size = New System.Drawing.Size(100, 22)
        Me.Bonus.TabIndex = 28
        Me.Bonus.Text = "101"
        Me.Bonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vincita
        '
        Me.Vincita.BackColor = System.Drawing.SystemColors.InfoText
        Me.Vincita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vincita.ForeColor = System.Drawing.Color.Lime
        Me.Vincita.Location = New System.Drawing.Point(6, 27)
        Me.Vincita.Name = "Vincita"
        Me.Vincita.ReadOnly = True
        Me.Vincita.Size = New System.Drawing.Size(100, 22)
        Me.Vincita.TabIndex = 26
        Me.Vincita.Text = "0"
        Me.Vincita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbl8)
        Me.GroupBox1.Controls.Add(Me.lbl7)
        Me.GroupBox1.Controls.Add(Me.lbl6)
        Me.GroupBox1.Controls.Add(Me.lbl9)
        Me.GroupBox1.Controls.Add(Me.lbl5)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Agate-Normal", 15.25!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 298)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Win quotas"
        '
        'lbl8
        '
        Me.lbl8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl8.Location = New System.Drawing.Point(171, 230)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(36, 18)
        Me.lbl8.TabIndex = 38
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl7
        '
        Me.lbl7.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl7.Location = New System.Drawing.Point(171, 204)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(36, 18)
        Me.lbl7.TabIndex = 30
        Me.lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl6
        '
        Me.lbl6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl6.Location = New System.Drawing.Point(171, 178)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(36, 18)
        Me.lbl6.TabIndex = 22
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl9
        '
        Me.lbl9.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl9.Location = New System.Drawing.Point(171, 256)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(36, 18)
        Me.lbl9.TabIndex = 15
        Me.lbl9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl5
        '
        Me.lbl5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl5.Location = New System.Drawing.Point(171, 152)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(36, 18)
        Me.lbl5.TabIndex = 14
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl4
        '
        Me.lbl4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl4.Location = New System.Drawing.Point(171, 126)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(36, 18)
        Me.lbl4.TabIndex = 12
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl3
        '
        Me.lbl3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl3.Location = New System.Drawing.Point(171, 100)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(36, 18)
        Me.lbl3.TabIndex = 11
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl2
        '
        Me.lbl2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl2.Location = New System.Drawing.Point(171, 74)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(36, 18)
        Me.lbl2.TabIndex = 10
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl1
        '
        Me.lbl1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl1.Location = New System.Drawing.Point(171, 44)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(36, 18)
        Me.lbl1.TabIndex = 9
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 256)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "A Pair"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 230)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Two Pairs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 204)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "3 of a kind"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Full House"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Straight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Flush"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "4 of a kind"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Straight flush"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Royal flush"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Vincita)
        Me.GroupBox3.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(251, 185)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(112, 60)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Win"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Bonus)
        Me.GroupBox4.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(574, 185)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 60)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bonus"
        '
        'poker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 317)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PlayCards)
        Me.Controls.Add(Me.ScartaTutte)
        Me.Controls.Add(Me.Card5)
        Me.Controls.Add(Me.Uscita)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Card4)
        Me.Controls.Add(Me.Card3)
        Me.Controls.Add(Me.m5)
        Me.Controls.Add(Me.m4)
        Me.Controls.Add(Me.m3)
        Me.Controls.Add(Me.m2)
        Me.Controls.Add(Me.m1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Card2)
        Me.Controls.Add(Me.Card1)
        Me.Controls.Add(Me.Test)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "poker"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Video Poker"
        Me.TopMost = True
        CType(Me.Card5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Card4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Card1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IL1 As System.Windows.Forms.ImageList
    Friend WithEvents Sound As System.ComponentModel.BackgroundWorker
    Friend WithEvents sound1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents sound2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents sound3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents sound4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PlayCards As System.Windows.Forms.Button
    Friend WithEvents ScartaTutte As System.Windows.Forms.Button
    Friend WithEvents Card5 As System.Windows.Forms.PictureBox
    Friend WithEvents Uscita As System.Windows.Forms.Button
    Friend WithEvents Test As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DecrPunt As System.Windows.Forms.Button
    Friend WithEvents IncrPunt As System.Windows.Forms.Button
    Friend WithEvents Puntata As System.Windows.Forms.TextBox
    Friend WithEvents Card4 As System.Windows.Forms.PictureBox
    Friend WithEvents Card3 As System.Windows.Forms.PictureBox
    Friend WithEvents Card2 As System.Windows.Forms.PictureBox
    Friend WithEvents Card1 As System.Windows.Forms.PictureBox
    Friend WithEvents m5 As System.Windows.Forms.CheckBox
    Friend WithEvents m4 As System.Windows.Forms.CheckBox
    Friend WithEvents m3 As System.Windows.Forms.CheckBox
    Friend WithEvents m2 As System.Windows.Forms.CheckBox
    Friend WithEvents m1 As System.Windows.Forms.CheckBox
    Friend WithEvents Bonus As System.Windows.Forms.TextBox
    Friend WithEvents Vincita As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents lbl7 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl9 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
