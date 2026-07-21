<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newroot
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
        Me.rootbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.rootbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rootlabelok = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rootbutton
        '
        Me.rootbutton.BackColor = System.Drawing.Color.Transparent
        Me.rootbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.rootbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootbutton.Location = New System.Drawing.Point(294, 37)
        Me.rootbutton.Name = "rootbutton"
        Me.rootbutton.Size = New System.Drawing.Size(118, 23)
        Me.rootbutton.TabIndex = 0
        Me.rootbutton.Text = "Reset root"
        Me.rootbutton.UseVisualStyleBackColor = False
        '
        'savebutton
        '
        Me.savebutton.BackColor = System.Drawing.Color.Transparent
        Me.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.savebutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebutton.Location = New System.Drawing.Point(294, 110)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(118, 23)
        Me.savebutton.TabIndex = 1
        Me.savebutton.Text = "Save settings"
        Me.savebutton.UseVisualStyleBackColor = False
        '
        'rootbox
        '
        Me.rootbox.Location = New System.Drawing.Point(13, 37)
        Me.rootbox.Name = "rootbox"
        Me.rootbox.Size = New System.Drawing.Size(261, 20)
        Me.rootbox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AERO root directory"
        '
        'rootlabelok
        '
        Me.rootlabelok.AutoSize = True
        Me.rootlabelok.BackColor = System.Drawing.Color.Transparent
        Me.rootlabelok.Font = New System.Drawing.Font("Agate-Normal", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rootlabelok.Location = New System.Drawing.Point(13, 110)
        Me.rootlabelok.Name = "rootlabelok"
        Me.rootlabelok.Size = New System.Drawing.Size(58, 15)
        Me.rootlabelok.TabIndex = 4
        Me.rootlabelok.Text = "Status"
        Me.rootlabelok.Visible = False
        '
        'newroot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(424, 149)
        Me.Controls.Add(Me.rootlabelok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rootbox)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.rootbutton)
        Me.DoubleBuffered = True
        Me.Name = "newroot"
        Me.ShowIcon = False
        Me.Text = "Create new installation"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rootbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents rootbox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rootlabelok As System.Windows.Forms.Label
End Class
