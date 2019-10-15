Public Class Menu_Inicio

    Private Sub btnOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrden.Click
        Historial_ordenes.Show()
        Me.Hide()
    End Sub

    Private Sub btnRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepuesto.Click
        lista_repuestos.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        Historial_usuario.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductividad.Click

    End Sub
End Class