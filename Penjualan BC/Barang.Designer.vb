<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.harga_jual = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.stok = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.button_tutup = New System.Windows.Forms.Button()
        Me.button_hapus = New System.Windows.Forms.Button()
        Me.button_edit = New System.Windows.Forms.Button()
        Me.button_input = New System.Windows.Forms.Button()
        Me.nama_barang = New System.Windows.Forms.TextBox()
        Me.harga_beli = New System.Windows.Forms.TextBox()
        Me.kode_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Min = New System.Windows.Forms.Button()
        Me.Cls = New System.Windows.Forms.Button()
        Me.Max = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.harga_jual)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.stok)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.button_tutup)
        Me.GroupBox1.Controls.Add(Me.button_hapus)
        Me.GroupBox1.Controls.Add(Me.button_edit)
        Me.GroupBox1.Controls.Add(Me.button_input)
        Me.GroupBox1.Controls.Add(Me.nama_barang)
        Me.GroupBox1.Controls.Add(Me.harga_beli)
        Me.GroupBox1.Controls.Add(Me.kode_barang)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(412, 383)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Barang"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(165, 355)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 20)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Tampilkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'harga_jual
        '
        Me.harga_jual.Location = New System.Drawing.Point(127, 94)
        Me.harga_jual.Margin = New System.Windows.Forms.Padding(2)
        Me.harga_jual.Name = "harga_jual"
        Me.harga_jual.Size = New System.Drawing.Size(275, 23)
        Me.harga_jual.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(13, 94)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Harga Jual"
        '
        'stok
        '
        Me.stok.Location = New System.Drawing.Point(127, 116)
        Me.stok.Margin = New System.Windows.Forms.Padding(2)
        Me.stok.Name = "stok"
        Me.stok.Size = New System.Drawing.Size(152, 23)
        Me.stok.TabIndex = 21
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 179)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 33
        Me.DataGridView2.Size = New System.Drawing.Size(390, 172)
        Me.DataGridView2.TabIndex = 20
        '
        'button_tutup
        '
        Me.button_tutup.Location = New System.Drawing.Point(293, 145)
        Me.button_tutup.Margin = New System.Windows.Forms.Padding(2)
        Me.button_tutup.Name = "button_tutup"
        Me.button_tutup.Size = New System.Drawing.Size(78, 20)
        Me.button_tutup.TabIndex = 18
        Me.button_tutup.Text = "Tutup"
        Me.button_tutup.UseVisualStyleBackColor = True
        '
        'button_hapus
        '
        Me.button_hapus.Location = New System.Drawing.Point(200, 145)
        Me.button_hapus.Margin = New System.Windows.Forms.Padding(2)
        Me.button_hapus.Name = "button_hapus"
        Me.button_hapus.Size = New System.Drawing.Size(78, 20)
        Me.button_hapus.TabIndex = 17
        Me.button_hapus.Text = "Hapus"
        Me.button_hapus.UseVisualStyleBackColor = True
        '
        'button_edit
        '
        Me.button_edit.Location = New System.Drawing.Point(106, 145)
        Me.button_edit.Margin = New System.Windows.Forms.Padding(2)
        Me.button_edit.Name = "button_edit"
        Me.button_edit.Size = New System.Drawing.Size(78, 20)
        Me.button_edit.TabIndex = 16
        Me.button_edit.Text = "Edit"
        Me.button_edit.UseVisualStyleBackColor = True
        '
        'button_input
        '
        Me.button_input.Location = New System.Drawing.Point(13, 145)
        Me.button_input.Margin = New System.Windows.Forms.Padding(2)
        Me.button_input.Name = "button_input"
        Me.button_input.Size = New System.Drawing.Size(78, 20)
        Me.button_input.TabIndex = 15
        Me.button_input.Text = "Input"
        Me.button_input.UseVisualStyleBackColor = True
        '
        'nama_barang
        '
        Me.nama_barang.Location = New System.Drawing.Point(127, 50)
        Me.nama_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.nama_barang.Name = "nama_barang"
        Me.nama_barang.Size = New System.Drawing.Size(275, 23)
        Me.nama_barang.TabIndex = 13
        '
        'harga_beli
        '
        Me.harga_beli.Location = New System.Drawing.Point(127, 72)
        Me.harga_beli.Margin = New System.Windows.Forms.Padding(2)
        Me.harga_beli.Name = "harga_beli"
        Me.harga_beli.Size = New System.Drawing.Size(275, 23)
        Me.harga_beli.TabIndex = 11
        '
        'kode_barang
        '
        Me.kode_barang.Location = New System.Drawing.Point(127, 28)
        Me.kode_barang.Margin = New System.Windows.Forms.Padding(2)
        Me.kode_barang.Name = "kode_barang"
        Me.kode_barang.Size = New System.Drawing.Size(152, 23)
        Me.kode_barang.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(13, 116)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(13, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga Beli"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(13, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(13, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Kode Barang"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(452, 37)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 402)
        Me.Panel3.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 37)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 402)
        Me.Panel1.TabIndex = 26
        '
        'Min
        '
        Me.Min.FlatAppearance.BorderSize = 0
        Me.Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Min.Image = CType(resources.GetObject("Min.Image"), System.Drawing.Image)
        Me.Min.Location = New System.Drawing.Point(6, 6)
        Me.Min.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Cls.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Max.Margin = New System.Windows.Forms.Padding(2)
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
        Me.Panel5.Location = New System.Drawing.Point(357, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(102, 37)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 439)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(459, 6)
        Me.Panel4.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(459, 37)
        Me.Panel2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 37)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Form Barang"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 445)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents button_tutup As Button
    Friend WithEvents button_hapus As Button
    Friend WithEvents button_edit As Button
    Friend WithEvents button_input As Button
    Friend WithEvents nama_barang As TextBox
    Friend WithEvents harga_beli As TextBox
    Friend WithEvents kode_barang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Min As Button
    Friend WithEvents Cls As Button
    Friend WithEvents Max As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents stok As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents harga_jual As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
