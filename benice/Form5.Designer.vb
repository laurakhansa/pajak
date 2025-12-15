<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnSelanjutnya = New Button()
        grpKodeBilling = New GroupBox()
        btnKonfirmasiPembayaran = New Button()
        lblKodeBillingValue = New Label()
        lblKodeBillingTitle = New Label()
        btnTerbitkanKodeBilling = New Button()
        txtJumlahKurangBayar = New TextBox()
        lblJumlahKurangBayar = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        grpKodeBilling.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnSelanjutnya)
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(grpKodeBilling)
        mainPanel.Controls.Add(btnTerbitkanKodeBilling)
        mainPanel.Controls.Add(txtJumlahKurangBayar)
        mainPanel.Controls.Add(lblJumlahKurangBayar)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(152, 248)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1097, 632)
        mainPanel.TabIndex = 0
        ' 
        ' btnSelanjutnya
        ' 
        btnSelanjutnya.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnSelanjutnya.FlatAppearance.BorderSize = 0
        btnSelanjutnya.FlatStyle = FlatStyle.Flat
        btnSelanjutnya.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnSelanjutnya.ForeColor = Color.White
        btnSelanjutnya.Location = New Point(777, 549)
        btnSelanjutnya.Name = "btnSelanjutnya"
        btnSelanjutnya.Size = New Size(220, 50)
        btnSelanjutnya.TabIndex = 5
        btnSelanjutnya.Text = "Selanjutnya"
        btnSelanjutnya.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(87, 549)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 6
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' grpKodeBilling
        ' 
        grpKodeBilling.Controls.Add(btnKonfirmasiPembayaran)
        grpKodeBilling.Controls.Add(lblKodeBillingValue)
        grpKodeBilling.Controls.Add(lblKodeBillingTitle)
        grpKodeBilling.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpKodeBilling.ForeColor = Color.White
        grpKodeBilling.Location = New Point(87, 345)
        grpKodeBilling.Name = "grpKodeBilling"
        grpKodeBilling.Size = New Size(910, 180)
        grpKodeBilling.TabIndex = 4
        grpKodeBilling.TabStop = False
        ' 
        ' btnKonfirmasiPembayaran
        ' 
        btnKonfirmasiPembayaran.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnKonfirmasiPembayaran.FlatAppearance.BorderSize = 0
        btnKonfirmasiPembayaran.FlatStyle = FlatStyle.Flat
        btnKonfirmasiPembayaran.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnKonfirmasiPembayaran.ForeColor = Color.White
        btnKonfirmasiPembayaran.Location = New Point(518, 74)
        btnKonfirmasiPembayaran.Name = "btnKonfirmasiPembayaran"
        btnKonfirmasiPembayaran.Size = New Size(250, 50)
        btnKonfirmasiPembayaran.TabIndex = 2
        btnKonfirmasiPembayaran.Text = "Konfirmasi Pembayaran"
        btnKonfirmasiPembayaran.UseVisualStyleBackColor = False
        ' 
        ' lblKodeBillingValue
        ' 
        lblKodeBillingValue.AutoSize = True
        lblKodeBillingValue.Font = New Font("Segoe UI", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKodeBillingValue.ForeColor = Color.LightSkyBlue
        lblKodeBillingValue.Location = New Point(35, 100)
        lblKodeBillingValue.Name = "lblKodeBillingValue"
        lblKodeBillingValue.Size = New Size(236, 41)
        lblKodeBillingValue.TabIndex = 1
        lblKodeBillingValue.Text = "[Belum dihitung]"
        ' 
        ' lblKodeBillingTitle
        ' 
        lblKodeBillingTitle.AutoSize = True
        lblKodeBillingTitle.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblKodeBillingTitle.Location = New Point(35, 49)
        lblKodeBillingTitle.Name = "lblKodeBillingTitle"
        lblKodeBillingTitle.Size = New Size(280, 41)
        lblKodeBillingTitle.TabIndex = 0
        lblKodeBillingTitle.Text = "Kode Billing Anda:"
        ' 
        ' btnTerbitkanKodeBilling
        ' 
        btnTerbitkanKodeBilling.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnTerbitkanKodeBilling.FlatAppearance.BorderSize = 0
        btnTerbitkanKodeBilling.FlatStyle = FlatStyle.Flat
        btnTerbitkanKodeBilling.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTerbitkanKodeBilling.ForeColor = Color.White
        btnTerbitkanKodeBilling.Location = New Point(367, 260)
        btnTerbitkanKodeBilling.Name = "btnTerbitkanKodeBilling"
        btnTerbitkanKodeBilling.Size = New Size(360, 53)
        btnTerbitkanKodeBilling.TabIndex = 3
        btnTerbitkanKodeBilling.Text = "Terbitkan Kode Billing"
        btnTerbitkanKodeBilling.UseVisualStyleBackColor = False
        ' 
        ' txtJumlahKurangBayar
        ' 
        txtJumlahKurangBayar.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtJumlahKurangBayar.BorderStyle = BorderStyle.FixedSingle
        txtJumlahKurangBayar.ForeColor = Color.White
        txtJumlahKurangBayar.Location = New Point(87, 196)
        txtJumlahKurangBayar.Name = "txtJumlahKurangBayar"
        txtJumlahKurangBayar.Size = New Size(910, 39)
        txtJumlahKurangBayar.TabIndex = 2
        ' 
        ' lblJumlahKurangBayar
        ' 
        lblJumlahKurangBayar.AutoSize = True
        lblJumlahKurangBayar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJumlahKurangBayar.ForeColor = Color.White
        lblJumlahKurangBayar.Location = New Point(87, 142)
        lblJumlahKurangBayar.Name = "lblJumlahKurangBayar"
        lblJumlahKurangBayar.Size = New Size(293, 41)
        lblJumlahKurangBayar.TabIndex = 1
        lblJumlahKurangBayar.Text = "Jumlah Kurang Bayar"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(355, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(372, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Kurang Bayar"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1404, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kurang Bayar"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        grpKodeBilling.ResumeLayout(False)
        grpKodeBilling.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblJumlahKurangBayar As System.Windows.Forms.Label
    Friend WithEvents txtJumlahKurangBayar As System.Windows.Forms.TextBox
    Friend WithEvents btnTerbitkanKodeBilling As System.Windows.Forms.Button
    Friend WithEvents grpKodeBilling As System.Windows.Forms.GroupBox
    Friend WithEvents lblKodeBillingTitle As System.Windows.Forms.Label
    Friend WithEvents lblKodeBillingValue As System.Windows.Forms.Label
    Friend WithEvents btnKonfirmasiPembayaran As System.Windows.Forms.Button
    Friend WithEvents btnSelanjutnya As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
