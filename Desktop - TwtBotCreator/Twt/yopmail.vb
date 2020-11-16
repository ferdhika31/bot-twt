Imports TwitteCreatebyLangit
Public Class yopmail

    Private Sub yopmail_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If WebBrowser1.Url.ToString = "http://www.yopmail.com/en" Then
                WebBrowser1.Document.GetElementById("login").Focus()
                SendKeys.Send("{ENTER}")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub yopmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://www.yopmail.com/en")
        'WebBrowser1.Document.GetElementById("login").SetAttribute("value", TextBox1.Text)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub WebBrowser1_DocumentCompleted_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        WebBrowser1.Document.GetElementById("login").SetAttribute("value", TextBox1.Text)
        If WebBrowser1.Url.ToString = "http://www.yopmail.com/en" Then
            WebBrowser1.Document.GetElementById("login").Focus()
            SendKeys.Send("{ENTER}")
        End If
    End Sub

    Private Sub btnMasuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class