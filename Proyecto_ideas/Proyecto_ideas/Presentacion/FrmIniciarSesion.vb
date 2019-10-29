Public Class FrmIniciarSesion

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        Dim validacion = ManUsuario.getInstancia.iniciarSesion(Me.txtUsuario.Text, Me.txtContrasenia.Text)

        If validacion = True Then
            FrmInicio.Show()
            Me.Hide()

        Else
            lblError.Text = "       " + "Usuario y/o contraseña incorrectos."
            lblError.Visible = True

        End If

        If txtUsuario.Text <> "" & txtContrasenia.Text Then
            If txtUsuario.Text <> "" Then
                If txtContrasenia.Text <> "" Then
                Else
                    lblError.Text = "       " + "Contraseña vacía."
                    lblError.Visible = True
                End If
            Else
                lblError.Text = "       " + "Usuario vacío."
                lblError.Visible = True
            End If
        Else
            lblError.Text = "       " + "Usuario y contraseña vacíos."
            lblError.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class