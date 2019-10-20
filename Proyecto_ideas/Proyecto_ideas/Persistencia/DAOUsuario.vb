Public Class DAOUsuario
    Public Function guardar(ByVal obj As Usuario)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO usuario(user, pass, nombreU, telefonoU, costoServicio) VALUES ('" + obj.User + "','" + obj.Password + "','" + obj.Nombre + "','" + obj.Telefono + "','" + obj.costoServicio.ToString + "')"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerUsuarios() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM usuario"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function obtenerTecnico() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT idU ,nombreU FROM usuario"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function comprobacion(ByVal obj As Usuario) As Boolean
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM usuario WHERE user='" + obj.User + "' AND pass='" + obj.Password + "'"

        Dim datareader As MySql.Data.MySqlClient.MySqlDataReader = objConexion.ejecutar(sentencia, True)
        If datareader.HasRows Then
            While datareader.Read()
                obj = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"), datareader("costoServicio"))
            End While
            datareader.Dispose()
            Return True
        Else
            Return False
        End If
    End Function

    Public Function modificarUsuario(ByVal obj As Usuario)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE usuario SET user = '" + obj.User + "', nombreU = '" + obj.Nombre + "', telefonoU = '" + obj.Telefono + "', costoServicio = '" + obj.costoServicio.ToString + "' WHERE idU = " + obj.IdUsuario.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarUsuario(ByVal obj As Usuario)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM usuario WHERE idU = " + obj.IdUsuario.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarUsuario(ByVal obj As Usuario) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from usuario where nombreU like '%" + obj.Nombre + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
