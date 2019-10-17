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
        Me.btnBuscadorCli = New System.Windows.Forms.Button()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnCModificar = New System.Windows.Forms.Button()
        Me.btnCEliminar = New System.Windows.Forms.Button()
        Me.btnCAgregar = New System.Windows.Forms.Button()
        Me.txtBuscadorCli = New System.Windows.Forms.TextBox()
        Me.dgvListadoCliente = New System.Windows.Forms.DataGridView()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.idR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscadorCli
        '
        Me.btnBuscadorCli.Location = New System.Drawing.Point(331, 14)
        Me.btnBuscadorCli.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorCli.Name = "btnBuscadorCli"
        Me.btnBuscadorCli.Size = New System.Drawing.Size(56, 19)
        Me.btnBuscadorCli.TabIndex = 23
        Me.btnBuscadorCli.Text = "Buscar"
        Me.btnBuscadorCli.UseVisualStyleBackColor = True
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(24, 13)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(56, 19)
        Me.btnVolverOrdenesLista.TabIndex = 21
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnCModificar
        '
        Me.btnCModificar.Enabled = False
        Me.btnCModificar.Location = New System.Drawing.Point(283, 224)
        Me.btnCModificar.Name = "btnCModificar"
        Me.btnCModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnCModificar.TabIndex = 20
        Me.btnCModificar.Text = "Modificar"
        Me.btnCModificar.UseVisualStyleBackColor = True
        '
        'btnCEliminar
        '
        Me.btnCEliminar.Enabled = False
        Me.btnCEliminar.Location = New System.Drawing.Point(184, 224)
        Me.btnCEliminar.Name = "btnCEliminar"
        Me.btnCEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnCEliminar.TabIndex = 19
        Me.btnCEliminar.Text = "Eliminar"
        Me.btnCEliminar.UseVisualStyleBackColor = True
        '
        'btnCAgregar
        '
        Me.btnCAgregar.Location = New System.Drawing.Point(83, 224)
        Me.btnCAgregar.Name = "btnCAgregar"
        Me.btnCAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnCAgregar.TabIndex = 18
        Me.btnCAgregar.Text = "Agregar"
        Me.btnCAgregar.UseVisualStyleBackColor = True
        '
        'txtBuscadorCli
        '
        Me.txtBuscadorCli.Location = New System.Drawing.Point(216, 14)
        Me.txtBuscadorCli.Name = "txtBuscadorCli"
        Me.txtBuscadorCli.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscadorCli.TabIndex = 17
        '
        'dgvListadoCliente
        '
        Me.dgvListadoCliente.AllowUserToAddRows = False
        Me.dgvListadoCliente.AllowUserToDeleteRows = False
        Me.dgvListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idR, Me.nombre, Me.telefono})
        Me.dgvListadoCliente.Location = New System.Drawing.Point(45, 55)
        Me.dgvListadoCliente.Name = "dgvListadoCliente"
        Me.dgvListadoCliente.ReadOnly = True
        Me.dgvListadoCliente.Size = New System.Drawing.Size(343, 150)
        Me.dgvListadoCliente.TabIndex = 16
        '
        'pbRefresh
        '
        Me.pbRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh
        Me.pbRefresh.Location = New System.Drawing.Point(45, 37)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(16, 16)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 22
        Me.pbRefresh.TabStop = False
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
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBuscadorCli As System.Windows.Forms.Button
    Friend WithEvents pbRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnCModificar As System.Windows.Forms.Button
    Friend WithEvents btnCEliminar As System.Windows.Forms.Button
    Friend WithEvents btnCAgregar As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvListadoCliente As System.Windows.Forms.DataGridView
    Friend WithEvents idR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
