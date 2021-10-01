<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanPembelian))
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cetak_nota_bulanan = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cetak_nota_harian = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cetak_nota_mingguan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Min = New System.Windows.Forms.Button()
        Me.Cls = New System.Windows.Forms.Button()
        Me.Max = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cetak_nota = New System.Windows.Forms.Button()
        Me.laporan_per_nota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBox2.Location = New System.Drawing.Point(128, 115)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(254, 33)
        Me.ComboBox2.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(19, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 31)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Tahun"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"01. Januari", "02. Februari", "03. Maret", "04. April", "05. Mei", "06. Juni", "07. Juli", "08. Agustus", "09. September", "10. Oktober", "11. November", "12. Desember"})
        Me.ComboBox1.Location = New System.Drawing.Point(128, 44)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(254, 33)
        Me.ComboBox1.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(19, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bulan"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox2)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.ComboBox1)
        Me.GroupBox4.Controls.Add(Me.cetak_nota_bulanan)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(462, 365)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(398, 252)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Laporan Pembelian Bulanan"
        '
        'cetak_nota_bulanan
        '
        Me.cetak_nota_bulanan.Location = New System.Drawing.Point(19, 189)
        Me.cetak_nota_bulanan.Name = "cetak_nota_bulanan"
        Me.cetak_nota_bulanan.Size = New System.Drawing.Size(363, 34)
        Me.cetak_nota_bulanan.TabIndex = 15
        Me.cetak_nota_bulanan.Text = "Cetak"
        Me.cetak_nota_bulanan.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(254, 31)
        Me.DateTimePicker1.TabIndex = 17
        '
        'cetak_nota_harian
        '
        Me.cetak_nota_harian.Location = New System.Drawing.Point(19, 147)
        Me.cetak_nota_harian.Name = "cetak_nota_harian"
        Me.cetak_nota_harian.Size = New System.Drawing.Size(363, 34)
        Me.cetak_nota_harian.TabIndex = 15
        Me.cetak_nota_harian.Text = "Cetak"
        Me.cetak_nota_harian.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(19, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tanggal"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.cetak_nota_harian)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(462, 89)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 252)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laporan Pembelian Harian"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cetak_nota_mingguan)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 365)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(392, 252)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Laporan Pembelian Mingguan"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(114, 113)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(254, 31)
        Me.DateTimePicker3.TabIndex = 19
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(114, 46)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(254, 31)
        Me.DateTimePicker2.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(19, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Tgl Awal"
        '
        'cetak_nota_mingguan
        '
        Me.cetak_nota_mingguan.Location = New System.Drawing.Point(19, 189)
        Me.cetak_nota_mingguan.Name = "cetak_nota_mingguan"
        Me.cetak_nota_mingguan.Size = New System.Drawing.Size(349, 34)
        Me.cetak_nota_mingguan.TabIndex = 15
        Me.cetak_nota_mingguan.Text = "Cetak"
        Me.cetak_nota_mingguan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tgl Awal"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(10, 631)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 10)
        Me.Panel4.TabIndex = 36
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Min)
        Me.Panel5.Controls.Add(Me.Cls)
        Me.Panel5.Controls.Add(Me.Max)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(756, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(145, 61)
        Me.Panel5.TabIndex = 3
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
        Me.Cls.Location = New System.Drawing.Point(103, 9)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(39, 46)
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(891, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 580)
        Me.Panel3.TabIndex = 35
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 580)
        Me.Panel1.TabIndex = 34
        '
        'cetak_nota
        '
        Me.cetak_nota.Location = New System.Drawing.Point(19, 147)
        Me.cetak_nota.Name = "cetak_nota"
        Me.cetak_nota.Size = New System.Drawing.Size(349, 34)
        Me.cetak_nota.TabIndex = 15
        Me.cetak_nota.Text = "Cetak"
        Me.cetak_nota.UseVisualStyleBackColor = True
        '
        'laporan_per_nota
        '
        Me.laporan_per_nota.Location = New System.Drawing.Point(114, 46)
        Me.laporan_per_nota.Name = "laporan_per_nota"
        Me.laporan_per_nota.Size = New System.Drawing.Size(254, 31)
        Me.laporan_per_nota.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(19, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No.Nota"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cetak_nota)
        Me.GroupBox1.Controls.Add(Me.laporan_per_nota)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 252)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Pembelian Per Nota"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(901, 61)
        Me.Panel2.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(299, 61)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Form Laporan Pembelian"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLaporanPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 641)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporanPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanPembelian"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cetak_nota_bulanan As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cetak_nota_harian As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents cetak_nota_mingguan As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Min As Button
    Friend WithEvents Cls As Button
    Friend WithEvents Max As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cetak_nota As Button
    Friend WithEvents laporan_per_nota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
End Class
