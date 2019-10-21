<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_dispositivos
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
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.btnBuscadorD = New System.Windows.Forms.Button()
        Me.pbRefresh = New System.Windows.Forms.PictureBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnDModificar = New System.Windows.Forms.Button()
        Me.btnDEliminar = New System.Windows.Forms.Button()
        Me.btnDAgregar = New System.Windows.Forms.Button()
        Me.txtBuscadorD = New System.Windows.Forms.TextBox()
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
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvListadoDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(710, 240)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(97, 31)
        Me.btnSeleccionar.TabIndex = 41
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'btnBuscadorD
        '
        Me.btnBuscadorD.Location = New System.Drawing.Point(668, 9)
        Me.btnBuscadorD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscadorD.Name = "btnBuscadorD"
        Me.btnBuscadorD.Size = New System.Drawing.Size(90, 31)
        Me.btnBuscadorD.TabIndex = 40
        Me.btnBuscadorD.Text = "Buscar"
        Me.btnBuscadorD.UseVisualStyleBackColor = True
        '
        'pbRefresh
        '
        Me.pbRefresh.Image = Global.Proyecto_ideas.My.Resources.Resources.refresh
        Me.pbRefresh.Location = New System.Drawing.Point(346, 10)
        Me.pbRefresh.Name = "pbRefresh"
        Me.pbRefresh.Size = New System.Drawing.Size(25, 24)
        Me.pbRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRefresh.TabIndex = 39
        Me.pbRefresh.TabStop = False
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(201, 9)
        Me.btnVolver.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(69, 31)
        Me.btnVolver.TabIndex = 38
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnDModificar
        '
        Me.btnDModificar.Enabled = False
        Me.btnDModificar.Location = New System.Drawing.Point(549, 238)
        Me.btnDModificar.Name = "btnDModificar"
        Me.btnDModificar.Size = New System.Drawing.Size(97, 34)
        Me.btnDModificar.TabIndex = 37
        Me.btnDModificar.Text = "Modificar"
        Me.btnDModificar.UseVisualStyleBackColor = True
        '
        'btnDEliminar
        '
        Me.btnDEliminar.Enabled = False
        Me.btnDEliminar.Location = New System.Drawing.Point(382, 236)
        Me.btnDEliminar.Name = "btnDEliminar"
        Me.btnDEliminar.Size = New System.Drawing.Size(83, 36)
        Me.btnDEliminar.TabIndex = 36
        Me.btnDEliminar.Text = "Eliminar"
        Me.btnDEliminar.UseVisualStyleBackColor = True
        '
        'btnDAgregar
        '
        Me.btnDAgregar.Location = New System.Drawing.Point(189, 238)
        Me.btnDAgregar.Name = "btnDAgregar"
        Me.btnDAgregar.Size = New System.Drawing.Size(105, 34)
        Me.btnDAgregar.TabIndex = 35
        Me.btnDAgregar.Text = "Agregar"
        Me.btnDAgregar.UseVisualStyleBackColor = True
        '
        'txtBuscadorD
        '
        Me.txtBuscadorD.Location = New System.Drawing.Point(404, 10)
        Me.txtBuscadorD.Name = "txtBuscadorD"
        Me.txtBuscadorD.Size = New System.Drawing.Size(259, 20)
        Me.txtBuscadorD.TabIndex = 34
        '
        'dgvListadoDispositivo
        '
        Me.dgvListadoDispositivo.AllowUserToAddRows = False
        Me.dgvListadoDispositivo.AllowUserToDeleteRows = False
        Me.dgvListadoDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoDispositivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idD, Me.modelo, Me.bateria, Me.sim, Me.cargador, Me.tapa, Me.estuche, Me.tmemoria, Me.pin, Me.idC})
        Me.dgvListadoDispositivo.Location = New System.Drawing.Point(12, 67)
        Me.dgvListadoDispositivo.Name = "dgvListadoDispositivo"
        Me.dgvListadoDispositivo.ReadOnly = True
        Me.dgvListadoDispositivo.Size = New System.Drawing.Size(1046, 150)
        Me.dgvListadoDispositivo.TabIndex = 33
        '
        'idD
        '
        Me.idD.HeaderText = "ID"
        Me.idD.Name = "idD"
        Me.idD.ReadOnly = True
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
        '
        'sim
        '
        Me.sim.HeaderText = "SIM"
        Me.sim.Name = "sim"
        Me.sim.ReadOnly = True
        '
        'cargador
        '
        Me.cargador.HeaderText = "Cargador"
        Me.cargador.Name = "cargador"
        Me.cargador.ReadOnly = True
        '
        'tapa
        '
        Me.tapa.HeaderText = "Tapa"
        Me.tapa.Name = "tapa"
        Me.tapa.ReadOnly = True
        '
        'estuche
        '
        Me.estuche.HeaderText = "Estuche"
        Me.estuche.Name = "estuche"
        Me.estuche.ReadOnly = True
        '
        'tmemoria
        '
        Me.tmemoria.HeaderText = "T. Memoria"
        Me.tmemoria.Name = "tmemoria"
        Me.tmemoria.ReadOnly = True
        '
        'pin
        '
        Me.pin.HeaderText = "PIN"
        Me.pin.Name = "pin"
        Me.pin.ReadOnly = True
        '
        'idC
        '
        Me.idC.HeaderText = "ID Cli."
        Me.idC.Name = "idC"
        Me.idC.ReadOnly = True
        '
        'lista_dispositivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 280)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnBuscadorD)
        Me.Controls.Add(Me.pbRefresh)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnDModificar)
        Me.Controls.Add(Me.btnDEliminar)
        Me.Controls.Add(Me.btnDAgregar)
        Me.Controls.Add(Me.txtBuscadorD)
        Me.Controls.Add(Me.dgvListadoDispositivo)
        Me.Name = "lista_dispositivos"
        Me.Text = "lista_dispositivos"
        CType(Me.pbRefresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvListadoDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents btnBuscadorD As System.Windows.Forms.Button
    Friend WithEvents pbRefresh As System.Windows.Forms.PictureBox
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents btnDModificar As System.Windows.Forms.Button
    Friend WithEvents btnDEliminar As System.Windows.Forms.Button
    Friend WithEvents btnDAgregar As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorD As System.Windows.Forms.TextBox
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
End Class
