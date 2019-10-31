Public Class FrmModifUsuario

    Dim idUsuario As Integer

    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUModificar.Click

        If txtCostoServicio.Text = "" Then
            txtCostoServicio.Text = "0"
        End If

        ManUsuario.getInstancia.modificarUsuario(idUsuario, txtUsuario.Text, txtNombre.Text, txtTelefono.Text, txtCostoServicio.Text)

        FrmListaUsuario.dgvListadoUsuario.Rows.Clear()
        Dim hashUsuario As Hashtable
        hashUsuario = ManUsuario.getInstancia.obtenerUsuario()
        FrmListaUsuario.CargarDGV(hashUsuario)
        Me.Close()

    End Sub

    Private Sub btnUCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUCancelar.Click
        Me.Close()

    End Sub

    Public Function cargarUsuario(ByVal id As Integer, ByVal nick As String, ByVal nombre As String, ByVal telefono As String, ByVal costoServicio As String)
        idUsuario = id
        txtUsuario.Text = nick
        txtNombre.Text = nombre
        txtTelefono.Text = telefono
        txtCostoServicio.Text = costoServicio
        Return True

    End Function

    Private Sub txtCostoU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoServicio.KeyPress
        Numeros(e)

    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Letras(e)

    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Numeros(e)

    End Sub
End Class