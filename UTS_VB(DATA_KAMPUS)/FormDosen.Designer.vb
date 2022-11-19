<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDosen))
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.cbAgama = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.btHapus = New System.Windows.Forms.Button()
        Me.btBatal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNip = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btTambah = New System.Windows.Forms.Button()
        Me.btEdit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.BackColor = System.Drawing.Color.Tan
        Me.rbPerempuan.Location = New System.Drawing.Point(240, 363)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbPerempuan.TabIndex = 88
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = False
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.BackColor = System.Drawing.Color.Tan
        Me.rbLaki.Location = New System.Drawing.Point(164, 363)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(70, 17)
        Me.rbLaki.TabIndex = 87
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki - laki"
        Me.rbLaki.UseVisualStyleBackColor = False
        '
        'cbAgama
        '
        Me.cbAgama.FormattingEnabled = True
        Me.cbAgama.Items.AddRange(New Object() {"Islam", "Hindu", "Katolik", "Protestan", "Buddha"})
        Me.cbAgama.Location = New System.Drawing.Point(163, 266)
        Me.cbAgama.Name = "cbAgama"
        Me.cbAgama.Size = New System.Drawing.Size(144, 21)
        Me.cbAgama.TabIndex = 86
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Tan
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Location = New System.Drawing.Point(45, 122)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(817, 13)
        Me.Label9.TabIndex = 82
        Me.Label9.Text = "_________________________________________________________________________________" & _
            "______________________________________________________"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Tan
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(199, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(277, 82)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(86, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Tan
        Me.Label7.Location = New System.Drawing.Point(329, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Pilih Dosen"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(417, 172)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(97, 21)
        Me.ComboBox1.TabIndex = 80
        '
        'btHapus
        '
        Me.btHapus.BackColor = System.Drawing.SystemColors.Control
        Me.btHapus.Location = New System.Drawing.Point(599, 171)
        Me.btHapus.Margin = New System.Windows.Forms.Padding(2)
        Me.btHapus.Name = "btHapus"
        Me.btHapus.Size = New System.Drawing.Size(50, 23)
        Me.btHapus.TabIndex = 79
        Me.btHapus.Text = "Hapus"
        Me.btHapus.UseVisualStyleBackColor = False
        '
        'btBatal
        '
        Me.btBatal.BackColor = System.Drawing.SystemColors.Control
        Me.btBatal.Location = New System.Drawing.Point(251, 399)
        Me.btBatal.Margin = New System.Windows.Forms.Padding(2)
        Me.btBatal.Name = "btBatal"
        Me.btBatal.Size = New System.Drawing.Size(50, 23)
        Me.btBatal.TabIndex = 78
        Me.btBatal.Text = "Batal"
        Me.btBatal.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Tan
        Me.Label5.Location = New System.Drawing.Point(47, 365)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Tan
        Me.Label4.Location = New System.Drawing.Point(47, 269)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Agama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Tan
        Me.Label3.Location = New System.Drawing.Point(47, 316)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 75
        Me.Label3.Text = "Alamat"
        '
        'tbAlamat
        '
        Me.tbAlamat.Location = New System.Drawing.Point(163, 314)
        Me.tbAlamat.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAlamat.Name = "tbAlamat"
        Me.tbAlamat.Size = New System.Drawing.Size(145, 20)
        Me.tbAlamat.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 219)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Nama Lengkap"
        '
        'tbNama
        '
        Me.tbNama.Location = New System.Drawing.Point(163, 217)
        Me.tbNama.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNama.Name = "tbNama"
        Me.tbNama.Size = New System.Drawing.Size(145, 20)
        Me.tbNama.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "NIP"
        '
        'tbNip
        '
        Me.tbNip.Location = New System.Drawing.Point(163, 171)
        Me.tbNip.Margin = New System.Windows.Forms.Padding(2)
        Me.tbNip.Name = "tbNip"
        Me.tbNip.Size = New System.Drawing.Size(145, 20)
        Me.tbNip.TabIndex = 70
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(332, 218)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(533, 204)
        Me.DataGridView1.TabIndex = 69
        '
        'btTambah
        '
        Me.btTambah.BackColor = System.Drawing.SystemColors.Control
        Me.btTambah.Location = New System.Drawing.Point(156, 399)
        Me.btTambah.Margin = New System.Windows.Forms.Padding(2)
        Me.btTambah.Name = "btTambah"
        Me.btTambah.Size = New System.Drawing.Size(62, 23)
        Me.btTambah.TabIndex = 68
        Me.btTambah.Text = "Tambah"
        Me.btTambah.UseVisualStyleBackColor = False
        '
        'btEdit
        '
        Me.btEdit.BackColor = System.Drawing.SystemColors.Control
        Me.btEdit.Location = New System.Drawing.Point(533, 171)
        Me.btEdit.Margin = New System.Windows.Forms.Padding(2)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(50, 23)
        Me.btEdit.TabIndex = 67
        Me.btEdit.Text = "Edit"
        Me.btEdit.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(135, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 126)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 84
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.tbNama)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tbNip)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(902, 476)
        Me.Panel1.TabIndex = 89
        '
        'FormDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 459)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.cbAgama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.btHapus)
        Me.Controls.Add(Me.btBatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbAlamat)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btTambah)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FormDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDosen"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Private WithEvents cbAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btHapus As System.Windows.Forms.Button
    Friend WithEvents btBatal As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNip As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btTambah As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
