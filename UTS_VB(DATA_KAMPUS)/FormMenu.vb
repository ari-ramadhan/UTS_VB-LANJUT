Public Class FormMenu

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click

        'Menampilkan pop-up konfirmasi Menutup Aplikasi saat Sub Menu File [Quit] ditekan
        Dim quit As DialogResult
        quit = MessageBox.Show("Yakin ingin keluar aplikasi ?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If quit = vbYes Then
            FormLogin.Close()
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click

        'Menampilkan pop-up konfirmasi Logout User saat Sub Menu [Logout] ditekan
        Dim logout As DialogResult
        logout = MessageBox.Show("Yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If logout = vbYes Then
            bukaDB()
            Me.Show()
            Me.DataMasterToolStripMenuItem.Visible = False
            Me.LogoutToolStripMenuItem.Visible = False
            Me.LoginToolStripMenuItem.Visible = True
        End If

    End Sub

    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click

        'Menutup FormMenu dan Membuka FormLogin saat tombol Login ditekan
        Me.Close()
        FormLogin.FormLogin_Load(sender, e)
        FormLogin.TextBox1.Text = ""
        FormLogin.TextBox2.Text = ""
        FormLogin.Opacity = 100
    End Sub

    Private Sub MahasiswaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MahasiswaToolStripMenuItem.Click

        'Menampilkan FormMahasiswa saat Sub Menu Master Data [Mahasiswa] ditekan
        FormMahasiswa.Show()
    End Sub

    Private Sub DosenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DosenToolStripMenuItem.Click

        'Menampilkan FormDosen saat Sub Menu Master Data [Dosen] ditekan
        FormDosen.Show()
    End Sub

    Private Sub StafToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StafToolStripMenuItem.Click

        ''Menampilkan FormStaff saat Sub Menu Master Data [Staff] ditekan
        FormStaff.Show()
    End Sub
End Class