Public Class delta_delta_introduction
    Private Sub btn_nxt_Click(sender As Object, e As EventArgs)
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_transformer_details)
    End Sub
    Private Sub btn_back_Click(sender As Object, e As EventArgs)
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub
End Class
