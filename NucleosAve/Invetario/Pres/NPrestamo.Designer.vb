<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NPrestamo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PLinea = New System.Windows.Forms.Panel()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.BBProducto = New System.Windows.Forms.Button()
        Me.BBTrabajador = New System.Windows.Forms.Button()
        Me.IDP = New System.Windows.Forms.Label()
        Me.IDE = New System.Windows.Forms.Label()
        Me.DTFPrestamo = New System.Windows.Forms.DateTimePicker()
        Me.DTFEntrega = New System.Windows.Forms.DateTimePicker()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.IDD = New System.Windows.Forms.Label()
        Me.TxtDSalida = New System.Windows.Forms.TextBox()
        Me.LSalidaDetalle = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNN = New System.Windows.Forms.Label()
        Me.LEntrega = New System.Windows.Forms.Label()
        Me.TxtNN = New System.Windows.Forms.TextBox()
        Me.TxtTrabajador = New System.Windows.Forms.TextBox()
        Me.LFP = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.LCalidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.PMaterial = New System.Windows.Forms.Panel()
        Me.TxtBMaterial = New System.Windows.Forms.TextBox()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.IDPP = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTrabajador = New System.Windows.Forms.Panel()
        Me.TxtBusT = New System.Windows.Forms.TextBox()
        Me.DGTrabajador = New System.Windows.Forms.DataGridView()
        Me.Id_Empleado = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Numero_Nomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTrabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNT = New System.Windows.Forms.Panel()
        Me.BRNT = New System.Windows.Forms.Button()
        Me.BGNT = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtAM = New System.Windows.Forms.TextBox()
        Me.TxtAP = New System.Windows.Forms.TextBox()
        Me.TxtNNN = New System.Windows.Forms.TextBox()
        Me.LAM = New System.Windows.Forms.Label()
        Me.LAP = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LN = New System.Windows.Forms.Label()
        Me.LT = New System.Windows.Forms.Label()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.ANuevoT = New System.Windows.Forms.Button()
        Me.BGuardarMo = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        Me.PDatos.SuspendLayout()
        Me.PMaterial.SuspendLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTrabajador.SuspendLayout()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNT.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLinea
        '
        Me.PLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PLinea.BackColor = System.Drawing.Color.SteelBlue
        Me.PLinea.Location = New System.Drawing.Point(-120, 54)
        Me.PLinea.Name = "PLinea"
        Me.PLinea.Size = New System.Drawing.Size(602, 11)
        Me.PLinea.TabIndex = 78
        '
        'PDatos
        '
        Me.PDatos.BackColor = System.Drawing.Color.Transparent
        Me.PDatos.Controls.Add(Me.BBProducto)
        Me.PDatos.Controls.Add(Me.BBTrabajador)
        Me.PDatos.Controls.Add(Me.IDP)
        Me.PDatos.Controls.Add(Me.IDE)
        Me.PDatos.Controls.Add(Me.DTFPrestamo)
        Me.PDatos.Controls.Add(Me.DTFEntrega)
        Me.PDatos.Controls.Add(Me.LUsuario)
        Me.PDatos.Controls.Add(Me.IDD)
        Me.PDatos.Controls.Add(Me.TxtDSalida)
        Me.PDatos.Controls.Add(Me.LSalidaDetalle)
        Me.PDatos.Controls.Add(Me.LDescripcion)
        Me.PDatos.Controls.Add(Me.LNN)
        Me.PDatos.Controls.Add(Me.LEntrega)
        Me.PDatos.Controls.Add(Me.TxtNN)
        Me.PDatos.Controls.Add(Me.TxtTrabajador)
        Me.PDatos.Controls.Add(Me.LFP)
        Me.PDatos.Controls.Add(Me.TxtDescripcion)
        Me.PDatos.Controls.Add(Me.LNombre)
        Me.PDatos.Controls.Add(Me.TxtMaterial)
        Me.PDatos.Controls.Add(Me.LCalidad)
        Me.PDatos.Controls.Add(Me.TxtCantidad)
        Me.PDatos.Controls.Add(Me.LMaterial)
        Me.PDatos.Location = New System.Drawing.Point(32, 128)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(306, 312)
        Me.PDatos.TabIndex = 1
        '
        'BBProducto
        '
        Me.BBProducto.BackColor = System.Drawing.Color.Transparent
        Me.BBProducto.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBProducto.Location = New System.Drawing.Point(262, 63)
        Me.BBProducto.Name = "BBProducto"
        Me.BBProducto.Size = New System.Drawing.Size(21, 21)
        Me.BBProducto.TabIndex = 5
        Me.BBProducto.UseVisualStyleBackColor = False
        '
        'BBTrabajador
        '
        Me.BBTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.BBTrabajador.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBTrabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBTrabajador.Location = New System.Drawing.Point(262, 11)
        Me.BBTrabajador.Name = "BBTrabajador"
        Me.BBTrabajador.Size = New System.Drawing.Size(21, 21)
        Me.BBTrabajador.TabIndex = 2
        Me.BBTrabajador.UseVisualStyleBackColor = False
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.Location = New System.Drawing.Point(4, 68)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 99
        Me.IDP.Visible = False
        '
        'IDE
        '
        Me.IDE.AutoSize = True
        Me.IDE.Location = New System.Drawing.Point(4, 19)
        Me.IDE.Name = "IDE"
        Me.IDE.Size = New System.Drawing.Size(0, 13)
        Me.IDE.TabIndex = 98
        Me.IDE.Visible = False
        '
        'DTFPrestamo
        '
        Me.DTFPrestamo.Enabled = False
        Me.DTFPrestamo.Location = New System.Drawing.Point(136, 117)
        Me.DTFPrestamo.Name = "DTFPrestamo"
        Me.DTFPrestamo.Size = New System.Drawing.Size(155, 20)
        Me.DTFPrestamo.TabIndex = 7
        '
        'DTFEntrega
        '
        Me.DTFEntrega.Location = New System.Drawing.Point(136, 144)
        Me.DTFEntrega.Name = "DTFEntrega"
        Me.DTFEntrega.Size = New System.Drawing.Size(155, 20)
        Me.DTFEntrega.TabIndex = 8
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(4, 44)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LUsuario.TabIndex = 94
        Me.LUsuario.Visible = False
        '
        'IDD
        '
        Me.IDD.AutoSize = True
        Me.IDD.Location = New System.Drawing.Point(4, 38)
        Me.IDD.Name = "IDD"
        Me.IDD.Size = New System.Drawing.Size(0, 13)
        Me.IDD.TabIndex = 93
        Me.IDD.Visible = False
        '
        'TxtDSalida
        '
        Me.TxtDSalida.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDSalida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDSalida.Location = New System.Drawing.Point(136, 241)
        Me.TxtDSalida.Multiline = True
        Me.TxtDSalida.Name = "TxtDSalida"
        Me.TxtDSalida.Size = New System.Drawing.Size(155, 60)
        Me.TxtDSalida.TabIndex = 10
        '
        'LSalidaDetalle
        '
        Me.LSalidaDetalle.AutoSize = True
        Me.LSalidaDetalle.BackColor = System.Drawing.Color.Transparent
        Me.LSalidaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSalidaDetalle.Location = New System.Drawing.Point(47, 243)
        Me.LSalidaDetalle.Name = "LSalidaDetalle"
        Me.LSalidaDetalle.Size = New System.Drawing.Size(86, 32)
        Me.LSalidaDetalle.TabIndex = 92
        Me.LSalidaDetalle.Text = "Condiciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Salida"
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.Location = New System.Drawing.Point(52, 170)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.LDescripcion.TabIndex = 91
        Me.LDescripcion.Text = "Descripción"
        '
        'LNN
        '
        Me.LNN.AutoSize = True
        Me.LNN.BackColor = System.Drawing.Color.Transparent
        Me.LNN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNN.Location = New System.Drawing.Point(24, 13)
        Me.LNN.Name = "LNN"
        Me.LNN.Size = New System.Drawing.Size(108, 16)
        Me.LNN.TabIndex = 79
        Me.LNN.Text = "Núm. de Nómina"
        Me.LNN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LEntrega
        '
        Me.LEntrega.AutoSize = True
        Me.LEntrega.BackColor = System.Drawing.Color.Transparent
        Me.LEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntrega.Location = New System.Drawing.Point(18, 143)
        Me.LEntrega.Name = "LEntrega"
        Me.LEntrega.Size = New System.Drawing.Size(115, 16)
        Me.LEntrega.TabIndex = 89
        Me.LEntrega.Text = "Fecha de Entrega"
        '
        'TxtNN
        '
        Me.TxtNN.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNN.Location = New System.Drawing.Point(136, 12)
        Me.TxtNN.Multiline = True
        Me.TxtNN.Name = "TxtNN"
        Me.TxtNN.Size = New System.Drawing.Size(119, 20)
        Me.TxtNN.TabIndex = 1
        Me.TxtNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTrabajador
        '
        Me.TxtTrabajador.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTrabajador.Location = New System.Drawing.Point(136, 38)
        Me.TxtTrabajador.Multiline = True
        Me.TxtTrabajador.Name = "TxtTrabajador"
        Me.TxtTrabajador.Size = New System.Drawing.Size(155, 20)
        Me.TxtTrabajador.TabIndex = 3
        '
        'LFP
        '
        Me.LFP.AutoSize = True
        Me.LFP.BackColor = System.Drawing.Color.Transparent
        Me.LFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFP.Location = New System.Drawing.Point(7, 117)
        Me.LFP.Name = "LFP"
        Me.LFP.Size = New System.Drawing.Size(126, 16)
        Me.LFP.TabIndex = 87
        Me.LFP.Text = "Fecha de Prestamo"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(136, 170)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(155, 60)
        Me.TxtDescripcion.TabIndex = 9
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(56, 39)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(76, 16)
        Me.LNombre.TabIndex = 81
        Me.LNombre.Text = "Trabajador"
        '
        'TxtMaterial
        '
        Me.TxtMaterial.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMaterial.Location = New System.Drawing.Point(136, 64)
        Me.TxtMaterial.Multiline = True
        Me.TxtMaterial.Name = "TxtMaterial"
        Me.TxtMaterial.Size = New System.Drawing.Size(119, 20)
        Me.TxtMaterial.TabIndex = 4
        '
        'LCalidad
        '
        Me.LCalidad.AutoSize = True
        Me.LCalidad.BackColor = System.Drawing.Color.Transparent
        Me.LCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCalidad.Location = New System.Drawing.Point(70, 91)
        Me.LCalidad.Name = "LCalidad"
        Me.LCalidad.Size = New System.Drawing.Size(62, 16)
        Me.LCalidad.TabIndex = 85
        Me.LCalidad.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.Location = New System.Drawing.Point(136, 90)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(155, 20)
        Me.TxtCantidad.TabIndex = 6
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.BackColor = System.Drawing.Color.Transparent
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.Location = New System.Drawing.Point(76, 65)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(56, 16)
        Me.LMaterial.TabIndex = 83
        Me.LMaterial.Text = "Material"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(116, 87)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(140, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Nuevo Prestamo"
        '
        'PMaterial
        '
        Me.PMaterial.BackColor = System.Drawing.Color.Transparent
        Me.PMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PMaterial.Controls.Add(Me.TxtBMaterial)
        Me.PMaterial.Controls.Add(Me.DGProducto)
        Me.PMaterial.Location = New System.Drawing.Point(31, 212)
        Me.PMaterial.Name = "PMaterial"
        Me.PMaterial.Size = New System.Drawing.Size(307, 288)
        Me.PMaterial.TabIndex = 2
        Me.PMaterial.Visible = False
        '
        'TxtBMaterial
        '
        Me.TxtBMaterial.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtBMaterial.Location = New System.Drawing.Point(9, 6)
        Me.TxtBMaterial.Multiline = True
        Me.TxtBMaterial.Name = "TxtBMaterial"
        Me.TxtBMaterial.Size = New System.Drawing.Size(288, 31)
        Me.TxtBMaterial.TabIndex = 1
        '
        'DGProducto
        '
        Me.DGProducto.AllowUserToAddRows = False
        Me.DGProducto.AllowUserToDeleteRows = False
        Me.DGProducto.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPP, Me.Produto, Me.CodigoP})
        Me.DGProducto.Location = New System.Drawing.Point(3, 43)
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.ReadOnly = True
        Me.DGProducto.Size = New System.Drawing.Size(301, 240)
        Me.DGProducto.TabIndex = 2
        '
        'IDPP
        '
        Me.IDPP.DataPropertyName = "Id_Producto"
        Me.IDPP.HeaderText = "ID"
        Me.IDPP.Name = "IDPP"
        Me.IDPP.ReadOnly = True
        Me.IDPP.Width = 40
        '
        'Produto
        '
        Me.Produto.DataPropertyName = "Nombre_Producto"
        Me.Produto.HeaderText = "Producto"
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        Me.Produto.Width = 250
        '
        'CodigoP
        '
        Me.CodigoP.DataPropertyName = "Clave_Producto"
        Me.CodigoP.HeaderText = "Codigo"
        Me.CodigoP.Name = "CodigoP"
        Me.CodigoP.ReadOnly = True
        Me.CodigoP.Visible = False
        '
        'PTrabajador
        '
        Me.PTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.PTrabajador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PTrabajador.Controls.Add(Me.TxtBusT)
        Me.PTrabajador.Controls.Add(Me.DGTrabajador)
        Me.PTrabajador.Location = New System.Drawing.Point(32, 168)
        Me.PTrabajador.Name = "PTrabajador"
        Me.PTrabajador.Size = New System.Drawing.Size(308, 337)
        Me.PTrabajador.TabIndex = 3
        Me.PTrabajador.Visible = False
        '
        'TxtBusT
        '
        Me.TxtBusT.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtBusT.Location = New System.Drawing.Point(22, 7)
        Me.TxtBusT.Multiline = True
        Me.TxtBusT.Name = "TxtBusT"
        Me.TxtBusT.Size = New System.Drawing.Size(270, 31)
        Me.TxtBusT.TabIndex = 1
        '
        'DGTrabajador
        '
        Me.DGTrabajador.AllowUserToAddRows = False
        Me.DGTrabajador.AllowUserToDeleteRows = False
        Me.DGTrabajador.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DGTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTrabajador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Empleado, Me.Numero_Nomina, Me.NTrabajador})
        Me.DGTrabajador.Location = New System.Drawing.Point(-1, 44)
        Me.DGTrabajador.Name = "DGTrabajador"
        Me.DGTrabajador.ReadOnly = True
        Me.DGTrabajador.Size = New System.Drawing.Size(308, 289)
        Me.DGTrabajador.TabIndex = 2
        '
        'Id_Empleado
        '
        Me.Id_Empleado.DataPropertyName = "Id_Empleado"
        Me.Id_Empleado.HeaderText = "ID"
        Me.Id_Empleado.Name = "Id_Empleado"
        Me.Id_Empleado.ReadOnly = True
        Me.Id_Empleado.Width = 40
        '
        'Numero_Nomina
        '
        Me.Numero_Nomina.DataPropertyName = "Numero_Nomina"
        Me.Numero_Nomina.HeaderText = "Núm. Nómina"
        Me.Numero_Nomina.Name = "Numero_Nomina"
        Me.Numero_Nomina.ReadOnly = True
        Me.Numero_Nomina.Width = 50
        '
        'NTrabajador
        '
        Me.NTrabajador.DataPropertyName = "Nombre"
        Me.NTrabajador.HeaderText = "Trabajador"
        Me.NTrabajador.Name = "NTrabajador"
        Me.NTrabajador.ReadOnly = True
        Me.NTrabajador.Width = 170
        '
        'PNT
        '
        Me.PNT.BackColor = System.Drawing.Color.Transparent
        Me.PNT.Controls.Add(Me.BRNT)
        Me.PNT.Controls.Add(Me.BGNT)
        Me.PNT.Controls.Add(Me.TxtNombre)
        Me.PNT.Controls.Add(Me.TxtAM)
        Me.PNT.Controls.Add(Me.TxtAP)
        Me.PNT.Controls.Add(Me.TxtNNN)
        Me.PNT.Controls.Add(Me.LAM)
        Me.PNT.Controls.Add(Me.LAP)
        Me.PNT.Controls.Add(Me.LNom)
        Me.PNT.Controls.Add(Me.LN)
        Me.PNT.Controls.Add(Me.LT)
        Me.PNT.Location = New System.Drawing.Point(75, 219)
        Me.PNT.Name = "PNT"
        Me.PNT.Size = New System.Drawing.Size(210, 242)
        Me.PNT.TabIndex = 4
        Me.PNT.Visible = False
        '
        'BRNT
        '
        Me.BRNT.BackColor = System.Drawing.Color.Transparent
        Me.BRNT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BRNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRNT.Location = New System.Drawing.Point(114, 203)
        Me.BRNT.Name = "BRNT"
        Me.BRNT.Size = New System.Drawing.Size(38, 34)
        Me.BRNT.TabIndex = 6
        Me.BRNT.UseVisualStyleBackColor = False
        '
        'BGNT
        '
        Me.BGNT.BackColor = System.Drawing.Color.Transparent
        Me.BGNT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGNT.Location = New System.Drawing.Point(52, 203)
        Me.BGNT.Name = "BGNT"
        Me.BGNT.Size = New System.Drawing.Size(38, 34)
        Me.BGNT.TabIndex = 5
        Me.BGNT.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombre.Location = New System.Drawing.Point(80, 96)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtAM
        '
        Me.TxtAM.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtAM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAM.Location = New System.Drawing.Point(80, 164)
        Me.TxtAM.Multiline = True
        Me.TxtAM.Name = "TxtAM"
        Me.TxtAM.Size = New System.Drawing.Size(100, 20)
        Me.TxtAM.TabIndex = 4
        '
        'TxtAP
        '
        Me.TxtAP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtAP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtAP.Location = New System.Drawing.Point(80, 130)
        Me.TxtAP.Multiline = True
        Me.TxtAP.Name = "TxtAP"
        Me.TxtAP.Size = New System.Drawing.Size(100, 20)
        Me.TxtAP.TabIndex = 3
        '
        'TxtNNN
        '
        Me.TxtNNN.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNNN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNNN.Location = New System.Drawing.Point(80, 62)
        Me.TxtNNN.Multiline = True
        Me.TxtNNN.Name = "TxtNNN"
        Me.TxtNNN.Size = New System.Drawing.Size(100, 20)
        Me.TxtNNN.TabIndex = 1
        Me.TxtNNN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LAM
        '
        Me.LAM.AutoSize = True
        Me.LAM.Location = New System.Drawing.Point(26, 164)
        Me.LAM.Name = "LAM"
        Me.LAM.Size = New System.Drawing.Size(47, 26)
        Me.LAM.TabIndex = 0
        Me.LAM.Text = "Apellido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Materno"
        Me.LAM.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LAP
        '
        Me.LAP.AutoSize = True
        Me.LAP.Location = New System.Drawing.Point(29, 127)
        Me.LAP.Name = "LAP"
        Me.LAP.Size = New System.Drawing.Size(44, 26)
        Me.LAP.TabIndex = 0
        Me.LAP.Text = "Apellido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paterno"
        Me.LAP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Location = New System.Drawing.Point(29, 97)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(44, 13)
        Me.LNom.TabIndex = 0
        Me.LNom.Text = "Nombre"
        '
        'LN
        '
        Me.LN.AutoSize = True
        Me.LN.Location = New System.Drawing.Point(15, 59)
        Me.LN.Name = "LN"
        Me.LN.Size = New System.Drawing.Size(58, 26)
        Me.LN.TabIndex = 0
        Me.LN.Text = "Número " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Nómina"
        Me.LN.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LT
        '
        Me.LT.AutoSize = True
        Me.LT.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LT.Location = New System.Drawing.Point(49, 17)
        Me.LT.Name = "LT"
        Me.LT.Size = New System.Drawing.Size(119, 18)
        Me.LT.TabIndex = 0
        Me.LT.Text = "Ingresar Datos"
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(309, 2)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 0
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(258, 2)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 0
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'ANuevoT
        '
        Me.ANuevoT.BackColor = System.Drawing.Color.Transparent
        Me.ANuevoT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.user_40
        Me.ANuevoT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANuevoT.Location = New System.Drawing.Point(115, 2)
        Me.ANuevoT.Name = "ANuevoT"
        Me.ANuevoT.Size = New System.Drawing.Size(50, 50)
        Me.ANuevoT.TabIndex = 0
        Me.ANuevoT.UseVisualStyleBackColor = False
        Me.ANuevoT.Visible = False
        '
        'BGuardarMo
        '
        Me.BGuardarMo.BackColor = System.Drawing.Color.Transparent
        Me.BGuardarMo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardarMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGuardarMo.Location = New System.Drawing.Point(171, 2)
        Me.BGuardarMo.Name = "BGuardarMo"
        Me.BGuardarMo.Size = New System.Drawing.Size(50, 50)
        Me.BGuardarMo.TabIndex = 0
        Me.BGuardarMo.UseVisualStyleBackColor = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(312, 99)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 79
        Me.LCS.Visible = False
        '
        'NPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(363, 534)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.BGuardarMo)
        Me.Controls.Add(Me.ANuevoT)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.PNT)
        Me.Controls.Add(Me.PTrabajador)
        Me.Controls.Add(Me.PMaterial)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.PLinea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NPrestamo"
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.PMaterial.ResumeLayout(False)
        Me.PMaterial.PerformLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTrabajador.ResumeLayout(False)
        Me.PTrabajador.PerformLayout()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNT.ResumeLayout(False)
        Me.PNT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PLinea As Panel
    Friend WithEvents PDatos As Panel
    Friend WithEvents DTFEntrega As DateTimePicker
    Friend WithEvents LUsuario As Label
    Friend WithEvents IDD As Label
    Friend WithEvents TxtDSalida As TextBox
    Friend WithEvents LSalidaDetalle As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNN As Label
    Friend WithEvents LEntrega As Label
    Friend WithEvents TxtNN As TextBox
    Friend WithEvents TxtTrabajador As TextBox
    Friend WithEvents LFP As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TxtMaterial As TextBox
    Friend WithEvents LCalidad As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LMaterial As Label
    Friend WithEvents DTFPrestamo As DateTimePicker
    Friend WithEvents LTitulo As Label
    Friend WithEvents IDP As Label
    Friend WithEvents IDE As Label
    Friend WithEvents PMaterial As Panel
    Friend WithEvents TxtBMaterial As TextBox
    Friend WithEvents DGProducto As DataGridView
    Friend WithEvents PTrabajador As Panel
    Friend WithEvents TxtBusT As TextBox
    Friend WithEvents DGTrabajador As DataGridView
    Friend WithEvents Id_Empleado As DataGridViewLinkColumn
    Friend WithEvents Numero_Nomina As DataGridViewTextBoxColumn
    Friend WithEvents NTrabajador As DataGridViewTextBoxColumn
    Friend WithEvents PNT As Panel
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtAM As TextBox
    Friend WithEvents TxtAP As TextBox
    Friend WithEvents TxtNNN As TextBox
    Friend WithEvents LAM As Label
    Friend WithEvents LAP As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LN As Label
    Friend WithEvents LT As Label
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents ANuevoT As Button
    Friend WithEvents BGuardarMo As Button
    Friend WithEvents BBProducto As Button
    Friend WithEvents BBTrabajador As Button
    Friend WithEvents BRNT As Button
    Friend WithEvents BGNT As Button
    Friend WithEvents IDPP As DataGridViewLinkColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoP As DataGridViewTextBoxColumn
    Friend WithEvents LCS As Label
End Class
