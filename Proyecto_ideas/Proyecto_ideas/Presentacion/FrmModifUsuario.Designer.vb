<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModifUsuario))
        Me.lblRegistroUsuario = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUModificar = New System.Windows.Forms.Button()
        Me.btnUCancelar = New System.Windows.Forms.Button()
        Me.txtCostoServicio = New System.Windows.Forms.TextBox()
        Me.lblCostoServicio = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.btnURegistrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistroUsuario
        '
        Me.lblRegistroUsuario.AutoSize = True
        Me.lblRegistroUsuario.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroUsuario.ForeColor = System.Drawing.Color.White
        Me.lblRegistroUsuario.Location = New System.Drawing.Point(69, 24)
        Me.lblRegistroUsuario.Name = "lblRegistroUsuario"
        Me.lblRegistroUsuario.Size = New System.Drawing.Size(219, 30)
        Me.lblRegistroUsuario.TabIndex = 59
        Me.lblRegistroUsuario.Text = "Modificar usuario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUModificar)
        Me.Panel1.Controls.Add(Me.btnUCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 57)
        Me.Panel1.TabIndex = 57
        '
        'btnUModificar
        '
        Me.btnUModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUModificar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUModificar.ForeColor = System.Drawing.Color.White
        Me.btnUModificar.Location = New System.Drawing.Point(50, 10)
        Me.btnUModificar.Name = "btnUModificar"
        Me.btnUModificar.Size = New System.Drawing.Size(115, 35)
        Me.btnUModificar.TabIndex = 6
        Me.btnUModificar.Text = "Modificar"
        Me.btnUModificar.UseVisualStyleBackColor = True
        '
        'btnUCancelar
        '
        Me.btnUCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUCancelar.ForeColor = System.Drawing.Color.White
        Me.btnUCancelar.Location = New System.Drawing.Point(183, 10)
        Me.btnUCancelar.Name = "btnUCancelar"
        Me.btnUCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnUCancelar.TabIndex = 7
        Me.btnUCancelar.Text = "Cancelar"
        Me.btnUCancelar.UseVisualStyleBackColor = True
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoServicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoServicio.ForeColor = System.Drawing.Color.White
        Me.txtCostoServicio.Location = New System.Drawing.Point(171, 202)
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(142, 27)
        Me.txtCostoServicio.TabIndex = 56
        Me.txtCostoServicio.Text = "0"
        '
        'lblCostoServicio
        '
        Me.lblCostoServicio.AutoSize = True
        Me.lblCostoServicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoServicio.ForeColor = System.Drawing.Color.White
        Me.lblCostoServicio.Location = New System.Drawing.Point(42, 205)
        Me.lblCostoServicio.Name = "lblCostoServicio"
        Me.lblCostoServicio.Size = New System.Drawing.Size(123, 21)
        Me.lblCostoServicio.TabIndex = 58
        Me.lblCostoServicio.Text = "Costo Servicio:"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(171, 169)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(142, 27)
        Me.txtTelefono.TabIndex = 55
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(171, 136)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 27)
        Me.txtNombre.TabIndex = 54
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(171, 103)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(142, 27)
        Me.txtUsuario.TabIndex = 49
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(42, 172)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 21)
        Me.lblTelefono.TabIndex = 53
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(42, 139)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 21)
        Me.lblNombre.TabIndex = 52
        Me.lblNombre.Text = "Nombre:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(42, 106)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(70, 21)
        Me.lblUsuario.TabIndex = 48
        Me.lblUsuario.Text = "Usuario:"
        '
        'btnURegistrar
        '
        Me.btnURegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnURegistrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnURegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnURegistrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnURegistrar.ForeColor = System.Drawing.Color.White
        Me.btnURegistrar.Location = New System.Drawing.Point(38, 10)
        Me.btnURegistrar.Name = "btnURegistrar"
        Me.btnURegistrar.Size = New System.Drawing.Size(115, 35)
        Me.btnURegistrar.TabIndex = 6
        Me.btnURegistrar.Text = "Registrar"
        Me.btnURegistrar.UseVisualStyleBackColor = False
        '
        'FrmModifUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 350)
        Me.Controls.Add(Me.lblRegistroUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCostoServicio)
        Me.Controls.Add(Me.lblCostoServicio)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModifUsuario"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegistroUsuario As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUModificar As System.Windows.Forms.Button
    Friend WithEvents btnUCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCostoServicio As System.Windows.Forms.TextBox
    Friend WithEvents lblCostoServicio As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents btnURegistrar As System.Windows.Forms.Button
End Class
