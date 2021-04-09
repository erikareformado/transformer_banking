Public Class EditTransformer
    Dim id As Integer
    Dim connection As String
    Private Sub EditTransformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
    Private Sub txt_secondary_voltage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_secondary_voltage.KeyPress, txt_primary_voltage.KeyPress
        If (Not e.KeyChar = ChrW(Keys.Back) And ("0123456789.").IndexOf(e.KeyChar) = -1) Then
            e.Handled = True
        End If
    End Sub
    Public Sub get_details(primary, secondary, polarity, rating, transformer_id, home_connection)
        txt_primary_voltage.Text = primary
        txt_secondary_voltage.Text = secondary
        cmb_polarity.Text = polarity
        cmb_rating.Text = rating
        id = transformer_id
        connection = home_connection
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Dim results As DialogResult = MsgBox("Are you sure to update?", MsgBoxStyle.YesNo, "Disconnect Wire")
        If results = DialogResult.Yes Then
            Dim result = save_transformer_details(cmb_polarity.Text, cmb_rating.Text, connection, txt_primary_voltage.Text, txt_secondary_voltage.Text)
            If result = "1" Then

                If connection = "WYE-WYE CONNECTION" Then
                    Home.uc_wye_wye_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_wye_wye_activity.additive(cmb_polarity.Text)
                ElseIf connection = "DELTA-WYE CONNECTION" Then
                    'uc_delta_wye_activity
                    Home.uc_delta_wye_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_delta_wye_activity.additive(cmb_polarity.Text)
                ElseIf connection = "DELTA-DELTA CONNECTION" Then
                    'uc_delta_delta_activity
                    Home.uc_delta_delta_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_delta_delta_activity.additive(cmb_polarity.Text)
                ElseIf connection = "WYE-DELTA CONNECTION" Then
                    'uc_wye_delta_activity
                    Home.uc_wye_delta_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_wye_delta_activity.additive(cmb_polarity.Text)
                ElseIf connection = "OPEN-DELTA CONNECTION" Then
                    'uc_open_delta_activity
                    Home.uc_open_delta_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_open_delta_activity.additive(cmb_polarity.Text)
                ElseIf connection = "OPEN WYE-OPEN DELTA CONNECTION" Then
                    'uc_open_wye_open_delta_activity
                    Home.uc_open_wye_open_delta_activity.update_transformer(cmb_polarity.Text, cmb_rating.Text, txt_primary_voltage.Text, txt_secondary_voltage.Text)
                    Home.uc_open_wye_open_delta_activity.additive(cmb_polarity.Text)

                End If
                MsgBox("Transformer details was successfully updated.", MsgBoxStyle.Information, "EDIT TRANSFORMER")
                'update_transformer()

            End If
        End If
    End Sub


    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
End Class