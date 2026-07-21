<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class devices
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
        Me.natadapterbutton = New System.Windows.Forms.Button()
        Me.wifibutton = New System.Windows.Forms.Button()
        Me.printerbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'natadapterbutton
        '
        Me.natadapterbutton.BackColor = System.Drawing.Color.Transparent
        Me.natadapterbutton.BackgroundImage = Global.AERO.My.Resources.Resources.network_plug_icon
        Me.natadapterbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.natadapterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.natadapterbutton.Location = New System.Drawing.Point(41, 45)
        Me.natadapterbutton.Name = "natadapterbutton"
        Me.natadapterbutton.Size = New System.Drawing.Size(89, 75)
        Me.natadapterbutton.TabIndex = 13
        Me.natadapterbutton.UseVisualStyleBackColor = False
        '
        'wifibutton
        '
        Me.wifibutton.BackColor = System.Drawing.Color.Transparent
        Me.wifibutton.BackgroundImage = Global.AERO.My.Resources.Resources.Devices_network_wireless_icon
        Me.wifibutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.wifibutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.wifibutton.Location = New System.Drawing.Point(206, 45)
        Me.wifibutton.Name = "wifibutton"
        Me.wifibutton.Size = New System.Drawing.Size(89, 75)
        Me.wifibutton.TabIndex = 14
        Me.wifibutton.UseVisualStyleBackColor = False
        '
        'printerbutton
        '
        Me.printerbutton.BackColor = System.Drawing.Color.Transparent
        Me.printerbutton.BackgroundImage = Global.AERO.My.Resources.Resources.Devices_printer_icon
        Me.printerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.printerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.printerbutton.Location = New System.Drawing.Point(371, 45)
        Me.printerbutton.Name = "printerbutton"
        Me.printerbutton.Size = New System.Drawing.Size(89, 75)
        Me.printerbutton.TabIndex = 15
        Me.printerbutton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Network adapters"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(172, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Wi-Fi Neighborhood"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Printers 'n' Faxes"
        '
        'devices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 209)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.printerbutton)
        Me.Controls.Add(Me.wifibutton)
        Me.Controls.Add(Me.natadapterbutton)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "devices"
        Me.ShowIcon = False
        Me.Text = "Devices and Networks"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents natadapterbutton As System.Windows.Forms.Button
    Friend WithEvents wifibutton As System.Windows.Forms.Button
    Friend WithEvents printerbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
