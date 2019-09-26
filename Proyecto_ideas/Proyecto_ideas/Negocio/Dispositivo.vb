Public Class Dispositivo

    Private _idDispositivo As Integer
    Private _modelo As String
    Private _bateria As Boolean
    Private _sim As Boolean
    Private _cargador As Boolean
    Private _tapa As Boolean
    Private _estuche As Boolean
    Private _tmemoria As Boolean
    Private _pin As Integer

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

    Public Property Pin() As Integer
        Get
            ' Return the value stored in the field.
            Return _pin
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _pin = Value
        End Set
    End Property

    Public Sub New(ByVal IdDispositivo As Integer, ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer)
        Me._idDispositivo = IdDispositivo
        Me._modelo = modelo
        Me._bateria = bateria
        Me._sim = sim
        Me._cargador = cargador
        Me._tapa = tapa
        Me._estuche = estuche
        Me._tmemoria = tmemoria
        Me._pin = pin
    End Sub

    Public Sub New(ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer)
        Me._modelo = modelo
        Me._bateria = bateria
        Me._sim = sim
        Me._cargador = cargador
        Me._tapa = tapa
        Me._estuche = estuche
        Me._tmemoria = tmemoria
        Me._pin = pin
    End Sub

    Public Sub New(ByVal IdDispositivo As Integer)
        Me._idDispositivo = IdDispositivo
    End Sub

    Public Function guardar()

        Dim obj As DAODispositivo = New DAODispositivo
        Return obj.guardar(Me)

    End Function

End Class
