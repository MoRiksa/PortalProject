Public Class LatihanValidasi

    Private Sub field_ValidasiAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles field_ValidasiAngka.KeyPress
        Dim keyascii As Integer = Asc(e.KeyChar)
        If Not (keyascii = 8 Or keyascii = 13 Or (keyascii >= 48 And keyascii <= 57)) Then
            e.Handled = True
            MessageBox.Show("Hanya boleh angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub field_ValidasiHuruf_TextChanged(sender As Object, e As KeyPressEventArgs) Handles field_ValidasiHuruf.TextChanged
        Dim keyascii As Integer = Asc(e.KeyChar)
        If Not (keyascii = 8 Or keyascii = 13 Or (keyascii >= 65 And keyascii <= 90) Or (keyascii >= 97 And keyascii <= 122)) Then
            e.Handled = True
            MessageBox.Show("Hanya boleh huruf!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub field_ValidasiHurufKapital_TextChanged(sender As Object, e As KeyPressEventArgs) Handles field_ValidasiHurufKapital.TextChanged
        field_ValidasiHurufKapital.CharacterCasing = CharacterCasing.Upper
    End Sub


    Private Sub field_ValidasiHurufKecil_TextChanged(sender As Object, e As KeyPressEventArgs) Handles field_ValidasiHurufKecil.TextChanged
        field_ValidasiHurufKecil.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub button_ValidasiKosong_Click(sender As Object, e As EventArgs) Handles button_ValidasiKosong.Click
        If field_NIM.Text.Trim() = "" Then
            MessageBox.Show("NIM tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf field_Nama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf field_Alamat.Text.Trim() = "" Then
            MessageBox.Show("Alamat tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Data berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub field_PanjangKarakter_TextChanged(sender As Object, e As KeyPressEventArgs) Handles field_PanjangKarakter.TextChanged
        field_PanjangKarakter.MaxLength = 10
    End Sub

    Private Sub field_NIMEnter_TextChanged(sender As Object, e As KeyPressEventArgs) Handles field_NIMEnter.TextChanged
        If e.KeyChar = Chr(13) Then
            field_NamaEnter.Focus()
        End If
    End Sub

    Private isResetting As Boolean = False ' Flag untuk menonaktifkan validasi saat reset

    Private Sub LatihanValidasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Auto-generate Nomor Pendaftaran
        field_NomorPendaftaran.Text = GenerateNomorPendaftaran()
        field_NomorPendaftaran.ReadOnly = True ' No Pendaftaran tidak bisa diubah

        ' Set header ListView
        listview_Data.View = View.Details
        listview_Data.Columns.Add("No Pendaftaran", 120)
        listview_Data.Columns.Add("Nama Pendaftar", 150)
        listview_Data.Columns.Add("Tempat Lahir", 120)
        listview_Data.Columns.Add("Tanggal Lahir", 120)
        listview_Data.Columns.Add("Jenis Kelamin", 100)
        listview_Data.Columns.Add("Alamat", 180)
        listview_Data.Columns.Add("Nama Orang Tua", 150)
        listview_Data.Columns.Add("Pekerjaan", 120)
        listview_Data.Columns.Add("Penghasilan", 100)
    End Sub

    Private Function GenerateNomorPendaftaran() As String
        ' Simulasi auto-generate nomor (misalnya: tahun + random 4 digit)
        Dim tahun As String = DateTime.Now.Year.ToString()
        Dim randomNumber As String = New Random().Next(1000, 9999).ToString()
        Return tahun & randomNumber
    End Function

    Private Function IsAngka(ByVal input As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(input, "^\d+$")
    End Function

    Private Function IsHuruf(ByVal input As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z\s]+$")
    End Function

    ' Validasi input angka
    Private Sub field_PenghasilanOrangTua_TextChanged(sender As Object, e As EventArgs) Handles field_PenghasilanOrangTua.TextChanged
        If isResetting Then Exit Sub ' Abaikan validasi saat reset

        If Not IsAngka(field_PenghasilanOrangTua.Text) Then
            MessageBox.Show("Penghasilan harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            field_PenghasilanOrangTua.Text = ""
        End If
    End Sub

    ' Validasi input huruf
    Private Sub field_NamaPendaftar_TextChanged(sender As Object, e As EventArgs) Handles field_NamaPendaftar.TextChanged
        If isResetting Then Exit Sub ' Abaikan validasi saat reset

        If Not IsHuruf(field_NamaPendaftar.Text) Then
            MessageBox.Show("Nama Pendaftar hanya boleh berisi huruf!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            field_NamaPendaftar.Text = ""
        End If
    End Sub

    Private Sub field_NamaOrangTua_TextChanged(sender As Object, e As EventArgs) Handles field_NamaOrangTua.TextChanged
        If isResetting Then Exit Sub ' Abaikan validasi saat reset

        If Not IsHuruf(field_NamaOrangTua.Text) Then
            MessageBox.Show("Nama Orang Tua hanya boleh berisi huruf!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            field_NamaOrangTua.Text = ""
        End If
    End Sub

    Private Sub field_PekerjaanOrangTua_TextChanged(sender As Object, e As EventArgs) Handles field_PekerjaanOrangTua.TextChanged
        If isResetting Then Exit Sub ' Abaikan validasi saat reset

        If Not IsHuruf(field_PekerjaanOrangTua.Text) Then
            MessageBox.Show("Pekerjaan Orang Tua hanya boleh berisi huruf!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            field_PekerjaanOrangTua.Text = ""
        End If
    End Sub

    Private Sub field_TempatLahir_TextChanged(sender As Object, e As EventArgs) Handles field_TempatLahir.TextChanged
        If isResetting Then Exit Sub ' Abaikan validasi saat reset

        If Not IsHuruf(field_TempatLahir.Text) Then
            MessageBox.Show("Tempat Lahir hanya boleh berisi huruf!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            field_TempatLahir.Text = ""
        End If
    End Sub

    Private Function ValidasiInput() As Boolean
        ' Pastikan semua field telah diisi
        If String.IsNullOrWhiteSpace(field_NamaPendaftar.Text) OrElse
           String.IsNullOrWhiteSpace(field_NamaOrangTua.Text) OrElse
           String.IsNullOrWhiteSpace(field_TempatLahir.Text) OrElse
           String.IsNullOrWhiteSpace(field_Alamat.Text) OrElse
           String.IsNullOrWhiteSpace(field_PekerjaanOrangTua.Text) OrElse
           String.IsNullOrWhiteSpace(field_PenghasilanOrangTua.Text) Then

            MessageBox.Show("Semua field wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    Private Sub button_Tambah_Click(sender As Object, e As EventArgs) Handles button_Tambah.Click
        If ValidasiInput() Then
            ' Tambahkan data ke ListView
            Dim item As New ListViewItem(field_NomorPendaftaran.Text)
            item.SubItems.Add(field_NamaPendaftar.Text)
            item.SubItems.Add(field_TempatLahir.Text)
            item.SubItems.Add(field_TanggalLahir.Value.ToShortDateString())
            item.SubItems.Add(combobox_JenisKelamin.Text)
            item.SubItems.Add(field_Alamat.Text)
            item.SubItems.Add(field_NamaOrangTua.Text)
            item.SubItems.Add(field_PekerjaanOrangTua.Text)
            item.SubItems.Add(field_PenghasilanOrangTua.Text)

            listview_Data.Items.Add(item)

            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form setelah data ditambahkan
            ResetForm()
        End If
    End Sub

    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        ResetForm()
    End Sub

    Private Sub ResetForm()
        isResetting = True ' Nonaktifkan validasi sementara

        field_NamaPendaftar.Text = ""
        field_TempatLahir.Text = ""
        field_Alamat.Text = ""
        field_NamaOrangTua.Text = ""
        field_PekerjaanOrangTua.Text = ""
        field_PenghasilanOrangTua.Text = ""
        combobox_JenisKelamin.SelectedIndex = -1
        field_TanggalLahir.Value = DateTime.Now

        ' Generate No Pendaftaran baru
        field_NomorPendaftaran.Text = GenerateNomorPendaftaran()

        isResetting = False ' Aktifkan kembali validasi
    End Sub
    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Close()
    End Sub
End Class