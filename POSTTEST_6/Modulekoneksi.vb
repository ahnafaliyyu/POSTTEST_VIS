Imports MySql.Data.MySqlClient
Imports MySqlConnector

Module Modulekoneksi
    Public ReadOnly ConnectionString As String = "Server=localhost; Port=3306; Database=db_sembako; User ID=root; Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function
End Module