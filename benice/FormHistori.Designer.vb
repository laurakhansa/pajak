<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHistori
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
        btnTutup = New Button()
        lblKeterangan = New Label()
        gridHistori = New DataGridView()
        colTahunPajak = New DataGridViewTextBoxColumn()
        colTanggal = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colJumlah = New DataGridViewTextBoxColumn()
        lblTitle = New Label()
        mainPanel.SuspendLayout()
        CType(gridHistori, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' mainPanel
        ' 
        mainPanel.BackColor = Color.FromArgb(CByte(30), CByte(32), CByte(60))
        mainPanel.BorderStyle = BorderStyle.FixedSingle
        mainPanel.Controls.Add(btnTutup)
        mainPanel.Controls.Add(lblKeterangan)
        mainPanel.Controls.Add(gridHistori)
        mainPanel.Controls.Add(lblTitle)
        mainPanel.Location = New Point(144, 263)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(1105, 586)
        mainPanel.TabIndex = 0
        ' 
        ' btnTutup
        ' 
        btnTutup.BackColor = Color.FromArgb(CByte(64), CByte(121), CByte(229))
        btnTutup.FlatAppearance.BorderSize = 0
        btnTutup.FlatStyle = FlatStyle.Flat
        btnTutup.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTutup.ForeColor = Color.White
        btnTutup.Location = New Point(914, 496)
        btnTutup.Name = "btnTutup"
        btnTutup.Size = New Size(150, 48)
        btnTutup.TabIndex = 3
        btnTutup.Text = "Tutup"
        btnTutup.UseVisualStyleBackColor = False
        ' 
        ' lblKeterangan
        ' 
        lblKeterangan.AutoSize = True
        lblKeterangan.Font = New Font("Segoe UI", 10.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblKeterangan.ForeColor = Color.LightGray
        lblKeterangan.Location = New Point(55, 496)
        lblKeterangan.Name = "lblKeterangan"
        lblKeterangan.Size = New Size(541, 37)
        lblKeterangan.TabIndex = 2
        lblKeterangan.Text = "Riwayat SPT Tahunan yang pernah diajukan."
        ' 
        ' gridHistori
        ' 
        gridHistori.AllowUserToAddRows = False
        gridHistori.AllowUserToDeleteRows = False
        gridHistori.AllowUserToOrderColumns = True
        gridHistori.AllowUserToResizeRows = False
        gridHistori.BackgroundColor = Color.FromArgb(CByte(20), CByte(22), CByte(50))
        gridHistori.BorderStyle = BorderStyle.None
        gridHistori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridHistori.Columns.AddRange(New DataGridViewColumn() {colTahunPajak, colTanggal, colStatus, colJumlah})
        gridHistori.GridColor = Color.FromArgb(CByte(40), CByte(42), CByte(70))
        gridHistori.Location = New Point(43, 125)
        gridHistori.MultiSelect = False
        gridHistori.Name = "gridHistori"
        gridHistori.ReadOnly = True
        gridHistori.RightToLeft = RightToLeft.No
        gridHistori.RowHeadersVisible = False
        gridHistori.RowHeadersWidth = 82
        gridHistori.RowTemplate.Height = 28
        gridHistori.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridHistori.Size = New Size(709, 330)
        gridHistori.TabIndex = 1
        ' 
        ' colTahunPajak
        ' 
        colTahunPajak.HeaderText = "Tahun Pajak"
        colTahunPajak.MinimumWidth = 10
        colTahunPajak.Name = "colTahunPajak"
        colTahunPajak.ReadOnly = True
        colTahunPajak.Width = 200
        ' 
        ' colTanggal
        ' 
        colTanggal.HeaderText = "Tanggal"
        colTanggal.MinimumWidth = 10
        colTanggal.Name = "colTanggal"
        colTanggal.ReadOnly = True
        colTanggal.Width = 150
        ' 
        ' colStatus
        ' 
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 10
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Width = 180
        ' 
        ' colJumlah
        ' 
        colJumlah.HeaderText = "Jumlah (Rp)"
        colJumlah.MinimumWidth = 10
        colJumlah.Name = "colJumlah"
        colJumlah.ReadOnly = True
        colJumlah.Width = 180
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 20.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.White
        lblTitle.Location = New Point(312, 15)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(412, 72)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Histori SPT WP"
        ' 
        ' FormHistori
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(10), CByte(12), CByte(40))
        ClientSize = New Size(1403, 1238)
        Controls.Add(mainPanel)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "FormHistori"
        StartPosition = FormStartPosition.CenterParent
        Text = "Histori SPT Tahunan"
        mainPanel.ResumeLayout(False)
        mainPanel.PerformLayout()
        CType(gridHistori, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Public WithEvents gridHistori As DataGridView
    Friend WithEvents colTahunPajak As DataGridViewTextBoxColumn
    Friend WithEvents colTanggal As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colJumlah As DataGridViewTextBoxColumn

End Class


