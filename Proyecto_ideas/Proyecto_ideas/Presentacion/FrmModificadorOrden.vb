Public Class FrmModificadorOrden
    Dim idU As Integer
    Dim idC As Integer
    Dim idD As Integer
    Dim hora
    Private Sub FrmModificadorOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub obtenerOrden(ByVal objOrden As Orden)
        lblNOrden.Text = objOrden.IdOrden.ToString
        lblFecha.Text = objOrden.Fecha.ToString("dd/MM/yyyy")
        txtFalla.Text = objOrden.Falla
        txtResolucion.Text = objOrden.Resolucion
        txtImporte.Text = objOrden.Importe.ToString
        If objOrden.Dolar = True Then
            chbDolar.Checked = True
        End If
        If objOrden.Garantia = True Then
            chbGarantia.Checked = True
        End If
        Select Case objOrden.Estado
            Case "Pendiente"
                rdPendiente.Checked = True
            Case "En espera"
                rdEspera.Checked = True
            Case "Reparado"
                rdReparado.Checked = True
            Case "Entregado"
                rdEntregado.Checked = True
        End Select

        idU = objOrden.idU
        idC = objOrden.idC
        idD = objOrden.idD
        hora = objOrden.Hora
    End Sub

    Private Sub btnModificarOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarOrden.Click
        Dim dolar As Boolean
        Dim garantia As Boolean
        Dim estado As String = ""
        If chbDolar.Checked = True Then
            dolar = True
        End If
        If chbGarantia.Checked = True Then
            garantia = True
        End If
        If rdPendiente.Checked = True Then
            estado = "Pendiente"
        End If
        If rdEspera.Checked = True Then
            estado = "En espera"
        End If
        If rdReparado.Checked = True Then
            estado = "Reparado"
        End If
        If rdEntregado.Checked = True Then
            estado = "Entregado"
        End If

        ManOrden.getInstancia.modificarOrden(lblNOrden.Text, txtFalla.Text, txtResolucion.Text, txtImporte.Text, dolar, garantia, lblFecha.Text, hora, estado, idU, idC, idD)
        MsgBox("Se modifico la orden.")
        FrmListaOrden.btnRefresh.PerformClick()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class