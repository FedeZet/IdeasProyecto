Public Class DAOCliente
    Public Function guardar(ByVal obj As Cliente)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO cliente(nombreC, telefonoC, email) VALUES ('" + obj.Nombre + "','" + obj.Telefono + "','" + obj.correo + "')"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerClientes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM cliente"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function modificarCliente(ByVal obj As Cliente)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE cliente SET nombreC = '" + obj.Nombre + "' , telefonoC = '" + obj.Telefono + "', email = '" + obj.correo + "' WHERE idU = " + obj.IdCliente.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarCliente(ByVal obj As Cliente)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM cliente WHERE idC = " + obj.IdCliente.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarCliente(ByVal obj As Cliente) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from cliente where nombreC like '" + obj.Nombre + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function buscarClienteID(ByVal obj As Cliente) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from cliente where idC = " + obj.IdCliente.ToString + ";"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
