Public Class FrmInicio

    Private Sub btnOrden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrden.Click
        FrmListaOrden.Show()
        Me.Hide()
    End Sub

    Private Sub btnRepuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepuesto.Click
        FrmListaRepuesto.Show()
        Me.Hide()
    End Sub

    Private Sub btnUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsuario.Click
        FrmListaUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub btnProductividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductividad.Click

    End Sub

    Public Sub New()
        InitializeComponent()
        timerHoraFecha.Enabled = True

        If UsuarioActivo.user <> "admin" Then
            btnUsuario.Visible = False
            btnProductividad.Visible = False
        End If

        lblNombre.Text = UsuarioActivo.nombre
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub timerHoraFecha_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerHoraFecha.Tick
        lblHoraFecha.Text = DateTime.Now.ToShortTimeString() + " - " + DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        Application.Restart()
    End Sub

    Private Sub btnCambiarPass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarPass.Click
        FrmCambiarPass.Show()

    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        FrmAbout.Show()
    End Sub
End Class