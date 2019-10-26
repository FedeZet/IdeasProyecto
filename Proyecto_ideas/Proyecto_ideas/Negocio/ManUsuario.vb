Imports MySql.Data.MySqlClient
Public Class ManUsuario
    Dim hashUsuario As Hashtable = New Hashtable
    Dim hashTecnico As Hashtable = New Hashtable

    Private Shared instancia As ManUsuario
    Public Function crearUsuario(ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String, ByVal costoServicio As Integer)
        Dim passEncriptada As String = Encriptar.SHA256Encriptador(password)

        Dim objUsuario As Usuario = New Usuario(user, passEncriptada, nombre, telefono, costoServicio)
        objUsuario.guardar()
        Return True
    End Function

    Public Function obtenerUsuario() As Hashtable
        hashUsuario.Clear()
        Dim datareader As MySqlDataReader = Usuario.obtenerUsuarios()
        Dim objU As Usuario = Nothing
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"), datareader("costoServicio"))
            Me.hashUsuario.Add(objU.IdUsuario, objU)
        End While
        Return Me.hashUsuario
    End Function

    Public Function obtenerTecnico() As Hashtable
        hashTecnico.Clear()
        Dim datareader As MySqlDataReader = Usuario.obtenerTecnico()
        Dim objU As Usuario = Nothing
        While datareader.Read()
            objU = New Usuario(CType(datareader("idU"), Integer), CType(datareader("nombreU"), String))
            Me.hashTecnico.Add(objU.IdUsuario, objU)
        End While
        Return Me.hashTecnico
    End Function

    Public Function modificarUsuario(ByVal idUsuario As Integer, ByVal nick As String, ByVal nombre As String, ByVal telefono As String, ByVal costoServicio As Integer)
        Dim objUsuario As Usuario = New Usuario(idUsuario, nick, nombre, telefono, costoServicio)
        objUsuario.modificar()
        Return True
    End Function

    Public Function eliminarUsuario(ByVal idUsuario As Integer)
        Dim objUsuario As Usuario = New Usuario(idUsuario)
        objUsuario.eliminar()
        Return True
    End Function

    Public Function buscarUsuario(ByVal nombre As String)
        hashUsuario.Clear()
        Dim objU As Usuario = New Usuario(nombre)
        Dim datareader As MySqlDataReader = objU.buscar
        While datareader.Read()
            objU = New Usuario(datareader("idU"), datareader("user"), datareader("pass"), datareader("nombreU"), datareader("telefonoU"), datareader("costoServicio"))
            Me.hashUsuario.Add(objU.Nombre, objU)
        End While
        Return Me.hashUsuario
    End Function

    Public Function iniciarSesion(ByVal user As String, ByVal pass As String)
        Dim passEncriptada As String = Encriptar.SHA256Encriptador(pass)

        Dim objUsuario As Usuario = New Usuario(user, passEncriptada)
        Dim verificar = objUsuario.autenticar(user, passEncriptada)
        If verificar = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManUsuario
        End If
        Return instancia
    End Function
End Class
