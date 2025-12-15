Imports Microsoft.VisualBasic

Public Class FormManajemenPegawai

    Private ReadOnly _currentNpwp As String
    Private _idPk As Integer = 0

    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        Me.Text = "Manajemen Data Pegawai - NPWP PK: " & _currentNpwp
    End Sub

    Private Sub FormManajemenPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ambil ID PK
        _idPk = Modulekoneksi.GetPkIdByNpwp(_currentNpwp)
        If _idPk = 0 Then
            MsgBox("Data Pemberi Kerja tidak ditemukan.", MsgBoxStyle.Critical)
            Me.Close()
            Return
        End If
        LoadDataPegawai()
    End Sub

    Private Sub LoadDataPegawai()
        Dim dt As DataTable = Modulekoneksi.GetPegawaiList(_idPk)
        gridPegawai.DataSource = dt
        
        ' Format Grid
        If gridPegawai.Columns("id_pegawai") IsNot Nothing Then gridPegawai.Columns("id_pegawai").Visible = False
        If gridPegawai.Columns("npwp_pegawai") IsNot Nothing Then gridPegawai.Columns("npwp_pegawai").HeaderText = "NPWP"
        If gridPegawai.Columns("nama_pegawai") IsNot Nothing Then gridPegawai.Columns("nama_pegawai").HeaderText = "Nama"
        gridPegawai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        ' Simple Input Flows using InputBox for MVP
        Dim nama As String = InputBox("Masukkan Nama Pegawai:", "Tambah Pegawai")
        If String.IsNullOrWhiteSpace(nama) Then Return

        Dim npwp As String = InputBox("Masukkan NPWP Pegawai:", "Tambah Pegawai")
        If String.IsNullOrWhiteSpace(npwp) Then Return

        Dim status As String = InputBox("Masukkan Status Kawin (TK/K/HB):", "Tambah Pegawai", "TK")
        If String.IsNullOrWhiteSpace(status) Then Return

        Dim tanggunganStr As String = InputBox("Masukkan Jumlah Tanggungan (0-3):", "Tambah Pegawai", "0")
        If Not IsNumeric(tanggunganStr) Then Return
        Dim tanggungan As Integer = Convert.ToInt32(tanggunganStr)

        Dim jabatan As String = InputBox("Masukkan Jabatan:", "Tambah Pegawai", "Staf")
        
        Dim newPegawai As New Modulekoneksi.PegawaiData With {
            .nama_pegawai = nama,
            .npwp_pegawai = npwp,
            .status_kawin = status,
            .jumlah_tanggungan = tanggungan,
            .jabatan = jabatan
        }

        If Modulekoneksi.AddPegawai(_idPk, newPegawai) Then
            MsgBox("Pegawai berhasil ditambahkan.", MsgBoxStyle.Information)
            LoadDataPegawai()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MsgBox("Fitur Edit belum tersedia di versi ini (Gunakan Hapus lalu Tambah Baru).", MsgBoxStyle.Information)
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If gridPegawai.SelectedRows.Count = 0 Then
            MsgBox("Pilih pegawai yang akan dihapus.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim idPegawai As Integer = Convert.ToInt32(gridPegawai.SelectedRows(0).Cells("id_pegawai").Value)
        Dim nama As String = gridPegawai.SelectedRows(0).Cells("nama_pegawai").Value.ToString()

        If MessageBox.Show("Hapus pegawai " & nama & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If Modulekoneksi.DeletePegawai(idPegawai) Then
                MsgBox("Data berhasil dihapus.", MsgBoxStyle.Information)
                LoadDataPegawai()
            End If
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim menuForm As New FormMenuPemberiKerja()
        FormMenuPemberiKerja.CurrentNpwp = _currentNpwp
        menuForm.Show()
        Me.Close()
    End Sub

End Class

