﻿Imports System.Drawing.Drawing2D
Public Class Exercises
    Dim exercise As New exercise_details
    Dim no As Integer

    Dim transformer_details As New exercise_transformer_details()

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


    Dim transformer_1, transformer_2 As String

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

    Dim ctr_cl_clamp As Integer = 0

    Dim counter, counter_bulb As Integer

    Private Sub btn_t1_h1_Click(sender As Object, e As EventArgs) Handles btn_t1_h1.Click, btn_t1_h2.Click, btn_t2_h1.Click, btn_t2_h2.Click, btn_t3_h2.Click, btn_t3_h1.Click

        If wire_conenction = 1 Or clamp_meter = 1 Then

            Dim myButton As Button = CType(sender, Button)

            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            h_transformer = myButton.Name

            If ctr = 1 Then
                transformer_1 = myButton.Name
                Dim color_pen As String = ""
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, color_pen, clamp_meter)

            Else
                transformer_2 = myButton.Name
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

                        pic_clamp_meter.Visible = True
                        btn_clamp_black.Visible = True
                        btn_clamp_red.Visible = True


                    Else
                        delete_unwanted_connection(transformer_id, table)
                        get_point()
                        MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    End If
                    clamp_meter = 0
                    ctr = 0
                    Me.Refresh()
                Else

                    If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t2_h2" And voltage = "vpblack" Then
                        update_clamp_no("3", transformer_id, table)
                        counter_2(myButton.Name, "", "3")


                    ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t2_h1" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t1_x2" And voltage = "vlblack" Then
                        update_clamp_no("4", transformer_id, table)
                        counter_2(myButton.Name, "", "4")



                    Else
                        If h_transformer = "btn_t1_h1" And primary = "a" Or h_transformer = "btn_t2_h1" And primary = "b" Or h_transformer = "btn_t3_h1" And primary = "c" Then
                            counter_2(myButton.Name, "", clamp_meter)
                        ElseIf transformer_1 = "btn_t1_h2" And transformer_2 = "btn_t2_h1" Or transformer_2 = "btn_t1_h2" And transformer_1 = "btn_t2_h1" Then
                            counter_2(myButton.Name, "Blue", clamp_meter)
                        ElseIf transformer_1 = "btn_t2_h2" And transformer_2 = "btn_t3_h1" Or transformer_2 = "btn_t2_h2" And transformer_1 = "btn_t3_h1" Then
                            counter_2(myButton.Name, "Yellow", clamp_meter)
                        ElseIf transformer_1 = "btn_t3_h2" And transformer_2 = "btn_t1_h1" Or transformer_2 = "btn_t3_h2" And transformer_1 = "btn_t1_h1" Then
                            counter_2(myButton.Name, "Red", clamp_meter)
                        Else
                            counter_2(myButton.Name, "Black", clamp_meter)
                        End If
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

    Dim pens As New Pen(Color.Red, 2)

    Private Sub Exercises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbopen()
        'refresh_form()
    End Sub

    Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
        draw_lines(e)
    End Sub

    Private Sub btn_connect_wires_Click(sender As Object, e As EventArgs) Handles btn_connect_wires.Click
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

    Private Sub btn_t2_x1_Click(sender As Object, e As EventArgs) Handles btn_t1_x1.Click, btn_t1_x2.Click, btn_t2_x1.Click, btn_t2_x2.Click, btn_t3_x1.Click, btn_t3_x2.Click

        Dim myButton As Button = CType(sender, Button)
        'Dim myName As String =
        ctr = ctr + 1
        ctr_lines = ctr_lines + 1

        x_transformer = myButton.Name
        If ctr = 1 Then
            transformer_1 = myButton.Name
            Dim color_pen As String = ""
            ctr_points = ctr_points + 1
            counter_1(myButton.Name, color_pen, clamp_meter)

        Else
            transformer_2 = myButton.Name
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

                    pic_clamp_meter.Location = loc
                    btn_clamp_black.Location = b_location
                    btn_clamp_red.Location = r_location

                    pic_clamp_meter.Visible = True
                    btn_clamp_black.Visible = True
                    btn_clamp_red.Visible = True


                Else

                    delete_unwanted_connection(transformer_id, table)
                    get_point()
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                End If
                clamp_meter = 0
                ctr = 0
                Me.Refresh()

            Else

                If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or x_transformer = "btn_t1_x1" And voltage = "vpred" Or x_transformer = "btn_t1_x2" And voltage = "vpblack" Then
                    update_clamp_no("3", transformer_id, table)
                    counter_2(myButton.Name, "", "3")

                ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t1_h2" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                    update_clamp_no("4", transformer_id, table)
                    counter_2(myButton.Name, "", "4")

                Else
                    If x_transformer = "btn_t1_x1" And secondary = "l1" Or x_transformer = "btn_t2_x1" And secondary = "l2" Or x_transformer = "btn_t3_x1" And secondary = "l3" Then
                        counter_2(myButton.Name, "", clamp_meter)
                    ElseIf transformer_1 = "btn_t1_x2" And transformer_2 = "btn_t2_x1" Or transformer_2 = "btn_t1_x2" And transformer_1 = "btn_t2_x1" Then
                        counter_2(myButton.Name, "Blue", clamp_meter)
                    ElseIf transformer_1 = "btn_t2_x2" And transformer_2 = "btn_t3_x1" Or transformer_2 = "btn_t2_x2" And transformer_1 = "btn_t3_x1" Then
                        counter_2(myButton.Name, "Yellow", clamp_meter)
                    ElseIf transformer_1 = "btn_t3_x2" And transformer_2 = "btn_t1_x1" Or transformer_2 = "btn_t3_x2" And transformer_1 = "btn_t1_x1" Then
                        counter_2(myButton.Name, "Red", clamp_meter)
                    Else
                        counter_2(myButton.Name, "Black", clamp_meter)
                    End If
                End If
                secondary = ""
            End If

            ctr = 0
            Me.Refresh()

        End If
    End Sub

    Private Sub btn_sec_n_3_Click(sender As Object, e As EventArgs) Handles btn_sec_n_1.Click, btn_sec_n_2.Click, btn_sec_n_3.Click, btn_sec_n_4.Click, btn_sec_n_5.Click, btn_sec_n_6.Click,
                                            btn_sec_l1_1.Click, btn_sec_l1_2.Click, btn_sec_l1_3.Click, btn_sec_l1_4.Click, btn_sec_l1_5.Click, btn_sec_l1_6.Click,
                                            btn_sec_l2_1.Click, btn_sec_l2_2.Click, btn_sec_l2_3.Click, btn_sec_l2_4.Click, btn_sec_l2_5.Click, btn_sec_l2_6.Click,
                                            btn_sec_l3_1.Click, btn_sec_l3_2.Click, btn_sec_l3_3.Click, btn_sec_l3_4.Click, btn_sec_l3_5.Click, btn_sec_l3_6.Click
        If wire_conenction = 1 Or clamp_meter = 1 Then
            Dim myButton As Button = CType(sender, Button)

            btn_primary = myButton.Name
            Dim split_value() As String = btn_primary.Split("_")
            Dim btn_color = split_value(2).ToString
            Dim pen_color As String

            secondary = ""
            If btn_color = "n" Then
                pen_color = "Black"
                secondary = "n"
            ElseIf btn_color = "l1" Then
                secondary = "l1"
                pen_color = "Red"
            ElseIf btn_color = "l2" Then
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
                    panel_activity.Refresh()

                Else
                    If bulb <> "" Then
                        counter_2(myButton.Name, "", "5")
                    Else
                        counter_2(myButton.Name, pen_color, clamp_meter)

                    End If
                    bulb = ""
                End If
                ctr = 0
                panel_activity.Refresh()
                wire_conenction = 0
            End If

        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If

    End Sub

    Private Sub btn_clamp_meter_Click(sender As Object, e As EventArgs) Handles btn_clamp_meter.Click
        Dim clamp_ctr = select_clamp_count(transformer_id, table)
        If clamp_ctr = 0 Then
            clamp_meter = 1
        ElseIf clamp_ctr = 1 Then
            ctr_lines = ctr_lines - 1
            delete_unwanted_connection(transformer_id, table)
            clamp_meter = 1
        Else
            MsgBox("Clamp meter already exist.", MsgBoxStyle.Information, "Transformer Banking")
        End If
    End Sub

    Private Sub btn_cl_clamp_meter_Click(sender As Object, e As EventArgs) Handles btn_cl_clamp_meter.Click
        ctr_cl_clamp = 1
    End Sub

    Private Sub btn_cpblack_Click(sender As Object, e As EventArgs) Handles btn_cpred.Click, btn_cpblack.Click
        If ctr_cl_clamp = 1 Then
            Dim myButton As Button = CType(sender, Button)

            ctr = ctr + 1
            ctr_lines = ctr_lines + 1


            Dim split_value() As String = myButton.Name.Split("_")
            current = split_value(1).ToString

            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, "", "7")

            Else

                If clamp = "cpred" And current = "cpred" Or clamp = "cpblack" And current = "cpblack" Then
                    counter_2(myButton.Name, "", "7")


                Else
                    ctr_lines = ctr_lines - 2
                    points.RemoveAt(ctr_lines)
                    delete_unwanted_connection(transformer_id, table)
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
                ctr = 0
                ctr_cl_clamp = 1
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub btn_clblack_Click(sender As Object, e As EventArgs) Handles btn_clblack.Click, btn_clred.Click
        Dim myButton As Button = CType(sender, Button)
        If clamp_meter = 1 Then
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1

            Dim split_value() As String = myButton.Name.Split("_")

            current = split_value(1).ToString

            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, "", "2")

            Else
                If clamp = "red" And current = "clred" Or clamp = "black" And current = "clblack" Then
                    counter_2(myButton.Name, "", "2")

                Else
                    ctr_lines = ctr_lines - 2
                    points.RemoveAt(ctr_lines)
                    delete_unwanted_connection(transformer_id, table)
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")
                    clamp = 0
                End If

                ctr = 0
                Me.Refresh()
            End If
        End If
    End Sub

    Private Sub btn_clamp_cpred_Click(sender As Object, e As EventArgs) Handles btn_clamp_cpblack.Click, btn_clamp_cpred.Click
        Dim myButton As Button = CType(sender, Button)
        If ctr_cl_clamp = 1 Then
            ctr = ctr + 1
            ctr_lines = ctr_lines + 1
            'clamp = myButton.Name

            Dim split_value() As String = myButton.Name.Split("_")
            Dim btn_color = split_value(2).ToString
            clamp = btn_color.ToString
            'MsgBox(clamp.ToString)
            Dim pen_color As String
            If btn_color = "cpred" Then
                pen_color = "Red"
            Else
                pen_color = "Black"
            End If

            If ctr = 1 Then
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, "7")

            Else
                If clamp = "cpred" And current = "cpred" Or clamp = "cpblack" And current = "cpblack" Then
                    counter_2(myButton.Name, pen_color, "7")

                Else

                    delete_unwanted_connection(transformer_id, table)
                    get_point()
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
                ctr_cl_clamp = 0
                ctr = 0
                Me.Refresh()
            End If
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
                If clamp = "red" And current = "clred" Or clamp = "black" And current = "clblack" Then
                    counter_2(myButton.Name, pen_color, "2")

                Else
                    ctr_lines = ctr_lines - 2
                    points.RemoveAt(ctr_lines)
                    delete_unwanted_connection(transformer_id, table)
                    MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

                End If
                clamp_meter = 0
                ctr = 0
                Me.Refresh()
            End If
        End If
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
        ElseIf ctr_cl_clamp = 1 Then
            MsgBox("Wrong Connection!", MsgBoxStyle.Exclamation, "Transformer Banking")

        Else
            MsgBox("Please click connecting wire!", MsgBoxStyle.Exclamation, "Transformer Banking")
        End If
    End Sub

