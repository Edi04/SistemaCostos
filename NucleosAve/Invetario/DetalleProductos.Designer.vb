<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleProductos
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
        Me.POpc = New System.Windows.Forms.Panel()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unitario_PZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU_Corte_PZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDP = New System.Windows.Forms.Label()
        Me.Producto = New System.Windows.Forms.TextBox()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(737, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 72
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(790, 1)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 71
        Me.BCerrar.TabStop = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(-1, 59)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(846, 10)
        Me.POpc.TabIndex = 73
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(568, 75)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(277, 62)
        Me.GBusqueda.TabIndex = 1
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda por Orden de Compra"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(229, 18)
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
        Me.TxtBusqueda.Location = New System.Drawing.Point(26, 24)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(193, 31)
        Me.TxtBusqueda.TabIndex = 1
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
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cantidad, Me.Created, Me.Precio_Unitario_PZA, Me.PU_Corte_PZA, Me.PU_Total, Me.Precio_Total, Me.Tipo_Cambio, Me.Orden_Compra})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(4, 147)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(838, 368)
        Me.DataView.TabIndex = 2
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_DProducto"
        Me.ID.Frozen = True
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ID.Text = ""
        Me.ID.Width = 25
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.Frozen = True
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 70
        '
        'Created
        '
        Me.Created.DataPropertyName = "Created"
        Me.Created.HeaderText = "Fecha de Ingreso"
        Me.Created.Name = "Created"
        Me.Created.ReadOnly = True
        '
        'Precio_Unitario_PZA
        '
        Me.Precio_Unitario_PZA.DataPropertyName = "Precio_Unitario_PZA"
        Me.Precio_Unitario_PZA.HeaderText = "Precio Unitario PZA"
        Me.Precio_Unitario_PZA.Name = "Precio_Unitario_PZA"
        Me.Precio_Unitario_PZA.ReadOnly = True
        '
        'PU_Corte_PZA
        '
        Me.PU_Corte_PZA.DataPropertyName = "PU_Corte_PZA"
        Me.PU_Corte_PZA.HeaderText = "Precio Unitario Corte PZA"
        Me.PU_Corte_PZA.Name = "PU_Corte_PZA"
        Me.PU_Corte_PZA.ReadOnly = True
        '
        'PU_Total
        '
        Me.PU_Total.DataPropertyName = "PU_Total"
        Me.PU_Total.HeaderText = "Precio Unitario Total"
        Me.PU_Total.Name = "PU_Total"
        Me.PU_Total.ReadOnly = True
        '
        'Precio_Total
        '
        Me.Precio_Total.DataPropertyName = "Precio_Total"
        Me.Precio_Total.HeaderText = "Precio Total"
        Me.Precio_Total.Name = "Precio_Total"
        Me.Precio_Total.ReadOnly = True
        '
        'Tipo_Cambio
        '
        Me.Tipo_Cambio.DataPropertyName = "Tipo_Cambio"
        Me.Tipo_Cambio.HeaderText = "Tipo de Cambio"
        Me.Tipo_Cambio.Name = "Tipo_Cambio"
        Me.Tipo_Cambio.ReadOnly = True
        '
        'Orden_Compra
        '
        Me.Orden_Compra.DataPropertyName = "Orden_Compra"
        Me.Orden_Compra.HeaderText = "Orden de Compra"
        Me.Orden_Compra.Name = "Orden_Compra"
        Me.Orden_Compra.ReadOnly = True
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.Location = New System.Drawing.Point(126, 1)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 0
        Me.IDP.Visible = False
        '
        'Producto
        '
        Me.Producto.BackColor = System.Drawing.Color.White
        Me.Producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(26, 75)
        Me.Producto.Multiline = True
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Size = New System.Drawing.Size(489, 62)
        Me.Producto.TabIndex = 74
        '
        'DetalleProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(845, 515)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetalleProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleProductos"
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents POpc As Panel
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DataView As DataGridView
    Friend WithEvents IDP As Label
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Created As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unitario_PZA As DataGridViewTextBoxColumn
    Friend WithEvents PU_Corte_PZA As DataGridViewTextBoxColumn
    Friend WithEvents PU_Total As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Total As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Cambio As DataGridViewTextBoxColumn
    Friend WithEvents Orden_Compra As DataGridViewTextBoxColumn
    Friend WithEvents Producto As TextBox
End Class
