Public Class Calculadora

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n1, n2, r
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        r = n1 + n2
        Me.TextBox3.Text = r


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n1, n2, r
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        r = n1 - n2
        Me.TextBox3.Text = r

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim n1, n2, r
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        r = n1 * n2
        Me.TextBox3.Text = r

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim n1, n2, r
        n1 = Val(Me.TextBox1.Text)
        n2 = Val(Me.TextBox2.Text)
        r = n1 / n2
        Me.TextBox3.Text = r

    End Sub
End Class
