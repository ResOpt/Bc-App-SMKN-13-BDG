Imports System.Data.SqlClient

Public Class PembelianDB
	Inherits BaseConnection
	Public Function purchase(note As String,
							 purchase_date As DateTime,
							 user_id As String,
							 amount As Integer,
							 item_code As String
							 )

		Dim total = get_total_price(item_code, amount)
		open_connection()
		cmd = New SqlCommand(String.Format("INSERT INTO pembelian(no_nota_beli, tanggal_beli, user_id, harga_beli, jumlah, kode_barang, subtotal) VALUES ('{0}', @purchase_date,'{1}','{2}','{3}','{4}', '{5}')", note, user_id, total.Item1, amount, item_code, total.Item2), conn
			)
		cmd.Parameters.Add("@purchase_date", SqlDbType.SmallDateTime).Value = purchase_date
		Try
			cmd.ExecuteNonQuery()
		Catch ex As Exception
			Debug.WriteLine(ex)
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		close_connection()
		increase_stock(item_code, amount)
		Return Status.Success
	End Function

	Public Function list_purchase()
		open_connection()
		cmd = New SqlCommand("SELECT * FROM pembelian", conn)
		Dim adapter As New SqlDataAdapter(cmd)
		Dim dataset As New DataSet
		adapter.Fill(dataset)
		close_connection()
		Return dataset
	End Function

	Private Sub increase_stock(item_id, amount)
		open_connection()
		cmd = New SqlCommand(String.Format("SELECT stok FROM barang WHERE kode_barang = {0}", item_id), conn)
		Dim harga As Int32
		Dim reader = cmd.ExecuteReader()
		While reader.Read
			harga = reader.GetInt32(0) + amount
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
		cmd = New SqlCommand(String.Format("SELECT SUM(total) FROM pembelian WHERE no_nota_beli = {0}", note), conn)
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

	Public Function add_to_total_tbl(note, total, time)
		open_connection()
		cmd = New SqlCommand(String.Format("INSERT INTO pembelian_total(nota_pembelian, total, waktu_pembelian) VALUES ({0}, {1}, {2})", note, total, time), conn)
		Try
			cmd.ExecuteNonQuery()
		Catch ex As Exception
			close_connection()
			Return Status.FailedToAddPurchase
		End Try
		close_connection()
		Return Status.Success
	End Function

	Public Function create_table()
		Dim Table1 As DataTable
		Table1 = New DataTable("Penjualan")
		Dim column1 As DataColumn = New DataColumn("no_nota_beli")
		column1.DataType = System.Type.GetType("System.String")

		Dim column2 As DataColumn = New DataColumn("tanggal_beli")
		column2.DataType = System.Type.GetType("System.DateTime")
		Dim column3 As DataColumn = New DataColumn("user_id")
		column3.DataType = System.Type.GetType("System.String")
		Dim column4 As DataColumn = New DataColumn("harga_beli")
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

		Dim Row1 As DataRow
		Row1 = table.NewRow()
		open_connection()
		Dim price = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = " & item_code, conn)
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

		Row1.Item("no_nota_beli") = note
			Row1.Item("tanggal_beli") = purchase_date
			Row1.Item("user_id") = user_id
			Row1.Item("jumlah") = amount
			Row1.Item("harga_beli") = read
			Row1.Item("kode_barang") = item_code
			Row1.Item("subtotal") = get_total_price(item_code, amount).Item2
			Row1.Item("id") = id
			close_connection()
			open_connection()
			cmd = New SqlCommand(String.Format("UPDATE barang SET stok = {0} WHERE kode_barang = {1}", read_stock + amount, item_code), conn)
			cmd.ExecuteNonQuery()
			close_connection()
			table.Rows.Add(Row1)
			Return Status.Success

	End Function

	Public Sub clear_datatable(table As DataTable)
		table.Clear()
	End Sub

	Public Sub bulk_copy(table As DataTable)
		open_connection()
		Dim cp = New SqlBulkCopy(conn)
		cp.DestinationTableName = "pembelian"
		cp.WriteToServer(table)
		close_connection()
	End Sub

End Class
