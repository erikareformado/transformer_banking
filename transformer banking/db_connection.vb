Imports System.IO

Module db_connection
    Dim appPath As String = Application.StartupPath()
    'Public constr As String = "Data source = 10.51.6.31; Initial Catalog = mydb; User ID = sa; password = ftec@1966;Connect Timeout=500;Pooling=False"
    Public constrpg As String = File.ReadAllText(appPath & "/path/pg_connection.txt")

    Public conn As New Odbc.OdbcConnection(constrpg)

    Public Sub dbopen()
        Try
            conn.Open()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
