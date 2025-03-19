<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Praktikum2
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
        Me.label_NilaiRataRataKelas = New System.Windows.Forms.Label()
        Me.field_NilaiRataRataKelas = New System.Windows.Forms.TextBox()
        Me.button_Timmy = New System.Windows.Forms.Button()
        Me.button_Tommy = New System.Windows.Forms.Button()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_NilaiRataRataKelas
        '
        Me.label_NilaiRataRataKelas.AutoSize = True
        Me.label_NilaiRataRataKelas.Location = New System.Drawing.Point(58, 102)
        Me.label_NilaiRataRataKelas.Name = "label_NilaiRataRataKelas"
        Me.label_NilaiRataRataKelas.Size = New System.Drawing.Size(136, 16)
        Me.label_NilaiRataRataKelas.TabIndex = 0
        Me.label_NilaiRataRataKelas.Text = "Nilai Rata-Rata Kelas"
        '
        'field_NilaiRataRataKelas
        '
        Me.field_NilaiRataRataKelas.Location = New System.Drawing.Point(230, 99)
        Me.field_NilaiRataRataKelas.Name = "field_NilaiRataRataKelas"
        Me.field_NilaiRataRataKelas.Size = New System.Drawing.Size(153, 22)
        Me.field_NilaiRataRataKelas.TabIndex = 1
        '
        'button_Timmy
        '
        Me.button_Timmy.Location = New System.Drawing.Point(74, 169)
        Me.button_Timmy.Name = "button_Timmy"
        Me.button_Timmy.Size = New System.Drawing.Size(130, 31)
        Me.button_Timmy.TabIndex = 2
        Me.button_Timmy.Text = "Timmy"
        Me.button_Timmy.UseVisualStyleBackColor = True
        '
        'button_Tommy
        '
        Me.button_Tommy.Location = New System.Drawing.Point(230, 169)
        Me.button_Tommy.Name = "button_Tommy"
        Me.button_Tommy.Size = New System.Drawing.Size(130, 31)
        Me.button_Tommy.TabIndex = 3
        Me.button_Tommy.Text = "Tommy"
        Me.button_Tommy.UseVisualStyleBackColor = True
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(349, 295)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(75, 23)
        Me.button_Kembali.TabIndex = 4
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'Praktikum2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 330)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.button_Tommy)
        Me.Controls.Add(Me.button_Timmy)
        Me.Controls.Add(Me.field_NilaiRataRataKelas)
        Me.Controls.Add(Me.label_NilaiRataRataKelas)
        Me.Name = "Praktikum2"
        Me.Text = "Praktikum2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_NilaiRataRataKelas As Label
    Friend WithEvents field_NilaiRataRataKelas As TextBox
    Friend WithEvents button_Timmy As Button
    Friend WithEvents button_Tommy As Button
    Friend WithEvents button_Kembali As Button
End Class
