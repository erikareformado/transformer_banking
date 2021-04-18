Imports Microsoft.Office.Interop
Module transformer_details
    Dim query As String
    Dim return_message As String
    Public transformer_details_id As Integer

    Public Function save_transformer_details(polarity, rating, connection_type, primary_voltage, secondary_voltage)
        Dim query_search = "select * from transformer_details where polarity = '" & polarity & "'and rating = '" & rating & "' and 
        connection = '" & connection_type & "' and primary_voltage = '" & primary_voltage & "' and secondary_voltage = '" & secondary_voltage & "'"
        Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
        Dim dt_search As New DataTable
        da_search.Fill(dt_search)

        If dt_search.Rows.Count = 0 Then
            query = "Insert Into transformer_details
                (polarity, rating, connection, primary_voltage, secondary_voltage) 
                Values(
                 '" & polarity & "','" & rating & "', '" & connection_type & "','" & primary_voltage & "', '" & secondary_voltage & "')"

            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
        End If
        conn.Close()
        Return "1"
    End Function

    Public Function update_transformer(transformer_id, polarity, rating, connection_type, primary_voltage, secondary_voltage)
        Dim query_search = "select * from transformer_details where id = '" & transformer_id & "'"
        Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
        Dim dt_search As New DataTable
        da_search.Fill(dt_search)

        If dt_search.Rows.Count <> 0 Then
            query = "update transformer_details set
                polarity = '" & polarity & "', rating = '" & rating & "', connection = '" & connection_type & "', primary_voltage ='" & primary_voltage & "', secondary_voltage = '" & secondary_voltage & "'
               where id = '" & transformer_id & "'"

            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            conn.Close()
            Return "1"
        End If

    End Function

    Public Function search_transformer_id(polarity, rating, connection_type, primary_voltage, secondary_voltage)
        Dim query_search = "select * from transformer_details where polarity = '" & polarity & "' and rating = '" & rating & "' and connection = '" & connection_type & "' and primary_voltage = '" & primary_voltage & "' and secondary_voltage = '" & secondary_voltage & "'"
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
        Dim query_search = "select primary_voltage from transformer_details where id = '" & transformer_id & "'"
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
        Dim query_search = "select secondary_voltage from transformer_details where id = '" & transformer_id & "'"
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

        Dim query_search = "select rating from transformer_details where id = '" & transformer_id & "'"
        Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
        Dim dt_search As New DataTable
        da_search.Fill(dt_search)

        If dt_search.Rows.Count <> 0 Then
            Return dt_search(0)(0).ToString
        Else
            Return "No data"
        End If
    End Function


End Module
