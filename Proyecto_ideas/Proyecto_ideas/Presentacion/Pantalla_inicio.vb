Public Class Pantalla_inicio

    Private Sub btnRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepuesto.Click
        lista_repuestos.Show()
        Me.Hide()
    End Sub

    Private Sub btnOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrden.Click
        Historial_ordenes.Show()
        Me.Hide()
    End Sub
End Class