Public Class FrmModifUsuario
    Dim idUsuario As Integer
    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarR.Click

        ManUsuario.getInstancia.modificarUsuario(idUsuario, txtNick.Text, txtNombre.Text, txtTelefono.Text, txtCostoU.Text)

        FrmListaUsuario.dgvListadoUsuario.Rows.Clear()
        Dim hashUsuario As Hashtable
        hashUsuario = ManUsuario.getInstancia.obtenerUsuario()
        FrmListaUsuario.CargarDGV(hashUsuario)
        Me.Close()
    End Sub

    Private Sub btnCancelarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarR.Click

        FrmListaUsuario.Show()
        Me.Close()
    End Sub

    Public Function cargarUsuario(ByVal id As Integer, ByVal nick As String, ByVal nombre As String, ByVal telefono As String, ByVal costoServicio As String)
        idUsuario = id
        txtNick.Text = nick
        txtNombre.Text = nombre
        txtTelefono.Text = telefono
        txtCostoU.Text = costoServicio
        Return True

    End Function


    Private Sub modificadorUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtCostoU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoU.KeyPress
        Numeros(e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Letras(e)
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Numeros(e)
    End Sub
End Class