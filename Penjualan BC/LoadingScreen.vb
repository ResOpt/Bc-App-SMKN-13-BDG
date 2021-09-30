Public Class LoadingScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar2.Value += 5
        If ProgressBar2.Value = 100 Then
            Timer1.Enabled = False
            Me.Hide()
            Form1.Show()
        End If
    End Sub
End Class