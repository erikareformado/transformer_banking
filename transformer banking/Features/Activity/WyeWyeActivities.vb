Imports System.Drawing.Drawing2D
Public Class WyeWyeActivities
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

    Dim vp As Integer ' for computation
    Dim category_1 As String 'primary/secondary
    Dim category_2 As String 'primary/secondary

    Dim color_str As String
    Dim btn_primary, btn_transformer As String

    Dim transformer_id As Integer
    Dim done As Integer

    Dim pens As New Pen(Color.Red, 2)
    Private Sub WyeWyeActivities_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbopen()
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
            primary = ""

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
            'get_points_primary()

            'point1_x = panel_activity.Controls.Item(myButton.Name).Location.X + panel_activity.Controls.Item(myButton.Name).Width / 2
            'point1_y = panel_activity.Controls.Item(myButton.Name).Location.Y + panel_activity.Controls.Item(myButton.Name).Height / 2

            'TextBox3.Text = "{x=" & point1_x.ToString & ",y=" & point1_y.ToString & "}"
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
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()
                Else


                    If h_transformer = "btn_t1_h1" And primary = "a" Or h_transformer = "btn_t1_h2" And primary = "n" Or h_transformer = "btn_t2_h1" And primary = "b" Or h_transformer = "btn_t2_h2" And primary = "n" Or h_transformer = "btn_t3_h1" And primary = "c" Or h_transformer = "btn_t3_h2" And primary = "n" Then
                        counter_2(myButton.Name, pen_color, clamp_meter)
                    Else
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                    End If
                End If
                'If category_1 = category_2 Then
                '    ctr_lines = ctr_lines - 2
                '    points.RemoveAt(ctr_lines)
                '    MsgBox("Cannot Connect! Please select other connection.", MsgBoxStyle.Exclamation)
                'Else
                '    counter_2(myButton.Name, pen_color)
                'End If
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
            'Dim myName As String =
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            h_transformer = myButton.Name
            If ctr = 1 Then

                Dim color_pen As String = ""
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, color_pen, clamp_meter)
                voltage = ""

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
                        'picbox_clamp_meter.Location = panel_activity.Cursor.Position
                        pic_clamp_meter.Location = loc
                        btn_clamp_black.Location = b_location
                        btn_clamp_red.Location = r_location

                        pic_clamp_meter.Visible = True
                        btn_clamp_black.Visible = True
                        btn_clamp_red.Visible = True


                    Else
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()
                Else

                    If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or x_transformer = "btn_t1_x1" And voltage = "vpred" Or x_transformer = "btn_t1_x2" And voltage = "vpblack" Then
                        update_clamp_no("3", transformer_id, table)
                        counter_2(myButton.Name, "", "3")
                    ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t2_h1" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                        update_clamp_no("3", transformer_id, table)
                        counter_2(myButton.Name, "", "4")

                    ElseIf h_transformer = "btn_t1_h1" And primary = "a" Or h_transformer = "btn_t1_h2" And primary = "n" Or h_transformer = "btn_t2_h1" And primary = "b" Or h_transformer = "btn_t2_h2" And primary = "n" Or h_transformer = "btn_t3_h1" And primary = "c" Or h_transformer = "btn_t3_h2" And primary = "n" Then
                        counter_2(myButton.Name, "", clamp_meter)
                    Else
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        get_point()
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
    'secondary
    Private Sub btn_sec_n_1_Click(sender As Object, e As EventArgs) Handles btn_sec_n_1.Click, btn_sec_n_2.Click, btn_sec_n_3.Click, btn_sec_n_4.Click, btn_sec_n_5.Click, btn_sec_n_6.Click,
                                            btn_sec_l1_1.Click, btn_sec_l1_2.Click, btn_sec_l1_3.Click, btn_sec_l1_4.Click, btn_sec_l1_5.Click, btn_sec_l1_6.Click,
                                            btn_sec_l2_1.Click, btn_sec_l2_2.Click, btn_sec_l2_3.Click, btn_sec_l2_4.Click, btn_sec_l2_5.Click, btn_sec_l2_6.Click,
                                            btn_sec_l3_1.Click, btn_sec_l3_2.Click, btn_sec_l3_3.Click, btn_sec_l3_4.Click, btn_sec_l3_5.Click, btn_sec_l3_6.Click
        If wire_conenction = 1 Or clamp_meter = 1 Then
            Dim myButton As Button = CType(sender, Button)
            'category = "primary"
            btn_primary = myButton.Name
            Dim split_value() As String = btn_primary.Split("_")
            Dim btn_color = split_value(2).ToString
            Dim pen_color As String
            'MsgBox(color.ToString)
            secondary = ""
            If btn_color = "n" Then
                pen_color = "Black"
                secondary = "n"
            ElseIf btn_color = "l1"
                secondary = "l1"
                pen_color = "Red"
            ElseIf btn_color = "l2"
                secondary = "l2"
                pen_color = "Blue"
            Else btn_color = "l3"
                secondary = "l3"
                pen_color = "Yellow"
            End If
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, clamp_meter)

            Else
                If clamp_meter = 1 Then
                    If x_transformer = "btn_t1_x1" And secondary = "l1" Or x_transformer = "btn_t2_x1" And secondary = "l2" Or x_transformer = "btn_t3_x1" And secondary = "l3" Then
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
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        get_point()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()

                Else
                    If secondary = "l1" And bulb = "l1red" Or secondary = "n" And bulb = "l1black" Or secondary = "l2" And bulb = "l2red" Or secondary = "n" And bulb = "l2black" Or secondary = "l3" And bulb = "l3red" Or secondary = "n" And bulb = "l3black" Then
                        counter_2(myButton.Name, "", "5")
                    ElseIf x_transformer = "btn_t1_x1" And secondary = "l1" Or x_transformer = "btn_t1_x2" And secondary = "n" Or x_transformer = "btn_t2_x1" And secondary = "l2" Or x_transformer = "btn_t2_x2" And secondary = "n" Or x_transformer = "btn_t3_x1" And secondary = "l3" Or x_transformer = "btn_t3_x2" And secondary = "n" Then
                        counter_2(myButton.Name, pen_color, clamp_meter)
                    Else

                        delete_unwanted_connection(transformer_id, table)
                        get_point()
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
    Private Sub btn_sec_n_6_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_sec_n_1.MouseDown, btn_sec_n_2.MouseDown, btn_sec_n_3.MouseDown, btn_sec_n_4.MouseDown, btn_sec_n_5.MouseDown, btn_sec_n_6.MouseDown,
                                            btn_sec_l1_1.MouseDown, btn_sec_l1_2.MouseDown, btn_sec_l1_3.MouseDown, btn_sec_l1_4.MouseDown, btn_sec_l1_5.MouseDown, btn_sec_l1_6.MouseDown,
                                            btn_sec_l2_1.MouseDown, btn_sec_l2_2.MouseDown, btn_sec_l2_3.MouseDown, btn_sec_l2_4.MouseDown, btn_sec_l2_5.MouseDown, btn_sec_l2_6.MouseDown,
                                            btn_sec_l3_1.MouseDown, btn_sec_l3_2.MouseDown, btn_sec_l3_3.MouseDown, btn_sec_l3_4.MouseDown, btn_sec_l3_5.MouseDown, btn_sec_l3_6.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    delete_connections(btn, transformer_id, table)
                    get_point()
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        Me.Refresh()

    End Sub
    'transformer secondary
    Private Sub btn_t1_x1_Click(sender As Object, e As EventArgs) Handles btn_t1_x1.Click, btn_t1_x2.Click, btn_t2_x1.Click, btn_t2_x2.Click, btn_t3_x1.Click, btn_t3_x2.Click
        If wire_conenction = 1 Or clamp_meter = 1 Then
            Dim myButton As Button = CType(sender, Button)
            'Dim myName As String =
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            x_transformer = myButton.Name
            If ctr = 1 Then

                Dim color_pen As String = ""
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, color_pen, clamp_meter)

            Else
                If clamp_meter = 1 Then
                    If x_transformer = "btn_t1_x1" And secondary = "l1" Or x_transformer = "btn_t2_x1" And secondary = "l2" Or x_transformer = "btn_t3_x1" And secondary = "l3" Then
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
                        'picbox_clamp_meter.Location = panel_activity.Cursor.Position
                        pic_clamp_meter.Location = loc
                        btn_clamp_black.Location = b_location
                        btn_clamp_red.Location = r_location

                        pic_clamp_meter.Visible = True
                        btn_clamp_black.Visible = True
                        btn_clamp_red.Visible = True


                    Else
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        get_point()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()

                Else

                    category_2 = "primary"
                    If x_transformer = "btn_t1_x1" And secondary = "l1" Or x_transformer = "btn_t1_x2" And secondary = "n" Or x_transformer = "btn_t2_x1" And secondary = "l2" Or x_transformer = "btn_t2_x2" And secondary = "n" Or x_transformer = "btn_t3_x1" And secondary = "l3" Or x_transformer = "btn_t3_x2" And secondary = "n" Then

                        counter_2(myButton.Name, "", clamp_meter)
                    ElseIf h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or x_transformer = "btn_t1_x1" And voltage = "vpred" Or x_transformer = "btn_t1_x2" And voltage = "vpblack" Then
                        update_clamp_no("3", transformer_id, table)
                        counter_2(myButton.Name, "", "3")

                    ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t1_h2" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                        update_clamp_no("4", transformer_id, table)
                        counter_2(myButton.Name, "", "4")
                    Else
                        'ctr_lines = ctr_lines - 2
                        'points.RemoveAt(ctr_lines)
                        delete_unwanted_connection(transformer_id, table)
                        get_point()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                End If


                'If category_1 = category_2 Then
                '    ctr_lines = ctr_lines - 2
                '    points.RemoveAt(ctr_lines)
                '    delete_unwanted_connection()
                '    MsgBox("Cannot Connect! Please select other connection.", MsgBoxStyle.Exclamation)
                'Else
                '    Dim color_pen As String = ""
                'counter_2(myButton.Name, color_pen)
                'End If
                ctr = 0
                wire_conenction = 0
                Me.Refresh()
            End If

        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If



    End Sub
    'disconnection of wire
    Private Sub btn_prim_a1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles btn_prim_a_1.MouseDown, btn_prim_a_2.MouseDown, btn_prim_a_3.MouseDown, btn_prim_a_4.MouseDown, btn_prim_a_5.MouseDown, btn_prim_a_6.MouseDown,
                                                                            btn_prim_b_1.MouseDown, btn_prim_b_2.MouseDown, btn_prim_b_3.MouseDown, btn_prim_b_4.MouseDown, btn_prim_b_5.MouseDown, btn_prim_b_6.MouseDown,
                                                                            btn_prim_c_1.MouseDown, btn_prim_c_2.MouseDown, btn_prim_c_3.MouseDown, btn_prim_c_4.MouseDown, btn_prim_c_5.MouseDown, btn_prim_c_6.MouseDown,
                                                                            btn_prim_n_1.MouseDown, btn_prim_n_2.MouseDown, btn_prim_n_3.MouseDown, btn_prim_n_4.MouseDown, btn_prim_n_5.MouseDown, btn_prim_n_6.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    delete_connections(btn, transformer_id, table)
                    get_point()
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        Me.Refresh()
    End Sub
    Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
        draw_lines(e)
    End Sub
    Private Sub btn_clamp_meter_Click(sender As Object, e As EventArgs) Handles btn_clamp_meter.Click
        Dim clamp_ctr = select_clamp_count(transformer_id, table)
        If clamp_ctr = 0 Then
            clamp_meter = 1
        ElseIf clamp_ctr = 1
            ctr_lines = ctr_lines - 1
            delete_unwanted_connection(transformer_id, table)
            clamp_meter = 1
        Else
            MsgBox("Clamp meter already exist.", MsgBoxStyle.Information, "Transformer Banking")
        End If

    End Sub

    Private Sub btn_clamp_red_Click(sender As Object, e As EventArgs) Handles btn_clamp_red.Click, btn_clamp_black.Click
        Dim myButton As Button = CType(sender, Button)
        clamp_meter = 1
        If clamp_meter = 1 Then
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1
            'clamp = myButton.Name

            Dim split_value() As String = myButton.Name.Split("_")
            Dim btn_color = split_value(2).ToString
            clamp = btn_color.ToString
            'MsgBox(clamp.ToString)
            Dim pen_color As String
            If btn_color = "red" Then
                pen_color = "Red"
            Else
                pen_color = "Black"
            End If

            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, "2")

            Else
                If clamp = "red" And current = "clred" Or clamp = "black" And current = "clblack" Or clamp = "red" And current = "cpred" Or clamp = "black" And current = "cpblack" Then
                    counter_2(myButton.Name, pen_color, "2")


                Else

                    delete_unwanted_connection(transformer_id, table)
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
                clamp_meter = 0
                ctr = 0
                Me.Refresh()
            End If
        End If
    End Sub
    Private Sub btn_cpred_Click(sender As Object, e As EventArgs) Handles btn_cpred.Click, btn_cpblack.Click, btn_clblack.Click, btn_clred.Click
        Dim myButton As Button = CType(sender, Button)

        ctr = ctr + 1
        ctr_lines = ctr_lines + 1


        Dim split_value() As String = myButton.Name.Split("_")
        current = split_value(1).ToString
        'MsgBox(current.ToString)
        'Dim pen_color As String
        'If btn_color = "red" Then
        '    pen_color = "Red"
        'Else
        '    pen_color = "Black"
        'End If

        If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, "", "2")

            Else

            If clamp = "red" And current = "clred" Or clamp = "black" And current = "clblack" Or clamp = "red" And current = "cpred" Or clamp = "black" And current = "cpblack" Then
                counter_2(myButton.Name, "", "2")


            Else
                'ctr_lines = ctr_lines - 2
                'points.RemoveAt(ctr_lines)
                delete_unwanted_connection(transformer_id, table)
                get_point()
                MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
            ctr = 0
            Me.Refresh()
        End If

    End Sub
    Private Sub btn_vpred_Click(sender As Object, e As EventArgs) Handles btn_vpred.Click, btn_vpblack.Click, btn_vlblack.Click, btn_vlred.Click
        Dim myButton As Button = CType(sender, Button)

        ctr = ctr + 1
        ctr_lines = ctr_lines + 1

        Dim split_value() As String = myButton.Name.Split("_")
        voltage = split_value(1).ToString
        'MsgBox(current.ToString)
        Dim pen_color As String
        If voltage = "vpred" Or voltage = "vlred" Then
            pen_color = "Red"
        Else
            pen_color = "Black"
        End If

        If ctr = 1 Then
            If voltage = "vpred" Or voltage = "vpblack" Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, "3")
            Else
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, "4")
            End If
            h_transformer = ""
        Else

            If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or x_transformer = "btn_t1_x1" And voltage = "vpred" Or x_transformer = "btn_t1_x2" And voltage = "vpblack" Then
                update_clamp_no("3", transformer_id, table)
                counter_2(myButton.Name, pen_color, "3")


            ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t2_h1" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                update_clamp_no("4", transformer_id, table)
                counter_2(myButton.Name, pen_color, "4")

            Else


                delete_unwanted_connection(transformer_id, table)
                get_point()
                MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
                ctr = 0
                clamp_meter = 0
                Me.Refresh()
            End If

    End Sub
    Private Sub btn_connect_wires_Click(sender As Object, e As EventArgs) Handles btn_connect_wires.Click   'wire connection
        wire_conenction = 1

        If ctr = 0 Then
            Dim count_points = select_count_points(transformer_id, table)
            Dim result = count_points Mod 2

            If result <> 0 Then
                delete_unwanted_connection(transformer_id, table)
            End If
        ElseIf ctr = 1 Then
            ctr = 0
            ctr_lines = ctr_lines - 1
            delete_unwanted_connection(transformer_id, table)
        Else

        End If
    End Sub
    Private Sub pic_switch_Click(sender As Object, e As EventArgs) Handles pic_switch.Click 'switch
        ctr_switch = ctr_switch + 1
        Dim category As String

        Dim query = "select * from wye_wye_lines where clamp_meter::integer >= 1 and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim ctr_clamp As Integer = 0
        Dim ctr_voltage_phase As Integer = 0
        Dim ctr_voltage_line As Integer = 0
        Dim ctr_bulb As Integer = 0

        For counter As Integer = 0 To dt.Rows.Count - 1


            If dt.Rows(counter)(4) <> 2 And dt.Rows(counter)(4) <> 5 Then

                If dt.Rows(counter)(3).ToString = "" Then

                    Dim split_value() As String = dt.Rows(counter)(1).Split("_")
                    Dim val As String = split_value(2)
                    If val = "h1" Or val = "h2" Then
                        category = "primary"
                    Else
                        category = "secondary"
                    End If
                End If
            End If
            If dt.Rows(counter)(4) = 2 Then
                ctr_clamp = ctr_clamp + 1
            ElseIf dt.Rows(counter)(4) = 3
                ctr_voltage_phase = ctr_voltage_phase + 1
            ElseIf dt.Rows(counter)(4) = 4
                ctr_voltage_line = ctr_voltage_line + 1
            ElseIf dt.Rows(counter)(4) = 5
                ctr_bulb = ctr_bulb + 1
            End If
        Next
        '    If dt.Rows.Count > 3 Then
        '    validation = 1
        'Else
        '    validation = 0
        'End If
        If ctr_switch = 1 And ctr_clamp <> 0 And ctr_bulb <> 0 Or ctr_switch = 1 And ctr_voltage_phase <> 0 And ctr_bulb <> 0 Or ctr_switch = 1 And ctr_voltage_line <> 0 And ctr_bulb <> 0 Or ctr_switch = 1 And ctr_bulb <> 0 Then
            pic_switch.Image = Image.FromFile(appPath & "\pictures\circuit_breaker_on.png")
            pic_switch.SizeMode = PictureBoxSizeMode.Zoom

            pic_color.Image = Image.FromFile(appPath & "\pictures\LED_LIGHT_INDICATOR_ON.png")
            pic_color.SizeMode = PictureBoxSizeMode.Zoom

            Dim primary_voltage, secondary_voltage, rating As Double

            Dim result_primary = select_voltage_primary(transformer_id)
            If result_primary <> "No data" Then
                primary_voltage = result_primary
                result_model.save(transformer_id, "primary_phase_voltage", primary_voltage)
            End If

            Dim result_secondary = select_secondary_primary(transformer_id)
            If result_secondary <> "No data" Then
                secondary_voltage = result_secondary

            End If

            Dim result_rating = select_rating(transformer_id)
            If result_rating <> "No data" Then
                Dim split_value() As String = result_rating.Split(" ")
                rating = CDbl(split_value(0))
            End If
            Dim cp, vl, apparent, real As Double
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)

                vl = Math.Round((primary_voltage * 1.73), 2)
                apparent = Math.Round((3 * primary_voltage * cp), 2)
            Else category = "secondary"
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                vl = Math.Round((secondary_voltage * 1.73), 2)
                real = Math.Round((((secondary_voltage * 1.73) * 1.73) * cp), 2)
            End If
            If ctr_clamp > 3 Then
                txt_cp.Text = cp.ToString
                txt_cl.Text = cp.ToString
                If category = "primary" Then
                    txt_apparent.Text = apparent.ToString
                    result_model.save(transformer_id, "apparent_power", apparent.ToString)
                    result_model.save(transformer_id, "primary_line_current", cp.ToString)
                    result_model.save(transformer_id, "primary_phase_current", cp.ToString)
                ElseIf category = "secondary" Then
                    txt_real.Text = real.ToString
                    result_model.save(transformer_id, "real_power", real.ToString)
                    result_model.save(transformer_id, "secondary_line_current", cp.ToString)
                    result_model.save(transformer_id, "secondary_phase_current", cp.ToString)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    txt_apparent.Text = apparent.ToString

                    result_model.save(transformer_id, "primary_phase_voltage", primary_voltage)
                    result_model.save(transformer_id, "apparent_power", apparent.ToString)
                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    result_model.save(transformer_id, "secondary_phase_voltage", secondary_voltage)
                    txt_real.Text = real.ToString
                    result_model.save(transformer_id, "real_power", real.ToString)
                End If

            End If
            If ctr_voltage_line > 3 Then
                txt_vl.Text = vl
                If category = "primary" Then
                    result_model.save(transformer_id, "primary_line_voltage", vl)
                    txt_apparent.Text = apparent.ToString
                    result_model.save(transformer_id, "apparent_power", apparent.ToString)


                ElseIf category = "secondary" Then
                    result_model.save(transformer_id, "secondary_line_voltage", vl)
                    txt_real.Text = real.ToString
                    result_model.save(transformer_id, "real_power", real.ToString)

                End If
            End If

            If ctr_bulb > 11 Then
                pic_bulb1.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                pic_bulb1.SizeMode = PictureBoxSizeMode.Zoom

                pic_bulb2.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                pic_bulb2.SizeMode = PictureBoxSizeMode.Zoom

                pic_bulb3.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                pic_bulb3.SizeMode = PictureBoxSizeMode.Zoom
            End If


            ctr_switch = 1
            done = result_model.select_specific(transformer_id)
            If done = 1 Then
                btn_done.Enabled = True
            End If
        Else
            pic_switch.Image = Image.FromFile(appPath & "\pictures\circuit_breaker.png")
            pic_switch.SizeMode = PictureBoxSizeMode.Zoom

            pic_color.Image = Image.FromFile(appPath & "\pictures\LED_LIGHT_INDICATOR_OFF.png")
            pic_color.SizeMode = PictureBoxSizeMode.Zoom
            ctr_switch = 0

            pic_bulb1.Image = Image.FromFile(appPath & "\pictures\bulb_off.png")
            pic_bulb1.SizeMode = PictureBoxSizeMode.Zoom

            pic_bulb2.Image = Image.FromFile(appPath & "\pictures\bulb_off.png")
            pic_bulb2.SizeMode = PictureBoxSizeMode.Zoom

            pic_bulb3.Image = Image.FromFile(appPath & "\pictures\bulb_off.png")
            pic_bulb3.SizeMode = PictureBoxSizeMode.Zoom

            txt_cl.Clear()
            txt_cp.Clear()
            txt_vl.Clear()
            txt_vp.Clear()
            txt_apparent.Clear()
            txt_real.Clear()

        End If


    End Sub
    Private Sub btn_vpred_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_vpred.MouseDown, btn_vpblack.MouseDown, btn_vlblack.MouseDown, btn_vlred.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    delete_connections(btn, transformer_id, table)
                    get_point()
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
        Me.Refresh()
    End Sub
    Private Sub btn_try_again_Click(sender As Object, e As EventArgs) Handles btn_try_again.Click
        Dim result As DialogResult = MsgBox("Are you sure to try again?", MsgBoxStyle.YesNo, "Disconnect Wire")
        If result = DialogResult.Yes Then

            Dim myButton As Button = CType(sender, Button)

                Dim btn = myButton.Name
                Dim query As String
            query = "delete from wye_wye_lines where transformer_details_id = '" & transformer_id & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
            da.Fill(dt)


            ctr = 0
            ctr_lines = 0
            clamp = 0
            ctr_switch = 0

            get_point()

            Me.Refresh()
        End If

    End Sub
    Private Sub btn_red_l1_Click(sender As Object, e As EventArgs) Handles btn_l1red.Click, btn_l1black.Click, btn_l2red.Click, btn_l2black.Click, btn_l3red.Click, btn_l3black.Click
        Dim myButton As Button = CType(sender, Button)

        ctr = ctr + 1
        ctr_lines = ctr_lines + 1

        Dim split_value() As String = myButton.Name.Split("_")
        Dim pen_color As String
        bulb = split_value(1)
        If split_value(1) = "l1red" Or split_value(1) = "l2red" Or split_value(1) = "l3red" Then
            pen_color = "Red"
        Else
            pen_color = "Black"
        End If
        If ctr = 1 Then
            ctr_points = ctr_points + 1
            counter_1(myButton.Name, pen_color, "5")

        Else
            If secondary = "l1" And bulb = "l1red" Or secondary = "n" And bulb = "l1black" Or secondary = "l2" And bulb = "l2red" Or secondary = "n" And bulb = "l2black" Or secondary = "l3" And bulb = "l3red" Or secondary = "n" And bulb = "l3black" Then
                counter_2(myButton.Name, pen_color, "5")
            Else
                'ctr_lines = ctr_lines - 2
                'points.RemoveAt(ctr_lines)
                delete_unwanted_connection(transformer_id, table)
                get_point()
                MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

            End If
            ctr = 0
            clamp_meter = 0
            Me.Refresh()
        End If
    End Sub
