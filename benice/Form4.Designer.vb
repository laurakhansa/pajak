<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnLanjut = New Button()
        grpStatusPajak = New GroupBox()
        lblStatusResult = New Label()
        lblStatusTitle = New Label()
        btnHitungStatus = New Button()
        grpQ6 = New GroupBox()
        rbQ6Tidak = New RadioButton()
        rbQ6Ya = New RadioButton()
        lblQ6 = New Label()
        grpQ7 = New GroupBox()
        rbQ7Tidak = New RadioButton()
        rbQ7Ya = New RadioButton()
        lblQ7 = New Label()
        grpQ5 = New GroupBox()
        rbQ5Tidak = New RadioButton()
        rbQ5Ya = New RadioButton()
        lblQ5 = New Label()
        grpQ4 = New GroupBox()
        rbQ4Tidak = New RadioButton()
        rbQ4Ya = New RadioButton()
        lblQ4 = New Label()
        grpQ3 = New GroupBox()
        rbQ3Tidak = New RadioButton()
        rbQ3Ya = New RadioButton()
        lblQ3 = New Label()
        grpQ2 = New GroupBox()
        rbQ2Tidak = New RadioButton()
        rbQ2Ya = New RadioButton()
        lblQ2 = New Label()
        grpQ1 = New GroupBox()
        rbQ1Tidak = New RadioButton()
        rbQ1Ya = New RadioButton()
        lblQ1 = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        grpStatusPajak.SuspendLayout()
        grpQ6.SuspendLayout()
        grpQ7.SuspendLayout()
        grpQ5.SuspendLayout()
        grpQ4.SuspendLayout()
        grpQ3.SuspendLayout()
        grpQ2.SuspendLayout()
        grpQ1.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnLanjut)
        mainPanel.Controls.Add(grpStatusPajak)
        mainPanel.Controls.Add(btnHitungStatus)
        mainPanel.Controls.Add(grpQ6)
        mainPanel.Controls.Add(grpQ7)
        mainPanel.Controls.Add(grpQ5)
        mainPanel.Controls.Add(grpQ4)
        mainPanel.Controls.Add(grpQ3)
        mainPanel.Controls.Add(grpQ2)
        mainPanel.Controls.Add(grpQ1)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(20, 20)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1340, 1171)
        mainPanel.TabIndex = 0
        ' 
        ' btnLanjut
        ' 
        btnLanjut.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnLanjut.FlatAppearance.BorderSize = 0
        btnLanjut.FlatStyle = FlatStyle.Flat
        btnLanjut.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnLanjut.ForeColor = Color.White
        btnLanjut.Location = New Point(803, 1084)
        btnLanjut.Name = "btnLanjut"
        btnLanjut.Size = New Size(413, 50)
        btnLanjut.TabIndex = 11
        btnLanjut.Text = "Lanjut ke Halaman"
        btnLanjut.UseVisualStyleBackColor = False
        ' 
        ' btnKembali (Removed)
        ' 

        ' 
        ' grpStatusPajak
        ' 
        grpStatusPajak.Controls.Add(lblStatusResult)
        grpStatusPajak.Controls.Add(lblStatusTitle)
        grpStatusPajak.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpStatusPajak.ForeColor = Color.White
        grpStatusPajak.Location = New Point(59, 1035)
        grpStatusPajak.Name = "grpStatusPajak"
        grpStatusPajak.Size = New Size(704, 114)
        grpStatusPajak.TabIndex = 10
        grpStatusPajak.TabStop = False
        ' 
        ' lblStatusResult
        ' 
        lblStatusResult.AutoSize = True
        lblStatusResult.Font = New Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblStatusResult.ForeColor = Color.LightSkyBlue
        lblStatusResult.Location = New Point(30, 62)
        lblStatusResult.Name = "lblStatusResult"
        lblStatusResult.Size = New Size(211, 37)
        lblStatusResult.TabIndex = 1
        lblStatusResult.Text = "[Belum dihitung]"
        ' 
        ' lblStatusTitle
        ' 
        lblStatusTitle.AutoSize = True
        lblStatusTitle.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatusTitle.Location = New Point(20, 25)
        lblStatusTitle.Name = "lblStatusTitle"
        lblStatusTitle.Size = New Size(253, 37)
        lblStatusTitle.TabIndex = 0
        lblStatusTitle.Text = "Status Pajak Anda:"
        ' 
        ' btnHitungStatus
        ' 
        btnHitungStatus.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnHitungStatus.FlatAppearance.BorderSize = 0
        btnHitungStatus.FlatStyle = FlatStyle.Flat
        btnHitungStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitungStatus.ForeColor = Color.White
        btnHitungStatus.Location = New Point(443, 961)
        btnHitungStatus.Name = "btnHitungStatus"
        btnHitungStatus.Size = New Size(320, 58)
        btnHitungStatus.TabIndex = 9
        btnHitungStatus.Text = "Hitung Status Pajak"
        btnHitungStatus.UseVisualStyleBackColor = False
        grpQ6.Controls.Add(rbQ6Tidak)
        grpQ6.Controls.Add(rbQ6Ya)
        grpQ6.Controls.Add(lblQ6)
        grpQ6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ6.ForeColor = Color.White
        grpQ6.Location = New Point(59, 697)
        grpQ6.Name = "grpQ6"
        grpQ6.Size = New Size(1207, 113)
        grpQ6.TabIndex = 7
        grpQ6.TabStop = False
        ' 
        ' rbQ6Tidak
        ' 
        rbQ6Tidak.AutoSize = True
        rbQ6Tidak.Location = New Point(215, 53)
        rbQ6Tidak.Name = "rbQ6Tidak"
        rbQ6Tidak.Size = New Size(112, 41)
        rbQ6Tidak.TabIndex = 2
        rbQ6Tidak.TabStop = True
        rbQ6Tidak.Text = "Tidak"
        rbQ6Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ6Ya
        ' 
        rbQ6Ya.AutoSize = True
        rbQ6Ya.Location = New Point(70, 53)
        rbQ6Ya.Name = "rbQ6Ya"
        rbQ6Ya.Size = New Size(75, 41)
        rbQ6Ya.TabIndex = 1
        rbQ6Ya.TabStop = True
        rbQ6Ya.Text = "Ya"
        rbQ6Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ6
        ' 
        lblQ6.AutoSize = True
        lblQ6.Location = New Point(10, 5)
        lblQ6.Name = "lblQ6"
        lblQ6.Size = New Size(1169, 37)
        lblQ6.TabIndex = 0
        lblQ6.Text = "Q6: Apakah Anda memiliki bukti pembayaran Zakat atau sumbangan keagamaan wajib yang sah?"
        ' 
        ' grpQ7
        ' 
        grpQ7.Controls.Add(rbQ7Tidak)
        grpQ7.Controls.Add(rbQ7Ya)
        grpQ7.Controls.Add(lblQ7)
        grpQ7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ7.ForeColor = Color.White
        grpQ7.Location = New Point(59, 816)
        grpQ7.Name = "grpQ7"
        grpQ7.Size = New Size(1207, 117)
        grpQ7.TabIndex = 8
        grpQ7.TabStop = False
        ' 
        ' rbQ7Tidak
        ' 
        rbQ7Tidak.AutoSize = True
        rbQ7Tidak.Location = New Point(215, 58)
        rbQ7Tidak.Name = "rbQ7Tidak"
        rbQ7Tidak.Size = New Size(112, 41)
        rbQ7Tidak.TabIndex = 2
        rbQ7Tidak.TabStop = True
        rbQ7Tidak.Text = "Tidak"
        rbQ7Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ7Ya
        ' 
        rbQ7Ya.AutoSize = True
        rbQ7Ya.Location = New Point(70, 58)
        rbQ7Ya.Name = "rbQ7Ya"
        rbQ7Ya.Size = New Size(75, 41)
        rbQ7Ya.TabIndex = 1
        rbQ7Ya.TabStop = True
        rbQ7Ya.Text = "Ya"
        rbQ7Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ7
        ' 
        lblQ7.AutoSize = True
        lblQ7.Location = New Point(10, 10)
        lblQ7.Name = "lblQ7"
        lblQ7.Size = New Size(1054, 37)
        lblQ7.TabIndex = 0
        lblQ7.Text = "Q7: Apakah Anda akan melaporkan SPT Tahunan setelah batas waktu tanggal 31 Maret?"
        ' 
        ' grpQ5
        ' 
        grpQ5.Controls.Add(rbQ5Tidak)
        grpQ5.Controls.Add(rbQ5Ya)
        grpQ5.Controls.Add(lblQ5)
        grpQ5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ5.ForeColor = Color.White
        grpQ5.Location = New Point(59, 577)
        grpQ5.Name = "grpQ5"
        grpQ5.Size = New Size(1207, 114)
        grpQ5.TabIndex = 6
        grpQ5.TabStop = False
        ' 
        ' rbQ5Tidak
        ' 
        rbQ5Tidak.AutoSize = True
        rbQ5Tidak.Location = New Point(215, 51)
        rbQ5Tidak.Name = "rbQ5Tidak"
        rbQ5Tidak.Size = New Size(112, 41)
        rbQ5Tidak.TabIndex = 2
        rbQ5Tidak.TabStop = True
        rbQ5Tidak.Text = "Tidak"
        rbQ5Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ5Ya
        ' 
        rbQ5Ya.AutoSize = True
        rbQ5Ya.Location = New Point(70, 51)
        rbQ5Ya.Name = "rbQ5Ya"
        rbQ5Ya.Size = New Size(75, 41)
        rbQ5Ya.TabIndex = 1
        rbQ5Ya.TabStop = True
        rbQ5Ya.Text = "Ya"
        rbQ5Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ5
        ' 
        lblQ5.AutoSize = True
        lblQ5.Location = New Point(10, 5)
        lblQ5.Name = "lblQ5"
        lblQ5.Size = New Size(1119, 37)
        lblQ5.TabIndex = 0
        lblQ5.Text = "Q5: Apakah ada penerimaan bonus besar, THR, atau kenaikan gaji mendadak dalam setahun?"
        ' 
        ' grpQ4
        ' 
        grpQ4.Controls.Add(rbQ4Tidak)
        grpQ4.Controls.Add(rbQ4Ya)
        grpQ4.Controls.Add(lblQ4)
        grpQ4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ4.ForeColor = Color.White
        grpQ4.Location = New Point(59, 460)
        grpQ4.Name = "grpQ4"
        grpQ4.Size = New Size(1207, 111)
        grpQ4.TabIndex = 5
        grpQ4.TabStop = False
        ' 
        ' rbQ4Tidak
        ' 
        rbQ4Tidak.AutoSize = True
        rbQ4Tidak.Location = New Point(215, 53)
        rbQ4Tidak.Name = "rbQ4Tidak"
        rbQ4Tidak.Size = New Size(112, 41)
        rbQ4Tidak.TabIndex = 2
        rbQ4Tidak.TabStop = True
        rbQ4Tidak.Text = "Tidak"
        rbQ4Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ4Ya
        ' 
        rbQ4Ya.AutoSize = True
        rbQ4Ya.Location = New Point(70, 53)
        rbQ4Ya.Name = "rbQ4Ya"
        rbQ4Ya.Size = New Size(75, 41)
        rbQ4Ya.TabIndex = 1
        rbQ4Ya.TabStop = True
        rbQ4Ya.Text = "Ya"
        rbQ4Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ4
        ' 
        lblQ4.AutoSize = True
        lblQ4.Location = New Point(10, 5)
        lblQ4.Name = "lblQ4"
        lblQ4.Size = New Size(984, 37)
        lblQ4.TabIndex = 0
        lblQ4.Text = "Q4: Apakah Anda mulai bekerja atau berhenti/resign di pertengahan tahun pajak?"
        ' 
        ' grpQ3
        ' 
        grpQ3.Controls.Add(rbQ3Tidak)
        grpQ3.Controls.Add(rbQ3Ya)
        grpQ3.Controls.Add(lblQ3)
        grpQ3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ3.ForeColor = Color.White
        grpQ3.Location = New Point(59, 341)
        grpQ3.Name = "grpQ3"
        grpQ3.Size = New Size(1207, 113)
        grpQ3.TabIndex = 4
        grpQ3.TabStop = False
        ' 
        ' rbQ3Tidak
        ' 
        rbQ3Tidak.AutoSize = True
        rbQ3Tidak.Location = New Point(215, 52)
        rbQ3Tidak.Name = "rbQ3Tidak"
        rbQ3Tidak.Size = New Size(112, 41)
        rbQ3Tidak.TabIndex = 2
        rbQ3Tidak.TabStop = True
        rbQ3Tidak.Text = "Tidak"
        rbQ3Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ3Ya
        ' 
        rbQ3Ya.AutoSize = True
        rbQ3Ya.Location = New Point(70, 52)
        rbQ3Ya.Name = "rbQ3Ya"
        rbQ3Ya.Size = New Size(75, 41)
        rbQ3Ya.TabIndex = 1
        rbQ3Ya.TabStop = True
        rbQ3Ya.Text = "Ya"
        rbQ3Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ3
        ' 
        lblQ3.AutoSize = True
        lblQ3.Location = New Point(10, 5)
        lblQ3.Name = "lblQ3"
        lblQ3.Size = New Size(777, 37)
        lblQ3.TabIndex = 0
        lblQ3.Text = "Q3: Apakah Anda memiliki lebih dari SATU sumber penghasilan?"
        ' 
        ' grpQ2
        ' 
        grpQ2.Controls.Add(rbQ2Tidak)
        grpQ2.Controls.Add(rbQ2Ya)
        grpQ2.Controls.Add(lblQ2)
        grpQ2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ2.ForeColor = Color.White
        grpQ2.Location = New Point(59, 224)
        grpQ2.Name = "grpQ2"
        grpQ2.Size = New Size(1207, 111)
        grpQ2.TabIndex = 3
        grpQ2.TabStop = False
        ' 
        ' rbQ2Tidak
        ' 
        rbQ2Tidak.AutoSize = True
        rbQ2Tidak.Location = New Point(215, 51)
        rbQ2Tidak.Name = "rbQ2Tidak"
        rbQ2Tidak.Size = New Size(112, 41)
        rbQ2Tidak.TabIndex = 2
        rbQ2Tidak.TabStop = True
        rbQ2Tidak.Text = "Tidak"
        rbQ2Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ2Ya
        ' 
        rbQ2Ya.AutoSize = True
        rbQ2Ya.Location = New Point(70, 51)
        rbQ2Ya.Name = "rbQ2Ya"
        rbQ2Ya.Size = New Size(75, 41)
        rbQ2Ya.TabIndex = 1
        rbQ2Ya.TabStop = True
        rbQ2Ya.Text = "Ya"
        rbQ2Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ2
        ' 
        lblQ2.AutoSize = True
        lblQ2.Location = New Point(10, 5)
        lblQ2.Name = "lblQ2"
        lblQ2.Size = New Size(895, 37)
        lblQ2.TabIndex = 0
        lblQ2.Text = "Q2: Apakah Anda menerima Gaji atau Penghasilan selama tahun pajak ini?"
        ' 
        ' grpQ1
        ' 
        grpQ1.Controls.Add(rbQ1Tidak)
        grpQ1.Controls.Add(rbQ1Ya)
        grpQ1.Controls.Add(lblQ1)
        grpQ1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        grpQ1.ForeColor = Color.White
        grpQ1.Location = New Point(59, 110)
        grpQ1.Name = "grpQ1"
        grpQ1.Size = New Size(1207, 108)
        grpQ1.TabIndex = 2
        grpQ1.TabStop = False
        ' 
        ' rbQ1Tidak
        ' 
        rbQ1Tidak.AutoSize = True
        rbQ1Tidak.Location = New Point(215, 48)
        rbQ1Tidak.Name = "rbQ1Tidak"
        rbQ1Tidak.Size = New Size(112, 41)
        rbQ1Tidak.TabIndex = 2
        rbQ1Tidak.TabStop = True
        rbQ1Tidak.Text = "Tidak"
        rbQ1Tidak.UseVisualStyleBackColor = True
        ' 
        ' rbQ1Ya
        ' 
        rbQ1Ya.AutoSize = True
        rbQ1Ya.Location = New Point(70, 48)
        rbQ1Ya.Name = "rbQ1Ya"
        rbQ1Ya.Size = New Size(75, 41)
        rbQ1Ya.TabIndex = 1
        rbQ1Ya.TabStop = True
        rbQ1Ya.Text = "Ya"
        rbQ1Ya.UseVisualStyleBackColor = True
        ' 
        ' lblQ1
        ' 
        lblQ1.AutoSize = True
        lblQ1.Location = New Point(10, 5)
        lblQ1.Name = "lblQ1"
        lblQ1.Size = New Size(955, 37)
        lblQ1.TabIndex = 0
        lblQ1.Text = "Q1: Apakah Anda memiliki Nomor Pokok Wajib Pajak (NPWP) yang masih aktif?"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(351, 12)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(604, 72)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Kuesioner Status Pajak"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1402, 1239)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kuesioner Status Pajak"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        grpStatusPajak.ResumeLayout(False)
        grpStatusPajak.PerformLayout()
        grpQ6.ResumeLayout(False)
        grpQ6.PerformLayout()
        grpQ7.ResumeLayout(False)
        grpQ7.PerformLayout()
        grpQ5.ResumeLayout(False)
        grpQ5.PerformLayout()
        grpQ4.ResumeLayout(False)
        grpQ4.PerformLayout()
        grpQ3.ResumeLayout(False)
        grpQ3.PerformLayout()
        grpQ2.ResumeLayout(False)
        grpQ2.PerformLayout()
        grpQ1.ResumeLayout(False)
        grpQ1.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents grpQ1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblQ1 As System.Windows.Forms.Label
    Friend WithEvents rbQ1Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ1Ya As System.Windows.Forms.RadioButton
    Friend WithEvents grpQ2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ2Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ2Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ2 As System.Windows.Forms.Label
    Friend WithEvents grpQ3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ3Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ3Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ3 As System.Windows.Forms.Label
    Friend WithEvents grpQ4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ4Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ4Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ4 As System.Windows.Forms.Label
    Friend WithEvents grpQ5 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ5Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ5Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ5 As System.Windows.Forms.Label
    Friend WithEvents grpQ6 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ6Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ6Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ6 As System.Windows.Forms.Label
    Friend WithEvents grpQ7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbQ7Tidak As System.Windows.Forms.RadioButton
    Friend WithEvents rbQ7Ya As System.Windows.Forms.RadioButton
    Friend WithEvents lblQ7 As System.Windows.Forms.Label
    Friend WithEvents btnHitungStatus As System.Windows.Forms.Button
    Friend WithEvents grpStatusPajak As System.Windows.Forms.GroupBox
    Friend WithEvents lblStatusResult As System.Windows.Forms.Label
    Friend WithEvents lblStatusTitle As System.Windows.Forms.Label
    Friend WithEvents btnLanjut As System.Windows.Forms.Button
End Class
