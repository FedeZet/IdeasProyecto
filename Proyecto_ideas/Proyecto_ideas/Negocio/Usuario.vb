Public Class Usuario

    Private _idUsuario As Integer
    Private _user As String
    Private _password As String
    Private _nombre As String
    Private _telefono As String

    Public Property IdUsuario() As Integer
        Get
            ' Return the value stored in the field.
            Return _idUsuario
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idUsuario = Value
        End Set
    End Property
    Public Property User() As String
        Get
            ' Return the value stored in the field.
            Return _user
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _user = Value
        End Set
    End Property
    Public Property Password() As String
        Get
            ' Return the value stored in the field.
            Return _password
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _password = Value
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
    Public Sub New(ByVal IdUsuario As Integer, ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)
        Me._idUsuario = IdUsuario
        Me._user = user
        Me._password = password
        Me._nombre = nombre
        Me._telefono = telefono
    End Sub

    Public Function guardar()
        Dim obj As DAOUsuario = New DAOUsuario
        Return obj.guardar(Me)

    End Function


    Sub New(ByVal user As String, ByVal password As String)
        _user = user
        _password = password
    End Sub

    Public Function iniciarSesion()
        Dim objI As DAOUsuario = New DAOUsuario
        Return objI.iniciarSesion(Me)

    End Function

    Public Shared Function obtenerUsuarios() As MySql.Data.MySqlClient.MySqlDataReader
        Dim objR As DAOUsuario = New DAOUsuario
        Return objR.obtenerUsuarios()
    End Function
End Class
