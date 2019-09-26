Public Class ManDispositivo
    Public Function crearDispositivo(ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer)

        Dim objDispositivo As Dispositivo = New Dispositivo(modelo, bateria, sim, cargador, tapa, estuche, tmemoria, pin)
        objDispositivo.guardar()
        Return True
    End Function
End Class
