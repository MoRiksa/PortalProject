Public Class Latihan1sd2
    Private Sub Latihan1sd2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        field_Hasil.ReadOnly = True
        field_NilaiAkhir.ReadOnly = True
    End Sub
    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Close()
    End Sub

    Private Sub button_Pertambahan_Click(sender As Object, e As EventArgs) Handles button_Pertambahan.Click
        Dim angka1, angka2 As Double

        If Double.TryParse(field_AngkaPertama.Text, angka1) AndAlso Double.TryParse(field_AngkaKedua.Text, angka2) Then
            field_Hasil.Text = (angka1 + angka2).ToString()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button_Pengurangan_Click(sender As Object, e As EventArgs) Handles button_Pengurangan.Click
        Dim angka1, angka2 As Double

        If Double.TryParse(field_AngkaPertama.Text, angka1) AndAlso Double.TryParse(field_AngkaKedua.Text, angka2) Then
            field_Hasil.Text = (angka1 - angka2).ToString()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button_Pembagian_Click(sender As Object, e As EventArgs) Handles button_Pembagian.Click
        Dim angka1, angka2 As Double

        If Double.TryParse(field_AngkaPertama.Text, angka1) AndAlso Double.TryParse(field_AngkaKedua.Text, angka2) Then
            If angka2 <> 0 Then
                field_Hasil.Text = (angka1 / angka2).ToString()
            Else
                MessageBox.Show("Tidak bisa membagi dengan nol!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button_Perkalian_Click(sender As Object, e As EventArgs) Handles button_Perkalian.Click
        Dim angka1, angka2 As Double

        If Double.TryParse(field_AngkaPertama.Text, angka1) AndAlso Double.TryParse(field_AngkaKedua.Text, angka2) Then
            field_Hasil.Text = (angka1 * angka2).ToString()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub button_Hitung_Click(sender As Object, e As EventArgs) Handles button_Hitung.Click
        Dim tatapMuka, midTest, finalTest As Double

        ' Validasi input angka
        If Double.TryParse(field_TatapMuka.Text, tatapMuka) AndAlso
           Double.TryParse(field_MidTest.Text, midTest) AndAlso
           Double.TryParse(field_FinalTest.Text, finalTest) Then

            ' Rumus: (Tatap Muka + Mid Test + Final Test) / 3
            Dim nilaiAkhir As Double = (tatapMuka + midTest + finalTest) / 3
            field_NilaiAkhir.Text = nilaiAkhir.ToString("0.00") ' Format 2 desimal
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class