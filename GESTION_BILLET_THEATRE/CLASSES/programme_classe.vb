Public Class programme_classe
    Dim id_programme As Integer
    Dim date_cer As DateTime
    Dim heure_begin As Decimal
    Dim heure_end As Decimal
    Dim ref_sall As Integer
    Dim ref_theat As Integer

    Public Property Id_programme1 As Integer
        Get
            Return id_programme
        End Get
        Set(value As Integer)
            id_programme = value
        End Set
    End Property

    Public Property Date_cer1 As Date
        Get
            Return date_cer
        End Get
        Set(value As Date)
            date_cer = value
        End Set
    End Property

    Public Property Heure_begin1 As Decimal
        Get
            Return heure_begin
        End Get
        Set(value As Decimal)
            heure_begin = value
        End Set
    End Property

    Public Property Heure_end1 As Decimal
        Get
            Return heure_end
        End Get
        Set(value As Decimal)
            heure_end = value
        End Set
    End Property

    Public Property Ref_sall1 As Integer
        Get
            Return ref_sall
        End Get
        Set(value As Integer)
            ref_sall = value
        End Set
    End Property

    Public Property Ref_theat1 As Integer
        Get
            Return ref_theat
        End Get
        Set(value As Integer)
            ref_theat = value
        End Set
    End Property
End Class
