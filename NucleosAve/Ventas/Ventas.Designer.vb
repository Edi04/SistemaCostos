<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_Factura = New System.Windows.Forms.TextBox()
        Me.TextBox_total = New System.Windows.Forms.TextBox()
        Me.TextBox_estatus = New System.Windows.Forms.TextBox()
        Me.DateTimePicker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Text_Url_Pdf = New System.Windows.Forms.TextBox()
        Me.btn_pdf = New System.Windows.Forms.PictureBox()
        Me.btn_buscar = New System.Windows.Forms.PictureBox()
        Me.textpdf = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.BtnGuardarFac = New System.Windows.Forms.Button()
        Me.TextBox_codigo_general = New System.Windows.Forms.TextBox()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.btn_regis = New System.Windows.Forms.PictureBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.btn_regis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(688, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 118
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(744, 0)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 117
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(362, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 116
        Me.Label2.Text = "Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(207, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 115
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'TextBox_Factura
        '
        Me.TextBox_Factura.Location = New System.Drawing.Point(13, 40)
        Me.TextBox_Factura.Name = "TextBox_Factura"
        Me.TextBox_Factura.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Factura.TabIndex = 119
        '
        'TextBox_total
        '
        Me.TextBox_total.Location = New System.Drawing.Point(167, 40)
        Me.TextBox_total.Name = "TextBox_total"
        Me.TextBox_total.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_total.TabIndex = 120
        '
        'TextBox_estatus
        '
        Me.TextBox_estatus.Location = New System.Drawing.Point(282, 40)
        Me.TextBox_estatus.Name = "TextBox_estatus"
        Me.TextBox_estatus.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_estatus.TabIndex = 121
        '
        'DateTimePicker_fecha
        '
        Me.DateTimePicker_fecha.Location = New System.Drawing.Point(399, 40)
        Me.DateTimePicker_fecha.Name = "DateTimePicker_fecha"
        Me.DateTimePicker_fecha.Size = New System.Drawing.Size(211, 20)
        Me.DateTimePicker_fecha.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(13, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 124
        Me.Label3.Text = "Factura"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(164, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(279, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "Estatus"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(396, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 127
        Me.Label6.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(619, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Factura Pdf"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Text_Url_Pdf)
        Me.Panel1.Controls.Add(Me.btn_pdf)
        Me.Panel1.Controls.Add(Me.btn_buscar)
        Me.Panel1.Controls.Add(Me.TextBox_Factura)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox_total)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox_estatus)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.DateTimePicker_fecha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(12, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 82)
        Me.Panel1.TabIndex = 129
        '
        'Text_Url_Pdf
        '
        Me.Text_Url_Pdf.Cursor = System.Windows.Forms.Cursors.No
        Me.Text_Url_Pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text_Url_Pdf.Location = New System.Drawing.Point(616, 40)
        Me.Text_Url_Pdf.Name = "Text_Url_Pdf"
        Me.Text_Url_Pdf.Size = New System.Drawing.Size(114, 20)
        Me.Text_Url_Pdf.TabIndex = 196
        '
        'btn_pdf
        '
        Me.btn_pdf.BackColor = System.Drawing.Color.Transparent
        Me.btn_pdf.Image = Global.NucleosAve.My.Resources.Resources.icons8_pdf_100
        Me.btn_pdf.Location = New System.Drawing.Point(733, 35)
        Me.btn_pdf.Name = "btn_pdf"
        Me.btn_pdf.Size = New System.Drawing.Size(30, 25)
        Me.btn_pdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_pdf.TabIndex = 197
        Me.btn_pdf.TabStop = False
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = Global.NucleosAve.My.Resources.Resources.icons8_google_web_search_512
        Me.btn_buscar.Location = New System.Drawing.Point(119, 36)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(29, 24)
        Me.btn_buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_buscar.TabIndex = 129
        Me.btn_buscar.TabStop = False
        '
        'textpdf
        '
        Me.textpdf.Cursor = System.Windows.Forms.Cursors.No
        Me.textpdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textpdf.Location = New System.Drawing.Point(659, 83)
        Me.textpdf.Name = "textpdf"
        Me.textpdf.ReadOnly = True
        Me.textpdf.Size = New System.Drawing.Size(129, 20)
        Me.textpdf.TabIndex = 195
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel10.Controls.Add(Me.btn_modificar)
        Me.Panel10.Controls.Add(Me.btn_clean)
        Me.Panel10.Controls.Add(Me.BtnGuardarFac)
        Me.Panel10.Location = New System.Drawing.Point(197, 203)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(425, 73)
        Me.Panel10.TabIndex = 196
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_modificar.Location = New System.Drawing.Point(285, 22)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(119, 32)
        Me.btn_modificar.TabIndex = 184
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_clean
        '
        Me.btn_clean.BackColor = System.Drawing.Color.DodgerBlue
        Me.btn_clean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clean.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_clean.Location = New System.Drawing.Point(142, 22)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(137, 32)
        Me.btn_clean.TabIndex = 186
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = False
        '
        'BtnGuardarFac
        '
        Me.BtnGuardarFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnGuardarFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarFac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardarFac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardarFac.Location = New System.Drawing.Point(13, 22)
        Me.BtnGuardarFac.Name = "BtnGuardarFac"
        Me.BtnGuardarFac.Size = New System.Drawing.Size(123, 32)
        Me.BtnGuardarFac.TabIndex = 185
        Me.BtnGuardarFac.Text = "Guardar"
        Me.BtnGuardarFac.UseVisualStyleBackColor = False
        '
        'TextBox_codigo_general
        '
        Me.TextBox_codigo_general.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox_codigo_general.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_codigo_general.Location = New System.Drawing.Point(12, 83)
        Me.TextBox_codigo_general.Name = "TextBox_codigo_general"
        Me.TextBox_codigo_general.ReadOnly = True
        Me.TextBox_codigo_general.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_codigo_general.TabIndex = 197
        '
        'TextBox_id
        '
        Me.TextBox_id.Cursor = System.Windows.Forms.Cursors.No
        Me.TextBox_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_id.Location = New System.Drawing.Point(493, 83)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.ReadOnly = True
        Me.TextBox_id.Size = New System.Drawing.Size(129, 20)
        Me.TextBox_id.TabIndex = 198
        '
        'btn_regis
        '
        Me.btn_regis.BackColor = System.Drawing.Color.Transparent
        Me.btn_regis.Image = Global.NucleosAve.My.Resources.Resources.icons8_google_web_search_512
        Me.btn_regis.Location = New System.Drawing.Point(757, 75)
        Me.btn_regis.Name = "btn_regis"
        Me.btn_regis.Size = New System.Drawing.Size(31, 28)
        Me.btn_regis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_regis.TabIndex = 199
        Me.btn_regis.TabStop = False
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(800, 298)
        Me.Controls.Add(Me.btn_regis)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.TextBox_codigo_general)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.textpdf)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btn_pdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_buscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.btn_regis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_Factura As TextBox
    Friend WithEvents TextBox_total As TextBox
    Friend WithEvents TextBox_estatus As TextBox
    Friend WithEvents DateTimePicker_fecha As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_buscar As PictureBox
    Friend WithEvents Text_Url_Pdf As TextBox
    Friend WithEvents textpdf As TextBox
    Friend WithEvents btn_pdf As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_clean As Button
    Friend WithEvents BtnGuardarFac As Button
    Friend WithEvents TextBox_codigo_general As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents btn_regis As PictureBox
End Class
