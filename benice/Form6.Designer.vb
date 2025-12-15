<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        btnSelanjutnya = New Button()
        btnKembali = New Button()
        btnKonfirmasiPengembalian = New Button()
        txtInstruksiWp = New TextBox()
        lblInstruksiWp = New Label()
        txtJumlahKelebihanBayar = New TextBox()
        lblJumlahKelebihanBayar = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnSelanjutnya)
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(btnKonfirmasiPengembalian)
        mainPanel.Controls.Add(txtInstruksiWp)
        mainPanel.Controls.Add(lblInstruksiWp)
        mainPanel.Controls.Add(txtJumlahKelebihanBayar)
        mainPanel.Controls.Add(lblJumlahKelebihanBayar)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(126, 238)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1127, 675)
        mainPanel.TabIndex = 0
        ' 
        ' btnSelanjutnya
        ' 
        btnSelanjutnya.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnSelanjutnya.FlatAppearance.BorderSize = 0
        btnSelanjutnya.FlatStyle = FlatStyle.Flat
        btnSelanjutnya.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnSelanjutnya.ForeColor = Color.White
        btnSelanjutnya.Location = New Point(794, 506)
        btnSelanjutnya.Name = "btnSelanjutnya"
        btnSelanjutnya.Size = New Size(261, 50)
        btnSelanjutnya.TabIndex = 6
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
        btnKembali.Location = New Point(794, 570)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(261, 50)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnKonfirmasiPengembalian
        ' 
        btnKonfirmasiPengembalian.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnKonfirmasiPengembalian.FlatAppearance.BorderSize = 0
        btnKonfirmasiPengembalian.FlatStyle = FlatStyle.Flat
        btnKonfirmasiPengembalian.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnKonfirmasiPengembalian.ForeColor = Color.White
        btnKonfirmasiPengembalian.Location = New Point(77, 506)
        btnKonfirmasiPengembalian.Name = "btnKonfirmasiPengembalian"
        btnKonfirmasiPengembalian.Size = New Size(615, 50)
        btnKonfirmasiPengembalian.TabIndex = 5
        btnKonfirmasiPengembalian.Text = "Konfirmasi Uang Telah Dikembalikan"
        btnKonfirmasiPengembalian.UseVisualStyleBackColor = False
        ' 
        ' txtInstruksiWp
        ' 
        txtInstruksiWp.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtInstruksiWp.BorderStyle = BorderStyle.FixedSingle
        txtInstruksiWp.ForeColor = Color.White
        txtInstruksiWp.Location = New Point(77, 277)
        txtInstruksiWp.Multiline = True
        txtInstruksiWp.Name = "txtInstruksiWp"
        txtInstruksiWp.ScrollBars = ScrollBars.Vertical
        txtInstruksiWp.Size = New Size(978, 190)
        txtInstruksiWp.TabIndex = 4
        ' 
        ' lblInstruksiWp
        ' 
        lblInstruksiWp.AutoSize = True
        lblInstruksiWp.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstruksiWp.ForeColor = Color.White
        lblInstruksiWp.Location = New Point(77, 233)
        lblInstruksiWp.Name = "lblInstruksiWp"
        lblInstruksiWp.Size = New Size(181, 41)
        lblInstruksiWp.TabIndex = 3
        lblInstruksiWp.Text = "Instruksi WP"
        ' 
        ' txtJumlahKelebihanBayar
        ' 
        txtJumlahKelebihanBayar.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtJumlahKelebihanBayar.BorderStyle = BorderStyle.FixedSingle
        txtJumlahKelebihanBayar.ForeColor = Color.White
        txtJumlahKelebihanBayar.Location = New Point(77, 168)
        txtJumlahKelebihanBayar.Name = "txtJumlahKelebihanBayar"
        txtJumlahKelebihanBayar.Size = New Size(978, 39)
        txtJumlahKelebihanBayar.TabIndex = 2
        ' 
        ' lblJumlahKelebihanBayar
        ' 
        lblJumlahKelebihanBayar.AutoSize = True
        lblJumlahKelebihanBayar.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblJumlahKelebihanBayar.ForeColor = Color.White
        lblJumlahKelebihanBayar.Location = New Point(77, 124)
        lblJumlahKelebihanBayar.Name = "lblJumlahKelebihanBayar"
        lblJumlahKelebihanBayar.Size = New Size(329, 41)
        lblJumlahKelebihanBayar.TabIndex = 1
        lblJumlahKelebihanBayar.Text = "Jumlah Kelebihan Bayar"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(379, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(326, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Lebih Bayar"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1400, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Lebih Bayar"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblJumlahKelebihanBayar As System.Windows.Forms.Label
    Friend WithEvents txtJumlahKelebihanBayar As System.Windows.Forms.TextBox
    Friend WithEvents lblInstruksiWp As System.Windows.Forms.Label
    Friend WithEvents txtInstruksiWp As System.Windows.Forms.TextBox
    Friend WithEvents btnKonfirmasiPengembalian As System.Windows.Forms.Button
    Friend WithEvents btnSelanjutnya As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
