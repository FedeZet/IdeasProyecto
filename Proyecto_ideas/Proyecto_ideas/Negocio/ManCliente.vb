Imports MySql.Data.MySqlClient
Public Class ManCliente
    Dim hashCliente As Hashtable = New Hashtable

    Public Function crearCliente(ByVal nombre As String, ByVal telefono As String)

        Dim objCliente As Cliente = New Cliente(nombre, telefono)
        objCliente.guardar()
        Return True
    End Function

    Public Function obtenerCliente() As Hashtable
        Dim datareader As MySqlDataReader = Cliente.obtenerClientes()
        Dim objC As Cliente = Nothing
        While datareader.Read()
            objC = New Cliente(datareader("idC"), datareader("nombreC"), datareader("telefonoC"))
            Me.hashCliente.Add(objC.IdCliente, objC)
        End While
        Return Me.hashCliente
    End Function

    Public Function modificarCliente(ByVal idCliente As Integer, ByVal nombreCliente As String, ByVal telefonoCliente As String)
        Dim objCliente As Cliente = New Cliente(idCliente, nombreCliente, telefonoCliente)
        objCliente.modificar()
        Return True
    End Function

    Public Function eliminarCliente(ByVal idCliente As Integer)
        Dim objCliente As Cliente = New Cliente(idCliente)
        objCliente.eliminar()
        Return True
    End Function

    Public Function buscarCliente(ByVal nombre As String)
        Dim objCliente As Cliente = New Cliente(nombre)
        Dim datareader As MySqlDataReader = objCliente.buscar
        While datareader.Read()
            objCliente = New Cliente(datareader("idC"), datareader("nombreC"), datareader("telefonoC"))
            Me.hashCliente.Add(objCliente.Nombre, objCliente)
        End While
        Return Me.hashCliente
    End Function

End Class
