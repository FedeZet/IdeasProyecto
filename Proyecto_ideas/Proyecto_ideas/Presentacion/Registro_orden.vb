Public Class Registro_orden

    Private Sub Registro_orden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCrearOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCrearOrden.Click
        Dim objManDispositivo As ManDispositivo = New ManDispositivo
        Dim bateria, sim, cargador, tapa, estuche, memoria As Boolean
        If chbBateria.Checked = True Then
            bateria = True
        Else
            bateria = False
        End If
        If chbSIM.Checked = True Then
            sim = True
        Else
            sim = False
        End If
        If chbCargador.Checked = True Then
            cargador = True
        Else
            cargador = False
        End If
        If chbTapa.Checked = True Then
            tapa = True
        Else
            tapa = False
        End If
        If chbEstuche.Checked = True Then
            estuche = True
        Else
            estuche = False
        End If
        If chbMemoria.Checked = True Then
            memoria = True
        Else
            memoria = False
        End If


        objManDispositivo.crearDispositivo(Me.txtIDDis.Text, Me.txtModelo.Text, bateria, sim, cargador, tapa, estuche, memoria, Me.txtPIN.Text)
    End Sub
End Class