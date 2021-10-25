Public Class Form1
    Dim panelMenu As String = "open"
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean
    Dim conn = New PenggunaDB
    Private FormSekarang As Form
    Private Sub Panel2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel2.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Maximized
    End Sub
    Private Sub Max_Click(sender As Object, e As EventArgs) Handles Max.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles Cls.Click
        LoadingScreen.Close()
        Me.Close()
    End Sub
    Private Sub Min_Click(sender As Object, e As EventArgs) Handles Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Tgl.Text = Format(Now, "dd MMM yyy")
        Wkt.Text = Format(Now, "H:mm")
    End Sub
    Private Sub Menu_Click(sender As Object, e As EventArgs) Handles Menu.Click
        If PnlMenu.Visible = False Then
            PnlMenu.Height = 0
            PnlMenu.Visible = True
        Else
            PnlMenu.Visible = True
        End If
        Timer2.Start()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If panelMenu = "open" Then
            PnlMenu.Height += 50
            If PnlMenu.Height >= 150 Then
                Timer2.Stop()
                panelMenu = "close"
            End If
        Else
            PnlMenu.Height -= 50
            If PnlMenu.Height <= 0 Then
                Timer2.Stop()
                panelMenu = "open"
            End If
        End If
    End Sub

    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
        FormAdmin.ShowDialog()
    End Sub
    Private Sub Admin_Click(sender As Object, e As EventArgs) Handles admin.Click
        FormAdmin.ShowDialog()
    End Sub

    Private Sub Barang_Click(sender As Object, e As EventArgs) Handles barang.Click
        FormBarang.Show()
        FormBarang.Button1.PerformClick()
    End Sub
    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        FormBarang.ShowDialog()
    End Sub
    Private Sub Penjualan_Click(sender As Object, e As EventArgs) Handles penjualan.Click
        FormPenjualan.ShowDialog()
    End Sub
    Private Sub PenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PenjualanToolStripMenuItem.Click
        FormPenjualan.ShowDialog()
    End Sub

    Private Sub LapData_Click(sender As Object, e As EventArgs) Handles laporan_data.Click
        FormLaporanDataMaster.ShowDialog()
    End Sub

    Private Sub LaporanDataMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanDataMasterToolStripMenuItem.Click
        FormLaporanDataMaster.ShowDialog()
    End Sub
    Private Sub LapPenjualan_Click(sender As Object, e As EventArgs) Handles laporan_penjualan.Click
        FormLaporanPenjualan.ShowDialog()
    End Sub
    Private Sub LaporanPenjualanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPenjualanToolStripMenuItem.Click
        FormLaporanPenjualan.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles pembelian.Click
        FormPembelian.ShowDialog()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        FormPembelian.ShowDialog()
    End Sub
    Private Sub LaporanPembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanPembelianToolStripMenuItem.Click
        FormLaporanPembelian.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles laporan_pembelian.Click
        FormLaporanPembelian.ShowDialog()
    End Sub
    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Yakin Ingin Keluar ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Menu.Enabled = False
            MenuStrip1.Visible = False
            PnlMenu.Visible = False
            user = vbNullString
            LblStatus.Text = ""
            LblUsername.Text = ""
            Login.ShowDialog()
        End If
    End Sub
    'Private Sub BukaFormBaru(FormBaru As Form)
    'If FormSekarang IsNot Nothing Then
    '      FormSekarang.Close()
    'End If
    '  FormSekarang = FormBaru
    '  FormBaru.TopLevel = False
    '  FormBaru.Dock = DockStyle.Fill
    '  Dashboard.Controls.Add(FormBaru)
    '  Dashboard.Tag = FormBaru
    '  FormBaru.BringToFront()
    '  FormBaru.Show()
    '  Label9.Text = FormBaru.Text
    '  End Sub
End Class