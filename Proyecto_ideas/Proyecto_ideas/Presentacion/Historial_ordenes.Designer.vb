<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial_ordenes
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnVolverOrdenesLista = New System.Windows.Forms.Button()
        Me.btnAgregarO = New System.Windows.Forms.Button()
        Me.btnListaImprimir = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 33)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(437, 258)
        Me.DataGridView1.TabIndex = 0
        '
        'btnVolverOrdenesLista
        '
        Me.btnVolverOrdenesLista.Location = New System.Drawing.Point(43, 331)
        Me.btnVolverOrdenesLista.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVolverOrdenesLista.Name = "btnVolverOrdenesLista"
        Me.btnVolverOrdenesLista.Size = New System.Drawing.Size(100, 28)
        Me.btnVolverOrdenesLista.TabIndex = 1
        Me.btnVolverOrdenesLista.Text = "Volver"
        Me.btnVolverOrdenesLista.UseVisualStyleBackColor = True
        '
        'btnAgregarO
        '
        Me.btnAgregarO.Location = New System.Drawing.Point(175, 330)
        Me.btnAgregarO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregarO.Name = "btnAgregarO"
        Me.btnAgregarO.Size = New System.Drawing.Size(100, 28)
        Me.btnAgregarO.TabIndex = 2
        Me.btnAgregarO.Text = "Agregar"
        Me.btnAgregarO.UseVisualStyleBackColor = True
        '
        'btnListaImprimir
        '
        Me.btnListaImprimir.Location = New System.Drawing.Point(306, 330)
        Me.btnListaImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnListaImprimir.Name = "btnListaImprimir"
        Me.btnListaImprimir.Size = New System.Drawing.Size(100, 28)
        Me.btnListaImprimir.TabIndex = 3
        Me.btnListaImprimir.Text = "Imprimir"
        Me.btnListaImprimir.UseVisualStyleBackColor = True
        '
        'Historial_ordenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 373)
        Me.Controls.Add(Me.btnListaImprimir)
        Me.Controls.Add(Me.btnAgregarO)
        Me.Controls.Add(Me.btnVolverOrdenesLista)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Historial_ordenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial_ordenes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnVolverOrdenesLista As System.Windows.Forms.Button
    Friend WithEvents btnAgregarO As System.Windows.Forms.Button
    Friend WithEvents btnListaImprimir As System.Windows.Forms.Button
End Class
