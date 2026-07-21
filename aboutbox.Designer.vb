<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aboutbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aboutbox))
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.aboutlabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.OK_Button.BackColor = System.Drawing.Color.Transparent
        Me.OK_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OK_Button.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.ForeColor = System.Drawing.Color.Black
        Me.OK_Button.Location = New System.Drawing.Point(160, 374)
        Me.OK_Button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(159, 26)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "Aero Homepage"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'aboutlabel
        '
        Me.aboutlabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.aboutlabel.AutoSize = True
        Me.aboutlabel.BackColor = System.Drawing.Color.Transparent
        Me.aboutlabel.Font = New System.Drawing.Font("Agate-Normal", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutlabel.ForeColor = System.Drawing.Color.Black
        Me.aboutlabel.Location = New System.Drawing.Point(33, 42)
        Me.aboutlabel.Name = "aboutlabel"
        Me.aboutlabel.Size = New System.Drawing.Size(146, 25)
        Me.aboutlabel.TabIndex = 22
        Me.aboutlabel.Text = "Aero 2020"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(302, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "2013-2020 - A.Demontis "
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(278, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Release Aero 7.0:  January 2020"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.TextBox1.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(38, 70)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(388, 299)
        Me.TextBox1.TabIndex = 31
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        '
        'aboutbox
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 10.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(457, 430)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.aboutlabel)
        Me.Controls.Add(Me.OK_Button)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Agate-Normal", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "aboutbox"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Aero 2018"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents aboutlabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
