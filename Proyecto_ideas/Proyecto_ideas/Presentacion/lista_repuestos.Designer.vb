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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListadoRepuesto = New System.Windows.Forms.DataGridView()
        Me.idR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscadorRep = New System.Windows.Forms.TextBox()
        Me.lblListaRepuestos = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRAgregar = New System.Windows.Forms.Button()
        Me.btnREliminar = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnRModificar = New System.Windows.Forms.Button()
        Me.btnBuscadorRep = New System.Windows.Forms.Button()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.dgvListadoRepuesto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idR, Me.nombre, Me.cantidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoRepuesto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoRepuesto.GridColor = System.Drawing.Color.White
        Me.dgvListadoRepuesto.Location = New System.Drawing.Point(12, 90)
        Me.dgvListadoRepuesto.Name = "dgvListadoRepuesto"
        Me.dgvListadoRepuesto.ReadOnly = True
        Me.dgvListadoRepuesto.RowHeadersVisible = False
        Me.dgvListadoRepuesto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoRepuesto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoRepuesto.Size = New System.Drawing.Size(343, 192)
        Me.dgvListadoRepuesto.TabIndex = 4
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
        'txtBuscadorRep
        '
        Me.txtBuscadorRep.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorRep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorRep.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorRep.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorRep.Location = New System.Drawing.Point(217, 62)
        Me.txtBuscadorRep.Name = "txtBuscadorRep"
        Me.txtBuscadorRep.Size = New System.Drawing.Size(117, 21)
        Me.txtBuscadorRep.TabIndex = 1
        '
        'lblListaRepuestos
        '
        Me.lblListaRepuestos.AutoSize = True
        Me.lblListaRepuestos.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblListaRepuestos.ForeColor = System.Drawing.Color.White
        Me.lblListaRepuestos.Location = New System.Drawing.Point(69, 15)
        Me.lblListaRepuestos.Name = "lblListaRepuestos"
        Me.lblListaRepuestos.Size = New System.Drawing.Size(224, 30)
        Me.lblListaRepuestos.TabIndex = 17
        Me.lblListaRepuestos.Text = "Lista de repuestos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRAgregar)
        Me.Panel1.Controls.Add(Me.btnREliminar)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnRModificar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(383, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 345)
        Me.Panel1.TabIndex = 2
        '
        'btnRAgregar
        '
        Me.btnRAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRAgregar.FlatAppearance.BorderSize = 0
        Me.btnRAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRAgregar.Image = Global.Proyecto_ideas.My.Resources.Resources.add
        Me.btnRAgregar.Location = New System.Drawing.Point(10, 102)
        Me.btnRAgregar.Name = "btnRAgregar"
        Me.btnRAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnRAgregar.TabIndex = 3
        Me.btnRAgregar.UseVisualStyleBackColor = True
        '
        'btnREliminar
        '
        Me.btnREliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnREliminar.FlatAppearance.BorderSize = 0
        Me.btnREliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnREliminar.Image = Global.Proyecto_ideas.My.Resources.Resources.remove
        Me.btnREliminar.Location = New System.Drawing.Point(10, 287)
        Me.btnREliminar.Name = "btnREliminar"
        Me.btnREliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnREliminar.TabIndex = 5
        Me.btnREliminar.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh1
        Me.btnRefresh.Location = New System.Drawing.Point(10, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 46)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnRModificar
        '
        Me.btnRModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRModificar.FlatAppearance.BorderSize = 0
        Me.btnRModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRModificar.Image = Global.Proyecto_ideas.My.Resources.Resources.modify
        Me.btnRModificar.Location = New System.Drawing.Point(10, 202)
        Me.btnRModificar.Name = "btnRModificar"
        Me.btnRModificar.Size = New System.Drawing.Size(46, 46)
        Me.btnRModificar.TabIndex = 4
        Me.btnRModificar.UseVisualStyleBackColor = True
        '
        'btnBuscadorRep
        '
        Me.btnBuscadorRep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorRep.FlatAppearance.BorderSize = 0
        Me.btnBuscadorRep.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorRep.Image = Global.Proyecto_ideas.My.Resources.Resources.search1
        Me.btnBuscadorRep.Location = New System.Drawing.Point(339, 63)
        Me.btnBuscadorRep.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorRep.Name = "btnBuscadorRep"
        Me.btnBuscadorRep.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorRep.TabIndex = 2
        Me.btnBuscadorRep.TabStop = False
        Me.btnBuscadorRep.UseVisualStyleBackColor = True
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnVolverOrdenesLista.FlatAppearance.BorderSize = 0
        Me.btnVolverOrdenesLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolverOrdenesLista.Image = Global.Proyecto_ideas.My.Resources.Resources.back
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(11, 287)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(46, 46)
        Me.btnVolverOrdenesLista.TabIndex = 6
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'lista_repuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(451, 345)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblListaRepuestos)
        Me.Controls.Add(Me.btnBuscadorRep)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.txtBuscadorRep)
        Me.Controls.Add(Me.dgvListadoRepuesto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lista_repuestos"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro_repuesto"
        CType(Me.dgvListadoRepuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoRepuesto As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscadorRep As System.Windows.Forms.TextBox
    Friend WithEvents btnRAgregar As System.Windows.Forms.Button
    Friend WithEvents btnREliminar As System.Windows.Forms.Button
    Friend WithEvents btnRModificar As System.Windows.Forms.Button
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnBuscadorRep As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lblListaRepuestos As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents idR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
