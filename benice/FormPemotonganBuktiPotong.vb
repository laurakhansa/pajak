Imports System.Convert

Public Class FormPemotonganBuktiPotong

    Private ReadOnly _currentNpwp As String
    Private _idPk As Integer = 0
    Private _currentPph As Decimal = 0

    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        Me.Text = "Pemotongan & Bukti Potong - NPWP PK: " & _currentNpwp
    End Sub

    Private Sub FormPemotonganBuktiPotong_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _idPk = Modulekoneksi.GetPkIdByNpwp(_currentNpwp)
        LoadDataPegawai()
    End Sub

    Private Sub LoadDataPegawai()
        Dim dt As DataTable = Modulekoneksi.GetPegawaiList(_idPk)
        cmbPegawai.DataSource = dt
        cmbPegawai.DisplayMember = "nama_pegawai"
        cmbPegawai.ValueMember = "id_pegawai"
        cmbPegawai.SelectedIndex = -1
    End Sub

    Private Sub btnHitungPph_Click(sender As Object, e As EventArgs) Handles btnHitungPph.Click
        If cmbPegawai.SelectedIndex = -1 Then
            MsgBox("Pilih pegawai terlebih dahulu.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim gaji As Decimal = 0
        Dim tunjangan As Decimal = 0
        Dim iuran As Decimal = 0

        Decimal.TryParse(txtGajiPokok.Text, gaji)
        Decimal.TryParse(txtTunjangan.Text, tunjangan)
        Decimal.TryParse(txtIuranPensiun.Text, iuran)

        ' Ambil Status Pegawai dari ComboBox (DataRowView)
        Dim row As DataRowView = CType(cmbPegawai.SelectedItem, DataRowView)
        Dim statusKawin As String = row("status_kawin").ToString()
        Dim tanggungan As Integer = Convert.ToInt32(row("jumlah_tanggungan"))

        ' 1. Bruto
        Dim bruto As Decimal = gaji + tunjangan
        
        ' 2. Biaya Jabatan (5%, Max 500rb)
        Dim bjabatan As Decimal = bruto * 0.05D
        If bjabatan > 500000 Then bjabatan = 500000

        ' 3. Netto Sebulan
        Dim nettoSebulan As Decimal = bruto - bjabatan - iuran

        ' 4. Netto Setahun
        Dim nettoSetahun As Decimal = nettoSebulan * 12

        ' 5. PTKP
        Dim ptkp As Decimal = 54000000 ' Base
        If statusKawin.ToUpper() = "K" OrElse statusKawin.ToUpper() = "KAWIN" Then ptkp += 4500000
        Dim maksTanggungan As Integer = If(tanggungan > 3, 3, tanggungan)
        ptkp += (maksTanggungan * 4500000)

        ' 6. PKP
        Dim pkp As Decimal = nettoSetahun - ptkp
        If pkp < 0 Then pkp = 0
        pkp = Math.Floor(pkp / 1000) * 1000 ' Pembulatan ke bawah ribuan

        ' 7. PPh Terutang Setahun (Progresif)
        Dim pphThn As Decimal = CalculatePphProgresif(pkp)
        Dim pphBln As Decimal = pphThn / 12

        _currentPph = pphBln
        MsgBox("Perhitungan PPh Pasal 21:" & vbCrLf & _
               "Gaji Bruto: " & bruto.ToString("N0") & vbCrLf & _
               "PTKP: " & ptkp.ToString("N0") & vbCrLf & _
               "PKP: " & pkp.ToString("N0") & vbCrLf & _
               "PPh Terutang (Thn): " & pphThn.ToString("N0") & vbCrLf & _
               "PPh Dipotong (Bln): " & pphBln.ToString("N0"), MsgBoxStyle.Information, "Hasil Perhitungan")
    End Sub

    Private Function CalculatePphProgresif(ByVal pkp As Decimal) As Decimal
        Dim pph As Decimal = 0
        If pkp > 0 Then
            Dim layer1 As Decimal = Math.Min(pkp, 60000000)
            pph += layer1 * 0.05D
            pkp -= layer1
        End If
        If pkp > 0 Then
            Dim layer2 As Decimal = Math.Min(pkp, 190000000)
            pph += layer2 * 0.15D
            pkp -= layer2
        End If
         If pkp > 0 Then
            Dim layer3 As Decimal = Math.Min(pkp, 250000000)
            pph += layer3 * 0.25D
            pkp -= layer3
        End If
        If pkp > 0 Then
            Dim layer4 As Decimal = Math.Min(pkp, 4500000000)
            pph += layer4 * 0.3D
            pkp -= layer4
        End If
        If pkp > 0 Then
             pph += pkp * 0.35D
        End If
        Return pph
    End Function

    Private Sub btnCetakBuktiPotong_Click(sender As Object, e As EventArgs) Handles btnCetakBuktiPotong.Click
        If cmbPegawai.SelectedIndex = -1 Then Return
        
        Dim gaji As Decimal = 0
        Dim tunjangan As Decimal = 0
        Dim iuran As Decimal = 0
        Decimal.TryParse(txtGajiPokok.Text, gaji)
        Decimal.TryParse(txtTunjangan.Text, tunjangan)
        Decimal.TryParse(txtIuranPensiun.Text, iuran)

        Dim idPegawai As Integer = Convert.ToInt32(cmbPegawai.SelectedValue)

        If Modulekoneksi.SaveTransaksiGaji(_idPk, idPegawai, gaji, tunjangan, iuran, _currentPph) Then
             MsgBox("Bukti Potong PPh 21 berhasil disimpan dan dicetak (Simulasi PDF).", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim menuForm As New FormMenuPemberiKerja()
        FormMenuPemberiKerja.CurrentNpwp = _currentNpwp
        menuForm.Show()
        Me.Close()
    End Sub

End Class

