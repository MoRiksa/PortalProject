Public Class Pertemuan4
    Private Sub button_Kembali_Click(sender As Object, e As EventArgs) Handles button_Kembali.Click
        F_Menu.Show()
        Me.Close()
    End Sub

    Private Sub button_Proses_Click(sender As Object, e As EventArgs) Handles button_Proses.Click
        Dim i As Integer
        For i = 1 To 15
            ListLooping1.Items.Add(i)
        Next i
    End Sub

    Private Sub button_Reset_Click(sender As Object, e As EventArgs) Handles button_Reset.Click
        ListLooping1.Items.Clear()
    End Sub

    Private Sub button_ProsesInput_Click(sender As Object, e As EventArgs) Handles button_ProsesInput.Click
        Dim tulisan As String
        Dim jumlah As Integer
        tulisan = field_InputText.Text
        jumlah = Val(field_JumlahText.Text)

        For i = 1 To jumlah
            ListLooping1.Items.Add(tulisan)
        Next i
    End Sub

    Private Sub button_ResetInput_Click(sender As Object, e As EventArgs) Handles button_ResetInput.Click
        field_JumlahText.Text = ""
        field_InputText.Text = ""
        ListLooping1.Items.Clear()
    End Sub

    Private Sub button_ResetHaridanBulan_Click(sender As Object, e As EventArgs) Handles button_ResetHaridanBulan.Click
        list_HaridanBulan.Items.Clear()
    End Sub

    Private Sub button_Hari_Click(sender As Object, e As EventArgs) Handles button_Hari.Click
        Dim i As Integer
        For i = 1 To 7
            list_HaridanBulan.Items.Add(WeekdayName(i))
        Next
    End Sub

    Private Sub button_Bulan_Click(sender As Object, e As EventArgs) Handles button_Bulan.Click
        Dim i As Integer
        For i = 1 To 12
            list_HaridanBulan.Items.Add(MonthName(i))
        Next
    End Sub

    Private Sub button_ResetGanjilGenap_Click(sender As Object, e As EventArgs) Handles button_ResetGanjilGenap.Click
        list_Ganjil.Items.Clear()
        list_Genap.Items.Clear()
        field_AngkaAwal.Text = ""
        field_AngkaAkhir.Text = ""
    End Sub

    Private Sub button_GanjilGenap_Click(sender As Object, e As EventArgs) Handles button_GanjilGenap.Click
        Dim x, y, i As Integer
        x = Val(field_AngkaAwal.Text)
        y = Val(field_AngkaAkhir.Text)

        For i = x To y
            If i Mod 2 = 0 Then
                list_Genap.Items.Add(i)
            ElseIf i Mod 2 = 1 Then
                list_Ganjil.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub button_DoWhile_Click(sender As Object, e As EventArgs) Handles button_DoWhile.Click
        Dim i As Integer = 0
        Do While i <= 10
            ListLooping1.Items.Add("Perulangan Do While ke - " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub button_ResetAngka_Click(sender As Object, e As EventArgs) Handles button_ResetAngka.Click
        field_InputAngka.Text = ""
    End Sub

    Private Sub button_ProsesAngka_Click(sender As Object, e As EventArgs) Handles button_ProsesAngka.Click
        Dim x
        x = field_InputAngka.Text
        Do
            x = x Mod 2
            If x = 0 Then
                MsgBox("Angka Genap", vbOKOnly, "Do While Angka Genap")
                Exit Do
            ElseIf x = 1 Then
                MsgBox("Angka Ganjil", vbOKOnly, "Do While Angka Ganjil")
                Exit Do
            End If
        Loop
    End Sub

    Private Sub button_DoLoop_Click(sender As Object, e As EventArgs) Handles button_DoLoop.Click
        Dim i As Integer
        i = 1
        list_HaridanBulan.Items.Clear()
        Do Until i > 12
            list_HaridanBulan.Items.Add(i)
            i += 1
        Loop
    End Sub

    Private Sub button_forNext_Click(sender As Object, e As EventArgs) Handles button_forNext.Click
        list_HaridanBulan.Items.Clear()
        Dim i As Integer
        For i = 1 To 12
            list_HaridanBulan.Items.Add("For Next: " & i)
        Next
    End Sub

    Private Sub button_forDo_Click(sender As Object, e As EventArgs) Handles button_forDo.Click
        list_HaridanBulan.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 10
            list_HaridanBulan.Items.Add("Do While: " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub button_doUntil_Click(sender As Object, e As EventArgs) Handles button_doUntil.Click
        list_HaridanBulan.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 10
            list_HaridanBulan.Items.Add("Do Until: " & i)
            i = i + 1
        Loop
    End Sub
End Class