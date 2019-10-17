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

        Next
    End Sub

    Private Sub btnVolverOrdenesLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenesLista.Click
        Menu_Inicio.Show()
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
        objManCliente.eliminarCliente(dgvListadoCliente.CurrentRow.Cells("idC").Value.ToString)

    End Sub

    
    Private Sub btnCModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCModificar.Click

        Me.Hide()
        modificadorCliente.Show()
        modificadorCliente.cargarCliente(dgvListadoCliente.CurrentRow.Cells("idC").Value.ToString, dgvListadoCliente.CurrentRow.Cells("nombre").Value.ToString, dgvListadoCliente.CurrentRow.Cells("telefono").Value.ToString)

    End Sub
End Class