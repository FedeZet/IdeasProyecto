Public Class Registro_cliente

    Private Sub btnCAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAgregar.Click

        Dim objManCliente As ManCliente = New ManCliente
        objManCliente.crearCliente(Me.txtCNombre.Text, Me.txtCTelefono.Text, Me.txtMailC.Text)
        Me.Hide()


        MsgBox("El cliente se ha creado exitosamente.")

        lista_clientes.dgvListadoCliente.Rows.Clear()

        Dim hashCliente As Hashtable
        hashCliente = objManCliente.obtenerCliente()
        lista_clientes.CargarDGV(hashCliente)

    End Sub

    Private Sub btnCCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCancelar.Click

        lista_clientes.Show()
        Me.Close()

    End Sub

    Private Sub txtCNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCNombre.KeyPress
        Letras(e)
    End Sub

    Private Sub txtCTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCTelefono.KeyPress
        Numeros(e)
    End Sub
End Class