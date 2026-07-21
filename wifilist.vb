Imports AERO.NativeWifi
Imports System.IO

Public Class wifilist

    Private Sub wifilist_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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



        Dim client As New WlanClient()

        For Each wlanIface As WlanClient.WlanInterface In client.Interfaces

            Dim wlanBssEntries As Wlan.WlanAvailableNetwork() = wlanIface.GetAvailableNetworkList(0)



            For Each network As Wlan.WlanAvailableNetwork In wlanBssEntries

                Dim listItemWiFi As New ListViewItem()


                listItemWiFi.Text = System.Text.ASCIIEncoding.ASCII.GetString(network.dot11Ssid.SSID).Trim(ChrW(0))
                listItemWiFi.SubItems.Add(network.wlanSignalQuality.ToString() + "%")

                listItemWiFi.SubItems.Add(network.dot11DefaultAuthAlgorithm.ToString().Trim(CChar(ChrW(0))))

                listItemWiFi.SubItems.Add(network.dot11DefaultCipherAlgorithm.ToString().Trim(CChar(ChrW(0))))


                ListView1.Items.Add(listItemWiFi)
            Next
        Next
    End Sub
    Sub Doublekiller()
        Dim WFlist As New List(Of ListViewItem) ' 
        For Each WFnet As ListViewItem In ListView1.Items ' 
            Dim WFstat As Boolean = False
            For Each WFitem As ListViewItem In WFlist
                If WFnet.Text = WFitem.Text Then WFstat = True
            Next
            If WFstat = False Then WFlist.Add(WFnet)
        Next
        ListView1.Items.Clear()
        For Each WFconn As ListViewItem In WFlist
            ListView1.Items.Add(WFconn)
        Next
    End Sub
End Class