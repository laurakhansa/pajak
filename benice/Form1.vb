Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Data

Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtNpwp.Text
        Dim password As String = txtPassword.Text
        Dim jumlahData As Integer = 0
        Dim sql As String = ""

        ' Tentukan tabel berdasarkan jenis login
        If rbPemberiKerja.Checked Then
            ' Login sebagai Pemberi Kerja (Sesuai SOP: npwp_pk dan pass_pk)
            sql = "SELECT COUNT(*) FROM pk_profil WHERE npwp_pk = @user AND pass_pk = @pass"
        Else
            ' Login sebagai Wajib Pajak
            sql = "SELECT COUNT(*) FROM wp_profil WHERE npwp = @user AND kata_sandi = @pass"
        End If

        Try
            Modulekoneksi.BukaKoneksi()

            If Modulekoneksi.koneksi Is Nothing OrElse Modulekoneksi.koneksi.State <> ConnectionState.Open Then
                ' Koneksi gagal, MsgBox sudah ditampilkan di ModuleKoneksi.BukaKoneksi
                Return
            End If

            Dim cmd As New MySqlCommand(sql, Modulekoneksi.koneksi)
            cmd.Parameters.AddWithValue("@user", username)
            cmd.Parameters.AddWithValue("@pass", password)

            jumlahData = CInt(cmd.ExecuteScalar())

            If jumlahData > 0 Then

                MsgBox("Login Berhasil!", MsgBoxStyle.Information, "Sukses")

                If rbPemberiKerja.Checked Then
                    ' Login sebagai Pemberi Kerja - buka Form Menu Pemberi Kerja
                    FormMenuPemberiKerja.CurrentNpwp = username
                    Dim pkMenuForm As New FormMenuPemberiKerja()
                    pkMenuForm.Show()
                    Me.Hide()
                Else
                    ' Login sebagai Wajib Pajak - buka Form Menu Wajib Pajak
                    Form2.CurrentNpwp = username
                    Dim mainMenuForm As New Form2()
                    mainMenuForm.Show()
                    Me.Hide()
                End If

            Else

                MsgBox("Username atau Password salah.", MsgBoxStyle.Exclamation, "Gagal Login")
                txtPassword.Clear()
                txtNpwp.Focus()

            End If

        Catch ex As Exception
            MsgBox("Terjadi Error: " & ex.Message, MsgBoxStyle.Critical, "Error")

        Finally
            Modulekoneksi.TutupKoneksi()
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class