Public Class FrmRegistroDispositivo



    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        'se crea el dispositivo
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


        ManDispositivo.getInstancia.crearDispositivo(Me.txtModelo.Text, bateria, sim, cargador, tapa, estuche, memoria, Me.txtPIN.Text, Me.txtIDCli.Text)
        MsgBox("El dispositivo se ha creado exitosamente.")
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        FrmListaDispositivo.Show()
        Me.Close()
    End Sub

    Private Sub Registro_dispositivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPIN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIN.KeyPress
        Numeros(e)
    End Sub

    Public Sub obtenerIDcli(ByVal id As Integer)
        txtIDCli.Text = id.ToString
    End Sub
End Class