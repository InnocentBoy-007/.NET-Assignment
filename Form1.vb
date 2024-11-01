Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Dim result As Double

        Num1 = Convert.ToDouble(TextBox1.Text)
        Num2 = Convert.ToDouble(TextBox2.Text)
        result = Num1 + Num2

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Dim result As Double

        Num1 = Convert.ToDouble(TextBox1.Text)
        Num2 = Convert.ToDouble(TextBox2.Text)
        result = Num1 - Num2

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Dim result As Double

        Num1 = Convert.ToDouble(TextBox1.Text)
        Num2 = Convert.ToDouble(TextBox2.Text)
        result = Num1 * Num2

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Dim result As Double

        Num1 = Convert.ToDouble(TextBox1.Text)
        Num2 = Convert.ToDouble(TextBox2.Text)
        result = Num1 / Num2

        TextBox3.Text = result.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Num1 As Double
        Dim Num2 As Double
        Dim result As Double

        Num1 = Convert.ToDouble(TextBox1.Text)
        Num2 = Convert.ToDouble(TextBox2.Text)
        result = Num1 ^ Num2

        TextBox3.Text = result.ToString()
    End Sub
End Class
