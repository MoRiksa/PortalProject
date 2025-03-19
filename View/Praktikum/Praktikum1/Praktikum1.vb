Public Class Praktikum1
    ' Autogenerate kode barang
    Private Function GenerateKodeBarang() As String
        Dim kodePraktikum As String = "PRKTK1"
        Dim randomID As String = "B" & (New Random()).Next(100, 999).ToString() & kodePraktikum
        Return randomID
    End Function

    ' Validasi input angka (Harga Satuan dan Jumlah)
    Private Function IsValidNumber(input As String) As Boolean
        Dim number As Decimal
        Return Decimal.TryParse(input, number)
    End Function

    ' Validasi input huruf (Nama Barang dan Satuan)
    Private Function IsValidText(input As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(input, "^[a-zA-Z\s]+$")
    End Function

    ' Cek semua field sebelum hitung
    Private Function ValidateFields() As Boolean
        Dim errorMessage As String = ""

        ' Validasi satu per satu sesuai field
        If field_NamaBarang.Text.Trim() = "" Then
            errorMessage &= "Nama harus diisi!" & vbCrLf
        ElseIf Not IsValidText(field_NamaBarang.Text) Then
            errorMessage &= "Nama hanya boleh mengandung huruf!" & vbCrLf
        End If

        If field_Satuan.Text.Trim() = "" Then
            errorMessage &= "Satuan harus diisi!" & vbCrLf
        ElseIf Not IsValidText(field_Satuan.Text) Then
            errorMessage &= "Satuan hanya boleh mengandung huruf!" & vbCrLf
        End If

        If field_HargaSatuan.Text.Trim() = "" Then
            errorMessage &= "Harga Satuan harus diisi!" & vbCrLf
        ElseIf Not IsValidNumber(field_HargaSatuan.Text) Then
            errorMessage &= "Harga Satuan harus berupa angka!" & vbCrLf
        End If

        If field_Jumlah.Text.Trim() = "" Then
            errorMessage &= "Jumlah harus diisi!" & vbCrLf
        ElseIf Not IsValidNumber(field_Jumlah.Text) Then
            errorMessage &= "Jumlah harus berupa angka!" & vbCrLf
        End If

        ' Jika ada error, tampilkan pesan dan return False
        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "Validasi Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    ' Hitung total harga otomatis
    Private Sub field_HargaSatuan_TextChanged(sender As Object, e As EventArgs) Handles field_HargaSatuan.TextChanged, field_Jumlah.TextChanged
        HitungTotalHarga()
    End Sub

    Private Sub HitungTotalHarga()
        Dim hargaSatuan, jumlah As Decimal

        If Decimal.TryParse(field_HargaSatuan.Text, hargaSatuan) AndAlso Decimal.TryParse(field_Jumlah.Text, jumlah) Then
            field_TotalHarga.Text = (hargaSatuan * jumlah).ToString("N2")
        Else
            field_TotalHarga.Text = "0.00"
        End If
    End Sub

    ' Tombol Hitung: Menampilkan pesan informasi jika validasi lolos
    Private Sub button_Hitung_Click(sender As Object, e As EventArgs) Handles button_Hitung.Click
        If Not ValidateFields() Then Exit Sub

        MessageBox.Show(
            "Nama Barang: " & field_NamaBarang.Text & vbCrLf &
            "Kode Barang: " & field_KodeBarang.Text & vbCrLf &
            "Jumlah: " & field_Jumlah.Text & " pcs" & vbCrLf &
            "Harga Satuan: Rp " & field_HargaSatuan.Text & vbCrLf &
            "Total Harga: Rp " & field_TotalHarga.Text,
            "Detail Barang",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    ' Tombol Reset: Mengosongkan input kecuali kode barang
    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        field_NamaBarang.Clear()
        field_Satuan.Clear()
        field_HargaSatuan.Clear()
        field_Jumlah.Clear()
        field_TotalHarga.Text = "0.00"
    End Sub
    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        Menu_Praktikum.Show()
        Me.Hide()
    End Sub

    Private Sub Praktikum1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set kode barang saat form dibuka
        field_KodeBarang.Text = GenerateKodeBarang()
        field_KodeBarang.ReadOnly = True
        field_TotalHarga.ReadOnly = True
    End Sub
End Class