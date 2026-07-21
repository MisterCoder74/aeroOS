<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoundRecorder
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
        Me.pnlSRecord = New System.Windows.Forms.Panel()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.prgrecording = New System.Windows.Forms.ProgressBar()
        Me.lblDuartion = New System.Windows.Forms.Label()
        Me.tmrDuration = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUnplay = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlSRecord.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSRecord
        '
        Me.pnlSRecord.BackColor = System.Drawing.Color.Transparent
        Me.pnlSRecord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSRecord.Controls.Add(Me.btnStop)
        Me.pnlSRecord.Controls.Add(Me.btnStart)
        Me.pnlSRecord.Location = New System.Drawing.Point(12, 12)
        Me.pnlSRecord.Name = "pnlSRecord"
        Me.pnlSRecord.Size = New System.Drawing.Size(329, 43)
        Me.pnlSRecord.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.Color.Transparent
        Me.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStop.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStop.Location = New System.Drawing.Point(162, 7)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(151, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop Recording"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStart.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(11, 7)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(130, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start Recording"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.Transparent
        Me.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPlay.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(185, 105)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'prgrecording
        '
        Me.prgrecording.Location = New System.Drawing.Point(12, 61)
        Me.prgrecording.Name = "prgrecording"
        Me.prgrecording.Size = New System.Drawing.Size(329, 13)
        Me.prgrecording.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.prgrecording.TabIndex = 1
        '
        'lblDuartion
        '
        Me.lblDuartion.AutoSize = True
        Me.lblDuartion.BackColor = System.Drawing.Color.Transparent
        Me.lblDuartion.Font = New System.Drawing.Font("Agate-Normal", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuartion.Location = New System.Drawing.Point(92, 90)
        Me.lblDuartion.Name = "lblDuartion"
        Me.lblDuartion.Size = New System.Drawing.Size(57, 10)
        Me.lblDuartion.TabIndex = 2
        Me.lblDuartion.Text = "00:00:00"
        '
        'tmrDuration
        '
        Me.tmrDuration.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 10)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DURATION:"
        '
        'btnUnplay
        '
        Me.btnUnplay.BackColor = System.Drawing.Color.Transparent
        Me.btnUnplay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUnplay.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnplay.Location = New System.Drawing.Point(266, 105)
        Me.btnUnplay.Name = "btnUnplay"
        Me.btnUnplay.Size = New System.Drawing.Size(75, 23)
        Me.btnUnplay.TabIndex = 4
        Me.btnUnplay.Text = "Stop"
        Me.btnUnplay.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(326, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 10)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File address:"
        '
        'frmSoundRecorder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(357, 166)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnUnplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblDuartion)
        Me.Controls.Add(Me.prgrecording)
        Me.Controls.Add(Me.pnlSRecord)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSoundRecorder"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sound Recorder"
        Me.TopMost = True
        Me.pnlSRecord.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlSRecord As System.Windows.Forms.Panel
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents prgrecording As System.Windows.Forms.ProgressBar
    Friend WithEvents lblDuartion As System.Windows.Forms.Label
    Friend WithEvents tmrDuration As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUnplay As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
