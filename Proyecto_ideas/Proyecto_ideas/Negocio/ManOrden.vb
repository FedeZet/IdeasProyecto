Public Class ManOrden
    Public Function agregarOrden(ByVal falla As String, ByVal resolucion As String, ByVal importe As Integer, ByVal dolar As Boolean, ByVal garantia As Boolean, ByVal fecha As String, ByVal hora As String, ByVal estado As Integer, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Dim objOrden As Orden = New Orden(falla, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD)
        objOrden.agregarOrden()
        Return True
    End Function
End Class
