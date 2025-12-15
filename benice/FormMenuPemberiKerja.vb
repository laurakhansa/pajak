Public Class FormMenuPemberiKerja

    Public Shared Property CurrentNpwp As String = ""

    Private Sub btnManajemenPegawai_Click(sender As Object, e As EventArgs) Handles btnManajemenPegawai.Click
        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim f As New FormManajemenPegawai(CurrentNpwp)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnPemotonganBuktiPotong_Click(sender As Object, e As EventArgs) Handles btnPemotonganBuktiPotong.Click
        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim f As New FormPemotonganBuktiPotong(CurrentNpwp)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnPembayaranPajak_Click(sender As Object, e As EventArgs) Handles btnPembayaranPajak.Click
        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim f As New FormPembayaranPajak(CurrentNpwp)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub btnPelaporanSptMasa_Click(sender As Object, e As EventArgs) Handles btnPelaporanSptMasa.Click
        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim f As New FormPelaporanSptMasa(CurrentNpwp)
        f.Show()
        Me.Hide()
    End Sub

    Private Sub lblSubtitle_Click(sender As Object, e As EventArgs) Handles lblSubtitle.Click

    End Sub
End Class

