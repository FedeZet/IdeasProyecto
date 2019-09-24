Public Class DAORepuesto
    Public Function agregar(ByVal obj As Repuesto)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "insert into repuesto values (" + obj.IdRepuesto.ToString + ",'" + obj.Nombre + "'," + obj.Cantidad.ToString + ")"
        dao.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerRepuestos() As MySql.Data.MySqlClient.MySqlDataReader
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "Select * from repuesto"
        Return dao.ejecutar(sentencia, True)
    End Function
End Class
