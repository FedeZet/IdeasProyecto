<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaOrden
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaOrden))
        Me.dgvListaOrdenes = New System.Windows.Forms.DataGridView()
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
        Me.btnCEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOModificar = New System.Windows.Forms.Button()
        Me.btnOImprimir = New System.Windows.Forms.Button()
        Me.btnOAgregar = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnORepuesto = New System.Windows.Forms.Button()
        Me.btnOEliminar = New System.Windows.Forms.Button()
        Me.lblListaOrden = New System.Windows.Forms.Label()
        Me.txtBuscadorO = New System.Windows.Forms.TextBox()
        Me.btnBuscadorO = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvListaOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListaOrdenes
        '
        Me.dgvListaOrdenes.AllowUserToAddRows = False
        Me.dgvListaOrdenes.AllowUserToDeleteRows = False
        Me.dgvListaOrdenes.AllowUserToResizeColumns = False
        Me.dgvListaOrdenes.AllowUserToResizeRows = False
        Me.dgvListaOrdenes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListaOrdenes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaOrdenes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idO, Me.detalle, Me.resolucion, Me.importe, Me.dolar, Me.garantia, Me.fecha, Me.hora, Me.estado, Me.idU, Me.idC, Me.idD})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaOrdenes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaOrdenes.GridColor = System.Drawing.Color.White
        Me.dgvListaOrdenes.Location = New System.Drawing.Point(11, 62)
        Me.dgvListaOrdenes.Name = "dgvListaOrdenes"
        Me.dgvListaOrdenes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaOrdenes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaOrdenes.RowHeadersVisible = False
        Me.dgvListaOrdenes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListaOrdenes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaOrdenes.Size = New System.Drawing.Size(833, 235)
        Me.dgvListaOrdenes.TabIndex = 0
        Me.dgvListaOrdenes.TabStop = False
        '
        'idO
        '
        Me.idO.HeaderText = "ID"
        Me.idO.Name = "idO"
        Me.idO.ReadOnly = True
        Me.idO.Width = 50
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
        Me.importe.Width = 90
        '
        'dolar
        '
        Me.dolar.HeaderText = "Dolar"
        Me.dolar.Name = "dolar"
        Me.dolar.ReadOnly = True
        Me.dolar.Width = 50
        '
        'garantia
        '
        Me.garantia.HeaderText = "Garantia"
        Me.garantia.Name = "garantia"
        Me.garantia.ReadOnly = True
        Me.garantia.Width = 70
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 80
        '
        'hora
        '
        Me.hora.HeaderText = "Hora"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Width = 70
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Width = 70
        '
        'idU
        '
        Me.idU.HeaderText = "IDU"
        Me.idU.Name = "idU"
        Me.idU.ReadOnly = True
        Me.idU.Width = 50
        '
        'idC
        '
        Me.idC.HeaderText = "IDC"
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        Me.idC.Width = 50
        '
        'idD
        '
        Me.idD.HeaderText = "IDD"
        Me.idD.Name = "idD"
        Me.idD.ReadOnly = True
        Me.idD.Width = 50
        '
        'btnCEliminar
        '
        Me.btnCEliminar.Enabled = False
        Me.btnCEliminar.Location = New System.Drawing.Point(812, 268)
        Me.btnCEliminar.Name = "btnCEliminar"
        Me.btnCEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnCEliminar.TabIndex = 39
        Me.btnCEliminar.Text = "Eliminar"
        Me.btnCEliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnOModificar)
        Me.Panel1.Controls.Add(Me.btnOImprimir)
        Me.Panel1.Controls.Add(Me.btnOAgregar)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnORepuesto)
        Me.Panel1.Controls.Add(Me.btnOEliminar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 315)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(857, 68)
        Me.Panel1.TabIndex = 2
        '
        'btnOModificar
        '
        Me.btnOModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnOModificar.FlatAppearance.BorderSize = 0
        Me.btnOModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOModificar.Image = Global.Ideas.My.Resources.Resources.modify
        Me.btnOModificar.Location = New System.Drawing.Point(497, 10)
        Me.btnOModificar.Name = "btnOModificar"
        Me.btnOModificar.Size = New System.Drawing.Size(46, 46)
        Me.btnOModificar.TabIndex = 5
        Me.btnOModificar.UseVisualStyleBackColor = True
        '
        'btnOImprimir
        '
        Me.btnOImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnOImprimir.FlatAppearance.BorderSize = 0
        Me.btnOImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOImprimir.Image = Global.Ideas.My.Resources.Resources.printing_tool
        Me.btnOImprimir.Location = New System.Drawing.Point(798, 10)
        Me.btnOImprimir.Name = "btnOImprimir"
        Me.btnOImprimir.Size = New System.Drawing.Size(46, 46)
        Me.btnOImprimir.TabIndex = 7
        Me.btnOImprimir.UseVisualStyleBackColor = True
        '
        'btnOAgregar
        '
        Me.btnOAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnOAgregar.FlatAppearance.BorderSize = 0
        Me.btnOAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOAgregar.Image = Global.Ideas.My.Resources.Resources.add
        Me.btnOAgregar.Location = New System.Drawing.Point(159, 10)
        Me.btnOAgregar.Name = "btnOAgregar"
        Me.btnOAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnOAgregar.TabIndex = 3
        Me.btnOAgregar.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = Global.Ideas.My.Resources.Resources.refresh1
        Me.btnRefresh.Location = New System.Drawing.Point(12, 10)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 46)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnORepuesto
        '
        Me.btnORepuesto.Enabled = False
        Me.btnORepuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnORepuesto.FlatAppearance.BorderSize = 0
        Me.btnORepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnORepuesto.Image = Global.Ideas.My.Resources.Resources.repuestos
        Me.btnORepuesto.Location = New System.Drawing.Point(325, 10)
        Me.btnORepuesto.Name = "btnORepuesto"
        Me.btnORepuesto.Size = New System.Drawing.Size(46, 46)
        Me.btnORepuesto.TabIndex = 4
        Me.btnORepuesto.UseVisualStyleBackColor = True
        '
        'btnOEliminar
        '
        Me.btnOEliminar.Enabled = False
        Me.btnOEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnOEliminar.FlatAppearance.BorderSize = 0
        Me.btnOEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOEliminar.Image = Global.Ideas.My.Resources.Resources.remove
        Me.btnOEliminar.Location = New System.Drawing.Point(654, 10)
        Me.btnOEliminar.Name = "btnOEliminar"
        Me.btnOEliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnOEliminar.TabIndex = 6
        Me.btnOEliminar.UseVisualStyleBackColor = True
        '
        'lblListaOrden
        '
        Me.lblListaOrden.AutoSize = True
        Me.lblListaOrden.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblListaOrden.ForeColor = System.Drawing.Color.White
        Me.lblListaOrden.Location = New System.Drawing.Point(315, 14)
        Me.lblListaOrden.Name = "lblListaOrden"
        Me.lblListaOrden.Size = New System.Drawing.Size(206, 30)
        Me.lblListaOrden.TabIndex = 48
        Me.lblListaOrden.Text = "Lista de órdenes"
        '
        'txtBuscadorO
        '
        Me.txtBuscadorO.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorO.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorO.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorO.Location = New System.Drawing.Point(702, 35)
        Me.txtBuscadorO.Name = "txtBuscadorO"
        Me.txtBuscadorO.Size = New System.Drawing.Size(117, 21)
        Me.txtBuscadorO.TabIndex = 1
        '
        'btnBuscadorO
        '
        Me.btnBuscadorO.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorO.FlatAppearance.BorderSize = 0
        Me.btnBuscadorO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorO.Image = Global.Ideas.My.Resources.Resources.search1
        Me.btnBuscadorO.Location = New System.Drawing.Point(824, 36)
        Me.btnBuscadorO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorO.Name = "btnBuscadorO"
        Me.btnBuscadorO.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorO.TabIndex = 50
        Me.btnBuscadorO.TabStop = False
        Me.btnBuscadorO.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Image = Global.Ideas.My.Resources.Resources.back
        Me.btnVolver.Location = New System.Drawing.Point(11, 11)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(46, 46)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FrmListaOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(857, 383)
        Me.Controls.Add(Me.btnBuscadorO)
        Me.Controls.Add(Me.txtBuscadorO)
        Me.Controls.Add(Me.lblListaOrden)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvListaOrdenes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListaOrden"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ide@s"
        CType(Me.dgvListaOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListaOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents btnCEliminar As System.Windows.Forms.Button
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOImprimir As System.Windows.Forms.Button
    Friend WithEvents btnOAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnORepuesto As System.Windows.Forms.Button
    Friend WithEvents btnOEliminar As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblListaOrden As System.Windows.Forms.Label
    Friend WithEvents btnBuscadorO As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorO As System.Windows.Forms.TextBox
    Friend WithEvents btnOModificar As System.Windows.Forms.Button
End Class
