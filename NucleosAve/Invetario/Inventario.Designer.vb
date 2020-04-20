<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventario
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
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.GDatos_Generales = New System.Windows.Forms.GroupBox()
        Me.CMarca = New System.Windows.Forms.ComboBox()
        Me.CMedida = New System.Windows.Forms.ComboBox()
        Me.LMa = New System.Windows.Forms.Label()
        Me.LM = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.TxtMedida = New System.Windows.Forms.TextBox()
        Me.LUMedida = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.TxtClaveP = New System.Windows.Forms.TextBox()
        Me.LClave = New System.Windows.Forms.Label()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.IDP = New System.Windows.Forms.Label()
        Me.GCantidad = New System.Windows.Forms.GroupBox()
        Me.LExitencia = New System.Windows.Forms.Label()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.LMínimo = New System.Windows.Forms.Label()
        Me.TxtMinimo = New System.Windows.Forms.TextBox()
        Me.LMáximo = New System.Windows.Forms.Label()
        Me.TxtMaximo = New System.Windows.Forms.TextBox()
        Me.GDetalles = New System.Windows.Forms.GroupBox()
        Me.CCategoria = New System.Windows.Forms.ComboBox()
        Me.LC = New System.Windows.Forms.Label()
        Me.LP = New System.Windows.Forms.Label()
        Me.CProceso = New System.Windows.Forms.ComboBox()
        Me.LA = New System.Windows.Forms.Label()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.CArea = New System.Windows.Forms.ComboBox()
        Me.TxtProceso = New System.Windows.Forms.TextBox()
        Me.TxtArea = New System.Windows.Forms.TextBox()
        Me.LArea = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.GCodigoBarras = New System.Windows.Forms.GroupBox()
        Me.PCodigoBarras = New System.Windows.Forms.Button()
        Me.TxtCB = New System.Windows.Forms.TextBox()
        Me.CodigoBarras = New IDAutomation.Windows.Forms.LinearBarCode.Barcode()
        Me.GPrecio = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.GPUSD = New System.Windows.Forms.GroupBox()
        Me.TxtUSD = New System.Windows.Forms.TextBox()
        Me.GTipoCambio = New System.Windows.Forms.GroupBox()
        Me.TxtTipoCambio = New System.Windows.Forms.TextBox()
        Me.AgregarExistencias = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GNExistencia = New System.Windows.Forms.GroupBox()
        Me.PMenos = New System.Windows.Forms.PictureBox()
        Me.TxtNExistencia = New System.Windows.Forms.TextBox()
        Me.BGExistencia = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        Me.OrdenCompra = New System.Windows.Forms.GroupBox()
        Me.TxtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.PUSD = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.TxtUTotal = New System.Windows.Forms.TextBox()
        Me.LUTotal = New System.Windows.Forms.Label()
        Me.TxtUCPza = New System.Windows.Forms.TextBox()
        Me.TxTUPza = New System.Windows.Forms.TextBox()
        Me.LPUPZA = New System.Windows.Forms.Label()
        Me.LUCPza = New System.Windows.Forms.Label()
        Me.LErrEP = New System.Windows.Forms.Label()
        Me.MURL = New System.Windows.Forms.Label()
        Me.DTTipoCambio = New System.Windows.Forms.DateTimePicker()
        Me.GTCambio = New System.Windows.Forms.GroupBox()
        Me.PCalendario = New System.Windows.Forms.Button()
        Me.TCambio = New System.Windows.Forms.TextBox()
        Me.GPrecioUSD = New System.Windows.Forms.GroupBox()
        Me.TxtTUSD = New System.Windows.Forms.TextBox()
        Me.LTUSD = New System.Windows.Forms.Label()
        Me.TxtFUSD = New System.Windows.Forms.TextBox()
        Me.TxtUUSD = New System.Windows.Forms.TextBox()
        Me.LUUSD = New System.Windows.Forms.Label()
        Me.LFUSD = New System.Windows.Forms.Label()
        Me.LEntraP = New System.Windows.Forms.Label()
        Me.PSeparador = New System.Windows.Forms.Panel()
        Me.LTExistencias = New System.Windows.Forms.Label()
        Me.LIdProducto = New System.Windows.Forms.Label()
        Me.HURL = New System.Windows.Forms.Label()
        Me.LAdvet = New System.Windows.Forms.Label()
        Me.TC = New System.Windows.Forms.Timer(Me.components)
        Me.HTC = New System.Windows.Forms.Timer(Me.components)
        Me.BImagen = New System.Windows.Forms.Button()
        Me.NameImagen = New System.Windows.Forms.Label()
        Me.IA = New System.Windows.Forms.Label()
        Me.BNuevoProducto = New System.Windows.Forms.Button()
        Me.BMostrarHist = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BAgregarExistencia = New System.Windows.Forms.Button()
        Me.BGuardarMo = New System.Windows.Forms.Button()
        Me.BRetorno = New System.Windows.Forms.Button()
        Me.BOrdenC = New System.Windows.Forms.Button()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LIDE = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GDatos_Generales.SuspendLayout()
        Me.GCantidad.SuspendLayout()
        Me.GDetalles.SuspendLayout()
        Me.GCodigoBarras.SuspendLayout()
        Me.GPrecio.SuspendLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPUSD.SuspendLayout()
        Me.GTipoCambio.SuspendLayout()
        Me.AgregarExistencias.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GNExistencia.SuspendLayout()
        CType(Me.PMenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OrdenCompra.SuspendLayout()
        Me.PUSD.SuspendLayout()
        Me.GTCambio.SuspendLayout()
        Me.GPrecioUSD.SuspendLayout()
        Me.PSeparador.SuspendLayout()
        Me.SuspendLayout()
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(20, 65)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(1112, 10)
        Me.POpc.TabIndex = 0
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.AllowUserToOrderColumns = True
        Me.DataView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre_Producto, Me.Clave_Producto, Me.Exis})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(603, 77)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(541, 443)
        Me.DataView.TabIndex = 1
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(25, 81)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(552, 65)
        Me.GBusqueda.TabIndex = 0
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(85, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(329, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Clave del Producto, Nombre del Producto, Marca O Código de Barra"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(501, 21)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(469, 31)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'GDatos_Generales
        '
        Me.GDatos_Generales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDatos_Generales.BackColor = System.Drawing.Color.Transparent
        Me.GDatos_Generales.Controls.Add(Me.CMarca)
        Me.GDatos_Generales.Controls.Add(Me.CMedida)
        Me.GDatos_Generales.Controls.Add(Me.LMa)
        Me.GDatos_Generales.Controls.Add(Me.LM)
        Me.GDatos_Generales.Controls.Add(Me.TxtMarca)
        Me.GDatos_Generales.Controls.Add(Me.LMarca)
        Me.GDatos_Generales.Controls.Add(Me.TxtMedida)
        Me.GDatos_Generales.Controls.Add(Me.LUMedida)
        Me.GDatos_Generales.Controls.Add(Me.TxtDescripcion)
        Me.GDatos_Generales.Controls.Add(Me.LDescripcion)
        Me.GDatos_Generales.Controls.Add(Me.TxtNombreP)
        Me.GDatos_Generales.Controls.Add(Me.TxtClaveP)
        Me.GDatos_Generales.Controls.Add(Me.LClave)
        Me.GDatos_Generales.Controls.Add(Me.LProducto)
        Me.GDatos_Generales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GDatos_Generales.ForeColor = System.Drawing.Color.Black
        Me.GDatos_Generales.Location = New System.Drawing.Point(25, 164)
        Me.GDatos_Generales.Name = "GDatos_Generales"
        Me.GDatos_Generales.Size = New System.Drawing.Size(310, 236)
        Me.GDatos_Generales.TabIndex = 2
        Me.GDatos_Generales.TabStop = False
        Me.GDatos_Generales.Text = "Datos Generales del Producto"
        '
        'CMarca
        '
        Me.CMarca.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMarca.FormattingEnabled = True
        Me.CMarca.Location = New System.Drawing.Point(143, 122)
        Me.CMarca.Name = "CMarca"
        Me.CMarca.Size = New System.Drawing.Size(162, 21)
        Me.CMarca.TabIndex = 81
        Me.CMarca.Visible = False
        '
        'CMedida
        '
        Me.CMedida.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMedida.FormattingEnabled = True
        Me.CMedida.Location = New System.Drawing.Point(143, 97)
        Me.CMedida.Name = "CMedida"
        Me.CMedida.Size = New System.Drawing.Size(162, 21)
        Me.CMedida.TabIndex = 81
        Me.CMedida.Visible = False
        '
        'LMa
        '
        Me.LMa.AutoSize = True
        Me.LMa.Location = New System.Drawing.Point(-3, 106)
        Me.LMa.Name = "LMa"
        Me.LMa.Size = New System.Drawing.Size(13, 13)
        Me.LMa.TabIndex = 7
        Me.LMa.Text = "1"
        Me.LMa.Visible = False
        '
        'LM
        '
        Me.LM.AutoSize = True
        Me.LM.Location = New System.Drawing.Point(2, 78)
        Me.LM.Name = "LM"
        Me.LM.Size = New System.Drawing.Size(13, 13)
        Me.LM.TabIndex = 6
        Me.LM.Text = "1"
        Me.LM.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMarca.Location = New System.Drawing.Point(143, 125)
        Me.TxtMarca.Multiline = True
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(162, 15)
        Me.TxtMarca.TabIndex = 4
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(91, 123)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(46, 16)
        Me.LMarca.TabIndex = 0
        Me.LMarca.Text = "Marca"
        '
        'TxtMedida
        '
        Me.TxtMedida.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMedida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMedida.Location = New System.Drawing.Point(143, 100)
        Me.TxtMedida.Multiline = True
        Me.TxtMedida.Name = "TxtMedida"
        Me.TxtMedida.ReadOnly = True
        Me.TxtMedida.Size = New System.Drawing.Size(162, 15)
        Me.TxtMedida.TabIndex = 3
        '
        'LUMedida
        '
        Me.LUMedida.AutoSize = True
        Me.LUMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUMedida.ForeColor = System.Drawing.Color.Black
        Me.LUMedida.Location = New System.Drawing.Point(17, 98)
        Me.LUMedida.Name = "LUMedida"
        Me.LUMedida.Size = New System.Drawing.Size(120, 16)
        Me.LUMedida.TabIndex = 0
        Me.LUMedida.Text = "Unidad de Medida"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(143, 149)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(162, 82)
        Me.TxtDescripcion.TabIndex = 5
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.ForeColor = System.Drawing.Color.Black
        Me.LDescripcion.Location = New System.Drawing.Point(57, 149)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.LDescripcion.TabIndex = 0
        Me.LDescripcion.Text = "Descripción"
        '
        'TxtNombreP
        '
        Me.TxtNombreP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreP.Location = New System.Drawing.Point(143, 50)
        Me.TxtNombreP.Multiline = True
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.ReadOnly = True
        Me.TxtNombreP.Size = New System.Drawing.Size(162, 41)
        Me.TxtNombreP.TabIndex = 2
        '
        'TxtClaveP
        '
        Me.TxtClaveP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtClaveP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtClaveP.Location = New System.Drawing.Point(143, 25)
        Me.TxtClaveP.Multiline = True
        Me.TxtClaveP.Name = "TxtClaveP"
        Me.TxtClaveP.ReadOnly = True
        Me.TxtClaveP.Size = New System.Drawing.Size(162, 15)
        Me.TxtClaveP.TabIndex = 1
        '
        'LClave
        '
        Me.LClave.AutoSize = True
        Me.LClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClave.ForeColor = System.Drawing.Color.Black
        Me.LClave.Location = New System.Drawing.Point(15, 23)
        Me.LClave.Name = "LClave"
        Me.LClave.Size = New System.Drawing.Size(122, 16)
        Me.LClave.TabIndex = 0
        Me.LClave.Text = "Clave del Producto"
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.ForeColor = System.Drawing.Color.Black
        Me.LProducto.Location = New System.Drawing.Point(0, 50)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(136, 16)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Nombre del Producto"
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.BackColor = System.Drawing.Color.Transparent
        Me.IDP.Location = New System.Drawing.Point(2, 202)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 0
        Me.IDP.Visible = False
        '
        'GCantidad
        '
        Me.GCantidad.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GCantidad.BackColor = System.Drawing.Color.Transparent
        Me.GCantidad.Controls.Add(Me.LExitencia)
        Me.GCantidad.Controls.Add(Me.TxtExistencia)
        Me.GCantidad.Controls.Add(Me.LMínimo)
        Me.GCantidad.Controls.Add(Me.TxtMinimo)
        Me.GCantidad.Controls.Add(Me.LMáximo)
        Me.GCantidad.Controls.Add(Me.TxtMaximo)
        Me.GCantidad.ForeColor = System.Drawing.Color.Black
        Me.GCantidad.Location = New System.Drawing.Point(12, 406)
        Me.GCantidad.Name = "GCantidad"
        Me.GCantidad.Size = New System.Drawing.Size(110, 84)
        Me.GCantidad.TabIndex = 3
        Me.GCantidad.TabStop = False
        '
        'LExitencia
        '
        Me.LExitencia.AutoSize = True
        Me.LExitencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LExitencia.ForeColor = System.Drawing.Color.Black
        Me.LExitencia.Location = New System.Drawing.Point(-1, 13)
        Me.LExitencia.Name = "LExitencia"
        Me.LExitencia.Size = New System.Drawing.Size(69, 16)
        Me.LExitencia.TabIndex = 0
        Me.LExitencia.Text = "Existencia"
        '
        'TxtExistencia
        '
        Me.TxtExistencia.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExistencia.Location = New System.Drawing.Point(68, 15)
        Me.TxtExistencia.Multiline = True
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.ReadOnly = True
        Me.TxtExistencia.Size = New System.Drawing.Size(35, 15)
        Me.TxtExistencia.TabIndex = 1
        Me.TxtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LMínimo
        '
        Me.LMínimo.AutoSize = True
        Me.LMínimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMínimo.ForeColor = System.Drawing.Color.Black
        Me.LMínimo.Location = New System.Drawing.Point(17, 37)
        Me.LMínimo.Name = "LMínimo"
        Me.LMínimo.Size = New System.Drawing.Size(51, 16)
        Me.LMínimo.TabIndex = 0
        Me.LMínimo.Text = "Mínimo"
        '
        'TxtMinimo
        '
        Me.TxtMinimo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMinimo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMinimo.Location = New System.Drawing.Point(68, 39)
        Me.TxtMinimo.Multiline = True
        Me.TxtMinimo.Name = "TxtMinimo"
        Me.TxtMinimo.ReadOnly = True
        Me.TxtMinimo.Size = New System.Drawing.Size(35, 15)
        Me.TxtMinimo.TabIndex = 2
        Me.TxtMinimo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LMáximo
        '
        Me.LMáximo.AutoSize = True
        Me.LMáximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMáximo.ForeColor = System.Drawing.Color.Black
        Me.LMáximo.Location = New System.Drawing.Point(13, 60)
        Me.LMáximo.Name = "LMáximo"
        Me.LMáximo.Size = New System.Drawing.Size(55, 16)
        Me.LMáximo.TabIndex = 0
        Me.LMáximo.Text = "Máximo"
        '
        'TxtMaximo
        '
        Me.TxtMaximo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMaximo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMaximo.Location = New System.Drawing.Point(68, 62)
        Me.TxtMaximo.Multiline = True
        Me.TxtMaximo.Name = "TxtMaximo"
        Me.TxtMaximo.ReadOnly = True
        Me.TxtMaximo.Size = New System.Drawing.Size(35, 15)
        Me.TxtMaximo.TabIndex = 3
        Me.TxtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GDetalles
        '
        Me.GDetalles.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDetalles.BackColor = System.Drawing.Color.Transparent
        Me.GDetalles.Controls.Add(Me.CCategoria)
        Me.GDetalles.Controls.Add(Me.LC)
        Me.GDetalles.Controls.Add(Me.LP)
        Me.GDetalles.Controls.Add(Me.CProceso)
        Me.GDetalles.Controls.Add(Me.LA)
        Me.GDetalles.Controls.Add(Me.TxtCategoria)
        Me.GDetalles.Controls.Add(Me.LCategoria)
        Me.GDetalles.Controls.Add(Me.CArea)
        Me.GDetalles.Controls.Add(Me.TxtProceso)
        Me.GDetalles.Controls.Add(Me.TxtArea)
        Me.GDetalles.Controls.Add(Me.LArea)
        Me.GDetalles.Controls.Add(Me.LProceso)
        Me.GDetalles.ForeColor = System.Drawing.Color.White
        Me.GDetalles.Location = New System.Drawing.Point(127, 406)
        Me.GDetalles.Name = "GDetalles"
        Me.GDetalles.Size = New System.Drawing.Size(257, 103)
        Me.GDetalles.TabIndex = 4
        Me.GDetalles.TabStop = False
        '
        'CCategoria
        '
        Me.CCategoria.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CCategoria.DropDownHeight = 120
        Me.CCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCategoria.DropDownWidth = 200
        Me.CCategoria.FormattingEnabled = True
        Me.CCategoria.IntegralHeight = False
        Me.CCategoria.Location = New System.Drawing.Point(66, 71)
        Me.CCategoria.Name = "CCategoria"
        Me.CCategoria.Size = New System.Drawing.Size(176, 21)
        Me.CCategoria.TabIndex = 83
        Me.CCategoria.Visible = False
        '
        'LC
        '
        Me.LC.AutoSize = True
        Me.LC.Location = New System.Drawing.Point(0, 60)
        Me.LC.Name = "LC"
        Me.LC.Size = New System.Drawing.Size(13, 13)
        Me.LC.TabIndex = 6
        Me.LC.Text = "1"
        Me.LC.Visible = False
        '
        'LP
        '
        Me.LP.AutoSize = True
        Me.LP.Location = New System.Drawing.Point(0, 39)
        Me.LP.Name = "LP"
        Me.LP.Size = New System.Drawing.Size(13, 13)
        Me.LP.TabIndex = 5
        Me.LP.Text = "1"
        Me.LP.Visible = False
        '
        'CProceso
        '
        Me.CProceso.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CProceso.FormattingEnabled = True
        Me.CProceso.IntegralHeight = False
        Me.CProceso.Location = New System.Drawing.Point(65, 42)
        Me.CProceso.Name = "CProceso"
        Me.CProceso.Size = New System.Drawing.Size(177, 21)
        Me.CProceso.TabIndex = 82
        Me.CProceso.Visible = False
        '
        'LA
        '
        Me.LA.AutoSize = True
        Me.LA.Location = New System.Drawing.Point(4, 15)
        Me.LA.Name = "LA"
        Me.LA.Size = New System.Drawing.Size(13, 13)
        Me.LA.TabIndex = 4
        Me.LA.Text = "1"
        Me.LA.Visible = False
        '
        'TxtCategoria
        '
        Me.TxtCategoria.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCategoria.Location = New System.Drawing.Point(68, 70)
        Me.TxtCategoria.Multiline = True
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.ReadOnly = True
        Me.TxtCategoria.Size = New System.Drawing.Size(175, 22)
        Me.TxtCategoria.TabIndex = 3
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.Black
        Me.LCategoria.Location = New System.Drawing.Point(1, 70)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(67, 16)
        Me.LCategoria.TabIndex = 0
        Me.LCategoria.Text = "Categoria"
        Me.LCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'CArea
        '
        Me.CArea.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CArea.FormattingEnabled = True
        Me.CArea.IntegralHeight = False
        Me.CArea.ItemHeight = 13
        Me.CArea.Location = New System.Drawing.Point(65, 14)
        Me.CArea.Name = "CArea"
        Me.CArea.Size = New System.Drawing.Size(177, 21)
        Me.CArea.TabIndex = 81
        Me.CArea.Visible = False
        '
        'TxtProceso
        '
        Me.TxtProceso.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtProceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProceso.Location = New System.Drawing.Point(68, 42)
        Me.TxtProceso.Multiline = True
        Me.TxtProceso.Name = "TxtProceso"
        Me.TxtProceso.ReadOnly = True
        Me.TxtProceso.Size = New System.Drawing.Size(175, 22)
        Me.TxtProceso.TabIndex = 2
        '
        'TxtArea
        '
        Me.TxtArea.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtArea.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtArea.Location = New System.Drawing.Point(68, 14)
        Me.TxtArea.Multiline = True
        Me.TxtArea.Name = "TxtArea"
        Me.TxtArea.ReadOnly = True
        Me.TxtArea.Size = New System.Drawing.Size(175, 22)
        Me.TxtArea.TabIndex = 1
        '
        'LArea
        '
        Me.LArea.AutoSize = True
        Me.LArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LArea.ForeColor = System.Drawing.Color.Black
        Me.LArea.Location = New System.Drawing.Point(31, 13)
        Me.LArea.Name = "LArea"
        Me.LArea.Size = New System.Drawing.Size(37, 16)
        Me.LArea.TabIndex = 0
        Me.LArea.Text = "Área"
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProceso.ForeColor = System.Drawing.Color.Black
        Me.LProceso.Location = New System.Drawing.Point(9, 45)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(59, 16)
        Me.LProceso.TabIndex = 0
        Me.LProceso.Text = "Proceso"
        Me.LProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GCodigoBarras
        '
        Me.GCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GCodigoBarras.BackColor = System.Drawing.Color.Transparent
        Me.GCodigoBarras.Controls.Add(Me.PCodigoBarras)
        Me.GCodigoBarras.Controls.Add(Me.TxtCB)
        Me.GCodigoBarras.Controls.Add(Me.CodigoBarras)
        Me.GCodigoBarras.ForeColor = System.Drawing.Color.Black
        Me.GCodigoBarras.Location = New System.Drawing.Point(388, 406)
        Me.GCodigoBarras.Name = "GCodigoBarras"
        Me.GCodigoBarras.Size = New System.Drawing.Size(216, 114)
        Me.GCodigoBarras.TabIndex = 5
        Me.GCodigoBarras.TabStop = False
        Me.GCodigoBarras.Text = "Código de Barras"
        '
        'PCodigoBarras
        '
        Me.PCodigoBarras.BackColor = System.Drawing.Color.Transparent
        Me.PCodigoBarras.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_refrescar_código_de_barras_32
        Me.PCodigoBarras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PCodigoBarras.Location = New System.Drawing.Point(190, 86)
        Me.PCodigoBarras.Name = "PCodigoBarras"
        Me.PCodigoBarras.Size = New System.Drawing.Size(26, 27)
        Me.PCodigoBarras.TabIndex = 84
        Me.PCodigoBarras.UseVisualStyleBackColor = False
        Me.PCodigoBarras.Visible = False
        '
        'TxtCB
        '
        Me.TxtCB.Location = New System.Drawing.Point(16, 19)
        Me.TxtCB.Name = "TxtCB"
        Me.TxtCB.Size = New System.Drawing.Size(166, 20)
        Me.TxtCB.TabIndex = 83
        Me.TxtCB.Visible = False
        '
        'CodigoBarras
        '
        Me.CodigoBarras.ApplyTilde = True
        Me.CodigoBarras.BarHeightCM = 1.0!
        Me.CodigoBarras.BearerBarHorizontal = 0
        Me.CodigoBarras.BearerBarVertical = 0
        Me.CodigoBarras.CaptionAbove = ""
        Me.CodigoBarras.CaptionBelow = ""
        Me.CodigoBarras.CaptionBottomAlignment = System.Drawing.StringAlignment.Center
        Me.CodigoBarras.CaptionBottomColor = System.Drawing.Color.Black
        Me.CodigoBarras.CaptionBottomSpace = 0.1!
        Me.CodigoBarras.CaptionFontAbove = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CodigoBarras.CaptionFontBelow = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.CodigoBarras.CaptionTopAlignment = System.Drawing.StringAlignment.Center
        Me.CodigoBarras.CaptionTopColor = System.Drawing.Color.Black
        Me.CodigoBarras.CaptionTopSpace = 0.1!
        Me.CodigoBarras.CharacterGrouping = 0
        Me.CodigoBarras.CheckCharacter = False
        Me.CodigoBarras.CheckCharacterInText = True
        Me.CodigoBarras.CODABARStartChar = "A"
        Me.CodigoBarras.CODABARStopChar = "B"
        Me.CodigoBarras.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Code128CharacterSets.[Auto]
        Me.CodigoBarras.DataToEncode = ""
        Me.CodigoBarras.DoPaint = True
        Me.CodigoBarras.FitControlToBarcode = True
        Me.CodigoBarras.LeftMarginCM = 0.2!
        Me.CodigoBarras.Location = New System.Drawing.Point(11, 37)
        Me.CodigoBarras.Name = "CodigoBarras"
        Me.CodigoBarras.NarrowToWideRatio = 2.0!
        Me.CodigoBarras.OneBitPerPixelImage = False
        Me.CodigoBarras.PostnetHeightShort = 0.127!
        Me.CodigoBarras.PostnetHeightTall = 0.3226!
        Me.CodigoBarras.PostnetSpacing = 0.064!
        Me.CodigoBarras.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Resolutions.Printer
        Me.CodigoBarras.ResolutionCustomDPI = 96.0!
        Me.CodigoBarras.ResolutionPrinterToUse = ""
        Me.CodigoBarras.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.RotationAngles.Zero_Degrees
        Me.CodigoBarras.ShowText = True
        Me.CodigoBarras.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.HRTextPositions.Bottom
        Me.CodigoBarras.Size = New System.Drawing.Size(41, 74)
        Me.CodigoBarras.SuppSeparationCM = 0.5!
        Me.CodigoBarras.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Symbologies.Code39
        Me.CodigoBarras.TabIndex = 81
        Me.CodigoBarras.TextFontColor = System.Drawing.Color.Black
        Me.CodigoBarras.TextMarginCM = 0.1!
        Me.CodigoBarras.TopMarginCM = 0.2!
        Me.CodigoBarras.UPCESystem = "0"
        Me.CodigoBarras.WhiteBarIncrease = 0!
        Me.CodigoBarras.XDimensionCM = 0.0298!
        Me.CodigoBarras.XDimensionMILS = 11.7714!
        '
        'GPrecio
        '
        Me.GPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GPrecio.BackColor = System.Drawing.Color.Transparent
        Me.GPrecio.Controls.Add(Me.TxtPrecio)
        Me.GPrecio.ForeColor = System.Drawing.Color.Black
        Me.GPrecio.Location = New System.Drawing.Point(351, 179)
        Me.GPrecio.Name = "GPrecio"
        Me.GPrecio.Size = New System.Drawing.Size(90, 38)
        Me.GPrecio.TabIndex = 6
        Me.GPrecio.TabStop = False
        Me.GPrecio.Text = "Precio (MXN)"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPrecio.Location = New System.Drawing.Point(14, 16)
        Me.TxtPrecio.Multiline = True
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(63, 15)
        Me.TxtPrecio.TabIndex = 1
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Imagen
        '
        Me.Imagen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Imagen.BackColor = System.Drawing.Color.Transparent
        Me.Imagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Imagen.Location = New System.Drawing.Point(451, 164)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(134, 172)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Imagen.TabIndex = 70
        Me.Imagen.TabStop = False
        '
        'GPUSD
        '
        Me.GPUSD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GPUSD.BackColor = System.Drawing.Color.Transparent
        Me.GPUSD.Controls.Add(Me.TxtUSD)
        Me.GPUSD.ForeColor = System.Drawing.Color.Black
        Me.GPUSD.Location = New System.Drawing.Point(350, 334)
        Me.GPUSD.Name = "GPUSD"
        Me.GPUSD.Size = New System.Drawing.Size(90, 38)
        Me.GPUSD.TabIndex = 8
        Me.GPUSD.TabStop = False
        Me.GPUSD.Text = "Precio (USD)"
        '
        'TxtUSD
        '
        Me.TxtUSD.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtUSD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUSD.Location = New System.Drawing.Point(14, 16)
        Me.TxtUSD.Multiline = True
        Me.TxtUSD.Name = "TxtUSD"
        Me.TxtUSD.ReadOnly = True
        Me.TxtUSD.Size = New System.Drawing.Size(63, 15)
        Me.TxtUSD.TabIndex = 1
        Me.TxtUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GTipoCambio
        '
        Me.GTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GTipoCambio.BackColor = System.Drawing.Color.Transparent
        Me.GTipoCambio.Controls.Add(Me.TxtTipoCambio)
        Me.GTipoCambio.ForeColor = System.Drawing.Color.Black
        Me.GTipoCambio.Location = New System.Drawing.Point(341, 237)
        Me.GTipoCambio.Name = "GTipoCambio"
        Me.GTipoCambio.Size = New System.Drawing.Size(106, 45)
        Me.GTipoCambio.TabIndex = 7
        Me.GTipoCambio.TabStop = False
        Me.GTipoCambio.Text = "Tipo de Cambio"
        '
        'TxtTipoCambio
        '
        Me.TxtTipoCambio.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTipoCambio.Location = New System.Drawing.Point(24, 21)
        Me.TxtTipoCambio.Multiline = True
        Me.TxtTipoCambio.Name = "TxtTipoCambio"
        Me.TxtTipoCambio.ReadOnly = True
        Me.TxtTipoCambio.Size = New System.Drawing.Size(63, 15)
        Me.TxtTipoCambio.TabIndex = 1
        Me.TxtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AgregarExistencias
        '
        Me.AgregarExistencias.BackColor = System.Drawing.Color.Transparent
        Me.AgregarExistencias.Controls.Add(Me.Panel1)
        Me.AgregarExistencias.Controls.Add(Me.LCS)
        Me.AgregarExistencias.Controls.Add(Me.OrdenCompra)
        Me.AgregarExistencias.Controls.Add(Me.PUSD)
        Me.AgregarExistencias.Controls.Add(Me.LErrEP)
        Me.AgregarExistencias.Controls.Add(Me.MURL)
        Me.AgregarExistencias.Controls.Add(Me.DTTipoCambio)
        Me.AgregarExistencias.Controls.Add(Me.GTCambio)
        Me.AgregarExistencias.Controls.Add(Me.GPrecioUSD)
        Me.AgregarExistencias.Controls.Add(Me.LEntraP)
        Me.AgregarExistencias.Controls.Add(Me.PSeparador)
        Me.AgregarExistencias.Location = New System.Drawing.Point(1, 534)
        Me.AgregarExistencias.Name = "AgregarExistencias"
        Me.AgregarExistencias.Size = New System.Drawing.Size(1141, 190)
        Me.AgregarExistencias.TabIndex = 9
        Me.AgregarExistencias.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GNExistencia)
        Me.Panel1.Controls.Add(Me.BGExistencia)
        Me.Panel1.Location = New System.Drawing.Point(4, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 133)
        Me.Panel1.TabIndex = 85
        '
        'GNExistencia
        '
        Me.GNExistencia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GNExistencia.BackColor = System.Drawing.Color.Transparent
        Me.GNExistencia.Controls.Add(Me.PMenos)
        Me.GNExistencia.Controls.Add(Me.TxtNExistencia)
        Me.GNExistencia.ForeColor = System.Drawing.Color.Black
        Me.GNExistencia.Location = New System.Drawing.Point(450, 23)
        Me.GNExistencia.Name = "GNExistencia"
        Me.GNExistencia.Size = New System.Drawing.Size(104, 72)
        Me.GNExistencia.TabIndex = 10
        Me.GNExistencia.TabStop = False
        Me.GNExistencia.Text = "Cantidad"
        '
        'PMenos
        '
        Me.PMenos.Image = Global.NucleosAve.My.Resources.Resources.file_511
        Me.PMenos.Location = New System.Drawing.Point(75, 28)
        Me.PMenos.Name = "PMenos"
        Me.PMenos.Size = New System.Drawing.Size(24, 24)
        Me.PMenos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PMenos.TabIndex = 28
        Me.PMenos.TabStop = False
        '
        'TxtNExistencia
        '
        Me.TxtNExistencia.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNExistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNExistencia.Location = New System.Drawing.Point(6, 21)
        Me.TxtNExistencia.Multiline = True
        Me.TxtNExistencia.Name = "TxtNExistencia"
        Me.TxtNExistencia.Size = New System.Drawing.Size(63, 37)
        Me.TxtNExistencia.TabIndex = 1
        Me.TxtNExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BGExistencia
        '
        Me.BGExistencia.BackColor = System.Drawing.Color.Transparent
        Me.BGExistencia.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGExistencia.Location = New System.Drawing.Point(573, 35)
        Me.BGExistencia.Name = "BGExistencia"
        Me.BGExistencia.Size = New System.Drawing.Size(50, 50)
        Me.BGExistencia.TabIndex = 84
        Me.BGExistencia.UseVisualStyleBackColor = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(158, 31)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 84
        Me.LCS.Visible = False
        '
        'OrdenCompra
        '
        Me.OrdenCompra.BackColor = System.Drawing.Color.Transparent
        Me.OrdenCompra.Controls.Add(Me.TxtOrdenCompra)
        Me.OrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.OrdenCompra.ForeColor = System.Drawing.Color.White
        Me.OrdenCompra.Location = New System.Drawing.Point(767, 86)
        Me.OrdenCompra.Name = "OrdenCompra"
        Me.OrdenCompra.Size = New System.Drawing.Size(139, 65)
        Me.OrdenCompra.TabIndex = 15
        Me.OrdenCompra.TabStop = False
        Me.OrdenCompra.Text = "Orden de Compra"
        '
        'TxtOrdenCompra
        '
        Me.TxtOrdenCompra.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtOrdenCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtOrdenCompra.Location = New System.Drawing.Point(24, 28)
        Me.TxtOrdenCompra.Multiline = True
        Me.TxtOrdenCompra.Name = "TxtOrdenCompra"
        Me.TxtOrdenCompra.Size = New System.Drawing.Size(97, 20)
        Me.TxtOrdenCompra.TabIndex = 1
        Me.TxtOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PUSD
        '
        Me.PUSD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PUSD.BackColor = System.Drawing.Color.Transparent
        Me.PUSD.Controls.Add(Me.TxtTotal)
        Me.PUSD.Controls.Add(Me.LTotal)
        Me.PUSD.Controls.Add(Me.TxtUTotal)
        Me.PUSD.Controls.Add(Me.LUTotal)
        Me.PUSD.Controls.Add(Me.TxtUCPza)
        Me.PUSD.Controls.Add(Me.TxTUPza)
        Me.PUSD.Controls.Add(Me.LPUPZA)
        Me.PUSD.Controls.Add(Me.LUCPza)
        Me.PUSD.ForeColor = System.Drawing.Color.White
        Me.PUSD.Location = New System.Drawing.Point(513, 60)
        Me.PUSD.Name = "PUSD"
        Me.PUSD.Size = New System.Drawing.Size(233, 108)
        Me.PUSD.TabIndex = 14
        Me.PUSD.TabStop = False
        Me.PUSD.Text = "Precio (MXN)"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTotal.Location = New System.Drawing.Point(144, 87)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(81, 15)
        Me.TxtTotal.TabIndex = 4
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.ForeColor = System.Drawing.Color.White
        Me.LTotal.Location = New System.Drawing.Point(97, 87)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(44, 16)
        Me.LTotal.TabIndex = 0
        Me.LTotal.Text = "Total"
        Me.LTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtUTotal
        '
        Me.TxtUTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtUTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUTotal.Location = New System.Drawing.Point(144, 64)
        Me.TxtUTotal.Multiline = True
        Me.TxtUTotal.Name = "TxtUTotal"
        Me.TxtUTotal.ReadOnly = True
        Me.TxtUTotal.Size = New System.Drawing.Size(81, 15)
        Me.TxtUTotal.TabIndex = 3
        Me.TxtUTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LUTotal
        '
        Me.LUTotal.AutoSize = True
        Me.LUTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUTotal.ForeColor = System.Drawing.Color.White
        Me.LUTotal.Location = New System.Drawing.Point(39, 64)
        Me.LUTotal.Name = "LUTotal"
        Me.LUTotal.Size = New System.Drawing.Size(102, 16)
        Me.LUTotal.TabIndex = 0
        Me.LUTotal.Text = "Unitario Total"
        Me.LUTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtUCPza
        '
        Me.TxtUCPza.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtUCPza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUCPza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUCPza.Location = New System.Drawing.Point(144, 40)
        Me.TxtUCPza.Multiline = True
        Me.TxtUCPza.Name = "TxtUCPza"
        Me.TxtUCPza.Size = New System.Drawing.Size(81, 15)
        Me.TxtUCPza.TabIndex = 2
        Me.TxtUCPza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxTUPza
        '
        Me.TxTUPza.BackColor = System.Drawing.Color.Gainsboro
        Me.TxTUPza.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxTUPza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxTUPza.Location = New System.Drawing.Point(144, 17)
        Me.TxTUPza.Multiline = True
        Me.TxTUPza.Name = "TxTUPza"
        Me.TxTUPza.ReadOnly = True
        Me.TxTUPza.Size = New System.Drawing.Size(81, 15)
        Me.TxTUPza.TabIndex = 1
        Me.TxTUPza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LPUPZA
        '
        Me.LPUPZA.AutoSize = True
        Me.LPUPZA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPUPZA.ForeColor = System.Drawing.Color.White
        Me.LPUPZA.Location = New System.Drawing.Point(46, 17)
        Me.LPUPZA.Name = "LPUPZA"
        Me.LPUPZA.Size = New System.Drawing.Size(95, 16)
        Me.LPUPZA.TabIndex = 0
        Me.LPUPZA.Text = "Unitario PZA"
        '
        'LUCPza
        '
        Me.LUCPza.AutoSize = True
        Me.LUCPza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUCPza.ForeColor = System.Drawing.Color.White
        Me.LUCPza.Location = New System.Drawing.Point(5, 40)
        Me.LUCPza.Name = "LUCPza"
        Me.LUCPza.Size = New System.Drawing.Size(136, 16)
        Me.LUCPza.TabIndex = 0
        Me.LUCPza.Text = "Unitario Corte PZA"
        Me.LUCPza.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LErrEP
        '
        Me.LErrEP.AutoSize = True
        Me.LErrEP.BackColor = System.Drawing.Color.LightCoral
        Me.LErrEP.ForeColor = System.Drawing.Color.Black
        Me.LErrEP.Location = New System.Drawing.Point(429, 112)
        Me.LErrEP.Name = "LErrEP"
        Me.LErrEP.Size = New System.Drawing.Size(71, 39)
        Me.LErrEP.TabIndex = 0
        Me.LErrEP.Text = "Error," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingresar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manualmente"
        Me.LErrEP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LErrEP.Visible = False
        '
        'MURL
        '
        Me.MURL.AutoSize = True
        Me.MURL.Location = New System.Drawing.Point(325, 150)
        Me.MURL.Name = "MURL"
        Me.MURL.Size = New System.Drawing.Size(0, 13)
        Me.MURL.TabIndex = 5
        Me.MURL.Visible = False
        '
        'DTTipoCambio
        '
        Me.DTTipoCambio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTipoCambio.Location = New System.Drawing.Point(351, 113)
        Me.DTTipoCambio.Name = "DTTipoCambio"
        Me.DTTipoCambio.Size = New System.Drawing.Size(84, 20)
        Me.DTTipoCambio.TabIndex = 13
        Me.DTTipoCambio.Visible = False
        '
        'GTCambio
        '
        Me.GTCambio.BackColor = System.Drawing.Color.Transparent
        Me.GTCambio.Controls.Add(Me.PCalendario)
        Me.GTCambio.Controls.Add(Me.TCambio)
        Me.GTCambio.ForeColor = System.Drawing.Color.Black
        Me.GTCambio.Location = New System.Drawing.Point(349, 65)
        Me.GTCambio.Name = "GTCambio"
        Me.GTCambio.Size = New System.Drawing.Size(117, 47)
        Me.GTCambio.TabIndex = 12
        Me.GTCambio.TabStop = False
        Me.GTCambio.Text = "Tipo de Cambio"
        '
        'PCalendario
        '
        Me.PCalendario.BackColor = System.Drawing.Color.Transparent
        Me.PCalendario.BackgroundImage = Global.NucleosAve.My.Resources.Resources.calendar_281
        Me.PCalendario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PCalendario.Location = New System.Drawing.Point(87, 17)
        Me.PCalendario.Name = "PCalendario"
        Me.PCalendario.Size = New System.Drawing.Size(26, 27)
        Me.PCalendario.TabIndex = 6
        Me.PCalendario.UseVisualStyleBackColor = False
        '
        'TCambio
        '
        Me.TCambio.BackColor = System.Drawing.Color.Gainsboro
        Me.TCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TCambio.Location = New System.Drawing.Point(17, 19)
        Me.TCambio.Multiline = True
        Me.TCambio.Name = "TCambio"
        Me.TCambio.ReadOnly = True
        Me.TCambio.Size = New System.Drawing.Size(63, 20)
        Me.TCambio.TabIndex = 1
        Me.TCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GPrecioUSD
        '
        Me.GPrecioUSD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GPrecioUSD.BackColor = System.Drawing.Color.Transparent
        Me.GPrecioUSD.Controls.Add(Me.TxtTUSD)
        Me.GPrecioUSD.Controls.Add(Me.LTUSD)
        Me.GPrecioUSD.Controls.Add(Me.TxtFUSD)
        Me.GPrecioUSD.Controls.Add(Me.TxtUUSD)
        Me.GPrecioUSD.Controls.Add(Me.LUUSD)
        Me.GPrecioUSD.Controls.Add(Me.LFUSD)
        Me.GPrecioUSD.ForeColor = System.Drawing.Color.Black
        Me.GPrecioUSD.Location = New System.Drawing.Point(178, 60)
        Me.GPrecioUSD.Name = "GPrecioUSD"
        Me.GPrecioUSD.Size = New System.Drawing.Size(145, 85)
        Me.GPrecioUSD.TabIndex = 11
        Me.GPrecioUSD.TabStop = False
        Me.GPrecioUSD.Text = "Precio (USD)"
        '
        'TxtTUSD
        '
        Me.TxtTUSD.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTUSD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTUSD.Location = New System.Drawing.Point(59, 64)
        Me.TxtTUSD.Multiline = True
        Me.TxtTUSD.Name = "TxtTUSD"
        Me.TxtTUSD.ReadOnly = True
        Me.TxtTUSD.Size = New System.Drawing.Size(81, 15)
        Me.TxtTUSD.TabIndex = 3
        Me.TxtTUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LTUSD
        '
        Me.LTUSD.AutoSize = True
        Me.LTUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTUSD.ForeColor = System.Drawing.Color.Black
        Me.LTUSD.Location = New System.Drawing.Point(18, 63)
        Me.LTUSD.Name = "LTUSD"
        Me.LTUSD.Size = New System.Drawing.Size(39, 16)
        Me.LTUSD.TabIndex = 0
        Me.LTUSD.Text = "Total"
        Me.LTUSD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtFUSD
        '
        Me.TxtFUSD.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtFUSD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFUSD.Location = New System.Drawing.Point(59, 40)
        Me.TxtFUSD.Multiline = True
        Me.TxtFUSD.Name = "TxtFUSD"
        Me.TxtFUSD.Size = New System.Drawing.Size(81, 15)
        Me.TxtFUSD.TabIndex = 2
        Me.TxtFUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtUUSD
        '
        Me.TxtUUSD.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtUUSD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUUSD.Location = New System.Drawing.Point(59, 17)
        Me.TxtUUSD.Multiline = True
        Me.TxtUUSD.Name = "TxtUUSD"
        Me.TxtUUSD.Size = New System.Drawing.Size(81, 15)
        Me.TxtUUSD.TabIndex = 1
        Me.TxtUUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LUUSD
        '
        Me.LUUSD.AutoSize = True
        Me.LUUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUUSD.ForeColor = System.Drawing.Color.Black
        Me.LUUSD.Location = New System.Drawing.Point(5, 17)
        Me.LUUSD.Name = "LUUSD"
        Me.LUUSD.Size = New System.Drawing.Size(54, 16)
        Me.LUUSD.TabIndex = 0
        Me.LUUSD.Text = "Unitario"
        '
        'LFUSD
        '
        Me.LFUSD.AutoSize = True
        Me.LFUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFUSD.ForeColor = System.Drawing.Color.Black
        Me.LFUSD.Location = New System.Drawing.Point(19, 40)
        Me.LFUSD.Name = "LFUSD"
        Me.LFUSD.Size = New System.Drawing.Size(38, 16)
        Me.LFUSD.TabIndex = 0
        Me.LFUSD.Text = "Flete"
        Me.LFUSD.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LEntraP
        '
        Me.LEntraP.AutoSize = True
        Me.LEntraP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntraP.ForeColor = System.Drawing.Color.Black
        Me.LEntraP.Location = New System.Drawing.Point(458, 26)
        Me.LEntraP.Name = "LEntraP"
        Me.LEntraP.Size = New System.Drawing.Size(175, 20)
        Me.LEntraP.TabIndex = 0
        Me.LEntraP.Text = "Entrada de Producto"
        '
        'PSeparador
        '
        Me.PSeparador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PSeparador.BackColor = System.Drawing.Color.SteelBlue
        Me.PSeparador.Controls.Add(Me.LTExistencias)
        Me.PSeparador.Controls.Add(Me.LIdProducto)
        Me.PSeparador.Location = New System.Drawing.Point(3, 3)
        Me.PSeparador.Name = "PSeparador"
        Me.PSeparador.Size = New System.Drawing.Size(1135, 18)
        Me.PSeparador.TabIndex = 1
        '
        'LTExistencias
        '
        Me.LTExistencias.AutoSize = True
        Me.LTExistencias.Location = New System.Drawing.Point(56, 0)
        Me.LTExistencias.Name = "LTExistencias"
        Me.LTExistencias.Size = New System.Drawing.Size(0, 13)
        Me.LTExistencias.TabIndex = 1
        Me.LTExistencias.Visible = False
        '
        'LIdProducto
        '
        Me.LIdProducto.AutoSize = True
        Me.LIdProducto.Location = New System.Drawing.Point(33, 0)
        Me.LIdProducto.Name = "LIdProducto"
        Me.LIdProducto.Size = New System.Drawing.Size(0, 13)
        Me.LIdProducto.TabIndex = 0
        Me.LIdProducto.Visible = False
        '
        'HURL
        '
        Me.HURL.AutoSize = True
        Me.HURL.BackColor = System.Drawing.Color.Transparent
        Me.HURL.Location = New System.Drawing.Point(223, 290)
        Me.HURL.Name = "HURL"
        Me.HURL.Size = New System.Drawing.Size(0, 13)
        Me.HURL.TabIndex = 0
        Me.HURL.Visible = False
        '
        'LAdvet
        '
        Me.LAdvet.AutoSize = True
        Me.LAdvet.BackColor = System.Drawing.Color.LightCoral
        Me.LAdvet.ForeColor = System.Drawing.Color.Black
        Me.LAdvet.Location = New System.Drawing.Point(361, 275)
        Me.LAdvet.Name = "LAdvet"
        Me.LAdvet.Size = New System.Drawing.Size(71, 39)
        Me.LAdvet.TabIndex = 0
        Me.LAdvet.Text = "Error," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingresar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Manualmente"
        Me.LAdvet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LAdvet.Visible = False
        '
        'TC
        '
        Me.TC.Interval = 1000
        '
        'HTC
        '
        '
        'BImagen
        '
        Me.BImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImagen.ForeColor = System.Drawing.Color.Black
        Me.BImagen.Location = New System.Drawing.Point(453, 297)
        Me.BImagen.Name = "BImagen"
        Me.BImagen.Size = New System.Drawing.Size(75, 39)
        Me.BImagen.TabIndex = 81
        Me.BImagen.Text = "Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Imágen"
        Me.BImagen.UseVisualStyleBackColor = True
        Me.BImagen.Visible = False
        '
        'NameImagen
        '
        Me.NameImagen.AutoSize = True
        Me.NameImagen.Location = New System.Drawing.Point(359, 400)
        Me.NameImagen.Name = "NameImagen"
        Me.NameImagen.Size = New System.Drawing.Size(0, 13)
        Me.NameImagen.TabIndex = 82
        Me.NameImagen.Visible = False
        '
        'IA
        '
        Me.IA.AutoSize = True
        Me.IA.Location = New System.Drawing.Point(314, 400)
        Me.IA.Name = "IA"
        Me.IA.Size = New System.Drawing.Size(0, 13)
        Me.IA.TabIndex = 83
        Me.IA.Visible = False
        '
        'BNuevoProducto
        '
        Me.BNuevoProducto.BackColor = System.Drawing.Color.Transparent
        Me.BNuevoProducto.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file1
        Me.BNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BNuevoProducto.Location = New System.Drawing.Point(20, 10)
        Me.BNuevoProducto.Name = "BNuevoProducto"
        Me.BNuevoProducto.Size = New System.Drawing.Size(50, 50)
        Me.BNuevoProducto.TabIndex = 1
        Me.BNuevoProducto.UseVisualStyleBackColor = False
        '
        'BMostrarHist
        '
        Me.BMostrarHist.BackColor = System.Drawing.Color.Transparent
        Me.BMostrarHist.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list_81
        Me.BMostrarHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMostrarHist.Location = New System.Drawing.Point(601, 10)
        Me.BMostrarHist.Name = "BMostrarHist"
        Me.BMostrarHist.Size = New System.Drawing.Size(50, 50)
        Me.BMostrarHist.TabIndex = 0
        Me.BMostrarHist.UseVisualStyleBackColor = False
        Me.BMostrarHist.Visible = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(1092, 5)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 4
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(1036, 5)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 3
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(768, 10)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 0
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.Color.Transparent
        Me.BModificar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_42
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BModificar.Location = New System.Drawing.Point(712, 10)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(50, 50)
        Me.BModificar.TabIndex = 0
        Me.BModificar.UseVisualStyleBackColor = False
        Me.BModificar.Visible = False
        '
        'BAgregarExistencia
        '
        Me.BAgregarExistencia.BackColor = System.Drawing.Color.Transparent
        Me.BAgregarExistencia.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list1
        Me.BAgregarExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAgregarExistencia.Location = New System.Drawing.Point(656, 10)
        Me.BAgregarExistencia.Name = "BAgregarExistencia"
        Me.BAgregarExistencia.Size = New System.Drawing.Size(50, 50)
        Me.BAgregarExistencia.TabIndex = 0
        Me.BAgregarExistencia.UseVisualStyleBackColor = False
        Me.BAgregarExistencia.Visible = False
        '
        'BGuardarMo
        '
        Me.BGuardarMo.BackColor = System.Drawing.Color.Transparent
        Me.BGuardarMo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardarMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGuardarMo.Location = New System.Drawing.Point(712, 10)
        Me.BGuardarMo.Name = "BGuardarMo"
        Me.BGuardarMo.Size = New System.Drawing.Size(50, 50)
        Me.BGuardarMo.TabIndex = 0
        Me.BGuardarMo.UseVisualStyleBackColor = False
        Me.BGuardarMo.Visible = False
        '
        'BRetorno
        '
        Me.BRetorno.BackColor = System.Drawing.Color.Transparent
        Me.BRetorno.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRetorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRetorno.Location = New System.Drawing.Point(656, 10)
        Me.BRetorno.Name = "BRetorno"
        Me.BRetorno.Size = New System.Drawing.Size(50, 50)
        Me.BRetorno.TabIndex = 0
        Me.BRetorno.UseVisualStyleBackColor = False
        Me.BRetorno.Visible = False
        '
        'BOrdenC
        '
        Me.BOrdenC.BackColor = System.Drawing.Color.Transparent
        Me.BOrdenC.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_verificar_80
        Me.BOrdenC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOrdenC.Location = New System.Drawing.Point(81, 10)
        Me.BOrdenC.Name = "BOrdenC"
        Me.BOrdenC.Size = New System.Drawing.Size(50, 50)
        Me.BOrdenC.TabIndex = 2
        Me.BOrdenC.UseVisualStyleBackColor = False
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(246, 518)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LUsuario.TabIndex = 84
        Me.LUsuario.Visible = False
        '
        'LIDE
        '
        Me.LIDE.AutoSize = True
        Me.LIDE.Location = New System.Drawing.Point(335, 51)
        Me.LIDE.Name = "LIDE"
        Me.LIDE.Size = New System.Drawing.Size(0, 13)
        Me.LIDE.TabIndex = 85
        Me.LIDE.Visible = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_Producto"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle17
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ID.Text = ""
        Me.ID.Width = 40
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.DataPropertyName = "Nombre_Producto"
        Me.Nombre_Producto.FillWeight = 150.0!
        Me.Nombre_Producto.HeaderText = "Nombre del Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        Me.Nombre_Producto.Width = 295
        '
        'Clave_Producto
        '
        Me.Clave_Producto.DataPropertyName = "Clave_Producto"
        Me.Clave_Producto.HeaderText = "Clave del Producto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = True
        '
        'Exis
        '
        Me.Exis.DataPropertyName = "Existencia"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Exis.DefaultCellStyle = DataGridViewCellStyle18
        Me.Exis.HeaderText = "Existencia"
        Me.Exis.Name = "Exis"
        Me.Exis.ReadOnly = True
        Me.Exis.Width = 60
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1144, 726)
        Me.Controls.Add(Me.LIDE)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.BOrdenC)
        Me.Controls.Add(Me.BRetorno)
        Me.Controls.Add(Me.BGuardarMo)
        Me.Controls.Add(Me.BAgregarExistencia)
        Me.Controls.Add(Me.GDetalles)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BMostrarHist)
        Me.Controls.Add(Me.BNuevoProducto)
        Me.Controls.Add(Me.IA)
        Me.Controls.Add(Me.NameImagen)
        Me.Controls.Add(Me.BImagen)
        Me.Controls.Add(Me.LAdvet)
        Me.Controls.Add(Me.HURL)
        Me.Controls.Add(Me.AgregarExistencias)
        Me.Controls.Add(Me.GPUSD)
        Me.Controls.Add(Me.GTipoCambio)
        Me.Controls.Add(Me.Imagen)
        Me.Controls.Add(Me.GPrecio)
        Me.Controls.Add(Me.GCodigoBarras)
        Me.Controls.Add(Me.GCantidad)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.GDatos_Generales)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.POpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GDatos_Generales.ResumeLayout(False)
        Me.GDatos_Generales.PerformLayout()
        Me.GCantidad.ResumeLayout(False)
        Me.GCantidad.PerformLayout()
        Me.GDetalles.ResumeLayout(False)
        Me.GDetalles.PerformLayout()
        Me.GCodigoBarras.ResumeLayout(False)
        Me.GCodigoBarras.PerformLayout()
        Me.GPrecio.ResumeLayout(False)
        Me.GPrecio.PerformLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPUSD.ResumeLayout(False)
        Me.GPUSD.PerformLayout()
        Me.GTipoCambio.ResumeLayout(False)
        Me.GTipoCambio.PerformLayout()
        Me.AgregarExistencias.ResumeLayout(False)
        Me.AgregarExistencias.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GNExistencia.ResumeLayout(False)
        Me.GNExistencia.PerformLayout()
        CType(Me.PMenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OrdenCompra.ResumeLayout(False)
        Me.OrdenCompra.PerformLayout()
        Me.PUSD.ResumeLayout(False)
        Me.PUSD.PerformLayout()
        Me.GTCambio.ResumeLayout(False)
        Me.GTCambio.PerformLayout()
        Me.GPrecioUSD.ResumeLayout(False)
        Me.GPrecioUSD.PerformLayout()
        Me.PSeparador.ResumeLayout(False)
        Me.PSeparador.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents POpc As Panel
    Friend WithEvents DataView As DataGridView
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents GDatos_Generales As GroupBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents LMarca As Label
    Friend WithEvents TxtMedida As TextBox
    Friend WithEvents LUMedida As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LDescripcion As Label
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents TxtClaveP As TextBox
    Friend WithEvents LClave As Label
    Friend WithEvents LProducto As Label
    Friend WithEvents IDP As Label
    Friend WithEvents GCantidad As GroupBox
    Friend WithEvents LExitencia As Label
    Friend WithEvents TxtExistencia As TextBox
    Friend WithEvents LMínimo As Label
    Friend WithEvents TxtMinimo As TextBox
    Friend WithEvents LMáximo As Label
    Friend WithEvents TxtMaximo As TextBox
    Friend WithEvents GDetalles As GroupBox
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents TxtProceso As TextBox
    Friend WithEvents TxtArea As TextBox
    Friend WithEvents LArea As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents GCodigoBarras As GroupBox
    Friend WithEvents GPrecio As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents GPUSD As GroupBox
    Friend WithEvents TxtUSD As TextBox
    Friend WithEvents GTipoCambio As GroupBox
    Friend WithEvents TxtTipoCambio As TextBox
    Friend WithEvents AgregarExistencias As Panel
    Friend WithEvents HURL As Label
    Friend WithEvents LAdvet As Label
    Friend WithEvents PSeparador As Panel
    Friend WithEvents LTExistencias As Label
    Friend WithEvents LIdProducto As Label
    Friend WithEvents GNExistencia As GroupBox
    Friend WithEvents PMenos As PictureBox
    Friend WithEvents TxtNExistencia As TextBox
    Friend WithEvents LEntraP As Label
    Friend WithEvents GPrecioUSD As GroupBox
    Friend WithEvents TxtTUSD As TextBox
    Friend WithEvents LTUSD As Label
    Friend WithEvents TxtFUSD As TextBox
    Friend WithEvents TxtUUSD As TextBox
    Friend WithEvents LUUSD As Label
    Friend WithEvents LFUSD As Label
    Friend WithEvents DTTipoCambio As DateTimePicker
    Friend WithEvents GTCambio As GroupBox
    Friend WithEvents TCambio As TextBox
    Friend WithEvents MURL As Label
    Friend WithEvents LErrEP As Label
    Friend WithEvents TC As Timer
    Friend WithEvents PUSD As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LTotal As Label
    Friend WithEvents TxtUTotal As TextBox
    Friend WithEvents LUTotal As Label
    Friend WithEvents TxtUCPza As TextBox
    Friend WithEvents TxTUPza As TextBox
    Friend WithEvents LPUPZA As Label
    Friend WithEvents LUCPza As Label
    Friend WithEvents OrdenCompra As GroupBox
    Friend WithEvents TxtOrdenCompra As TextBox
    Friend WithEvents HTC As Timer
    Friend WithEvents CodigoBarras As IDAutomation.Windows.Forms.LinearBarCode.Barcode
    Friend WithEvents LMa As Label
    Friend WithEvents LM As Label
    Friend WithEvents LC As Label
    Friend WithEvents LP As Label
    Friend WithEvents LA As Label
    Friend WithEvents CMedida As ComboBox
    Friend WithEvents CMarca As ComboBox
    Friend WithEvents CCategoria As ComboBox
    Friend WithEvents CProceso As ComboBox
    Friend WithEvents CArea As ComboBox
    Friend WithEvents BImagen As Button
    Friend WithEvents NameImagen As Label
    Friend WithEvents IA As Label
    Friend WithEvents TxtCB As TextBox
    Friend WithEvents BNuevoProducto As Button
    Friend WithEvents BMostrarHist As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BAgregarExistencia As Button
    Friend WithEvents BGuardarMo As Button
    Friend WithEvents BRetorno As Button
    Friend WithEvents PCodigoBarras As Button
    Friend WithEvents BGExistencia As Button
    Friend WithEvents PCalendario As Button
    Friend WithEvents BOrdenC As Button
    Friend WithEvents LCS As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents LIDE As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Exis As DataGridViewTextBoxColumn
End Class
