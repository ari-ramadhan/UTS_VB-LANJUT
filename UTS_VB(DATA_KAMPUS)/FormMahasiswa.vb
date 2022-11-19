Imports MySql.Data.MySqlClient

Public Class FormMahasiswa

    'TextBox1 = tbKodeBarang
    'TextBox2 = tbNamaBarang
    'TextBox3 = tbHargaBarang
    'TextBox4 = tbStok
    'Button4 = btTambah
    'Button3 = btEdit
    'Button1 = btBatal
    'Button2 = btHapus

    Private Sub FormMahasiswa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaDB()
        Call isiGrid()
        Call isiCombo()

        DataGridView1.RowHeadersVisible = False
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Azure
        ''If tbKodeBarang.Text = String.Empty Then 'tambahan
        ''    btHapus.Enabled = False 'tambahan
        ''Else
        ''    btHapus.Enabled = True 'tambahan
        ''End If    
        With DataGridView1
            With .Columns(0)
                .HeaderCell.Value = "NIM"
                .Width = 70
            End With
            With .Columns(1)
                .HeaderCell.Value = "Nama"
                .Width = 90
            End With
            With .Columns(2)
                .HeaderCell.Value = "Tempat Lahir"
                .Width = 110
            End With
            With .Columns(3)
                .HeaderCell.Value = "Tanggal Lahir"
                .Width = 110
            End With

            With .Columns(4)
                .HeaderCell.Value = "Alamat"
                .Width = 190
            End With

            With .Columns(5)
                .HeaderCell.Value = "Handphone"
                .Width = 86
            End With
        End With
    End Sub

    Sub isiGrid()
        modConnection.bukaDB()
        DA = New MySqlDataAdapter("SELECT * from mahasiswa", Conn)
        DS = New DataSet
        DA.Fill(DS, "mahasiswa")
        DataGridView1.DataSource = DS.Tables("mahasiswa")
        DataGridView1.ReadOnly = True

    End Sub

    Sub Bersih()

        tbNim.Text = ""
        tbNama.Text = ""
        tbTempatLahir.Text = ""
        dateLahir.Text = DateAndTime.Now()
        tbAlamat.Text = ""
        tbHp.Text = ""

        tbNim.Focus()
        ComboBox1.ResetText() 'tambahan
        tbNim.Enabled = True 'tambahan
        btTambah.Text = "Tambah"
    End Sub

    Sub isiCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nim From mahasiswa", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            'Dim nb As String 'tambahan

            'nb = "(" & RD.Item(0) & ") " & RD.Item(1) 'tambahan

            'ComboBox1.Items.Add(nb) 'tambahan
            ComboBox1.Items.Add(RD.Item(0))

        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub
    Private Sub btTambah_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        If btTambah.Text = "Tambah" Then
            btTambah.Text = "Simpan"
            tbNim.Focus()
        Else
            Try
                Call bukaDB()
                CMD = New MySqlCommand("SELECT nim from mahasiswa WHERE nim = '" & tbNim.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    MsgBox("Maaf, Mahasiswa dengan NIM tersebut telah ada",
                    MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call bukaDB()
                    simpan = "INSERT INTO mahasiswa (nim, nama, tempatLahir, tanggalLahir, alamat, noHp) VALUES (?,?,?,?,?,?)"
                    CMD = Conn.CreateCommand
                    With CMD
                        .CommandText = simpan
                        .Connection = Conn
                        .Parameters.Add("p1", MySqlDbType.String, 10).Value = tbNim.Text
                        .Parameters.Add("p2", MySqlDbType.String, 30).Value = tbNama.Text
                        .Parameters.Add("p3", MySqlDbType.String, 30).Value = tbTempatLahir.Text
                        .Parameters.Add("p4", MySqlDbType.String, 30).Value = dateLahir.Text.ToString
                        .Parameters.Add("p5", MySqlDbType.String, 30).Value = tbAlamat.Text
                        .Parameters.Add("p6", MySqlDbType.String, 12).Value = tbHp.Text
                        .ExecuteNonQuery()
                    End With
                    Call isiGrid()
                    Call Bersih()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
            End Try
        End If
        Call bukaDB() 'tambahan
        Call isiCombo() 'tambahan
    End Sub

    Private Sub btBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBatal.Click
        Call Bersih()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nim, nama, tempatLahir, tanggalLahir, alamat, noHp FROM mahasiswa WHERE nim = '" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then

            tbNim.Text = RD.Item(0)
            tbNama.Text = RD.Item(1)
            tbTempatLahir.Text = RD.Item(2)
            dateLahir.Text = RD.Item(3)
            tbAlamat.Text = RD.Item(4)
            tbHp.Text = RD.Item(5)

            tbNim.Enabled = False
            tbNama.Focus()
        End If
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click

        Try
            Call bukaDB()
            hapus = "DELETE FROM mahasiswa WHERE nim=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.String, 4).Value = tbNim.Text
                .ExecuteNonQuery()
            End With
            Call Bersih()
            Call isiGrid()
            Call isiCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try

    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        Try
            Call bukaDB()
            ubah = "UPDATE mahasiswa SET nama = @p2, tempatLahir = @p3, tanggalLahir = @p4, alamat = @p5, noHp = @p6 WHERE nim = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn

                .Parameters.Add("p1", MySqlDbType.Int32, 10).Value = tbNim.Text
                .Parameters.Add("p2", MySqlDbType.String, 30).Value = tbNama.Text
                .Parameters.Add("p3", MySqlDbType.String, 30).Value = tbTempatLahir.Text
                .Parameters.Add("p4", MySqlDbType.String, 30).Value = dateLahir.Text.ToString
                .Parameters.Add("p5", MySqlDbType.String, 30).Value = tbAlamat.Text
                .Parameters.Add("p6", MySqlDbType.String, 12).Value = tbHp.Text
                .ExecuteNonQuery()
            End With
            Call Bersih()
            Call isiGrid()
            Call isiCombo()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical, "Terjadi Kesalahan")
        End Try

    End Sub


End Class
