Public Class theatre_class
    Dim id As Integer
    Dim nom_theatre As String
    Dim description As String

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nom_theatre1 As String
        Get
            Return nom_theatre
        End Get
        Set(value As String)
            nom_theatre = value
        End Set
    End Property

    Public Property Description1 As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property
End Class
