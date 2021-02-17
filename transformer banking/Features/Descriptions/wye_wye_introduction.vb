Public Class wye_wye_introduction
    Private Sub wye_wye_introduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_next_wye_Click(sender As Object, e As EventArgs) Handles btn_next_wye.Click
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_transformer_details)
    End Sub

    Private Sub btn_back_wye_Click(sender As Object, e As EventArgs) Handles btn_back_wye.Click
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub
End Class
