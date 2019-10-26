<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroCliente))
        Me.lblRegistroCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCRegistrar = New System.Windows.Forms.Button()
        Me.btnCCancelar = New System.Windows.Forms.Button()
        Me.txtCMail = New System.Windows.Forms.TextBox()
        Me.txtCNombre = New System.Windows.Forms.TextBox()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblMail = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCTelefono = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistroCliente
        '
        Me.lblRegistroCliente.AutoSize = True
        Me.lblRegistroCliente.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroCliente.ForeColor = System.Drawing.Color.White
        Me.lblRegistroCliente.Location = New System.Drawing.Point(77, 32)
        Me.lblRegistroCliente.Name = "lblRegistroCliente"
        Me.lblRegistroCliente.Size = New System.Drawing.Size(204, 30)
        Me.lblRegistroCliente.TabIndex = 77
        Me.lblRegistroCliente.Text = "Registrar cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCRegistrar)
        Me.Panel1.Controls.Add(Me.btnCCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 57)
        Me.Panel1.TabIndex = 4
        '
        'btnCRegistrar
        '
        Me.btnCRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCRegistrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnCRegistrar.Location = New System.Drawing.Point(52, 10)
        Me.btnCRegistrar.Name = "btnCRegistrar"
        Me.btnCRegistrar.Size = New System.Drawing.Size(115, 35)
        Me.btnCRegistrar.TabIndex = 4
        Me.btnCRegistrar.Text = "Registrar"
        Me.btnCRegistrar.UseVisualStyleBackColor = True
        '
        'btnCCancelar
        '
        Me.btnCCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCCancelar.Location = New System.Drawing.Point(185, 10)
        Me.btnCCancelar.Name = "btnCCancelar"
        Me.btnCCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCCancelar.TabIndex = 5
        Me.btnCCancelar.Text = "Cancelar"
        Me.btnCCancelar.UseVisualStyleBackColor = True
        '
        'txtCMail
        '
        Me.txtCMail.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCMail.ForeColor = System.Drawing.Color.White
        Me.txtCMail.Location = New System.Drawing.Point(114, 170)
        Me.txtCMail.Name = "txtCMail"
        Me.txtCMail.Size = New System.Drawing.Size(215, 27)
        Me.txtCMail.TabIndex = 3
        '
        'txtCNombre
        '
        Me.txtCNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCNombre.ForeColor = System.Drawing.Color.White
        Me.txtCNombre.Location = New System.Drawing.Point(114, 104)
        Me.txtCNombre.Name = "txtCNombre"
        Me.txtCNombre.Size = New System.Drawing.Size(215, 27)
        Me.txtCNombre.TabIndex = 1
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.White
        Me.lblTelefono.Location = New System.Drawing.Point(28, 139)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(80, 21)
        Me.lblTelefono.TabIndex = 76
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblMail
        '
        Me.lblMail.AutoSize = True
        Me.lblMail.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMail.ForeColor = System.Drawing.Color.White
        Me.lblMail.Location = New System.Drawing.Point(28, 173)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(46, 21)
        Me.lblMail.TabIndex = 75
        Me.lblMail.Text = "Mail:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(28, 107)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 21)
        Me.lblNombre.TabIndex = 74
        Me.lblNombre.Text = "Nombre:"
        '
        'txtCTelefono
        '
        Me.txtCTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtCTelefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTelefono.ForeColor = System.Drawing.Color.White
        Me.txtCTelefono.Location = New System.Drawing.Point(114, 136)
        Me.txtCTelefono.Name = "txtCTelefono"
        Me.txtCTelefono.Size = New System.Drawing.Size(215, 27)
        Me.txtCTelefono.TabIndex = 2
        '
        'FrmRegistroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 300)
        Me.Controls.Add(Me.txtCTelefono)
        Me.Controls.Add(Me.lblRegistroCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtCMail)
        Me.Controls.Add(Me.txtCNombre)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.lblNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroCliente"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegistroCliente As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnCCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCMail As System.Windows.Forms.TextBox
    Friend WithEvents txtCNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtCTelefono As System.Windows.Forms.TextBox
End Class
