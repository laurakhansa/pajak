Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Convert
Imports System.Windows.Forms ' DITAMBAHKAN: Untuk mengatasi error BC30456 (MsgBoxStyle)

Module Modulekoneksi

    ' --- 1. VARIABEL KONEKSI & CONNECTION STRING ---
    Public koneksi As MySqlConnection ' Sudah Public
    Public connectionString As String = "server=localhost;database=benice;uid=root;password="

    ' Variabel global untuk ID Wajib Pajak (WP) yang sedang aktif
    Public ActiveWP_ID As Integer = 123 ' >>> HARAP GANTI DENGAN ID WP AKTIF YANG SESUNGGUHNYA <<<

    ' --- 2. CLASS MODEL DATA (Semua harus Public) ---
    Public Class WpProfileData
        Public Property npwp As String
        Public Property nama As String
        Public Property email As String
        Public Property no_handphone As String
        Public Property alamat As String
    End Class

    Public Class PegawaiData
        Public Property id_pegawai As Integer
        Public Property npwp_pegawai As String
        Public Property nama_pegawai As String
        Public Property status_kawin As String
        Public Property jumlah_tanggungan As Integer
        Public Property jabatan As String
    End Class

    ' --- 3. FUNGSI DASAR KONEKSI (Semua harus Public) ---
    Public Sub BukaKoneksi() ' DIPERBAIKI: Harus Public (Mengatasi error BC30451)
        Try
            koneksi = New MySqlConnection(connectionString)
            If koneksi.State = ConnectionState.Closed Then
                koneksi.Open()
            End If
        Catch ex As Exception
            MsgBox("Koneksi ke database GAGAL: " & ex.Message, MsgBoxStyle.Critical, "Error Koneksi")
        End Try
    End Sub

    Public Sub TutupKoneksi() ' DIPERBAIKI: Harus Public (Mengatasi error BC30451)
        If koneksi IsNot Nothing AndAlso koneksi.State = ConnectionState.Open Then
            koneksi.Close()
        End If
    End Sub

    ' --- 4. FUNGSI QUERY KHUSUS (Semua harus Public) ---

    Public Function GetWpProfile(ByVal npwp As String) As WpProfileData ' DIPERBAIKI: Harus Public (Mengatasi error BC30451)
        Dim data As WpProfileData = Nothing
        Dim query As String = "SELECT npwp, nama, email, no_handphone, alamat FROM wp_profil WHERE npwp = @npwp"

        BukaKoneksi()

        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@npwp", npwp)

                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        data = New WpProfileData() With {
                            .npwp = reader("npwp").ToString(),
                            .nama = reader("nama").ToString(),
                            .email = reader("email").ToString(),
                            .no_handphone = If(reader("no_handphone") Is DBNull.Value, "", reader("no_handphone").ToString()),
                            .alamat = If(reader("alamat") Is DBNull.Value, "", reader("alamat").ToString())
                        }
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Biarkan form yang menangani error spesifik
        Finally
            TutupKoneksi()
        End Try
        Return data
    End Function

    Public Function UpdateWpProfile(ByVal data As WpProfileData) As Boolean ' DIPERBAIKI: Harus Public (Mengatasi error BC30451)
        Dim success As Boolean = False
        Dim query As String = "UPDATE wp_profil SET nama = @nama, email = @email, no_handphone = @hp, alamat = @alamat WHERE npwp = @npwp"

        BukaKoneksi()

        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@nama", data.nama)
                cmd.Parameters.AddWithValue("@email", data.email)
                cmd.Parameters.AddWithValue("@hp", data.no_handphone)
                cmd.Parameters.AddWithValue("@alamat", data.alamat)
                cmd.Parameters.AddWithValue("@npwp", data.npwp)

                If cmd.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal menyimpan perubahan: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function

    ' FUNGSI BARU UNTUK INTEGRASI PROLOG
    Public Function GetActiveSptId(ByVal id_wp As Integer) As Integer ' DIPERBAIKI: Harus Public
        Dim id_spt As Integer = 0
        Dim query As String = "SELECT id_spt FROM spt_tahunan WHERE id_wp = @id_wp ORDER BY tahun_pajak DESC, tanggal_lapor DESC LIMIT 1"

        BukaKoneksi()

        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@id_wp", id_wp)

                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    id_spt = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil ID SPT aktif: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try
        Return id_spt
    End Function

    Public Function UpdateStatusSPT(ByVal idSpt As Integer, ByVal statusPerhitungan As String) As Boolean ' DIPERBAIKI: Harus Public
        Dim success As Boolean = False
        Dim query As String = "UPDATE perhitungan_spt SET jenis_pembayaran_akhir = @Status WHERE id_spt = @IDSpt"

        BukaKoneksi()

        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@Status", statusPerhitungan)
                cmd.Parameters.AddWithValue("@IDSpt", idSpt)

                If cmd.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal menyimpan Status SPT: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function

    Public Function GetWpIdByNpwp(ByVal npwp As String) As Integer
        Dim id_wp As Integer = 0
        Dim query As String = "SELECT id_wp FROM wp_profil WHERE npwp = @npwp"

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@npwp", npwp)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    id_wp = Convert.ToInt32(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil ID WP: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try
        Return id_wp
    End Function

    ' Mengambil Jumlah Kurang Bayar (dari kolom 'jumlah_kurang_lebih_bayar' di tabel 'perhitungan_spt')
    ' Jika positif = kurang bayar, jika negatif = lebih bayar
    Public Function GetJumlahKurangBayar(ByVal idSpt As Integer) As Decimal
        Dim jumlah As Decimal = 0
        Dim query As String = "SELECT jumlah_kurang_lebih_bayar FROM perhitungan_spt WHERE id_spt = @IDSpt"

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@IDSpt", idSpt)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Dim nilai As Decimal = Convert.ToDecimal(result)
                    
                    ' Jika positif, itu kurang bayar (misal 500000)
                    ' Jika negatif, itu lebih bayar (misal -500000)
                    ' Kita ingin mengambil nilai Kurang Bayar, jadi ambil jika > 0
                    If nilai > 0 Then
                        jumlah = nilai
                    End If
                End If
            End Using
        Finally
            TutupKoneksi()
        End Try
        Return jumlah
    End Function

    ' Mengambil Jumlah Lebih Bayar (dari kolom 'jumlah_kurang_lebih_bayar' di tabel 'perhitungan_spt')
    ' Jika negatif = lebih bayar
    Public Function GetJumlahLebihBayar(ByVal idSpt As Integer) As Decimal
        Dim jumlah As Decimal = 0
        Dim query As String = "SELECT jumlah_kurang_lebih_bayar FROM perhitungan_spt WHERE id_spt = @IDSpt"

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@IDSpt", idSpt)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Dim nilai As Decimal = Convert.ToDecimal(result)
                    ' Jika negatif, itu lebih bayar (ambil nilai absolut)
                    If nilai < 0 Then
                        jumlah = Math.Abs(nilai)
                    End If
                End If
            End Using
        Finally
            TutupKoneksi()
        End Try
        Return jumlah
    End Function

    ' Finalisasi SPT Tahunan (Update tanggal lapor dan status final di tabel spt_tahunan)
    Public Function FinalizeSpt(ByVal idSpt As Integer, ByVal statusFinal As String) As Boolean
        Dim success As Boolean = False
        Dim query As String = "UPDATE spt_tahunan SET tanggal_lapor = NOW(), status = @StatusFinal WHERE id_spt = @IDSpt"

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                ' Konversi status ke format yang sesuai dengan database
                Dim statusDb As String = ""
                Select Case statusFinal.ToLower()
                    Case "nihil"
                        statusDb = "Nihil"
                    Case "kurang_bayar"
                        statusDb = "Kurang Bayar"
                    Case "lebih_bayar"
                        statusDb = "Lebih Bayar"
                    Case Else
                        statusDb = statusFinal
                End Select

                cmd.Parameters.AddWithValue("@StatusFinal", statusDb)
                cmd.Parameters.AddWithValue("@IDSpt", idSpt)

                If cmd.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal memfinalisasi SPT: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function

    ' Mengambil status SPT dari perhitungan_spt
    Public Function GetStatusSpt(ByVal idSpt As Integer) As String
        Dim status As String = ""
        Dim query As String = "SELECT jenis_pembayaran_akhir FROM perhitungan_spt WHERE id_spt = @IDSpt"

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@IDSpt", idSpt)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    status = result.ToString()
                End If
            End Using
        Catch ex As Exception
            ' Silent fail
        Finally
            TutupKoneksi()
        End Try
        Return status
    End Function

    ' --- FUNGSI SIMPAN DATA HASIL PERHITUNGAN FORM 3 ---
    Public Function SaveSptDetail(ByVal idSpt As Integer, ByVal totalPenghasilan As Decimal, ByVal ptkp As Decimal, ByVal pphTerutang As Decimal, ByVal kreditPajak As Decimal) As Boolean
        Dim success As Boolean = False
        ' Asumsi: Data disimpan ke tabel 'perhitungan_spt'. 
        ' Kita perlu cek apakah record sudah ada untuk id_spt ini, jika belum INSERT, jika sudah UPDATE.
        ' Untuk penyederhanaan, kita gunakan INSERT ON DUPLICATE KEY UPDATE atau Cek dulu.

        Dim checkQuery As String = "SELECT COUNT(*) FROM perhitungan_spt WHERE id_spt = @idSpt"
        Dim query As String = ""

        BukaKoneksi()
        Try
            Dim count As Integer = 0
            Using cmdCheck As New MySqlCommand(checkQuery, koneksi)
                cmdCheck.Parameters.AddWithValue("@idSpt", idSpt)
                count = Convert.ToInt32(cmdCheck.ExecuteScalar())
            End Using

            ' Hitung Kurang/Lebih Bayar sederhana untuk disimpan
            ' Hitung Kurang/Lebih Bayar sederhana untuk disimpan
            ' Pastikan presisi desimal terjaga
            Dim selisih As Decimal = pphTerutang - kreditPajak
            
            ' Debug log (bisa dihapus nanti)
            ' MsgBox($"DEBUG DB SAVE: Terutang={pphTerutang}, Kredit={kreditPajak}, Selisih={selisih}")
            
            Dim status As String = ""
            If selisih > 0 Then
                status = "kurang_bayar"
            ElseIf selisih < 0 Then
                status = "lebih_bayar"
            Else
                status = "nihil"
            End If

            If count > 0 Then
                ' UPDATE
                query = "UPDATE perhitungan_spt SET total_penghasilan_setahun = @total, ptkp = @ptkp, pph_terutang = @pph, total_kredit_pajak = @kredit, jumlah_kurang_lebih_bayar = @selisih, jenis_pembayaran_akhir = @status WHERE id_spt = @idSpt"
            Else
                ' INSERT
                query = "INSERT INTO perhitungan_spt (id_spt, total_penghasilan_setahun, ptkp, pph_terutang, total_kredit_pajak, jumlah_kurang_lebih_bayar, jenis_pembayaran_akhir) VALUES (@idSpt, @total, @ptkp, @pph, @kredit, @selisih, @status)"
            End If


            
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@idSpt", idSpt)
                cmd.Parameters.AddWithValue("@total", totalPenghasilan)
                cmd.Parameters.AddWithValue("@ptkp", ptkp)
                cmd.Parameters.AddWithValue("@pph", pphTerutang)
                cmd.Parameters.AddWithValue("@kredit", kreditPajak)
                cmd.Parameters.AddWithValue("@selisih", selisih)
                cmd.Parameters.AddWithValue("@status", status)

                If cmd.ExecuteNonQuery() > 0 Then
                    success = True
                End If
            End Using

        Catch ex As Exception
            MsgBox("Gagal menyimpan detail SPT: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            TutupKoneksi()
        End Try

        Return success
    End Function

    ' Fungsi Helper untuk membuat SPT Tahunan baru jika belum ada (Dipanggil di awal Form3 jika perlu)
    Public Function CreateOrGetSpt(ByVal idWp As Integer, ByVal tahun As Integer) As Integer
        Dim idSpt As Integer = GetActiveSptId(idWp)
        If idSpt > 0 Then Return idSpt ' Sudah ada

        Dim query As String = "INSERT INTO spt_tahunan (id_wp, tahun_pajak, tanggal_lapor, status, status_final) VALUES (@idWp, @tahun, NOW(), 'Draft', 'Belum Lapor'); SELECT LAST_INSERT_ID();"
        Dim newId As Integer = 0

        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@idWp", idWp)
                cmd.Parameters.AddWithValue("@tahun", tahun)
                newId = Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox("Gagal membuat SPT baru: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return newId
    End Function

    ' --- FUNGSI CRUD PEGAWAI (PEMBERI KERJA) ---
    Public Function GetPegawaiList(ByVal idPk As Integer) As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT id_pegawai, npwp_pegawai, nama_pegawai, status_kawin, jumlah_tanggungan, jabatan FROM pk_pegawai WHERE id_pk = @idPk"
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@idPk", idPk)
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil data pegawai: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return dt
    End Function

    Public Function AddPegawai(ByVal idPk As Integer, ByVal data As PegawaiData) As Boolean
        Dim success As Boolean = False
        Dim query As String = "INSERT INTO pk_pegawai (id_pk, npwp_pegawai, nama_pegawai, status_kawin, jumlah_tanggungan, jabatan) VALUES (@idPk, @npwp, @nama, @status, @tanggungan, @jabatan)"
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@idPk", idPk)
                cmd.Parameters.AddWithValue("@npwp", data.npwp_pegawai)
                cmd.Parameters.AddWithValue("@nama", data.nama_pegawai)
                cmd.Parameters.AddWithValue("@status", data.status_kawin)
                cmd.Parameters.AddWithValue("@tanggungan", data.jumlah_tanggungan)
                cmd.Parameters.AddWithValue("@jabatan", data.jabatan)
                If cmd.ExecuteNonQuery() > 0 Then success = True
            End Using
        Catch ex As Exception
            MsgBox("Gagal menambah pegawai: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function

    Public Function DeletePegawai(ByVal idPegawai As Integer) As Boolean
        Dim success As Boolean = False
        Dim query As String = "DELETE FROM pk_pegawai WHERE id_pegawai = @id"
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@id", idPegawai)
                If cmd.ExecuteNonQuery() > 0 Then success = True
            End Using
        Catch ex As Exception
            MsgBox("Gagal menghapus pegawai: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function
    
    ' Fungsi untuk mendapatkan ID PK (Pemberi Kerja) dari NPWP PK (Login)
    Public Function GetPkIdByNpwp(ByVal npwp As String) As Integer
        Dim id_pk As Integer = 0
        Dim query As String = "SELECT id_pk FROM pk_profil WHERE npwp_pk = @npwp" ' Asumsi kolom npwp_pk
        ' Note: Cek kolom di screenshot 'pk_profil' -> kolomnya adalah 'npwp_pk'
        
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@npwp", npwp)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then id_pk = Convert.ToInt32(result)
            End Using
        Catch ex As Exception
            ' MsgBox("Gagal mengambil ID PK: " & ex.Message)
            ' Silent fail or log
        Finally
            TutupKoneksi()
        End Try
        Return id_pk
    End Function

    Public Function SaveTransaksiGaji(ByVal idPk As Integer, ByVal idPegawai As Integer, ByVal gaji As Decimal, ByVal tunjangan As Decimal, ByVal iuran As Decimal, ByVal pph As Decimal) As Boolean
        Dim success As Boolean = False
        Dim bulan As Integer = DateTime.Now.Month
        Dim tahun As Integer = DateTime.Now.Year
        
        ' Sesuai dengan struktur database pk_transaksi_gaji: id_transaksi, id_pegawai, tahun, bulan, gaji_pokok, tunjangan, iuran_pensiun, pph21_dipotong
        Dim query As String = "INSERT INTO pk_transaksi_gaji (id_pegawai, tahun, bulan, gaji_pokok, tunjangan, iuran_pensiun, pph21_dipotong) VALUES (@idPegawai, @tahun, @bulan, @gaji, @tunj, @iuran, @pph)"
        
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@idPegawai", idPegawai)
                cmd.Parameters.AddWithValue("@tahun", tahun)
                cmd.Parameters.AddWithValue("@bulan", bulan)
                cmd.Parameters.AddWithValue("@gaji", gaji)
                cmd.Parameters.AddWithValue("@tunj", tunjangan)
                cmd.Parameters.AddWithValue("@iuran", iuran)
                cmd.Parameters.AddWithValue("@pph", pph)
                If cmd.ExecuteNonQuery() > 0 Then success = True
            End Using
        Catch ex As Exception
            MsgBox("Gagal menyimpan transaksi gaji: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return success
    End Function

    ' --- FUNGSI INTEGRASI Wajib Pajak (WP) - Ambil Data Bukti Potong dari Employer ---
    
    ' Mengambil Total Gaji Bruto Setahun (Gaji + Tunjangan) berdasarkan NPWP Pegawai
    Public Function GetTotalPendapatanTahun(ByVal npwpPegawai As String, ByVal tahun As Integer) As Decimal
        Dim total As Decimal = 0
        ' Join pk_transaksi_gaji dengan pk_pegawai on id_pegawai
        ' Filter by npwp_pegawai dan tahun
        Dim query As String = "SELECT SUM(t.gaji_pokok + t.tunjangan) FROM pk_transaksi_gaji t " &
                              "JOIN pk_pegawai p ON t.id_pegawai = p.id_pegawai " &
                              "WHERE p.npwp_pegawai = @npwp AND t.tahun = @tahun"
                              
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@npwp", npwpPegawai)
                cmd.Parameters.AddWithValue("@tahun", tahun)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    total = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil data pendapatan: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return total
    End Function

    ' Mengambil Total PPh 21 yang sudah dipotong perusahaan
    Public Function GetTotalPphDipotongTahun(ByVal npwpPegawai As String, ByVal tahun As Integer) As Decimal
        Dim total As Decimal = 0
        Dim query As String = "SELECT SUM(t.pph21_dipotong) FROM pk_transaksi_gaji t " &
                              "JOIN pk_pegawai p ON t.id_pegawai = p.id_pegawai " &
                              "WHERE p.npwp_pegawai = @npwp AND t.tahun = @tahun"
                              
        BukaKoneksi()
        Try
            Using cmd As New MySqlCommand(query, koneksi)
                cmd.Parameters.AddWithValue("@npwp", npwpPegawai)
                cmd.Parameters.AddWithValue("@tahun", tahun)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    total = Convert.ToDecimal(result)
                End If
            End Using
        Catch ex As Exception
            MsgBox("Gagal mengambil data potongan pajak: " & ex.Message)
        Finally
            TutupKoneksi()
        End Try
        Return total
    End Function

End Module