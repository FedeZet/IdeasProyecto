Public Class modificadorRepuesto
    Dim idRepuesto

    Private Sub btnCancelarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarR.Click
        Me.Hide()
        lista_repuestos.Show()
    End Sub

    Private Sub modificadorRepuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarR.Click
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        objManRepuesto.modificarRepuesto(idRepuesto, txtMUnombre.Text, txtMUcantidad.Text)
    End Sub

    Public Function modificarRepuesto(ByVal id As Integer, ByVal nombre As String, ByVal cantidad As Integer)
        idRepuesto = id
        txtMUnombre.Text = nombre
        txtMUcantidad.Text = cantidad.ToString
    End Function
End Class