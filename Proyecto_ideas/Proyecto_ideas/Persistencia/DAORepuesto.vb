Public Class DAORepuesto
    Public Function agregar(ByVal obj As Repuesto)
        Dim dao = New ConectorBD()

        'Dim sentencia As String
        'sentencia = "insert into usuario(id_usuario, Nick, contrasenia, nombre, telefono) values (" + obj.IdUsuario.ToString + ",'" + obj.User + "','" + obj.Password + "','" + obj.Nombre + "','" + obj.Telefono + "')"
        'dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
