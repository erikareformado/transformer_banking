Module results
    Public Class activity_result
        Dim query As String
        Dim result As String
        Public Function save(transformer_id, column, value)

            query = "Insert into activity_result(transformer_details, connection, " & column & ") values ( '" & transformer_id & "', '" & value & "')"
            Dim da As New Odbc.OdbcDataAdapter(query, conn)
            Dim dt As New DataTable
            da.Fill(dt)
            Return "1"

        End Function

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
