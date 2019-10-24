Public Class FrmRegistroRepuesto

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        ManRepuesto.getInstancia.agregarRepuesto(Me.txtRNombre.Text, Me.nudRCantidad.Text, Me.txtCostoRe.Text)
        Me.Hide()
        FrmListaRepuesto.Show()

        MsgBox("El repuesto se ha creado exitosamente.")

        FrmListaRepuesto.dgvListadoRepuesto.Rows.Clear()
        Dim hashRepuesto As Hashtable
        hashRepuesto = ManRepuesto.getInstancia.obtenerRepuesto()
        FrmListaRepuesto.CargarDGV(hashRepuesto)
    End Sub

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click

        FrmListaRepuesto.Show()
        Me.Close()

    End Sub

    Private Sub Registro_repuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nudRCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudRCantidad.KeyPress
        Numeros(e)
    End Sub
End Class