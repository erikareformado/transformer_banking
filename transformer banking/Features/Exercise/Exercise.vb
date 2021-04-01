Imports System.Drawing.Drawing2D

Public Class Exercise

    Dim exercise As New Exercises
    Dim no As Integer

    Dim point_x, point_y As Point
    Private Sub Exercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_form()
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H2000000
            Return cp
        End Get
    End Property 'CreateParams


#Region "sub"
    Public Sub refresh_form()
        no = Home.exam_no
        'Dim test = exercise.exercise_questions(no)
        'txt_exam.Text = test
    End Sub

    'Private Sub panel_activity_Paint(sender As Object, e As PaintEventArgs) Handles panel_activity.Paint
    '    Dim MPx As Point = MousePosition()
    '    txt_apparent.Text = MPx.ToString
    '    point_y = MPx

    '    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
    '    panel_activity.BringToFront()
    '    Dim pen_n = New Pen(Color.Red, 2)
    '    Dim point_w = New Point(0, 0)
    '    'point_w = (x = 0, y=0)

    '    e.Graphics.DrawLine(pen_n, point_w, MPx)
    'End Sub

    Private Sub btn_prim_n_1_Click(sender As Object, e As EventArgs) Handles btn_prim_n_1.Click
        point_x = btn_prim_n_1.Location
        Me.Refresh()
    End Sub

    Private Sub btn_prim_a_2_KeyDown(sender As Object, e As KeyEventArgs) Handles btn_prim_a_2.KeyDown

    End Sub

    Private Sub btn_prim_a_1_MouseClick(sender As Object, e As MouseEventArgs) Handles btn_prim_a_1.MouseClick

    End Sub

    Private Sub panel_activity_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_activity.MouseDown

    End Sub

    Private Sub panel_activity_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_activity.MouseMove
        MyBase.OnMouseMove(e)

        Me.startPoint = e.Location
        'Me.Invalidate()
        Me.Refresh()
    End Sub

    Private startPoint As System.Nullable(Of Point)
    Protected Overrides Sub OnPaint(e As PaintEventArgs)

        MyBase.OnPaint(e)
        If startPoint.HasValue Then
            Dim g As Graphics = e.Graphics
            g.SmoothingMode = SmoothingMode.AntiAlias
            'g.InterpolationMode = InterpolationMode.Low
            'g.CompositingQuality = CompositingQuality.HighSpeed
            'g.SmoothingMode = SmoothingMode.HighSpeed
            'g.PixelOffsetMode = PixelOffsetMode.HighSpeed
            'g.CompositingMode = CompositingMode.SourceCopy
            Using p As New Pen(Color.Black, 2.0F)


                g.DrawLine(p, startPoint.Value, New Point(100, 100))
            End Using
        End If
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)

    End Sub

    Private Sub panel_activity_MouseHover(sender As Object, e As EventArgs) Handles panel_activity.MouseHover

    End Sub


#End Region
End Class
