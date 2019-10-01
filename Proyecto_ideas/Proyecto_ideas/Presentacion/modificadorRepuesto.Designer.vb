<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificadorRepuesto
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
        Me.SuspendLayout()
        '
        'btnModificarR
        '
        Me.btnModificarR.Location = New System.Drawing.Point(71, 102)
        Me.btnModificarR.Name = "btnModificarR"
        Me.btnModificarR.Size = New System.Drawing.Size(75, 23)
        Me.btnModificarR.TabIndex = 0
        Me.btnModificarR.Text = "Modificar"
        Me.btnModificarR.UseVisualStyleBackColor = True
        '
        'btnCancelarR
        '
        Me.btnCancelarR.Location = New System.Drawing.Point(238, 102)
        Me.btnCancelarR.Name = "btnCancelarR"
        Me.btnCancelarR.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarR.TabIndex = 1
        Me.btnCancelarR.Text = "Cancelar"
        Me.btnCancelarR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Repuesto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad:"
        '
        'txtMUnombre
        '
        Me.txtMUnombre.Location = New System.Drawing.Point(173, 12)
        Me.txtMUnombre.Name = "txtMUnombre"
        Me.txtMUnombre.Size = New System.Drawing.Size(174, 22)
        Me.txtMUnombre.TabIndex = 4
        '
        'txtMUcantidad
        '
        Me.txtMUcantidad.Location = New System.Drawing.Point(112, 55)
        Me.txtMUcantidad.Name = "txtMUcantidad"
        Me.txtMUcantidad.Size = New System.Drawing.Size(93, 22)
        Me.txtMUcantidad.TabIndex = 5
        '
        'modificadorRepuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 151)
        Me.Controls.Add(Me.txtMUcantidad)
        Me.Controls.Add(Me.txtMUnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarR)
        Me.Controls.Add(Me.btnModificarR)
        Me.Name = "modificadorRepuesto"
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
End Class
