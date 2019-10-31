Public Class DAOOrden
    Public Function agregarOrden(ByVal objO As Orden)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO orden(detalle, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD) VALUES ('" + objO.Falla + "', '" + objO.Resolucion + "', " + objO.Importe.ToString + ", " + objO.Dolar.ToString + ", " + objO.Garantia.ToString + ", STR_TO_DATE('" + objO.Fecha + "', '%d/%m/%Y'), '" + objO.Hora.ToString + "', '" + objO.Estado + "', " + objO.idU.ToString + ", " + objO.idC.ToString + ", " + objO.idD.ToString + ")"
        'sentencia = "INSERT INTO orden(detalle, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD) VALUES ('" + objO.Falla + "', '" + objO.Resolucion + "', " + objO.Importe.ToString + ", " + objO.Dolar.ToString + ", " + objO.Garantia.ToString + ", " + objO.Fecha + ", '" + objO.Hora.ToString + "', '" + objO.Estado + "', " + objO.idU.ToString + ", " + objO.idC.ToString + ", " + objO.idD.ToString + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerOrdenes() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM orden"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function modificarOrden(ByVal obj As Orden)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE orden SET detalle = '" + obj.Falla + "' , resolucion = '" + obj.Resolucion + "', importe = " + obj.Importe.ToString + ", dolar = " + obj.Dolar.ToString + ", garantia = " + obj.Garantia.ToString + ", estado = '" + obj.Estado + "' WHERE idO = " + obj.IdOrden.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarOrden(ByVal obj As Orden)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM orden WHERE idO = " + obj.IdOrden.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarOrden(ByVal obj As Orden) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from orden where estado like '" + obj.Estado + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function obtenerOrden(ByVal obj As Orden) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "select * from orden where idO = " + obj.IdOrden.ToString + ";"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
