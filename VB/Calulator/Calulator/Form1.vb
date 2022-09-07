Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim oper As String
    Dim mem As Decimal
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles MyBase.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click, Button1.Click, Button11.Click
        Displaytextbox.Text = Displaytextbox.Text + sender.text

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Displaytextbox.Clear()
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "+"
        Displaytextbox.Clear()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Decimal.TryParse(Displaytextbox.Text, num2)
        If oper = "+" Then
            Displaytextbox.Text = num1 + num2
        End If
        If oper = "-" Then
            Displaytextbox.Text = num1 - num2
        End If
        If oper = "/" Then
            Displaytextbox.Text = num1 / num2
        End If
        If oper = "*" Then
            Displaytextbox.Text = num1 * num2
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "-"
        Displaytextbox.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "/"
        Displaytextbox.Clear()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        oper = "*"
        Displaytextbox.Clear()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Sqrt(num1)
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Sin(num1)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Cos(num1)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Decimal.TryParse(Displaytextbox.Text, num1)
        Displaytextbox.Text = Math.Tan(num1)
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Displaytextbox.Text = Math.PI
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Decimal.TryParse(Displaytextbox.Text, mem)

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Displaytextbox.Text = mem
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        mem = 0
    End Sub
End Class
