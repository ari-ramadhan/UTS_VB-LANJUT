Imports MySql.Data.MySqlClient

Public Class FormLogin

    'Fungsi untuk menonaktifkan akses pada FormMenu, akan digunakan saat memblok user yang belum login
    Public Sub tutupAkses()
        FormMenu.Enabled = False
        FormMenu.DataMasterToolStripMenuItem.Visible = False
    End Sub

    'Fungsi untuk mengaktifkan akses pada form menu, akan dipanggil untuk membolehkan user yang sudah login
    'untuk mengakses FormMenu
    Public Sub bukaAkses()
        FormMenu.Enabled = True
        FormMenu.DataMasterToolStripMenuItem.Visible = True
    End Sub

    Public Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bukaDB()
        FormMenu.Visible = False
        Call tutupAkses()

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim myAdapter As New MySqlDataAdapter

        'Query Pengecekan ketersediaan user
        Dim sqlQuery = "SELECT * FROM user WHERE username = '" + TextBox1.Text + "' AND password = '" + TextBox2.Text + "'"

        Dim myCommand As New MySqlCommand
        myCommand.Connection = Conn
        myCommand.CommandText = sqlQuery

        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()

        'Pengkondisian untuk menge-cek apakah user & password tersedia didatabase / tidak. Lalu memperbolehkan
        'akses kepada FormMenu jika user berhasil login
        If myData.HasRows = 0 Then
            MsgBox("Username dan Password salah!", MsgBoxStyle.Exclamation, "Error Login")
            bukaDB()
        Else
            MsgBox("Login berhasil, Selamat Datang " & TextBox1.Text & "!", MsgBoxStyle.Information, "Successfull Login")
            FormMenu.Show()
            bukaAkses()
            Me.Opacity = 0
            FormMenu.LoginToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        'Tutup form login saat tombol Batal diklik
        Me.Close()
    End Sub
End Class
