<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImprimirOrden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmImprimirOrden))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtSim = New System.Windows.Forms.TextBox()
        Me.txtCargador = New System.Windows.Forms.TextBox()
        Me.txtTapa = New System.Windows.Forms.TextBox()
        Me.txtEstuche = New System.Windows.Forms.TextBox()
        Me.txtTMem = New System.Windows.Forms.TextBox()
        Me.txtBat = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtFalla = New System.Windows.Forms.TextBox()
        Me.txtReso = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtNSerie = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCancelarImp = New System.Windows.Forms.Button()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblPagina = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(11, 74)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(680, 17)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "_________________________________________________________________________________" & _
            "___"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(193, 460)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(403, 17)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Firma: ____________________________________________"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(581, 431)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(120, 22)
        Me.txtImporte.TabIndex = 82
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(525, 436)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 17)
        Me.Label23.TabIndex = 81
        Me.Label23.Text = "Importe:"
        '
        'txtSim
        '
        Me.txtSim.Location = New System.Drawing.Point(88, 434)
        Me.txtSim.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSim.Name = "txtSim"
        Me.txtSim.Size = New System.Drawing.Size(39, 22)
        Me.txtSim.TabIndex = 80
        '
        'txtCargador
        '
        Me.txtCargador.Location = New System.Drawing.Point(262, 405)
        Me.txtCargador.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCargador.Name = "txtCargador"
        Me.txtCargador.Size = New System.Drawing.Size(39, 22)
        Me.txtCargador.TabIndex = 79
        '
        'txtTapa
        '
        Me.txtTapa.Location = New System.Drawing.Point(262, 431)
        Me.txtTapa.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTapa.Name = "txtTapa"
        Me.txtTapa.Size = New System.Drawing.Size(39, 22)
        Me.txtTapa.TabIndex = 78
        '
        'txtEstuche
        '
        Me.txtEstuche.Location = New System.Drawing.Point(447, 410)
        Me.txtEstuche.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEstuche.Name = "txtEstuche"
        Me.txtEstuche.Size = New System.Drawing.Size(39, 22)
        Me.txtEstuche.TabIndex = 77
        '
        'txtTMem
        '
        Me.txtTMem.Location = New System.Drawing.Point(447, 436)
        Me.txtTMem.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTMem.Name = "txtTMem"
        Me.txtTMem.Size = New System.Drawing.Size(39, 22)
        Me.txtTMem.TabIndex = 76
        '
        'txtBat
        '
        Me.txtBat.Location = New System.Drawing.Point(87, 408)
        Me.txtBat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBat.Name = "txtBat"
        Me.txtBat.Size = New System.Drawing.Size(39, 22)
        Me.txtBat.TabIndex = 75
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(46, 434)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 17)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Sim:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(189, 410)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 17)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Cargador:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(211, 436)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 17)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Tapa:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(389, 410)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(63, 17)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Estuche:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(362, 436)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 17)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "T.Memoria:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(25, 408)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(57, 17)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Bateria:"
        '
        'txtFalla
        '
        Me.txtFalla.Location = New System.Drawing.Point(27, 219)
        Me.txtFalla.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.Size = New System.Drawing.Size(298, 146)
        Me.txtFalla.TabIndex = 68
        '
        'txtReso
        '
        Me.txtReso.Location = New System.Drawing.Point(392, 219)
        Me.txtReso.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReso.Multiline = True
        Me.txtReso.Name = "txtReso"
        Me.txtReso.Size = New System.Drawing.Size(286, 146)
        Me.txtReso.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(102, 200)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 17)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Falla:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(517, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 17)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Resolucion:"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(565, 134)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(100, 22)
        Me.txtPin.TabIndex = 64
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(565, 111)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(100, 22)
        Me.txtTel.TabIndex = 63
        '
        'txtNSerie
        '
        Me.txtNSerie.Location = New System.Drawing.Point(321, 134)
        Me.txtNSerie.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNSerie.Name = "txtNSerie"
        Me.txtNSerie.Size = New System.Drawing.Size(100, 22)
        Me.txtNSerie.TabIndex = 62
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(321, 111)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 22)
        Me.txtNombre.TabIndex = 61
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(77, 134)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 22)
        Me.txtModelo.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(527, 116)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 17)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Tel:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(527, 133)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Pin:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(259, 114)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 17)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Nombre :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Modelo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(259, 131)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 17)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "NSerie:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(545, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Pagina:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(545, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 17)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(545, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Hora:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 17)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "ide@s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 17)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Orden de Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "tel : 473 35191"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 17)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Lavalleja 47 Salto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Imarket S.A"
        '
        'btnCancelarImp
        '
        Me.btnCancelarImp.Location = New System.Drawing.Point(341, 488)
        Me.btnCancelarImp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelarImp.Name = "btnCancelarImp"
        Me.btnCancelarImp.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarImp.TabIndex = 46
        Me.btnCancelarImp.Text = "Cancelar"
        Me.btnCancelarImp.UseVisualStyleBackColor = True
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(77, 111)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 22)
        Me.txtOrden.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Orden:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.Gray
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(254, 488)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 43
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(594, 23)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(80, 17)
        Me.lblFecha.TabIndex = 85
        Me.lblFecha.Text = "00/00/0000"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(594, 40)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(44, 17)
        Me.lblHora.TabIndex = 86
        Me.lblHora.Text = "00:00"
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Location = New System.Drawing.Point(607, 57)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(16, 17)
        Me.lblPagina.TabIndex = 87
        Me.lblPagina.Text = "1"
        '
        'FrmImprimirOrden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 538)
        Me.Controls.Add(Me.lblPagina)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.txtSim)
        Me.Controls.Add(Me.txtCargador)
        Me.Controls.Add(Me.txtTapa)
        Me.Controls.Add(Me.txtEstuche)
        Me.Controls.Add(Me.txtTMem)
        Me.Controls.Add(Me.txtBat)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtFalla)
        Me.Controls.Add(Me.txtReso)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtNSerie)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancelarImp)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmImprimirOrden"
        Me.Text = "ImprimirOrden"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtSim As System.Windows.Forms.TextBox
    Friend WithEvents txtCargador As System.Windows.Forms.TextBox
    Friend WithEvents txtTapa As System.Windows.Forms.TextBox
    Friend WithEvents txtEstuche As System.Windows.Forms.TextBox
    Friend WithEvents txtTMem As System.Windows.Forms.TextBox
    Friend WithEvents txtBat As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtFalla As System.Windows.Forms.TextBox
    Friend WithEvents txtReso As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPin As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarImp As System.Windows.Forms.Button
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblPagina As System.Windows.Forms.Label
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
End Class
