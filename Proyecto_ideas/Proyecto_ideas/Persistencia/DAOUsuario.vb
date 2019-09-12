Public Class DAOUsuario
    Public Function guardar(ByVal obj As Usuario)
        Dim dao = New ConectorBD()

        Dim sentencia As String
        sentencia = "insert into usuario(id_usuario, Nick, contrasenia, nombre, telefono) values (" + obj.IdUsuario.ToString + ",'" + obj.User + "','" + obj.Password + "','" + obj.Nombre + "','" + obj.Telefono + "')"
        dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
