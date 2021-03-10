Module results
    Public Class results_activity
        Dim query As String
        Dim result As String
        Public Sub save(transformer_id, column, value)
            'MsgBox(transformer_id)
            Dim query_search = "select * from results_activity where transformer_id = '" & transformer_id & "' "
            Dim dt_search As New DataTable
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            da_search.Fill(dt_search)
            'MsgBox(dt_search.Rows.Count)

            If dt_search.Rows.Count = 0 Then
                query = "Insert into results_activity(transformer_id, " & column & ") values ( '" & transformer_id & "', '" & value & "')"
                Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
            Else
                query = "update results_activity set " & column & " = '" & value & "' where transformer_id = '" & transformer_id & "'"
                Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
            End If

        End Sub

        Public Function select_specific(transformer_id)
            Dim result As New List(Of String)

            query = "select * from activity_result where transformer_details = '" & transformer_id & "' "
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            Dim phase_current, line_current, line_voltage, phase_voltage, apparent_power, real_power As String

            If dt.Rows.Count = 1 Then
                phase_current = dt.Rows(0)(3).ToString
                line_current = dt.Rows(0)(4).ToString
                line_voltage = dt.Rows(0)(5).ToString
                phase_voltage = dt.Rows(0)(6).ToString
                apparent_power = dt.Rows(0)(7).ToString
                real_power = dt.Rows(0)(8).ToString
                result.Add(phase_current)
                result.Add(line_current)
                result.Add(line_voltage)
                result.Add(phase_voltage)
                result.Add(apparent_power)
                result.Add(real_power)
            Else
                result.Add("No data")
            End If

            Return result

        End Function
        Public Function select_count(transformer_id)
            Dim result As String

            query = "select * from activity_result where transformer_details = '" & transformer_id & "' "
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function
        Public Sub update(transformer_id, column, value)

            query = "update activity_result set " & column & "= " & value & " transformer_details = '" & value & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

        End Sub

    End Class



End Module
