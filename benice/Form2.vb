Public Class Form2

    Public Shared Property CurrentNpwp As String = ""

    ' --- Event Handler Tombol Edit Profil ---
    Private Sub btnEditProfil_Click(sender As Object, e As EventArgs) Handles btnEditProfil.Click

        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim editForm As New FormEditProfil(CurrentNpwp)

        editForm.Show()
        Me.Hide()
    End Sub

    ' --- Event Handler Tombol Lihat Histori (Diperbaiki) ---
    Private Sub btnHistori_Click(sender As Object, e As EventArgs) Handles btnHistori.Click

        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu sebelum melihat histori.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        ' Menggunakan Show() dan mengirimkan NPWP melalui constructor
        Dim historiForm As New FormHistori(CurrentNpwp)

        historiForm.Show() ' Menampilkan Form Histori
        Me.Hide()          ' Menyembunyikan Form Menu Utama (Form2)
    End Sub

    ' --- Event Handler Tombol Hitung SPT Tahunan ---
    Private Sub btnHitungSpt_Click(sender As Object, e As EventArgs) Handles btnHitungSpt.Click

        If String.IsNullOrEmpty(CurrentNpwp) Then
            MsgBox("Mohon login terlebih dahulu untuk memulai perhitungan SPT.", MsgBoxStyle.Exclamation, "Informasi")
            Return
        End If

        Dim f As New Form3()
        f.CurrentNpwp = CurrentNpwp ' <<< PASTIKAN NPWP DIKIRIM KE FORM3
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class