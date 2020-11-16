Public Class About

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        System.Diagnostics.Process.Start("http://twitter.com/FerdhikaYudira")
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        System.Diagnostics.Process.Start("http://facebook.com/Ferdhika31")
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub
End Class