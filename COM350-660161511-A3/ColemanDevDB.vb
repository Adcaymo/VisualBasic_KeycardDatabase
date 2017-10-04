Imports System.Data.SqlClient

Public Class ColemanDevDB

    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String =
            "Data Source=localhost\SqlExpress;" &
            "Initial Catalog=ColemanDevelopment;" &
            "Integrated Security=True"
        Return New SqlConnection(connectionString)
    End Function

End Class
