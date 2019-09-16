Public Class ManRepuesto
    Public Function agregarRepuesto(ByVal idRepuesto As Integer, ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(idRepuesto, nombreRepuesto, cantidadRepuesto)
        objRepuesto.agregar()
        Return True
    End Function
End Class
