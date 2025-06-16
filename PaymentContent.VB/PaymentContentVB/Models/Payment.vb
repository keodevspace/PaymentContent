Public Class Payment
    Public Property Id As Integer
    Public Property Amount As Decimal
    Public Property Date As DateTime
    Public Property CustomerId As Integer
    Public Property ProductId As Integer

    Public Sub New(id As Integer, amount As Decimal, date As DateTime, customerId As Integer, productId As Integer)
        Me.Id = id
        Me.Amount = amount
        Me.Date = date
        Me.CustomerId = customerId
        Me.ProductId = productId
    End Sub
End Class