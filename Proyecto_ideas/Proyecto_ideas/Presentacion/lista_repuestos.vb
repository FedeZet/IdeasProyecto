Public Class lista_repuestos

    Private Sub btnRAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRAgregar.Click
        'Registro_orden.Show()
        'Me.Hide()
    End Sub

    Private Sub btnVolverOrdenesLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolverOrdenesLista.Click
        Menu_Inicio.Show()
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        Dim hashRepuesto As Hashtable
        hashRepuesto = objManRepuesto.obtenerRepuesto()
        Me.CargarDGV(hashRepuesto)

    End Sub

    Sub CargarDGV(ByVal colRepuesto As Hashtable)
        For Each DEntry As DictionaryEntry In colRepuesto
            Dim objR As Repuesto = CType(DEntry.Value, Repuesto)
            Me.dgvListadoRepuesto.Rows.Add()
            Dim cantFilas As Integer = dgvListadoRepuesto.Rows.Count - 1
            Me.dgvListadoRepuesto(0, cantFilas).Value = objR.IdRepuesto.ToString
            Me.dgvListadoRepuesto(1, cantFilas).Value = objR.Nombre
            Me.dgvListadoRepuesto(2, cantFilas).Value = objR.Cantidad.ToString

        Next
    End Sub

    Private Sub pbRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbRefresh.Click
        Me.dgvListadoRepuesto.Rows.Clear()
        Dim objManRepuesto As ManRepuesto = New ManRepuesto
        Dim hashRepuesto As Hashtable
        hashRepuesto = objManRepuesto.obtenerRepuesto()
        Me.CargarDGV(hashRepuesto)
    End Sub
End Class