Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.Text = "Centigrade"
        Label2.Text = "Fahrenheit"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.Text = "Fahrenheit"
        Label2.Text = "Centigrade"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c, f As Double

        If (RadioButton1.Checked = True) Then
            c = Val(TextBox1.Text)
            f = (9 * c + 160) / 5
            TextBox2.Text = Val(f)
        End If
        If (RadioButton2.Checked = True) Then
            f = Val(TextBox1.Text)
            c = (5 * f - 160) / 9
            TextBox2.Text = Val(c)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

End Class
