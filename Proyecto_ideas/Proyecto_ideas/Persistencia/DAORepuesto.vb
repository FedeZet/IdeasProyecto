Public Class DAORepuesto
    Public Function agregar(ByVal obj As Repuesto)
        Dim dao = New ConectorBD()
        Dim sentencia As String
        sentencia = "insert into repuesto values (" + obj.IdRepuesto.ToString + ",'" + obj.Nombre + "'," + obj.Cantidad.ToString + ")"
        dao.ejecutar(sentencia, False)
        Return True
    End Function
End Class
