Imports MySql.Data.MySqlClient
Public Class ManUsuario
    Dim hashUsuario As Hashtable = New Hashtable
    Dim hashTecnico As Hashtable = New Hashtable
    Public Function crearUsuario(ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)

        Dim objUsuario As Usuario = New Usuario(user, password, nombre, telefono)
        objUsuario.guardar()
        Return True
    End Function

    Public Function obtenerUsuario() As Hashtable
        Dim datareader As MySqlDataReader = Usuario.obtenerUsuarios()
        Dim objU As Usuario = Nothing
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"))
            Me.hashUsuario.Add(objU.IdUsuario, objU)
        End While
        Return Me.hashUsuario
    End Function

    Public Function obtenerTecnico() As Hashtable
        Dim datareader As MySqlDataReader = Usuario.obtenerTecnico()
        Dim objU As Usuario = Nothing
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("nombreU"))
            Me.hashTecnico.Add(objU.IdUsuario, objU)
        End While
        Return Me.hashTecnico
    End Function
End Class
