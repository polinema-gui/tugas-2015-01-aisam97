Public Class Change

    Private Sub Ubah_Click(sender As Object, e As EventArgs) Handles Ubah.Click
        If Me.BackColor = Color.Red Then
            Me.BackColor = Color.DarkBlue
        ElseIf Me.BackColor = Color.DarkBlue Then
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
