Imports MySql.Data.MySqlClient

Public Class Form6

    Public Property CurrentNpwp As String = ""
    Private _jumlahLebihBayar As Decimal = 0

    ' Safe Constructor
    Public Sub New()
        Try
            InitializeComponent()
        Catch ex As Exception
            MsgBox("Error initializing Form6: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Ambil Jumlah Lebih Bayar dari DB
        Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
        Dim idSpt As Integer = Modulekoneksi.GetActiveSptId(idWp)

        If idSpt <> 0 Then
            _jumlahLebihBayar = Modulekoneksi.GetJumlahLebihBayar(idSpt)
            txtJumlahKelebihanBayar.Text = "Rp " & _jumlahLebihBayar.ToString("N2")
            txtJumlahKelebihanBayar.ReadOnly = True
            
            ' Set Instruksi WP
            txtInstruksiWp.Text = "🟢 Instruksi Wajib Pajak: Penanganan Status Lebih Bayar" & vbCrLf & vbCrLf &
                                  "Apabila perhitungan SPT Tahunan Anda menghasilkan status Lebih Bayar, ini menandakan bahwa total PPh yang sudah dipotong oleh perusahaan dan menjadi Kredit Pajak Anda selama setahun melebihi total PPh Terutang kewajiban pajak sesungguhnya." & vbCrLf & vbCrLf &
                                  "Kelebihan bayar ini adalah urusan antara Pemberi Kerja dan Pegawai." & vbCrLf & vbCrLf &
                                  "Sebagai Wajib Pajak, Anda wajib segera menagih jumlah kelebihan bayar yang tertera pada formulir SPT tersebut kepada perusahaan atau Pemberi Kerja Anda." & vbCrLf & vbCrLf &
                                  "Setelah Anda benar-benar menerima pengembalian uang dari perusahaan, Anda harus kembali ke formulir SPT dan menekan tombol 'Konfirmasi Uang Telah Dikembalikan'." & vbCrLf & vbCrLf &
                                  "SPT yang dilaporkan harus mencerminkan status Nihil setelah uang dikembalikan." & vbCrLf & vbCrLf &
                                  "Jika uang belum dikembalikan oleh perusahaan, SPT Anda masih akan menunjukkan status Lebih Bayar, dan Anda belum bisa menyelesaikan (submit) pelaporan tersebut."
            txtInstruksiWp.ReadOnly = True

            btnSelanjutnya.Enabled = False
        Else
            MsgBox("Gagal mengambil data SPT aktif.", MsgBoxStyle.Critical)
            btnKonfirmasiPengembalian.Enabled = False
        End If
    End Sub

    Private Sub btnKonfirmasiPengembalian_Click(sender As Object, e As EventArgs) Handles btnKonfirmasiPengembalian.Click
        ' Update Database menjadi NIHIL agar di Form 7 status final valid
        Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
        Dim idSpt As Integer = Modulekoneksi.GetActiveSptId(idWp)
        
        If Modulekoneksi.UpdateStatusSPT(idSpt, "nihil") Then
             MsgBox("Pengembalian dana sebesar " & txtJumlahKelebihanBayar.Text & " telah dikonfirmasi. Status SPT kini NIHIL.", MsgBoxStyle.Information, "Konfirmasi Berhasil")
             
             txtJumlahKelebihanBayar.Text = "" 
             txtJumlahKelebihanBayar.Visible = False
             lblJumlahKelebihanBayar.Visible = False
             btnKonfirmasiPengembalian.Enabled = False
             btnSelanjutnya.Enabled = True
        Else
             MsgBox("Gagal mengupdate status database. Silakan coba lagi.", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnSelanjutnya_Click(sender As Object, e As EventArgs) Handles btnSelanjutnya.Click
        ' Navigasi ke Form7
        Dim form7 As New Form7()
        form7.CurrentNpwp = CurrentNpwp
        form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form4 As New Form4()
        form4.CurrentNpwp = CurrentNpwp
        form4.Show()
        Me.Close()
    End Sub
End Class