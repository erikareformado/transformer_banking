Imports System.Drawing.Drawing2D

Public Class WyeWyeActivity
    Dim ctr As Integer = 0
    Dim ctr_lines As Integer = 0
    Dim ctr_points As Integer = 0

    Dim point1_x As Integer
    Dim point1_y As Integer

    Dim point2_x As Integer
    Dim point2_y As Integer

    Dim point_1 As Point
    Dim point_2 As Point

    Dim points As New List(Of Point)
    Dim arry_ctr_points As New List(Of String)

    Dim btn_remove As New Button()

    Dim clamp_meter As Integer = 0

    Dim vp As Integer ' for computation
    Dim category_1 As String 'primary/secondary
    Dim category_2 As String 'primary/secondary

    Dim color_str As String
    Dim btn_primary, btn_transformer As String

    Dim pens As New Pen(Color.Red, 2)

    Private Sub DeltaWyeActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dbopen()
        get_point()
    End Sub
    'primary
    Private Sub btn_prim_a1_Click(sender As Object, e As EventArgs) Handles btn_prim_a_1.Click, btn_prim_a_2.Click, btn_prim_a_3.Click, btn_prim_a_4.Click, btn_prim_a_5.Click, btn_prim_a_6.Click,
                                                                            btn_prim_b_1.Click, btn_prim_b_2.Click, btn_prim_b_3.Click, btn_prim_b_4.Click, btn_prim_b_5.Click, btn_prim_b_6.Click,
                                                                            btn_prim_c_1.Click, btn_prim_c_2.Click, btn_prim_c_3.Click, btn_prim_c_4.Click, btn_prim_c_5.Click, btn_prim_c_6.Click,
                                                                            btn_prim_n_1.Click, btn_prim_n_2.Click, btn_prim_n_3.Click, btn_prim_n_4.Click, btn_prim_n_5.Click, btn_prim_n_6.Click


        Dim myButton As Button = CType(sender, Button)
        'category = "primary"
        btn_primary = myButton.Name
        Dim split_value() As String = btn_primary.Split("_")
        Dim btn_color = split_value(2).ToString
        Dim pen_color As String
        'MsgBox(color.ToString)
        If btn_color = "a" Then
            pen_color = "Red"
        ElseIf btn_color = "b"
            pen_color = "Blue"
        ElseIf btn_color = "c"
            pen_color = "Yellow"
        Else
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
            If category_1 = category_2 Then
                ctr_lines = ctr_lines - 2
                points.RemoveAt(ctr_lines)
                MsgBox("Cannot Connect! Please select other connection.", MsgBoxStyle.Exclamation)
            Else
                counter_2(myButton.Name, pen_color, clamp_meter)
            End If
            ctr = 0
            Me.Refresh()

        End If
    End Sub
    'transformer primary
    Private Sub btn_t1_h1_Click(sender As Object, e As EventArgs) Handles btn_t1_h1.Click, btn_t1_h2.Click, btn_t2_h1.Click, btn_t2_h2.Click, btn_t3_h2.Click, btn_t3_h1.Click
        'Dim myButton As Button = CType(sender, Button)
        'category = "primary"
        'btn_transformer = myButton.Name
        'point1_x = panel_activity.Controls.Item(myButton.Name).Location.X + panel_activity.Controls.Item(myButton.Name).Width / 2
        'point1_y = panel_activity.Controls.Item(myButton.Name).Location.Y + panel_activity.Controls.Item(myButton.Name).Height / 2

        'TextBox3.Text = "{x=" & point1_x.ToString & ",y=" & point1_y.ToString & "}"
        'get_points_primary()
        'If ctr = 1 Then

        'Else
        '    'points.Add(select_points(btn_primary, btn_transformer, "primary_" & no(3)))
        '    ctr = 0
        '    ctr_lines = 5
        'End If

        '
        'Dim myButton As Button = CType(sender, Button)
        ''Dim myName As String =
        'ctr = ctr + 1
        'ctr_lines = ctr_lines + 1
        'If ctr = 1 Then
        '    category_1 = "primary_transformer"
        '    Dim color_pen As String = ""
        '    ctr_points = ctr_points + 1
        '    counter_1(myButton.Name, color_pen)

        'Else
        '    category_2 = "primary_transformer"
        '    If category_1 = category_2 Then
        '        ctr_lines = ctr_lines - 2
        '        points.RemoveAt(ctr_lines)
        '        delete_unwanted_connection()
        '        MsgBox("Cannot Connect! Please select other connection.", MsgBoxStyle.Exclamation)
        '    Else
        '        Dim color_pen As String = ""
        '        counter_2(myButton.Name, color_pen)
        '    End If
        '    ctr = 0
        '    Me.Refresh()

        'End If
    End Sub
    'voltage
    Private Sub btn_cp_red_Click(sender As Object, e As EventArgs) Handles btn_cp_red.Click, btn_cp_black.Click
        'Dim myButton As Button = CType(sender, Button)
        ''Dim myName As String =
        'ctr = ctr + 1
        'ctr_lines = ctr_lines + 1
        'If ctr = 1 Then
        '    ctr_points = ctr_points + 1
        '    'counter_1(myButton.Name)

        'Else
        '    'counter_2(myButton.Name)
        '    ctr = 0
        '    Me.Refresh()
        '    'If category = "Primary" Then
        '    '    txt_cl.Text = "460 V"
        '    'End If

        'End If

    End Sub
    'Clamp
    Private Sub btn_clamp_red_Click(sender As Object, e As EventArgs) Handles btn_clamp_red.Click, btn_clamp_black.Click
        'Dim myButton As Button = CType(sender, Button)
        ''Dim myName As String =
        'ctr = ctr + 1
        'ctr_lines = ctr_lines + 1
        'If ctr = 1 Then
        '    ctr_points = ctr_points + 1
        '    'counter_1(myButton.Name)

        'Else

        '    'counter_2(myButton.Name)
        '    ctr = 0
        '    Me.Refresh()
        'End If

        ''If txt Then

    End Sub
    Private Sub panel_activity_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_activity.MouseDown
        If e.Button = MouseButtons.Left Then
            Dim loc As New Point(e.X, e.Y)
            TextBox2.Text = loc.ToString
            If clamp_meter = 1 Then
                ''point1_x = panel_activity.Controls.Item("").Location.X + panel_activity.Controls.Item(btn_name).Width / 2
                Dim b_x = e.X + 41
                Dim b_y = e.Y + 13

                Dim r_x = e.X + 41
                Dim r_y = e.Y + 37

                Dim location As New Point(e.X, e.Y)
                Dim b_location As New Point(b_x, b_y)
                Dim r_location As New Point(r_x, r_y)
                'picbox_clamp_meter.Location = panel_activity.Cursor.Position
                btn_clamp_meter.Location = location
                btn_clamp_black.Location = b_location
                btn_clamp_red.Location = r_location

            Else

            End If
            'TextBox2.Text = panel_activity.MousePosition.ToString
        End If


    End Sub

    Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
        draw_lines(e)
        'Dim pens As New Pen(Color.Red)

        'Dim points_one As New List(Of Point)
        'Dim point1 As New Point(268, 33)
        'Dim point2 As New Point(261, 35)
        'Dim point3 As New Point(681, 405)
        'Dim point4 As New Point(553, 405)
        'Dim point5 As New Point(142, 166)
        'points_one.Add(point1)
        'points_one.Add(point2)
        'points_one.Add(point3)
        'points_one.Add(point4)
        'points_one.Add(point5)

        'point_1 = New Point(point1_x, point1_y)
        'point_2 = New Point(point2_x, point2_y)
        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
        'DataGridView1.Columns.Add("points", "points")
        'e.Graphics.DrawLines(pens, points_one)
        'e.Graphics.DrawLine(pens, point1, point2)
        'e.Graphics.DrawLine(pens, point2, point3)
        'e.Graphics.DrawLine(pens, point3, point4)
        'e.Graphics.DrawLine(pens, point4, point5)


    End Sub


    Private Sub btn_vp_black_Click(sender As Object, e As EventArgs) Handles btn_vp_black.Click, btn_vp_red.Click
        Dim myButton As Button = CType(sender, Button)
        'Dim myName As String =
        ctr = ctr + 1
        vp = vp + 1

        If vp = 2 Then
            vp = 0
            txt_vp.Text = "4160 V"
        End If

        ctr_lines = ctr_lines + 1
        If ctr = 1 Then
            ctr_points = ctr_points + 1
            'counter_1(myButton.Name)

        Else

            'counter_2(myButton.Name)
            ctr = 0
            Me.Refresh()
        End If
    End Sub
    Private Sub picbox_clamp_meter_Click(sender As Object, e As EventArgs) Handles picbox_clamp_meter.Click
        clamp_meter = 1
    End Sub
    Private Sub Button75_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Home.Hide()
        transformer_banking_connections.Show()


        'DataGridView1.Rows.Add(points.Item(i))
        'MsgBox(point_x & "," & point_y)


    End Sub

