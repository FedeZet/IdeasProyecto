Public Class DAOCliente
    Public Function guardar(ByVal obj As Cliente)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO cliente(nombreC, telefonoC) VALUES ('" + obj.Nombre + "','" + obj.Telefono + "')"
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
        sentencia = "UPDATE cliente SET nombreC = '" + obj.Nombre + "' , telefonoC = " + obj.Telefono + " WHERE idU = " + obj.IdCliente.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarCliente(ByVal obj As Cliente)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM cliente WHERE idU = " + obj.IdCliente.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarCliente(ByVal obj As Cliente) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from cliente where nombreC like '%" + obj.Nombre + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
