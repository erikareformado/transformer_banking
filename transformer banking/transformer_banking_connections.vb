Public Class transformer_banking_connections
    Private Sub transformer_banking_connections_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_form()
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
        Home.lbl_connection_type.Text = "WYE-DELTA CONNECTION"
    End Sub

    Private Sub btn_open_delta_Click(sender As Object, e As EventArgs) Handles btn_open_delta.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_open_delta_intro)
        Home.lbl_connection_type.Text = "OPEN-DELTA CONNECTION"
    End Sub

    Private Sub btn_open_wye_Click(sender As Object, e As EventArgs) Handles btn_open_wye.Click
        Me.Hide()
        Home.Show()
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_openwye_opendelta_intro)
        Home.lbl_connection_type.Text = "OPEN WYE-OPEN DELTA CONNECTION"
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

    Public Sub refresh_form()
        Dim query As String
        query = "select a.id, a.connection, b.transformer_id 
	             from 
	             public.transformer_details as a
	             left join results_activity as b
	             on a.id =  b.transformer_id::integer
                where b.primary_phase_current is not null
	            and b.primary_line_current is not null
	            and b.primary_line_voltage is not null
	            and b.primary_phase_voltage is not null
	            and b.apparent_power is not null
	            and b.real_power is not null
	            and b.secondary_phase_current is not null
	            and b.secondary_line_current is not null
	            and b.secondary_line_voltage is not null
	            and b.secondary_phase_voltage is not null"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)





        For counter As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(counter)(1) = "WYE-WYE CONNECTION" Then
                btn_wye_wye.BackColor = Color.Maroon
                btn_wye_wye.Enabled = False

            ElseIf dt.Rows(counter)(1) = "DELTA-WYE CONNECTION" Then
                btn_delta_wye.BackColor = Color.Maroon
                btn_delta_wye.Enabled = False
            ElseIf dt.Rows(counter)(1) = "DELTA-DELTA CONNECTION" Then
                btn_delta_delta.BackColor = Color.Maroon
                btn_delta_delta.Enabled = False
            ElseIf dt.Rows(counter)(1) = "WYE-DELTA CONNECTION" Then
                btn_wye_delta.BackColor = Color.Maroon
                btn_wye_delta.Enabled = False
            ElseIf dt.Rows(counter)(1) = "OPEN-DELTA CONNECTION" Then
                btn_open_delta.BackColor = Color.Maroon
                btn_open_delta.Enabled = False
            ElseIf dt.Rows(counter)(1) = "OPEN WYE-OPEN DELTA CONNECTION" Then
                btn_open_wye.BackColor = Color.Maroon
                btn_open_wye.Enabled = False
            End If
        Next



    End Sub
End Class