Imports MySql.Data.MySqlClient

Public Class SQLManager

    Private Connection As New MySqlConnection With {.ConnectionString = "host = localhost; username = root; password = xaixle64 ; database = mydb;"}
    Public Command As MySqlCommand
    Public Adapter As MySqlDataAdapter
    Public Table As DataTable
    Public Parameters As New List(Of MySqlParameter) 'Collection of Sql Parameters




    'Check if theres a Connection or Not
    Public Function HasConnection() As Boolean
        Try
            Connection.Open()

            Connection.Close()
            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return False
    End Function


    Public Sub AddParam(Name As String, Value As Object, Optional DataType As DbType = DbType.String)
        Dim newParam As New MySqlParameter With {.ParameterName = Name, .Value = Value, .DbType = DataType}
        Parameters.Add(newParam)
    End Sub

    Public Sub RunQuery(Query As String)
        Try
            Connection.Open()
            Command = New MySqlCommand(Query, Connection)

            For Each p In Parameters
                Command.Parameters.Add(p)
                Command.Parameters(p.ParameterName).Value = p.Value
            Next

            'FIll Data Table
            Adapter = New MySqlDataAdapter(Command)
            Table = New DataTable
            Adapter.Fill(Table)
            Connection.Close()
        Catch ex As Exception
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
                MsgBox("Query Failed: " & ex.Message)
            End If

        End Try
        FlushParams()
    End Sub

    Public Sub FlushParams()
        Parameters.Clear()
    End Sub


End Class
