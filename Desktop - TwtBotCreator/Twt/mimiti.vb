Imports MySql.Data.MySqlClient
Public Class mimiti
    Dim db As New MySql.Data.MySqlClient.MySqlConnection
    Sub opendb()
        Try
            db.ConnectionString = "server=localhost;uid=root;pwd=;database=langit"
            db.Open()
            Timer1.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try
    End Sub
    Private Sub mimiti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Call opendb()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If pb.Value < 100 Then
            loadtx.Text = "Twitter Akun Create Apps Ver 1.0 - Now Loading " & pb.Value & "%"
            If pb.Value = 2 Then
                komponen.Text = "Allah SWT"
            ElseIf pb.Value = 20 Then
                komponen.Text = "My Friend"
            ElseIf pb.Value = 40 Then
                komponen.Text = "Langit Developer"
            ElseIf pb.Value = 70 Then
                komponen.Text = "Cimahi Blackhat"
            ElseIf pb.Value = 90 Then
                komponen.Text = "You!"
            ElseIf pb.Value = 98 Then
                komponen.Text = "You!"
            End If
            pb.Value += 2
        ElseIf pb.Value = 100 Then
            Timer1.Stop()
            login.Show()
            Me.Hide()
        End If
    End Sub
End Class