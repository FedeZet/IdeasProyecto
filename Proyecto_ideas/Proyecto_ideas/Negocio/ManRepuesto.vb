Imports MySql.Data.MySqlClient

Public Class ManRepuesto
    Dim hashRepuesto As Hashtable = New Hashtable

    Public Function agregarRepuesto(ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(nombreRepuesto, cantidadRepuesto)
        objRepuesto.agregar()
        Return True
    End Function

    Public Function obtenerRepuesto() As Hashtable
        Dim datareader As MySqlDataReader = Repuesto.obtenerRepuestos()
        Dim objR As Repuesto = Nothing
        While datareader.Read()
            objR = New Repuesto(datareader("idR"), datareader("nombreR"), datareader("cantidad"))
            Me.hashRepuesto.Add(objR.IdRepuesto, objR)
        End While
        Return Me.hashRepuesto
    End Function

    Public Function modificarRepuesto(ByVal idRepuesto As Integer, ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(idRepuesto, nombreRepuesto, cantidadRepuesto)
        objRepuesto.modificar()
        Return True
    End Function
End Class
