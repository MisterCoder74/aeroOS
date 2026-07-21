<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sendserver
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.strStatus = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.cmdListen = New System.Windows.Forms.Button()
        Me.tmrControlConnection = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGetData = New System.Windows.Forms.Timer(Me.components)
        Me.bgReceiveFile = New System.ComponentModel.BackgroundWorker()
        Me.tmrControlFile = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.strStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'strStatus
        '
        Me.strStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.strStatus.Location = New System.Drawing.Point(0, 156)
        Me.strStatus.Name = "strStatus"
        Me.strStatus.Size = New System.Drawing.Size(425, 22)
        Me.strStatus.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(134, 17)
        Me.lblStatus.Text = "Waiting for connections"
        '
        'cmdListen
        '
        Me.cmdListen.BackColor = System.Drawing.Color.Transparent
        Me.cmdListen.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdListen.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdListen.Location = New System.Drawing.Point(241, 111)
        Me.cmdListen.Name = "cmdListen"
        Me.cmdListen.Size = New System.Drawing.Size(172, 22)
        Me.cmdListen.TabIndex = 1
        Me.cmdListen.Text = "Accept connections"
        Me.cmdListen.UseVisualStyleBackColor = False
        '
        'tmrControlConnection
        '
        '
        'tmrGetData
        '
        '
        'bgReceiveFile
        '
        Me.bgReceiveFile.WorkerReportsProgress = True
        '
        'tmrControlFile
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Reception progress:"
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(12, 43)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(401, 22)
        Me.prgProgress.TabIndex = 3
        '
        'sendserver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(425, 178)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdListen)
        Me.Controls.Add(Me.strStatus)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "sendserver"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Sender Server"
        Me.TopMost = True
        Me.strStatus.ResumeLayout(False)
        Me.strStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents strStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdListen As System.Windows.Forms.Button
    Friend WithEvents tmrControlConnection As System.Windows.Forms.Timer
    Friend WithEvents tmrGetData As System.Windows.Forms.Timer
    Friend WithEvents bgReceiveFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents tmrControlFile As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
End Class
