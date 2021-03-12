Module delta_delta_lines
    Public Class delta_delta
        Dim query As String
        Dim return_message As String
        'Public Function save_points(btn, points, color_pen, clamp_meter, transformer)
        '    query = "Insert Into delta_delta_lines
        '        (btn, points, color,clamp_meter,transformer_details_id) 
        '        Values(
        '         '" & btn & "','" & points.ToString & "', '" & color_pen.ToString & "','" & clamp_meter.ToString & "','" & transformer & "')"

        '    Dim da As New Odbc.OdbcDataAdapter(query, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    Return "1"
        'End Function

        Public Function select_delta_delta_points(transformer)
            Dim result As New List(Of String)

            query = "select * from delta_delta_lines where transformer_details_id = '" & transformer & "' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                result.Add(row.Item("points"))
            Next row

            Return result
        End Function

        Public Function select_count_delta_delta_points(transformer)
            Dim result As Integer

            query = "select * from delta_delta_lines where transformer_details_id = '" & transformer & "' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function

        Public Function select_color(transformer)
            Dim result As New List(Of String)

            query = "select * from delta_delta_lines where transformer_details_id = '" & transformer & "' order by id asc"
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
            query = "DELETE FROM delta_delta_lines WHERE id in (
                SELECT id FROM delta_delta_lines ORDER BY id desc LIMIT 1)"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
        End Sub

        Public Function select_points(transformer_btn, primary_btn, no)

            Dim result As New List(Of String)

            query = "select * from points where  (btn_2 = '" & primary_btn & "' and transformer_details_id = '" & transformer_details_id & "') or (btn_1 = '" & transformer_btn & "' and btn_2 = 'prim_" & no & "' and transformer_details_id = '" & transformer_details_id & ") order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                result.Add(row.Item("points"))
            Next row

            Return result

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

            query = "select * from delta_delta_lines where clamp_meter = '1' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function

        Public Sub update_clamp_no(no, transformer_id)
            query = "update delta_delta_lines set clamp_meter = '" & no.ToString & "' WHERE id in (
                SELECT id FROM delta_delta_lines where transformer_details_id = '" & transformer_id & "' ORDER BY id desc LIMIT 1)"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
        End Sub
    End Class


End Module
