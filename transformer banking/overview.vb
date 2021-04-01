Public Class overview
    Dim exercise As New exercise_details()
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
        Home.action = "activity"
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

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        Home.Show()
        Home.action = "exercises"
        Home.panel_all.Controls.Clear()
        Home.panel_all.Controls.Add(Home.uc_transformer_details)
        Home.exam_no = exercise.get_exercise_no()
        Home.lbl_connection_type.Text = "Exercise " & Home.exam_no

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

        Dim connections_done As Boolean
        For counter As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(counter)(1) = "WYE-WYE CONNECTION" And
             dt.Rows(counter)(1) = "DELTA-WYE CONNECTION" And
             dt.Rows(counter)(1) = "DELTA-DELTA CONNECTION" And
             dt.Rows(counter)(1) = "WYE-DELTA CONNECTION" And
             dt.Rows(counter)(1) = "OPEN-DELTA CONNECTION" And
             dt.Rows(counter)(1) = "OPEN WYE-OPEN DELTA CONNECTION" Then
                connections_done = True
            Else
                connections_done = False
                Exit For
            End If
        Next
        If connections_done = True Then
            PictureBox4_Transformer.BackColor = Color.Maroon
            PictureBox4_Transformer.Enabled = False
        End If



    End Sub

    Private Sub overview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_form()
    End Sub
End Class