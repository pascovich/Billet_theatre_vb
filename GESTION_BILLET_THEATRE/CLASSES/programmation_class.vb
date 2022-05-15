Public Class programmation_class
    Dim id As Integer
    Dim ref_type_billet As Integer
    Dim ref_programme As Integer
    Dim prix As Decimal

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Ref_type_billet1 As Integer
        Get
            Return ref_type_billet
        End Get
        Set(value As Integer)
            ref_type_billet = value
        End Set
    End Property

    Public Property Ref_programme1 As Integer
        Get
            Return ref_programme
        End Get
        Set(value As Integer)
            ref_programme = value
        End Set
    End Property

    Public Property Prix1 As Decimal
        Get
            Return prix
        End Get
        Set(value As Decimal)
            prix = value
        End Set
    End Property
End Class
