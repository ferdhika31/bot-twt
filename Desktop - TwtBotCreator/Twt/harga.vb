Public Class harga

    
    Private Sub btnOrder1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder1.Click
        System.Diagnostics.Process.Start("http://maker.hints.me")
    End Sub

    Private Sub btnOrder2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder2.Click
        System.Diagnostics.Process.Start("http://maker.hints.me")
    End Sub

    Private Sub btnOrder3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrder3.Click
        System.Diagnostics.Process.Start("https://www.facebook.com/messages/ferdhika31")
    End Sub

    Private Sub harga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Hide()
        login.TopMost = True
    End Sub
End Class