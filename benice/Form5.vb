Imports MySql.Data.MySqlClient

Public Class Form5

    Public Property CurrentNpwp As String = ""
    Public Property TargetSptId As Integer = 0
    Private kur_jumlahKurangBayar As Decimal = 0

    ' Explicit Constructor to ensure controls are initialized
    Public Sub New()
        ' This call is required by the designer.
        Try
            InitializeComponent()
        Catch ex As Exception
            MsgBox("Error initializing Form5: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Tentukan ID SPT
        Dim idSpt As Integer = 0
        If TargetSptId > 0 Then
            idSpt = TargetSptId
        Else
            Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
            idSpt = Modulekoneksi.GetActiveSptId(idWp)
        End If

        If idSpt <> 0 Then
            ' Ambil detail angka untuk diagnosa
            Dim pphTerutang As Decimal = 0
            Dim kreditPajak As Decimal = 0
            
            Dim queryDetail As String = "SELECT pph_terutang, total_kredit_pajak FROM perhitungan_spt WHERE id_spt = @id"

            Modulekoneksi.BukaKoneksi()
            Using cmd As New MySqlCommand(queryDetail, Modulekoneksi.koneksi)
                cmd.Parameters.AddWithValue("@id", idSpt)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        pphTerutang = Convert.ToDecimal(reader("pph_terutang"))
                        kreditPajak = Convert.ToDecimal(reader("total_kredit_pajak"))
                    End If
                End Using
            End Using
            Modulekoneksi.TutupKoneksi()

            ' Hitung ulang di sini untuk kepastian
            kur_jumlahKurangBayar = pphTerutang - kreditPajak

            ' Tampilkan nilai
            txtJumlahKurangBayar.Text = "Rp " & kur_jumlahKurangBayar.ToString("N2")
            txtJumlahKurangBayar.ReadOnly = True

            ' Set UI Default: Kode Billing area murni untuk kode billing
            ' KITA HILANGKAN STATUS "LEBIH BAYAR" AGAR TOMBOL BISA DIPAKAI
            lblKodeBillingValue.Text = "[Belum diterbitkan]"
            
            ' Aktifkan tombol agar user bisa memproses
            btnTerbitkanKodeBilling.Enabled = True
            btnKonfirmasiPembayaran.Enabled = False
            btnSelanjutnya.Enabled = True ' Enable this by default if user wants to skip

        Else
            MsgBox("Gagal mengambil data SPT aktif.", MsgBoxStyle.Critical)
            btnTerbitkanKodeBilling.Enabled = False
            btnKonfirmasiPembayaran.Enabled = False
        End If
    End Sub

    Private Sub btnTerbitkanKodeBilling_Click(sender As Object, e As EventArgs) Handles btnTerbitkanKodeBilling.Click
        ' Logika pembuatan Kode Billing (15 digit)
        ' Kita izinkan generate untuk semua nilai (termasuk 0 atau negatif) demi kelancaran flow aplikasi
        
        Dim random As New Random()
        Dim kodeBilling As String = ""
        For i As Integer = 1 To 15
            kodeBilling &= random.Next(0, 9).ToString()
        Next
        
        lblKodeBillingValue.Text = kodeBilling
        
        ' Setelah terbit, aktifkan tombol konfirmasi
        btnKonfirmasiPembayaran.Enabled = True
        btnTerbitkanKodeBilling.Enabled = False
    End Sub

    Private Sub btnKonfirmasiPembayaran_Click(sender As Object, e As EventArgs) Handles btnKonfirmasiPembayaran.Click
        ' Simulasikan konfirmasi pembayaran
        Dim statusFinal As String = "Kurang Bayar"
        
        ' Update status di database menjadi Final (Lapor)
        Dim idSpt As Integer = 0
        If TargetSptId > 0 Then
            idSpt = TargetSptId
        Else
            Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
            idSpt = Modulekoneksi.GetActiveSptId(idWp)
        End If
        
        Modulekoneksi.FinalizeSpt(idSpt, statusFinal)

        MsgBox("Pembayaran Berhasil!" & vbCrLf & "Kode Billing: " & lblKodeBillingValue.Text & vbCrLf & "SPT Anda telah dilaporkan.", MsgBoxStyle.Information, "Sukses")
        
        ' Navigasi ke Form7 (Bukti Lapor)
        Dim form7 As New Form7()
        form7.CurrentNpwp = CurrentNpwp
        form7.Show()
        Me.Hide()
    End Sub

    Private Sub btnSelanjutnya_Click(sender As Object, e As EventArgs) Handles btnSelanjutnya.Click
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