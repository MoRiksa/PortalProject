<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum1
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
        Me.label_KodeBarang = New System.Windows.Forms.Label()
        Me.label_NamaBarang = New System.Windows.Forms.Label()
        Me.label_Satuan = New System.Windows.Forms.Label()
        Me.label_HargaSatuan = New System.Windows.Forms.Label()
        Me.label_Jumlah = New System.Windows.Forms.Label()
        Me.label_TotalHarga = New System.Windows.Forms.Label()
        Me.field_KodeBarang = New System.Windows.Forms.TextBox()
        Me.field_NamaBarang = New System.Windows.Forms.TextBox()
        Me.field_Satuan = New System.Windows.Forms.TextBox()
        Me.field_HargaSatuan = New System.Windows.Forms.TextBox()
        Me.field_Jumlah = New System.Windows.Forms.TextBox()
        Me.field_TotalHarga = New System.Windows.Forms.TextBox()
        Me.button_Reset = New System.Windows.Forms.Button()
        Me.button_Hitung = New System.Windows.Forms.Button()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_KodeBarang
        '
        Me.label_KodeBarang.AutoSize = True
        Me.label_KodeBarang.Location = New System.Drawing.Point(12, 36)
        Me.label_KodeBarang.Name = "label_KodeBarang"
        Me.label_KodeBarang.Size = New System.Drawing.Size(86, 16)
        Me.label_KodeBarang.TabIndex = 0
        Me.label_KodeBarang.Text = "Kode Barang"
        '
        'label_NamaBarang
        '
        Me.label_NamaBarang.AutoSize = True
        Me.label_NamaBarang.Location = New System.Drawing.Point(12, 84)
        Me.label_NamaBarang.Name = "label_NamaBarang"
        Me.label_NamaBarang.Size = New System.Drawing.Size(91, 16)
        Me.label_NamaBarang.TabIndex = 1
        Me.label_NamaBarang.Text = "Nama Barang"
        '
        'label_Satuan
        '
        Me.label_Satuan.AutoSize = True
        Me.label_Satuan.Location = New System.Drawing.Point(12, 132)
        Me.label_Satuan.Name = "label_Satuan"
        Me.label_Satuan.Size = New System.Drawing.Size(49, 16)
        Me.label_Satuan.TabIndex = 2
        Me.label_Satuan.Text = "Satuan"
        '
        'label_HargaSatuan
        '
        Me.label_HargaSatuan.AutoSize = True
        Me.label_HargaSatuan.Location = New System.Drawing.Point(12, 180)
        Me.label_HargaSatuan.Name = "label_HargaSatuan"
        Me.label_HargaSatuan.Size = New System.Drawing.Size(90, 16)
        Me.label_HargaSatuan.TabIndex = 3
        Me.label_HargaSatuan.Text = "Harga Satuan"
        '
        'label_Jumlah
        '
        Me.label_Jumlah.AutoSize = True
        Me.label_Jumlah.Location = New System.Drawing.Point(12, 229)
        Me.label_Jumlah.Name = "label_Jumlah"
        Me.label_Jumlah.Size = New System.Drawing.Size(50, 16)
        Me.label_Jumlah.TabIndex = 4
        Me.label_Jumlah.Text = "Jumlah"
        '
        'label_TotalHarga
        '
        Me.label_TotalHarga.AutoSize = True
        Me.label_TotalHarga.Location = New System.Drawing.Point(12, 276)
        Me.label_TotalHarga.Name = "label_TotalHarga"
        Me.label_TotalHarga.Size = New System.Drawing.Size(79, 16)
        Me.label_TotalHarga.TabIndex = 5
        Me.label_TotalHarga.Text = "Total Harga"
        '
        'field_KodeBarang
        '
        Me.field_KodeBarang.Location = New System.Drawing.Point(136, 33)
        Me.field_KodeBarang.Name = "field_KodeBarang"
        Me.field_KodeBarang.Size = New System.Drawing.Size(142, 22)
        Me.field_KodeBarang.TabIndex = 6
        '
        'field_NamaBarang
        '
        Me.field_NamaBarang.Location = New System.Drawing.Point(136, 81)
        Me.field_NamaBarang.Name = "field_NamaBarang"
        Me.field_NamaBarang.Size = New System.Drawing.Size(186, 22)
        Me.field_NamaBarang.TabIndex = 7
        '
        'field_Satuan
        '
        Me.field_Satuan.Location = New System.Drawing.Point(136, 129)
        Me.field_Satuan.Name = "field_Satuan"
        Me.field_Satuan.Size = New System.Drawing.Size(107, 22)
        Me.field_Satuan.TabIndex = 8
        '
        'field_HargaSatuan
        '
        Me.field_HargaSatuan.Location = New System.Drawing.Point(136, 177)
        Me.field_HargaSatuan.Name = "field_HargaSatuan"
        Me.field_HargaSatuan.Size = New System.Drawing.Size(173, 22)
        Me.field_HargaSatuan.TabIndex = 9
        '
        'field_Jumlah
        '
        Me.field_Jumlah.Location = New System.Drawing.Point(136, 226)
        Me.field_Jumlah.Name = "field_Jumlah"
        Me.field_Jumlah.Size = New System.Drawing.Size(142, 22)
        Me.field_Jumlah.TabIndex = 10
        '
        'field_TotalHarga
        '
        Me.field_TotalHarga.Location = New System.Drawing.Point(136, 270)
        Me.field_TotalHarga.Name = "field_TotalHarga"
        Me.field_TotalHarga.Size = New System.Drawing.Size(173, 22)
        Me.field_TotalHarga.TabIndex = 11
        '
        'button_Reset
        '
        Me.button_Reset.Location = New System.Drawing.Point(136, 320)
        Me.button_Reset.Name = "button_Reset"
        Me.button_Reset.Size = New System.Drawing.Size(75, 23)
        Me.button_Reset.TabIndex = 12
        Me.button_Reset.Text = "Reset"
        Me.button_Reset.UseVisualStyleBackColor = True
        '
        'button_Hitung
        '
        Me.button_Hitung.Location = New System.Drawing.Point(234, 320)
        Me.button_Hitung.Name = "button_Hitung"
        Me.button_Hitung.Size = New System.Drawing.Size(75, 23)
        Me.button_Hitung.TabIndex = 13
        Me.button_Hitung.Text = "Hitung"
        Me.button_Hitung.UseVisualStyleBackColor = True
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(306, 368)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.button_Kembali.TabIndex = 14
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'Praktikum1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 403)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.button_Hitung)
        Me.Controls.Add(Me.button_Reset)
        Me.Controls.Add(Me.field_TotalHarga)
        Me.Controls.Add(Me.field_Jumlah)
        Me.Controls.Add(Me.field_HargaSatuan)
        Me.Controls.Add(Me.field_Satuan)
        Me.Controls.Add(Me.field_NamaBarang)
        Me.Controls.Add(Me.field_KodeBarang)
        Me.Controls.Add(Me.label_TotalHarga)
        Me.Controls.Add(Me.label_Jumlah)
        Me.Controls.Add(Me.label_HargaSatuan)
        Me.Controls.Add(Me.label_Satuan)
        Me.Controls.Add(Me.label_NamaBarang)
        Me.Controls.Add(Me.label_KodeBarang)
        Me.Name = "Praktikum1"
        Me.Text = "Praktikum1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_KodeBarang As Label
    Friend WithEvents label_NamaBarang As Label
    Friend WithEvents label_Satuan As Label
    Friend WithEvents label_HargaSatuan As Label
    Friend WithEvents label_Jumlah As Label
    Friend WithEvents label_TotalHarga As Label
    Friend WithEvents field_KodeBarang As TextBox
    Friend WithEvents field_NamaBarang As TextBox
    Friend WithEvents field_Satuan As TextBox
    Friend WithEvents field_HargaSatuan As TextBox
    Friend WithEvents field_Jumlah As TextBox
    Friend WithEvents field_TotalHarga As TextBox
    Friend WithEvents button_Reset As Button
    Friend WithEvents button_Hitung As Button
    Friend WithEvents button_Kembali As Button
End Class
