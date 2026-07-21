Imports System.IO
Public Class thememanager

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        My.Settings.themepresent = False
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Base"
        settings.Label13.Text = "Desktop: Aero"
        Try
            aero.BackgroundImage = My.Resources.base
            aero.BackgroundImageLayout = ImageLayout.Stretch

            aboutbox.BackgroundImage = My.Resources.base
            addbook.BackgroundImage = My.Resources.base
            addword.BackgroundImage = My.Resources.base
            aero_dictionary.BackgroundImage = My.Resources.base
            alarmclock.BackgroundImage = My.Resources.base
            bigshow.BackgroundImage = My.Resources.base
            browser.BackgroundImage = My.Resources.base
            calc.BackgroundImage = My.Resources.base
            cclient.BackgroundImage = My.Resources.base
            clipmanager.BackgroundImage = My.Resources.base
            copyfile.BackgroundImage = My.Resources.base
            'CrawlingView.BackgroundImage = My.Resources.base
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
            'frmSetting.BackgroundImage = My.Resources.base
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
            saveform.BackgroundImage = My.Resources.base
            screencapturer.BackgroundImage = My.Resources.base
            selectbck.BackgroundImage = My.Resources.base
            senderclient.BackgroundImage = My.Resources.base
            sendserver.BackgroundImage = My.Resources.base
            settings.BackgroundImage = My.Resources.base
            socialmanager.BackgroundImage = My.Resources.base
            speak.BackgroundImage = My.Resources.base
            stack.BackgroundImage = My.Resources.base
            startupmusic.BackgroundImage = My.Resources.base
            stegano.BackgroundImage = My.Resources.base
            Me.BackgroundImage = My.Resources.base
            usersadmin.BackgroundImage = My.Resources.base
            wifilist.BackgroundImage = My.Resources.base
            write.BackgroundImage = My.Resources.base
            zipper.BackgroundImage = My.Resources.base


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
        'logolabel.ForeColor = Color.Lime
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
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub
    Private Sub Form1_Deactivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.6
    End Sub
    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub



    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Explosion"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources._02
            aero.BackgroundImageLayout = ImageLayout.Stretch


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources._02")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.Red
        aero.wcustombuttssmall.ForeColor = Color.Red
        aero.openaeromediaButton.ForeColor = Color.Red
        aero.magbutton.ForeColor = Color.Red
        aero.vmagbutton.ForeColor = Color.Red
        aero.notesbutton.ForeColor = Color.Red
        aero.timelabel.ForeColor = Color.Red
        aero.scpopenbutton.ForeColor = Color.Red
        aero.scpclosebutton.ForeColor = Color.Red
        aero.grouplabel.ForeColor = Color.Red

        aero.openpanelbutton.ForeColor = Color.Red
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.Red
        aero.stoppanelmediaButton.ForeColor = Color.Red
        aero.hidepanelButton.ForeColor = Color.Red
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
        aero.xlabel.ForeColor = Color.Red
        aero.ylabel.ForeColor = Color.Red
        aero.createiconbutton.ForeColor = Color.Red
        aero.ipcbutton.ForeColor = Color.Red
        aero.aeromenulabel.ForeColor = Color.Red
        aero.calendarclosebutton.ForeColor = Color.Red
        aero.inamelabel.ForeColor = Color.Red
        aero.iprocesslabel.ForeColor = Color.Red
        aero.alarmbutton.BackColor = Color.Red
        aero.pausepanelmediabutton.ForeColor = Color.Red
        aero.playpanelmediabutton.ForeColor = Color.Red
        aero.Label2.ForeColor = Color.Red
        aero.Label3.ForeColor = Color.Red
        aero.Label4.ForeColor = Color.Red
        aero.Label4.ForeColor = Color.Red
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Storm 1"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.storm1
            aero.BackgroundImageLayout = ImageLayout.Stretch

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.storm1")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.stormplayer.URL = My.Settings.rootdir & "\Sounds\stormsound.mp3"
        aero.stormplayer.settings.setMode("loop", True)
        aero.scpopenbutton.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
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
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.White
        aero.iprocesslabel.ForeColor = Color.White
        aero.alarmbutton.BackColor = Color.Transparent
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
    End Sub


    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Forest"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.forest
            aero.BackgroundImageLayout = ImageLayout.Stretch

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.forest")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.stormplayer.URL = My.Settings.rootdir & "\Sounds\forest.mp3"
        aero.stormplayer.settings.setMode("loop", True)
        aero.scpopenbutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
    End Sub


    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Elegant"
        settings.Label13.Text = "Desktop: Themepack"

        Try
            aero.BackgroundImage = My.Resources._01
            aero.BackgroundImageLayout = ImageLayout.Stretch



            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources._01")
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
        aero.timelabel.ForeColor = Color.Black
        aero.scpopenbutton.ForeColor = Color.Black
        aero.scpclosebutton.ForeColor = Color.Black
        aero.grouplabel.ForeColor = Color.Black
        aero.openpanelbutton.ForeColor = Color.Black
        aero.openpanelbutton.BackColor = Color.White
        aero.closepanelbutton.BackColor = Color.White
        aero.dmopenbutton.ForeColor = Color.Black
        aero.stoppanelmediaButton.ForeColor = Color.Black
        aero.hidepanelButton.ForeColor = Color.Black
        aero.officepanel.BackgroundImage = My.Resources.aeromenu04turned
        aero.mediapanel.BackgroundImage = My.Resources.aeromenu04turned
        aero.netpanel.BackgroundImage = My.Resources.aeromenu04turned
        aero.gamespanel.BackgroundImage = My.Resources.aeromenu04turned
        aero.systempanel.BackgroundImage = My.Resources.aeromenu04turned
        aero.menupanel01.BackgroundImage = My.Resources.aeromenu04
        aero.calendarpanel.BackgroundImage = My.Resources.aeromenu04mirror
        aero.shortcutpanel.BackgroundImage = My.Resources.aeromenu04mirror
        aero.downbutton.BackColor = Color.Black
        aero.upbutton.BackColor = Color.Black
        aero.mutebutton.BackColor = Color.Black
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.Black
        aero.iprocesslabel.ForeColor = Color.Black
        aero.alarmbutton.BackColor = Color.White
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black

    End Sub



    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Delicate"
        settings.Label13.Text = "Desktop: Themepack"

        Try
            aero.BackgroundImage = My.Resources._03
            aero.BackgroundImageLayout = ImageLayout.Stretch

            aboutbox.BackgroundImage = My.Resources._03
            addbook.BackgroundImage = My.Resources._03
            addword.BackgroundImage = My.Resources._03
            aero_dictionary.BackgroundImage = My.Resources._03
            alarmclock.BackgroundImage = My.Resources._03
            bigshow.BackgroundImage = My.Resources._03
            browser.BackgroundImage = My.Resources._03
            calc.BackgroundImage = My.Resources._03
            cclient.BackgroundImage = My.Resources._03
            clipmanager.BackgroundImage = My.Resources._03
            copyfile.BackgroundImage = My.Resources._03
            'CrawlingView.BackgroundImage = My.Resources._03
            cserve.BackgroundImage = My.Resources._03
            dancerladysetup.BackgroundImage = My.Resources._03
            dancersetup.BackgroundImage = My.Resources._03
            devices.BackgroundImage = My.Resources._03
            DJconsolePro.BackgroundImage = My.Resources._03
            emailer.BackgroundImage = My.Resources._03
            erasefile.BackgroundImage = My.Resources._03
            explorer.BackgroundImage = My.Resources._03
            externalprogs.BackgroundImage = My.Resources._03
            externalsetup.BackgroundImage = My.Resources._03
            filetransfer.BackgroundImage = My.Resources._03
            frmNameEntry.BackgroundImage = My.Resources._03
            'frmSetting.BackgroundImage = My.Resources._03
            frmSoundRecorder.BackgroundImage = My.Resources._03
            html.BackgroundImage = My.Resources._03
            iconssetup.BackgroundImage = My.Resources._03
            imgbrowser.BackgroundImage = My.Resources._03
            lanlist.BackgroundImage = My.Resources._03
            loginregister.BackgroundImage = My.Resources._03
            maps.BackgroundImage = My.Resources._03
            media.BackgroundImage = My.Resources._03
            mediacrawler.BackgroundImage = My.Resources._03
            meteocredits.BackgroundImage = My.Resources._03
            meteoform.BackgroundImage = My.Resources._03
            newimage.BackgroundImage = My.Resources._03
            newroot.BackgroundImage = My.Resources._03
            painter.BackgroundImage = My.Resources._03
            performance.BackgroundImage = My.Resources._03
            poker.BackgroundImage = My.Resources._03
            printlist.BackgroundImage = My.Resources._03
            resizeimage.BackgroundImage = My.Resources._03
            saveform.BackgroundImage = My.Resources._03
            screencapturer.BackgroundImage = My.Resources._03
            selectbck.BackgroundImage = My.Resources._03
            senderclient.BackgroundImage = My.Resources._03
            sendserver.BackgroundImage = My.Resources._03
            settings.BackgroundImage = My.Resources._03
            socialmanager.BackgroundImage = My.Resources._03
            speak.BackgroundImage = My.Resources._03
            stack.BackgroundImage = My.Resources._03
            startupmusic.BackgroundImage = My.Resources._03
            stegano.BackgroundImage = My.Resources._03
            Me.BackgroundImage = My.Resources._03
            usersadmin.BackgroundImage = My.Resources._03
            wifilist.BackgroundImage = My.Resources._03
            write.BackgroundImage = My.Resources._03
            zipper.BackgroundImage = My.Resources._03
            runwindows.BackgroundImage = My.Resources._03
            recent.BackgroundImage = My.Resources._03


            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources._03")
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
        aero.pausepanelmediabutton.ForeColor = Color.Black
        aero.playpanelmediabutton.ForeColor = Color.Black
        aero.Label2.ForeColor = Color.Black
        aero.Label3.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
        aero.Label4.ForeColor = Color.Black
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Meditation"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.meditate1
            aero.BackgroundImageLayout = ImageLayout.Stretch



            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.meditate1")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.stormplayer.URL = My.Settings.rootdir & "\Sounds\chillout.mp3"
        aero.stormplayer.settings.setMode("loop", True)
        aero.scpopenbutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Transparent
        aero.upbutton.BackColor = Color.Transparent
        aero.mutebutton.BackColor = Color.Transparent
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.White
        aero.iprocesslabel.ForeColor = Color.White
        aero.alarmbutton.BackColor = Color.Transparent
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White

    End Sub

    Private Sub thememanager_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Cosmo 1"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.Cosmo1
            aero.BackgroundImageLayout = ImageLayout.Stretch

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.Cosmo1")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.closepanelbutton.BackColor = Color.Transparent
        aero.scpopenbutton.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Transparent
        aero.upbutton.BackColor = Color.Transparent
        aero.mutebutton.BackColor = Color.Transparent
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.White
        aero.iprocesslabel.ForeColor = Color.White
        aero.alarmbutton.BackColor = Color.White
        aero.presentuser.ForeColor = Color.White
        aero.temperaturelabel.ForeColor = Color.White
        aero.Skylabel.ForeColor = Color.White
        aero.locationlabel.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.closepanelbutton.ForeColor = Color.White
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "DNA 1"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.dna1
            aero.BackgroundImageLayout = ImageLayout.Stretch

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.dna1")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.closepanelbutton.BackColor = Color.Transparent

        aero.scpopenbutton.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.officepanel.BackgroundImage = Nothing
        aero.mediapanel.BackgroundImage = Nothing
        aero.netpanel.BackgroundImage = Nothing
        aero.gamespanel.BackgroundImage = Nothing
        aero.systempanel.BackgroundImage = Nothing
        aero.menupanel01.BackgroundImage = Nothing
        aero.calendarpanel.BackgroundImage = Nothing
        aero.shortcutpanel.BackgroundImage = Nothing
        aero.downbutton.BackColor = Color.Transparent
        aero.upbutton.BackColor = Color.Transparent
        aero.mutebutton.BackColor = Color.Transparent
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.White
        aero.iprocesslabel.ForeColor = Color.White
        aero.alarmbutton.BackColor = Color.White
        aero.presentuser.ForeColor = Color.White
        aero.temperaturelabel.ForeColor = Color.White
        aero.Skylabel.ForeColor = Color.White
        aero.locationlabel.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.closepanelbutton.ForeColor = Color.White
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.themepresent = True
        My.Settings.Save()
        My.Settings.Reload()

        settings.Label11.Text = "Ra 1"
        settings.Label13.Text = "Desktop: Themepack"
        Try
            aero.BackgroundImage = My.Resources.ra1
            aero.BackgroundImageLayout = ImageLayout.Stretch

            Dim path As String = My.Settings.rootdir & "\users\" & loginregister.useridtext.Text & loginregister.passtext.Text & My.Settings.loggedrole & "\conf\" & "configuration.txt"
            Dim sw As StreamWriter
            sw = File.CreateText(path)
            sw.WriteLine("My.Resources.ra1")
            sw.Flush()
            sw.Close()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
        aero.wcustombutts.ForeColor = Color.White
        aero.wcustombuttssmall.ForeColor = Color.White
        aero.openaeromediaButton.ForeColor = Color.White
        aero.magbutton.ForeColor = Color.White
        aero.vmagbutton.ForeColor = Color.White
        aero.notesbutton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.dmopenbutton.ForeColor = Color.White
        aero.timelabel.ForeColor = Color.White
        aero.closepanelbutton.BackColor = Color.Transparent

        aero.scpopenbutton.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.grouplabel.ForeColor = Color.White

        aero.openpanelbutton.ForeColor = Color.White
        aero.openpanelbutton.BackColor = Color.Transparent
        aero.dmopenbutton.ForeColor = Color.White
        aero.stoppanelmediaButton.ForeColor = Color.White
        aero.hidepanelButton.ForeColor = Color.White
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
        aero.xlabel.ForeColor = Color.White
        aero.ylabel.ForeColor = Color.White
        aero.createiconbutton.ForeColor = Color.White
        aero.ipcbutton.ForeColor = Color.White
        aero.aeromenulabel.ForeColor = Color.White
        aero.calendarclosebutton.ForeColor = Color.White
        aero.inamelabel.ForeColor = Color.White
        aero.iprocesslabel.ForeColor = Color.White
        aero.alarmbutton.BackColor = Color.White
        aero.presentuser.ForeColor = Color.White
        aero.temperaturelabel.ForeColor = Color.White
        aero.Skylabel.ForeColor = Color.White
        aero.locationlabel.ForeColor = Color.White
        aero.scpclosebutton.ForeColor = Color.White
        aero.closepanelbutton.ForeColor = Color.White
        aero.pausepanelmediabutton.ForeColor = Color.White
        aero.playpanelmediabutton.ForeColor = Color.White
        aero.Label2.ForeColor = Color.White
        aero.Label3.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
        aero.Label4.ForeColor = Color.White
    End Sub
End Class