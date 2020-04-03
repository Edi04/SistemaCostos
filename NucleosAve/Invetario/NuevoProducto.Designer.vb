<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoProducto
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
        Me.BMinimizar = New System.Windows.Forms.PictureBox()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.BGuardar = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Datos_Generales = New System.Windows.Forms.GroupBox()
        Me.BNMarca = New System.Windows.Forms.PictureBox()
        Me.CMarca = New System.Windows.Forms.ComboBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.CBUMedida = New System.Windows.Forms.ComboBox()
        Me.LUMedida = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.LDescripcion = New System.Windows.Forms.Label()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.TxtClaveP = New System.Windows.Forms.TextBox()
        Me.LClave = New System.Windows.Forms.Label()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.GGrupos = New System.Windows.Forms.GroupBox()
        Me.CBArea = New System.Windows.Forms.ComboBox()
        Me.CBCategoria = New System.Windows.Forms.ComboBox()
        Me.CBProceso = New System.Windows.Forms.ComboBox()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LArea = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.GEstadistica = New System.Windows.Forms.GroupBox()
        Me.LMínimo = New System.Windows.Forms.Label()
        Me.TxtMinimo = New System.Windows.Forms.TextBox()
        Me.LMáximo = New System.Windows.Forms.Label()
        Me.TxtMaximo = New System.Windows.Forms.TextBox()
        Me.GCodigoBarras = New System.Windows.Forms.GroupBox()
        Me.TxtCB = New System.Windows.Forms.TextBox()
        Me.PCodigoBarras = New System.Windows.Forms.PictureBox()
        Me.Barcode1 = New IDAutomation.Windows.Forms.LinearBarCode.Barcode()
        Me.GImagen = New System.Windows.Forms.GroupBox()
        Me.BImagen = New System.Windows.Forms.Button()
        Me.Imagen = New System.Windows.Forms.PictureBox()
        Me.NameImagen = New System.Windows.Forms.Label()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Datos_Generales.SuspendLayout()
        CType(Me.BNMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GGrupos.SuspendLayout()
        Me.GEstadistica.SuspendLayout()
        Me.GCodigoBarras.SuspendLayout()
        CType(Me.PCodigoBarras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GImagen.SuspendLayout()
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(431, 3)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 69
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(485, 3)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 68
        Me.BCerrar.TabStop = False
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BGuardar.Image = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardar.Location = New System.Drawing.Point(343, 1)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(47, 50)
        Me.BGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BGuardar.TabIndex = 70
        Me.BGuardar.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(2, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 11)
        Me.Panel2.TabIndex = 71
        '
        'Datos_Generales
        '
        Me.Datos_Generales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Datos_Generales.BackColor = System.Drawing.Color.Transparent
        Me.Datos_Generales.Controls.Add(Me.BNMarca)
        Me.Datos_Generales.Controls.Add(Me.CMarca)
        Me.Datos_Generales.Controls.Add(Me.LMarca)
        Me.Datos_Generales.Controls.Add(Me.CBUMedida)
        Me.Datos_Generales.Controls.Add(Me.LUMedida)
        Me.Datos_Generales.Controls.Add(Me.TxtDescripcion)
        Me.Datos_Generales.Controls.Add(Me.LDescripcion)
        Me.Datos_Generales.Controls.Add(Me.TxtNombreP)
        Me.Datos_Generales.Controls.Add(Me.TxtClaveP)
        Me.Datos_Generales.Controls.Add(Me.LClave)
        Me.Datos_Generales.Controls.Add(Me.LProducto)
        Me.Datos_Generales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Datos_Generales.ForeColor = System.Drawing.Color.Black
        Me.Datos_Generales.Location = New System.Drawing.Point(17, 183)
        Me.Datos_Generales.Name = "Datos_Generales"
        Me.Datos_Generales.Size = New System.Drawing.Size(310, 222)
        Me.Datos_Generales.TabIndex = 2
        Me.Datos_Generales.TabStop = False
        Me.Datos_Generales.Text = "Datos Generales del Producto"
        '
        'BNMarca
        '
        Me.BNMarca.Image = Global.NucleosAve.My.Resources.Resources.file1
        Me.BNMarca.Location = New System.Drawing.Point(277, 102)
        Me.BNMarca.Name = "BNMarca"
        Me.BNMarca.Size = New System.Drawing.Size(27, 21)
        Me.BNMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BNMarca.TabIndex = 6
        Me.BNMarca.TabStop = False
        '
        'CMarca
        '
        Me.CMarca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMarca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMarca.BackColor = System.Drawing.Color.Gainsboro
        Me.CMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMarca.FormattingEnabled = True
        Me.CMarca.Location = New System.Drawing.Point(139, 103)
        Me.CMarca.Name = "CMarca"
        Me.CMarca.Size = New System.Drawing.Size(139, 21)
        Me.CMarca.TabIndex = 4
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.Location = New System.Drawing.Point(92, 105)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(46, 16)
        Me.LMarca.TabIndex = 0
        Me.LMarca.Text = "Marca"
        '
        'CBUMedida
        '
        Me.CBUMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBUMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBUMedida.BackColor = System.Drawing.Color.Gainsboro
        Me.CBUMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBUMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBUMedida.FormattingEnabled = True
        Me.CBUMedida.Location = New System.Drawing.Point(139, 74)
        Me.CBUMedida.Name = "CBUMedida"
        Me.CBUMedida.Size = New System.Drawing.Size(165, 21)
        Me.CBUMedida.TabIndex = 3
        '
        'LUMedida
        '
        Me.LUMedida.AutoSize = True
        Me.LUMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUMedida.Location = New System.Drawing.Point(18, 76)
        Me.LUMedida.Name = "LUMedida"
        Me.LUMedida.Size = New System.Drawing.Size(120, 16)
        Me.LUMedida.TabIndex = 0
        Me.LUMedida.Text = "Unidad de Medida"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(139, 132)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(162, 79)
        Me.TxtDescripcion.TabIndex = 5
        '
        'LDescripcion
        '
        Me.LDescripcion.AutoSize = True
        Me.LDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDescripcion.Location = New System.Drawing.Point(58, 135)
        Me.LDescripcion.Name = "LDescripcion"
        Me.LDescripcion.Size = New System.Drawing.Size(80, 16)
        Me.LDescripcion.TabIndex = 0
        Me.LDescripcion.Text = "Descripción"
        '
        'TxtNombreP
        '
        Me.TxtNombreP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreP.Location = New System.Drawing.Point(139, 50)
        Me.TxtNombreP.Multiline = True
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.Size = New System.Drawing.Size(162, 15)
        Me.TxtNombreP.TabIndex = 2
        '
        'TxtClaveP
        '
        Me.TxtClaveP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtClaveP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtClaveP.Location = New System.Drawing.Point(139, 26)
        Me.TxtClaveP.Multiline = True
        Me.TxtClaveP.Name = "TxtClaveP"
        Me.TxtClaveP.Size = New System.Drawing.Size(162, 15)
        Me.TxtClaveP.TabIndex = 1
        '
        'LClave
        '
        Me.LClave.AutoSize = True
        Me.LClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClave.Location = New System.Drawing.Point(15, 24)
        Me.LClave.Name = "LClave"
        Me.LClave.Size = New System.Drawing.Size(122, 16)
        Me.LClave.TabIndex = 0
        Me.LClave.Text = "Clave del Producto"
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.Location = New System.Drawing.Point(1, 48)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(136, 16)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Nombre del Producto"
        '
        'GGrupos
        '
        Me.GGrupos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GGrupos.BackColor = System.Drawing.Color.Transparent
        Me.GGrupos.Controls.Add(Me.CBArea)
        Me.GGrupos.Controls.Add(Me.CBCategoria)
        Me.GGrupos.Controls.Add(Me.CBProceso)
        Me.GGrupos.Controls.Add(Me.LCategoria)
        Me.GGrupos.Controls.Add(Me.LArea)
        Me.GGrupos.Controls.Add(Me.LProceso)
        Me.GGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GGrupos.ForeColor = System.Drawing.Color.White
        Me.GGrupos.Location = New System.Drawing.Point(78, 67)
        Me.GGrupos.Name = "GGrupos"
        Me.GGrupos.Size = New System.Drawing.Size(240, 105)
        Me.GGrupos.TabIndex = 1
        Me.GGrupos.TabStop = False
        '
        'CBArea
        '
        Me.CBArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBArea.BackColor = System.Drawing.Color.Gainsboro
        Me.CBArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBArea.DropDownWidth = 157
        Me.CBArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBArea.FormattingEnabled = True
        Me.CBArea.Location = New System.Drawing.Point(77, 15)
        Me.CBArea.Name = "CBArea"
        Me.CBArea.Size = New System.Drawing.Size(157, 21)
        Me.CBArea.TabIndex = 1
        '
        'CBCategoria
        '
        Me.CBCategoria.BackColor = System.Drawing.Color.Gainsboro
        Me.CBCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCategoria.DropDownWidth = 200
        Me.CBCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBCategoria.FormattingEnabled = True
        Me.CBCategoria.Location = New System.Drawing.Point(77, 75)
        Me.CBCategoria.Name = "CBCategoria"
        Me.CBCategoria.Size = New System.Drawing.Size(157, 21)
        Me.CBCategoria.TabIndex = 3
        '
        'CBProceso
        '
        Me.CBProceso.BackColor = System.Drawing.Color.Gainsboro
        Me.CBProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProceso.DropDownWidth = 157
        Me.CBProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.CBProceso.FormattingEnabled = True
        Me.CBProceso.Location = New System.Drawing.Point(77, 45)
        Me.CBProceso.Name = "CBProceso"
        Me.CBProceso.Size = New System.Drawing.Size(157, 21)
        Me.CBProceso.TabIndex = 2
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.Black
        Me.LCategoria.Location = New System.Drawing.Point(6, 77)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(67, 16)
        Me.LCategoria.TabIndex = 0
        Me.LCategoria.Text = "Categoria"
        Me.LCategoria.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LArea
        '
        Me.LArea.AutoSize = True
        Me.LArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LArea.ForeColor = System.Drawing.Color.Black
        Me.LArea.Location = New System.Drawing.Point(36, 18)
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
        Me.LProceso.Location = New System.Drawing.Point(15, 47)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(59, 16)
        Me.LProceso.TabIndex = 0
        Me.LProceso.Text = "Proceso"
        Me.LProceso.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GEstadistica
        '
        Me.GEstadistica.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GEstadistica.BackColor = System.Drawing.Color.Transparent
        Me.GEstadistica.Controls.Add(Me.LMínimo)
        Me.GEstadistica.Controls.Add(Me.TxtMinimo)
        Me.GEstadistica.Controls.Add(Me.LMáximo)
        Me.GEstadistica.Controls.Add(Me.TxtMaximo)
        Me.GEstadistica.Location = New System.Drawing.Point(371, 313)
        Me.GEstadistica.Name = "GEstadistica"
        Me.GEstadistica.Size = New System.Drawing.Size(139, 81)
        Me.GEstadistica.TabIndex = 3
        Me.GEstadistica.TabStop = False
        '
        'LMínimo
        '
        Me.LMínimo.AutoSize = True
        Me.LMínimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMínimo.ForeColor = System.Drawing.Color.Black
        Me.LMínimo.Location = New System.Drawing.Point(9, 20)
        Me.LMínimo.Name = "LMínimo"
        Me.LMínimo.Size = New System.Drawing.Size(51, 16)
        Me.LMínimo.TabIndex = 0
        Me.LMínimo.Text = "Mínimo"
        '
        'TxtMinimo
        '
        Me.TxtMinimo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMinimo.Location = New System.Drawing.Point(68, 17)
        Me.TxtMinimo.Name = "TxtMinimo"
        Me.TxtMinimo.Size = New System.Drawing.Size(60, 20)
        Me.TxtMinimo.TabIndex = 1
        '
        'LMáximo
        '
        Me.LMáximo.AutoSize = True
        Me.LMáximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMáximo.ForeColor = System.Drawing.Color.Black
        Me.LMáximo.Location = New System.Drawing.Point(5, 46)
        Me.LMáximo.Name = "LMáximo"
        Me.LMáximo.Size = New System.Drawing.Size(55, 16)
        Me.LMáximo.TabIndex = 0
        Me.LMáximo.Text = "Máximo"
        '
        'TxtMaximo
        '
        Me.TxtMaximo.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtMaximo.Location = New System.Drawing.Point(68, 43)
        Me.TxtMaximo.Name = "TxtMaximo"
        Me.TxtMaximo.Size = New System.Drawing.Size(60, 20)
        Me.TxtMaximo.TabIndex = 2
        '
        'GCodigoBarras
        '
        Me.GCodigoBarras.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GCodigoBarras.BackColor = System.Drawing.Color.Transparent
        Me.GCodigoBarras.Controls.Add(Me.TxtCB)
        Me.GCodigoBarras.Controls.Add(Me.PCodigoBarras)
        Me.GCodigoBarras.Controls.Add(Me.Barcode1)
        Me.GCodigoBarras.ForeColor = System.Drawing.Color.Black
        Me.GCodigoBarras.Location = New System.Drawing.Point(156, 411)
        Me.GCodigoBarras.Name = "GCodigoBarras"
        Me.GCodigoBarras.Size = New System.Drawing.Size(284, 110)
        Me.GCodigoBarras.TabIndex = 5
        Me.GCodigoBarras.TabStop = False
        Me.GCodigoBarras.Text = "Código de Barras"
        '
        'TxtCB
        '
        Me.TxtCB.Location = New System.Drawing.Point(36, 19)
        Me.TxtCB.Name = "TxtCB"
        Me.TxtCB.Size = New System.Drawing.Size(153, 20)
        Me.TxtCB.TabIndex = 72
        '
        'PCodigoBarras
        '
        Me.PCodigoBarras.BackColor = System.Drawing.Color.White
        Me.PCodigoBarras.Image = Global.NucleosAve.My.Resources.Resources.icons8_refrescar_código_de_barras_32
        Me.PCodigoBarras.Location = New System.Drawing.Point(251, 66)
        Me.PCodigoBarras.Name = "PCodigoBarras"
        Me.PCodigoBarras.Size = New System.Drawing.Size(24, 29)
        Me.PCodigoBarras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PCodigoBarras.TabIndex = 53
        Me.PCodigoBarras.TabStop = False
        '
        'Barcode1
        '
        Me.Barcode1.ApplyTilde = True
        Me.Barcode1.BarHeightCM = 1.0!
        Me.Barcode1.BearerBarHorizontal = 0
        Me.Barcode1.BearerBarVertical = 0
        Me.Barcode1.CaptionAbove = ""
        Me.Barcode1.CaptionBelow = ""
        Me.Barcode1.CaptionBottomAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionBottomColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionBottomSpace = 0.1!
        Me.Barcode1.CaptionFontAbove = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Barcode1.CaptionFontBelow = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Barcode1.CaptionTopAlignment = System.Drawing.StringAlignment.Center
        Me.Barcode1.CaptionTopColor = System.Drawing.Color.Black
        Me.Barcode1.CaptionTopSpace = 0.1!
        Me.Barcode1.CharacterGrouping = 0
        Me.Barcode1.CheckCharacter = False
        Me.Barcode1.CheckCharacterInText = True
        Me.Barcode1.CODABARStartChar = "A"
        Me.Barcode1.CODABARStopChar = "B"
        Me.Barcode1.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Code128CharacterSets.[Auto]
        Me.Barcode1.DataToEncode = ""
        Me.Barcode1.DoPaint = True
        Me.Barcode1.FitControlToBarcode = True
        Me.Barcode1.LeftMarginCM = 0.2!
        Me.Barcode1.Location = New System.Drawing.Point(27, 36)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.NarrowToWideRatio = 2.0!
        Me.Barcode1.OneBitPerPixelImage = False
        Me.Barcode1.PostnetHeightShort = 0.127!
        Me.Barcode1.PostnetHeightTall = 0.3226!
        Me.Barcode1.PostnetSpacing = 0.064!
        Me.Barcode1.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Resolutions.Printer
        Me.Barcode1.ResolutionCustomDPI = 96.0!
        Me.Barcode1.ResolutionPrinterToUse = ""
        Me.Barcode1.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.RotationAngles.Zero_Degrees
        Me.Barcode1.ShowText = True
        Me.Barcode1.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.HRTextPositions.Bottom
        Me.Barcode1.Size = New System.Drawing.Size(41, 74)
        Me.Barcode1.SuppSeparationCM = 0.5!
        Me.Barcode1.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Symbologies.Code39
        Me.Barcode1.TabIndex = 2
        Me.Barcode1.TextFontColor = System.Drawing.Color.Black
        Me.Barcode1.TextMarginCM = 0.1!
        Me.Barcode1.TopMarginCM = 0.2!
        Me.Barcode1.UPCESystem = "0"
        Me.Barcode1.WhiteBarIncrease = 0!
        Me.Barcode1.XDimensionCM = 0.0298!
        Me.Barcode1.XDimensionMILS = 11.7714!
        '
        'GImagen
        '
        Me.GImagen.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GImagen.BackColor = System.Drawing.Color.Transparent
        Me.GImagen.Controls.Add(Me.BImagen)
        Me.GImagen.Controls.Add(Me.Imagen)
        Me.GImagen.Location = New System.Drawing.Point(362, 74)
        Me.GImagen.Name = "GImagen"
        Me.GImagen.Size = New System.Drawing.Size(168, 212)
        Me.GImagen.TabIndex = 6
        Me.GImagen.TabStop = False
        '
        'BImagen
        '
        Me.BImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImagen.ForeColor = System.Drawing.Color.Black
        Me.BImagen.Location = New System.Drawing.Point(93, 173)
        Me.BImagen.Name = "BImagen"
        Me.BImagen.Size = New System.Drawing.Size(75, 39)
        Me.BImagen.TabIndex = 4
        Me.BImagen.Text = "Seleccionar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Imágen"
        Me.BImagen.UseVisualStyleBackColor = True
        '
        'Imagen
        '
        Me.Imagen.Location = New System.Drawing.Point(9, 19)
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Size = New System.Drawing.Size(149, 177)
        Me.Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Imagen.TabIndex = 21
        Me.Imagen.TabStop = False
        '
        'NameImagen
        '
        Me.NameImagen.AutoSize = True
        Me.NameImagen.Location = New System.Drawing.Point(362, 293)
        Me.NameImagen.Name = "NameImagen"
        Me.NameImagen.Size = New System.Drawing.Size(0, 13)
        Me.NameImagen.TabIndex = 0
        Me.NameImagen.Visible = False
        '
        'NuevoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(541, 533)
        Me.Controls.Add(Me.NameImagen)
        Me.Controls.Add(Me.GImagen)
        Me.Controls.Add(Me.GCodigoBarras)
        Me.Controls.Add(Me.GEstadistica)
        Me.Controls.Add(Me.GGrupos)
        Me.Controls.Add(Me.Datos_Generales)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NuevoProducto"
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Datos_Generales.ResumeLayout(False)
        Me.Datos_Generales.PerformLayout()
        CType(Me.BNMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GGrupos.ResumeLayout(False)
        Me.GGrupos.PerformLayout()
        Me.GEstadistica.ResumeLayout(False)
        Me.GEstadistica.PerformLayout()
        Me.GCodigoBarras.ResumeLayout(False)
        Me.GCodigoBarras.PerformLayout()
        CType(Me.PCodigoBarras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GImagen.ResumeLayout(False)
        CType(Me.Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents BGuardar As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Datos_Generales As GroupBox
    Friend WithEvents CMarca As ComboBox
    Friend WithEvents LMarca As Label
    Friend WithEvents CBUMedida As ComboBox
    Friend WithEvents LUMedida As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents LDescripcion As Label
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents TxtClaveP As TextBox
    Friend WithEvents LClave As Label
    Friend WithEvents LProducto As Label
    Friend WithEvents GGrupos As GroupBox
    Friend WithEvents CBArea As ComboBox
    Friend WithEvents CBCategoria As ComboBox
    Friend WithEvents CBProceso As ComboBox
    Friend WithEvents LCategoria As Label
    Friend WithEvents LArea As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents GEstadistica As GroupBox
    Friend WithEvents LMínimo As Label
    Friend WithEvents TxtMinimo As TextBox
    Friend WithEvents LMáximo As Label
    Friend WithEvents TxtMaximo As TextBox
    Friend WithEvents GCodigoBarras As GroupBox
    Friend WithEvents PCodigoBarras As PictureBox
    Friend WithEvents GImagen As GroupBox
    Friend WithEvents BImagen As Button
    Friend WithEvents Imagen As PictureBox
    Friend WithEvents NameImagen As Label
    Friend WithEvents Barcode1 As IDAutomation.Windows.Forms.LinearBarCode.Barcode
    Friend WithEvents BNMarca As PictureBox
    Friend WithEvents TxtCB As TextBox
End Class
