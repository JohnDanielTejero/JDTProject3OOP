Public Class ConnectionDb
    Private Const CONNOLEDB4 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=../../CaribeanAdventures.mdb"
    Private Const CONNOLEDB12 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../CaribeanAdventures.mdb"

    Private con As OleDb.OleDbConnection
    Sub New()
        Try
            Using connection As New OleDb.OleDbConnection(CONNOLEDB12)
                connection.Open()
                Console.WriteLine("Connection has been established!!")
                con = New OleDb.OleDbConnection(CONNOLEDB12)
            End Using
        Catch ex As Exception
            'Console.WriteLine(ex.Message)
            Using connection As New OleDb.OleDbConnection(CONNOLEDB4)
                connection.Open()
                Console.WriteLine("Connection has been established!!")
                con = New OleDb.OleDbConnection(CONNOLEDB4)
            End Using
        End Try
    End Sub

    'table = table name
    'columnName = column names of the table
    'dataList = data to be inserted on the column
    'returns TRUE if insertion is successful
    Public Function insert(table As String, columnName As List(Of String), dataList As List(Of Object)) As Boolean
        Dim query = "INSERT INTO " & table & "("
        Dim values = " VALUES ("
        Dim index = 1

        For Each column As String In columnName
            If index <> columnName.Count Then
                query &= "[" & column & "], "
                values &= "@" & column & ", "
            Else
                query &= "[" & column & "])"
                values &= "@" & column & ")"
            End If
            index += 1
        Next

        query &= values
        Using con
            Dim command As New OleDb.OleDbCommand()
            command.Connection = con

            For i As Integer = 0 To dataList.Count - 1
                command.Parameters.AddWithValue("@" & columnName(i), dataList(i))
            Next

            Try
                con.Open()
                command.CommandText = query
                Dim result = command.ExecuteNonQuery()
                Console.WriteLine(result & " rows was affected")
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.WriteLine("Could not execute sql query: " & query)
            End Try

        End Using
        Return False
    End Function

    Public Function getAllDataOf(table As String, columnIdentifier As String, columnValue As String) As Dictionary(Of String, Object)
        Dim data As New Dictionary(Of String, Object)

        Using con
            Dim command As New OleDb.OleDbCommand()
            command.Connection = con
            command.CommandText = "SELECT * FROM " & table & " WHERE [" & columnIdentifier & "] = " & columnValue

            Try
                con.Open()
                Dim reader = command.ExecuteReader
                While reader.Read
                    For i = 0 To reader.FieldCount - 1
                        data.Add(i, reader.Item(i))
                    Next
                End While
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.WriteLine("failed to execute query: " & command.CommandText)
            End Try
        End Using
        Return data
    End Function

    Public Function getDataFrom(table As String, columns As List(Of String), columnid As String, columndata As Object) As Dictionary(Of String, Object)
        Dim query = "SELECT "
        For i = 0 To columns.Count - 1
            If i <> columns.Count - 1 Then
                query &= "[" & columns.Item(i) & "], "
            Else
                query &= "[" & columns.Item(i) & "] FROM " & table & " WHERE [" & columnid & "] = @" & columnid
            End If
        Next

        Dim data As New Dictionary(Of String, Object)
        Using con
            Dim command As New OleDb.OleDbCommand()
            command.Connection = con
            command.Parameters.AddWithValue(columnid, columndata)
            command.CommandText = query
            Try
                con.Open()
                Dim reader = command.ExecuteReader()
                While reader.Read()
                    For i = 0 To reader.FieldCount - 1
                        data.Add(columns(i), reader.Item(i))
                    Next
                End While
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.WriteLine("failed to execute query: " & command.CommandText)
            End Try
        End Using
        Return data
    End Function
    'table = table name
    'gridview = the Data Grid View on the form
    Public Sub getUpdatedTable(table As String, gridview As DataGridView)
        Dim newAdapter As New OleDb.OleDbDataAdapter
        Dim newTable As New DataTable
        Dim newSource As New BindingSource

        Using con
            newAdapter.SelectCommand = New OleDb.OleDbCommand("SELECT * FROM " & table, con)
            newAdapter.Fill(newTable)
            newSource.DataSource = newTable
            gridview.DataSource = newSource
            newAdapter.Update(newTable)
        End Using
    End Sub

    Public Sub searchTable(table As String, gridview As DataGridView, whereclause As String)
        Dim newAdapter As New OleDb.OleDbDataAdapter
        Dim newTable As New DataTable
        Dim newSource As New BindingSource

        Using con
            newAdapter.SelectCommand = New OleDb.OleDbCommand("SELECT * FROM " & table & " WHERE " & whereclause, con)
            Console.WriteLine("search query: " & newAdapter.SelectCommand.CommandText)
            newAdapter.Fill(newTable)
            newSource.DataSource = newTable
            gridview.DataSource = newSource
            newAdapter.Update(newTable)
        End Using
    End Sub



    'table = table name
    'id = id value
    'column = column name to be used in where clause
    Public Function deleteData(table As String, id As Integer, column As String) As Boolean
        Dim query = "DELETE FROM " & table & " WHERE " & column & " = " & id
        Return deleteResult(query)
    End Function

    'table = table name
    'ids = collection of ids to delete
    'column = column to be used in where clause
    Public Function deleteData(table As String, ids As Integer(), column As String) As Boolean
        Dim query = "DELETE FROM " & table & " WHERE " & column & " IN ("
        Dim index = 1
        For Each id In ids
            If index <> ids.Count Then
                query &= id & ", "
            Else
                query &= id & ")"
            End If
            index += 1
        Next
        Return deleteResult(query)
    End Function

    Private Function deleteResult(query As String) As Boolean

        Using con
            Dim command As New OleDb.OleDbCommand()
            command.Connection = con
            command.CommandText = query
            Try
                con.Open()
                Dim result = command.ExecuteNonQuery()
                Console.WriteLine(result & " rows has been affected")
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.WriteLine("Could not execute sql query: " & command.CommandText)
            End Try
        End Using
        Return False
    End Function

    'table = table name
    'columnNames = column names of the rows
    'data = data of the columns
    'idColumn = column name that will be used in where clause
    'idValue = value of the column that will be used in where clause
    Public Function updateData(table As String, columnNames As List(Of String), data As List(Of Object), idColumn As String, idValue As Integer)
        Dim query = "UPDATE " & table & " SET "
        Dim index = 0
        For Each column As String In columnNames
            If index <> columnNames.Count - 1 Then
                query &= "[" & column & "] = " & "@" & column & ", "
            Else
                query &= "[" & column & "] = " & "@" & column
            End If
            index += 1
        Next

        Using con

            Dim command As New OleDb.OleDbCommand()
            command.Connection = con
            For i = 0 To columnNames.Count - 1
                command.Parameters.AddWithValue("@" & columnNames(i), data(i))
            Next


            query &= " WHERE " & idColumn & " = " & idValue

            Try
                con.Open()
                command.CommandText = query
                Dim res = command.ExecuteNonQuery()
                Console.WriteLine(res & " rows has been affected")
                Return True
            Catch ex As Exception
                Console.WriteLine(ex.Message)
                Console.WriteLine("Could not execute sql query: " & command.CommandText)
            End Try
        End Using
        Return False
    End Function



End Class
