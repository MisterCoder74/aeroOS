<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStart))
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstMagnSize = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstMagn = New System.Windows.Forms.ListBox()
        Me.txtUsage = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdStart
        '
        Me.cmdStart.BackColor = System.Drawing.Color.Transparent
        Me.cmdStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStart.Font = New System.Drawing.Font("Agate-Normal", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.ForeColor = System.Drawing.Color.Black
        Me.cmdStart.Location = New System.Drawing.Point(7, 12)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(318, 44)
        Me.cmdStart.TabIndex = 0
        Me.cmdStart.Text = "Start Magnifier"
        Me.cmdStart.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Magnifying Glass Size:"
        '
        'lstMagnSize
        '
        Me.lstMagnSize.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMagnSize.FormattingEnabled = True
        Me.lstMagnSize.Items.AddRange(New Object() {" 48 - Small", " 64 - Normal", " 96 - Large", "128 - Extra large"})
        Me.lstMagnSize.Location = New System.Drawing.Point(7, 87)
        Me.lstMagnSize.Name = "lstMagnSize"
        Me.lstMagnSize.Size = New System.Drawing.Size(154, 56)
        Me.lstMagnSize.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(228, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Magnification:"
        '
        'lstMagn
        '
        Me.lstMagn.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMagn.FormattingEnabled = True
        Me.lstMagn.Items.AddRange(New Object() {"x2", "x4", "x8", "x16"})
        Me.lstMagn.Location = New System.Drawing.Point(231, 87)
        Me.lstMagn.Name = "lstMagn"
        Me.lstMagn.Size = New System.Drawing.Size(94, 56)
        Me.lstMagn.TabIndex = 5
        '
        'txtUsage
        '
        Me.txtUsage.BackColor = System.Drawing.Color.White
        Me.txtUsage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtUsage.Font = New System.Drawing.Font("Agate-Normal", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsage.Location = New System.Drawing.Point(0, 180)
        Me.txtUsage.Multiline = True
        Me.txtUsage.Name = "txtUsage"
        Me.txtUsage.ReadOnly = True
        Me.txtUsage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtUsage.Size = New System.Drawing.Size(332, 97)
        Me.txtUsage.TabIndex = 6
        Me.txtUsage.Text = resources.GetString("txtUsage.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Agate-Normal", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Usage:"
        '
        'frmStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(332, 277)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsage)
        Me.Controls.Add(Me.lstMagn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstMagnSize)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdStart)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmStart"
        Me.ShowIcon = False
        Me.Text = "Magnifying Glass"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstMagnSize As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstMagn As System.Windows.Forms.ListBox
    Friend WithEvents txtUsage As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
