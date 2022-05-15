Public Class salle_class
    Dim id As Integer
    Dim nom_salle As String
    Dim chaise_disponible As Integer

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nom_salle1 As String
        Get
            Return nom_salle
        End Get
        Set(value As String)
            nom_salle = value
        End Set
    End Property

    Public Property Chaise_disponible1 As Integer
        Get
            Return chaise_disponible
        End Get
        Set(value As Integer)
            chaise_disponible = value
        End Set
    End Property
End Class
