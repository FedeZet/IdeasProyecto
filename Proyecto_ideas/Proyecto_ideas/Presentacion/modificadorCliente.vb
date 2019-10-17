Public Class modificadorCliente

    Dim idCliente

    Private Sub btnModificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarC.Click
        Dim objManCliente As ManCliente = New ManCliente
        objManCliente.modificarCliente(idCliente, txtMCnombre.Text, txtMCtelefono.Text)
    End Sub

    Private Sub btnCancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarC.Click
        Lista_clientesvb.Show()
        Me.Close()
    End Sub

    Public Function cargarRepuesto(ByVal id As Integer, ByVal nombre As String, ByVal telefono As String)
        idCliente = id
        txtMCnombre.Text = nombre
        txtMCtelefono.Text = telefono
        Return True
    End Function

    Private Sub modificadorCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class