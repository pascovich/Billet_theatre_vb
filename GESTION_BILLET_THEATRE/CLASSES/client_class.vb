Public Class client_class
    Dim id As Integer
    Dim nom As String
    Dim postnom As String
    Dim prenom As String
    Dim sexe As String
    Dim adresse As String
    Dim telephone As String
    Dim date_naissance As DateTime

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nom1 As String
        Get
            Return nom
        End Get
        Set(value As String)
            nom = value
        End Set
    End Property

    Public Property Postnom1 As String
        Get
            Return postnom
        End Get
        Set(value As String)
            postnom = value
        End Set
    End Property

    Public Property Prenom1 As String
        Get
            Return prenom
        End Get
        Set(value As String)
            prenom = value
        End Set
    End Property

    Public Property Sexe1 As String
        Get
            Return sexe
        End Get
        Set(value As String)
            sexe = value
        End Set
    End Property

    Public Property Adresse1 As String
        Get
            Return adresse
        End Get
        Set(value As String)
            adresse = value
        End Set
    End Property

    Public Property Telephone1 As String
        Get
            Return telephone
        End Get
        Set(value As String)
            telephone = value
        End Set
    End Property

    Public Property Date_naissance1 As Date
        Get
            Return date_naissance
        End Get
        Set(value As Date)
            date_naissance = value
        End Set
    End Property
End Class
