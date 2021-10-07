<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPembelian))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.bayar = New System.Windows.Forms.TextBox()
        Me.kembalian = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Min = New System.Windows.Forms.Button()
        Me.Cls = New System.Windows.Forms.Button()
        Me.Max = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.kode_barang = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.no_nota_beli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.button_hapus = New System.Windows.Forms.Button()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.button_input = New System.Windows.Forms.Button()
        Me.total_beli = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.button_batal = New System.Windows.Forms.Button()
        Me.button_simpan = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(731, 37)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 355)
        Me.Panel3.TabIndex = 32
        '
        'bayar
        '
        Me.bayar.Location = New System.Drawing.Point(560, 26)
        Me.bayar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bayar.Name = "bayar"
        Me.bayar.Size = New System.Drawing.Size(126, 23)
        Me.bayar.TabIndex = 29
        '
        'kembalian
        '
        Me.kembalian.Location = New System.Drawing.Point(560, 50)
        Me.kembalian.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kembalian.Name = "kembalian"
        Me.kembalian.Size = New System.Drawing.Size(126, 23)
        Me.kembalian.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(476, 51)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 19)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Kembalian"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(476, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 19)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Bayar"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Min
        '
        Me.Min.FlatAppearance.BorderSize = 0
        Me.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min.Image = CType(resources.GetObject("Min.Image"), System.Drawing.Image)
        Me.Min.Location = New System.Drawing.Point(6, 6)
        Me.Min.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(29, 27)
        Me.Min.TabIndex = 2
        Me.Min.UseVisualStyleBackColor = True
        '
        'Cls
        '
        Me.Cls.FlatAppearance.BorderSize = 0
        Me.Cls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cls.Image = Global.Penjualan_BC.My.Resources.Resources.close
        Me.Cls.Location = New System.Drawing.Point(72, 5)
        Me.Cls.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(27, 28)
        Me.Cls.TabIndex = 0
        Me.Cls.UseVisualStyleBackColor = True
        '
        'Max
        '
        Me.Max.FlatAppearance.BorderSize = 0
        Me.Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Max.Image = CType(resources.GetObject("Max.Image"), System.Drawing.Image)
        Me.Max.Location = New System.Drawing.Point(39, 6)
        Me.Max.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Max.Name = "Max"
        Me.Max.Size = New System.Drawing.Size(29, 27)
        Me.Max.TabIndex = 1
        Me.Max.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Min)
        Me.Panel5.Controls.Add(Me.Cls)
        Me.Panel5.Controls.Add(Me.Max)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(636, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(102, 37)
        Me.Panel5.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(10, 82)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(672, 168)
        Me.DataGridView2.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 355)
        Me.Panel1.TabIndex = 31
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(738, 37)
        Me.Panel2.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label12.Location = New System.Drawing.Point(0, 0)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 37)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Form Pembelian"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'kode_barang
        '
        Me.kode_barang.Location = New System.Drawing.Point(114, 50)
        Me.kode_barang.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(124, 23)
        Me.kode_barang.TabIndex = 13
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(338, 26)
        Me.jumlah.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(122, 23)
        Me.jumlah.TabIndex = 11
        '
        'no_nota_beli
        '
        Me.no_nota_beli.Location = New System.Drawing.Point(114, 28)
        Me.no_nota_beli.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.no_nota_beli.Name = "no_nota_beli"
        Me.no_nota_beli.Size = New System.Drawing.Size(124, 23)
        Me.no_nota_beli.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Kode Barang"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "No. Nota Beli"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 392)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(738, 6)
        Me.Panel4.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(253, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Jumlah"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.button_hapus)
        Me.GroupBox1.Controls.Add(Me.button_edit)
        Me.GroupBox1.Controls.Add(Me.button_input)
        Me.GroupBox1.Controls.Add(Me.total_beli)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.button_batal)
        Me.GroupBox1.Controls.Add(Me.button_simpan)
        Me.GroupBox1.Controls.Add(Me.bayar)
        Me.GroupBox1.Controls.Add(Me.kembalian)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.kode_barang)
        Me.GroupBox1.Controls.Add(Me.jumlah)
        Me.GroupBox1.Controls.Add(Me.no_nota_beli)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(695, 331)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pembelian"
        '
        'button_hapus
        '
        Me.button_hapus.Location = New System.Drawing.Point(199, 262)
        Me.button_hapus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_hapus.Name = "button_hapus"
        Me.button_hapus.Size = New System.Drawing.Size(77, 22)
        Me.button_hapus.TabIndex = 43
        Me.button_hapus.Text = "Hapus"
        Me.button_hapus.UseVisualStyleBackColor = True
        '
        'button_edit
        '
        Me.button_edit.Location = New System.Drawing.Point(104, 262)
        Me.button_edit.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(77, 22)
        Me.button_edit.TabIndex = 42
        Me.button_edit.Text = "Edit"
        Me.button_edit.UseVisualStyleBackColor = True
        '
        'button_input
        '
        Me.button_input.Location = New System.Drawing.Point(15, 262)
        Me.button_input.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_input.Name = "button_input"
        Me.button_input.Size = New System.Drawing.Size(77, 22)
        Me.button_input.TabIndex = 41
        Me.button_input.Text = "Input"
        Me.button_input.UseVisualStyleBackColor = True
        '
        'total_beli
        '
        Me.total_beli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.total_beli.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.total_beli.Location = New System.Drawing.Point(420, 262)
        Me.total_beli.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.total_beli.Name = "total_beli"
        Me.total_beli.Size = New System.Drawing.Size(265, 56)
        Me.total_beli.TabIndex = 40
        Me.total_beli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(298, 262)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 56)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Total :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_batal
        '
        Me.button_batal.Location = New System.Drawing.Point(160, 297)
        Me.button_batal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_batal.Name = "button_batal"
        Me.button_batal.Size = New System.Drawing.Size(116, 21)
        Me.button_batal.TabIndex = 38
        Me.button_batal.Text = "Batal"
        Me.button_batal.UseVisualStyleBackColor = True
        '
        'button_simpan
        '
        Me.button_simpan.Location = New System.Drawing.Point(15, 297)
        Me.button_simpan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.button_simpan.Name = "button_simpan"
        Me.button_simpan.Size = New System.Drawing.Size(117, 21)
        Me.button_simpan.TabIndex = 37
        Me.button_simpan.Text = "Simpan"
        Me.button_simpan.UseVisualStyleBackColor = True
        '
        'FormPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 398)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        Me.Panel5.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents bayar As TextBox
    Friend WithEvents kembalian As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Min As Button
    Friend WithEvents Cls As Button
    Friend WithEvents Max As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents kode_barang As TextBox
    Friend WithEvents jumlah As TextBox
    Friend WithEvents no_nota_beli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents button_hapus As Button
    Friend WithEvents button_edit As Button
    Friend WithEvents button_input As Button
    Friend WithEvents total_beli As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents button_batal As Button
    Friend WithEvents button_simpan As Button
    Friend WithEvents Label12 As Label
End Class
