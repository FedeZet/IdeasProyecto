<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifRepuesto
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
        Me.btnModificarR = New System.Windows.Forms.Button()
        Me.btnCancelarR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMUnombre = New System.Windows.Forms.TextBox()
        Me.txtMUcantidad = New System.Windows.Forms.TextBox()
        Me.txtMCostoRep = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnModificarR
        '
        Me.btnModificarR.Location = New System.Drawing.Point(37, 127)
        Me.btnModificarR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarR.Name = "btnModificarR"
        Me.btnModificarR.Size = New System.Drawing.Size(63, 19)
        Me.btnModificarR.TabIndex = 0
        Me.btnModificarR.Text = "Modificar"
        Me.btnModificarR.UseVisualStyleBackColor = True
        '
        'btnCancelarR
        '
        Me.btnCancelarR.Location = New System.Drawing.Point(171, 127)
        Me.btnCancelarR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarR.Name = "btnCancelarR"
        Me.btnCancelarR.Size = New System.Drawing.Size(63, 19)
        Me.btnCancelarR.TabIndex = 1
        Me.btnCancelarR.Text = "Cancelar"
        Me.btnCancelarR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Repuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'txtMUnombre
        '
        Me.txtMUnombre.Location = New System.Drawing.Point(102, 11)
        Me.txtMUnombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMUnombre.Name = "txtMUnombre"
        Me.txtMUnombre.Size = New System.Drawing.Size(132, 20)
        Me.txtMUnombre.TabIndex = 4
        '
        'txtMUcantidad
        '
        Me.txtMUcantidad.Location = New System.Drawing.Point(102, 46)
        Me.txtMUcantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMUcantidad.Name = "txtMUcantidad"
        Me.txtMUcantidad.Size = New System.Drawing.Size(71, 20)
        Me.txtMUcantidad.TabIndex = 5
        '
        'txtMCostoRep
        '
        Me.txtMCostoRep.Location = New System.Drawing.Point(102, 85)
        Me.txtMCostoRep.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMCostoRep.Name = "txtMCostoRep"
        Me.txtMCostoRep.Size = New System.Drawing.Size(110, 20)
        Me.txtMCostoRep.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 88)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Costo por unidad :"
        '
        'modificadorRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(258, 157)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMCostoRep)
        Me.Controls.Add(Me.txtMUcantidad)
        Me.Controls.Add(Me.txtMUnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarR)
        Me.Controls.Add(Me.btnModificarR)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "modificadorRepuesto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificadorRepuesto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificarR As System.Windows.Forms.Button
    Friend WithEvents btnCancelarR As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMUnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtMUcantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtMCostoRep As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
