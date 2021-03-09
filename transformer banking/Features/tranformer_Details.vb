Public Class tranformer_Details

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click

        If cmb_polarity.Text = "" Then
            MsgBox("Please Select Polarity!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Select Rating!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Input Frequency!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf cmb_rating.Text = "" Then
            MsgBox("Please Input Frequency!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf txt_primary_voltage.Text = ""
            MsgBox("Please Input Primary Voltage!", MsgBoxStyle.Exclamation, "Transformer Banking")
        ElseIf txt_secondary_voltage.Text = ""
            MsgBox("Please Input Secondary Voltage!", MsgBoxStyle.Exclamation, "Transformer Banking")
        Else

            If Home.lbl_connection_type.Text = "WYE-WYE CONNECTION" Then

                Home.uc_wye_wye_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_wye_wye_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_wye_wye_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_wye_wye_activity.lbl_rating.Text = cmb_rating.Text

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_wye_wye_activity)
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

                Home.uc_delta_wye_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_delta_wye_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_delta_wye_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_delta_wye_activity.lbl_rating.Text = cmb_rating.Text


                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_delta_wye_activity)
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


                Home.uc_delta_delta_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_delta_delta_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_delta_delta_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_delta_delta_activity.lbl_rating.Text = cmb_rating.Text

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_delta_delta_activity)

                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_delta_delta_activity.Label21.Text = "X2"
                    Home.uc_delta_delta_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_delta_delta_activity.Label22.Text = "X1"
                    Home.uc_delta_delta_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_delta_delta_activity.Label24.Text = "X2"
                    Home.uc_delta_delta_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_delta_delta_activity.Label23.Text = "X1"
                    Home.uc_delta_delta_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_delta_delta_activity.Label26.Text = "X2"
                    Home.uc_delta_delta_activity.btn_t3_x1.Name = "btn_t3_x2"
                    Home.uc_delta_delta_activity.btn_t3_x2.Name = "btn_t3_x1"
                    Home.uc_delta_delta_activity.Label25.Text = "X1"


                End If
            ElseIf Home.lbl_connection_type.Text = "WYE-DELTA CONNECTION" Then

                Home.uc_wye_delta_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_wye_delta_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_wye_delta_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_wye_delta_activity.lbl_rating.Text = cmb_rating.Text

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_wye_delta_activity)
                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_wye_delta_activity.Label21.Text = "X2"
                    Home.uc_wye_delta_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_wye_delta_activity.Label22.Text = "X1"
                    Home.uc_wye_delta_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_wye_delta_activity.Label24.Text = "X2"
                    Home.uc_wye_delta_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_wye_delta_activity.Label23.Text = "X1"
                    Home.uc_wye_delta_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_wye_delta_activity.Label26.Text = "X2"
                    Home.uc_wye_delta_activity.btn_t3_x1.Name = "btn_t3_x2"
                    Home.uc_wye_delta_activity.btn_t3_x2.Name = "btn_t3_x1"
                    Home.uc_wye_delta_activity.Label25.Text = "X1"
                End If
            ElseIf Home.lbl_connection_type.Text = "OPEN-DELTA CONNECTION" Then
                Home.uc_open_delta_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_open_delta_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_open_delta_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_open_delta_activity.lbl_rating.Text = cmb_rating.Text

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_open_delta_activity)
                If Home.uc_transformer_details.cmb_polarity.Text = "Additive" Then
                    Home.uc_open_delta_activity.Label21.Text = "X2"
                    Home.uc_open_delta_activity.btn_t1_x1.Name = "btn_t1_x2"
                    Home.uc_open_delta_activity.Label22.Text = "X1"
                    Home.uc_open_delta_activity.btn_t1_x2.Name = "btn_t1_x1"
                    Home.uc_open_delta_activity.Label24.Text = "X2"
                    Home.uc_open_delta_activity.btn_t2_x1.Name = "btn_t2_x2"
                    Home.uc_open_delta_activity.Label23.Text = "X1"
                    Home.uc_open_delta_activity.btn_t2_x2.Name = "btn_t2_x1"
                    Home.uc_open_delta_activity.Label26.Text = "X2"
                    Home.uc_open_delta_activity.Label25.Text = "X1"
                End If
            ElseIf Home.lbl_connection_type.Text = "OPEN WYE-OPEN DELTA CONNECTION" Then
                Home.uc_open_wye_open_delta_activity.lbl_primary_voltage.Text = txt_primary_voltage.Text
                Home.uc_open_wye_open_delta_activity.lbl_secondary_voltage.Text = txt_secondary_voltage.Text
                Home.uc_open_wye_open_delta_activity.lbl_polarity.Text = cmb_polarity.Text
                Home.uc_open_wye_open_delta_activity.lbl_rating.Text = cmb_rating.Text

                Home.panel_all.Controls.Clear()
                Home.panel_all.Controls.Add(Home.uc_open_wye_open_delta_activity)
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
            End If
            Dim result = save_transformer_details(cmb_polarity.Text, cmb_rating.Text, Home.lbl_connection_type.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub


    Private Sub tranformer_Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_primary_voltage.Text = "250"
        txt_secondary_voltage.Text = "30"
    End Sub
End Class
