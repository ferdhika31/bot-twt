Public Class pengaturan

    Private Sub profil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        btnTutup.Visible = False
        If My.Computer.Network.IsAvailable Then
            tsStat.ForeColor = Color.Lime
            tsStat.Text = "Tersambung"
            btnSelesai.Enabled = True
        Else
            tsStat.ForeColor = Color.Red
            tsStat.Text = "Tidak Tersambung"
            btnSelesai.Enabled = False
        End If
    End Sub


    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        System.Diagnostics.Process.Start("http://twitter.com/FerdhikaYudira")
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        About.Close()
        About.Show()
    End Sub

    Private Sub btnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelesai.Click
        main.lblNama.Text = txtNama.Text
        main.lblUrl.Text = txtUrl.Text
        main.lblLokasi.Text = txtLokasi.Text
        main.lblBio.Text = txtBio.Text
        main.lblAkun1.Text = txtUsername1.Text
        main.lblAkun2.Text = txtUsername2.Text
        main.lblTweet1.Text = txtTweet1.Text
        main.lblTweet2.Text = txtTweet2.Text
        If cbAuto.Checked = True Then
            main.cbAuto.Checked = True
            main.lblAuto.Text = "Auto"
        Else
            main.cbAuto.Checked = False
            main.lblAuto.Text = "Manual"
        End If
        Me.Hide()
        main.Show()
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1")
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Hide()
    End Sub

    Private Sub btnAtur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Me.Hide()
        main.Close()
        login.Show()
    End Sub

End Class