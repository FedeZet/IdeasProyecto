<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroRepuesto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroRepuesto))
        Me.nudRCantidad = New System.Windows.Forms.NumericUpDown()
        Me.lblRegistroRepuesto = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRRegistrar = New System.Windows.Forms.Button()
        Me.btnRCancelar = New System.Windows.Forms.Button()
        Me.txtRCosto = New System.Windows.Forms.TextBox()
        Me.txtRNombre = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        CType(Me.nudRCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudRCantidad
        '
        Me.nudRCantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.nudRCantidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudRCantidad.ForeColor = System.Drawing.Color.White
        Me.nudRCantidad.Location = New System.Drawing.Point(171, 138)
        Me.nudRCantidad.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nudRCantidad.Name = "nudRCantidad"
        Me.nudRCantidad.Size = New System.Drawing.Size(142, 27)
        Me.nudRCantidad.TabIndex = 2
        '
        'lblRegistroRepuesto
        '
        Me.lblRegistroRepuesto.AutoSize = True
        Me.lblRegistroRepuesto.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroRepuesto.ForeColor = System.Drawing.Color.White
        Me.lblRegistroRepuesto.Location = New System.Drawing.Point(64, 35)
        Me.lblRegistroRepuesto.Name = "lblRegistroRepuesto"
        Me.lblRegistroRepuesto.Size = New System.Drawing.Size(225, 30)
        Me.lblRegistroRepuesto.TabIndex = 69
        Me.lblRegistroRepuesto.Text = "Registrar repuesto"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnRRegistrar)
        Me.Panel1.Controls.Add(Me.btnRCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 57)
        Me.Panel1.TabIndex = 4
        '
        'btnRRegistrar
        '
        Me.btnRRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRRegistrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnRRegistrar.Location = New System.Drawing.Point(52, 10)
        Me.btnRRegistrar.Name = "btnRRegistrar"
        Me.btnRRegistrar.Size = New System.Drawing.Size(115, 35)
        Me.btnRRegistrar.TabIndex = 4
        Me.btnRRegistrar.Text = "Registrar"
        Me.btnRRegistrar.UseVisualStyleBackColor = True
        '
        'btnRCancelar
        '
        Me.btnRCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnRCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRCancelar.ForeColor = System.Drawing.Color.White
        Me.btnRCancelar.Location = New System.Drawing.Point(185, 10)
        Me.btnRCancelar.Name = "btnRCancelar"
        Me.btnRCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnRCancelar.TabIndex = 5
        Me.btnRCancelar.Text = "Cancelar"
        Me.btnRCancelar.UseVisualStyleBackColor = True
        '
        'txtRCosto
        '
        Me.txtRCosto.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtRCosto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRCosto.ForeColor = System.Drawing.Color.White
        Me.txtRCosto.Location = New System.Drawing.Point(171, 171)
        Me.txtRCosto.Name = "txtRCosto"
        Me.txtRCosto.Size = New System.Drawing.Size(142, 27)
        Me.txtRCosto.TabIndex = 3
        Me.txtRCosto.Text = "0"
        '
        'txtRNombre
        '
        Me.txtRNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtRNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRNombre.ForeColor = System.Drawing.Color.White
        Me.txtRNombre.Location = New System.Drawing.Point(171, 105)
        Me.txtRNombre.Name = "txtRNombre"
        Me.txtRNombre.Size = New System.Drawing.Size(142, 27)
        Me.txtRNombre.TabIndex = 1
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.White
        Me.lblCantidad.Location = New System.Drawing.Point(42, 140)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(91, 21)
        Me.lblCantidad.TabIndex = 63
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCosto.ForeColor = System.Drawing.Color.White
        Me.lblCosto.Location = New System.Drawing.Point(42, 174)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(60, 21)
        Me.lblCosto.TabIndex = 62
        Me.lblCosto.Text = "Costo:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(42, 108)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(77, 21)
        Me.lblNombre.TabIndex = 60
        Me.lblNombre.Text = "Nombre:"
        '
        'FrmRegistroRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 300)
        Me.Controls.Add(Me.lblRegistroRepuesto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRCosto)
        Me.Controls.Add(Me.txtRNombre)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.nudRCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroRepuesto"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Repuesto"
        CType(Me.nudRCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nudRCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblRegistroRepuesto As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnRRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnRCancelar As System.Windows.Forms.Button
    Friend WithEvents txtRCosto As System.Windows.Forms.TextBox
    Friend WithEvents txtRNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
End Class
