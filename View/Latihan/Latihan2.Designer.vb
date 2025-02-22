<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Latihan2
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
        Me.cb_Makanan = New System.Windows.Forms.ComboBox()
        Me.label_HargaMakanan1 = New System.Windows.Forms.Label()
        Me.label_HargaMakanan2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cb_Minuman = New System.Windows.Forms.ComboBox()
        Me.label_HargaMinuman1 = New System.Windows.Forms.Label()
        Me.label_HargaMinuman2 = New System.Windows.Forms.Label()
        Me.grp_DetailPesanan = New System.Windows.Forms.GroupBox()
        Me.label_JumlahMinuman = New System.Windows.Forms.Label()
        Me.label_JumlahMakanan = New System.Windows.Forms.Label()
        Me.field_Makanan = New System.Windows.Forms.TextBox()
        Me.field_Minuman = New System.Windows.Forms.TextBox()
        Me.button_Hitung = New System.Windows.Forms.Button()
        Me.label_TotalNominal = New System.Windows.Forms.Label()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.grp_DetailPesanan.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb_Makanan
        '
        Me.cb_Makanan.FormattingEnabled = True
        Me.cb_Makanan.Items.AddRange(New Object() {"Ayam Goreng", "Ayam Bakar", "Nasi Goreng", "Indomie Kuah", "Indomie Goreng"})
        Me.cb_Makanan.Location = New System.Drawing.Point(25, 44)
        Me.cb_Makanan.Name = "cb_Makanan"
        Me.cb_Makanan.Size = New System.Drawing.Size(178, 24)
        Me.cb_Makanan.TabIndex = 0
        '
        'label_HargaMakanan1
        '
        Me.label_HargaMakanan1.AutoSize = True
        Me.label_HargaMakanan1.Location = New System.Drawing.Point(297, 51)
        Me.label_HargaMakanan1.Name = "label_HargaMakanan1"
        Me.label_HargaMakanan1.Size = New System.Drawing.Size(45, 16)
        Me.label_HargaMakanan1.TabIndex = 1
        Me.label_HargaMakanan1.Text = "Harga"
        '
        'label_HargaMakanan2
        '
        Me.label_HargaMakanan2.AutoSize = True
        Me.label_HargaMakanan2.Location = New System.Drawing.Point(369, 52)
        Me.label_HargaMakanan2.Name = "label_HargaMakanan2"
        Me.label_HargaMakanan2.Size = New System.Drawing.Size(31, 16)
        Me.label_HargaMakanan2.TabIndex = 2
        Me.label_HargaMakanan2.Text = "Rp. "
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(25, 156)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(199, 20)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Termasuk dengan minuman."
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cb_Minuman
        '
        Me.cb_Minuman.FormattingEnabled = True
        Me.cb_Minuman.Items.AddRange(New Object() {"Es Jeruk", "Teh Manis", "Air Putih"})
        Me.cb_Minuman.Location = New System.Drawing.Point(25, 96)
        Me.cb_Minuman.Name = "cb_Minuman"
        Me.cb_Minuman.Size = New System.Drawing.Size(178, 24)
        Me.cb_Minuman.TabIndex = 4
        '
        'label_HargaMinuman1
        '
        Me.label_HargaMinuman1.AutoSize = True
        Me.label_HargaMinuman1.Location = New System.Drawing.Point(297, 104)
        Me.label_HargaMinuman1.Name = "label_HargaMinuman1"
        Me.label_HargaMinuman1.Size = New System.Drawing.Size(45, 16)
        Me.label_HargaMinuman1.TabIndex = 5
        Me.label_HargaMinuman1.Text = "Harga"
        '
        'label_HargaMinuman2
        '
        Me.label_HargaMinuman2.AutoSize = True
        Me.label_HargaMinuman2.Location = New System.Drawing.Point(369, 104)
        Me.label_HargaMinuman2.Name = "label_HargaMinuman2"
        Me.label_HargaMinuman2.Size = New System.Drawing.Size(28, 16)
        Me.label_HargaMinuman2.TabIndex = 6
        Me.label_HargaMinuman2.Text = "Rp."
        '
        'grp_DetailPesanan
        '
        Me.grp_DetailPesanan.Controls.Add(Me.label_TotalNominal)
        Me.grp_DetailPesanan.Controls.Add(Me.button_Hitung)
        Me.grp_DetailPesanan.Controls.Add(Me.field_Minuman)
        Me.grp_DetailPesanan.Controls.Add(Me.field_Makanan)
        Me.grp_DetailPesanan.Controls.Add(Me.label_JumlahMinuman)
        Me.grp_DetailPesanan.Controls.Add(Me.label_JumlahMakanan)
        Me.grp_DetailPesanan.Location = New System.Drawing.Point(25, 218)
        Me.grp_DetailPesanan.Name = "grp_DetailPesanan"
        Me.grp_DetailPesanan.Size = New System.Drawing.Size(447, 166)
        Me.grp_DetailPesanan.TabIndex = 7
        Me.grp_DetailPesanan.TabStop = False
        Me.grp_DetailPesanan.Text = "Detail Pesanan"
        '
        'label_JumlahMinuman
        '
        Me.label_JumlahMinuman.AutoSize = True
        Me.label_JumlahMinuman.Location = New System.Drawing.Point(83, 87)
        Me.label_JumlahMinuman.Name = "label_JumlahMinuman"
        Me.label_JumlahMinuman.Size = New System.Drawing.Size(107, 16)
        Me.label_JumlahMinuman.TabIndex = 1
        Me.label_JumlahMinuman.Text = "Jumlah Minuman"
        '
        'label_JumlahMakanan
        '
        Me.label_JumlahMakanan.AutoSize = True
        Me.label_JumlahMakanan.Location = New System.Drawing.Point(83, 47)
        Me.label_JumlahMakanan.Name = "label_JumlahMakanan"
        Me.label_JumlahMakanan.Size = New System.Drawing.Size(109, 16)
        Me.label_JumlahMakanan.TabIndex = 0
        Me.label_JumlahMakanan.Text = "Jumlah Makanan"
        '
        'field_Makanan
        '
        Me.field_Makanan.Location = New System.Drawing.Point(221, 44)
        Me.field_Makanan.Name = "field_Makanan"
        Me.field_Makanan.Size = New System.Drawing.Size(116, 22)
        Me.field_Makanan.TabIndex = 2
        '
        'field_Minuman
        '
        Me.field_Minuman.Location = New System.Drawing.Point(221, 81)
        Me.field_Minuman.Name = "field_Minuman"
        Me.field_Minuman.Size = New System.Drawing.Size(116, 22)
        Me.field_Minuman.TabIndex = 3
        '
        'button_Hitung
        '
        Me.button_Hitung.Location = New System.Drawing.Point(86, 124)
        Me.button_Hitung.Name = "button_Hitung"
        Me.button_Hitung.Size = New System.Drawing.Size(75, 23)
        Me.button_Hitung.TabIndex = 4
        Me.button_Hitung.Text = "Hitung"
        Me.button_Hitung.UseVisualStyleBackColor = True
        '
        'label_TotalNominal
        '
        Me.label_TotalNominal.AutoSize = True
        Me.label_TotalNominal.Location = New System.Drawing.Point(221, 130)
        Me.label_TotalNominal.Name = "label_TotalNominal"
        Me.label_TotalNominal.Size = New System.Drawing.Size(31, 16)
        Me.label_TotalNominal.TabIndex = 5
        Me.label_TotalNominal.Text = "Rp. "
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(397, 402)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.button_Kembali.TabIndex = 8
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'Latihan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 450)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.grp_DetailPesanan)
        Me.Controls.Add(Me.label_HargaMinuman2)
        Me.Controls.Add(Me.label_HargaMinuman1)
        Me.Controls.Add(Me.cb_Minuman)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.label_HargaMakanan2)
        Me.Controls.Add(Me.label_HargaMakanan1)
        Me.Controls.Add(Me.cb_Makanan)
        Me.Name = "Latihan2"
        Me.Text = "Order Makanan"
        Me.grp_DetailPesanan.ResumeLayout(False)
        Me.grp_DetailPesanan.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cb_Makanan As ComboBox
    Friend WithEvents label_HargaMakanan1 As Label
    Friend WithEvents label_HargaMakanan2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cb_Minuman As ComboBox
    Friend WithEvents label_HargaMinuman1 As Label
    Friend WithEvents label_HargaMinuman2 As Label
    Friend WithEvents grp_DetailPesanan As GroupBox
    Friend WithEvents label_JumlahMinuman As Label
    Friend WithEvents label_JumlahMakanan As Label
    Friend WithEvents button_Hitung As Button
    Friend WithEvents field_Minuman As TextBox
    Friend WithEvents field_Makanan As TextBox
    Friend WithEvents label_TotalNominal As Label
    Friend WithEvents button_Kembali As Button
End Class
