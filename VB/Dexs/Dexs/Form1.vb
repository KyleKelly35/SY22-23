Public Class Form1


    Private Sub Dolphin_Click(sender As Object, e As EventArgs) Handles Dolphin.Click
        Displaypicturebox.Image = DolphinPictureBox.Image
        NameLabel.Text = "Dolphin"
        LegsLabel.Text = "0"
        HairyLabel.Text = "no"
        HeightLabel.Text = "2 to 3.9 m"
        FoodChainLabel.Text = "near the top"
        HairyLabel.Visible = True
        NameLabel.Visible = True
        LegsLabel.Visible = True
        HeightLabel.Visible = True
        FoodChainLabel.Visible = True
        balls.Visible = True
        Legs.Visible = True
        fhsf.Visible = True
        FoodChain.Visible = True
        Hairy.Visible = True
        Me.BackColor = Color.LightBlue

    End Sub

    Private Sub Shark_Click(sender As Object, e As EventArgs) Handles Shark.Click
        Displaypicturebox.Image = SharkPictureBox.Image
        NameLabel.Text = "Shark"
        LegsLabel.Text = "0"
        HairyLabel.Text = "no"
        HeightLabel.Text = "3.5 m"
        FoodChainLabel.Text = "The Top"
        HairyLabel.Visible = True
        NameLabel.Visible = True
        LegsLabel.Visible = True
        HeightLabel.Visible = True
        FoodChainLabel.Visible = True
        balls.Visible = True
        Legs.Visible = True
        fhsf.Visible = True
        FoodChain.Visible = True
        Hairy.Visible = True
        Me.BackColor = Color.LightBlue
    End Sub

    Private Sub Giraffe_Click(sender As Object, e As EventArgs) Handles Giraffe.Click
        Displaypicturebox.Image = GiraffePictureBox.Image
        NameLabel.Text = "Giraffe"
        LegsLabel.Text = "4"
        HairyLabel.Text = "yes"
        HeightLabel.Text = "16-19ft"
        FoodChainLabel.Text = "A Consumer"
        HairyLabel.Visible = True
        NameLabel.Visible = True
        LegsLabel.Visible = True
        HeightLabel.Visible = True
        FoodChainLabel.Visible = True
        balls.Visible = True
        Legs.Visible = True
        fhsf.Visible = True
        FoodChain.Visible = True
        Hairy.Visible = True
        Me.BackColor = Color.Tan
    End Sub

    Private Sub Sloth_Click(sender As Object, e As EventArgs) Handles Sloth.Click
        Displaypicturebox.Image = SlothPictureBox.Image
        NameLabel.Text = "Sloth"
        LegsLabel.Text = "2"
        HairyLabel.Text = "yes"
        HeightLabel.Text = "2.5ft"
        FoodChainLabel.Text = "Heterotroph"
        HairyLabel.Visible = True
        NameLabel.Visible = True
        LegsLabel.Visible = True
        HeightLabel.Visible = True
        FoodChainLabel.Visible = True
        balls.Visible = True
        Legs.Visible = True
        fhsf.Visible = True
        FoodChain.Visible = True
        Hairy.Visible = True
        Me.BackColor = Color.RosyBrown
    End Sub

    Private Sub Lion_Click(sender As Object, e As EventArgs) Handles Lion.Click
        Displaypicturebox.Image = LionPictureBox.Image
        NameLabel.Text = "Lion"
        LegsLabel.Text = "4"
        HairyLabel.Text = "yes"
        HeightLabel.Text = "3.9ft"
        FoodChainLabel.Text = "The Top"
        HairyLabel.Visible = True
        NameLabel.Visible = True
        LegsLabel.Visible = True
        HeightLabel.Visible = True
        FoodChainLabel.Visible = True
        balls.Visible = True
        Legs.Visible = True
        fhsf.Visible = True
        FoodChain.Visible = True
        Hairy.Visible = True
        Me.BackColor = Color.Tan
    End Sub

    Private Sub Startbutton_Click(sender As Object, e As EventArgs) Handles Startbutton.Click
        Dolphin.Visible = True
        Shark.Visible = True
        Sloth.Visible = True
        Giraffe.Visible = True
        Lion.Visible = True
        Restartbutton.Visible = True
        Startbutton.Visible = False
        Me.BackColor = Color.Thistle
        LionPictureBox.Visible = False
        DolphinPictureBox.Visible = False
        SharkPictureBox.Visible = False
        SlothPictureBox.Visible = False
        GiraffePictureBox.Visible = False
    End Sub

    Private Sub Restartbutton_Click(sender As Object, e As EventArgs) Handles Restartbutton.Click
        Dolphin.Visible = False
        Shark.Visible = False
        Sloth.Visible = False
        Giraffe.Visible = False
        Lion.Visible = False
        Startbutton.Visible = True
        Restartbutton.Visible = False
        HairyLabel.Visible = False
        NameLabel.Visible = False
        LegsLabel.Visible = False
        HeightLabel.Visible = False
        FoodChainLabel.Visible = False
        balls.Visible = False
        Legs.Visible = False
        fhsf.Visible = False
        FoodChain.Visible = False
        Hairy.Visible = False
        Displaypicturebox.Visible = False
        Me.BackColor = Color.Thistle
    End Sub
End Class