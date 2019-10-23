Public Class Prueba

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim fecha1 As Date = Date.Now.ToString("#dd-MM-yyyy#")
        Dim fecha As DateTime = DateTime.Now.ToString("dd-MM-yyyy")

        MsgBox(fecha)
    End Sub
End Class