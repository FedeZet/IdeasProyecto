Public Class DAOUsuario
    Public Function guardar(ByVal obj As Usuario)
        Dim dao = New ConectorBD()
        Dim sentencia As String
        sentencia = "INSERT INTO usuario(user, pass, nombreU, telefonoU) VALUES ('" + obj.User + "','" + obj.Password + "','" + obj.Nombre + "','" + obj.Telefono + "')"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerUsuarios() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "SELECT * FROM usuario"
        Return dao.ejecutar(sentencia, True)
    End Function

    Public Function obtenerTecnico() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "SELECT idU, nombreU FROM usuario"
        Return dao.ejecutar(sentencia, True)
    End Function

    'Public Function iniciarSesion(ByVal objU As Usuario) As MySql.Data.MySqlClient.MySqlDataReader
    '    Dim dao = New ConectorBD()

    '    Dim sentencia As String
    '    sentencia = "Select Nick, contrasenia From usuario Where Nick=  '" & objU.User & "' And contrasenia= '" + objU.Password + "'"
    '    Return dao.ejecutar(sentencia, True)
    'End Function
End Class
