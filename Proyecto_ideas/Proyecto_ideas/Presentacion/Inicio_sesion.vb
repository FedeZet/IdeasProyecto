Public Class Inicio_sesion

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim validacion = objManUsuario.iniciarSesion(Me.txtUsuario.Text, Me.txtContrasenia.Text)

        If validacion = True Then
            Menu_Inicio.Show()
            Me.Hide()
        Else
            MsgBox("Usuario y/o contraseña incorrectos.")
        End If
    End Sub
End Class