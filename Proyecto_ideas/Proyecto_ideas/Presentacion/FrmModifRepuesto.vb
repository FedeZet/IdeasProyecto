Public Class FrmModifRepuesto
    Dim idRepuesto

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click
        Me.Close()

    End Sub

    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRModificar.Click
        If txtRCosto.Text = "" Then
            txtRCosto.Text = "0"
        End If

        ManRepuesto.getInstancia.modificarRepuesto(idRepuesto, txtRNombre.Text, nudRCantidad.Text, txtRCosto.Text)

        MsgBox("El repuesto ha sido modificado con éxito.")

        FrmListaRepuesto.dgvListadoRepuesto.Rows.Clear()
        Dim hashRepuesto As Hashtable
        hashRepuesto = ManRepuesto.getInstancia.obtenerRepuesto()
        FrmListaRepuesto.CargarDGV(hashRepuesto)

        Me.Close()

    End Sub

    Public Function cargarRepuesto(ByVal id As Integer, ByVal nombre As String, ByVal cantidad As Integer, ByVal costo As Integer)
        idRepuesto = id
        txtRNombre.Text = nombre
        nudRCantidad.Text = cantidad.ToString
        txtRCosto.Text = costo.ToString
        Return True

    End Function

    Private Sub txtMUcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Numeros(e)

    End Sub
End Class