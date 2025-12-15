<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        lblTitle = New Label()
        btnKembali = New Button()
        tabMain = New TabControl()
        tabBuktiPotong = New TabPage()
        btnNextPenghasilanLain = New Button()
        chkSetuju = New CheckBox()
        grpBuktiPotong = New GroupBox()
        txtBuktiPotong = New TextBox()
        tabPenghasilanLain = New TabPage()
        btnNextPerhitungan = New Button()
        cboStatusPerkawinan = New ComboBox()
        lblJumlahTanggungan = New Label()
        lblStatusPerkawinan = New Label()
        txtJumlahTanggungan = New TextBox()
        grpPenghasilanLain = New GroupBox()
        txtPenghasilanLain = New TextBox()
        tabPerhitungan = New TabPage()
        btnNextKuesioner = New Button()
        txtTotalKreditPajak = New TextBox()
        txtPphTerutang = New TextBox()
        txtPtkp = New TextBox()
        txtTotalPenghasilanSetahun = New TextBox()
        lblTotalKreditPajak = New Label()
        lblPphTerutang = New Label()
        lblPtkp = New Label()
        lblTotalPenghasilanSetahun = New Label()
        mainPanel = New Panel()
        tabMain.SuspendLayout()
        tabBuktiPotong.SuspendLayout()
        grpBuktiPotong.SuspendLayout()
        tabPenghasilanLain.SuspendLayout()
        grpPenghasilanLain.SuspendLayout()
        tabPerhitungan.SuspendLayout()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(52, 31)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(880, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Data Utama dan Penghasilan Lain"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(40, 660)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 2
        btnKembali.Text = "Kembali Menu"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' tabMain
        ' 
        tabMain.Controls.Add(tabBuktiPotong)
        tabMain.Controls.Add(tabPenghasilanLain)
        tabMain.Controls.Add(tabPerhitungan)
        tabMain.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabMain.Location = New Point(40, 132)
        tabMain.Name = "tabMain"
        tabMain.SelectedIndex = 0
        tabMain.Size = New Size(900, 515)
        tabMain.TabIndex = 1
        ' 
        ' tabBuktiPotong
        ' 
        tabBuktiPotong.BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        tabBuktiPotong.Controls.Add(btnNextPenghasilanLain)
        tabBuktiPotong.Controls.Add(chkSetuju)
        tabBuktiPotong.Controls.Add(grpBuktiPotong)
        tabBuktiPotong.Location = New Point(8, 51)
        tabBuktiPotong.Name = "tabBuktiPotong"
        tabBuktiPotong.Padding = New Padding(3)
        tabBuktiPotong.Size = New Size(884, 456)
        tabBuktiPotong.TabIndex = 0
        tabBuktiPotong.Text = "Bukti Potong"
        ' 
        ' btnNextPenghasilanLain
        ' 
        btnNextPenghasilanLain.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnNextPenghasilanLain.FlatAppearance.BorderSize = 0
        btnNextPenghasilanLain.FlatStyle = FlatStyle.Flat
        btnNextPenghasilanLain.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnNextPenghasilanLain.ForeColor = Color.White
        btnNextPenghasilanLain.Location = New Point(330, 350)
        btnNextPenghasilanLain.Name = "btnNextPenghasilanLain"
        btnNextPenghasilanLain.Size = New Size(250, 50)
        btnNextPenghasilanLain.TabIndex = 2
        btnNextPenghasilanLain.Text = "Lanjut ke Penghasilan Lain"
        btnNextPenghasilanLain.UseVisualStyleBackColor = False
        ' 
        ' chkSetuju
        ' 
        chkSetuju.AutoSize = True
        chkSetuju.ForeColor = Color.White
        chkSetuju.Location = New Point(60, 280)
        chkSetuju.Name = "chkSetuju"
        chkSetuju.Size = New Size(185, 41)
        chkSetuju.TabIndex = 1
        chkSetuju.Text = "Saya Setuju"
        chkSetuju.UseVisualStyleBackColor = True
        ' 
        ' grpBuktiPotong
        ' 
        grpBuktiPotong.Controls.Add(txtBuktiPotong)
        grpBuktiPotong.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpBuktiPotong.ForeColor = Color.White
        grpBuktiPotong.Location = New Point(40, 40)
        grpBuktiPotong.Name = "grpBuktiPotong"
        grpBuktiPotong.Size = New Size(810, 220)
        grpBuktiPotong.TabIndex = 0
        grpBuktiPotong.TabStop = False
        grpBuktiPotong.Text = "Bukti Potong"
        ' 
        ' txtBuktiPotong
        ' 
        txtBuktiPotong.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtBuktiPotong.BorderStyle = BorderStyle.FixedSingle
        txtBuktiPotong.Dock = DockStyle.Fill
        txtBuktiPotong.ForeColor = Color.White
        txtBuktiPotong.Location = New Point(3, 43)
        txtBuktiPotong.Multiline = True
        txtBuktiPotong.Name = "txtBuktiPotong"
        txtBuktiPotong.Size = New Size(804, 174)
        txtBuktiPotong.TabIndex = 0
        ' 
        ' tabPenghasilanLain
        ' 
        tabPenghasilanLain.BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        tabPenghasilanLain.Controls.Add(btnNextPerhitungan)
        tabPenghasilanLain.Controls.Add(cboStatusPerkawinan)
        tabPenghasilanLain.Controls.Add(lblJumlahTanggungan)
        tabPenghasilanLain.Controls.Add(lblStatusPerkawinan)
        tabPenghasilanLain.Controls.Add(txtJumlahTanggungan)
        tabPenghasilanLain.Controls.Add(grpPenghasilanLain)
        tabPenghasilanLain.Location = New Point(8, 51)
        tabPenghasilanLain.Name = "tabPenghasilanLain"
        tabPenghasilanLain.Padding = New Padding(3)
        tabPenghasilanLain.Size = New Size(884, 456)
        tabPenghasilanLain.TabIndex = 1
        tabPenghasilanLain.Text = "Penghasilan Lain"
        ' 
        ' btnNextPerhitungan
        ' 
        btnNextPerhitungan.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnNextPerhitungan.FlatAppearance.BorderSize = 0
        btnNextPerhitungan.FlatStyle = FlatStyle.Flat
        btnNextPerhitungan.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnNextPerhitungan.ForeColor = Color.White
        btnNextPerhitungan.Location = New Point(340, 359)
        btnNextPerhitungan.Name = "btnNextPerhitungan"
        btnNextPerhitungan.Size = New Size(230, 50)
        btnNextPerhitungan.TabIndex = 5
        btnNextPerhitungan.Text = "Lanjut ke Perhitungan"
        btnNextPerhitungan.UseVisualStyleBackColor = False
        ' 
        ' cboStatusPerkawinan
        ' 
        cboStatusPerkawinan.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        cboStatusPerkawinan.DropDownStyle = ComboBoxStyle.DropDownList
        cboStatusPerkawinan.FlatStyle = FlatStyle.Flat
        cboStatusPerkawinan.ForeColor = Color.White
        cboStatusPerkawinan.FormattingEnabled = True
        cboStatusPerkawinan.Items.AddRange(New Object() {"Belum Kawin", "Kawin", "Kawin dengan tanggungan"})
        cboStatusPerkawinan.Location = New Point(368, 235)
        cboStatusPerkawinan.Name = "cboStatusPerkawinan"
        cboStatusPerkawinan.Size = New Size(270, 45)
        cboStatusPerkawinan.TabIndex = 2
        ' 
        ' lblJumlahTanggungan
        ' 
        lblJumlahTanggungan.AutoSize = True
        lblJumlahTanggungan.ForeColor = Color.White
        lblJumlahTanggungan.Location = New Point(43, 295)
        lblJumlahTanggungan.Name = "lblJumlahTanggungan"
        lblJumlahTanggungan.Size = New Size(255, 37)
        lblJumlahTanggungan.TabIndex = 3
        lblJumlahTanggungan.Text = "Jumlah Tanggungan"
        ' 
        ' lblStatusPerkawinan
        ' 
        lblStatusPerkawinan.AutoSize = True
        lblStatusPerkawinan.ForeColor = Color.White
        lblStatusPerkawinan.Location = New Point(40, 238)
        lblStatusPerkawinan.Name = "lblStatusPerkawinan"
        lblStatusPerkawinan.Size = New Size(230, 37)
        lblStatusPerkawinan.TabIndex = 1
        lblStatusPerkawinan.Text = "Status Perkawinan"
        ' 
        ' txtJumlahTanggungan
        ' 
        txtJumlahTanggungan.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtJumlahTanggungan.BorderStyle = BorderStyle.FixedSingle
        txtJumlahTanggungan.ForeColor = Color.White
        txtJumlahTanggungan.Location = New Point(368, 295)
        txtJumlahTanggungan.Name = "txtJumlahTanggungan"
        txtJumlahTanggungan.Size = New Size(270, 43)
        txtJumlahTanggungan.TabIndex = 4
        ' 
        ' grpPenghasilanLain
        ' 
        grpPenghasilanLain.Controls.Add(txtPenghasilanLain)
        grpPenghasilanLain.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpPenghasilanLain.ForeColor = Color.White
        grpPenghasilanLain.Location = New Point(40, 40)
        grpPenghasilanLain.Name = "grpPenghasilanLain"
        grpPenghasilanLain.Size = New Size(810, 180)
        grpPenghasilanLain.TabIndex = 0
        grpPenghasilanLain.TabStop = False
        grpPenghasilanLain.Text = "Penghasilan Lain"
        ' 
        ' txtPenghasilanLain
        ' 
        txtPenghasilanLain.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtPenghasilanLain.BorderStyle = BorderStyle.FixedSingle
        txtPenghasilanLain.Dock = DockStyle.Fill
        txtPenghasilanLain.ForeColor = Color.White
        txtPenghasilanLain.Location = New Point(3, 43)
        txtPenghasilanLain.Multiline = True
        txtPenghasilanLain.Name = "txtPenghasilanLain"
        txtPenghasilanLain.Size = New Size(804, 134)
        txtPenghasilanLain.TabIndex = 0
        ' 
        ' tabPerhitungan
        ' 
        tabPerhitungan.BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        tabPerhitungan.Controls.Add(btnNextKuesioner)
        tabPerhitungan.Controls.Add(txtTotalKreditPajak)
        tabPerhitungan.Controls.Add(txtPphTerutang)
        tabPerhitungan.Controls.Add(txtPtkp)
        tabPerhitungan.Controls.Add(txtTotalPenghasilanSetahun)
        tabPerhitungan.Controls.Add(lblTotalKreditPajak)
        tabPerhitungan.Controls.Add(lblPphTerutang)
        tabPerhitungan.Controls.Add(lblPtkp)
        tabPerhitungan.Controls.Add(lblTotalPenghasilanSetahun)
        tabPerhitungan.Location = New Point(8, 51)
        tabPerhitungan.Name = "tabPerhitungan"
        tabPerhitungan.Padding = New Padding(3)
        tabPerhitungan.Size = New Size(884, 456)
        tabPerhitungan.TabIndex = 2
        tabPerhitungan.Text = "Perhitungan"
        ' 
        ' btnNextKuesioner
        ' 
        btnNextKuesioner.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnNextKuesioner.FlatAppearance.BorderSize = 0
        btnNextKuesioner.FlatStyle = FlatStyle.Flat
        btnNextKuesioner.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnNextKuesioner.ForeColor = Color.White
        btnNextKuesioner.Location = New Point(343, 351)
        btnNextKuesioner.Name = "btnNextKuesioner"
        btnNextKuesioner.Size = New Size(230, 50)
        btnNextKuesioner.TabIndex = 8
        btnNextKuesioner.Text = "Lanjut ke Kuesioner"
        btnNextKuesioner.UseVisualStyleBackColor = False
        ' 
        ' txtTotalKreditPajak
        ' 
        txtTotalKreditPajak.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtTotalKreditPajak.BorderStyle = BorderStyle.FixedSingle
        txtTotalKreditPajak.ForeColor = Color.White
        txtTotalKreditPajak.Location = New Point(408, 258)
        txtTotalKreditPajak.Name = "txtTotalKreditPajak"
        txtTotalKreditPajak.Size = New Size(380, 43)
        txtTotalKreditPajak.TabIndex = 7
        ' 
        ' txtPphTerutang
        ' 
        txtPphTerutang.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtPphTerutang.BorderStyle = BorderStyle.FixedSingle
        txtPphTerutang.ForeColor = Color.White
        txtPphTerutang.Location = New Point(408, 200)
        txtPphTerutang.Name = "txtPphTerutang"
        txtPphTerutang.Size = New Size(380, 43)
        txtPphTerutang.TabIndex = 5
        ' 
        ' txtPtkp
        ' 
        txtPtkp.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtPtkp.BorderStyle = BorderStyle.FixedSingle
        txtPtkp.ForeColor = Color.White
        txtPtkp.Location = New Point(408, 142)
        txtPtkp.Name = "txtPtkp"
        txtPtkp.Size = New Size(380, 43)
        txtPtkp.TabIndex = 3
        ' 
        ' txtTotalPenghasilanSetahun
        ' 
        txtTotalPenghasilanSetahun.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtTotalPenghasilanSetahun.BorderStyle = BorderStyle.FixedSingle
        txtTotalPenghasilanSetahun.ForeColor = Color.White
        txtTotalPenghasilanSetahun.Location = New Point(408, 85)
        txtTotalPenghasilanSetahun.Name = "txtTotalPenghasilanSetahun"
        txtTotalPenghasilanSetahun.Size = New Size(380, 43)
        txtTotalPenghasilanSetahun.TabIndex = 1
        ' 
        ' lblTotalKreditPajak
        ' 
        lblTotalKreditPajak.AutoSize = True
        lblTotalKreditPajak.ForeColor = Color.White
        lblTotalKreditPajak.Location = New Point(40, 260)
        lblTotalKreditPajak.Name = "lblTotalKreditPajak"
        lblTotalKreditPajak.Size = New Size(221, 37)
        lblTotalKreditPajak.TabIndex = 6
        lblTotalKreditPajak.Text = "Total Kredit Pajak"
        ' 
        ' lblPphTerutang
        ' 
        lblPphTerutang.AutoSize = True
        lblPphTerutang.ForeColor = Color.White
        lblPphTerutang.Location = New Point(40, 202)
        lblPphTerutang.Name = "lblPphTerutang"
        lblPphTerutang.Size = New Size(172, 37)
        lblPphTerutang.TabIndex = 4
        lblPphTerutang.Text = "PPh Terutang"
        ' 
        ' lblPtkp
        ' 
        lblPtkp.AutoSize = True
        lblPtkp.ForeColor = Color.White
        lblPtkp.Location = New Point(40, 144)
        lblPtkp.Name = "lblPtkp"
        lblPtkp.Size = New Size(77, 37)
        lblPtkp.TabIndex = 2
        lblPtkp.Text = "PTKP"
        ' 
        ' lblTotalPenghasilanSetahun
        ' 
        lblTotalPenghasilanSetahun.AutoSize = True
        lblTotalPenghasilanSetahun.ForeColor = Color.White
        lblTotalPenghasilanSetahun.Location = New Point(40, 85)
        lblTotalPenghasilanSetahun.Name = "lblTotalPenghasilanSetahun"
        lblTotalPenghasilanSetahun.Size = New Size(326, 37)
        lblTotalPenghasilanSetahun.TabIndex = 0
        lblTotalPenghasilanSetahun.Text = "Total Penghasilan Setahun"
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(tabMain)
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(204, 215)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(980, 746)
        mainPanel.TabIndex = 0
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1237)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Utama & Penghasilan Lain"
        tabMain.ResumeLayout(False)
        tabBuktiPotong.ResumeLayout(False)
        tabBuktiPotong.PerformLayout()
        grpBuktiPotong.ResumeLayout(False)
        grpBuktiPotong.PerformLayout()
        tabPenghasilanLain.ResumeLayout(False)
        tabPenghasilanLain.PerformLayout()
        grpPenghasilanLain.ResumeLayout(False)
        grpPenghasilanLain.PerformLayout()
        tabPerhitungan.ResumeLayout(False)
        tabPerhitungan.PerformLayout()
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tabBuktiPotong As System.Windows.Forms.TabPage
    Friend WithEvents tabPenghasilanLain As System.Windows.Forms.TabPage
    Friend WithEvents tabPerhitungan As System.Windows.Forms.TabPage
    Friend WithEvents grpBuktiPotong As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuktiPotong As System.Windows.Forms.TextBox
    Friend WithEvents chkSetuju As System.Windows.Forms.CheckBox
    Friend WithEvents btnNextPenghasilanLain As System.Windows.Forms.Button
    Friend WithEvents grpPenghasilanLain As System.Windows.Forms.GroupBox
    Friend WithEvents txtPenghasilanLain As System.Windows.Forms.TextBox
    Friend WithEvents cboStatusPerkawinan As System.Windows.Forms.ComboBox
    Friend WithEvents lblJumlahTanggungan As System.Windows.Forms.Label
    Friend WithEvents lblStatusPerkawinan As System.Windows.Forms.Label
    Friend WithEvents txtJumlahTanggungan As System.Windows.Forms.TextBox
    Friend WithEvents btnNextPerhitungan As System.Windows.Forms.Button
    Friend WithEvents lblTotalPenghasilanSetahun As System.Windows.Forms.Label
    Friend WithEvents lblPtkp As System.Windows.Forms.Label
    Friend WithEvents lblPphTerutang As System.Windows.Forms.Label
    Friend WithEvents lblTotalKreditPajak As System.Windows.Forms.Label
    Friend WithEvents txtTotalPenghasilanSetahun As System.Windows.Forms.TextBox
    Friend WithEvents txtPtkp As System.Windows.Forms.TextBox
    Friend WithEvents txtPphTerutang As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKreditPajak As System.Windows.Forms.TextBox
    Friend WithEvents btnNextKuesioner As System.Windows.Forms.Button
    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
