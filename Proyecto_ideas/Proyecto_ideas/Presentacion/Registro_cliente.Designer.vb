<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_cliente
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
        Me.txtCNombre = New System.Windows.Forms.TextBox()
        Me.lblRCantidad = New System.Windows.Forms.Label()
        Me.lblRNombre = New System.Windows.Forms.Label()
        Me.btnCCancelar = New System.Windows.Forms.Button()
        Me.btnCAgregar = New System.Windows.Forms.Button()
        Me.txtCTelefono = New System.Windows.Forms.TextBox()
        Me.txtMailC = New System.Windows.Forms.TextBox()
        Me.lblMailC = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCNombre
        '
        Me.txtCNombre.Location = New System.Drawing.Point(102, 48)
        Me.txtCNombre.Name = "txtCNombre"
        Me.txtCNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtCNombre.TabIndex = 6
        '
        'lblRCantidad
        '
        Me.lblRCantidad.AutoSize = True
        Me.lblRCantidad.Location = New System.Drawing.Point(47, 87)
        Me.lblRCantidad.Name = "lblRCantidad"
        Me.lblRCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblRCantidad.TabIndex = 11
        Me.lblRCantidad.Text = "Telefono"
        '
        'lblRNombre
        '
        Me.lblRNombre.AutoSize = True
        Me.lblRNombre.Location = New System.Drawing.Point(47, 51)
        Me.lblRNombre.Name = "lblRNombre"
        Me.lblRNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblRNombre.TabIndex = 10
        Me.lblRNombre.Text = "Nombre"
        '
        'btnCCancelar
        '
        Me.btnCCancelar.Location = New System.Drawing.Point(147, 173)
        Me.btnCCancelar.Name = "btnCCancelar"
        Me.btnCCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCCancelar.TabIndex = 14
        Me.btnCCancelar.Text = "Cancelar"
        Me.btnCCancelar.UseVisualStyleBackColor = True
        '
        'btnCAgregar
        '
        Me.btnCAgregar.Location = New System.Drawing.Point(50, 173)
        Me.btnCAgregar.Name = "btnCAgregar"
        Me.btnCAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnCAgregar.TabIndex = 13
        Me.btnCAgregar.Text = "Agregar"
        Me.btnCAgregar.UseVisualStyleBackColor = True
        '
        'txtCTelefono
        '
        Me.txtCTelefono.Location = New System.Drawing.Point(102, 87)
        Me.txtCTelefono.Name = "txtCTelefono"
        Me.txtCTelefono.Size = New System.Drawing.Size(120, 20)
        Me.txtCTelefono.TabIndex = 7
        '
        'txtMailC
        '
        Me.txtMailC.Location = New System.Drawing.Point(102, 122)
        Me.txtMailC.Name = "txtMailC"
        Me.txtMailC.Size = New System.Drawing.Size(120, 20)
        Me.txtMailC.TabIndex = 8
        '
        'lblMailC
        '
        Me.lblMailC.Location = New System.Drawing.Point(47, 125)
        Me.lblMailC.Name = "lblMailC"
        Me.lblMailC.Size = New System.Drawing.Size(49, 13)
        Me.lblMailC.TabIndex = 12
        Me.lblMailC.Text = "e-mail"
        '
        'Registro_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.Controls.Add(Me.lblMailC)
        Me.Controls.Add(Me.txtMailC)
        Me.Controls.Add(Me.txtCTelefono)
        Me.Controls.Add(Me.txtCNombre)
        Me.Controls.Add(Me.lblRCantidad)
        Me.Controls.Add(Me.lblRNombre)
        Me.Controls.Add(Me.btnCCancelar)
        Me.Controls.Add(Me.btnCAgregar)
        Me.Name = "Registro_cliente"
        Me.Text = "Registro_cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblRCantidad As System.Windows.Forms.Label
    Friend WithEvents lblRNombre As System.Windows.Forms.Label
    Friend WithEvents btnCCancelar As System.Windows.Forms.Button
    Friend WithEvents btnCAgregar As System.Windows.Forms.Button
    Friend WithEvents txtCTelefono As System.Windows.Forms.TextBox
    Friend WithEvents txtMailC As System.Windows.Forms.TextBox
    Friend WithEvents lblMailC As System.Windows.Forms.Label
End Class
