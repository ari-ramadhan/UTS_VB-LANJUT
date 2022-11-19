<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbTanggalLahir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTempatLahir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNim = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbHp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(412, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 33
        '
        'btHapus
        '
        Me.btHapus.Location = New System.Drawing.Point(524, 136)
        Me.btHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(50, 23)
        Me.btHapus.TabIndex = 32
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = True
        '
        'btBatal
        '
        Me.btBatal.Location = New System.Drawing.Point(253, 417)
        Me.btBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(50, 23)
        Me.btBatal.TabIndex = 31
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 280)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Tanggal Lahir"
        '
        'tbTanggalLahir
        '
        Me.tbTanggalLahir.Location = New System.Drawing.Point(159, 278)
        Me.tbTanggalLahir.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTanggalLahir.Name = "tbTanggalLahir"
        Me.tbTanggalLahir.Size = New System.Drawing.Size(145, 20)
        Me.tbTanggalLahir.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(43, 232)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Tempat Lahir"
        '
        'tbTempatLahir
        '
        Me.tbTempatLahir.Location = New System.Drawing.Point(159, 230)
        Me.tbTempatLahir.Margin = New System.Windows.Forms.Padding(2)
        Me.tbTempatLahir.Name = "tbTempatLahir"
        Me.tbTempatLahir.Size = New System.Drawing.Size(145, 20)
        Me.tbTempatLahir.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 184)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Nama Lengkap"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(158, 182)
        Me.tbNama.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(145, 20)
        Me.tbNama.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Nim"
        '
        'tbNim
        '
        Me.tbNim.Location = New System.Drawing.Point(158, 136)
        Me.tbNim.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNim.Name = "tbNim"
        Me.tbNim.Size = New System.Drawing.Size(145, 20)
        Me.tbNim.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(327, 182)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(676, 165)
        Me.DataGridView1.TabIndex = 22
        '
        'btTambah
        '
        Me.btTambah.Location = New System.Drawing.Point(159, 417)
        Me.btTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(62, 23)
        Me.btTambah.TabIndex = 21
        Me.btTambah.Text = "Tambah"
        Me.btTambah.UseVisualStyleBackColor = True
        '
        'btEdit
        '
        Me.btEdit.Location = New System.Drawing.Point(588, 136)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(50, 23)
        Me.btEdit.TabIndex = 20
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = True
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(158, 327)
        Me.tbAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(145, 20)
        Me.tbAlamat.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Alamat"
        '
        'tbHp
        '
        Me.tbHp.Location = New System.Drawing.Point(158, 377)
        Me.tbHp.Margin = New System.Windows.Forms.Padding(2)
        Me.tbHp.Name = "tbHp"
        Me.tbHp.Size = New System.Drawing.Size(145, 20)
        Me.tbHp.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 379)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nomor Handphone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(324, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Pilih Mahasiswa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 497)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbHp)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.tbTanggalLahir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTempatLahir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbNama)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNim)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.btEdit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbTanggalLahir As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNim As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbHp As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label

End Class
