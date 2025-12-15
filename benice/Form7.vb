Imports MySql.Data.MySqlClient
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports System.IO
Imports System.Diagnostics
Imports PdfSharp.Fonts

Public Class Form7

    Public Property CurrentNpwp As String = ""
    Private _sptStatusFinal As String = "NIHIL"

    ' Safe Constructor
    Public Sub New()
        Try
            InitializeComponent()
        Catch ex As Exception
            MsgBox("Error initializing Form7: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil status final dari database
        Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
        Dim idSpt As Integer = Modulekoneksi.GetActiveSptId(idWp)

        If idSpt <> 0 Then
            ' Ambil status dari perhitungan_spt
            Dim status As String = Modulekoneksi.GetStatusSpt(idSpt)
            If Not String.IsNullOrEmpty(status) Then
                _sptStatusFinal = status
                ' Tampilkan status dalam format yang lebih user-friendly
                Select Case status.ToLower()
                    Case "nihil"
                        txtStatusFinalSpt.Text = "NIHIL"
                    Case "kurang_bayar"
                        txtStatusFinalSpt.Text = "LUNAS (Setelah Pembayaran)"
                    Case "lebih_bayar"
                        txtStatusFinalSpt.Text = "KEMBALI (Setelah Pengembalian)"
                    Case Else
                        txtStatusFinalSpt.Text = status.ToUpper()
                End Select
            Else
                txtStatusFinalSpt.Text = "NIHIL"
            End If
        Else
            txtStatusFinalSpt.Text = "NIHIL"
        End If

        txtStatusFinalSpt.ReadOnly = True
        btnSubmitSpt.Enabled = False
    End Sub

    Private Sub chkPernyataan_CheckedChanged(sender As Object, e As EventArgs) Handles chkPernyataan.CheckedChanged
        ' Mengaktifkan tombol submit jika checkbox dicentang
        btnSubmitSpt.Enabled = chkPernyataan.Checked
    End Sub

    Private Sub btnSubmitSpt_Click(sender As Object, e As EventArgs) Handles btnSubmitSpt.Click
        If chkPernyataan.Checked Then
            ' 1. Simpan Tgl Lapor dan Status Final SPT ke Database
            Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
            Dim idSpt As Integer = Modulekoneksi.GetActiveSptId(idWp)

            If idSpt <> 0 Then
                ' Tentukan status final berdasarkan _sptStatusFinal
                Dim statusFinal As String = _sptStatusFinal
                If Modulekoneksi.FinalizeSpt(idSpt, statusFinal) Then
                    
                    ' GENERATE PDF REPORT
                    Try
                        GeneratePdfReport(idSpt, CurrentNpwp, statusFinal)
                    Catch ex As Exception
                        MsgBox("Gagal membuat PDF Laporan: " & ex.Message, MsgBoxStyle.Exclamation)
                        ' Log error detail
                        Console.WriteLine("PDF Error: " & ex.ToString())
                    End Try

                    MsgBox("SPT Tahunan berhasil dikirim dan Bukti Penerimaan Elektronik (BPE) diterbitkan. PDF Laporan telah disimpan.", MsgBoxStyle.Information, "SPT Berhasil")

                    ' Kembali ke Menu Utama
                    Dim mainMenuForm As New Form2()
                    Form2.CurrentNpwp = CurrentNpwp
                    mainMenuForm.Show()
                    Me.Close()
                Else
                    MsgBox("Gagal menyimpan finalisasi SPT ke database.", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("Gagal mengambil data SPT aktif.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Anda harus menyatakan data yang diisi sudah benar sebelum submit.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub GeneratePdfReport(idSpt As Integer, npwp As String, statusFinal As String)
        ' 0. Setup Font Resolver (Wajib untuk PdfSharp 6 di beberapa environment)
        Try
            If GlobalFontSettings.FontResolver Is Nothing Then
                GlobalFontSettings.FontResolver = New SimpleFontResolver()
            End If
        Catch ex As Exception
            ' Ignore
        End Try

        ' 1. Ambil data detail perhitungan dari database
        Dim neto As Decimal = 0
        Dim ptkp As Decimal = 0
        Dim pkp As Decimal = 0 
        Dim pphTerutang As Decimal = 0
        Dim kreditPajak As Decimal = 0
        
        Dim query As String = "SELECT total_penghasilan_setahun, ptkp, pph_terutang, total_kredit_pajak FROM perhitungan_spt WHERE id_spt = @id"
        
        Modulekoneksi.BukaKoneksi()
        Using cmd As New MySqlCommand(query, Modulekoneksi.koneksi)
            cmd.Parameters.AddWithValue("@id", idSpt)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    neto = Convert.ToDecimal(reader("total_penghasilan_setahun"))
                    ptkp = Convert.ToDecimal(reader("ptkp"))
                    pphTerutang = Convert.ToDecimal(reader("pph_terutang"))
                    kreditPajak = Convert.ToDecimal(reader("total_kredit_pajak"))
                End If
            End Using
        End Using
        Modulekoneksi.TutupKoneksi()

        ' Hitung Selisih (Positif = Kurang Bayar, Negatif = Lebih Bayar)
        Dim selisih As Decimal = pphTerutang - kreditPajak
        Dim statusAwal As String = "NIHIL"
        If selisih > 0 Then
            statusAwal = "KURANG BAYAR"
        ElseIf selisih < 0 Then
            statusAwal = "LEBIH BAYAR"
        End If

        ' 2. Buat Dokumen PDF
        Dim document As New PdfDocument()
        document.Info.Title = "Bukti Penerimaan Elektronik (BPE)"
        
        Dim page As PdfPage = document.AddPage()
        Dim gfx As XGraphics = XGraphics.FromPdfPage(page)
        
        ' Font Setup
        Dim fontTitle As New XFont("Arial", 18)
        Dim fontHeader As New XFont("Arial", 12)
        Dim fontRegular As New XFont("Arial", 11)
        Dim fontSmall As New XFont("Arial", 9)
        Dim fontBoldText As New XFont("Arial", 11)

        Dim yPoint As Double = 40
        Dim xLeft As Double = 40
        
        ' Header
        gfx.DrawString("KEMENTERIAN KEUANGAN", fontHeader, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 20
        gfx.DrawString("DIREKTORAT JENDERAL PAJAK", fontHeader, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 40
        gfx.DrawString("BUKTI PENERIMAAN ELEKTRONIK (BPE)", fontTitle, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 30
        
        ' Garis separator
        Dim pageWidth As Double = page.Width.Point
        gfx.DrawLine(XPens.Black, xLeft, yPoint, pageWidth - 40, yPoint)
        yPoint += 20

        ' Identitas
        gfx.DrawString("Nama / NPWP     : " & npwp, fontRegular, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 20
        gfx.DrawString("Tahun Pajak     : 2025", fontRegular, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 20
        gfx.DrawString("Tanggal Lapor   : " & DateTime.Now.ToString("dd MMMM yyyy HH:mm:ss"), fontRegular, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 40

        ' Detail Perhitungan
        gfx.DrawString("RINCIAN PERHITUNGAN PAJAK PENGHASILAN", fontHeader, XBrushes.Black, New XPoint(xLeft, yPoint))
        yPoint += 30

        Dim col1 As Double = xLeft
        Dim col2 As Double = xLeft + 300

        ' Baris-baris Perhitungan
        DrawRow(gfx, "1. Penghasilan Netto", "Rp " & neto.ToString("N2"), fontRegular, col1, col2, yPoint)
        DrawRow(gfx, "2. Penghasilan Tidak Kena Pajak (PTKP)", "Rp " & ptkp.ToString("N2"), fontRegular, col1, col2, yPoint)
        
        Dim pkpCalc As Decimal = If(neto - ptkp > 0, Math.Floor((neto - ptkp) / 1000) * 1000, 0)
        DrawRow(gfx, "3. Penghasilan Kena Pajak (PKP)", "Rp " & pkpCalc.ToString("N2"), fontRegular, col1, col2, yPoint)
        
        yPoint += 10
        DrawRow(gfx, "4. PPh Terutang", "Rp " & pphTerutang.ToString("N2"), fontRegular, col1, col2, yPoint)
        DrawRow(gfx, "5. Kredit Pajak", "Rp " & kreditPajak.ToString("N2"), fontRegular, col1, col2, yPoint)
        
        ' Status Awal (Hasil Perhitungan)
        yPoint += 10
        Dim nilaiSelisih As Decimal = Math.Abs(selisih)
        Dim textSelisih As String = "Rp " & nilaiSelisih.ToString("N2")
        If selisih = 0 Then textSelisih = "Rp 0"

        DrawRow(gfx, "6. Status SPT (Hasil Perhitungan)", statusAwal, fontBoldText, col1, col2, yPoint)
        DrawRow(gfx, "7. Nilai Kurang/Lebih Bayar", textSelisih, fontBoldText, col1, col2, yPoint)
        
        yPoint += 10
        gfx.DrawLine(XPens.Black, col1, yPoint, pageWidth - 40, yPoint)
        yPoint += 20

        ' Penyesuaian / Tindak Lanjut
        If selisih > 0 Then
            ' Kurang Bayar -> Ada Pembayaran
             gfx.DrawString("TINDAK LANJUT PEMBAYARAN", fontHeader, XBrushes.Black, New XPoint(xLeft, yPoint))
             yPoint += 30
             DrawRow(gfx, "8. Pembayaran Pajak (SSB/NTPN)", "(Rp " & nilaiSelisih.ToString("N2") & ")", fontRegular, col1, col2, yPoint)
             DrawRow(gfx, "   Status Pembayaran", "LUNAS", fontSmall, col1, col2, yPoint)

        ElseIf selisih < 0 Then
            ' Lebih Bayar -> Restitusi
             gfx.DrawString("TINDAK LANJUT LEBIH BAYAR", fontHeader, XBrushes.Black, New XPoint(xLeft, yPoint))
             yPoint += 30
             DrawRow(gfx, "8. Permohonan Pengembalian (Restitusi)", "(Rp " & nilaiSelisih.ToString("N2") & ")", fontRegular, col1, col2, yPoint)
             DrawRow(gfx, "   Status", "DIPROSES", fontSmall, col1, col2, yPoint)
        End If

        yPoint += 20
        gfx.DrawLine(XPens.Black, col1, yPoint, pageWidth - 40, yPoint)
        yPoint += 20
        
        ' Status Akhir
        Dim finalStatusShow As String = statusFinal.ToUpper()
        If finalStatusShow = "KURANG_BAYAR" Then finalStatusShow = "LUNAS"
        If finalStatusShow = "LEBIH_BAYAR" Then finalStatusShow = "NIHIL (SETELAH RESTITUSI)"
        
        DrawRow(gfx, "9. STATUS AKHIR SPT", finalStatusShow, fontBoldText, col1, col2, yPoint)

        yPoint += 50
        gfx.DrawString("Dokumen ini dihasilkan secara otomatis oleh sistem Benice.", fontSmall, XBrushes.Gray, New XPoint(xLeft, yPoint))
        yPoint += 15
        gfx.DrawString("Terima kasih telah menunaikan kewajiban perpajakan Anda.", fontSmall, XBrushes.Gray, New XPoint(xLeft, yPoint))

        ' 3. Simpan File
        Dim sanitizedNpwp As String = npwp.Replace(".", "").Replace("-", "")
        Dim fileName As String = $"BPE_SPT_2025_{sanitizedNpwp}_{DateTime.Now.ToString("yyyyMMddHHmmss")}.pdf"
        Dim folderPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Benice_Reports")
        
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        
        Dim fullPath As String = Path.Combine(folderPath, fileName)
        document.Save(fullPath)

        ' Biarkan user tahu
        MsgBox("Laporan PDF berhasil disimpan di:" & vbCrLf & fullPath, MsgBoxStyle.Information, "Export PDF Sukses")
        
        ' Coba buka file
        Try
            Dim p As New ProcessStartInfo(fullPath) With {.UseShellExecute = True}
            Process.Start(p)
        Catch
            ' Ignore
        End Try

    End Sub

    Private Sub DrawRow(gfx As XGraphics, label As String, value As String, font As XFont, col1 As Double, col2 As Double, ByRef yPoint As Double)
        gfx.DrawString(label, font, XBrushes.Black, New XPoint(col1, yPoint))
        gfx.DrawString(value, font, XBrushes.Black, New XPoint(col2, yPoint))
        yPoint += 25
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New Form2()
        Form2.CurrentNpwp = CurrentNpwp
        form2.Show()
        Me.Close()
    End Sub
End Class