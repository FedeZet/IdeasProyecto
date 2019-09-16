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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRModificar = New System.Windows.Forms.Button()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(40, 64)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(457, 185)
        Me.DataGridView1.TabIndex = 4
        '
        'codigo
        '
        Me.codigo.HeaderText = "ID"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 32)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(132, 22)
        Me.TextBox1.TabIndex = 8
        '
        'btnRAgregar
        '
        Me.btnRAgregar.Location = New System.Drawing.Point(88, 278)
        Me.btnRAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(100, 28)
        Me.btnRAgregar.TabIndex = 10
        Me.btnRAgregar.Text = "Agregar"
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'btnREliminar
        '
        Me.btnREliminar.Location = New System.Drawing.Point(223, 278)
        Me.btnREliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(100, 28)
        Me.btnREliminar.TabIndex = 11
        Me.btnREliminar.Text = "Eliminar"
        Me.btnREliminar.UseVisualStyleBackColor = True
        '
        'btnRModificar
        '
        Me.btnRModificar.Location = New System.Drawing.Point(355, 278)
        Me.btnRModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRModificar.Name = "btnRModificar"
        Me.btnRModificar.Size = New System.Drawing.Size(100, 28)
        Me.btnRModificar.TabIndex = 12
        Me.btnRModificar.Text = "Modificar"
        Me.btnRModificar.UseVisualStyleBackColor = True
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(12, 12)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverOrdenesLista.TabIndex = 13
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'lista_repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 348)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.btnRModificar)
        Me.Controls.Add(Me.btnREliminar)
        Me.Controls.Add(Me.btnRAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "lista_repuestos"
        Me.Text = "Registro_repuesto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnRAgregar As System.Windows.Forms.Button
    Friend WithEvents btnREliminar As System.Windows.Forms.Button
    Friend WithEvents btnRModificar As System.Windows.Forms.Button
    Friend WithEvents codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
End Class
