Imports MySql.Data.MySqlClient

Module modConnection

    Public Conn As MySqlConnection
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public CMD As MySqlCommand
    Public DS As DataSet
    Public simpan, ubah, hapus As String

    Public Sub bukaDB()
        Dim SQLconn As String
        SQLconn = "server=localhost;Uid=root;Pwd=;Database=app_kampus"
        Conn = New MySqlConnection(SQLconn)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

End Module
