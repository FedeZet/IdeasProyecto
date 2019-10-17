Public Class DAOCliente
    Public Function guardar(ByVal obj As Cliente)
        Dim dao = New ConectorBD()
        Dim sentencia As String
        sentencia = "INSERT INTO cliente(nombreC, telefonoC) VALUES ('" + obj.Nombre + "','" + obj.Telefono + "')"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerClientes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "SELECT * FROM cliente"
        Return dao.ejecutar(sentencia, True)
    End Function

    Public Function modificarCliente(ByVal obj As Cliente)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "UPDATE cliente SET nombreC = '" + obj.Nombre + "' , telefonoC = " + obj.Telefono + " WHERE idU = " + obj.IdCliente.ToString + ";"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarCliente(ByVal obj As Cliente)
        Dim dao As ConectorBD = New ConectorBD
        Dim sentencia As String
        sentencia = "DELETE FROM cliente WHERE idU = " + obj.IdCliente.ToString + ";"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarCliente(ByVal obj As Cliente) As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD
        Dim sentencia As String
        sentencia = "select * from cliente where nombreC like '%" + obj.Nombre + "%';"
        Return dao.ejecutar(sentencia, True)
    End Function
End Class
