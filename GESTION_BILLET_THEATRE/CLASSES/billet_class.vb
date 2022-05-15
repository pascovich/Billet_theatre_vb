Public Class billet_class
    Dim id As Integer
    Dim reduction As Decimal
    Dim prix_a_paye As Decimal
    Dim numero_chaise As Integer
    Dim ref_client As Integer
    Dim ref_programmation As Integer
    Dim date_achat As DateTime
    Dim check_paie As Boolean

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Reduction1 As Decimal
        Get
            Return reduction
        End Get
        Set(value As Decimal)
            reduction = value
        End Set
    End Property

    Public Property Prix_a_paye1 As Decimal
        Get
            Return prix_a_paye
        End Get
        Set(value As Decimal)
            prix_a_paye = value
        End Set
    End Property

    Public Property Numero_chaise1 As Integer
        Get
            Return numero_chaise
        End Get
        Set(value As Integer)
            numero_chaise = value
        End Set
    End Property

    Public Property Ref_client1 As Integer
        Get
            Return ref_client
        End Get
        Set(value As Integer)
            ref_client = value
        End Set
    End Property

    Public Property Ref_programmation1 As Integer
        Get
            Return ref_programmation
        End Get
        Set(value As Integer)
            ref_programmation = value
        End Set
    End Property

    Public Property Date_achat1 As Date
        Get
            Return date_achat
        End Get
        Set(value As Date)
            date_achat = value
        End Set
    End Property

    Public Property Check_paie1 As Boolean
        Get
            Return check_paie
        End Get
        Set(value As Boolean)
            check_paie = value
        End Set
    End Property
End Class
