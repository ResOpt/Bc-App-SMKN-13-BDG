﻿Imports System.Data.SqlClient

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
        conn.Close()

        Return Status.Success
    End Function

    Public Function list_barang()
        conn.Open()
        cmd = New SqlCommand("SELECT * FROM barang", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dataset As New DataSet
        adapter.Fill(dataset)
        conn.Close()
        Return dataset
    End Function

    Public Function get_buy_price(code As String)
        conn.Open()
        cmd = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = @code", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = code.ToLower()
        Dim str = ""
        Dim reader = cmd.ExecuteReader()
        While reader.Read
            str = reader.GetInt32(0).ToString()
        End While
        conn.Close()
        Return str
    End Function

    Public Function price_difference()

    End Function

End Class
