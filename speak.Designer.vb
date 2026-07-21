<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class speak
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
        Me.voicescombo = New System.Windows.Forms.ComboBox()
        Me.speakbox = New System.Windows.Forms.TextBox()
        Me.trvolume = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.recordbutton = New System.Windows.Forms.Button()
        CType(Me.trvolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'voicescombo
        '
        Me.voicescombo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.voicescombo.FormattingEnabled = True
        Me.voicescombo.Location = New System.Drawing.Point(334, 61)
        Me.voicescombo.Name = "voicescombo"
        Me.voicescombo.Size = New System.Drawing.Size(189, 21)
        Me.voicescombo.TabIndex = 2
        '
        'speakbox
        '
        Me.speakbox.Location = New System.Drawing.Point(12, 114)
        Me.speakbox.Multiline = True
        Me.speakbox.Name = "speakbox"
        Me.speakbox.Size = New System.Drawing.Size(511, 195)
        Me.speakbox.TabIndex = 3
        '
        'trvolume
        '
        Me.trvolume.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trvolume.BackColor = System.Drawing.Color.White
        Me.trvolume.Location = New System.Drawing.Point(290, 319)
        Me.trvolume.Name = "trvolume"
        Me.trvolume.Size = New System.Drawing.Size(172, 45)
        Me.trvolume.TabIndex = 4
        Me.trvolume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(137, 315)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 49)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Speak!"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Available voices:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 315)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 49)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Paste from Clipboard"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Volume"
        '
        'BackgroundWorker1
        '
        '
        'recordbutton
        '
        Me.recordbutton.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.recordbutton.BackColor = System.Drawing.Color.Transparent
        Me.recordbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.recordbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recordbutton.ForeColor = System.Drawing.Color.Black
        Me.recordbutton.Location = New System.Drawing.Point(334, 85)
        Me.recordbutton.Name = "recordbutton"
        Me.recordbutton.Size = New System.Drawing.Size(189, 23)
        Me.recordbutton.TabIndex = 26
        Me.recordbutton.Text = "Launch sound recorder"
        Me.recordbutton.UseVisualStyleBackColor = False
        '
        'speak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(535, 376)
        Me.Controls.Add(Me.recordbutton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.trvolume)
        Me.Controls.Add(Me.speakbox)
        Me.Controls.Add(Me.voicescombo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "speak"
        Me.ShowIcon = False
        Me.Text = "Aero Speak!"
        Me.TopMost = True
        CType(Me.trvolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents voicescombo As System.Windows.Forms.ComboBox
    Friend WithEvents speakbox As System.Windows.Forms.TextBox
    Friend WithEvents trvolume As System.Windows.Forms.TrackBar
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents recordbutton As System.Windows.Forms.Button

End Class
