Public Class modificadorUsuario
    Dim idUsuario As Integer
    Private Sub btnModificarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarR.Click

        Dim objManUsuario As ManUsuario = New ManUsuario
        objManUsuario.modificarUsuario(idUsuario, txtNick.Text, txtNombre.Text, txtTelefono.Text)

    End Sub

    Private Sub btnCancelarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarR.Click

        Historial_usuario.Show()
        Me.Close()
    End Sub

    Public Function cargarUsuario(ByVal id As Integer, ByVal nick As String, ByVal nombre As String, ByVal telefono As String)
        idUsuario = id
        txtNick.Text = nick
        txtNombre.Text = nombre
        txtTelefono.Text = telefono

        Return True

    End Function


    Private Sub modificadorUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class