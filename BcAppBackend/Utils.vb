Imports System.IO

Module Utils
    Public Sub ClearTextBoxes(frm As Form)

        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub


    Private path As String = ".\config.conf"
    Public Function config()
        Dim list As New List(Of String)
        Dim hashtable As New Hashtable()
        Try
            Using Reader As New StreamReader(path)
                While Reader.Peek <> -1
                    Dim splitter = Reader.ReadLine().Trim().Split("=")
                    hashtable.Add(splitter(0).Trim(), splitter(1).Trim())
                End While
            End Using
        Catch ex As Exception
            MsgBox("File config.conf tidak ditemukan!!")
        End Try
        Return hashtable
    End Function

    Public Function is_empty(frm As Form)
        Dim list = New List(Of Control)
        For Each Control In frm.Controls
            If TypeOf Control Is TextBox Or TypeOf Control Is ComboBox Then
                If String.IsNullOrWhiteSpace(Control.Text) Or String.IsNullOrEmpty(Control.Text) Then
                    list.Add(Control)
                End If
            End If
        Next Control
        If list.Count() > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Module
