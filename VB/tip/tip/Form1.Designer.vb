<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fiveRadioButton = New System.Windows.Forms.RadioButton()
        Me.tenRadioButton = New System.Windows.Forms.RadioButton()
        Me.fivRadioButton = New System.Windows.Forms.RadioButton()
        Me.tRadioButton = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(304, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(304, 184)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bill"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total"
        '
        'fiveRadioButton
        '
        Me.fiveRadioButton.AutoSize = True
        Me.fiveRadioButton.Location = New System.Drawing.Point(244, 89)
        Me.fiveRadioButton.Name = "fiveRadioButton"
        Me.fiveRadioButton.Size = New System.Drawing.Size(47, 20)
        Me.fiveRadioButton.TabIndex = 7
        Me.fiveRadioButton.TabStop = True
        Me.fiveRadioButton.Text = "5%"
        Me.fiveRadioButton.UseVisualStyleBackColor = True
        '
        'tenRadioButton
        '
        Me.tenRadioButton.AutoSize = True
        Me.tenRadioButton.Location = New System.Drawing.Point(244, 116)
        Me.tenRadioButton.Name = "tenRadioButton"
        Me.tenRadioButton.Size = New System.Drawing.Size(54, 20)
        Me.tenRadioButton.TabIndex = 8
        Me.tenRadioButton.TabStop = True
        Me.tenRadioButton.Text = "10%"
        Me.tenRadioButton.UseVisualStyleBackColor = True
        '
        'fivRadioButton
        '
        Me.fivRadioButton.AutoSize = True
        Me.fivRadioButton.Location = New System.Drawing.Point(244, 143)
        Me.fivRadioButton.Name = "fivRadioButton"
        Me.fivRadioButton.Size = New System.Drawing.Size(54, 20)
        Me.fivRadioButton.TabIndex = 9
        Me.fivRadioButton.TabStop = True
        Me.fivRadioButton.Text = "15%"
        Me.fivRadioButton.UseVisualStyleBackColor = True
        '
        'tRadioButton
        '
        Me.tRadioButton.AutoSize = True
        Me.tRadioButton.Location = New System.Drawing.Point(244, 170)
        Me.tRadioButton.Name = "tRadioButton"
        Me.tRadioButton.Size = New System.Drawing.Size(54, 20)
        Me.tRadioButton.TabIndex = 10
        Me.tRadioButton.TabStop = True
        Me.tRadioButton.Text = "20%"
        Me.tRadioButton.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(304, 132)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tip"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(307, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.tRadioButton)
        Me.Controls.Add(Me.fivRadioButton)
        Me.Controls.Add(Me.tenRadioButton)
        Me.Controls.Add(Me.fiveRadioButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Tip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents fiveRadioButton As RadioButton
    Friend WithEvents tenRadioButton As RadioButton
    Friend WithEvents fivRadioButton As RadioButton
    Friend WithEvents tRadioButton As RadioButton
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
