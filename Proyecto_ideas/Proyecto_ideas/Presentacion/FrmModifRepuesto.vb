Public Class FrmModifRepuesto
    Dim idRepuesto

    Private Sub btnCancelarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarR.Click

        FrmListaRepuesto.Show()
        Me.Close()
    End Sub

    Private Sub modificadorRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarR.Click
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        objManRepuesto.modificarRepuesto(idRepuesto, txtMUnombre.Text, txtMUcantidad.Text, txtMCostoRep.Text)

        MsgBox("El repuesto ha sido modificado con éxito.")

        FrmListaRepuesto.dgvListadoRepuesto.Rows.Clear()
        Dim hashRepuesto As Hashtable
        hashRepuesto = objManRepuesto.obtenerRepuesto()
        FrmListaRepuesto.CargarDGV(hashRepuesto)
        Me.Close()
        FrmListaRepuesto.Show()
    End Sub

    Public Function cargarRepuesto(ByVal id As Integer, ByVal nombre As String, ByVal cantidad As Integer, ByVal costo As Integer)
        idRepuesto = id
        txtMUnombre.Text = nombre
        txtMUcantidad.Text = cantidad.ToString
        txtMCostoRep.Text = costo.ToString
        Return True
    End Function


    Private Sub txtMUcantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMUcantidad.KeyPress
        Numeros(e)
    End Sub
End Class