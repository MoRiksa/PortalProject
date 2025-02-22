Public Class F_Menu
    Private Sub F_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonF_Latihan_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Membuka Form Latihan1
        Dim latihan1Form As New Latihan1
        latihan1Form.Show()  ' Menampilkan Form Latihan1
        Me.Hide()  ' Menyembunyikan Form F_Menu agar tidak tumpang tindih
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Membuka Form Latihan1
        Dim latihan2Form As New Latihan2
        latihan2Form.Show()  ' Menampilkan Form Latihan2
        Me.Hide()  ' Menyembunyikan Form F_Menu agar tidak tumpang tindih
    End Sub

    Private Sub button_Latihan3_Click(sender As Object, e As EventArgs) Handles button_Latihan3.Click
        Latihan3.Show()  ' Menampilkan Form Latihan3
        Me.Hide()  ' Menyembunyikan Form F_Menu agar tidak tumpang tindih
    End Sub

    Private Sub button_KalkulatorHitungNilai_Click(sender As Object, e As EventArgs) Handles button_KalkulatorHitungNilai.Click
        Latihan1sd2.Show()  ' Menampilkan Form Latihan1sd2
        Me.Hide()  ' Menyembunyikan Form F_Menu agar tidak tumpang tindih
    End Sub
End Class
