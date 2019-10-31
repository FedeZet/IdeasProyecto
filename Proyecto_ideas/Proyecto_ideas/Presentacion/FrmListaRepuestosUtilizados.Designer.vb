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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaRepuestosUtilizados))
        Me.lblListaRepuestos = New System.Windows.Forms.Label()
        Me.dgvListadoRepuesto = New System.Windows.Forms.DataGridView()
        Me.idR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoRep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvListadoRepuestosUtilizados = New System.Windows.Forms.DataGridView()
        Me.idRU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreRU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoRepU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRGuardar = New System.Windows.Forms.Button()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoRepuestosUtilizados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblListaRepuestos
        '
        Me.lblListaRepuestos.AutoSize = True
        Me.lblListaRepuestos.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblListaRepuestos.ForeColor = System.Drawing.Color.White
        Me.lblListaRepuestos.Location = New System.Drawing.Point(137, 11)
        Me.lblListaRepuestos.Name = "lblListaRepuestos"
        Me.lblListaRepuestos.Size = New System.Drawing.Size(224, 30)
        Me.lblListaRepuestos.TabIndex = 23
        Me.lblListaRepuestos.Text = "Lista de repuestos"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoRepuesto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRepuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idR, Me.nombre, Me.cantidad, Me.costoRep})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRepuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoRepuesto.GridColor = System.Drawing.Color.White
        Me.dgvListadoRepuesto.Location = New System.Drawing.Point(12, 91)
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
        'dgvListadoRepuestosUtilizados
        '
        Me.dgvListadoRepuestosUtilizados.AllowUserToAddRows = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToDeleteRows = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToResizeColumns = False
        Me.dgvListadoRepuestosUtilizados.AllowUserToResizeRows = False
        Me.dgvListadoRepuestosUtilizados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoRepuestosUtilizados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoRepuestosUtilizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoRepuestosUtilizados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRU, Me.nombreRU, Me.cantidadU, Me.costoRepU})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRepuestosUtilizados.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListadoRepuestosUtilizados.GridColor = System.Drawing.Color.White
        Me.dgvListadoRepuestosUtilizados.Location = New System.Drawing.Point(12, 289)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnREliminar)
        Me.Panel1.Controls.Add(Me.btnRGuardar)
        Me.Panel1.Controls.Add(Me.btnRAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 499)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(470, 68)
        Me.Panel1.TabIndex = 2
        '
        'btnREliminar
        '
        Me.btnREliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnREliminar.FlatAppearance.BorderSize = 0
        Me.btnREliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREliminar.Image = Global.Ideas.My.Resources.Resources.remove
        Me.btnREliminar.Location = New System.Drawing.Point(412, 10)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnREliminar.TabIndex = 4
        Me.btnREliminar.UseVisualStyleBackColor = True
        '
        'btnRGuardar
        '
        Me.btnRGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRGuardar.FlatAppearance.BorderSize = 0
        Me.btnRGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRGuardar.Image = Global.Ideas.My.Resources.Resources.save_file_option
        Me.btnRGuardar.Location = New System.Drawing.Point(213, 10)
        Me.btnRGuardar.Name = "btnRGuardar"
        Me.btnRGuardar.Size = New System.Drawing.Size(46, 46)
        Me.btnRGuardar.TabIndex = 3
        Me.btnRGuardar.UseVisualStyleBackColor = True
        '
        'btnRAgregar
        '
        Me.btnRAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRAgregar.FlatAppearance.BorderSize = 0
        Me.btnRAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRAgregar.Image = Global.Ideas.My.Resources.Resources.add
        Me.btnRAgregar.Location = New System.Drawing.Point(12, 10)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnRAgregar.TabIndex = 2
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Image = Global.Ideas.My.Resources.Resources.back
        Me.btnVolver.Location = New System.Drawing.Point(12, 11)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(46, 46)
        Me.btnVolver.TabIndex = 5
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'FrmListaRepuestosUtilizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvListadoRepuestosUtilizados)
        Me.Controls.Add(Me.lblListaRepuestos)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvListadoRepuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListaRepuestosUtilizados"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoRepuestosUtilizados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRAgregar As System.Windows.Forms.Button
    Friend WithEvents lblListaRepuestos As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents dgvListadoRepuesto As System.Windows.Forms.DataGridView
    Friend WithEvents idR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoRep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvListadoRepuestosUtilizados As System.Windows.Forms.DataGridView
    Friend WithEvents idRU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreRU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidadU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoRepU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRGuardar As System.Windows.Forms.Button
    Friend WithEvents btnREliminar As System.Windows.Forms.Button
End Class
