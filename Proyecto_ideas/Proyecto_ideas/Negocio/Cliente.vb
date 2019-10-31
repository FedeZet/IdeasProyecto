Public Class Cliente

    Private _id_cliente As Integer
    Private _nombre As String
    Private _telefono As String
    Private _correo As String


    Public Property IdCliente() As Integer
        Get
            ' Return the value stored in the field.
            Return _id_cliente
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _id_cliente = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            ' Return the value stored in the field.
            Return _nombre
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _nombre = Value
        End Set
    End Property
    Public Property Telefono() As String
        Get
            ' Return the value stored in the field.
            Return _telefono
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _telefono = Value
        End Set
    End Property
    Public Property correo() As String
        Get
            ' Return the value stored in the field.
            Return _correo
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _correo = Value
        End Set
    End Property

    Public Sub New(ByVal IdCliente As Integer, ByVal nombre As String, ByVal telefono As String, ByVal correo As String)
        Me._id_cliente = IdCliente
        Me._nombre = nombre
        Me._telefono = telefono
        Me._correo = correo
    End Sub

    Public Sub New(ByVal nombre As String, ByVal telefono As String, ByVal correo As String)
        Me._nombre = nombre
        Me._telefono = telefono
        Me._correo = correo
    End Sub

    Public Sub New(ByVal IdCliente As Integer)
        Me._id_cliente = IdCliente
    End Sub

    Public Sub New(ByVal nombre As String)
        Me._nombre = nombre
    End Sub

    Public Function guardar()
        Dim obj As DAOCliente = New DAOCliente
        Return obj.guardar(Me)

    End Function

    Public Function buscar() As MySql.Data.MySqlClient.MySqlDataReader
        Dim obj As DAOCliente = New DAOCliente
        Return obj.buscarCliente(Me)
    End Function

    Public Function buscarID() As MySql.Data.MySqlClient.MySqlDataReader
        Dim obj As DAOCliente = New DAOCliente
        Return obj.buscarClienteID(Me)
    End Function

    Public Shared Function obtenerClientes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim objR As DAOCliente = New DAOCliente
        Return objR.obtenerClientes()
    End Function

    Public Function modificar()
        Dim obj As DAOCliente = New DAOCliente
        Return obj.modificarCliente(Me)
    End Function

    Public Function eliminar()
        Dim obj As DAOCliente = New DAOCliente
        Return obj.eliminarCliente(Me)
    End Function
End Class
