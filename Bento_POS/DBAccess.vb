
'Programmed by Jiayi Wu
Imports System.Data.Odbc  'It is a namespace (library,module)
Public Class DBAccess
    'Declare variables
    Private ConnectionString As String = "Driver={MySQL ODBC 8.0 ANSI Driver}; server=141.209.241.47; database=sp2022bis698fc1g1; user=sp2022bis698fc1g1;password=Omicron"

    Private DBConnection As New OdbcConnection(ConnectionString)
    Private DBCommand As OdbcCommand          'A command is like "select * from customer"
    Public Params As New List(Of OdbcParameter)       'A parameter is a condition for a command, A parameter is like "Where first_name LIKE cath%"
    Public DBDataAdapter As OdbcDataAdapter     'It is an agent that carry out a command.

    Public DBDataTable As DataTable    'It is the container that takes data back and display.
    Public RecordCount As Integer     'how many records in the datatable
    Public DBException As String     'how many error?

    Public Sub ExecuteQuery(QueryString As String)
        RecordCount = 0
        DBException = String.Empty

        Try
            DBConnection.Open()    'open database
            DBCommand = New OdbcCommand(QueryString, DBConnection)

            For Each p As OdbcParameter In Params
                DBCommand.Parameters.Add(p)
            Next
            Params.Clear()

            DBDataTable = New DataTable
            DBDataAdapter = New OdbcDataAdapter(DBCommand)
            RecordCount = DBDataAdapter.Fill(DBDataTable)

        Catch ex As Exception
            DBException = ex.Message
        End Try

        If DBConnection.State = ConnectionState.Open Then
            DBConnection.Close()
        End If
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New OdbcParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class
