Public Class DAORepuesto
    Public Function agregar(ByVal obj As Repuesto)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO repuesto(nombreR,cantidad, costoRepuesto) VALUES ('" + obj.Nombre + "'," + obj.Cantidad.ToString + "," + obj.costo.ToString + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerRepuestos() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM repuesto"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function modificarRepuesto(ByVal obj As Repuesto)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE repuesto SET nombreR = '" + obj.Nombre + "' , cantidad = " + obj.Cantidad.ToString + ", costoRepuesto= " + obj.costo.ToString + " WHERE idR = " + obj.IdRepuesto.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function modificarCantidadRepuesto(ByVal obj As Repuesto)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE repuesto SET cantidad = " + obj.Cantidad.ToString + " WHERE idR = " + obj.IdRepuesto.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarRepuesto(ByVal obj As Repuesto)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM repuesto WHERE idR = " + obj.IdRepuesto.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarRepuesto(ByVal obj As Repuesto) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM repuesto WHERE nombreR LIKE '" + obj.Nombre + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
