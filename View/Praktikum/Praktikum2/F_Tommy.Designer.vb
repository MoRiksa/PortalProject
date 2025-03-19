<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Tommy
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
        Me.lv_NilaiTommy = New System.Windows.Forms.ListView()
        Me.button_Tambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lv_NilaiTommy
        '
        Me.lv_NilaiTommy.HideSelection = False
        Me.lv_NilaiTommy.Location = New System.Drawing.Point(59, 24)
        Me.lv_NilaiTommy.Name = "lv_NilaiTommy"
        Me.lv_NilaiTommy.Size = New System.Drawing.Size(188, 97)
        Me.lv_NilaiTommy.TabIndex = 0
        Me.lv_NilaiTommy.UseCompatibleStateImageBehavior = False
        '
        'button_Tambah
        '
        Me.button_Tambah.Location = New System.Drawing.Point(111, 150)
        Me.button_Tambah.Name = "button_Tambah"
        Me.button_Tambah.Size = New System.Drawing.Size(75, 23)
        Me.button_Tambah.TabIndex = 1
        Me.button_Tambah.Text = "Tambah"
        Me.button_Tambah.UseVisualStyleBackColor = True
        '
        'F_Tommy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 206)
        Me.Controls.Add(Me.button_Tambah)
        Me.Controls.Add(Me.lv_NilaiTommy)
        Me.Name = "F_Tommy"
        Me.Text = "F_Tommy"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lv_NilaiTommy As ListView
    Friend WithEvents button_Tambah As Button
End Class
