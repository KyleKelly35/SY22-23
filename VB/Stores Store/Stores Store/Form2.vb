Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quantity1 As Integer
        Dim quantity2 As Integer




        Integer.TryParse(TextBox4.Text, quantity1)
        Ben_and_Jerry = 1700 * quantity1




        Integer.TryParse(TextBox3.Text, quantity2)
        Space_Jam = 220 * quantity2

        Form1.BenTextBox.Text = quantity1
        Form1.AirTextBox.Text = quantity2
        Me.Close()

    End Sub
End Class
