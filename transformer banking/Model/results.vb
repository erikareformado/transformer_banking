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
            Dim result As Integer

            query = "select * from results_activity where transformer_id = '" & transformer_id & "' "
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count = 1 Then
                If dt.Rows(0)(2).ToString <> "" And
                    dt.Rows(0)(3).ToString <> "" And
                dt.Rows(0)(4).ToString <> "" And
                dt.Rows(0)(5).ToString <> "" And
                dt.Rows(0)(6).ToString <> "" And
                dt.Rows(0)(7).ToString <> "" And
                dt.Rows(0)(8).ToString <> "" And
                dt.Rows(0)(9).ToString <> "" And
                dt.Rows(0)(10).ToString <> "" And
                dt.Rows(0)(11).ToString <> "" Then

                    result = 1
                Else
                    result = 0
                End If
            End If
            Return result

        End Function
        Public Function select_count(transformer_id)
            Dim result As String

            query = "select * from results_activity where transformer_details = '" & transformer_id & "' "
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            result = dt.Rows.Count

            Return result
        End Function
        Public Sub update(transformer_id, column, value)

            query = "update results_activity set " & column & "= " & value & " transformer_details = '" & value & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

        End Sub

        Public Function apparent_power(transformer_id)
            Dim result As Integer = 0

            query = "select * from results_activity where 
            primary_phase_current is not null
            and primary_line_current  is not null
            and primary_line_voltage  is not null
            and primary_phase_voltage  is not null 
            and transformer_id = '" & transformer_id & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                result = 1
            End If

            Return result
        End Function

        Public Function real_power(transformer_id)
            Dim result As Integer = 0

            query = "select * from results_activity where 
            secondary_phase_current is not null
            and secondary_line_current  is not null
            and secondary_line_voltage  is not null
            and secondary_phase_voltage  is not null 
            and transformer_id = '" & transformer_id & "'"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count <> 0 Then
                result = 1
            End If

            Return result
        End Function



    End Class



End Module
