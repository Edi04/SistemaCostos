<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtiquetasCB
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
        Me.components = New System.ComponentModel.Container()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.BMinimizar = New System.Windows.Forms.PictureBox()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.DataCB = New System.Windows.Forms.DataGridView()
        Me.Id_Producto = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo_Barras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.LImp = New System.Windows.Forms.Label()
        Me.PDi = New System.Windows.Forms.Panel()
        Me.Imprimir = New System.Windows.Forms.Button()
        Me.Formato = New System.Windows.Forms.Panel()
        Me.Codigo = New IDAutomation.Windows.Forms.LinearBarCode.Barcode()
        Me.NProducto = New System.Windows.Forms.TextBox()
        Me.Espera = New System.Windows.Forms.Timer(Me.components)
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataCB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Formato.SuspendLayout()
        Me.SuspendLayout()
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.LightBlue
        Me.POpc.Location = New System.Drawing.Point(0, 55)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(528, 13)
        Me.POpc.TabIndex = 76
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(420, 2)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 75
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(473, 2)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 74
        Me.BCerrar.TabStop = False
        '
        'DataCB
        '
        Me.DataCB.BackgroundColor = System.Drawing.Color.LightBlue
        Me.DataCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Producto, Me.Clave_Producto, Me.Nombre_Producto, Me.Codigo_Barras})
        Me.DataCB.Location = New System.Drawing.Point(22, 75)
        Me.DataCB.Name = "DataCB"
        Me.DataCB.Size = New System.Drawing.Size(490, 171)
        Me.DataCB.TabIndex = 2
        '
        'Id_Producto
        '
        Me.Id_Producto.DataPropertyName = "Id_Producto"
        Me.Id_Producto.HeaderText = "ID"
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Id_Producto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Id_Producto.Width = 50
        '
        'Clave_Producto
        '
        Me.Clave_Producto.DataPropertyName = "Clave_Producto"
        Me.Clave_Producto.HeaderText = "Código de Producto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.Width = 120
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.DataPropertyName = "Nombre_Producto"
        Me.Nombre_Producto.HeaderText = "Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.Width = 150
        '
        'Codigo_Barras
        '
        Me.Codigo_Barras.DataPropertyName = "Codigo_Barras"
        Me.Codigo_Barras.HeaderText = "Código Barras"
        Me.Codigo_Barras.Name = "Codigo_Barras"
        Me.Codigo_Barras.Width = 110
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(39, 1)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(277, 52)
        Me.GBusqueda.TabIndex = 1
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(234, 11)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(39, 38)
        Me.PBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBusqueda.TabIndex = 26
        Me.PBusqueda.TabStop = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(29, 20)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(193, 30)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'LImp
        '
        Me.LImp.AutoSize = True
        Me.LImp.BackColor = System.Drawing.Color.Transparent
        Me.LImp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImp.ForeColor = System.Drawing.Color.Black
        Me.LImp.Location = New System.Drawing.Point(160, 271)
        Me.LImp.Name = "LImp"
        Me.LImp.Size = New System.Drawing.Size(205, 20)
        Me.LImp.TabIndex = 80
        Me.LImp.Text = "Preparando la Impresión"
        '
        'PDi
        '
        Me.PDi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PDi.BackColor = System.Drawing.Color.LightBlue
        Me.PDi.Location = New System.Drawing.Point(0, 255)
        Me.PDi.Name = "PDi"
        Me.PDi.Size = New System.Drawing.Size(528, 13)
        Me.PDi.TabIndex = 77
        '
        'Imprimir
        '
        Me.Imprimir.BackColor = System.Drawing.Color.Transparent
        Me.Imprimir.Image = Global.NucleosAve.My.Resources.Resources.icons8_imprimir_481
        Me.Imprimir.Location = New System.Drawing.Point(460, 462)
        Me.Imprimir.Name = "Imprimir"
        Me.Imprimir.Size = New System.Drawing.Size(52, 38)
        Me.Imprimir.TabIndex = 4
        Me.Imprimir.UseVisualStyleBackColor = False
        '
        'Formato
        '
        Me.Formato.BackColor = System.Drawing.Color.White
        Me.Formato.Controls.Add(Me.Codigo)
        Me.Formato.Controls.Add(Me.NProducto)
        Me.Formato.Location = New System.Drawing.Point(138, 303)
        Me.Formato.Name = "Formato"
        Me.Formato.Size = New System.Drawing.Size(254, 201)
        Me.Formato.TabIndex = 82
        '
        'Codigo
        '
        Me.Codigo.ApplyTilde = True
        Me.Codigo.BarHeightCM = 1.0!
        Me.Codigo.BearerBarHorizontal = 0
        Me.Codigo.BearerBarVertical = 0
        Me.Codigo.CaptionAbove = ""
        Me.Codigo.CaptionBelow = ""
        Me.Codigo.CaptionBottomAlignment = System.Drawing.StringAlignment.Center
        Me.Codigo.CaptionBottomColor = System.Drawing.Color.Black
        Me.Codigo.CaptionBottomSpace = 0.1!
        Me.Codigo.CaptionFontAbove = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.CaptionFontBelow = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Codigo.CaptionTopAlignment = System.Drawing.StringAlignment.Center
        Me.Codigo.CaptionTopColor = System.Drawing.Color.Black
        Me.Codigo.CaptionTopSpace = 0.1!
        Me.Codigo.CharacterGrouping = 0
        Me.Codigo.CheckCharacter = False
        Me.Codigo.CheckCharacterInText = True
        Me.Codigo.CODABARStartChar = "A"
        Me.Codigo.CODABARStopChar = "B"
        Me.Codigo.Code128Set = IDAutomation.Windows.Forms.LinearBarCode.Code128CharacterSets.[Auto]
        Me.Codigo.DataToEncode = "1234567890"
        Me.Codigo.DoPaint = True
        Me.Codigo.FitControlToBarcode = True
        Me.Codigo.LeftMarginCM = 0.2!
        Me.Codigo.Location = New System.Drawing.Point(26, 81)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.NarrowToWideRatio = 2.0!
        Me.Codigo.OneBitPerPixelImage = False
        Me.Codigo.PostnetHeightShort = 0.127!
        Me.Codigo.PostnetHeightTall = 0.3226!
        Me.Codigo.PostnetSpacing = 0.064!
        Me.Codigo.Resolution = IDAutomation.Windows.Forms.LinearBarCode.Resolutions.Printer
        Me.Codigo.ResolutionCustomDPI = 600.0!
        Me.Codigo.ResolutionPrinterToUse = ""
        Me.Codigo.RotationAngle = IDAutomation.Windows.Forms.LinearBarCode.RotationAngles.Zero_Degrees
        Me.Codigo.ShowText = True
        Me.Codigo.ShowTextLocation = IDAutomation.Windows.Forms.LinearBarCode.HRTextPositions.Bottom
        Me.Codigo.Size = New System.Drawing.Size(171, 79)
        Me.Codigo.SuppSeparationCM = 0.5!
        Me.Codigo.SymbologyID = IDAutomation.Windows.Forms.LinearBarCode.Symbologies.Code39
        Me.Codigo.TabIndex = 6
        Me.Codigo.TextFontColor = System.Drawing.Color.Black
        Me.Codigo.TextMarginCM = 0.1!
        Me.Codigo.TopMarginCM = 0.2!
        Me.Codigo.UPCESystem = "0"
        Me.Codigo.WhiteBarIncrease = 0!
        Me.Codigo.XDimensionCM = 0.0273!
        Me.Codigo.XDimensionMILS = 10.7714!
        '
        'NProducto
        '
        Me.NProducto.BackColor = System.Drawing.Color.White
        Me.NProducto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NProducto.ForeColor = System.Drawing.Color.Black
        Me.NProducto.Location = New System.Drawing.Point(26, 21)
        Me.NProducto.Multiline = True
        Me.NProducto.Name = "NProducto"
        Me.NProducto.ReadOnly = True
        Me.NProducto.Size = New System.Drawing.Size(201, 54)
        Me.NProducto.TabIndex = 3
        '
        'Espera
        '
        Me.Espera.Interval = 1000
        '
        'EtiquetasCB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(528, 512)
        Me.Controls.Add(Me.Formato)
        Me.Controls.Add(Me.Imprimir)
        Me.Controls.Add(Me.PDi)
        Me.Controls.Add(Me.LImp)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.DataCB)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EtiquetasCB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EtiquetasCB"
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataCB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Formato.ResumeLayout(False)
        Me.Formato.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents POpc As Panel
    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents DataCB As DataGridView
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents LImp As Label
    Friend WithEvents PDi As Panel
    Friend WithEvents Imprimir As Button
    Friend WithEvents Id_Producto As DataGridViewLinkColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Codigo_Barras As DataGridViewTextBoxColumn
    Friend WithEvents Formato As Panel
    Friend WithEvents NProducto As TextBox
    Friend WithEvents Espera As Timer
    Friend WithEvents Codigo As IDAutomation.Windows.Forms.LinearBarCode.Barcode
End Class
