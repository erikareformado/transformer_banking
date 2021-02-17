Module transformer_details
    Dim query As String
    Dim return_message As String
    Public transformer_details_id As Integer


    Public Function save_transformer_details(polarity, rating, connection_type)
        Dim query_search = "select * from transformer_details where polarity = '" & polarity & "'and rating = '" & rating & "' and connection = '" & connection_type & "'"
        Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
        Dim dt_search As New DataTable
        da_search.Fill(dt_search)

        If dt_search.Rows.Count = 0 Then
            query = "Insert Into transformer_details
                (polarity, rating, connection) 
                Values(
                 '" & polarity & "','" & rating & "', '" & connection_type & "')"

            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
        End If

        Return "1"
    End Function
    Public Function search_transformer_id(polarity, rating, connection_type)
        Dim query_search = "select * from transformer_details where polarity = '" & polarity & "' and rating = '" & rating & "' and connection = '" & connection_type & "'"
        Dim da_search As New Odbc.OdbcDataAdapter(query_search, conn)
        Dim dt_search As New DataTable
        da_search.Fill(dt_search)

        If dt_search.Rows.Count = 1 Then
            transformer_details_id = dt_search(0)(0).ToString
            Return transformer_details_id
        End If

    End Function

End Module
