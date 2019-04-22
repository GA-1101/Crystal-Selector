Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Randomize()
        i = Rnd() * 40 + 1
        If i Mod 4 = 0 Then
            TextBox1.Text = "拉面".ToString
        End If
        If i Mod 4 = 1 Then
            TextBox1.Text = "苏式面".ToString
        End If
        If i Mod 4 = 2 Then
            TextBox1.Text = "燃面".ToString
        End If
        If i Mod 4 = 3 Then
            TextBox1.Text = "盖浇饭".ToString
        End If
    End Sub
End Class
