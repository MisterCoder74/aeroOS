Partial Class CrawlingView
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.lblImages = New System.Windows.Forms.Label()
        Me.lblDomains = New System.Windows.Forms.Label()
        Me.lblImagesQueue = New System.Windows.Forms.Label()
        Me.lblDomainQueue = New System.Windows.Forms.Label()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.lblPRocessing = New System.Windows.Forms.Label()
        Me.crawltimer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(63, 57)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(63, 11)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Domains:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(63, 81)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(45, 11)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Media:"
        '
        'lblImages
        '
        Me.lblImages.AutoSize = True
        Me.lblImages.BackColor = System.Drawing.Color.Transparent
        Me.lblImages.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImages.Location = New System.Drawing.Point(130, 81)
        Me.lblImages.Name = "lblImages"
        Me.lblImages.Size = New System.Drawing.Size(14, 11)
        Me.lblImages.TabIndex = 3
        Me.lblImages.Text = "0"
        '
        'lblDomains
        '
        Me.lblDomains.AutoSize = True
        Me.lblDomains.BackColor = System.Drawing.Color.Transparent
        Me.lblDomains.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomains.Location = New System.Drawing.Point(130, 57)
        Me.lblDomains.Name = "lblDomains"
        Me.lblDomains.Size = New System.Drawing.Size(14, 11)
        Me.lblDomains.TabIndex = 2
        Me.lblDomains.Text = "0"
        '
        'lblImagesQueue
        '
        Me.lblImagesQueue.AutoSize = True
        Me.lblImagesQueue.BackColor = System.Drawing.Color.Transparent
        Me.lblImagesQueue.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImagesQueue.Location = New System.Drawing.Point(289, 81)
        Me.lblImagesQueue.Name = "lblImagesQueue"
        Me.lblImagesQueue.Size = New System.Drawing.Size(14, 11)
        Me.lblImagesQueue.TabIndex = 7
        Me.lblImagesQueue.Text = "0"
        '
        'lblDomainQueue
        '
        Me.lblDomainQueue.AutoSize = True
        Me.lblDomainQueue.BackColor = System.Drawing.Color.Transparent
        Me.lblDomainQueue.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomainQueue.Location = New System.Drawing.Point(289, 57)
        Me.lblDomainQueue.Name = "lblDomainQueue"
        Me.lblDomainQueue.Size = New System.Drawing.Size(14, 11)
        Me.lblDomainQueue.TabIndex = 6
        Me.lblDomainQueue.Text = "0"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Transparent
        Me.label5.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(239, 81)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(49, 11)
        Me.label5.TabIndex = 5
        Me.label5.Text = "Queue:"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(239, 57)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(49, 11)
        Me.label6.TabIndex = 4
        Me.label6.Text = "Queue:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(63, 107)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(78, 11)
        Me.label3.TabIndex = 9
        Me.label3.Text = "Processing:"
        '
        'lblPRocessing
        '
        Me.lblPRocessing.AutoEllipsis = True
        Me.lblPRocessing.BackColor = System.Drawing.Color.Transparent
        Me.lblPRocessing.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPRocessing.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPRocessing.Location = New System.Drawing.Point(173, 107)
        Me.lblPRocessing.Name = "lblPRocessing"
        Me.lblPRocessing.Size = New System.Drawing.Size(172, 13)
        Me.lblPRocessing.TabIndex = 10
        '
        'crawltimer
        '
        Me.crawltimer.Interval = 150
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(432, 134)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Abort Crawling"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(100, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 26)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Scanning for media files " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(jpg, png, gif, mp3, wav, wma, avi, mpg, mp4, wmv, flv" & _
    ")"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrawlingView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(582, 180)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPRocessing)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.lblImagesQueue)
        Me.Controls.Add(Me.lblDomainQueue)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.lblImages)
        Me.Controls.Add(Me.lblDomains)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CrawlingView"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crawling media files..."
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private lblImages As System.Windows.Forms.Label
    Private lblDomains As System.Windows.Forms.Label
    Private lblImagesQueue As System.Windows.Forms.Label
    Private lblDomainQueue As System.Windows.Forms.Label
    Private label5 As System.Windows.Forms.Label
    Private label6 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private lblPRocessing As System.Windows.Forms.Label
    Friend WithEvents crawltimer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
