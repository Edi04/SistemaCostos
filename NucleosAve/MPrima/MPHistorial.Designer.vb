<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPHistorial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MPHistorial))
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.LCS = New System.Windows.Forms.Label()
        Me.LBOC = New System.Windows.Forms.Label()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.BBOC1 = New System.Windows.Forms.Button()
        Me.CFechas = New System.Windows.Forms.CheckBox()
        Me.DTF2 = New System.Windows.Forms.DateTimePicker()
        Me.DTF1 = New System.Windows.Forms.DateTimePicker()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DGHR = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.OCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Interno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Externo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calibre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLlegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBMPr = New System.Windows.Forms.Panel()
        Me.BPMPr = New System.Windows.Forms.PictureBox()
        Me.LPMMP = New System.Windows.Forms.Label()
        Me.BInicio = New System.Windows.Forms.Button()
        Me.PCorreo = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BMenos = New System.Windows.Forms.Button()
        Me.TxtEmail1 = New System.Windows.Forms.TextBox()
        Me.TxtEmail2 = New System.Windows.Forms.TextBox()
        Me.BE1 = New System.Windows.Forms.Button()
        Me.TxtEmail3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BHist = New System.Windows.Forms.Button()
        Me.LCorreo = New System.Windows.Forms.Label()
        Me.BExcel = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.l3 = New System.Windows.Forms.Label()
        Me.IMP = New System.Windows.Forms.Label()
        Me.LPeso = New System.Windows.Forms.Label()
        Me.LRI = New System.Windows.Forms.Label()
        Me.POpc.SuspendLayout()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGHR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PBMPr.SuspendLayout()
        CType(Me.BPMPr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCorreo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(941, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 4
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(991, 1)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 5
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Controls.Add(Me.LCS)
        Me.POpc.Location = New System.Drawing.Point(-105, 55)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(1252, 10)
        Me.POpc.TabIndex = 6
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(225, 0)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 60
        Me.LCS.Visible = False
        '
        'LBOC
        '
        Me.LBOC.AutoSize = True
        Me.LBOC.BackColor = System.Drawing.Color.Transparent
        Me.LBOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBOC.Location = New System.Drawing.Point(451, 68)
        Me.LBOC.Name = "LBOC"
        Me.LBOC.Size = New System.Drawing.Size(200, 24)
        Me.LBOC.TabIndex = 66
        Me.LBOC.Text = "Rollos en Existencia"
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.BBOC1)
        Me.GBusqueda.Controls.Add(Me.CFechas)
        Me.GBusqueda.Controls.Add(Me.DTF2)
        Me.GBusqueda.Controls.Add(Me.DTF1)
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(6, 106)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(1035, 81)
        Me.GBusqueda.TabIndex = 67
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'BBOC1
        '
        Me.BBOC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BBOC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBOC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBOC1.Location = New System.Drawing.Point(726, 56)
        Me.BBOC1.Name = "BBOC1"
        Me.BBOC1.Size = New System.Drawing.Size(75, 23)
        Me.BBOC1.TabIndex = 75
        Me.BBOC1.Text = "Buscar"
        Me.BBOC1.UseVisualStyleBackColor = False
        '
        'CFechas
        '
        Me.CFechas.AutoSize = True
        Me.CFechas.Checked = True
        Me.CFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFechas.Location = New System.Drawing.Point(682, 9)
        Me.CFechas.Name = "CFechas"
        Me.CFechas.Size = New System.Drawing.Size(165, 22)
        Me.CFechas.TabIndex = 74
        Me.CFechas.Text = "Fecha de Registro"
        Me.CFechas.UseVisualStyleBackColor = True
        '
        'DTF2
        '
        Me.DTF2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF2.Location = New System.Drawing.Point(764, 34)
        Me.DTF2.Name = "DTF2"
        Me.DTF2.Size = New System.Drawing.Size(262, 21)
        Me.DTF2.TabIndex = 73
        '
        'DTF1
        '
        Me.DTF1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF1.Location = New System.Drawing.Point(491, 34)
        Me.DTF1.Name = "DTF1"
        Me.DTF1.Size = New System.Drawing.Size(267, 21)
        Me.DTF1.TabIndex = 71
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(92, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(163, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Núm. de Rollo, Orden de Compra"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(428, 25)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(34, 37)
        Me.PBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBusqueda.TabIndex = 26
        Me.PBusqueda.TabStop = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(22, 26)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(400, 31)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'DGHR
        '
        Me.DGHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.OCompra, Me.Proveedor, Me.Num_Interno, Me.Num_Externo, Me.Calibre, Me.Ancho, Me.Peso, Me.UMedida, Me.Descripcion, Me.FechaLlegada, Me.FechaRegistro, Me.CSeguimiento})
        Me.DGHR.Location = New System.Drawing.Point(6, 193)
        Me.DGHR.Name = "DGHR"
        Me.DGHR.Size = New System.Drawing.Size(1033, 381)
        Me.DGHR.TabIndex = 68
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_MPrim"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle1
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 45
        '
        'OCompra
        '
        Me.OCompra.DataPropertyName = "OCompra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.OCompra.HeaderText = "OCompra"
        Me.OCompra.Name = "OCompra"
        Me.OCompra.Width = 60
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 380
        '
        'Num_Interno
        '
        Me.Num_Interno.DataPropertyName = "Num_Interno"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Num_Interno.DefaultCellStyle = DataGridViewCellStyle3
        Me.Num_Interno.FillWeight = 150.0!
        Me.Num_Interno.HeaderText = "Num_Interno"
        Me.Num_Interno.Name = "Num_Interno"
        Me.Num_Interno.Width = 80
        '
        'Num_Externo
        '
        Me.Num_Externo.DataPropertyName = "Num_Externo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Num_Externo.DefaultCellStyle = DataGridViewCellStyle4
        Me.Num_Externo.HeaderText = "Num_Externo"
        Me.Num_Externo.Name = "Num_Externo"
        Me.Num_Externo.Width = 80
        '
        'Calibre
        '
        Me.Calibre.DataPropertyName = "Calibre"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Calibre.DefaultCellStyle = DataGridViewCellStyle5
        Me.Calibre.HeaderText = "Calibre"
        Me.Calibre.Name = "Calibre"
        Me.Calibre.Width = 60
        '
        'Ancho
        '
        Me.Ancho.DataPropertyName = "Ancho"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Ancho.DefaultCellStyle = DataGridViewCellStyle6
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        Me.Ancho.Width = 60
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle7
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 60
        '
        'UMedida
        '
        Me.UMedida.DataPropertyName = "UMedida"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UMedida.DefaultCellStyle = DataGridViewCellStyle8
        Me.UMedida.HeaderText = "UMedida"
        Me.UMedida.Name = "UMedida"
        Me.UMedida.Width = 55
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'FechaLlegada
        '
        Me.FechaLlegada.DataPropertyName = "Fecha_Llegada"
        Me.FechaLlegada.HeaderText = "FechaLlegada"
        Me.FechaLlegada.Name = "FechaLlegada"
        '
        'FechaRegistro
        '
        Me.FechaRegistro.DataPropertyName = "Fecha_Registro"
        Me.FechaRegistro.HeaderText = "FechaRegistro"
        Me.FechaRegistro.Name = "FechaRegistro"
        '
        'CSeguimiento
        '
        Me.CSeguimiento.DataPropertyName = "CSeguimiento"
        Me.CSeguimiento.HeaderText = "CSeguimiento"
        Me.CSeguimiento.Name = "CSeguimiento"
        Me.CSeguimiento.Visible = False
        '
        'PBMPr
        '
        Me.PBMPr.BackColor = System.Drawing.Color.Transparent
        Me.PBMPr.Controls.Add(Me.BPMPr)
        Me.PBMPr.Controls.Add(Me.LPMMP)
        Me.PBMPr.Location = New System.Drawing.Point(3, 1)
        Me.PBMPr.Name = "PBMPr"
        Me.PBMPr.Size = New System.Drawing.Size(61, 85)
        Me.PBMPr.TabIndex = 69
        '
        'BPMPr
        '
        Me.BPMPr.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BPMPr.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BPMPr.BackColor = System.Drawing.Color.Transparent
        Me.BPMPr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BPMPr.Image = Global.NucleosAve.My.Resources.Resources.icons8_rollo_de_papel_para_empapelar_96
        Me.BPMPr.Location = New System.Drawing.Point(3, 2)
        Me.BPMPr.Name = "BPMPr"
        Me.BPMPr.Size = New System.Drawing.Size(55, 52)
        Me.BPMPr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BPMPr.TabIndex = 35
        Me.BPMPr.TabStop = False
        '
        'LPMMP
        '
        Me.LPMMP.AutoSize = True
        Me.LPMMP.BackColor = System.Drawing.Color.Transparent
        Me.LPMMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPMMP.ForeColor = System.Drawing.Color.Black
        Me.LPMMP.Location = New System.Drawing.Point(6, 57)
        Me.LPMMP.Name = "LPMMP"
        Me.LPMMP.Size = New System.Drawing.Size(53, 26)
        Me.LPMMP.TabIndex = 36
        Me.LPMMP.Text = "Ingresar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Material"
        '
        'BInicio
        '
        Me.BInicio.BackColor = System.Drawing.Color.Transparent
        Me.BInicio.BackgroundImage = CType(resources.GetObject("BInicio.BackgroundImage"), System.Drawing.Image)
        Me.BInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BInicio.Location = New System.Drawing.Point(92, 3)
        Me.BInicio.Name = "BInicio"
        Me.BInicio.Size = New System.Drawing.Size(50, 50)
        Me.BInicio.TabIndex = 71
        Me.BInicio.UseVisualStyleBackColor = False
        Me.BInicio.Visible = False
        '
        'PCorreo
        '
        Me.PCorreo.BackColor = System.Drawing.Color.Transparent
        Me.PCorreo.Controls.Add(Me.GroupBox2)
        Me.PCorreo.Controls.Add(Me.GroupBox1)
        Me.PCorreo.Controls.Add(Me.BHist)
        Me.PCorreo.Controls.Add(Me.LCorreo)
        Me.PCorreo.Location = New System.Drawing.Point(92, 68)
        Me.PCorreo.Name = "PCorreo"
        Me.PCorreo.Size = New System.Drawing.Size(578, 234)
        Me.PCorreo.TabIndex = 72
        Me.PCorreo.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BMenos)
        Me.GroupBox2.Controls.Add(Me.TxtEmail1)
        Me.GroupBox2.Controls.Add(Me.TxtEmail2)
        Me.GroupBox2.Controls.Add(Me.BE1)
        Me.GroupBox2.Controls.Add(Me.TxtEmail3)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 100)
        Me.GroupBox2.TabIndex = 84
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enviar a"
        '
        'BMenos
        '
        Me.BMenos.BackColor = System.Drawing.Color.Transparent
        Me.BMenos.BackgroundImage = CType(resources.GetObject("BMenos.BackgroundImage"), System.Drawing.Image)
        Me.BMenos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMenos.Location = New System.Drawing.Point(362, 48)
        Me.BMenos.Name = "BMenos"
        Me.BMenos.Size = New System.Drawing.Size(31, 28)
        Me.BMenos.TabIndex = 83
        Me.BMenos.UseVisualStyleBackColor = False
        Me.BMenos.Visible = False
        '
        'TxtEmail1
        '
        Me.TxtEmail1.Location = New System.Drawing.Point(6, 20)
        Me.TxtEmail1.Name = "TxtEmail1"
        Me.TxtEmail1.Size = New System.Drawing.Size(350, 20)
        Me.TxtEmail1.TabIndex = 77
        '
        'TxtEmail2
        '
        Me.TxtEmail2.Location = New System.Drawing.Point(6, 48)
        Me.TxtEmail2.Name = "TxtEmail2"
        Me.TxtEmail2.Size = New System.Drawing.Size(350, 20)
        Me.TxtEmail2.TabIndex = 79
        Me.TxtEmail2.Visible = False
        '
        'BE1
        '
        Me.BE1.BackColor = System.Drawing.Color.Transparent
        Me.BE1.BackgroundImage = CType(resources.GetObject("BE1.BackgroundImage"), System.Drawing.Image)
        Me.BE1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BE1.Location = New System.Drawing.Point(362, 13)
        Me.BE1.Name = "BE1"
        Me.BE1.Size = New System.Drawing.Size(31, 28)
        Me.BE1.TabIndex = 82
        Me.BE1.UseVisualStyleBackColor = False
        '
        'TxtEmail3
        '
        Me.TxtEmail3.Location = New System.Drawing.Point(6, 75)
        Me.TxtEmail3.Name = "TxtEmail3"
        Me.TxtEmail3.Size = New System.Drawing.Size(350, 20)
        Me.TxtEmail3.TabIndex = 81
        Me.TxtEmail3.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtUser)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(566, 82)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inicio de Sesión"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(383, 43)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(177, 20)
        Me.TxtPassword.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Correo Electrónico"
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(7, 43)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(350, 20)
        Me.TxtUser.TabIndex = 73
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Contraseña"
        '
        'BHist
        '
        Me.BHist.BackColor = System.Drawing.Color.Transparent
        Me.BHist.BackgroundImage = CType(resources.GetObject("BHist.BackgroundImage"), System.Drawing.Image)
        Me.BHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BHist.Location = New System.Drawing.Point(453, 154)
        Me.BHist.Name = "BHist"
        Me.BHist.Size = New System.Drawing.Size(50, 50)
        Me.BHist.TabIndex = 71
        Me.BHist.UseVisualStyleBackColor = False
        '
        'LCorreo
        '
        Me.LCorreo.AutoSize = True
        Me.LCorreo.BackColor = System.Drawing.Color.Transparent
        Me.LCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreo.Location = New System.Drawing.Point(189, 11)
        Me.LCorreo.Name = "LCorreo"
        Me.LCorreo.Size = New System.Drawing.Size(186, 24)
        Me.LCorreo.TabIndex = 67
        Me.LCorreo.Text = "Correo Electrónico"
        '
        'BExcel
        '
        Me.BExcel.BackColor = System.Drawing.Color.Transparent
        Me.BExcel.BackgroundImage = CType(resources.GetObject("BExcel.BackgroundImage"), System.Drawing.Image)
        Me.BExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BExcel.Location = New System.Drawing.Point(152, 3)
        Me.BExcel.Name = "BExcel"
        Me.BExcel.Size = New System.Drawing.Size(50, 50)
        Me.BExcel.TabIndex = 73
        Me.BExcel.UseVisualStyleBackColor = False
        Me.BExcel.Visible = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(714, 3)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 74
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Location = New System.Drawing.Point(784, 33)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(0, 13)
        Me.l3.TabIndex = 75
        '
        'IMP
        '
        Me.IMP.AutoSize = True
        Me.IMP.Location = New System.Drawing.Point(566, 20)
        Me.IMP.Name = "IMP"
        Me.IMP.Size = New System.Drawing.Size(0, 13)
        Me.IMP.TabIndex = 76
        Me.IMP.Visible = False
        '
        'LPeso
        '
        Me.LPeso.AutoSize = True
        Me.LPeso.Location = New System.Drawing.Point(585, 20)
        Me.LPeso.Name = "LPeso"
        Me.LPeso.Size = New System.Drawing.Size(0, 13)
        Me.LPeso.TabIndex = 77
        Me.LPeso.Visible = False
        '
        'LRI
        '
        Me.LRI.AutoSize = True
        Me.LRI.Location = New System.Drawing.Point(862, 37)
        Me.LRI.Name = "LRI"
        Me.LRI.Size = New System.Drawing.Size(0, 13)
        Me.LRI.TabIndex = 78
        Me.LRI.Visible = False
        '
        'MPHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1044, 586)
        Me.Controls.Add(Me.LRI)
        Me.Controls.Add(Me.LPeso)
        Me.Controls.Add(Me.IMP)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BExcel)
        Me.Controls.Add(Me.PCorreo)
        Me.Controls.Add(Me.BInicio)
        Me.Controls.Add(Me.PBMPr)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LBOC)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.DGHR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MPHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MPHistorial"
        Me.POpc.ResumeLayout(False)
        Me.POpc.PerformLayout()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGHR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PBMPr.ResumeLayout(False)
        Me.PBMPr.PerformLayout()
        CType(Me.BPMPr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCorreo.ResumeLayout(False)
        Me.PCorreo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents POpc As Panel
    Friend WithEvents LCS As Label
    Friend WithEvents LBOC As Label
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DGHR As DataGridView
    Friend WithEvents DTF1 As DateTimePicker
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents OCompra As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Num_Interno As DataGridViewTextBoxColumn
    Friend WithEvents Num_Externo As DataGridViewTextBoxColumn
    Friend WithEvents Calibre As DataGridViewTextBoxColumn
    Friend WithEvents Ancho As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents UMedida As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents FechaLlegada As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents CSeguimiento As DataGridViewTextBoxColumn
    Friend WithEvents PBMPr As Panel
    Friend WithEvents BPMPr As PictureBox
    Friend WithEvents LPMMP As Label
    Friend WithEvents CFechas As CheckBox
    Friend WithEvents DTF2 As DateTimePicker
    Friend WithEvents BBOC1 As Button
    Friend WithEvents BInicio As Button
    Friend WithEvents PCorreo As Panel
    Friend WithEvents TxtEmail3 As TextBox
    Friend WithEvents TxtEmail2 As TextBox
    Friend WithEvents TxtEmail1 As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LCorreo As Label
    Friend WithEvents BE1 As Button
    Friend WithEvents BHist As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BMenos As Button
    Friend WithEvents BExcel As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents l3 As Label
    Friend WithEvents IMP As Label
    Friend WithEvents LPeso As Label
    Friend WithEvents LRI As Label
End Class
