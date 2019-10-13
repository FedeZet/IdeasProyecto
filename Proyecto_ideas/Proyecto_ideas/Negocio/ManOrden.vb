Public Class ManOrden
    Public Function agregarOrden(ByVal falla As String, ByVal importe As Integer, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As DateTime, ByVal estado As Integer)
        Dim objOrden As Orden = New Orden(falla, importe, garantia, fecha, hora, estado)
        objOrden.agregarOrden()
        Return True
    End Function
End Class
