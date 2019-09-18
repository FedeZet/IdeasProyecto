Public Class ManUsuario
    Public Function crearUsuario(ByVal IdUsuario As Integer, ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)

        Dim objUsuario As Usuario = New Usuario(IdUsuario, user, password, nombre, telefono)
        objUsuario.guardar()
        Return true
    End Function

    Public Function iniciarSesion(ByVal user As String, ByVal password As String) As String

        Dim objIniciar As Usuario = New Usuario(user, password)
        objIniciar.iniciarSesion()
        Return True
    End Function
End Class
