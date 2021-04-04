Module exercise_transformer
    Public Class exercise_transformer_details
        Dim query As String
        Dim return_message As String
        Public transformer_details_id As Integer
        Public Function save_transformer_details(polarity, rating, no, primary_voltage, secondary_voltage)
            Dim query_search = "select * from exercise_transformer_details where polarity = '" & polarity & "'and rating = '" & rating & "' and 
        exercise_no = '" & no & "' and primary_voltage = '" & primary_voltage & "' and secondary_voltage = '" & secondary_voltage & "'"
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            Dim dt_search As New DataTable
            da_search.Fill(dt_search)

            If dt_search.Rows.Count = 0 Then
                query = "Insert Into exercise_transformer_details
                (polarity, rating, exercise_no, primary_voltage, secondary_voltage) 
                Values(
                 '" & polarity & "','" & rating & "', '" & no & "','" & primary_voltage & "', '" & secondary_voltage & "')"

                Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
            End If
            conn.Close()
            Return "1"
        End Function
        Public Function search_transformer_id(polarity, rating, no, primary_voltage, secondary_voltage)
            Dim query_search = "select * from exercise_transformer_details where polarity = '" & polarity & "' and rating = '" & rating & "' and exercise_no = '" & no & "' and primary_voltage = '" & primary_voltage & "' and secondary_voltage = '" & secondary_voltage & "'"
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            Dim dt_search As New DataTable
            da_search.Fill(dt_search)

            If dt_search.Rows.Count <> 0 Then
                transformer_details_id = dt_search(0)(0).ToString
                Return transformer_details_id
            Else
                Return 0
            End If

        End Function

        Public Function select_voltage_primary(transformer_id)
            Dim query_search = "select primary_voltage from exercise_transformer_details where id = '" & transformer_id & "'"
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            Dim dt_search As New DataTable
            da_search.Fill(dt_search)

            If dt_search.Rows.Count <> 0 Then
                Return dt_search(0)(0).ToString
            Else
                Return "No data"
            End If
        End Function
        Public Function select_secondary_primary(transformer_id)
            Dim query_search = "select secondary_voltage from exercise_transformer_details where id = '" & transformer_id & "'"
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            Dim dt_search As New DataTable
            da_search.Fill(dt_search)

            If dt_search.Rows.Count <> 0 Then
                Return dt_search(0)(0).ToString
            Else
                Return "No data"
            End If
        End Function

        Public Function select_rating(transformer_id)

            Dim query_search = "select rating from exercise_transformer_details where id = '" & transformer_id & "'"
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            Dim dt_search As New DataTable
            da_search.Fill(dt_search)

            If dt_search.Rows.Count <> 0 Then
                Return dt_search(0)(0).ToString
            Else
                Return "No data"
            End If
        End Function

        Public Sub save(transformer_id, column, value)
            'MsgBox(transformer_id)
            Dim query_search = "select * from results_exercises where transformer_id = '" & transformer_id & "' "
            Dim dt_search As New DataTable
            Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
            da_search.Fill(dt_search)
            'MsgBox(dt_search.Rows.Count)

            If dt_search.Rows.Count = 0 Then
                query = "Insert into results_exercises(transformer_id, " & column & ") values ( '" & transformer_id & "', '" & value & "')"
                Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
            Else
                query = "update results_exercises set " & column & " = '" & value & "' where transformer_id = '" & transformer_id & "'"
                Dim da As New Odbc.OdbcDataAdapter(query, conn)
                Dim dt As New DataTable
                da.Fill(dt)
            End If

        End Sub
        Public Function apparent_power(transformer_id)
            Dim result As Integer = 0

            query = "select * from results_exercises where 
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

            query = "select * from results_exercises where 
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
        Public Function select_specific(transformer_id)
            Dim result As Integer

            query = "select * from results_exercises where transformer_id = '" & transformer_id & "' "
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
    End Class

End Module
