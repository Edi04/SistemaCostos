<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AltaTrasportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AltaTrasportes))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelP_Servicio = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Btn_guardarmarca = New System.Windows.Forms.Button()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.TextBox_marca = New System.Windows.Forms.TextBox()
        Me.btn_ventanita_close = New System.Windows.Forms.PictureBox()
        Me.Btn_nueva_marca = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.PictureBox()
        Me.btn_xml = New System.Windows.Forms.PictureBox()
        Me.btn_pdf = New System.Windows.Forms.PictureBox()
        Me.TextOC = New System.Windows.Forms.TextBox()
        Me.txtCargaKG = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextMAACtivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboMarca = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnGuardarFac = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextDAcumulada = New System.Windows.Forms.TextBox()
        Me.TextAno = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextModelo = New System.Windows.Forms.TextBox()
        Me.TextM_CDEp = New System.Windows.Forms.TextBox()
        Me.TextPlacas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextNserie = New System.Windows.Forms.TextBox()
        Me.TextNseguro = New System.Windows.Forms.TextBox()
        Me.TextMdAcumu = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextMoMaxDed = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextPnDeducible = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Textdepreciacion = New System.Windows.Forms.TextBox()
        Me.TextMoInversion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.codigotrasport = New System.Windows.Forms.Label()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MostrarTrasportes = New NucleosAve.mostrarTrasportes()
        Me.TBTrasportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TB_TrasportesTableAdapter = New NucleosAve.mostrarTrasportesTableAdapters.TB_TrasportesTableAdapter()
        Me.SISUT020DataSet3 = New NucleosAve.SISUT020DataSet3()
        Me.SPMostrarTrasportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_MostrarTrasportesTableAdapter = New NucleosAve.SISUT020DataSet3TableAdapters.SP_MostrarTrasportesTableAdapter()
        Me.DataGridViewtrasport = New System.Windows.Forms.DataGridView()
        Me.btn_Todos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_Limpiar = New System.Windows.Forms.Button()
        Me.text_xml = New System.Windows.Forms.TextBox()
        Me.textpdf = New System.Windows.Forms.TextBox()
        Me.Text_Url_Pdf = New System.Windows.Forms.TextBox()
        Me.Text_Url_Xml = New System.Windows.Forms.TextBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelP_Servicio.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_ventanita_close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_xml, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MostrarTrasportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBTrasportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISUT020DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPMostrarTrasportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewtrasport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(877, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 108
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(933, 1)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 107
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(454, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 15)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Trasportes"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Btn_nueva_marca)
        Me.Panel1.Controls.Add(Me.btn_Buscar)
        Me.Panel1.Controls.Add(Me.btn_xml)
        Me.Panel1.Controls.Add(Me.btn_pdf)
        Me.Panel1.Controls.Add(Me.TextOC)
        Me.Panel1.Controls.Add(Me.txtCargaKG)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.TextTipo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextMAACtivo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.ComboMarca)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.BtnGuardarFac)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextDAcumulada)
        Me.Panel1.Controls.Add(Me.TextAno)
        Me.Panel1.Controls.Add(Me.btn_modificar)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextModelo)
        Me.Panel1.Controls.Add(Me.TextM_CDEp)
        Me.Panel1.Controls.Add(Me.TextPlacas)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TextNserie)
        Me.Panel1.Controls.Add(Me.TextNseguro)
        Me.Panel1.Controls.Add(Me.TextMdAcumu)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.TextMoMaxDed)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TextPnDeducible)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Textdepreciacion)
        Me.Panel1.Controls.Add(Me.TextMoInversion)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(12, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 531)
        Me.Panel1.TabIndex = 112
        '
        'PanelP_Servicio
        '
        Me.PanelP_Servicio.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.PanelP_Servicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelP_Servicio.Controls.Add(Me.PictureBox2)
        Me.PanelP_Servicio.Controls.Add(Me.Btn_guardarmarca)
        Me.PanelP_Servicio.Controls.Add(Me.Label43)
        Me.PanelP_Servicio.Controls.Add(Me.Label42)
        Me.PanelP_Servicio.Controls.Add(Me.TextBox_marca)
        Me.PanelP_Servicio.Controls.Add(Me.btn_ventanita_close)
        Me.PanelP_Servicio.Location = New System.Drawing.Point(484, 204)
        Me.PanelP_Servicio.Name = "PanelP_Servicio"
        Me.PanelP_Servicio.Size = New System.Drawing.Size(342, 133)
        Me.PanelP_Servicio.TabIndex = 214
        Me.PanelP_Servicio.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.PictureBox2.Location = New System.Drawing.Point(297, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 41)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 196
        Me.PictureBox2.TabStop = False
        '
        'Btn_guardarmarca
        '
        Me.Btn_guardarmarca.BackColor = System.Drawing.Color.SpringGreen
        Me.Btn_guardarmarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_guardarmarca.Location = New System.Drawing.Point(131, 92)
        Me.Btn_guardarmarca.Name = "Btn_guardarmarca"
        Me.Btn_guardarmarca.Size = New System.Drawing.Size(85, 30)
        Me.Btn_guardarmarca.TabIndex = 214
        Me.Btn_guardarmarca.Text = "Guardar"
        Me.Btn_guardarmarca.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.Transparent
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label43.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label43.Location = New System.Drawing.Point(113, 10)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(91, 15)
        Me.Label43.TabIndex = 195
        Me.Label43.Text = "Nueva Marca"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label42.Location = New System.Drawing.Point(73, 46)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(50, 13)
        Me.Label42.TabIndex = 214
        Me.Label42.Text = "Marca :"
        '
        'TextBox_marca
        '
        Me.TextBox_marca.Location = New System.Drawing.Point(76, 67)
        Me.TextBox_marca.Name = "TextBox_marca"
        Me.TextBox_marca.Size = New System.Drawing.Size(214, 20)
        Me.TextBox_marca.TabIndex = 196
        '
        'btn_ventanita_close
        '
        Me.btn_ventanita_close.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_ventanita_close.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ventanita_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_ventanita_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ventanita_close.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_ventanita_close.Location = New System.Drawing.Point(293, -31)
        Me.btn_ventanita_close.Name = "btn_ventanita_close"
        Me.btn_ventanita_close.Size = New System.Drawing.Size(39, 35)
        Me.btn_ventanita_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_ventanita_close.TabIndex = 195
        Me.btn_ventanita_close.TabStop = False
        '
        'Btn_nueva_marca
        '
        Me.Btn_nueva_marca.BackColor = System.Drawing.Color.SpringGreen
        Me.Btn_nueva_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_nueva_marca.Location = New System.Drawing.Point(156, 9)
        Me.Btn_nueva_marca.Name = "Btn_nueva_marca"
        Me.Btn_nueva_marca.Size = New System.Drawing.Size(31, 21)
        Me.Btn_nueva_marca.TabIndex = 207
        Me.Btn_nueva_marca.Text = "+"
        Me.Btn_nueva_marca.UseVisualStyleBackColor = False
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Buscar.Image = Global.NucleosAve.My.Resources.Resources.icons8_google_web_search_512
        Me.btn_Buscar.Location = New System.Drawing.Point(110, -12)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(28, 26)
        Me.btn_Buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Buscar.TabIndex = 188
        Me.btn_Buscar.TabStop = False
        Me.btn_Buscar.Visible = False
        '
        'btn_xml
        '
        Me.btn_xml.BackColor = System.Drawing.Color.Transparent
        Me.btn_xml.Image = Global.NucleosAve.My.Resources.Resources.icons8_archivo_xml_100
        Me.btn_xml.Location = New System.Drawing.Point(322, 453)
        Me.btn_xml.Name = "btn_xml"
        Me.btn_xml.Size = New System.Drawing.Size(34, 29)
        Me.btn_xml.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_xml.TabIndex = 190
        Me.btn_xml.TabStop = False
        '
        'btn_pdf
        '
        Me.btn_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btn_pdf.Image = Global.NucleosAve.My.Resources.Resources.icons8_pdf_100
        Me.btn_pdf.Location = New System.Drawing.Point(280, 453)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(36, 29)
        Me.btn_pdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pdf.TabIndex = 189
        Me.btn_pdf.TabStop = False
        '
        'TextOC
        '
        Me.TextOC.Location = New System.Drawing.Point(20, -9)
        Me.TextOC.Name = "TextOC"
        Me.TextOC.Size = New System.Drawing.Size(84, 20)
        Me.TextOC.TabIndex = 205
        Me.TextOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextOC.Visible = False
        '
        'txtCargaKG
        '
        Me.txtCargaKG.Location = New System.Drawing.Point(20, 227)
        Me.txtCargaKG.Name = "txtCargaKG"
        Me.txtCargaKG.Size = New System.Drawing.Size(165, 20)
        Me.txtCargaKG.TabIndex = 203
        Me.txtCargaKG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label21.Location = New System.Drawing.Point(20, 204)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 16)
        Me.Label21.TabIndex = 204
        Me.Label21.Text = "Carga Kg"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label20.Location = New System.Drawing.Point(193, 405)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(172, 16)
        Me.Label20.TabIndex = 202
        Me.Label20.Text = "Monto Actual Del Activo"
        '
        'TextTipo
        '
        Me.TextTipo.Location = New System.Drawing.Point(20, 84)
        Me.TextTipo.Name = "TextTipo"
        Me.TextTipo.Size = New System.Drawing.Size(168, 20)
        Me.TextTipo.TabIndex = 184
        Me.TextTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Marca"
        '
        'TextMAACtivo
        '
        Me.TextMAACtivo.Location = New System.Drawing.Point(194, 426)
        Me.TextMAACtivo.Name = "TextMAACtivo"
        Me.TextMAACtivo.Size = New System.Drawing.Size(174, 20)
        Me.TextMAACtivo.TabIndex = 201
        Me.TextMAACtivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(17, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "Tipo"
        '
        'ComboMarca
        '
        Me.ComboMarca.FormattingEnabled = True
        Me.ComboMarca.Location = New System.Drawing.Point(20, 37)
        Me.ComboMarca.Name = "ComboMarca"
        Me.ComboMarca.Size = New System.Drawing.Size(168, 21)
        Me.ComboMarca.TabIndex = 113
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label19.Location = New System.Drawing.Point(22, 403)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 16)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "D. Acumulada"
        '
        'BtnGuardarFac
        '
        Me.BtnGuardarFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnGuardarFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarFac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardarFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarFac.Location = New System.Drawing.Point(0, 488)
        Me.BtnGuardarFac.Name = "BtnGuardarFac"
        Me.BtnGuardarFac.Size = New System.Drawing.Size(386, 45)
        Me.BtnGuardarFac.TabIndex = 183
        Me.BtnGuardarFac.Text = "Guardar"
        Me.BtnGuardarFac.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(194, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Año"
        '
        'TextDAcumulada
        '
        Me.TextDAcumulada.Location = New System.Drawing.Point(20, 424)
        Me.TextDAcumulada.Name = "TextDAcumulada"
        Me.TextDAcumulada.Size = New System.Drawing.Size(163, 20)
        Me.TextDAcumulada.TabIndex = 199
        Me.TextDAcumulada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextAno
        '
        Me.TextAno.Location = New System.Drawing.Point(194, 84)
        Me.TextAno.Name = "TextAno"
        Me.TextAno.Size = New System.Drawing.Size(174, 20)
        Me.TextAno.TabIndex = 118
        Me.TextAno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(190, 350)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 16)
        Me.Label18.TabIndex = 198
        Me.Label18.Text = "M _C de uso C/Dep"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(195, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 115
        Me.Label4.Text = "Modelo"
        '
        'TextModelo
        '
        Me.TextModelo.Location = New System.Drawing.Point(194, 38)
        Me.TextModelo.Name = "TextModelo"
        Me.TextModelo.Size = New System.Drawing.Size(174, 20)
        Me.TextModelo.TabIndex = 114
        Me.TextModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextM_CDEp
        '
        Me.TextM_CDEp.Location = New System.Drawing.Point(193, 371)
        Me.TextM_CDEp.Name = "TextM_CDEp"
        Me.TextM_CDEp.Size = New System.Drawing.Size(175, 20)
        Me.TextM_CDEp.TabIndex = 197
        Me.TextM_CDEp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextPlacas
        '
        Me.TextPlacas.Location = New System.Drawing.Point(194, 130)
        Me.TextPlacas.Name = "TextPlacas"
        Me.TextPlacas.Size = New System.Drawing.Size(174, 20)
        Me.TextPlacas.TabIndex = 120
        Me.TextPlacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(194, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Placas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(20, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "No. Serie"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(22, 350)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 16)
        Me.Label17.TabIndex = 196
        Me.Label17.Text = "M.D Acumulada"
        '
        'TextNserie
        '
        Me.TextNserie.Location = New System.Drawing.Point(20, 130)
        Me.TextNserie.Name = "TextNserie"
        Me.TextNserie.Size = New System.Drawing.Size(168, 20)
        Me.TextNserie.TabIndex = 116
        Me.TextNserie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNseguro
        '
        Me.TextNseguro.Location = New System.Drawing.Point(20, 176)
        Me.TextNseguro.Name = "TextNseguro"
        Me.TextNseguro.Size = New System.Drawing.Size(168, 20)
        Me.TextNseguro.TabIndex = 122
        Me.TextNseguro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextMdAcumu
        '
        Me.TextMdAcumu.Location = New System.Drawing.Point(20, 371)
        Me.TextMdAcumu.Name = "TextMdAcumu"
        Me.TextMdAcumu.Size = New System.Drawing.Size(163, 20)
        Me.TextMdAcumu.TabIndex = 195
        Me.TextMdAcumu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 176)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePicker1.TabIndex = 125
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(191, 301)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 16)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "M.O.I Max Ded"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(20, 276)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(165, 20)
        Me.DateTimePicker2.TabIndex = 187
        '
        'TextMoMaxDed
        '
        Me.TextMoMaxDed.Location = New System.Drawing.Point(193, 323)
        Me.TextMoMaxDed.Name = "TextMoMaxDed"
        Me.TextMoMaxDed.Size = New System.Drawing.Size(175, 20)
        Me.TextMoMaxDed.TabIndex = 193
        Me.TextMoMaxDed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(193, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 16)
        Me.Label9.TabIndex = 125
        Me.Label9.Text = "Vigencia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(22, 301)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 16)
        Me.Label15.TabIndex = 192
        Me.Label15.Text = "P.N Deducible"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(17, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 16)
        Me.Label8.TabIndex = 123
        Me.Label8.Text = "No. Seguro"
        '
        'TextPnDeducible
        '
        Me.TextPnDeducible.Location = New System.Drawing.Point(20, 323)
        Me.TextPnDeducible.Name = "TextPnDeducible"
        Me.TextPnDeducible.Size = New System.Drawing.Size(163, 20)
        Me.TextPnDeducible.TabIndex = 191
        Me.TextPnDeducible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(191, 255)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 16)
        Me.Label14.TabIndex = 190
        Me.Label14.Text = "M.O de Inversion"
        '
        'Textdepreciacion
        '
        Me.Textdepreciacion.Location = New System.Drawing.Point(194, 227)
        Me.Textdepreciacion.Name = "Textdepreciacion"
        Me.Textdepreciacion.Size = New System.Drawing.Size(174, 20)
        Me.Textdepreciacion.TabIndex = 185
        Me.Textdepreciacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextMoInversion
        '
        Me.TextMoInversion.Location = New System.Drawing.Point(193, 276)
        Me.TextMoInversion.Name = "TextMoInversion"
        Me.TextMoInversion.Size = New System.Drawing.Size(175, 20)
        Me.TextMoInversion.TabIndex = 189
        Me.TextMoInversion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(190, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(141, 16)
        Me.Label12.TabIndex = 186
        Me.Label12.Text = "Tasa Depreciacion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(22, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 16)
        Me.Label13.TabIndex = 188
        Me.Label13.Text = "Fecha Adquisiscion"
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_modificar.Location = New System.Drawing.Point(-1, 489)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(386, 45)
        Me.btn_modificar.TabIndex = 182
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        Me.btn_modificar.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(12, 27)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(173, 25)
        Me.Label11.TabIndex = 113
        Me.Label11.Text = "Nuevo Trasporte"
        '
        'codigotrasport
        '
        Me.codigotrasport.AutoSize = True
        Me.codigotrasport.BackColor = System.Drawing.Color.Transparent
        Me.codigotrasport.Location = New System.Drawing.Point(268, 47)
        Me.codigotrasport.Name = "codigotrasport"
        Me.codigotrasport.Size = New System.Drawing.Size(45, 13)
        Me.codigotrasport.TabIndex = 120
        Me.codigotrasport.Text = "Label12"
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(404, 88)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(113, 20)
        Me.TextBuscar.TabIndex = 183
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(523, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 32)
        Me.Button1.TabIndex = 184
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MostrarTrasportes
        '
        Me.MostrarTrasportes.DataSetName = "mostrarTrasportes"
        Me.MostrarTrasportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBTrasportesBindingSource
        '
        Me.TBTrasportesBindingSource.DataMember = "TB_Trasportes"
        Me.TBTrasportesBindingSource.DataSource = Me.MostrarTrasportes
        '
        'TB_TrasportesTableAdapter
        '
        Me.TB_TrasportesTableAdapter.ClearBeforeFill = True
        '
        'SISUT020DataSet3
        '
        Me.SISUT020DataSet3.DataSetName = "SISUT020DataSet3"
        Me.SISUT020DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPMostrarTrasportesBindingSource
        '
        Me.SPMostrarTrasportesBindingSource.DataMember = "SP_MostrarTrasportes"
        Me.SPMostrarTrasportesBindingSource.DataSource = Me.SISUT020DataSet3
        '
        'SP_MostrarTrasportesTableAdapter
        '
        Me.SP_MostrarTrasportesTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewtrasport
        '
        Me.DataGridViewtrasport.AllowUserToAddRows = False
        Me.DataGridViewtrasport.AllowUserToOrderColumns = True
        Me.DataGridViewtrasport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewtrasport.Location = New System.Drawing.Point(404, 119)
        Me.DataGridViewtrasport.Name = "DataGridViewtrasport"
        Me.DataGridViewtrasport.Size = New System.Drawing.Size(576, 348)
        Me.DataGridViewtrasport.TabIndex = 185
        '
        'btn_Todos
        '
        Me.btn_Todos.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_Todos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Todos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Todos.Location = New System.Drawing.Point(839, 81)
        Me.btn_Todos.Name = "btn_Todos"
        Me.btn_Todos.Size = New System.Drawing.Size(143, 32)
        Me.btn_Todos.TabIndex = 186
        Me.btn_Todos.Text = "Todos Registros"
        Me.btn_Todos.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PictureBox1.Location = New System.Drawing.Point(857, 473)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(125, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 187
        Me.PictureBox1.TabStop = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Limpiar.Location = New System.Drawing.Point(578, 492)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(191, 48)
        Me.btn_Limpiar.TabIndex = 188
        Me.btn_Limpiar.Text = "Limpiar Formulario"
        Me.btn_Limpiar.UseVisualStyleBackColor = False
        '
        'text_xml
        '
        Me.text_xml.Cursor = System.Windows.Forms.Cursors.No
        Me.text_xml.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_xml.Location = New System.Drawing.Point(645, 572)
        Me.text_xml.Name = "text_xml"
        Me.text_xml.ReadOnly = True
        Me.text_xml.Size = New System.Drawing.Size(202, 20)
        Me.text_xml.TabIndex = 192
        Me.text_xml.Visible = False
        '
        'textpdf
        '
        Me.textpdf.Cursor = System.Windows.Forms.Cursors.No
        Me.textpdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpdf.Location = New System.Drawing.Point(416, 499)
        Me.textpdf.Name = "textpdf"
        Me.textpdf.ReadOnly = True
        Me.textpdf.Size = New System.Drawing.Size(129, 20)
        Me.textpdf.TabIndex = 191
        Me.textpdf.Visible = False
        '
        'Text_Url_Pdf
        '
        Me.Text_Url_Pdf.Cursor = System.Windows.Forms.Cursors.No
        Me.Text_Url_Pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Url_Pdf.Location = New System.Drawing.Point(416, 473)
        Me.Text_Url_Pdf.Name = "Text_Url_Pdf"
        Me.Text_Url_Pdf.ReadOnly = True
        Me.Text_Url_Pdf.Size = New System.Drawing.Size(129, 20)
        Me.Text_Url_Pdf.TabIndex = 194
        Me.Text_Url_Pdf.Visible = False
        '
        'Text_Url_Xml
        '
        Me.Text_Url_Xml.Cursor = System.Windows.Forms.Cursors.No
        Me.Text_Url_Xml.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Url_Xml.Location = New System.Drawing.Point(416, 572)
        Me.Text_Url_Xml.Name = "Text_Url_Xml"
        Me.Text_Url_Xml.ReadOnly = True
        Me.Text_Url_Xml.Size = New System.Drawing.Size(223, 20)
        Me.Text_Url_Xml.TabIndex = 195
        Me.Text_Url_Xml.Visible = False
        '
        'AltaTrasportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(991, 599)
        Me.Controls.Add(Me.PanelP_Servicio)
        Me.Controls.Add(Me.Text_Url_Xml)
        Me.Controls.Add(Me.Text_Url_Pdf)
        Me.Controls.Add(Me.text_xml)
        Me.Controls.Add(Me.textpdf)
        Me.Controls.Add(Me.btn_Limpiar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Todos)
        Me.Controls.Add(Me.DataGridViewtrasport)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBuscar)
        Me.Controls.Add(Me.codigotrasport)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AltaTrasportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "¿"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelP_Servicio.ResumeLayout(False)
        Me.PanelP_Servicio.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_ventanita_close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_xml, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MostrarTrasportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBTrasportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISUT020DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPMostrarTrasportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewtrasport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboMarca As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextNseguro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextPlacas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextAno As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNserie As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextModelo As TextBox
    Friend WithEvents BtnGuardarFac As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents TextTipo As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents codigotrasport As Label
    Private WithEvents Label20 As Label
    Private WithEvents TextMAACtivo As TextBox
    Private WithEvents Label19 As Label
    Private WithEvents TextDAcumulada As TextBox
    Private WithEvents Label18 As Label
    Private WithEvents TextM_CDEp As TextBox
    Private WithEvents Label17 As Label
    Private WithEvents TextMdAcumu As TextBox
    Private WithEvents Label16 As Label
    Private WithEvents TextMoMaxDed As TextBox
    Private WithEvents Label15 As Label
    Private WithEvents TextPnDeducible As TextBox
    Private WithEvents Label14 As Label
    Private WithEvents TextMoInversion As TextBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Textdepreciacion As TextBox
    Friend WithEvents txtCargaKG As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MostrarTrasportes As mostrarTrasportes
    Friend WithEvents TBTrasportesBindingSource As BindingSource
    Friend WithEvents TB_TrasportesTableAdapter As mostrarTrasportesTableAdapters.TB_TrasportesTableAdapter
    Friend WithEvents SPMostrarTrasportesBindingSource As BindingSource
    Friend WithEvents SISUT020DataSet3 As SISUT020DataSet3
    Friend WithEvents SP_MostrarTrasportesTableAdapter As SISUT020DataSet3TableAdapters.SP_MostrarTrasportesTableAdapter
    Friend WithEvents DataGridViewtrasport As DataGridView
    Friend WithEvents btn_Todos As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextOC As TextBox
    Friend WithEvents btn_Buscar As PictureBox
    Friend WithEvents btn_Limpiar As Button
    Friend WithEvents btn_xml As PictureBox
    Friend WithEvents btn_pdf As PictureBox
    Friend WithEvents text_xml As TextBox
    Friend WithEvents textpdf As TextBox
    Friend WithEvents Text_Url_Pdf As TextBox
    Friend WithEvents Text_Url_Xml As TextBox
    Friend WithEvents Btn_nueva_marca As Button
    Friend WithEvents PanelP_Servicio As Panel
    Friend WithEvents Btn_guardarmarca As Button
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents TextBox_marca As TextBox
    Friend WithEvents btn_ventanita_close As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
