Public Class Registro_repuesto

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        objManRepuesto.agregarRepuesto(Me.txtRNombre.Text, Me.nudRCantidad.Text, Me.txtCostoRe.Text)
        Me.Hide()
        lista_repuestos.Show()

        MsgBox("El repuesto se ha creado exitosamente.")

    End Sub

    Private Sub btnRCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRCancelar.Click

        lista_repuestos.Show()
        Me.Close()

    End Sub

    Private Sub Registro_repuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nudRCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudRCantidad.KeyPress
        Numeros(e)
    End Sub
End Class