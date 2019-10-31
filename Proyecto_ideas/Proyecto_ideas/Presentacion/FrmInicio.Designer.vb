<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.plSistema = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnCambiarPass = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblHoraFecha = New System.Windows.Forms.Label()
        Me.timerHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.btnProductividad = New System.Windows.Forms.Button()
        Me.btnRepuesto = New System.Windows.Forms.Button()
        Me.btnOrden = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.plSistema.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plSistema
        '
        Me.plSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.plSistema.Controls.Add(Me.btnLogout)
        Me.plSistema.Controls.Add(Me.btnCambiarPass)
        Me.plSistema.Controls.Add(Me.btnAbout)
        Me.plSistema.Controls.Add(Me.btnExit)
        Me.plSistema.Controls.Add(Me.lblNombre)
        Me.plSistema.Dock = System.Windows.Forms.DockStyle.Top
        Me.plSistema.Location = New System.Drawing.Point(0, 0)
        Me.plSistema.Name = "plSistema"
        Me.plSistema.Size = New System.Drawing.Size(624, 69)
        Me.plSistema.TabIndex = 5
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.Ideas.My.Resources.Resources.logout
        Me.btnLogout.Location = New System.Drawing.Point(514, 12)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(46, 46)
        Me.btnLogout.TabIndex = 7
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnCambiarPass
        '
        Me.btnCambiarPass.FlatAppearance.BorderSize = 0
        Me.btnCambiarPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnCambiarPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnCambiarPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarPass.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambiarPass.ForeColor = System.Drawing.Color.White
        Me.btnCambiarPass.Image = Global.Ideas.My.Resources.Resources.key
        Me.btnCambiarPass.Location = New System.Drawing.Point(410, 12)
        Me.btnCambiarPass.Name = "btnCambiarPass"
        Me.btnCambiarPass.Size = New System.Drawing.Size(46, 46)
        Me.btnCambiarPass.TabIndex = 5
        Me.btnCambiarPass.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.Ideas.My.Resources.Resources.exclamation
        Me.btnAbout.Location = New System.Drawing.Point(462, 12)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(46, 46)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Global.Ideas.My.Resources.Resources.poweroff
        Me.btnExit.Location = New System.Drawing.Point(566, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 46)
        Me.btnExit.TabIndex = 8
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.White
        Me.lblNombre.Location = New System.Drawing.Point(27, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(98, 22)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "[Nombre]"
        '
        'lblHoraFecha
        '
        Me.lblHoraFecha.AutoSize = True
        Me.lblHoraFecha.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFecha.ForeColor = System.Drawing.Color.White
        Me.lblHoraFecha.Location = New System.Drawing.Point(412, 86)
        Me.lblHoraFecha.Name = "lblHoraFecha"
        Me.lblHoraFecha.Size = New System.Drawing.Size(126, 22)
        Me.lblHoraFecha.TabIndex = 1
        Me.lblHoraFecha.Text = "[HoraFecha]"
        Me.lblHoraFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'timerHoraFecha
        '
        '
        'btnUsuario
        '
        Me.btnUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Image = Global.Ideas.My.Resources.Resources.employees
        Me.btnUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUsuario.Location = New System.Drawing.Point(31, 126)
        Me.btnUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(136, 105)
        Me.btnUsuario.TabIndex = 1
        Me.btnUsuario.Text = "Usuarios"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'btnProductividad
        '
        Me.btnProductividad.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnProductividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductividad.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductividad.ForeColor = System.Drawing.Color.White
        Me.btnProductividad.Image = Global.Ideas.My.Resources.Resources.resources
        Me.btnProductividad.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnProductividad.Location = New System.Drawing.Point(451, 126)
        Me.btnProductividad.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProductividad.Name = "btnProductividad"
        Me.btnProductividad.Size = New System.Drawing.Size(136, 105)
        Me.btnProductividad.TabIndex = 4
        Me.btnProductividad.Text = "Productividad"
        Me.btnProductividad.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnProductividad.UseVisualStyleBackColor = False
        '
        'btnRepuesto
        '
        Me.btnRepuesto.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnRepuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepuesto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepuesto.ForeColor = System.Drawing.Color.White
        Me.btnRepuesto.Image = Global.Ideas.My.Resources.Resources.smartphone
        Me.btnRepuesto.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRepuesto.Location = New System.Drawing.Point(311, 126)
        Me.btnRepuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRepuesto.Name = "btnRepuesto"
        Me.btnRepuesto.Size = New System.Drawing.Size(136, 105)
        Me.btnRepuesto.TabIndex = 3
        Me.btnRepuesto.Text = "Repuestos"
        Me.btnRepuesto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRepuesto.UseVisualStyleBackColor = False
        '
        'btnOrden
        '
        Me.btnOrden.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrden.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrden.ForeColor = System.Drawing.Color.White
        Me.btnOrden.Image = Global.Ideas.My.Resources.Resources.package
        Me.btnOrden.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOrden.Location = New System.Drawing.Point(171, 126)
        Me.btnOrden.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrden.Name = "btnOrden"
        Me.btnOrden.Size = New System.Drawing.Size(136, 105)
        Me.btnOrden.TabIndex = 2
        Me.btnOrden.Text = "Ordenes"
        Me.btnOrden.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnOrden.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Ideas.My.Resources.Resources.ideasLogo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(482, 236)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 53)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(624, 301)
        Me.Controls.Add(Me.plSistema)
        Me.Controls.Add(Me.btnUsuario)
        Me.Controls.Add(Me.btnProductividad)
        Me.Controls.Add(Me.lblHoraFecha)
        Me.Controls.Add(Me.btnRepuesto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnOrden)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FrmInicio"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu_Inicio"
        Me.plSistema.ResumeLayout(False)
        Me.plSistema.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOrden As System.Windows.Forms.Button
    Friend WithEvents btnRepuesto As System.Windows.Forms.Button
    Friend WithEvents btnProductividad As System.Windows.Forms.Button
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents plSistema As System.Windows.Forms.Panel
    Friend WithEvents lblHoraFecha As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAbout As System.Windows.Forms.Button
    Friend WithEvents btnCambiarPass As System.Windows.Forms.Button
    Friend WithEvents timerHoraFecha As System.Windows.Forms.Timer
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
