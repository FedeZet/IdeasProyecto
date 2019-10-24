Public Class FrmRegistroUsuario

    Private Sub Registro_usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnRegistrarUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrarUser.Click

        ManRepuesto.getInstancia.crearUsuario(Me.txtUsuario.Text, Me.txtContra.Text, Me.txtNombre.Text, Me.txtTelefono.Text, Me.txtCostoServicio.Text)

        MsgBox("El usuario se ha creado exitosamente.")

        FrmListaUsuario.dgvListadoUsuario.Rows.Clear()
        Dim hashUsuario As Hashtable
        hashUsuario = ManRepuesto.getInstancia.obtenerUsuario()
        FrmListaUsuario.CargarDGV(hashUsuario)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmInicio.Show()
        Me.Close()
    End Sub

    Private Sub txtCostoServicio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCostoServicio.KeyPress
        Numeros(e)
    End Sub

    Private Sub txtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombre.KeyPress
        Letras(e)
    End Sub

    Private Sub txtTelefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefono.KeyPress
        Numeros(e)
    End Sub
End Class