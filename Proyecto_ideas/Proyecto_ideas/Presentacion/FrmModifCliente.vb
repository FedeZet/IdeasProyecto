Public Class FrmModifCliente

    Dim idCliente

    Private Sub btnModificarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarC.Click
        ManCliente.getInstancia.modificarCliente(idCliente, txtMCnombre.Text, txtMCtelefono.Text, txtModCEmail.Text)

        MsgBox("El cliente ha sido modificado con éxito.")

        FrmListaCliente.dgvListadoCliente.Rows.Clear()

        Dim hashCliente As Hashtable
        hashCliente = ManCliente.getInstancia.obtenerCliente()
        FrmListaCliente.CargarDGV(hashCliente)
        Me.Close()
    End Sub

    Private Sub btnCancelarC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarC.Click
        FrmListaCliente.Show()
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

    Private Sub FrmModifCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class