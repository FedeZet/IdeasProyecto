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
        Me.idU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtBuscadorU = New System.Windows.Forms.TextBox()
        Me.btnBuscarU = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoUsuario
        '
        Me.dgvListadoUsuario.AllowUserToAddRows = False
        Me.dgvListadoUsuario.AllowUserToDeleteRows = False
        Me.dgvListadoUsuario.AllowUserToResizeColumns = False
        Me.dgvListadoUsuario.AllowUserToResizeRows = False
        Me.dgvListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idU, Me.user, Me.nombre, Me.telefono, Me.costoServicio})
        Me.dgvListadoUsuario.Location = New System.Drawing.Point(12, 27)
        Me.dgvListadoUsuario.Name = "dgvListadoUsuario"
        Me.dgvListadoUsuario.ReadOnly = True
        Me.dgvListadoUsuario.Size = New System.Drawing.Size(538, 180)
        Me.dgvListadoUsuario.TabIndex = 0
        '
        'idU
        '
        Me.idU.HeaderText = "ID"
        Me.idU.Name = "idU"
        Me.idU.ReadOnly = True
        '
        'user
        '
        Me.user.HeaderText = "User"
        Me.user.Name = "user"
        Me.user.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'costoServicio
        '
        Me.costoServicio.HeaderText = "Servicio"
        Me.costoServicio.Name = "costoServicio"
        Me.costoServicio.ReadOnly = True
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(12, 228)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(56, 23)
        Me.btnVolverOrdenesLista.TabIndex = 2
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(203, 228)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(65, 23)
        Me.btnActualizar.TabIndex = 3
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(273, 228)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(354, 228)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtBuscadorU
        '
        Me.txtBuscadorU.Location = New System.Drawing.Point(228, 4)
        Me.txtBuscadorU.Name = "txtBuscadorU"
        Me.txtBuscadorU.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscadorU.TabIndex = 6
        '
        'btnBuscarU
        '
        Me.btnBuscarU.Location = New System.Drawing.Point(386, 1)
        Me.btnBuscarU.Name = "btnBuscarU"
        Me.btnBuscarU.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarU.TabIndex = 7
        Me.btnBuscarU.Text = "Buscar"
        Me.btnBuscarU.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(123, 228)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Historial_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 261)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnBuscarU)
        Me.Controls.Add(Me.txtBuscadorU)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.dgvListadoUsuario)
        Me.Name = "Historial_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_usuario"
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorU As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarU As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents idU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