#Region "subs"
    Public Sub get_point()
        'Dim array_points = select_wye_wye_points(transformer_id)
        'Dim count_points = select_count_wye_wye_points(transformer_id)
        'ctr_lines = count_points
        'For i As Integer = 0 To count_points - 1
        '    Dim value = array_points(i).ToString
        '    'Dim value_points As New Point(value)
        '    Dim split_value() As String = value.Split(",")
        '    Dim x = split_value(0)
        '    Dim y = split_value(1)
        '    Dim value_point As New Point(x, y)

        '    points.Add(value_point)
        'Next
        'Me.Refresh()

    End Sub
    Public Sub get_points_primary()
        ctr = ctr + 1

        If ctr = 1 Then

        Else
            If category_1 = "primary" Then
                Dim Str As String = btn_primary.ToString
                Dim str_no() As String = Str.Split("_")
                Dim no = str_no(3)

                'Dim arry_points = select_points(btn_transformer, btn_primary, no)
                'Dim arry_count = select_points_count(btn_transformer, btn_primary, no)
                'MsgBox(arry_points(0).ToString)
                ''ListBox1.Items.Add(arry_points())
                Dim for_count As Integer = 0
                'ctr_lines = arry_count
                '    For i As Integer = 0 To arry_count - 1
                '        for_count += 1
                '        Dim value As String = arry_points(i).ToString
                '        'MsgBox(for_count.ToString)
                '        If for_count > 2 Then
                '            value = arry_points(i - 1).ToString

                '            Dim split_value() As String = value.Split(",")
                '            Dim x = split_value(0)
                '            Dim y = split_value(1)
                '            Dim value_point As New Point(x, y)

                '            points.Add(value_point)
                '            ctr_lines = ctr_lines + 1
                '            ListBox1.Items.Add(value.ToString)

                '            value = arry_points(i).ToString
                '            split_value = value.Split(",")
                '            x = split_value(0)
                '            y = split_value(1)
                '            value_point = New Point(x, y)

                '            points.Add(value_point)
                '            ctr_lines = ctr_lines + 1
                '            ListBox1.Items.Add(value.ToString)
                '        Else
                '            value = arry_points(i).ToString

                '            Dim split_value() As String = value.Split(",")
                '            Dim x = split_value(0)
                '            Dim y = split_value(1) - for_count

                '            Dim value_point As New Point(x, y)

                '            points.Add(value_point)
                '            ctr_lines = ctr_lines + 1
                '            ListBox1.Items.Add(value.ToString)
                '        End If



                '    Next

            End If
            Me.Refresh()
            ctr = 0
            'ctr_lines = 5
        End If
    End Sub
    Private Sub counter_1(btn_name, pen_color, clamp)
        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        TextBox3.Text = "{x=" & point1_x.ToString & ",y=" & point1_y.ToString & "}"
        point_1 = New Point(point1_x, point1_y)
        'Dim result = save_points(btn_name, point1_x & "," & point1_y, pen_color, clamp)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'Dim result = save_points(point_1.ToString, ctr_lines)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'point_1 = New Point(367, 139)
        points.Add(point_1)
        'points.Add(268, 33)
    End Sub
    Private Sub counter_2(btn_name, pen_color, clamp)
        point2_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point2_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2
        point_2 = New Point(point2_x, point2_y)
        TextBox3.Text = "{x=" & point2_x.ToString & ",y=" & point2_y.ToString & "}"
        'Dim result = save_points(btn_name, point2_x & "," & point2_y, pen_color, clamp)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'point_2 = New Point(142, 139)

        points.Add(point_2)
    End Sub

    Private Sub draw_lines(ByVal e As PaintEventArgs)
        'counter_1()
        'counter_2()
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        'pens.DashCap
        'pens.Width = 2.0

        panel_activity.BringToFront()

        'point_1 = New Point(point1_x, point1_y)
        'point_2 = New Point(point2_x, point2_y)
        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
        'DataGridView1.Columns.Add("points", "points")
        Dim count As Integer = 0
        'Dim arry_color = select_color()
        'Dim colors_pen As String = ""
        'For i As Integer = 0 To ctr_lines - 1
        '    Dim x = -1
        '    count = count + 1


        '    If count = 1 Then
        '        point_x = points.Item(i)
        '        colors_pen = arry_color(i)
        '    ElseIf count = 2
        '        point_y = points.Item(i)
        '        If colors_pen = "" Then
        '            colors_pen = arry_color(i)
        '        End If

        '        MsgBox(colors.ToString)
        '        If colors_pen = "Red" Then
        '            Dim pen_a = New Pen(Color.Red, 2)
        '            e.Graphics.DrawLine(pen_a, point_x, point_y)
        '        ElseIf colors_pen = "Blue" Then
        '            Dim pen_b = New Pen(Color.Blue, 2)
        '            e.Graphics.DrawLine(pen_b, point_x, point_y)
        '        ElseIf colors_pen = "Yellow" Then
        '            Dim pen_c = New Pen(Color.Yellow, 2)
        '            e.Graphics.DrawLine(pen_c, point_x, point_y)
        '        Else
        '            Dim pen_n = New Pen(Color.Black, 2)
        '            e.Graphics.DrawLine(pen_n, point_x, point_y)
        '        End If


        '        count = 0
        '        Me.Refresh()
        '        ListBox1.Items.Add(point_x.ToString & " " & point_y.ToString)
        '    End If

        '    DataGridView1.Rows.Add(points.Item(i))
        '    MsgBox(point_x & "," & point_y)
        'Next

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
