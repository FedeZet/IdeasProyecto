<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_repuestos
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
        Me.dgvListadoRepuesto = New System.Windows.Forms.DataGridView()
        Me.txtBuscadorRep = New System.Windows.Forms.TextBox()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRModificar = New System.Windows.Forms.Button()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.btnBuscadorRep = New System.Windows.Forms.Button()
        Me.idR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListadoRepuesto
        '
        Me.dgvListadoRepuesto.AllowUserToAddRows = False
        Me.dgvListadoRepuesto.AllowUserToDeleteRows = False
        Me.dgvListadoRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRepuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idR, Me.nombre, Me.cantidad})
        Me.dgvListadoRepuesto.Location = New System.Drawing.Point(30, 52)
        Me.dgvListadoRepuesto.Name = "dgvListadoRepuesto"
        Me.dgvListadoRepuesto.ReadOnly = True
        Me.dgvListadoRepuesto.Size = New System.Drawing.Size(343, 150)
        Me.dgvListadoRepuesto.TabIndex = 4
        '
        'txtBuscadorRep
        '
        Me.txtBuscadorRep.Location = New System.Drawing.Point(201, 11)
        Me.txtBuscadorRep.Name = "txtBuscadorRep"
        Me.txtBuscadorRep.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscadorRep.TabIndex = 8
        '
        'btnRAgregar
        '
        Me.btnRAgregar.Location = New System.Drawing.Point(68, 221)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnRAgregar.TabIndex = 10
        Me.btnRAgregar.Text = "Agregar"
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'btnREliminar
        '
        Me.btnREliminar.Enabled = False
        Me.btnREliminar.Location = New System.Drawing.Point(169, 221)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnREliminar.TabIndex = 11
        Me.btnREliminar.Text = "Eliminar"
        Me.btnREliminar.UseVisualStyleBackColor = True
        '
        'btnRModificar
        '
        Me.btnRModificar.Enabled = False
        Me.btnRModificar.Location = New System.Drawing.Point(268, 221)
        Me.btnRModificar.Name = "btnRModificar"
        Me.btnRModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnRModificar.TabIndex = 12
        Me.btnRModificar.Text = "Modificar"
        Me.btnRModificar.UseVisualStyleBackColor = True
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(9, 10)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(56, 19)
        Me.btnVolverOrdenesLista.TabIndex = 13
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'pbRefresh
        '
        Me.pbRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh
        Me.pbRefresh.Location = New System.Drawing.Point(30, 34)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(16, 16)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 14
        Me.pbRefresh.TabStop = False
        '
        'btnBuscadorRep
        '
        Me.btnBuscadorRep.Location = New System.Drawing.Point(316, 11)
        Me.btnBuscadorRep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorRep.Name = "btnBuscadorRep"
        Me.btnBuscadorRep.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscadorRep.TabIndex = 15
        Me.btnBuscadorRep.Text = "Buscar"
        Me.btnBuscadorRep.UseVisualStyleBackColor = True
        '
        'idR
        '
        Me.idR.HeaderText = "ID"
        Me.idR.Name = "idR"
        Me.idR.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'lista_repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 265)
        Me.Controls.Add(Me.btnBuscadorRep)
        Me.Controls.Add(Me.pbRefresh)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.btnRModificar)
        Me.Controls.Add(Me.btnREliminar)
        Me.Controls.Add(Me.btnRAgregar)
        Me.Controls.Add(Me.txtBuscadorRep)
        Me.Controls.Add(Me.dgvListadoRepuesto)
        Me.Name = "lista_repuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro_repuesto"
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoRepuesto As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscadorRep As System.Windows.Forms.TextBox
    Friend WithEvents btnRAgregar As System.Windows.Forms.Button
    Friend WithEvents btnREliminar As System.Windows.Forms.Button
    Friend WithEvents btnRModificar As System.Windows.Forms.Button
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents pbRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents btnBuscadorRep As System.Windows.Forms.Button
    Friend WithEvents idR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
