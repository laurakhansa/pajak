Public Class FormPelaporanSptMasa

    Private ReadOnly _currentNpwp As String

    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        Me.Text = "Pelaporan SPT Masa - NPWP: " & _currentNpwp
        LoadTahun()
    End Sub

    Private Sub LoadTahun()
        Dim tahunSekarang As Integer = DateTime.Now.Year
        For i As Integer = 0 To 5
            cmbTahun.Items.Add(tahunSekarang - i)
        Next
        If cmbTahun.Items.Count > 0 Then
            cmbTahun.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnBuatDraft_Click(sender As Object, e As EventArgs) Handles btnBuatDraft.Click
        If cmbTahun.SelectedItem Is Nothing OrElse cmbBulan.SelectedItem Is Nothing Then
            MsgBox("Pilih tahun dan bulan terlebih dahulu.", MsgBoxStyle.Exclamation, "Peringatan")
            Return
        End If

        MsgBox("Draft SPT Masa PPh 21/26 berhasil dibuat." & vbCrLf & _
               "Total PPh Dipotong: Rp 12.500.000" & vbCrLf & _
               "Status: Kurang Bayar (Sudah Disetor)", MsgBoxStyle.Information, "Draft SPT Masa")
    End Sub

    Private Sub btnValidasiData_Click(sender As Object, e As EventArgs) Handles btnValidasiData.Click
        MsgBox("Validasi Data Berhasil. Tidak ditemukan selisih.", MsgBoxStyle.Information, "Validasi")
    End Sub

    Private Sub btnEksporFile_Click(sender As Object, e As EventArgs) Handles btnEksporFile.Click
        MsgBox("File CSV untuk pelaporan e-Filing berhasil diekspor ke Documents/Pelaporan_Masa.csv", MsgBoxStyle.Information, "Ekspor Berhasil")
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim menuForm As New FormMenuPemberiKerja()
        FormMenuPemberiKerja.CurrentNpwp = _currentNpwp
        menuForm.Show()
        Me.Close()
    End Sub

    Private Sub FormPelaporanSptMasa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

