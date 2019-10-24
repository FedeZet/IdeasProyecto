<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMCtelefono = New System.Windows.Forms.TextBox()
        Me.txtMCnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.lblModCorreo = New System.Windows.Forms.Label()
        Me.txtModCEmail = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtMCtelefono
        '
        Me.txtMCtelefono.Location = New System.Drawing.Point(110, 76)
        Me.txtMCtelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMCtelefono.Name = "txtMCtelefono"
        Me.txtMCtelefono.Size = New System.Drawing.Size(71, 20)
        Me.txtMCtelefono.TabIndex = 11
        '
        'txtMCnombre
        '
        Me.txtMCnombre.Location = New System.Drawing.Point(110, 41)
        Me.txtMCnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMCnombre.Name = "txtMCnombre"
        Me.txtMCnombre.Size = New System.Drawing.Size(132, 20)
        Me.txtMCnombre.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Telefono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre Cliente:"
        '
        'btnCancelarC
        '
        Me.btnCancelarC.Location = New System.Drawing.Point(179, 131)
        Me.btnCancelarC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarC.Name = "btnCancelarC"
        Me.btnCancelarC.Size = New System.Drawing.Size(63, 19)
        Me.btnCancelarC.TabIndex = 7
        Me.btnCancelarC.Text = "Cancelar"
        Me.btnCancelarC.UseVisualStyleBackColor = True
        '
        'btnModificarC
        '
        Me.btnModificarC.Location = New System.Drawing.Point(45, 131)
        Me.btnModificarC.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(63, 19)
        Me.btnModificarC.TabIndex = 6
        Me.btnModificarC.Text = "Modificar"
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'lblModCorreo
        '
        Me.lblModCorreo.AutoSize = True
        Me.lblModCorreo.Location = New System.Drawing.Point(56, 107)
        Me.lblModCorreo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblModCorreo.Name = "lblModCorreo"
        Me.lblModCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblModCorreo.TabIndex = 12
        Me.lblModCorreo.Text = "Correo:"
        '
        'txtModCEmail
        '
        Me.txtModCEmail.Location = New System.Drawing.Point(110, 107)
        Me.txtModCEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModCEmail.Name = "txtModCEmail"
        Me.txtModCEmail.Size = New System.Drawing.Size(132, 20)
        Me.txtModCEmail.TabIndex = 13
        '
        'modificadorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.txtModCEmail)
        Me.Controls.Add(Me.lblModCorreo)
        Me.Controls.Add(Me.txtMCtelefono)
        Me.Controls.Add(Me.txtMCnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarC)
        Me.Controls.Add(Me.btnModificarC)
        Me.Name = "modificadorCliente"
        Me.Text = "modificadorCliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMCtelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMCnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarC As System.Windows.Forms.Button
    Friend WithEvents btnModificarC As System.Windows.Forms.Button
    Friend WithEvents lblModCorreo As System.Windows.Forms.Label
    Friend WithEvents txtModCEmail As System.Windows.Forms.TextBox
End Class
