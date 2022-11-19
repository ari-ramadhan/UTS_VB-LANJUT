Imports MySql.Data.MySqlClient

Public Class FormLogin

    Public Sub tutupAkses()
        FormMenu.Enabled = False
        FormMenu.DataMasterToolStripMenuItem.Visible = False
    End Sub

    Public Sub bukaAkses()
        FormMenu.Enabled = True
        FormMenu.DataMasterToolStripMenuItem.Visible = True
    End Sub

    Public Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bukaDB()
        FormMenu.Visible = False
        Call tutupAkses()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myAdapter As New MySqlDataAdapter

        Dim sqlQuery = "SELECT * FROM user WHERE username = '" + TextBox1.Text + "' AND password = '" + TextBox2.Text + "'"

        Dim myCommand As New MySqlCommand
        myCommand.Connection = Conn
        myCommand.CommandText = sqlQuery

        myAdapter.SelectCommand = myCommand
        Dim myData As MySqlDataReader
        myData = myCommand.ExecuteReader()

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
