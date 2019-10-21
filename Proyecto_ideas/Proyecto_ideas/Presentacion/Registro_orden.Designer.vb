<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_orden
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
        Me.btnDipositivo = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.chbGarantia = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.gboEstado = New System.Windows.Forms.GroupBox()
        Me.rdEntregado = New System.Windows.Forms.RadioButton()
        Me.rdReparado = New System.Windows.Forms.RadioButton()
        Me.rdEspera = New System.Windows.Forms.RadioButton()
        Me.rdPendiente = New System.Windows.Forms.RadioButton()
        Me.chbDolar = New System.Windows.Forms.CheckBox()
        Me.cbTecnico = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResolucion = New System.Windows.Forms.TextBox()
        Me.btnCrearOrden = New System.Windows.Forms.Button()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtFalla = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtNombreCli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gboEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDipositivo
        '
        Me.btnDipositivo.Location = New System.Drawing.Point(331, 32)
        Me.btnDipositivo.Name = "btnDipositivo"
        Me.btnDipositivo.Size = New System.Drawing.Size(75, 23)
        Me.btnDipositivo.TabIndex = 69
        Me.btnDipositivo.Text = "Dispositivo"
        Me.btnDipositivo.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(68, 35)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(75, 23)
        Me.btnCliente.TabIndex = 68
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'chbGarantia
        '
        Me.chbGarantia.AutoSize = True
        Me.chbGarantia.Location = New System.Drawing.Point(238, 200)
        Me.chbGarantia.Name = "chbGarantia"
        Me.chbGarantia.Size = New System.Drawing.Size(66, 17)
        Me.chbGarantia.TabIndex = 67
        Me.chbGarantia.Text = "Garantia"
        Me.chbGarantia.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(385, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(53, 13)
        Me.lblFecha.TabIndex = 66
        Me.lblFecha.Text = "1/1/1111"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(77, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "0"
        '
        'gboEstado
        '
        Me.gboEstado.Controls.Add(Me.rdEntregado)
        Me.gboEstado.Controls.Add(Me.rdReparado)
        Me.gboEstado.Controls.Add(Me.rdEspera)
        Me.gboEstado.Controls.Add(Me.rdPendiente)
        Me.gboEstado.Location = New System.Drawing.Point(436, 174)
        Me.gboEstado.Name = "gboEstado"
        Me.gboEstado.Size = New System.Drawing.Size(139, 129)
        Me.gboEstado.TabIndex = 64
        Me.gboEstado.TabStop = False
        Me.gboEstado.Text = "Estado"
        '
        'rdEntregado
        '
        Me.rdEntregado.AutoSize = True
        Me.rdEntregado.Location = New System.Drawing.Point(6, 89)
        Me.rdEntregado.Name = "rdEntregado"
        Me.rdEntregado.Size = New System.Drawing.Size(74, 17)
        Me.rdEntregado.TabIndex = 3
        Me.rdEntregado.Text = "Entregado"
        Me.rdEntregado.UseVisualStyleBackColor = True
        '
        'rdReparado
        '
        Me.rdReparado.AutoSize = True
        Me.rdReparado.Location = New System.Drawing.Point(6, 69)
        Me.rdReparado.Name = "rdReparado"
        Me.rdReparado.Size = New System.Drawing.Size(72, 17)
        Me.rdReparado.TabIndex = 2
        Me.rdReparado.Text = "Reparado"
        Me.rdReparado.UseVisualStyleBackColor = True
        '
        'rdEspera
        '
        Me.rdEspera.AutoSize = True
        Me.rdEspera.Location = New System.Drawing.Point(6, 43)
        Me.rdEspera.Name = "rdEspera"
        Me.rdEspera.Size = New System.Drawing.Size(74, 17)
        Me.rdEspera.TabIndex = 1
        Me.rdEspera.Text = "En Espera"
        Me.rdEspera.UseVisualStyleBackColor = True
        '
        'rdPendiente
        '
        Me.rdPendiente.AutoSize = True
        Me.rdPendiente.Checked = True
        Me.rdPendiente.Location = New System.Drawing.Point(6, 21)
        Me.rdPendiente.Name = "rdPendiente"
        Me.rdPendiente.Size = New System.Drawing.Size(73, 17)
        Me.rdPendiente.TabIndex = 0
        Me.rdPendiente.TabStop = True
        Me.rdPendiente.Text = "Pendiente"
        Me.rdPendiente.UseVisualStyleBackColor = True
        '
        'chbDolar
        '
        Me.chbDolar.AutoSize = True
        Me.chbDolar.Location = New System.Drawing.Point(374, 176)
        Me.chbDolar.Name = "chbDolar"
        Me.chbDolar.Size = New System.Drawing.Size(51, 17)
        Me.chbDolar.TabIndex = 63
        Me.chbDolar.Text = "Dolar"
        Me.chbDolar.UseVisualStyleBackColor = True
        '
        'cbTecnico
        '
        Me.cbTecnico.FormattingEnabled = True
        Me.cbTecnico.Location = New System.Drawing.Point(68, 272)
        Me.cbTecnico.Name = "cbTecnico"
        Me.cbTecnico.Size = New System.Drawing.Size(191, 21)
        Me.cbTecnico.TabIndex = 62
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(581, 382)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 61
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 272)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Tecnico:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(332, 310)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 13)
        Me.Label8.TabIndex = 59
        Me.Label8.Text = "Resolucion:"
        '
        'txtResolucion
        '
        Me.txtResolucion.Location = New System.Drawing.Point(331, 333)
        Me.txtResolucion.Multiline = True
        Me.txtResolucion.Name = "txtResolucion"
        Me.txtResolucion.Size = New System.Drawing.Size(244, 133)
        Me.txtResolucion.TabIndex = 58
        '
        'btnCrearOrden
        '
        Me.btnCrearOrden.Location = New System.Drawing.Point(581, 353)
        Me.btnCrearOrden.Name = "btnCrearOrden"
        Me.btnCrearOrden.Size = New System.Drawing.Size(100, 23)
        Me.btnCrearOrden.TabIndex = 57
        Me.btnCrearOrden.Text = "Crear Orden"
        Me.btnCrearOrden.UseVisualStyleBackColor = True
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(238, 174)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(130, 20)
        Me.txtImporte.TabIndex = 56
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(68, 101)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(187, 20)
        Me.txtTel.TabIndex = 55
        Me.txtTel.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Tel:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(328, 9)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Orden:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Detalles:"
        '
        'txtFalla
        '
        Me.txtFalla.Location = New System.Drawing.Point(15, 333)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.Size = New System.Drawing.Size(244, 133)
        Me.txtFalla.TabIndex = 50
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(388, 64)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ReadOnly = True
        Me.txtModelo.Size = New System.Drawing.Size(179, 20)
        Me.txtModelo.TabIndex = 49
        Me.txtModelo.TabStop = False
        '
        'txtNombreCli
        '
        Me.txtNombreCli.Location = New System.Drawing.Point(68, 67)
        Me.txtNombreCli.Name = "txtNombreCli"
        Me.txtNombreCli.ReadOnly = True
        Me.txtNombreCli.Size = New System.Drawing.Size(187, 20)
        Me.txtNombreCli.TabIndex = 48
        Me.txtNombreCli.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(326, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(178, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Importe:"
        '
        'Registro_orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 475)
        Me.Controls.Add(Me.btnDipositivo)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.chbGarantia)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.gboEstado)
        Me.Controls.Add(Me.chbDolar)
        Me.Controls.Add(Me.cbTecnico)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResolucion)
        Me.Controls.Add(Me.btnCrearOrden)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtFalla)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.txtNombreCli)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Registro_orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Orden"
        Me.gboEstado.ResumeLayout(False)
        Me.gboEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDipositivo As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents chbGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents gboEstado As System.Windows.Forms.GroupBox
    Friend WithEvents rdEntregado As System.Windows.Forms.RadioButton
    Friend WithEvents rdReparado As System.Windows.Forms.RadioButton
    Friend WithEvents rdEspera As System.Windows.Forms.RadioButton
    Friend WithEvents rdPendiente As System.Windows.Forms.RadioButton
    Friend WithEvents chbDolar As System.Windows.Forms.CheckBox
    Friend WithEvents cbTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtResolucion As System.Windows.Forms.TextBox
    Friend WithEvents btnCrearOrden As System.Windows.Forms.Button
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFalla As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreCli As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
