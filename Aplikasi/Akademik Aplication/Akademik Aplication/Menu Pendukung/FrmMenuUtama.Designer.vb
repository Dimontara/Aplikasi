<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnBackgroud = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnUbah = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAsli = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TugasAkhirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenilaianTugasAkhirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnlaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanReguKerjaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MahasiswaPerTahunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TugasAkhirPerTahunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.LblID = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Lbluser = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Lblakses = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblNameComputer = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblOs = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblTanggal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblTime = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.LblCopyright = New System.Windows.Forms.ToolStripLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ClikKanan = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btmubah = New System.Windows.Forms.ToolStripMenuItem()
        Me.btmasli = New System.Windows.Forms.ToolStripMenuItem()
        Me.btmlogouet = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.picdekstop = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.ClikKanan.SuspendLayout()
        CType(Me.picdekstop, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Snow
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem36, Me.ToolStripMenuItem41, Me.ToolStripMenuItem45, Me.Btnlaporan})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(867, 24)
        Me.MenuStrip1.TabIndex = 34
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnBackgroud, Me.BtnLogout, Me.BtnExit})
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem36.Text = "&File"
        '
        'BtnBackgroud
        '
        Me.BtnBackgroud.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnUbah, Me.BtnAsli})
        Me.BtnBackgroud.Image = CType(resources.GetObject("BtnBackgroud.Image"), System.Drawing.Image)
        Me.BtnBackgroud.Name = "BtnBackgroud"
        Me.BtnBackgroud.Size = New System.Drawing.Size(152, 22)
        Me.BtnBackgroud.Text = "Background"
        '
        'BtnUbah
        '
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(115, 22)
        Me.BtnUbah.Text = "&Replace"
        '
        'BtnAsli
        '
        Me.BtnAsli.Name = "BtnAsli"
        Me.BtnAsli.Size = New System.Drawing.Size(115, 22)
        Me.BtnAsli.Text = "&Default"
        '
        'BtnLogout
        '
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.BtnLogout.Size = New System.Drawing.Size(152, 22)
        Me.BtnLogout.Text = "Logout"
        '
        'BtnExit
        '
        Me.BtnExit.Image = CType(resources.GetObject("BtnExit.Image"), System.Drawing.Image)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.ShortcutKeyDisplayString = ""
        Me.BtnExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.BtnExit.Size = New System.Drawing.Size(152, 22)
        Me.BtnExit.Tag = "8"
        Me.BtnExit.Text = "&Exit"
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperatorToolStripMenuItem, Me.ProdiToolStripMenuItem, Me.DosenToolStripMenuItem1, Me.MahasiswaToolStripMenuItem})
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(82, 20)
        Me.ToolStripMenuItem41.Text = "&Master Data"
        '
        'OperatorToolStripMenuItem
        '
        Me.OperatorToolStripMenuItem.Name = "OperatorToolStripMenuItem"
        Me.OperatorToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OperatorToolStripMenuItem.Text = "Operator"
        '
        'ProdiToolStripMenuItem
        '
        Me.ProdiToolStripMenuItem.Name = "ProdiToolStripMenuItem"
        Me.ProdiToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ProdiToolStripMenuItem.Text = "Program Studi"
        '
        'DosenToolStripMenuItem1
        '
        Me.DosenToolStripMenuItem1.Name = "DosenToolStripMenuItem1"
        Me.DosenToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.DosenToolStripMenuItem1.Text = "Dosen"
        '
        'MahasiswaToolStripMenuItem
        '
        Me.MahasiswaToolStripMenuItem.Name = "MahasiswaToolStripMenuItem"
        Me.MahasiswaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.MahasiswaToolStripMenuItem.Text = "Mahasiswa"
        '
        'ToolStripMenuItem45
        '
        Me.ToolStripMenuItem45.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TugasAkhirToolStripMenuItem, Me.PenilaianTugasAkhirToolStripMenuItem})
        Me.ToolStripMenuItem45.Name = "ToolStripMenuItem45"
        Me.ToolStripMenuItem45.Size = New System.Drawing.Size(67, 20)
        Me.ToolStripMenuItem45.Text = "&Transaksi"
        '
        'TugasAkhirToolStripMenuItem
        '
        Me.TugasAkhirToolStripMenuItem.Name = "TugasAkhirToolStripMenuItem"
        Me.TugasAkhirToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.TugasAkhirToolStripMenuItem.Text = "Tugas Akhir"
        '
        'PenilaianTugasAkhirToolStripMenuItem
        '
        Me.PenilaianTugasAkhirToolStripMenuItem.Name = "PenilaianTugasAkhirToolStripMenuItem"
        Me.PenilaianTugasAkhirToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PenilaianTugasAkhirToolStripMenuItem.Text = "Penilaian Tugas Akhir"
        '
        'Btnlaporan
        '
        Me.Btnlaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanReguKerjaToolStripMenuItem, Me.MahasiswaPerTahunToolStripMenuItem, Me.TugasAkhirPerTahunToolStripMenuItem})
        Me.Btnlaporan.Name = "Btnlaporan"
        Me.Btnlaporan.Size = New System.Drawing.Size(62, 20)
        Me.Btnlaporan.Text = "&Laporan"
        '
        'LaporanReguKerjaToolStripMenuItem
        '
        Me.LaporanReguKerjaToolStripMenuItem.Name = "LaporanReguKerjaToolStripMenuItem"
        Me.LaporanReguKerjaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LaporanReguKerjaToolStripMenuItem.Text = "Dosen (All)"
        '
        'MahasiswaPerTahunToolStripMenuItem
        '
        Me.MahasiswaPerTahunToolStripMenuItem.Name = "MahasiswaPerTahunToolStripMenuItem"
        Me.MahasiswaPerTahunToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MahasiswaPerTahunToolStripMenuItem.Text = "Mahasiswa Per Tahun"
        '
        'TugasAkhirPerTahunToolStripMenuItem
        '
        Me.TugasAkhirPerTahunToolStripMenuItem.Name = "TugasAkhirPerTahunToolStripMenuItem"
        Me.TugasAkhirPerTahunToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.TugasAkhirPerTahunToolStripMenuItem.Text = "Tugas Akhir per Tahun"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Snow
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel9, Me.LblID, Me.ToolStripButton1, Me.ToolStripSeparator7, Me.ToolStripLabel1, Me.Lbluser, Me.ToolStripSeparator12, Me.ToolStripLabel2, Me.Lblakses, Me.ToolStripSeparator1, Me.LblNameComputer, Me.ToolStripSeparator4, Me.LblOs, Me.ToolStripSeparator3, Me.LblTanggal, Me.ToolStripSeparator5, Me.LblTime, Me.ToolStripSeparator6, Me.LblCopyright})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 450)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(867, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(50, 22)
        Me.ToolStripLabel9.Text = "User ID :"
        '
        'LblID
        '
        Me.LblID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblID.ForeColor = System.Drawing.Color.Green
        Me.LblID.Name = "LblID"
        Me.LblID.Size = New System.Drawing.Size(48, 22)
        Me.LblID.Text = "IU0000"
        Me.LblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblID.ToolTipText = "Change user"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Change user"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(39, 22)
        Me.ToolStripLabel1.Text = "User : "
        '
        'Lbluser
        '
        Me.Lbluser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Lbluser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbluser.ForeColor = System.Drawing.Color.Green
        Me.Lbluser.Name = "Lbluser"
        Me.Lbluser.Size = New System.Drawing.Size(43, 22)
        Me.Lbluser.Text = "Admin"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(67, 22)
        Me.ToolStripLabel2.Text = "User Right :"
        '
        'Lblakses
        '
        Me.Lblakses.BackColor = System.Drawing.SystemColors.Control
        Me.Lblakses.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Lblakses.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblakses.ForeColor = System.Drawing.Color.Green
        Me.Lblakses.Name = "Lblakses"
        Me.Lblakses.Size = New System.Drawing.Size(43, 22)
        Me.Lblakses.Text = "Admin"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'LblNameComputer
        '
        Me.LblNameComputer.Name = "LblNameComputer"
        Me.LblNameComputer.Size = New System.Drawing.Size(146, 22)
        Me.LblNameComputer.Text = "Name Computer : Asus pc"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'LblOs
        '
        Me.LblOs.Name = "LblOs"
        Me.LblOs.Size = New System.Drawing.Size(89, 22)
        Me.LblOs.Text = "OS : Windows 8"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'LblTanggal
        '
        Me.LblTanggal.Name = "LblTanggal"
        Me.LblTanggal.Size = New System.Drawing.Size(143, 22)
        Me.LblTanggal.Text = "Date : Sabtu 12 April 2013 "
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'LblTime
        '
        Me.LblTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Green
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(130, 17)
        Me.LblTime.Text = "Time : 12:20:30 Wib"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'LblCopyright
        '
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(236, 15)
        Me.LblCopyright.Text = "Copyright ©  2015 by Softmed Consultindo"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 250
        '
        'ClikKanan
        '
        Me.ClikKanan.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ToolStripMenuItem3, Me.btmlogouet, Me.ToolStripMenuItem4})
        Me.ClikKanan.Name = "ClikKanan"
        Me.ClikKanan.Size = New System.Drawing.Size(153, 92)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Image = CType(resources.GetObject("RefreshToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btmubah, Me.btmasli})
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem3.Text = "Background"
        '
        'Btmubah
        '
        Me.Btmubah.Name = "Btmubah"
        Me.Btmubah.Size = New System.Drawing.Size(115, 22)
        Me.Btmubah.Text = "&Replace"
        '
        'btmasli
        '
        Me.btmasli.Name = "btmasli"
        Me.btmasli.Size = New System.Drawing.Size(115, 22)
        Me.btmasli.Text = "&Default"
        '
        'btmlogouet
        '
        Me.btmlogouet.Image = CType(resources.GetObject("btmlogouet.Image"), System.Drawing.Image)
        Me.btmlogouet.Name = "btmlogouet"
        Me.btmlogouet.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.btmlogouet.Size = New System.Drawing.Size(152, 22)
        Me.btmlogouet.Text = "Logout"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeyDisplayString = ""
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F14), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(152, 22)
        Me.ToolStripMenuItem4.Tag = "8"
        Me.ToolStripMenuItem4.Text = "&Exit"
        '
        'picdekstop
        '
        Me.picdekstop.BackColor = System.Drawing.Color.White
        Me.picdekstop.ContextMenuStrip = Me.ClikKanan
        Me.picdekstop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picdekstop.Image = CType(resources.GetObject("picdekstop.Image"), System.Drawing.Image)
        Me.picdekstop.Location = New System.Drawing.Point(0, 24)
        Me.picdekstop.Name = "picdekstop"
        Me.picdekstop.Size = New System.Drawing.Size(867, 426)
        Me.picdekstop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picdekstop.TabIndex = 42
        Me.picdekstop.TabStop = False
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(867, 475)
        Me.Controls.Add(Me.picdekstop)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Politeknik Negeri Medan "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ClikKanan.ResumeLayout(False)
        CType(Me.picdekstop, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem36 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnBackgroud As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnUbah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnAsli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem41 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem45 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btnlaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblID As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Lbluser As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Lblakses As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblNameComputer As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblTanggal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblCopyright As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents OperatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProdiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DosenToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TugasAkhirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanReguKerjaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenilaianTugasAkhirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClikKanan As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Btmubah As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btmasli As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btmlogouet As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LblOs As System.Windows.Forms.ToolStripLabel
    Friend WithEvents picdekstop As System.Windows.Forms.PictureBox
    Friend WithEvents MahasiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MahasiswaPerTahunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TugasAkhirPerTahunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
