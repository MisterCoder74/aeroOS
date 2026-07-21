<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bigshow
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
        Me.PictureBoxMain = New System.Windows.Forms.PictureBox()
        Me.clipbutton = New System.Windows.Forms.Button()
        Me.pastbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.aquirebutton = New System.Windows.Forms.Button()
        CType(Me.PictureBoxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxMain
        '
        Me.PictureBoxMain.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMain.Location = New System.Drawing.Point(13, 31)
        Me.PictureBoxMain.Name = "PictureBoxMain"
        Me.PictureBoxMain.Size = New System.Drawing.Size(775, 589)
        Me.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMain.TabIndex = 0
        Me.PictureBoxMain.TabStop = False
        '
        'clipbutton
        '
        Me.clipbutton.BackColor = System.Drawing.Color.Transparent
        Me.clipbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clipbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clipbutton.Location = New System.Drawing.Point(13, 3)
        Me.clipbutton.Name = "clipbutton"
        Me.clipbutton.Size = New System.Drawing.Size(152, 23)
        Me.clipbutton.TabIndex = 1
        Me.clipbutton.Text = "Copy to Clipboard"
        Me.clipbutton.UseVisualStyleBackColor = False
        '
        'pastbutton
        '
        Me.pastbutton.BackColor = System.Drawing.Color.Transparent
        Me.pastbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.pastbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pastbutton.Location = New System.Drawing.Point(214, 3)
        Me.pastbutton.Name = "pastbutton"
        Me.pastbutton.Size = New System.Drawing.Size(162, 23)
        Me.pastbutton.TabIndex = 6
        Me.pastbutton.Text = "Paste from Clipboard"
        Me.pastbutton.UseVisualStyleBackColor = False
        '
        'savebutton
        '
        Me.savebutton.BackColor = System.Drawing.Color.Transparent
        Me.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.savebutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.savebutton.Location = New System.Drawing.Point(636, 3)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(152, 23)
        Me.savebutton.TabIndex = 9
        Me.savebutton.Text = "Save to Disk"
        Me.savebutton.UseVisualStyleBackColor = False
        '
        'aquirebutton
        '
        Me.aquirebutton.BackColor = System.Drawing.Color.Transparent
        Me.aquirebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.aquirebutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aquirebutton.Location = New System.Drawing.Point(425, 3)
        Me.aquirebutton.Name = "aquirebutton"
        Me.aquirebutton.Size = New System.Drawing.Size(162, 23)
        Me.aquirebutton.TabIndex = 10
        Me.aquirebutton.Text = "Aquire from Scanner"
        Me.aquirebutton.UseVisualStyleBackColor = False
        '
        'bigshow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 650)
        Me.Controls.Add(Me.aquirebutton)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.pastbutton)
        Me.Controls.Add(Me.clipbutton)
        Me.Controls.Add(Me.PictureBoxMain)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "bigshow"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wide view"
        Me.TopMost = True
        CType(Me.PictureBoxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBoxMain As System.Windows.Forms.PictureBox
    Friend WithEvents clipbutton As System.Windows.Forms.Button
    Friend WithEvents pastbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents aquirebutton As System.Windows.Forms.Button
End Class
