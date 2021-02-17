Module wye_wye_lines

    Dim query As String
    Dim return_message As String

    Public Function save_points(btn, points, color_pen, clamp_meter, transformer)
        'Try

        'Dim duplicate = select_duplicate(str_points, line_no)

        'If duplicate = 1 Then
        query = "Insert Into wye_wye_lines
                (btn, points, color,clamp_meter,transformer_details_id) 
                Values(
                 '" & btn & "','" & points.ToString & "', '" & color_pen.ToString & "','" & clamp_meter.ToString & "','" & transformer & "')"

        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return "1"
        'Else
        '    Return "Cannot connect same line."
        'End If


        'Catch ex As Exception
        '    Return ex.ToString
        'End Try

    End Function

    Public Function select_points_1(line_no)
        Try
            Dim result As New List(Of String)
            query = "select * from wye_wye_lines where line_no = '" & line_no & "'"

            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                result.Add(row.Item("points"))
            Next row

            Return result
        Catch ex As Exception
            Return return_message = ex.ToString
        End Try
    End Function

    Public Function select_duplicate(str_points, line_no)
        query = "select * from wye_wye_lines where line_no = '" & line_no & "' and points = '" & str_points & "'"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        If dt.Rows.Count = 0 Then
            Return 1
        Else
            Return 0
        End If
    End Function
    Public Function select_wye_wye_points(transformer)
        Dim result As New List(Of String)

        query = "select * from wye_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            result.Add(row.Item("points"))
        Next row

        Return result
    End Function
    Public Function select_count_wye_wye_points(transformer)
        Dim result As Integer

        query = "select * from wye_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        result = dt.Rows.Count

        Return result
    End Function
    Public Function select_color(transformer)
        Dim result As New List(Of String)

        query = "select * from wye_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Dim value = row.Item("color")
            result.Add(value.ToString)

        Next row

        Return result
    End Function
    Public Sub delete_unwanted_connection()
        query = "DELETE FROM wye_wye_lines WHERE id in (
                SELECT id FROM wye_wye_lines ORDER BY id desc LIMIT 1)"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
    End Sub
    Public Function select_points(transformer_btn, primary_btn, no)
        'Try
        Dim result As New List(Of String)
        'query = "select * from points where btn_1 = '" & transformer_btn & "' and btn_2 = '" & primary_btn & "' or btn_2 = 'prim_" & no & "' order by id asc"
        query = "select * from points where  (btn_2 = '" & primary_btn & "' and transformer_details_id = '" & transformer_details_id & "') or (btn_1 = '" & transformer_btn & "' and btn_2 = 'prim_" & no & "' and transformer_details_id = '" & transformer_details_id & ") order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            result.Add(row.Item("points"))
        Next row

        Return result
        'Catch ex As Exception
        'Return return_message = ex.ToString
        'End Try
    End Function
    Public Function select_points_count(transformer_btn, primary_btn, no)
        'Try
        Dim result As New List(Of String)
        query = "select * from points where  (btn_2 = '" & primary_btn & "' and transformer_details_id = '" & transformer_details_id & "') or (btn_1 = '" & transformer_btn & "' and btn_2 = 'prim_" & no & "' and transformer_details_id = '" & transformer_details_id & ") order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        Return dt.Rows.Count
    End Function
    Public Function select_clamp_count()
        Dim result As Integer

        query = "select * from wye_wye_lines where clamp_meter = '1' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        result = dt.Rows.Count

        Return result
    End Function

End Module
