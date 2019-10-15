Public Class Orden

    Private _idOrden As String
    Private _falla As String
    Private _importe As Integer
    Private _garantia As Boolean
    Private _fecha As Date
    Private _hora As DateTime
    Private _estado As Integer
    Private _idU As Integer
    Private _idC As Integer
    Private _idD As Integer

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

    Public Property idU() As Integer
        Get
            ' Return the value stored in the field.
            Return _idU
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idU = Value
        End Set
    End Property

    Public Property idC() As Integer
        Get
            ' Return the value stored in the field.
            Return _idC
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idC = Value
        End Set
    End Property

    Public Property idD() As Integer
        Get
            ' Return the value stored in the field.
            Return _idD
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idD = Value
        End Set
    End Property


    Public Sub New(ByVal idOrden As Integer, ByVal falla As String, ByVal importe As Integer, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As DateTime, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Me._idOrden = idOrden
        Me._falla = falla
        Me._importe = importe
        Me._garantia = garantia
        Me._fecha = fecha
        Me._hora = hora
        Me._estado = estado
        Me._idU = idU
        Me._idC = idC
        Me._idD = idD

    End Sub

    Public Sub New(ByVal falla As String, ByVal importe As Integer, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As DateTime, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Me._falla = falla
        Me._importe = importe
        Me._garantia = garantia
        Me._fecha = fecha
        Me._hora = hora
        Me._estado = estado
        Me._idU = idU
        Me._idC = idC
        Me._idD = idD

    End Sub

    Public Function agregarOrden()
        Dim objO As DAOOrden = New DAOOrden
        Return objO.agregarOrden(Me)
    End Function
End Class
