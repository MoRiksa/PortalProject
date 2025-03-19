Public Class Praktikum2
    Public Shared Instance As Praktikum2

    Private Sub Praktikum2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Instance = Me
        field_NilaiRataRataKelas.ReadOnly = True
        UpdateRataRata()
    End Sub

    Public Sub UpdateRataRata()
        field_NilaiRataRataKelas.Text = HitungRataRataKelas().ToString("N2")
    End Sub

    Private Sub button_Tommy_Click(sender As Object, e As EventArgs) Handles button_Tommy.Click
        Dim formTommy As New F_Tommy()
        formTommy.Show()
    End Sub

    Private Sub button_Timmy_Click(sender As Object, e As EventArgs) Handles button_Timmy.Click
        Dim formTimmy As New F_Timmy()
        formTimmy.Show()
    End Sub

    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        Menu_Praktikum.Show()
        Me.Hide()
    End Sub
End Class