Public Class DAORepuesto
    Public Function agregar(ByVal obj As Repuesto)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "INSERT INTO repuesto(nombreR,cantidad) VALUES ('" + obj.Nombre + "'," + obj.Cantidad.ToString + ")"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerRepuestos() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "SELECT * FROM repuesto"
        Return dao.ejecutar(sentencia, True)
    End Function

    Public Function modificarRepuesto(ByVal obj As Repuesto)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "update * from repuesto"
        dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
