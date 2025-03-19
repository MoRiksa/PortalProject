Module ModuleRataRata
    Public ListNilaiTommy As New List(Of Decimal)()
    Public ListNilaiTimmy As New List(Of Decimal)()

    ' Menyimpan urutan tugas
    Public CounterTugasTommy As Integer = 0
    Public CounterTugasTimmy As Integer = 0

    ' Fungsi menghitung rata-rata dari seluruh nilai siswa
    Public Function HitungRataRataKelas() As Decimal
        Dim semuaNilai As New List(Of Decimal)
        semuaNilai.AddRange(ListNilaiTommy)
        semuaNilai.AddRange(ListNilaiTimmy)

        If semuaNilai.Count = 0 Then
            Return 0
        Else
            Return Math.Round(semuaNilai.Average(), 2)
        End If
    End Function
End Module
