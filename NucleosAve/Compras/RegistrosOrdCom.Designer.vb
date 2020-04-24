<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistrosOrdCom
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrosOrdCom))
        Me.DataGridRegistrosOd = New System.Windows.Forms.DataGridView()
        Me.SISUT020DataSet = New NucleosAve.SISUT020DataSet()
        Me.SISUT020DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.DateTimeRango1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeRango2 = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_pdf = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_bAlmacen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_busqueda_almacen = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_codigo_orden = New System.Windows.Forms.TextBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_cerrarventanita = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridRegistrosOd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISUT020DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISUT020DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_bAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_busqueda_almacen.SuspendLayout()
        CType(Me.btn_cerrarventanita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridRegistrosOd
        '
        Me.DataGridRegistrosOd.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridRegistrosOd.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistrosOd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridRegistrosOd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DataGridRegistrosOd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridRegistrosOd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistrosOd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistrosOd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistrosOd.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRegistrosOd.GridColor = System.Drawing.Color.Maroon
        Me.DataGridRegistrosOd.Location = New System.Drawing.Point(12, 127)
        Me.DataGridRegistrosOd.Name = "DataGridRegistrosOd"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistrosOd.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRegistrosOd.Size = New System.Drawing.Size(827, 268)
        Me.DataGridRegistrosOd.TabIndex = 0
        '
        'SISUT020DataSet
        '
        Me.SISUT020DataSet.DataSetName = "SISUT020DataSet"
        Me.SISUT020DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SISUT020DataSetBindingSource
        '
        Me.SISUT020DataSetBindingSource.DataSource = Me.SISUT020DataSet
        Me.SISUT020DataSetBindingSource.Position = 0
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(741, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 15
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(795, 0)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 14
        Me.btn_Cerrar.TabStop = False
        '
        'DateTimeRango1
        '
        Me.DateTimeRango1.Location = New System.Drawing.Point(198, 47)
        Me.DateTimeRango1.Name = "DateTimeRango1"
        Me.DateTimeRango1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimeRango1.TabIndex = 17
        Me.DateTimeRango1.Value = New Date(2020, 3, 24, 12, 2, 58, 0)
        '
        'DateTimeRango2
        '
        Me.DateTimeRango2.Location = New System.Drawing.Point(449, 47)
        Me.DateTimeRango2.Name = "DateTimeRango2"
        Me.DateTimeRango2.Size = New System.Drawing.Size(202, 20)
        Me.DateTimeRango2.TabIndex = 18
        Me.DateTimeRango2.Value = New Date(2020, 3, 24, 12, 3, 27, 0)
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(333, 79)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(184, 38)
        Me.btnBuscar.TabIndex = 19
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(674, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Visualizar/Generar PDF"
        '
        'btn_pdf
        '
        Me.btn_pdf.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_pdf.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btn_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_pdf.Image = Global.NucleosAve.My.Resources.Resources.notepad_101
        Me.btn_pdf.Location = New System.Drawing.Point(726, 68)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(38, 38)
        Me.btn_pdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pdf.TabIndex = 20
        Me.btn_pdf.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 178
        Me.PictureBox2.TabStop = False
        '
        'btn_bAlmacen
        '
        Me.btn_bAlmacen.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_bAlmacen.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_bAlmacen.BackColor = System.Drawing.Color.Transparent
        Me.btn_bAlmacen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_bAlmacen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btn_bAlmacen.Image = Global.NucleosAve.My.Resources.Resources.icons8_warehouse_80
        Me.btn_bAlmacen.Location = New System.Drawing.Point(143, 68)
        Me.btn_bAlmacen.Name = "btn_bAlmacen"
        Me.btn_bAlmacen.Size = New System.Drawing.Size(38, 38)
        Me.btn_bAlmacen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_bAlmacen.TabIndex = 179
        Me.btn_bAlmacen.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(102, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 180
        Me.Label1.Text = "Busqueda Almacen"
        '
        'Panel_busqueda_almacen
        '
        Me.Panel_busqueda_almacen.BackColor = System.Drawing.Color.White
        Me.Panel_busqueda_almacen.Controls.Add(Me.Label4)
        Me.Panel_busqueda_almacen.Controls.Add(Me.btn_cerrarventanita)
        Me.Panel_busqueda_almacen.Controls.Add(Me.Label2)
        Me.Panel_busqueda_almacen.Controls.Add(Me.TextBox_codigo_orden)
        Me.Panel_busqueda_almacen.Controls.Add(Me.btn_buscar)
        Me.Panel_busqueda_almacen.Location = New System.Drawing.Point(216, 153)
        Me.Panel_busqueda_almacen.Name = "Panel_busqueda_almacen"
        Me.Panel_busqueda_almacen.Size = New System.Drawing.Size(411, 94)
        Me.Panel_busqueda_almacen.TabIndex = 181
        Me.Panel_busqueda_almacen.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(19, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 184
        Me.Label2.Text = "Codigo Orden Compra"
        '
        'TextBox_codigo_orden
        '
        Me.TextBox_codigo_orden.Location = New System.Drawing.Point(20, 60)
        Me.TextBox_codigo_orden.Name = "TextBox_codigo_orden"
        Me.TextBox_codigo_orden.Size = New System.Drawing.Size(229, 20)
        Me.TextBox_codigo_orden.TabIndex = 183
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.btn_buscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btn_buscar.Location = New System.Drawing.Point(273, 52)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(129, 33)
        Me.btn_buscar.TabIndex = 182
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'btn_cerrarventanita
        '
        Me.btn_cerrarventanita.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_cerrarventanita.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cerrarventanita.BackColor = System.Drawing.Color.Transparent
        Me.btn_cerrarventanita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cerrarventanita.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_cerrarventanita.Location = New System.Drawing.Point(372, 0)
        Me.btn_cerrarventanita.Name = "btn_cerrarventanita"
        Me.btn_cerrarventanita.Size = New System.Drawing.Size(39, 34)
        Me.btn_cerrarventanita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_cerrarventanita.TabIndex = 182
        Me.btn_cerrarventanita.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(146, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "Busqueda por Codigo"
        '
        'RegistrosOrdCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(851, 407)
        Me.Controls.Add(Me.Panel_busqueda_almacen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_bAlmacen)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_pdf)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DateTimeRango2)
        Me.Controls.Add(Me.DateTimeRango1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.DataGridRegistrosOd)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrosOrdCom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrosOrdCom"
        CType(Me.DataGridRegistrosOd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISUT020DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISUT020DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_bAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_busqueda_almacen.ResumeLayout(False)
        Me.Panel_busqueda_almacen.PerformLayout()
        CType(Me.btn_cerrarventanita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridRegistrosOd As DataGridView
    Friend WithEvents SISUT020DataSetBindingSource As BindingSource
    Friend WithEvents SISUT020DataSet As SISUT020DataSet
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents DateTimeRango1 As DateTimePicker
    Friend WithEvents DateTimeRango2 As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_pdf As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_bAlmacen As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_busqueda_almacen As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_codigo_orden As TextBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_cerrarventanita As PictureBox
End Class
