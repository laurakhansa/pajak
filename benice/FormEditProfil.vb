Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class FormEditProfil

    Private ReadOnly _currentNpwp As String

    Public Sub New(ByVal npwp As String)
        InitializeComponent()
        _currentNpwp = npwp
        LoadProfileData()
    End Sub

    Private Function UpdateWpProfile() As Boolean
        Dim updatedData As New Modulekoneksi.WpProfileData() With {
            .npwp = _currentNpwp,
            .nama = txtNama.Text,
            .email = txtEmail.Text,
            .no_handphone = txtNoHp.Text,
            .alamat = txtAlamat.Text
        }
        Return Modulekoneksi.UpdateWpProfile(updatedData)
    End Function

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If Not IsNumeric(txtNoHp.Text) AndAlso Not String.IsNullOrEmpty(txtNoHp.Text) Then
            MsgBox("Nomor Handphone harus berupa angka.", MsgBoxStyle.Exclamation, "Validasi")
            txtNoHp.Focus()
            Return
        End If

        If UpdateWpProfile() Then
            MsgBox("Data profil berhasil diperbarui!", MsgBoxStyle.Information, "Sukses")
            NavigateToMainMenu()
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        NavigateToMainMenu()
    End Sub

    Private Sub NavigateToMainMenu()
        Dim mainMenuForm As New Form2()
        Form2.CurrentNpwp = _currentNpwp
        mainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub LoadProfileData()
        Dim profile As Modulekoneksi.WpProfileData = Modulekoneksi.GetWpProfile(_currentNpwp)

        If profile IsNot Nothing Then
            txtNpwp.Text = profile.npwp
            txtNama.Text = profile.nama
            txtEmail.Text = profile.email
            txtNoHp.Text = profile.no_handphone
            txtAlamat.Text = profile.alamat
        Else
            MsgBox("Gagal memuat data profil. Form akan ditutup.", MsgBoxStyle.Critical, "Data Tidak Ditemukan")
            Me.Close()
        End If
    End Sub

    Private Sub FormEditProfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class