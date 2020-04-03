<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialM
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
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.BMinimizar = New System.Windows.Forms.PictureBox()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.Producto = New System.Windows.Forms.TextBox()
        Me.IDP = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Unitario_PZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU_Corte_PZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PU_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_Cambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Orden_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
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
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Cantidad, Me.Precio_Unitario_PZA, Me.PU_Corte_PZA, Me.PU_Total, Me.Precio_Total, Me.Created, Me.Tipo_Cambio, Me.Orden_Compra})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(11, 176)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(544, 368)
        Me.DataView.TabIndex = 76
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(-152, 55)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(846, 10)
        Me.POpc.TabIndex = 79
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(460, 0)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 78
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(513, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 77
        Me.BCerrar.TabStop = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(26, 24)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(169, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(218, 18)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(39, 38)
        Me.PBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBusqueda.TabIndex = 26
        Me.PBusqueda.TabStop = False
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(306, 78)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(277, 62)
        Me.GBusqueda.TabIndex = 75
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda por Orden de Compra"
        '
        'Producto
        '
        Me.Producto.BackColor = System.Drawing.Color.White
        Me.Producto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.Location = New System.Drawing.Point(47, 96)
        Me.Producto.Multiline = True
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(227, 59)
        Me.Producto.TabIndex = 80
        '
        'IDP
        '
        Me.IDP.AutoSize = True
        Me.IDP.Location = New System.Drawing.Point(306, 147)
        Me.IDP.Name = "IDP"
        Me.IDP.Size = New System.Drawing.Size(0, 13)
        Me.IDP.TabIndex = 81
        Me.IDP.Visible = False
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
        'Precio_Unitario_PZA
        '
        Me.Precio_Unitario_PZA.DataPropertyName = "Precio_Unitario_PZA"
        Me.Precio_Unitario_PZA.HeaderText = "Precio Unitario PZA"
        Me.Precio_Unitario_PZA.Name = "Precio_Unitario_PZA"
        Me.Precio_Unitario_PZA.ReadOnly = True
        Me.Precio_Unitario_PZA.Visible = False
        '
        'PU_Corte_PZA
        '
        Me.PU_Corte_PZA.DataPropertyName = "PU_Corte_PZA"
        Me.PU_Corte_PZA.HeaderText = "Precio Unitario Corte PZA"
        Me.PU_Corte_PZA.Name = "PU_Corte_PZA"
        Me.PU_Corte_PZA.ReadOnly = True
        Me.PU_Corte_PZA.Visible = False
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
        'Created
        '
        Me.Created.DataPropertyName = "Created"
        Me.Created.HeaderText = "Fecha de Ingreso"
        Me.Created.Name = "Created"
        Me.Created.ReadOnly = True
        '
        'Tipo_Cambio
        '
        Me.Tipo_Cambio.DataPropertyName = "Tipo_Cambio"
        Me.Tipo_Cambio.HeaderText = "Tipo de Cambio"
        Me.Tipo_Cambio.Name = "Tipo_Cambio"
        Me.Tipo_Cambio.ReadOnly = True
        Me.Tipo_Cambio.Visible = False
        '
        'Orden_Compra
        '
        Me.Orden_Compra.DataPropertyName = "Orden_Compra"
        Me.Orden_Compra.HeaderText = "Orden de Compra"
        Me.Orden_Compra.Name = "Orden_Compra"
        Me.Orden_Compra.ReadOnly = True
        '
        'HistorialM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(568, 559)
        Me.Controls.Add(Me.IDP)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.POpc)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistorialM"
        Me.Text = "HistorialM"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataView As DataGridView
    Friend WithEvents POpc As Panel
    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents Producto As TextBox
    Friend WithEvents IDP As Label
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Unitario_PZA As DataGridViewTextBoxColumn
    Friend WithEvents PU_Corte_PZA As DataGridViewTextBoxColumn
    Friend WithEvents PU_Total As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Total As DataGridViewTextBoxColumn
    Friend WithEvents Created As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_Cambio As DataGridViewTextBoxColumn
    Friend WithEvents Orden_Compra As DataGridViewTextBoxColumn
End Class
