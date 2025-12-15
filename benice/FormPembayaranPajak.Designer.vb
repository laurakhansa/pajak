<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembayaranPajak
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
        btnLihatRiwayat = New Button()
        btnGenerateKodeBilling = New Button()
        txtJumlahPajak = New TextBox()
        lblJumlahPajak = New Label()
        cmbJenisPajak = New ComboBox()
        lblJenisPajak = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(btnLihatRiwayat)
        mainPanel.Controls.Add(btnGenerateKodeBilling)
        mainPanel.Controls.Add(txtJumlahPajak)
        mainPanel.Controls.Add(lblJumlahPajak)
        mainPanel.Controls.Add(cmbJenisPajak)
        mainPanel.Controls.Add(lblJenisPajak)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(225, 180)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(927, 755)
        mainPanel.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(637, 644)
        btnKembali.Margin = New Padding(4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnLihatRiwayat
        ' 
        btnLihatRiwayat.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnLihatRiwayat.FlatAppearance.BorderSize = 0
        btnLihatRiwayat.FlatStyle = FlatStyle.Flat
        btnLihatRiwayat.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnLihatRiwayat.ForeColor = Color.White
        btnLihatRiwayat.Location = New Point(487, 483)
        btnLihatRiwayat.Margin = New Padding(4)
        btnLihatRiwayat.Name = "btnLihatRiwayat"
        btnLihatRiwayat.Size = New Size(300, 57)
        btnLihatRiwayat.TabIndex = 6
        btnLihatRiwayat.Text = "Lihat Riwayat Setoran"
        btnLihatRiwayat.UseVisualStyleBackColor = False
        ' 
        ' btnGenerateKodeBilling
        ' 
        btnGenerateKodeBilling.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnGenerateKodeBilling.FlatAppearance.BorderSize = 0
        btnGenerateKodeBilling.FlatStyle = FlatStyle.Flat
        btnGenerateKodeBilling.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnGenerateKodeBilling.ForeColor = Color.White
        btnGenerateKodeBilling.Location = New Point(154, 485)
        btnGenerateKodeBilling.Margin = New Padding(4)
        btnGenerateKodeBilling.Name = "btnGenerateKodeBilling"
        btnGenerateKodeBilling.Size = New Size(250, 55)
        btnGenerateKodeBilling.TabIndex = 5
        btnGenerateKodeBilling.Text = "Generate Kode Billing"
        btnGenerateKodeBilling.UseVisualStyleBackColor = False
        ' 
        ' txtJumlahPajak
        ' 
        txtJumlahPajak.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtJumlahPajak.BorderStyle = BorderStyle.FixedSingle
        txtJumlahPajak.ForeColor = Color.White
        txtJumlahPajak.Location = New Point(154, 389)
        txtJumlahPajak.Margin = New Padding(4)
        txtJumlahPajak.Name = "txtJumlahPajak"
        txtJumlahPajak.Size = New Size(484, 39)
        txtJumlahPajak.TabIndex = 4
        ' 
        ' lblJumlahPajak
        ' 
        lblJumlahPajak.AutoSize = True
        lblJumlahPajak.Font = New Font("Segoe UI", 11F)
        lblJumlahPajak.ForeColor = Color.White
        lblJumlahPajak.Location = New Point(154, 349)
        lblJumlahPajak.Margin = New Padding(4, 0, 4, 0)
        lblJumlahPajak.Name = "lblJumlahPajak"
        lblJumlahPajak.Size = New Size(249, 41)
        lblJumlahPajak.TabIndex = 3
        lblJumlahPajak.Text = "Jumlah Pajak (Rp)"
        ' 
        ' cmbJenisPajak
        ' 
        cmbJenisPajak.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        cmbJenisPajak.ForeColor = Color.White
        cmbJenisPajak.FormattingEnabled = True
        cmbJenisPajak.Items.AddRange(New Object() {"PPh Pasal 21", "PPh Pasal 23", "PPh Pasal 26"})
        cmbJenisPajak.Location = New Point(154, 263)
        cmbJenisPajak.Margin = New Padding(4)
        cmbJenisPajak.Name = "cmbJenisPajak"
        cmbJenisPajak.Size = New Size(484, 40)
        cmbJenisPajak.TabIndex = 2
        ' 
        ' lblJenisPajak
        ' 
        lblJenisPajak.AutoSize = True
        lblJenisPajak.Font = New Font("Segoe UI", 11F)
        lblJenisPajak.ForeColor = Color.White
        lblJenisPajak.Location = New Point(154, 223)
        lblJenisPajak.Margin = New Padding(4, 0, 4, 0)
        lblJenisPajak.Name = "lblJenisPajak"
        lblJenisPajak.Size = New Size(158, 41)
        lblJenisPajak.TabIndex = 1
        lblJenisPajak.Text = "Jenis Pajak"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(46, 60)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(833, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Pembayaran (Penyetoran) Pajak"
        ' 
        ' FormPembayaranPajak
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "FormPembayaranPajak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pembayaran (Penyetoran) Pajak"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblJenisPajak As System.Windows.Forms.Label
    Friend WithEvents cmbJenisPajak As System.Windows.Forms.ComboBox
    Friend WithEvents lblJumlahPajak As System.Windows.Forms.Label
    Friend WithEvents txtJumlahPajak As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerateKodeBilling As System.Windows.Forms.Button
    Friend WithEvents btnLihatRiwayat As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button

End Class

