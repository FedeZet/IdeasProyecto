Public Class Registro_cliente

    Private Sub btnCAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAgregar.Click

        Dim objManCliente As ManCliente = New ManCliente
        objManCliente.crearCliente(Me.txtCNombre.Text, Me.txtCTelefono.Text)
        Me.Hide()


        MsgBox("El cliente se ha creado exitosamente.")

    End Sub

    Private Sub btnCCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCancelar.Click

        lista_clientes.Show()
        Me.Close()

    End Sub
End Class