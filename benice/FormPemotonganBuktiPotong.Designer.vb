<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPemotonganBuktiPotong
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
        btnCetakBuktiPotong = New Button()
        btnHitungPph = New Button()
        txtIuranPensiun = New TextBox()
        lblIuranPensiun = New Label()
        txtTunjangan = New TextBox()
        lblTunjangan = New Label()
        txtGajiPokok = New TextBox()
        lblGajiPokok = New Label()
        cmbPegawai = New ComboBox()
        lblPegawai = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(btnCetakBuktiPotong)
        mainPanel.Controls.Add(btnHitungPph)
        mainPanel.Controls.Add(txtIuranPensiun)
        mainPanel.Controls.Add(lblIuranPensiun)
        mainPanel.Controls.Add(txtTunjangan)
        mainPanel.Controls.Add(lblTunjangan)
        mainPanel.Controls.Add(txtGajiPokok)
        mainPanel.Controls.Add(lblGajiPokok)
        mainPanel.Controls.Add(cmbPegawai)
        mainPanel.Controls.Add(lblPegawai)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(148, 186)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1088, 846)
        mainPanel.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(843, 722)
        btnKembali.Margin = New Padding(4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 11
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnCetakBuktiPotong
        ' 
        btnCetakBuktiPotong.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnCetakBuktiPotong.FlatAppearance.BorderSize = 0
        btnCetakBuktiPotong.FlatStyle = FlatStyle.Flat
        btnCetakBuktiPotong.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnCetakBuktiPotong.ForeColor = Color.White
        btnCetakBuktiPotong.Location = New Point(431, 719)
        btnCetakBuktiPotong.Margin = New Padding(4)
        btnCetakBuktiPotong.Name = "btnCetakBuktiPotong"
        btnCetakBuktiPotong.Size = New Size(300, 57)
        btnCetakBuktiPotong.TabIndex = 10
        btnCetakBuktiPotong.Text = "Cetak Bukti Potong"
        btnCetakBuktiPotong.UseVisualStyleBackColor = False
        ' 
        ' btnHitungPph
        ' 
        btnHitungPph.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnHitungPph.FlatAppearance.BorderSize = 0
        btnHitungPph.FlatStyle = FlatStyle.Flat
        btnHitungPph.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnHitungPph.ForeColor = Color.White
        btnHitungPph.Location = New Point(114, 719)
        btnHitungPph.Margin = New Padding(4)
        btnHitungPph.Name = "btnHitungPph"
        btnHitungPph.Size = New Size(250, 57)
        btnHitungPph.TabIndex = 9
        btnHitungPph.Text = "Hitung PPh Pasal 21"
        btnHitungPph.UseVisualStyleBackColor = False
        ' 
        ' txtIuranPensiun
        ' 
        txtIuranPensiun.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtIuranPensiun.BorderStyle = BorderStyle.FixedSingle
        txtIuranPensiun.ForeColor = Color.White
        txtIuranPensiun.Location = New Point(93, 596)
        txtIuranPensiun.Margin = New Padding(4)
        txtIuranPensiun.Name = "txtIuranPensiun"
        txtIuranPensiun.Size = New Size(521, 39)
        txtIuranPensiun.TabIndex = 8
        ' 
        ' lblIuranPensiun
        ' 
        lblIuranPensiun.AutoSize = True
        lblIuranPensiun.Font = New Font("Segoe UI", 11F)
        lblIuranPensiun.ForeColor = Color.White
        lblIuranPensiun.Location = New Point(93, 556)
        lblIuranPensiun.Margin = New Padding(4, 0, 4, 0)
        lblIuranPensiun.Name = "lblIuranPensiun"
        lblIuranPensiun.Size = New Size(196, 41)
        lblIuranPensiun.TabIndex = 7
        lblIuranPensiun.Text = "Iuran Pensiun"
        ' 
        ' txtTunjangan
        ' 
        txtTunjangan.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtTunjangan.BorderStyle = BorderStyle.FixedSingle
        txtTunjangan.ForeColor = Color.White
        txtTunjangan.Location = New Point(93, 466)
        txtTunjangan.Margin = New Padding(4)
        txtTunjangan.Name = "txtTunjangan"
        txtTunjangan.Size = New Size(521, 39)
        txtTunjangan.TabIndex = 6
        ' 
        ' lblTunjangan
        ' 
        lblTunjangan.AutoSize = True
        lblTunjangan.Font = New Font("Segoe UI", 11F)
        lblTunjangan.ForeColor = Color.White
        lblTunjangan.Location = New Point(93, 426)
        lblTunjangan.Margin = New Padding(4, 0, 4, 0)
        lblTunjangan.Name = "lblTunjangan"
        lblTunjangan.Size = New Size(157, 41)
        lblTunjangan.TabIndex = 5
        lblTunjangan.Text = "Tunjangan"
        ' 
        ' txtGajiPokok
        ' 
        txtGajiPokok.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtGajiPokok.BorderStyle = BorderStyle.FixedSingle
        txtGajiPokok.ForeColor = Color.White
        txtGajiPokok.Location = New Point(93, 343)
        txtGajiPokok.Margin = New Padding(4)
        txtGajiPokok.Name = "txtGajiPokok"
        txtGajiPokok.Size = New Size(521, 39)
        txtGajiPokok.TabIndex = 4
        ' 
        ' lblGajiPokok
        ' 
        lblGajiPokok.AutoSize = True
        lblGajiPokok.Font = New Font("Segoe UI", 11F)
        lblGajiPokok.ForeColor = Color.White
        lblGajiPokok.Location = New Point(93, 303)
        lblGajiPokok.Margin = New Padding(4, 0, 4, 0)
        lblGajiPokok.Name = "lblGajiPokok"
        lblGajiPokok.Size = New Size(158, 41)
        lblGajiPokok.TabIndex = 3
        lblGajiPokok.Text = "Gaji Pokok"
        ' 
        ' cmbPegawai
        ' 
        cmbPegawai.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        cmbPegawai.ForeColor = Color.White
        cmbPegawai.FormattingEnabled = True
        cmbPegawai.Location = New Point(93, 229)
        cmbPegawai.Margin = New Padding(4)
        cmbPegawai.Name = "cmbPegawai"
        cmbPegawai.Size = New Size(521, 40)
        cmbPegawai.TabIndex = 2
        ' 
        ' lblPegawai
        ' 
        lblPegawai.AutoSize = True
        lblPegawai.Font = New Font("Segoe UI", 11F)
        lblPegawai.ForeColor = Color.White
        lblPegawai.Location = New Point(93, 184)
        lblPegawai.Margin = New Padding(4, 0, 4, 0)
        lblPegawai.Name = "lblPegawai"
        lblPegawai.Size = New Size(127, 41)
        lblPegawai.TabIndex = 1
        lblPegawai.Text = "Pegawai"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(188, 65)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(717, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pemotongan & Bukti Potong"
        ' 
        ' FormPemotonganBuktiPotong
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "FormPemotonganBuktiPotong"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pemotongan & Bukti Potong"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPegawai As System.Windows.Forms.Label
    Friend WithEvents cmbPegawai As System.Windows.Forms.ComboBox
    Friend WithEvents lblGajiPokok As System.Windows.Forms.Label
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents lblTunjangan As System.Windows.Forms.Label
    Friend WithEvents txtTunjangan As System.Windows.Forms.TextBox
    Friend WithEvents lblIuranPensiun As System.Windows.Forms.Label
    Friend WithEvents txtIuranPensiun As System.Windows.Forms.TextBox
    Friend WithEvents btnHitungPph As System.Windows.Forms.Button
    Friend WithEvents btnCetakBuktiPotong As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button

End Class

