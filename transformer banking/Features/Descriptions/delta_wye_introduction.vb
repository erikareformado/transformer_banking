Public Class delta_wye_introduction
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        RichTextBox1.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        RichTextBox1.Show()
    End Sub

    Private Sub btn_next_wye_Click(sender As Object, e As EventArgs) Handles btn_next_wye.Click
        Home.panel_all.Controls.Clear()
        Home.uc_transformer_details.refresh_form()
        Home.panel_all.Controls.Add(Home.uc_transformer_details)
    End Sub

    Private Sub btn_back_wye_Click(sender As Object, e As EventArgs) Handles btn_back_wye.Click
        Home.Hide()
        Home.uc_transformer_details.refresh_form()
        transformer_banking_connections.Show()
    End Sub
End Class
