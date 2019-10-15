Public Class Historial_usuario

    Public Sub New()
        InitializeComponent()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.obtenerUsuario()
        Me.CargarDGV(hashUsuario)

    End Sub
    Sub CargarDGV(ByVal colRepuesto As Hashtable)
        For Each DEntry As DictionaryEntry In colRepuesto
            Dim objR As Usuario = CType(DEntry.Value, Usuario)
            Me.dgvListadoUsuario.Rows.Add()
            Dim cantFilas As Integer = dgvListadoUsuario.Rows.Count - 1
            Me.dgvListadoUsuario(0, cantFilas).Value = objR.IdUsuario.ToString
            Me.dgvListadoUsuario(1, cantFilas).Value = objR.User
            Me.dgvListadoUsuario(2, cantFilas).Value = objR.Nombre.ToString
            Me.dgvListadoUsuario(3, cantFilas).Value = objR.Telefono.ToString

        Next
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Me.dgvListadoUsuario.Rows.Clear()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.obtenerUsuario()
        Me.CargarDGV(hashUsuario)
    End Sub

    Private Sub btnVolverOrdenesLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenesLista.Click

        Menu_Inicio.Show()
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Me.Hide()
        modificadorUsuario.Show()
        modificadorUsuario.cargarUsuario(dgvListadoUsuario.CurrentRow.Cells("id_usuario").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("Nick").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("Nombre").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("Telefono").Value.ToString)
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim objManRepuesto As ManUsuario = New ManUsuario
        objManRepuesto.eliminarRepuesto(dgvListadoUsuario.CurrentRow.Cells("id_usuario").Value.ToString)

    End Sub

    Private Sub btnBuscarU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarU.Click
        Me.dgvListadoUsuario.Rows.Clear()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.buscarUsuario(Me.txtBuscadorU.Text)
        Me.CargarDGV(hashUsuario)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Registro_usuario.Show()
    End Sub

    Private Sub dgvListadoUsuario_RowHeaderMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoUsuario.RowHeaderMouseClick
        btnEliminar.Enabled = True
        btnModificar.Enabled = True
    End Sub
End Class