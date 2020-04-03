<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Compra_Conbustible
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compra_Conbustible))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox_pmn = New System.Windows.Forms.ComboBox()
        Me.btn_clean = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Responsable = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox_total = New System.Windows.Forms.TextBox()
        Me.TextBox_Precio = New System.Windows.Forms.TextBox()
        Me.TextBox_Litros = New System.Windows.Forms.TextBox()
        Me.DateTimeFecha = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_comprobante = New System.Windows.Forms.Button()
        Me.texturl = New System.Windows.Forms.TextBox()
        Me.texturl_def = New System.Windows.Forms.TextBox()
        Me.codigo_combus = New System.Windows.Forms.Label()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_clean, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(494, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 110
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(550, 0)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 109
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(221, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 15)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Compra Conbustible"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ComboBox_pmn)
        Me.GroupBox1.Controls.Add(Me.btn_clean)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox_Responsable)
        Me.GroupBox1.Controls.Add(Me.BtnGuardar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Tipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TextBox_total)
        Me.GroupBox1.Controls.Add(Me.TextBox_Precio)
        Me.GroupBox1.Controls.Add(Me.TextBox_Litros)
        Me.GroupBox1.Controls.Add(Me.DateTimeFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(256, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(275, 409)
        Me.GroupBox1.TabIndex = 113
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Combustible"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(26, 249)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 216
        Me.Label8.Text = "Magna/Premium"
        '
        'ComboBox_pmn
        '
        Me.ComboBox_pmn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_pmn.FormattingEnabled = True
        Me.ComboBox_pmn.Items.AddRange(New Object() {"Magna", "Premium", "Normal"})
        Me.ComboBox_pmn.Location = New System.Drawing.Point(29, 267)
        Me.ComboBox_pmn.Name = "ComboBox_pmn"
        Me.ComboBox_pmn.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox_pmn.TabIndex = 215
        '
        'btn_clean
        '
        Me.btn_clean.Image = Global.NucleosAve.My.Resources.Resources.icons8_broom_64
        Me.btn_clean.Location = New System.Drawing.Point(6, 380)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(26, 23)
        Me.btn_clean.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_clean.TabIndex = 119
        Me.btn_clean.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(26, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 214
        Me.Label7.Text = "Responsable"
        '
        'TextBox_Responsable
        '
        Me.TextBox_Responsable.Location = New System.Drawing.Point(29, 309)
        Me.TextBox_Responsable.Name = "TextBox_Responsable"
        Me.TextBox_Responsable.ReadOnly = True
        Me.TextBox_Responsable.Size = New System.Drawing.Size(210, 20)
        Me.TextBox_Responsable.TabIndex = 5
        Me.TextBox_Responsable.Text = "Armando Quiroz"
        Me.TextBox_Responsable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(147, 338)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(92, 35)
        Me.BtnGuardar.TabIndex = 184
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(26, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "Tipo"
        '
        'ComboBox_Tipo
        '
        Me.ComboBox_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Tipo.FormattingEnabled = True
        Me.ComboBox_Tipo.Items.AddRange(New Object() {"Gasolina", "Diesel"})
        Me.ComboBox_Tipo.Location = New System.Drawing.Point(29, 223)
        Me.ComboBox_Tipo.Name = "ComboBox_Tipo"
        Me.ComboBox_Tipo.Size = New System.Drawing.Size(210, 21)
        Me.ComboBox_Tipo.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(26, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 210
        Me.Label5.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(26, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(26, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 208
        Me.Label3.Text = "Litros Comprados"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.75!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label22.Location = New System.Drawing.Point(26, 33)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 207
        Me.Label22.Text = "Fecha"
        '
        'TextBox_total
        '
        Me.TextBox_total.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox_total.Location = New System.Drawing.Point(29, 180)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.ReadOnly = True
        Me.TextBox_total.Size = New System.Drawing.Size(210, 20)
        Me.TextBox_total.TabIndex = 3
        Me.TextBox_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Precio
        '
        Me.TextBox_Precio.Location = New System.Drawing.Point(29, 137)
        Me.TextBox_Precio.Name = "TextBox_Precio"
        Me.TextBox_Precio.Size = New System.Drawing.Size(210, 20)
        Me.TextBox_Precio.TabIndex = 2
        Me.TextBox_Precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox_Litros
        '
        Me.TextBox_Litros.Location = New System.Drawing.Point(29, 94)
        Me.TextBox_Litros.Name = "TextBox_Litros"
        Me.TextBox_Litros.Size = New System.Drawing.Size(210, 20)
        Me.TextBox_Litros.TabIndex = 1
        Me.TextBox_Litros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimeFecha
        '
        Me.DateTimeFecha.Location = New System.Drawing.Point(29, 52)
        Me.DateTimeFecha.Name = "DateTimeFecha"
        Me.DateTimeFecha.Size = New System.Drawing.Size(210, 20)
        Me.DateTimeFecha.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NucleosAve.My.Resources.Resources._889f90805c66acfd92517a7ed1d78764_icon
        Me.PictureBox1.Location = New System.Drawing.Point(33, 120)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(181, 179)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'btn_comprobante
        '
        Me.btn_comprobante.Image = Global.NucleosAve.My.Resources.Resources.icons_orden_de_compra
        Me.btn_comprobante.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_comprobante.Location = New System.Drawing.Point(56, 380)
        Me.btn_comprobante.Name = "btn_comprobante"
        Me.btn_comprobante.Size = New System.Drawing.Size(142, 70)
        Me.btn_comprobante.TabIndex = 115
        Me.btn_comprobante.Text = "Comprobante"
        Me.btn_comprobante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_comprobante.UseVisualStyleBackColor = True
        '
        'texturl
        '
        Me.texturl.Location = New System.Drawing.Point(41, 413)
        Me.texturl.Name = "texturl"
        Me.texturl.Size = New System.Drawing.Size(142, 20)
        Me.texturl.TabIndex = 116
        Me.texturl.Visible = False
        '
        'texturl_def
        '
        Me.texturl_def.Location = New System.Drawing.Point(41, 439)
        Me.texturl_def.Name = "texturl_def"
        Me.texturl_def.Size = New System.Drawing.Size(142, 20)
        Me.texturl_def.TabIndex = 117
        Me.texturl_def.Visible = False
        '
        'codigo_combus
        '
        Me.codigo_combus.AutoSize = True
        Me.codigo_combus.Location = New System.Drawing.Point(420, 53)
        Me.codigo_combus.Name = "codigo_combus"
        Me.codigo_combus.Size = New System.Drawing.Size(40, 13)
        Me.codigo_combus.TabIndex = 118
        Me.codigo_combus.Text = "Codigo"
        '
        'Compra_Conbustible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(605, 489)
        Me.Controls.Add(Me.codigo_combus)
        Me.Controls.Add(Me.texturl_def)
        Me.Controls.Add(Me.texturl)
        Me.Controls.Add(Me.btn_comprobante)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compra_Conbustible"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compra_Conbustible"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_clean, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_total As TextBox
    Friend WithEvents TextBox_Precio As TextBox
    Friend WithEvents TextBox_Litros As TextBox
    Friend WithEvents DateTimeFecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox_Tipo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btn_comprobante As Button
    Friend WithEvents texturl As TextBox
    Friend WithEvents texturl_def As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_Responsable As TextBox
    Friend WithEvents codigo_combus As Label
    Friend WithEvents btn_clean As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox_pmn As ComboBox
End Class
