Public Class Dispositivo

    Private _idDispositivo As Integer
    Private _modelo As String
    Private _bateria As Boolean
    Private _sim As Boolean
    Private _cargador As Boolean
    Private _tapa As Boolean
    Private _estuche As Boolean
    Private _tmemoria As Boolean
    Private _numero As String
    Private _pin As Boolean

    Public Property IdDispositivo() As Integer
        Get
            ' Return the value stored in the field.
            Return _idDispositivo
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idDispositivo = Value
        End Set
    End Property
    Public Property Modelo() As String
        Get
            ' Return the value stored in the field.
            Return _modelo
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _modelo = Value
        End Set
    End Property
    Public Property Bateria() As Boolean
        Get
            ' Return the value stored in the field.
            Return _bateria
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _bateria = Value
        End Set
    End Property
    Public Property Sim() As Boolean
        Get
            ' Return the value stored in the field.
            Return _sim
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _sim = Value
        End Set
    End Property
    Public Property Cargador() As Boolean
        Get
            ' Return the value stored in the field.
            Return _cargador
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _cargador = Value
        End Set
    End Property
    Public Property Tapa() As Boolean
        Get
            ' Return the value stored in the field.
            Return _tapa
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _tapa = Value
        End Set
    End Property
    Public Property Estuche() As Boolean
        Get
            ' Return the value stored in the field.
            Return _estuche
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _estuche = Value
        End Set
    End Property
    Public Property Tmemoria() As Boolean
        Get
            ' Return the value stored in the field.
            Return _tmemoria
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _tmemoria = Value
        End Set
    End Property
    Public Property Numero() As String
        Get
            ' Return the value stored in the field.
            Return _numero
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _numero = Value
        End Set
    End Property
    Public Property Pin() As Boolean
        Get
            ' Return the value stored in the field.
            Return _pin
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _pin = Value
        End Set
    End Property
End Class
