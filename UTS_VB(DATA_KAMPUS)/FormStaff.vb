Imports MySql.Data.MySqlClient

Public Class FormStaff

    'TextBox1 = tbKodeBarang
    'TextBox2 = tbNamaBarang
    'TextBox3 = tbHargaBarang
    'TextBox4 = tbStok
    'Button4 = btTambah
    'Button3 = btEdit
    'Button1 = btBatal
    'Button2 = btHapus

    Private Sub FormStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        modConnection.bukaDB()
        DA = New MySqlDataAdapter("SELECT * from staff", Conn)
        DS = New DataSet
        DA.Fill(DS, "staff")
        DataGridView1.DataSource = DS.Tables("staff")
        DataGridView1.ReadOnly = True

    End Sub

    Sub Bersih()

        tbNip.Text = ""
        tbNama.Text = ""
        tbDomisili.Text = ""
        cbAgama.Text = ""
        rbLaki.Checked = False
        rbPerempuan.Checked = False


        tbNip.Focus()
        ComboBox1.ResetText() 'tambahan
        tbNip.Enabled = True 'tambahan
        btTambah.Text = "Tambah"
    End Sub

    Sub isiCombo()
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nip From staff", Conn)
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
            Try
                Call bukaDB()
                CMD = New MySqlCommand("SELECT nip from staff WHERE nip = '" & tbNip.Text & "'", Conn)
                RD = CMD.ExecuteReader
                RD.Read()
                If RD.HasRows Then
                    MsgBox("Maaf, staff dengan NIP tersebut telah ada",
                    MsgBoxStyle.Exclamation, "Peringatan")
                Else
                    Call bukaDB()
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
        Call bukaDB()
        CMD = New MySqlCommand("SELECT nip, nama, domisili, agama, jenisKelamin FROM staff WHERE nip = '" & ComboBox1.Text & "'", Conn)
        RD = CMD.ExecuteReader
        RD.Read()
        If RD.HasRows Then

            tbNip.Text = RD.Item(0)
            tbNama.Text = RD.Item(1)
            tbDomisili.Text = RD.Item(2)
            cbAgama.Text = RD.Item(3)
            If RD.Item(4) = "L" Then
                rbLaki.Checked = True
            ElseIf RD.Item(4) = "P" Then
                rbPerempuan.Checked = True
            End If

            tbNip.Enabled = False
            tbNama.Focus()
        End If
    End Sub

    Private Sub btHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btHapus.Click

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
                .Parameters.Add("p5", MySqlDbType.String, 30).Value = hasil
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
