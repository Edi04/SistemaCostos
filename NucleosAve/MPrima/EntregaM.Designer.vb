<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EntregaM
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.LCS = New System.Windows.Forms.Label()
        Me.LEMP = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.DTF1 = New System.Windows.Forms.DateTimePicker()
        Me.DTF2 = New System.Windows.Forms.DateTimePicker()
        Me.CFechas = New System.Windows.Forms.CheckBox()
        Me.BBOC1 = New System.Windows.Forms.Button()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.CSeguimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaRegistro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLlegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UMedida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calibre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Externo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Num_Interno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DGHR = New System.Windows.Forms.DataGridView()
        Me.POpc.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.DGHR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(950, 0)
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
        Me.BCerrar.Location = New System.Drawing.Point(1000, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 8
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Controls.Add(Me.LCS)
        Me.POpc.Location = New System.Drawing.Point(-89, 54)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(1252, 10)
        Me.POpc.TabIndex = 9
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(225, 0)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 60
        Me.LCS.Visible = False
        '
        'LEMP
        '
        Me.LEMP.AutoSize = True
        Me.LEMP.BackColor = System.Drawing.Color.Transparent
        Me.LEMP.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEMP.Location = New System.Drawing.Point(396, 80)
        Me.LEMP.Name = "LEMP"
        Me.LEMP.Size = New System.Drawing.Size(246, 24)
        Me.LEMP.TabIndex = 68
        Me.LEMP.Text = "Entrega de Materia Prima"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(22, 26)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(400, 31)
        Me.TxtBusqueda.TabIndex = 0
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(428, 25)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(34, 37)
        Me.PBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBusqueda.TabIndex = 26
        Me.PBusqueda.TabStop = False
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(92, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(163, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Núm. de Rollo, Orden de Compra"
        '
        'DTF1
        '
        Me.DTF1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF1.Location = New System.Drawing.Point(491, 34)
        Me.DTF1.Name = "DTF1"
        Me.DTF1.Size = New System.Drawing.Size(267, 21)
        Me.DTF1.TabIndex = 71
        '
        'DTF2
        '
        Me.DTF2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTF2.Location = New System.Drawing.Point(764, 34)
        Me.DTF2.Name = "DTF2"
        Me.DTF2.Size = New System.Drawing.Size(262, 21)
        Me.DTF2.TabIndex = 73
        '
        'CFechas
        '
        Me.CFechas.AutoSize = True
        Me.CFechas.Checked = True
        Me.CFechas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CFechas.Location = New System.Drawing.Point(682, 9)
        Me.CFechas.Name = "CFechas"
        Me.CFechas.Size = New System.Drawing.Size(165, 22)
        Me.CFechas.TabIndex = 74
        Me.CFechas.Text = "Fecha de Registro"
        Me.CFechas.UseVisualStyleBackColor = True
        '
        'BBOC1
        '
        Me.BBOC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BBOC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBOC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBOC1.Location = New System.Drawing.Point(726, 56)
        Me.BBOC1.Name = "BBOC1"
        Me.BBOC1.Size = New System.Drawing.Size(75, 23)
        Me.BBOC1.TabIndex = 75
        Me.BBOC1.Text = "Buscar"
        Me.BBOC1.UseVisualStyleBackColor = False
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.BBOC1)
        Me.GBusqueda.Controls.Add(Me.CFechas)
        Me.GBusqueda.Controls.Add(Me.DTF2)
        Me.GBusqueda.Controls.Add(Me.DTF1)
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(12, 114)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(1035, 81)
        Me.GBusqueda.TabIndex = 69
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'CSeguimiento
        '
        Me.CSeguimiento.DataPropertyName = "CSeguimiento"
        Me.CSeguimiento.HeaderText = "CSeguimiento"
        Me.CSeguimiento.Name = "CSeguimiento"
        Me.CSeguimiento.Visible = False
        '
        'FechaRegistro
        '
        Me.FechaRegistro.DataPropertyName = "Fecha_Registro"
        Me.FechaRegistro.HeaderText = "FechaRegistro"
        Me.FechaRegistro.Name = "FechaRegistro"
        '
        'FechaLlegada
        '
        Me.FechaLlegada.DataPropertyName = "Fecha_Llegada"
        Me.FechaLlegada.HeaderText = "FechaLlegada"
        Me.FechaLlegada.Name = "FechaLlegada"
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'UMedida
        '
        Me.UMedida.DataPropertyName = "UMedida"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.UMedida.DefaultCellStyle = DataGridViewCellStyle1
        Me.UMedida.HeaderText = "UMedida"
        Me.UMedida.Name = "UMedida"
        Me.UMedida.Width = 55
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Peso.DefaultCellStyle = DataGridViewCellStyle2
        Me.Peso.HeaderText = "Peso"
        Me.Peso.Name = "Peso"
        Me.Peso.Width = 60
        '
        'Ancho
        '
        Me.Ancho.DataPropertyName = "Ancho"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Ancho.DefaultCellStyle = DataGridViewCellStyle3
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        Me.Ancho.Width = 60
        '
        'Calibre
        '
        Me.Calibre.DataPropertyName = "Calibre"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Calibre.DefaultCellStyle = DataGridViewCellStyle4
        Me.Calibre.HeaderText = "Calibre"
        Me.Calibre.Name = "Calibre"
        Me.Calibre.Width = 60
        '
        'Num_Externo
        '
        Me.Num_Externo.DataPropertyName = "Num_Externo"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Num_Externo.DefaultCellStyle = DataGridViewCellStyle5
        Me.Num_Externo.HeaderText = "Num_Externo"
        Me.Num_Externo.Name = "Num_Externo"
        Me.Num_Externo.Width = 80
        '
        'Num_Interno
        '
        Me.Num_Interno.DataPropertyName = "Num_Interno"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Num_Interno.DefaultCellStyle = DataGridViewCellStyle6
        Me.Num_Interno.FillWeight = 150.0!
        Me.Num_Interno.HeaderText = "Num_Interno"
        Me.Num_Interno.Name = "Num_Interno"
        Me.Num_Interno.Width = 80
        '
        'Proveedor
        '
        Me.Proveedor.DataPropertyName = "Proveedor"
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        Me.Proveedor.Width = 380
        '
        'OCompra
        '
        Me.OCompra.DataPropertyName = "OCompra"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.OCompra.DefaultCellStyle = DataGridViewCellStyle7
        Me.OCompra.HeaderText = "OCompra"
        Me.OCompra.Name = "OCompra"
        Me.OCompra.Width = 60
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_MPrim"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ID.DefaultCellStyle = DataGridViewCellStyle8
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 45
        '
        'DGHR
        '
        Me.DGHR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.OCompra, Me.Proveedor, Me.Num_Interno, Me.Num_Externo, Me.Calibre, Me.Ancho, Me.Peso, Me.UMedida, Me.Descripcion, Me.FechaLlegada, Me.FechaRegistro, Me.CSeguimiento})
        Me.DGHR.Location = New System.Drawing.Point(1, 201)
        Me.DGHR.Name = "DGHR"
        Me.DGHR.Size = New System.Drawing.Size(1050, 381)
        Me.DGHR.TabIndex = 70
        '
        'EntregaM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1052, 582)
        Me.Controls.Add(Me.DGHR)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LEMP)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.POpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EntregaM"
        Me.Text = "EntregaM"
        Me.POpc.ResumeLayout(False)
        Me.POpc.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.DGHR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents POpc As Panel
    Friend WithEvents LCS As Label
    Friend WithEvents LEMP As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents DTF1 As DateTimePicker
    Friend WithEvents DTF2 As DateTimePicker
    Friend WithEvents CFechas As CheckBox
    Friend WithEvents BBOC1 As Button
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents CSeguimiento As DataGridViewTextBoxColumn
    Friend WithEvents FechaRegistro As DataGridViewTextBoxColumn
    Friend WithEvents FechaLlegada As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents UMedida As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Ancho As DataGridViewTextBoxColumn
    Friend WithEvents Calibre As DataGridViewTextBoxColumn
    Friend WithEvents Num_Externo As DataGridViewTextBoxColumn
    Friend WithEvents Num_Interno As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents OCompra As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents DGHR As DataGridView
End Class
