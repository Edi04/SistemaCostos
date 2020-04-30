<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregasEPP
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
        Me.TxtResponsable = New System.Windows.Forms.Label()
        Me.LCS = New System.Windows.Forms.Label()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.BBBMaterial = New System.Windows.Forms.Button()
        Me.BBTrabajador = New System.Windows.Forms.Button()
        Me.CProceso = New System.Windows.Forms.ComboBox()
        Me.IDD = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.TxtProceso = New System.Windows.Forms.TextBox()
        Me.IDE = New System.Windows.Forms.Label()
        Me.IDP = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.LNN = New System.Windows.Forms.Label()
        Me.TxtNN = New System.Windows.Forms.TextBox()
        Me.TxtTrabajador = New System.Windows.Forms.TextBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.LCalidad = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.DatosPM = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NumNomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLinea = New System.Windows.Forms.Panel()
        Me.CEPendientes = New System.Windows.Forms.CheckBox()
        Me.BNuevoPrestamo = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.ANuevoT = New System.Windows.Forms.Button()
        Me.BRIngreso = New System.Windows.Forms.Button()
        Me.BGEntrega = New System.Windows.Forms.Button()
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
        Me.PMaterial = New System.Windows.Forms.Panel()
        Me.TxtBMaterial = New System.Windows.Forms.TextBox()
        Me.DGProducto = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PTrabajador = New System.Windows.Forms.Panel()
        Me.TxtBusT = New System.Windows.Forms.TextBox()
        Me.DGTrabajador = New System.Windows.Forms.DataGridView()
        Me.Id_Empleado = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Numero_Nomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NTrabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEx = New System.Windows.Forms.Label()
        Me.PDatos.SuspendLayout()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNT.SuspendLayout()
        Me.PMaterial.SuspendLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PTrabajador.SuspendLayout()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtResponsable
        '
        Me.TxtResponsable.AutoSize = True
        Me.TxtResponsable.Location = New System.Drawing.Point(687, 83)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(0, 13)
        Me.TxtResponsable.TabIndex = 96
        Me.TxtResponsable.Visible = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(649, 77)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 95
        Me.LCS.Visible = False
        '
        'PDatos
        '
        Me.PDatos.BackColor = System.Drawing.Color.Transparent
        Me.PDatos.Controls.Add(Me.BBBMaterial)
        Me.PDatos.Controls.Add(Me.BBTrabajador)
        Me.PDatos.Controls.Add(Me.CProceso)
        Me.PDatos.Controls.Add(Me.IDD)
        Me.PDatos.Controls.Add(Me.LProceso)
        Me.PDatos.Controls.Add(Me.TxtProceso)
        Me.PDatos.Controls.Add(Me.IDE)
        Me.PDatos.Controls.Add(Me.IDP)
        Me.PDatos.Controls.Add(Me.LDescripcion)
        Me.PDatos.Controls.Add(Me.LNN)
        Me.PDatos.Controls.Add(Me.TxtNN)
        Me.PDatos.Controls.Add(Me.TxtTrabajador)
        Me.PDatos.Controls.Add(Me.TxtDescripcion)
        Me.PDatos.Controls.Add(Me.LNombre)
        Me.PDatos.Controls.Add(Me.TxtMaterial)
        Me.PDatos.Controls.Add(Me.LCalidad)
        Me.PDatos.Controls.Add(Me.TxtCantidad)
        Me.PDatos.Controls.Add(Me.LMaterial)
        Me.PDatos.Location = New System.Drawing.Point(11, 168)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(306, 331)
        Me.PDatos.TabIndex = 94
        '
        'BBBMaterial
        '
        Me.BBBMaterial.BackColor = System.Drawing.Color.Transparent
        Me.BBBMaterial.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBBMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBBMaterial.Location = New System.Drawing.Point(270, 80)
        Me.BBBMaterial.Name = "BBBMaterial"
        Me.BBBMaterial.Size = New System.Drawing.Size(21, 21)
        Me.BBBMaterial.TabIndex = 103
        Me.BBBMaterial.UseVisualStyleBackColor = False
        Me.BBBMaterial.Visible = False
        '
        'BBTrabajador
        '
        Me.BBTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.BBTrabajador.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.BBTrabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BBTrabajador.Location = New System.Drawing.Point(273, 10)
        Me.BBTrabajador.Name = "BBTrabajador"
        Me.BBTrabajador.Size = New System.Drawing.Size(21, 21)
        Me.BBTrabajador.TabIndex = 102
        Me.BBTrabajador.UseVisualStyleBackColor = False
        Me.BBTrabajador.Visible = False
        '
        'CProceso
        '
        Me.CProceso.FormattingEnabled = True
        Me.CProceso.Location = New System.Drawing.Point(137, 236)
        Me.CProceso.Name = "CProceso"
        Me.CProceso.Size = New System.Drawing.Size(154, 21)
        Me.CProceso.TabIndex = 101
        Me.CProceso.Visible = False
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
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.BackColor = System.Drawing.Color.Transparent
        Me.LProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProceso.Location = New System.Drawing.Point(70, 238)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(59, 16)
        Me.LProceso.TabIndex = 0
        Me.LProceso.Text = "Proceso"
        '
        'TxtProceso
        '
        Me.TxtProceso.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtProceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtProceso.Location = New System.Drawing.Point(135, 236)
        Me.TxtProceso.Multiline = True
        Me.TxtProceso.Name = "TxtProceso"
        Me.TxtProceso.ReadOnly = True
        Me.TxtProceso.Size = New System.Drawing.Size(155, 20)
        Me.TxtProceso.TabIndex = 0
        Me.TxtProceso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.Location = New System.Drawing.Point(52, 147)
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
        'TxtNN
        '
        Me.TxtNN.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNN.Location = New System.Drawing.Point(136, 12)
        Me.TxtNN.Multiline = True
        Me.TxtNN.Name = "TxtNN"
        Me.TxtNN.ReadOnly = True
        Me.TxtNN.Size = New System.Drawing.Size(133, 20)
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
        Me.TxtDescripcion.Location = New System.Drawing.Point(136, 147)
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
        Me.TxtMaterial.Size = New System.Drawing.Size(133, 35)
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
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(905, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 88
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(954, 1)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 89
        Me.BCerrar.UseVisualStyleBackColor = False
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
        Me.GBusqueda.Location = New System.Drawing.Point(2, 97)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(454, 65)
        Me.GBusqueda.TabIndex = 91
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
        Me.PBusqueda.Location = New System.Drawing.Point(404, 13)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(376, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(334, 68)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(274, 20)
        Me.LTitulo.TabIndex = 90
        Me.LTitulo.Text = "Entrega de Equipo de Protección"
        '
        'DatosPM
        '
        Me.DatosPM.AllowUserToAddRows = False
        Me.DatosPM.AllowUserToDeleteRows = False
        Me.DatosPM.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DatosPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NumNomina, Me.NombreE, Me.IdPP, Me.NombreP, Me.Cantid, Me.Descripcion, Me.Proceso})
        Me.DatosPM.Location = New System.Drawing.Point(323, 165)
        Me.DatosPM.Name = "DatosPM"
        Me.DatosPM.ReadOnly = True
        Me.DatosPM.Size = New System.Drawing.Size(679, 348)
        Me.DatosPM.TabIndex = 92
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
        Me.NombreE.Width = 200
        '
        'IdPP
        '
        Me.IdPP.DataPropertyName = "Id_Producto"
        Me.IdPP.HeaderText = "IDPP"
        Me.IdPP.Name = "IdPP"
        Me.IdPP.ReadOnly = True
        Me.IdPP.Visible = False
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "Nombre_Producto"
        Me.NombreP.HeaderText = "Material"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 200
        '
        'Cantid
        '
        Me.Cantid.DataPropertyName = "Cantidad"
        Me.Cantid.HeaderText = "Cantidad"
        Me.Cantid.Name = "Cantid"
        Me.Cantid.ReadOnly = True
        Me.Cantid.Width = 50
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Visible = False
        '
        'Proceso
        '
        Me.Proceso.DataPropertyName = "Nombre_Proceso"
        Me.Proceso.HeaderText = "Proceso"
        Me.Proceso.Name = "Proceso"
        Me.Proceso.ReadOnly = True
        '
        'PLinea
        '
        Me.PLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PLinea.BackColor = System.Drawing.Color.SteelBlue
        Me.PLinea.Location = New System.Drawing.Point(-10, 54)
        Me.PLinea.Name = "PLinea"
        Me.PLinea.Size = New System.Drawing.Size(1001, 11)
        Me.PLinea.TabIndex = 93
        '
        'CEPendientes
        '
        Me.CEPendientes.AutoSize = True
        Me.CEPendientes.BackColor = System.Drawing.Color.Transparent
        Me.CEPendientes.Checked = True
        Me.CEPendientes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CEPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CEPendientes.Location = New System.Drawing.Point(586, 136)
        Me.CEPendientes.Name = "CEPendientes"
        Me.CEPendientes.Size = New System.Drawing.Size(196, 24)
        Me.CEPendientes.TabIndex = 97
        Me.CEPendientes.Text = "Entregas Pendientes"
        Me.CEPendientes.UseVisualStyleBackColor = False
        '
        'BNuevoPrestamo
        '
        Me.BNuevoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.BNuevoPrestamo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file1
        Me.BNuevoPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BNuevoPrestamo.Location = New System.Drawing.Point(11, 1)
        Me.BNuevoPrestamo.Name = "BNuevoPrestamo"
        Me.BNuevoPrestamo.Size = New System.Drawing.Size(50, 50)
        Me.BNuevoPrestamo.TabIndex = 98
        Me.BNuevoPrestamo.UseVisualStyleBackColor = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(637, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 99
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'ANuevoT
        '
        Me.ANuevoT.BackColor = System.Drawing.Color.Transparent
        Me.ANuevoT.BackgroundImage = Global.NucleosAve.My.Resources.Resources.user_40
        Me.ANuevoT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ANuevoT.Location = New System.Drawing.Point(469, 2)
        Me.ANuevoT.Name = "ANuevoT"
        Me.ANuevoT.Size = New System.Drawing.Size(50, 50)
        Me.ANuevoT.TabIndex = 100
        Me.ANuevoT.UseVisualStyleBackColor = False
        Me.ANuevoT.Visible = False
        '
        'BRIngreso
        '
        Me.BRIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BRIngreso.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRIngreso.Location = New System.Drawing.Point(525, 2)
        Me.BRIngreso.Name = "BRIngreso"
        Me.BRIngreso.Size = New System.Drawing.Size(50, 50)
        Me.BRIngreso.TabIndex = 101
        Me.BRIngreso.UseVisualStyleBackColor = False
        Me.BRIngreso.Visible = False
        '
        'BGEntrega
        '
        Me.BGEntrega.BackColor = System.Drawing.Color.Transparent
        Me.BGEntrega.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGEntrega.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGEntrega.Location = New System.Drawing.Point(581, 2)
        Me.BGEntrega.Name = "BGEntrega"
        Me.BGEntrega.Size = New System.Drawing.Size(50, 50)
        Me.BGEntrega.TabIndex = 102
        Me.BGEntrega.UseVisualStyleBackColor = False
        Me.BGEntrega.Visible = False
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
        Me.PNT.Location = New System.Drawing.Point(306, 158)
        Me.PNT.Name = "PNT"
        Me.PNT.Size = New System.Drawing.Size(210, 242)
        Me.PNT.TabIndex = 29
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
        'PMaterial
        '
        Me.PMaterial.BackColor = System.Drawing.Color.Transparent
        Me.PMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PMaterial.Controls.Add(Me.TxtBMaterial)
        Me.PMaterial.Controls.Add(Me.DGProducto)
        Me.PMaterial.Location = New System.Drawing.Point(11, 287)
        Me.PMaterial.Name = "PMaterial"
        Me.PMaterial.Size = New System.Drawing.Size(307, 212)
        Me.PMaterial.TabIndex = 28
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
        'DGProducto
        '
        Me.DGProducto.AllowUserToAddRows = False
        Me.DGProducto.AllowUserToDeleteRows = False
        Me.DGProducto.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DGProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1, Me.Produto, Me.CodigoP, Me.Existencia})
        Me.DGProducto.Location = New System.Drawing.Point(3, 46)
        Me.DGProducto.Name = "DGProducto"
        Me.DGProducto.ReadOnly = True
        Me.DGProducto.Size = New System.Drawing.Size(301, 162)
        Me.DGProducto.TabIndex = 2
        '
        'DataGridViewLinkColumn1
        '
        Me.DataGridViewLinkColumn1.DataPropertyName = "Id_Producto"
        Me.DataGridViewLinkColumn1.HeaderText = "ID"
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
        Me.DataGridViewLinkColumn1.ReadOnly = True
        Me.DataGridViewLinkColumn1.Width = 40
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
        'PTrabajador
        '
        Me.PTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.PTrabajador.Controls.Add(Me.TxtBusT)
        Me.PTrabajador.Controls.Add(Me.DGTrabajador)
        Me.PTrabajador.Location = New System.Drawing.Point(10, 227)
        Me.PTrabajador.Name = "PTrabajador"
        Me.PTrabajador.Size = New System.Drawing.Size(308, 272)
        Me.PTrabajador.TabIndex = 27
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
        'LEx
        '
        Me.LEx.AutoSize = True
        Me.LEx.Location = New System.Drawing.Point(726, 109)
        Me.LEx.Name = "LEx"
        Me.LEx.Size = New System.Drawing.Size(0, 13)
        Me.LEx.TabIndex = 103
        Me.LEx.Visible = False
        '
        'EntregasEPP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1006, 520)
        Me.Controls.Add(Me.LEx)
        Me.Controls.Add(Me.PNT)
        Me.Controls.Add(Me.ANuevoT)
        Me.Controls.Add(Me.PMaterial)
        Me.Controls.Add(Me.BRIngreso)
        Me.Controls.Add(Me.PTrabajador)
        Me.Controls.Add(Me.BGEntrega)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BNuevoPrestamo)
        Me.Controls.Add(Me.CEPendientes)
        Me.Controls.Add(Me.TxtResponsable)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.DatosPM)
        Me.Controls.Add(Me.PLinea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EntregasEPP"
        Me.Text = "EntregasEPP"
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNT.ResumeLayout(False)
        Me.PNT.PerformLayout()
        Me.PMaterial.ResumeLayout(False)
        Me.PMaterial.PerformLayout()
        CType(Me.DGProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PTrabajador.ResumeLayout(False)
        Me.PTrabajador.PerformLayout()
        CType(Me.DGTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtResponsable As Label
    Friend WithEvents LCS As Label
    Friend WithEvents PDatos As Panel
    Friend WithEvents IDD As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents TxtProceso As TextBox
    Friend WithEvents IDE As Label
    Friend WithEvents IDP As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents LNN As Label
    Friend WithEvents TxtNN As TextBox
    Friend WithEvents TxtTrabajador As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TxtMaterial As TextBox
    Friend WithEvents LCalidad As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LMaterial As Label
    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LTitulo As Label
    Friend WithEvents DatosPM As DataGridView
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents NumNomina As DataGridViewTextBoxColumn
    Friend WithEvents NombreE As DataGridViewTextBoxColumn
    Friend WithEvents IdPP As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents Cantid As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Proceso As DataGridViewTextBoxColumn
    Friend WithEvents PLinea As Panel
    Friend WithEvents CEPendientes As CheckBox
    Friend WithEvents CProceso As ComboBox
    Friend WithEvents BNuevoPrestamo As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents ANuevoT As Button
    Friend WithEvents BRIngreso As Button
    Friend WithEvents BGEntrega As Button
    Friend WithEvents BBBMaterial As Button
    Friend WithEvents BBTrabajador As Button
    Friend WithEvents PNT As Panel
    Friend WithEvents BRNT As Button
    Friend WithEvents BGNT As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtAM As TextBox
    Friend WithEvents TxtAP As TextBox
    Friend WithEvents TxtNNN As TextBox
    Friend WithEvents LAM As Label
    Friend WithEvents LAP As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LN As Label
    Friend WithEvents LT As Label
    Friend WithEvents PMaterial As Panel
    Friend WithEvents TxtBMaterial As TextBox
    Friend WithEvents DGProducto As DataGridView
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents CodigoP As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
    Friend WithEvents PTrabajador As Panel
    Friend WithEvents TxtBusT As TextBox
    Friend WithEvents DGTrabajador As DataGridView
    Friend WithEvents Id_Empleado As DataGridViewLinkColumn
    Friend WithEvents Numero_Nomina As DataGridViewTextBoxColumn
    Friend WithEvents NTrabajador As DataGridViewTextBoxColumn
    Friend WithEvents LEx As Label
End Class
