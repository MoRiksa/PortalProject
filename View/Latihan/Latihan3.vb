Public Class Latihan3

    Private Sub Latihan3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        group_DataKepegawaian.Enabled = False
        group_PerhitunganGaji.Enabled = False
        button_Hapus.Enabled = False
        button_TambahData.Text = "Tambah Data"
        field_HariKerja.ReadOnly = True
        field_GajiPokok.ReadOnly = True
        field_GajiBersih.ReadOnly = True
        field_Pajak.ReadOnly = True
        field_Tunjangan.ReadOnly = True
    End Sub

    Private Sub button_TambahData_Click(sender As Object, e As EventArgs) Handles button_TambahData.Click
        If button_TambahData.Text = "Tambah Data" Then
            ' Jika tombol "Tambah" diklik, aktifkan Group Data Kepegawaian
            group_DataKepegawaian.Enabled = True
            button_Hapus.Enabled = True
            button_TambahData.Text = "Batal"
            field_NIP.Focus()
        Else
            ' Jika tombol "Batal" diklik, kembali ke kondisi awal
            group_DataKepegawaian.Enabled = False
            group_PerhitunganGaji.Enabled = False
            button_Hapus.Enabled = False
            button_TambahData.Text = "Tambah Data"
        End If
    End Sub

    Private Sub button_Hapus_Click(sender As Object, e As EventArgs) Handles button_Hapus.Click
        ' Menampilkan pesan konfirmasi sebelum menghapus
        Dim result As DialogResult
        result = MessageBox.Show("Apakah Anda yakin ingin menghapus semua data?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        ' Jika user memilih "Yes", lanjutkan penghapusan
        If result = DialogResult.Yes Then
            ' Kosongkan semua field input
            field_NIP.Clear()
            field_Nama.Clear()
            cb_Jabatan.SelectedIndex = -1 ' Mengosongkan ComboBox
            field_TempatLahir.Clear()
            field_GajiBersih.Clear()
            cb_Bulan.SelectedIndex = -1 ' Mengosongkan ComboBox
            field_Pajak.Clear()
            field_Potongan.Clear()
            field_Tunjangan.Clear()
            field_Izin.Clear()
            field_TanpaKeterangan.Clear()
            field_Sakit.Clear()
            field_HariKerja.Clear()
            field_GajiPokok.Clear()

            ' Set DateTimePicker ke tanggal default (opsional)
            field_TanggalLahir.Value = DateTime.Now

            ' Fokus kembali ke field NIP
            field_NIP.Focus()

            ' Nonaktifkan group perhitungan gaji dan kosongkan field-nya
            group_PerhitunganGaji.Enabled = False
            field_GajiPokok.Clear()
            field_HariKerja.Clear()
            field_Tunjangan.Clear()
            field_Pajak.Clear()
            field_GajiBersih.Clear()
            field_Potongan.Clear()

            ' Pastikan tombol Hitung Gaji bisa diklik kembali
            button_HitungGaji.Enabled = True
        End If
    End Sub


    Private Sub button_HitungGaji_Click(sender As Object, e As EventArgs) Handles button_HitungGaji.Click
        ' Cek apakah semua field dalam group Data Kepegawaian sudah terisi
        If field_NIP.Text = "" Or field_Nama.Text = "" Or cb_Jabatan.SelectedIndex = -1 Or
       field_TanggalLahir.Text = "" Or field_TempatLahir.Text = "" Then

            MessageBox.Show("Harap lengkapi semua data kepegawaian sebelum menghitung gaji!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Menentukan Gaji Pokok berdasarkan jabatan
        Select Case cb_Jabatan.Text
            Case "Operator"
                field_GajiPokok.Text = "1000000"
            Case "Pejabat Level 2"
                field_GajiPokok.Text = "1500000"
            Case "Pejabat Level 1"
                field_GajiPokok.Text = "2000000"
            Case Else
                MessageBox.Show("Jabatan tidak valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
        End Select

        ' Aktifkan group perhitungan gaji
        group_PerhitunganGaji.Enabled = True
        button_HitungGaji.Enabled = False ' Setelah dihitung, tombol dihentikan agar tidak bisa dihitung ulang sebelum reset
    End Sub

    Private Sub cb_Bulan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Bulan.SelectedIndexChanged
        ' Pastikan user memilih bulan
        If cb_Bulan.SelectedIndex <> -1 Then
            ' Ambil tahun saat ini (atau bisa dari input user jika ada)
            Dim tahun As Integer = DateTime.Now.Year

            ' Mapping bulan ke angka 1-12
            Dim bulanTerpilih As Integer = cb_Bulan.SelectedIndex + 1

            ' Dapatkan jumlah hari dalam bulan yang dipilih
            Dim jumlahHari As Integer = DateTime.DaysInMonth(tahun, bulanTerpilih)

            ' Kurangi 4 hari kerja
            Dim hariKerja As Integer = jumlahHari - 4

            ' Tampilkan hasil di field_HariKerja
            field_HariKerja.Text = hariKerja.ToString()
        End If
    End Sub
    Private Sub field_Sakit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles field_Sakit.KeyPress, field_Izin.KeyPress, field_TanpaKeterangan.KeyPress, field_Potongan.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Mencegah input selain angka
        End If
    End Sub
    Private Sub HitungGaji()
        ' Pastikan field gaji pokok sudah terisi
        If String.IsNullOrEmpty(field_GajiPokok.Text) Then Exit Sub

        ' Ambil nilai yang ada dalam field
        Dim hariKerja As Integer = Val(field_HariKerja.Text)
        Dim gajiPokok As Integer = Val(field_GajiPokok.Text)
        Dim sakit As Integer = Val(field_Sakit.Text)
        Dim izin As Integer = Val(field_Izin.Text)
        Dim tanpaKet As Integer = Val(field_TanpaKeterangan.Text)
        Dim potongan As Integer = Val(field_Potongan.Text)

        ' Hitung total potongan dari sakit, izin, dan tanpa keterangan
        Dim potonganSakit As Integer = sakit * 20000
        Dim potonganIzin As Integer = izin * 5000
        Dim potonganTanpaKet As Integer = tanpaKet * 30000
        Dim totalPotongan As Integer = potonganSakit + potonganIzin + potonganTanpaKet

        ' Maksimum potongan dari sakit, izin, tanpa keterangan adalah gaji pokok
        If totalPotongan > gajiPokok Then totalPotongan = gajiPokok

        ' Hitung tunjangan
        Dim tunjangan As Integer = (hariKerja * 50000) - totalPotongan
        If tunjangan < 0 Then tunjangan = 0 ' Pastikan tunjangan tidak negatif
        field_Tunjangan.Text = tunjangan.ToString()

        ' Hitung pajak berdasarkan jabatan
        ' Cek apakah cb_Jabatan memiliki item yang dipilih sebelum mengaksesnya
        Dim pajak As Double = 0
        If cb_Jabatan.SelectedItem IsNot Nothing Then
            Select Case cb_Jabatan.SelectedItem.ToString()
                Case "Operator"
                    pajak = gajiPokok * 0.05
                Case "Pejabat Level 2"
                    pajak = gajiPokok * 0.075
                Case "Pejabat Level 1"
                    pajak = gajiPokok * 0.0975
            End Select
        End If
        field_Pajak.Text = pajak.ToString()

        ' Hitung gaji bersih
        Dim gajiBersih As Integer = gajiPokok + tunjangan - potongan - pajak
        field_GajiBersih.Text = gajiBersih.ToString()
    End Sub

    ' Memanggil fungsi perhitungan saat ada perubahan di field terkait
    Private Sub field_GajiPokok_TextChanged(sender As Object, e As EventArgs) Handles field_GajiPokok.TextChanged, field_Sakit.TextChanged, field_Izin.TextChanged, field_TanpaKeterangan.TextChanged, field_Potongan.TextChanged, cb_Jabatan.SelectedIndexChanged
        HitungGaji()
    End Sub

    Private Sub button_Keluar_Click(sender As Object, e As EventArgs) Handles button_Keluar.Click
        F_Menu.Show()
        Me.Close()
    End Sub
End Class