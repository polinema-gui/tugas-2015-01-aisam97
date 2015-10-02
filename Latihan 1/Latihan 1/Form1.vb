Public Class AplikasiLatihan

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lenghtLabel.Text = nameText.Text.Length
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles nameText.TextChanged
        lenghtLabel.Text = nameText.Text.Length
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        infoText.Text = "Selamat Sore, " & nameText.Text
    End Sub

    Private Sub Label2_TextChanged(sender As Object, e As EventArgs)
        lenghtLabel.Text = nameText.Text.Length
    End Sub

    Private Sub nameText_KeyDown(sender As Object, e As KeyEventArgs) Handles nameText.KeyDown
        If e.KeyCode = Keys.Enter Then
            infoText.Text = "Selamat Ores, " & nameText.Text
        End If
    End Sub

    Private Sub showButton_Click(sender As Object, e As EventArgs) Handles showButton.Click
        Form2.Show()
    End Sub
End Class
