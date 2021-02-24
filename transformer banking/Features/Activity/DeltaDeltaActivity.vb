Imports System.Drawing.Drawing2D
Public Class DeltaDeltaActivity
    Dim appPath As String = Application.StartupPath()

    Dim delta_model As New delta_delta


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

    Dim vp As Integer ' for computation
    Dim category_1 As String 'primary/secondary
    Dim category_2 As String 'primary/secondary

    Dim color_str As String
    Dim btn_primary, btn_transformer As String

    Dim transformer_id As Integer

    Dim pens As New Pen(Color.Red, 2)

    Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
        draw_lines(e)
    End Sub

    Private Sub draw_lines(ByVal e As PaintEventArgs)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        get_point()
        Dim point_x, point_y As Point
        panel_activity.BringToFront()


        Dim count As Integer = 0
        Dim arry_color = delta_model.select_color(transformer_id)
        Dim colors_pen As String = ""
        For i As Integer = 0 To ctr_lines - 1

            count = count + 1


            If count = 1 Then
                point_x = points.Item(i)
                colors_pen = arry_color(i)
            ElseIf count = 2
                point_y = points.Item(i)
                If colors_pen = "" Then
                    colors_pen = arry_color(i)
                End If


                If colors_pen = "Red" Then
                    Dim pen_a = New Pen(Color.Red, 2)
                    e.Graphics.DrawLine(pen_a, point_x, point_y)
                ElseIf colors_pen = "Blue" Then
                    Dim pen_b = New Pen(Color.Blue, 2)
                    e.Graphics.DrawLine(pen_b, point_x, point_y)
                ElseIf colors_pen = "Yellow" Then
                    Dim pen_c = New Pen(Color.Yellow, 2)
                    e.Graphics.DrawLine(pen_c, point_x, point_y)
                ElseIf colors_pen = "Black" Then
                    Dim pen_n = New Pen(Color.Black, 2)
                    e.Graphics.DrawLine(pen_n, point_x, point_y)
                End If


                count = 0

            End If
        Next

    End Sub
    Public Sub get_point()
        Dim array_points = select_wye_wye_points(transformer_id)
        Dim count_points = select_count_wye_wye_points(transformer_id)
        ctr_lines = count_points
        points.Clear()

        For i As Integer = 0 To count_points - 1
            Dim value = array_points(i).ToString

            Dim split_value() As String = value.Split(",")
            Dim x = split_value(0)
            Dim y = split_value(1)
            Dim value_point As New Point(x, y)

            points.Add(value_point)
        Next
    End Sub


    Private Sub WyeWyeActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbopen()
        get_point()
        Dim result = search_transformer_id(lbl_polarity.Text, lbl_rating.Text, Home.lbl_connection_type.Text, lbl_primary_voltage.Text, lbl_secondary_voltage.Text)

        If result <> 0 Then
            transformer_id = result
        End If
        MsgBox(transformer_id.ToString)
        'transformer_id = search_transformer_id(lbl_polarity.Text, lbl_rating.Text, Home.lbl_connection_type.Text, lbl_primary_voltage.Text, lbl_secondary_voltage.Text)
        'select_clamp()
    End Sub
    Private Sub btn_prim_a1_Click(sender As Object, e As EventArgs) Handles btn_prim_a_1.Click, btn_prim_a_2.Click, btn_prim_a_3.Click, btn_prim_a_4.Click, btn_prim_a_5.Click, btn_prim_a_6.Click,
                                                                            btn_prim_b_1.Click, btn_prim_b_2.Click, btn_prim_b_3.Click, btn_prim_b_4.Click, btn_prim_b_5.Click, btn_prim_b_6.Click,
                                                                            btn_prim_c_1.Click, btn_prim_c_2.Click, btn_prim_c_3.Click, btn_prim_c_4.Click, btn_prim_c_5.Click, btn_prim_c_6.Click,
                                                                            btn_prim_n_1.Click, btn_prim_n_2.Click, btn_prim_n_3.Click, btn_prim_n_4.Click, btn_prim_n_5.Click, btn_prim_n_6.Click

        If wire_conenction = 1 Or clamp_meter = 1 Then
            Dim myButton As Button = CType(sender, Button)
            'category = "primary"
            btn_primary = myButton.Name

            Dim split_value() As String = btn_primary.Split("_")
            Dim btn_color = split_value(2).ToString
            Dim pen_color As String
            'MsgBox(color.ToString)
            If btn_color = "a" Then
                pen_color = "Red"
                primary = "a"
            ElseIf btn_color = "b"
                primary = "b"
                pen_color = "Blue"
            ElseIf btn_color = "c"
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
                category_1 = "primary"
                counter_1(myButton.Name, pen_color, clamp_meter)

            Else
                category_2 = "primary"
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


                        Dim b_location As New Point(b_x, b_y)
                        Dim r_location As New Point(r_x, r_y)
                        'picbox_clamp_meter.Location = panel_activity.Cursor.Position
                        pic_clamp_meter.Location = loc
                        btn_clamp_black.Location = b_location
                        btn_clamp_red.Location = r_location

                        pic_clamp_meter.Visible = True
                        btn_clamp_black.Visible = True
                        btn_clamp_red.Visible = True


                    Else
                        ctr_lines = ctr_lines - 2
                        points.RemoveAt(ctr_lines)
                        delta_model.delete_unwanted_connection()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()
                Else


                    If h_transformer = "btn_t1_h1" And primary = "a" Or h_transformer = "btn_t1_h2" And primary = "n" Or h_transformer = "btn_t2_h1" And primary = "b" Or h_transformer = "btn_t2_h2" And primary = "n" Or h_transformer = "btn_t3_h1" And primary = "c" Or h_transformer = "btn_t3_h2" And primary = "n" Then
                        counter_2(myButton.Name, pen_color, clamp_meter)
                    Else
                        ctr_lines = ctr_lines - 2
                        points.RemoveAt(ctr_lines)
                        delta_model.delete_unwanted_connection()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                    End If
                End If

                ctr = 0
                Me.Refresh()
                wire_conenction = 0
            End If
        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If

    End Sub

    'transformer primary
    Private Sub btn_t1_h1_Click(sender As Object, e As EventArgs) Handles btn_t1_h1.Click, btn_t1_h2.Click, btn_t2_h1.Click, btn_t2_h2.Click, btn_t3_h2.Click, btn_t3_h1.Click

        If wire_conenction = 1 Or clamp_meter = 1 Then

            Dim myButton As Button = CType(sender, Button)

            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            h_transformer = myButton.Name
            If ctr = 1 Then

                Dim color_pen As String = ""
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, color_pen, clamp_meter)

            Else
                If clamp_meter = 1 Then
                    If h_transformer = "btn_t1_h1" And primary = "a" And clamp_meter = 1 Or h_transformer = "btn_t2_h1" And primary = "b" And clamp_meter = 1 Or h_transformer = "btn_t3_h1" And primary = "c" And clamp_meter = 1 Then
                        counter_2(myButton.Name, "", clamp_meter)

                        Dim x_point = (point_1.X / 2) + (point_2.X / 2) - 30
                        Dim y_point = (point_1.Y / 2) + (point_2.Y / 2)

                        Dim loc As New Point(x_point, y_point)

                        Dim b_x = loc.X + 41
                        Dim b_y = loc.Y + 13

                        Dim r_x = loc.X + 41
                        Dim r_y = loc.Y + 37


                        Dim b_location As New Point(b_x, b_y)
                        Dim r_location As New Point(r_x, r_y)

                        pic_clamp_meter.Location = loc
                        btn_clamp_black.Location = b_location
                        btn_clamp_red.Location = r_location


                    Else
                        ctr_lines = ctr_lines - 2
                        points.RemoveAt(ctr_lines)
                        delta_model.delete_unwanted_connection()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()
                Else

                    If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t2_h2" And voltage = "vpblack" Then
                        counter_2(myButton.Name, "", "3")
                    ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t1_h2" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                        counter_2(myButton.Name, "", "4")

                    ElseIf h_transformer = "btn_t1_h1" And primary = "a" Or h_transformer = "btn_t1_h2" And primary = "n" Or h_transformer = "btn_t2_h1" And primary = "b" Or h_transformer = "btn_t2_h2" And primary = "n" Or h_transformer = "btn_t3_h1" And primary = "c" Or h_transformer = "btn_t3_h2" And primary = "n" Then
                        counter_2(myButton.Name, "", clamp_meter)
                    Else
                        ctr_lines = ctr_lines - 2
                        points.RemoveAt(ctr_lines)
                        delta_model.delete_unwanted_connection()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                End If

                ctr = 0
                Me.Refresh()
                wire_conenction = 0

            End If
        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If
    End Sub

    Private Sub counter_1(btn_name, pen_color, clamp)

        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        point_1 = New Point(point1_x, point1_y)

        Dim result = delta_model.save_points(btn_name, point1_x & "," & point1_y, pen_color, clamp, transformer_id)
        If result <> "1" Then
            MsgBox(result.ToString)
        End If

    End Sub
    Private Sub counter_2(btn_name, pen_color, clamp)

        point2_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point2_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2
        point_2 = New Point(point2_x, point2_y)

        Dim result = delta_model.save_points(btn_name, point2_x & "," & point2_y, pen_color, clamp, transformer_id)

        If result <> "1" Then
            MsgBox(result.ToString)
        End If

    End Sub

    Private Sub btn_connect_wires_Click(sender As Object, e As EventArgs) Handles btn_connect_wires.Click   'wire connection
        wire_conenction = 1
        If ctr = 1 Then
            ctr = 0
            ctr_lines = ctr_lines - 1
            delta_model.delete_unwanted_connection()
        Else

        End If
    End Sub
End Class
