Public Class type_billet_class
    Dim id As Integer
    Dim designation As String

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Designation1 As String
        Get
            Return designation
        End Get
        Set(value As String)
            designation = value
        End Set
    End Property
End Class
