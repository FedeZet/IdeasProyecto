Public Class Historial_ordenes

    Private Sub btnVolverOrdenesLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenesLista.Click
        Menu_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarO.Click
        Registro_orden.Show()
    End Sub
End Class