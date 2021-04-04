Module wye_wye_lines

    Dim query As String
    Dim return_message As String

    Public Function save_points(btn, points, color_pen, clamp_meter, transformer, table)

        query = "Insert Into " & table & " (btn, points, color,clamp_meter,transformer_details_id) 
                Values(
                 '" & btn & "','" & points.ToString & "', '" & color_pen.ToString & "','" & clamp_meter.ToString & "','" & transformer & "')"

        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        Return "1"


    End Function

    Public Function select_points(transformer, table)
        Dim result As New List(Of String)

        query = "select * from " & table & " where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            result.Add(row.Item("points"))
        Next row

        Return result
    End Function

    Public Function select_btn(transformer, table)
        Dim result As New List(Of String)

        query = "select * from " & table & " where transformer_details_id = '" & transformer & "' and clamp_meter::integer = 0 order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            result.Add(row.Item("btn"))
        Next row

        Return result
    End Function
    Public Function select_count_points(transformer, table)
        Dim result As Integer

        query = "select * from " & table & " where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        result = dt.Rows.Count

        Return result
    End Function
    Public Function select_color(transformer, table)
        Dim result As New List(Of String)

        query = "select * from " & table & " where transformer_details_id = '" & transformer & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Dim value = row.Item("color")
            result.Add(value.ToString)

        Next row

        Return result
    End Function
    Public Sub delete_unwanted_connection(transformer, table)
        query = "DELETE FROM " & table & " WHERE id in (
                SELECT id FROM " & table & " where transformer_details_id = '" & transformer & "' ORDER BY id desc LIMIT 1)"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
    End Sub
    Public Function select_count_btn(transformer, table)
        Dim result As Integer

        query = "select * from " & table & " where transformer_details_id = '" & transformer & "' and clamp_meter::integer = 0 order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        result = dt.Rows.Count

        Return result
    End Function

    Public Function select_clamp_count(transformer_id, table)
        Dim result As Integer

        query = "select * from " & table & " where clamp_meter = '1' and transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)

        result = dt.Rows.Count

        Return result
    End Function

    Public Sub update_clamp_no(no, transformer_id, table)
        query = "update " & table & " set clamp_meter = '" & no.ToString & "' WHERE id in (
                SELECT id FROM " & table & " where transformer_details_id = '" & transformer_id & "' ORDER BY id desc LIMIT 1)"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
    End Sub
    'Public Function select_clamp_count(table, transformer_id)
    '    Dim result As Integer

    '    query = "select * from " & table & " where clamp_meter = '1' and transformer_details_id = '" & transformer_id & "'  order by id asc"
    '    Dim da As New Odbc.OdbcDataAdapter(query, conn)
    '    Dim dt As New DataTable
    '    da.Fill(dt)

    '    result = dt.Rows.Count

    '    Return result
    'End Function

    Public Sub delete_connections(btn, transformer_id, table)
        Dim query, query_delete As String
        query = "select * from " & table & " where transformer_details_id = '" & transformer_id & "' order by id asc"
        Dim da As New Odbc.OdbcDataAdapter(query, conn)
        Dim dt As New DataTable
        da.Fill(dt)
        For counter As Integer = 0 To dt.Rows.Count - 1

            If dt.Rows(counter)(1) = btn.ToString Then
                If counter = 0 Then

                    query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter + 1)(0) & "')"
                    Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                    Dim dt_delete As New DataTable
                    da_delete.Fill(dt_delete)

                ElseIf counter = dt.Rows.Count - 1 Then

                    query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                    Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                    Dim dt_delete As New DataTable
                    da_delete.Fill(dt_delete)
                Else
                    If dt.Rows(counter - 1)(3) = "" Then
                        'MsgBox(dt.Rows(counter)(0).ToString)
                        query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter + 1)(0) & "')"
                        Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                        Dim dt_delete As New DataTable
                        da_delete.Fill(dt_delete)

                    ElseIf dt.Rows(counter + 1)(3) = "" Then
                        query_delete = "delete from " & table & " where id in ('" & dt.Rows(counter)(0) & "', '" & dt.Rows(counter - 1)(0) & "')"
                        Dim da_delete As New Odbc.OdbcDataAdapter(query_delete, conn)
                        Dim dt_delete As New DataTable
                        da_delete.Fill(dt_delete)
                    End If
                End If
                Exit For
            End If
        Next
    End Sub

End Module
