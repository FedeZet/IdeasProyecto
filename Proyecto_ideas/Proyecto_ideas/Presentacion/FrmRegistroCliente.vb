Public Class FrmRegistroCliente

    Private Sub btnCRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCRegistrar.Click

        ManCliente.getInstancia.crearCliente(Me.txtCNombre.Text, Me.txtCTelefono.Text, Me.txtCMail.Text)

        MsgBox("El cliente se ha creado exitosamente.")

        FrmListaCliente.dgvListadoCliente.Rows.Clear()

        Dim hashCliente As Hashtable
        hashCliente = ManCliente.getInstancia.obtenerCliente()
        FrmListaCliente.CargarDGV(hashCliente)

        Me.Close()
    End Sub

    Private Sub btnCCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)
    End Sub

    Private Sub txtCTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Numeros(e)
    End Sub
End Class