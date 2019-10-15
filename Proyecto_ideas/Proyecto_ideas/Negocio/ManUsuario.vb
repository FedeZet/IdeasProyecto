Imports MySql.Data.MySqlClient
Public Class ManUsuario
    Dim hashUsuario As Hashtable = New Hashtable
    Dim hashTecnico As Hashtable = New Hashtable
    Public Function crearUsuario(ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)

        Dim objUsuario As Usuario = New Usuario(user, password, nombre, telefono)
        objUsuario.guardar()
        Return True
    End Function

    Public Function obtenerUsuario() As Hashtable
        Dim datareader As MySqlDataReader = Usuario.obtenerUsuarios()
        Dim objU As Usuario = Nothing
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"))
            Me.hashUsuario.Add(objU.IdUsuario, objU)
        End While
        Return Me.hashUsuario
    End Function

    'Public Function obtenerTecnico() As Hashtable
    '    Dim datareader As MySqlDataReader = Usuario.obtenerTecnico()
    '    Dim objU As Usuario = Nothing
    '    While datareader.Read()
    '        objU = New Usuario(datareader("idU"), datareader("nombreU"))
    '        Me.hashTecnico.Add(objU.IdUsuario, objU)
    '    End While
    '    Return Me.hashTecnico
    'End Function

    Public Function modificarUsuario(ByVal idUsuario As Integer, ByVal nick As String, ByVal nombre As String, ByVal telefono As String)
        Dim objUsuario As Usuario = New Usuario(idUsuario, nick, nombre, telefono)
        objUsuario.modificar()
        Return True
    End Function

    Public Function eliminarRepuesto(ByVal idUsuario As Integer)
        Dim objUsuario As Usuario = New Usuario(idUsuario)
        objUsuario.eliminar()
        Return True
    End Function

    Public Function buscarUsuario(ByVal nombre As String)
        Dim objU As Usuario = New Usuario(nombre)
        Dim datareader As MySqlDataReader = objU.buscar
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"))
            Me.hashUsuario.Add(objU.Nombre, objU)
        End While
        Return Me.hashUsuario
    End Function
End Class
