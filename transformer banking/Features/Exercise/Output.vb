Imports Excel = Microsoft.Office.Interop.Excel
Public Class Output
    Dim exercise As New exercise_details
    Dim appPath As String = Application.StartupPath()

    Dim no As Integer
    Private Sub Output_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
    End Sub
    Public Sub refresh_form(exam_no, transformer_id)

        no = exam_no
        lbl_exam.Text = "Exam " & exam_no
        Dim test = exercise.exercise_questions(exam_no)
        txt_exam.Text = test

        pic_primary.Image = Image.FromFile(appPath & "\exercise\exercise_" & exam_no & "_primary.png")
        pic_primary.SizeMode = PictureBoxSizeMode.Zoom

        pic_secondary.Image = Image.FromFile(appPath & "\exercise\exercise_" & exam_no & "_secondary.png")
        pic_secondary.SizeMode = PictureBoxSizeMode.Zoom

        get_data(transformer_id)
    End Sub

    Private Sub get_data(transformer_id)
        Dim query = "select * from results_exercises where  transformer_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count <> 0 Then
            txt_measure_cp.Text = dt.Rows(0)(2)
            txt_measure_cl.Text = dt.Rows(0)(3)
            txt_measure_vl.Text = dt.Rows(0)(4)
            txt_measure_vp.Text = dt.Rows(0)(5)
            txt_measure_apparent.Text = dt.Rows(0)(6)

            txt_measure_sec_real.Text = dt.Rows(0)(7)
            txt_measure_sec_cp.Text = dt.Rows(0)(8)
            txt_measure_sec_cl.Text = dt.Rows(0)(9)
            txt_measure_sec_vl.Text = dt.Rows(0)(10)
            txt_measure_sec_vp.Text = dt.Rows(0)(11)
        End If
    End Sub

    Private Sub txt_computed_vl_TextChanged(sender As Object, e As EventArgs) Handles txt_computed_vl.TextChanged, txt_computed_vp.TextChanged, txt_computed_cp.TextChanged, txt_computed_cl.TextChanged, txt_computed_apparent.TextChanged

        Dim txt As TextBox = CType(sender, TextBox)
        Dim txt_name As String = txt.Name

        Dim difference As Double
        Dim percent As Integer = 100
        If txt.Text <> "" Then

            If txt_name = "txt_computed_vl" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_vl.Text)) / CDbl(txt.Text)) * 100
                txt_difference_vl.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_vp" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_vp.Text)) / CDbl(txt.Text)) * 100
                txt_difference_vp.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_cl" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_cl.Text)) / CDbl(txt.Text)) * 100
                txt_difference_cl.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_cp" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_cp.Text)) / CDbl(txt.Text)) * 100
                txt_difference_cp.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_apparent" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_apparent.Text)) / CDbl(txt.Text)) * 100
                txt_difference_apparent.Text = Math.Round(difference, 2) & "%"
            End If
        End If


    End Sub

    Private Sub txt_computed_sec_vl_TextChanged(sender As Object, e As EventArgs) Handles txt_computed_sec_vl.TextChanged, txt_computed_sec_vp.TextChanged, txt_computed_sec_cp.TextChanged, txt_computed_sec_cl.TextChanged, txt_computed_sec_real.TextChanged
        Dim txt As TextBox = CType(sender, TextBox)
        Dim txt_name As String = txt.Name

        Dim difference As Double
        Dim percent As Integer = 100
        If txt.Text <> "" Then

            If txt_name = "txt_computed_sec_vl" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_sec_vl.Text)) / CDbl(txt.Text)) * percent
                txt_difference_sec_vl.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_sec_vp" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_sec_vp.Text)) / CDbl(txt.Text)) * percent
                txt_difference_sec_vp.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_sec_cp" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_sec_cp.Text)) / CDbl(txt.Text)) * percent
                txt_difference_sec_cp.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_sec_cl" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_sec_cl.Text)) / CDbl(txt.Text)) * percent
                txt_difference_sec_cl.Text = Math.Round(difference, 2) & "%"
            ElseIf txt_name = "txt_computed_sec_real" Then
                difference = ((CDbl(txt.Text) - CDbl(txt_measure_sec_real.Text)) / CDbl(txt.Text)) * percent
                txt_difference_real.Text = Math.Round(difference, 2) & "%"
            End If
        End If

    End Sub

    Private Sub btn_done_Click(sender As Object, e As EventArgs) Handles btn_done.Click
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet

        xlApp = New Excel.Application

        xlWorkBook = xlApp.Workbooks.Open(appPath & "/exercise/output.xlsx")
        xlWorkSheet = xlWorkBook.Worksheets("sheet1")

        xlWorkSheet.Range("C1").Value = txt_name.Text
        xlWorkSheet.Range("C2").Value = txt_srcode.Text
        xlWorkSheet.Range("I1").Value = txt_section.Text
        xlWorkSheet.Range("I2").Value = dt_date.Text

        xlWorkSheet.Range("D3").Value = "Exercise" & no
        xlWorkSheet.Range("C4").Value = txt_exam.Text


        xlWorkSheet.Shapes.AddPicture(appPath & "\exercise\exercise_" & no & "_primary.png", False, True, 15, 200, 228, 150)
        xlWorkSheet.Shapes.AddPicture(appPath & "\exercise\exercise_" & no & "_secondary.png", False, True, 250, 200, 228, 150)

        xlWorkSheet.Range("C28").Value = txt_measure_vl.Text
        xlWorkSheet.Range("D28").Value = txt_measure_vp.Text
        xlWorkSheet.Range("E28").Value = txt_measure_cl.Text
        xlWorkSheet.Range("F28").Value = txt_measure_cp.Text
        xlWorkSheet.Range("H28").Value = txt_measure_apparent.Text

        xlWorkSheet.Range("C29").Value = txt_computed_vl.Text
        xlWorkSheet.Range("D29").Value = txt_computed_vp.Text
        xlWorkSheet.Range("E29").Value = txt_computed_cl.Text
        xlWorkSheet.Range("F29").Value = txt_computed_cp.Text
        xlWorkSheet.Range("H29").Value = txt_computed_apparent.Text

        xlWorkSheet.Range("C30").Value = txt_difference_vl.Text
        xlWorkSheet.Range("D30").Value = txt_difference_vp.Text
        xlWorkSheet.Range("E30").Value = txt_difference_cl.Text
        xlWorkSheet.Range("F30").Value = txt_difference_cp.Text
        xlWorkSheet.Range("H30").Value = txt_difference_apparent.Text

        xlWorkSheet.Range("C34").Value = txt_measure_sec_vl.Text
        xlWorkSheet.Range("D34").Value = txt_measure_sec_vp.Text
        xlWorkSheet.Range("E34").Value = txt_measure_sec_cl.Text
        xlWorkSheet.Range("F34").Value = txt_measure_sec_cp.Text
        xlWorkSheet.Range("H34").Value = txt_measure_sec_real.Text

        xlWorkSheet.Range("C35").Value = txt_computed_sec_vl.Text
        xlWorkSheet.Range("D35").Value = txt_computed_sec_vp.Text
        xlWorkSheet.Range("E35").Value = txt_computed_sec_cl.Text
        xlWorkSheet.Range("F35").Value = txt_computed_sec_cp.Text
        xlWorkSheet.Range("H35").Value = txt_computed_sec_real.Text

        xlWorkSheet.Range("C36").Value = txt_difference_sec_vl.Text
        xlWorkSheet.Range("D36").Value = txt_difference_sec_vp.Text
        xlWorkSheet.Range("E36").Value = txt_difference_sec_cl.Text
        xlWorkSheet.Range("F36").Value = txt_difference_sec_cp.Text
        xlWorkSheet.Range("H36").Value = txt_difference_real.Text



        xlWorkSheet.SaveToPdf(appPath & "/exercise/exercise " & no & ".pdf")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub




End Class