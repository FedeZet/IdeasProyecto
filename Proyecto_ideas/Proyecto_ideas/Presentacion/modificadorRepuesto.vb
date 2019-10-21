Public Class modificadorRepuesto
    Dim idRepuesto

    Private Sub btnCancelarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarR.Click

        lista_repuestos.Show()
        Me.Close()
    End Sub

    Private Sub modificadorRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarR.Click
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        objManRepuesto.modificarRepuesto(idRepuesto, txtMUnombre.Text, txtMUcantidad.Text)

        MsgBox("El repuesto ha sido modificado con éxito.")
    End Sub

    Public Function cargarRepuesto(ByVal id As Integer, ByVal nombre As String, ByVal cantidad As Integer)
        idRepuesto = id
        txtMUnombre.Text = nombre
        txtMUcantidad.Text = cantidad.ToString
        Return True
    End Function
End Class