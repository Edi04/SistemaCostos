<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entregas_diarias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entregas_diarias))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTime_hoy = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView_entregas = New System.Windows.Forms.DataGridView()
        Me.Panel_detalles = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePicker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DateTimePicker_fecha2 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox_observaciones = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox_calibre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_clave = New System.Windows.Forms.TextBox()
        Me.TextBox_kilogramo = New System.Windows.Forms.TextBox()
        Me.TextBox_moneda = New System.Windows.Forms.TextBox()
        Me.TextBox_precio = New System.Windows.Forms.TextBox()
        Me.TextBox_orden_compra = New System.Windows.Forms.TextBox()
        Me.TextBox_cantidad = New System.Windows.Forms.TextBox()
        Me.TextBox_cliente = New System.Windows.Forms.TextBox()
        Me.TextBox_ot = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_nprog = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_entregas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_detalles.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = CType(resources.GetObject("btn_minimizar.Image"), System.Drawing.Image)
        Me.btn_minimizar.InitialImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(967, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 31
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(1021, 1)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 30
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(488, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 20)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Entregas Diarias"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(337, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(482, 20)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DateTime_hoy
        '
        Me.DateTime_hoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime_hoy.Location = New System.Drawing.Point(396, 87)
        Me.DateTime_hoy.Name = "DateTime_hoy"
        Me.DateTime_hoy.Size = New System.Drawing.Size(328, 24)
        Me.DateTime_hoy.TabIndex = 113
        '
        'DataGridView_entregas
        '
        Me.DataGridView_entregas.AllowUserToAddRows = False
        Me.DataGridView_entregas.AllowUserToDeleteRows = False
        Me.DataGridView_entregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_entregas.Location = New System.Drawing.Point(12, 147)
        Me.DataGridView_entregas.Name = "DataGridView_entregas"
        Me.DataGridView_entregas.ReadOnly = True
        Me.DataGridView_entregas.Size = New System.Drawing.Size(1053, 409)
        Me.DataGridView_entregas.TabIndex = 114
        '
        'Panel_detalles
        '
        Me.Panel_detalles.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.Panel_detalles.Controls.Add(Me.Label17)
        Me.Panel_detalles.Controls.Add(Me.DateTimePicker_fecha)
        Me.Panel_detalles.Controls.Add(Me.Label18)
        Me.Panel_detalles.Controls.Add(Me.DateTimePicker_fecha2)
        Me.Panel_detalles.Controls.Add(Me.Label16)
        Me.Panel_detalles.Controls.Add(Me.TextBox_observaciones)
        Me.Panel_detalles.Controls.Add(Me.Label15)
        Me.Panel_detalles.Controls.Add(Me.TextBox_calibre)
        Me.Panel_detalles.Controls.Add(Me.Label14)
        Me.Panel_detalles.Controls.Add(Me.TextBox_descripcion)
        Me.Panel_detalles.Controls.Add(Me.Label13)
        Me.Panel_detalles.Controls.Add(Me.Label12)
        Me.Panel_detalles.Controls.Add(Me.Label11)
        Me.Panel_detalles.Controls.Add(Me.Label10)
        Me.Panel_detalles.Controls.Add(Me.Label9)
        Me.Panel_detalles.Controls.Add(Me.TextBox_clave)
        Me.Panel_detalles.Controls.Add(Me.TextBox_kilogramo)
        Me.Panel_detalles.Controls.Add(Me.TextBox_moneda)
        Me.Panel_detalles.Controls.Add(Me.TextBox_precio)
        Me.Panel_detalles.Controls.Add(Me.TextBox_orden_compra)
        Me.Panel_detalles.Controls.Add(Me.TextBox_cantidad)
        Me.Panel_detalles.Controls.Add(Me.TextBox_cliente)
        Me.Panel_detalles.Controls.Add(Me.TextBox_ot)
        Me.Panel_detalles.Controls.Add(Me.Label8)
        Me.Panel_detalles.Controls.Add(Me.Label7)
        Me.Panel_detalles.Controls.Add(Me.Label6)
        Me.Panel_detalles.Controls.Add(Me.Label5)
        Me.Panel_detalles.Controls.Add(Me.Label4)
        Me.Panel_detalles.Controls.Add(Me.Label3)
        Me.Panel_detalles.Controls.Add(Me.TextBox_nprog)
        Me.Panel_detalles.Controls.Add(Me.PictureBox2)
        Me.Panel_detalles.Location = New System.Drawing.Point(143, 216)
        Me.Panel_detalles.Name = "Panel_detalles"
        Me.Panel_detalles.Size = New System.Drawing.Size(797, 258)
        Me.Panel_detalles.TabIndex = 115
        Me.Panel_detalles.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label17.Location = New System.Drawing.Point(352, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 20)
        Me.Label17.TabIndex = 117
        Me.Label17.Text = "Detalles"
        '
        'DateTimePicker_fecha
        '
        Me.DateTimePicker_fecha.Location = New System.Drawing.Point(82, 191)
        Me.DateTimePicker_fecha.Name = "DateTimePicker_fecha"
        Me.DateTimePicker_fecha.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker_fecha.TabIndex = 152
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label18.Location = New System.Drawing.Point(178, 15)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(482, 20)
        Me.Label18.TabIndex = 116
        Me.Label18.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DateTimePicker_fecha2
        '
        Me.DateTimePicker_fecha2.Location = New System.Drawing.Point(82, 166)
        Me.DateTimePicker_fecha2.Name = "DateTimePicker_fecha2"
        Me.DateTimePicker_fecha2.Size = New System.Drawing.Size(213, 20)
        Me.DateTimePicker_fecha2.TabIndex = 151
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label16.Location = New System.Drawing.Point(528, 167)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 13)
        Me.Label16.TabIndex = 150
        Me.Label16.Text = "Observaciones"
        '
        'TextBox_observaciones
        '
        Me.TextBox_observaciones.Location = New System.Drawing.Point(625, 164)
        Me.TextBox_observaciones.Multiline = True
        Me.TextBox_observaciones.Name = "TextBox_observaciones"
        Me.TextBox_observaciones.Size = New System.Drawing.Size(144, 47)
        Me.TextBox_observaciones.TabIndex = 149
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label15.Location = New System.Drawing.Point(543, 86)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 148
        Me.Label15.Text = "Calibre"
        '
        'TextBox_calibre
        '
        Me.TextBox_calibre.Location = New System.Drawing.Point(626, 83)
        Me.TextBox_calibre.Name = "TextBox_calibre"
        Me.TextBox_calibre.Size = New System.Drawing.Size(143, 20)
        Me.TextBox_calibre.TabIndex = 147
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label14.Location = New System.Drawing.Point(543, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 146
        Me.Label14.Text = "Descripcion"
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.Location = New System.Drawing.Point(626, 108)
        Me.TextBox_descripcion.Multiline = True
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(143, 51)
        Me.TextBox_descripcion.TabIndex = 145
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label13.Location = New System.Drawing.Point(337, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "Clave"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(328, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 143
        Me.Label12.Text = "Kilogramo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(333, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 142
        Me.Label11.Text = "Moneda"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(333, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 141
        Me.Label10.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(284, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 13)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Orden de Compra"
        '
        'TextBox_clave
        '
        Me.TextBox_clave.Location = New System.Drawing.Point(395, 217)
        Me.TextBox_clave.Name = "TextBox_clave"
        Me.TextBox_clave.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_clave.TabIndex = 139
        '
        'TextBox_kilogramo
        '
        Me.TextBox_kilogramo.Location = New System.Drawing.Point(395, 191)
        Me.TextBox_kilogramo.Name = "TextBox_kilogramo"
        Me.TextBox_kilogramo.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_kilogramo.TabIndex = 138
        '
        'TextBox_moneda
        '
        Me.TextBox_moneda.Location = New System.Drawing.Point(395, 164)
        Me.TextBox_moneda.Name = "TextBox_moneda"
        Me.TextBox_moneda.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_moneda.TabIndex = 137
        '
        'TextBox_precio
        '
        Me.TextBox_precio.Location = New System.Drawing.Point(395, 138)
        Me.TextBox_precio.Name = "TextBox_precio"
        Me.TextBox_precio.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_precio.TabIndex = 136
        '
        'TextBox_orden_compra
        '
        Me.TextBox_orden_compra.Location = New System.Drawing.Point(395, 87)
        Me.TextBox_orden_compra.Name = "TextBox_orden_compra"
        Me.TextBox_orden_compra.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_orden_compra.TabIndex = 135
        '
        'TextBox_cantidad
        '
        Me.TextBox_cantidad.Location = New System.Drawing.Point(395, 113)
        Me.TextBox_cantidad.Name = "TextBox_cantidad"
        Me.TextBox_cantidad.Size = New System.Drawing.Size(124, 20)
        Me.TextBox_cantidad.TabIndex = 134
        '
        'TextBox_cliente
        '
        Me.TextBox_cliente.Location = New System.Drawing.Point(82, 139)
        Me.TextBox_cliente.Name = "TextBox_cliente"
        Me.TextBox_cliente.Size = New System.Drawing.Size(245, 20)
        Me.TextBox_cliente.TabIndex = 131
        '
        'TextBox_ot
        '
        Me.TextBox_ot.Location = New System.Drawing.Point(82, 113)
        Me.TextBox_ot.Name = "TextBox_ot"
        Me.TextBox_ot.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_ot.TabIndex = 130
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(331, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 129
        Me.Label8.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(24, 193)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(23, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 125
        Me.Label6.Text = "Fecha 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(22, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(22, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "OT Ave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "N Prog"
        '
        'TextBox_nprog
        '
        Me.TextBox_nprog.Location = New System.Drawing.Point(82, 87)
        Me.TextBox_nprog.Name = "TextBox_nprog"
        Me.TextBox_nprog.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_nprog.TabIndex = 118
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.PictureBox2.Location = New System.Drawing.Point(747, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 43)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 116
        Me.PictureBox2.TabStop = False
        '
        'Entregas_diarias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1077, 568)
        Me.Controls.Add(Me.Panel_detalles)
        Me.Controls.Add(Me.DataGridView_entregas)
        Me.Controls.Add(Me.DateTime_hoy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Entregas_diarias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entregas_diarias"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_entregas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_detalles.ResumeLayout(False)
        Me.Panel_detalles.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTime_hoy As DateTimePicker
    Friend WithEvents DataGridView_entregas As DataGridView
    Friend WithEvents Panel_detalles As Panel
    Friend WithEvents DateTimePicker_fecha As DateTimePicker
    Friend WithEvents DateTimePicker_fecha2 As DateTimePicker
    Friend WithEvents Label16 As Label
    Friend WithEvents TextBox_observaciones As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox_calibre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_clave As TextBox
    Friend WithEvents TextBox_kilogramo As TextBox
    Friend WithEvents TextBox_moneda As TextBox
    Friend WithEvents TextBox_precio As TextBox
    Friend WithEvents TextBox_orden_compra As TextBox
    Friend WithEvents TextBox_cantidad As TextBox
    Friend WithEvents TextBox_cliente As TextBox
    Friend WithEvents TextBox_ot As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_nprog As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
End Class
