Imports System
Imports System.IO
Imports System.Text
Public Class selectbck

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.alternative
            aero.BackgroundImageLayout = ImageLayout.Stretch
            'change all forms backimage
            aboutbox.BackgroundImage = My.Resources.alternative
            addbook.BackgroundImage = My.Resources.alternative
            addword.BackgroundImage = My.Resources.alternative
            aero_dictionary.BackgroundImage = My.Resources.alternative
            alarmclock.BackgroundImage = My.Resources.alternative
            bigshow.BackgroundImage = My.Resources.alternative
            browser.BackgroundImage = My.Resources.alternative
            friendlist.BackgroundImage = My.Resources.alternative
            calc.BackgroundImage = My.Resources.alternative
            cclient.BackgroundImage = My.Resources.alternative
            clipmanager.BackgroundImage = My.Resources.alternative
            copyfile.BackgroundImage = My.Resources.alternative
            'CrawlingView.BackgroundImage = My.Resources.base
            cserve.BackgroundImage = My.Resources.alternative
            dancerladysetup.BackgroundImage = My.Resources.alternative
            dancersetup.BackgroundImage = My.Resources.alternative
            devices.BackgroundImage = My.Resources.alternative
            DJconsolePro.BackgroundImage = My.Resources.alternative
            emailer.BackgroundImage = My.Resources.alternative
            erasefile.BackgroundImage = My.Resources.alternative
            explorer.BackgroundImage = My.Resources.alternative
            externalprogs.BackgroundImage = My.Resources.alternative
            externalsetup.BackgroundImage = My.Resources.alternative
            filetransfer.BackgroundImage = My.Resources.alternative
            frmNameEntry.BackgroundImage = My.Resources.alternative
            frmStart.BackgroundImage = My.Resources.alternative
            frmSoundRecorder.BackgroundImage = My.Resources.alternative
            html.BackgroundImage = My.Resources.alternative
            iconssetup.BackgroundImage = My.Resources.alternative
            imgbrowser.BackgroundImage = My.Resources.alternative
            lanlist.BackgroundImage = My.Resources.alternative
            loginregister.BackgroundImage = My.Resources.alternative
            maps.BackgroundImage = My.Resources.alternative
            media.BackgroundImage = My.Resources.alternative
            mediacrawler.BackgroundImage = My.Resources.alternative
            meteocredits.BackgroundImage = My.Resources.alternative
            meteoform.BackgroundImage = My.Resources.alternative
            newimage.BackgroundImage = My.Resources.alternative
            newroot.BackgroundImage = My.Resources.alternative
            painter.BackgroundImage = My.Resources.alternative
            performance.BackgroundImage = My.Resources.alternative
            poker.BackgroundImage = My.Resources.alternative
            printlist.BackgroundImage = My.Resources.alternative
            resizeimage.BackgroundImage = My.Resources.alternative
            RSSfeed.BackgroundImage = My.Resources.alternative
            saveform.BackgroundImage = My.Resources.alternative
            screencapturer.BackgroundImage = My.Resources.alternative
            Me.BackgroundImage = My.Resources.alternative
            senderclient.BackgroundImage = My.Resources.alternative
            sendserver.BackgroundImage = My.Resources.alternative
            settings.BackgroundImage = My.Resources.alternative
            socialmanager.BackgroundImage = My.Resources.alternative
            speak.BackgroundImage = My.Resources.alternative
            stack.BackgroundImage = My.Resources.alternative
            startupmusic.BackgroundImage = My.Resources.alternative
            stegano.BackgroundImage = My.Resources.alternative
            thememanager.BackgroundImage = My.Resources.alternative
            usersadmin.BackgroundImage = My.Resources.alternative
            wifilist.BackgroundImage = My.Resources.alternative
            write.BackgroundImage = My.Resources.alternative
            zipper.BackgroundImage = My.Resources.alternative
            runwindows.BackgroundImage = My.Resources.alternative
            recent.BackgroundImage = My.Resources.alternative

            'end change form backimage
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Aero Alternative Yellow"

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.alternative")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub
    Private Sub selectbck_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub selectbck_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.base
            aero.BackgroundImageLayout = ImageLayout.Stretch
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Base"

            aboutbox.BackgroundImage = My.Resources.base
            addbook.BackgroundImage = My.Resources.base
            addword.BackgroundImage = My.Resources.base
            aero_dictionary.BackgroundImage = My.Resources.base
            alarmclock.BackgroundImage = My.Resources.base
            bigshow.BackgroundImage = My.Resources.base
            browser.BackgroundImage = My.Resources.base
            friendlist.BackgroundImage = My.Resources.base
            calc.BackgroundImage = My.Resources.base
            cclient.BackgroundImage = My.Resources.base
            clipmanager.BackgroundImage = My.Resources.base
            copyfile.BackgroundImage = My.Resources.base
            cserve.BackgroundImage = My.Resources.base
            dancerladysetup.BackgroundImage = My.Resources.base
            dancersetup.BackgroundImage = My.Resources.base
            devices.BackgroundImage = My.Resources.base
            DJconsolePro.BackgroundImage = My.Resources.base
            emailer.BackgroundImage = My.Resources.base
            erasefile.BackgroundImage = My.Resources.base
            explorer.BackgroundImage = My.Resources.base
            externalprogs.BackgroundImage = My.Resources.base
            externalsetup.BackgroundImage = My.Resources.base
            filetransfer.BackgroundImage = My.Resources.base
            frmNameEntry.BackgroundImage = My.Resources.base
            frmStart.BackgroundImage = My.Resources.base
            frmSoundRecorder.BackgroundImage = My.Resources.base
            html.BackgroundImage = My.Resources.base
            iconssetup.BackgroundImage = My.Resources.base
            imgbrowser.BackgroundImage = My.Resources.base
            lanlist.BackgroundImage = My.Resources.base
            loginregister.BackgroundImage = My.Resources.base
            maps.BackgroundImage = My.Resources.base
            media.BackgroundImage = My.Resources.base
            mediacrawler.BackgroundImage = My.Resources.base
            meteocredits.BackgroundImage = My.Resources.base
            meteoform.BackgroundImage = My.Resources.base
            newimage.BackgroundImage = My.Resources.base
            newroot.BackgroundImage = My.Resources.base
            painter.BackgroundImage = My.Resources.base
            performance.BackgroundImage = My.Resources.base
            poker.BackgroundImage = My.Resources.base
            printlist.BackgroundImage = My.Resources.base
            resizeimage.BackgroundImage = My.Resources.base
            RSSfeed.BackgroundImage = My.Resources.base
            saveform.BackgroundImage = My.Resources.base
            screencapturer.BackgroundImage = My.Resources.base
            Me.BackgroundImage = My.Resources.base
            senderclient.BackgroundImage = My.Resources.base
            sendserver.BackgroundImage = My.Resources.base
            settings.BackgroundImage = My.Resources.base
            socialmanager.BackgroundImage = My.Resources.base
            speak.BackgroundImage = My.Resources.base
            stack.BackgroundImage = My.Resources.base
            startupmusic.BackgroundImage = My.Resources.base
            stegano.BackgroundImage = My.Resources.base
            thememanager.BackgroundImage = My.Resources.base
            usersadmin.BackgroundImage = My.Resources.base
            wifilist.BackgroundImage = My.Resources.base
            write.BackgroundImage = My.Resources.base
            zipper.BackgroundImage = My.Resources.base
            runwindows.BackgroundImage = My.Resources.base
            recent.BackgroundImage = My.Resources.base


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.base")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.alternative2
            aero.BackgroundImageLayout = ImageLayout.Stretch
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Aero Alternative Red"

            aboutbox.BackgroundImage = My.Resources.alternative2
            addbook.BackgroundImage = My.Resources.alternative2
            addword.BackgroundImage = My.Resources.alternative2
            aero_dictionary.BackgroundImage = My.Resources.alternative2
            alarmclock.BackgroundImage = My.Resources.alternative2
            bigshow.BackgroundImage = My.Resources.alternative2
            browser.BackgroundImage = My.Resources.alternative2
            friendlist.BackgroundImage = My.Resources.alternative2
            calc.BackgroundImage = My.Resources.alternative2
            cclient.BackgroundImage = My.Resources.alternative2
            clipmanager.BackgroundImage = My.Resources.alternative2
            copyfile.BackgroundImage = My.Resources.alternative2
            'CrawlingView.BackgroundImage = My.Resources.alternative2
            cserve.BackgroundImage = My.Resources.alternative2
            dancerladysetup.BackgroundImage = My.Resources.alternative2
            dancersetup.BackgroundImage = My.Resources.alternative2
            devices.BackgroundImage = My.Resources.alternative2
            DJconsolePro.BackgroundImage = My.Resources.alternative2
            emailer.BackgroundImage = My.Resources.alternative2
            erasefile.BackgroundImage = My.Resources.alternative2
            explorer.BackgroundImage = My.Resources.alternative2
            externalprogs.BackgroundImage = My.Resources.alternative2
            externalsetup.BackgroundImage = My.Resources.alternative2
            filetransfer.BackgroundImage = My.Resources.alternative2
            frmNameEntry.BackgroundImage = My.Resources.alternative2
            frmStart.BackgroundImage = My.Resources.alternative2
            frmSoundRecorder.BackgroundImage = My.Resources.alternative2
            html.BackgroundImage = My.Resources.alternative2
            iconssetup.BackgroundImage = My.Resources.alternative2
            imgbrowser.BackgroundImage = My.Resources.alternative2
            lanlist.BackgroundImage = My.Resources.alternative2
            loginregister.BackgroundImage = My.Resources.alternative2
            maps.BackgroundImage = My.Resources.alternative2
            media.BackgroundImage = My.Resources.alternative2
            mediacrawler.BackgroundImage = My.Resources.alternative2
            meteocredits.BackgroundImage = My.Resources.alternative2
            meteoform.BackgroundImage = My.Resources.alternative2
            newimage.BackgroundImage = My.Resources.alternative2
            newroot.BackgroundImage = My.Resources.alternative2
            painter.BackgroundImage = My.Resources.alternative2
            performance.BackgroundImage = My.Resources.alternative2
            poker.BackgroundImage = My.Resources.alternative2
            printlist.BackgroundImage = My.Resources.alternative2
            resizeimage.BackgroundImage = My.Resources.alternative2
            RSSfeed.BackgroundImage = My.Resources.alternative2
            saveform.BackgroundImage = My.Resources.alternative2
            screencapturer.BackgroundImage = My.Resources.alternative2
            Me.BackgroundImage = My.Resources.alternative2
            senderclient.BackgroundImage = My.Resources.alternative2
            sendserver.BackgroundImage = My.Resources.alternative2
            settings.BackgroundImage = My.Resources.alternative2
            socialmanager.BackgroundImage = My.Resources.alternative2
            speak.BackgroundImage = My.Resources.alternative2
            stack.BackgroundImage = My.Resources.alternative2
            startupmusic.BackgroundImage = My.Resources.alternative2
            stegano.BackgroundImage = My.Resources.alternative2
            thememanager.BackgroundImage = My.Resources.alternative2
            usersadmin.BackgroundImage = My.Resources.alternative2
            wifilist.BackgroundImage = My.Resources.alternative2
            write.BackgroundImage = My.Resources.alternative2
            zipper.BackgroundImage = My.Resources.alternative2
            runwindows.BackgroundImage = My.Resources.alternative2
            recent.BackgroundImage = My.Resources.alternative2


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.alternative2")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.alternative3
            aero.BackgroundImageLayout = ImageLayout.Stretch
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Aero Alternative Green"

            aboutbox.BackgroundImage = My.Resources.alternative3
            addbook.BackgroundImage = My.Resources.alternative3
            addword.BackgroundImage = My.Resources.alternative3
            aero_dictionary.BackgroundImage = My.Resources.alternative3
            alarmclock.BackgroundImage = My.Resources.alternative3
            bigshow.BackgroundImage = My.Resources.alternative3
            browser.BackgroundImage = My.Resources.alternative3
            friendlist.BackgroundImage = My.Resources.alternative3
            calc.BackgroundImage = My.Resources.alternative3
            cclient.BackgroundImage = My.Resources.alternative3
            clipmanager.BackgroundImage = My.Resources.alternative3
            copyfile.BackgroundImage = My.Resources.alternative3
            'CrawlingView.BackgroundImage = My.Resources.alternative3
            cserve.BackgroundImage = My.Resources.alternative3
            dancerladysetup.BackgroundImage = My.Resources.alternative3
            dancersetup.BackgroundImage = My.Resources.alternative3
            devices.BackgroundImage = My.Resources.alternative3
            DJconsolePro.BackgroundImage = My.Resources.alternative3
            emailer.BackgroundImage = My.Resources.alternative3
            erasefile.BackgroundImage = My.Resources.alternative3
            explorer.BackgroundImage = My.Resources.alternative3
            externalprogs.BackgroundImage = My.Resources.alternative3
            externalsetup.BackgroundImage = My.Resources.alternative3
            filetransfer.BackgroundImage = My.Resources.alternative3
            frmNameEntry.BackgroundImage = My.Resources.alternative3
            frmStart.BackgroundImage = My.Resources.alternative3
            frmSoundRecorder.BackgroundImage = My.Resources.alternative3
            html.BackgroundImage = My.Resources.alternative3
            iconssetup.BackgroundImage = My.Resources.alternative3
            imgbrowser.BackgroundImage = My.Resources.alternative3
            lanlist.BackgroundImage = My.Resources.alternative3
            loginregister.BackgroundImage = My.Resources.alternative3
            maps.BackgroundImage = My.Resources.alternative3
            media.BackgroundImage = My.Resources.alternative3
            mediacrawler.BackgroundImage = My.Resources.alternative3
            meteocredits.BackgroundImage = My.Resources.alternative3
            meteoform.BackgroundImage = My.Resources.alternative3
            newimage.BackgroundImage = My.Resources.alternative3
            newroot.BackgroundImage = My.Resources.alternative3
            painter.BackgroundImage = My.Resources.alternative3
            performance.BackgroundImage = My.Resources.alternative3
            poker.BackgroundImage = My.Resources.alternative3
            printlist.BackgroundImage = My.Resources.alternative3
            resizeimage.BackgroundImage = My.Resources.alternative3
            RSSfeed.BackgroundImage = My.Resources.alternative3
            saveform.BackgroundImage = My.Resources.alternative3
            screencapturer.BackgroundImage = My.Resources.alternative3
            Me.BackgroundImage = My.Resources.alternative3
            senderclient.BackgroundImage = My.Resources.alternative3
            sendserver.BackgroundImage = My.Resources.alternative3
            settings.BackgroundImage = My.Resources.alternative3
            socialmanager.BackgroundImage = My.Resources.alternative3
            speak.BackgroundImage = My.Resources.alternative3
            stack.BackgroundImage = My.Resources.alternative3
            startupmusic.BackgroundImage = My.Resources.alternative3
            stegano.BackgroundImage = My.Resources.alternative3
            thememanager.BackgroundImage = My.Resources.alternative3
            usersadmin.BackgroundImage = My.Resources.alternative3
            wifilist.BackgroundImage = My.Resources.alternative3
            write.BackgroundImage = My.Resources.alternative3
            zipper.BackgroundImage = My.Resources.alternative3
            runwindows.BackgroundImage = My.Resources.alternative3
            recent.BackgroundImage = My.Resources.alternative3


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.alternative3")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.alternative4
            aero.BackgroundImageLayout = ImageLayout.Stretch
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Aero Alternative Violet"

            aboutbox.BackgroundImage = My.Resources.alternative4
            addbook.BackgroundImage = My.Resources.alternative4
            addword.BackgroundImage = My.Resources.alternative4
            aero_dictionary.BackgroundImage = My.Resources.alternative4
            alarmclock.BackgroundImage = My.Resources.alternative4
            bigshow.BackgroundImage = My.Resources.alternative4
            browser.BackgroundImage = My.Resources.alternative4
            friendlist.BackgroundImage = My.Resources.alternative4
            calc.BackgroundImage = My.Resources.alternative4
            cclient.BackgroundImage = My.Resources.alternative4
            clipmanager.BackgroundImage = My.Resources.alternative4
            copyfile.BackgroundImage = My.Resources.alternative4
            'CrawlingView.BackgroundImage = My.Resources.alternative4
            cserve.BackgroundImage = My.Resources.alternative4
            dancerladysetup.BackgroundImage = My.Resources.alternative4
            dancersetup.BackgroundImage = My.Resources.alternative4
            devices.BackgroundImage = My.Resources.alternative4
            DJconsolePro.BackgroundImage = My.Resources.alternative4
            emailer.BackgroundImage = My.Resources.alternative4
            erasefile.BackgroundImage = My.Resources.alternative4
            explorer.BackgroundImage = My.Resources.alternative4
            externalprogs.BackgroundImage = My.Resources.alternative4
            externalsetup.BackgroundImage = My.Resources.alternative4
            filetransfer.BackgroundImage = My.Resources.alternative4

            frmNameEntry.BackgroundImage = My.Resources.alternative4
            frmStart.BackgroundImage = My.Resources.alternative4
            frmSoundRecorder.BackgroundImage = My.Resources.alternative4
            html.BackgroundImage = My.Resources.alternative4
            iconssetup.BackgroundImage = My.Resources.alternative4
            imgbrowser.BackgroundImage = My.Resources.alternative4
            lanlist.BackgroundImage = My.Resources.alternative4
            loginregister.BackgroundImage = My.Resources.alternative4
            maps.BackgroundImage = My.Resources.alternative4
            media.BackgroundImage = My.Resources.alternative4
            mediacrawler.BackgroundImage = My.Resources.alternative4
            meteocredits.BackgroundImage = My.Resources.alternative4
            meteoform.BackgroundImage = My.Resources.alternative4
            newimage.BackgroundImage = My.Resources.alternative4
            newroot.BackgroundImage = My.Resources.alternative4
            painter.BackgroundImage = My.Resources.alternative4
            performance.BackgroundImage = My.Resources.alternative4
            poker.BackgroundImage = My.Resources.alternative4
            printlist.BackgroundImage = My.Resources.alternative4
            resizeimage.BackgroundImage = My.Resources.alternative4
            RSSfeed.BackgroundImage = My.Resources.alternative4
            saveform.BackgroundImage = My.Resources.alternative4
            screencapturer.BackgroundImage = My.Resources.alternative4
            Me.BackgroundImage = My.Resources.alternative4
            senderclient.BackgroundImage = My.Resources.alternative4
            sendserver.BackgroundImage = My.Resources.alternative4
            settings.BackgroundImage = My.Resources.alternative4
            socialmanager.BackgroundImage = My.Resources.alternative4
            speak.BackgroundImage = My.Resources.alternative4
            stack.BackgroundImage = My.Resources.alternative4
            startupmusic.BackgroundImage = My.Resources.alternative4
            stegano.BackgroundImage = My.Resources.alternative4
            thememanager.BackgroundImage = My.Resources.alternative4
            usersadmin.BackgroundImage = My.Resources.alternative4
            wifilist.BackgroundImage = My.Resources.alternative4
            write.BackgroundImage = My.Resources.alternative4
            zipper.BackgroundImage = My.Resources.alternative4
            runwindows.BackgroundImage = My.Resources.alternative4
            recent.BackgroundImage = My.Resources.alternative4


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.alternative4")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub



    Private Sub selectbck_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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


    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()
        Try
            aero.BackgroundImage = My.Resources.alternative5
            aero.BackgroundImageLayout = ImageLayout.Stretch
            settings.Label11.Text = "None"
            settings.Label13.Text = "Desktop: Aero Alternative Smoke"

            aboutbox.BackgroundImage = My.Resources.alternative5
            addbook.BackgroundImage = My.Resources.alternative5
            addword.BackgroundImage = My.Resources.alternative5
            aero_dictionary.BackgroundImage = My.Resources.alternative5
            alarmclock.BackgroundImage = My.Resources.alternative5
            bigshow.BackgroundImage = My.Resources.alternative5
            browser.BackgroundImage = My.Resources.alternative5
            friendlist.BackgroundImage = My.Resources.alternative5
            calc.BackgroundImage = My.Resources.alternative5
            cclient.BackgroundImage = My.Resources.alternative5
            clipmanager.BackgroundImage = My.Resources.alternative5
            copyfile.BackgroundImage = My.Resources.alternative5
            'CrawlingView.BackgroundImage = My.Resources.alternative5
            cserve.BackgroundImage = My.Resources.alternative5
            dancerladysetup.BackgroundImage = My.Resources.alternative5
            dancersetup.BackgroundImage = My.Resources.alternative5
            devices.BackgroundImage = My.Resources.alternative5
            DJconsolePro.BackgroundImage = My.Resources.alternative5
            emailer.BackgroundImage = My.Resources.alternative5
            erasefile.BackgroundImage = My.Resources.alternative5
            explorer.BackgroundImage = My.Resources.alternative5
            externalprogs.BackgroundImage = My.Resources.alternative5
            externalsetup.BackgroundImage = My.Resources.alternative5
            filetransfer.BackgroundImage = My.Resources.alternative5

            frmNameEntry.BackgroundImage = My.Resources.alternative5
            frmStart.BackgroundImage = My.Resources.alternative5
            frmSoundRecorder.BackgroundImage = My.Resources.alternative5
            html.BackgroundImage = My.Resources.alternative5
            iconssetup.BackgroundImage = My.Resources.alternative5
            imgbrowser.BackgroundImage = My.Resources.alternative5
            lanlist.BackgroundImage = My.Resources.alternative5
            loginregister.BackgroundImage = My.Resources.alternative5
            maps.BackgroundImage = My.Resources.alternative5
            media.BackgroundImage = My.Resources.alternative5
            mediacrawler.BackgroundImage = My.Resources.alternative5
            meteocredits.BackgroundImage = My.Resources.alternative5
            meteoform.BackgroundImage = My.Resources.alternative5
            newimage.BackgroundImage = My.Resources.alternative5
            newroot.BackgroundImage = My.Resources.alternative5
            painter.BackgroundImage = My.Resources.alternative5
            performance.BackgroundImage = My.Resources.alternative5
            poker.BackgroundImage = My.Resources.alternative5
            printlist.BackgroundImage = My.Resources.alternative5
            resizeimage.BackgroundImage = My.Resources.alternative5
            RSSfeed.BackgroundImage = My.Resources.alternative5
            saveform.BackgroundImage = My.Resources.alternative5
            screencapturer.BackgroundImage = My.Resources.alternative5
            Me.BackgroundImage = My.Resources.alternative5
            senderclient.BackgroundImage = My.Resources.alternative5
            sendserver.BackgroundImage = My.Resources.alternative5
            settings.BackgroundImage = My.Resources.alternative5
            socialmanager.BackgroundImage = My.Resources.alternative5
            speak.BackgroundImage = My.Resources.alternative5
            stack.BackgroundImage = My.Resources.alternative5
            startupmusic.BackgroundImage = My.Resources.alternative5
            stegano.BackgroundImage = My.Resources.alternative5
            thememanager.BackgroundImage = My.Resources.alternative5
            usersadmin.BackgroundImage = My.Resources.alternative5
            wifilist.BackgroundImage = My.Resources.alternative5
            write.BackgroundImage = My.Resources.alternative5
            zipper.BackgroundImage = My.Resources.alternative5
            runwindows.BackgroundImage = My.Resources.alternative5
            recent.BackgroundImage = My.Resources.alternative5


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.alternative5")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Black
        aero.wcustombuttssmall.ForeColor = Color.Black
        aero.openaeromediaButton.ForeColor = Color.Black
        aero.magbutton.ForeColor = Color.Black
        aero.vmagbutton.ForeColor = Color.Black
        aero.notesbutton.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.timelabel.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black

        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.Black
        aero.ylabel.ForeColor = Color.Black
        aero.createiconbutton.ForeColor = Color.Black
        aero.ipcbutton.ForeColor = Color.Black
        aero.aeromenulabel.ForeColor = Color.Black
        aero.calendarclosebutton.ForeColor = Color.Black
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.Transparent
        aero.presentuser.ForeColor = Color.Black
        aero.temperaturelabel.ForeColor = Color.Black
        aero.Skylabel.ForeColor = Color.Black
        aero.locationlabel.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.closepanelbutton.ForeColor = Color.Black
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub
End Class