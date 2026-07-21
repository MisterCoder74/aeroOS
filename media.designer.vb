<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class media
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(media))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AxVLCPlugin21 = New AxAXVLC.AxVLCPlugin2()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.openvbutt = New System.Windows.Forms.Button()
        Me.playvbutton = New System.Windows.Forms.Button()
        Me.stopvbutton = New System.Windows.Forms.Button()
        Me.pausevbutton = New System.Windows.Forms.Button()
        Me.loopvbutton = New System.Windows.Forms.Button()
        Me.toolbalvbutt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AxVLCPlugin21
        '
        Me.AxVLCPlugin21.AllowDrop = True
        Me.AxVLCPlugin21.Enabled = True
        Me.AxVLCPlugin21.Location = New System.Drawing.Point(12, 12)
        Me.AxVLCPlugin21.Name = "AxVLCPlugin21"
        Me.AxVLCPlugin21.OcxState = CType(resources.GetObject("AxVLCPlugin21.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPlugin21.Size = New System.Drawing.Size(748, 447)
        Me.AxVLCPlugin21.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 21
        Me.ListBox1.Location = New System.Drawing.Point(435, 487)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(325, 88)
        Me.ListBox1.TabIndex = 1
        '
        'openvbutt
        '
        Me.openvbutt.BackColor = System.Drawing.Color.Transparent
        Me.openvbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.openvbutt.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openvbutt.Location = New System.Drawing.Point(13, 492)
        Me.openvbutt.Name = "openvbutt"
        Me.openvbutt.Size = New System.Drawing.Size(75, 23)
        Me.openvbutt.TabIndex = 2
        Me.openvbutt.Text = "Open"
        Me.openvbutt.UseVisualStyleBackColor = False
        '
        'playvbutton
        '
        Me.playvbutton.BackColor = System.Drawing.Color.Transparent
        Me.playvbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.playvbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playvbutton.Location = New System.Drawing.Point(94, 492)
        Me.playvbutton.Name = "playvbutton"
        Me.playvbutton.Size = New System.Drawing.Size(75, 23)
        Me.playvbutton.TabIndex = 3
        Me.playvbutton.Text = "Play"
        Me.playvbutton.UseVisualStyleBackColor = False
        '
        'stopvbutton
        '
        Me.stopvbutton.BackColor = System.Drawing.Color.Transparent
        Me.stopvbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stopvbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stopvbutton.Location = New System.Drawing.Point(175, 492)
        Me.stopvbutton.Name = "stopvbutton"
        Me.stopvbutton.Size = New System.Drawing.Size(75, 23)
        Me.stopvbutton.TabIndex = 4
        Me.stopvbutton.Text = "Stop"
        Me.stopvbutton.UseVisualStyleBackColor = False
        '
        'pausevbutton
        '
        Me.pausevbutton.BackColor = System.Drawing.Color.Transparent
        Me.pausevbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pausevbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pausevbutton.Location = New System.Drawing.Point(256, 492)
        Me.pausevbutton.Name = "pausevbutton"
        Me.pausevbutton.Size = New System.Drawing.Size(75, 23)
        Me.pausevbutton.TabIndex = 5
        Me.pausevbutton.Text = "Pause"
        Me.pausevbutton.UseVisualStyleBackColor = False
        '
        'loopvbutton
        '
        Me.loopvbutton.BackColor = System.Drawing.Color.Transparent
        Me.loopvbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loopvbutton.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loopvbutton.Location = New System.Drawing.Point(13, 521)
        Me.loopvbutton.Name = "loopvbutton"
        Me.loopvbutton.Size = New System.Drawing.Size(156, 23)
        Me.loopvbutton.TabIndex = 6
        Me.loopvbutton.Text = "Loop"
        Me.loopvbutton.UseVisualStyleBackColor = False
        '
        'toolbalvbutt
        '
        Me.toolbalvbutt.BackColor = System.Drawing.Color.Transparent
        Me.toolbalvbutt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toolbalvbutt.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolbalvbutt.Location = New System.Drawing.Point(175, 521)
        Me.toolbalvbutt.Name = "toolbalvbutt"
        Me.toolbalvbutt.Size = New System.Drawing.Size(156, 23)
        Me.toolbalvbutt.TabIndex = 7
        Me.toolbalvbutt.Text = "Toggle Toolbar"
        Me.toolbalvbutt.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 550)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Loop ON"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 470)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Chronology"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(642, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 22)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clear List"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'media
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(772, 580)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.toolbalvbutt)
        Me.Controls.Add(Me.loopvbutton)
        Me.Controls.Add(Me.pausevbutton)
        Me.Controls.Add(Me.stopvbutton)
        Me.Controls.Add(Me.playvbutton)
        Me.Controls.Add(Me.openvbutt)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.AxVLCPlugin21)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Kokila", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "media"
        Me.ShowIcon = False
        Me.Text = "M-player"
        Me.TopMost = True
        CType(Me.AxVLCPlugin21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AxVLCPlugin21 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents openvbutt As System.Windows.Forms.Button
    Friend WithEvents playvbutton As System.Windows.Forms.Button
    Friend WithEvents stopvbutton As System.Windows.Forms.Button
    Friend WithEvents pausevbutton As System.Windows.Forms.Button
    Friend WithEvents loopvbutton As System.Windows.Forms.Button
    Friend WithEvents toolbalvbutt As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
