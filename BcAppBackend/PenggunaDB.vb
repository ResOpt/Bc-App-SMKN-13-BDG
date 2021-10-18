Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Linq
Public Class PenggunaDB
    Inherits BaseConnection
    Public Function register(user_id As String, password As String, confirm_password As String, username As String, status As String)
        'Fungsi untuk mendaftarkan pengguna

        '@param user_id As String
        '   ID unik User dengan tipe String
        '@param password As String
        '   Password User dengan tipe String
        '@confirm_password As String
        '   Konfirmasi Password dengan tipe String
        '@username As String
        '   Nama User dengan tipe String
        '@status As String
        '   Status Privilege User
        Dim errors As Status

        'Bila username belum terpakai dan id valid
        If username_exists(user_id) = False And userid_isvalid(user_id) Then
            'Bila password dan konfirmasi password cocok
            If validate_password(password, confirm_password) Then
                conn.Open()
                'Masukkan username dan password yang diinput ke database
                Dim cmmd = New SqlCommand("INSERT INTO pengguna (user_id, password, nama_pengguna, status) VALUES ('" & user_id.ToLower() & "','" & GetHash(password) & "','" & username & "','" & convert_privilege(status) & "')", conn)
                Try
                    cmmd.ExecuteNonQuery()
                Catch e As Exception
                    conn.Close()
                    Return errors.DataIncomplete
                End Try
                'Tutup koneksi
                conn.Close()
                Return errors.Success
            Else
                Return errors.PasswordDoesNotMatch
            End If

        Else
            Return errors.InvalidUsername
        End If
    End Function
    Public Function login(user_id As String, password As String)
        Dim command = New SqlCommand("SELECT * FROM pengguna WHERE user_id = @user_id AND password = @password", conn)
        command.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_id.ToLower()
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = GetHash(password)
        Dim adapter = New SqlDataAdapter(command)
        Dim table = New DataTable()
        adapter.Fill(table)
        If table.Rows.Count() <= 0 Then
            Return Status.LoginFailed
        Else
            user = user_id
            Return Status.Success
        End If
    End Function

    Public Function logout()
        user = vbNullString
    End Function

    Public Function edit_user(user_id As String, password As String, confirm_password As String, username As String, status As String)
        'UNIMPLEMENTED
    End Function

    Public Function delete_user(user_id As String)
        conn.Open()
        cmd = New SqlCommand("DELETE FROM pengguna WHERE user_id = @user_id", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_id.ToLower()
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            conn.Close()
            Return Status.FailedToDeleteUser
        End Try
        conn.Close()
        Return Status.Success
    End Function

    Private Function username_exists(user_id As String)
        conn.Open()
        cmd = New SqlCommand("SELECT COUNT(*) FROM pengguna WHERE user_id = @user_id", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_id.ToLower()
        Dim result = cmd.ExecuteScalar()
        conn.Close()
        If Convert.ToInt32(result) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function userid_isvalid(user_id As String)
        Dim special_char = {
            "+", "-", "&&", "||", "!", "(", ")", "{", "}", "[", "]", "^",
            "~", "*", "?", ":", """", "\"
        }
        If special_char.Any(Function(x) user_id.ToLower().Contains(x.ToLower())) Or user_id.Any(Function(x) Char.IsWhiteSpace(x)) Or String.IsNullOrWhiteSpace(user_id) Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function validate_password(password As String, confirm_password As String)
        If password = confirm_password Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Function GetHash(theInput As String) As String

        Using hasher As MD5 = MD5.Create()

            Dim dbytes As Byte() =
                 hasher.ComputeHash(Encoding.UTF8.GetBytes(theInput))

            Dim sBuilder As New StringBuilder()

            For n As Integer = 0 To dbytes.Length - 1
                sBuilder.Append(dbytes(n).ToString("X2"))
            Next n

            Return sBuilder.ToString()
        End Using

    End Function

    Private Function convert_privilege(status As String)
        If status = "User" Then
            Return 1
        ElseIf status = "Admin" Then
            Return 2
        ElseIf status = "Superuser" Then
            Return 3
        End If
    End Function
    Public Function get_username(user_id As String)
        conn.Open()
        cmd = New SqlCommand("SELECT nama_pengguna FROM pengguna WHERE user_id = @user_id", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_id.ToLower()
        Dim str = ""
        Dim reader = cmd.ExecuteReader()
        While reader.Read
            str = reader.GetString(0)
        End While
        conn.Close()
        Return str
    End Function
    Public Function get_status(user_id As String)
        conn.Open()
        cmd = New SqlCommand("SELECT status FROM pengguna WHERE user_id = @user_id", conn)
        cmd.Parameters.Add("@user_id", SqlDbType.VarChar).Value = user_id.ToLower()
        Dim str = ""
        Dim reader = cmd.ExecuteReader()
        While reader.Read
            If reader.GetInt32(0) = 3 Then
                str = "Superuser"
            ElseIf reader.GetInt32(0) = 2 Then
                str = "Admin"
            ElseIf reader.GetInt32(0) = 1 Then
                str = "Pengguna"
            End If
        End While
        conn.Close()
        Return str
    End Function
End Class
