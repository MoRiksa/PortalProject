Public Class Latihan2
    Private hargamakanan As Integer = 0
    Private hargaminuman As Integer = 0
    Private Sub Latihan2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Kosongkan jumlah makanan dan minuman saat pertama kali form dimuat
        field_Makanan.Text = "0"
        field_Minuman.Text = "0"
    End Sub
    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Hide()
    End Sub
    Private Sub cb_Makanan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Makanan.SelectedIndexChanged
        Select Case cb_Makanan.Text
            Case "Ayam Goreng"
                hargamakanan = 10000
            Case "Ayam Bakar"
                hargamakanan = 15000
            Case "Nasi Goreng"
                hargamakanan = 12000
            Case "Indomie Kuah", "Indomie Goreng"
                hargamakanan = 8000
            Case Else
                hargamakanan = 0
        End Select
        label_HargaMakanan2.Text = "Rp. " & hargamakanan.ToString("N0")
    End Sub
    Private Sub cb_Minuman_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_Minuman.SelectedIndexChanged
        Select Case cb_Minuman.Text
            Case "Es Jeruk"
                hargaminuman = 6000
            Case "Teh Manis"
                hargaminuman = 3000
            Case "Air Putih"
                hargaminuman = 1500
            Case Else
                hargaminuman = 0
        End Select
        label_HargaMinuman2.Text = "Rp. " & hargaminuman.ToString("N0")
    End Sub
    Public Sub New()
        InitializeComponent()
        ' Sembunyikan komponen minuman di awal
        cb_Minuman.Visible = False
        label_HargaMinuman1.Visible = False
        label_HargaMinuman2.Visible = False
        field_Minuman.Visible = False
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Dim isChecked As Boolean = CheckBox1.Checked
        cb_Minuman.Visible = isChecked
        label_HargaMinuman1.Visible = isChecked
        label_HargaMinuman2.Visible = isChecked
        field_Minuman.Visible = isChecked

        ' Reset nilai jika checkbox tidak dicentang
        If Not isChecked Then
            field_Minuman.Text = "0"
            label_HargaMinuman2.Text = "Rp. 0"
            hargaminuman = 0
        End If
    End Sub
    Private Sub button_Hitung_Click(sender As Object, e As EventArgs) Handles button_Hitung.Click
        Dim total, jumlahMakanan, jumlahMinuman As Integer

        ' Ambil jumlah makanan, jika tidak valid maka set 0
        If Not Integer.TryParse(field_Makanan.Text, jumlahMakanan) Then jumlahMakanan = 0

        ' Ambil jumlah minuman hanya jika checkbox dicentang
        If CheckBox1.Checked Then
            If Not Integer.TryParse(field_Minuman.Text, jumlahMinuman) Then jumlahMinuman = 0
        Else
            jumlahMinuman = 0
        End If

        ' Hitung total harga
        total = (jumlahMakanan * hargamakanan) + (jumlahMinuman * hargaminuman)
        label_TotalNominal.Text = "Rp. " & total.ToString("N0") ' Format angka dengan pemisah ribuan
    End Sub
End Class
