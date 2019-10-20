<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio_sesion
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
        Me.txtContrasenia = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.plLogo = New System.Windows.Forms.Panel()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.lshPassword = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lshUsuario = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lblIniciarSesion = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pbPassword = New System.Windows.Forms.PictureBox()
        Me.pbUsuario = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtContrasenia
        '
        Me.txtContrasenia.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContrasenia.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContrasenia.ForeColor = System.Drawing.Color.White
        Me.txtContrasenia.Location = New System.Drawing.Point(315, 141)
        Me.txtContrasenia.Name = "txtContrasenia"
        Me.txtContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtContrasenia.Size = New System.Drawing.Size(149, 24)
        Me.txtContrasenia.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(265, 222)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(130, 32)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Acceder"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.White
        Me.txtUsuario.Location = New System.Drawing.Point(313, 73)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(149, 24)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.Tag = ""
        '
        'plLogo
        '
        Me.plLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.plLogo.Dock = System.Windows.Forms.DockStyle.Left
        Me.plLogo.Location = New System.Drawing.Point(0, 0)
        Me.plLogo.Name = "plLogo"
        Me.plLogo.Size = New System.Drawing.Size(220, 280)
        Me.plLogo.TabIndex = 5
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.lshPassword, Me.lshUsuario})
        Me.ShapeContainer1.Size = New System.Drawing.Size(500, 280)
        Me.ShapeContainer1.TabIndex = 6
        Me.ShapeContainer1.TabStop = False
        '
        'lshPassword
        '
        Me.lshPassword.BorderColor = System.Drawing.Color.White
        Me.lshPassword.Enabled = False
        Me.lshPassword.Name = "lshPassword"
        Me.lshPassword.X1 = 314
        Me.lshPassword.X2 = 464
        Me.lshPassword.Y1 = 167
        Me.lshPassword.Y2 = 167
        '
        'lshUsuario
        '
        Me.lshUsuario.BorderColor = System.Drawing.Color.White
        Me.lshUsuario.Enabled = False
        Me.lshUsuario.Name = "lshUsuario"
        Me.lshUsuario.X1 = 313
        Me.lshUsuario.X2 = 463
        Me.lshUsuario.Y1 = 99
        Me.lshUsuario.Y2 = 99
        '
        'lblIniciarSesion
        '
        Me.lblIniciarSesion.AutoSize = True
        Me.lblIniciarSesion.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.lblIniciarSesion.ForeColor = System.Drawing.Color.White
        Me.lblIniciarSesion.Location = New System.Drawing.Point(290, 20)
        Me.lblIniciarSesion.Name = "lblIniciarSesion"
        Me.lblIniciarSesion.Size = New System.Drawing.Size(134, 24)
        Me.lblIniciarSesion.TabIndex = 1
        Me.lblIniciarSesion.Text = "Iniciar sesión"
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Image = Global.Proyecto_ideas.My.Resources.Resources.logout
        Me.btnExit.Location = New System.Drawing.Point(419, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(46, 46)
        Me.btnExit.TabIndex = 4
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pbPassword
        '
        Me.pbPassword.Image = Global.Proyecto_ideas.My.Resources.Resources.password
        Me.pbPassword.Location = New System.Drawing.Point(265, 136)
        Me.pbPassword.Name = "pbPassword"
        Me.pbPassword.Size = New System.Drawing.Size(32, 32)
        Me.pbPassword.TabIndex = 9
        Me.pbPassword.TabStop = False
        '
        'pbUsuario
        '
        Me.pbUsuario.Image = Global.Proyecto_ideas.My.Resources.Resources.avatar
        Me.pbUsuario.Location = New System.Drawing.Point(265, 67)
        Me.pbUsuario.Name = "pbUsuario"
        Me.pbUsuario.Size = New System.Drawing.Size(32, 32)
        Me.pbUsuario.TabIndex = 8
        Me.pbUsuario.TabStop = False
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblError.Image = Global.Proyecto_ideas.My.Resources.Resources.cancel
        Me.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblError.Location = New System.Drawing.Point(243, 189)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 17)
        Me.lblError.TabIndex = 10
        '
        'Inicio_sesion
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(500, 280)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.pbPassword)
        Me.Controls.Add(Me.pbUsuario)
        Me.Controls.Add(Me.lblIniciarSesion)
        Me.Controls.Add(Me.plLogo)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtContrasenia)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Inicio_sesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio sesión"
        CType(Me.pbPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtContrasenia As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents plLogo As System.Windows.Forms.Panel
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lshUsuario As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lshPassword As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lblIniciarSesion As System.Windows.Forms.Label
    Friend WithEvents pbUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents pbPassword As System.Windows.Forms.PictureBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label
End Class
