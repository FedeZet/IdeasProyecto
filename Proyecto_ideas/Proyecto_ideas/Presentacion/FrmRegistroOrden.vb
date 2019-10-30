Public Class FrmRegistroOrden

    Dim idU As Integer
    Dim idC As Integer
    Dim idD As Integer

    Private Sub btnCrearOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearOrden.Click
        'se crea la orden
        Dim estado As String = ""
        Dim garantia, dolar As Boolean

        If (rdPendiente.Checked = True) Then
            estado = "Pendiente"
        ElseIf (rdEspera.Checked = True) Then
            estado = "En Espera"
        ElseIf (rdReparado.Checked = True) Then
            estado = "Reparado"
        ElseIf (rdEntregado.Checked = True) Then
            estado = "Entregado"
        End If

        If chbGarantia.Checked = True Then
            garantia = True
        End If
        If chbDolar.Checked = True Then
            dolar = True
        End If

        Dim horaDateTime As DateTime = DateTime.Now.ToString("HH:mm:ss")
        Dim hora As TimeSpan = horaDateTime.TimeOfDay

        Dim fecha As DateTime = DateTime.Now.ToString("dd/MM/yyyy")


        If (idU Or idC Or idD) = Nothing Then
            MsgBox("Seleccione un usuario, cliente y dispositivo")
        Else
            ManOrden.getInstancia.agregarOrden(Me.txtFalla.Text, txtResolucion.Text, txtImporte.Text, dolar, garantia, fecha, hora, estado, idU, idC, idD)

            MsgBox("La orden se ha creado exitosamente.")
            Me.Close()

        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Dim hashTecnico As Hashtable
        hashTecnico = ManUsuario.getInstancia.obtenerTecnico()
        Me.CargarTecnicos(hashTecnico)


    End Sub

    Sub CargarTecnicos(ByVal colTecnico As Hashtable)

        For Each DEntry As DictionaryEntry In colTecnico
            Dim objU As Usuario = CType(DEntry.Value, Usuario)
            cbTecnico.Items.Add(objU)


        Next
    End Sub


    Private Sub Registro_orden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cbTecnico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTecnico.SelectedIndexChanged

        Dim objU As Usuario = CType(cbTecnico.SelectedItem, Usuario)
        idU = objU.IdUsuario.ToString

    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click

        FrmListaCliente.Show()
        FrmListaCliente.btnCSeleccionar.Enabled = True

    End Sub

    Private Sub btnDipositivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDipositivo.Click

        If idC = Nothing Then
            MsgBox("Debe seleccionar a un cliente.")
        Else
            FrmListaDispositivo.Show()
            FrmListaDispositivo.obtenerDisCli(idC)
            FrmListaDispositivo.btnDSeleccionar.Enabled = True
        End If

    End Sub

    Public Sub obtenerCliente(ByVal idCliente As Integer, ByVal nombreCliente As String, ByVal telefonoCliente As String)

        idC = idCliente
        txtNombreCli.Text = nombreCliente
        txtTel.Text = telefonoCliente

    End Sub

    Public Sub obtenerDispositivo(ByVal idDispositivo As Integer, ByVal modelo As String)

        idD = idDispositivo
        txtModelo.Text = modelo

    End Sub

    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        Numeros(e)
    End Sub

End Class