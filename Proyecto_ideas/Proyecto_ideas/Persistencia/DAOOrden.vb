Public Class DAOOrden
    Public Function agregarOrden(ByVal objO As Orden)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO orden(detalle, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD) VALUES ('" + objO.Falla + "', '" + objO.Resolucion + "', " + objO.Importe.ToString + ", " + objO.Dolar.ToString + ", " + objO.Garantia.ToString + ", STR_TO_DATE(REPLACE('" + objO.Fecha.ToString + "','/','.') ,GET_FORMAT(date,'EUR')), '" + objO.Hora.ToString + "', '" + objO.Estado + "', " + objO.idU.ToString + ", " + objO.idC.ToString + ", " + objO.idD.ToString + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function
End Class
