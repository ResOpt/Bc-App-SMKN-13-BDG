<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporanDataMaster
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLaporanDataMaster))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.button_user = New System.Windows.Forms.Button()
        Me.button_barang = New System.Windows.Forms.Button()
        Me.button_admin = New System.Windows.Forms.Button()
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
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.button_user)
        Me.GroupBox1.Controls.Add(Me.button_barang)
        Me.GroupBox1.Controls.Add(Me.button_admin)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 155)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Laporan Data Master"
        '
        'button_user
        '
        Me.button_user.Location = New System.Drawing.Point(212, 59)
        Me.button_user.Name = "button_user"
        Me.button_user.Size = New System.Drawing.Size(168, 59)
        Me.button_user.TabIndex = 17
        Me.button_user.Text = "User"
        Me.button_user.UseVisualStyleBackColor = True
        '
        'button_barang
        '
        Me.button_barang.Location = New System.Drawing.Point(396, 59)
        Me.button_barang.Name = "button_barang"
        Me.button_barang.Size = New System.Drawing.Size(142, 59)
        Me.button_barang.TabIndex = 16
        Me.button_barang.Text = "Barang"
        Me.button_barang.UseVisualStyleBackColor = True
        '
        'button_admin
        '
        Me.button_admin.Location = New System.Drawing.Point(27, 59)
        Me.button_admin.Name = "button_admin"
        Me.button_admin.Size = New System.Drawing.Size(168, 59)
        Me.button_admin.TabIndex = 15
        Me.button_admin.Text = "Admin"
        Me.button_admin.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(632, 61)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 206)
        Me.Panel3.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 206)
        Me.Panel1.TabIndex = 26
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
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Min)
        Me.Panel5.Controls.Add(Me.Cls)
        Me.Panel5.Controls.Add(Me.Max)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(497, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(145, 61)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 267)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(642, 10)
        Me.Panel4.TabIndex = 28
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(642, 61)
        Me.Panel2.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 61)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Form Laporan Data Master"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLaporanDataMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 277)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLaporanDataMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanDataMaster"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents button_barang As Button
    Friend WithEvents button_admin As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Min As Button
    Friend WithEvents Cls As Button
    Friend WithEvents Max As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents button_user As Button
    Friend WithEvents Label6 As Label
End Class
