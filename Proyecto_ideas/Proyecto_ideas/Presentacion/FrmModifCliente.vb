Public Class FrmModifCliente

    Dim idCliente

    Private Sub btnModificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCModificar.Click
        ManCliente.getInstancia.modificarCliente(idCliente, txtCNombre.Text, txtCTelefono.Text, txtCMail.Text)

        MsgBox("El cliente ha sido modificado con éxito.")

        FrmListaCliente.dgvListadoCliente.Rows.Clear()

        Dim hashCliente As Hashtable
        hashCliente = ManCliente.getInstancia.obtenerCliente()
        FrmListaCliente.CargarDGV(hashCliente)

        Me.Close()

    End Sub

    Private Sub btnCancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCCancelar.Click
        Me.Close()

    End Sub

    Public Function cargarCliente(ByVal id As Integer, ByVal nombre As String, ByVal telefono As String, ByVal mail As String)
        idCliente = id
        txtCNombre.Text = nombre
        txtCTelefono.Text = telefono
        txtCMail.Text = mail
        Return True

    End Function

    Private Sub txtMCnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Letras(e)

    End Sub

    Private Sub txtMCtelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Numeros(e)

    End Sub
End Class