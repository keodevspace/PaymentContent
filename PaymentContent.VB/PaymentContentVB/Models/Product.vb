Public Class Product
    Public Property Id As Integer
    Public Property Name As String
    Public Property Price As Decimal

    Public Sub New(id As Integer, name As String, price As Decimal)
        Me.Id = id
        Me.Name = name
        Me.Price = price
    End Sub
End Class