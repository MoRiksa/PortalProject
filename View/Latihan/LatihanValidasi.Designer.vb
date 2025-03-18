<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LatihanValidasi
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
        Me.label_ValidasiAngka = New System.Windows.Forms.Label()
        Me.field_ValidasiAngka = New System.Windows.Forms.TextBox()
        Me.field_ValidasiHuruf = New System.Windows.Forms.TextBox()
        Me.label_ValidasiHuruf = New System.Windows.Forms.Label()
        Me.field_ValidasiHurufKapital = New System.Windows.Forms.TextBox()
        Me.label_ValidasiHurufKapital = New System.Windows.Forms.Label()
        Me.field_ValidasiHurufKecil = New System.Windows.Forms.TextBox()
        Me.label_ValidasiHurufKecil = New System.Windows.Forms.Label()
        Me.group_TeksKosong = New System.Windows.Forms.GroupBox()
        Me.button_ValidasiKosong = New System.Windows.Forms.Button()
        Me.field_Kelas = New System.Windows.Forms.TextBox()
        Me.field_Nama = New System.Windows.Forms.TextBox()
        Me.field_NIM = New System.Windows.Forms.TextBox()
        Me.label_Kelas = New System.Windows.Forms.Label()
        Me.label_Nama = New System.Windows.Forms.Label()
        Me.label_NIM = New System.Windows.Forms.Label()
        Me.field_PanjangKarakter = New System.Windows.Forms.TextBox()
        Me.label_PanjangKarakter = New System.Windows.Forms.Label()
        Me.group_KeypressEnter = New System.Windows.Forms.GroupBox()
        Me.field_NamaKelas = New System.Windows.Forms.TextBox()
        Me.field_NamaEnter = New System.Windows.Forms.TextBox()
        Me.field_NIMEnter = New System.Windows.Forms.TextBox()
        Me.label_KelasEnter = New System.Windows.Forms.Label()
        Me.label_NamaEnter = New System.Windows.Forms.Label()
        Me.label_NIMEnter = New System.Windows.Forms.Label()
        Me.groupbox_LatihanValidasi = New System.Windows.Forms.GroupBox()
        Me.field_PenghasilanOrangTua = New System.Windows.Forms.TextBox()
        Me.field_PekerjaanOrangTua = New System.Windows.Forms.TextBox()
        Me.combobox_JenisKelamin = New System.Windows.Forms.ComboBox()
        Me.field_TanggalLahir = New System.Windows.Forms.DateTimePicker()
        Me.field_TempatLahir = New System.Windows.Forms.TextBox()
        Me.field_NamaOrangTua = New System.Windows.Forms.TextBox()
        Me.field_Alamat = New System.Windows.Forms.TextBox()
        Me.field_NamaPendaftar = New System.Windows.Forms.TextBox()
        Me.field_NomorPendaftaran = New System.Windows.Forms.TextBox()
        Me.button_Tambah = New System.Windows.Forms.Button()
        Me.button_Reset = New System.Windows.Forms.Button()
        Me.listview_Data = New System.Windows.Forms.ListView()
        Me.combobox_Pilihan2 = New System.Windows.Forms.ComboBox()
        Me.label_Pilihan2 = New System.Windows.Forms.Label()
        Me.label_Pilihan1 = New System.Windows.Forms.Label()
        Me.combobox_Pilihan1 = New System.Windows.Forms.ComboBox()
        Me.label_PekerjaanOrangTua = New System.Windows.Forms.Label()
        Me.label_PenghasilanOrangTua = New System.Windows.Forms.Label()
        Me.label_NamaOrangTua = New System.Windows.Forms.Label()
        Me.label_TempatLahir = New System.Windows.Forms.Label()
        Me.label_TanggalLahir = New System.Windows.Forms.Label()
        Me.label_JenisKelamin = New System.Windows.Forms.Label()
        Me.label_Alamat = New System.Windows.Forms.Label()
        Me.label_NamaLatihan = New System.Windows.Forms.Label()
        Me.label_NoPendaftaran = New System.Windows.Forms.Label()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.group_TeksKosong.SuspendLayout()
        Me.group_KeypressEnter.SuspendLayout()
        Me.groupbox_LatihanValidasi.SuspendLayout()
        Me.SuspendLayout()
        '
        'label_ValidasiAngka
        '
        Me.label_ValidasiAngka.AutoSize = True
        Me.label_ValidasiAngka.Location = New System.Drawing.Point(26, 33)
        Me.label_ValidasiAngka.Name = "label_ValidasiAngka"
        Me.label_ValidasiAngka.Size = New System.Drawing.Size(98, 16)
        Me.label_ValidasiAngka.TabIndex = 0
        Me.label_ValidasiAngka.Text = "Validasi Angka"
        '
        'field_ValidasiAngka
        '
        Me.field_ValidasiAngka.Location = New System.Drawing.Point(29, 52)
        Me.field_ValidasiAngka.Name = "field_ValidasiAngka"
        Me.field_ValidasiAngka.Size = New System.Drawing.Size(135, 22)
        Me.field_ValidasiAngka.TabIndex = 1
        '
        'field_ValidasiHuruf
        '
        Me.field_ValidasiHuruf.Location = New System.Drawing.Point(29, 112)
        Me.field_ValidasiHuruf.Name = "field_ValidasiHuruf"
        Me.field_ValidasiHuruf.Size = New System.Drawing.Size(135, 22)
        Me.field_ValidasiHuruf.TabIndex = 3
        '
        'label_ValidasiHuruf
        '
        Me.label_ValidasiHuruf.AutoSize = True
        Me.label_ValidasiHuruf.Location = New System.Drawing.Point(26, 93)
        Me.label_ValidasiHuruf.Name = "label_ValidasiHuruf"
        Me.label_ValidasiHuruf.Size = New System.Drawing.Size(90, 16)
        Me.label_ValidasiHuruf.TabIndex = 2
        Me.label_ValidasiHuruf.Text = "Validasi Huruf"
        '
        'field_ValidasiHurufKapital
        '
        Me.field_ValidasiHurufKapital.Location = New System.Drawing.Point(29, 178)
        Me.field_ValidasiHurufKapital.Name = "field_ValidasiHurufKapital"
        Me.field_ValidasiHurufKapital.Size = New System.Drawing.Size(135, 22)
        Me.field_ValidasiHurufKapital.TabIndex = 5
        '
        'label_ValidasiHurufKapital
        '
        Me.label_ValidasiHurufKapital.AutoSize = True
        Me.label_ValidasiHurufKapital.Location = New System.Drawing.Point(26, 159)
        Me.label_ValidasiHurufKapital.Name = "label_ValidasiHurufKapital"
        Me.label_ValidasiHurufKapital.Size = New System.Drawing.Size(134, 16)
        Me.label_ValidasiHurufKapital.TabIndex = 4
        Me.label_ValidasiHurufKapital.Text = "Validasi Huruf Kapital"
        '
        'field_ValidasiHurufKecil
        '
        Me.field_ValidasiHurufKecil.Location = New System.Drawing.Point(29, 240)
        Me.field_ValidasiHurufKecil.Name = "field_ValidasiHurufKecil"
        Me.field_ValidasiHurufKecil.Size = New System.Drawing.Size(135, 22)
        Me.field_ValidasiHurufKecil.TabIndex = 7
        '
        'label_ValidasiHurufKecil
        '
        Me.label_ValidasiHurufKecil.AutoSize = True
        Me.label_ValidasiHurufKecil.Location = New System.Drawing.Point(26, 221)
        Me.label_ValidasiHurufKecil.Name = "label_ValidasiHurufKecil"
        Me.label_ValidasiHurufKecil.Size = New System.Drawing.Size(122, 16)
        Me.label_ValidasiHurufKecil.TabIndex = 6
        Me.label_ValidasiHurufKecil.Text = "Validasi Huruf Kecil"
        '
        'group_TeksKosong
        '
        Me.group_TeksKosong.Controls.Add(Me.button_ValidasiKosong)
        Me.group_TeksKosong.Controls.Add(Me.field_Kelas)
        Me.group_TeksKosong.Controls.Add(Me.field_Nama)
        Me.group_TeksKosong.Controls.Add(Me.field_NIM)
        Me.group_TeksKosong.Controls.Add(Me.label_Kelas)
        Me.group_TeksKosong.Controls.Add(Me.label_Nama)
        Me.group_TeksKosong.Controls.Add(Me.label_NIM)
        Me.group_TeksKosong.Location = New System.Drawing.Point(220, 33)
        Me.group_TeksKosong.Name = "group_TeksKosong"
        Me.group_TeksKosong.Size = New System.Drawing.Size(200, 238)
        Me.group_TeksKosong.TabIndex = 8
        Me.group_TeksKosong.TabStop = False
        Me.group_TeksKosong.Text = "Validasi Teks Kosong"
        '
        'button_ValidasiKosong
        '
        Me.button_ValidasiKosong.Location = New System.Drawing.Point(90, 166)
        Me.button_ValidasiKosong.Name = "button_ValidasiKosong"
        Me.button_ValidasiKosong.Size = New System.Drawing.Size(75, 23)
        Me.button_ValidasiKosong.TabIndex = 6
        Me.button_ValidasiKosong.Text = "Validasi"
        Me.button_ValidasiKosong.UseVisualStyleBackColor = True
        '
        'field_Kelas
        '
        Me.field_Kelas.Location = New System.Drawing.Point(78, 123)
        Me.field_Kelas.Name = "field_Kelas"
        Me.field_Kelas.Size = New System.Drawing.Size(100, 22)
        Me.field_Kelas.TabIndex = 5
        '
        'field_Nama
        '
        Me.field_Nama.Location = New System.Drawing.Point(78, 79)
        Me.field_Nama.Name = "field_Nama"
        Me.field_Nama.Size = New System.Drawing.Size(100, 22)
        Me.field_Nama.TabIndex = 4
        '
        'field_NIM
        '
        Me.field_NIM.Location = New System.Drawing.Point(78, 37)
        Me.field_NIM.Name = "field_NIM"
        Me.field_NIM.Size = New System.Drawing.Size(100, 22)
        Me.field_NIM.TabIndex = 3
        '
        'label_Kelas
        '
        Me.label_Kelas.AutoSize = True
        Me.label_Kelas.Location = New System.Drawing.Point(6, 126)
        Me.label_Kelas.Name = "label_Kelas"
        Me.label_Kelas.Size = New System.Drawing.Size(41, 16)
        Me.label_Kelas.TabIndex = 2
        Me.label_Kelas.Text = "Kelas"
        '
        'label_Nama
        '
        Me.label_Nama.AutoSize = True
        Me.label_Nama.Location = New System.Drawing.Point(6, 82)
        Me.label_Nama.Name = "label_Nama"
        Me.label_Nama.Size = New System.Drawing.Size(44, 16)
        Me.label_Nama.TabIndex = 1
        Me.label_Nama.Text = "Nama"
        '
        'label_NIM
        '
        Me.label_NIM.AutoSize = True
        Me.label_NIM.Location = New System.Drawing.Point(7, 40)
        Me.label_NIM.Name = "label_NIM"
        Me.label_NIM.Size = New System.Drawing.Size(31, 16)
        Me.label_NIM.TabIndex = 0
        Me.label_NIM.Text = "NIM"
        '
        'field_PanjangKarakter
        '
        Me.field_PanjangKarakter.Location = New System.Drawing.Point(29, 305)
        Me.field_PanjangKarakter.Name = "field_PanjangKarakter"
        Me.field_PanjangKarakter.Size = New System.Drawing.Size(135, 22)
        Me.field_PanjangKarakter.TabIndex = 10
        '
        'label_PanjangKarakter
        '
        Me.label_PanjangKarakter.AutoSize = True
        Me.label_PanjangKarakter.Location = New System.Drawing.Point(26, 286)
        Me.label_PanjangKarakter.Name = "label_PanjangKarakter"
        Me.label_PanjangKarakter.Size = New System.Drawing.Size(162, 16)
        Me.label_PanjangKarakter.TabIndex = 9
        Me.label_PanjangKarakter.Text = "Validasi Panjang Karakter"
        '
        'group_KeypressEnter
        '
        Me.group_KeypressEnter.Controls.Add(Me.field_NamaKelas)
        Me.group_KeypressEnter.Controls.Add(Me.field_NamaEnter)
        Me.group_KeypressEnter.Controls.Add(Me.field_NIMEnter)
        Me.group_KeypressEnter.Controls.Add(Me.label_KelasEnter)
        Me.group_KeypressEnter.Controls.Add(Me.label_NamaEnter)
        Me.group_KeypressEnter.Controls.Add(Me.label_NIMEnter)
        Me.group_KeypressEnter.Location = New System.Drawing.Point(220, 277)
        Me.group_KeypressEnter.Name = "group_KeypressEnter"
        Me.group_KeypressEnter.Size = New System.Drawing.Size(200, 166)
        Me.group_KeypressEnter.TabIndex = 11
        Me.group_KeypressEnter.TabStop = False
        Me.group_KeypressEnter.Text = "Keypress Enter"
        '
        'field_NamaKelas
        '
        Me.field_NamaKelas.Location = New System.Drawing.Point(81, 119)
        Me.field_NamaKelas.Name = "field_NamaKelas"
        Me.field_NamaKelas.Size = New System.Drawing.Size(100, 22)
        Me.field_NamaKelas.TabIndex = 5
        '
        'field_NamaEnter
        '
        Me.field_NamaEnter.Location = New System.Drawing.Point(81, 75)
        Me.field_NamaEnter.Name = "field_NamaEnter"
        Me.field_NamaEnter.Size = New System.Drawing.Size(100, 22)
        Me.field_NamaEnter.TabIndex = 4
        '
        'field_NIMEnter
        '
        Me.field_NIMEnter.Location = New System.Drawing.Point(81, 36)
        Me.field_NIMEnter.Name = "field_NIMEnter"
        Me.field_NIMEnter.Size = New System.Drawing.Size(100, 22)
        Me.field_NIMEnter.TabIndex = 3
        '
        'label_KelasEnter
        '
        Me.label_KelasEnter.AutoSize = True
        Me.label_KelasEnter.Location = New System.Drawing.Point(6, 122)
        Me.label_KelasEnter.Name = "label_KelasEnter"
        Me.label_KelasEnter.Size = New System.Drawing.Size(41, 16)
        Me.label_KelasEnter.TabIndex = 2
        Me.label_KelasEnter.Text = "Kelas"
        '
        'label_NamaEnter
        '
        Me.label_NamaEnter.AutoSize = True
        Me.label_NamaEnter.Location = New System.Drawing.Point(6, 78)
        Me.label_NamaEnter.Name = "label_NamaEnter"
        Me.label_NamaEnter.Size = New System.Drawing.Size(44, 16)
        Me.label_NamaEnter.TabIndex = 1
        Me.label_NamaEnter.Text = "Nama"
        '
        'label_NIMEnter
        '
        Me.label_NIMEnter.AutoSize = True
        Me.label_NIMEnter.Location = New System.Drawing.Point(6, 39)
        Me.label_NIMEnter.Name = "label_NIMEnter"
        Me.label_NIMEnter.Size = New System.Drawing.Size(31, 16)
        Me.label_NIMEnter.TabIndex = 0
        Me.label_NIMEnter.Text = "NIM"
        '
        'groupbox_LatihanValidasi
        '
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_PenghasilanOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_PekerjaanOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.combobox_JenisKelamin)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_TanggalLahir)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_TempatLahir)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_NamaOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_Alamat)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_NamaPendaftar)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.field_NomorPendaftaran)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.button_Tambah)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.button_Reset)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.listview_Data)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.combobox_Pilihan2)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_Pilihan2)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_Pilihan1)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.combobox_Pilihan1)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_PekerjaanOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_PenghasilanOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_NamaOrangTua)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_TempatLahir)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_TanggalLahir)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_JenisKelamin)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_Alamat)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_NamaLatihan)
        Me.groupbox_LatihanValidasi.Controls.Add(Me.label_NoPendaftaran)
        Me.groupbox_LatihanValidasi.Location = New System.Drawing.Point(436, 33)
        Me.groupbox_LatihanValidasi.Name = "groupbox_LatihanValidasi"
        Me.groupbox_LatihanValidasi.Size = New System.Drawing.Size(411, 517)
        Me.groupbox_LatihanValidasi.TabIndex = 12
        Me.groupbox_LatihanValidasi.TabStop = False
        Me.groupbox_LatihanValidasi.Text = "Latihan Validasi"
        '
        'field_PenghasilanOrangTua
        '
        Me.field_PenghasilanOrangTua.Location = New System.Drawing.Point(174, 351)
        Me.field_PenghasilanOrangTua.Name = "field_PenghasilanOrangTua"
        Me.field_PenghasilanOrangTua.Size = New System.Drawing.Size(200, 22)
        Me.field_PenghasilanOrangTua.TabIndex = 25
        '
        'field_PekerjaanOrangTua
        '
        Me.field_PekerjaanOrangTua.Location = New System.Drawing.Point(174, 316)
        Me.field_PekerjaanOrangTua.Name = "field_PekerjaanOrangTua"
        Me.field_PekerjaanOrangTua.Size = New System.Drawing.Size(200, 22)
        Me.field_PekerjaanOrangTua.TabIndex = 24
        '
        'combobox_JenisKelamin
        '
        Me.combobox_JenisKelamin.FormattingEnabled = True
        Me.combobox_JenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.combobox_JenisKelamin.Location = New System.Drawing.Point(172, 283)
        Me.combobox_JenisKelamin.Name = "combobox_JenisKelamin"
        Me.combobox_JenisKelamin.Size = New System.Drawing.Size(200, 24)
        Me.combobox_JenisKelamin.TabIndex = 23
        '
        'field_TanggalLahir
        '
        Me.field_TanggalLahir.Location = New System.Drawing.Point(172, 213)
        Me.field_TanggalLahir.Name = "field_TanggalLahir"
        Me.field_TanggalLahir.Size = New System.Drawing.Size(200, 22)
        Me.field_TanggalLahir.TabIndex = 21
        '
        'field_TempatLahir
        '
        Me.field_TempatLahir.Location = New System.Drawing.Point(172, 247)
        Me.field_TempatLahir.Name = "field_TempatLahir"
        Me.field_TempatLahir.Size = New System.Drawing.Size(200, 22)
        Me.field_TempatLahir.TabIndex = 20
        '
        'field_NamaOrangTua
        '
        Me.field_NamaOrangTua.Location = New System.Drawing.Point(172, 382)
        Me.field_NamaOrangTua.Name = "field_NamaOrangTua"
        Me.field_NamaOrangTua.Size = New System.Drawing.Size(202, 22)
        Me.field_NamaOrangTua.TabIndex = 19
        '
        'field_Alamat
        '
        Me.field_Alamat.Location = New System.Drawing.Point(116, 120)
        Me.field_Alamat.Name = "field_Alamat"
        Me.field_Alamat.Size = New System.Drawing.Size(279, 22)
        Me.field_Alamat.TabIndex = 18
        '
        'field_NamaPendaftar
        '
        Me.field_NamaPendaftar.Location = New System.Drawing.Point(116, 82)
        Me.field_NamaPendaftar.Name = "field_NamaPendaftar"
        Me.field_NamaPendaftar.Size = New System.Drawing.Size(200, 22)
        Me.field_NamaPendaftar.TabIndex = 17
        '
        'field_NomorPendaftaran
        '
        Me.field_NomorPendaftaran.Location = New System.Drawing.Point(116, 37)
        Me.field_NomorPendaftaran.Name = "field_NomorPendaftaran"
        Me.field_NomorPendaftaran.Size = New System.Drawing.Size(157, 22)
        Me.field_NomorPendaftaran.TabIndex = 16
        '
        'button_Tambah
        '
        Me.button_Tambah.Location = New System.Drawing.Point(322, 410)
        Me.button_Tambah.Name = "button_Tambah"
        Me.button_Tambah.Size = New System.Drawing.Size(75, 23)
        Me.button_Tambah.TabIndex = 15
        Me.button_Tambah.Text = "Tambah"
        Me.button_Tambah.UseVisualStyleBackColor = True
        '
        'button_Reset
        '
        Me.button_Reset.Location = New System.Drawing.Point(241, 410)
        Me.button_Reset.Name = "button_Reset"
        Me.button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.button_Reset.TabIndex = 14
        Me.button_Reset.Text = "Reset"
        Me.button_Reset.UseVisualStyleBackColor = True
        '
        'listview_Data
        '
        Me.listview_Data.HideSelection = False
        Me.listview_Data.Location = New System.Drawing.Point(6, 439)
        Me.listview_Data.Name = "listview_Data"
        Me.listview_Data.Size = New System.Drawing.Size(389, 72)
        Me.listview_Data.TabIndex = 13
        Me.listview_Data.UseCompatibleStateImageBehavior = False
        '
        'combobox_Pilihan2
        '
        Me.combobox_Pilihan2.FormattingEnabled = True
        Me.combobox_Pilihan2.Items.AddRange(New Object() {"AKUNTANSI", "ADBIS"})
        Me.combobox_Pilihan2.Location = New System.Drawing.Point(287, 165)
        Me.combobox_Pilihan2.Name = "combobox_Pilihan2"
        Me.combobox_Pilihan2.Size = New System.Drawing.Size(118, 24)
        Me.combobox_Pilihan2.TabIndex = 12
        '
        'label_Pilihan2
        '
        Me.label_Pilihan2.AutoSize = True
        Me.label_Pilihan2.Location = New System.Drawing.Point(216, 168)
        Me.label_Pilihan2.Name = "label_Pilihan2"
        Me.label_Pilihan2.Size = New System.Drawing.Size(57, 16)
        Me.label_Pilihan2.TabIndex = 11
        Me.label_Pilihan2.Text = "Pilihan 2"
        '
        'label_Pilihan1
        '
        Me.label_Pilihan1.AutoSize = True
        Me.label_Pilihan1.Location = New System.Drawing.Point(6, 169)
        Me.label_Pilihan1.Name = "label_Pilihan1"
        Me.label_Pilihan1.Size = New System.Drawing.Size(57, 16)
        Me.label_Pilihan1.TabIndex = 10
        Me.label_Pilihan1.Text = "Pilihan 1"
        '
        'combobox_Pilihan1
        '
        Me.combobox_Pilihan1.FormattingEnabled = True
        Me.combobox_Pilihan1.Items.AddRange(New Object() {"MI", "TEKOM", "ELEKTRO"})
        Me.combobox_Pilihan1.Location = New System.Drawing.Point(77, 165)
        Me.combobox_Pilihan1.Name = "combobox_Pilihan1"
        Me.combobox_Pilihan1.Size = New System.Drawing.Size(120, 24)
        Me.combobox_Pilihan1.TabIndex = 9
        '
        'label_PekerjaanOrangTua
        '
        Me.label_PekerjaanOrangTua.AutoSize = True
        Me.label_PekerjaanOrangTua.Location = New System.Drawing.Point(13, 319)
        Me.label_PekerjaanOrangTua.Name = "label_PekerjaanOrangTua"
        Me.label_PekerjaanOrangTua.Size = New System.Drawing.Size(136, 16)
        Me.label_PekerjaanOrangTua.TabIndex = 8
        Me.label_PekerjaanOrangTua.Text = "Pekerjaan Orang Tua"
        '
        'label_PenghasilanOrangTua
        '
        Me.label_PenghasilanOrangTua.AutoSize = True
        Me.label_PenghasilanOrangTua.Location = New System.Drawing.Point(13, 354)
        Me.label_PenghasilanOrangTua.Name = "label_PenghasilanOrangTua"
        Me.label_PenghasilanOrangTua.Size = New System.Drawing.Size(149, 16)
        Me.label_PenghasilanOrangTua.TabIndex = 7
        Me.label_PenghasilanOrangTua.Text = "Penghasilan Orang Tua"
        '
        'label_NamaOrangTua
        '
        Me.label_NamaOrangTua.AutoSize = True
        Me.label_NamaOrangTua.Location = New System.Drawing.Point(13, 385)
        Me.label_NamaOrangTua.Name = "label_NamaOrangTua"
        Me.label_NamaOrangTua.Size = New System.Drawing.Size(111, 16)
        Me.label_NamaOrangTua.TabIndex = 6
        Me.label_NamaOrangTua.Text = "Nama Orang Tua"
        '
        'label_TempatLahir
        '
        Me.label_TempatLahir.AutoSize = True
        Me.label_TempatLahir.Location = New System.Drawing.Point(13, 250)
        Me.label_TempatLahir.Name = "label_TempatLahir"
        Me.label_TempatLahir.Size = New System.Drawing.Size(86, 16)
        Me.label_TempatLahir.TabIndex = 5
        Me.label_TempatLahir.Text = "Tempat Lahir"
        '
        'label_TanggalLahir
        '
        Me.label_TanggalLahir.AutoSize = True
        Me.label_TanggalLahir.Location = New System.Drawing.Point(13, 218)
        Me.label_TanggalLahir.Name = "label_TanggalLahir"
        Me.label_TanggalLahir.Size = New System.Drawing.Size(90, 16)
        Me.label_TanggalLahir.TabIndex = 4
        Me.label_TanggalLahir.Text = "Tanggal Lahir"
        '
        'label_JenisKelamin
        '
        Me.label_JenisKelamin.AutoSize = True
        Me.label_JenisKelamin.Location = New System.Drawing.Point(13, 286)
        Me.label_JenisKelamin.Name = "label_JenisKelamin"
        Me.label_JenisKelamin.Size = New System.Drawing.Size(90, 16)
        Me.label_JenisKelamin.TabIndex = 3
        Me.label_JenisKelamin.Text = "Jenis Kelamin"
        '
        'label_Alamat
        '
        Me.label_Alamat.AutoSize = True
        Me.label_Alamat.Location = New System.Drawing.Point(6, 123)
        Me.label_Alamat.Name = "label_Alamat"
        Me.label_Alamat.Size = New System.Drawing.Size(49, 16)
        Me.label_Alamat.TabIndex = 2
        Me.label_Alamat.Text = "Alamat"
        '
        'label_NamaLatihan
        '
        Me.label_NamaLatihan.AutoSize = True
        Me.label_NamaLatihan.Location = New System.Drawing.Point(6, 79)
        Me.label_NamaLatihan.Name = "label_NamaLatihan"
        Me.label_NamaLatihan.Size = New System.Drawing.Size(44, 16)
        Me.label_NamaLatihan.TabIndex = 1
        Me.label_NamaLatihan.Text = "Nama"
        '
        'label_NoPendaftaran
        '
        Me.label_NoPendaftaran.AutoSize = True
        Me.label_NoPendaftaran.Location = New System.Drawing.Point(6, 40)
        Me.label_NoPendaftaran.Name = "label_NoPendaftaran"
        Me.label_NoPendaftaran.Size = New System.Drawing.Size(104, 16)
        Me.label_NoPendaftaran.TabIndex = 0
        Me.label_NoPendaftaran.Text = "No. Pendaftaran"
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(29, 520)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.button_Kembali.TabIndex = 13
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'LatihanValidasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 562)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.groupbox_LatihanValidasi)
        Me.Controls.Add(Me.group_KeypressEnter)
        Me.Controls.Add(Me.field_PanjangKarakter)
        Me.Controls.Add(Me.label_PanjangKarakter)
        Me.Controls.Add(Me.group_TeksKosong)
        Me.Controls.Add(Me.field_ValidasiHurufKecil)
        Me.Controls.Add(Me.label_ValidasiHurufKecil)
        Me.Controls.Add(Me.field_ValidasiHurufKapital)
        Me.Controls.Add(Me.label_ValidasiHurufKapital)
        Me.Controls.Add(Me.field_ValidasiHuruf)
        Me.Controls.Add(Me.label_ValidasiHuruf)
        Me.Controls.Add(Me.field_ValidasiAngka)
        Me.Controls.Add(Me.label_ValidasiAngka)
        Me.Name = "LatihanValidasi"
        Me.Text = "Latihan Validasi"
        Me.group_TeksKosong.ResumeLayout(False)
        Me.group_TeksKosong.PerformLayout()
        Me.group_KeypressEnter.ResumeLayout(False)
        Me.group_KeypressEnter.PerformLayout()
        Me.groupbox_LatihanValidasi.ResumeLayout(False)
        Me.groupbox_LatihanValidasi.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_ValidasiAngka As Label
    Friend WithEvents field_ValidasiAngka As TextBox
    Friend WithEvents field_ValidasiHuruf As TextBox
    Friend WithEvents label_ValidasiHuruf As Label
    Friend WithEvents field_ValidasiHurufKapital As TextBox
    Friend WithEvents label_ValidasiHurufKapital As Label
    Friend WithEvents field_ValidasiHurufKecil As TextBox
    Friend WithEvents label_ValidasiHurufKecil As Label
    Friend WithEvents group_TeksKosong As GroupBox
    Friend WithEvents field_Nama As TextBox
    Friend WithEvents field_NIM As TextBox
    Friend WithEvents label_Kelas As Label
    Friend WithEvents label_Nama As Label
    Friend WithEvents label_NIM As Label
    Friend WithEvents button_ValidasiKosong As Button
    Friend WithEvents field_Kelas As TextBox
    Friend WithEvents field_PanjangKarakter As TextBox
    Friend WithEvents label_PanjangKarakter As Label
    Friend WithEvents group_KeypressEnter As GroupBox
    Friend WithEvents field_NamaKelas As TextBox
    Friend WithEvents field_NamaEnter As TextBox
    Friend WithEvents field_NIMEnter As TextBox
    Friend WithEvents label_KelasEnter As Label
    Friend WithEvents label_NamaEnter As Label
    Friend WithEvents label_NIMEnter As Label

    Friend WithEvents groupbox_LatihanValidasi As GroupBox
    Friend WithEvents label_Pilihan2 As Label
    Friend WithEvents label_Pilihan1 As Label
    Friend WithEvents combobox_Pilihan1 As ComboBox
    Friend WithEvents label_PekerjaanOrangTua As Label
    Friend WithEvents label_PenghasilanOrangTua As Label
    Friend WithEvents label_NamaOrangTua As Label
    Friend WithEvents label_TempatLahir As Label
    Friend WithEvents label_TanggalLahir As Label
    Friend WithEvents label_JenisKelamin As Label
    Friend WithEvents label_Alamat As Label
    Friend WithEvents label_NamaLatihan As Label
    Friend WithEvents label_NoPendaftaran As Label
    Friend WithEvents combobox_Pilihan2 As ComboBox
    Friend WithEvents field_TanggalLahir As DateTimePicker
    Friend WithEvents field_TempatLahir As TextBox
    Friend WithEvents field_NamaOrangTua As TextBox
    Friend WithEvents field_Alamat As TextBox
    Friend WithEvents field_NamaPendaftar As TextBox
    Friend WithEvents field_NomorPendaftaran As TextBox
    Friend WithEvents button_Tambah As Button
    Friend WithEvents button_Reset As Button
    Friend WithEvents listview_Data As ListView
    Friend WithEvents field_PenghasilanOrangTua As TextBox
    Friend WithEvents field_PekerjaanOrangTua As TextBox
    Friend WithEvents combobox_JenisKelamin As ComboBox
    Friend WithEvents button_Kembali As Button
End Class
