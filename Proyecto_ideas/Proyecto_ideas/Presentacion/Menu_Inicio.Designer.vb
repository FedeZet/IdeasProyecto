<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Inicio
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
        Me.btnOrden = New System.Windows.Forms.Button()
        Me.btnRepuesto = New System.Windows.Forms.Button()
        Me.btnProductividad = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOrden
        '
        Me.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrden.Location = New System.Drawing.Point(11, 11)
        Me.btnOrden.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrden.Name = "btnOrden"
        Me.btnOrden.Size = New System.Drawing.Size(136, 105)
        Me.btnOrden.TabIndex = 2
        Me.btnOrden.Text = "Orden"
        Me.btnOrden.UseVisualStyleBackColor = True
        '
        'btnRepuesto
        '
        Me.btnRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepuesto.Location = New System.Drawing.Point(151, 11)
        Me.btnRepuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRepuesto.Name = "btnRepuesto"
        Me.btnRepuesto.Size = New System.Drawing.Size(136, 105)
        Me.btnRepuesto.TabIndex = 3
        Me.btnRepuesto.Text = "Repuesto"
        Me.btnRepuesto.UseVisualStyleBackColor = True
        '
        'btnProductividad
        '
        Me.btnProductividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductividad.Location = New System.Drawing.Point(151, 120)
        Me.btnProductividad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProductividad.Name = "btnProductividad"
        Me.btnProductividad.Size = New System.Drawing.Size(136, 105)
        Me.btnProductividad.TabIndex = 5
        Me.btnProductividad.Text = "Productividad"
        Me.btnProductividad.UseVisualStyleBackColor = True
        '
        'btnUsuario
        '
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Location = New System.Drawing.Point(11, 120)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(136, 105)
        Me.btnUsuario.TabIndex = 6
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.UseVisualStyleBackColor = True
        '
        'Menu_Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 240)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnProductividad)
        Me.Controls.Add(Me.btnRepuesto)
        Me.Controls.Add(Me.btnOrden)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Menu_Inicio"
        Me.Text = "Menu_Inicio"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOrden As System.Windows.Forms.Button
    Friend WithEvents btnRepuesto As System.Windows.Forms.Button
    Friend WithEvents btnProductividad As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
End Class
