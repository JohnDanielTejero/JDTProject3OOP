Public Class Tour
    Private _destName As String
    Private _tourId As Integer
    Private _PriceAt7 As Double
    Private _PriceAt14 As Double

    Public Property TourId() As Integer
        Get
            Return _tourId
        End Get
        Set(value As Integer)
            _tourId = value
        End Set
    End Property
    Public Property Destination() As String
        Get
            Return _destName
        End Get
        Set(value As String)
            _destName = value
        End Set
    End Property
    Public Property Day7Price() As Double
        Get
            Return _PriceAt7
        End Get
        Set(value As Double)
            _PriceAt7 = value
        End Set
    End Property

    Public Property Day14Price() As Double
        Get
            Return _PriceAt14
        End Get
        Set(value As Double)
            _PriceAt14 = value
        End Set
    End Property
End Class
