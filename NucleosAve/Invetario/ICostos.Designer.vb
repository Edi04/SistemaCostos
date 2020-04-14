<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ICostos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMostrarHist = New System.Windows.Forms.Button()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.DataView = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Nombre_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Minimo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Maximo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Flete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitarioUSD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUPZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUCortePZA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PUTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIOTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORDENCOMPRA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(800, 2)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 7
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(856, 2)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 8
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'BMostrarHist
        '
        Me.BMostrarHist.BackColor = System.Drawing.Color.Transparent
        Me.BMostrarHist.BackgroundImage = Global.NucleosAve.My.Resources.Resources.list_81
        Me.BMostrarHist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMostrarHist.Location = New System.Drawing.Point(669, 2)
        Me.BMostrarHist.Name = "BMostrarHist"
        Me.BMostrarHist.Size = New System.Drawing.Size(50, 50)
        Me.BMostrarHist.TabIndex = 5
        Me.BMostrarHist.UseVisualStyleBackColor = False
        Me.BMostrarHist.Visible = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(-80, 58)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(1047, 10)
        Me.POpc.TabIndex = 6
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre_Producto, Me.Clave_Producto, Me.Minimo, Me.Maximo, Me.Exis, Me.PUUS, Me.Flete, Me.PrecioUnitarioUSD, Me.TipoCambio, Me.PrecioUPZA, Me.PUCortePZA, Me.UMedida, Me.PUTotal, Me.PRECIOTOTAL, Me.ORDENCOMPRA})
        Me.DataView.EnableHeadersVisualStyles = False
        Me.DataView.GridColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataView.Location = New System.Drawing.Point(4, 149)
        Me.DataView.Name = "DataView"
        Me.DataView.ReadOnly = True
        Me.DataView.Size = New System.Drawing.Size(1009, 443)
        Me.DataView.TabIndex = 10
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
        Me.ID.Width = 40
        '
        'Nombre_Producto
        '
        Me.Nombre_Producto.DataPropertyName = "Nombre_Producto"
        Me.Nombre_Producto.FillWeight = 150.0!
        Me.Nombre_Producto.HeaderText = "Nombre del Producto"
        Me.Nombre_Producto.Name = "Nombre_Producto"
        Me.Nombre_Producto.ReadOnly = True
        Me.Nombre_Producto.Width = 300
        '
        'Clave_Producto
        '
        Me.Clave_Producto.DataPropertyName = "Clave_Producto"
        Me.Clave_Producto.HeaderText = "Clave del Producto"
        Me.Clave_Producto.Name = "Clave_Producto"
        Me.Clave_Producto.ReadOnly = True
        '
        'Minimo
        '
        Me.Minimo.HeaderText = "Mínimo"
        Me.Minimo.Name = "Minimo"
        Me.Minimo.ReadOnly = True
        '
        'Maximo
        '
        Me.Maximo.HeaderText = "Máximo"
        Me.Maximo.Name = "Maximo"
        Me.Maximo.ReadOnly = True
        '
        'Exis
        '
        Me.Exis.DataPropertyName = "Existencia"
        Me.Exis.HeaderText = "Existencia"
        Me.Exis.Name = "Exis"
        Me.Exis.ReadOnly = True
        Me.Exis.Width = 50
        '
        'PUUS
        '
        Me.PUUS.HeaderText = "Precio Unitario USD"
        Me.PUUS.Name = "PUUS"
        Me.PUUS.ReadOnly = True
        '
        'Flete
        '
        Me.Flete.HeaderText = "SHIPPING / FLETE"
        Me.Flete.Name = "Flete"
        Me.Flete.ReadOnly = True
        '
        'PrecioUnitarioUSD
        '
        Me.PrecioUnitarioUSD.HeaderText = "Precio Unitario USD"
        Me.PrecioUnitarioUSD.Name = "PrecioUnitarioUSD"
        Me.PrecioUnitarioUSD.ReadOnly = True
        '
        'TipoCambio
        '
        Me.TipoCambio.HeaderText = "Tipo de Cambio"
        Me.TipoCambio.Name = "TipoCambio"
        Me.TipoCambio.ReadOnly = True
        '
        'PrecioUPZA
        '
        Me.PrecioUPZA.HeaderText = "Precio Unitario PZA"
        Me.PrecioUPZA.Name = "PrecioUPZA"
        Me.PrecioUPZA.ReadOnly = True
        '
        'PUCortePZA
        '
        Me.PUCortePZA.HeaderText = "P.U Corte PZA"
        Me.PUCortePZA.Name = "PUCortePZA"
        Me.PUCortePZA.ReadOnly = True
        '
        'UMedida
        '
        Me.UMedida.HeaderText = "Unidad de Medida"
        Me.UMedida.Name = "UMedida"
        Me.UMedida.ReadOnly = True
        '
        'PUTotal
        '
        Me.PUTotal.HeaderText = "PU TOTAL"
        Me.PUTotal.Name = "PUTotal"
        Me.PUTotal.ReadOnly = True
        '
        'PRECIOTOTAL
        '
        Me.PRECIOTOTAL.HeaderText = "PRECIOTOTAL"
        Me.PRECIOTOTAL.Name = "PRECIOTOTAL"
        Me.PRECIOTOTAL.ReadOnly = True
        '
        'ORDENCOMPRA
        '
        Me.ORDENCOMPRA.HeaderText = "OC"
        Me.ORDENCOMPRA.Name = "ORDENCOMPRA"
        Me.ORDENCOMPRA.ReadOnly = True
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
        Me.GBusqueda.Location = New System.Drawing.Point(36, 75)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(552, 65)
        Me.GBusqueda.TabIndex = 11
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
        Me.LEspecific.Text = "Clave del Producto, Nombre del Producto, Marca O Codigo de Barra"
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
        'ICostos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1015, 597)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.DataView)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BMostrarHist)
        Me.Controls.Add(Me.POpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ICostos"
        Me.Text = "ICostos"
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMostrarHist As Button
    Friend WithEvents POpc As Panel
    Friend WithEvents DataView As DataGridView
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Nombre_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Clave_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Minimo As DataGridViewTextBoxColumn
    Friend WithEvents Maximo As DataGridViewTextBoxColumn
    Friend WithEvents Exis As DataGridViewTextBoxColumn
    Friend WithEvents PUUS As DataGridViewTextBoxColumn
    Friend WithEvents Flete As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitarioUSD As DataGridViewTextBoxColumn
    Friend WithEvents TipoCambio As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUPZA As DataGridViewTextBoxColumn
    Friend WithEvents PUCortePZA As DataGridViewTextBoxColumn
    Friend WithEvents UMedida As DataGridViewTextBoxColumn
    Friend WithEvents PUTotal As DataGridViewTextBoxColumn
    Friend WithEvents PRECIOTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents ORDENCOMPRA As DataGridViewTextBoxColumn
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
End Class
