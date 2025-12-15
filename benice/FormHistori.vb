Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class FormHistori

    Private ReadOnly _currentNpwp As String

    ' Constructor yang menerima NPWP
    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        Me.Text = "Histori SPT WP - NPWP: " & _currentNpwp
        LoadHistoriData()
    End Sub

    ' --- FUNGSI UTAMA: MENGAMBIL DATA HISTORI SPT ---
    Private Sub LoadHistoriData()
        Dim dt As New DataTable()

        Dim query As String = "SELECT tahun_pajak, tanggal_lapor, status, jumlah_rupiah FROM spt_tahunan st " &
                              "INNER JOIN wp_profil wp ON st.id_wp = wp.id_wp " &
                              "WHERE wp.npwp = @npwp ORDER BY tahun_pajak DESC"

        Modulekoneksi.BukaKoneksi()

        ' Pengecekan koneksi yang ketat
        If Modulekoneksi.koneksi Is Nothing OrElse Modulekoneksi.koneksi.State <> ConnectionState.Open Then
            MsgBox("Koneksi ke database tidak tersedia. Cek XAMPP.", MsgBoxStyle.Exclamation, "Koneksi Gagal")
            Return
        End If

        Try
            ' dgvHistori sekarang merujuk pada kontrol visual yang benar
            Using cmd As New MySqlCommand(query, Modulekoneksi.koneksi)
                cmd.Parameters.AddWithValue("@npwp", _currentNpwp)

                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dt)
                End Using
            End Using


            gridHistori.AutoGenerateColumns = False ' Mencegah duplikasi kolom
            gridHistori.DataSource = dt
            FormatDataGridView()

        Catch ex As Exception
            MsgBox("Gagal memuat data Histori SPT: " & ex.Message, MsgBoxStyle.Critical, "Error Database")
        Finally
            Modulekoneksi.TutupKoneksi()
        End Try
    End Sub

    ' --- FUNGSI OPTIONAL: FORMAT DATAGRIDVIEW ---
    Private Sub FormatDataGridView()
        If gridHistori.Columns.Count > 0 Then
            gridHistori.Columns("colTahunPajak").DataPropertyName = "tahun_pajak"
            gridHistori.Columns("colTanggal").DataPropertyName = "tanggal_lapor"
            gridHistori.Columns("colStatus").DataPropertyName = "status"
            gridHistori.Columns("colJumlah").DataPropertyName = "jumlah_rupiah"

            gridHistori.Columns("jumlah_rupiah").DefaultCellStyle.Format = "N2"
            gridHistori.Columns("jumlah_rupiah").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            gridHistori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End If
    End Sub

    ' --- Event Handler Tombol Tutup ---
    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        NavigateToMainMenu()
    End Sub

    ' Event Handler bawaan dari form
    Private Sub mainPanel_Paint(sender As Object, e As PaintEventArgs) Handles mainPanel.Paint
    End Sub

    ' --- Navigasi ---
    Private Sub NavigateToMainMenu()
        ' Kembali ke Form Menu Utama
        Dim mainMenuForm As New Form2()
        Form2.CurrentNpwp = _currentNpwp
        mainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub FormHistori_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class