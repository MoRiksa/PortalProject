Public Class Latihan1
    Private Sub ButtonF_Menu_Click(sender As Object, e As EventArgs) Handles ButtonF_Menu.Click
        Dim menuForm As New F_Menu
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        field_Nama.Text = ""
        field_Diskon.Text = ""
        field_Harga.Text = ""
        field_Jumlah.Text = ""
        field_TotalBayar.Text = ""
        field_Bonus.Text = ""
        field_TotalHarga.Text = ""
        field_Nama.Focus()
    End Sub

    Private Sub button_Hitung_Click(sender As Object, e As EventArgs) Handles button_Hitung.Click
        Dim bonus As String
        Dim harga, jumlah As Integer
        Dim diskon, totalBayar, totalHarga As Double

        ' Ambil input harga dan jumlah
        harga = Val(field_Harga.Text)
        jumlah = Val(field_Jumlah.Text)

        ' Hitung total harga
        totalHarga = harga * jumlah

        ' Tentukan diskon dan bonus berdasarkan total harga
        If totalHarga >= 500000 Then
            diskon = 0.2
            bonus = "Anda mendapatkan bonus 1 buah karpet cantik"
        ElseIf totalHarga >= 200000 Then
            diskon = 0.15
            bonus = "Anda mendapatkan bonus 1 buah payung cantik"
        ElseIf totalHarga >= 100000 Then
            diskon = 0.1
            bonus = "Anda mendapatkan bonus 1 buah payung kecil"
        ElseIf totalHarga >= 50000 Then
            diskon = 0.05
            bonus = "Anda mendapatkan bonus 1 buah gelas cantik"
        Else
            diskon = 0
            bonus = "Maaf, Anda tidak mendapatkan bonus"
        End If

        ' Hitung total bayar setelah diskon
        totalBayar = totalHarga - (totalHarga * diskon)

        ' Tampilkan hasil ke dalam TextBox
        field_TotalHarga.Text = totalHarga.ToString("N0")
        field_Diskon.Text = (diskon * 100).ToString("N0") & "%"
        field_TotalBayar.Text = totalBayar.ToString("N0")
        field_Bonus.Text = bonus
    End Sub

End Class