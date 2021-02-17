Imports System.Drawing.Drawing2D
Public Class Test
    'Dim pens As New Pen(Color.Red, 5)
    Dim pens As New Pen(Color.Red, 5)
    Dim point1 As New Point
    Dim point2 As New Point
    Dim ctr As Integer = 0
    'Private polygon As New List(Of List(Of Point))
    'Private new_polygon As List(Of Point) = Nothing
    Private new_point As Point
    Dim x As Point
    Dim y As Point
    Dim btn As Integer = 0


    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        ''pens.DashStyle = DashStyle.Dash 'pen will draw with a dashed line
        'pens.EndCap = LineCap.ArrowAnchor 'the line will end in an arrow
        'pens.StartCap = LineCap.Round 'The line draw will start rounded
        'pens.Brush = Brushes.Brown
        ''*Notice* - the Start and End Caps will not show if you draw a closed shape


    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = MouseButtons.Left Then
            ctr = ctr + 1
            If ctr = 1 Then
                x = e.Location
                TextBox1.Text = x.ToString
            Else
                y = e.Location
                Dim graphics As Graphics = PictureBox1.CreateGraphics

                graphics.DrawLine(pens, x, y)

                ctr = 0
                btn = 0
                TextBox2.Text = y.ToString

            End If
        End If
    End Sub

    Private Sub btn_connect_Click(sender As Object, e As EventArgs) Handles btn_connect.Click
        btn = 1
    End Sub

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        'pens.EndCap = LineCap.ArrowAnchor 'the line will end in an arrow
        'pens.StartCap = LineCap.Round 'The line draw will start rounded

        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        condition(Button1.Name)

    End Sub
    Dim point1_x As Integer
    Dim point1_y As Integer

    Dim point2_x As Integer
    Dim point2_y As Integer
    Private Sub condition(btn_name)
        ctr = ctr + 1
        'Dim crl As Control
        If ctr = 1 Then
            point1_x = Panel1.Controls.Item(btn_name).Location.X + Panel1.Controls.Item(btn_name).width / 2
            point1_y = Panel1.Controls.Item(btn_name).Location.Y + Panel1.Controls.Item(btn_name).Height / 2

            'Button1.Location.X +Button1.Width / 2

            'TextBox1.Text = Panel1.Controls.Item(btn_name).Location.ToString()
            'point1 = Panel1.Controls.Item(btn_name).Location
        Else
            point2_x = Panel1.Controls.Item(btn_name).Location.X + Panel1.Controls.Item(btn_name).width / 2
            point2_y = Panel1.Controls.Item(btn_name).Location.Y + Panel1.Controls.Item(btn_name).Height / 2
            'TextBox2.Text = Panel1.Controls.Item(btn_name).Location.ToString()
            'point2 = Panel1.Controls.Item(btn_name).Location
            ctr = 0
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        condition(Button2.Name)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        pens.EndCap = LineCap.Round
        'the line will end in an arrow
        pens.StartCap = LineCap.Round 'The line draw will start rounded

        e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
    End Sub

    Private Sub Test_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'pens.EndCap = LineCap.ArrowAnchor 'the line will end in an arrow
        'pens.StartCap = LineCap.Round 'The line draw will start rounded

        'e.Graphics.DrawLine(pens, point1_x, point1_y, point2_x, point2_y)
    End Sub
    'Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
    '    If (new_polygon Is Nothing) Then
    '        Exit Sub
    '    End If
    '    new_point = e.Location
    '    PictureBox1.Invalidate()
    'End Sub

    'Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
    '    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    '    e.Graphics.Clear(PictureBox1.BackColor)

    '    For Each polygons As List(Of Point) In polygon
    '        e.Graphics.FillPolygon(Brushes.White, polygons.ToArray)
    '        e.Graphics.DrawPolygon(Pens.Blue, polygons.ToArray)
    '    Next polygons

    '    If new_polygon IsNot Nothing Then
    '        If (new_polygon.Count > 1) Then
    '            e.Graphics.DrawLines(Pens.Green, new_polygon.ToArray())
    '        End If

    '        If new_polygon.Count > 0 Then
    '            Using dash_pen As New Pen(Color.Green)
    '                dash_pen.DashPattern = New Single() {3, 3}
    '                e.Graphics.DrawLine(dash_pen, new_polygon(new_polygon.Count - 1), new_point)
    '            End Using

    '        End If
    '    End If
    'End Sub
End Class
