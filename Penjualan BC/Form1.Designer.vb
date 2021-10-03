<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.PnlMenu = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.laporan_data = New System.Windows.Forms.Button()
        Me.laporan_penjualan = New System.Windows.Forms.Button()
        Me.laporan_pembelian = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.penjualan = New System.Windows.Forms.Button()
        Me.pembelian = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.barang = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.admin = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanDataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPenjualanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanPembelianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Wkt = New System.Windows.Forms.Label()
        Me.Tgl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Menu = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Min = New System.Windows.Forms.Button()
        Me.Cls = New System.Windows.Forms.Button()
        Me.Max = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Dashboard = New System.Windows.Forms.Panel()
        Me.Panel6.SuspendLayout()
        Me.PnlMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.LblUsername)
        Me.Panel6.Controls.Add(Me.LblStatus)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(181, 53)
        Me.Panel6.TabIndex = 5
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblUsername.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblUsername.Location = New System.Drawing.Point(11, 15)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(0, 28)
        Me.LblUsername.TabIndex = 3
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStatus.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblStatus.Location = New System.Drawing.Point(127, 22)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(0, 21)
        Me.LblStatus.TabIndex = 4
        '
        'PnlMenu
        '
        Me.PnlMenu.BackColor = System.Drawing.Color.LightGray
        Me.PnlMenu.Controls.Add(Me.GroupBox1)
        Me.PnlMenu.Controls.Add(Me.GroupBox2)
        Me.PnlMenu.Controls.Add(Me.GroupBox5)
        Me.PnlMenu.Controls.Add(Me.GroupBox3)
        Me.PnlMenu.Controls.Add(Me.GroupBox4)
        Me.PnlMenu.Location = New System.Drawing.Point(0, 95)
        Me.PnlMenu.Name = "PnlMenu"
        Me.PnlMenu.Size = New System.Drawing.Size(1026, 149)
        Me.PnlMenu.TabIndex = 7
        Me.PnlMenu.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.logout)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(687, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(84, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Keluar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Logout"
        '
        'logout
        '
        Me.logout.FlatAppearance.BorderSize = 0
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.Image = CType(resources.GetObject("logout.Image"), System.Drawing.Image)
        Me.logout.Location = New System.Drawing.Point(11, 30)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(64, 63)
        Me.logout.TabIndex = 6
        Me.logout.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.laporan_data)
        Me.GroupBox2.Controls.Add(Me.laporan_penjualan)
        Me.GroupBox2.Controls.Add(Me.laporan_pembelian)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(358, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 149)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(119, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 58)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Laporan Penjualan"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'laporan_data
        '
        Me.laporan_data.FlatAppearance.BorderSize = 0
        Me.laporan_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.laporan_data.Image = CType(resources.GetObject("laporan_data.Image"), System.Drawing.Image)
        Me.laporan_data.Location = New System.Drawing.Point(23, 30)
        Me.laporan_data.Name = "laporan_data"
        Me.laporan_data.Size = New System.Drawing.Size(64, 63)
        Me.laporan_data.TabIndex = 7
        Me.laporan_data.UseVisualStyleBackColor = True
        '
        'laporan_penjualan
        '
        Me.laporan_penjualan.FlatAppearance.BorderSize = 0
        Me.laporan_penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.laporan_penjualan.Image = CType(resources.GetObject("laporan_penjualan.Image"), System.Drawing.Image)
        Me.laporan_penjualan.Location = New System.Drawing.Point(133, 30)
        Me.laporan_penjualan.Name = "laporan_penjualan"
        Me.laporan_penjualan.Size = New System.Drawing.Size(64, 63)
        Me.laporan_penjualan.TabIndex = 8
        Me.laporan_penjualan.UseVisualStyleBackColor = True
        '
        'laporan_pembelian
        '
        Me.laporan_pembelian.FlatAppearance.BorderSize = 0
        Me.laporan_pembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.laporan_pembelian.Image = CType(resources.GetObject("laporan_pembelian.Image"), System.Drawing.Image)
        Me.laporan_pembelian.Location = New System.Drawing.Point(234, 22)
        Me.laporan_pembelian.Name = "laporan_pembelian"
        Me.laporan_pembelian.Size = New System.Drawing.Size(64, 63)
        Me.laporan_pembelian.TabIndex = 10
        Me.laporan_pembelian.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(219, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 58)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Laporan Pembelian"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(0, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 58)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Laporan Data Master"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.penjualan)
        Me.GroupBox5.Controls.Add(Me.pembelian)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(165, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(193, 149)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Penjualan"
        '
        'penjualan
        '
        Me.penjualan.FlatAppearance.BorderSize = 0
        Me.penjualan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.penjualan.Image = CType(resources.GetObject("penjualan.Image"), System.Drawing.Image)
        Me.penjualan.Location = New System.Drawing.Point(14, 30)
        Me.penjualan.Name = "penjualan"
        Me.penjualan.Size = New System.Drawing.Size(64, 63)
        Me.penjualan.TabIndex = 6
        Me.penjualan.UseVisualStyleBackColor = True
        '
        'pembelian
        '
        Me.pembelian.FlatAppearance.BorderSize = 0
        Me.pembelian.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.pembelian.Image = CType(resources.GetObject("pembelian.Image"), System.Drawing.Image)
        Me.pembelian.Location = New System.Drawing.Point(111, 30)
        Me.pembelian.Name = "pembelian"
        Me.pembelian.Size = New System.Drawing.Size(64, 63)
        Me.pembelian.TabIndex = 7
        Me.pembelian.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Pembelian"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.barang)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(90, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(75, 149)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Barang"
        '
        'barang
        '
        Me.barang.FlatAppearance.BorderSize = 0
        Me.barang.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.barang.Image = CType(resources.GetObject("barang.Image"), System.Drawing.Image)
        Me.barang.Location = New System.Drawing.Point(6, 30)
        Me.barang.Name = "barang"
        Me.barang.Size = New System.Drawing.Size(64, 63)
        Me.barang.TabIndex = 2
        Me.barang.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.admin)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(90, 149)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Admin"
        '
        'admin
        '
        Me.admin.FlatAppearance.BorderSize = 0
        Me.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.admin.Image = CType(resources.GetObject("admin.Image"), System.Drawing.Image)
        Me.admin.Location = New System.Drawing.Point(12, 30)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(64, 63)
        Me.admin.TabIndex = 0
        Me.admin.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 62)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1026, 33)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MaterToolStripMenuItem
        '
        Me.MaterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.BarangToolStripMenuItem})
        Me.MaterToolStripMenuItem.Name = "MaterToolStripMenuItem"
        Me.MaterToolStripMenuItem.Size = New System.Drawing.Size(82, 29)
        Me.MaterToolStripMenuItem.Text = "Master"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'BarangToolStripMenuItem
        '
        Me.BarangToolStripMenuItem.Name = "BarangToolStripMenuItem"
        Me.BarangToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.BarangToolStripMenuItem.Text = "Barang"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PenjualanToolStripMenuItem, Me.PembelianToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'PenjualanToolStripMenuItem
        '
        Me.PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        Me.PenjualanToolStripMenuItem.Size = New System.Drawing.Size(195, 34)
        Me.PenjualanToolStripMenuItem.Text = "Penjualan"
        '
        'PembelianToolStripMenuItem
        '
        Me.PembelianToolStripMenuItem.Name = "PembelianToolStripMenuItem"
        Me.PembelianToolStripMenuItem.Size = New System.Drawing.Size(195, 34)
        Me.PembelianToolStripMenuItem.Text = "Pembelian"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanDataMasterToolStripMenuItem, Me.LaporanPenjualanToolStripMenuItem, Me.LaporanPembelianToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanDataMasterToolStripMenuItem
        '
        Me.LaporanDataMasterToolStripMenuItem.Name = "LaporanDataMasterToolStripMenuItem"
        Me.LaporanDataMasterToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.LaporanDataMasterToolStripMenuItem.Text = "Laporan Data Master"
        '
        'LaporanPenjualanToolStripMenuItem
        '
        Me.LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        Me.LaporanPenjualanToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        '
        'LaporanPembelianToolStripMenuItem
        '
        Me.LaporanPembelianToolStripMenuItem.Name = "LaporanPembelianToolStripMenuItem"
        Me.LaporanPembelianToolStripMenuItem.Size = New System.Drawing.Size(279, 34)
        Me.LaporanPembelianToolStripMenuItem.Text = "Laporan Pembelian"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Wkt)
        Me.Panel3.Controls.Add(Me.Tgl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(769, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(257, 53)
        Me.Panel3.TabIndex = 0
        '
        'Wkt
        '
        Me.Wkt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Wkt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Wkt.Location = New System.Drawing.Point(169, 8)
        Me.Wkt.Name = "Wkt"
        Me.Wkt.Size = New System.Drawing.Size(78, 35)
        Me.Wkt.TabIndex = 19
        Me.Wkt.Text = "Waktu"
        '
        'Tgl
        '
        Me.Tgl.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Tgl.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Tgl.Location = New System.Drawing.Point(19, 8)
        Me.Tgl.Name = "Tgl"
        Me.Tgl.Size = New System.Drawing.Size(142, 35)
        Me.Tgl.TabIndex = 1
        Me.Tgl.Text = "Tanggal"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 735)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 53)
        Me.Panel1.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Menu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(70, 62)
        Me.Panel4.TabIndex = 5
        '
        'Menu
        '
        Me.Menu.FlatAppearance.BorderSize = 0
        Me.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Menu.Image = Global.Penjualan_BC.My.Resources.Resources.menu
        Me.Menu.Location = New System.Drawing.Point(11, 13)
        Me.Menu.Name = "Menu"
        Me.Menu.Size = New System.Drawing.Size(43, 32)
        Me.Menu.TabIndex = 0
        Me.Menu.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Min
        '
        Me.Min.FlatAppearance.BorderSize = 0
        Me.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min.Image = CType(resources.GetObject("Min.Image"), System.Drawing.Image)
        Me.Min.Location = New System.Drawing.Point(9, 10)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(41, 45)
        Me.Min.TabIndex = 2
        Me.Min.UseVisualStyleBackColor = True
        '
        'Cls
        '
        Me.Cls.FlatAppearance.BorderSize = 0
        Me.Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cls.Image = Global.Penjualan_BC.My.Resources.Resources.close
        Me.Cls.Location = New System.Drawing.Point(103, 8)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(39, 47)
        Me.Cls.TabIndex = 0
        Me.Cls.UseVisualStyleBackColor = True
        '
        'Max
        '
        Me.Max.FlatAppearance.BorderSize = 0
        Me.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Max.Image = CType(resources.GetObject("Max.Image"), System.Drawing.Image)
        Me.Max.Location = New System.Drawing.Point(56, 10)
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(41, 45)
        Me.Max.TabIndex = 1
        Me.Max.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Min)
        Me.Panel5.Controls.Add(Me.Cls)
        Me.Panel5.Controls.Add(Me.Max)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(880, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(146, 62)
        Me.Panel5.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1026, 62)
        Me.Panel2.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label9.Location = New System.Drawing.Point(70, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(299, 62)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Menu Utama"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        '
        'Dashboard
        '
        Me.Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dashboard.Location = New System.Drawing.Point(0, 62)
        Me.Dashboard.Name = "Dashboard"
        Me.Dashboard.Size = New System.Drawing.Size(1026, 673)
        Me.Dashboard.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 788)
        Me.Controls.Add(Me.PnlMenu)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Dashboard)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuUtama"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.PnlMenu.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents LblUsername As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents PnlMenu As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Wkt As Label
    Friend WithEvents Tgl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Menu As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Min As Button
    Friend WithEvents Cls As Button
    Friend WithEvents Max As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Dashboard As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MaterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanDataMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents penjualan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents barang As Button
    Friend WithEvents admin As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents laporan_penjualan As Button
    Friend WithEvents laporan_data As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents logout As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents laporan_pembelian As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents pembelian As Button
    Friend WithEvents PembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPembelianToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox5 As GroupBox
End Class
