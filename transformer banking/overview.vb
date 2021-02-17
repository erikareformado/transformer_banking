Public Class overview
    Private Sub PictureBox1_Introduction_Click(sender As Object, e As EventArgs) Handles PictureBox1_Introduction.Click
        Me.Hide()
        introduction_menu.Show()
    End Sub

    Private Sub PictureBox2_Objectives_Click(sender As Object, e As EventArgs) Handles PictureBox2_Objectives.Click
        Me.Hide()
        objective_menu.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        manual_menu.Show()
    End Sub

    Private Sub PictureBox4_Transformer_Click(sender As Object, e As EventArgs) Handles PictureBox4_Transformer.Click
        Me.Hide()
        transformer_banking_connections.Show()
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs)
        minimize(Me)
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        close_form()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub picturebox_minimize_Click(sender As Object, e As EventArgs) Handles picturebox_minimize.Click
        minimize(Me)
    End Sub

    Private Sub picturebox_close_Click(sender As Object, e As EventArgs) Handles picturebox_close.Click
        Close()
    End Sub
End Class