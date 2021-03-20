Public Class tranformer_Details
    Dim exercise As New exercise_transformer_details
    'Dim exercises As New exercises
    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click



        If cmb_polarity.Text = "" Then
            MsgBox("Please Select Polarity!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Select Rating!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Input Frequency!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Input Frequency!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf txt_primary_voltage.Text = "" Then
            MsgBox("Please Input Primary Voltage!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf txt_secondary_voltage.Text = "" Then
            MsgBox("Please Input Secondary Voltage!", MsgBoxStyle.Exclamation, "Transformer Banking")
        Else
            If Home.action = "activity" Then
                Dim result = save_transformer_details(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
            Else
                'Dim no = exercises.get_exercise_no()
                'Dim result = exercise.save_transformer_details(cmb_polarity.Text, cmb_rating.Text, no, txt_primary_voltage.Text, txt_secondary_voltage.Text)

            End If
            If Home.lbl_connection_type.Text = "WYE-WYE CONNECTION" Then
                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_wye_wye_activity)


                Home.uc_wye_wye_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_wye_wye_activity.Label21.Text = "X2"
                    Home.uc_wye_wye_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_wye_wye_activity.Label22.Text = "X1"
                    Home.uc_wye_wye_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_wye_wye_activity.Label24.Text = "X2"
                    Home.uc_wye_wye_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_wye_wye_activity.Label23.Text = "X1"
                    Home.uc_wye_wye_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_wye_wye_activity.Label26.Text = "X2"
                    Home.uc_wye_wye_activity.btn_t3_x1.Name = "btn_t3_x2"
                    Home.uc_wye_wye_activity.btn_t3_x2.Name = "btn_t3_x1"
                    Home.uc_wye_wye_activity.Label25.Text = "X1"
                End If
            ElseIf Home.lbl_connection_type.Text = "DELTA-WYE CONNECTION" Then

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_delta_wye_activity)
                Home.uc_delta_wye_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then

                    Home.uc_delta_wye_activity.Label21.Text = "X2"
                    Home.uc_delta_wye_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_delta_wye_activity.Label22.Text = "X1"
                    Home.uc_delta_wye_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_delta_wye_activity.Label24.Text = "X2"
                    Home.uc_delta_wye_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_delta_wye_activity.Label23.Text = "X1"
                    Home.uc_delta_wye_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_delta_wye_activity.Label26.Text = "X2"
                    Home.uc_delta_wye_activity.btn_t3_x1.Name = "btn_t3_x2"
                    Home.uc_delta_wye_activity.btn_t3_x2.Name = "btn_t3_x1"
                    Home.uc_delta_wye_activity.Label25.Text = "X1"
                End If
            ElseIf Home.lbl_connection_type.Text = "DELTA-DELTA CONNECTION" Then

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_delta_delta_activity)

                Home.uc_delta_delta_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    additive_delta_properties()


                End If
            ElseIf Home.lbl_connection_type.Text = "WYE-DELTA CONNECTION" Then

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_wye_delta_activity)
                Home.uc_wye_delta_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    additive_delta_properties()
                End If
            ElseIf Home.lbl_connection_type.Text = "OPEN-DELTA CONNECTION" Then


                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_open_delta_activity)
                Home.uc_open_delta_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    additive_delta_properties()
                End If
            ElseIf Home.lbl_connection_type.Text = "OPEN WYE-OPEN DELTA CONNECTION" Then


                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_open_wye_open_delta_activity)
                Home.uc_open_wye_open_delta_activity.refresh_form(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_open_wye_open_delta_activity.Label21.Text = "X2"
                    Home.uc_open_wye_open_delta_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_open_wye_open_delta_activity.Label22.Text = "X1"
                    Home.uc_open_wye_open_delta_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_open_wye_open_delta_activity.Label24.Text = "X2"
                    Home.uc_open_wye_open_delta_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_open_wye_open_delta_activity.Label23.Text = "X1"
                    Home.uc_open_wye_open_delta_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_open_wye_open_delta_activity.Label26.Text = "X2"
                    Home.uc_open_wye_open_delta_activity.Label25.Text = "X1"
                End If
            Else
                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_exercises)
                Home.lbl_connection_type.Text = "Exercise " & Home.exam_no

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_exercises.Label21.Text = "X2"
                    Home.uc_exercises.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_exercises.Label22.Text = "X1"
                    Home.uc_exercises.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_exercises.Label24.Text = "X2"
                    Home.uc_exercises.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_exercises.Label23.Text = "X1"
                    Home.uc_exercises.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_exercises.Label26.Text = "X2"
                    Home.uc_exercises.Label25.Text = "X1"
                End If

            End If



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub


    Private Sub tranformer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_primary_voltage.Text = "250"
        txt_secondary_voltage.Text = "30"
        refresh_form()
    End Sub

    Public Sub refresh_form()
        Me.Controls.Clear()
        InitializeComponent()
    End Sub

    Private Sub additive_delta_properties()
        Dim blue_1 As New Point(106, 293)
        Dim blue_2 As New Point(301, 293)

        Dim red_1 As New Point(156, 291)
        Dim red_2 As New Point(400, 291)

        Dim yellow_1 As New Point(252, 288)
        Dim yellow_2 As New Point(451, 288)


        Home.uc_wye_delta_activity.Label21.Text = "X2"
        Home.uc_wye_delta_activity.Label21.BringToFront()
        Home.uc_wye_delta_activity.btn_t1_x1.Name = "btn_t1_x2"

        Home.uc_wye_delta_activity.btn_t1_x1.Location = blue_1
        Home.uc_wye_delta_activity.Label22.Text = "X1"
        Home.uc_wye_delta_activity.Label22.BringToFront()

        Home.uc_wye_delta_activity.btn_t1_x2.Name = "btn_t1_x1"
        Home.uc_wye_delta_activity.btn_t1_x2.Location = red_1
        Home.uc_wye_delta_activity.Label24.Text = "X2"
        Home.uc_wye_delta_activity.Label24.BringToFront()

        Home.uc_wye_delta_activity.btn_t2_x1.Name = "btn_t2_x2"
        Home.uc_wye_delta_activity.btn_t2_x1.Location = yellow_1
        Home.uc_wye_delta_activity.Label23.Text = "X1"
        Home.uc_wye_delta_activity.Label23.BringToFront()

        Home.uc_wye_delta_activity.btn_t2_x2.Name = "btn_t2_x1"
        Home.uc_wye_delta_activity.btn_t2_x2.Location = blue_2
        Home.uc_wye_delta_activity.Label26.Text = "X2"
        Home.uc_wye_delta_activity.Label26.BringToFront()

        Home.uc_wye_delta_activity.btn_t3_x1.Name = "btn_t3_x2"
        Home.uc_wye_delta_activity.btn_t3_x1.Location = red_2

        Home.uc_wye_delta_activity.btn_t3_x2.Name = "btn_t3_x1"
        Home.uc_wye_delta_activity.btn_t3_x2.Location = yellow_2
        Home.uc_wye_delta_activity.Label25.Text = "X1"
        Home.uc_wye_delta_activity.Label25.BringToFront()
    End Sub

End Class
