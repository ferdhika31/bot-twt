Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class login
    Dim db As New MySql.Data.MySqlClient.MySqlConnection
    Dim perintah As MySqlCommand
    Dim baca As MySqlDataReader
    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            db.ConnectionString = "server=db4free.net;port=3306; user id=ferdhika31; pwd=bandung0; database=makertwt; Connect Timeout=60;Encrypt=true"
            db.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub
    Sub langit()
        perintah = New MySqlCommand("select * from akun where user='" & txtUser.Text & "' and pass='" & txtPass.Text & "'", db)
        baca = perintah.ExecuteReader()
        If baca.Read Then
            Dim versi As String = 1.0 'change versi
            perintah = New MySqlCommand("select * from pengaturan where versi='" & versi & "'", db)
            baca = perintah.ExecuteReader()
            If baca.Read Then
                pengaturan.Text = "Twitter Akun Create Apps Ver " & versi
                main.Text = "Twitter Akun Create Apps Ver " & versi
                About.Text = "Twitter Akun Create Apps Ver " & versi & " - About"
                harga.Text = "Twitter Akun Create Apps Ver " & versi & " - Harga Akun"
                yopmail.Text = "Twitter Akun Create Apps Ver " & versi & " - Verifikasi Email Akun"
            Else
                MsgBox("Mau update sekarang?", MsgBoxStyle.YesNo, "Ada program baru,silahkan update..")
                pengaturan.Text = "Twitter Akun Create Apps Ver " & versi
                main.Text = "Twitter Akun Create Apps Ver " & versi
                About.Text = "Twitter Akun Create Apps Ver " & versi & " - About"
                harga.Text = "Twitter Akun Create Apps Ver " & versi & " - Harga Akun"
                yopmail.Text = "Twitter Akun Create Apps Ver " & versi & " - Verifikasi Email Akun"
            End If
        End If
    End Sub
    Private Sub btnEx_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEx.Click
        End
    End Sub
    Sub kedip()
        For a = 20 To 0 Step -1
            Me.Opacity = a / 20
            Me.Refresh()
        Next
        For a = 0 To 20 Step +1
            Me.Opacity = a / 20
            Me.Refresh()
        Next
    End Sub
    Sub tglts()
        Dim dates As String
        dates = Format(Now, "dd MMMM yyyy")
        lblTgl.Text = dates
    End Sub
    Sub logins()
        db.Close()
        db.Open()
        If txtUser.Text = "" Then
            MsgBox("Username tidak boleh kosong!", MsgBoxStyle.Critical, "Twitter Akun Create Apps Ver 1.0")
            kedip()
        ElseIf txtPass.Text = "" Then
            MsgBox("Password tidak boleh kosong!", MsgBoxStyle.Critical, "Twitter Akun Create Apps Ver 1.0")
            kedip()
        Else
            perintah = New MySqlCommand("select * from akun where user='" & txtUser.Text & "' and pass='" & txtPass.Text & "'", db)
            baca = perintah.ExecuteReader()
            If baca.Read Then
                If baca(4) = "Premium" Then
                    Call tglts()
                    Dim id
                    id = baca(0)
                    If baca(8) = lblTgl.Text Then
                        db.Close()
                        db.Open()
                        perintah = New MySqlCommand("update akun set status='Tidak Aktif' where id='" & id & "'", db)
                        perintah.ExecuteNonQuery()
                        MsgBox("Akun expired!", MsgBoxStyle.Critical, "Expired")
                    Else
                        If baca(5) = "Aktif" Then
                            MsgBox("Anda Login Sebagai Akun Premium", MsgBoxStyle.Information, "Selamat Datang!")
                            System.Console.Beep(1000, 100)
                            pengaturan.lblNama.Text = baca(3)
                            pengaturan.lblAkunStat.Text = baca(4)
                            pengaturan.txtUsername2.Text = baca(6)
                            pengaturan.lblAkunStat.ForeColor = Color.Lime
                            pengaturan.cbAuto.Enabled = True
                            pengaturan.txtNama.Enabled = True
                            pengaturan.txtUrl.Enabled = True
                            pengaturan.txtBio.Enabled = True
                            pengaturan.txtLokasi.Enabled = True
                            main.cbAuto.Enabled = True
                            pengaturan.Show()
                            Me.Hide()
                        End If
                    End If
                ElseIf baca(4) = "Biasa" Then
                    Call tglts()
                    Dim id
                    id = baca(0)
                    If baca(8) = lblTgl.Text Then
                        db.Close()
                        db.Open()
                        perintah = New MySqlCommand("update akun set status='Tidak Aktif' where id='" & id & "'", db)
                        perintah.ExecuteNonQuery()
                        MsgBox("Akun expired!", MsgBoxStyle.Critical, "Expired")
                    Else
                        If baca(5) = "Aktif" Then
                            MsgBox("Anda Login Sebagai Akun Biasa", MsgBoxStyle.Information, "Selamat Datang!")
                            System.Console.Beep(1000, 100)
                            pengaturan.lblNama.Text = baca(3)
                            pengaturan.lblAkunStat.Text = baca(4)
                            pengaturan.txtUsername2.Text = baca(6)
                            pengaturan.lblAkunStat.ForeColor = Color.Orange
                            pengaturan.txtTweet2.Enabled = True
                            pengaturan.txtUsername2.Enabled = True
                            pengaturan.Show()
                            Me.Hide()
                        Else
                            MsgBox("Akun expired!", MsgBoxStyle.Critical, "Expired")
                        End If
                    End If
                ElseIf baca(4) = "Trial" Then
                    Call tglts()
                    Dim id
                    id = baca(0)
                    If baca(8) = lblTgl.Text Then
                        db.Close()
                        db.Open()
                        perintah = New MySqlCommand("update akun set status='Tidak Aktif' where id='" & id & "'", db)
                        perintah.ExecuteNonQuery()
                        MsgBox("Akun expired!", MsgBoxStyle.Critical, "Expired")
                    Else
                        If baca(5) = "Aktif" Then
                            MsgBox("Anda Login Sebagai Akun Trial", MsgBoxStyle.Information, "Selamat Datang!")
                            System.Console.Beep(1000, 100)
                            pengaturan.lblNama.Text = baca(3)
                            pengaturan.lblAkunStat.Text = baca(4)
                            pengaturan.txtUsername2.Text = baca(6)
                            pengaturan.txtUsername2.Enabled = False
                            pengaturan.lblAkunStat.ForeColor = Color.Red
                            pengaturan.txtTweet2.Enabled = False
                            pengaturan.Show()
                            Me.Hide()
                        End If
                    End If
                Else
                    MsgBox("Tidak ada hak akses!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Username atau Password salah!", MsgBoxStyle.Critical, "Twitter Akun Create Apps Ver 1.0")
                kedip()
            End If
        End If
    End Sub
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Call logins()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        System.Diagnostics.Process.Start("http://facebook.com/Ferdhika31")
    End Sub

    Private Sub btnUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        Me.TopMost = False
        harga.Close()
        harga.Show()
    End Sub

    Private Sub txtUser_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtUser.MouseClick
        txtUser.Text = ""
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPass.KeyPress
        If e.KeyChar = ChrW(13) Then
            Call logins()
        End If
    End Sub

    Private Sub txtPass_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtPass.MouseClick
        txtPass.Text = ""
    End Sub

End Class