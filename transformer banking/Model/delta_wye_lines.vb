Module delta_wye_lines
    Public Class delta_wye
        Dim query As String
        Dim return_message As String
        'Public Function save_points(btn, points, color_pen, clamp_meter, transformer)
        '    query = "Insert  into delta_wye_lines
        '        (btn, points, color,clamp_meter,transformer_details_id) 
        '        Values(
        '         '" & btn & "','" & points.ToString & "', '" & color_pen.ToString & "','" & clamp_meter.ToString & "','" & transformer & "')"

        '    Dim da As New Odbc.OdbcDataAdapter(query, conn)
        '    Dim dt As New DataTable
        '    da.Fill(dt)
        '    Return "1"
        'End Function

        Public Function select_delta_wye_points(transformer)
            Dim result As New List(Of String)

            query = "select * from delta_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                result.Add(row.Item("points"))
            Next row

            Return result
        End Function

        Public Function select_count_delta_wye_points(transformer)
            Dim result As Integer

            query = "select * from delta_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function

        Public Function select_color(transformer)
            Dim result As New List(Of String)

            query = "select * from delta_wye_lines where transformer_details_id = '" & transformer & "' order by id asc"
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
            query = "DELETE FROM delta_wye_lines WHERE id in (
                SELECT id FROM delta_wye_lines ORDER BY id desc LIMIT 1)"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
        End Sub


        Public Function select_clamp_count()
            Dim result As Integer

            query = "select * from delta_wye_lines where clamp_meter = '1' order by id asc"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function
    End Class
End Module
