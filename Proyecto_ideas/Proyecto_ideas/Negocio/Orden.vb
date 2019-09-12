Public Class Orden

    Private _idOrden As String
    Private _falla As String
    Private _importe As Integer
    Private _garantia As Boolean
    Private _fecha As Date
    Private _hora As DateTime
    Private _estado As Integer

    Public Property IdOrden() As String
        Get
            ' Return the value stored in the field.
            Return _idOrden
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _idOrden = Value
        End Set
    End Property

    Public Property Falla() As String
        Get
            ' Return the value stored in the field.
            Return _falla
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _falla = Value
        End Set
    End Property

    Public Property Importe() As Integer
        Get
            ' Return the value stored in the field.
            Return _importe
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _importe = Value
        End Set
    End Property

    Public Property Garantia() As Boolean
        Get
            ' Return the value stored in the field.
            Return _garantia
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _garantia = Value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            ' Return the value stored in the field.
            Return _fecha
        End Get
        Set(ByVal Value As Date)
            ' Store the value in the field.
            _fecha = Value
        End Set
    End Property

    Public Property Hora() As DateTime
        Get
            ' Return the value stored in the field.
            Return _hora
        End Get
        Set(ByVal Value As DateTime)
            ' Store the value in the field.
            _hora = Value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            ' Return the value stored in the field.
            Return _estado
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _estado = Value
        End Set
    End Property
End Class
