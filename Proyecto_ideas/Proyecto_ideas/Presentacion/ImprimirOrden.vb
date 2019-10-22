Public Class ImprimirOrden

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings 'permite ajustar tamaño y copias
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintForm1.Print()
        End If
    End Sub

    Private Sub btnCancelarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarImp.Click
        Me.Hide()
        Historial_ordenes.Show()
    End Sub

    Private Sub ImprimirOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class