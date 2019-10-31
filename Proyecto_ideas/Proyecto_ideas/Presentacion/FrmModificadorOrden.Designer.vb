<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificadorOrden
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
        Me.lblRegistroOrden = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModificarOrden = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chbGarantia = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblNOrden = New System.Windows.Forms.Label()
        Me.gboEstado = New System.Windows.Forms.GroupBox()
        Me.rdEntregado = New System.Windows.Forms.RadioButton()
        Me.rdReparado = New System.Windows.Forms.RadioButton()
        Me.rdEspera = New System.Windows.Forms.RadioButton()
        Me.rdPendiente = New System.Windows.Forms.RadioButton()
        Me.chbDolar = New System.Windows.Forms.CheckBox()
        Me.lblResolucion = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.lblTFecha = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.txtFalla = New System.Windows.Forms.TextBox()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gboEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblRegistroOrden
        '
        Me.lblRegistroOrden.AutoSize = True
        Me.lblRegistroOrden.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroOrden.ForeColor = System.Drawing.Color.White
        Me.lblRegistroOrden.Location = New System.Drawing.Point(194, 7)
        Me.lblRegistroOrden.Name = "lblRegistroOrden"
        Me.lblRegistroOrden.Size = New System.Drawing.Size(204, 30)
        Me.lblRegistroOrden.TabIndex = 103
        Me.lblRegistroOrden.Text = "Modificar orden"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnModificarOrden)
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 445)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(600, 57)
        Me.Panel1.TabIndex = 102
        '
        'btnModificarOrden
        '
        Me.btnModificarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarOrden.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarOrden.ForeColor = System.Drawing.Color.White
        Me.btnModificarOrden.Location = New System.Drawing.Point(85, 10)
        Me.btnModificarOrden.Name = "btnModificarOrden"
        Me.btnModificarOrden.Size = New System.Drawing.Size(199, 35)
        Me.btnModificarOrden.TabIndex = 4
        Me.btnModificarOrden.Text = "Modificar orden"
        Me.btnModificarOrden.UseVisualStyleBackColor = True
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
        'chbGarantia
        '
        Me.chbGarantia.AutoSize = True
        Me.chbGarantia.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbGarantia.ForeColor = System.Drawing.Color.White
        Me.chbGarantia.Location = New System.Drawing.Point(385, 389)
        Me.chbGarantia.Name = "chbGarantia"
        Me.chbGarantia.Size = New System.Drawing.Size(77, 20)
        Me.chbGarantia.TabIndex = 99
        Me.chbGarantia.Text = "Garantia"
        Me.chbGarantia.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblFecha.ForeColor = System.Drawing.Color.White
        Me.lblFecha.Location = New System.Drawing.Point(411, 78)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(71, 21)
        Me.lblFecha.TabIndex = 98
        Me.lblFecha.Text = "[Fecha]"
        '
        'lblNOrden
        '
        Me.lblNOrden.AutoSize = True
        Me.lblNOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblNOrden.ForeColor = System.Drawing.Color.White
        Me.lblNOrden.Location = New System.Drawing.Point(81, 78)
        Me.lblNOrden.Name = "lblNOrden"
        Me.lblNOrden.Size = New System.Drawing.Size(19, 21)
        Me.lblNOrden.TabIndex = 97
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
        Me.gboEstado.Location = New System.Drawing.Point(62, 320)
        Me.gboEstado.Name = "gboEstado"
        Me.gboEstado.Size = New System.Drawing.Size(139, 119)
        Me.gboEstado.TabIndex = 96
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
        Me.chbDolar.Location = New System.Drawing.Point(521, 365)
        Me.chbDolar.Name = "chbDolar"
        Me.chbDolar.Size = New System.Drawing.Size(55, 20)
        Me.chbDolar.TabIndex = 95
        Me.chbDolar.Text = "Dolar"
        Me.chbDolar.UseVisualStyleBackColor = True
        '
        'lblResolucion
        '
        Me.lblResolucion.AutoSize = True
        Me.lblResolucion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResolucion.ForeColor = System.Drawing.Color.White
        Me.lblResolucion.Location = New System.Drawing.Point(338, 153)
        Me.lblResolucion.Name = "lblResolucion"
        Me.lblResolucion.Size = New System.Drawing.Size(68, 16)
        Me.lblResolucion.TabIndex = 92
        Me.lblResolucion.Text = "Resolución:"
        '
        'txtResolucion
        '
        Me.txtResolucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtResolucion.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResolucion.ForeColor = System.Drawing.Color.White
        Me.txtResolucion.Location = New System.Drawing.Point(328, 172)
        Me.txtResolucion.Multiline = True
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(244, 133)
        Me.txtResolucion.TabIndex = 91
        '
        'txtImporte
        '
        Me.txtImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtImporte.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.ForeColor = System.Drawing.Color.White
        Me.txtImporte.Location = New System.Drawing.Point(385, 363)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(130, 21)
        Me.txtImporte.TabIndex = 90
        '
        'lblTFecha
        '
        Me.lblTFecha.AutoSize = True
        Me.lblTFecha.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblTFecha.ForeColor = System.Drawing.Color.White
        Me.lblTFecha.Location = New System.Drawing.Point(332, 78)
        Me.lblTFecha.Name = "lblTFecha"
        Me.lblTFecha.Size = New System.Drawing.Size(63, 21)
        Me.lblTFecha.TabIndex = 87
        Me.lblTFecha.Text = "Fecha:"
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lblOrden.ForeColor = System.Drawing.Color.White
        Me.lblOrden.Location = New System.Drawing.Point(11, 78)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(64, 21)
        Me.lblOrden.TabIndex = 86
        Me.lblOrden.Text = "Orden:"
        '
        'lblDetalle
        '
        Me.lblDetalle.AutoSize = True
        Me.lblDetalle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetalle.ForeColor = System.Drawing.Color.White
        Me.lblDetalle.Location = New System.Drawing.Point(17, 153)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(53, 16)
        Me.lblDetalle.TabIndex = 85
        Me.lblDetalle.Text = "Detalles:"
        '
        'txtFalla
        '
        Me.txtFalla.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtFalla.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFalla.ForeColor = System.Drawing.Color.White
        Me.txtFalla.Location = New System.Drawing.Point(12, 172)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.Size = New System.Drawing.Size(244, 133)
        Me.txtFalla.TabIndex = 84
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.Color.White
        Me.lblImporte.Location = New System.Drawing.Point(325, 366)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(53, 16)
        Me.lblImporte.TabIndex = 79
        Me.lblImporte.Text = "Importe:"
        '
        'FrmModificadorOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(600, 502)
        Me.Controls.Add(Me.lblRegistroOrden)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chbGarantia)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblNOrden)
        Me.Controls.Add(Me.gboEstado)
        Me.Controls.Add(Me.chbDolar)
        Me.Controls.Add(Me.lblResolucion)
        Me.Controls.Add(Me.txtResolucion)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.lblTFecha)
        Me.Controls.Add(Me.lblOrden)
        Me.Controls.Add(Me.lblDetalle)
        Me.Controls.Add(Me.txtFalla)
        Me.Controls.Add(Me.lblImporte)
        Me.Name = "FrmModificadorOrden"
        Me.Text = "FrmModificadorOrden"
        Me.Panel1.ResumeLayout(False)
        Me.gboEstado.ResumeLayout(False)
        Me.gboEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegistroOrden As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnModificarOrden As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chbGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblNOrden As System.Windows.Forms.Label
    Friend WithEvents gboEstado As System.Windows.Forms.GroupBox
    Friend WithEvents rdEntregado As System.Windows.Forms.RadioButton
    Friend WithEvents rdReparado As System.Windows.Forms.RadioButton
    Friend WithEvents rdEspera As System.Windows.Forms.RadioButton
    Friend WithEvents rdPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents chbDolar As System.Windows.Forms.CheckBox
    Friend WithEvents lblResolucion As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents lblTFecha As System.Windows.Forms.Label
    Friend WithEvents lblOrden As System.Windows.Forms.Label
    Friend WithEvents lblDetalle As System.Windows.Forms.Label
    Friend WithEvents txtFalla As System.Windows.Forms.TextBox
    Friend WithEvents lblImporte As System.Windows.Forms.Label
End Class
