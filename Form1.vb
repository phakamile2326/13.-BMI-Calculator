Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Height, Weight, BMI As Double
        Height = Val(TextBox1.Text)
        Weight = Val(TextBox2.Text)

        BMI = Weight / (Height) ^ 2 'BMI FORMULA

        TextBox3.Text = BMI

        If BMI < 18 Then
            TextBox4.Text = "you are underweight"

        ElseIf 18 <= BMI And BMI < 26 Then
            TextBox4.Text = "you are normal"

        Else
            TextBox4.Text = "you are overweight"
        End If
        BackColor = Color.Gray
        Opacity = 0.95

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub
End Class
