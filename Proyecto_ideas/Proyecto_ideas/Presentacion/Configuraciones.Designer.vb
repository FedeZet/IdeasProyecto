<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuraciones
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
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(12, 12)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(75, 23)
        Me.btnVolverOrdenesLista.TabIndex = 2
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'Configuraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Name = "Configuraciones"
        Me.Text = "Configuraciones"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
End Class
