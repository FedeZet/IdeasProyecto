Public Class FrmCambiarPass

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim actual As String = txtActual.Text
        Dim actualEncriptada As String = Encriptar.SHA256Encriptador(actual)

        If txtActual.Text <> "" And txtNueva.Text <> "" And txtRNueva.Text <> "" Then
            If actualEncriptada = UsuarioActivo.pass Then
                If txtNueva.Text = txtRNueva.Text Then
                    ManUsuario.getInstancia.cambiarContrasenia(txtNueva.Text)
                    UsuarioActivo.pass = txtNueva.Text
                    MsgBox("Contraseña cambiada.")
                    Me.Close()
                Else
                    lblError.Text = "       " + "Las contraseñas no coinciden."
                End If
            Else
                lblError.Text = "       " + "La contraseña actual no es correcta."
            End If
        Else
            lblError.Text = "       " + "Los campos no pueden estar vacíos."
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub
End Class