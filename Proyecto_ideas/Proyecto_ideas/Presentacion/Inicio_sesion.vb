Public Class Inicio_sesion

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim objManUsuario As ManUsuario = New ManUsuario
        objManUsuario.iniciarSesion(Me.txtUsuario.Text, Me.txtContrasenia.Text)

        Try

        Catch ex As Exception

        End Try
    End Sub
End Class