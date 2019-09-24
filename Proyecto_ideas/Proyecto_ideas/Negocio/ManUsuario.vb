Imports MySql.Data.MySqlClient
Public Class ManUsuario
    Dim hashUsuario As Hashtable = New Hashtable
    Public Function crearUsuario(ByVal IdUsuario As Integer, ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)

        Dim objUsuario As Usuario = New Usuario(IdUsuario, user, password, nombre, telefono)
        objUsuario.guardar()
        Return True
    End Function

    Public Function iniciarSesion(ByVal user As String, ByVal password As String) As String

        Dim objIniciar As Usuario = New Usuario(user, password)
        objIniciar.iniciarSesion()
        Return True
    End Function

    Public Function obtenerUsuario() As Hashtable
        Dim datareader As MySqlDataReader = Usuario.obtenerUsuarios()
        Dim objR As Usuario = Nothing
        While datareader.Read()
            objR = New Usuario(datareader("id_usuario"), datareader("nick"), datareader("contrasenia"), datareader("nombre"), datareader("telefono"))
            Me.hashUsuario.Add(objR.IdUsuario, objR)
        End While
        Return Me.hashUsuario
    End Function
End Class
