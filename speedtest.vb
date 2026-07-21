Public Class speedtest

    Private Sub speedtest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate(System.AppDomain.CurrentDomain.BaseDirectory() & "speedtest.html")
    End Sub

    Private Sub speedtest_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then

            aero.speedtestbuttonsmall.Visible = True
        End If
        If Me.WindowState = FormWindowState.Normal Then

            aero.speedtestbuttonsmall.Visible = False
        End If
    End Sub
End Class