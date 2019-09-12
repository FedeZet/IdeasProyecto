<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pantalla_inicio
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
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnRepuesto = New System.Windows.Forms.Button()
        Me.btnOrden = New System.Windows.Forms.Button()
        Me.btnDispositivo = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCliente
        '
        Me.btnCliente.Location = New System.Drawing.Point(27, 46)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(120, 95)
        Me.btnCliente.TabIndex = 0
        Me.btnCliente.Text = "Cliente"
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnRepuesto
        '
        Me.btnRepuesto.Location = New System.Drawing.Point(174, 46)
        Me.btnRepuesto.Name = "btnRepuesto"
        Me.btnRepuesto.Size = New System.Drawing.Size(120, 95)
        Me.btnRepuesto.TabIndex = 1
        Me.btnRepuesto.Text = "Repuesto"
        Me.btnRepuesto.UseVisualStyleBackColor = True
        '
        'btnOrden
        '
        Me.btnOrden.Location = New System.Drawing.Point(329, 46)
        Me.btnOrden.Name = "btnOrden"
        Me.btnOrden.Size = New System.Drawing.Size(120, 212)
        Me.btnOrden.TabIndex = 2
        Me.btnOrden.Text = "Orden"
        Me.btnOrden.UseVisualStyleBackColor = True
        '
        'btnDispositivo
        '
        Me.btnDispositivo.Location = New System.Drawing.Point(27, 168)
        Me.btnDispositivo.Name = "btnDispositivo"
        Me.btnDispositivo.Size = New System.Drawing.Size(120, 90)
        Me.btnDispositivo.TabIndex = 3
        Me.btnDispositivo.Text = "Dispositivo"
        Me.btnDispositivo.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.Location = New System.Drawing.Point(174, 168)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(120, 90)
        Me.btnUsuario.TabIndex = 4
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'Pantalla_inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 291)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnDispositivo)
        Me.Controls.Add(Me.btnOrden)
        Me.Controls.Add(Me.btnRepuesto)
        Me.Controls.Add(Me.btnCliente)
        Me.Name = "Pantalla_inicio"
        Me.Text = "Pantalla_inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents btnRepuesto As System.Windows.Forms.Button
    Friend WithEvents btnOrden As System.Windows.Forms.Button
    Friend WithEvents btnDispositivo As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
End Class
