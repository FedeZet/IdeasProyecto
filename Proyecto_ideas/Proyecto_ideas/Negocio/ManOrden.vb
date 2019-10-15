Public Class ManOrden
    Public Function agregarOrden(ByVal falla As String, ByVal importe As Integer, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As DateTime, ByVal estado As Integer, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Dim objOrden As Orden = New Orden(falla, importe, garantia, fecha, hora, estado, idU, idC, idD)
        objOrden.agregarOrden()
        Return True
    End Function
End Class
