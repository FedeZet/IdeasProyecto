<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaDispositivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmListaDispositivo))
        Me.dgvListadoDispositivo = New System.Windows.Forms.DataGridView()
        Me.idD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bateria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tapa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estuche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tmemoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscadorD = New System.Windows.Forms.Button()
        Me.txtBuscadorD = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDSeleccionar = New System.Windows.Forms.Button()
        Me.btnDAgregar = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDModificar = New System.Windows.Forms.Button()
        Me.btnDEliminar = New System.Windows.Forms.Button()
        Me.lblListaDispositivo = New System.Windows.Forms.Label()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dgvListadoDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListadoDispositivo
        '
        Me.dgvListadoDispositivo.AllowUserToAddRows = False
        Me.dgvListadoDispositivo.AllowUserToDeleteRows = False
        Me.dgvListadoDispositivo.AllowUserToResizeColumns = False
        Me.dgvListadoDispositivo.AllowUserToResizeRows = False
        Me.dgvListadoDispositivo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.dgvListadoDispositivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListadoDispositivo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListadoDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListadoDispositivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idD, Me.modelo, Me.bateria, Me.sim, Me.cargador, Me.tapa, Me.estuche, Me.tmemoria, Me.pin, Me.idC})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListadoDispositivo.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListadoDispositivo.GridColor = System.Drawing.Color.White
        Me.dgvListadoDispositivo.Location = New System.Drawing.Point(12, 83)
        Me.dgvListadoDispositivo.Name = "dgvListadoDispositivo"
        Me.dgvListadoDispositivo.ReadOnly = True
        Me.dgvListadoDispositivo.RowHeadersVisible = False
        Me.dgvListadoDispositivo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListadoDispositivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListadoDispositivo.Size = New System.Drawing.Size(613, 182)
        Me.dgvListadoDispositivo.TabIndex = 33
        Me.dgvListadoDispositivo.TabStop = False
        '
        'idD
        '
        Me.idD.HeaderText = "ID"
        Me.idD.Name = "idD"
        Me.idD.ReadOnly = True
        Me.idD.Width = 50
        '
        'modelo
        '
        Me.modelo.HeaderText = "Modelo"
        Me.modelo.Name = "modelo"
        Me.modelo.ReadOnly = True
        '
        'bateria
        '
        Me.bateria.HeaderText = "Bateria"
        Me.bateria.Name = "bateria"
        Me.bateria.ReadOnly = True
        Me.bateria.Width = 60
        '
        'sim
        '
        Me.sim.HeaderText = "SIM"
        Me.sim.Name = "sim"
        Me.sim.ReadOnly = True
        Me.sim.Width = 40
        '
        'cargador
        '
        Me.cargador.HeaderText = "Cargador"
        Me.cargador.Name = "cargador"
        Me.cargador.ReadOnly = True
        Me.cargador.Width = 70
        '
        'tapa
        '
        Me.tapa.HeaderText = "Tapa"
        Me.tapa.Name = "tapa"
        Me.tapa.ReadOnly = True
        Me.tapa.Width = 50
        '
        'estuche
        '
        Me.estuche.HeaderText = "Estuche"
        Me.estuche.Name = "estuche"
        Me.estuche.ReadOnly = True
        Me.estuche.Width = 60
        '
        'tmemoria
        '
        Me.tmemoria.HeaderText = "T. Memoria"
        Me.tmemoria.Name = "tmemoria"
        Me.tmemoria.ReadOnly = True
        Me.tmemoria.Width = 80
        '
        'pin
        '
        Me.pin.HeaderText = "PIN"
        Me.pin.Name = "pin"
        Me.pin.ReadOnly = True
        Me.pin.Width = 50
        '
        'idC
        '
        Me.idC.HeaderText = "IDC"
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        Me.idC.Width = 50
        '
        'btnBuscadorD
        '
        Me.btnBuscadorD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnBuscadorD.FlatAppearance.BorderSize = 0
        Me.btnBuscadorD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscadorD.Image = Global.Ideas.My.Resources.Resources.search1
        Me.btnBuscadorD.Location = New System.Drawing.Point(605, 57)
        Me.btnBuscadorD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorD.Name = "btnBuscadorD"
        Me.btnBuscadorD.Size = New System.Drawing.Size(16, 16)
        Me.btnBuscadorD.TabIndex = 43
        Me.btnBuscadorD.TabStop = False
        Me.btnBuscadorD.UseVisualStyleBackColor = True
        '
        'txtBuscadorD
        '
        Me.txtBuscadorD.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtBuscadorD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscadorD.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscadorD.ForeColor = System.Drawing.Color.White
        Me.txtBuscadorD.Location = New System.Drawing.Point(483, 56)
        Me.txtBuscadorD.Name = "txtBuscadorD"
        Me.txtBuscadorD.Size = New System.Drawing.Size(117, 21)
        Me.txtBuscadorD.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDSeleccionar)
        Me.Panel1.Controls.Add(Me.btnDAgregar)
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.btnDModificar)
        Me.Panel1.Controls.Add(Me.btnDEliminar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 283)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(638, 68)
        Me.Panel1.TabIndex = 2
        '
        'btnDSeleccionar
        '
        Me.btnDSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnDSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDSeleccionar.Image = Global.Ideas.My.Resources.Resources._select
        Me.btnDSeleccionar.Location = New System.Drawing.Point(152, 10)
        Me.btnDSeleccionar.Name = "btnDSeleccionar"
        Me.btnDSeleccionar.Size = New System.Drawing.Size(46, 46)
        Me.btnDSeleccionar.TabIndex = 3
        Me.btnDSeleccionar.UseVisualStyleBackColor = True
        '
        'btnDAgregar
        '
        Me.btnDAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDAgregar.FlatAppearance.BorderSize = 0
        Me.btnDAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDAgregar.Image = Global.Ideas.My.Resources.Resources.add
        Me.btnDAgregar.Location = New System.Drawing.Point(302, 10)
        Me.btnDAgregar.Name = "btnDAgregar"
        Me.btnDAgregar.Size = New System.Drawing.Size(46, 46)
        Me.btnDAgregar.TabIndex = 4
        Me.btnDAgregar.UseVisualStyleBackColor = True
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
        'btnDModificar
        '
        Me.btnDModificar.Enabled = False
        Me.btnDModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDModificar.FlatAppearance.BorderSize = 0
        Me.btnDModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDModificar.Image = Global.Ideas.My.Resources.Resources.modify
        Me.btnDModificar.Location = New System.Drawing.Point(442, 10)
        Me.btnDModificar.Name = "btnDModificar"
        Me.btnDModificar.Size = New System.Drawing.Size(46, 46)
        Me.btnDModificar.TabIndex = 5
        Me.btnDModificar.UseVisualStyleBackColor = True
        '
        'btnDEliminar
        '
        Me.btnDEliminar.Enabled = False
        Me.btnDEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDEliminar.FlatAppearance.BorderSize = 0
        Me.btnDEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDEliminar.Image = Global.Ideas.My.Resources.Resources.remove
        Me.btnDEliminar.Location = New System.Drawing.Point(580, 10)
        Me.btnDEliminar.Name = "btnDEliminar"
        Me.btnDEliminar.Size = New System.Drawing.Size(46, 46)
        Me.btnDEliminar.TabIndex = 6
        Me.btnDEliminar.UseVisualStyleBackColor = True
        '
        'lblListaDispositivo
        '
        Me.lblListaDispositivo.AutoSize = True
        Me.lblListaDispositivo.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblListaDispositivo.ForeColor = System.Drawing.Color.White
        Me.lblListaDispositivo.Location = New System.Drawing.Point(200, 14)
        Me.lblListaDispositivo.Name = "lblListaDispositivo"
        Me.lblListaDispositivo.Size = New System.Drawing.Size(245, 30)
        Me.lblListaDispositivo.TabIndex = 48
        Me.lblListaDispositivo.Text = "Lista de dispositivos"
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
        'FrmListaDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(638, 351)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.lblListaDispositivo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBuscadorD)
        Me.Controls.Add(Me.txtBuscadorD)
        Me.Controls.Add(Me.dgvListadoDispositivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmListaDispositivo"
        Me.Opacity = 0.95R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvListadoDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvListadoDispositivo As System.Windows.Forms.DataGridView
    Friend WithEvents idD As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bateria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cargador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tapa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estuche As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmemoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBuscadorD As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorD As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDAgregar As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDModificar As System.Windows.Forms.Button
    Friend WithEvents btnDEliminar As System.Windows.Forms.Button
    Friend WithEvents btnDSeleccionar As System.Windows.Forms.Button
    Friend WithEvents lblListaDispositivo As System.Windows.Forms.Label
    Friend WithEvents btnVolver As System.Windows.Forms.Button
End Class
