<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambiarPass
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCambiarPass))
        Me.lblRegistroUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.txtRNueva = New System.Windows.Forms.TextBox()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.txtActual = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNuevaPass = New System.Windows.Forms.Label()
        Me.lblActualPass = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistroUsuario
        '
        Me.lblRegistroUsuario.AutoSize = True
        Me.lblRegistroUsuario.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroUsuario.ForeColor = System.Drawing.Color.White
        Me.lblRegistroUsuario.Location = New System.Drawing.Point(45, 33)
        Me.lblRegistroUsuario.Name = "lblRegistroUsuario"
        Me.lblRegistroUsuario.Size = New System.Drawing.Size(260, 30)
        Me.lblRegistroUsuario.TabIndex = 69
        Me.lblRegistroUsuario.Text = "Cambiar contraseña"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCambiar)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 57)
        Me.Panel1.TabIndex = 67
        '
        'btnCambiar
        '
        Me.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiar.ForeColor = System.Drawing.Color.White
        Me.btnCambiar.Location = New System.Drawing.Point(50, 10)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(115, 35)
        Me.btnCambiar.TabIndex = 6
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(183, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'txtRNueva
        '
        Me.txtRNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtRNueva.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRNueva.ForeColor = System.Drawing.Color.White
        Me.txtRNueva.Location = New System.Drawing.Point(168, 171)
        Me.txtRNueva.Name = "txtRNueva"
        Me.txtRNueva.Size = New System.Drawing.Size(142, 27)
        Me.txtRNueva.TabIndex = 65
        '
        'txtNueva
        '
        Me.txtNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNueva.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNueva.ForeColor = System.Drawing.Color.White
        Me.txtNueva.Location = New System.Drawing.Point(168, 138)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.Size = New System.Drawing.Size(142, 27)
        Me.txtNueva.TabIndex = 64
        '
        'txtActual
        '
        Me.txtActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtActual.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActual.ForeColor = System.Drawing.Color.White
        Me.txtActual.Location = New System.Drawing.Point(168, 105)
        Me.txtActual.Name = "txtActual"
        Me.txtActual.Size = New System.Drawing.Size(142, 27)
        Me.txtActual.TabIndex = 61
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(39, 174)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(121, 21)
        Me.lblTelefono.TabIndex = 63
        Me.lblTelefono.Text = "Repita nueva:"
        '
        'lblNuevaPass
        '
        Me.lblNuevaPass.AutoSize = True
        Me.lblNuevaPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNuevaPass.ForeColor = System.Drawing.Color.White
        Me.lblNuevaPass.Location = New System.Drawing.Point(39, 141)
        Me.lblNuevaPass.Name = "lblNuevaPass"
        Me.lblNuevaPass.Size = New System.Drawing.Size(67, 21)
        Me.lblNuevaPass.TabIndex = 62
        Me.lblNuevaPass.Text = "Nueva:"
        '
        'lblActualPass
        '
        Me.lblActualPass.AutoSize = True
        Me.lblActualPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActualPass.ForeColor = System.Drawing.Color.White
        Me.lblActualPass.Location = New System.Drawing.Point(39, 108)
        Me.lblActualPass.Name = "lblActualPass"
        Me.lblActualPass.Size = New System.Drawing.Size(68, 21)
        Me.lblActualPass.TabIndex = 60
        Me.lblActualPass.Text = "Actual:"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblError.Image = Global.Ideas.My.Resources.Resources.cancel
        Me.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblError.Location = New System.Drawing.Point(48, 210)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 70
        '
        'FrmCambiarPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 306)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblRegistroUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRNueva)
        Me.Controls.Add(Me.txtNueva)
        Me.Controls.Add(Me.txtActual)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNuevaPass)
        Me.Controls.Add(Me.lblActualPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCambiarPass"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCambiarPass"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegistroUsuario As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtRNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtNueva As System.Windows.Forms.TextBox
    Friend WithEvents txtActual As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblNuevaPass As System.Windows.Forms.Label
    Friend WithEvents lblActualPass As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
End Class