#Region "subs"
    Public Sub refresh_form(polarity, rating, connection, voltage_primary, voltage_secondary)
        Me.Controls.Clear()
        InitializeComponent()

        table = "wye_wye_lines"

        lbl_primary_voltage.Text = voltage_primary
        lbl_secondary_voltage.Text = voltage_secondary
        lbl_polarity.Text = polarity
        lbl_rating.Text = rating
        'Dim connection = Home.lbl_connection_type.Text

        'MsgBox(connection)
        Dim result = search_transformer_id(lbl_polarity.Text, lbl_rating.Text, connection, lbl_primary_voltage.Text, lbl_secondary_voltage.Text)
        If result <> 0 Then
            transformer_id = result
        End If

        get_point()
        'MsgBox(transformer_id.ToString)
        'transformer_id = search_transformer_id(lbl_polarity.Text, lbl_rating.Text, Home.lbl_connection_type.Text, lbl_primary_voltage.Text, lbl_secondary_voltage.Text)
        select_clamp()
    End Sub

    Private Sub select_clamp()
        Dim query = "select * from wye_wye_lines where clamp_meter = '1' and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            Dim x_value = dt.Rows(0)(2).ToString
            Dim y_value = dt.Rows(1)(2).ToString

            Dim x_split_value() As String = x_value.Split(",")
            Dim x = x_split_value(0)
            Dim y = x_split_value(1)
            Dim clamp_point_x As New Point(x, y)

            Dim y_split_value() As String = y_value.Split(",")
            Dim x_1 = y_split_value(0)
            Dim y_1 = y_split_value(1)
            Dim clamp_point_y As New Point(x_1, y_1)



            Dim x_point = (clamp_point_x.X / 2) + (clamp_point_y.X / 2) - 30
            Dim y_point = (clamp_point_x.Y / 2) + (clamp_point_y.Y / 2)

            Dim loc As New Point(x_point, y_point)
            'Dim loc As New Point(199, 116)
            'TextBox3.Text = clamp_point_x.ToString

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

            pic_clamp_meter.BringToFront()
            btn_clamp_black.BringToFront()
            btn_clamp_red.BringToFront()

        End If

    End Sub
    Public Sub get_point()
        Dim array_points = select_points(transformer_id, table)
        Dim count_points = select_count_points(transformer_id, table)
        ctr_lines = count_points
        points.Clear()

        For i As Integer = 0 To count_points - 1
            Dim value = array_points(i).ToString
            'Dim value_points As New Point(value)
            Dim split_value() As String = value.Split(",")
            Dim x = split_value(0)
            Dim y = split_value(1)
            Dim value_point As New Point(x, y)

            points.Add(value_point)
        Next
    End Sub


    Private Sub btn_l3red_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_l1red.MouseDown, btn_l1black.MouseDown, btn_l2red.MouseDown, btn_l2black.MouseDown, btn_l3red.MouseDown, btn_l3black.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    delete_connections(btn, transformer_id, table)
                    get_point()
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)

                End If
            End If
        End If
        Me.Refresh()
    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        MsgBox("Wye wye connection was performed correctly. You may proceed on the next connection")
        transformer_banking_connections.refresh_form()
        transformer_banking_connections.Show()
        Me.Hide()
    End Sub



    Private Sub pic_clamp_meter_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_clamp_meter.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim query_delete As String
                    query_delete = "delete from wye_wye_lines where clamp_meter in ('1','2') and  transformer_details_id = '" & transformer_id & "'"
                    Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                    Dim dt_delete As New DataTable
                    da_delete.Fill(dt_delete)

                    ctr_lines = ctr_lines - 2
                    get_point()

                    pic_clamp_meter.Visible = False
                    btn_clamp_black.Visible = False
                    btn_clamp_red.Visible = False
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If


                'pic_clamp_meter.Location = (702, 462)
            End If
        End If
        Me.Refresh()
    End Sub



    Private Sub counter_1(btn_name, pen_color, clamp)

        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        'TextBox3.Text = "{x=" & point1_x.ToString & ",y=" & point1_y.ToString & "}"
        point_1 = New Point(point1_x, point1_y)

        Dim result = save_points(btn_name, point1_x & "," & point1_y, pen_color, clamp, transformer_id, table)
        If result <> "1" Then
            MsgBox(result.ToString)
        End If


        'Dim result = save_points(point_1.ToString, ctr_lines)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'point_1 = New Point(367, 139)
        'points.Add(point_1)
        'points.Add(268, 33)
    End Sub
    Private Sub panel_activity_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_activity.MouseDown

        If e.Button = MouseButtons.Left Then
            Dim location As New Point(e.X, e.Y)
            'TextBox2.Text = location.ToString
        End If

    End Sub

    Private Sub counter_2(btn_name, pen_color, clamp)

        point2_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point2_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2
        point_2 = New Point(point2_x, point2_y)
        'TextBox3.Text = "{x=" & point2_x.ToString & ",y=" & point2_y.ToString & "}"

        Dim result = save_points(btn_name, point2_x & "," & point2_y, pen_color, clamp, transformer_id, table)

        If result <> "1" Then
            MsgBox(result.ToString)
        End If


        'point_2 = New Point(142, 139)

        'points.Add(point_2)
    End Sub

    Private Sub draw_lines(ByVal e As PaintEventArgs)
        'counter_1()
        'counter_2()
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'pens.DashCap
        'pens.Width = 2.0
        get_point()
        Dim point_x, point_y As Point
        panel_activity.BringToFront()

        'point_1 = New Point(point1_x, point1_y)
        'point_2 = New Point(point2_x, point2_y)
        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
        'DataGridView1.Columns.Add("points", "points")
        Dim count As Integer = 0
        Dim arry_color = select_color(transformer_id, table)
        Dim colors_pen As String = ""
        For i As Integer = 0 To ctr_lines - 1
            'Dim x = -1
            count = count + 1


            If count = 1 Then
                point_x = points.Item(i)
                colors_pen = arry_color(i)
            ElseIf count = 2
                point_y = points.Item(i)
                If colors_pen = "" Then
                    colors_pen = arry_color(i)
                End If

                'MsgBox(colors.ToString)
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
                'Me.Refresh()
                'ListBox1.Items.Add(point_x.ToString & " " & point_y.ToString)
            End If

            'DataGridView1.Rows.Add(points.Item(i))
            'MsgBox(point_x & "," & point_y)
        Next

        'e.Graphics.DrawLine(pens, point_1, point_2)
    End Sub

    Private Sub draw_lines_2(ByVal e As PaintEventArgs)
        'counter_1()
        'counter_2()
        Dim pens As New Pen(Color.Black)

        'Dim pointers As New List(Of Point)

        panel_activity.BringToFront()

        'point_1 = New Point(point1_x, point1_y)
        'point_2 = New Point(point2_x, point2_y)
        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
        'DataGridView1.Columns.Add("points", "points")
        'Dim count As Integer = 0
        'For i As Integer = 0 To ctr_lines - 1
        '    Dim x = -1

        '    count = count + 1
        '    If count = 1 Then
        '        point_x = points.Item(i)
        '    ElseIf count = 2
        '        point_y = points.Item(i)
        '        'pointers.Add(point_x)



        '        e.Graphics.DrawLine(pens, point_x, point_y)
        '        count = 0
        '        'Me.Refresh()
        '    End If

        '    'DataGridView1.Rows.Add(points.Item(i))
        '    'MsgBox(point_x & "," & point_y)
        'Next

        'e.Graphics.DrawLine(pens, point_1, point_2) totoo
    End Sub




#End Region
End Class
