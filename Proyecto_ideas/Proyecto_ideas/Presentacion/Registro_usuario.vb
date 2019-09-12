Public Class Registro_usuario

    Private Sub Registro_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnRegistrarUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarUser.Click
        Dim objManUsuario As ManUsuario = New ManUsuario
        objManUsuario.crearUsuario(Me.txtID.Text, Me.txtUsuario.Text, Me.txtContra.Text, Me.txtNombre.Text, Me.txtTelefono.Text)
    End Sub
End Class