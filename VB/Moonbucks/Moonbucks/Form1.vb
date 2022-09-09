Public Class Form1
    Dim Dpounds As Decimal
    Dim Rpounds As Decimal
    Private Sub caluatebutton_Click(sender As Object, e As EventArgs) Handles CaluateButton.Click
        Decimal.TryParse(decafTextBox.Text, Dpounds)
        Decimal.TryParse(RegularTextBox.Text, Rpounds)
        PoundsTextBox.Text = Rpounds + Dpounds
        TotalTextBox.Text = ((Rpounds + Dpounds) * 4.99).ToString("C2")
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        PoundsTextBox.Clear()
        TotalTextBox.Clear()
        decafTextBox.Clear()
        RegularTextBox.Clear()
        StatesComboBox.ResetText()
    End Sub
End Class
