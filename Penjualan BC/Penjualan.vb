Public Class FormPenjualan
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean

    Dim connect = New PenjualanDB
    Dim table = connect.create_table()
    Dim id = 1

    Private Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizedBounds = Screen.FromHandle(Me.Handle).WorkingArea
        Me.WindowState = FormWindowState.Normal
    End Sub
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
    Private Sub Max_Click(sender As Object, e As EventArgs) Handles Max.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub
    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles Cls.Click
        Me.Close()
    End Sub
    Private Sub Min_Click(sender As Object, e As EventArgs) Handles Min.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles button_simpan.Click
        Dim res = MessageBox.Show("Apakah Ingin Cetak Nota ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = System.Windows.Forms.DialogResult.Yes Then
            connect.bulk_copy(table)
            MessageBox.Show("Pembelian sukses disimpan")
            connect.clear_datatable(table)
            connect.add_to_total_tbl(no_nota_jual.Text, Val(total_bayar.Text), DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
            id = 1
        Else
            connect.bulk_copy(table)
            MessageBox.Show("Pembelian sukses disimpan")
            connect.clear_datatable(table)
            connect.add_to_total_tbl(no_nota_jual.Text, Val(total_bayar.Text), DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
            id = 1
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles no_nota_jual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) 
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlah.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kembalian.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles bayar.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox9_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub no_nota_jual_TextChanged(sender As Object, e As EventArgs) Handles no_nota_jual.TextChanged

    End Sub

    Private Sub kode_barang_TextChanged(sender As Object, e As EventArgs) Handles kode_barang.TextChanged

    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged

    End Sub

    Private Sub button_input_Click(sender As Object, e As EventArgs) Handles button_input.Click
        Dim add = connect.add_to_data_table(table, no_nota_jual.Text, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), user, Val(jumlah.Text), kode_barang.Text, id)
        If add = Status.FailedToAddPurchase Then
            id = 1
            MessageBox.Show("Gagal menambah penjualan!! Ceklah stok barang!!")
        ElseIf add = Status.AlreadyExist Then
            MessageBox.Show("Barang sudah ada!! Harap mengedit saja!")
        ElseIf add = Status.DataDoesNotExist Then
            MessageBox.Show("Barang tidak ada!!")
        Else
            id += 1
            Dim sum = 0
            Dim x As DataRow
            For Each x In table.Rows
                sum += Val(x.Item("subtotal"))
            Next x
            total_bayar.Text = sum
            MessageBox.Show("Penjualan berhasil ditambahkan")
        End If
    End Sub

    Private Sub total_bayar_Click(sender As Object, e As EventArgs) Handles total_bayar.Click

    End Sub

    Private Sub btn_tampilkan_Click(sender As Object, e As EventArgs) Handles btn_tampilkan.Click
        DataGridView2.DataSource = table
    End Sub
End Class