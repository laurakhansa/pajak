<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManajemenPegawai
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
        btnHapus = New Button()
        btnEdit = New Button()
        btnTambah = New Button()
        gridPegawai = New DataGridView()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        CType(gridPegawai, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnKembali)
        mainPanel.Controls.Add(btnHapus)
        mainPanel.Controls.Add(btnEdit)
        mainPanel.Controls.Add(btnTambah)
        mainPanel.Controls.Add(gridPegawai)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(50, 50)
        mainPanel.Margin = New Padding(4)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1300, 1100)
        mainPanel.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        btnKembali.FlatAppearance.BorderSize = 0
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(1100, 1000)
        btnKembali.Margin = New Padding(4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 5
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(200), CByte(50), CByte(50))
        btnHapus.FlatAppearance.BorderSize = 0
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnHapus.ForeColor = Color.White
        btnHapus.Location = New Point(316, 1000)
        btnHapus.Margin = New Padding(4)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 50)
        btnHapus.TabIndex = 4
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(158, 1000)
        btnEdit.Margin = New Padding(4)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 50)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        btnTambah.ForeColor = Color.White
        btnTambah.Location = New Point(50, 1000)
        btnTambah.Margin = New Padding(4)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(100, 50)
        btnTambah.TabIndex = 2
        btnTambah.Text = "+ Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' gridPegawai
        ' 
        gridPegawai.AllowUserToAddRows = False
        gridPegawai.AllowUserToDeleteRows = False
        gridPegawai.BackgroundColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        gridPegawai.BorderStyle = BorderStyle.None
        gridPegawai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridPegawai.GridColor = Color.FromArgb(CByte(40), CByte(42), CByte(70))
        gridPegawai.Location = New Point(50, 150)
        gridPegawai.Margin = New Padding(4)
        gridPegawai.MultiSelect = False
        gridPegawai.Name = "gridPegawai"
        gridPegawai.ReadOnly = True
        gridPegawai.RowHeadersVisible = False
        gridPegawai.RowHeadersWidth = 82
        gridPegawai.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridPegawai.Size = New Size(1200, 800)
        gridPegawai.TabIndex = 1
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(50, 40)
        lblTitle.Margin = New Padding(4, 0, 4, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(686, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Manajemen Data Pegawai"
        ' 
        ' FormManajemenPegawai
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1401, 1240)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F)
        Margin = New Padding(4)
        Name = "FormManajemenPegawai"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Manajemen Data Pegawai"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        CType(gridPegawai, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents gridPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnKembali As System.Windows.Forms.Button

End Class

