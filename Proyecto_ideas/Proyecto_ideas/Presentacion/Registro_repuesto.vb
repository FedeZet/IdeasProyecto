Public Class Registro_repuesto

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        objManRepuesto.agregarRepuesto(Me.txtRID.Text, Me.txtRNombre.Text, Me.nudRCantidad.Text)
        Me.Hide()
        lista_repuestos.Show()
    End Sub

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click
        Me.Close()
        lista_repuestos.Show()
    End Sub
End Class