<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrosReportes
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_empleado = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridView_reportes_atencion = New System.Windows.Forms.DataGridView()
        Me.rango1 = New System.Windows.Forms.DateTimePicker()
        Me.rango2 = New System.Windows.Forms.DateTimePicker()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_reportes_atencion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(352, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(231, 15)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "Reportes o LLamadas de Atencion "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(269, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(738, 2)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 122
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(794, 2)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 121
        Me.btn_Cerrar.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(27, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Empleado"
        '
        'ComboBox_empleado
        '
        Me.ComboBox_empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_empleado.FormattingEnabled = True
        Me.ComboBox_empleado.Location = New System.Drawing.Point(30, 76)
        Me.ComboBox_empleado.Name = "ComboBox_empleado"
        Me.ComboBox_empleado.Size = New System.Drawing.Size(315, 21)
        Me.ComboBox_empleado.TabIndex = 125
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(368, 115)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(152, 34)
        Me.btnBuscar.TabIndex = 184
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DataGridView_reportes_atencion
        '
        Me.DataGridView_reportes_atencion.AllowUserToAddRows = False
        Me.DataGridView_reportes_atencion.AllowUserToDeleteRows = False
        Me.DataGridView_reportes_atencion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_reportes_atencion.Location = New System.Drawing.Point(12, 158)
        Me.DataGridView_reportes_atencion.Name = "DataGridView_reportes_atencion"
        Me.DataGridView_reportes_atencion.ReadOnly = True
        Me.DataGridView_reportes_atencion.Size = New System.Drawing.Size(823, 280)
        Me.DataGridView_reportes_atencion.TabIndex = 185
        '
        'rango1
        '
        Me.rango1.Location = New System.Drawing.Point(355, 77)
        Me.rango1.Name = "rango1"
        Me.rango1.Size = New System.Drawing.Size(200, 20)
        Me.rango1.TabIndex = 186
        '
        'rango2
        '
        Me.rango2.Location = New System.Drawing.Point(568, 77)
        Me.rango2.Name = "rango2"
        Me.rango2.Size = New System.Drawing.Size(200, 20)
        Me.rango2.TabIndex = 187
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Image = Global.NucleosAve.My.Resources.Resources.icons8_basura_100
        Me.btn_eliminar.Location = New System.Drawing.Point(794, 106)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(44, 43)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 188
        Me.btn_eliminar.TabStop = False
        '
        'RegistrosReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(850, 450)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.rango2)
        Me.Controls.Add(Me.rango1)
        Me.Controls.Add(Me.DataGridView_reportes_atencion)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox_empleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "RegistrosReportes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrosReportes"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_reportes_atencion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_empleado As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView_reportes_atencion As DataGridView
    Friend WithEvents rango1 As DateTimePicker
    Friend WithEvents rango2 As DateTimePicker
    Friend WithEvents btn_eliminar As PictureBox
End Class
