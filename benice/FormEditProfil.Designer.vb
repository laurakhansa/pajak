<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditProfil
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
        btnBatal = New Button()
        btnSimpan = New Button()
        txtAlamat = New TextBox()
        lblAlamat = New Label()
        txtNoHp = New TextBox()
        lblNoHp = New Label()
        txtEmail = New TextBox()
        lblEmail = New Label()
        txtNama = New TextBox()
        lblNama = New Label()
        txtNpwp = New TextBox()
        lblNpwp = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnBatal)
        mainPanel.Controls.Add(btnSimpan)
        mainPanel.Controls.Add(txtAlamat)
        mainPanel.Controls.Add(lblAlamat)
        mainPanel.Controls.Add(txtNoHp)
        mainPanel.Controls.Add(lblNoHp)
        mainPanel.Controls.Add(txtEmail)
        mainPanel.Controls.Add(lblEmail)
        mainPanel.Controls.Add(txtNama)
        mainPanel.Controls.Add(lblNama)
        mainPanel.Controls.Add(txtNpwp)
        mainPanel.Controls.Add(lblNpwp)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(158, 256)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1070, 594)
        mainPanel.TabIndex = 0
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnBatal.FlatAppearance.BorderSize = 0
        btnBatal.FlatStyle = FlatStyle.Flat
        btnBatal.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(689, 515)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(130, 53)
        btnBatal.TabIndex = 12
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.White
        btnSimpan.Location = New Point(839, 515)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 53)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtAlamat.BorderStyle = BorderStyle.FixedSingle
        txtAlamat.ForeColor = Color.White
        txtAlamat.Location = New Point(60, 378)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.ScrollBars = ScrollBars.Vertical
        txtAlamat.Size = New Size(929, 100)
        txtAlamat.TabIndex = 10
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAlamat.ForeColor = Color.White
        lblAlamat.Location = New Point(60, 334)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(110, 41)
        lblAlamat.TabIndex = 9
        lblAlamat.Text = "Alamat"
        ' 
        ' txtNoHp
        ' 
        txtNoHp.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtNoHp.BorderStyle = BorderStyle.FixedSingle
        txtNoHp.ForeColor = Color.White
        txtNoHp.Location = New Point(526, 277)
        txtNoHp.Name = "txtNoHp"
        txtNoHp.Size = New Size(463, 39)
        txtNoHp.TabIndex = 8
        ' 
        ' lblNoHp
        ' 
        lblNoHp.AutoSize = True
        lblNoHp.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNoHp.ForeColor = Color.White
        lblNoHp.Location = New Point(526, 233)
        lblNoHp.Name = "lblNoHp"
        lblNoHp.Size = New Size(230, 41)
        lblNoHp.TabIndex = 7
        lblNoHp.Text = "No. Handphone"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.ForeColor = Color.White
        txtEmail.Location = New Point(60, 277)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(369, 39)
        txtEmail.TabIndex = 6
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.ForeColor = Color.White
        lblEmail.Location = New Point(60, 233)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(88, 41)
        lblEmail.TabIndex = 5
        lblEmail.Text = "Email"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtNama.BorderStyle = BorderStyle.FixedSingle
        txtNama.ForeColor = Color.White
        txtNama.Location = New Point(526, 175)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(463, 39)
        txtNama.TabIndex = 4
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNama.ForeColor = Color.White
        lblNama.Location = New Point(526, 131)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(96, 41)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama"
        ' 
        ' txtNpwp
        ' 
        txtNpwp.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtNpwp.BorderStyle = BorderStyle.FixedSingle
        txtNpwp.ForeColor = Color.White
        txtNpwp.Location = New Point(60, 175)
        txtNpwp.Name = "txtNpwp"
        txtNpwp.ReadOnly = True
        txtNpwp.Size = New Size(369, 39)
        txtNpwp.TabIndex = 2
        ' 
        ' lblNpwp
        ' 
        lblNpwp.AutoSize = True
        lblNpwp.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNpwp.ForeColor = Color.White
        lblNpwp.Location = New Point(60, 131)
        lblNpwp.Name = "lblNpwp"
        lblNpwp.Size = New Size(102, 41)
        lblNpwp.TabIndex = 1
        lblNpwp.Text = "NPWP"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(369, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(280, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Edit Profil"
        ' 
        ' FormEditProfil
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1235)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormEditProfil"
        StartPosition = FormStartPosition.CenterParent
        Text = "Edit Profil Wajib Pajak"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNpwp As System.Windows.Forms.Label
    Friend WithEvents txtNpwp As System.Windows.Forms.TextBox
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblNoHp As System.Windows.Forms.Label
    Friend WithEvents txtNoHp As System.Windows.Forms.TextBox
    Friend WithEvents lblAlamat As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button

End Class


