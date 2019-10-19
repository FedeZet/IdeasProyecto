Public Class DAOCliente
    Public Function guardar(ByVal obj As Cliente)
        Dim sentencia As String
        sentencia = "INSERT INTO cliente(nombreC, telefonoC) VALUES ('" + obj.Nombre + "','" + obj.Telefono + "')"
        ConectorBD.getInstancia.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerClientes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        sentencia = "SELECT * FROM cliente"
        Return ConectorBD.getInstancia.ejecutar(sentencia, True)
    End Function

    Public Function modificarCliente(ByVal obj As Cliente)
        Dim sentencia As String
        sentencia = "UPDATE cliente SET nombreC = '" + obj.Nombre + "' , telefonoC = " + obj.Telefono + " WHERE idU = " + obj.IdCliente.ToString + ";"
        ConectorBD.getInstancia.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarCliente(ByVal obj As Cliente)
        Dim sentencia As String
        sentencia = "DELETE FROM cliente WHERE idU = " + obj.IdCliente.ToString + ";"
        ConectorBD.getInstancia.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarCliente(ByVal obj As Cliente) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        sentencia = "select * from cliente where nombreC like '%" + obj.Nombre + "%';"
        Return ConectorBD.getInstancia.ejecutar(sentencia, True)
    End Function
End Class
