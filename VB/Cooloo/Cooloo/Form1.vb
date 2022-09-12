Public Class Form1
    Dim inputred As Integer
    Dim inputgreen As Integer
    Dim inputblue As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Integer.TryParse(RedTextBox.Text, inputred)
        Integer.TryParse(GreenTextBox.Text, inputgreen)
        Integer.TryParse(BlueTextBox.Text, inputblue)
        PictureBox1.BackColor = Color.FromArgb(inputred, inputgreen, inputblue)
    End Sub
End Class
