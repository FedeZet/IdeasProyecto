Public Class Registro_orden

    Private Sub btnCrearOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearOrden.Click
        'se crea la orden
        Dim estado As Integer
        Dim garantia As Boolean = False

        If (rdPendiente.Checked = True) Then
            estado = 1
        ElseIf (rdEspera.Checked = True) Then
            estado = 2
        ElseIf (rdReparado.Checked = True) Then
            estado = 3
        ElseIf (rdEntregado.Checked = True) Then
            estado = 4
        End If

        If chbGarantia.Checked = True Then
            garantia = True
        End If

        Dim hora As DateTime = DateTime.Now.ToShortTimeString()

        'Dim objManOrden As ManOrden = New ManOrden
        'objManOrden.agregarOrden(Me.txtFalla.Text, Me.txtImporte.Text, garantia, Me.lblFecha.Text, hora, estado)

        'se crea el cliente
        Dim objManCliente As ManCliente = New ManCliente
        objManCliente.crearCliente(Me.txtNombreCli.Text, Me.txtTel.Text)

        'se crea el dispositivo
        Dim objManDispositivo As ManDispositivo = New ManDispositivo
        Dim bateria, sim, cargador, tapa, estuche, memoria As Boolean
        If chbBateria.Checked = True Then
            bateria = True
        Else
            bateria = False
        End If
        If chbSIM.Checked = True Then
            sim = True
        Else
            sim = False
        End If
        If chbCargador.Checked = True Then
            cargador = True
        Else
            cargador = False
        End If
        If chbTapa.Checked = True Then
            tapa = True
        Else
            tapa = False
        End If
        If chbEstuche.Checked = True Then
            estuche = True
        Else
            estuche = False
        End If
        If chbMemoria.Checked = True Then
            memoria = True
        Else
            memoria = False
        End If


        objManDispositivo.crearDispositivo(Me.txtModelo.Text, bateria, sim, cargador, tapa, estuche, memoria, Me.txtPIN.Text)

        MsgBox("La orden se ha creado exitosamente.")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Historial_ordenes.Show()
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")

        'Dim objManUsuario As ManUsuario = New ManUsuario
        'Dim hashTecnico As Hashtable
        'hashTecnico = objManUsuario.obtenerTecnico()
        'Me.CargarTecnicos(hashTecnico)
    End Sub

    Sub CargarTecnicos(ByVal colTecnico As Hashtable)
        For Each DEntry As DictionaryEntry In colTecnico
            Dim objU As Usuario = CType(DEntry.Value, Usuario)

        Next
    End Sub

    Private Sub Registro_orden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class