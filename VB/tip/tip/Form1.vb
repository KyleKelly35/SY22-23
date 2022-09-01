Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Decimal
        Decimal.TryParse(TextBox1.Text, total)
        Dim tip As Decimal
        tip = total
        If fiveRadioButton.Checked Then
            TextBox2.Text = total * 1.05
            TextBox3.Text = tip * 0.05
        End If
        If tenRadioButton.Checked Then
            TextBox2.Text = total * 1.1

            TextBox3.Text = tip * 0.1
        End If
        If fivRadioButton.Checked Then
            TextBox2.Text = total * 1.15

            TextBox3.Text = tip * 0.15
        End If
        If tRadioButton.Checked Then
            TextBox2.Text = total * 1.2

            TextBox3.Text = tip * 0.2
        End If
    End Sub
End Class
