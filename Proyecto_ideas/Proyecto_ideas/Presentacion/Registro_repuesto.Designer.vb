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
        Me.txtRID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.nudRCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(48, 177)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnRCancelar
        '
        Me.btnRCancelar.Location = New System.Drawing.Point(177, 177)
        Me.btnRCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRCancelar.Name = "btnRCancelar"
        Me.btnRCancelar.Size = New System.Drawing.Size(100, 28)
        Me.btnRCancelar.TabIndex = 1
        Me.btnRCancelar.Text = "Cancelar"
        Me.btnRCancelar.UseVisualStyleBackColor = True
        '
        'lblRNombre
        '
        Me.lblRNombre.AutoSize = True
        Me.lblRNombre.Location = New System.Drawing.Point(44, 58)
        Me.lblRNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRNombre.Name = "lblRNombre"
        Me.lblRNombre.Size = New System.Drawing.Size(58, 17)
        Me.lblRNombre.TabIndex = 2
        Me.lblRNombre.Text = "Nombre"
        '
        'lblRCantidad
        '
        Me.lblRCantidad.AutoSize = True
        Me.lblRCantidad.Location = New System.Drawing.Point(44, 102)
        Me.lblRCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRCantidad.Name = "lblRCantidad"
        Me.lblRCantidad.Size = New System.Drawing.Size(64, 17)
        Me.lblRCantidad.TabIndex = 3
        Me.lblRCantidad.Text = "Cantidad"
        '
        'txtRNombre
        '
        Me.txtRNombre.Location = New System.Drawing.Point(117, 54)
        Me.txtRNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRNombre.Name = "txtRNombre"
        Me.txtRNombre.Size = New System.Drawing.Size(159, 22)
        Me.txtRNombre.TabIndex = 4
        '
        'nudRCantidad
        '
        Me.nudRCantidad.Location = New System.Drawing.Point(117, 100)
        Me.nudRCantidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.nudRCantidad.Name = "nudRCantidad"
        Me.nudRCantidad.Size = New System.Drawing.Size(160, 22)
        Me.nudRCantidad.TabIndex = 5
        '
        'txtRID
        '
        Me.txtRID.Location = New System.Drawing.Point(118, 13)
        Me.txtRID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRID.Name = "txtRID"
        Me.txtRID.Size = New System.Drawing.Size(159, 22)
        Me.txtRID.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID REPUESTO"
        '
        'Registro_repuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRID)
        Me.Controls.Add(Me.nudRCantidad)
        Me.Controls.Add(Me.txtRNombre)
        Me.Controls.Add(Me.lblRCantidad)
        Me.Controls.Add(Me.lblRNombre)
        Me.Controls.Add(Me.btnRCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
    Friend WithEvents txtRID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
