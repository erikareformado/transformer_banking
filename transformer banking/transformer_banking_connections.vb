Public Class transformer_banking_connections
    Private Sub transformer_banking_connections_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_wye_wye_Click(sender As Object, e As EventArgs) Handles btn_wye_wye.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_wye_wye_intro)
        Home.lbl_connection_type.Text = "WYE-WYE CONNECTION"

    End Sub
    Private Sub btn_delta_wye_Click(sender As Object, e As EventArgs) Handles btn_delta_wye.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_delta_wye_intro)
        Home.lbl_connection_type.Text = "DELTA-WYE CONNECTION"

    End Sub

    Private Sub btn_delta_delta_Click(sender As Object, e As EventArgs) Handles btn_delta_delta.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_delta_delta_intro)
        Home.lbl_connection_type.Text = "DELTA-DELTA CONNECTION"
    End Sub

    Private Sub btn_wye_delta_Click(sender As Object, e As EventArgs) Handles btn_wye_delta.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_wye_delta_intro)
    End Sub

    Private Sub btn_open_delta_Click(sender As Object, e As EventArgs) Handles btn_open_delta.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_open_delta_intro)
    End Sub

    Private Sub btn_open_wye_Click(sender As Object, e As EventArgs) Handles btn_open_wye.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_openwye_opendelta_intro)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles picturebox_close.Click
        Close()
    End Sub

    Private Sub picturebox_minimize_Click(sender As Object, e As EventArgs) Handles picturebox_minimize.Click
        minimize(Me)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        overview.Show()
    End Sub
End Class