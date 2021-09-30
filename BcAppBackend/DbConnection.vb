Imports System.Data.SqlClient
Public Module DbConnection
    Public conn As SqlConnection = New SqlConnection("Server = " & config().Item("SERVER") & "; Database = " & config().Item("DATABASE") & "; Integrated Security = true")
    Public cmd As SqlCommand
    Public logged_in As Boolean = False
    Public user As String = vbNullString
End Module
