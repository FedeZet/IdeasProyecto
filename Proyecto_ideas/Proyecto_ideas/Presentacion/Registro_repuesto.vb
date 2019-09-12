Public Class Registro_repuesto

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim objManUsuario As ManUsuario = New ManUsuario
        'objManUsuario.crearUsuario(Me.txtRNombre.Text, Me.nudRCantidad.Text)
        Me.Close()
        lista_repuestos.Show()
    End Sub

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click
        Me.Close()
        lista_repuestos.Show()
    End Sub
End Class