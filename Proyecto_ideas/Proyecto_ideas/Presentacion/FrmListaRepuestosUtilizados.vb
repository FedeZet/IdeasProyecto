Public Class FrmListaRepuestosUtilizados

    Dim idOrden As Integer
    Dim cambios As Boolean = False

    Public Sub New()
        InitializeComponent()
        Dim hashRepuesto As Hashtable
        hashRepuesto = ManRepuesto.getInstancia.obtenerRepuesto()
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
            Me.dgvListadoRepuesto(3, cantFilas).Value = objR.costo.ToString
        Next
    End Sub

    Sub CargarDGV2(ByVal colUtiliza As Hashtable)
        For Each DEntry As DictionaryEntry In colUtiliza
            Dim objU As Utiliza = CType(DEntry.Value, Utiliza)
            Dim nombreR As String = ""
            Dim costoU As Integer
            Dim costoT As Integer
            Me.dgvListadoRepuestosUtilizados.Rows.Add()
            Dim cantFilas As Integer = dgvListadoRepuestosUtilizados.Rows.Count - 1
            Me.dgvListadoRepuestosUtilizados(0, cantFilas).Value = objU.idR.ToString

            For Each Row As DataGridViewRow In dgvListadoRepuesto.Rows

                If Row.Cells("idR").Value = objU.idR Then
                    nombreR = Row.Cells("nombre").Value.ToString

                End If

            Next

            Me.dgvListadoRepuestosUtilizados(1, cantFilas).Value = nombreR
            Me.dgvListadoRepuestosUtilizados(2, cantFilas).Value = objU.Cuantos.ToString
            For Each Row As DataGridViewRow In dgvListadoRepuesto.Rows

                If Row.Cells("idR").Value = objU.idR Then
                    costoU = Row.Cells("costoRep").Value
                    costoT = objU.Cuantos * costoU

                End If

            Next
            Me.dgvListadoRepuestosUtilizados(3, cantFilas).Value = costoT.ToString
        Next
    End Sub


    Public Sub obtenerOrden(ByVal idO As Integer)

        idOrden = idO
        Me.dgvListadoRepuestosUtilizados.Rows.Clear()
        Dim hashUtiliza As Hashtable
        hashUtiliza = ManUtiliza.getInstancia.obtenerRepuesto(idOrden)
        Me.CargarDGV2(hashUtiliza)

    End Sub

    Private Sub btnRAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRAgregar.Click
        cambios = True
        Dim row As DataGridViewRow = dgvListadoRepuesto.CurrentRow

        Dim existe As Boolean
        Dim cancelar As Boolean
        Dim seguirAccion As Boolean
        Dim cantidad As String
        Dim cantidadUtilizada As Integer = 1
        Dim cantidadInicial As Integer = dgvListadoRepuesto.CurrentRow.Cells("cantidad").Value

        While cantidadUtilizada > cantidadInicial Or cantidadUtilizada = 0 Or seguirAccion = False
            Do
                cantidad = InputBox("Ingrese la cantidad de repuestos: ")
                If String.IsNullOrEmpty(cantidad) = True Then
                    cancelar = True
                Else
                    cancelar = False
                End If
            Loop Until IsNumeric(cantidad) = True Or cancelar = True
            If cancelar = True Then

                seguirAccion = True
            Else
                cantidadUtilizada = cantidad
                seguirAccion = True
            End If


        End While
        Dim id As String = row.Cells("idR").Value

        If seguirAccion = True And cancelar = False Then
            
            Dim restantes As Integer = cantidadInicial - cantidadUtilizada
            dgvListadoRepuesto.CurrentRow.Cells("cantidad").Value = restantes

            For Each row2 As DataGridViewRow In dgvListadoRepuestosUtilizados.Rows
                If row2.Cells("idRU").Value = id Then
                    row2.Cells("cantidadU").Value += cantidadUtilizada
                    dgvListadoRepuesto.CurrentRow.Cells("cantidad").Value = restantes
                    existe = True
                Else

                End If
            Next
            If existe = False Then
                Dim nombre As String = row.Cells("nombre").Value
                Dim costoRep As String = row.Cells("costoRep").Value
                dgvListadoRepuestosUtilizados.Rows.Add(id, nombre, cantidadUtilizada, costoRep)
            End If
        Else

            'Dim cantidad As String = row.Cells("cantidad").Value
        End If
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRGuardar.Click

        ManUtiliza.getInstancia.eliminarUtiliza(idOrden)

        For Each row As DataGridViewRow In dgvListadoRepuestosUtilizados.Rows
            Dim idR As Integer = row.Cells("idRU").Value
            Dim cuantos As Integer = row.Cells("cantidadU").Value



            ManUtiliza.getInstancia.agregarRepuestosUtilizados(idOrden, idR, cuantos)

        Next

        For Each row As DataGridViewRow In dgvListadoRepuesto.Rows
            Dim idR As Integer = row.Cells("idR").Value
            Dim cuantos As Integer = row.Cells("cantidad").Value

            ManRepuesto.getInstancia.modificarCantidadRepuesto(idR, cuantos)

        Next

        MsgBox("Se guardaron los repuestos utilizados correctamente.")

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        If cambios = True Then
            Dim resultado As Integer = MsgBox("Desea Guardar los cambios efectuados? ", vbYesNo + vbQuestion)
            If resultado = vbYes Then
                btnRGuardar.PerformClick()
                Me.Close()
            Else
                MsgBox("No se guardaron los cambios.")
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub btnREliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnREliminar.Click
        cambios = True

        Dim resultado As Integer = MsgBox("Desea Eliminar este repuesto utilizado? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            Dim cantidad As Integer = dgvListadoRepuestosUtilizados.CurrentRow.Cells("CantidadU").Value

            For Each Row As DataGridViewRow In dgvListadoRepuesto.Rows

                If Row.Cells("idR").Value = dgvListadoRepuestosUtilizados.CurrentRow.Cells("idRU").Value Then
                    Row.Cells("cantidad").Value += cantidad

                End If

            Next

            ManUtiliza.getInstancia.eliminarRepuestoUtilizado(idOrden, dgvListadoRepuestosUtilizados.CurrentRow.Cells("idRU").Value.ToString, dgvListadoRepuestosUtilizados.CurrentRow.Cells("costoRepU").Value.ToString)
            MsgBox("El repuesto utilizado ha sido eliminado con éxito.")
            Me.dgvListadoRepuestosUtilizados.Rows.Clear()
            Dim hashUtiliza As Hashtable
            hashUtiliza = ManUtiliza.getInstancia.obtenerRepuesto(idOrden)
            Me.CargarDGV2(hashUtiliza)
        Else
            MsgBox("El repuesto no ha sido eliminado.")
        End If
    End Sub
End Class