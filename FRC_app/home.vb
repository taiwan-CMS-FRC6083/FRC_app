Imports MySql.Data.MySqlClient

Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login_button.Click
        Dim login As login
        login = New login()
        login.Show()


    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles login_button.MouseEnter
        'login_button.Cursor = Cursors.No
        'login_button.Text = "Not avliable"

    End Sub

    'MySQL

    Dim myConnectionString As String
    Dim oTable As Data.DataTable
    Dim oDbAdapter As MySqlDataAdapter

    Public Sub mysql()
        myConnectionString = "server=sql6.freemysqlhosting.net;" _
                      & "uid=sql6115059;" _
                      & "pwd=J81PZFkQ23;" _
                      & "port=3306;" _
                      & "database=sql6115059;"

        Dim oConn As New MySql.Data.MySqlClient.MySqlConnection(myConnectionString)
        Try
            oConn.Open()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

        oDbAdapter = New MySqlDataAdapter("SELECT * FROM help_keyword", oConn)




    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        mysql()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        login.loginstat = 0
    End Sub
End Class
