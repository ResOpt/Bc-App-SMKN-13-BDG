Imports System.Data.SqlClient

Public Class BarangDB
    Inherits BaseConnection
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

        open_connection()
        cmd = New SqlCommand("INSERT INTO barang(kode_barang, nama_barang, harga_beli, harga_jual, stok) VALUES ('" & code & "','" & name & "'," & buy_price & "," & sell_price & "," & stock & ")", conn)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            close_connection()
            Return Status.FailedToAddItem
        End Try
        close_connection()

        Return Status.Success
    End Function

    Public Function list_barang()
        open_connection()
        cmd = New SqlCommand("SELECT * FROM barang", conn)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim dataset As New DataSet
        adapter.Fill(dataset)
        close_connection()
        Return dataset
    End Function

    Public Function get_buy_price(code As String)
        open_connection()
        cmd = New SqlCommand("SELECT harga_beli FROM barang WHERE kode_barang = @code", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = code.ToLower()
        Dim str = ""
        Dim reader = cmd.ExecuteReader()
        While reader.Read
            str = reader.GetInt32(0).ToString()
        End While
        close_connection()
        Return str
    End Function

    Public Function create_hashtable(code As String, name As String, buy_price As String, sell_price As String, stock As String)
        Dim table As New Hashtable()
        table.Add("kode_barang", code)
        If Not String.IsNullOrEmpty(name) Then
            table.Add("nama_barang", name)
        End If
        If Not String.IsNullOrEmpty(buy_price) Then
            table.Add("harga_beli", Val(buy_price))
        End If
        If Not String.IsNullOrEmpty(sell_price) Then
            table.Add("harga_jual", Val(sell_price))
        End If
        If Not String.IsNullOrEmpty(stock) Then
            table.Add("stok", Val(stock))
        End If
        Return table
    End Function

    Public Function update_item(table As Hashtable)
        Dim list As New ArrayList()
        If Not table.ContainsKey("kode_barang") Then
            Return Status.FailedToAddItem
        Else
            'Membuat UPDATE barang SET x = y etc, etc
            Dim str = New System.Text.StringBuilder
            str.Append("UPDATE barang SET ")
            If table.ContainsKey("nama_barang") Then
                If list.Count < 1 Then
                    list.Add($" nama_barang = '{table.Item("nama_barang")}'")
                Else
                    list.Add($", nama_barang = {table.Item("nama_barang")}")
                End If
            End If
            If table.ContainsKey("harga_beli") Then
                If list.Count < 1 Then
                    list.Add($" harga_beli = {table.Item("harga_beli")}")
                Else
                    list.Add($", harga_beli = {table.Item("harga_beli")}")
                End If
            End If
            If table.ContainsKey("harga_jual") Then
                If list.Count < 1 Then
                    list.Add($" harga_jual = {table.Item("harga_jual")}")
                Else
                    list.Add($", harga_jual = {table.Item("harga_jual")}")

                End If
            End If
            If table.ContainsKey("stok") Then
                If list.Count < 1 Then
                    list.Add($" stok = {table.Item("stok")}")
                Else
                    list.Add($", stok = {table.Item("stok")}")
                End If
            End If
            str.Append(String.Join("", list.ToArray()))
            str.Append($" WHERE kode_barang = {table.Item("kode_barang")}")
            Debug.WriteLine($"DEBUG: {str}")
            cmd = New SqlCommand(str.ToString(), conn)
            open_connection()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                close_connection()
                Return Status.FailedToAddItem
            End Try
            close_connection()
            list.Clear()
            Return Status.Success
            End If
    End Function

    Public Function price_difference()

    End Function
    Public Sub fill_box(box)
        open_connection()
        Dim read = cmd.ExecuteReader()
        Dim x As New DataTable()
        Dim adapter As New SqlDataAdapter("SELECT kode_barang FROM barang", conn)
        adapter.Fill(x)
        close_connection()
    End Sub
End Class
