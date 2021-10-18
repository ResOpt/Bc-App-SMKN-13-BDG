Imports System.Data.SqlClient
'Public Module DbConnection
'Public conn As SqlConnection = New SqlConnection("Server = " & config().Item("SERVER") & "; Database = " & config().Item("DATABASE") & "; Integrated Security = true")
'Public cmd As SqlCommand
'Public logged_in As Boolean = False
'Public user As String = vbNullString
'End Module

Public Module Account
    Public user = vbNullString
End Module

Public MustInherit Class BaseConnection
    Public Property conn As SqlConnection = New SqlConnection("Server = " & config().Item("SERVER") & "; Database = " & config().Item("DATABASE") & "; Integrated Security = true")
    Public Property cmd As SqlCommand

    Public Sub open_connection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub close_connection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub
End Class