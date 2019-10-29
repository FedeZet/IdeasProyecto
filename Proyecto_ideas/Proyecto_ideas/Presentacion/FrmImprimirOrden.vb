Public Class FrmImprimirOrden
    Private Sub btnImprimir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        PrintForm1.PrinterSettings = PrintDialog1.PrinterSettings 'permite ajustar tamaño y copias
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintForm1.PrinterSettings.Copies = 2
            PrintForm1.PrinterSettings.Clone()
            PrintForm1.Print()
        End If
    End Sub

    Private Sub btnCancelarImp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarImp.Click
        Me.Hide()
        FrmListaOrden.Show()
    End Sub
End Class