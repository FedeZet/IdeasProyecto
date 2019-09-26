Public Class DAOUsuario
    Public Function guardar(ByVal obj As Usuario)
        Dim dao = New ConectorBD()

        Dim sentencia As String
        sentencia = "insert into usuario(Nick, contrasenia, nombre, telefono) values ('" + obj.User + "','" + obj.Password + "','" + obj.Nombre + "','" + obj.Telefono + "')"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function iniciarSesion(ByVal objI As Usuario) As Boolean
        Dim dao = New ConectorBD()

        Dim sentencia As String
        sentencia = "Select Nick, contrasenia From usuario Where Nick=  '" & objI.User & "' And contrasenia= '" + objI.Password + "'"
        dao.ejecutar(sentencia, False)


        Return True
    End Function

    Public Function obtenerUsuarios() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "Select * from usuario"
        Return dao.ejecutar(sentencia, True)
    End Function
End Class
