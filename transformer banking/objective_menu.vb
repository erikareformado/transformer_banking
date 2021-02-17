Public Class objective_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        overview.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        overview.Show()
    End Sub

    Private Sub picturebox_minimize_Click(sender As Object, e As EventArgs) Handles picturebox_minimize.Click
        minimize(Me)
    End Sub

    Private Sub picturebox_close_Click(sender As Object, e As EventArgs) Handles picturebox_close.Click
        Close()
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class