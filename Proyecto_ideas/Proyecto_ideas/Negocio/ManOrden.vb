Imports MySql.Data.MySqlClient

Public Class ManOrden
    Dim hashOrden As Hashtable = New Hashtable
    Private Shared instancia As ManOrden

    Public Function agregarOrden(ByVal falla As String, ByVal resolucion As String, ByVal importe As Integer, ByVal dolar As Boolean, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As TimeSpan, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Dim objO As Orden = New Orden(falla, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD)
        objO.agregarOrden()
        Return True
    End Function

    Public Function obtenerOrden() As Hashtable
        hashOrden.Clear()
        Dim datareader As MySqlDataReader = Orden.obtenerOrdenes()
        Dim objO As Orden = Nothing
        While datareader.Read()
            objO = New Orden(datareader("idO"), datareader("detalle"), datareader("resolucion"), datareader("importe"), datareader("dolar"), datareader("garantia"), datareader("fecha"), datareader("hora"), datareader("estado"), datareader("idU"), datareader("idC"), datareader("idD"))
            Me.hashOrden.Add(objO.IdOrden, objO)
        End While
        Return Me.hashOrden

    End Function

    Public Function modificarOrden(ByVal idOrden As Integer, ByVal falla As String, ByVal resolucion As String, ByVal importe As Integer, ByVal dolar As Boolean, ByVal garantia As Boolean, ByVal fecha As Date, ByVal hora As TimeSpan, ByVal estado As String, ByVal idU As Integer, ByVal idC As Integer, ByVal idD As Integer)
        Dim objO As Orden = New Orden(idOrden, falla, resolucion, importe, dolar, garantia, fecha, hora, estado, idU, idC, idD)
        objO.modificar()
        Return True
    End Function

    Public Function eliminarOrden(ByVal idOrden As Integer)
        Dim objO As Orden = New Orden(idOrden)
        objO.eliminar()
        Return True
    End Function

    Public Function buscarOrden(ByVal estado As String)
        hashOrden.Clear()
        Dim objO As Orden = New Orden(estado)
        Dim datareader As MySqlDataReader = objO.buscar
        While datareader.Read()
            objO = New Orden(datareader("idO"), datareader("detalle"), datareader("resolucion"), datareader("importe"), datareader("dolar"), datareader("garantia"), datareader("fecha").ToString, datareader("hora"), datareader("estado"), datareader("idU"), datareader("idC"), datareader("idD"))
            Me.hashOrden.Add(objO.Estado, objO)
        End While
        Return Me.hashOrden
    End Function

    Public Function buscarOrdenID(ByVal idOrden As Integer)
        hashOrden.Clear()
        Dim objO As Orden = New Orden(idOrden)
        Dim datareader As MySqlDataReader = objO.obtenerOrden
        While datareader.Read()
            objO = New Orden(datareader("idO"), datareader("detalle"), datareader("resolucion"), datareader("importe"), datareader("dolar"), datareader("garantia"), datareader("fecha").ToString, datareader("hora"), datareader("estado"), datareader("idU"), datareader("idC"), datareader("idD"))
            Me.hashOrden.Add(objO.IdOrden, objO)
        End While
        Return Me.hashOrden
    End Function

    Private Sub New()

    End Sub

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManOrden
        End If
        Return instancia
    End Function
End Class
