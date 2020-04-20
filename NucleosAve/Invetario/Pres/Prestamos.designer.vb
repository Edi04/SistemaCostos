<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prestamos
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
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DatosPM = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.NombreE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNN = New System.Windows.Forms.Label()
        Me.TxtNN = New System.Windows.Forms.TextBox()
        Me.TxtTrabajador = New System.Windows.Forms.TextBox()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.TxtMaterial = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.LCalidad = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LFP = New System.Windows.Forms.Label()
        Me.LEntrega = New System.Windows.Forms.Label()
        Me.PDatos = New System.Windows.Forms.Panel()
        Me.DTFEntrega = New System.Windows.Forms.DateTimePicker()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.IDD = New System.Windows.Forms.Label()
        Me.TxtFPrestamo = New System.Windows.Forms.TextBox()
        Me.TxtDSalida = New System.Windows.Forms.TextBox()
        Me.LSalidaDetalle = New System.Windows.Forms.Label()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.TxtFEntrega = New System.Windows.Forms.TextBox()
        Me.PIngreso = New System.Windows.Forms.Panel()
        Me.TxtConIngreso = New System.Windows.Forms.TextBox()
        Me.LCondE = New System.Windows.Forms.Label()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BGuardarMo = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BGIngreso = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BRIngreso = New System.Windows.Forms.Button()
        Me.BIngreso = New System.Windows.Forms.Button()
        Me.BRetorno = New System.Windows.Forms.Button()
        Me.BNuevoPrestamo = New System.Windows.Forms.Button()
        Me.BMostrarHist = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PDatos.SuspendLayout()
        Me.PIngreso.SuspendLayout()
        Me.SuspendLayout()
        '
        'PLinea
        '
        Me.PLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PLinea.BackColor = System.Drawing.Color.SteelBlue
        Me.PLinea.Location = New System.Drawing.Point(42, 53)
        Me.PLinea.Name = "PLinea"
        Me.PLinea.Size = New System.Drawing.Size(691, 11)
        Me.PLinea.TabIndex = 75
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(267, 67)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(198, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Prestamo de Materiales"
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
        Me.GBusqueda.Size = New System.Drawing.Size(353, 65)
        Me.GBusqueda.TabIndex = 1
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(85, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(147, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Número de Nómina, Producto"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(303, 11)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(275, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'DatosPM
        '
        Me.DatosPM.AllowUserToAddRows = False
        Me.DatosPM.AllowUserToDeleteRows = False
        Me.DatosPM.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DatosPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NombreE, Me.NombreP, Me.FechaEnt})
        Me.DatosPM.Location = New System.Drawing.Point(355, 97)
        Me.DatosPM.Name = "DatosPM"
        Me.DatosPM.ReadOnly = True
        Me.DatosPM.Size = New System.Drawing.Size(419, 395)
        Me.DatosPM.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_Prestamo"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 35
        '
        'NombreE
        '
        Me.NombreE.DataPropertyName = "Nombre"
        Me.NombreE.HeaderText = "Trabajador"
        Me.NombreE.Name = "NombreE"
        Me.NombreE.ReadOnly = True
        Me.NombreE.Width = 120
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "Nombre_Producto"
        Me.NombreP.HeaderText = "Material"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 120
        '
        'FechaEnt
        '
        Me.FechaEnt.DataPropertyName = "Fecha_Entrega"
        Me.FechaEnt.HeaderText = "Entrega"
        Me.FechaEnt.Name = "FechaEnt"
        Me.FechaEnt.ReadOnly = True
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
        'TxtNN
        '
        Me.TxtNN.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNN.Location = New System.Drawing.Point(136, 12)
        Me.TxtNN.Multiline = True
        Me.TxtNN.Name = "TxtNN"
        Me.TxtNN.ReadOnly = True
        Me.TxtNN.Size = New System.Drawing.Size(155, 20)
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
        Me.TxtTrabajador.Size = New System.Drawing.Size(155, 20)
        Me.TxtTrabajador.TabIndex = 2
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
        Me.TxtMaterial.ReadOnly = True
        Me.TxtMaterial.Size = New System.Drawing.Size(155, 20)
        Me.TxtMaterial.TabIndex = 3
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
        'TxtCantidad
        '
        Me.TxtCantidad.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCantidad.Location = New System.Drawing.Point(136, 90)
        Me.TxtCantidad.Multiline = True
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.ReadOnly = True
        Me.TxtCantidad.Size = New System.Drawing.Size(155, 20)
        Me.TxtCantidad.TabIndex = 4
        Me.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(136, 170)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(155, 60)
        Me.TxtDescripcion.TabIndex = 7
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
        'PDatos
        '
        Me.PDatos.BackColor = System.Drawing.Color.Transparent
        Me.PDatos.Controls.Add(Me.DTFEntrega)
        Me.PDatos.Controls.Add(Me.LUsuario)
        Me.PDatos.Controls.Add(Me.IDD)
        Me.PDatos.Controls.Add(Me.TxtFPrestamo)
        Me.PDatos.Controls.Add(Me.TxtDSalida)
        Me.PDatos.Controls.Add(Me.LSalidaDetalle)
        Me.PDatos.Controls.Add(Me.LDescripcion)
        Me.PDatos.Controls.Add(Me.LNN)
        Me.PDatos.Controls.Add(Me.LEntrega)
        Me.PDatos.Controls.Add(Me.TxtFEntrega)
        Me.PDatos.Controls.Add(Me.TxtNN)
        Me.PDatos.Controls.Add(Me.TxtTrabajador)
        Me.PDatos.Controls.Add(Me.LFP)
        Me.PDatos.Controls.Add(Me.TxtDescripcion)
        Me.PDatos.Controls.Add(Me.LNombre)
        Me.PDatos.Controls.Add(Me.TxtMaterial)
        Me.PDatos.Controls.Add(Me.LCalidad)
        Me.PDatos.Controls.Add(Me.TxtCantidad)
        Me.PDatos.Controls.Add(Me.LMaterial)
        Me.PDatos.Location = New System.Drawing.Point(22, 180)
        Me.PDatos.Name = "PDatos"
        Me.PDatos.Size = New System.Drawing.Size(306, 312)
        Me.PDatos.TabIndex = 3
        '
        'DTFEntrega
        '
        Me.DTFEntrega.Location = New System.Drawing.Point(136, 143)
        Me.DTFEntrega.Name = "DTFEntrega"
        Me.DTFEntrega.Size = New System.Drawing.Size(155, 20)
        Me.DTFEntrega.TabIndex = 95
        Me.DTFEntrega.Visible = False
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
        'TxtFPrestamo
        '
        Me.TxtFPrestamo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtFPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFPrestamo.Location = New System.Drawing.Point(136, 116)
        Me.TxtFPrestamo.Multiline = True
        Me.TxtFPrestamo.Name = "TxtFPrestamo"
        Me.TxtFPrestamo.ReadOnly = True
        Me.TxtFPrestamo.Size = New System.Drawing.Size(155, 20)
        Me.TxtFPrestamo.TabIndex = 5
        Me.TxtFPrestamo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDSalida
        '
        Me.TxtDSalida.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDSalida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDSalida.Location = New System.Drawing.Point(136, 241)
        Me.TxtDSalida.Multiline = True
        Me.TxtDSalida.Name = "TxtDSalida"
        Me.TxtDSalida.ReadOnly = True
        Me.TxtDSalida.Size = New System.Drawing.Size(155, 60)
        Me.TxtDSalida.TabIndex = 8
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
        'TxtFEntrega
        '
        Me.TxtFEntrega.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtFEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFEntrega.Location = New System.Drawing.Point(136, 142)
        Me.TxtFEntrega.Multiline = True
        Me.TxtFEntrega.Name = "TxtFEntrega"
        Me.TxtFEntrega.ReadOnly = True
        Me.TxtFEntrega.Size = New System.Drawing.Size(155, 20)
        Me.TxtFEntrega.TabIndex = 6
        Me.TxtFEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PIngreso
        '
        Me.PIngreso.BackColor = System.Drawing.Color.Transparent
        Me.PIngreso.Controls.Add(Me.TxtConIngreso)
        Me.PIngreso.Controls.Add(Me.LCondE)
        Me.PIngreso.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PIngreso.Location = New System.Drawing.Point(67, 348)
        Me.PIngreso.Name = "PIngreso"
        Me.PIngreso.Size = New System.Drawing.Size(260, 139)
        Me.PIngreso.TabIndex = 88
        Me.PIngreso.UseWaitCursor = True
        Me.PIngreso.Visible = False
        '
        'TxtConIngreso
        '
        Me.TxtConIngreso.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtConIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtConIngreso.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.TxtConIngreso.Location = New System.Drawing.Point(91, 14)
        Me.TxtConIngreso.Multiline = True
        Me.TxtConIngreso.Name = "TxtConIngreso"
        Me.TxtConIngreso.Size = New System.Drawing.Size(155, 119)
        Me.TxtConIngreso.TabIndex = 96
        Me.TxtConIngreso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtConIngreso.UseWaitCursor = True
        '
        'LCondE
        '
        Me.LCondE.AutoSize = True
        Me.LCondE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCondE.Location = New System.Drawing.Point(5, 12)
        Me.LCondE.Name = "LCondE"
        Me.LCondE.Size = New System.Drawing.Size(86, 32)
        Me.LCondE.TabIndex = 0
        Me.LCondE.Text = "Condiciones " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " de Entrada"
        Me.LCondE.UseWaitCursor = True
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(724, 1)
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
        Me.BMinimizar.Location = New System.Drawing.Point(668, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 0
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BGuardarMo
        '
        Me.BGuardarMo.BackColor = System.Drawing.Color.Transparent
        Me.BGuardarMo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardarMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGuardarMo.Location = New System.Drawing.Point(421, 1)
        Me.BGuardarMo.Name = "BGuardarMo"
        Me.BGuardarMo.Size = New System.Drawing.Size(50, 50)
        Me.BGuardarMo.TabIndex = 0
        Me.BGuardarMo.UseVisualStyleBackColor = False
        Me.BGuardarMo.Visible = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.Color.Transparent
        Me.BModificar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_42
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BModificar.Location = New System.Drawing.Point(421, 1)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(50, 50)
        Me.BModificar.TabIndex = 0
        Me.BModificar.UseVisualStyleBackColor = False
        Me.BModificar.Visible = False
        '
        'BGIngreso
        '
        Me.BGIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BGIngreso.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGIngreso.Location = New System.Drawing.Point(421, 1)
        Me.BGIngreso.Name = "BGIngreso"
        Me.BGIngreso.Size = New System.Drawing.Size(50, 50)
        Me.BGIngreso.TabIndex = 0
        Me.BGIngreso.UseVisualStyleBackColor = False
        Me.BGIngreso.Visible = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(477, 1)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 0
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'BRIngreso
        '
        Me.BRIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BRIngreso.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRIngreso.Location = New System.Drawing.Point(365, 1)
        Me.BRIngreso.Name = "BRIngreso"
        Me.BRIngreso.Size = New System.Drawing.Size(50, 50)
        Me.BRIngreso.TabIndex = 0
        Me.BRIngreso.UseVisualStyleBackColor = False
        Me.BRIngreso.Visible = False
        '
        'BIngreso
        '
        Me.BIngreso.BackColor = System.Drawing.Color.Transparent
        Me.BIngreso.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_producto_40
        Me.BIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BIngreso.Location = New System.Drawing.Point(365, 1)
        Me.BIngreso.Name = "BIngreso"
        Me.BIngreso.Size = New System.Drawing.Size(50, 50)
        Me.BIngreso.TabIndex = 0
        Me.BIngreso.UseVisualStyleBackColor = False
        Me.BIngreso.Visible = False
        '
        'BRetorno
        '
        Me.BRetorno.BackColor = System.Drawing.Color.Transparent
        Me.BRetorno.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRetorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRetorno.Location = New System.Drawing.Point(365, 1)
        Me.BRetorno.Name = "BRetorno"
        Me.BRetorno.Size = New System.Drawing.Size(50, 50)
        Me.BRetorno.TabIndex = 89
        Me.BRetorno.UseVisualStyleBackColor = False
        Me.BRetorno.Visible = False
        '
        'BNuevoPrestamo
        '
        Me.BNuevoPrestamo.BackColor = System.Drawing.Color.Transparent
        Me.BNuevoPrestamo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list1
        Me.BNuevoPrestamo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BNuevoPrestamo.Location = New System.Drawing.Point(12, 1)
        Me.BNuevoPrestamo.Name = "BNuevoPrestamo"
        Me.BNuevoPrestamo.Size = New System.Drawing.Size(50, 50)
        Me.BNuevoPrestamo.TabIndex = 0
        Me.BNuevoPrestamo.UseVisualStyleBackColor = False
        '
        'BMostrarHist
        '
        Me.BMostrarHist.BackColor = System.Drawing.Color.Transparent
        Me.BMostrarHist.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list_81
        Me.BMostrarHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMostrarHist.Location = New System.Drawing.Point(67, 1)
        Me.BMostrarHist.Name = "BMostrarHist"
        Me.BMostrarHist.Size = New System.Drawing.Size(50, 50)
        Me.BMostrarHist.TabIndex = 0
        Me.BMostrarHist.UseVisualStyleBackColor = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(553, 84)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 90
        Me.LCS.Visible = False
        '
        'Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(774, 505)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.BMostrarHist)
        Me.Controls.Add(Me.BNuevoPrestamo)
        Me.Controls.Add(Me.BRetorno)
        Me.Controls.Add(Me.BIngreso)
        Me.Controls.Add(Me.BRIngreso)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BGIngreso)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BGuardarMo)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.PIngreso)
        Me.Controls.Add(Me.PDatos)
        Me.Controls.Add(Me.DatosPM)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PLinea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Prestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestamos"
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PDatos.ResumeLayout(False)
        Me.PDatos.PerformLayout()
        Me.PIngreso.ResumeLayout(False)
        Me.PIngreso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PLinea As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DatosPM As DataGridView
    Friend WithEvents LNN As Label
    Friend WithEvents TxtNN As TextBox
    Friend WithEvents TxtTrabajador As TextBox
    Friend WithEvents LNombre As Label
    Friend WithEvents TxtMaterial As TextBox
    Friend WithEvents LMaterial As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents LCalidad As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LFP As Label
    Friend WithEvents LEntrega As Label
    Friend WithEvents PDatos As Panel
    Friend WithEvents TxtFPrestamo As TextBox
    Friend WithEvents TxtDSalida As TextBox
    Friend WithEvents LSalidaDetalle As Label
    Friend WithEvents LDescripcion As Label
    Friend WithEvents TxtFEntrega As TextBox
    Friend WithEvents IDD As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents DTFEntrega As DateTimePicker
    Friend WithEvents PIngreso As Panel
    Friend WithEvents LCondE As Label
    Friend WithEvents TxtConIngreso As TextBox
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents BGuardarMo As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BGIngreso As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BRIngreso As Button
    Friend WithEvents BIngreso As Button
    Friend WithEvents BRetorno As Button
    Friend WithEvents BNuevoPrestamo As Button
    Friend WithEvents BMostrarHist As Button
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents NombreE As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents FechaEnt As DataGridViewTextBoxColumn
    Friend WithEvents LCS As Label
End Class
