<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistroDispositivo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegistroDispositivo))
        Me.lblBateria = New System.Windows.Forms.Label()
        Me.lblSIM = New System.Windows.Forms.Label()
        Me.lblEstuche = New System.Windows.Forms.Label()
        Me.lblTapa = New System.Windows.Forms.Label()
        Me.lblCargador = New System.Windows.Forms.Label()
        Me.lblIDCli = New System.Windows.Forms.Label()
        Me.lblPIN = New System.Windows.Forms.Label()
        Me.lblTMemoria = New System.Windows.Forms.Label()
        Me.chbBateria = New System.Windows.Forms.CheckBox()
        Me.chbSIM = New System.Windows.Forms.CheckBox()
        Me.chbCargador = New System.Windows.Forms.CheckBox()
        Me.chbEstuche = New System.Windows.Forms.CheckBox()
        Me.chbTapa = New System.Windows.Forms.CheckBox()
        Me.chbMemoria = New System.Windows.Forms.CheckBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtIDCli = New System.Windows.Forms.TextBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDRegistrar = New System.Windows.Forms.Button()
        Me.btnDCancelar = New System.Windows.Forms.Button()
        Me.lblRegistroUsuario = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBateria
        '
        Me.lblBateria.AutoSize = True
        Me.lblBateria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBateria.ForeColor = System.Drawing.Color.White
        Me.lblBateria.Location = New System.Drawing.Point(35, 218)
        Me.lblBateria.Name = "lblBateria"
        Me.lblBateria.Size = New System.Drawing.Size(46, 16)
        Me.lblBateria.TabIndex = 10
        Me.lblBateria.Text = "Bateria"
        '
        'lblSIM
        '
        Me.lblSIM.AutoSize = True
        Me.lblSIM.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSIM.ForeColor = System.Drawing.Color.White
        Me.lblSIM.Location = New System.Drawing.Point(36, 253)
        Me.lblSIM.Name = "lblSIM"
        Me.lblSIM.Size = New System.Drawing.Size(28, 16)
        Me.lblSIM.TabIndex = 11
        Me.lblSIM.Text = "SIM"
        '
        'lblEstuche
        '
        Me.lblEstuche.AutoSize = True
        Me.lblEstuche.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstuche.ForeColor = System.Drawing.Color.White
        Me.lblEstuche.Location = New System.Drawing.Point(219, 218)
        Me.lblEstuche.Name = "lblEstuche"
        Me.lblEstuche.Size = New System.Drawing.Size(50, 16)
        Me.lblEstuche.TabIndex = 14
        Me.lblEstuche.Text = "Estuche"
        '
        'lblTapa
        '
        Me.lblTapa.AutoSize = True
        Me.lblTapa.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTapa.ForeColor = System.Drawing.Color.White
        Me.lblTapa.Location = New System.Drawing.Point(120, 254)
        Me.lblTapa.Name = "lblTapa"
        Me.lblTapa.Size = New System.Drawing.Size(37, 16)
        Me.lblTapa.TabIndex = 13
        Me.lblTapa.Text = "Tapa"
        '
        'lblCargador
        '
        Me.lblCargador.AutoSize = True
        Me.lblCargador.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCargador.ForeColor = System.Drawing.Color.White
        Me.lblCargador.Location = New System.Drawing.Point(120, 218)
        Me.lblCargador.Name = "lblCargador"
        Me.lblCargador.Size = New System.Drawing.Size(61, 16)
        Me.lblCargador.TabIndex = 12
        Me.lblCargador.Text = "Cargador"
        '
        'lblIDCli
        '
        Me.lblIDCli.AutoSize = True
        Me.lblIDCli.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDCli.ForeColor = System.Drawing.Color.White
        Me.lblIDCli.Location = New System.Drawing.Point(59, 167)
        Me.lblIDCli.Name = "lblIDCli"
        Me.lblIDCli.Size = New System.Drawing.Size(54, 21)
        Me.lblIDCli.TabIndex = 17
        Me.lblIDCli.Text = "ID Cli."
        '
        'lblPIN
        '
        Me.lblPIN.AutoSize = True
        Me.lblPIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPIN.ForeColor = System.Drawing.Color.White
        Me.lblPIN.Location = New System.Drawing.Point(59, 132)
        Me.lblPIN.Name = "lblPIN"
        Me.lblPIN.Size = New System.Drawing.Size(36, 21)
        Me.lblPIN.TabIndex = 16
        Me.lblPIN.Text = "PIN"
        '
        'lblTMemoria
        '
        Me.lblTMemoria.AutoSize = True
        Me.lblTMemoria.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTMemoria.ForeColor = System.Drawing.Color.White
        Me.lblTMemoria.Location = New System.Drawing.Point(219, 252)
        Me.lblTMemoria.Name = "lblTMemoria"
        Me.lblTMemoria.Size = New System.Drawing.Size(67, 16)
        Me.lblTMemoria.TabIndex = 15
        Me.lblTMemoria.Text = "T. Memoria"
        '
        'chbBateria
        '
        Me.chbBateria.AutoSize = True
        Me.chbBateria.Location = New System.Drawing.Point(87, 219)
        Me.chbBateria.Name = "chbBateria"
        Me.chbBateria.Size = New System.Drawing.Size(15, 14)
        Me.chbBateria.TabIndex = 4
        Me.chbBateria.UseVisualStyleBackColor = True
        '
        'chbSIM
        '
        Me.chbSIM.AutoSize = True
        Me.chbSIM.Location = New System.Drawing.Point(87, 254)
        Me.chbSIM.Name = "chbSIM"
        Me.chbSIM.Size = New System.Drawing.Size(15, 14)
        Me.chbSIM.TabIndex = 7
        Me.chbSIM.UseVisualStyleBackColor = True
        '
        'chbCargador
        '
        Me.chbCargador.AutoSize = True
        Me.chbCargador.Location = New System.Drawing.Point(187, 219)
        Me.chbCargador.Name = "chbCargador"
        Me.chbCargador.Size = New System.Drawing.Size(15, 14)
        Me.chbCargador.TabIndex = 5
        Me.chbCargador.UseVisualStyleBackColor = True
        '
        'chbEstuche
        '
        Me.chbEstuche.AutoSize = True
        Me.chbEstuche.Location = New System.Drawing.Point(292, 219)
        Me.chbEstuche.Name = "chbEstuche"
        Me.chbEstuche.Size = New System.Drawing.Size(15, 14)
        Me.chbEstuche.TabIndex = 6
        Me.chbEstuche.UseVisualStyleBackColor = True
        '
        'chbTapa
        '
        Me.chbTapa.AutoSize = True
        Me.chbTapa.Location = New System.Drawing.Point(187, 254)
        Me.chbTapa.Name = "chbTapa"
        Me.chbTapa.Size = New System.Drawing.Size(15, 14)
        Me.chbTapa.TabIndex = 8
        Me.chbTapa.UseVisualStyleBackColor = True
        '
        'chbMemoria
        '
        Me.chbMemoria.AutoSize = True
        Me.chbMemoria.Location = New System.Drawing.Point(292, 253)
        Me.chbMemoria.Name = "chbMemoria"
        Me.chbMemoria.Size = New System.Drawing.Size(15, 14)
        Me.chbMemoria.TabIndex = 9
        Me.chbMemoria.UseVisualStyleBackColor = True
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtModelo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.ForeColor = System.Drawing.Color.White
        Me.txtModelo.Location = New System.Drawing.Point(148, 96)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(142, 27)
        Me.txtModelo.TabIndex = 1
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.ForeColor = System.Drawing.Color.White
        Me.lblModelo.Location = New System.Drawing.Point(59, 99)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(73, 21)
        Me.lblModelo.TabIndex = 28
        Me.lblModelo.Text = "Modelo:"
        '
        'txtIDCli
        '
        Me.txtIDCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtIDCli.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDCli.ForeColor = System.Drawing.Color.White
        Me.txtIDCli.Location = New System.Drawing.Point(148, 164)
        Me.txtIDCli.Name = "txtIDCli"
        Me.txtIDCli.ReadOnly = True
        Me.txtIDCli.Size = New System.Drawing.Size(142, 27)
        Me.txtIDCli.TabIndex = 3
        '
        'txtPIN
        '
        Me.txtPIN.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtPIN.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.ForeColor = System.Drawing.Color.White
        Me.txtPIN.Location = New System.Drawing.Point(148, 129)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(142, 27)
        Me.txtPIN.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDRegistrar)
        Me.Panel1.Controls.Add(Me.btnDCancelar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(355, 57)
        Me.Panel1.TabIndex = 10
        '
        'btnDRegistrar
        '
        Me.btnDRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDRegistrar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDRegistrar.ForeColor = System.Drawing.Color.White
        Me.btnDRegistrar.Location = New System.Drawing.Point(52, 10)
        Me.btnDRegistrar.Name = "btnDRegistrar"
        Me.btnDRegistrar.Size = New System.Drawing.Size(115, 35)
        Me.btnDRegistrar.TabIndex = 10
        Me.btnDRegistrar.Text = "Registrar"
        Me.btnDRegistrar.UseVisualStyleBackColor = True
        '
        'btnDCancelar
        '
        Me.btnDCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDCancelar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDCancelar.ForeColor = System.Drawing.Color.White
        Me.btnDCancelar.Location = New System.Drawing.Point(185, 10)
        Me.btnDCancelar.Name = "btnDCancelar"
        Me.btnDCancelar.Size = New System.Drawing.Size(115, 35)
        Me.btnDCancelar.TabIndex = 11
        Me.btnDCancelar.Text = "Cancelar"
        Me.btnDCancelar.UseVisualStyleBackColor = True
        '
        'lblRegistroUsuario
        '
        Me.lblRegistroUsuario.AutoSize = True
        Me.lblRegistroUsuario.Font = New System.Drawing.Font("Century Gothic", 18.0!)
        Me.lblRegistroUsuario.ForeColor = System.Drawing.Color.White
        Me.lblRegistroUsuario.Location = New System.Drawing.Point(52, 27)
        Me.lblRegistroUsuario.Name = "lblRegistroUsuario"
        Me.lblRegistroUsuario.Size = New System.Drawing.Size(246, 30)
        Me.lblRegistroUsuario.TabIndex = 48
        Me.lblRegistroUsuario.Text = "Registrar dispositivo"
        '
        'FrmRegistroDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 350)
        Me.Controls.Add(Me.lblRegistroUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.txtIDCli)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.chbMemoria)
        Me.Controls.Add(Me.chbEstuche)
        Me.Controls.Add(Me.chbTapa)
        Me.Controls.Add(Me.chbCargador)
        Me.Controls.Add(Me.chbSIM)
        Me.Controls.Add(Me.chbBateria)
        Me.Controls.Add(Me.lblIDCli)
        Me.Controls.Add(Me.lblPIN)
        Me.Controls.Add(Me.lblTMemoria)
        Me.Controls.Add(Me.lblEstuche)
        Me.Controls.Add(Me.lblTapa)
        Me.Controls.Add(Me.lblCargador)
        Me.Controls.Add(Me.lblSIM)
        Me.Controls.Add(Me.lblBateria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmRegistroDispositivo"
        Me.Opacity = 0.98R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBateria As System.Windows.Forms.Label
    Friend WithEvents lblSIM As System.Windows.Forms.Label
    Friend WithEvents lblEstuche As System.Windows.Forms.Label
    Friend WithEvents lblTapa As System.Windows.Forms.Label
    Friend WithEvents lblCargador As System.Windows.Forms.Label
    Friend WithEvents lblIDCli As System.Windows.Forms.Label
    Friend WithEvents lblPIN As System.Windows.Forms.Label
    Friend WithEvents lblTMemoria As System.Windows.Forms.Label
    Friend WithEvents chbBateria As System.Windows.Forms.CheckBox
    Friend WithEvents chbSIM As System.Windows.Forms.CheckBox
    Friend WithEvents chbCargador As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstuche As System.Windows.Forms.CheckBox
    Friend WithEvents chbTapa As System.Windows.Forms.CheckBox
    Friend WithEvents chbMemoria As System.Windows.Forms.CheckBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents txtIDCli As System.Windows.Forms.TextBox
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnDRegistrar As System.Windows.Forms.Button
    Friend WithEvents btnDCancelar As System.Windows.Forms.Button
    Friend WithEvents lblRegistroUsuario As System.Windows.Forms.Label
End Class
