Imports System.Data.SqlClient

'UNIMPLEMENTED
Public Class PenjualanDB
	Inherits BaseConnection
	Public Function sale(note As String,
						 sold_date As DateTime,
						 user_id As String,
						 amount As Integer,
						 item_code As String
						 )

		open_connection()
		Dim buy_price = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = " & item_code, conn)
		Dim int As Integer
		Try
			Dim reader = buy_price.ExecuteReader()
			While reader.Read
				int = reader.GetInt32(0)
			End While
		Catch ex As Exception
			Debug.WriteLine(ex)
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		Dim total = calculate_total(int, amount)
		close_connection()
		open_connection()
		cmd = New SqlCommand(String.Format("INSERT INTO pembelian(no_nota_beli, tanggal_beli, user_id, harga_beli, jumlah, kode_barang, subtotal) VALUES ('{0}', @purchase_date,'{1}','{2}','{3}','{4}', '{5}')", note, user_id, int, amount, item_code, total), conn
			)
		cmd.Parameters.Add("@purchase_date", SqlDbType.SmallDateTime).Value = sold_date
		Try
			cmd.ExecuteNonQuery()
		Catch ex As Exception
			Debug.WriteLine(ex)
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		close_connection()
		decrease_stock(item_code, amount)
		Return Status.Success

	End Function
	Private Sub decrease_stock(item_id, amount)
		open_connection()
		cmd = New SqlCommand(String.Format("SELECT stok FROM barang WHERE kode_barang = {0}", item_id), conn)
		Dim harga As Int32
		Dim reader = cmd.ExecuteReader()
		While reader.Read
			harga = reader.GetInt32(0) - amount
		End While
		close_connection()
		open_connection()
		cmd = New SqlCommand(String.Format("UPDATE barang SET stok = {0} WHERE kode_barang = {1}", harga, item_id), conn)
		cmd.ExecuteNonQuery()
		close_connection()
	End Sub
	Public Function calculate_total(buy_price As Integer, amount As Integer)
		Return buy_price * amount
	End Function

	Public Function get_total_price(item_code As String, amount As Integer)
		open_connection()
		Dim buy_price = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = " & item_code, conn)
		Dim int As Integer
		Try
			Dim reader = buy_price.ExecuteReader()
			While reader.Read
				int = reader.GetInt32(0)
			End While
		Catch ex As Exception
			Debug.WriteLine(ex)
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		Dim total = calculate_total(int, amount)
		close_connection()
		Return (int, total)
	End Function

	Public Function get_total_purchase(note As String)
		open_connection()
		cmd = New SqlCommand(String.Format("SELECT SUM(total) FROM penjualan WHERE no_nota_jual = {0}", note), conn)
		Dim Int As Integer
		Try
			Dim reader = cmd.ExecuteReader()
			While reader.Read
				Int = reader.GetInt32(0)
			End While
		Catch ex As Exception
			Debug.WriteLine(ex)
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		close_connection()
		Return Int
	End Function

	Public Function add_to_total_tbl(note As String, total As Integer, time As DateTime)
		open_connection()
		cmd = New SqlCommand(String.Format("INSERT INTO penjualan_total(nota_penjualan, total, waktu_penjualan) VALUES ({0}, {1}, @date)", note, total), conn)
		cmd.Parameters.Add("@date", SqlDbType.SmallDateTime).Value = time
		'Try
		cmd.ExecuteNonQuery()
		'Catch ex As Exception
		'	close_connection()
		'	Return Status.FailedToAddPurchase
		'End Try
		close_connection()
		Return Status.Success
	End Function

	Public Function create_table()
		Dim Table1 As DataTable
		Table1 = New DataTable("Penjualan")
		Dim column1 As DataColumn = New DataColumn("no_nota_beli")
		column1.DataType = System.Type.GetType("System.String")

		Dim column2 As DataColumn = New DataColumn("tanggal_jual")
		column2.DataType = System.Type.GetType("System.DateTime")
		Dim column3 As DataColumn = New DataColumn("user_id")
		column3.DataType = System.Type.GetType("System.String")
		Dim column4 As DataColumn = New DataColumn("harga_jual")
		column4.DataType = System.Type.GetType("System.Int32")

		Dim column5 As DataColumn = New DataColumn("jumlah")
		column5.DataType = System.Type.GetType("System.Int32")
		Dim column6 As DataColumn = New DataColumn("kode_barang")
		column6.DataType = System.Type.GetType("System.String")
		Dim column7 As DataColumn = New DataColumn("subtotal")
		column7.DataType = System.Type.GetType("System.Int32")
		Dim column8 As DataColumn = New DataColumn("id")
		column8.DataType = System.Type.GetType("System.Int32")


		Table1.Columns.Add(column1)
		Table1.Columns.Add(column2)
		Table1.Columns.Add(column3)
		Table1.Columns.Add(column4)
		Table1.Columns.Add(column5)
		Table1.Columns.Add(column6)
		Table1.Columns.Add(column7)
		Table1.Columns.Add(column8)

		Return Table1

	End Function

	Public Function add_to_data_table(table As DataTable,
									  note As String,
						 purchase_date As DateTime,
						 user_id As String,
						 amount As Integer,
						 item_code As String,
									  id As Integer)
		open_connection()
		Dim command = New SqlCommand("SELECT * FROM barang", conn)
		Dim data_reader = command.ExecuteReader()
		Dim a = New ArrayList()
		If data_reader.HasRows Then
			Do While data_reader.Read()
				a.Add(data_reader.Item("kode_barang"))
			Loop
		End If
		If a.Contains(item_code) = False Then
			close_connection()
			Return Status.DataDoesNotExist
		End If
		close_connection()

		Dim i As DataRow
		Dim x = True
		Dim arr = New ArrayList()
		For Each i In table.Rows
			arr.Add(i.Item("kode_barang"))
		Next i
		Debug.WriteLine($"DEBUG: {arr.Contains(item_code)}")
		If arr.Contains(item_code) Then
			Return Status.AlreadyExist
		Else
			Dim Row1 As DataRow
			Row1 = table.NewRow()
			open_connection()
			Dim price = New SqlCommand("SELECT harga_jual FROM barang WHERE kode_barang = " & item_code, conn)
			Dim stock = New SqlCommand("SELECT stok FROM barang WHERE kode_barang = " & item_code, conn)
			Dim read As Integer
			Dim read_stock As Integer
			Try
				read = price.ExecuteScalar()
				read_stock = stock.ExecuteScalar()
			Catch ex As Exception
				close_connection()
				Return Status.FailedToAddPurchase
			End Try

			If amount > read_stock Then
				close_connection()
				Return Status.FailedToAddPurchase
			Else
				Row1.Item("no_nota_beli") = note
				Row1.Item("tanggal_jual") = purchase_date
				Row1.Item("user_id") = user_id
				Row1.Item("jumlah") = amount
				Row1.Item("harga_jual") = read
				Row1.Item("kode_barang") = item_code
				Row1.Item("subtotal") = get_total_price(item_code, amount).Item2
				Row1.Item("id") = id
				close_connection()
				table.Rows.Add(Row1)
				Return Status.Success
			End If
		End If

	End Function

	Private Sub decrease_stock(table As DataTable)
		Dim i As DataRow
		For Each i In table.Rows
			open_connection()
			Dim another_cmd = New SqlCommand($"SELECT stok FROM barang WHERE kode_barang = {i.Item("kode_barang")}", conn)
			Dim read = another_cmd.ExecuteScalar()
			cmd = New SqlCommand($"UPDATE barang SET stok = {read - Val(i.Item("jumlah"))} WHERE kode_barang = {i.Item("kode_barang")}", conn)
			cmd.ExecuteNonQuery()
			close_connection()
		Next i
	End Sub

	Public Sub clear_datatable(table As DataTable)
		table.Clear()
	End Sub

	Public Sub bulk_copy(table As DataTable)
		decrease_stock(table)
		open_connection()
		Dim cp = New SqlBulkCopy(conn)
		cp.DestinationTableName = "penjualan"
		cp.WriteToServer(table)
		close_connection()
	End Sub
End Class
