Imports System.Data.SqlClient

Public Class PembelianDB
	Public Function purchase(note As String,
							 purchase_date As DateTime,
							 user_id As String,
							 amount As Integer,
							 item_code As String
							 )

		conn.Open()
		Dim buy_price = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = " & item_code, conn)
		Dim int As Integer
		Try
			Dim reader = buy_price.ExecuteReader()
			While reader.Read
				int = reader.GetInt32(0)
			End While
		Catch ex As Exception
			Debug.WriteLine(ex)
			conn.Close()
			Return Status.FailedToAddPurchase
		End Try
		Dim total = calculate_total(int, amount)
		conn.Close()
		conn.Open()
		cmd = New SqlCommand(String.Format("INSERT INTO pembelian(no_nota_beli, tanggal_beli, user_id, harga_beli, jumlah, kode_barang, subtotal) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}', '{6}')", note, purchase_date, user_id, int, amount, item_code, total), conn
			)
		Try
			cmd.ExecuteNonQuery()
		Catch ex As Exception
			Debug.WriteLine(ex)
			conn.Close()
			Return Status.FailedToAddPurchase
		End Try
		conn.Close()
		Return Status.Success
	End Function

	Public Function list_purchase()
		conn.Open()
		cmd = New SqlCommand("SELECT * FROM pembelian", conn)
		Dim adapter As New SqlDataAdapter(cmd)
		Dim dataset As New DataSet
		adapter.Fill(dataset)
		conn.Close()
		Return dataset
	End Function

	Public Function calculate_total(buy_price As Integer, amount As Integer)
		Return buy_price * amount
	End Function
End Class
