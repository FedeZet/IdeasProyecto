<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_usuario
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
        Me.dgvListadoUsuario = New System.Windows.Forms.DataGridView()
        Me.idU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.costoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBuscadorU = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnUAgregar = New System.Windows.Forms.Button()
        Me.btnUEliminar = New System.Windows.Forms.Button()
        Me.btnURefresh = New System.Windows.Forms.Button()
        Me.btnUModificar = New System.Windows.Forms.Button()
        Me.btnUVolver = New System.Windows.Forms.Button()
        Me.btnBuscadorUsu = New System.Windows.Forms.Button()
        Me.lblUsuarios = New System.Windows.Forms.Label()
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoUsuario
        '
        Me.dgvListadoUsuario.AllowUserToAddRows = False
        Me.dgvListadoUsuario.AllowUserToDeleteRows = False
        Me.dgvListadoUsuario.AllowUserToResizeColumns = False
        Me.dgvListadoUsuario.AllowUserToResizeRows = False
        Me.dgvListadoUsuario.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idU, Me.user, Me.nombre, Me.telefono, Me.costoServicio})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoUsuario.GridColor = System.Drawing.Color.White
        Me.dgvListadoUsuario.Location = New System.Drawing.Point(12, 94)
        Me.dgvListadoUsuario.Name = "dgvListadoUsuario"
        Me.dgvListadoUsuario.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoUsuario.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListadoUsuario.RowHeadersVisible = False
        Me.dgvListadoUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoUsuario.Size = New System.Drawing.Size(523, 180)
        Me.dgvListadoUsuario.TabIndex = 0
        Me.dgvListadoUsuario.TabStop = False
        '
        'idU
        '
        Me.idU.HeaderText = "ID"
        Me.idU.Name = "idU"
        Me.idU.ReadOnly = True
        Me.idU.Width = 50
        '
        'user
        '
        Me.user.HeaderText = "User"
        Me.user.Name = "user"
        Me.user.ReadOnly = True
        Me.user.Width = 120
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 160
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'costoServicio
        '
        Me.costoServicio.HeaderText = "Servicio"
        Me.costoServicio.Name = "costoServicio"
        Me.costoServicio.ReadOnly = True
        Me.costoServicio.Width = 90
        '
        'txtBuscadorU
        '
        Me.txtBuscadorU.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorU.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorU.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorU.Location = New System.Drawing.Point(362, 67)
        Me.txtBuscadorU.Name = "txtBuscadorU"
        Me.txtBuscadorU.Size = New System.Drawing.Size(152, 21)
        Me.txtBuscadorU.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUAgregar)
        Me.Panel1.Controls.Add(Me.btnUEliminar)
        Me.Panel1.Controls.Add(Me.btnURefresh)
        Me.Panel1.Controls.Add(Me.btnUModificar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(554, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 336)
        Me.Panel1.TabIndex = 2
        '
        'btnUAgregar
        '
        Me.btnUAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnUAgregar.FlatAppearance.BorderSize = 0
        Me.btnUAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUAgregar.Image = Global.Proyecto_ideas.My.Resources.Resources.add
        Me.btnUAgregar.Location = New System.Drawing.Point(10, 98)
        Me.btnUAgregar.Name = "btnUAgregar"
        Me.btnUAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnUAgregar.TabIndex = 3
        Me.btnUAgregar.UseVisualStyleBackColor = True
        '
        'btnUEliminar
        '
        Me.btnUEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnUEliminar.FlatAppearance.BorderSize = 0
        Me.btnUEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUEliminar.Image = Global.Proyecto_ideas.My.Resources.Resources.remove
        Me.btnUEliminar.Location = New System.Drawing.Point(10, 278)
        Me.btnUEliminar.Name = "btnUEliminar"
        Me.btnUEliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnUEliminar.TabIndex = 5
        Me.btnUEliminar.UseVisualStyleBackColor = True
        '
        'btnURefresh
        '
        Me.btnURefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnURefresh.FlatAppearance.BorderSize = 0
        Me.btnURefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnURefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh1
        Me.btnURefresh.Location = New System.Drawing.Point(10, 15)
        Me.btnURefresh.Name = "btnURefresh"
        Me.btnURefresh.Size = New System.Drawing.Size(46, 46)
        Me.btnURefresh.TabIndex = 2
        Me.btnURefresh.UseVisualStyleBackColor = True
        '
        'btnUModificar
        '
        Me.btnUModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnUModificar.FlatAppearance.BorderSize = 0
        Me.btnUModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUModificar.Image = Global.Proyecto_ideas.My.Resources.Resources.modify
        Me.btnUModificar.Location = New System.Drawing.Point(10, 189)
        Me.btnUModificar.Name = "btnUModificar"
        Me.btnUModificar.Size = New System.Drawing.Size(46, 46)
        Me.btnUModificar.TabIndex = 4
        Me.btnUModificar.UseVisualStyleBackColor = True
        '
        'btnUVolver
        '
        Me.btnUVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUVolver.FlatAppearance.BorderSize = 0
        Me.btnUVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUVolver.Image = Global.Proyecto_ideas.My.Resources.Resources.back
        Me.btnUVolver.Location = New System.Drawing.Point(11, 279)
        Me.btnUVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUVolver.Name = "btnUVolver"
        Me.btnUVolver.Size = New System.Drawing.Size(46, 46)
        Me.btnUVolver.TabIndex = 6
        Me.btnUVolver.UseVisualStyleBackColor = True
        '
        'btnBuscadorUsu
        '
        Me.btnBuscadorUsu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorUsu.FlatAppearance.BorderSize = 0
        Me.btnBuscadorUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorUsu.Image = Global.Proyecto_ideas.My.Resources.Resources.search1
        Me.btnBuscadorUsu.Location = New System.Drawing.Point(519, 68)
        Me.btnBuscadorUsu.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorUsu.Name = "btnBuscadorUsu"
        Me.btnBuscadorUsu.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorUsu.TabIndex = 11
        Me.btnBuscadorUsu.TabStop = False
        Me.btnBuscadorUsu.UseVisualStyleBackColor = True
        '
        'lblUsuarios
        '
        Me.lblUsuarios.AutoSize = True
        Me.lblUsuarios.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblUsuarios.ForeColor = System.Drawing.Color.White
        Me.lblUsuarios.Location = New System.Drawing.Point(177, 18)
        Me.lblUsuarios.Name = "lblUsuarios"
        Me.lblUsuarios.Size = New System.Drawing.Size(206, 30)
        Me.lblUsuarios.TabIndex = 47
        Me.lblUsuarios.Text = "Lista de Usuarios"
        '
        'Historial_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 336)
        Me.Controls.Add(Me.lblUsuarios)
        Me.Controls.Add(Me.btnBuscadorUsu)
        Me.Controls.Add(Me.btnUVolver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBuscadorU)
        Me.Controls.Add(Me.dgvListadoUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Historial_usuario"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_usuario"
        CType(Me.dgvListadoUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscadorU As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnUAgregar As System.Windows.Forms.Button
    Friend WithEvents btnUEliminar As System.Windows.Forms.Button
    Friend WithEvents btnURefresh As System.Windows.Forms.Button
    Friend WithEvents btnUModificar As System.Windows.Forms.Button
    Friend WithEvents btnUVolver As System.Windows.Forms.Button
    Friend WithEvents btnBuscadorUsu As System.Windows.Forms.Button
    Friend WithEvents idU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents user As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents costoServicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblUsuarios As System.Windows.Forms.Label
End Class
