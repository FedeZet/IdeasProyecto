Public Class FrmAbout
    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()

    End Sub

    Private Sub lilCorreo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lilCorreo.LinkClicked
        Try
            Dim soporte As New System.Text.StringBuilder()
            soporte.Append("mailto:atomcore@gmail.com")
            System.Diagnostics.Process.Start(soporte.ToString())
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Close()
        End Try

    End Sub
End Class