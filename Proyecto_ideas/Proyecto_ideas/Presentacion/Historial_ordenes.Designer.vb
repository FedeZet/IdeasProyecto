<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_ordenes
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
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnAgregarO = New System.Windows.Forms.Button()
        Me.btnListaImprimir = New System.Windows.Forms.Button()
        Me.idO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dolar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.garantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idO, Me.detalle, Me.resolucion, Me.importe, Me.dolar, Me.garantia, Me.fecha, Me.hora, Me.estado, Me.idU, Me.idC, Me.idD})
        Me.DataGridView1.Location = New System.Drawing.Point(32, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1242, 210)
        Me.DataGridView1.TabIndex = 0
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(517, 269)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverOrdenesLista.TabIndex = 1
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnAgregarO
        '
        Me.btnAgregarO.Location = New System.Drawing.Point(616, 268)
        Me.btnAgregarO.Name = "btnAgregarO"
        Me.btnAgregarO.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarO.TabIndex = 2
        Me.btnAgregarO.Text = "Agregar"
        Me.btnAgregarO.UseVisualStyleBackColor = True
        '
        'btnListaImprimir
        '
        Me.btnListaImprimir.Location = New System.Drawing.Point(715, 268)
        Me.btnListaImprimir.Name = "btnListaImprimir"
        Me.btnListaImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnListaImprimir.TabIndex = 3
        Me.btnListaImprimir.Text = "Imprimir"
        Me.btnListaImprimir.UseVisualStyleBackColor = True
        '
        'idO
        '
        Me.idO.HeaderText = "Id Orden"
        Me.idO.Name = "idO"
        Me.idO.ReadOnly = True
        '
        'detalle
        '
        Me.detalle.HeaderText = "Detalle"
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        '
        'resolucion
        '
        Me.resolucion.HeaderText = "Resolucion"
        Me.resolucion.Name = "resolucion"
        Me.resolucion.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "Importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'dolar
        '
        Me.dolar.HeaderText = "Dolar"
        Me.dolar.Name = "dolar"
        Me.dolar.ReadOnly = True
        '
        'garantia
        '
        Me.garantia.HeaderText = "Garantia"
        Me.garantia.Name = "garantia"
        Me.garantia.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'hora
        '
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'idU
        '
        Me.idU.HeaderText = "Id Us. "
        Me.idU.Name = "idU"
        Me.idU.ReadOnly = True
        '
        'idC
        '
        Me.idC.HeaderText = "Id Cli."
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        '
        'idD
        '
        Me.idD.HeaderText = "id Disp."
        Me.idD.Name = "idD"
        Me.idD.ReadOnly = True
        '
        'Historial_ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1298, 303)
        Me.Controls.Add(Me.btnListaImprimir)
        Me.Controls.Add(Me.btnAgregarO)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Historial_ordenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_ordenes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnAgregarO As System.Windows.Forms.Button
    Friend WithEvents btnListaImprimir As System.Windows.Forms.Button
    Friend WithEvents idO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents detalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents resolucion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dolar As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents garantia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idD As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
