Imports BarangDB

Public Class FormBarang
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean

    Dim connect = New BarangDB
    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles harga_beli.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stok.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles harga_jual.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub kode_barang_TextChanged(sender As Object, e As EventArgs) Handles kode_barang.TextChanged

    End Sub

    Private Sub nama_barang_TextChanged(sender As Object, e As EventArgs) Handles nama_barang.TextChanged

    End Sub

    Private Sub harga_beli_TextChanged(sender As Object, e As EventArgs) Handles harga_beli.TextChanged

    End Sub

    Private Sub harga_jual_TextChanged(sender As Object, e As EventArgs) Handles harga_jual.TextChanged

    End Sub

    Private Sub stok_TextChanged(sender As Object, e As EventArgs) Handles stok.TextChanged

    End Sub

    Private Sub button_input_Click(sender As Object, e As EventArgs) Handles button_input.Click
        If String.IsNullOrEmpty(kode_barang.Text) Or String.IsNullOrEmpty(nama_barang.Text) Or String.IsNullOrEmpty(harga_beli.Text) Then
            MessageBox.Show("Isi barang!!")
        Else
            Dim insert = connect.add_item(kode_barang.Text, nama_barang.Text, Val(harga_beli.Text), Val(harga_jual.Text), Val(stok.Text))
            If insert = Status.FailedToAddItem Then
                MessageBox.Show("Gagal menambahkan barang!!")
            Else
                MessageBox.Show("Berhasil menambahkan barang " & nama_barang.Text & " dengan kode " & kode_barang.Text)
                ClearTextBoxes(Me)
            End If
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim barang = connect.list_barang()
        Dim table As New DataTable
        For Each table In barang.Tables
            DataGridView2.DataSource = table
        Next
    End Sub

    Private Sub button_hapus_Click(sender As Object, e As EventArgs) Handles button_hapus.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim barang = connect.list_barang()
        Dim table As New DataTable
        For Each table In barang.Tables
            DataGridView2.DataSource = table
        Next
    End Sub

    Private Sub button_edit_Click(sender As Object, e As EventArgs) Handles button_edit.Click
        Dim table = connect.create_hashtable(kode_barang.Text, nama_barang.Text, harga_beli.Text, harga_jual.Text, stok.Text)
        Dim update = connect.update_item(table)
        If update = Status.FailedToAddItem Then
            MessageBox.Show("Gagal mengedit barang!! Cek apakah kode barang valid")
        Else
            MessageBox.Show("Sukses!!")
            Me.Button1.PerformClick()
        End If
    End Sub
End Class