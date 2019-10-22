Public Class lista_clientes


    Public Sub New()
        InitializeComponent()
        Dim objManCliente As ManCliente = New ManCliente
        Dim hashCliente As Hashtable
        hashCliente = objManCliente.obtenerCliente()
        Me.CargarDGV(hashCliente)

    End Sub

    Sub CargarDGV(ByVal colCliente As Hashtable)
        For Each DEntry As DictionaryEntry In colCliente
            Dim objR As Cliente = CType(DEntry.Value, Cliente)
            Me.dgvListadoCliente.Rows.Add()
            Dim cantFilas As Integer = dgvListadoCliente.Rows.Count - 1
            Me.dgvListadoCliente(0, cantFilas).Value = objR.IdCliente.ToString
            Me.dgvListadoCliente(1, cantFilas).Value = objR.Nombre
            Me.dgvListadoCliente(2, cantFilas).Value = objR.Telefono.ToString
            Me.dgvListadoCliente(3, cantFilas).Value = objR.correo.ToString
        Next
    End Sub

    Private Sub btnCVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCVolver.Click
        Me.Close()

    End Sub

    Private Sub btnBuscadorCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadorCli.Click
        Me.dgvListadoCliente.Rows.Clear()
        Dim objManCliente As ManCliente = New ManCliente
        Dim hashCliente As Hashtable
        hashCliente = objManCliente.buscarCliente(Me.txtBuscadorCli.Text)
        Me.CargarDGV(hashCliente)

    End Sub

    Private Sub btnCAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCAgregar.Click
        Registro_cliente.Show()

    End Sub

    Private Sub btnCEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCEliminar.Click
        Dim objManCliente As ManCliente = New ManCliente
        Dim resultado As Integer = MsgBox("Desea Eliminar este cliente? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            objManCliente.eliminarCliente(dgvListadoCliente.CurrentRow.Cells("idC").Value.ToString)
            MsgBox("El cliente ha sido eliminado con éxito.")
        Else
            MsgBox("El cliente no ha sido eliminado.")
        End If
    End Sub


    Private Sub btnCModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCModificar.Click
        Me.Hide()
        modificadorCliente.Show()
        modificadorCliente.cargarCliente(dgvListadoCliente.CurrentRow.Cells("idC").Value.ToString, dgvListadoCliente.CurrentRow.Cells("nombre").Value.ToString, dgvListadoCliente.CurrentRow.Cells("telefono").Value.ToString)

    End Sub

    Private Sub btnCSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCSeleccionar.Click
        Registro_orden.obtenerCliente(dgvListadoCliente.CurrentRow.Cells("idC").Value.ToString, dgvListadoCliente.CurrentRow.Cells("nombre").Value.ToString, dgvListadoCliente.CurrentRow.Cells("telefono").Value.ToString)
        Me.Close()

    End Sub


    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.dgvListadoCliente.Rows.Clear()
        Dim objManCliente As ManCliente = New ManCliente
        Dim hashCliente As Hashtable
        hashCliente = objManCliente.obtenerCliente()
        Me.CargarDGV(hashCliente)

    End Sub

    'Private Sub dgvListadoCliente_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvListadoCliente.RowHeaderMouseClick
    '    btnCEliminar.Enabled = True
    '    btnCModificar.Enabled = True
    'End Sub
End Class