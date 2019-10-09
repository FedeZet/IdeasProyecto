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

    'Public Function autenticar() As MySql.Data.MySqlClient.MySqlDataReader
    '    Dim dao As ConectorBD = New ConectorBD()
    '    Dim sentencia As String
    '    sentencia = "SELECT * FROM usuario WHERE user='+ + +'"
    '    Return dao.ejecutar(sentencia, True)
    'End Function

    Public Function modificarUsuario(ByVal obj As Usuario)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "UPDATE usuario SET user = '" + obj.User + "', nombreU = '" + obj.Nombre + "', telefonoU = '" + obj.Telefono + "' WHERE idU = " + obj.IdUsuario.ToString + ";"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarUsuario(ByVal obj As Usuario)
        Dim dao As ConectorBD = New ConectorBD
        Dim sentencia As String
        sentencia = "DELETE FROM usuario WHERE idU = " + obj.IdUsuario.ToString + ";"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarUsuario(ByVal obj As Usuario) As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD
        Dim sentencia As String
        sentencia = "select * from usuario where nombreU like '%" + obj.Nombre + "%';"
        Return dao.ejecutar(sentencia, True)
    End Function
End Class
