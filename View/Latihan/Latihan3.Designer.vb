<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihan3
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
        Me.label_NIP = New System.Windows.Forms.Label()
        Me.label_Nama = New System.Windows.Forms.Label()
        Me.label_Jabatan = New System.Windows.Forms.Label()
        Me.label_TanggalLahir = New System.Windows.Forms.Label()
        Me.label_TempatLahir = New System.Windows.Forms.Label()
        Me.group_PerhitunganGaji = New System.Windows.Forms.GroupBox()
        Me.cb_Bulan = New System.Windows.Forms.ComboBox()
        Me.field_GajiBersih = New System.Windows.Forms.TextBox()
        Me.field_Pajak = New System.Windows.Forms.TextBox()
        Me.field_Potongan = New System.Windows.Forms.TextBox()
        Me.field_Tunjangan = New System.Windows.Forms.TextBox()
        Me.field_Izin = New System.Windows.Forms.TextBox()
        Me.field_TanpaKeterangan = New System.Windows.Forms.TextBox()
        Me.field_Sakit = New System.Windows.Forms.TextBox()
        Me.field_HariKerja = New System.Windows.Forms.TextBox()
        Me.field_GajiPokok = New System.Windows.Forms.TextBox()
        Me.label_GajiBersih = New System.Windows.Forms.Label()
        Me.label_Pajak = New System.Windows.Forms.Label()
        Me.label_Potongan = New System.Windows.Forms.Label()
        Me.label_Tunjangan = New System.Windows.Forms.Label()
        Me.label_Izin = New System.Windows.Forms.Label()
        Me.label_TanpaKet = New System.Windows.Forms.Label()
        Me.label_Sakit = New System.Windows.Forms.Label()
        Me.label_HariKerja = New System.Windows.Forms.Label()
        Me.label_GajiPokok = New System.Windows.Forms.Label()
        Me.label_Bulan = New System.Windows.Forms.Label()
        Me.field_NIP = New System.Windows.Forms.TextBox()
        Me.field_Nama = New System.Windows.Forms.TextBox()
        Me.cb_Jabatan = New System.Windows.Forms.ComboBox()
        Me.field_TempatLahir = New System.Windows.Forms.TextBox()
        Me.button_HitungGaji = New System.Windows.Forms.Button()
        Me.button_TambahData = New System.Windows.Forms.Button()
        Me.button_Hapus = New System.Windows.Forms.Button()
        Me.button_Keluar = New System.Windows.Forms.Button()
        Me.group_DataKepegawaian = New System.Windows.Forms.GroupBox()
        Me.field_TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.group_PerhitunganGaji.SuspendLayout()
        Me.group_DataKepegawaian.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_NIP
        '
        Me.label_NIP.AutoSize = True
        Me.label_NIP.Location = New System.Drawing.Point(32, 32)
        Me.label_NIP.Name = "label_NIP"
        Me.label_NIP.Size = New System.Drawing.Size(29, 16)
        Me.label_NIP.TabIndex = 0
        Me.label_NIP.Text = "NIP"
        '
        'label_Nama
        '
        Me.label_Nama.AutoSize = True
        Me.label_Nama.Location = New System.Drawing.Point(32, 69)
        Me.label_Nama.Name = "label_Nama"
        Me.label_Nama.Size = New System.Drawing.Size(44, 16)
        Me.label_Nama.TabIndex = 1
        Me.label_Nama.Text = "Nama"
        '
        'label_Jabatan
        '
        Me.label_Jabatan.AutoSize = True
        Me.label_Jabatan.Location = New System.Drawing.Point(32, 111)
        Me.label_Jabatan.Name = "label_Jabatan"
        Me.label_Jabatan.Size = New System.Drawing.Size(56, 16)
        Me.label_Jabatan.TabIndex = 2
        Me.label_Jabatan.Text = "Jabatan"
        '
        'label_TanggalLahir
        '
        Me.label_TanggalLahir.AutoSize = True
        Me.label_TanggalLahir.Location = New System.Drawing.Point(309, 32)
        Me.label_TanggalLahir.Name = "label_TanggalLahir"
        Me.label_TanggalLahir.Size = New System.Drawing.Size(90, 16)
        Me.label_TanggalLahir.TabIndex = 3
        Me.label_TanggalLahir.Text = "Tanggal Lahir"
        '
        'label_TempatLahir
        '
        Me.label_TempatLahir.AutoSize = True
        Me.label_TempatLahir.Location = New System.Drawing.Point(309, 69)
        Me.label_TempatLahir.Name = "label_TempatLahir"
        Me.label_TempatLahir.Size = New System.Drawing.Size(86, 16)
        Me.label_TempatLahir.TabIndex = 4
        Me.label_TempatLahir.Text = "Tempat Lahir"
        '
        'group_PerhitunganGaji
        '
        Me.group_PerhitunganGaji.Controls.Add(Me.cb_Bulan)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_GajiBersih)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_Pajak)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_Potongan)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_Tunjangan)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_Izin)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_TanpaKeterangan)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_Sakit)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_HariKerja)
        Me.group_PerhitunganGaji.Controls.Add(Me.field_GajiPokok)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_GajiBersih)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Pajak)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Potongan)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Tunjangan)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Izin)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_TanpaKet)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Sakit)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_HariKerja)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_GajiPokok)
        Me.group_PerhitunganGaji.Controls.Add(Me.label_Bulan)
        Me.group_PerhitunganGaji.Location = New System.Drawing.Point(47, 185)
        Me.group_PerhitunganGaji.Name = "group_PerhitunganGaji"
        Me.group_PerhitunganGaji.Size = New System.Drawing.Size(524, 333)
        Me.group_PerhitunganGaji.TabIndex = 5
        Me.group_PerhitunganGaji.TabStop = False
        Me.group_PerhitunganGaji.Text = "Perhitungan Gaji"
        '
        'cb_Bulan
        '
        Me.cb_Bulan.FormattingEnabled = True
        Me.cb_Bulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.cb_Bulan.Location = New System.Drawing.Point(129, 95)
        Me.cb_Bulan.Name = "cb_Bulan"
        Me.cb_Bulan.Size = New System.Drawing.Size(134, 24)
        Me.cb_Bulan.TabIndex = 26
        '
        'field_GajiBersih
        '
        Me.field_GajiBersih.Location = New System.Drawing.Point(380, 196)
        Me.field_GajiBersih.Name = "field_GajiBersih"
        Me.field_GajiBersih.Size = New System.Drawing.Size(131, 22)
        Me.field_GajiBersih.TabIndex = 25
        '
        'field_Pajak
        '
        Me.field_Pajak.Location = New System.Drawing.Point(380, 144)
        Me.field_Pajak.Name = "field_Pajak"
        Me.field_Pajak.Size = New System.Drawing.Size(131, 22)
        Me.field_Pajak.TabIndex = 24
        '
        'field_Potongan
        '
        Me.field_Potongan.Location = New System.Drawing.Point(380, 95)
        Me.field_Potongan.Name = "field_Potongan"
        Me.field_Potongan.Size = New System.Drawing.Size(131, 22)
        Me.field_Potongan.TabIndex = 23
        '
        'field_Tunjangan
        '
        Me.field_Tunjangan.Location = New System.Drawing.Point(380, 45)
        Me.field_Tunjangan.Name = "field_Tunjangan"
        Me.field_Tunjangan.Size = New System.Drawing.Size(131, 22)
        Me.field_Tunjangan.TabIndex = 22
        '
        'field_Izin
        '
        Me.field_Izin.Location = New System.Drawing.Point(132, 290)
        Me.field_Izin.Name = "field_Izin"
        Me.field_Izin.Size = New System.Drawing.Size(131, 22)
        Me.field_Izin.TabIndex = 21
        '
        'field_TanpaKeterangan
        '
        Me.field_TanpaKeterangan.Location = New System.Drawing.Point(132, 244)
        Me.field_TanpaKeterangan.Name = "field_TanpaKeterangan"
        Me.field_TanpaKeterangan.Size = New System.Drawing.Size(131, 22)
        Me.field_TanpaKeterangan.TabIndex = 20
        '
        'field_Sakit
        '
        Me.field_Sakit.Location = New System.Drawing.Point(132, 196)
        Me.field_Sakit.Name = "field_Sakit"
        Me.field_Sakit.Size = New System.Drawing.Size(131, 22)
        Me.field_Sakit.TabIndex = 19
        '
        'field_HariKerja
        '
        Me.field_HariKerja.Location = New System.Drawing.Point(132, 144)
        Me.field_HariKerja.Name = "field_HariKerja"
        Me.field_HariKerja.Size = New System.Drawing.Size(131, 22)
        Me.field_HariKerja.TabIndex = 18
        '
        'field_GajiPokok
        '
        Me.field_GajiPokok.Location = New System.Drawing.Point(132, 45)
        Me.field_GajiPokok.Name = "field_GajiPokok"
        Me.field_GajiPokok.Size = New System.Drawing.Size(131, 22)
        Me.field_GajiPokok.TabIndex = 16
        '
        'label_GajiBersih
        '
        Me.label_GajiBersih.AutoSize = True
        Me.label_GajiBersih.Location = New System.Drawing.Point(286, 199)
        Me.label_GajiBersih.Name = "label_GajiBersih"
        Me.label_GajiBersih.Size = New System.Drawing.Size(72, 16)
        Me.label_GajiBersih.TabIndex = 15
        Me.label_GajiBersih.Text = "Gaji Bersih"
        '
        'label_Pajak
        '
        Me.label_Pajak.AutoSize = True
        Me.label_Pajak.Location = New System.Drawing.Point(286, 147)
        Me.label_Pajak.Name = "label_Pajak"
        Me.label_Pajak.Size = New System.Drawing.Size(42, 16)
        Me.label_Pajak.TabIndex = 14
        Me.label_Pajak.Text = "Pajak"
        '
        'label_Potongan
        '
        Me.label_Potongan.AutoSize = True
        Me.label_Potongan.Location = New System.Drawing.Point(286, 98)
        Me.label_Potongan.Name = "label_Potongan"
        Me.label_Potongan.Size = New System.Drawing.Size(65, 16)
        Me.label_Potongan.TabIndex = 13
        Me.label_Potongan.Text = "Potongan"
        '
        'label_Tunjangan
        '
        Me.label_Tunjangan.AutoSize = True
        Me.label_Tunjangan.Location = New System.Drawing.Point(286, 48)
        Me.label_Tunjangan.Name = "label_Tunjangan"
        Me.label_Tunjangan.Size = New System.Drawing.Size(71, 16)
        Me.label_Tunjangan.TabIndex = 12
        Me.label_Tunjangan.Text = "Tunjangan"
        '
        'label_Izin
        '
        Me.label_Izin.AutoSize = True
        Me.label_Izin.Location = New System.Drawing.Point(42, 293)
        Me.label_Izin.Name = "label_Izin"
        Me.label_Izin.Size = New System.Drawing.Size(26, 16)
        Me.label_Izin.TabIndex = 11
        Me.label_Izin.Text = "Izin"
        '
        'label_TanpaKet
        '
        Me.label_TanpaKet.AutoSize = True
        Me.label_TanpaKet.Location = New System.Drawing.Point(42, 247)
        Me.label_TanpaKet.Name = "label_TanpaKet"
        Me.label_TanpaKet.Size = New System.Drawing.Size(72, 16)
        Me.label_TanpaKet.TabIndex = 10
        Me.label_TanpaKet.Text = "Tanpa Ket."
        '
        'label_Sakit
        '
        Me.label_Sakit.AutoSize = True
        Me.label_Sakit.Location = New System.Drawing.Point(42, 199)
        Me.label_Sakit.Name = "label_Sakit"
        Me.label_Sakit.Size = New System.Drawing.Size(37, 16)
        Me.label_Sakit.TabIndex = 9
        Me.label_Sakit.Text = "Sakit"
        '
        'label_HariKerja
        '
        Me.label_HariKerja.AutoSize = True
        Me.label_HariKerja.Location = New System.Drawing.Point(42, 147)
        Me.label_HariKerja.Name = "label_HariKerja"
        Me.label_HariKerja.Size = New System.Drawing.Size(66, 16)
        Me.label_HariKerja.TabIndex = 8
        Me.label_HariKerja.Text = "Hari Kerja"
        '
        'label_GajiPokok
        '
        Me.label_GajiPokok.AutoSize = True
        Me.label_GajiPokok.Location = New System.Drawing.Point(42, 48)
        Me.label_GajiPokok.Name = "label_GajiPokok"
        Me.label_GajiPokok.Size = New System.Drawing.Size(73, 16)
        Me.label_GajiPokok.TabIndex = 6
        Me.label_GajiPokok.Text = "Gaji Pokok"
        '
        'label_Bulan
        '
        Me.label_Bulan.AutoSize = True
        Me.label_Bulan.Location = New System.Drawing.Point(42, 98)
        Me.label_Bulan.Name = "label_Bulan"
        Me.label_Bulan.Size = New System.Drawing.Size(41, 16)
        Me.label_Bulan.TabIndex = 7
        Me.label_Bulan.Text = "Bulan"
        '
        'field_NIP
        '
        Me.field_NIP.Location = New System.Drawing.Point(116, 29)
        Me.field_NIP.Name = "field_NIP"
        Me.field_NIP.Size = New System.Drawing.Size(169, 22)
        Me.field_NIP.TabIndex = 6
        '
        'field_Nama
        '
        Me.field_Nama.Location = New System.Drawing.Point(116, 66)
        Me.field_Nama.Name = "field_Nama"
        Me.field_Nama.Size = New System.Drawing.Size(169, 22)
        Me.field_Nama.TabIndex = 7
        '
        'cb_Jabatan
        '
        Me.cb_Jabatan.FormattingEnabled = True
        Me.cb_Jabatan.Items.AddRange(New Object() {"Operator", "Pejabat Level 2", "Pejabat Level 1"})
        Me.cb_Jabatan.Location = New System.Drawing.Point(116, 108)
        Me.cb_Jabatan.Name = "cb_Jabatan"
        Me.cb_Jabatan.Size = New System.Drawing.Size(169, 24)
        Me.cb_Jabatan.TabIndex = 8
        '
        'field_TempatLahir
        '
        Me.field_TempatLahir.Location = New System.Drawing.Point(415, 66)
        Me.field_TempatLahir.Name = "field_TempatLahir"
        Me.field_TempatLahir.Size = New System.Drawing.Size(169, 22)
        Me.field_TempatLahir.TabIndex = 10
        '
        'button_HitungGaji
        '
        Me.button_HitungGaji.Location = New System.Drawing.Point(415, 108)
        Me.button_HitungGaji.Name = "button_HitungGaji"
        Me.button_HitungGaji.Size = New System.Drawing.Size(169, 35)
        Me.button_HitungGaji.TabIndex = 11
        Me.button_HitungGaji.Text = "Hitung Gaji"
        Me.button_HitungGaji.UseVisualStyleBackColor = True
        '
        'button_TambahData
        '
        Me.button_TambahData.Location = New System.Drawing.Point(47, 539)
        Me.button_TambahData.Name = "button_TambahData"
        Me.button_TambahData.Size = New System.Drawing.Size(169, 52)
        Me.button_TambahData.TabIndex = 12
        Me.button_TambahData.Text = "Tambah Data"
        Me.button_TambahData.UseVisualStyleBackColor = True
        '
        'button_Hapus
        '
        Me.button_Hapus.Location = New System.Drawing.Point(222, 539)
        Me.button_Hapus.Name = "button_Hapus"
        Me.button_Hapus.Size = New System.Drawing.Size(169, 52)
        Me.button_Hapus.TabIndex = 13
        Me.button_Hapus.Text = "Hapus"
        Me.button_Hapus.UseVisualStyleBackColor = True
        '
        'button_Keluar
        '
        Me.button_Keluar.Location = New System.Drawing.Point(402, 539)
        Me.button_Keluar.Name = "button_Keluar"
        Me.button_Keluar.Size = New System.Drawing.Size(169, 52)
        Me.button_Keluar.TabIndex = 14
        Me.button_Keluar.Text = "Keluar"
        Me.button_Keluar.UseVisualStyleBackColor = True
        '
        'group_DataKepegawaian
        '
        Me.group_DataKepegawaian.Controls.Add(Me.field_TanggalLahir)
        Me.group_DataKepegawaian.Controls.Add(Me.label_NIP)
        Me.group_DataKepegawaian.Controls.Add(Me.field_NIP)
        Me.group_DataKepegawaian.Controls.Add(Me.field_Nama)
        Me.group_DataKepegawaian.Controls.Add(Me.button_HitungGaji)
        Me.group_DataKepegawaian.Controls.Add(Me.label_Nama)
        Me.group_DataKepegawaian.Controls.Add(Me.field_TempatLahir)
        Me.group_DataKepegawaian.Controls.Add(Me.label_Jabatan)
        Me.group_DataKepegawaian.Controls.Add(Me.label_TempatLahir)
        Me.group_DataKepegawaian.Controls.Add(Me.cb_Jabatan)
        Me.group_DataKepegawaian.Controls.Add(Me.label_TanggalLahir)
        Me.group_DataKepegawaian.Location = New System.Drawing.Point(12, 22)
        Me.group_DataKepegawaian.Name = "group_DataKepegawaian"
        Me.group_DataKepegawaian.Size = New System.Drawing.Size(594, 157)
        Me.group_DataKepegawaian.TabIndex = 15
        Me.group_DataKepegawaian.TabStop = False
        Me.group_DataKepegawaian.Text = "Data Kepegawaian"
        '
        'field_TanggalLahir
        '
        Me.field_TanggalLahir.Location = New System.Drawing.Point(415, 32)
        Me.field_TanggalLahir.Name = "field_TanggalLahir"
        Me.field_TanggalLahir.Size = New System.Drawing.Size(169, 22)
        Me.field_TanggalLahir.TabIndex = 12
        '
        'Latihan3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 627)
        Me.Controls.Add(Me.button_Keluar)
        Me.Controls.Add(Me.button_Hapus)
        Me.Controls.Add(Me.button_TambahData)
        Me.Controls.Add(Me.group_PerhitunganGaji)
        Me.Controls.Add(Me.group_DataKepegawaian)
        Me.Name = "Latihan3"
        Me.Text = "FORM KEPEGAWAIAN"
        Me.group_PerhitunganGaji.ResumeLayout(False)
        Me.group_PerhitunganGaji.PerformLayout()
        Me.group_DataKepegawaian.ResumeLayout(False)
        Me.group_DataKepegawaian.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents label_NIP As Label
    Friend WithEvents label_Nama As Label
    Friend WithEvents label_Jabatan As Label
    Friend WithEvents label_TanggalLahir As Label
    Friend WithEvents label_TempatLahir As Label
    Friend WithEvents label_GajiBersih As Label
    Friend WithEvents label_Pajak As Label
    Friend WithEvents label_Potongan As Label
    Friend WithEvents label_Tunjangan As Label
    Friend WithEvents label_Izin As Label
    Friend WithEvents label_TanpaKet As Label
    Friend WithEvents label_Sakit As Label
    Friend WithEvents label_HariKerja As Label
    Friend WithEvents label_GajiPokok As Label
    Friend WithEvents label_Bulan As Label
    Friend WithEvents field_NIP As TextBox
    Friend WithEvents field_Nama As TextBox
    Friend WithEvents cb_Jabatan As ComboBox
    Friend WithEvents field_TempatLahir As TextBox
    Friend WithEvents button_HitungGaji As Button
    Friend WithEvents field_GajiBersih As TextBox
    Friend WithEvents field_Pajak As TextBox
    Friend WithEvents field_Potongan As TextBox
    Friend WithEvents field_Tunjangan As TextBox
    Friend WithEvents field_Izin As TextBox
    Friend WithEvents field_TanpaKeterangan As TextBox
    Friend WithEvents field_Sakit As TextBox
    Friend WithEvents field_HariKerja As TextBox
    Friend WithEvents field_GajiPokok As TextBox
    Friend WithEvents button_TambahData As Button
    Friend WithEvents button_Hapus As Button
    Friend WithEvents button_Keluar As Button
    Private WithEvents group_PerhitunganGaji As GroupBox
    Private WithEvents group_DataKepegawaian As GroupBox
    Friend WithEvents field_TanggalLahir As DateTimePicker
    Friend WithEvents cb_Bulan As ComboBox
End Class
