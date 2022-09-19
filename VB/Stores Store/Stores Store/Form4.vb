Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quantity1 As Integer




        Integer.TryParse(TextBox4.Text, quantity1)
        If quantity1 > 10 Then
            quantity1 = 0
            MessageBox.Show("Unable to add to Cart", "Error")
        Else
            Air_Mags = 30000 * quantity1
        End If




        Form1.MagsTextBox.Text = quantity1
        Me.Close()
    End Sub
End Class