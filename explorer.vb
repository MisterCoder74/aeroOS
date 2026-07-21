Imports ExpTreeLib
Imports ExpTreeLib.CShItem
Imports ExpTreeLib.SystemImageListManager
Imports System.Threading
Imports Ionic.Zip
Imports System.IO

Public Class explorer
    Private LastSelectedCSI As CShItem
    Private Shared Event1 As New ManualResetEvent(True)
    Dim sourcedir As String
    Dim filetocopyname As String
    Dim targetdir As String
    Dim sourcefile As String
    Dim targetfile As String

    Private Sub AfterNodeSelect(ByVal pathName As String, ByVal CSI As CShItem) Handles ExpTree1.ExpTreeNodeSelected
        Dim dirList As New ArrayList()
        Dim fileList As New ArrayList()
        Dim TotalItems As Integer
        If CSI.DisplayName.Equals(CShItem.strMyComputer) Then
            'avoid re-query since only has dirs
            dirList = CSI.GetDirectories
        Else
            dirList = CSI.GetDirectories
            fileList = CSI.GetFiles
        End If
        TotalItems = dirList.Count + fileList.Count
        If TotalItems > 0 Then
            Dim item As CShItem
            dirList.Sort()
            fileList.Sort()

            sbr1.Text = pathName & "                 " & dirList.Count & " Directories " & fileList.Count & " Files"
            Dim combList As New ArrayList(TotalItems)
            combList.AddRange(dirList)
            combList.AddRange(fileList)
            lv1.BeginUpdate()
            lv1.Items.Clear()
            For Each item In combList
                Dim lvi As New ListViewItem(item.DisplayName)
                With lvi
                    .ImageIndex = SystemImageListManager.GetIconIndex(item, False)
                    .Tag = item
                End With
                lv1.Items.Add(lvi)
            Next
            lv1.EndUpdate()
        Else
            sbr1.Text = pathName & "Has No Items"
        End If
    End Sub

    Private Sub explorer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        SystemImageListManager.SetListViewImageList(lv1, True, False)
        SystemImageListManager.SetListViewImageList(lv1, False, False)
        If stack.TextBox5.Text <> "" Then
            ExpTree1.ExpandANode(stack.TextBox5.Text)
        End If
        lv1.View = View.List
    End Sub

    Private Sub lv1_VisibleChanged(sender As System.Object, e As System.EventArgs) Handles lv1.VisibleChanged
        If lv1.Visible Then
            SystemImageListManager.SetListViewImageList(lv1, True, False)
            SystemImageListManager.SetListViewImageList(lv1, False, False)
        End If
    End Sub

    Private Sub lv1_MouseUp(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles lv1.MouseUp
        Dim lvi As ListViewItem = lv1.GetItemAt(e.X, e.Y)
        If IsNothing(lvi) Then Exit Sub
        If IsNothing(lv1.SelectedItems) OrElse lv1.SelectedItems.Count < 1 Then Exit Sub

        Dim item As CShItem = lv1.SelectedItems(0).Tag
        If item.IsFolder Then
            ExpTree1.ExpandANode(item)
            TextBox1.Text = item.Path.ToString
        Else
            Try
                TextBox1.Text = item.Parent.Path.ToString
                TextBox2.Text = item.Path.ToString
                TextBox3.Text = item.GetFileName.ToString
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in starting application")
            End Try
        End If
    End Sub
    Private BackList As ArrayList

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim item As CShItem = lv1.SelectedItems(0).Tag
        sourcefile = TextBox2.Text
        TextBox1.Text = item.Parent.Path.ToString
        targetdir = TextBox1.Text
        filetocopyname = TextBox3.Text
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            targetfile = TextBox1.Text & "\" & filetocopyname
            Me.TopMost = False
            MsgBox("Confirm paste file")
            copyfile.Show()
            copyfile.Text = "Pasting file"
            My.Computer.FileSystem.CopyFile(sourcefile, targetfile, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
            If Not ExpTree1.SelectedItem Is Nothing Then
                ExpTree1.RefreshTree()
            End If
            Me.TopMost = True
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
        Catch ex As Exception
            Me.TopMost = False
            MsgBox("Please click on a file in the folder to acquire folder path")
            Me.TopMost = True
        End Try

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If Not ExpTree1.SelectedItem Is Nothing Then
            ExpTree1.RefreshTree()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Normal Icons" Then
            lv1.View = View.SmallIcon
        ElseIf ComboBox1.SelectedItem = "Large Icons" Then
            lv1.View = View.LargeIcon
        ElseIf ComboBox1.SelectedItem = "List" Then
            lv1.View = View.List
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Try
            Dim item As CShItem = lv1.SelectedItems(0).Tag
            sourcefile = item.Path.ToString
            erasefile.Show()
            My.Computer.FileSystem.DeleteFile(sourcefile)
            If Not ExpTree1.SelectedItem Is Nothing Then
                ExpTree1.RefreshTree()
            End If
            lv1.Refresh()
        Catch ex As Exception
            Me.TopMost = False
            MsgBox("Error erasing file")
            Me.TopMost = True
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub
    Private Sub lv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lv1.DoubleClick
        Dim csi As CShItem = lv1.SelectedItems(0).Tag
        If csi.IsFolder Then
            ExpTree1.ExpandANode(csi)
        Else
            Try
                Dim filetoopen As String = csi.Path.ToString
                Dim fileext = Microsoft.VisualBasic.Right(filetoopen, 3)
                If fileext = "jpg" Or fileext = "gif" Or fileext = "tif" Or fileext = "bmp" Or fileext = "wmf" Or fileext = "png" Then
                    stack.TextBox1.Text = filetoopen
                    bigshow.Show()
                ElseIf fileext = "rtf" Then
                    stack.TextBox2.Text = filetoopen
                    write.Show()
                ElseIf fileext = "txt" Then
                    stack.TextBox2.Text = filetoopen
                    notepad.Show()
                ElseIf fileext = "mp3" Or fileext = "wav" Or fileext = "wma" Or fileext = "avi" Or fileext = "mpg" Or fileext = "wmv" Or fileext = "mp4" Or fileext = "m4a" Or fileext = "flv" Then
                    stack.TextBox3.Text = filetoopen
                    media.Show()

                ElseIf fileext = "zip" Or fileext = "rar" Then
                    stack.TextBox6.Text = filetoopen
                    zipper.Show()
                Else
                    MsgBox("Aero cannot handle this type of file." & vbCrLf & "Click OK to open it with Windows default program.")
                    Process.Start(filetoopen)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "Error in starting application")
            End Try
        End If
    End Sub

    Private Sub explorer_Deactivate(sender As System.Object, e As System.EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.6
    End Sub

    Private Sub explorer_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub
    Private Sub explorer_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            aero.sfButtonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then
            aero.sfButtonsmall.Visible = False
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim csi As CShItem = lv1.SelectedItems(0).Tag
        If csi.IsFolder Then
            sourcedir = csi.Path.ToString
            My.Computer.FileSystem.DeleteDirectory(sourcedir, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            Me.TopMost = False
            MsgBox("Folder " & sourcedir & " has been sent to the recycle bin")

            Me.TopMost = True
            If Not ExpTree1.SelectedItem Is Nothing Then
                ExpTree1.RefreshTree()
            End If
            'ExpTree1.ExpandANode(csi.parent)
        Else
            'do nothing
        End If

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Dim item As CShItem = lv1.SelectedItems(0).Tag
            Me.TopMost = False
            Dim newfolder As String = InputBox("New folder name:")
            Dim fullpath As String = item.Parent.Path.ToString & "\" & newfolder
            Me.TopMost = True
            If Not My.Computer.FileSystem.DirectoryExists(fullpath) Then
                My.Computer.FileSystem.CreateDirectory(fullpath)
            End If
            If Not ExpTree1.SelectedItem Is Nothing Then
                ExpTree1.RefreshTree()
            End If
        Catch ex As Exception
            Me.TopMost = False
            MsgBox("Folder error. Please select one file in the current folder" & vbCrLf & "in order to acquire the full path")
            Me.TopMost = True
        End Try
       
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        zipper.Show()
    End Sub

    Private Sub lv1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lv1.SelectedIndexChanged
        Try
            Dim csi As CShItem = lv1.SelectedItems(0).Tag
            sbr1.Text = "Selected:     " & csi.Path.ToString
        Catch ex As Exception

        End Try

    End Sub
End Class
