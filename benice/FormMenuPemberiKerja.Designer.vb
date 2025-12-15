<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuPemberiKerja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        mainPanel = New Panel()
        btnPelaporanSptMasa = New Button()
        btnPembayaranPajak = New Button()
        btnPemotonganBuktiPotong = New Button()
        btnManajemenPegawai = New Button()
        lblSubtitle = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnPelaporanSptMasa)
        mainPanel.Controls.Add(btnPembayaranPajak)
        mainPanel.Controls.Add(btnPemotonganBuktiPotong)
        mainPanel.Controls.Add(btnManajemenPegawai)
        mainPanel.Controls.Add(lblSubtitle)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(231, 255)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(935, 700)
        mainPanel.TabIndex = 0
        ' 
        ' btnPelaporanSptMasa
        ' 
        btnPelaporanSptMasa.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnPelaporanSptMasa.FlatAppearance.BorderSize = 0
        btnPelaporanSptMasa.FlatStyle = FlatStyle.Flat
        btnPelaporanSptMasa.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnPelaporanSptMasa.ForeColor = Color.White
        btnPelaporanSptMasa.Location = New Point(211, 546)
        btnPelaporanSptMasa.Margin = New Padding(4)
        btnPelaporanSptMasa.Name = "btnPelaporanSptMasa"
        btnPelaporanSptMasa.Size = New Size(491, 70)
        btnPelaporanSptMasa.TabIndex = 5
        btnPelaporanSptMasa.Text = "Pelaporan SPT Masa"
        btnPelaporanSptMasa.UseVisualStyleBackColor = False
        ' 
        ' btnPembayaranPajak
        ' 
        btnPembayaranPajak.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnPembayaranPajak.FlatAppearance.BorderSize = 0
        btnPembayaranPajak.FlatStyle = FlatStyle.Flat
        btnPembayaranPajak.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnPembayaranPajak.ForeColor = Color.White
        btnPembayaranPajak.Location = New Point(211, 446)
        btnPembayaranPajak.Margin = New Padding(4)
        btnPembayaranPajak.Name = "btnPembayaranPajak"
        btnPembayaranPajak.Size = New Size(491, 70)
        btnPembayaranPajak.TabIndex = 4
        btnPembayaranPajak.Text = "Pembayaran (Penyetoran) Pajak"
        btnPembayaranPajak.UseVisualStyleBackColor = False
        ' 
        ' btnPemotonganBuktiPotong
        ' 
        btnPemotonganBuktiPotong.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnPemotonganBuktiPotong.FlatAppearance.BorderSize = 0
        btnPemotonganBuktiPotong.FlatStyle = FlatStyle.Flat
        btnPemotonganBuktiPotong.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnPemotonganBuktiPotong.ForeColor = Color.White
        btnPemotonganBuktiPotong.Location = New Point(211, 346)
        btnPemotonganBuktiPotong.Margin = New Padding(4)
        btnPemotonganBuktiPotong.Name = "btnPemotonganBuktiPotong"
        btnPemotonganBuktiPotong.Size = New Size(491, 70)
        btnPemotonganBuktiPotong.TabIndex = 3
        btnPemotonganBuktiPotong.Text = "Pemotongan & Bukti Potong"
        btnPemotonganBuktiPotong.UseVisualStyleBackColor = False
        ' 
        ' btnManajemenPegawai
        ' 
        btnManajemenPegawai.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnManajemenPegawai.FlatAppearance.BorderSize = 0
        btnManajemenPegawai.FlatStyle = FlatStyle.Flat
        btnManajemenPegawai.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
        btnManajemenPegawai.ForeColor = Color.White
        btnManajemenPegawai.Location = New Point(211, 246)
        btnManajemenPegawai.Margin = New Padding(4)
        btnManajemenPegawai.Name = "btnManajemenPegawai"
        btnManajemenPegawai.Size = New Size(491, 70)
        btnManajemenPegawai.TabIndex = 2
        btnManajemenPegawai.Text = "Manajemen Data Pegawai"
        btnManajemenPegawai.UseVisualStyleBackColor = False
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 10.0F)
        lblSubtitle.ForeColor = Color.White
        lblSubtitle.Location = New Point(118, 150)
        lblSubtitle.Margin = New Padding(4, 0, 4, 0)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(683, 37)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Kelola data pegawai, pemotongan pajak, dan pelaporan"
        lblSubtitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(108, 57)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(724, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Menu Utama Pemberi Kerja"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FormMenuPemberiKerja
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "FormMenuPemberiKerja"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu Utama Pemberi Kerja"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents btnManajemenPegawai As System.Windows.Forms.Button
    Friend WithEvents btnPemotonganBuktiPotong As System.Windows.Forms.Button
    Friend WithEvents btnPembayaranPajak As System.Windows.Forms.Button
    Friend WithEvents btnPelaporanSptMasa As System.Windows.Forms.Button

End Class

