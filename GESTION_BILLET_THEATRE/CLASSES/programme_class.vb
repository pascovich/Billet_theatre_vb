Public Class programme_class
    Dim id As Integer
    Dim date_ceremony As DateTime
    Dim heure_debut As Decimal
    Dim heure_fin As Decimal
    Dim ref_salle As Integer
    Dim ref_theatre As Integer

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Date_ceremony1 As Date
        Get
            Return date_ceremony
        End Get
        Set(value As Date)
            date_ceremony = value
        End Set
    End Property

    Public Property Heure_debut1 As Decimal
        Get
            Return heure_debut
        End Get
        Set(value As Decimal)
            heure_debut = value
        End Set
    End Property

    Public Property Heure_fin1 As Decimal
        Get
            Return heure_fin
        End Get
        Set(value As Decimal)
            heure_fin = value
        End Set
    End Property

    Public Property Ref_salle1 As Integer
        Get
            Return ref_salle
        End Get
        Set(value As Integer)
            ref_salle = value
        End Set
    End Property

    Public Property Ref_theatre1 As Integer
        Get
            Return ref_theatre
        End Get
        Set(value As Integer)
            ref_theatre = value
        End Set
    End Property
End Class
