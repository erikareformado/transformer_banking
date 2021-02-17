Imports System.Drawing.Drawing2D
Public Class DeltaDeltaActivity
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
    Dim category As String 'primary/secondary

    Dim btn_primary, btn_transformer As String
    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Home.Hide()
        transformer_banking_connections.Show()
    End Sub

    Private Sub btn_prim_a_1_Click(sender As Object, e As EventArgs) Handles btn_prim_a_1.Click
        Dim myButton As Button = CType(sender, Button)
        category = "primary"
        btn_primary = myButton.Name

        ctr = ctr + 1
        ctr_lines = ctr_lines + 1
        If ctr = 1 Then
            ctr_points = ctr_points + 1
            counter_1(myButton.Name)

        Else
            counter_2(myButton.Name)
            ctr = 0
            Me.Refresh()

        End If
    End Sub

    Private Sub btn_t1_h1_Click(sender As Object, e As EventArgs) Handles btn_t1_h1.Click
        Dim myButton As Button = CType(sender, Button)
        category = "primary"
        btn_primary = myButton.Name

        ctr = ctr + 1
        ctr_lines = ctr_lines + 1
        If ctr = 1 Then
            ctr_points = ctr_points + 1
            counter_1(myButton.Name)

        Else
            counter_2(myButton.Name)
            ctr = 0
            Me.Refresh()

        End If
    End Sub
    Private Sub DeltaDeltaActivity_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
        draw_lines(e)
    End Sub

#Region "subs"
    Private Sub counter_1(btn_name)
        point1_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point1_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2

        TextBox3.Text = "{x=" & point1_x.ToString & ",y=" & point1_y.ToString & "}"
        point_1 = New Point(point1_x, point1_y)
        'Dim result = save_points(point_1.ToString, ctr_lines)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'point_1 = New Point(367, 139)
        points.Add(point_1)
        'points.Add(268, 33)
    End Sub
    Private Sub counter_2(btn_name)
        point2_x = panel_activity.Controls.Item(btn_name).Location.X + panel_activity.Controls.Item(btn_name).Width / 2
        point2_y = panel_activity.Controls.Item(btn_name).Location.Y + panel_activity.Controls.Item(btn_name).Height / 2
        point_2 = New Point(point2_x, point2_y)
        TextBox3.Text = "{x=" & point2_x.ToString & ",y=" & point2_y.ToString & "}"
        'Dim result = save_points(point_2.ToString, ctr_lines)

        'If result <> "1" Then
        '    MsgBox(result.ToString)
        'End If
        'point_2 = New Point(142, 139)

        points.Add(point_2)
    End Sub



    Private Sub draw_lines(ByVal e As PaintEventArgs)
        'counter_1()
        'counter_2()
        Dim pens As New Pen(Color.Black)
        pens.Width = 1.0

        Dim point_x, point_y As Point
        panel_activity.BringToFront()

        'point_1 = New Point(point1_x, point1_y)
        'point_2 = New Point(point2_x, point2_y)
        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
        'DataGridView1.Columns.Add("points", "points")
        Dim count As Integer = 0
        For i As Integer = 0 To ctr_lines - 1

            count = count + 1
            If count = 1 Then
                point_x = points.Item(i)
            ElseIf count = 2
                point_y = points.Item(i)
                e.Graphics.DrawLine(pens, point_x, point_y)
                count = 0
                'Me.Refresh()
                ListBox1.Items.Add(point_x.ToString & " " & point_y.ToString)
            End If

            'DataGridView1.Rows.Add(points.Item(i))
            'MsgBox(point_x & "," & point_y)
        Next

        'e.Graphics.DrawLine(pens, point_1, point_2)
    End Sub
#End Region
End Class
