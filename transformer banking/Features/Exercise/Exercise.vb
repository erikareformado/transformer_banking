Public Class Exercise
    Dim exercises As New exercises
    Dim no As Integer
    Private Sub Exercise_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh_form()
    End Sub


#Region "sub"
    Public Sub refresh_form()
        no = Home.exam_no
        Dim test = exercises.exercise_questions(no)
        txt_exam.Text = test
    End Sub
#End Region
End Class
