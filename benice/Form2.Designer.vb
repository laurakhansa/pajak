<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnHitungSpt = New Button()
        btnHistori = New Button()
        btnEditProfil = New Button()
        lblSubtitle = New Label()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnHitungSpt)
        mainPanel.Controls.Add(btnHistori)
        mainPanel.Controls.Add(btnEditProfil)
        mainPanel.Controls.Add(lblSubtitle)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(225, 323)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(932, 509)
        mainPanel.TabIndex = 0
        ' 
        ' btnHitungSpt
        ' 
        btnHitungSpt.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnHitungSpt.FlatAppearance.BorderSize = 0
        btnHitungSpt.FlatStyle = FlatStyle.Flat
        btnHitungSpt.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitungSpt.ForeColor = Color.White
        btnHitungSpt.Location = New Point(231, 387)
        btnHitungSpt.Name = "btnHitungSpt"
        btnHitungSpt.Size = New Size(420, 60)
        btnHitungSpt.TabIndex = 4
        btnHitungSpt.Text = "Hitung SPT Tahunan"
        btnHitungSpt.UseVisualStyleBackColor = False
        ' 
        ' btnHistori
        ' 
        btnHistori.BackColor = Color.FromArgb(CByte(45), CByte(90), CByte(170))
        btnHistori.FlatAppearance.BorderSize = 0
        btnHistori.FlatStyle = FlatStyle.Flat
        btnHistori.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnHistori.ForeColor = Color.White
        btnHistori.Location = New Point(231, 303)
        btnHistori.Name = "btnHistori"
        btnHistori.Size = New Size(420, 61)
        btnHistori.TabIndex = 3
        btnHistori.Text = "Lihat Histori"
        btnHistori.UseVisualStyleBackColor = False
        ' 
        ' btnEditProfil
        ' 
        btnEditProfil.BackColor = Color.FromArgb(CByte(45), CByte(90), CByte(170))
        btnEditProfil.FlatAppearance.BorderSize = 0
        btnEditProfil.FlatStyle = FlatStyle.Flat
        btnEditProfil.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditProfil.ForeColor = Color.White
        btnEditProfil.Location = New Point(231, 220)
        btnEditProfil.Name = "btnEditProfil"
        btnEditProfil.Size = New Size(420, 58)
        btnEditProfil.TabIndex = 2
        btnEditProfil.Text = "Edit Profil"
        btnEditProfil.UseVisualStyleBackColor = False
        ' 
        ' lblSubtitle
        ' 
        lblSubtitle.AutoSize = True
        lblSubtitle.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblSubtitle.ForeColor = Color.Gainsboro
        lblSubtitle.Location = New Point(85, 113)
        lblSubtitle.Name = "lblSubtitle"
        lblSubtitle.Size = New Size(748, 41)
        lblSubtitle.TabIndex = 1
        lblSubtitle.Text = "Silakan pilih menu untuk melanjutkan pengelolaan SPT."
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(124, 41)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(668, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Menu Utama Wajib Pajak"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1235)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menu"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents btnHitungSpt As System.Windows.Forms.Button
    Friend WithEvents btnHistori As System.Windows.Forms.Button
    Friend WithEvents btnEditProfil As System.Windows.Forms.Button
    Friend WithEvents lblSubtitle As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
End Class
