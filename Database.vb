Imports System.Data
Imports MySql.Data.MySqlClient

Namespace RegistrarDocumentRequestSystem
    Public Module Database
        Private Function ReadSetting(name As String, defaultValue As String) As String
            Dim value = Environment.GetEnvironmentVariable(name)
            Return If(String.IsNullOrWhiteSpace(value), defaultValue, value.Trim())
        End Function

        Private Function BuildConnectionString() As String
            Dim port As UInteger = 3306UI
            UInteger.TryParse(ReadSetting("REGISTRAR_DB_PORT", "3306"), port)

            Dim builder As New MySqlConnectionStringBuilder With {
                .Server = ReadSetting("REGISTRAR_DB_SERVER", "localhost"),
                .Port = port,
                .Database = ReadSetting("REGISTRAR_DB_NAME", "registrar_db"),
                .UserID = ReadSetting("REGISTRAR_DB_USER", "root"),
                .Password = ReadSetting("REGISTRAR_DB_PASSWORD", String.Empty),
                .SslMode = MySqlSslMode.Preferred,
                .AllowUserVariables = False
            }
            Return builder.ConnectionString
        End Function

        Public Function GetConnection() As MySqlConnection
            Return New MySqlConnection(BuildConnectionString())
        End Function

        Public Function GetTable(sql As String,
                                 Optional parameters As IDictionary(Of String, Object) = Nothing) As DataTable
            Dim table As New DataTable()
            Using connection = GetConnection(), command As New MySqlCommand(sql, connection)
                AddParameters(command, parameters)
                connection.Open()
                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                End Using
            End Using
            Return table
        End Function

        Public Function Execute(sql As String,
                                Optional parameters As IDictionary(Of String, Object) = Nothing) As Integer
            Using connection = GetConnection(), command As New MySqlCommand(sql, connection)
                AddParameters(command, parameters)
                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Function

        Public Function Scalar(sql As String,
                               Optional parameters As IDictionary(Of String, Object) = Nothing) As Object
            Using connection = GetConnection(), command As New MySqlCommand(sql, connection)
                AddParameters(command, parameters)
                connection.Open()
                Return command.ExecuteScalar()
            End Using
        End Function

        Public Sub AddParameters(command As MySqlCommand,
                                 parameters As IDictionary(Of String, Object))
            If parameters Is Nothing Then Return
            For Each item In parameters
                command.Parameters.AddWithValue(item.Key, If(item.Value, DBNull.Value))
            Next
        End Sub

        Public Function ConnectionSummary() As String
            Return ReadSetting("REGISTRAR_DB_SERVER", "localhost") & ":" &
                   ReadSetting("REGISTRAR_DB_PORT", "3306") & "/" &
                   ReadSetting("REGISTRAR_DB_NAME", "registrar_db")
        End Function
    End Module
End Namespace
