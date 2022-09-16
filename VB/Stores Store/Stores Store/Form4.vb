Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quantity1 As Integer




        Integer.TryParse(TextBox4.Text, quantity1)
        Air_Mags = 30000 * quantity1





        Form1.MagsTextBox.Text = quantity1
        Me.Close()
    End Sub
End Class