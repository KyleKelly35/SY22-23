Public Class form1
    Private Sub EuroButton_Click(sender As Object, e As EventArgs) Handles EuroButton.Click
        Dim dollars As Decimal
        Decimal.TryParse(TextBox1.Text, dollars)
        Dim Euro As Decimal
        Euro = dollars * 1
        TextBox2.Text = Euro.ToString("N2")
    End Sub
End Class
