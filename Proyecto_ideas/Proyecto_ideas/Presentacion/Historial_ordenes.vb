Public Class Historial_ordenes

    Public Sub New()
        InitializeComponent()
        Dim objManOrden As ManOrden = New ManOrden
        Dim hashOrden As Hashtable
        hashOrden = objManOrden.obtenerOrden()
        Me.CargarDGV(hashOrden)

    End Sub

    Sub CargarDGV(ByVal colOrden As Hashtable)
        For Each DEntry As DictionaryEntry In colOrden
            Dim objO As Orden = CType(DEntry.Value, Orden)
            Me.dgvListaOrdenes.Rows.Add()
            Dim dolar, garantia As String
            If objO.Dolar = True Then
                dolar = "Si"
            Else
                dolar = "No"
            End If
            If objO.Garantia = True Then
                garantia = "Si"
            Else
                garantia = "No"
            End If

            Dim cantFilas As Integer = Me.dgvListaOrdenes.Rows.Count - 1
            Me.dgvListaOrdenes(0, cantFilas).Value = objO.IdOrden.ToString
            Me.dgvListaOrdenes(1, cantFilas).Value = objO.Falla
            Me.dgvListaOrdenes(2, cantFilas).Value = objO.Resolucion
            Me.dgvListaOrdenes(3, cantFilas).Value = objO.Importe.ToString
            Me.dgvListaOrdenes(4, cantFilas).Value = dolar
            Me.dgvListaOrdenes(5, cantFilas).Value = garantia
            Me.dgvListaOrdenes(6, cantFilas).Value = objO.Fecha
            Me.dgvListaOrdenes(7, cantFilas).Value = objO.Hora
            Me.dgvListaOrdenes(8, cantFilas).Value = objO.Estado
            Me.dgvListaOrdenes(9, cantFilas).Value = objO.idU.ToString
            Me.dgvListaOrdenes(10, cantFilas).Value = objO.idC.ToString
            Me.dgvListaOrdenes(11, cantFilas).Value = objO.idD.ToString

        Next
    End Sub

    Private Sub btnVolverOrdenesLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenesLista.Click
        Menu_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnAgregarO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarO.Click
        Registro_orden.Show()
    End Sub

    Private Sub btnListaImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListaImprimir.Click
        Me.Hide()
        ImprimirOrden.Show()
    End Sub

    Private Sub btnCModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCModificar.Click

    End Sub

    Private Sub btnCEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCEliminar.Click

        Dim objManOrden As ManOrden = New ManOrden
        Dim resultado As Integer = MsgBox("Desea Eliminar esta orden? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            objManOrden.eliminarOrden(dgvListaOrdenes.CurrentRow.Cells("idO").Value.ToString)
            MsgBox("La orden ha sido eliminada con éxito.")
        Else
            MsgBox("La orden no ha sido eliminada.")
        End If

    End Sub

    Private Sub Historial_ordenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class