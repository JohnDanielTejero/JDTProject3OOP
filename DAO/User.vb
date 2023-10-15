Public Class User

    Private _custId As Integer
    Private _username As String
    Private _custPhone As String
    Private _role As String
    Private _custAddress As String
    Private _custName As String

    Public Property CustomerId() As Integer
        Get
            Return _custId
        End Get
        Set(value As Integer)
            _custId = value
        End Set
    End Property

    Public Property Username() As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return _custName
        End Get
        Set(value As String)
            _custName = value
        End Set
    End Property
    Public Property PhoneAddress() As String
        Get
            Return _custPhone
        End Get
        Set(value As String)
            _custPhone = value
        End Set
    End Property

    Public Property CustomerAddress() As String
        Get
            Return _custAddress
        End Get
        Set(value As String)
            _custAddress = value
        End Set
    End Property

    Public Property Role() As String
        Get
            Return _role
        End Get
        Set(value As String)
            _role = value
        End Set
    End Property

End Class
