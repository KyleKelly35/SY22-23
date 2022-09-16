Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim quantity1 As Integer
        Dim quantity2 As Integer




        Integer.TryParse(TextBox4.Text, quantity1)
        Dunks_Argon = 250 * quantity1




        Integer.TryParse(TextBox3.Text, quantity2)
        Dunks_Phantom = 350 * quantity2

        Form1.ArgonTextBox.Text = quantity1
        Form1.PhantomTextBox.Text = quantity2

        Me.Close()

    End Sub
End Class