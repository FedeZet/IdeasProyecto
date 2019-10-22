Public Class modificadorCliente

    Dim idCliente

    Private Sub btnModificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarC.Click
        Dim objManCliente As ManCliente = New ManCliente
        objManCliente.modificarCliente(idCliente, txtMCnombre.Text, txtMCtelefono.Text, txtModCEmail.Text)
    End Sub

    Private Sub btnCancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarC.Click
        lista_clientes.Show()
        Me.Close()
    End Sub

    Public Function cargarCliente(ByVal id As Integer, ByVal nombre As String, ByVal telefono As String)
        idCliente = id
        txtMCnombre.Text = nombre
        txtMCtelefono.Text = telefono
        Return True
    End Function

    Private Sub txtMCnombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMCnombre.KeyPress
        Letras(e)
    End Sub

    Private Sub txtMCtelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMCtelefono.KeyPress
        Numeros(e)
    End Sub
End Class