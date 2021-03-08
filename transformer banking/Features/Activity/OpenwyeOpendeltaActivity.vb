Imports System.Drawing.Drawing2D
Public Class OpenwyeOpendeltaActivity
    Dim appPath As String = Application.StartupPath()

    Dim openwye_opendelta_model As New openwye_opendelta


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

    Dim transformer_1, transformer_2 As String


    Dim pens As New Pen(Color.Red, 2)

    Dim ctr_cl_clamp As Integer = 0
    Private Sub btn_done_Click(sender As Object, e As EventArgs)
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub

    Private Sub OpenwyeOpendeltaActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


#Region "subs"
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
    Private Sub select_clamp_line()
        Dim query = "select * from delta_delta_lines where clamp_meter = '1' and transformer_details_id = '" & transformer_id & "' order by id asc"
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
        Dim query = "select * from delta_delta_lines where clamp_meter = '6' and transformer_details_id = '" & transformer_id & "' order by id asc"
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

    Public Sub get_point()
        Dim array_points = openwye_opendelta_model.select_openwye_opendelta_lines_points(transformer_id)
        Dim count_points = openwye_opendelta_model.select_count_openwye_opendelta_lines_points(transformer_id)
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

    Private Sub draw_lines(ByVal e As PaintEventArgs)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        get_point()
        Dim point_x, point_y As Point
        panel_activity.BringToFront()


        Dim count As Integer = 0
        Dim arry_color = openwye_opendelta_model.select_color(transformer_id)
        Dim colors_pen As String = ""
        For i As Integer = 0 To ctr_lines - 1

            count = count + 1


            If count = 1 Then
                point_x = points.Item(i)
                colors_pen = arry_color(i)
            ElseIf count = 2 Then
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

#End Region
End Class
