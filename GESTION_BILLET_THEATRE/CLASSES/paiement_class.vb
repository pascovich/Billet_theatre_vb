Public Class paiement_class
    Dim id As Integer
    Dim designation As String
    Dim montant As Decimal
    Dim date_paiement As DateTime
    Dim ref_billet As Integer

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

    Public Property Montant1 As Decimal
        Get
            Return montant
        End Get
        Set(value As Decimal)
            montant = value
        End Set
    End Property

    Public Property Date_paiement1 As Date
        Get
            Return date_paiement
        End Get
        Set(value As Date)
            date_paiement = value
        End Set
    End Property

    Public Property Ref_billet1 As Integer
        Get
            Return ref_billet
        End Get
        Set(value As Integer)
            ref_billet = value
        End Set
    End Property
End Class
