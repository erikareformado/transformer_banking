Public Class manual_menu
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        overview.Show()
    End Sub

    Private Sub manual_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox_Legend.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox_Legend.Hide()
        RichTextBox_Manual.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        RichTextBox_Manual.Hide()
        PictureBox_Legend.Show()
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
End Class