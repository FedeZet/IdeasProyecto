<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaRepuestosUtilizados
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.lblListaRepuestos = New System.Windows.Forms.Label()
        Me.txtBuscadorRep = New System.Windows.Forms.TextBox()
        Me.dgvListadoRepuesto = New System.Windows.Forms.DataGridView()
        Me.idR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscadorRep = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.dgvListadoRepuestosUtilizados = New System.Windows.Forms.DataGridView()
        Me.idRU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreRU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoRepU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoRepuestosUtilizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnRAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(499, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 540)
        Me.Panel1.TabIndex = 20
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(3, 107)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(55, 55)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnRAgregar
        '
        Me.btnRAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRAgregar.FlatAppearance.BorderSize = 0
        Me.btnRAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRAgregar.Image = Global.Ideas.My.Resources.Resources.add
        Me.btnRAgregar.Location = New System.Drawing.Point(10, 15)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnRAgregar.TabIndex = 3
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'lblListaRepuestos
        '
        Me.lblListaRepuestos.AutoSize = True
        Me.lblListaRepuestos.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblListaRepuestos.ForeColor = System.Drawing.Color.White
        Me.lblListaRepuestos.Location = New System.Drawing.Point(124, 9)
        Me.lblListaRepuestos.Name = "lblListaRepuestos"
        Me.lblListaRepuestos.Size = New System.Drawing.Size(224, 30)
        Me.lblListaRepuestos.TabIndex = 23
        Me.lblListaRepuestos.Text = "Lista de repuestos"
        '
        'txtBuscadorRep
        '
        Me.txtBuscadorRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorRep.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorRep.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorRep.Location = New System.Drawing.Point(311, 64)
        Me.txtBuscadorRep.Name = "txtBuscadorRep"
        Me.txtBuscadorRep.Size = New System.Drawing.Size(117, 21)
        Me.txtBuscadorRep.TabIndex = 18
        '
        'dgvListadoRepuesto
        '
        Me.dgvListadoRepuesto.AllowUserToAddRows = False
        Me.dgvListadoRepuesto.AllowUserToDeleteRows = False
        Me.dgvListadoRepuesto.AllowUserToResizeColumns = False
        Me.dgvListadoRepuesto.AllowUserToResizeRows = False
        Me.dgvListadoRepuesto.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoRepuesto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoRepuesto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoRepuesto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListadoRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRepuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idR, Me.nombre, Me.cantidad, Me.costoRep})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRepuesto.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListadoRepuesto.GridColor = System.Drawing.Color.White
        Me.dgvListadoRepuesto.Location = New System.Drawing.Point(6, 90)
        Me.dgvListadoRepuesto.MultiSelect = False
        Me.dgvListadoRepuesto.Name = "dgvListadoRepuesto"
        Me.dgvListadoRepuesto.ReadOnly = True
        Me.dgvListadoRepuesto.RowHeadersVisible = False
        Me.dgvListadoRepuesto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoRepuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoRepuesto.Size = New System.Drawing.Size(443, 192)
        Me.dgvListadoRepuesto.TabIndex = 21
        Me.dgvListadoRepuesto.TabStop = False
        '
        'idR
        '
        Me.idR.HeaderText = "ID"
        Me.idR.MaxInputLength = 5
        Me.idR.Name = "idR"
        Me.idR.ReadOnly = True
        Me.idR.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 190
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        '
        'costoRep
        '
        Me.costoRep.HeaderText = "Costo Rep."
        Me.costoRep.Name = "costoRep"
        Me.costoRep.ReadOnly = True
        '
        'btnBuscadorRep
        '
        Me.btnBuscadorRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorRep.FlatAppearance.BorderSize = 0
        Me.btnBuscadorRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorRep.Image = Global.Ideas.My.Resources.Resources.search1
        Me.btnBuscadorRep.Location = New System.Drawing.Point(433, 65)
        Me.btnBuscadorRep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorRep.Name = "btnBuscadorRep"
        Me.btnBuscadorRep.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorRep.TabIndex = 19
        Me.btnBuscadorRep.TabStop = False
        Me.btnBuscadorRep.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Image = Global.Ideas.My.Resources.Resources.back
        Me.btnVolver.Location = New System.Drawing.Point(11, 15)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(46, 46)
        Me.btnVolver.TabIndex = 22
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'dgvListadoRepuestosUtilizados
        '
        Me.dgvListadoRepuestosUtilizados.AllowUserToAddRows = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToDeleteRows = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToResizeColumns = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToResizeRows = False
        Me.dgvListadoRepuestosUtilizados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoRepuestosUtilizados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRepuestosUtilizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRU, Me.nombreRU, Me.cantidadU, Me.costoRepU})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRepuestosUtilizados.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListadoRepuestosUtilizados.GridColor = System.Drawing.Color.White
        Me.dgvListadoRepuestosUtilizados.Location = New System.Drawing.Point(6, 316)
        Me.dgvListadoRepuestosUtilizados.Name = "dgvListadoRepuestosUtilizados"
        Me.dgvListadoRepuestosUtilizados.ReadOnly = True
        Me.dgvListadoRepuestosUtilizados.RowHeadersVisible = False
        Me.dgvListadoRepuestosUtilizados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoRepuestosUtilizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoRepuestosUtilizados.Size = New System.Drawing.Size(443, 192)
        Me.dgvListadoRepuestosUtilizados.TabIndex = 24
        Me.dgvListadoRepuestosUtilizados.TabStop = False
        '
        'idRU
        '
        Me.idRU.HeaderText = "ID"
        Me.idRU.MaxInputLength = 5
        Me.idRU.Name = "idRU"
        Me.idRU.ReadOnly = True
        Me.idRU.Width = 50
        '
        'nombreRU
        '
        Me.nombreRU.HeaderText = "Nombre"
        Me.nombreRU.Name = "nombreRU"
        Me.nombreRU.ReadOnly = True
        Me.nombreRU.Width = 190
        '
        'cantidadU
        '
        Me.cantidadU.HeaderText = "Cantidad"
        Me.cantidadU.Name = "cantidadU"
        Me.cantidadU.ReadOnly = True
        '
        'costoRepU
        '
        Me.costoRepU.HeaderText = "Costo Total"
        Me.costoRepU.Name = "costoRepU"
        Me.costoRepU.ReadOnly = True
        '
        'FrmListaRepuestosUtilizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(567, 540)
        Me.Controls.Add(Me.dgvListadoRepuestosUtilizados)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblListaRepuestos)
        Me.Controls.Add(Me.btnBuscadorRep)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtBuscadorRep)
        Me.Controls.Add(Me.dgvListadoRepuesto)
        Me.Name = "FrmListaRepuestosUtilizados"
        Me.Text = "FrmListaRepuestosUtilizados"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoRepuestosUtilizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRAgregar As System.Windows.Forms.Button
    Friend WithEvents lblListaRepuestos As System.Windows.Forms.Label
    Friend WithEvents btnBuscadorRep As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorRep As System.Windows.Forms.TextBox
    Friend WithEvents dgvListadoRepuesto As System.Windows.Forms.DataGridView
    Friend WithEvents idR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoRep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dgvListadoRepuestosUtilizados As System.Windows.Forms.DataGridView
    Friend WithEvents idRU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreRU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoRepU As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
