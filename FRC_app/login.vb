Public Class login

    Public Property loginstat As Integer

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles Info.Click

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Info.Text = ""
        If loginstat = 0 Then
            Info.Text = "Login to continue"
        End If

    End Sub
End Class