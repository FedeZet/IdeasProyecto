<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificadorUsuario
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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNick = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelarR = New System.Windows.Forms.Button()
        Me.btnModificarR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCostoU = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(110, 68)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 20)
        Me.txtNombre.TabIndex = 11
        '
        'txtNick
        '
        Me.txtNick.Location = New System.Drawing.Point(110, 31)
        Me.txtNick.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(132, 20)
        Me.txtNick.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nick:"
        '
        'btnCancelarR
        '
        Me.btnCancelarR.Location = New System.Drawing.Point(167, 177)
        Me.btnCancelarR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarR.Name = "btnCancelarR"
        Me.btnCancelarR.Size = New System.Drawing.Size(63, 19)
        Me.btnCancelarR.TabIndex = 7
        Me.btnCancelarR.Text = "Cancelar"
        Me.btnCancelarR.UseVisualStyleBackColor = True
        '
        'btnModificarR
        '
        Me.btnModificarR.Location = New System.Drawing.Point(59, 177)
        Me.btnModificarR.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModificarR.Name = "btnModificarR"
        Me.btnModificarR.Size = New System.Drawing.Size(63, 19)
        Me.btnModificarR.TabIndex = 6
        Me.btnModificarR.Text = "Modificar"
        Me.btnModificarR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(110, 109)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(132, 20)
        Me.txtTelefono.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Costo:"
        '
        'txtCostoU
        '
        Me.txtCostoU.Location = New System.Drawing.Point(110, 141)
        Me.txtCostoU.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCostoU.Name = "txtCostoU"
        Me.txtCostoU.Size = New System.Drawing.Size(132, 20)
        Me.txtCostoU.TabIndex = 15
        '
        'modificadorUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 223)
        Me.Controls.Add(Me.txtCostoU)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNick)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelarR)
        Me.Controls.Add(Me.btnModificarR)
        Me.Name = "modificadorUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificadorUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNick As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarR As System.Windows.Forms.Button
    Friend WithEvents btnModificarR As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCostoU As System.Windows.Forms.TextBox
End Class
