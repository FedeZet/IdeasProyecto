Public Class DAOOrden
    Public Function agregarOrden(ByVal objO As Orden)
        Dim dao As ConectorBD = New ConectorBD()
        Dim sentencia As String
        sentencia = "INSERT INTO orden(falla, importe, garantia, fecha, hora, estado) VALUES ('" + objO.Falla + "', " + objO.Importe.ToString + ", " + objO.Garantia + ", " + objO.Fecha.ToString + ", " + objO.Hora.ToString + ", " + objO.Estado.ToString + ")"
        dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
