<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SPACEINVADERS
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemyTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.scoreTimer = New System.Windows.Forms.Timer(Me.components)
        Me.bustedlabel = New System.Windows.Forms.Label()
        Me.pauselabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'enemyTimer
        '
        Me.enemyTimer.Interval = 200
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.scoreLabel.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.ForeColor = System.Drawing.Color.Yellow
        Me.scoreLabel.Location = New System.Drawing.Point(33, 9)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(116, 15)
        Me.scoreLabel.TabIndex = 0
        Me.scoreLabel.Text = "Total Score: "
        '
        'scoreTimer
        '
        Me.scoreTimer.Interval = 1000
        '
        'bustedlabel
        '
        Me.bustedlabel.AutoSize = True
        Me.bustedlabel.BackColor = System.Drawing.Color.Transparent
        Me.bustedlabel.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bustedlabel.ForeColor = System.Drawing.Color.Yellow
        Me.bustedlabel.Location = New System.Drawing.Point(451, 9)
        Me.bustedlabel.Name = "bustedlabel"
        Me.bustedlabel.Size = New System.Drawing.Size(124, 15)
        Me.bustedlabel.TabIndex = 1
        Me.bustedlabel.Text = "Busted aliens:"
        '
        'pauselabel
        '
        Me.pauselabel.AutoSize = True
        Me.pauselabel.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pauselabel.ForeColor = System.Drawing.Color.Gold
        Me.pauselabel.Location = New System.Drawing.Point(250, 210)
        Me.pauselabel.Name = "pauselabel"
        Me.pauselabel.Size = New System.Drawing.Size(158, 11)
        Me.pauselabel.TabIndex = 2
        Me.pauselabel.Text = "GAME PAUSED (PRESS P)"
        Me.pauselabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(271, 597)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 11)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Press P to pause game"
        '
        'SPACEINVADERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.farbackbig
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(665, 612)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pauselabel)
        Me.Controls.Add(Me.bustedlabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SPACEINVADERS"
        Me.ShowIcon = False
        Me.Text = "Space Invaders"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents enemyTimer As System.Windows.Forms.Timer
    Friend WithEvents scoreLabel As System.Windows.Forms.Label
    Friend WithEvents scoreTimer As System.Windows.Forms.Timer
    Friend WithEvents bustedlabel As System.Windows.Forms.Label
    Friend WithEvents pauselabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
