Public Class ManUsuario
    Public Function crearUsuario(ByVal IdUsuario As Integer, ByVal user As String, ByVal password As String, ByVal nombre As String, ByVal telefono As String)

        Dim objUsuario As Usuario = New Usuario(IdUsuario, user, password, nombre, telefono)
        objUsuario.guardar()
        Return true
    End Function
End Class
