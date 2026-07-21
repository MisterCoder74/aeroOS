<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
    Inherits System.Windows.Forms.Form

    'Form replaces the method Disposes to clean the list of the components.  
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Creative Windows Form.
    Private components As System.ComponentModel.IContainer

    'NOTICE: The following procedure is required by the Creative Windows Form.
    'It can be modified using the Creative Windows Form.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.grpbLocal = New System.Windows.Forms.GroupBox
        Me.rdbEasy = New System.Windows.Forms.RadioButton
        Me.rdbHard = New System.Windows.Forms.RadioButton
        Me.grpbRemote = New System.Windows.Forms.GroupBox
        Me.txtIp = New System.Windows.Forms.TextBox
        Me.rdbCon = New System.Windows.Forms.RadioButton
        Me.rdbHost = New System.Windows.Forms.RadioButton
        Me.rdbLocal = New System.Windows.Forms.RadioButton
        Me.rdbRemote = New System.Windows.Forms.RadioButton
        Me.grpbLocal.SuspendLayout()
        Me.grpbRemote.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(129, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpbLocal
        '
        Me.grpbLocal.Controls.Add(Me.rdbEasy)
        Me.grpbLocal.Controls.Add(Me.rdbHard)
        Me.grpbLocal.Location = New System.Drawing.Point(12, 43)
        Me.grpbLocal.Name = "grpbLocal"
        Me.grpbLocal.Size = New System.Drawing.Size(140, 170)
        Me.grpbLocal.TabIndex = 1
        Me.grpbLocal.TabStop = False
        '
        'rdbEasy
        '
        Me.rdbEasy.AutoSize = True
        Me.rdbEasy.Checked = True
        Me.rdbEasy.Location = New System.Drawing.Point(12, 46)
        Me.rdbEasy.Name = "rdbEasy"
        Me.rdbEasy.Size = New System.Drawing.Size(53, 17)
        Me.rdbEasy.TabIndex = 1
        Me.rdbEasy.TabStop = True
        Me.rdbEasy.Text = "Easy"
        Me.rdbEasy.UseVisualStyleBackColor = True
        '
        'rdbHard
        '
        Me.rdbHard.AutoSize = True
        Me.rdbHard.Location = New System.Drawing.Point(12, 115)
        Me.rdbHard.Name = "rdbHard"
        Me.rdbHard.Size = New System.Drawing.Size(59, 17)
        Me.rdbHard.TabIndex = 4
        Me.rdbHard.Text = "Hard"
        Me.rdbHard.UseVisualStyleBackColor = True
        '
        'grpbRemote
        '
        Me.grpbRemote.Controls.Add(Me.txtIp)
        Me.grpbRemote.Controls.Add(Me.rdbCon)
        Me.grpbRemote.Controls.Add(Me.rdbHost)
        Me.grpbRemote.Location = New System.Drawing.Point(182, 43)
        Me.grpbRemote.Name = "grpbRemote"
        Me.grpbRemote.Size = New System.Drawing.Size(138, 170)
        Me.grpbRemote.TabIndex = 3
        Me.grpbRemote.TabStop = False
        '
        'txtIp
        '
        Me.txtIp.Location = New System.Drawing.Point(6, 138)
        Me.txtIp.Name = "txtIp"
        Me.txtIp.Size = New System.Drawing.Size(100, 20)
        Me.txtIp.TabIndex = 9
        '
        'rdbCon
        '
        Me.rdbCon.AutoSize = True
        Me.rdbCon.Location = New System.Drawing.Point(6, 115)
        Me.rdbCon.Name = "rdbCon"
        Me.rdbCon.Size = New System.Drawing.Size(89, 17)
        Me.rdbCon.TabIndex = 4
        Me.rdbCon.TabStop = True
        Me.rdbCon.Text = "Connect"
        Me.rdbCon.UseVisualStyleBackColor = True
        '
        'rdbHost
        '
        Me.rdbHost.AutoSize = True
        Me.rdbHost.Checked = True
        Me.rdbHost.Location = New System.Drawing.Point(6, 30)
        Me.rdbHost.Name = "rdbHost"
        Me.rdbHost.Size = New System.Drawing.Size(109, 17)
        Me.rdbHost.TabIndex = 6
        Me.rdbHost.TabStop = True
        Me.rdbHost.Text = "Start the game"
        Me.rdbHost.UseVisualStyleBackColor = True
        '
        'rdbLocal
        '
        Me.rdbLocal.AutoSize = True
        Me.rdbLocal.Checked = True
        Me.rdbLocal.Location = New System.Drawing.Point(24, 20)
        Me.rdbLocal.Name = "rdbLocal"
        Me.rdbLocal.Size = New System.Drawing.Size(83, 17)
        Me.rdbLocal.TabIndex = 5
        Me.rdbLocal.TabStop = True
        Me.rdbLocal.Text = "Local game"
        Me.rdbLocal.UseVisualStyleBackColor = True
        '
        'rdbRemote
        '
        Me.rdbRemote.AutoSize = True
        Me.rdbRemote.Location = New System.Drawing.Point(182, 20)
        Me.rdbRemote.Name = "rdbRemote"
        Me.rdbRemote.Size = New System.Drawing.Size(83, 17)
        Me.rdbRemote.TabIndex = 6
        Me.rdbRemote.Text = "Online game"
        Me.rdbRemote.UseVisualStyleBackColor = True
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 271)
        Me.Controls.Add(Me.rdbRemote)
        Me.Controls.Add(Me.rdbLocal)
        Me.Controls.Add(Me.grpbRemote)
        Me.Controls.Add(Me.grpbLocal)
        Me.Controls.Add(Me.Button1)
        Me.Name = "frmSetting"
        Me.Text = "Game Configuration"
        Me.grpbLocal.ResumeLayout(False)
        Me.grpbLocal.PerformLayout()
        Me.grpbRemote.ResumeLayout(False)
        Me.grpbRemote.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpbLocal As System.Windows.Forms.GroupBox
    Friend WithEvents grpbRemote As System.Windows.Forms.GroupBox
    Friend WithEvents rdbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rdbRemote As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEasy As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHard As System.Windows.Forms.RadioButton
    Friend WithEvents txtIp As System.Windows.Forms.TextBox
    Friend WithEvents rdbCon As System.Windows.Forms.RadioButton
    Friend WithEvents rdbHost As System.Windows.Forms.RadioButton
End Class
