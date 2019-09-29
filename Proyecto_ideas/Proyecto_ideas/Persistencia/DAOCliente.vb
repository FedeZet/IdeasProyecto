Public Class DAOCliente
    Public Function guardar(ByVal obj As Cliente)
        Dim dao = New ConectorBD()
        Dim sentencia As String
        sentencia = "INSERT INTO cliente(nombreC, telefonoC) VALUES ('" + obj.Nombre + "','" + obj.Telefono + "')"
        dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
