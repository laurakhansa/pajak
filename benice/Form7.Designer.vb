<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        lblNote = New Label()
        btnSubmitSpt = New Button()
        chkPernyataan = New CheckBox()
        txtStatusFinalSpt = New TextBox()
        lblStatusFinalSpt = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(lblNote)
        mainPanel.Controls.Add(btnSubmitSpt)
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(chkPernyataan)
        mainPanel.Controls.Add(txtStatusFinalSpt)
        mainPanel.Controls.Add(lblStatusFinalSpt)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(166, 262)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1061, 575)
        mainPanel.TabIndex = 0
        ' 
        ' lblNote
        ' 
        lblNote.AutoSize = True
        lblNote.Font = New Font("Segoe UI", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNote.ForeColor = Color.LightSkyBlue
        lblNote.Location = New Point(91, 480)
        lblNote.Name = "lblNote"
        lblNote.Size = New Size(855, 37)
        lblNote.TabIndex = 5
        lblNote.Text = "* SPT akan dikirim dan menampilkan Bukti Penerimaan Elektronik (BPE)"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(470, 398)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 63)
        btnKembali.TabIndex = 6
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnSubmitSpt
        ' 
        btnSubmitSpt.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnSubmitSpt.FlatAppearance.BorderSize = 0
        btnSubmitSpt.FlatStyle = FlatStyle.Flat
        btnSubmitSpt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmitSpt.ForeColor = Color.White
        btnSubmitSpt.Location = New Point(91, 398)
        btnSubmitSpt.Name = "btnSubmitSpt"
        btnSubmitSpt.Size = New Size(360, 63)
        btnSubmitSpt.TabIndex = 4
        btnSubmitSpt.Text = "Submit SPT Tahunan"
        btnSubmitSpt.UseVisualStyleBackColor = False
        ' 
        ' chkPernyataan
        ' 
        chkPernyataan.AutoSize = True
        chkPernyataan.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkPernyataan.ForeColor = Color.White
        chkPernyataan.Location = New Point(91, 311)
        chkPernyataan.Name = "chkPernyataan"
        chkPernyataan.Size = New Size(787, 45)
        chkPernyataan.TabIndex = 3
        chkPernyataan.Text = "Saya menyatakan bahwa data yang saya isi sudah benar"
        chkPernyataan.UseVisualStyleBackColor = True
        ' 
        ' txtStatusFinalSpt
        ' 
        txtStatusFinalSpt.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtStatusFinalSpt.BorderStyle = BorderStyle.FixedSingle
        txtStatusFinalSpt.ForeColor = Color.White
        txtStatusFinalSpt.Location = New Point(91, 224)
        txtStatusFinalSpt.Name = "txtStatusFinalSpt"
        txtStatusFinalSpt.Size = New Size(855, 39)
        txtStatusFinalSpt.TabIndex = 2
        ' 
        ' lblStatusFinalSpt
        ' 
        lblStatusFinalSpt.AutoSize = True
        lblStatusFinalSpt.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatusFinalSpt.ForeColor = Color.White
        lblStatusFinalSpt.Location = New Point(91, 169)
        lblStatusFinalSpt.Name = "lblStatusFinalSpt"
        lblStatusFinalSpt.Size = New Size(224, 41)
        lblStatusFinalSpt.TabIndex = 1
        lblStatusFinalSpt.Text = "Status Final SPT"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(235, 49)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(553, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Submit SPT Tahunan"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1402, 1236)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Submit SPT Tahunan"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblStatusFinalSpt As System.Windows.Forms.Label
    Friend WithEvents txtStatusFinalSpt As System.Windows.Forms.TextBox
    Friend WithEvents chkPernyataan As System.Windows.Forms.CheckBox
    Friend WithEvents btnSubmitSpt As System.Windows.Forms.Button
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
End Class
