Public Class FormPembayaranPajak

    Private ReadOnly _currentNpwp As String

    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        Me.Text = "Pembayaran Pajak - NPWP: " & _currentNpwp
    End Sub

    Private Sub btnGenerateKodeBilling_Click(sender As Object, e As EventArgs) Handles btnGenerateKodeBilling.Click
        If cmbJenisPajak.SelectedIndex = -1 Then
             MsgBox("Pilih jenis pajak terlebih dahulu.", MsgBoxStyle.Exclamation)
             Return
        End If
        If String.IsNullOrWhiteSpace(txtJumlahPajak.Text) OrElse Not IsNumeric(txtJumlahPajak.Text) Then
             MsgBox("Masukkan jumlah pajak yang valid.", MsgBoxStyle.Exclamation)
             Return
        End If

        ' Generate Kode (Dummy 15 digit)
        Dim random As New Random()
        Dim kode As String = ""
        For i As Integer = 1 To 15
            kode &= random.Next(0, 9).ToString()
        Next

        MsgBox("Kode Billing Berhasil Diterbitkan: " & kode & vbCrLf & _
               "Silakan lakukan pembayaran melalui Bank/Pos Persepsi.", MsgBoxStyle.Information, "Sukses")
    End Sub

    Private Sub btnLihatRiwayat_Click(sender As Object, e As EventArgs) Handles btnLihatRiwayat.Click
        ' Simulasi Riwayat (MVP)
        MsgBox("Riwayat Setoran Pajak:" & vbCrLf & _
               "1. 10 Jan 2025 - PPh 21 - Rp 5.000.000 - LUNAS" & vbCrLf & _
               "2. 10 Feb 2025 - PPh 21 - Rp 5.200.000 - LUNAS", MsgBoxStyle.Information, "Riwayat")
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim menuForm As New FormMenuPemberiKerja()
        FormMenuPemberiKerja.CurrentNpwp = _currentNpwp
        menuForm.Show()
        Me.Close()
    End Sub

End Class

