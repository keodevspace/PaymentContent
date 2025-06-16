Imports System.Data.SqlClient

Public Class PaymentService
    Private connectionString As String

    Public Sub New(connString As String)
        connectionString = connString
    End Sub

    Public Function ProcessPayment(payment As Payment) As Boolean
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("INSERT INTO Payments (Amount, Date) VALUES (@Amount, @Date)", connection)
            command.Parameters.AddWithValue("@Amount", payment.Amount)
            command.Parameters.AddWithValue("@Date", payment.Date)

            Dim result As Integer = command.ExecuteNonQuery()
            Return result > 0
        End Using
    End Function

    Public Function GetPayments() As List(Of Payment)
        Dim payments As New List(Of Payment)()

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("SELECT * FROM Payments", connection)
            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim payment As New Payment() With {
                        .Id = reader.GetInt32(0),
                        .Amount = reader.GetDecimal(1),
                        .Date = reader.GetDateTime(2)
                    }
                    payments.Add(payment)
                End While
            End Using
        End Using

        Return payments
    End Function
End Class