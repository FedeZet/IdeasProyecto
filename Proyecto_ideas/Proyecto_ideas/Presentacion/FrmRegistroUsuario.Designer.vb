<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroUsuario))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblContrasenia = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContra = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnURegistrar = New System.Windows.Forms.Button()
        Me.btnUCancelar = New System.Windows.Forms.Button()
        Me.lblCostoServicio = New System.Windows.Forms.Label()
        Me.txtCostoServicio = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRegistroUsuario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(39, 100)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(70, 21)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblContrasenia
        '
        Me.lblContrasenia.AutoSize = True
        Me.lblContrasenia.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContrasenia.ForeColor = System.Drawing.Color.White
        Me.lblContrasenia.Location = New System.Drawing.Point(39, 133)
        Me.lblContrasenia.Name = "lblContrasenia"
        Me.lblContrasenia.Size = New System.Drawing.Size(107, 21)
        Me.lblContrasenia.TabIndex = 1
        Me.lblContrasenia.Text = "Contraseña:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(39, 166)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 21)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(39, 199)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 21)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Teléfono:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(168, 97)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(142, 27)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContra
        '
        Me.txtContra.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContra.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContra.ForeColor = System.Drawing.Color.White
        Me.txtContra.Location = New System.Drawing.Point(168, 130)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.Size = New System.Drawing.Size(142, 27)
        Me.txtContra.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(168, 163)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 27)
        Me.txtNombre.TabIndex = 3
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.White
        Me.txtTelefono.Location = New System.Drawing.Point(168, 196)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(142, 27)
        Me.txtTelefono.TabIndex = 4
        '
        'btnURegistrar
        '
        Me.btnURegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnURegistrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnURegistrar.ForeColor = System.Drawing.Color.White
        Me.btnURegistrar.Location = New System.Drawing.Point(53, 10)
        Me.btnURegistrar.Name = "btnURegistrar"
        Me.btnURegistrar.Size = New System.Drawing.Size(115, 35)
        Me.btnURegistrar.TabIndex = 6
        Me.btnURegistrar.Text = "Registrar"
        Me.btnURegistrar.UseVisualStyleBackColor = True
        '
        'btnUCancelar
        '
        Me.btnUCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnUCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUCancelar.ForeColor = System.Drawing.Color.White
        Me.btnUCancelar.Location = New System.Drawing.Point(186, 10)
        Me.btnUCancelar.Name = "btnUCancelar"
        Me.btnUCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnUCancelar.TabIndex = 7
        Me.btnUCancelar.Text = "Cancelar"
        Me.btnUCancelar.UseVisualStyleBackColor = True
        '
        'lblCostoServicio
        '
        Me.lblCostoServicio.AutoSize = True
        Me.lblCostoServicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostoServicio.ForeColor = System.Drawing.Color.White
        Me.lblCostoServicio.Location = New System.Drawing.Point(39, 232)
        Me.lblCostoServicio.Name = "lblCostoServicio"
        Me.lblCostoServicio.Size = New System.Drawing.Size(123, 21)
        Me.lblCostoServicio.TabIndex = 11
        Me.lblCostoServicio.Text = "Costo Servicio:"
        '
        'txtCostoServicio
        '
        Me.txtCostoServicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCostoServicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoServicio.ForeColor = System.Drawing.Color.White
        Me.txtCostoServicio.Location = New System.Drawing.Point(168, 229)
        Me.txtCostoServicio.Name = "txtCostoServicio"
        Me.txtCostoServicio.Size = New System.Drawing.Size(142, 27)
        Me.txtCostoServicio.TabIndex = 5
        Me.txtCostoServicio.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnURegistrar)
        Me.Panel1.Controls.Add(Me.btnUCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(354, 57)
        Me.Panel1.TabIndex = 6
        '
        'lblRegistroUsuario
        '
        Me.lblRegistroUsuario.AutoSize = True
        Me.lblRegistroUsuario.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroUsuario.ForeColor = System.Drawing.Color.White
        Me.lblRegistroUsuario.Location = New System.Drawing.Point(74, 28)
        Me.lblRegistroUsuario.Name = "lblRegistroUsuario"
        Me.lblRegistroUsuario.Size = New System.Drawing.Size(206, 30)
        Me.lblRegistroUsuario.TabIndex = 47
        Me.lblRegistroUsuario.Text = "Registrar usuario"
        '
        'FrmRegistroUsuario
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
        Me.Controls.Add(Me.txtContra)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblContrasenia)
        Me.Controls.Add(Me.lblUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroUsuario"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents lblContrasenia As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContra As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnURegistrar As System.Windows.Forms.Button
    Friend WithEvents btnUCancelar As System.Windows.Forms.Button
    Friend WithEvents lblCostoServicio As System.Windows.Forms.Label
    Friend WithEvents txtCostoServicio As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblRegistroUsuario As System.Windows.Forms.Label
End Class
