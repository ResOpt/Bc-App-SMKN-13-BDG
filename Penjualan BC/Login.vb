﻿Imports PenggunaDB

Public Class Login
    Dim firstX As Integer
    Dim firstY As Integer
    Dim lbuttonDown As Boolean
    Dim connect = New PenggunaDB

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = True
            firstX = e.X
            firstY = e.Y
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbuttonDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        If lbuttonDown Then
            Me.Left = -firstX + PointToScreen(e.Location).X
            Me.Top = PointToScreen(e.Location).Y
        End If
    End Sub
    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles Cls.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim log = connect.login(Username.Text, Password.Text)
        If log Then
            MessageBox.Show("Login berhasil! Selamat datang, " & user)
        Else
            MessageBox.Show("Login gagal!")
        End If
    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged

    End Sub
End Class