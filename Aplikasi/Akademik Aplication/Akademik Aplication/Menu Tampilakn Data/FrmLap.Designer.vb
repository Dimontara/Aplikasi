<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLap
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Keterangan = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnKeluar = New System.Windows.Forms.PictureBox()
        Me.BtnCari = New System.Windows.Forms.PictureBox()
        Me.DgPenjualan = New System.Windows.Forms.DataGridView()
        Me.TanggalAwal = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblData = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.BtnKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "KlikKanan"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 70)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Tag = "11"
        Me.ToolStripMenuItem1.Text = "Refresh"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem2.Tag = "1"
        Me.ToolStripMenuItem2.Text = "Exit"
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKeluar.Location = New System.Drawing.Point(1341, 33)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(24, 24)
        Me.BtnKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnKeluar.TabIndex = 372
        Me.BtnKeluar.TabStop = False
        Me.BtnKeluar.Tag = "1"
        Me.Keterangan.SetToolTip(Me.BtnKeluar, "Silahkan klik tombol ini untuk keluar dari menu ini ")
        '
        'BtnCari
        '
        Me.BtnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCari.BackColor = System.Drawing.Color.White
        Me.BtnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCari.Image = Global.Akademik_Aplication.My.Resources.Resources.search
        Me.BtnCari.Location = New System.Drawing.Point(1299, 33)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(19, 19)
        Me.BtnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCari.TabIndex = 382
        Me.BtnCari.TabStop = False
        Me.BtnCari.Tag = "2"
        Me.Keterangan.SetToolTip(Me.BtnCari, "Silahkan klik tombol ini untuk menacri data")
        '
        'DgPenjualan
        '
        Me.DgPenjualan.AllowUserToAddRows = False
        Me.DgPenjualan.AllowUserToDeleteRows = False
        Me.DgPenjualan.AllowUserToResizeColumns = False
        Me.DgPenjualan.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.DgPenjualan.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgPenjualan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DgPenjualan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgPenjualan.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgPenjualan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgPenjualan.GridColor = System.Drawing.Color.DimGray
        Me.DgPenjualan.Location = New System.Drawing.Point(0, 70)
        Me.DgPenjualan.Name = "DgPenjualan"
        Me.DgPenjualan.RowHeadersWidth = 10
        Me.DgPenjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgPenjualan.Size = New System.Drawing.Size(1354, 328)
        Me.DgPenjualan.TabIndex = 364
        '
        'TanggalAwal
        '
        Me.TanggalAwal.CustomFormat = "yyyy"
        Me.TanggalAwal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TanggalAwal.Location = New System.Drawing.Point(1106, 34)
        Me.TanggalAwal.Name = "TanggalAwal"
        Me.TanggalAwal.ShowCheckBox = True
        Me.TanggalAwal.Size = New System.Drawing.Size(179, 23)
        Me.TanggalAwal.TabIndex = 381
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1354, 70)
        Me.PictureBox1.TabIndex = 376
        Me.PictureBox1.TabStop = False
        '
        'LblData
        '
        Me.LblData.AutoSize = True
        Me.LblData.BackColor = System.Drawing.Color.SteelBlue
        Me.LblData.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblData.ForeColor = System.Drawing.Color.White
        Me.LblData.Location = New System.Drawing.Point(28, 15)
        Me.LblData.Name = "LblData"
        Me.LblData.Size = New System.Drawing.Size(187, 40)
        Me.LblData.TabIndex = 383
        Me.LblData.Text = "Data Barang "
        '
        'FrmLap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1354, 398)
        Me.Controls.Add(Me.LblData)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.TanggalAwal)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.DgPenjualan)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLap"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.BtnKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Keterangan As System.Windows.Forms.ToolTip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnKeluar As System.Windows.Forms.PictureBox
    Friend WithEvents DgPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TanggalAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnCari As System.Windows.Forms.PictureBox
    Friend WithEvents LblData As System.Windows.Forms.Label
End Class
