Public Class FrmListaOrden

    Public Sub New()
        InitializeComponent()
        Dim hashOrden As Hashtable
        hashOrden = ManOrden.getInstancia.obtenerOrden()
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
            Me.dgvListaOrdenes(6, cantFilas).Value = objO.Fecha.ToString("dd/MM/yyyy")
            Me.dgvListaOrdenes(7, cantFilas).Value = objO.Hora
            Me.dgvListaOrdenes(8, cantFilas).Value = objO.Estado
            Me.dgvListaOrdenes(9, cantFilas).Value = objO.idU.ToString
            Me.dgvListaOrdenes(10, cantFilas).Value = objO.idC.ToString
            Me.dgvListaOrdenes(11, cantFilas).Value = objO.idD.ToString

        Next
    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub btnOAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOAgregar.Click
        FrmRegistroOrden.Show()
    End Sub

    Private Sub btnOImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOImprimir.Click
        Me.Hide()
        FrmImprimirOrden.Show()
    End Sub

    Private Sub btnOEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOEliminar.Click
        Dim resultado As Integer = MsgBox("Desea Eliminar esta orden? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            ManOrden.getInstancia.eliminarOrden(dgvListaOrdenes.CurrentRow.Cells("idO").Value.ToString)
            MsgBox("La orden ha sido eliminada con éxito.")
            btnRefresh.PerformClick()
        Else
            MsgBox("La orden no ha sido eliminada.")

        End If
    End Sub

    'Private Sub dgvListaOrdenes_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListaOrdenes.
    '    btnOEliminar.Enabled = True
    '    btnOModificar.Enabled = True
    'End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.dgvListaOrdenes.Rows.Clear()
        Dim hashOrden As Hashtable
        hashOrden = ManOrden.getInstancia.obtenerOrden()
        Me.CargarDGV(hashOrden)
    End Sub

    Private Sub dgvListaOrdenes_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvListaOrdenes.CellFormatting
        Dim EstadoC As String
        If dgvListaOrdenes.Columns(e.ColumnIndex).Name.Equals("estado") Then
            EstadoC = (dgvListaOrdenes.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)

            If EstadoC = "Pendiente" Then
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#F1948A")
            ElseIf EstadoC = "En Espera" Then
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#F7DC6F")
            ElseIf EstadoC = "Reparado" Then
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#ABEBC6")
            ElseIf EstadoC = "Entregado" Then
                e.CellStyle.BackColor = ColorTranslator.FromHtml("#A9CCE3")
            End If
        End If
    End Sub

    Private Sub dgvListaOrdenes_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListaOrdenes.SelectionChanged
        btnOEliminar.Enabled = True
        btnORepuesto.Enabled = True

    End Sub

    Private Sub btnORepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnORepuesto.Click
        FrmListaRepuestosUtilizados.Show()
        FrmListaRepuestosUtilizados.obtenerOrden(dgvListaOrdenes.CurrentRow.Cells("idO").Value)
    End Sub
End Class