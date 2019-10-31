Imports MySql.Data.MySqlClient
Public Class ManCliente
    Dim hashCliente As Hashtable = New Hashtable
    Private Shared instancia As ManCliente

    Public Function crearCliente(ByVal nombre As String, ByVal telefono As String, ByVal correo As String)

        Dim objCliente As Cliente = New Cliente(nombre, telefono, correo)
        objCliente.guardar()
        Return True
    End Function

    Public Function obtenerCliente() As Hashtable
        hashCliente.Clear()
        Dim datareader As MySqlDataReader = Cliente.obtenerClientes()
        Dim objC As Cliente = Nothing
        While datareader.Read()
            objC = New Cliente(datareader("idC"), datareader("nombreC"), datareader("telefonoC"), datareader("email"))
            Me.hashCliente.Add(objC.IdCliente, objC)
        End While
        Return Me.hashCliente
    End Function

    Public Function modificarCliente(ByVal idCliente As Integer, ByVal nombreCliente As String, ByVal telefonoCliente As String, ByVal correoCliente As String)
        Dim objCliente As Cliente = New Cliente(idCliente, nombreCliente, telefonoCliente, correoCliente)
        objCliente.modificar()
        Return True
    End Function

    Public Function eliminarCliente(ByVal idCliente As Integer)
        Dim objCliente As Cliente = New Cliente(idCliente)
        objCliente.eliminar()
        Return True
    End Function

    Public Function buscarCliente(ByVal nombre As String)
        hashCliente.Clear()
        Dim objCliente As Cliente = New Cliente(nombre)
        Dim datareader As MySqlDataReader = objCliente.buscar
        While datareader.Read()
            objCliente = New Cliente(datareader("idC"), datareader("nombreC"), datareader("telefonoC"), datareader("email"))
            Me.hashCliente.Add(objCliente.Nombre, objCliente)
        End While
        Return Me.hashCliente
    End Function

    Public Function buscarClienteID(ByVal idCliente As Integer)
        hashCliente.Clear()
        Dim objCliente As Cliente = New Cliente(idCliente)
        Dim datareader As MySqlDataReader = objCliente.buscarID
        While datareader.Read()
            objCliente = New Cliente(datareader("idC"), datareader("nombreC"), datareader("telefonoC"), datareader("email"))
            Me.hashCliente.Add(objCliente.IdCliente, objCliente)
        End While
        Return Me.hashCliente
    End Function

    Private Sub New()

    End Sub


    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManCliente
        End If
        Return instancia
    End Function
End Class
