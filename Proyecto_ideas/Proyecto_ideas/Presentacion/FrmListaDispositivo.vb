Public Class FrmListaDispositivo
    Dim idCli As Integer

    Sub CargarDGV(ByVal colDispositivo As Hashtable)
        For Each DEntry As DictionaryEntry In colDispositivo
            Dim objD As Dispositivo = CType(DEntry.Value, Dispositivo)
            Dim bateria, sim, cargador, tapa, estuche, tmemoria As String
            Me.dgvListadoDispositivo.Rows.Add()
            If objD.Bateria = True Then
                bateria = "Si"
            Else
                bateria = "No"
            End If
            If objD.Sim = True Then
                sim = "Si"
            Else
                sim = "No"
            End If
            If objD.Cargador = True Then
                cargador = "Si"
            Else
                cargador = "No"
            End If
            If objD.Tapa = True Then
                tapa = "Si"
            Else
                tapa = "No"
            End If
            If objD.Estuche = True Then
                estuche = "Si"
            Else
                estuche = "No"
            End If
            If objD.Tmemoria = True Then
                tmemoria = "Si"
            Else
                tmemoria = "No"
            End If
            Dim cantFilas As Integer = dgvListadoDispositivo.Rows.Count - 1
            Me.dgvListadoDispositivo(0, cantFilas).Value = objD.IdDispositivo.ToString
            Me.dgvListadoDispositivo(1, cantFilas).Value = objD.Modelo
            Me.dgvListadoDispositivo(2, cantFilas).Value = bateria
            Me.dgvListadoDispositivo(3, cantFilas).Value = sim
            Me.dgvListadoDispositivo(4, cantFilas).Value = cargador
            Me.dgvListadoDispositivo(5, cantFilas).Value = tapa
            Me.dgvListadoDispositivo(6, cantFilas).Value = estuche
            Me.dgvListadoDispositivo(7, cantFilas).Value = tmemoria
            Me.dgvListadoDispositivo(8, cantFilas).Value = objD.Pin.ToString
            Me.dgvListadoDispositivo(9, cantFilas).Value = objD.IdC.ToString
        Next

    End Sub

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.dgvListadoDispositivo.Rows.Clear()
        Dim hashDispositivo As Hashtable
        hashDispositivo = ManDispositivo.getInstancia.obtenerDispositivo()
        Me.CargarDGV(hashDispositivo)

    End Sub

    Private Sub btnBuscadorD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscadorD.Click
        Me.dgvListadoDispositivo.Rows.Clear()
        Dim hashDispositivo As Hashtable
        hashDispositivo = ManDispositivo.getInstancia.buscarDispositivo(Me.txtBuscadorD.Text)
        Me.CargarDGV(hashDispositivo)

    End Sub

    Private Sub btnDAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAgregar.Click
        FrmRegistroDispositivo.Show()
        FrmRegistroDispositivo.obtenerIDcli(idCli)

    End Sub

    Private Sub btnDEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDEliminar.Click
        Dim resultado As Integer = MsgBox("¿Desea Eliminar este dispositivo? ", vbYesNo + vbQuestion)
        If resultado = vbYes Then
            ManDispositivo.getInstancia.eliminarDispositivo(dgvListadoDispositivo.CurrentRow.Cells("idD").Value.ToString)
            MsgBox("El dispositivo ha sido eliminado con éxito.")

            Me.dgvListadoDispositivo.Rows.Clear()
            Dim hashDispositivo As Hashtable
            hashDispositivo = ManDispositivo.getInstancia.obtenerDispositivo()
            Me.CargarDGV(hashDispositivo)
        Else
            MsgBox("El dispositivo no ha sido eliminado.")
        End If

    End Sub

    Private Sub btnDModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDModificar.Click
        Me.Hide()
        FrmModifDispositivo.Show()
        Dim bateria, sim, cargador, tapa, estuche, tmemoria As Boolean
        If dgvListadoDispositivo.CurrentRow.Cells("bateria").Value.ToString = "Si" Then
            bateria = True
        Else
            bateria = False
        End If
        If dgvListadoDispositivo.CurrentRow.Cells("sim").Value.ToString = "Si" Then
            sim = True
        Else
            sim = False
        End If
        If dgvListadoDispositivo.CurrentRow.Cells("cargador").Value.ToString = "Si" Then
            cargador = True
        Else
            cargador = False
        End If
        If dgvListadoDispositivo.CurrentRow.Cells("tapa").Value.ToString = "Si" Then
            tapa = True
        Else
            tapa = False
        End If
        If dgvListadoDispositivo.CurrentRow.Cells("estuche").Value.ToString = "Si" Then
            estuche = True
        Else
            estuche = False
        End If
        If dgvListadoDispositivo.CurrentRow.Cells("tmemoria").Value.ToString = "Si" Then
            tmemoria = True
        Else
            tmemoria = False
        End If

        FrmModifDispositivo.cargarDispositivo(dgvListadoDispositivo.CurrentRow.Cells("idD").Value.ToString, dgvListadoDispositivo.CurrentRow.Cells("modelo").Value.ToString, bateria, sim, cargador, tapa, estuche, tmemoria, dgvListadoDispositivo.CurrentRow.Cells("pin").Value.ToString, dgvListadoDispositivo.CurrentRow.Cells("idC").Value.ToString)

    End Sub

    Private Sub btnDSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDSeleccionar.Click
        FrmRegistroOrden.obtenerDispositivo(dgvListadoDispositivo.CurrentRow.Cells("idD").Value.ToString, dgvListadoDispositivo.CurrentRow.Cells("modelo").Value.ToString)
        Me.Close()

    End Sub

    Public Sub obtenerDisCli(ByVal idC As Integer)
        idCli = idC
        Me.dgvListadoDispositivo.Rows.Clear()
        Dim hashDispositivo As Hashtable
        hashDispositivo = ManDispositivo.getInstancia.buscarDispositivoCli(idC)
        Me.CargarDGV(hashDispositivo)

    End Sub

    Private Sub dgvListadoDispositivo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvListadoDispositivo.SelectionChanged
        btnDEliminar.Enabled = True
        btnDModificar.Enabled = True

    End Sub
End Class