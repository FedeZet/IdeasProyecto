Public Class FrmRegistroRepuesto

    Private Sub btnRRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRRegistrar.Click
        If txtRCosto.Text = "" Then
            txtRCosto.Text = "0"
        End If

        ManRepuesto.getInstancia.agregarRepuesto(Me.txtRNombre.Text, Me.nudRCantidad.Text, Me.txtRCosto.Text)

        MsgBox("El repuesto se ha creado exitosamente.")

        FrmListaRepuesto.dgvListadoRepuesto.Rows.Clear()
        Dim hashRepuesto As Hashtable
        hashRepuesto = ManRepuesto.getInstancia.obtenerRepuesto()
        FrmListaRepuesto.CargarDGV(hashRepuesto)

        Me.Close()
    End Sub

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click
        Me.Close()

    End Sub

    Private Sub nudRCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudRCantidad.KeyPress
        Numeros(e)

    End Sub
End Class