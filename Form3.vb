Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim n As Integer
        Dim squares As String = ""
        If Integer.TryParse(TextBox1.Text, n) Then
            For i As Integer = 1 To n
                squares &= (i * i).ToString() & ", "
            Next

            TextBox2.Text = squares
        Else
            TextBox2.Clear()
        End If
    End Sub
End Class
