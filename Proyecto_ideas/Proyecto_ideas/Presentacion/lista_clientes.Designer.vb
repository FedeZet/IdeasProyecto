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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscadorCli = New System.Windows.Forms.TextBox()
        Me.dgvListadoCliente = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCSeleccionar = New System.Windows.Forms.Button()
        Me.btnCAgregar = New System.Windows.Forms.Button()
        Me.btnCEliminar = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCModificar = New System.Windows.Forms.Button()
        Me.lblClientes = New System.Windows.Forms.Label()
        Me.btnCVolver = New System.Windows.Forms.Button()
        Me.btnBuscadorCli = New System.Windows.Forms.Button()
        Me.idC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mailC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscadorCli
        '
        Me.txtBuscadorCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorCli.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorCli.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorCli.Location = New System.Drawing.Point(227, 41)
        Me.txtBuscadorCli.Name = "txtBuscadorCli"
        Me.txtBuscadorCli.Size = New System.Drawing.Size(117, 21)
        Me.txtBuscadorCli.TabIndex = 1
        '
        'dgvListadoCliente
        '
        Me.dgvListadoCliente.AllowUserToAddRows = False
        Me.dgvListadoCliente.AllowUserToDeleteRows = False
        Me.dgvListadoCliente.AllowUserToResizeColumns = False
        Me.dgvListadoCliente.AllowUserToResizeRows = False
        Me.dgvListadoCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListadoCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idC, Me.nombre, Me.telefono, Me.mailC})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoCliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoCliente.GridColor = System.Drawing.Color.White
        Me.dgvListadoCliente.Location = New System.Drawing.Point(12, 69)
        Me.dgvListadoCliente.Name = "dgvListadoCliente"
        Me.dgvListadoCliente.ReadOnly = True
        Me.dgvListadoCliente.RowHeadersVisible = False
        Me.dgvListadoCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoCliente.Size = New System.Drawing.Size(353, 150)
        Me.dgvListadoCliente.TabIndex = 34
        Me.dgvListadoCliente.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCSeleccionar)
        Me.Panel1.Controls.Add(Me.btnCAgregar)
        Me.Panel1.Controls.Add(Me.btnCEliminar)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnCModificar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(389, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(68, 278)
        Me.Panel1.TabIndex = 2
        '
        'btnCSeleccionar
        '
        Me.btnCSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnCSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCSeleccionar.Image = Global.Proyecto_ideas.My.Resources.Resources._select
        Me.btnCSeleccionar.Location = New System.Drawing.Point(10, 64)
        Me.btnCSeleccionar.Name = "btnCSeleccionar"
        Me.btnCSeleccionar.Size = New System.Drawing.Size(46, 46)
        Me.btnCSeleccionar.TabIndex = 3
        Me.btnCSeleccionar.UseVisualStyleBackColor = True
        '
        'btnCAgregar
        '
        Me.btnCAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCAgregar.FlatAppearance.BorderSize = 0
        Me.btnCAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCAgregar.Image = Global.Proyecto_ideas.My.Resources.Resources.add
        Me.btnCAgregar.Location = New System.Drawing.Point(10, 116)
        Me.btnCAgregar.Name = "btnCAgregar"
        Me.btnCAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnCAgregar.TabIndex = 4
        Me.btnCAgregar.UseVisualStyleBackColor = True
        '
        'btnCEliminar
        '
        Me.btnCEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCEliminar.FlatAppearance.BorderSize = 0
        Me.btnCEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCEliminar.Image = Global.Proyecto_ideas.My.Resources.Resources.remove
        Me.btnCEliminar.Location = New System.Drawing.Point(10, 220)
        Me.btnCEliminar.Name = "btnCEliminar"
        Me.btnCEliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnCEliminar.TabIndex = 6
        Me.btnCEliminar.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh1
        Me.btnRefresh.Location = New System.Drawing.Point(10, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(46, 46)
        Me.btnRefresh.TabIndex = 2
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCModificar
        '
        Me.btnCModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnCModificar.FlatAppearance.BorderSize = 0
        Me.btnCModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCModificar.Image = Global.Proyecto_ideas.My.Resources.Resources.modify
        Me.btnCModificar.Location = New System.Drawing.Point(10, 168)
        Me.btnCModificar.Name = "btnCModificar"
        Me.btnCModificar.Size = New System.Drawing.Size(46, 46)
        Me.btnCModificar.TabIndex = 5
        Me.btnCModificar.UseVisualStyleBackColor = True
        '
        'lblClientes
        '
        Me.lblClientes.AutoSize = True
        Me.lblClientes.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblClientes.ForeColor = System.Drawing.Color.White
        Me.lblClientes.Location = New System.Drawing.Point(12, 9)
        Me.lblClientes.Name = "lblClientes"
        Me.lblClientes.Size = New System.Drawing.Size(110, 30)
        Me.lblClientes.TabIndex = 46
        Me.lblClientes.Text = "Clientes"
        '
        'btnCVolver
        '
        Me.btnCVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnCVolver.FlatAppearance.BorderSize = 0
        Me.btnCVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCVolver.Image = Global.Proyecto_ideas.My.Resources.Resources.back
        Me.btnCVolver.Location = New System.Drawing.Point(11, 224)
        Me.btnCVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCVolver.Name = "btnCVolver"
        Me.btnCVolver.Size = New System.Drawing.Size(46, 46)
        Me.btnCVolver.TabIndex = 7
        Me.btnCVolver.UseVisualStyleBackColor = True
        '
        'btnBuscadorCli
        '
        Me.btnBuscadorCli.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorCli.FlatAppearance.BorderSize = 0
        Me.btnBuscadorCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorCli.Image = Global.Proyecto_ideas.My.Resources.Resources.search1
        Me.btnBuscadorCli.Location = New System.Drawing.Point(349, 42)
        Me.btnBuscadorCli.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorCli.Name = "btnBuscadorCli"
        Me.btnBuscadorCli.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorCli.TabIndex = 44
        Me.btnBuscadorCli.TabStop = False
        Me.btnBuscadorCli.UseVisualStyleBackColor = True
        '
        'idC
        '
        Me.idC.HeaderText = "ID"
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        Me.idC.Width = 50
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 180
        '
        'telefono
        '
        Me.telefono.HeaderText = "Telefono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        Me.telefono.Width = 120
        '
        'mailC
        '
        Me.mailC.HeaderText = "Correo"
        Me.mailC.Name = "mailC"
        Me.mailC.ReadOnly = True
        '
        'lista_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(457, 278)
        Me.Controls.Add(Me.lblClientes)
        Me.Controls.Add(Me.btnCVolver)
        Me.Controls.Add(Me.btnBuscadorCli)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtBuscadorCli)
        Me.Controls.Add(Me.dgvListadoCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lista_clientes"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lista_clientes"
        CType(Me.dgvListadoCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscadorCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvListadoCliente As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCEliminar As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCModificar As System.Windows.Forms.Button
    Friend WithEvents btnBuscadorCli As System.Windows.Forms.Button
    Friend WithEvents btnCSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnCVolver As System.Windows.Forms.Button
    Friend WithEvents lblClientes As System.Windows.Forms.Label
    Friend WithEvents idC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mailC As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
