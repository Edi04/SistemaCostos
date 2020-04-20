<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes_Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes_Empleado))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Registros = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_descripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_motivo = New System.Windows.Forms.TextBox()
        Me.TextBox_quien_Reporta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_empleado = New System.Windows.Forms.ComboBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_clean = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btn_Registros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(475, 0)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(531, 0)
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
        Me.Label2.Location = New System.Drawing.Point(202, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 15)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Reportes a Empleados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(93, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Registros)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker_fecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_motivo)
        Me.GroupBox1.Controls.Add(Me.TextBox_quien_Reporta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ComboBox_empleado)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(562, 327)
        Me.GroupBox1.TabIndex = 121
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reportes a Empleados"
        '
        'btn_Registros
        '
        Me.btn_Registros.Image = Global.NucleosAve.My.Resources.Resources.icons8_google_web_search_512
        Me.btn_Registros.Location = New System.Drawing.Point(532, 0)
        Me.btn_Registros.Name = "btn_Registros"
        Me.btn_Registros.Size = New System.Drawing.Size(30, 27)
        Me.btn_Registros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Registros.TabIndex = 11
        Me.btn_Registros.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Fecha"
        '
        'DateTimePicker_fecha
        '
        Me.DateTimePicker_fecha.Location = New System.Drawing.Point(34, 135)
        Me.DateTimePicker_fecha.Name = "DateTimePicker_fecha"
        Me.DateTimePicker_fecha.Size = New System.Drawing.Size(224, 20)
        Me.DateTimePicker_fecha.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Descripcion"
        '
        'TextBox_descripcion
        '
        Me.TextBox_descripcion.Location = New System.Drawing.Point(34, 224)
        Me.TextBox_descripcion.Multiline = True
        Me.TextBox_descripcion.Name = "TextBox_descripcion"
        Me.TextBox_descripcion.Size = New System.Drawing.Size(499, 96)
        Me.TextBox_descripcion.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Motivo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quien Reporta"
        '
        'TextBox_motivo
        '
        Me.TextBox_motivo.Location = New System.Drawing.Point(34, 178)
        Me.TextBox_motivo.Name = "TextBox_motivo"
        Me.TextBox_motivo.Size = New System.Drawing.Size(315, 20)
        Me.TextBox_motivo.TabIndex = 3
        '
        'TextBox_quien_Reporta
        '
        Me.TextBox_quien_Reporta.Location = New System.Drawing.Point(34, 91)
        Me.TextBox_quien_Reporta.Name = "TextBox_quien_Reporta"
        Me.TextBox_quien_Reporta.Size = New System.Drawing.Size(315, 20)
        Me.TextBox_quien_Reporta.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Empleado"
        '
        'ComboBox_empleado
        '
        Me.ComboBox_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_empleado.FormattingEnabled = True
        Me.ComboBox_empleado.Location = New System.Drawing.Point(34, 47)
        Me.ComboBox_empleado.Name = "ComboBox_empleado"
        Me.ComboBox_empleado.Size = New System.Drawing.Size(315, 21)
        Me.ComboBox_empleado.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel10.Controls.Add(Me.btn_modificar)
        Me.Panel10.Controls.Add(Me.btn_clean)
        Me.Panel10.Controls.Add(Me.BtnGuardar)
        Me.Panel10.Location = New System.Drawing.Point(76, 423)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(425, 52)
        Me.Panel10.TabIndex = 198
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_modificar.Location = New System.Drawing.Point(285, 9)
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
        Me.btn_clean.Location = New System.Drawing.Point(142, 9)
        Me.btn_clean.Name = "btn_clean"
        Me.btn_clean.Size = New System.Drawing.Size(137, 32)
        Me.btn_clean.TabIndex = 186
        Me.btn_clean.Text = "Limpiar"
        Me.btn_clean.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(13, 9)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(123, 32)
        Me.BtnGuardar.TabIndex = 185
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'TextBox_id
        '
        Me.TextBox_id.Location = New System.Drawing.Point(389, 58)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_id.TabIndex = 199
        Me.TextBox_id.Visible = False
        '
        'Reportes_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(586, 482)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Reportes_Empleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes_Empleado"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btn_Registros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_motivo As TextBox
    Friend WithEvents TextBox_quien_Reporta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_empleado As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker_fecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_descripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_clean As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents btn_Registros As PictureBox
    Friend WithEvents TextBox_id As TextBox
End Class
