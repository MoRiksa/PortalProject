<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Praktikum
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
        Me.button_Praktikum1 = New System.Windows.Forms.Button()
        Me.button_Praktikum2 = New System.Windows.Forms.Button()
        Me.button_Kembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_Praktikum1
        '
        Me.button_Praktikum1.Location = New System.Drawing.Point(173, 193)
        Me.button_Praktikum1.Name = "button_Praktikum1"
        Me.button_Praktikum1.Size = New System.Drawing.Size(164, 48)
        Me.button_Praktikum1.TabIndex = 0
        Me.button_Praktikum1.Text = "Praktikum 1"
        Me.button_Praktikum1.UseVisualStyleBackColor = True
        '
        'button_Praktikum2
        '
        Me.button_Praktikum2.Location = New System.Drawing.Point(421, 193)
        Me.button_Praktikum2.Name = "button_Praktikum2"
        Me.button_Praktikum2.Size = New System.Drawing.Size(164, 48)
        Me.button_Praktikum2.TabIndex = 1
        Me.button_Praktikum2.Text = "Praktikum 2"
        Me.button_Praktikum2.UseVisualStyleBackColor = True
        '
        'button_Kembali
        '
        Me.button_Kembali.Location = New System.Drawing.Point(624, 390)
        Me.button_Kembali.Name = "button_Kembali"
        Me.button_Kembali.Size = New System.Drawing.Size(164, 48)
        Me.button_Kembali.TabIndex = 2
        Me.button_Kembali.Text = "Kembali"
        Me.button_Kembali.UseVisualStyleBackColor = True
        '
        'Menu_Praktikum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.button_Kembali)
        Me.Controls.Add(Me.button_Praktikum2)
        Me.Controls.Add(Me.button_Praktikum1)
        Me.Name = "Menu_Praktikum"
        Me.Text = "Menu Praktikum"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_Praktikum1 As Button
    Friend WithEvents button_Praktikum2 As Button
    Friend WithEvents button_Kembali As Button
End Class
