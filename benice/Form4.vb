Imports System.Collections.Generic
Imports System.Windows.Forms
Imports Mysqlx.XDevAPI.Common

Public Class Form4

    Private ActiveSptID As Integer = 0
    Public Property CurrentNpwp As String = ""
    Private _currentStatus As String = "" ' Untuk menyimpan status hasil perhitungan

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Ambil ID WP dari NPWP
        Dim idWp As Integer = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)

        If idWp <> 0 Then
            Modulekoneksi.ActiveWP_ID = idWp
            ActiveSptID = Modulekoneksi.GetActiveSptId(idWp)
        End If

        If ActiveSptID = 0 Then
            MsgBox("PERINGATAN: Tidak ditemukan data SPT Tahunan aktif. Status hasil perhitungan tidak akan disimpan ke database.", MsgBoxStyle.Information)
        End If

        lblStatusResult.Text = "[Belum dihitung]"
    End Sub

    Private Async Sub btnHitungStatus_Click(sender As Object, e As EventArgs) Handles btnHitungStatus.Click

        If Not CheckAllQuestionsAnswered() Then
            MsgBox("Harap jawab SEMUA pertanyaan (Q1 sampai Q7) sebelum menghitung status.", MsgBoxStyle.Exclamation, "Jawaban Belum Lengkap")
            Return
        End If

        btnHitungStatus.Enabled = False
        lblStatusResult.Text = "Sedang Menghitung Status..."

        Try
            ' 1. Ambil Status Hitungan Matematis (dari Form 3)
            Dim dbStatus As String = Modulekoneksi.GetStatusSpt(ActiveSptID)
            If String.IsNullOrEmpty(dbStatus) Then dbStatus = "nihil"
            dbStatus = dbStatus.ToLower()

            ' 2. Panggil API Prolog (Untuk profil risiko)
            Dim qValues As New List(Of Integer)
            qValues.Add(If(rbQ1Ya.Checked, 1, 0)) ' Q1: punya_npwp
            qValues.Add(If(rbQ2Ya.Checked, 1, 0)) ' Q2: punya_penghasilan
            qValues.Add(If(rbQ3Ya.Checked, 1, 0)) ' Q3: sumber_penghasilan_ganda
            qValues.Add(If(rbQ4Ya.Checked, 1, 0)) ' Q4: resign_tengah_tahun
            qValues.Add(If(rbQ5Ya.Checked, 1, 0)) ' Q5: gaji_fluktuatif
            qValues.Add(If(rbQ6Ya.Checked, 1, 0)) ' Q6: ada_bukti_zakat
            qValues.Add(If(rbQ7Ya.Checked, 1, 0)) ' Q7: terlambat_lapor

            Dim client As New PrologClient()
            ' Kita panggil Prolog tapi tidak biarkan meng-overwrite status pembayaran jika ada uang terlibat
            Dim result As PrologClient.SptResult = Await client.GetSptStatus(qValues)
            Dim statusProlog As String = result.status_spt.ToLower()

            ' 3. Logika Penentuan Status Akhir
            ' PRIORITAS UTAMA: HASIL SISTEM PAKAR (KUESIONER)
            ' Sesuai permintaan user: status harus sesuai dengan sistem pakar.
            
            ' Ambil status math sebagai referensi nilai uang saja
            Dim mathStatus As String = dbStatus 

            If statusProlog = "kurang_bayar" Then
                ' Sistem Pakar mendeteksi Kurang Bayar -> SET STATUS KURANG BAYAR
                ' Meskipun hitungan math 0, status tetap Kurang Bayar (user mungkin salah input nilai di form sebelumnya)
                _currentStatus = "kurang_bayar"
                
                If mathStatus = "kurang_bayar" Then
                    lblStatusResult.Text = "KURANG BAYAR"
                Else
                    ' Math bilang Nihil/Lebih, tapi Prolog bilang Kurang.
                    ' Kita tetap set status Kurang Bayar, tapi beri indikasi bahwa nilai uang mungkin perlu dicek.
                    lblStatusResult.Text = "KURANG BAYAR (CEK NILAI PENGHASILAN)"
                End If

            ElseIf statusProlog = "lebih_bayar" Then
                 ' Sistem Pakar mendeteksi Lebih Bayar
                _currentStatus = "lebih_bayar"
                
                If mathStatus = "lebih_bayar" Then
                    lblStatusResult.Text = "LEBIH BAYAR"
                Else
                    lblStatusResult.Text = "LEBIH BAYAR (CEK NILAI BUKTI POTONG)"
                End If

            Else
                ' Sistem Pakar Netral/Nihil -> Ikuti Hitungan Math
                Select Case mathStatus
                    Case "kurang_bayar"
                        lblStatusResult.Text = "KURANG BAYAR"
                        _currentStatus = "kurang_bayar"
                    Case "lebih_bayar"
                        lblStatusResult.Text = "LEBIH BAYAR"
                        _currentStatus = "lebih_bayar"
                    Case Else
                        If statusProlog = "tidak_wajib_lapor" Then
                            lblStatusResult.Text = "TIDAK WAJIB LAPOR"
                            _currentStatus = "nihil"
                        Else
                            lblStatusResult.Text = "NIHIL"
                            _currentStatus = "nihil"
                        End If
                End Select
            End If

            ' 4. Final Update ke DB agar konsisten saat navigasi
            Modulekoneksi.UpdateStatusSPT(ActiveSptID, _currentStatus)

        Catch ex As Exception
            lblStatusResult.Text = "[Terjadi Kesalahan]"
            MsgBox("Error: " & ex.Message)
            _currentStatus = "ERROR"
        Finally
            btnHitungStatus.Enabled = True
        End Try

    End Sub

    ' --- Event Handler Tombol Lanjut Ke Halaman ---
    Private Sub btnLanjut_Click(sender As Object, e As EventArgs) Handles btnLanjut.Click
        If String.IsNullOrEmpty(_currentStatus) OrElse _currentStatus = "ERROR" Then
            MsgBox("Harap hitung status SPT terlebih dahulu.", MsgBoxStyle.Exclamation, "Status Belum Dihitung")
            Return
        End If

        Select Case _currentStatus
            Case "kurang_bayar"
                ' Navigasi ke Form5 (Kurang Bayar)
                Dim form5 As New Form5()
                form5.CurrentNpwp = CurrentNpwp
                form5.TargetSptId = ActiveSptID ' Ensure matching ID
                form5.Show()
                Me.Hide()
            Case "lebih_bayar"
                ' Navigasi ke Form6 (Lebih Bayar)
                Dim form6 As New Form6()
                form6.CurrentNpwp = CurrentNpwp
                form6.Show()
                Me.Hide()
            Case "nihil"
                ' Navigasi langsung ke Form7 (Submit)
                Dim form7 As New Form7()
                form7.CurrentNpwp = CurrentNpwp
                form7.Show()
                Me.Hide()
            Case Else
                MsgBox($"Status SPT tidak dapat diproses: {_currentStatus}", MsgBoxStyle.Exclamation, "Error Status")
        End Select

    End Sub

    ' Fungsi untuk memastikan user telah menjawab semua pertanyaan
    Private Function CheckAllQuestionsAnswered() As Boolean
        If Not (rbQ1Ya.Checked Or rbQ1Tidak.Checked) Then Return False
        If Not (rbQ2Ya.Checked Or rbQ2Tidak.Checked) Then Return False
        If Not (rbQ3Ya.Checked Or rbQ3Tidak.Checked) Then Return False
        If Not (rbQ4Ya.Checked Or rbQ4Tidak.Checked) Then Return False
        If Not (rbQ5Ya.Checked Or rbQ5Tidak.Checked) Then Return False
        If Not (rbQ6Ya.Checked Or rbQ6Tidak.Checked) Then Return False
        If Not (rbQ7Ya.Checked Or rbQ7Tidak.Checked) Then Return False
        Return True
    End Function



End Class