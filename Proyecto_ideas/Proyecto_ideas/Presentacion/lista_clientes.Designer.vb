<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_clientes
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
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnBuscadorCli = New System.Windows.Forms.Button()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnCModificar = New System.Windows.Forms.Button()
        Me.btnCEliminar = New System.Windows.Forms.Button()
        Me.btnCAgregar = New System.Windows.Forms.Button()
        Me.txtBuscadorCli = New System.Windows.Forms.TextBox()
        Me.dgvListadoCliente = New System.Windows.Forms.DataGridView()
        Me.idC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Enabled = False
        Me.btnSeleccionar.Location = New System.Drawing.Point(331, 225)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(77, 23)
        Me.btnSeleccionar.TabIndex = 42
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnBuscadorCli
        '
        Me.btnBuscadorCli.Location = New System.Drawing.Point(331, 13)
        Me.btnBuscadorCli.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorCli.Name = "btnBuscadorCli"
        Me.btnBuscadorCli.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscadorCli.TabIndex = 41
        Me.btnBuscadorCli.Text = "Buscar"
        Me.btnBuscadorCli.UseVisualStyleBackColor = True
        '
        'pbRefresh
        '
        Me.pbRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh
        Me.pbRefresh.Location = New System.Drawing.Point(45, 36)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(16, 16)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 40
        Me.pbRefresh.TabStop = False
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(24, 12)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(56, 19)
        Me.btnVolverOrdenesLista.TabIndex = 39
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnCModificar
        '
        Me.btnCModificar.Enabled = False
        Me.btnCModificar.Location = New System.Drawing.Point(232, 225)
        Me.btnCModificar.Name = "btnCModificar"
        Me.btnCModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnCModificar.TabIndex = 38
        Me.btnCModificar.Text = "Modificar"
        Me.btnCModificar.UseVisualStyleBackColor = True
        '
        'btnCEliminar
        '
        Me.btnCEliminar.Enabled = False
        Me.btnCEliminar.Location = New System.Drawing.Point(133, 225)
        Me.btnCEliminar.Name = "btnCEliminar"
        Me.btnCEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnCEliminar.TabIndex = 37
        Me.btnCEliminar.Text = "Eliminar"
        Me.btnCEliminar.UseVisualStyleBackColor = True
        '
        'btnCAgregar
        '
        Me.btnCAgregar.Location = New System.Drawing.Point(32, 225)
        Me.btnCAgregar.Name = "btnCAgregar"
        Me.btnCAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnCAgregar.TabIndex = 36
        Me.btnCAgregar.Text = "Agregar"
        Me.btnCAgregar.UseVisualStyleBackColor = True
        '
        'txtBuscadorCli
        '
        Me.txtBuscadorCli.Location = New System.Drawing.Point(216, 13)
        Me.txtBuscadorCli.Name = "txtBuscadorCli"
        Me.txtBuscadorCli.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscadorCli.TabIndex = 35
        '
        'dgvListadoCliente
        '
        Me.dgvListadoCliente.AllowUserToAddRows = False
        Me.dgvListadoCliente.AllowUserToDeleteRows = False
        Me.dgvListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idC, Me.nombre, Me.telefono})
        Me.dgvListadoCliente.Location = New System.Drawing.Point(45, 54)
        Me.dgvListadoCliente.Name = "dgvListadoCliente"
        Me.dgvListadoCliente.ReadOnly = True
        Me.dgvListadoCliente.Size = New System.Drawing.Size(343, 150)
        Me.dgvListadoCliente.TabIndex = 34
        '
        'idC
        '
        Me.idC.HeaderText = "ID"
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'lista_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 261)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnBuscadorCli)
        Me.Controls.Add(Me.pbRefresh)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.btnCModificar)
        Me.Controls.Add(Me.btnCEliminar)
        Me.Controls.Add(Me.btnCAgregar)
        Me.Controls.Add(Me.txtBuscadorCli)
        Me.Controls.Add(Me.dgvListadoCliente)
        Me.Name = "lista_clientes"
        Me.Text = "lista_clientes"
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnBuscadorCli As System.Windows.Forms.Button
    Friend WithEvents pbRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnCModificar As System.Windows.Forms.Button
    Friend WithEvents btnCEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCAgregar As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvListadoCliente As System.Windows.Forms.DataGridView
    Friend WithEvents idC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
