Public Class Pertemuan5

    ' Variabel untuk menyimpan nomor pendaftaran yang terakhir digunakan
    Private nextNoPendaftaran As Integer = 1

    ' Deklarasi array multidimensi (maksimal 100 data)
    Private dataArray(99, 3) As String
    Private dataCount As Integer = 0 ' Jumlah data yang tersimpan

    Private Sub button_Tambah_Click(sender As Object, e As EventArgs) Handles button_Tambah.Click
        ' Pastikan teks tidak kosong sebelum ditambahkan ke ListView
        If field_Nama.Text.Trim() <> "" Then
            Dim item As New ListViewItem(field_Nama.Text)
            list_Nama.Items.Add(item)

            ' Kosongkan kembali TextBox setelah menambahkan
            field_Nama.Text = ""
        Else
            MessageBox.Show("Masukkan nama terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        field_Nama.Text = ""
        list_Nama.Items.Clear()
    End Sub

    Private Sub Pertemuan5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        list_Nama.View = View.Details
        list_Nama.GridLines = True

        list_Nama.Columns.Add("Nama", 100)

        ' Funey 
        listview_Funey.View = View.Details
        listview_Funey.GridLines = True
        listview_Funey.FullRowSelect = True

        ' Menambahkan kolom ke ListView
        listview_Funey.Columns.Clear()
        listview_Funey.Columns.Add("Kode Barang", 100)
        listview_Funey.Columns.Add("Nama Barang", 150)
        listview_Funey.Columns.Add("Satuan", 80)
        listview_Funey.Columns.Add("Harga", 100)

        ' Klinik
        ' Konfigurasi awal ListView
        listview_Klinik.View = View.Details
        listview_Klinik.GridLines = True
        listview_Klinik.FullRowSelect = True

        ' Menambahkan kolom ke ListView
        listview_Klinik.Columns.Clear()
        listview_Klinik.Columns.Add("No Pendaftaran", 120)
        listview_Klinik.Columns.Add("Nama Pendaftar", 150)
        listview_Klinik.Columns.Add("Alamat", 200)
        listview_Klinik.Columns.Add("Tempat Lahir", 120)
        listview_Klinik.Columns.Add("Tanggal Lahir", 100)

        ' Atur No Pendaftaran pertama kali
        field_NoPendaftaran.Text = nextNoPendaftaran.ToString()
        field_NoPendaftaran.ReadOnly = True ' Buat readonly

        ' Array Multi Dimensi Mahasiswa
        ' Konfigurasi ListView
        listview_Array.View = View.Details
        listview_Array.GridLines = True
        listview_Array.FullRowSelect = True

        ' Menambahkan kolom ke ListView
        listview_Array.Columns.Clear()
        listview_Array.Columns.Add("NIM", 120)
        listview_Array.Columns.Add("Nama", 150)
        listview_Array.Columns.Add("Jenis Kelamin", 120)
        listview_Array.Columns.Add("Program Studi", 150)

        ' Isi ComboBox Jenis Kelamin
        combobox_JenisKelamin.Items.Add("Laki-laki")
        combobox_JenisKelamin.Items.Add("Perempuan")

        ' Isi ComboBox Program Studi
        combobox_ProgramStudi.Items.Add("Teknik Informatika")
        combobox_ProgramStudi.Items.Add("Sistem Informasi")
        combobox_ProgramStudi.Items.Add("Teknik Elektro")
        combobox_ProgramStudi.Items.Add("Manajemen Bisnis")

    End Sub

    Private Sub button_TambahFuney_Click(sender As Object, e As EventArgs) Handles button_TambahFuney.Click
        If field_KodeBarang.Text.Trim() <> "" AndAlso field_NamaBarang.Text.Trim() <> "" AndAlso
          field_Satuan.Text.Trim() <> "" AndAlso field_HargaBarang.Text.Trim() <> "" Then

            ' Buat item ListView baru dengan Kode Barang sebagai elemen utama
            Dim item As New ListViewItem(field_KodeBarang.Text)

            ' Tambahkan sub-item lainnya
            item.SubItems.Add(field_NamaBarang.Text)
            item.SubItems.Add(field_Satuan.Text)
            item.SubItems.Add(field_HargaBarang.Text)

            ' Tambahkan item ke dalam ListView
            listview_Funey.Items.Add(item)

            ' Kosongkan kembali semua TextBox setelah menambahkan
            field_KodeBarang.Clear()
            field_NamaBarang.Clear()
            field_Satuan.Clear()
            field_HargaBarang.Clear()
        Else
            MessageBox.Show("Pastikan semua data telah diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub button_ResetFuney_Click(sender As Object, e As EventArgs) Handles button_ResetFuney.Click
        ' Mengosongkan semua TextBox
        field_KodeBarang.Clear()
        field_NamaBarang.Clear()
        field_Satuan.Clear()
        field_HargaBarang.Clear()

        ' Menghapus semua item di ListView
        listview_Funey.Items.Clear()
    End Sub

    Private Sub button_TambahKlinik_Click(sender As Object, e As EventArgs) Handles button_TambahKlinik.Click
        ' Pastikan semua field tidak kosong sebelum ditambahkan ke ListView
        If field_NamaPendaftaran.Text.Trim() <> "" AndAlso field_Alamat.Text.Trim() <> "" AndAlso field_TempatLahir.Text.Trim() <> "" Then
            ' Buat item ListView baru dengan No Pendaftaran otomatis
            Dim item As New ListViewItem(field_NoPendaftaran.Text)

            ' Tambahkan sub-item lainnya
            item.SubItems.Add(field_NamaPendaftaran.Text)
            item.SubItems.Add(field_Alamat.Text)
            item.SubItems.Add(field_TempatLahir.Text)
            item.SubItems.Add(datetime_TanggalLahir.Value.ToString("dd/MM/yyyy"))

            ' Tambahkan item ke dalam ListView
            listview_Klinik.Items.Add(item)

            ' Kosongkan kembali field kecuali No Pendaftaran
            field_NamaPendaftaran.Clear()
            field_Alamat.Clear()
            field_TempatLahir.Clear()
            datetime_TanggalLahir.Value = DateTime.Now

            ' Tambahkan 1 ke No Pendaftaran dan perbarui tampilan
            nextNoPendaftaran += 1
            field_NoPendaftaran.Text = nextNoPendaftaran.ToString()
        Else
            MessageBox.Show("Pastikan semua data telah diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub button_HapusKlinik_Click(sender As Object, e As EventArgs) Handles button_HapusKlinik.Click
        ' Menghapus item yang dipilih dalam ListView
        If listview_Klinik.SelectedItems.Count > 0 Then
            listview_Klinik.Items.Remove(listview_Klinik.SelectedItems(0))
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub button_ResetKlinik_Click(sender As Object, e As EventArgs) Handles button_ResetKlinik.Click
        ' Reset semua input dan No Pendaftaran kembali ke 1
        field_NamaPendaftaran.Clear()
        field_Alamat.Clear()
        field_TempatLahir.Clear()
        datetime_TanggalLahir.Value = DateTime.Now

        listview_Klinik.Items.Clear()

        ' Reset No Pendaftaran ke 1
        nextNoPendaftaran = 1
        field_NoPendaftaran.Text = nextNoPendaftaran.ToString()
    End Sub

    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Close()
    End Sub

    Private Sub button_TambahArray_Click(sender As Object, e As EventArgs) Handles button_TambahArray.Click
        ' Validasi input
        If field_NimArray.Text.Trim() = "" OrElse field_NamaArray.Text.Trim() = "" OrElse
           combobox_JenisKelamin.SelectedIndex = -1 OrElse combobox_ProgramStudi.SelectedIndex = -1 Then
            MessageBox.Show("Lengkapi semua data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Pastikan tidak melebihi kapasitas array
        If dataCount >= 100 Then
            MessageBox.Show("Data sudah penuh!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Simpan data ke array
        dataArray(dataCount, 0) = field_NimArray.Text
        dataArray(dataCount, 1) = field_NamaArray.Text
        dataArray(dataCount, 2) = combobox_JenisKelamin.SelectedItem.ToString()
        dataArray(dataCount, 3) = combobox_ProgramStudi.SelectedItem.ToString()

        ' Tambahkan ke ListView
        Dim item As New ListViewItem(dataArray(dataCount, 0)) ' NIM
        item.SubItems.Add(dataArray(dataCount, 1)) ' Nama
        item.SubItems.Add(dataArray(dataCount, 2)) ' Jenis Kelamin
        item.SubItems.Add(dataArray(dataCount, 3)) ' Program Studi
        listview_Array.Items.Add(item)

        ' Tambah jumlah data
        dataCount += 1

        ' Kosongkan field input
        field_NimArray.Clear()
        field_NamaArray.Clear()
        combobox_JenisKelamin.SelectedIndex = -1
        combobox_ProgramStudi.SelectedIndex = -1
    End Sub

    Private Sub button_ResetArray_Click(sender As Object, e As EventArgs) Handles button_ResetArray.Click
        ' Reset semua data dalam array
        Array.Clear(dataArray, 0, dataArray.Length)
        dataCount = 0

        ' Kosongkan ListView
        listview_Array.Items.Clear()
    End Sub
End Class