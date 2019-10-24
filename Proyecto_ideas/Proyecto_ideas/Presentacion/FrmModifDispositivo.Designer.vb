<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifDispositivo
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
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.chbMemoria = New System.Windows.Forms.CheckBox()
        Me.chbEstuche = New System.Windows.Forms.CheckBox()
        Me.chbTapa = New System.Windows.Forms.CheckBox()
        Me.chbCargador = New System.Windows.Forms.CheckBox()
        Me.chbSIM = New System.Windows.Forms.CheckBox()
        Me.chbBateria = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIDCli = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.btnCancelarD = New System.Windows.Forms.Button()
        Me.btnModificarD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(183, 273)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(195, 20)
        Me.txtPIN.TabIndex = 45
        '
        'chbMemoria
        '
        Me.chbMemoria.AutoSize = True
        Me.chbMemoria.Location = New System.Drawing.Point(183, 237)
        Me.chbMemoria.Name = "chbMemoria"
        Me.chbMemoria.Size = New System.Drawing.Size(15, 14)
        Me.chbMemoria.TabIndex = 44
        Me.chbMemoria.UseVisualStyleBackColor = True
        '
        'chbEstuche
        '
        Me.chbEstuche.AutoSize = True
        Me.chbEstuche.Location = New System.Drawing.Point(183, 201)
        Me.chbEstuche.Name = "chbEstuche"
        Me.chbEstuche.Size = New System.Drawing.Size(15, 14)
        Me.chbEstuche.TabIndex = 43
        Me.chbEstuche.UseVisualStyleBackColor = True
        '
        'chbTapa
        '
        Me.chbTapa.AutoSize = True
        Me.chbTapa.Location = New System.Drawing.Point(183, 166)
        Me.chbTapa.Name = "chbTapa"
        Me.chbTapa.Size = New System.Drawing.Size(15, 14)
        Me.chbTapa.TabIndex = 42
        Me.chbTapa.UseVisualStyleBackColor = True
        '
        'chbCargador
        '
        Me.chbCargador.AutoSize = True
        Me.chbCargador.Location = New System.Drawing.Point(183, 130)
        Me.chbCargador.Name = "chbCargador"
        Me.chbCargador.Size = New System.Drawing.Size(15, 14)
        Me.chbCargador.TabIndex = 41
        Me.chbCargador.UseVisualStyleBackColor = True
        '
        'chbSIM
        '
        Me.chbSIM.AutoSize = True
        Me.chbSIM.Location = New System.Drawing.Point(183, 95)
        Me.chbSIM.Name = "chbSIM"
        Me.chbSIM.Size = New System.Drawing.Size(15, 14)
        Me.chbSIM.TabIndex = 40
        Me.chbSIM.UseVisualStyleBackColor = True
        '
        'chbBateria
        '
        Me.chbBateria.AutoSize = True
        Me.chbBateria.Location = New System.Drawing.Point(183, 60)
        Me.chbBateria.Name = "chbBateria"
        Me.chbBateria.Size = New System.Drawing.Size(15, 14)
        Me.chbBateria.TabIndex = 39
        Me.chbBateria.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 308)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "ID Cli."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "PIN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "T. Memoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Estuche"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Tapa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Cargador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "SIM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Bateria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Modelo"
        '
        'txtIDCli
        '
        Me.txtIDCli.Location = New System.Drawing.Point(183, 308)
        Me.txtIDCli.Name = "txtIDCli"
        Me.txtIDCli.Size = New System.Drawing.Size(195, 20)
        Me.txtIDCli.TabIndex = 29
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(183, 24)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(195, 20)
        Me.txtModelo.TabIndex = 28
        '
        'btnCancelarD
        '
        Me.btnCancelarD.Location = New System.Drawing.Point(183, 337)
        Me.btnCancelarD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarD.Name = "btnCancelarD"
        Me.btnCancelarD.Size = New System.Drawing.Size(71, 29)
        Me.btnCancelarD.TabIndex = 47
        Me.btnCancelarD.Text = "Cancelar"
        Me.btnCancelarD.UseVisualStyleBackColor = True
        '
        'btnModificarD
        '
        Me.btnModificarD.Location = New System.Drawing.Point(26, 337)
        Me.btnModificarD.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarD.Name = "btnModificarD"
        Me.btnModificarD.Size = New System.Drawing.Size(71, 29)
        Me.btnModificarD.TabIndex = 46
        Me.btnModificarD.Text = "Modificar"
        Me.btnModificarD.UseVisualStyleBackColor = True
        '
        'modificadorDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 403)
        Me.Controls.Add(Me.btnCancelarD)
        Me.Controls.Add(Me.btnModificarD)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.chbMemoria)
        Me.Controls.Add(Me.chbEstuche)
        Me.Controls.Add(Me.chbTapa)
        Me.Controls.Add(Me.chbCargador)
        Me.Controls.Add(Me.chbSIM)
        Me.Controls.Add(Me.chbBateria)
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
        Me.Name = "modificadorDispositivo"
        Me.Text = "modificadorDispositivo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPIN As System.Windows.Forms.TextBox
    Friend WithEvents chbMemoria As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstuche As System.Windows.Forms.CheckBox
    Friend WithEvents chbTapa As System.Windows.Forms.CheckBox
    Friend WithEvents chbCargador As System.Windows.Forms.CheckBox
    Friend WithEvents chbSIM As System.Windows.Forms.CheckBox
    Friend WithEvents chbBateria As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDCli As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelarD As System.Windows.Forms.Button
    Friend WithEvents btnModificarD As System.Windows.Forms.Button
End Class
