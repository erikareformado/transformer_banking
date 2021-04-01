Imports System.Drawing.Drawing2D
Public Class Exercises
    Dim exercise As New exercise_details
    Dim no As Integer

    Dim appPath As String = Application.StartupPath()


    Dim result_model As New results_activity
    Dim table As String

    Dim ctr As Integer = 0
    Dim ctr_lines As Integer = 0
    Dim ctr_points As Integer = 0
    Dim ctr_switch As Integer = 0

    Dim switch As Integer = 0

    Dim point1_x As Integer
    Dim point1_y As Integer

    Dim point2_x As Integer
    Dim point2_y As Integer

    Dim point_1 As Point
    Dim point_2 As Point

    Dim points As New List(Of Point)

    Dim arry_clam_meter As New List(Of String)

    Dim primary, h_transformer As String
    Dim secondary, x_transformer As String
    Dim clamp, current, voltage, bulb As String

    Dim btn_remove As New Button()

    Dim clamp_meter As Integer = 0
    Dim wire_conenction As Integer = 0

    Dim color_str As String
    Dim btn_primary, btn_transformer As String

    Dim transformer_id As Integer
    Dim done As Integer
    Dim pens As New Pen(Color.Red, 2)

    Private Sub Exercises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_form()
    End Sub
    Private Sub btn_prim_a_1_Click(sender As Object, e As EventArgs) Handles btn_prim_a_1.Click, btn_prim_a_2.Click, btn_prim_a_3.Click, btn_prim_a_4.Click, btn_prim_a_5.Click, btn_prim_a_6.Click,
                                                                            btn_prim_b_1.Click, btn_prim_b_2.Click, btn_prim_b_3.Click, btn_prim_b_4.Click, btn_prim_b_5.Click, btn_prim_b_6.Click,
                                                                            btn_prim_c_1.Click, btn_prim_c_2.Click, btn_prim_c_3.Click, btn_prim_c_4.Click, btn_prim_c_5.Click, btn_prim_c_6.Click,
                                                                            btn_prim_n_1.Click, btn_prim_n_2.Click, btn_prim_n_3.Click, btn_prim_n_4.Click, btn_prim_n_5.Click, btn_prim_n_6.Click

        If wire_conenction = 1 Or clamp_meter = 1 Then
            Dim myButton As Button = CType(sender, Button)

            btn_primary = myButton.Name

            Dim split_value() As String = btn_primary.Split("_")
            Dim btn_color = split_value(2).ToString
            Dim pen_color As String
            primary = ""

            If btn_color = "a" Then
                pen_color = "Red"
                primary = "a"
            ElseIf btn_color = "b" Then
                primary = "b"
                pen_color = "Blue"
            ElseIf btn_color = "c" Then
                primary = "c"
                pen_color = "Yellow"
            Else btn_color = "n"
                primary = "n"
                pen_color = "Black"
            End If

            ctr = ctr + 1
            ctr_lines = ctr_lines + 1
            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, clamp_meter)

            Else
                If clamp_meter = 1 Then
                    If h_transformer = "btn_t1_h1" And primary = "a" And clamp_meter = 1 Or h_transformer = "btn_t2_h1" And primary = "b" And clamp_meter = 1 Or h_transformer = "btn_t3_h1" And primary = "c" And clamp_meter = 1 Then
                        counter_2(myButton.Name, pen_color, clamp_meter)

                        Dim x_point = (point_1.X / 2) + (point_2.X / 2) - 30
                        Dim y_point = (point_1.Y / 2) + (point_2.Y / 2)

                        Dim loc As New Point(x_point, y_point)

                        Dim b_x = loc.X + 41
                        Dim b_y = loc.Y + 13

                        Dim r_x = loc.X + 41
                        Dim r_y = loc.Y + 37

                        pic_clamp_meter.Visible = True
                        btn_clamp_black.Visible = True
                        btn_clamp_red.Visible = True

                        Dim b_location As New Point(b_x, b_y)
                        Dim r_location As New Point(r_x, r_y)
                        'picbox_clamp_meter.Location = panel_activity.Cursor.Position
                        pic_clamp_meter.Location = loc
                        btn_clamp_black.Location = b_location
                        btn_clamp_red.Location = r_location
                    Else
                        delete_unwanted_connection(transformer_id, table)
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    panel_activity.Refresh()
                Else
                    counter_2(myButton.Name, pen_color, clamp_meter)
                End If
                ctr = 0
                panel_activity.Refresh()
                wire_conenction = 0
            End If
        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If
    End Sub

#Region "sub"
    Public Sub refresh_form()
        no = Home.exam_no
        Dim test = exercise.exercise_questions(no)
        txt_exam.Text = test

        table = "exercise_lines"
    End Sub
    Private Sub counter_1(btn_name, pen_color, clamp)

        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        point_1 = New Point(point1_x, point1_y)

        Dim result = exercise.save_points(btn_name, point1_x & "," & point1_y, pen_color, clamp, transformer_id, table)
        If result <> "1" Then
            MsgBox(result.ToString)
        End If
    End Sub
    Private Sub counter_2(btn_name, pen_color, clamp)

        point2_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point2_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2
        point_2 = New Point(point2_x, point2_y)

        Dim result = save_points(btn_name, point2_x & "," & point2_y, pen_color, clamp, transformer_id, table)

        If result <> "1" Then
            MsgBox(result.ToString)
        End If
    End Sub
#End Region

End Class
