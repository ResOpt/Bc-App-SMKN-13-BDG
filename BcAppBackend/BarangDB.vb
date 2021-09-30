Imports System.Data.SqlClient

Public Class BarangDB
    Public Function add_item(code As String, name As String, buy_price As Integer, sell_price As Integer, stock As Integer)
        'Fungsi untuk menambah barang

        '@param code As String
        '   Kode Barang dengan tipe String
        '@param name As String
        '   Nama Barang dengan tipe String
        '@param buy_price As Integer
        '   Harga beli dengan tipe Integer
        '@param sell_price As Integer
        '   Harga jual dengan tipe Integer
        '@param stock As Integer
        '   Stok dengan tipe Integer
        '@return Enum
        '   Mengembalikan Enum yang cocok dengan kondisi

        conn.Open()
        cmd = New SqlCommand("INSERT INTO barang(kode_barang, nama_barang, harga_beli, harga_jual, stok) VALUES ('" & code & "','" & name & "'," & buy_price & "," & sell_price & "," & stock & ")", conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            conn.Close()
            Return Status.FailedToAddItem
        End Try

        Return Status.Success
    End Function

End Class
