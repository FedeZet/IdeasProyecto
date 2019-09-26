Imports MySql.Data.MySqlClient
Public Class ManCliente

    Public Function crearCliente(ByVal nombre As String, ByVal telefono As String)

        Dim objCliente As Cliente = New Cliente(nombre, telefono)
        objCliente.guardar()
        Return True
    End Function

End Class
