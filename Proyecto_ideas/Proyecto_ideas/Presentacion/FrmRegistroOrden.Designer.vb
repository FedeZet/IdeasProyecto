<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroOrden))
        Me.chbGarantia = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNOrden = New System.Windows.Forms.Label()
        Me.gboEstado = New System.Windows.Forms.GroupBox()
        Me.rdEntregado = New System.Windows.Forms.RadioButton()
        Me.rdReparado = New System.Windows.Forms.RadioButton()
        Me.rdEspera = New System.Windows.Forms.RadioButton()
        Me.rdPendiente = New System.Windows.Forms.RadioButton()
        Me.chbDolar = New System.Windows.Forms.CheckBox()
        Me.cbTecnico = New System.Windows.Forms.ComboBox()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.lblResolucion = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.lblTel = New System.Windows.Forms.Label()
        Me.lblTFecha = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtFalla = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCrearOrden = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.lblRegistroOrden = New System.Windows.Forms.Label()
        Me.btnDipositivo = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.gboEstado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbGarantia
        '
        Me.chbGarantia.AutoSize = True
        Me.chbGarantia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGarantia.ForeColor = System.Drawing.Color.White
        Me.chbGarantia.Location = New System.Drawing.Point(388, 470)
        Me.chbGarantia.Name = "chbGarantia"
        Me.chbGarantia.Size = New System.Drawing.Size(77, 20)
        Me.chbGarantia.TabIndex = 67
        Me.chbGarantia.Text = "Garantia"
        Me.chbGarantia.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(419, 102)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(71, 21)
        Me.lblFecha.TabIndex = 66
        Me.lblFecha.Text = "[Fecha]"
        '
        'lblNOrden
        '
        Me.lblNOrden.AutoSize = True
        Me.lblNOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblNOrden.ForeColor = System.Drawing.Color.White
        Me.lblNOrden.Location = New System.Drawing.Point(89, 102)
        Me.lblNOrden.Name = "lblNOrden"
        Me.lblNOrden.Size = New System.Drawing.Size(19, 21)
        Me.lblNOrden.TabIndex = 65
        Me.lblNOrden.Text = "0"
        '
        'gboEstado
        '
        Me.gboEstado.Controls.Add(Me.rdEntregado)
        Me.gboEstado.Controls.Add(Me.rdReparado)
        Me.gboEstado.Controls.Add(Me.rdEspera)
        Me.gboEstado.Controls.Add(Me.rdPendiente)
        Me.gboEstado.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboEstado.ForeColor = System.Drawing.Color.White
        Me.gboEstado.Location = New System.Drawing.Point(65, 401)
        Me.gboEstado.Name = "gboEstado"
        Me.gboEstado.Size = New System.Drawing.Size(139, 119)
        Me.gboEstado.TabIndex = 64
        Me.gboEstado.TabStop = False
        Me.gboEstado.Text = "Estado"
        '
        'rdEntregado
        '
        Me.rdEntregado.AutoSize = True
        Me.rdEntregado.Location = New System.Drawing.Point(6, 95)
        Me.rdEntregado.Name = "rdEntregado"
        Me.rdEntregado.Size = New System.Drawing.Size(83, 20)
        Me.rdEntregado.TabIndex = 3
        Me.rdEntregado.Text = "Entregado"
        Me.rdEntregado.UseVisualStyleBackColor = True
        '
        'rdReparado
        '
        Me.rdReparado.AutoSize = True
        Me.rdReparado.Location = New System.Drawing.Point(6, 69)
        Me.rdReparado.Name = "rdReparado"
        Me.rdReparado.Size = New System.Drawing.Size(82, 20)
        Me.rdReparado.TabIndex = 2
        Me.rdReparado.Text = "Reparado"
        Me.rdReparado.UseVisualStyleBackColor = True
        '
        'rdEspera
        '
        Me.rdEspera.AutoSize = True
        Me.rdEspera.Location = New System.Drawing.Point(6, 43)
        Me.rdEspera.Name = "rdEspera"
        Me.rdEspera.Size = New System.Drawing.Size(78, 20)
        Me.rdEspera.TabIndex = 1
        Me.rdEspera.Text = "En Espera"
        Me.rdEspera.UseVisualStyleBackColor = True
        '
        'rdPendiente
        '
        Me.rdPendiente.AutoSize = True
        Me.rdPendiente.Checked = True
        Me.rdPendiente.Location = New System.Drawing.Point(6, 17)
        Me.rdPendiente.Name = "rdPendiente"
        Me.rdPendiente.Size = New System.Drawing.Size(82, 20)
        Me.rdPendiente.TabIndex = 0
        Me.rdPendiente.TabStop = True
        Me.rdPendiente.Text = "Pendiente"
        Me.rdPendiente.UseVisualStyleBackColor = True
        '
        'chbDolar
        '
        Me.chbDolar.AutoSize = True
        Me.chbDolar.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbDolar.ForeColor = System.Drawing.Color.White
        Me.chbDolar.Location = New System.Drawing.Point(524, 446)
        Me.chbDolar.Name = "chbDolar"
        Me.chbDolar.Size = New System.Drawing.Size(55, 20)
        Me.chbDolar.TabIndex = 63
        Me.chbDolar.Text = "Dolar"
        Me.chbDolar.UseVisualStyleBackColor = True
        '
        'cbTecnico
        '
        Me.cbTecnico.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.cbTecnico.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTecnico.ForeColor = System.Drawing.Color.White
        Me.cbTecnico.FormattingEnabled = True
        Me.cbTecnico.Location = New System.Drawing.Point(400, 186)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(179, 24)
        Me.cbTecnico.TabIndex = 62
        '
        'lblTecnico
        '
        Me.lblTecnico.AutoSize = True
        Me.lblTecnico.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTecnico.ForeColor = System.Drawing.Color.White
        Me.lblTecnico.Location = New System.Drawing.Point(341, 189)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(53, 16)
        Me.lblTecnico.TabIndex = 60
        Me.lblTecnico.Text = "Técnico:"
        '
        'lblResolucion
        '
        Me.lblResolucion.AutoSize = True
        Me.lblResolucion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucion.ForeColor = System.Drawing.Color.White
        Me.lblResolucion.Location = New System.Drawing.Point(341, 234)
        Me.lblResolucion.Name = "lblResolucion"
        Me.lblResolucion.Size = New System.Drawing.Size(68, 16)
        Me.lblResolucion.TabIndex = 59
        Me.lblResolucion.Text = "Resolución:"
        '
        'txtResolucion
        '
        Me.txtResolucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtResolucion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResolucion.ForeColor = System.Drawing.Color.White
        Me.txtResolucion.Location = New System.Drawing.Point(331, 253)
        Me.txtResolucion.Multiline = True
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(244, 133)
        Me.txtResolucion.TabIndex = 58
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtImporte.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(388, 444)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(130, 21)
        Me.txtImporte.TabIndex = 56
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtTel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTel.ForeColor = System.Drawing.Color.White
        Me.txtTel.Location = New System.Drawing.Point(82, 189)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(187, 21)
        Me.txtTel.TabIndex = 55
        Me.txtTel.TabStop = False
        '
        'lblTel
        '
        Me.lblTel.AutoSize = True
        Me.lblTel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTel.ForeColor = System.Drawing.Color.White
        Me.lblTel.Location = New System.Drawing.Point(20, 192)
        Me.lblTel.Name = "lblTel"
        Me.lblTel.Size = New System.Drawing.Size(56, 16)
        Me.lblTel.TabIndex = 54
        Me.lblTel.Text = "Teléfono:"
        '
        'lblTFecha
        '
        Me.lblTFecha.AutoSize = True
        Me.lblTFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblTFecha.ForeColor = System.Drawing.Color.White
        Me.lblTFecha.Location = New System.Drawing.Point(340, 102)
        Me.lblTFecha.Name = "lblTFecha"
        Me.lblTFecha.Size = New System.Drawing.Size(63, 21)
        Me.lblTFecha.TabIndex = 53
        Me.lblTFecha.Text = "Fecha:"
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblOrden.ForeColor = System.Drawing.Color.White
        Me.lblOrden.Location = New System.Drawing.Point(19, 102)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(64, 21)
        Me.lblOrden.TabIndex = 52
        Me.lblOrden.Text = "Orden:"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.Color.White
        Me.lblDetalle.Location = New System.Drawing.Point(20, 234)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(53, 16)
        Me.lblDetalle.TabIndex = 51
        Me.lblDetalle.Text = "Detalles:"
        '
        'txtFalla
        '
        Me.txtFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFalla.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFalla.ForeColor = System.Drawing.Color.White
        Me.txtFalla.Location = New System.Drawing.Point(15, 253)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.Size = New System.Drawing.Size(244, 133)
        Me.txtFalla.TabIndex = 50
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtModelo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.White
        Me.txtModelo.Location = New System.Drawing.Point(400, 154)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(179, 21)
        Me.txtModelo.TabIndex = 49
        Me.txtModelo.TabStop = False
        '
        'txtNombreCli
        '
        Me.txtNombreCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtNombreCli.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCli.ForeColor = System.Drawing.Color.White
        Me.txtNombreCli.Location = New System.Drawing.Point(82, 154)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.ReadOnly = True
        Me.txtNombreCli.Size = New System.Drawing.Size(187, 21)
        Me.txtNombreCli.TabIndex = 48
        Me.txtNombreCli.TabStop = False
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(341, 157)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(53, 16)
        Me.lblModelo.TabIndex = 47
        Me.lblModelo.Text = "Modelo:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(20, 157)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(54, 16)
        Me.lblNombre.TabIndex = 46
        Me.lblNombre.Text = "Nombre:"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.Color.White
        Me.lblImporte.Location = New System.Drawing.Point(328, 447)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 16)
        Me.lblImporte.TabIndex = 45
        Me.lblImporte.Text = "Importe:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCrearOrden)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 542)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 57)
        Me.Panel1.TabIndex = 70
        '
        'btnCrearOrden
        '
        Me.btnCrearOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearOrden.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearOrden.ForeColor = System.Drawing.Color.White
        Me.btnCrearOrden.Location = New System.Drawing.Point(145, 10)
        Me.btnCrearOrden.Name = "btnCrearOrden"
        Me.btnCrearOrden.Size = New System.Drawing.Size(139, 35)
        Me.btnCrearOrden.TabIndex = 4
        Me.btnCrearOrden.Text = "Crear orden"
        Me.btnCrearOrden.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(357, 10)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'lblRegistroOrden
        '
        Me.lblRegistroOrden.AutoSize = True
        Me.lblRegistroOrden.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroOrden.ForeColor = System.Drawing.Color.White
        Me.lblRegistroOrden.Location = New System.Drawing.Point(202, 31)
        Me.lblRegistroOrden.Name = "lblRegistroOrden"
        Me.lblRegistroOrden.Size = New System.Drawing.Size(191, 30)
        Me.lblRegistroOrden.TabIndex = 78
        Me.lblRegistroOrden.Text = "Registrar orden"
        '
        'btnDipositivo
        '
        Me.btnDipositivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnDipositivo.FlatAppearance.BorderSize = 0
        Me.btnDipositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDipositivo.Image = Global.Ideas.My.Resources.Resources.add_phone
        Me.btnDipositivo.Location = New System.Drawing.Point(585, 155)
        Me.btnDipositivo.Name = "btnDipositivo"
        Me.btnDipositivo.Size = New System.Drawing.Size(18, 18)
        Me.btnDipositivo.TabIndex = 69
        Me.btnDipositivo.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Image = Global.Ideas.My.Resources.Resources.add_client
        Me.btnCliente.Location = New System.Drawing.Point(275, 155)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(18, 18)
        Me.btnCliente.TabIndex = 68
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'FrmRegistroOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(619, 599)
        Me.Controls.Add(Me.lblRegistroOrden)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDipositivo)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.chbGarantia)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNOrden)
        Me.Controls.Add(Me.gboEstado)
        Me.Controls.Add(Me.chbDolar)
        Me.Controls.Add(Me.cbTecnico)
        Me.Controls.Add(Me.lblTecnico)
        Me.Controls.Add(Me.lblResolucion)
        Me.Controls.Add(Me.txtResolucion)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.lblTel)
        Me.Controls.Add(Me.lblTFecha)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.txtFalla)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtNombreCli)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblImporte)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroOrden"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gboEstado.ResumeLayout(False)
        Me.gboEstado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDipositivo As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents chbGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblNOrden As System.Windows.Forms.Label
    Friend WithEvents gboEstado As System.Windows.Forms.GroupBox
    Friend WithEvents rdEntregado As System.Windows.Forms.RadioButton
    Friend WithEvents rdReparado As System.Windows.Forms.RadioButton
    Friend WithEvents rdEspera As System.Windows.Forms.RadioButton
    Friend WithEvents rdPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents chbDolar As System.Windows.Forms.CheckBox
    Friend WithEvents cbTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents lblTecnico As System.Windows.Forms.Label
    Friend WithEvents lblResolucion As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents lblTel As System.Windows.Forms.Label
    Friend WithEvents lblTFecha As System.Windows.Forms.Label
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents txtFalla As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCrearOrden As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents lblRegistroOrden As System.Windows.Forms.Label
End Class
