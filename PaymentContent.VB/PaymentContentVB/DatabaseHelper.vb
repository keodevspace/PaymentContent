Imports System.Data.SqlClient

Public Class DatabaseHelper
    Private connectionString As String

    Public Sub New(connString As String)
        connectionString = connString
    End Sub

    Public Function ExecuteQuery(query As String) As DataTable
        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)

            connection.Open()
            adapter.Fill(dataTable)
        End Using

        Return dataTable
    End Function

    Public Sub ExecuteNonQuery(query As String)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)

            connection.Open()
            command.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class