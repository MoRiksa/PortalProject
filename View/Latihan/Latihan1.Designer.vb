<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Latihan1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ButtonF_Menu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.button_Reset = New System.Windows.Forms.Button()
        Me.button_Hitung = New System.Windows.Forms.Button()
        Me.field_Jumlah = New System.Windows.Forms.TextBox()
        Me.field_Harga = New System.Windows.Forms.TextBox()
        Me.Jumlah = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.Label()
        Me.field_Nama = New System.Windows.Forms.TextBox()
        Me.label_TotalHarga = New System.Windows.Forms.Label()
        Me.label_Diskon = New System.Windows.Forms.Label()
        Me.label_TotalBayar = New System.Windows.Forms.Label()
        Me.label_Bonus = New System.Windows.Forms.Label()
        Me.field_TotalHarga = New System.Windows.Forms.TextBox()
        Me.field_Diskon = New System.Windows.Forms.TextBox()
        Me.field_TotalBayar = New System.Windows.Forms.TextBox()
        Me.field_Bonus = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonF_Menu
        '
        Me.ButtonF_Menu.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonF_Menu.Location = New System.Drawing.Point(638, 401)
        Me.ButtonF_Menu.Name = "ButtonF_Menu"
        Me.ButtonF_Menu.Size = New System.Drawing.Size(118, 23)
        Me.ButtonF_Menu.TabIndex = 1
        Me.ButtonF_Menu.Text = "Menu Utama"
        Me.ButtonF_Menu.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.button_Reset)
        Me.Panel1.Controls.Add(Me.button_Hitung)
        Me.Panel1.Controls.Add(Me.field_Jumlah)
        Me.Panel1.Controls.Add(Me.field_Harga)
        Me.Panel1.Controls.Add(Me.Jumlah)
        Me.Panel1.Controls.Add(Me.Harga)
        Me.Panel1.Controls.Add(Me.Nama)
        Me.Panel1.Controls.Add(Me.field_Nama)
        Me.Panel1.Location = New System.Drawing.Point(33, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(317, 336)
        Me.Panel1.TabIndex = 2
        '
        'button_Reset
        '
        Me.button_Reset.Location = New System.Drawing.Point(180, 236)
        Me.button_Reset.Name = "button_Reset"
        Me.button_Reset.Size = New System.Drawing.Size(102, 43)
        Me.button_Reset.TabIndex = 8
        Me.button_Reset.Text = "Reset"
        Me.button_Reset.UseVisualStyleBackColor = True
        '
        'button_Hitung
        '
        Me.button_Hitung.Location = New System.Drawing.Point(23, 236)
        Me.button_Hitung.Name = "button_Hitung"
        Me.button_Hitung.Size = New System.Drawing.Size(102, 43)
        Me.button_Hitung.TabIndex = 3
        Me.button_Hitung.Text = "Hitung"
        Me.button_Hitung.UseVisualStyleBackColor = True
        '
        'field_Jumlah
        '
        Me.field_Jumlah.Location = New System.Drawing.Point(133, 120)
        Me.field_Jumlah.Name = "field_Jumlah"
        Me.field_Jumlah.Size = New System.Drawing.Size(169, 22)
        Me.field_Jumlah.TabIndex = 7
        '
        'field_Harga
        '
        Me.field_Harga.Location = New System.Drawing.Point(133, 76)
        Me.field_Harga.Name = "field_Harga"
        Me.field_Harga.Size = New System.Drawing.Size(169, 22)
        Me.field_Harga.TabIndex = 6
        '
        'Jumlah
        '
        Me.Jumlah.AutoSize = True
        Me.Jumlah.Location = New System.Drawing.Point(20, 123)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(97, 16)
        Me.Jumlah.TabIndex = 5
        Me.Jumlah.Text = "Jumlah Barang"
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.Location = New System.Drawing.Point(20, 79)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(90, 16)
        Me.Harga.TabIndex = 4
        Me.Harga.Text = "Harga Satuan"
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Location = New System.Drawing.Point(20, 35)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(91, 16)
        Me.Nama.TabIndex = 3
        Me.Nama.Text = "Nama Barang"
        '
        'field_Nama
        '
        Me.field_Nama.Location = New System.Drawing.Point(133, 32)
        Me.field_Nama.Name = "field_Nama"
        Me.field_Nama.Size = New System.Drawing.Size(169, 22)
        Me.field_Nama.TabIndex = 0
        '
        'label_TotalHarga
        '
        Me.label_TotalHarga.AutoSize = True
        Me.label_TotalHarga.Location = New System.Drawing.Point(403, 73)
        Me.label_TotalHarga.Name = "label_TotalHarga"
        Me.label_TotalHarga.Size = New System.Drawing.Size(79, 16)
        Me.label_TotalHarga.TabIndex = 3
        Me.label_TotalHarga.Text = "Total Harga"
        '
        'label_Diskon
        '
        Me.label_Diskon.AutoSize = True
        Me.label_Diskon.Location = New System.Drawing.Point(403, 117)
        Me.label_Diskon.Name = "label_Diskon"
        Me.label_Diskon.Size = New System.Drawing.Size(49, 16)
        Me.label_Diskon.TabIndex = 4
        Me.label_Diskon.Text = "Diskon"
        '
        'label_TotalBayar
        '
        Me.label_TotalBayar.AutoSize = True
        Me.label_TotalBayar.Location = New System.Drawing.Point(403, 161)
        Me.label_TotalBayar.Name = "label_TotalBayar"
        Me.label_TotalBayar.Size = New System.Drawing.Size(77, 16)
        Me.label_TotalBayar.TabIndex = 5
        Me.label_TotalBayar.Text = "Total Bayar"
        '
        'label_Bonus
        '
        Me.label_Bonus.AutoSize = True
        Me.label_Bonus.Location = New System.Drawing.Point(403, 202)
        Me.label_Bonus.Name = "label_Bonus"
        Me.label_Bonus.Size = New System.Drawing.Size(45, 16)
        Me.label_Bonus.TabIndex = 6
        Me.label_Bonus.Text = "Bonus"
        '
        'field_TotalHarga
        '
        Me.field_TotalHarga.Location = New System.Drawing.Point(501, 67)
        Me.field_TotalHarga.Name = "field_TotalHarga"
        Me.field_TotalHarga.Size = New System.Drawing.Size(264, 22)
        Me.field_TotalHarga.TabIndex = 7
        '
        'field_Diskon
        '
        Me.field_Diskon.Location = New System.Drawing.Point(501, 114)
        Me.field_Diskon.Name = "field_Diskon"
        Me.field_Diskon.Size = New System.Drawing.Size(264, 22)
        Me.field_Diskon.TabIndex = 8
        '
        'field_TotalBayar
        '
        Me.field_TotalBayar.Location = New System.Drawing.Point(501, 158)
        Me.field_TotalBayar.Name = "field_TotalBayar"
        Me.field_TotalBayar.Size = New System.Drawing.Size(264, 22)
        Me.field_TotalBayar.TabIndex = 9
        '
        'field_Bonus
        '
        Me.field_Bonus.Location = New System.Drawing.Point(406, 230)
        Me.field_Bonus.Name = "field_Bonus"
        Me.field_Bonus.Size = New System.Drawing.Size(359, 22)
        Me.field_Bonus.TabIndex = 10
        '
        'Latihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.field_Bonus)
        Me.Controls.Add(Me.field_TotalBayar)
        Me.Controls.Add(Me.field_Diskon)
        Me.Controls.Add(Me.field_TotalHarga)
        Me.Controls.Add(Me.label_Bonus)
        Me.Controls.Add(Me.label_TotalBayar)
        Me.Controls.Add(Me.label_Diskon)
        Me.Controls.Add(Me.label_TotalHarga)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonF_Menu)
        Me.Name = "Latihan1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROGRAM BELANJA SEDERHANA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonF_Menu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents field_Jumlah As TextBox
    Friend WithEvents field_Harga As TextBox
    Friend WithEvents Jumlah As Label
    Friend WithEvents Harga As Label
    Friend WithEvents Nama As Label
    Friend WithEvents field_Nama As TextBox
    Friend WithEvents button_Reset As Button
    Friend WithEvents button_Hitung As Button
    Friend WithEvents label_TotalHarga As Label
    Friend WithEvents label_Diskon As Label
    Friend WithEvents label_TotalBayar As Label
    Friend WithEvents label_Bonus As Label
    Friend WithEvents field_TotalHarga As TextBox
    Friend WithEvents field_Diskon As TextBox
    Friend WithEvents field_TotalBayar As TextBox
    Friend WithEvents field_Bonus As TextBox
End Class
