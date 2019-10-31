Imports MySql.Data.MySqlClient

Public Class ManUtiliza

    Dim hashUtiliza As Hashtable = New Hashtable
    Private Shared instancia As ManUtiliza

    Public Function agregarRepuestosUtilizados(ByVal idO As Integer, ByVal idR As Integer, ByVal cuantos As Integer)
        Dim obj As Utiliza = New Utiliza(idO, idR, cuantos)
        obj.agregar()
        Return True
    End Function

    Public Function obtenerRepuesto(ByVal idO As Integer) As Hashtable
        hashUtiliza.Clear()
        Dim obj As Utiliza = New Utiliza(idO)
        Dim datareader As MySqlDataReader = obj.obtenerUtilizados
        While datareader.Read()
            obj = New Utiliza(datareader("idO"), datareader("idR"), datareader("cuantos"))
            Me.hashUtiliza.Add(obj.idR, obj)
        End While
        Return Me.hashUtiliza
    End Function

    'Public Function modificarRepuesto(ByVal idRepuesto As Integer, ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer, ByVal costo As Integer)
    '    Dim objRepuesto As Repuesto = New Repuesto(idRepuesto, nombreRepuesto, cantidadRepuesto, costo)
    '    objRepuesto.modificar()
    '    Return True
    'End Function

    Public Function eliminarUtiliza(ByVal idOrden As Integer)
        Dim obj As Utiliza = New Utiliza(idOrden)
        obj.eliminar()
        Return True
    End Function

    Public Function eliminarRepuestoUtilizado(ByVal idOrden As Integer, ByVal idRepuesto As Integer, ByVal cuantos As Integer)
        Dim obj As Utiliza = New Utiliza(idOrden, idRepuesto, cuantos)
        obj.eliminarRepuesto()
        Return True
    End Function

    'Public Function buscarRepuesto(ByVal nombre As String)
    '    hashUtiliza.Clear()
    '    Dim objR As Repuesto = New Repuesto(nombre)
    '    Dim datareader As hashUtiliza = objR.buscar
    '    While datareader.Read()
    '        objR = New Repuesto(datareader("idR"), datareader("nombreR"), datareader("cantidad"), datareader("costoRepuesto"))
    '        Me.hashUtiliza.Add(objR.Nombre, objR)
    '    End While
    '    Return Me.hashUtiliza
    'End Function


    Private Sub New()

    End Sub

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManUtiliza
        End If
        Return instancia
    End Function

End Class
