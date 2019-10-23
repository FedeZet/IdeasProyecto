Public Class Orden

    Private _idOrden As String
    Private _falla As String
    Private _resolucion As String
    Private _importe As Integer
    Private _dolar As Boolean
    Private _garantia As Boolean
    Private _fecha As DateTime
    Private _hora As TimeSpan
    Private _estado As String
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

    Public Property Resolucion() As String
        Get
            ' Return the value stored in the field.
            Return _resolucion
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _resolucion = Value
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

    Public Property Dolar() As Boolean
        Get
            ' Return the value stored in the field.
            Return _dolar
        End Get
        Set(ByVal Value As Boolean)
            ' Store the value in the field.
            _dolar = Value
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

    Public Property Fecha() As DateTime
        Get
            ' Return the value stored in the field.
            Return _fecha
        End Get
        Set(ByVal Value As DateTime)
            ' Store the value in the field.
            _fecha = Value
        End Set
    End Property

    Public Property Hora() As TimeSpan
        Get
            ' Return the value stored in the field.
            Return _hora
        End Get
        Set(ByVal Value As TimeSpan)
            ' Store the value in the field.
            _hora = Value
        End Set
    End Property

    Public Property Estado() As String
        Get
            ' Return the value stored in the field.
            Return _estado
        End Get
        Set(ByVal Value As String)
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


    Public Sub New(ByVal idOrden As Integer, ByVal falla As String, ByVal resolucion As String, ByVal importe As Integer, ByVal dolar As Boolean, ByVal garantia As Boolean, ByVal fecha As DateTime, ByVal hora As TimeSpan, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Me._idOrden = idOrden
        Me._falla = falla
        Me._resolucion = resolucion
        Me._importe = importe
        Me._dolar = dolar
        Me._garantia = garantia
        Me._fecha = fecha
        Me._hora = hora
        Me._estado = estado
        Me._idU = idU
        Me._idC = idC
        Me._idD = idD

    End Sub

    Public Sub New(ByVal falla As String, ByVal resolucion As String, ByVal importe As Integer, ByVal dolar As Boolean, ByVal garantia As Boolean, ByVal fecha As DateTime, ByVal hora As TimeSpan, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Me._falla = falla
        Me._resolucion = resolucion
        Me._importe = importe
        Me._dolar = dolar
        Me._garantia = garantia
        Me._fecha = fecha
        Me._hora = hora
        Me._estado = estado
        Me._idU = idU
        Me._idC = idC
        Me._idD = idD

    End Sub

    Public Sub New(ByVal IdOrden As Integer)
        Me._idOrden = IdOrden
    End Sub

    Public Sub New(ByVal estado As String)
        Me._estado = estado
    End Sub

    Public Function agregarOrden()
        Dim objO As DAOOrden = New DAOOrden
        Return objO.agregarOrden(Me)
    End Function

    Public Function buscar() As MySql.Data.MySqlClient.MySqlDataReader
        Dim obj As DAOOrden = New DAOOrden
        Return obj.buscarOrden(Me)
    End Function

    Public Shared Function obtenerOrdenes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim obj As DAOOrden = New DAOOrden
        Return obj.obtenerOrdenes()
    End Function

    Public Function modificar()
        Dim obj As DAOOrden = New DAOOrden
        Return obj.modificarOrden(Me)
    End Function

    Public Function eliminar()
        Dim obj As DAOOrden = New DAOOrden
        Return obj.eliminarOrden(Me)
    End Function
End Class
