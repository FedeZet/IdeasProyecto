Public Class DAOOrden
    Public Function agregarOrden(ByVal objO As Orden)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO orden(falla, importe, garantia, fecha, hora, estado, idU, idC, idD)) VALUES ('" + objO.Falla + "', " + objO.Importe.ToString + ", " + objO.Garantia.ToString + ", '" + objO.Fecha.ToString + "', '" + objO.Hora.ToString + "', " + objO.Estado.ToString + ", " + objO.idU + ", " + ", " + objO.idC + ", " + ", " + objO.idD + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function
End Class
