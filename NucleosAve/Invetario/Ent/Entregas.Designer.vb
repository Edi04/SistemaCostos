<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entregas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entregas))
        Me.PLinea = New System.Windows.Forms.Panel()
        Me.DatosPM = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NumNomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RespS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.CProceso = New System.Windows.Forms.ComboBox()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.TxtProceso = New System.Windows.Forms.TextBox()
        Me.BBProducto = New System.Windows.Forms.Button()
        Me.BBTrabajador = New System.Windows.Forms.Button()
        Me.IDE = New System.Windows.Forms.Label()
        Me.IDP = New System.Windows.Forms.Label()
        Me.LResponsable = New System.Windows.Forms.Label()
        Me.txtResponsable = New System.Windows.Forms.TextBox()
        Me.IDD = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNN = New System.Windows.Forms.Label()
        Me.LEntrega = New System.Windows.Forms.Label()
        Me.TxtFEntrega = New System.Windows.Forms.TextBox()
        Me.TxtNN = New System.Windows.Forms.TextBox()
        Me.TxtTrabajador = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.LCalidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.IDPP = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGTrabajador = New System.Windows.Forms.DataGridView()
        Me.Id_Empleado = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Numero_Nomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTrabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTrabajador = New System.Windows.Forms.Panel()
        Me.TxtBusT = New System.Windows.Forms.TextBox()
        Me.PMaterial = New System.Windows.Forms.Panel()
        Me.TxtBMaterial = New System.Windows.Forms.TextBox()
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
        Me.BNuevoPrestamo = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BGEntrega = New System.Windows.Forms.Button()
        Me.BRIngreso = New System.Windows.Forms.Button()
        Me.ANuevoT = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        Me.LEx = New System.Windows.Forms.Label()
        Me.BEPP = New System.Windows.Forms.Button()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PDatos.SuspendLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTrabajador.SuspendLayout()
        Me.PMaterial.SuspendLayout()
        Me.PNT.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLinea
        '
        Me.PLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PLinea.BackColor = System.Drawing.Color.SteelBlue
        Me.PLinea.Location = New System.Drawing.Point(96, 55)
        Me.PLinea.Name = "PLinea"
        Me.PLinea.Size = New System.Drawing.Size(751, 11)
        Me.PLinea.TabIndex = 78
        '
        'DatosPM
        '
        Me.DatosPM.AllowUserToAddRows = False
        Me.DatosPM.AllowUserToDeleteRows = False
        Me.DatosPM.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DatosPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NumNomina, Me.NombreE, Me.NombreP, Me.Cantid, Me.FEntrega, Me.Descr, Me.RespS, Me.Proceso})
        Me.DatosPM.Location = New System.Drawing.Point(372, 117)
        Me.DatosPM.Name = "DatosPM"
        Me.DatosPM.ReadOnly = True
        Me.DatosPM.Size = New System.Drawing.Size(558, 403)
        Me.DatosPM.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_Entrega"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 35
        '
        'NumNomina
        '
        Me.NumNomina.DataPropertyName = "Numero_Nomina"
        Me.NumNomina.HeaderText = "Núm. Nómina"
        Me.NumNomina.Name = "NumNomina"
        Me.NumNomina.ReadOnly = True
        Me.NumNomina.Width = 50
        '
        'NombreE
        '
        Me.NombreE.DataPropertyName = "Nombre"
        Me.NombreE.HeaderText = "Trabajador"
        Me.NombreE.Name = "NombreE"
        Me.NombreE.ReadOnly = True
        Me.NombreE.Width = 150
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "Nombre_Producto"
        Me.NombreP.HeaderText = "Material"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 150
        '
        'Cantid
        '
        Me.Cantid.DataPropertyName = "Cantidad"
        Me.Cantid.HeaderText = "Cantidad"
        Me.Cantid.Name = "Cantid"
        Me.Cantid.ReadOnly = True
        Me.Cantid.Width = 50
        '
        'FEntrega
        '
        Me.FEntrega.DataPropertyName = "Fecha_Entrega"
        Me.FEntrega.HeaderText = "Fecha de Entrega"
        Me.FEntrega.Name = "FEntrega"
        Me.FEntrega.ReadOnly = True
        '
        'Descr
        '
        Me.Descr.DataPropertyName = "Descripcion"
        Me.Descr.HeaderText = "Descripción"
        Me.Descr.Name = "Descr"
        Me.Descr.ReadOnly = True
        '
        'RespS
        '
        Me.RespS.DataPropertyName = "ResponsableS"
        Me.RespS.HeaderText = "Responsable de Salida"
        Me.RespS.Name = "RespS"
        Me.RespS.ReadOnly = True
        '
        'Proceso
        '
        Me.Proceso.DataPropertyName = "Nombre_Proceso"
        Me.Proceso.HeaderText = "Proceso"
        Me.Proceso.Name = "Proceso"
        Me.Proceso.ReadOnly = True
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(285, 69)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(186, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Entrega de Materiales"
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(27, 113)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(339, 65)
        Me.GBusqueda.TabIndex = 1
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(83, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(147, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Número de Nómina, Producto"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(293, 12)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(44, 46)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(256, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'PDatos
        '
        Me.PDatos.BackColor = System.Drawing.Color.Transparent
        Me.PDatos.Controls.Add(Me.CProceso)
        Me.PDatos.Controls.Add(Me.LProceso)
        Me.PDatos.Controls.Add(Me.TxtProceso)
        Me.PDatos.Controls.Add(Me.BBProducto)
        Me.PDatos.Controls.Add(Me.BBTrabajador)
        Me.PDatos.Controls.Add(Me.IDE)
        Me.PDatos.Controls.Add(Me.IDP)
        Me.PDatos.Controls.Add(Me.LResponsable)
        Me.PDatos.Controls.Add(Me.txtResponsable)
        Me.PDatos.Controls.Add(Me.IDD)
        Me.PDatos.Controls.Add(Me.LDescripcion)
        Me.PDatos.Controls.Add(Me.LNN)
        Me.PDatos.Controls.Add(Me.LEntrega)
        Me.PDatos.Controls.Add(Me.TxtFEntrega)
        Me.PDatos.Controls.Add(Me.TxtNN)
        Me.PDatos.Controls.Add(Me.TxtTrabajador)
        Me.PDatos.Controls.Add(Me.TxtDescripcion)
        Me.PDatos.Controls.Add(Me.LNombre)
        Me.PDatos.Controls.Add(Me.TxtMaterial)
        Me.PDatos.Controls.Add(Me.LCalidad)
        Me.PDatos.Controls.Add(Me.TxtCantidad)
        Me.PDatos.Controls.Add(Me.LMaterial)
        Me.PDatos.Location = New System.Drawing.Point(34, 189)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(306, 331)
        Me.PDatos.TabIndex = 3
        '
        'CProceso
        '
        Me.CProceso.FormattingEnabled = True
        Me.CProceso.Location = New System.Drawing.Point(136, 264)
        Me.CProceso.Name = "CProceso"
        Me.CProceso.Size = New System.Drawing.Size(154, 21)
        Me.CProceso.TabIndex = 7
        Me.CProceso.Visible = False
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.BackColor = System.Drawing.Color.Transparent
        Me.LProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProceso.Location = New System.Drawing.Point(70, 267)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(59, 16)
        Me.LProceso.TabIndex = 0
        Me.LProceso.Text = "Proceso"
        '
        'TxtProceso
        '
        Me.TxtProceso.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtProceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProceso.Location = New System.Drawing.Point(135, 265)
        Me.TxtProceso.Multiline = True
        Me.TxtProceso.Name = "TxtProceso"
        Me.TxtProceso.ReadOnly = True
        Me.TxtProceso.Size = New System.Drawing.Size(155, 20)
        Me.TxtProceso.TabIndex = 0
        Me.TxtProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BBProducto
        '
        Me.BBProducto.BackColor = System.Drawing.Color.Transparent
        Me.BBProducto.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBProducto.Location = New System.Drawing.Point(277, 81)
        Me.BBProducto.Name = "BBProducto"
        Me.BBProducto.Size = New System.Drawing.Size(21, 21)
        Me.BBProducto.TabIndex = 5
        Me.BBProducto.UseVisualStyleBackColor = False
        Me.BBProducto.Visible = False
        '
        'BBTrabajador
        '
        Me.BBTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.BBTrabajador.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBTrabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBTrabajador.Location = New System.Drawing.Point(277, 12)
        Me.BBTrabajador.Name = "BBTrabajador"
        Me.BBTrabajador.Size = New System.Drawing.Size(21, 21)
        Me.BBTrabajador.TabIndex = 2
        Me.BBTrabajador.UseVisualStyleBackColor = False
        Me.BBTrabajador.Visible = False
        '
        'IDE
        '
        Me.IDE.AutoSize = True
        Me.IDE.Location = New System.Drawing.Point(7, 37)
        Me.IDE.Name = "IDE"
        Me.IDE.Size = New System.Drawing.Size(0, 13)
        Me.IDE.TabIndex = 100
        Me.IDE.Visible = False
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.Location = New System.Drawing.Point(4, 71)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 99
        Me.IDP.Visible = False
        '
        'LResponsable
        '
        Me.LResponsable.AutoSize = True
        Me.LResponsable.BackColor = System.Drawing.Color.Transparent
        Me.LResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResponsable.Location = New System.Drawing.Point(43, 293)
        Me.LResponsable.Name = "LResponsable"
        Me.LResponsable.Size = New System.Drawing.Size(90, 32)
        Me.LResponsable.TabIndex = 0
        Me.LResponsable.Text = "Responsable" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Entrega"
        '
        'txtResponsable
        '
        Me.txtResponsable.BackColor = System.Drawing.Color.Gainsboro
        Me.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResponsable.Location = New System.Drawing.Point(136, 299)
        Me.txtResponsable.Multiline = True
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(155, 20)
        Me.txtResponsable.TabIndex = 9
        Me.txtResponsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.Location = New System.Drawing.Point(52, 176)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.LDescripcion.TabIndex = 0
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
        Me.LNN.TabIndex = 0
        Me.LNN.Text = "Núm. de Nómina"
        Me.LNN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LEntrega
        '
        Me.LEntrega.AutoSize = True
        Me.LEntrega.BackColor = System.Drawing.Color.Transparent
        Me.LEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntrega.Location = New System.Drawing.Point(18, 149)
        Me.LEntrega.Name = "LEntrega"
        Me.LEntrega.Size = New System.Drawing.Size(115, 16)
        Me.LEntrega.TabIndex = 0
        Me.LEntrega.Text = "Fecha de Entrega"
        '
        'TxtFEntrega
        '
        Me.TxtFEntrega.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtFEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFEntrega.Location = New System.Drawing.Point(136, 148)
        Me.TxtFEntrega.Multiline = True
        Me.TxtFEntrega.Name = "TxtFEntrega"
        Me.TxtFEntrega.ReadOnly = True
        Me.TxtFEntrega.Size = New System.Drawing.Size(155, 20)
        Me.TxtFEntrega.TabIndex = 7
        Me.TxtFEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNN
        '
        Me.TxtNN.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNN.Location = New System.Drawing.Point(136, 12)
        Me.TxtNN.Multiline = True
        Me.TxtNN.Name = "TxtNN"
        Me.TxtNN.ReadOnly = True
        Me.TxtNN.Size = New System.Drawing.Size(139, 20)
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
        Me.TxtTrabajador.ReadOnly = True
        Me.TxtTrabajador.Size = New System.Drawing.Size(155, 36)
        Me.TxtTrabajador.TabIndex = 3
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(136, 176)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(155, 83)
        Me.TxtDescripcion.TabIndex = 8
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.BackColor = System.Drawing.Color.Transparent
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.Location = New System.Drawing.Point(56, 39)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(76, 16)
        Me.LNombre.TabIndex = 0
        Me.LNombre.Text = "Trabajador"
        '
        'TxtMaterial
        '
        Me.TxtMaterial.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMaterial.Location = New System.Drawing.Point(136, 80)
        Me.TxtMaterial.Multiline = True
        Me.TxtMaterial.Name = "TxtMaterial"
        Me.TxtMaterial.ReadOnly = True
        Me.TxtMaterial.Size = New System.Drawing.Size(139, 35)
        Me.TxtMaterial.TabIndex = 4
        '
        'LCalidad
        '
        Me.LCalidad.AutoSize = True
        Me.LCalidad.BackColor = System.Drawing.Color.Transparent
        Me.LCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCalidad.Location = New System.Drawing.Point(70, 122)
        Me.LCalidad.Name = "LCalidad"
        Me.LCalidad.Size = New System.Drawing.Size(62, 16)
        Me.LCalidad.TabIndex = 0
        Me.LCalidad.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.Location = New System.Drawing.Point(136, 121)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(155, 20)
        Me.TxtCantidad.TabIndex = 6
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.BackColor = System.Drawing.Color.Transparent
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.Location = New System.Drawing.Point(76, 81)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(56, 16)
        Me.LMaterial.TabIndex = 0
        Me.LMaterial.Text = "Material"
        '
        'DGProducto
        '
        Me.DGProducto.AllowUserToAddRows = False
        Me.DGProducto.AllowUserToDeleteRows = False
        Me.DGProducto.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDPP, Me.Produto, Me.CodigoP, Me.Existencia})
        Me.DGProducto.Location = New System.Drawing.Point(3, 46)
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.ReadOnly = True
        Me.DGProducto.Size = New System.Drawing.Size(301, 162)
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
        'Existencia
        '
        Me.Existencia.DataPropertyName = "Existencia"
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 50
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
        Me.DGTrabajador.Size = New System.Drawing.Size(308, 229)
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
        'PTrabajador
        '
        Me.PTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.PTrabajador.Controls.Add(Me.TxtBusT)
        Me.PTrabajador.Controls.Add(Me.DGTrabajador)
        Me.PTrabajador.Location = New System.Drawing.Point(32, 248)
        Me.PTrabajador.Name = "PTrabajador"
        Me.PTrabajador.Size = New System.Drawing.Size(308, 272)
        Me.PTrabajador.TabIndex = 4
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
        'PMaterial
        '
        Me.PMaterial.BackColor = System.Drawing.Color.Transparent
        Me.PMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PMaterial.Controls.Add(Me.TxtBMaterial)
        Me.PMaterial.Controls.Add(Me.DGProducto)
        Me.PMaterial.Location = New System.Drawing.Point(33, 308)
        Me.PMaterial.Name = "PMaterial"
        Me.PMaterial.Size = New System.Drawing.Size(307, 212)
        Me.PMaterial.TabIndex = 5
        Me.PMaterial.Visible = False
        '
        'TxtBMaterial
        '
        Me.TxtBMaterial.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TxtBMaterial.Location = New System.Drawing.Point(9, 10)
        Me.TxtBMaterial.Multiline = True
        Me.TxtBMaterial.Name = "TxtBMaterial"
        Me.TxtBMaterial.Size = New System.Drawing.Size(288, 31)
        Me.TxtBMaterial.TabIndex = 1
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
        Me.PNT.Location = New System.Drawing.Point(324, 179)
        Me.PNT.Name = "PNT"
        Me.PNT.Size = New System.Drawing.Size(210, 242)
        Me.PNT.TabIndex = 6
        Me.PNT.Visible = False
        '
        'BRNT
        '
        Me.BRNT.BackColor = System.Drawing.Color.Transparent
        Me.BRNT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BRNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRNT.Location = New System.Drawing.Point(120, 203)
        Me.BRNT.Name = "BRNT"
        Me.BRNT.Size = New System.Drawing.Size(37, 34)
        Me.BRNT.TabIndex = 6
        Me.BRNT.UseVisualStyleBackColor = False
        '
        'BGNT
        '
        Me.BGNT.BackColor = System.Drawing.Color.Transparent
        Me.BGNT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGNT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGNT.Location = New System.Drawing.Point(61, 203)
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
        'BNuevoPrestamo
        '
        Me.BNuevoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.BNuevoPrestamo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file1
        Me.BNuevoPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BNuevoPrestamo.Location = New System.Drawing.Point(12, 3)
        Me.BNuevoPrestamo.Name = "BNuevoPrestamo"
        Me.BNuevoPrestamo.Size = New System.Drawing.Size(50, 50)
        Me.BNuevoPrestamo.TabIndex = 0
        Me.BNuevoPrestamo.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(892, 0)
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
        Me.BMinimizar.Location = New System.Drawing.Point(843, 0)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 0
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(533, 3)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 0
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'BGEntrega
        '
        Me.BGEntrega.BackColor = System.Drawing.Color.Transparent
        Me.BGEntrega.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGEntrega.Location = New System.Drawing.Point(477, 3)
        Me.BGEntrega.Name = "BGEntrega"
        Me.BGEntrega.Size = New System.Drawing.Size(50, 50)
        Me.BGEntrega.TabIndex = 0
        Me.BGEntrega.UseVisualStyleBackColor = False
        Me.BGEntrega.Visible = False
        '
        'BRIngreso
        '
        Me.BRIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BRIngreso.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRIngreso.Location = New System.Drawing.Point(421, 3)
        Me.BRIngreso.Name = "BRIngreso"
        Me.BRIngreso.Size = New System.Drawing.Size(50, 50)
        Me.BRIngreso.TabIndex = 0
        Me.BRIngreso.UseVisualStyleBackColor = False
        Me.BRIngreso.Visible = False
        '
        'ANuevoT
        '
        Me.ANuevoT.BackColor = System.Drawing.Color.Transparent
        Me.ANuevoT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.user_40
        Me.ANuevoT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANuevoT.Location = New System.Drawing.Point(365, 3)
        Me.ANuevoT.Name = "ANuevoT"
        Me.ANuevoT.Size = New System.Drawing.Size(50, 50)
        Me.ANuevoT.TabIndex = 0
        Me.ANuevoT.UseVisualStyleBackColor = False
        Me.ANuevoT.Visible = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(274, 22)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 79
        Me.LCS.Visible = False
        '
        'LEx
        '
        Me.LEx.AutoSize = True
        Me.LEx.Location = New System.Drawing.Point(318, 97)
        Me.LEx.Name = "LEx"
        Me.LEx.Size = New System.Drawing.Size(0, 13)
        Me.LEx.TabIndex = 80
        Me.LEx.Visible = False
        '
        'BEPP
        '
        Me.BEPP.BackColor = System.Drawing.Color.Transparent
        Me.BEPP.BackgroundImage = CType(resources.GetObject("BEPP.BackgroundImage"), System.Drawing.Image)
        Me.BEPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEPP.Location = New System.Drawing.Point(80, 3)
        Me.BEPP.Name = "BEPP"
        Me.BEPP.Size = New System.Drawing.Size(50, 50)
        Me.BEPP.TabIndex = 81
        Me.BEPP.UseVisualStyleBackColor = False
        '
        'Entregas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(942, 520)
        Me.Controls.Add(Me.BEPP)
        Me.Controls.Add(Me.LEx)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.PNT)
        Me.Controls.Add(Me.ANuevoT)
        Me.Controls.Add(Me.BRIngreso)
        Me.Controls.Add(Me.BGEntrega)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BNuevoPrestamo)
        Me.Controls.Add(Me.PMaterial)
        Me.Controls.Add(Me.PTrabajador)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.DatosPM)
        Me.Controls.Add(Me.PLinea)
        Me.Controls.Add(Me.PDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entregas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entregas"
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTrabajador.ResumeLayout(False)
        Me.PTrabajador.PerformLayout()
        Me.PMaterial.ResumeLayout(False)
        Me.PMaterial.PerformLayout()
        Me.PNT.ResumeLayout(False)
        Me.PNT.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PLinea As Panel
    Friend WithEvents DatosPM As DataGridView
    Friend WithEvents LTitulo As Label
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PDatos As Panel
    Friend WithEvents IDD As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNN As Label
    Friend WithEvents LEntrega As Label
    Friend WithEvents TxtFEntrega As TextBox
    Friend WithEvents TxtNN As TextBox
    Friend WithEvents TxtTrabajador As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TxtMaterial As TextBox
    Friend WithEvents LCalidad As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LMaterial As Label
    Friend WithEvents LResponsable As Label
    Friend WithEvents txtResponsable As TextBox
    Friend WithEvents DGProducto As DataGridView
    Friend WithEvents IDP As Label
    Friend WithEvents IDE As Label
    Friend WithEvents DGTrabajador As DataGridView
    Friend WithEvents Id_Empleado As DataGridViewLinkColumn
    Friend WithEvents Numero_Nomina As DataGridViewTextBoxColumn
    Friend WithEvents NTrabajador As DataGridViewTextBoxColumn
    Friend WithEvents PTrabajador As Panel
    Friend WithEvents TxtBusT As TextBox
    Friend WithEvents PMaterial As Panel
    Friend WithEvents TxtBMaterial As TextBox
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
    Friend WithEvents BBProducto As Button
    Friend WithEvents BBTrabajador As Button
    Friend WithEvents BRNT As Button
    Friend WithEvents BGNT As Button
    Friend WithEvents BNuevoPrestamo As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BGEntrega As Button
    Friend WithEvents BRIngreso As Button
    Friend WithEvents ANuevoT As Button
    Friend WithEvents LCS As Label
    Friend WithEvents IDPP As DataGridViewLinkColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoP As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents LEx As Label
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents NumNomina As DataGridViewTextBoxColumn
    Friend WithEvents NombreE As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents Cantid As DataGridViewTextBoxColumn
    Friend WithEvents FEntrega As DataGridViewTextBoxColumn
    Friend WithEvents Descr As DataGridViewTextBoxColumn
    Friend WithEvents RespS As DataGridViewTextBoxColumn
    Friend WithEvents Proceso As DataGridViewTextBoxColumn
    Friend WithEvents CProceso As ComboBox
    Friend WithEvents LProceso As Label
    Friend WithEvents TxtProceso As TextBox
    Friend WithEvents BEPP As Button
End Class
