Public Class user_class
    Dim id_users As Integer
    Dim username As String
    Dim pwd As String

    Public Property Id_users1 As Integer
        Get
            Return id_users
        End Get
        Set(value As Integer)
            id_users = value
        End Set
    End Property

    Public Property Username1 As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property Pwd1 As String
        Get
            Return pwd
        End Get
        Set(value As String)
            pwd = value
        End Set
    End Property
End Class
