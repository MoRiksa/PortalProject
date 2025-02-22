<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihan1sd2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.group_Kalkulator = New System.Windows.Forms.GroupBox()
        Me.button_Perkalian = New System.Windows.Forms.Button()
        Me.button_Pembagian = New System.Windows.Forms.Button()
        Me.button_Pengurangan = New System.Windows.Forms.Button()
        Me.button_Pertambahan = New System.Windows.Forms.Button()
        Me.field_Hasil = New System.Windows.Forms.TextBox()
        Me.field_AngkaKedua = New System.Windows.Forms.TextBox()
        Me.field_AngkaPertama = New System.Windows.Forms.TextBox()
        Me.label_Hasil = New System.Windows.Forms.Label()
        Me.label_AngkaKedua = New System.Windows.Forms.Label()
        Me.label_AngkaPertama = New System.Windows.Forms.Label()
        Me.group_HitungNilai = New System.Windows.Forms.GroupBox()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.label_TatapMuka = New System.Windows.Forms.Label()
        Me.label_MidTest = New System.Windows.Forms.Label()
        Me.label_FinalTest = New System.Windows.Forms.Label()
        Me.label_NilaiAkhir = New System.Windows.Forms.Label()
        Me.field_TatapMuka = New System.Windows.Forms.TextBox()
        Me.field_MidTest = New System.Windows.Forms.TextBox()
        Me.field_FinalTest = New System.Windows.Forms.TextBox()
        Me.field_NilaiAkhir = New System.Windows.Forms.TextBox()
        Me.button_Hitung = New System.Windows.Forms.Button()
        Me.group_Kalkulator.SuspendLayout()
        Me.group_HitungNilai.SuspendLayout()
        Me.SuspendLayout()
        '
        'group_Kalkulator
        '
        Me.group_Kalkulator.Controls.Add(Me.button_Perkalian)
        Me.group_Kalkulator.Controls.Add(Me.button_Pembagian)
        Me.group_Kalkulator.Controls.Add(Me.button_Pengurangan)
        Me.group_Kalkulator.Controls.Add(Me.button_Pertambahan)
        Me.group_Kalkulator.Controls.Add(Me.field_Hasil)
        Me.group_Kalkulator.Controls.Add(Me.field_AngkaKedua)
        Me.group_Kalkulator.Controls.Add(Me.field_AngkaPertama)
        Me.group_Kalkulator.Controls.Add(Me.label_Hasil)
        Me.group_Kalkulator.Controls.Add(Me.label_AngkaKedua)
        Me.group_Kalkulator.Controls.Add(Me.label_AngkaPertama)
        Me.group_Kalkulator.Location = New System.Drawing.Point(26, 26)
        Me.group_Kalkulator.Name = "group_Kalkulator"
        Me.group_Kalkulator.Size = New System.Drawing.Size(300, 326)
        Me.group_Kalkulator.TabIndex = 0
        Me.group_Kalkulator.TabStop = False
        Me.group_Kalkulator.Text = "Kalkulator Sederhana"
        '
        'button_Perkalian
        '
        Me.button_Perkalian.Location = New System.Drawing.Point(252, 115)
        Me.button_Perkalian.Name = "button_Perkalian"
        Me.button_Perkalian.Size = New System.Drawing.Size(25, 23)
        Me.button_Perkalian.TabIndex = 12
        Me.button_Perkalian.Text = "*"
        Me.button_Perkalian.UseVisualStyleBackColor = True
        '
        'button_Pembagian
        '
        Me.button_Pembagian.Location = New System.Drawing.Point(221, 115)
        Me.button_Pembagian.Name = "button_Pembagian"
        Me.button_Pembagian.Size = New System.Drawing.Size(25, 23)
        Me.button_Pembagian.TabIndex = 11
        Me.button_Pembagian.Text = "/"
        Me.button_Pembagian.UseVisualStyleBackColor = True
        '
        'button_Pengurangan
        '
        Me.button_Pengurangan.Location = New System.Drawing.Point(190, 115)
        Me.button_Pengurangan.Name = "button_Pengurangan"
        Me.button_Pengurangan.Size = New System.Drawing.Size(25, 23)
        Me.button_Pengurangan.TabIndex = 10
        Me.button_Pengurangan.Text = "-"
        Me.button_Pengurangan.UseVisualStyleBackColor = True
        '
        'button_Pertambahan
        '
        Me.button_Pertambahan.Location = New System.Drawing.Point(159, 115)
        Me.button_Pertambahan.Name = "button_Pertambahan"
        Me.button_Pertambahan.Size = New System.Drawing.Size(25, 23)
        Me.button_Pertambahan.TabIndex = 9
        Me.button_Pertambahan.Text = "+"
        Me.button_Pertambahan.UseVisualStyleBackColor = True
        '
        'field_Hasil
        '
        Me.field_Hasil.Location = New System.Drawing.Point(121, 157)
        Me.field_Hasil.Name = "field_Hasil"
        Me.field_Hasil.Size = New System.Drawing.Size(156, 22)
        Me.field_Hasil.TabIndex = 8
        '
        'field_AngkaKedua
        '
        Me.field_AngkaKedua.Location = New System.Drawing.Point(121, 63)
        Me.field_AngkaKedua.Name = "field_AngkaKedua"
        Me.field_AngkaKedua.Size = New System.Drawing.Size(156, 22)
        Me.field_AngkaKedua.TabIndex = 7
        '
        'field_AngkaPertama
        '
        Me.field_AngkaPertama.Location = New System.Drawing.Point(121, 32)
        Me.field_AngkaPertama.Name = "field_AngkaPertama"
        Me.field_AngkaPertama.Size = New System.Drawing.Size(156, 22)
        Me.field_AngkaPertama.TabIndex = 6
        '
        'label_Hasil
        '
        Me.label_Hasil.AutoSize = True
        Me.label_Hasil.Location = New System.Drawing.Point(6, 160)
        Me.label_Hasil.Name = "label_Hasil"
        Me.label_Hasil.Size = New System.Drawing.Size(38, 16)
        Me.label_Hasil.TabIndex = 5
        Me.label_Hasil.Text = "Hasil"
        '
        'label_AngkaKedua
        '
        Me.label_AngkaKedua.AutoSize = True
        Me.label_AngkaKedua.Location = New System.Drawing.Point(6, 66)
        Me.label_AngkaKedua.Name = "label_AngkaKedua"
        Me.label_AngkaKedua.Size = New System.Drawing.Size(88, 16)
        Me.label_AngkaKedua.TabIndex = 4
        Me.label_AngkaKedua.Text = "Angka Kedua"
        '
        'label_AngkaPertama
        '
        Me.label_AngkaPertama.AutoSize = True
        Me.label_AngkaPertama.Location = New System.Drawing.Point(6, 35)
        Me.label_AngkaPertama.Name = "label_AngkaPertama"
        Me.label_AngkaPertama.Size = New System.Drawing.Size(100, 16)
        Me.label_AngkaPertama.TabIndex = 3
        Me.label_AngkaPertama.Text = "Angka Pertama"
        '
        'group_HitungNilai
        '
        Me.group_HitungNilai.Controls.Add(Me.button_Hitung)
        Me.group_HitungNilai.Controls.Add(Me.field_NilaiAkhir)
        Me.group_HitungNilai.Controls.Add(Me.field_FinalTest)
        Me.group_HitungNilai.Controls.Add(Me.field_MidTest)
        Me.group_HitungNilai.Controls.Add(Me.field_TatapMuka)
        Me.group_HitungNilai.Controls.Add(Me.label_NilaiAkhir)
        Me.group_HitungNilai.Controls.Add(Me.label_FinalTest)
        Me.group_HitungNilai.Controls.Add(Me.label_MidTest)
        Me.group_HitungNilai.Controls.Add(Me.label_TatapMuka)
        Me.group_HitungNilai.Location = New System.Drawing.Point(433, 26)
        Me.group_HitungNilai.Name = "group_HitungNilai"
        Me.group_HitungNilai.Size = New System.Drawing.Size(315, 326)
        Me.group_HitungNilai.TabIndex = 1
        Me.group_HitungNilai.TabStop = False
        Me.group_HitungNilai.Text = "Program Hitung NIlai"
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(673, 391)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.button_Kembali.TabIndex = 2
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'label_TatapMuka
        '
        Me.label_TatapMuka.AutoSize = True
        Me.label_TatapMuka.Location = New System.Drawing.Point(19, 35)
        Me.label_TatapMuka.Name = "label_TatapMuka"
        Me.label_TatapMuka.Size = New System.Drawing.Size(79, 16)
        Me.label_TatapMuka.TabIndex = 0
        Me.label_TatapMuka.Text = "Tatap Muka"
        '
        'label_MidTest
        '
        Me.label_MidTest.AutoSize = True
        Me.label_MidTest.Location = New System.Drawing.Point(19, 69)
        Me.label_MidTest.Name = "label_MidTest"
        Me.label_MidTest.Size = New System.Drawing.Size(59, 16)
        Me.label_MidTest.TabIndex = 1
        Me.label_MidTest.Text = "Mid Test"
        '
        'label_FinalTest
        '
        Me.label_FinalTest.AutoSize = True
        Me.label_FinalTest.Location = New System.Drawing.Point(19, 103)
        Me.label_FinalTest.Name = "label_FinalTest"
        Me.label_FinalTest.Size = New System.Drawing.Size(66, 16)
        Me.label_FinalTest.TabIndex = 2
        Me.label_FinalTest.Text = "Final Test"
        '
        'label_NilaiAkhir
        '
        Me.label_NilaiAkhir.AutoSize = True
        Me.label_NilaiAkhir.Location = New System.Drawing.Point(19, 180)
        Me.label_NilaiAkhir.Name = "label_NilaiAkhir"
        Me.label_NilaiAkhir.Size = New System.Drawing.Size(67, 16)
        Me.label_NilaiAkhir.TabIndex = 3
        Me.label_NilaiAkhir.Text = "Nilai Akhir"
        '
        'field_TatapMuka
        '
        Me.field_TatapMuka.Location = New System.Drawing.Point(106, 32)
        Me.field_TatapMuka.Name = "field_TatapMuka"
        Me.field_TatapMuka.Size = New System.Drawing.Size(178, 22)
        Me.field_TatapMuka.TabIndex = 4
        '
        'field_MidTest
        '
        Me.field_MidTest.Location = New System.Drawing.Point(106, 66)
        Me.field_MidTest.Name = "field_MidTest"
        Me.field_MidTest.Size = New System.Drawing.Size(178, 22)
        Me.field_MidTest.TabIndex = 5
        '
        'field_FinalTest
        '
        Me.field_FinalTest.Location = New System.Drawing.Point(106, 100)
        Me.field_FinalTest.Name = "field_FinalTest"
        Me.field_FinalTest.Size = New System.Drawing.Size(178, 22)
        Me.field_FinalTest.TabIndex = 6
        '
        'field_NilaiAkhir
        '
        Me.field_NilaiAkhir.Location = New System.Drawing.Point(106, 177)
        Me.field_NilaiAkhir.Name = "field_NilaiAkhir"
        Me.field_NilaiAkhir.Size = New System.Drawing.Size(178, 22)
        Me.field_NilaiAkhir.TabIndex = 7
        '
        'button_Hitung
        '
        Me.button_Hitung.Location = New System.Drawing.Point(153, 138)
        Me.button_Hitung.Name = "button_Hitung"
        Me.button_Hitung.Size = New System.Drawing.Size(75, 23)
        Me.button_Hitung.TabIndex = 8
        Me.button_Hitung.Text = "Hitung"
        Me.button_Hitung.UseVisualStyleBackColor = True
        '
        'Latihan1sd2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.group_HitungNilai)
        Me.Controls.Add(Me.group_Kalkulator)
        Me.Name = "Latihan1sd2"
        Me.Text = "Kalkulator Sederhana & Hitung Nilai"
        Me.group_Kalkulator.ResumeLayout(False)
        Me.group_Kalkulator.PerformLayout()
        Me.group_HitungNilai.ResumeLayout(False)
        Me.group_HitungNilai.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents group_Kalkulator As GroupBox
    Friend WithEvents group_HitungNilai As GroupBox
    Friend WithEvents button_Kembali As Button
    Friend WithEvents field_Hasil As TextBox
    Friend WithEvents field_AngkaKedua As TextBox
    Friend WithEvents field_AngkaPertama As TextBox
    Friend WithEvents label_Hasil As Label
    Friend WithEvents label_AngkaKedua As Label
    Friend WithEvents label_AngkaPertama As Label
    Friend WithEvents button_Perkalian As Button
    Friend WithEvents button_Pembagian As Button
    Friend WithEvents button_Pengurangan As Button
    Friend WithEvents button_Pertambahan As Button
    Friend WithEvents button_Hitung As Button
    Friend WithEvents field_NilaiAkhir As TextBox
    Friend WithEvents field_FinalTest As TextBox
    Friend WithEvents field_MidTest As TextBox
    Friend WithEvents field_TatapMuka As TextBox
    Friend WithEvents label_NilaiAkhir As Label
    Friend WithEvents label_FinalTest As Label
    Friend WithEvents label_MidTest As Label
    Friend WithEvents label_TatapMuka As Label
End Class
