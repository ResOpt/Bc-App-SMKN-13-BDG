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
End Class
