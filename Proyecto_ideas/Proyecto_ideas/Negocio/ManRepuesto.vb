Imports MySql.Data.MySqlClient

Public Class ManRepuesto
    Dim hashRepuesto As Hashtable = New Hashtable
    Private Shared instancia As ManRepuesto

    Public Function agregarRepuesto(ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer, ByVal costo As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(nombreRepuesto, cantidadRepuesto, costo)
        objRepuesto.agregar()
        Return True
    End Function

    Public Function obtenerRepuesto() As Hashtable
        hashRepuesto.Clear()
        Dim datareader As MySqlDataReader = Repuesto.obtenerRepuestos()
        Dim objR As Repuesto = Nothing
        While datareader.Read()
            objR = New Repuesto(datareader("idR"), datareader("nombreR"), datareader("cantidad"), datareader("costoRepuesto"))
            Me.hashRepuesto.Add(objR.IdRepuesto, objR)
        End While
        Return Me.hashRepuesto
    End Function

    Public Function modificarRepuesto(ByVal idRepuesto As Integer, ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer, ByVal costo As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(idRepuesto, nombreRepuesto, cantidadRepuesto, costo)
        objRepuesto.modificar()
        Return True
    End Function

    Public Function eliminarRepuesto(ByVal idRepuesto As Integer)
        Dim objRepuesto As Repuesto = New Repuesto(idRepuesto)
        objRepuesto.eliminar()
        Return True
    End Function

    Public Function buscarRepuesto(ByVal nombre As String)
        hashRepuesto.Clear()
        Dim objR As Repuesto = New Repuesto(nombre)
        Dim datareader As MySqlDataReader = objR.buscar
        While datareader.Read()
            objR = New Repuesto(datareader("idR"), datareader("nombreR"), datareader("cantidad"), datareader("costoRepuesto"))
            Me.hashRepuesto.Add(objR.Nombre, objR)
        End While
        Return Me.hashRepuesto
    End Function

    Private Sub New()

    End Sub

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManRepuesto
        End If
        Return instancia
    End Function
End Class
