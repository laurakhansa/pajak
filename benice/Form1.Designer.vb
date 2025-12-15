<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mainPanel = New Panel()
        grpJenisLogin = New GroupBox()
        rbWajibPajak = New RadioButton()
        rbPemberiKerja = New RadioButton()
        btnLogin = New Button()
        linkLupaPassword = New LinkLabel()
        txtPassword = New TextBox()
        lblPassword = New Label()
        txtNpwp = New TextBox()
        lblNpwp = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        grpJenisLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(grpJenisLogin)
        mainPanel.Controls.Add(btnLogin)
        mainPanel.Controls.Add(linkLupaPassword)
        mainPanel.Controls.Add(txtPassword)
        mainPanel.Controls.Add(lblPassword)
        mainPanel.Controls.Add(txtNpwp)
        mainPanel.Controls.Add(lblNpwp)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(388, 239)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(597, 740)
        mainPanel.TabIndex = 0
        ' 
        ' grpJenisLogin
        ' 
        grpJenisLogin.Controls.Add(rbWajibPajak)
        grpJenisLogin.Controls.Add(rbPemberiKerja)
        grpJenisLogin.Font = New Font("Segoe UI", 10F)
        grpJenisLogin.ForeColor = Color.White
        grpJenisLogin.Location = New Point(72, 109)
        grpJenisLogin.Name = "grpJenisLogin"
        grpJenisLogin.Size = New Size(455, 137)
        grpJenisLogin.TabIndex = 7
        grpJenisLogin.TabStop = False
        ' 
        ' rbWajibPajak
        ' 
        rbWajibPajak.AutoSize = True
        rbWajibPajak.Checked = True
        rbWajibPajak.Font = New Font("Segoe UI", 10F)
        rbWajibPajak.ForeColor = Color.White
        rbWajibPajak.Location = New Point(29, 30)
        rbWajibPajak.Name = "rbWajibPajak"
        rbWajibPajak.Size = New Size(185, 41)
        rbWajibPajak.TabIndex = 0
        rbWajibPajak.TabStop = True
        rbWajibPajak.Text = "Wajib Pajak"
        rbWajibPajak.UseVisualStyleBackColor = True
        ' 
        ' rbPemberiKerja
        ' 
        rbPemberiKerja.AutoSize = True
        rbPemberiKerja.Font = New Font("Segoe UI", 10F)
        rbPemberiKerja.ForeColor = Color.White
        rbPemberiKerja.Location = New Point(29, 83)
        rbPemberiKerja.Name = "rbPemberiKerja"
        rbPemberiKerja.Size = New Size(212, 41)
        rbPemberiKerja.TabIndex = 1
        rbPemberiKerja.Text = "Pemberi Kerja"
        rbPemberiKerja.UseVisualStyleBackColor = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(71, 588)
        btnLogin.Margin = New Padding(4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(455, 70)
        btnLogin.TabIndex = 6
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' linkLupaPassword
        ' 
        linkLupaPassword.ActiveLinkColor = Color.LightSkyBlue
        linkLupaPassword.AutoSize = True
        linkLupaPassword.Font = New Font("Segoe UI", 10F, FontStyle.Underline)
        linkLupaPassword.LinkColor = Color.LightSkyBlue
        linkLupaPassword.Location = New Point(72, 516)
        linkLupaPassword.Margin = New Padding(4, 0, 4, 0)
        linkLupaPassword.Name = "linkLupaPassword"
        linkLupaPassword.Size = New Size(214, 37)
        linkLupaPassword.TabIndex = 5
        linkLupaPassword.TabStop = True
        linkLupaPassword.Text = "Lupa kata sandi?"
        ' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Font = New Font("Segoe UI", 11F)
        txtPassword.ForeColor = Color.White
        txtPassword.Location = New Point(72, 444)
        txtPassword.Margin = New Padding(4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(454, 47)
        txtPassword.TabIndex = 4
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Segoe UI", 11F)
        lblPassword.ForeColor = Color.White
        lblPassword.Location = New Point(72, 399)
        lblPassword.Margin = New Padding(4, 0, 4, 0)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(156, 41)
        lblPassword.TabIndex = 3
        lblPassword.Text = "Kata Sandi"
        ' 
        ' txtNpwp
        ' 
        txtNpwp.BackColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        txtNpwp.BorderStyle = BorderStyle.FixedSingle
        txtNpwp.Font = New Font("Segoe UI", 11F)
        txtNpwp.ForeColor = Color.White
        txtNpwp.Location = New Point(72, 335)
        txtNpwp.Margin = New Padding(4)
        txtNpwp.Name = "txtNpwp"
        txtNpwp.Size = New Size(454, 47)
        txtNpwp.TabIndex = 2
        ' 
        ' lblNpwp
        ' 
        lblNpwp.AutoSize = True
        lblNpwp.Font = New Font("Segoe UI", 11F)
        lblNpwp.ForeColor = Color.White
        lblNpwp.Location = New Point(72, 290)
        lblNpwp.Margin = New Padding(4, 0, 4, 0)
        lblNpwp.Name = "lblNpwp"
        lblNpwp.Size = New Size(102, 41)
        lblNpwp.TabIndex = 1
        lblNpwp.Text = "NPWP"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(85, 25)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(432, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Selamat Datang"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        grpJenisLogin.ResumeLayout(False)
        grpJenisLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblNpwp As System.Windows.Forms.Label
    Friend WithEvents txtNpwp As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents linkLupaPassword As System.Windows.Forms.LinkLabel
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents grpJenisLogin As System.Windows.Forms.GroupBox
    Friend WithEvents rbPemberiKerja As System.Windows.Forms.RadioButton
    Friend WithEvents rbWajibPajak As System.Windows.Forms.RadioButton

End Class
