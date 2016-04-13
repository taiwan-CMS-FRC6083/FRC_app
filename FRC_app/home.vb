Imports MySql.Data.MySqlClient

Public Class home
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles login.Click


    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles login.MouseEnter
        login.Cursor = Cursors.No
        login.Text = "Not avliable"

    End Sub

    'MySQL

    Public KDBconn As New MySqlConnection
    Public KDBconnBackUp As New MySqlConnection
    Public KDBconnLib As New MySqlConnection
    Public Sub GetKDBConn()
        Dim connString As String = "Database=otgoo_17765387_app;Data Source=sql112.clouds.twgogo.org;User Id=otgoo_17765387;Password=frc6083;CharSet=utf8"

        Dim tmpSql As String
        If KDBconn.State = ConnectionState.Open Then KDBconn.Close() '若第二次重複連線需關閉
        KDBconn = New MySqlConnection(connString)
        KDBconn.Open()

        If KDBconn Is Nothing Then
            If connString = "" Then
                MsgBox("未設定連線字串" & connString)
            Else
                KDBconn = New MySqlConnection(connString)
                KDBconn.Open() '"正常連結資料庫"
                MsgBox("ok")
            End If
        Else
        End If
        If KDBconn Is Nothing Then MsgBox("MYSQL資料庫連線失敗")
    End Sub

    Public Sub mysql()
        Dim myConnectionString As String
        Dim oTable As Data.DataTable
        Dim oDbAdapter As MySqlDataAdapter

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
End Class
