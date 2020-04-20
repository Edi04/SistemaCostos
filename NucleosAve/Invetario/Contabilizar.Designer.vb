<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contabilizar
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
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.BMinimizar = New System.Windows.Forms.PictureBox()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.GDatos_Generales = New System.Windows.Forms.GroupBox()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LNE = New System.Windows.Forms.Label()
        Me.TxtNE = New System.Windows.Forms.TextBox()
        Me.LExitencia = New System.Windows.Forms.Label()
        Me.TxtExistencia = New System.Windows.Forms.TextBox()
        Me.TxtNombreP = New System.Windows.Forms.TextBox()
        Me.TxtClaveP = New System.Windows.Forms.TextBox()
        Me.LClave = New System.Windows.Forms.Label()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.BGuardarMo = New System.Windows.Forms.PictureBox()
        Me.IDD = New System.Windows.Forms.Label()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.txtResponsable = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GDatos_Generales.SuspendLayout()
        CType(Me.BGuardarMo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre_Producto, Me.Clave_Producto, Me.Existencia})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(3, 138)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(495, 364)
        Me.DataView.TabIndex = 19
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(39, 53)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(701, 10)
        Me.POpc.TabIndex = 18
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(623, 0)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 21
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(676, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 20
        Me.BCerrar.TabStop = False
        '
        'GDatos_Generales
        '
        Me.GDatos_Generales.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GDatos_Generales.BackColor = System.Drawing.Color.Transparent
        Me.GDatos_Generales.Controls.Add(Me.TxtDescripcion)
        Me.GDatos_Generales.Controls.Add(Me.Label1)
        Me.GDatos_Generales.Controls.Add(Me.LNE)
        Me.GDatos_Generales.Controls.Add(Me.TxtNE)
        Me.GDatos_Generales.Controls.Add(Me.LExitencia)
        Me.GDatos_Generales.Controls.Add(Me.TxtExistencia)
        Me.GDatos_Generales.Controls.Add(Me.TxtNombreP)
        Me.GDatos_Generales.Controls.Add(Me.TxtClaveP)
        Me.GDatos_Generales.Controls.Add(Me.LClave)
        Me.GDatos_Generales.Controls.Add(Me.LProducto)
        Me.GDatos_Generales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GDatos_Generales.ForeColor = System.Drawing.Color.Black
        Me.GDatos_Generales.Location = New System.Drawing.Point(508, 117)
        Me.GDatos_Generales.Name = "GDatos_Generales"
        Me.GDatos_Generales.Size = New System.Drawing.Size(218, 361)
        Me.GDatos_Generales.TabIndex = 22
        Me.GDatos_Generales.TabStop = False
        Me.GDatos_Generales.Text = "Datos del Producto"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.Location = New System.Drawing.Point(93, 260)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(119, 90)
        Me.TxtDescripcion.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 262)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Cambio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LNE
        '
        Me.LNE.AutoSize = True
        Me.LNE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNE.ForeColor = System.Drawing.Color.Black
        Me.LNE.Location = New System.Drawing.Point(18, 211)
        Me.LNE.Name = "LNE"
        Me.LNE.Size = New System.Drawing.Size(69, 32)
        Me.LNE.TabIndex = 10
        Me.LNE.Text = "Nueva" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Existencia"
        Me.LNE.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtNE
        '
        Me.TxtNE.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNE.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNE.Location = New System.Drawing.Point(93, 213)
        Me.TxtNE.Multiline = True
        Me.TxtNE.Name = "TxtNE"
        Me.TxtNE.Size = New System.Drawing.Size(119, 30)
        Me.TxtNE.TabIndex = 11
        Me.TxtNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LExitencia
        '
        Me.LExitencia.AutoSize = True
        Me.LExitencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LExitencia.ForeColor = System.Drawing.Color.Black
        Me.LExitencia.Location = New System.Drawing.Point(18, 184)
        Me.LExitencia.Name = "LExitencia"
        Me.LExitencia.Size = New System.Drawing.Size(69, 16)
        Me.LExitencia.TabIndex = 8
        Me.LExitencia.Text = "Existencia"
        '
        'TxtExistencia
        '
        Me.TxtExistencia.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtExistencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtExistencia.Location = New System.Drawing.Point(93, 184)
        Me.TxtExistencia.Multiline = True
        Me.TxtExistencia.Name = "TxtExistencia"
        Me.TxtExistencia.ReadOnly = True
        Me.TxtExistencia.Size = New System.Drawing.Size(119, 15)
        Me.TxtExistencia.TabIndex = 9
        Me.TxtExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreP
        '
        Me.TxtNombreP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtNombreP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreP.Location = New System.Drawing.Point(93, 78)
        Me.TxtNombreP.Multiline = True
        Me.TxtNombreP.Name = "TxtNombreP"
        Me.TxtNombreP.ReadOnly = True
        Me.TxtNombreP.Size = New System.Drawing.Size(119, 90)
        Me.TxtNombreP.TabIndex = 2
        '
        'TxtClaveP
        '
        Me.TxtClaveP.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtClaveP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtClaveP.Location = New System.Drawing.Point(93, 47)
        Me.TxtClaveP.Multiline = True
        Me.TxtClaveP.Name = "TxtClaveP"
        Me.TxtClaveP.ReadOnly = True
        Me.TxtClaveP.Size = New System.Drawing.Size(119, 15)
        Me.TxtClaveP.TabIndex = 1
        '
        'LClave
        '
        Me.LClave.AutoSize = True
        Me.LClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LClave.ForeColor = System.Drawing.Color.Black
        Me.LClave.Location = New System.Drawing.Point(18, 35)
        Me.LClave.Name = "LClave"
        Me.LClave.Size = New System.Drawing.Size(68, 32)
        Me.LClave.TabIndex = 0
        Me.LClave.Text = "Clave del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto"
        Me.LClave.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.ForeColor = System.Drawing.Color.Black
        Me.LProducto.Location = New System.Drawing.Point(5, 76)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(82, 32)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Nombre del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Producto"
        Me.LProducto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'BGuardarMo
        '
        Me.BGuardarMo.BackColor = System.Drawing.Color.Transparent
        Me.BGuardarMo.Image = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardarMo.Location = New System.Drawing.Point(729, 274)
        Me.BGuardarMo.Name = "BGuardarMo"
        Me.BGuardarMo.Size = New System.Drawing.Size(47, 50)
        Me.BGuardarMo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BGuardarMo.TabIndex = 75
        Me.BGuardarMo.TabStop = False
        Me.BGuardarMo.Visible = False
        '
        'IDD
        '
        Me.IDD.AutoSize = True
        Me.IDD.Location = New System.Drawing.Point(377, 92)
        Me.IDD.Name = "IDD"
        Me.IDD.Size = New System.Drawing.Size(0, 13)
        Me.IDD.TabIndex = 76
        Me.IDD.Visible = False
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
        Me.GBusqueda.Location = New System.Drawing.Point(84, 68)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(374, 65)
        Me.GBusqueda.TabIndex = 77
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(85, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(282, 12)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Clave del Producto, Nombre del Producto, Marca O Codigo de Barra"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(308, 26)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(51, 39)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(281, 31)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'txtResponsable
        '
        Me.txtResponsable.AutoSize = True
        Me.txtResponsable.Location = New System.Drawing.Point(461, 91)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.Size = New System.Drawing.Size(0, 13)
        Me.txtResponsable.TabIndex = 78
        Me.txtResponsable.Visible = False
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
        Me.Nombre_Producto.Frozen = True
        Me.Nombre_Producto.HeaderText = "Nombre del Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        Me.Nombre_Producto.Width = 230
        '
        'Clave_Producto
        '
        Me.Clave_Producto.DataPropertyName = "Clave_Producto"
        Me.Clave_Producto.Frozen = True
        Me.Clave_Producto.HeaderText = "Clave del Producto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = True
        '
        'Existencia
        '
        Me.Existencia.DataPropertyName = "Existencia"
        Me.Existencia.Frozen = True
        Me.Existencia.HeaderText = "Existencia"
        Me.Existencia.Name = "Existencia"
        Me.Existencia.ReadOnly = True
        Me.Existencia.Width = 60
        '
        'Contabilizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(778, 514)
        Me.Controls.Add(Me.txtResponsable)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.IDD)
        Me.Controls.Add(Me.BGuardarMo)
        Me.Controls.Add(Me.GDatos_Generales)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Contabilizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contabilizar"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GDatos_Generales.ResumeLayout(False)
        Me.GDatos_Generales.PerformLayout()
        CType(Me.BGuardarMo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataView As DataGridView
    Friend WithEvents POpc As Panel
    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents GDatos_Generales As GroupBox
    Friend WithEvents TxtNombreP As TextBox
    Friend WithEvents TxtClaveP As TextBox
    Friend WithEvents LClave As Label
    Friend WithEvents LProducto As Label
    Friend WithEvents LExitencia As Label
    Friend WithEvents TxtExistencia As TextBox
    Friend WithEvents LNE As Label
    Friend WithEvents TxtNE As TextBox
    Friend WithEvents BGuardarMo As PictureBox
    Friend WithEvents IDD As Label
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtResponsable As Label
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Existencia As DataGridViewTextBoxColumn
End Class
