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
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lblHora2 = New System.Windows.Forms.Label()
        Me.lblfecha2 = New System.Windows.Forms.Label()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtSim2 = New System.Windows.Forms.TextBox()
        Me.txtCarga2 = New System.Windows.Forms.TextBox()
        Me.txtTapa2 = New System.Windows.Forms.TextBox()
        Me.txtEstuche2 = New System.Windows.Forms.TextBox()
        Me.txtTMem2 = New System.Windows.Forms.TextBox()
        Me.txtBat2 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtFalla2 = New System.Windows.Forms.TextBox()
        Me.txtRes2 = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txtPin2 = New System.Windows.Forms.TextBox()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.PrintDialog2 = New System.Windows.Forms.PrintDialog()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txtNombre2 = New System.Windows.Forms.TextBox()
        Me.txtModelo2 = New System.Windows.Forms.TextBox()
        Me.txtOrden2 = New System.Windows.Forms.TextBox()
        Me.txtImp2 = New System.Windows.Forms.TextBox()
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
        Me.Label25.Location = New System.Drawing.Point(43, 60)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(511, 13)
        Me.Label25.TabIndex = 84
        Me.Label25.Text = "_________________________________________________________________________________" & _
            "___"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(190, 352)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(302, 13)
        Me.Label24.TabIndex = 83
        Me.Label24.Text = "Firma: ____________________________________________"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(484, 300)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(100, 20)
        Me.txtImporte.TabIndex = 82
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(435, 306)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(45, 13)
        Me.Label23.TabIndex = 81
        Me.Label23.Text = "Importe:"
        '
        'txtSim
        '
        Me.txtSim.Location = New System.Drawing.Point(114, 303)
        Me.txtSim.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSim.Name = "txtSim"
        Me.txtSim.Size = New System.Drawing.Size(30, 20)
        Me.txtSim.TabIndex = 80
        '
        'txtCargador
        '
        Me.txtCargador.Location = New System.Drawing.Point(244, 279)
        Me.txtCargador.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCargador.Name = "txtCargador"
        Me.txtCargador.Size = New System.Drawing.Size(30, 20)
        Me.txtCargador.TabIndex = 79
        '
        'txtTapa
        '
        Me.txtTapa.Location = New System.Drawing.Point(244, 300)
        Me.txtTapa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTapa.Name = "txtTapa"
        Me.txtTapa.Size = New System.Drawing.Size(30, 20)
        Me.txtTapa.TabIndex = 78
        '
        'txtEstuche
        '
        Me.txtEstuche.Location = New System.Drawing.Point(383, 283)
        Me.txtEstuche.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstuche.Name = "txtEstuche"
        Me.txtEstuche.Size = New System.Drawing.Size(30, 20)
        Me.txtEstuche.TabIndex = 77
        '
        'txtTMem
        '
        Me.txtTMem.Location = New System.Drawing.Point(383, 304)
        Me.txtTMem.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTMem.Name = "txtTMem"
        Me.txtTMem.Size = New System.Drawing.Size(30, 20)
        Me.txtTMem.TabIndex = 76
        '
        'txtBat
        '
        Me.txtBat.Location = New System.Drawing.Point(113, 282)
        Me.txtBat.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBat.Name = "txtBat"
        Me.txtBat.Size = New System.Drawing.Size(30, 20)
        Me.txtBat.TabIndex = 75
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(82, 303)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Sim:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(190, 283)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 73
        Me.Label21.Text = "Cargador:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(206, 304)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Tapa:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(326, 289)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 71
        Me.Label19.Text = "Estuche:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(320, 304)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 70
        Me.Label18.Text = "T.Memoria:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(67, 282)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 13)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Bateria:"
        '
        'txtFalla
        '
        Me.txtFalla.Location = New System.Drawing.Point(64, 155)
        Me.txtFalla.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFalla.Multiline = True
        Me.txtFalla.Name = "txtFalla"
        Me.txtFalla.Size = New System.Drawing.Size(224, 119)
        Me.txtFalla.TabIndex = 68
        '
        'txtReso
        '
        Me.txtReso.Location = New System.Drawing.Point(338, 155)
        Me.txtReso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReso.Multiline = True
        Me.txtReso.Name = "txtReso"
        Me.txtReso.Size = New System.Drawing.Size(216, 119)
        Me.txtReso.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(120, 139)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Falla:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(432, 139)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Resolucion:"
        '
        'txtPin
        '
        Me.txtPin.Location = New System.Drawing.Point(459, 109)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(76, 20)
        Me.txtPin.TabIndex = 64
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(459, 90)
        Me.txtTel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(76, 20)
        Me.txtTel.TabIndex = 63
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(276, 90)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(137, 20)
        Me.txtNombre.TabIndex = 61
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(93, 109)
        Me.txtModelo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo.TabIndex = 60
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(430, 94)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Tel:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(430, 108)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Pin:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(221, 93)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Nombre :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(44, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Modelo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(444, 46)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Pagina:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(444, 19)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Fecha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(444, 32)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Hora:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(267, 32)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "ide@s"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(242, 46)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Orden de Servicio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "tel : 473 35191"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Lavalleja 47 Salto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Imarket S.A"
        '
        'btnCancelarImp
        '
        Me.btnCancelarImp.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelarImp.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCancelarImp.FlatAppearance.BorderSize = 0
        Me.btnCancelarImp.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnCancelarImp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnCancelarImp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCancelarImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarImp.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelarImp.Location = New System.Drawing.Point(306, 9)
        Me.btnCancelarImp.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelarImp.Name = "btnCancelarImp"
        Me.btnCancelarImp.Size = New System.Drawing.Size(56, 19)
        Me.btnCancelarImp.TabIndex = 46
        Me.btnCancelarImp.Text = "Cancelar"
        Me.btnCancelarImp.UseVisualStyleBackColor = True
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(93, 90)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Orden:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.ForeColor = System.Drawing.Color.White
        Me.btnImprimir.Location = New System.Drawing.Point(240, 9)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(56, 19)
        Me.btnImprimir.TabIndex = 43
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(481, 19)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(65, 13)
        Me.lblFecha.TabIndex = 85
        Me.lblFecha.Text = "00/00/0000"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Location = New System.Drawing.Point(481, 32)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(34, 13)
        Me.lblHora.TabIndex = 86
        Me.lblHora.Text = "00:00"
        '
        'lblPagina
        '
        Me.lblPagina.AutoSize = True
        Me.lblPagina.Location = New System.Drawing.Point(490, 46)
        Me.lblPagina.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPagina.Name = "lblPagina"
        Me.lblPagina.Size = New System.Drawing.Size(13, 13)
        Me.lblPagina.TabIndex = 87
        Me.lblPagina.Text = "1"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(595, 788)
        Me.ShapeContainer1.TabIndex = 88
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(172, 325)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(350, 44)
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(229, 326)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(260, 13)
        Me.Label26.TabIndex = 89
        Me.Label26.Text = "-Presentar este documento para la entrega del equipo"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(229, 339)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(240, 13)
        Me.Label27.TabIndex = 90
        Me.Label27.Text = "* Importe estimado sujeto a REVISION  TECNICA"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(471, 454)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 13)
        Me.Label30.TabIndex = 135
        Me.Label30.Text = "1"
        '
        'lblHora2
        '
        Me.lblHora2.AutoSize = True
        Me.lblHora2.Location = New System.Drawing.Point(462, 440)
        Me.lblHora2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHora2.Name = "lblHora2"
        Me.lblHora2.Size = New System.Drawing.Size(34, 13)
        Me.lblHora2.TabIndex = 134
        Me.lblHora2.Text = "00:00"
        '
        'lblfecha2
        '
        Me.lblfecha2.AutoSize = True
        Me.lblfecha2.Location = New System.Drawing.Point(462, 427)
        Me.lblfecha2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfecha2.Name = "lblfecha2"
        Me.lblfecha2.Size = New System.Drawing.Size(65, 13)
        Me.lblfecha2.TabIndex = 133
        Me.lblfecha2.Text = "00/00/0000"
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(24, 468)
        Me.Label34.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(511, 13)
        Me.Label34.TabIndex = 132
        Me.Label34.Text = "_________________________________________________________________________________" & _
            "___"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(416, 714)
        Me.Label35.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(45, 13)
        Me.Label35.TabIndex = 129
        Me.Label35.Text = "Importe:"
        '
        'txtSim2
        '
        Me.txtSim2.Location = New System.Drawing.Point(95, 711)
        Me.txtSim2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSim2.Name = "txtSim2"
        Me.txtSim2.Size = New System.Drawing.Size(30, 20)
        Me.txtSim2.TabIndex = 128
        '
        'txtCarga2
        '
        Me.txtCarga2.Location = New System.Drawing.Point(225, 687)
        Me.txtCarga2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCarga2.Name = "txtCarga2"
        Me.txtCarga2.Size = New System.Drawing.Size(30, 20)
        Me.txtCarga2.TabIndex = 127
        '
        'txtTapa2
        '
        Me.txtTapa2.Location = New System.Drawing.Point(225, 708)
        Me.txtTapa2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTapa2.Name = "txtTapa2"
        Me.txtTapa2.Size = New System.Drawing.Size(30, 20)
        Me.txtTapa2.TabIndex = 126
        '
        'txtEstuche2
        '
        Me.txtEstuche2.Location = New System.Drawing.Point(364, 691)
        Me.txtEstuche2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEstuche2.Name = "txtEstuche2"
        Me.txtEstuche2.Size = New System.Drawing.Size(30, 20)
        Me.txtEstuche2.TabIndex = 125
        '
        'txtTMem2
        '
        Me.txtTMem2.Location = New System.Drawing.Point(364, 712)
        Me.txtTMem2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTMem2.Name = "txtTMem2"
        Me.txtTMem2.Size = New System.Drawing.Size(30, 20)
        Me.txtTMem2.TabIndex = 124
        '
        'txtBat2
        '
        Me.txtBat2.Location = New System.Drawing.Point(94, 690)
        Me.txtBat2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBat2.Name = "txtBat2"
        Me.txtBat2.Size = New System.Drawing.Size(30, 20)
        Me.txtBat2.TabIndex = 123
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(63, 711)
        Me.Label36.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(27, 13)
        Me.Label36.TabIndex = 122
        Me.Label36.Text = "Sim:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(171, 691)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(53, 13)
        Me.Label37.TabIndex = 121
        Me.Label37.Text = "Cargador:"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(187, 712)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 13)
        Me.Label38.TabIndex = 120
        Me.Label38.Text = "Tapa:"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(307, 697)
        Me.Label39.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(49, 13)
        Me.Label39.TabIndex = 119
        Me.Label39.Text = "Estuche:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(301, 712)
        Me.Label40.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 13)
        Me.Label40.TabIndex = 118
        Me.Label40.Text = "T.Memoria:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(48, 690)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(43, 13)
        Me.Label41.TabIndex = 117
        Me.Label41.Text = "Bateria:"
        '
        'txtFalla2
        '
        Me.txtFalla2.Location = New System.Drawing.Point(45, 563)
        Me.txtFalla2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFalla2.Multiline = True
        Me.txtFalla2.Name = "txtFalla2"
        Me.txtFalla2.Size = New System.Drawing.Size(224, 119)
        Me.txtFalla2.TabIndex = 116
        '
        'txtRes2
        '
        Me.txtRes2.Location = New System.Drawing.Point(319, 563)
        Me.txtRes2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRes2.Multiline = True
        Me.txtRes2.Name = "txtRes2"
        Me.txtRes2.Size = New System.Drawing.Size(216, 119)
        Me.txtRes2.TabIndex = 115
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(101, 547)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 13)
        Me.Label42.TabIndex = 114
        Me.Label42.Text = "Falla:"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(413, 547)
        Me.Label43.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(63, 13)
        Me.Label43.TabIndex = 113
        Me.Label43.Text = "Resolucion:"
        '
        'txtPin2
        '
        Me.txtPin2.Location = New System.Drawing.Point(440, 517)
        Me.txtPin2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPin2.Name = "txtPin2"
        Me.txtPin2.Size = New System.Drawing.Size(76, 20)
        Me.txtPin2.TabIndex = 112
        '
        'txtTel2
        '
        Me.txtTel2.Location = New System.Drawing.Point(440, 498)
        Me.txtTel2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.Size = New System.Drawing.Size(76, 20)
        Me.txtTel2.TabIndex = 111
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(411, 502)
        Me.Label44.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(25, 13)
        Me.Label44.TabIndex = 107
        Me.Label44.Text = "Tel:"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(411, 516)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(25, 13)
        Me.Label45.TabIndex = 106
        Me.Label45.Text = "Pin:"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(202, 501)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(50, 13)
        Me.Label46.TabIndex = 105
        Me.Label46.Text = "Nombre :"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(25, 514)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(45, 13)
        Me.Label47.TabIndex = 104
        Me.Label47.Text = "Modelo:"
        '
        'PrintDialog2
        '
        Me.PrintDialog2.UseEXDialog = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(425, 454)
        Me.Label49.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(43, 13)
        Me.Label49.TabIndex = 102
        Me.Label49.Text = "Pagina:"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(425, 427)
        Me.Label50.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(40, 13)
        Me.Label50.TabIndex = 101
        Me.Label50.Text = "Fecha:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(425, 440)
        Me.Label51.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(33, 13)
        Me.Label51.TabIndex = 100
        Me.Label51.Text = "Hora:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(248, 440)
        Me.Label52.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(37, 13)
        Me.Label52.TabIndex = 99
        Me.Label52.Text = "ide@s"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(223, 454)
        Me.Label53.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(92, 13)
        Me.Label53.TabIndex = 98
        Me.Label53.Text = "Orden de Servicio"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(34, 454)
        Me.Label54.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 13)
        Me.Label54.TabIndex = 97
        Me.Label54.Text = "tel : 473 35191"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(34, 440)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(91, 13)
        Me.Label55.TabIndex = 96
        Me.Label55.Text = "Lavalleja 47 Salto"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(34, 417)
        Me.Label56.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(62, 13)
        Me.Label56.TabIndex = 95
        Me.Label56.Text = "Imarket S.A"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(34, 501)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(39, 13)
        Me.Label57.TabIndex = 92
        Me.Label57.Text = "Orden:"
        '
        'txtNombre2
        '
        Me.txtNombre2.Location = New System.Drawing.Point(256, 499)
        Me.txtNombre2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre2.Name = "txtNombre2"
        Me.txtNombre2.Size = New System.Drawing.Size(137, 20)
        Me.txtNombre2.TabIndex = 136
        '
        'txtModelo2
        '
        Me.txtModelo2.Location = New System.Drawing.Point(74, 513)
        Me.txtModelo2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModelo2.Name = "txtModelo2"
        Me.txtModelo2.Size = New System.Drawing.Size(100, 20)
        Me.txtModelo2.TabIndex = 137
        '
        'txtOrden2
        '
        Me.txtOrden2.Location = New System.Drawing.Point(74, 494)
        Me.txtOrden2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtOrden2.Name = "txtOrden2"
        Me.txtOrden2.Size = New System.Drawing.Size(100, 20)
        Me.txtOrden2.TabIndex = 138
        '
        'txtImp2
        '
        Me.txtImp2.Location = New System.Drawing.Point(465, 711)
        Me.txtImp2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtImp2.Name = "txtImp2"
        Me.txtImp2.Size = New System.Drawing.Size(100, 20)
        Me.txtImp2.TabIndex = 139
        '
        'FrmImprimirOrden
        '
        Me.AcceptButton = Me.btnImprimir
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnCancelarImp
        Me.ClientSize = New System.Drawing.Size(595, 788)
        Me.Controls.Add(Me.txtImp2)
        Me.Controls.Add(Me.txtOrden2)
        Me.Controls.Add(Me.txtModelo2)
        Me.Controls.Add(Me.txtNombre2)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblHora2)
        Me.Controls.Add(Me.lblfecha2)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.txtSim2)
        Me.Controls.Add(Me.txtCarga2)
        Me.Controls.Add(Me.txtTapa2)
        Me.Controls.Add(Me.txtEstuche2)
        Me.Controls.Add(Me.txtTMem2)
        Me.Controls.Add(Me.txtBat2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.txtFalla2)
        Me.Controls.Add(Me.txtRes2)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.txtPin2)
        Me.Controls.Add(Me.txtTel2)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
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
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
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
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmImprimirOrden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents lblHora2 As System.Windows.Forms.Label
    Friend WithEvents lblfecha2 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtSim2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCarga2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTapa2 As System.Windows.Forms.TextBox
    Friend WithEvents txtEstuche2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTMem2 As System.Windows.Forms.TextBox
    Friend WithEvents txtBat2 As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtFalla2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRes2 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtPin2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog2 As System.Windows.Forms.PrintDialog
    Friend WithEvents txtOrden2 As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre2 As System.Windows.Forms.TextBox
    Friend WithEvents txtImp2 As System.Windows.Forms.TextBox
End Class
