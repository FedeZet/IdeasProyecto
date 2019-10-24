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
            Me.dgvListadoUsuario(4, cantFilas).Value = objR.costoServicio.ToString
        Next
    End Sub

    Private Sub btnURefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnURefresh.Click
        Me.dgvListadoUsuario.Rows.Clear()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.obtenerUsuario()
        Me.CargarDGV(hashUsuario)
    End Sub

    Private Sub btnUVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUVolver.Click
        Menu_Inicio.Show()
        Me.Close()

    End Sub

    Private Sub btnUModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUModificar.Click
        'Me.Hide()
        modificadorUsuario.Show()
        modificadorUsuario.cargarUsuario(dgvListadoUsuario.CurrentRow.Cells("idU").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("user").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("nombre").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("telefono").Value.ToString, dgvListadoUsuario.CurrentRow.Cells("costoServicio").Value.ToString)
    End Sub

    Private Sub btnUEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUEliminar.Click
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim resultado As Integer = MsgBox("Desea Eliminar este usuario? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            objManUsuario.eliminarUsuario(dgvListadoUsuario.CurrentRow.Cells("idU").Value.ToString)
            MsgBox("El usuario ha sido eliminado con éxito.")
            Me.dgvListadoUsuario.Rows.Clear()
            Dim hashUsuario As Hashtable
            hashUsuario = objManUsuario.obtenerUsuario()
            Me.CargarDGV(hashUsuario)
        Else
            MsgBox("El usuario no ha sido eliminado.")
        End If
    End Sub


    Private Sub btnBuscadorUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadorUsu.Click
        Me.dgvListadoUsuario.Rows.Clear()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.buscarUsuario(Me.txtBuscadorU.Text)
        Me.CargarDGV(hashUsuario)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUAgregar.Click
        Registro_usuario.Show()
    End Sub

    Private Sub txtBuscadorU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscadorU.KeyPress
        Me.dgvListadoUsuario.Rows.Clear()
        Dim objManUsuario As ManUsuario = New ManUsuario
        Dim hashUsuario As Hashtable
        hashUsuario = objManUsuario.buscarUsuario(Me.txtBuscadorU.Text)
        Me.CargarDGV(hashUsuario)
    End Sub
End Class