Public Class F_Tommy
    Private Sub button_Tambah_Click(sender As Object, e As EventArgs) Handles button_Tambah.Click
        Dim nilaiInput As String = InputBox("Masukkan Nilai Siswa", "Tambah Nilai")
        Dim nilai As Decimal

        If Decimal.TryParse(nilaiInput, nilai) AndAlso nilai >= 0 Then
            ' Tambah ke dalam list nilai Tommy
            ListNilaiTommy.Add(nilai)

            ' Tambah nomor tugas Tommy
            CounterTugasTommy += 1

            ' Tambahkan ke ListView dengan keterangan "Tugas x : Nilai"
            Dim listItem As New ListViewItem($"Tugas {CounterTugasTommy} : {nilai}")
            lv_NilaiTommy.Items.Add(listItem)

            ' Update rata-rata di Praktikum2
            UpdateNilaiRataRata()
        Else
            MessageBox.Show("Masukkan angka yang valid!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub UpdateNilaiRataRata()
        If Praktikum2.Instance IsNot Nothing Then
            Praktikum2.Instance.UpdateRataRata()
        End If
    End Sub
End Class