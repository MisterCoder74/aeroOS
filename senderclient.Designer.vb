<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class senderclient
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
        Me.tmrGetData = New System.Windows.Forms.Timer(Me.components)
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.bgSendFile = New System.ComponentModel.BackgroundWorker()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.prgProgress = New System.Windows.Forms.ProgressBar()
        Me.cmdSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.strStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'strStatus
        '
        Me.strStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.strStatus.Location = New System.Drawing.Point(0, 233)
        Me.strStatus.Name = "strStatus"
        Me.strStatus.Size = New System.Drawing.Size(404, 22)
        Me.strStatus.TabIndex = 0
        Me.strStatus.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(57, 17)
        Me.lblStatus.Text = "Waiting..."
        '
        'tmrGetData
        '
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.Color.Transparent
        Me.cmdConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdConnect.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.Location = New System.Drawing.Point(23, 193)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(170, 31)
        Me.cmdConnect.TabIndex = 8
        Me.cmdConnect.Text = "Connect to server"
        Me.cmdConnect.UseVisualStyleBackColor = False
        '
        'bgSendFile
        '
        Me.bgSendFile.WorkerReportsProgress = True
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.Transparent
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Location = New System.Drawing.Point(298, 66)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(82, 26)
        Me.cmdBrowse.TabIndex = 5
        Me.cmdBrowse.Text = "Browse"
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Progress"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(21, 40)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(359, 20)
        Me.txtFile.TabIndex = 4
        '
        'prgProgress
        '
        Me.prgProgress.Location = New System.Drawing.Point(21, 137)
        Me.prgProgress.Name = "prgProgress"
        Me.prgProgress.Size = New System.Drawing.Size(359, 21)
        Me.prgProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgProgress.TabIndex = 7
        '
        'cmdSend
        '
        Me.cmdSend.BackColor = System.Drawing.Color.Transparent
        Me.cmdSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdSend.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSend.Location = New System.Drawing.Point(313, 193)
        Me.cmdSend.Name = "cmdSend"
        Me.cmdSend.Size = New System.Drawing.Size(67, 31)
        Me.cmdSend.TabIndex = 2
        Me.cmdSend.Text = "Send"
        Me.cmdSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File to send"
        '
        'senderclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(404, 255)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.cmdSend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cmdBrowse)
        Me.Controls.Add(Me.prgProgress)
        Me.Controls.Add(Me.strStatus)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "senderclient"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "File Sender Client"
        Me.TopMost = True
        Me.strStatus.ResumeLayout(False)
        Me.strStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents strStatus As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrGetData As System.Windows.Forms.Timer
    Friend WithEvents cmdConnect As System.Windows.Forms.Button
    Friend WithEvents bgSendFile As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents prgProgress As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdSend As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
