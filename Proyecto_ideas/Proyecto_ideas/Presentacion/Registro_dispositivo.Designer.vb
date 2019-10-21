<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_dispositivo
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
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtIDCli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.chbBateria = New System.Windows.Forms.CheckBox()
        Me.chbSIM = New System.Windows.Forms.CheckBox()
        Me.chbCargador = New System.Windows.Forms.CheckBox()
        Me.chbEstuche = New System.Windows.Forms.CheckBox()
        Me.chbTapa = New System.Windows.Forms.CheckBox()
        Me.chbMemoria = New System.Windows.Forms.CheckBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(184, 25)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(195, 20)
        Me.txtModelo.TabIndex = 0
        '
        'txtIDCli
        '
        Me.txtIDCli.Location = New System.Drawing.Point(184, 309)
        Me.txtIDCli.Name = "txtIDCli"
        Me.txtIDCli.Size = New System.Drawing.Size(195, 20)
        Me.txtIDCli.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Bateria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Estuche"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tapa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cargador"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 309)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "ID Cli."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "T. Memoria"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(27, 345)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 23)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(262, 345)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(117, 23)
        Me.btnCancelar.TabIndex = 20
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'chbBateria
        '
        Me.chbBateria.AutoSize = True
        Me.chbBateria.Location = New System.Drawing.Point(184, 61)
        Me.chbBateria.Name = "chbBateria"
        Me.chbBateria.Size = New System.Drawing.Size(15, 14)
        Me.chbBateria.TabIndex = 21
        Me.chbBateria.UseVisualStyleBackColor = True
        '
        'chbSIM
        '
        Me.chbSIM.AutoSize = True
        Me.chbSIM.Location = New System.Drawing.Point(184, 96)
        Me.chbSIM.Name = "chbSIM"
        Me.chbSIM.Size = New System.Drawing.Size(15, 14)
        Me.chbSIM.TabIndex = 22
        Me.chbSIM.UseVisualStyleBackColor = True
        '
        'chbCargador
        '
        Me.chbCargador.AutoSize = True
        Me.chbCargador.Location = New System.Drawing.Point(184, 131)
        Me.chbCargador.Name = "chbCargador"
        Me.chbCargador.Size = New System.Drawing.Size(15, 14)
        Me.chbCargador.TabIndex = 23
        Me.chbCargador.UseVisualStyleBackColor = True
        '
        'chbEstuche
        '
        Me.chbEstuche.AutoSize = True
        Me.chbEstuche.Location = New System.Drawing.Point(184, 202)
        Me.chbEstuche.Name = "chbEstuche"
        Me.chbEstuche.Size = New System.Drawing.Size(15, 14)
        Me.chbEstuche.TabIndex = 25
        Me.chbEstuche.UseVisualStyleBackColor = True
        '
        'chbTapa
        '
        Me.chbTapa.AutoSize = True
        Me.chbTapa.Location = New System.Drawing.Point(184, 167)
        Me.chbTapa.Name = "chbTapa"
        Me.chbTapa.Size = New System.Drawing.Size(15, 14)
        Me.chbTapa.TabIndex = 24
        Me.chbTapa.UseVisualStyleBackColor = True
        '
        'chbMemoria
        '
        Me.chbMemoria.AutoSize = True
        Me.chbMemoria.Location = New System.Drawing.Point(184, 238)
        Me.chbMemoria.Name = "chbMemoria"
        Me.chbMemoria.Size = New System.Drawing.Size(15, 14)
        Me.chbMemoria.TabIndex = 26
        Me.chbMemoria.UseVisualStyleBackColor = True
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(184, 274)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(195, 20)
        Me.txtPIN.TabIndex = 27
        '
        'Registro_dispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 390)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.chbMemoria)
        Me.Controls.Add(Me.chbEstuche)
        Me.Controls.Add(Me.chbTapa)
        Me.Controls.Add(Me.chbCargador)
        Me.Controls.Add(Me.chbSIM)
        Me.Controls.Add(Me.chbBateria)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIDCli)
        Me.Controls.Add(Me.txtModelo)
        Me.Name = "Registro_dispositivo"
        Me.Text = "Registro_dispositivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtIDCli As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents chbBateria As System.Windows.Forms.CheckBox
    Friend WithEvents chbSIM As System.Windows.Forms.CheckBox
    Friend WithEvents chbCargador As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstuche As System.Windows.Forms.CheckBox
    Friend WithEvents chbTapa As System.Windows.Forms.CheckBox
    Friend WithEvents chbMemoria As System.Windows.Forms.CheckBox
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
End Class
