<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmData))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPencarian = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Keterangan = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.KlikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintFakturToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UbahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HapusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetailSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembayaranHutangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnRetur = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgPenjualan = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnTambah = New System.Windows.Forms.PictureBox()
        Me.BtnUbah = New System.Windows.Forms.PictureBox()
        Me.BtnHapus = New System.Windows.Forms.PictureBox()
        Me.BtnRefresh = New System.Windows.Forms.PictureBox()
        Me.BtnCari = New System.Windows.Forms.PictureBox()
        Me.BtnKeluar = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KlikKanan.SuspendLayout()
        CType(Me.DgPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnTambah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnUbah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHapus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnCari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnKeluar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "KlikKanan"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem1.Tag = "11"
        Me.ToolStripMenuItem1.Text = "Refresh"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem2.Tag = "1"
        Me.ToolStripMenuItem2.Text = "Exit"
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
        Me.LblData.TabIndex = 99
        Me.LblData.Text = "Data Barang "
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(533, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Search by"
        '
        'TxtPencarian
        '
        Me.TxtPencarian.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPencarian.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPencarian.Location = New System.Drawing.Point(803, 33)
        Me.TxtPencarian.Name = "TxtPencarian"
        Me.TxtPencarian.Size = New System.Drawing.Size(250, 23)
        Me.TxtPencarian.TabIndex = 97
        Me.TxtPencarian.Tag = "1"
        Me.Keterangan.SetToolTip(Me.TxtPencarian, "Ketikan sesuatu disini")
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label3.Location = New System.Drawing.Point(519, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 21)
        Me.Label3.TabIndex = 342
        Me.Label3.Text = "|"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label4.Location = New System.Drawing.Point(441, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 21)
        Me.Label4.TabIndex = 351
        Me.Label4.Text = "|"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label5.Location = New System.Drawing.Point(402, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 21)
        Me.Label5.TabIndex = 352
        Me.Label5.Text = "|"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.BackgroundImage = Global.Akademik_Aplication.My.Resources.Resources.tick
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(337, 31)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 382
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "11"
        Me.Keterangan.SetToolTip(Me.PictureBox2, "Silahkan klik tombol ini untuk pilih baris")
        Me.PictureBox2.Visible = False
        '
        'KlikKanan
        '
        Me.KlikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.PrintFakturToolStripMenuItem, Me.UbahToolStripMenuItem, Me.HapusToolStripMenuItem, Me.DetailSupplierToolStripMenuItem, Me.PembayaranHutangToolStripMenuItem, Me.BtnRetur})
        Me.KlikKanan.Name = "KlikKanan"
        Me.KlikKanan.Size = New System.Drawing.Size(184, 158)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RefreshToolStripMenuItem.Tag = "11"
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'PrintFakturToolStripMenuItem
        '
        Me.PrintFakturToolStripMenuItem.Name = "PrintFakturToolStripMenuItem"
        Me.PrintFakturToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PrintFakturToolStripMenuItem.Tag = "7"
        Me.PrintFakturToolStripMenuItem.Text = "Print Faktur"
        Me.PrintFakturToolStripMenuItem.Visible = False
        '
        'UbahToolStripMenuItem
        '
        Me.UbahToolStripMenuItem.Name = "UbahToolStripMenuItem"
        Me.UbahToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.UbahToolStripMenuItem.Tag = "4"
        Me.UbahToolStripMenuItem.Text = "Ubah"
        '
        'HapusToolStripMenuItem
        '
        Me.HapusToolStripMenuItem.Name = "HapusToolStripMenuItem"
        Me.HapusToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.HapusToolStripMenuItem.Tag = "3"
        Me.HapusToolStripMenuItem.Text = "Hapus"
        '
        'DetailSupplierToolStripMenuItem
        '
        Me.DetailSupplierToolStripMenuItem.Name = "DetailSupplierToolStripMenuItem"
        Me.DetailSupplierToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DetailSupplierToolStripMenuItem.Tag = "12"
        Me.DetailSupplierToolStripMenuItem.Text = "Detail Supplier"
        '
        'PembayaranHutangToolStripMenuItem
        '
        Me.PembayaranHutangToolStripMenuItem.Name = "PembayaranHutangToolStripMenuItem"
        Me.PembayaranHutangToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.PembayaranHutangToolStripMenuItem.Tag = "10"
        Me.PembayaranHutangToolStripMenuItem.Text = "Pembayaran Hutang"
        '
        'BtnRetur
        '
        Me.BtnRetur.Name = "BtnRetur"
        Me.BtnRetur.Size = New System.Drawing.Size(183, 22)
        Me.BtnRetur.Text = "Retur Barang"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Label6.Location = New System.Drawing.Point(480, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 21)
        Me.Label6.TabIndex = 361
        Me.Label6.Text = "|"
        '
        'CbFilter
        '
        Me.CbFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbFilter.BackColor = System.Drawing.Color.White
        Me.CbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbFilter.FormattingEnabled = True
        Me.CbFilter.Location = New System.Drawing.Point(600, 33)
        Me.CbFilter.Name = "CbFilter"
        Me.CbFilter.Size = New System.Drawing.Size(188, 23)
        Me.CbFilter.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(789, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 20)
        Me.Label1.TabIndex = 363
        Me.Label1.Text = ":"
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
        Me.DgPenjualan.Size = New System.Drawing.Size(1097, 328)
        Me.DgPenjualan.TabIndex = 95
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1097, 70)
        Me.PictureBox1.TabIndex = 354
        Me.PictureBox1.TabStop = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTambah.BackgroundImage = CType(resources.GetObject("BtnTambah.BackgroundImage"), System.Drawing.Image)
        Me.BtnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Location = New System.Drawing.Point(378, 30)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(24, 24)
        Me.BtnTambah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnTambah.TabIndex = 384
        Me.BtnTambah.TabStop = False
        Me.BtnTambah.Tag = "5"
        Me.Keterangan.SetToolTip(Me.BtnTambah, "Silahkan klik tombol ini untuk menambah data baru ")
        '
        'BtnUbah
        '
        Me.BtnUbah.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnUbah.BackgroundImage = CType(resources.GetObject("BtnUbah.BackgroundImage"), System.Drawing.Image)
        Me.BtnUbah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUbah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUbah.Location = New System.Drawing.Point(417, 31)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(24, 24)
        Me.BtnUbah.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnUbah.TabIndex = 385
        Me.BtnUbah.TabStop = False
        Me.BtnUbah.Tag = "4"
        Me.Keterangan.SetToolTip(Me.BtnUbah, "Silahkan klik tombol ini untuk mengubah data")
        '
        'BtnHapus
        '
        Me.BtnHapus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnHapus.BackgroundImage = CType(resources.GetObject("BtnHapus.BackgroundImage"), System.Drawing.Image)
        Me.BtnHapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnHapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHapus.Location = New System.Drawing.Point(456, 31)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(24, 24)
        Me.BtnHapus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnHapus.TabIndex = 386
        Me.BtnHapus.TabStop = False
        Me.BtnHapus.Tag = "3"
        Me.Keterangan.SetToolTip(Me.BtnHapus, "Silahkan klik tombol ini untuk menghapus data")
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRefresh.BackgroundImage = CType(resources.GetObject("BtnRefresh.BackgroundImage"), System.Drawing.Image)
        Me.BtnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRefresh.Image = CType(resources.GetObject("BtnRefresh.Image"), System.Drawing.Image)
        Me.BtnRefresh.Location = New System.Drawing.Point(495, 32)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(24, 24)
        Me.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnRefresh.TabIndex = 387
        Me.BtnRefresh.TabStop = False
        Me.BtnRefresh.Tag = "11"
        Me.Keterangan.SetToolTip(Me.BtnRefresh, "Silahkan klik tombol ini untuk refresh menu")
        '
        'BtnCari
        '
        Me.BtnCari.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCari.BackColor = System.Drawing.Color.White
        Me.BtnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCari.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.Location = New System.Drawing.Point(1033, 36)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(19, 19)
        Me.BtnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnCari.TabIndex = 389
        Me.BtnCari.TabStop = False
        Me.BtnCari.Tag = "2"
        Me.Keterangan.SetToolTip(Me.BtnCari, "Silahkan klik tombol ini untuk menacri data")
        '
        'BtnKeluar
        '
        Me.BtnKeluar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnKeluar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.Location = New System.Drawing.Point(1058, 32)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(24, 24)
        Me.BtnKeluar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BtnKeluar.TabIndex = 390
        Me.BtnKeluar.TabStop = False
        Me.BtnKeluar.Tag = "1"
        Me.Keterangan.SetToolTip(Me.BtnKeluar, "Silahkan klik tombol ini untuk keluar dari menu ini ")
        '
        'FrmData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1097, 398)
        Me.Controls.Add(Me.BtnKeluar)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.BtnUbah)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbFilter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPencarian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblData)
        Me.Controls.Add(Me.DgPenjualan)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmData"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Data"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KlikKanan.ResumeLayout(False)
        CType(Me.DgPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnTambah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnUbah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHapus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnCari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnKeluar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPencarian As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Keterangan As System.Windows.Forms.ToolTip
    Friend WithEvents KlikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents UbahToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HapusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintFakturToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PembayaranHutangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnRetur As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CbFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DgPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents BtnTambah As System.Windows.Forms.PictureBox
    Friend WithEvents BtnUbah As System.Windows.Forms.PictureBox
    Friend WithEvents BtnHapus As System.Windows.Forms.PictureBox
    Friend WithEvents BtnRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents BtnCari As System.Windows.Forms.PictureBox
    Friend WithEvents BtnKeluar As System.Windows.Forms.PictureBox
End Class
