Imports System.Data
Imports System.IO

Public Class friendlist
    Dim DS As New DataSet

    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub
    Private Sub pnlDetails_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlDetails.Paint

    End Sub

    Private Sub frmmyFriendInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
        Dim sr As StreamReader = File.OpenText(path)
        Dim s As String
        Try
            Do While sr.Peek() >= 0
                s = sr.ReadLine()
                If s = "My.Resources.base" Then
                    Me.BackgroundImage = My.Resources.base
                    Me.BackgroundImageLayout = ImageLayout.Stretch
                ElseIf s = "My.Resources.alternative" Then
                    Me.BackgroundImage = My.Resources.alternative
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

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnAdd.Enabled = True
        'clear()
        DS.ReadXml(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\friend.xml")
        Dim i As Integer = 0
        For Each r As DataRow In DS.Tables(0).Rows
            dtgFriends.Rows.Insert(i, r("Name"), r("Address"), r("Phone"), r("RelationShip"), r("Date_Of_Birth"), r("Email"))
            i = i + 1
        Next
        dtgFriends.ClearSelection()
    End Sub
    Public Sub showGrid()
        Try

            'DS.ReadXml(Application.StartupPath & "\friend.xml")
            DS.Tables(0).Clear()
            dtgFriends.Rows.Clear()
            DS.ReadXml(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\friend.xml")
            Dim i As Integer = 0
            For Each r As DataRow In DS.Tables(0).Rows
                dtgFriends.Rows.Insert(i, r("Name"), r("Address"), r("Phone"), r("RelationShip"), r("Date_Of_Birth"), r("Email"))
                i = i + 1
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Select Case btnClear.Text
            Case "Edit Mode"

                btnUpdate.Enabled = True
                btnDelete.Enabled = True
                btnAdd.Enabled = False
                clear()
                btnClear.Text = "Back"
            Case "Back"
                clear1()

                btnClear.Text = "Edit Mode"
                btnUpdate.Enabled = False
                btnDelete.Enabled = False
                btnAdd.Enabled = True
                dtgFriends.ClearSelection()
        End Select


    End Sub
    Public Sub clear()
        dtgFriends.ClearSelection()
        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtDB.Clear()
        txtEmail.Clear()
        txtRelation.Clear()

    End Sub
    Public Sub clear1()

        txtName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        txtDB.Clear()
        txtEmail.Clear()
        txtRelation.Clear()

    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If txtName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Or txtRelation.Text = "" Or txtDB.Text = "" Or txtEmail.Text = "" Then
            Exit Sub
        End If
        Dim rows As DataRow = DS.Tables(0).NewRow
        rows("Name") = txtName.Text
        rows("Address") = txtAddress.Text
        rows("Phone") = txtPhone.Text
        rows("RelationShip") = txtRelation.Text
        rows("Date_Of_Birth") = txtDB.Text
        rows("Email") = txtEmail.Text
        DS.Tables(0).Rows.Add(rows)
        DS.WriteXml(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\friend.xml")
        MessageBox.Show("One Record Added......")
        showGrid()
        clear()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'If dtgFriends.CurrentRow.Index >= 0 Then Exit Sub
        If txtName.Text = "" Or txtAddress.Text = "" Or txtPhone.Text = "" Or txtRelation.Text = "" Or txtDB.Text = "" Or txtEmail.Text = "" Then
            Exit Sub
        End If
        Dim rows As DataRow = DS.Tables(0).Rows(dtgFriends.CurrentRow.Index)
        rows("Name") = txtName.Text.ToUpper
        rows("Address") = txtAddress.Text.ToUpper
        rows("Phone") = txtPhone.Text.ToUpper
        rows("RelationShip") = txtRelation.Text.ToUpper
        rows("Date_Of_Birth") = txtDB.Text.ToUpper
        rows("Email") = txtEmail.Text.ToUpper
        DS.WriteXml(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\friend.xml")
        MessageBox.Show("One Record Updated......")

        showGrid()

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'Label7.Text = dtgFriends.CurrentRow.Index.ToString
        If dtgFriends.CurrentRow.Index > -1 Then
            DS.Tables(0).Rows(dtgFriends.CurrentRow.Index).Delete()
            DS.WriteXml(My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\friend.xml")
            showGrid()
        End If

    End Sub

    Private Sub dtgFriends_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgFriends.SelectionChanged
        If btnClear.Text = "Edit Mode" Then
            Exit Sub
        End If
        Try
            Dim rows As DataRow = DS.Tables(0).Rows(dtgFriends.CurrentRow.Index)
            txtName.Text = rows("Name")
            txtAddress.Text = rows("Address")
            txtPhone.Text = rows("Phone")
            txtRelation.Text = rows("RelationShip")
            txtDB.Text = rows("Date_Of_Birth")
            txtEmail.Text = rows("Email")
            'showGrid()
        Catch ex As Exception
            clear1()
        End Try

    End Sub

    Private Sub friendlist_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.flistbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.flistbuttonsmall.Visible = False
        End If
    End Sub
End Class
