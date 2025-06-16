Public Class Customer
    Public Property Id As Integer
    Public Property Name As String
    Public Property Email As String

    Public Sub New(id As Integer, name As String, email As String)
        Me.Id = id
        Me.Name = name
        Me.Email = email
    End Sub
End Class