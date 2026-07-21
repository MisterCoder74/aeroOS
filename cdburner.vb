Imports IMAPI_CDBurner
Imports System.IO
Public Class cdburner
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBurn As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofdBurn As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnBurn = New System.Windows.Forms.Button()
        Me.ofdBurn = New System.Windows.Forms.OpenFileDialog()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 251)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(125, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Files"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnBurn
        '
        Me.btnBurn.BackColor = System.Drawing.Color.Transparent
        Me.btnBurn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBurn.Font = New System.Drawing.Font("Agate-Normal", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBurn.Location = New System.Drawing.Point(143, 251)
        Me.btnBurn.Name = "btnBurn"
        Me.btnBurn.Size = New System.Drawing.Size(316, 23)
        Me.btnBurn.TabIndex = 3
        Me.btnBurn.Text = "Burn CD"
        Me.btnBurn.UseVisualStyleBackColor = False
        '
        'ofdBurn
        '
        Me.ofdBurn.Filter = "All Files (*.*)|*.*"
        Me.ofdBurn.Multiselect = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(447, 225)
        Me.ListBox1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Agate-Normal", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 10)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "standby"
        '
        'cdburner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = Global.AERO.My.Resources.Resources.alternative
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(471, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnBurn)
        Me.Controls.Add(Me.btnAdd)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "cdburner"
        Me.ShowIcon = False
        Me.Text = "CD Burner"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim clsBurn As clsCDBurn

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Try
            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative2" Then
                    Me.BackgroundImage = My.Resources.alternative2
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative3" Then
                    Me.BackgroundImage = My.Resources.alternative3
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative4" Then
                    Me.BackgroundImage = My.Resources.alternative4
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative5" Then
                    Me.BackgroundImage = My.Resources.alternative5
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                Else
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                End If
            Loop
            sr.Close()
        Catch ex As Exception
        End Try


        Try
            clsBurn = New clsCDBurn
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            btnAdd.Enabled = False
            btnBurn.Enabled = False
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim i As Integer
        If ofdBurn.ShowDialog = DialogResult.OK Then
            For Each file As String In ofdBurn.FileNames
                ListBox1.Items.Add(file)

            Next
            For i = 0 To ListBox1.Items.Count - 1
                ListBox1.SelectedIndex = i
                clsBurn.AddFileToBurn(ListBox1.SelectedItem)
            Next

            Label1.Text = i & " files ready to be written on disk"

        End If
    End Sub

    Private Sub btnBurn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBurn.Click
        clsBurn.Burn(Me.Handle)
        Label1.Text = "Burning files on disk"
    End Sub

    Private Sub cdburner_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.cdburnerbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.cdburnerbuttonsmall.Visible = False
        End If
    End Sub
End Class
