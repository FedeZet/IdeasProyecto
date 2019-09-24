<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_usuario
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
        Me.dgvListadoUsuario = New System.Windows.Forms.DataGridView()
        Me.id_usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nick = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoUsuario
        '
        Me.dgvListadoUsuario.AllowUserToAddRows = False
        Me.dgvListadoUsuario.AllowUserToDeleteRows = False
        Me.dgvListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_usuario, Me.Nick, Me.Nombre, Me.Telefono})
        Me.dgvListadoUsuario.Location = New System.Drawing.Point(40, 38)
        Me.dgvListadoUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListadoUsuario.Name = "dgvListadoUsuario"
        Me.dgvListadoUsuario.ReadOnly = True
        Me.dgvListadoUsuario.Size = New System.Drawing.Size(532, 222)
        Me.dgvListadoUsuario.TabIndex = 0
        '
        'id_usuario
        '
        Me.id_usuario.HeaderText = "id_usuario"
        Me.id_usuario.Name = "id_usuario"
        '
        'Nick
        '
        Me.Nick.HeaderText = "Nick"
        Me.Nick.Name = "Nick"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(12, 286)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverOrdenesLista.TabIndex = 2
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(198, 286)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(87, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'Historial_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 321)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.dgvListadoUsuario)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Historial_usuario"
        Me.Text = "Historial_usuario"
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvListadoUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents id_usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nick As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
End Class
