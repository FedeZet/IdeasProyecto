Public Class modificadorDispositivo

    Dim idDispositivo

    Public Function cargarDispositivo(ByVal Id As Integer, ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer, ByVal idC As Integer)
        idDispositivo = Id
        txtModelo.Text = modelo
        If bateria = True Then
            chbBateria.Checked = True
        End If
        If sim = True Then
            chbSIM.Checked = True
        End If
        If cargador = True Then
            chbCargador.Checked = True
        End If
        If tapa = True Then
            chbTapa.Checked = True
        End If
        If estuche = True Then
            chbEstuche.Checked = True
        End If
        If tmemoria = True Then
            chbMemoria.Checked = True
        End If
        txtPIN.Text = pin
        txtIDCli.Text = idC

        Return True
    End Function

    Private Sub btnCancelarD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarD.Click
        lista_dispositivos.Show()
        Me.Close()
    End Sub

    Private Sub btnModificarD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarD.Click
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


        Dim objManDispositivo As ManDispositivo = New ManDispositivo
        objManDispositivo.modificarDispositivo(idDispositivo, txtModelo.Text, bateria, sim, cargador, tapa, estuche, memoria, txtPIN.Text, txtIDCli.Text)
    End Sub

    Private Sub modificadorDispositivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class