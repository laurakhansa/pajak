Imports System.Windows.Forms
Imports System.Convert

Public Class Form3

    ' Properti untuk menyimpan NPWP dari Form2
    Public Property CurrentNpwp As String = ""
    Private _activeSptId As Integer = 0
    Private _idWp As Integer = 0
    Private _isNavigating As Boolean = False
    Private _isInitializing As Boolean = True

    ' Explicit Constructor to ensure InitializeComponent is called
    Public Sub New()
        Try
            ' This call is required by the designer.
            InitializeComponent()
        Catch ex As Exception
            MsgBox("Error initializing Form3 components: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical)
        End Try

        ' Add any initialization after the InitializeComponent() call.
        _isInitializing = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Setup awal - Check for null to avoid NRE
            If tabMain IsNot Nothing Then
                tabMain.SelectedIndex = 0
            End If

            ' Sembunyikan tombol Next di tab 1 dan 2
            btnNextPenghasilanLain.Visible = False
            btnNextPerhitungan.Visible = False


            ' Ambil ID WP
            _idWp = Modulekoneksi.GetWpIdByNpwp(CurrentNpwp)
            If _idWp = 0 Then
                MsgBox("Error: NPWP tidak ditemukan di database.", MsgBoxStyle.Critical)
                Me.Close()
                Return
            End If

            ' Buat atau Ambil SPT Tahunan Aktif (Tahun 2025 misal)
            ' Untuk demo ini kita hardcode tahun 2025
            _activeSptId = Modulekoneksi.CreateOrGetSpt(_idWp, 2025)

            ' Load Data Bukti Potong
            LoadDataBuktiPotong()

        Catch ex As Exception
            MsgBox("Error loading Form3: " & ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    ' --- TAB 1: BUKTI POTONG ---
    ' --- TAB 1: BUKTI POTONG ---
    ' Load otomatis data saat form dimuat atau tab diakses
    Private Sub LoadDataBuktiPotong()
        ' Ambil data total gaji dan pph dari database berdasarkan NPWP
        Dim totalGaji As Decimal = Modulekoneksi.GetTotalPendapatanTahun(CurrentNpwp, 2025)
        Dim totalPotongan As Decimal = Modulekoneksi.GetTotalPphDipotongTahun(CurrentNpwp, 2025)

        txtBuktiPotong.ReadOnly = True ' Form 3: Hanya verifikasi, bukan input manual

        If totalGaji > 0 Then
            txtBuktiPotong.Text = totalGaji.ToString("N0")
        Else
            txtBuktiPotong.Text = "0"
            ' Jika data 0, tampilkan pesan informatif bahwa data dari perusahaan belum masuk
            ' User tidak bisa edit, jadi mereka harus tahu kenapa 0.
            MessageBox.Show("Data Bukti Potong belum tersedia dari Pemberi Kerja." & vbCrLf & 
                            "Silakan hubungi bagian Keuangan/HRD perusahaan Anda untuk melakukan upload data ke Korteks.", 
                            "Data Kosong", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        
        ' Simpan potongan (Kredit Pajak) di TextBox hidden atau langsung ke Tab 3 nanti
        ' Kita bisa simpan di properti sementara atau langsung akses saat calculation
        ' Tapi agar user lihat, kita bisa taruh di tag atau variabel sementara
        txtTotalKreditPajak.Tag = totalPotongan ' Simpan nilai desimal asli
        txtTotalKreditPajak.Text = totalPotongan.ToString("N0")
    End Sub

    Private Sub chkSetuju_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetuju.CheckedChanged
        If _isInitializing Then Return

        If chkSetuju.Checked AndAlso Not _isNavigating Then
            ' Otomatis lanjut ke Tab 2
            _isNavigating = True
            tabMain.SelectedIndex = 1
            _isNavigating = False
        End If
    End Sub

    ' --- TAB 2: PENGHASILAN LAIN ---
    ' Navigasi otomatis saat semua data diisi
    Private Sub cboStatusPerkawinan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusPerkawinan.SelectedIndexChanged
        If _isInitializing Then Return

        If Not _isNavigating Then
            CheckAndNavigateFromTab2()
        End If
    End Sub

    Private Sub txtJumlahTanggungan_TextChanged(sender As Object, e As EventArgs) Handles txtJumlahTanggungan.TextChanged
        If _isInitializing Then Return

        If Not _isNavigating Then
            CheckAndNavigateFromTab2()
        End If
    End Sub

    Private Sub txtPenghasilanLain_TextChanged(sender As Object, e As EventArgs) Handles txtPenghasilanLain.TextChanged
        ' Update perhitungan setiap ada perubahan di input penghasilan lain
        If Not _isInitializing Then
            PerformTaxCalculation()
        End If
    End Sub

    Private Sub CheckAndNavigateFromTab2()
        ' Cek apakah semua data sudah diisi dengan benar
        If cboStatusPerkawinan.SelectedIndex >= 0 AndAlso
           Not String.IsNullOrWhiteSpace(txtJumlahTanggungan.Text) AndAlso
           IsNumeric(txtJumlahTanggungan.Text) Then
            
            ' Validasi jumlah tanggungan
            Dim jmlTanggungan As Integer
            If Integer.TryParse(txtJumlahTanggungan.Text, jmlTanggungan) AndAlso jmlTanggungan >= 0 AndAlso jmlTanggungan <= 10 Then
                ' Hitung perhitungan pajak
                PerformTaxCalculation()
                
                ' Otomatis lanjut ke Tab 3
                If tabMain.SelectedIndex = 1 AndAlso Not _isNavigating Then
                    _isNavigating = True
                    tabMain.SelectedIndex = 2
                    _isNavigating = False
                End If
            End If
        End If
    End Sub

    ' --- TAB 3: PERHITUNGAN & SAVING ---
    ' --- TAB 3: PERHITUNGAN & SAVING ---
    Private Sub btnNextKuesioner_Click(sender As Object, e As EventArgs) Handles btnNextKuesioner.Click
        
        ' Validasi akhir
        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("NPWP tidak terdeteksi. Silakan login ulang.", MsgBoxStyle.Critical)
            Return
        End If

        ' Validasi kredit pajak harus diisi
        If String.IsNullOrWhiteSpace(txtTotalKreditPajak.Text) Then
            MsgBox("Silakan isi Total Kredit Pajak terlebih dahulu.", MsgBoxStyle.Exclamation, "Data Belum Lengkap")
            txtTotalKreditPajak.Focus()
            Return
        End If

        ' 1. HITUNG ULANG (Safety)
        PerformTaxCalculation()

        ' 2. AMBIL NILAI DETIL
        Dim incBuktiPotong As Decimal = ParseDecimal(txtBuktiPotong.Text)
        Dim incLain As Decimal = ParseDecimal(txtPenghasilanLain.Text)
        Dim totalNetto As Decimal = ParseDecimal(txtTotalPenghasilanSetahun.Text)
        Dim valPtkp As Decimal = ParseDecimal(txtPtkp.Text)
        Dim valPkp As Decimal = If(totalNetto - valPtkp > 0, totalNetto - valPtkp, 0)
        Dim valTerutang As Decimal = ParseDecimal(txtPphTerutang.Text)
        Dim valKredit As Decimal = ParseDecimal(txtTotalKreditPajak.Text)
        Dim valSelisih As Decimal = valTerutang - valKredit

        ' 3. SKIP KONFIRMASI (Sesuai Request User)
        ' Lanjut simpan data


        ' SIMPAN KE DATABASE
        If Modulekoneksi.SaveSptDetail(_activeSptId, totalNetto, valPtkp, valTerutang, valKredit) Then
            ' Navigasi ke Form4
            Dim form4 As New Form4()
            form4.CurrentNpwp = CurrentNpwp
            form4.Show()
            Me.Hide()
        Else
            MsgBox("Gagal menyimpan data perhitungan. Silakan coba lagi.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    ' --- FUNGSI PERHITUNGAN ---
    Private Sub PerformTaxCalculation()
        ' 1. Hitung Penghasilan Bruto
        Dim penghasilanBuktiPotong As Decimal = ParseDecimal(txtBuktiPotong.Text)
        Dim penghasilanLain As Decimal = ParseDecimal(txtPenghasilanLain.Text)
        Dim penghasilanBruto As Decimal = penghasilanBuktiPotong + penghasilanLain

        ' 2. Hitung Biaya Jabatan (Max 6.000.000 setahun atau 5%)
        Dim biayaJabatan As Decimal = penghasilanBruto * 0.05D
        If biayaJabatan > 6000000 Then biayaJabatan = 6000000

        ' 3. Hitung Penghasilan Netto (Total Penghasilan Setahun sesuai SOP)
        Dim totalPenghasilanNetto As Decimal = penghasilanBruto - biayaJabatan
        
        ' 4. Hitung PTKP
        Dim ptkp As Decimal = CalculatePtkp()

        ' 5. Hitung PKP (Penghasilan Kena Pajak)
        Dim pkp As Decimal = totalPenghasilanNetto - ptkp
        If pkp < 0 Then pkp = 0
        pkp = Math.Floor(pkp / 1000) * 1000 ' Pembulatan ke bawah ribuan (Aturan Pajak Umum)

        ' 4. Hitung PPh Terutang (Tarif Progresif UU HPP)
        Dim pphTerutang As Decimal = CalculatePphProgresif(pkp)

        ' Tampilkan ke TextBox (Format Rupiah)
        txtTotalPenghasilanSetahun.Text = totalPenghasilanNetto.ToString("N0")
        txtPtkp.Text = ptkp.ToString("N0")
        txtPphTerutang.Text = pphTerutang.ToString("N0")
        
        ' Set Kredit Pajak jika belum diisi user (seharusnya sudah diisi dari LoadDataBuktiPotong)
        If String.IsNullOrEmpty(txtTotalKreditPajak.Text) Then
             ' Coba ambil dari Tag jika ada
             If txtTotalKreditPajak.Tag IsNot Nothing Then
                 Dim val As Decimal = CDec(txtTotalKreditPajak.Tag)
                 txtTotalKreditPajak.Text = val.ToString("N0")
             Else
                 txtTotalKreditPajak.Text = "0"
             End If
        End If
    End Sub

    Private Function CalculatePtkp() As Decimal
        Dim basePtkp As Decimal = 54000000
        Dim tambahanKawin As Decimal = 4500000
        Dim tambahanTanggungan As Decimal = 4500000
        Dim totalPtkp As Decimal = basePtkp

        ' Status Kawin
        ' Index 0: Belum Kawin, 1: Kawin, 2: Kawin dengan tanggungan (Logic sederhana: Kawin = +4.5jt)
        ' Sesuaikan dengan item combobox: {"Belum Kawin", "Kawin", "Kawin dengan tanggungan"}
        If cboStatusPerkawinan.SelectedIndex > 0 Then ' Kawin atau Kawin + Tanggungan
            totalPtkp += tambahanKawin
        End If

        ' Jumlah Tanggungan (Max 3)
        Dim jmlTanggungan As Integer = 0
        If Integer.TryParse(txtJumlahTanggungan.Text, jmlTanggungan) Then
            If jmlTanggungan > 3 Then jmlTanggungan = 3
            totalPtkp += (jmlTanggungan * tambahanTanggungan)
        End If

        Return totalPtkp
    End Function

    Private Function CalculatePphProgresif(ByVal pkp As Decimal) As Decimal
        Dim pph As Decimal = 0
        
        ' Lapisan 1: 0 - 60 Juta (5%)
        If pkp > 0 Then
            Dim layer1 As Decimal = Math.Min(pkp, 60000000)
            pph += layer1 * 0.05D
            pkp -= layer1
        End If

        ' Lapisan 2: >60 - 250 Juta (15%)
        If pkp > 0 Then
            Dim layer2 As Decimal = Math.Min(pkp, 190000000) ' 250 - 60
            pph += layer2 * 0.15D
            pkp -= layer2
        End If

         ' Lapisan 3: >250 - 500 Juta (25%)
        If pkp > 0 Then
            Dim layer3 As Decimal = Math.Min(pkp, 250000000) ' 500 - 250
            pph += layer3 * 0.25D
            pkp -= layer3
        End If

        ' Lapisan 4: >500 Juta - 5 Miliar (30%)
        If pkp > 0 Then
            Dim layer4 As Decimal = Math.Min(pkp, 4500000000) ' 5M - 500
            pph += layer4 * 0.3D
            pkp -= layer4
        End If
        
        ' Lapisan 5: >5 Miliar (35%)
        If pkp > 0 Then
             pph += pkp * 0.35D
        End If

        Return pph
    End Function

    Private Function ParseDecimal(ByVal text As String) As Decimal
        Dim val As Decimal = 0
        ' Hilangkan format ribuan (titik/koma tergantung locale, kita asumsi input bersih atau N0 format)
        ' N0 format pakai koma/titik. Kita replace non-numeric chars kecuali koma/titik desimal.
        ' Cara aman: Gunakan Decimal.TryParse
        Decimal.TryParse(text.Replace(",", "").Replace(".", ""), val)
        ' Note: Parsing ini sederhana. Jika user input "1.000.000", replace all . -> 1000000. 
        ' Jika input "1000000,00", replace . -> 1000000,00 -> ok? Tergantung CultureInfo. 
        ' Untuk simpelnya, anggap input angka polos.
        Return val
    End Function

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim form2 As New Form2()
        Form2.CurrentNpwp = CurrentNpwp
        form2.Show()
        Me.Close()
    End Sub

End Class