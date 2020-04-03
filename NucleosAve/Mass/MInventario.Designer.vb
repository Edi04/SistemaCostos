<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MInventario
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
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LIDE = New System.Windows.Forms.Label()
        Me.BOrdenC = New System.Windows.Forms.Button()
        Me.AgregarExistencias = New System.Windows.Forms.Panel()
        Me.BCerrarN = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        Me.BGExistencia = New System.Windows.Forms.Button()
        Me.PUSD = New System.Windows.Forms.GroupBox()
        Me.TxtUTotal = New System.Windows.Forms.TextBox()
        Me.LUTotal = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.GNExistencia = New System.Windows.Forms.GroupBox()
        Me.PMenos = New System.Windows.Forms.PictureBox()
        Me.TxtNExistencia = New System.Windows.Forms.TextBox()
        Me.LEntraP = New System.Windows.Forms.Label()
        Me.MURL = New System.Windows.Forms.Label()
        Me.PSeparador = New System.Windows.Forms.Panel()
        Me.LTExistencias = New System.Windows.Forms.Label()
        Me.LIdProducto = New System.Windows.Forms.Label()
        Me.BRetorno = New System.Windows.Forms.Button()
        Me.BGuardarMo = New System.Windows.Forms.Button()
        Me.BAgregarExistencia = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMostrarHist = New System.Windows.Forms.Button()
        Me.BNuevoProducto = New System.Windows.Forms.Button()
        Me.HURL = New System.Windows.Forms.Label()
        Me.GPrecio = New System.Windows.Forms.GroupBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.GCantidad = New System.Windows.Forms.GroupBox()
        Me.LExitencia = New System.Windows.Forms.Label()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.LMínimo = New System.Windows.Forms.Label()
        Me.TxtMinimo = New System.Windows.Forms.TextBox()
        Me.LMáximo = New System.Windows.Forms.Label()
        Me.TxtMaximo = New System.Windows.Forms.TextBox()
        Me.IDP = New System.Windows.Forms.Label()
        Me.GDatos_Generales = New System.Windows.Forms.GroupBox()
        Me.BAMar = New System.Windows.Forms.Button()
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
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.LC = New System.Windows.Forms.Label()
        Me.AgregarExistencias.SuspendLayout()
        Me.PUSD.SuspendLayout()
        Me.GNExistencia.SuspendLayout()
        CType(Me.PMenos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PSeparador.SuspendLayout()
        Me.GPrecio.SuspendLayout()
        Me.GCantidad.SuspendLayout()
        Me.GDatos_Generales.SuspendLayout()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(292, 443)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LUsuario.TabIndex = 114
        Me.LUsuario.Visible = False
        '
        'LIDE
        '
        Me.LIDE.AutoSize = True
        Me.LIDE.Location = New System.Drawing.Point(329, 45)
        Me.LIDE.Name = "LIDE"
        Me.LIDE.Size = New System.Drawing.Size(0, 13)
        Me.LIDE.TabIndex = 175
        Me.LIDE.Visible = False
        '
        'BOrdenC
        '
        Me.BOrdenC.BackColor = System.Drawing.Color.Transparent
        Me.BOrdenC.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_verificar_80
        Me.BOrdenC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BOrdenC.Location = New System.Drawing.Point(75, 4)
        Me.BOrdenC.Name = "BOrdenC"
        Me.BOrdenC.Size = New System.Drawing.Size(50, 50)
        Me.BOrdenC.TabIndex = 2
        Me.BOrdenC.UseVisualStyleBackColor = False
        '
        'AgregarExistencias
        '
        Me.AgregarExistencias.BackColor = System.Drawing.Color.Snow
        Me.AgregarExistencias.Controls.Add(Me.BCerrarN)
        Me.AgregarExistencias.Controls.Add(Me.LCS)
        Me.AgregarExistencias.Controls.Add(Me.BGExistencia)
        Me.AgregarExistencias.Controls.Add(Me.PUSD)
        Me.AgregarExistencias.Controls.Add(Me.GNExistencia)
        Me.AgregarExistencias.Controls.Add(Me.LEntraP)
        Me.AgregarExistencias.Controls.Add(Me.MURL)
        Me.AgregarExistencias.Controls.Add(Me.PSeparador)
        Me.AgregarExistencias.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.AgregarExistencias.Location = New System.Drawing.Point(371, 150)
        Me.AgregarExistencias.Name = "AgregarExistencias"
        Me.AgregarExistencias.Size = New System.Drawing.Size(199, 250)
        Me.AgregarExistencias.TabIndex = 11
        Me.AgregarExistencias.Visible = False
        '
        'BCerrarN
        '
        Me.BCerrarN.BackColor = System.Drawing.Color.Transparent
        Me.BCerrarN.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrarN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrarN.Location = New System.Drawing.Point(169, 1)
        Me.BCerrarN.Name = "BCerrarN"
        Me.BCerrarN.Size = New System.Drawing.Size(28, 29)
        Me.BCerrarN.TabIndex = 177
        Me.BCerrarN.UseVisualStyleBackColor = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(147, 26)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 103
        Me.LCS.Visible = False
        '
        'BGExistencia
        '
        Me.BGExistencia.BackColor = System.Drawing.Color.Transparent
        Me.BGExistencia.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGExistencia.Location = New System.Drawing.Point(135, 86)
        Me.BGExistencia.Name = "BGExistencia"
        Me.BGExistencia.Size = New System.Drawing.Size(50, 50)
        Me.BGExistencia.TabIndex = 3
        Me.BGExistencia.UseVisualStyleBackColor = False
        '
        'PUSD
        '
        Me.PUSD.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PUSD.BackColor = System.Drawing.Color.Transparent
        Me.PUSD.Controls.Add(Me.TxtUTotal)
        Me.PUSD.Controls.Add(Me.LUTotal)
        Me.PUSD.Controls.Add(Me.TxtTotal)
        Me.PUSD.Controls.Add(Me.LTotal)
        Me.PUSD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PUSD.ForeColor = System.Drawing.Color.Black
        Me.PUSD.Location = New System.Drawing.Point(13, 170)
        Me.PUSD.Name = "PUSD"
        Me.PUSD.Size = New System.Drawing.Size(172, 72)
        Me.PUSD.TabIndex = 2
        Me.PUSD.TabStop = False
        Me.PUSD.Text = "Precio (MXN)"
        '
        'TxtUTotal
        '
        Me.TxtUTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtUTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtUTotal.Location = New System.Drawing.Point(78, 18)
        Me.TxtUTotal.Multiline = True
        Me.TxtUTotal.Name = "TxtUTotal"
        Me.TxtUTotal.Size = New System.Drawing.Size(81, 15)
        Me.TxtUTotal.TabIndex = 2
        Me.TxtUTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LUTotal
        '
        Me.LUTotal.AutoSize = True
        Me.LUTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUTotal.ForeColor = System.Drawing.Color.Black
        Me.LUTotal.Location = New System.Drawing.Point(21, 17)
        Me.LUTotal.Name = "LUTotal"
        Me.LUTotal.Size = New System.Drawing.Size(54, 16)
        Me.LUTotal.TabIndex = 5
        Me.LUTotal.Text = "Unitario"
        Me.LUTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtTotal.Location = New System.Drawing.Point(78, 41)
        Me.TxtTotal.Multiline = True
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(81, 15)
        Me.TxtTotal.TabIndex = 3
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.ForeColor = System.Drawing.Color.Black
        Me.LTotal.Location = New System.Drawing.Point(35, 41)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(39, 16)
        Me.LTotal.TabIndex = 0
        Me.LTotal.Text = "Total"
        Me.LTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GNExistencia
        '
        Me.GNExistencia.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GNExistencia.BackColor = System.Drawing.Color.Transparent
        Me.GNExistencia.Controls.Add(Me.PMenos)
        Me.GNExistencia.Controls.Add(Me.TxtNExistencia)
        Me.GNExistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GNExistencia.ForeColor = System.Drawing.Color.Black
        Me.GNExistencia.Location = New System.Drawing.Point(16, 76)
        Me.GNExistencia.Name = "GNExistencia"
        Me.GNExistencia.Size = New System.Drawing.Size(104, 72)
        Me.GNExistencia.TabIndex = 1
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
        'LEntraP
        '
        Me.LEntraP.AutoSize = True
        Me.LEntraP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEntraP.ForeColor = System.Drawing.Color.Black
        Me.LEntraP.Location = New System.Drawing.Point(16, 32)
        Me.LEntraP.Name = "LEntraP"
        Me.LEntraP.Size = New System.Drawing.Size(175, 20)
        Me.LEntraP.TabIndex = 100
        Me.LEntraP.Text = "Entrada de Producto"
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
        'PSeparador
        '
        Me.PSeparador.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PSeparador.BackColor = System.Drawing.Color.SteelBlue
        Me.PSeparador.Controls.Add(Me.LTExistencias)
        Me.PSeparador.Controls.Add(Me.LIdProducto)
        Me.PSeparador.Location = New System.Drawing.Point(-43, 3)
        Me.PSeparador.Name = "PSeparador"
        Me.PSeparador.Size = New System.Drawing.Size(584, 18)
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
        'BRetorno
        '
        Me.BRetorno.BackColor = System.Drawing.Color.Transparent
        Me.BRetorno.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.BRetorno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BRetorno.Location = New System.Drawing.Point(443, 3)
        Me.BRetorno.Name = "BRetorno"
        Me.BRetorno.Size = New System.Drawing.Size(50, 50)
        Me.BRetorno.TabIndex = 163
        Me.BRetorno.UseVisualStyleBackColor = False
        Me.BRetorno.Visible = False
        '
        'BGuardarMo
        '
        Me.BGuardarMo.BackColor = System.Drawing.Color.Transparent
        Me.BGuardarMo.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardarMo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BGuardarMo.Location = New System.Drawing.Point(499, 3)
        Me.BGuardarMo.Name = "BGuardarMo"
        Me.BGuardarMo.Size = New System.Drawing.Size(50, 50)
        Me.BGuardarMo.TabIndex = 164
        Me.BGuardarMo.UseVisualStyleBackColor = False
        Me.BGuardarMo.Visible = False
        '
        'BAgregarExistencia
        '
        Me.BAgregarExistencia.BackColor = System.Drawing.Color.Transparent
        Me.BAgregarExistencia.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list1
        Me.BAgregarExistencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAgregarExistencia.Location = New System.Drawing.Point(443, 3)
        Me.BAgregarExistencia.Name = "BAgregarExistencia"
        Me.BAgregarExistencia.Size = New System.Drawing.Size(50, 50)
        Me.BAgregarExistencia.TabIndex = 165
        Me.BAgregarExistencia.UseVisualStyleBackColor = False
        Me.BAgregarExistencia.Visible = False
        '
        'BModificar
        '
        Me.BModificar.BackColor = System.Drawing.Color.Transparent
        Me.BModificar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_42
        Me.BModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BModificar.Location = New System.Drawing.Point(499, 3)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(50, 50)
        Me.BModificar.TabIndex = 6
        Me.BModificar.UseVisualStyleBackColor = False
        Me.BModificar.Visible = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file_1311
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEliminar.Location = New System.Drawing.Point(555, 3)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(50, 50)
        Me.BEliminar.TabIndex = 7
        Me.BEliminar.UseVisualStyleBackColor = False
        Me.BEliminar.Visible = False
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(742, 3)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 168
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(798, 3)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 169
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'BMostrarHist
        '
        Me.BMostrarHist.BackColor = System.Drawing.Color.Transparent
        Me.BMostrarHist.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list_81
        Me.BMostrarHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMostrarHist.Location = New System.Drawing.Point(388, 3)
        Me.BMostrarHist.Name = "BMostrarHist"
        Me.BMostrarHist.Size = New System.Drawing.Size(50, 50)
        Me.BMostrarHist.TabIndex = 5
        Me.BMostrarHist.UseVisualStyleBackColor = False
        Me.BMostrarHist.Visible = False
        '
        'BNuevoProducto
        '
        Me.BNuevoProducto.BackColor = System.Drawing.Color.Transparent
        Me.BNuevoProducto.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file1
        Me.BNuevoProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BNuevoProducto.Location = New System.Drawing.Point(14, 4)
        Me.BNuevoProducto.Name = "BNuevoProducto"
        Me.BNuevoProducto.Size = New System.Drawing.Size(50, 50)
        Me.BNuevoProducto.TabIndex = 1
        Me.BNuevoProducto.UseVisualStyleBackColor = False
        '
        'HURL
        '
        Me.HURL.AutoSize = True
        Me.HURL.BackColor = System.Drawing.Color.Transparent
        Me.HURL.Location = New System.Drawing.Point(332, 276)
        Me.HURL.Name = "HURL"
        Me.HURL.Size = New System.Drawing.Size(0, 13)
        Me.HURL.TabIndex = 172
        Me.HURL.Visible = False
        '
        'GPrecio
        '
        Me.GPrecio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GPrecio.BackColor = System.Drawing.Color.Transparent
        Me.GPrecio.Controls.Add(Me.TxtPrecio)
        Me.GPrecio.ForeColor = System.Drawing.Color.Black
        Me.GPrecio.Location = New System.Drawing.Point(357, 203)
        Me.GPrecio.Name = "GPrecio"
        Me.GPrecio.Size = New System.Drawing.Size(90, 38)
        Me.GPrecio.TabIndex = 9
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
        Me.GCantidad.Location = New System.Drawing.Point(330, 269)
        Me.GCantidad.Name = "GCantidad"
        Me.GCantidad.Size = New System.Drawing.Size(133, 84)
        Me.GCantidad.TabIndex = 10
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
        Me.TxtExistencia.Size = New System.Drawing.Size(60, 15)
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
        Me.TxtMinimo.Size = New System.Drawing.Size(60, 15)
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
        Me.TxtMaximo.Size = New System.Drawing.Size(60, 15)
        Me.TxtMaximo.TabIndex = 3
        Me.TxtMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.BackColor = System.Drawing.Color.Transparent
        Me.IDP.Location = New System.Drawing.Point(39, 190)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 173
        Me.IDP.Visible = False
        '
        'GDatos_Generales
        '
        Me.GDatos_Generales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDatos_Generales.BackColor = System.Drawing.Color.Transparent
        Me.GDatos_Generales.Controls.Add(Me.BAMar)
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
        Me.GDatos_Generales.Location = New System.Drawing.Point(12, 150)
        Me.GDatos_Generales.Name = "GDatos_Generales"
        Me.GDatos_Generales.Size = New System.Drawing.Size(310, 286)
        Me.GDatos_Generales.TabIndex = 8
        Me.GDatos_Generales.TabStop = False
        Me.GDatos_Generales.Text = "Datos Generales del Producto"
        '
        'BAMar
        '
        Me.BAMar.BackColor = System.Drawing.Color.Transparent
        Me.BAMar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.file1
        Me.BAMar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BAMar.Location = New System.Drawing.Point(283, 128)
        Me.BAMar.Name = "BAMar"
        Me.BAMar.Size = New System.Drawing.Size(22, 22)
        Me.BAMar.TabIndex = 177
        Me.BAMar.UseVisualStyleBackColor = False
        Me.BAMar.Visible = False
        '
        'CMarca
        '
        Me.CMarca.BackColor = System.Drawing.SystemColors.MenuBar
        Me.CMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMarca.FormattingEnabled = True
        Me.CMarca.Location = New System.Drawing.Point(143, 128)
        Me.CMarca.Name = "CMarca"
        Me.CMarca.Size = New System.Drawing.Size(137, 21)
        Me.CMarca.TabIndex = 8
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
        Me.CMedida.TabIndex = 4
        Me.CMedida.Visible = False
        '
        'LMa
        '
        Me.LMa.AutoSize = True
        Me.LMa.Location = New System.Drawing.Point(-3, 106)
        Me.LMa.Name = "LMa"
        Me.LMa.Size = New System.Drawing.Size(0, 13)
        Me.LMa.TabIndex = 7
        Me.LMa.Visible = False
        '
        'LM
        '
        Me.LM.AutoSize = True
        Me.LM.Location = New System.Drawing.Point(2, 78)
        Me.LM.Name = "LM"
        Me.LM.Size = New System.Drawing.Size(0, 13)
        Me.LM.TabIndex = 6
        Me.LM.Visible = False
        '
        'TxtMarca
        '
        Me.TxtMarca.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMarca.Location = New System.Drawing.Point(143, 131)
        Me.TxtMarca.Multiline = True
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.ReadOnly = True
        Me.TxtMarca.Size = New System.Drawing.Size(162, 15)
        Me.TxtMarca.TabIndex = 7
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(91, 129)
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
        Me.TxtDescripcion.Location = New System.Drawing.Point(143, 155)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.ReadOnly = True
        Me.TxtDescripcion.Size = New System.Drawing.Size(162, 82)
        Me.TxtDescripcion.TabIndex = 9
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.ForeColor = System.Drawing.Color.Black
        Me.LDescripcion.Location = New System.Drawing.Point(57, 155)
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
        Me.TxtClaveP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(12, 69)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(454, 65)
        Me.GBusqueda.TabIndex = 3
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(90, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(239, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Clave del Producto, Nombre del Producto, Marca"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(419, 22)
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
        Me.TxtBusqueda.Location = New System.Drawing.Point(10, 26)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(405, 31)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'DataView
        '
        Me.DataView.AllowUserToAddRows = False
        Me.DataView.AllowUserToDeleteRows = False
        Me.DataView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataView.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DataView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre_Producto, Me.Clave_Producto, Me.Exis})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(472, 73)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(393, 363)
        Me.DataView.TabIndex = 4
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_Producto"
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ID.Text = ""
        Me.ID.Width = 50
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.DataPropertyName = "Nombre_Producto"
        Me.Nombre_Producto.FillWeight = 150.0!
        Me.Nombre_Producto.Frozen = True
        Me.Nombre_Producto.HeaderText = "Nombre del Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        Me.Nombre_Producto.Width = 200
        '
        'Clave_Producto
        '
        Me.Clave_Producto.DataPropertyName = "Clave_Producto"
        Me.Clave_Producto.Frozen = True
        Me.Clave_Producto.HeaderText = "Clave del Producto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = True
        '
        'Exis
        '
        Me.Exis.DataPropertyName = "Existencia"
        Me.Exis.HeaderText = ""
        Me.Exis.Name = "Exis"
        Me.Exis.ReadOnly = True
        Me.Exis.Visible = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(-37, 59)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(961, 10)
        Me.POpc.TabIndex = 161
        '
        'LC
        '
        Me.LC.AutoSize = True
        Me.LC.Location = New System.Drawing.Point(329, 250)
        Me.LC.Name = "LC"
        Me.LC.Size = New System.Drawing.Size(0, 13)
        Me.LC.TabIndex = 176
        Me.LC.Visible = False
        '
        'MInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(868, 465)
        Me.Controls.Add(Me.LC)
        Me.Controls.Add(Me.LIDE)
        Me.Controls.Add(Me.BOrdenC)
        Me.Controls.Add(Me.AgregarExistencias)
        Me.Controls.Add(Me.BRetorno)
        Me.Controls.Add(Me.BGuardarMo)
        Me.Controls.Add(Me.BAgregarExistencia)
        Me.Controls.Add(Me.BModificar)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BMostrarHist)
        Me.Controls.Add(Me.BNuevoProducto)
        Me.Controls.Add(Me.HURL)
        Me.Controls.Add(Me.GPrecio)
        Me.Controls.Add(Me.GCantidad)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.GDatos_Generales)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.LUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MInventario"
        Me.AgregarExistencias.ResumeLayout(False)
        Me.AgregarExistencias.PerformLayout()
        Me.PUSD.ResumeLayout(False)
        Me.PUSD.PerformLayout()
        Me.GNExistencia.ResumeLayout(False)
        Me.GNExistencia.PerformLayout()
        CType(Me.PMenos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PSeparador.ResumeLayout(False)
        Me.PSeparador.PerformLayout()
        Me.GPrecio.ResumeLayout(False)
        Me.GPrecio.PerformLayout()
        Me.GCantidad.ResumeLayout(False)
        Me.GCantidad.PerformLayout()
        Me.GDatos_Generales.ResumeLayout(False)
        Me.GDatos_Generales.PerformLayout()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsuario As Label
    Friend WithEvents LIDE As Label
    Friend WithEvents BOrdenC As Button
    Friend WithEvents AgregarExistencias As Panel
    Friend WithEvents LCS As Label
    Friend WithEvents BGExistencia As Button
    Friend WithEvents PUSD As GroupBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LTotal As Label
    Friend WithEvents GNExistencia As GroupBox
    Friend WithEvents PMenos As PictureBox
    Friend WithEvents TxtNExistencia As TextBox
    Friend WithEvents LEntraP As Label
    Friend WithEvents MURL As Label
    Friend WithEvents PSeparador As Panel
    Friend WithEvents LTExistencias As Label
    Friend WithEvents LIdProducto As Label
    Friend WithEvents BRetorno As Button
    Friend WithEvents BGuardarMo As Button
    Friend WithEvents BAgregarExistencia As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents BEliminar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMostrarHist As Button
    Friend WithEvents BNuevoProducto As Button
    Friend WithEvents HURL As Label
    Friend WithEvents GPrecio As GroupBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents GCantidad As GroupBox
    Friend WithEvents LExitencia As Label
    Friend WithEvents TxtExistencia As TextBox
    Friend WithEvents LMínimo As Label
    Friend WithEvents TxtMinimo As TextBox
    Friend WithEvents LMáximo As Label
    Friend WithEvents TxtMaximo As TextBox
    Friend WithEvents IDP As Label
    Friend WithEvents GDatos_Generales As GroupBox
    Friend WithEvents CMarca As ComboBox
    Friend WithEvents CMedida As ComboBox
    Friend WithEvents LMa As Label
    Friend WithEvents LM As Label
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
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DataView As DataGridView
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Exis As DataGridViewTextBoxColumn
    Friend WithEvents POpc As Panel
    Friend WithEvents LC As Label
    Friend WithEvents BAMar As Button
    Friend WithEvents BCerrarN As Button
    Friend WithEvents TxtUTotal As TextBox
    Friend WithEvents LUTotal As Label
End Class
