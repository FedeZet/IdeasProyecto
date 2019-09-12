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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRModificar = New System.Windows.Forms.Button()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.nombre, Me.cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'btnRAgregar
        '
        Me.btnRAgregar.Location = New System.Drawing.Point(66, 226)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnRAgregar.TabIndex = 10
        Me.btnRAgregar.Text = "Agregar"
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'btnREliminar
        '
        Me.btnREliminar.Location = New System.Drawing.Point(167, 226)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnREliminar.TabIndex = 11
        Me.btnREliminar.Text = "Eliminar"
        Me.btnREliminar.UseVisualStyleBackColor = True
        '
        'btnRModificar
        '
        Me.btnRModificar.Location = New System.Drawing.Point(266, 226)
        Me.btnRModificar.Name = "btnRModificar"
        Me.btnRModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnRModificar.TabIndex = 12
        Me.btnRModificar.Text = "Modificar"
        Me.btnRModificar.UseVisualStyleBackColor = True
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
        'lista_repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 283)
        Me.Controls.Add(Me.btnRModificar)
        Me.Controls.Add(Me.btnREliminar)
        Me.Controls.Add(Me.btnRAgregar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
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
End Class
