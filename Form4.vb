Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim n As Integer
        Dim factorial As Long = 1

        If Integer.TryParse(TextBox1.Text, n) AndAlso n >= 0 Then
            If n = 0 Then
                factorial = 1
            Else
                For i As Integer = 1 To n
                    factorial *= i
                Next
            End If

            TextBox2.Text = factorial.ToString()
        Else
            TextBox2.Clear()
        End If
    End Sub
End Class
