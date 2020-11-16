Imports System.Threading
Public Class main
    Dim doc As HtmlDocument
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 1")
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
        WebBrowser1.Navigate("http://mobile.twitter.com/signup")
        btnLogout.Enabled = False
        btnEmail.Enabled = False
        Call baru()
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Call baru()
        btnLogout.Enabled = False
        btnSimpan.Enabled = False
        btnTambah.Enabled = False
        btnCopy.Enabled = False
        btnEmail.Enabled = False
    End Sub
    Sub baru()
        Dim Letters As New List(Of Integer)
        Dim a, b As String
        WebBrowser1.Navigate("http://mobile.twitter.com/signup")
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        Dim Rnd As New Random
        Dim SB As New System.Text.StringBuilder
        Dim Temp As Integer
        For count As Integer = 1 To 8
            Temp = Rnd.Next(0, Letters.Count)
            SB.Append(Chr(Letters(Temp)))
        Next
        'batas
        For gue As Integer = 48 To 57
            Letters.Add(gue)
        Next
        For gue As Integer = 97 To 122
            Letters.Add(gue)
        Next
        'uppercase letters
        For gue As Integer = 65 To 90
            Letters.Add(gue)
        Next
        Dim Rnd1 As New Random
        Dim SBX As New System.Text.StringBuilder
        Dim Temp1 As Integer
        For count As Integer = 1 To 3
            Temp1 = Rnd.Next(0, Letters.Count)
            SBX.Append(Chr(Letters(Temp)))
        Next
        'batas
        For i As Integer = 48 To 57
            Letters.Add(i)
        Next
        For i As Integer = 97 To 122
            Letters.Add(i)
        Next
        'uppercase letters
        For i As Integer = 65 To 90
            Letters.Add(i)
        Next
        Dim Rnda As New Random
        Dim SBa As New System.Text.StringBuilder
        Dim Tempa As Integer
        For count As Integer = 1 To 8
            Tempa = Rnda.Next(0, Letters.Count)
            SBa.Append(Chr(Letters(Temp)))
        Next
        a = "@yopmail.com"
        b = SB.ToString
        TextBox1.Text = SB.ToString
        TextBox2.Text = b + ("31") + a
        TextBox3.Text = SBX.ToString + "dika"
        txtIds.Text = TextBox1.Text + (":") + TextBox3.Text
    End Sub
    Sub email()
        yopmail.TextBox1.Text = TextBox1.Text + ("31@yopmail.com")
        yopmail.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        Call email()
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        Try
            WebBrowser1.Document.GetElementById("oauth_signup_client_fullname").SetAttribute("value", TextBox1.Text)
            WebBrowser1.Document.GetElementById("oauth_signup_client[phone_number]").SetAttribute("value", TextBox2.Text)
            WebBrowser1.Document.GetElementById("oauth_signup_client_password").SetAttribute("value", TextBox3.Text)
            WebBrowser1.Document.GetElementById("commit").Focus()
            WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnProf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProf.Click
        pengaturan.btnKeluar.Visible = False
        pengaturan.btnTutup.Visible = True
        pengaturan.Show()
    End Sub

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        lbHasil.Items.Add(txtIds.Text)
    End Sub
    Public Sub FadeFormIn()
        For FormOpacity As Decimal = 0D To 1D Step 0.02D
            copy.Opacity = FormOpacity
            copy.Refresh()
            Thread.Sleep(20)
        Next
    End Sub

    Public Sub FadeFormOut()
        For FormOpacity As Decimal = 1D To 0D Step -0.02D
            copy.Opacity = FormOpacity
            copy.Refresh()
            Thread.Sleep(20)
        Next
    End Sub
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        Try
            Dim s1 As String
            s1 = lbHasil.Text
            Clipboard.SetText(s1)
            copy.Show()
            Call FadeFormIn()
            Call FadeFormOut()
            copy.Close()
        Catch ex As Exception
            MsgBox("Pilih dulu yang mau di copy!", MsgBoxStyle.Critical, "Twitter Akun Create Apps Ver 1.0")
        End Try
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        sf1.InitialDirectory = "C:/"
        sf1.FileName = "Langit Maker Akun IDs.txt"
        sf1.Title = "Simpan Akun IDs..."
        sf1.Filter = ("text files (*.txt) | *.txt")
        sf1.ShowDialog()

        Dim w As New IO.StreamWriter(sf1.FileName)
        Dim i As Integer
        For i = 0 To lbHasil.Items.Count - 1
            w.WriteLine(lbHasil.Items(i).ToString)
        Next
        w.Close()
    End Sub

    Private Sub cbAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAuto.CheckedChanged
        If cbAuto.Checked = True Then
            WebBrowser1.Navigate("http://mobile.twitter.com/signup")
            lblAuto.Text = "Auto"
        Else
            WebBrowser1.Navigate("http://mobile.twitter.com/signup")
            lblAuto.Text = "Manual"
        End If
    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        End
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        About.Close()
        About.Show()
    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        'txtUrl.Text = WebBrowser1.Url.ToString
        txtUrl.Text = "http://langit.tk"
        lblProses.Text = "Silahkan klik tombol daftar/tunggu.."
        If lblAuto.Text = "Auto" Then
            Try
                WebBrowser1.Document.GetElementById("oauth_signup_client_fullname").SetAttribute("value", TextBox1.Text)
                WebBrowser1.Document.GetElementById("oauth_signup_client[phone_number]").SetAttribute("value", TextBox2.Text)
                WebBrowser1.Document.GetElementById("oauth_signup_client_password").SetAttribute("value", TextBox3.Text)
                WebBrowser1.Document.GetElementById("commit").Focus()
                WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
            Catch ex As Exception

            End Try
        End If
        If WebBrowser1.Url.ToString = "https://mobile.twitter.com/signup/screen_name" Then
            WebBrowser1.Document.GetElementById("commit").Focus()
            WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
            lblProses.Text = "Sedang mendaftarkan akun.."
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/welcome/intro" Then
            btnEmail.Enabled = True
            btnSimpan.Enabled = True
            btnCopy.Enabled = True
            btnTambah.Enabled = True
            'Memasukkan IDs
            lbHasil.Items.Add(txtIds.Text)
            'Tanya Verifikasi Email
            ' Dim a = MsgBox("Apakah anda akan memverifikasi email akun?", MsgBoxStyle.YesNo, "Konfirmasi")
            '  If a = MsgBoxResult.Yes Then
            '       yopmail.Close()
            'Call email()
            '  End If
            'Follow akun1
            lblProses.Text = "Sedang Follow Akun.."
            WebBrowser1.Navigate("https://mobile.twitter.com/" & lblAkun1.Text & "/follow")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/" & lblAkun1.Text & "/follow" Then
            WebBrowser1.Document.GetElementById("commit").Focus()
            WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/" & TextBox1.Text & "/following#" & lblAkun1.Text & "" Then
            'Follow akun2
            WebBrowser1.Navigate("https://mobile.twitter.com/" & lblAkun2.Text & "/follow")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/" & lblAkun2.Text & "/follow" Then
            WebBrowser1.Document.GetElementById("commit").Focus()
            WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/" & TextBox1.Text & "/following#" & lblAkun2.Text & "" Then
            lblProses.Text = "Sedang Membuat Tweet.."
            'Buat Tweet2
            WebBrowser1.Navigate("https://mobile.twitter.com/compose/tweet")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/compose/tweet" Then
            WebBrowser1.Document.GetElementById("tweet[Text]").SetAttribute("value", lblTweet2.Text)
            WebBrowser1.Document.GetElementById("commit").Focus()
            WebBrowser1.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser1.Url.ToString = "https://mobile.twitter.com/" Then
            'follow FerdhikaYudira
            WebBrowser2.Navigate("https://mobile.twitter.com/ferdhikayudira/follow")
        Else
            lblSelesai.ForeColor = Color.Orange
            lblSelesai.Text = "Dagoan.. Keur proses ngajieun.. :)"
        End If
    End Sub
    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted
        If WebBrowser2.Url.ToString = "https://mobile.twitter.com/ferdhikayudira/follow" Then
            WebBrowser2.Document.GetElementById("commit").Focus()
            WebBrowser2.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser2.Url.ToString = "https://mobile.twitter.com/" & TextBox1.Text & "/following#ferdhikayudira" Then
            lblProses.Text = "Sedang Mengubah Profil Akun.."
            'Edit Profil
            WebBrowser2.Navigate("https://mobile.twitter.com/settings/profile")
        ElseIf WebBrowser2.Url.ToString = "https://mobile.twitter.com/settings/profile" Then
            WebBrowser2.Document.GetElementById("settings[fullname]").SetAttribute("value", lblNama.Text)
            WebBrowser2.Document.GetElementById("settings[url]").SetAttribute("value", lblUrl.Text)
            WebBrowser2.Document.GetElementById("settings[location]").SetAttribute("value", lblLokasi.Text)
            WebBrowser2.Document.GetElementById("settings[description]").SetAttribute("value", lblBio.Text)
            WebBrowser2.Document.GetElementById("commit").Focus()
            WebBrowser2.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser2.Url.ToString = "https://mobile.twitter.com/settings" Then
            'Tweet 1
            WebBrowser2.Navigate("https://mobile.twitter.com/compose/tweet")
        ElseIf WebBrowser2.Url.ToString = "https://mobile.twitter.com/compose/tweet" Then
            WebBrowser2.Document.GetElementById("tweet[Text]").SetAttribute("value", lblTweet1.Text)
            WebBrowser2.Document.GetElementById("commit").Focus()
            WebBrowser2.Document.GetElementById("commit").InvokeMember("click")
        ElseIf WebBrowser2.Url.ToString = "https://mobile.twitter.com/" Then
            lblSelesai.ForeColor = Color.Lime
            lblSelesai.Text = "Selesai.."
            lblProses.ForeColor = Color.Lime
            lblProses.Text = "Silahkan logout.. :-)"
            ' yopmail.Close()
            btnLogout.Enabled = True
        Else

        End If
    End Sub
End Class
