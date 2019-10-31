Public Class FrmImprimirOrden
    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings 'permite ajustar tamaño y copias
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        End If
    End Sub

    Private Sub btnCancelarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarImp.Click
        Me.Hide()
        FrmListaOrden.Show()
    End Sub

    Private Sub FrmImprimirOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub cargarOrden(ByVal objOrden As Orden, ByVal objCliente As Cliente, ByVal objDispisitivo As Dispositivo)
        lblFecha.Text = objOrden.Fecha.ToString("dd/MM/yyyy")
        lblHora.Text = objOrden.Hora.ToString
        txtBat.Text = objDispisitivo.Bateria.ToString
        txtCargador.Text = objDispisitivo.Cargador.ToString
        txtEstuche.Text = objDispisitivo.Estuche.ToString
        txtFalla.Text = objOrden.Falla.ToString
        txtImporte.Text = objOrden.Importe.ToString
        txtModelo.Text = objDispisitivo.Modelo.ToString
        txtNombre.Text = objCliente.Nombre.ToString
        txtOrden.Text = objOrden.IdOrden.ToString
        txtPin.Text = objDispisitivo.Pin.ToString
        txtReso.Text = objOrden.Resolucion.ToString
        txtSim.Text = objDispisitivo.Sim.ToString
        txtTapa.Text = objDispisitivo.Tapa.ToString
        txtTel.Text = objCliente.Telefono.ToString
        txtTMem.Text = objDispisitivo.Tmemoria.ToString
    End Sub

    'ByVal fecha As String, ByVal hora As String, ByVal idOrden As Integer, ByVal modelo As String, ByVal nombre As String, ByVal tel As String, ByVal pin As Integer, ByVal falla As String, ByVal bateria As Boolean, ByVal cargador As Boolean, ByVal estuche As Boolean, ByVal sim As Boolean, ByVal tapa As Boolean, ByVal tmemoria As Boolean, ByVal dolar As Boolean, ByVal importe As Integer
End Class