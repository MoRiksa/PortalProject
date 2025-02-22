Imports PortalProject.View

Public Class Program
    <STAThread()>
    Public Shared Sub Main()
        ' Mengaktifkan visual styles untuk aplikasi
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Menjalankan Form Utama
        Application.Run(New F_Menu()) ' Pastikan ini sesuai dengan nama form yang kamu buat
    End Sub
End Class
