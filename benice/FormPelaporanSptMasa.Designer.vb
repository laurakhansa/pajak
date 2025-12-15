<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelaporanSptMasa
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
        btnKembali = New Button()
        btnEksporFile = New Button()
        btnValidasiData = New Button()
        btnBuatDraft = New Button()
        cmbBulan = New ComboBox()
        lblBulan = New Label()
        cmbTahun = New ComboBox()
        lblTahun = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(btnEksporFile)
        mainPanel.Controls.Add(btnValidasiData)
        mainPanel.Controls.Add(btnBuatDraft)
        mainPanel.Controls.Add(cmbBulan)
        mainPanel.Controls.Add(lblBulan)
        mainPanel.Controls.Add(cmbTahun)
        mainPanel.Controls.Add(lblTahun)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(300, 225)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(768, 679)
        mainPanel.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(550, 575)
        btnKembali.Margin = New Padding(4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 8
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnEksporFile
        ' 
        btnEksporFile.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnEksporFile.FlatAppearance.BorderSize = 0
        btnEksporFile.FlatStyle = FlatStyle.Flat
        btnEksporFile.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnEksporFile.ForeColor = Color.White
        btnEksporFile.Location = New Point(400, 454)
        btnEksporFile.Margin = New Padding(4)
        btnEksporFile.Name = "btnEksporFile"
        btnEksporFile.Size = New Size(300, 54)
        btnEksporFile.TabIndex = 7
        btnEksporFile.Text = "Ekspor File Pelaporan"
        btnEksporFile.UseVisualStyleBackColor = False
        ' 
        ' btnValidasiData
        ' 
        btnValidasiData.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnValidasiData.FlatAppearance.BorderSize = 0
        btnValidasiData.FlatStyle = FlatStyle.Flat
        btnValidasiData.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnValidasiData.ForeColor = Color.White
        btnValidasiData.Location = New Point(50, 454)
        btnValidasiData.Margin = New Padding(4)
        btnValidasiData.Name = "btnValidasiData"
        btnValidasiData.Size = New Size(300, 54)
        btnValidasiData.TabIndex = 6
        btnValidasiData.Text = "Validasi Data"
        btnValidasiData.UseVisualStyleBackColor = False
        ' 
        ' btnBuatDraft
        ' 
        btnBuatDraft.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnBuatDraft.FlatAppearance.BorderSize = 0
        btnBuatDraft.FlatStyle = FlatStyle.Flat
        btnBuatDraft.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnBuatDraft.ForeColor = Color.White
        btnBuatDraft.Location = New Point(50, 328)
        btnBuatDraft.Margin = New Padding(4)
        btnBuatDraft.Name = "btnBuatDraft"
        btnBuatDraft.Size = New Size(650, 70)
        btnBuatDraft.TabIndex = 5
        btnBuatDraft.Text = "Buat Draft SPT Masa PPh 21"
        btnBuatDraft.UseVisualStyleBackColor = False
        ' 
        ' cmbBulan
        ' 
        cmbBulan.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        cmbBulan.ForeColor = Color.White
        cmbBulan.FormattingEnabled = True
        cmbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        cmbBulan.Location = New Point(379, 230)
        cmbBulan.Margin = New Padding(4)
        cmbBulan.Name = "cmbBulan"
        cmbBulan.Size = New Size(321, 40)
        cmbBulan.TabIndex = 4
        ' 
        ' lblBulan
        ' 
        lblBulan.AutoSize = True
        lblBulan.Font = New Font("Segoe UI", 11F)
        lblBulan.ForeColor = Color.White
        lblBulan.Location = New Point(379, 185)
        lblBulan.Margin = New Padding(4, 0, 4, 0)
        lblBulan.Name = "lblBulan"
        lblBulan.Size = New Size(91, 41)
        lblBulan.TabIndex = 3
        lblBulan.Text = "Bulan"
        ' 
        ' cmbTahun
        ' 
        cmbTahun.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        cmbTahun.ForeColor = Color.White
        cmbTahun.FormattingEnabled = True
        cmbTahun.Location = New Point(50, 230)
        cmbTahun.Margin = New Padding(4)
        cmbTahun.Name = "cmbTahun"
        cmbTahun.Size = New Size(290, 40)
        cmbTahun.TabIndex = 2
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Font = New Font("Segoe UI", 11F)
        lblTahun.ForeColor = Color.White
        lblTahun.Location = New Point(50, 185)
        lblTahun.Margin = New Padding(4, 0, 4, 0)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(97, 41)
        lblTahun.TabIndex = 1
        lblTahun.Text = "Tahun"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(50, 40)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(542, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pelaporan SPT Masa"
        ' 
        ' FormPelaporanSptMasa
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "FormPelaporanSptMasa"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pelaporan SPT Masa"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents cmbTahun As System.Windows.Forms.ComboBox
    Friend WithEvents lblBulan As System.Windows.Forms.Label
    Friend WithEvents cmbBulan As System.Windows.Forms.ComboBox
    Friend WithEvents btnBuatDraft As System.Windows.Forms.Button
    Friend WithEvents btnValidasiData As System.Windows.Forms.Button
    Friend WithEvents btnEksporFile As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button

End Class

