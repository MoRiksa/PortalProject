Public Class Menu_Praktikum
    Private Sub button_Praktikum1_Click(sender As Object, e As EventArgs) Handles button_Praktikum1.Click
        Praktikum1.Show()
        Me.Hide()
    End Sub

    Private Sub button_Praktikum2_Click(sender As Object, e As EventArgs) Handles button_Praktikum2.Click
        Praktikum2.Show()
        Me.Hide()
    End Sub

    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Hide()
    End Sub
End Class