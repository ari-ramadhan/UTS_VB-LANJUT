Imports MySql.Data.MySqlClient

Public Class FormStaff

    Private Sub FormStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'melakukan koneksi, mengisi data ke grid dan comboBox dari database
        Call bukaDB()
        Call isiGrid()
        Call isiCombo()

        'Setting Style dari DataGridView
        DataGridView1.RowHeadersVisible = False
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.OrangeRed
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        'Setting Header dari DataGridView (Nama tiap-tiap Header, Ukuran Panjang tiap-tiap Header)
        With DataGridView1
            With .Columns(0)
                .HeaderCell.Value = "NIP"
                .Width = 70
            End With
            With .Columns(1)
                .HeaderCell.Value = "Nama"
                .Width = 90
            End With
            With .Columns(2)
                .HeaderCell.Value = "Domisili"
                .Width = 110
            End With
            With .Columns(3)
                .HeaderCell.Value = "Agama"
                .Width = 70
            End With

            With .Columns(4)
                .HeaderCell.Value = "JK"
                .Width = 40
            End With
        End With
    End Sub

    Sub isiGrid()
        'Mempopulasi Grid dengan Data Staf yang ada pada database
        modConnection.bukaDB()
        DA = New MySqlDataAdapter("SELECT * from staff", Conn)
        DS = New DataSet
        DA.Fill(DS, "staff")
        DataGridView1.DataSource = DS.Tables("staff")
        DataGridView1.ReadOnly = True

    End Sub

    Sub Bersih()
        'Fungsi untuk mengosongkan semua textBox dan radioButton
        tbNip.Text = ""
        tbNama.Text = ""
        tbDomisili.Text = ""
        cbAgama.Text = ""
        rbLaki.Checked = False
        rbPerempuan.Checked = False

        tbNip.Focus()
        ComboBox1.ResetText()
        'Mengembalikan textbox Nim untuk bisa diakses lagi
        tbNip.Enabled = True
        btTambah.Text = "Tambah"
    End Sub

    Sub isiCombo()
        'Mengisi ComboBox sebanyak data yang ada pada Tabel Staf dengan atribut Nip yang ditampilkan
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nip From staff", Conn)
        RD = CMD.ExecuteReader
        ComboBox1.Items.Clear()
        Do While RD.Read
            ComboBox1.Items.Add(RD.Item(0))
        Loop
        CMD.Dispose()
        RD.Close()
        Conn.Close()
    End Sub
    Private Sub btTambah_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btTambah.Click
        'Menentukan Data Jenis Kelamin mana yang diinput tergantung dari RadioButton mana yang dipilih
        'Apakah Laki - Laki = L, atau Perempuan = P
        Dim hasil As String
        If rbLaki.Checked = True Then
            hasil = "L"
        ElseIf rbPerempuan.Checked = True Then
            hasil = "P"
        End If

        If btTambah.Text = "Tambah" Then
            btTambah.Text = "Simpan"
            tbNip.Focus()
        Else
            'Pengkondisian untuk menge-cek apakah nip staf tersedia di database / tidak. Lalu memperbolehkan
            'user untuk melakukan insert jika Nip tidak tersedia
            Try
                Call bukaDB()
                'Query Pengecekan ketersediaan Staf dengan patokan Nip
                CMD = New MySqlCommand("SELECT nip from staff WHERE nip = '" & tbNip.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    MsgBox("Maaf, staff dengan NIP tersebut telah ada",
                    MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call bukaDB()
                    'Query Insert pada tabel Staf
                    simpan = "INSERT INTO staff (nip, nama, domisili, agama, jenisKelamin) VALUES (?,?,?,?,?)"
                    CMD = Conn.CreateCommand
                    With CMD
                        .CommandText = simpan
                        .Connection = Conn
                        .Parameters.Add("p1", MySqlDbType.String, 10).Value = tbNip.Text
                        .Parameters.Add("p2", MySqlDbType.String, 30).Value = tbNama.Text
                        .Parameters.Add("p3", MySqlDbType.String, 30).Value = tbDomisili.Text
                        .Parameters.Add("p4", MySqlDbType.String, 30).Value = cbAgama.SelectedItem
                        .Parameters.Add("p5", MySqlDbType.String, 30).Value = hasil
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

        'Mengisi tiap tiap textBox dengan data staf yang dipilih Nip nya dari comboBox.
        'Diperlukan untuk melakukan Hapus / Ubah data
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nip, nama, domisili, agama, jenisKelamin FROM staff WHERE nip = '" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then

            tbNip.Text = RD.Item(0)
            tbNama.Text = RD.Item(1)
            tbDomisili.Text = RD.Item(2)
            cbAgama.Text = RD.Item(3)

            'Menentukan radioButton Jenis Kelamin yang akan terpilih secara otomatis dari data dosen yang dipilih dari ComboBox
            If RD.Item(4) = "L" Then
                rbLaki.Checked = True
            ElseIf RD.Item(4) = "P" Then
                rbPerempuan.Checked = True
            End If

            'Mematikan textBox Nip saat sebuah data dipilih dari comboBox agar fungsi Hapus & Ubah lebih optimal
            tbNip.Enabled = False
            tbNama.Focus()
        End If
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click

        'Melakukan hapus data saat tombol Hapus ditekan.
        'Sebelumnya harus melakukan pemilihan data dari comboBox yang nantinya akan mengisi textBox Nip
        'yang menjadi patokan penghapusan Data
        Try
            Call bukaDB()
            hapus = "DELETE FROM staff WHERE nip=@p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = hapus
                .Connection = Conn
                .Parameters.Add("p1", MySqlDbType.String, 4).Value = tbNip.Text
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

        'Menentukan Data Jenis Kelamin mana yang akan diupdate tergantung dari RadioButton mana yang dipilih
        'Apakah Laki - Laki = L, atau Perempuan = P
        Dim hasil As String
        If rbLaki.Checked = True Then
            hasil = "L"
        ElseIf rbPerempuan.Checked = True Then
            hasil = "P"
        End If

        Try
            Call bukaDB()
            ubah = "UPDATE staff SET nama = @p2, domisili = @p3, agama = @p4, jenisKelamin = @p5 WHERE nip = @p1"
            CMD = Conn.CreateCommand
            With CMD
                .CommandText = ubah
                .Connection = Conn

                .Parameters.Add("p1", MySqlDbType.Int32, 12).Value = tbNip.Text
                .Parameters.Add("p2", MySqlDbType.String, 30).Value = tbNama.Text
                .Parameters.Add("p3", MySqlDbType.String, 30).Value = tbDomisili.Text
                .Parameters.Add("p4", MySqlDbType.String, 30).Value = cbAgama.SelectedItem
                .Parameters.Add("p5", MySqlDbType.String, 30).Value = hasil 'Nilai hasil diambil dari radioButton jenis kelamin mana yang user pilih
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
