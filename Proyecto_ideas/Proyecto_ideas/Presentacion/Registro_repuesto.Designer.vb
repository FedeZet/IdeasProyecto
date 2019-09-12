<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_repuesto
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnRCancelar = New System.Windows.Forms.Button()
        Me.lblRNombre = New System.Windows.Forms.Label()
        Me.lblRCantidad = New System.Windows.Forms.Label()
        Me.txtRNombre = New System.Windows.Forms.TextBox()
        Me.nudRCantidad = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudRCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(36, 144)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnRCancelar
        '
        Me.btnRCancelar.Location = New System.Drawing.Point(133, 144)
        Me.btnRCancelar.Name = "btnRCancelar"
        Me.btnRCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnRCancelar.TabIndex = 1
        Me.btnRCancelar.Text = "Cancelar"
        Me.btnRCancelar.UseVisualStyleBackColor = True
        '
        'lblRNombre
        '
        Me.lblRNombre.AutoSize = True
        Me.lblRNombre.Location = New System.Drawing.Point(33, 47)
        Me.lblRNombre.Name = "lblRNombre"
        Me.lblRNombre.Size = New System.Drawing.Size(44, 13)
        Me.lblRNombre.TabIndex = 2
        Me.lblRNombre.Text = "Nombre"
        '
        'lblRCantidad
        '
        Me.lblRCantidad.AutoSize = True
        Me.lblRCantidad.Location = New System.Drawing.Point(33, 83)
        Me.lblRCantidad.Name = "lblRCantidad"
        Me.lblRCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblRCantidad.TabIndex = 3
        Me.lblRCantidad.Text = "Cantidad"
        '
        'txtRNombre
        '
        Me.txtRNombre.Location = New System.Drawing.Point(88, 44)
        Me.txtRNombre.Name = "txtRNombre"
        Me.txtRNombre.Size = New System.Drawing.Size(120, 20)
        Me.txtRNombre.TabIndex = 4
        '
        'nudRCantidad
        '
        Me.nudRCantidad.Location = New System.Drawing.Point(88, 81)
        Me.nudRCantidad.Name = "nudRCantidad"
        Me.nudRCantidad.Size = New System.Drawing.Size(120, 20)
        Me.nudRCantidad.TabIndex = 5
        '
        'Registro_repuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 197)
        Me.Controls.Add(Me.nudRCantidad)
        Me.Controls.Add(Me.txtRNombre)
        Me.Controls.Add(Me.lblRCantidad)
        Me.Controls.Add(Me.lblRNombre)
        Me.Controls.Add(Me.btnRCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Registro_repuesto"
        Me.Text = "Registro_repuesto"
        CType(Me.nudRCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRCancelar As System.Windows.Forms.Button
    Friend WithEvents lblRNombre As System.Windows.Forms.Label
    Friend WithEvents lblRCantidad As System.Windows.Forms.Label
    Friend WithEvents txtRNombre As System.Windows.Forms.TextBox
    Friend WithEvents nudRCantidad As System.Windows.Forms.NumericUpDown
End Class