#Region "sub"
    Public Sub refresh_form(polarity, rating, connection, voltage_primary, voltage_secondary)
        Me.Controls.Clear()
        InitializeComponent()

        table = "exercise_lines"

        lbl_primary_voltage.Text = voltage_primary
        lbl_secondary_voltage.Text = voltage_secondary
        lbl_polarity.Text = polarity
        lbl_rating.Text = rating

        no = Home.exam_no
        Dim test = exercise.exercise_questions(no)
        txt_exam.Text = test

        Dim result = transformer_details.search_transformer_id(lbl_polarity.Text, lbl_rating.Text, no, lbl_primary_voltage.Text, lbl_secondary_voltage.Text)
        If result <> 0 Then
            transformer_id = result
        End If

        additive(polarity)
        select_clamp_phase()
        select_clamp_line()
    End Sub


    Private Sub btn_t1_Click(sender As Object, e As EventArgs) Handles btn_t1.Click, btn_t2.Click, btn_t3.Click
        If ctr_cl_clamp = 1 Then
            Dim myButton As Button = CType(sender, Button)

            Dim btn As String = myButton.Name
            If btn = "btn_t1" Then
                counter_1("btn_t1_h1", "", 6)
                counter_2("btn_t1_h2", "", 6)
            ElseIf btn = "btn_t2" Then
                counter_1("btn_t2_h1", "", 6)
                counter_2("btn_t2_h2", "", 6)
            ElseIf btn = "btn_t3" Then
                counter_1("btn_t3_h1", "", 6)
                counter_2("btn_t3_h2", "", 6)
            End If


            Dim x_point = (point_1.X / 2) + (point_2.X / 2) - 18
            Dim y_point = (point_1.Y / 2) + (point_2.Y / 2) + 53

            Dim loc As New Point(x_point, y_point)

            Dim b_x = (loc.X + 41)
            Dim b_y = (loc.Y + 13)

            Dim r_x = (loc.X + 41)
            Dim r_y = (loc.Y + 37)


            Dim b_location As New Point(b_x, b_y)
            Dim r_location As New Point(r_x, r_y)
            'picbox_clamp_meter.Location = panel_activity.Cursor.Position
            pic_clamp_meter_cp.Location = loc
            btn_clamp_cpblack.Location = b_location
            btn_clamp_cpred.Location = r_location

            pic_clamp_meter_cp.Visible = True
            btn_clamp_cpblack.Visible = True
            btn_clamp_cpred.Visible = True

            pic_clamp_meter_cp.BringToFront()
            btn_clamp_cpblack.BringToFront()
            btn_clamp_cpred.BringToFront()

        End If

    End Sub

    Private Sub btn_t1_x_Click(sender As Object, e As EventArgs) Handles btn_t1_x.Click, btn_t2_x.Click, btn_t3_x.Click
        If ctr_cl_clamp = 1 Then
            Dim myButton As Button = CType(sender, Button)
            'category = "primary"
            Dim btn As String = myButton.Name
            If btn = "btn_t1_x" Then
                counter_1("btn_t1_x1", "", 6)
                counter_2("btn_t1_x2", "", 6)
            ElseIf btn = "btn_t2_x" Then
                counter_1("btn_t2_x1", "", 6)
                counter_2("btn_t2_x2", "", 6)
            ElseIf btn = "btn_t3_x" Then
                counter_1("btn_t3_x1", "", 6)
                counter_2("btn_t3_x2", "", 6)
            End If


            Dim x_point = (point_1.X / 2) + (point_2.X / 2) - 18
            Dim y_point = (point_1.Y / 2) + (point_2.Y / 2) - 25

            Dim loc As New Point(x_point, y_point)

            Dim b_x = (loc.X + 41)
            Dim b_y = (loc.Y + 13)

            Dim r_x = (loc.X + 41)
            Dim r_y = (loc.Y + 37)


            Dim b_location As New Point(b_x, b_y)
            Dim r_location As New Point(r_x, r_y)
            'picbox_clamp_meter.Location = panel_activity.Cursor.Position
            pic_clamp_meter_cp.Location = loc
            btn_clamp_cpblack.Location = b_location
            btn_clamp_cpred.Location = r_location

            pic_clamp_meter_cp.Visible = True
            btn_clamp_cpblack.Visible = True
            btn_clamp_cpred.Visible = True

            pic_clamp_meter_cp.BringToFront()
            btn_clamp_cpblack.BringToFront()
            btn_clamp_cpred.BringToFront()

        End If

    End Sub

    Private Sub pic_clamp_meter_cp_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_clamp_meter_cp.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim query_delete As String
                    query_delete = "delete from " & table & " where clamp_meter in ('6','7') and transformer_details_id = '" & transformer_id & "'"
                    Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                    Dim dt_delete As New DataTable
                    da_delete.Fill(dt_delete)

                    ctr_lines = ctr_lines - 2
                    get_point()

                    pic_clamp_meter_cp.Visible = False
                    btn_clamp_cpblack.Visible = False
                    btn_clamp_cpred.Visible = False
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If


                'pic_clamp_meter.Location = (702, 462)
            End If
        End If
        Me.Refresh()
    End Sub

    Private Sub pic_clamp_meter_MouseDown(sender As Object, e As MouseEventArgs) Handles pic_clamp_meter.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim query_delete As String
                    query_delete = "delete from " & table & " where clamp_meter in ('1','2') and transformer_details_id = '" & transformer_id & "'"
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

    Private Sub btn_prim_a_5_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_prim_a_1.MouseDown, btn_prim_a_2.MouseDown, btn_prim_a_3.MouseDown, btn_prim_a_4.MouseDown, btn_prim_a_5.MouseDown, btn_prim_a_6.MouseDown,
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
                    Me.Refresh()
                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If
            End If

        End If
    End Sub

    Private Sub btn_t3_h1_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_t1_h1.MouseDown, btn_t1_h2.MouseDown, btn_t2_h1.MouseDown, btn_t2_h2.MouseDown, btn_t3_h2.MouseDown, btn_t3_h1.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    Dim query, query_delete As String
                    query = "select * from " & table & "  where transformer_details_id = '" & transformer_id & "' order by id asc"
                    Dim da As New Odbc.OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    For counter As Integer = 0 To dt.Rows.Count - 1

                        If dt.Rows(counter)(1) = btn.ToString Then
                            If dt.Rows(counter - 1)(3) = "" And dt.Rows(counter)(3) <> "" Then
                                query_delete = "delete from " & table & "  where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                                Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                                Dim dt_delete As New DataTable
                                da_delete.Fill(dt_delete)

                                ctr_lines = ctr_lines - 2
                                get_point()
                            ElseIf dt.Rows(counter)(3) = "" And dt.Rows(counter - 1)(3) <> "" Then
                                query_delete = "delete from " & table & "  where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                                Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                                Dim dt_delete As New DataTable
                                da_delete.Fill(dt_delete)

                                ctr_lines = ctr_lines - 2
                                get_point()

                            End If
                            Exit For
                        End If

                    Next

                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If

            End If
        End If
        Me.Refresh()
    End Sub

    Private Sub btn_t3_x2_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_t1_x1.MouseDown, btn_t1_x2.MouseDown, btn_t2_x1.MouseDown, btn_t2_x2.MouseDown, btn_t3_x1.MouseDown, btn_t3_x2.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim result As DialogResult = MsgBox("Are you sure to disconnect the wire?", MsgBoxStyle.YesNo, "Disconnect Wire")
            If result = DialogResult.Yes Then
                If ctr_switch <> 1 Then
                    Dim myButton As Button = CType(sender, Button)

                    Dim btn = myButton.Name
                    Dim query, query_delete As String
                    query = "select * from " & table & " where  transformer_details_id = '" & transformer_id & "' order by id asc"
                    Dim da As New Odbc.OdbcDataAdapter(query, conn)
                    Dim dt As New DataTable
                    da.Fill(dt)
                    For counter As Integer = 0 To dt.Rows.Count - 1

                        If dt.Rows(counter)(1) = btn.ToString Then
                            If dt.Rows(counter - 1)(3) = "" And dt.Rows(counter)(3) <> "" Then
                                query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                                Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                                Dim dt_delete As New DataTable
                                da_delete.Fill(dt_delete)


                                get_point()
                            ElseIf dt.Rows(counter)(3) = "" And dt.Rows(counter - 1)(3) <> "" Then
                                query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                                Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                                Dim dt_delete As New DataTable
                                da_delete.Fill(dt_delete)


                                get_point()

                            End If
                            Exit For
                        End If

                    Next

                Else
                    MsgBox("Please turn off the switch.", MsgBoxStyle.Exclamation)
                End If

            End If
            Me.Refresh()
        End If

    End Sub

    Private Sub btn_sec_n_5_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_sec_n_1.MouseDown, btn_sec_n_2.MouseDown, btn_sec_n_3.MouseDown, btn_sec_n_4.MouseDown, btn_sec_n_5.MouseDown, btn_sec_n_6.MouseDown,
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
                Me.Refresh()
            End If
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
        secondary = ""
        primary = ""
        transformer_1 = ""
        transformer_2 = ""
        If ctr = 1 Then
            If voltage = "vpred" Or voltage = "vpblack" Then
                ctr_points = ctr_points + 1

                counter_1(myButton.Name, pen_color, "3")
            Else
                ctr_points = ctr_points + 1
                counter_1(myButton.Name, pen_color, "4")
            End If
        Else

            If h_transformer = "btn_t1_h1" And voltage = "vpred" Or h_transformer = "btn_t1_h2" And voltage = "vpblack" Or x_transformer = "btn_t1_x1" And voltage = "vpred" Or x_transformer = "btn_t1_x2" And voltage = "vpblack" Then
                update_clamp_no("3", transformer_id, table)
                counter_2(myButton.Name, pen_color, "3")
            ElseIf h_transformer = "btn_t1_h1" And voltage = "vlred" Or h_transformer = "btn_t2_h1" And voltage = "vlblack" Or x_transformer = "btn_t1_x1" And voltage = "vlred" Or x_transformer = "btn_t2_x1" And voltage = "vlblack" Then
                update_clamp_no("4", transformer_id, table)
                counter_2(myButton.Name, pen_color, "4")
            Else
                ctr_lines = ctr_lines - 2
                points.RemoveAt(ctr_lines)
                delete_unwanted_connection(transformer_id, table)
                MsgBox("Please connect correct wires!", MsgBoxStyle.Exclamation, "Follow the procedure.")

            End If
            ctr = 0
            clamp_meter = 0
            Me.Refresh()
            wire_conenction = 0
        End If
    End Sub

    Public Sub additive(polarity)
        If polarity = "Additive" Then
            Dim blue_1 As New Point(106, 293)
            Dim blue_2 As New Point(301, 293)

            Dim red_1 As New Point(156, 291)
            Dim red_2 As New Point(400, 291)

            Dim yellow_1 As New Point(252, 288)
            Dim yellow_2 As New Point(451, 288)


            Label21.Text = "X2"
            Label21.BringToFront()
            btn_t1_x1.Name = "btn_t1_x2"

            'btn_t1_x1.Location = blue_1
            Label22.Text = "X1"
            Label22.BringToFront()

            btn_t1_x2.Name = "btn_t1_x1"
            'btn_t1_x2.Location = red_1
            Label24.Text = "X2"
            Label24.BringToFront()

            btn_t2_x1.Name = "btn_t2_x2"
            'btn_t2_x1.Location = yellow_1
            Label23.Text = "X1"
            Label23.BringToFront()

            btn_t2_x2.Name = "btn_t2_x1"
            'btn_t2_x2.Location = blue_2
            Label26.Text = "X2"
            Label26.BringToFront()

            btn_t3_x1.Name = "btn_t3_x2"
            'btn_t3_x1.Location = red_2

            btn_t3_x2.Name = "btn_t3_x1"
            'btn_t3_x2.Location = yellow_2
            Label25.Text = "X1"
            Label25.BringToFront()
        End If
    End Sub

    Private Sub btn_try_again_Click(sender As Object, e As EventArgs) Handles btn_try_again.Click
        Dim result As DialogResult = MsgBox("Are you sure to try again?", MsgBoxStyle.YesNo, "Disconnect Wire")
        If result = DialogResult.Yes Then

            Dim myButton As Button = CType(sender, Button)

            Dim btn = myButton.Name
            Dim query As String
            query = "delete from " & table & " where transformer_details_id = '" & transformer_id & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            ctr_cl_clamp = 0
            ctr = 0
            ctr_lines = 0
            clamp = 0
            ctr_switch = 0

            get_point()

            pic_clamp_meter_cp.Visible = False
            btn_clamp_cpblack.Visible = False
            btn_clamp_cpred.Visible = False

            pic_clamp_meter.Visible = False
            btn_clamp_black.Visible = False
            btn_clamp_red.Visible = False


            Me.Refresh()
        End If
    End Sub

    Private Sub btn_l1red_Click(sender As Object, e As EventArgs) Handles btn_l1red.Click, btn_l1black.Click, btn_l2red.Click, btn_l2black.Click, btn_l3red.Click, btn_l3black.Click
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
            counter_2(myButton.Name, pen_color, "5")

            ctr = 0
            clamp_meter = 0
            Me.Refresh()
        End If

    End Sub

    Private Sub pic_switch_Click(sender As Object, e As EventArgs) Handles pic_switch.Click
        Dim result As String
        result = wye_wye_connection()
        If result = "False" Then
            result = wye_delta_connection()
            If result = "False" Then
                result = delta_delta_connection()

                If result = "False" Then
                    result = delta_wye_connection()
                    If result = "False" Then
                        result = open_delta_connection()
                        If result = "False" Then
                            result = open_wye_open_delta_connection()
                        End If
                    End If
                End If
            End If
        End If
        If result <> "False" Then
            Dim bulb_result As String
            If result = "Wye Wye Connection" Or result = "Delta Wye Connection" Then
                bulb_result = wye_bulb_connection()
            Else
                bulb_result = delta_bulb_connection()
            End If
            If bulb_result <> "False" Then
                ctr_switch = ctr_switch + 1
                If ctr_switch = 1 Then
                    pic_switch.Image = Image.FromFile(appPath & "\pictures\circuit_breaker_on.png")
                    pic_switch.SizeMode = PictureBoxSizeMode.Zoom

                    pic_color.Image = Image.FromFile(appPath & "\pictures\LED_LIGHT_INDICATOR_ON.png")
                    pic_color.SizeMode = PictureBoxSizeMode.Zoom


                    pic_bulb1.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                    pic_bulb1.SizeMode = PictureBoxSizeMode.Zoom

                    pic_bulb2.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                    pic_bulb2.SizeMode = PictureBoxSizeMode.Zoom

                    pic_bulb3.Image = Image.FromFile(appPath & "\pictures\bulb_on.png")
                    pic_bulb3.SizeMode = PictureBoxSizeMode.Zoom
                    computations(result)
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
            End If
        End If

    End Sub

    Private Sub select_clamp_line()
        Dim query = "select * from " & table & " where clamp_meter = '1' and transformer_details_id = '" & transformer_id & "' order by id asc"
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

    Private Sub select_clamp_phase()
        Dim query = "select * from " & table & " where clamp_meter = '6' and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then


            Dim split_value() As String = dt.Rows(0)(1).Split("_")
            Dim val As String = split_value(2).ToString

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

            Dim x_point, y_point As Integer

            If val = "h1" Or val = "h2" Then
                x_point = (clamp_point_x.X / 2) + (clamp_point_y.X / 2) - 18
                y_point = (clamp_point_x.Y / 2) + (clamp_point_y.Y / 2) + 53
            Else
                x_point = (clamp_point_x.X / 2) + (clamp_point_y.X / 2) - 18
                y_point = (clamp_point_x.Y / 2) + (clamp_point_y.Y / 2) - 25
            End If


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
            pic_clamp_meter_cp.Location = loc
            btn_clamp_cpblack.Location = b_location
            btn_clamp_cpred.Location = r_location

            pic_clamp_meter_cp.Visible = True
            btn_clamp_cpblack.Visible = True
            btn_clamp_cpred.Visible = True

            pic_clamp_meter_cp.BringToFront()
            btn_clamp_cpblack.BringToFront()
            btn_clamp_cpred.BringToFront()
            ctr_cl_clamp = 1
        End If



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
            ElseIf count = 2 Then
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
                '  panel_activity.Refresh()
                'ListBox1.Items.Add(point_x.ToString & " " & point_y.ToString)
            End If

            'DataGridView1.Rows.Add(points.Item(i))
            'MsgBox(point_x & "," & point_y)
        Next

        'e.Graphics.DrawLine(pens, point_1, point_2)
    End Sub
    Private Sub counter_1(btn_name, pen_color, clamp)

        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        point_1 = New Point(point1_x, point1_y)

        Dim result = save_points(btn_name, point1_x & "," & point1_y, pen_color, clamp, transformer_id, table)
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
    Public Function wye_wye_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)
                End If
                Dim result = wye_wye(btn1, btn2)

                If result = False Then
                    Return False
                    counter = 0
                    Exit For
                Else

                End If
                count = 0
            End If
        Next
        If counter < 12 Then
            Return "False"
            counter = 0
        Else
            Return "Wye Wye Connection"
        End If

    End Function
    Private Function wye_wye(btn1, btn2)
        counter = counter + 1
        If btn2 = "btn_t1_h1" And btn1 = "a" Or btn1 = "btn_t1_h1" And btn2 = "a" Then
            Return True
        ElseIf btn2 = "btn_t1_h2" And btn1 = "n" Or btn1 = "btn_t1_h2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t2_h1" And btn1 = "b" Or btn1 = "btn_t2_h1" And btn2 = "b" Then
            Return True
        ElseIf btn2 = "btn_t2_h2" And btn1 = "n" Or btn1 = "btn_t2_h2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t3_h1" And btn1 = "c" Or btn1 = "btn_t3_h1" And btn2 = "c" Then
            Return True
        ElseIf btn2 = "btn_t3_h2" And btn1 = "n" Or btn1 = "btn_t3_h2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t1_x1" And btn1 = "l1" Or btn1 = "btn_t1_x1" And btn2 = "l1" Then
            Return True
        ElseIf btn2 = "btn_t1_x2" And btn1 = "n" Or btn1 = "btn_t1_x2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t2_x1" And btn1 = "l2" Or btn1 = "btn_t2_x1" And btn2 = "l2" Then
            Return True
        ElseIf btn2 = "btn_t2_x2" And btn1 = "n" Or btn1 = "btn_t2_x2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t3_x1" And btn1 = "l3" Or btn1 = "btn_t3_x1" And btn2 = "l3" Then
            Return True
        ElseIf btn2 = "btn_t3_x2" And btn1 = "n" Or btn1 = "btn_t3_x2" And btn2 = "n" Then
            Return True
        Else
            counter = 0
            Return False
        End If
    End Function

    Public Function wye_delta_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)
                End If
                Dim result = wye_delta(btn1, btn2)
                'MsgBox(result)
                If result = False Then
                    Return "False"
                    counter = 0
                    Exit For
                Else

                End If
                count = 0
            End If
        Next
        If counter < 12 Then
            Return "False"
            counter = 0
        Else
            Return "Wye Delta Connection"
        End If

    End Function
    Private Function wye_delta(btn1, btn2)
        counter = counter + 1
        If btn2 = "btn_t1_h1" And btn1 = "a" Or btn1 = "btn_t1_h1" And btn2 = "a" Then
            Return True
        ElseIf btn2 = "btn_t1_h2" And btn1 = "n" Or btn1 = "btn_t1_h2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t2_h1" And btn1 = "b" Or btn1 = "btn_t2_h1" And btn2 = "b" Then
            Return True
        ElseIf btn2 = "btn_t2_h2" And btn1 = "n" Or btn1 = "btn_t2_h2" And btn2 = "n" Then
            Return True
        ElseIf btn2 = "btn_t3_h1" And btn1 = "c" Or btn1 = "btn_t3_h1" And btn2 = "c" Then
            Return True
        ElseIf btn2 = "btn_t3_h2" And btn1 = "n" Or btn1 = "btn_t3_h1" And btn2 = "c" Then
            Return True
        ElseIf btn2 = "btn_t1_x1" And btn1 = "l1" Or btn1 = "btn_t1_x1" And btn2 = "l1" Then
            Return True
        ElseIf btn2 = "btn_t2_x1" And btn1 = "l2" Or btn1 = "btn_t2_x1" And btn2 = "l2" Then
            Return True
        ElseIf btn2 = "btn_t3_x1" And btn1 = "l3" Or btn1 = "btn_t3_x1" And btn2 = "l3" Then
            Return True
        ElseIf btn2 = "btn_t1_x2" And btn1 = "btn_t2_x1" Or btn1 = "btn_t1_x2" And btn2 = "btn_t2_x1" Then

            Return True
        ElseIf btn2 = "btn_t2_x2" And btn1 = "btn_t3_x1" Or btn1 = "btn_t2_x2" And btn2 = "btn_t3_x1" Then
            Return True

        ElseIf btn2 = "btn_t3_x2" And btn1 = "btn_t1_x1" Or btn1 = "btn_t3_x2" And btn2 = "btn_t1_x1" Then
            Return True
        Else
            counter = 0
            Return False
        End If

    End Function
    Public Function delta_delta_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)
                End If
                Dim result = delta_delta(btn1, btn2)
                btn1 = ""
                btn2 = ""
                If result = False Then
                    Return "False"
                    counter = 0
                    Exit For
                Else

                End If
                count = 0
            End If
        Next

        If counter < 12 Then
            Return "False"
            counter = 0
        Else
            Return "Delta Delta Connection"
        End If
    End Function
    Private Function delta_delta(btn1, btn2)
        counter = counter + 1
        If btn1 = "btn_t1_h1" And btn2 = "a" Or btn2 = "btn_t1_h1" And btn1 = "a" Then
            Return True
        ElseIf btn1 = "btn_t2_h1" And btn2 = "b" Or btn2 = "btn_t2_h1" And btn1 = "b" Then
            Return True
        ElseIf btn1 = "btn_t3_h1" And btn2 = "c" Or btn2 = "btn_t3_h1" And btn1 = "c" Then
            Return True
        ElseIf btn1 = "btn_t1_h2" And btn2 = "btn_t2_h1" Or btn2 = "btn_t1_h2" And btn1 = "btn_t2_h1" Then
            Return True
        ElseIf btn1 = "btn_t2_h2" And btn2 = "btn_t3_h1" Or btn2 = "btn_t2_h2" And btn1 = "btn_t3_h1" Then
            Return True
        ElseIf btn1 = "btn_t3_h2" And btn2 = "btn_t1_h1" Or btn2 = "btn_t3_h2" And btn1 = "btn_t1_h1" Then
            Return True
        ElseIf btn1 = "btn_t1_x1" And btn2 = "l1" Or btn2 = "btn_t1_x1" And btn1 = "l1" Then
            Return True
        ElseIf btn1 = "btn_t2_x1" And btn2 = "l2" Or btn2 = "btn_t2_x1" And btn1 = "l2" Then
            Return True
        ElseIf btn1 = "btn_t3_x1" And btn2 = "l3" Or btn2 = "btn_t3_x1" And btn1 = "l3" Then
            Return True
        ElseIf btn1 = "btn_t1_x2" And btn2 = "btn_t2_x1" Or btn2 = "btn_t1_x2" And btn1 = "btn_t2_x1" Then
            Return True
        ElseIf btn1 = "btn_t2_x2" And btn2 = "btn_t3_x1" Or btn2 = "btn_t2_x2" And btn1 = "btn_t3_x1" Then
            Return True
        ElseIf btn1 = "btn_t3_x2" And btn2 = "btn_t1_x1" Or btn2 = "btn_t3_x2" And btn1 = "btn_t1_x1" Then
            Return True
        Else
            counter = 0
            Return False
        End If
    End Function

    Public Function delta_wye_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)
                End If
                Dim result = delta_wye(btn1, btn2)

                If result = False Then
                    Return False
                    counter = 0
                    Exit For

                Else

                End If
                count = 0
            End If
        Next
        If counter < 12 Then
            Return "False"
            counter = 0
        Else
            Return "Delta Wye Connection"
        End If

    End Function

    Private Sub btn_l1red_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_l1red.MouseDown, btn_l1black.MouseDown, btn_l2red.MouseDown, btn_l2black.MouseDown, btn_l3red.MouseDown, btn_l3black.MouseDown
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
            Me.Refresh()
        End If
    End Sub

    Private Function delta_wye(btn1, btn2)
        counter = counter + 1
        If btn1 = "btn_t1_h1" And btn2 = "a" Or btn2 = "btn_t1_h1" And btn1 = "a" Then
            Return True
        ElseIf btn1 = "btn_t2_h1" And btn2 = "b" Or btn2 = "btn_t2_h1" And btn1 = "b" Then
            Return True
        ElseIf btn1 = "btn_t3_h1" And btn2 = "c" Or btn2 = "btn_t3_h1" And btn1 = "c" Then
            Return True
        ElseIf btn1 = "btn_t1_h2" And btn2 = "btn_t2_h1" Or btn2 = "btn_t1_h2" And btn1 = "btn_t2_h1" Then
            Return True
        ElseIf btn1 = "btn_t2_h2" And btn2 = "btn_t3_h1" Or btn2 = "btn_t2_h2" And btn1 = "btn_t3_h1" Then
            Return True
        ElseIf btn1 = "btn_t3_h2" And btn2 = "btn_t1_h1" Or btn2 = "btn_t3_h2" And btn1 = "btn_t1_h1" Then
            Return True
        ElseIf btn1 = "btn_t1_x1" And btn2 = "l1" Or btn2 = "btn_t1_x1" And btn1 = "l1" Then
            Return True
        ElseIf btn1 = "btn_t1_x2" And btn2 = "n" Or btn2 = "btn_t1_x2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t2_x1" And btn2 = "l2" Or btn2 = "btn_t1_x2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t2_x2" And btn2 = "n" Or btn2 = "btn_t1_x2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t3_x1" And btn2 = "l3" Or btn2 = "btn_t1_x2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t3_x2" And btn2 = "n" Or btn2 = "btn_t1_x2" And btn1 = "n" Then
            Return True
        Else
            counter = 0
            Return False
        End If
    End Function

    Public Function open_delta_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)
                End If
                Dim result = open_delta(btn1, btn2)

                If result = False Then
                    Return False
                    counter = 0
                    Exit For
                Else

                End If
                count = 0
            End If
        Next

        If counter < 9 Then
            Return "False"
        Else
            counter = 0
            Return "Open Delta Connection"
        End If

    End Function
    Private Function open_wye_open_delta(btn1, btn2)
        counter = counter + 1
        If btn1 = "btn_t1_h1" And btn2 = "a" Or btn2 = "btn_t1_h1" And btn1 = "a" Then
            Return True
        ElseIf btn1 = "btn_t1_h2" And btn2 = "n" Or btn2 = "btn_t1_h2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t2_h1" And btn2 = "b" Or btn2 = "btn_t2_h1" And btn1 = "b" Then
            Return True
        ElseIf btn1 = "btn_t2_h2" And btn2 = "n" Or btn2 = "btn_t2_h2" And btn1 = "n" Then
            Return True
        ElseIf btn1 = "btn_t1_x1" And btn2 = "l1" Or btn2 = "btn_t1_x1" And btn1 = "l1" Then
            Return True
        ElseIf btn1 = "btn_t2_x1" And btn2 = "l2" Or btn2 = "btn_t2_x1" And btn1 = "l2" Then
            Return True
        ElseIf btn1 = "btn_t2_x2" And btn2 = "l3" Or btn2 = "btn_t2_x2" And btn1 = "l3" Then
            Return True
        ElseIf btn1 = "btn_t1_x2" And btn2 = "btn_t2_x1" Or btn2 = "btn_t1_x2" And btn1 = "btn_t2_x1" Then
            Return True
        ElseIf btn1 = "btn_t2_x2" And btn2 = "btn_t1_x1" Or btn2 = "btn_t2_x2" And btn1 = "btn_t1_x1" Then
            Return True
        Else
            counter = 0
            Return False
        End If

    End Function

    Private Sub btn_vpblack_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_vpred.MouseDown, btn_vpblack.MouseDown, btn_vlblack.MouseDown, btn_vlred.MouseDown
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
                Me.Refresh()
            End If
        End If
    End Sub

    Public Function open_wye_open_delta_connection()
        Dim array_points = select_btn(transformer_id, table)
        Dim count_points = select_count_btn(transformer_id, table)

        points.Clear()

        Dim count As Integer = 0
        For i As Integer = 0 To count_points - 1
            Dim btn As String = array_points(i)
            Dim btn1, btn2 As String

            count = count + 1
            If count = 1 Then
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn1 = split_value(2).ToString
                Else
                    btn1 = array_points(i)
                End If
            Else
                If btn.Length > 9 Then
                    Dim split_value() As String = array_points(i).Split("_")
                    btn2 = split_value(2).ToString
                Else
                    btn2 = array_points(i)

                End If
                Dim result = open_wye_open_delta(btn1, btn2)

                If result = False Then
                    counter = 0
                    Return "False"
                    Exit For
                Else

                End If
                count = 0
            End If
        Next

        If counter < 9 Then
            Return "False"
        Else
            counter = 0
            Return "Open Wye Open Delta Connection"
        End If
    End Function

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Output.Show()
        Output.refresh_form(no, transformer_id)

    End Sub

    Private Function open_delta(btn1, btn2)
        counter = counter + 1
        If btn1 = "btn_t1_h1" And btn2 = "a" Or btn2 = "btn_t1_h1" And btn1 = "a" Then
            Return True
        ElseIf btn1 = "btn_t2_h1" And btn2 = "b" Or btn2 = "btn_t2_h1" And btn1 = "b" Then
            Return True
        ElseIf btn1 = "btn_t2_h2" And btn2 = "c" Or btn2 = "btn_t2_h2" And btn1 = "c" Then
            Return True
        ElseIf btn1 = "btn_t1_h2" And btn2 = "btn_t2_h1" Or btn2 = "btn_t1_h2" And btn1 = "btn_t2_h1" Then
            Return True
        ElseIf btn1 = "btn_t1_h2" And btn2 = "btn_t2_h1" Or btn2 = "btn_t1_h2" And btn1 = "btn_t2_h1" Then
            Return True
        ElseIf btn1 = "btn_t1_x1" And btn2 = "l1" Or btn2 = "btn_t1_x1" And btn1 = "l1" Then
            Return True
        ElseIf btn1 = "btn_t2_x1" And btn2 = "l2" Or btn2 = "btn_t2_x1" And btn1 = "l2" Then
            Return True
        ElseIf btn1 = "btn_t2_x2" And btn2 = "l3" Or btn2 = "btn_t2_x2" And btn1 = "l3" Then
            Return True
        ElseIf btn1 = "btn_t1_x2" And btn2 = "btn_t2_x1" Or btn2 = "btn_t1_x2" And btn2 = "btn_t2_x1" Then
            Return True
        Else
            counter = 0
            Return False
        End If
    End Function

    Private Function wye_bulb_connection()
        Dim query As String
        query = "select btn from " & table & " where clamp_meter::integer = 5 and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim count As Integer = 0
        For counter As Integer = 0 To dt.Rows.Count - 1
            Dim btn As String = dt.Rows(counter)(0)

            Dim btn1, btn2 As String

            count = count + 1

            If count = 1 Then
                Dim search = btn.IndexOf("black")
                If search = -1 Then
                    search = btn.IndexOf("red")
                    If search = -1 Then
                        Dim split_value() As String = btn.Split("_")
                        btn1 = split_value(2).ToString
                    Else
                        btn1 = btn
                    End If
                Else
                    btn1 = btn
                End If

            Else
                Dim search = btn.IndexOf("black")
                If search = -1 Then
                    search = btn.IndexOf("red")
                    If search = -1 Then
                        Dim split_value() As String = btn.Split("_")
                        btn2 = split_value(2).ToString
                    Else
                        btn2 = btn
                    End If
                Else
                    btn2 = btn
                End If

                Dim result = wye_bulb(btn1, btn2)
                btn1 = ""
                btn2 = ""
                If result = False Then
                    counter_bulb = 0
                    Return "False"
                    Exit For
                End If
                count = 0
            End If
        Next

        If counter_bulb < 6 Then
            counter_bulb = 0
            Return "False"
        Else
            Return "Wye Bulb"
        End If

    End Function

    Private Function wye_bulb(btn1, btn2)
        counter_bulb = counter_bulb + 1
        If btn1 = "l1" And btn2 = "btn_l1red" Or btn2 = "l1" And btn1 = "btn_l1red" Then
            Return True
        ElseIf btn1 = "n" And btn2 = "btn_l1black" Or btn2 = "n" And btn1 = "btn_l1black" Then
            Return True
        ElseIf btn1 = "l2" And btn2 = "btn_l2red" Or btn2 = "l2" And btn1 = "btn_l2red" Then
            Return True
        ElseIf btn1 = "n" And btn2 = "btn_l2black" Or btn2 = "n" And btn1 = "btn_l2black" Then
            Return True
        ElseIf btn1 = "l3" And btn2 = "btn_l3red" Or btn2 = "l3" And btn1 = "btn_l3red" Then
            Return True
        ElseIf btn1 = "n" And btn2 = "btn_l3black" Or btn2 = "n" And btn1 = "btn_l3black" Then
            Return True
        Else
            counter_bulb = 0
            Return False
        End If
    End Function

    Private Function delta_bulb_connection()
        Dim query As String
        query = "select btn from " & table & " where clamp_meter::integer = 5 and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim count As Integer = 0
        For counter As Integer = 0 To dt.Rows.Count - 1
            Dim btn As String = dt.Rows(counter)(0)

            Dim btn1, btn2 As String

            count = count + 1

            If count = 1 Then
                Dim search = btn.IndexOf("black")
                If search = -1 Then
                    search = btn.IndexOf("red")
                    If search = -1 Then
                        Dim split_value() As String = btn.Split("_")
                        btn1 = split_value(2).ToString
                    Else
                        btn1 = btn
                    End If
                Else
                    btn1 = btn
                End If

            Else
                Dim search = btn.IndexOf("black")
                If search = -1 Then
                    search = btn.IndexOf("red")
                    If search = -1 Then
                        Dim split_value() As String = btn.Split("_")
                        btn2 = split_value(2).ToString
                    Else
                        btn2 = btn
                    End If
                Else
                    btn2 = btn
                End If

                Dim result = delta_bulb(btn1, btn2)
                btn1 = ""
                btn2 = ""
                If result = False Then
                    counter_bulb = 0
                    Return "False"
                    Exit For
                End If
                count = 0
            End If
        Next

        If counter_bulb < 6 Then
            counter_bulb = 0
            Return "False"
        Else
            Return "Delta Bulb"
        End If

    End Function

    Private Function delta_bulb(btn1, btn2)
        counter_bulb = counter_bulb + 1
        If btn1 = "l1" And btn2 = "btn_l1red" Or btn2 = "l1" And btn1 = "btn_l1red" Then
            Return True
        ElseIf btn1 = "l2" And btn2 = "btn_l1black" Or btn2 = "l2" And btn1 = "btn_l1black" Then
            Return True
        ElseIf btn1 = "l2" And btn2 = "btn_l2red" Or btn2 = "l2" And btn1 = "btn_l2red" Then
            Return True
        ElseIf btn1 = "l3" And btn2 = "btn_l2black" Or btn2 = "l3" And btn1 = "btn_l2black" Then
            Return True
        ElseIf btn1 = "l3" And btn2 = "btn_l3red" Or btn2 = "l3" And btn1 = "btn_l3red" Then
            Return True
        ElseIf btn1 = "l1" And btn2 = "btn_l3black" Or btn2 = "l1" And btn1 = "btn_l3black" Then
            Return True
        Else
            counter_bulb = 0
            Return False
        End If

    End Function

    Private Sub computations(connection)
        Dim category As String
        Dim query = "select * from " & table & " where clamp_meter::integer >= 1 and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Dim ctr_clamp As Integer = 0
        Dim ctr_phase_current As Integer = 0
        Dim ctr_voltage_phase As Integer = 0
        Dim ctr_voltage_line As Integer = 0

        For counter As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(counter)(5) <> 2 And dt.Rows(counter)(5) <> 7 Then
                If dt.Rows(counter)(3).ToString = "" Then
                    'If dt.Rows(counter)(5) = 1 Or dt.Rows(counter)(5) = 1 Then
                    Dim split_value() As String = dt.Rows(counter)(1).Split("_")

                    Dim val As String = split_value(2).ToString

                    If val = "h1" Or val = "h2" Then
                        category = "primary"
                    Else
                        category = "secondary"
                    End If
                    'End If

                End If
            End If
            If dt.Rows(counter)(5) = 2 Then
                ctr_clamp = ctr_clamp + 1
            ElseIf dt.Rows(counter)(5) = 3 Then
                ctr_voltage_phase = ctr_voltage_phase + 1
            ElseIf dt.Rows(counter)(5) = 4 Then
                ctr_voltage_line = ctr_voltage_line + 1
            ElseIf dt.Rows(counter)(5) = 7 Then
                ctr_phase_current = ctr_phase_current + 1
            End If
        Next
        Dim primary_voltage, secondary_voltage, rating As Double
        Dim pie As Double = 1.732050808
        Dim ctr_apparent, ctr_real As Integer
        Dim result_rating = transformer_details.select_rating(transformer_id)
        If result_rating <> "No data" Then
            Dim split_value() As String = result_rating.Split(" ")
            rating = CDbl(split_value(0) * 1000)
        End If

        Dim result_primary = transformer_details.select_voltage_primary(transformer_id)
        If result_primary <> "No data" Then
            primary_voltage = result_primary
        End If

        Dim result_secondary = transformer_details.select_secondary_primary(transformer_id)
        If result_secondary <> "No data" Then
            secondary_voltage = result_secondary
        End If
        Dim cp, vl, cl, apparent, real As Double
        If connection = "Wye Wye Connection" Then

            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                vl = Math.Round((primary_voltage * pie), 2)
                apparent = Math.Round((3 * primary_voltage * cp), 2)
            ElseIf category = "secondary" Then
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                vl = Math.Round((secondary_voltage * pie), 2)
                real = Math.Round((((secondary_voltage * pie) * pie) * cp), 2)
            End If

            If ctr_clamp > 3 Then
                txt_cp.Text = cp.ToString
                txt_cl.Text = cp.ToString
                If category = "primary" Then

                    transformer_details.save(transformer_id, "primary_line_current", cp.ToString)
                    transformer_details.save(transformer_id, "primary_phase_current", cp.ToString)
                ElseIf category = "secondary" Then

                    transformer_details.save(transformer_id, "secondary_line_current", cp.ToString)
                    transformer_details.save(transformer_id, "secondary_phase_current", cp.ToString)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)

                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)

                End If
            End If

            If ctr_voltage_line > 3 Then
                txt_vl.Text = vl.ToString
                If category = "primary" Then
                    transformer_details.save(transformer_id, "primary_line_voltage", vl)
                ElseIf category = "secondary" Then
                    transformer_details.save(transformer_id, "secondary_line_voltage", vl)
                End If
            End If

            ctr_apparent = transformer_details.apparent_power(transformer_id)
            ctr_real = transformer_details.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)
            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                transformer_details.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)
            End If
        ElseIf connection = "Delta Delta Connection" Then
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                apparent = Math.Round((3 * primary_voltage * cp), 2)
            ElseIf category = "secondary" Then
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                real = Math.Round((((secondary_voltage * pie) * pie) * cp), 2)
            End If
            If ctr_clamp > 3 Then
                txt_cl.Text = cl.ToString
                If category = "primary" Then
                    transformer_details.save(transformer_id, "primary_line_current", cl)
                ElseIf category = "secondary" Then
                    transformer_details.save(transformer_id, "secondary_line_current", cl)
                End If
            End If
            If ctr_phase_current > 3 Then
                txt_cp.Text = cp.ToString
                If category = "primary" Then
                    transformer_details.save(transformer_id, "primary_phase_current", cp)

                ElseIf category = "secondary" Then
                    transformer_details.save(transformer_id, "secondary_phase_current", cp)
                End If
            End If

            If ctr_voltage_line > 3 Then
                If category = "primary" Then
                    txt_vl.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_line_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    txt_vl.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_line_voltage", primary_voltage)
                End If
            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)
                    txt_vp.Text = secondary_voltage
                End If

            End If

            ctr_apparent = transformer_details.apparent_power(transformer_id)
            ctr_real = transformer_details.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)
            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                transformer_details.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)
            End If

        ElseIf connection = "Delta Wye Connection" Then
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                'vl = Math.Round((primary_voltage * 1.73), 2)
                apparent = Math.Round((3 * primary_voltage * cp), 2)
            Else category = "secondary"
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                vl = Math.Round((secondary_voltage * pie), 2)
                real = Math.Round((((secondary_voltage * pie) * pie) * cp), 2)
            End If
            If ctr_clamp > 3 Then
                txt_cl.Text = cl.ToString

                If category = "primary" Then
                    transformer_details.save(transformer_id, "primary_line_current", cl)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cl.ToString
                    txt_cl.Text = cl.ToString
                    transformer_details.save(transformer_id, "secondary_line_current", cl)
                    transformer_details.save(transformer_id, "secondary_phase_current", cl)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)
                End If

            End If
            If ctr_voltage_line > 3 Then

                If category = "primary" Then
                    txt_vl.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_line_voltage", vl)
                ElseIf category = "secondary" Then
                    txt_vl.Text = vl.ToString
                    transformer_details.save(transformer_id, "secondary_line_voltage", vl)

                End If
            End If

            If ctr_phase_current > 3 Then

                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then

                End If
            End If

            ctr_apparent = transformer_details.apparent_power(transformer_id)
            ctr_real = transformer_details.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)
            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                transformer_details.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)
            End If

        ElseIf connection = "Wye Delta Connection" Then
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                vl = Math.Round((primary_voltage * 1.73), 2)
                apparent = Math.Round((3 * primary_voltage * cp), 2)
            Else category = "secondary"
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                cl = Math.Round(cp * pie, 2)
                'vl = Math.Round((secondary_voltage * 1.73), 2)
                real = Math.Round((((secondary_voltage * pie) * pie) * cp), 2)
            End If
            If ctr_clamp > 3 Then
                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                ElseIf category = "secondary" Then
                    txt_cl.Text = cl.ToString
                    transformer_details.save(transformer_id, "secondary_line_current", cl)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)
                End If

            End If
            If ctr_voltage_line > 3 Then

                If category = "primary" Then
                    txt_vl.Text = vl.ToString
                    transformer_details.save(transformer_id, "primary_line_voltage", vl)
                ElseIf category = "secondary" Then
                    txt_vl.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_line_voltage", secondary_voltage)
                End If
            End If

            If ctr_phase_current > 3 Then

                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cp.ToString
                    transformer_details.save(transformer_id, "secondary_phase_current", cp)
                End If
            End If
            ctr_apparent = transformer_details.apparent_power(transformer_id)
            ctr_real = transformer_details.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)
            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                result_model.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)
            End If
        ElseIf connection = "Open Delta Connection" Then
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                'cl = Math.Round(cp * 1.73, 2)
                'vl = Math.Round((primary_voltage * 1.73), 2)
                apparent = Math.Round((pie * primary_voltage * cp), 2)
            Else category = "secondary"
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                'cl = Math.Round(cp * 1.73, 2)
                'vl = Math.Round((secondary_voltage * 1.73), 2)
                real = Math.Round(((secondary_voltage * pie) * cp), 2)
            End If
            If ctr_clamp > 3 Then


                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "secondary_line_current", cp)
                    transformer_details.save(transformer_id, "secondary_phase_current", cp)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)
                End If

            End If
            If ctr_voltage_line > 3 Then

                If category = "primary" Then
                    txt_vl.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_line_voltage", primary_voltage)
                ElseIf category = "secondary" Then
                    txt_vl.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_line_voltage", secondary_voltage)

                End If
            End If

            If ctr_phase_current > 3 Then
                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                End If
            End If

            ctr_apparent = transformer_details.apparent_power(transformer_id)
            ctr_real = transformer_details.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)
            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                transformer_details.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)
            End If

        ElseIf connection = "Open Wye Open Delta Connection" Then
            If category = "primary" Then
                cp = Math.Round(CDbl(rating) / CDbl(primary_voltage), 2)
                'cl = Math.Round(cp * 1.73, 2)
                'vl = Math.Round((primary_voltage * 1.73), 2)
                apparent = Math.Round((pie * primary_voltage * cp), 2)
            Else category = "secondary"
                cp = Math.Round(CDbl(rating) / CDbl(secondary_voltage), 2)
                'cl = Math.Round(cp * 1.73, 2)
                'vl = Math.Round((secondary_voltage * 1.73), 2)
                real = Math.Round(((secondary_voltage * 1.73) * cp), 2)
            End If
            If ctr_clamp > 3 Then


                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "secondary_line_current", cp)
                    transformer_details.save(transformer_id, "secondary_phase_current", cp)
                End If

            End If
            If ctr_voltage_phase > 3 Then
                If category = "primary" Then
                    txt_vp.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_phase_voltage", primary_voltage)

                ElseIf category = "secondary" Then
                    txt_vp.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_phase_voltage", secondary_voltage)

                End If

            End If
            If ctr_voltage_line > 3 Then

                If category = "primary" Then
                    txt_vl.Text = primary_voltage
                    transformer_details.save(transformer_id, "primary_line_voltage", primary_voltage)

                ElseIf category = "secondary" Then
                    txt_vl.Text = secondary_voltage
                    transformer_details.save(transformer_id, "secondary_line_voltage", secondary_voltage)

                End If
            End If

            If ctr_phase_current > 3 Then
                If category = "primary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    transformer_details.save(transformer_id, "primary_line_current", cp)
                    transformer_details.save(transformer_id, "primary_phase_current", cp)
                ElseIf category = "secondary" Then
                    txt_cp.Text = cp.ToString
                    txt_cl.Text = cp.ToString
                    result_model.save(transformer_id, "secondary_line_current", cp)
                    transformer_details.save(transformer_id, "secondary_phase_current", cp)
                End If
            End If

            ctr_apparent = result_model.apparent_power(transformer_id)
            ctr_real = result_model.real_power(transformer_id)

            If ctr_apparent = 1 And category = "primary" Then
                txt_apparent.Text = apparent.ToString
                transformer_details.save(transformer_id, "apparent_power", apparent.ToString)
                convert_photo(category)

            End If

            If ctr_real = 1 And category = "secondary" Then
                txt_real.Text = real.ToString
                transformer_details.save(transformer_id, "real_power", real.ToString)
                convert_photo(category)

            End If
        End If
        done = transformer_details.select_specific(transformer_id)
        If done = 1 Then
            btn_done.Enabled = True
        End If


    End Sub

    Private Sub convert_photo(category)
        Using bm As New Bitmap(panel_activity.Width, panel_activity.Height, Imaging.PixelFormat.Format24bppRgb)
            panel_activity.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            bm.Save(appPath & "/exercise/" & "exercise_" & no & "_" & category & ".png", Imaging.ImageFormat.Jpeg)
        End Using
    End Sub
    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams


#End Region

End Class