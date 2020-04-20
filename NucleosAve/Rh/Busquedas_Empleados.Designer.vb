<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Busquedas_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Busquedas_Empleados))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_empleados = New System.Windows.Forms.DataGridView()
        Me.DateTime_rango1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTime_rango2 = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.PictureBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_empleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(865, -2)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(921, -2)
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
        Me.Label2.Location = New System.Drawing.Point(435, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 15)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Registros Empleados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(312, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DataGridView_empleados
        '
        Me.DataGridView_empleados.AllowUserToAddRows = False
        Me.DataGridView_empleados.AllowUserToDeleteRows = False
        Me.DataGridView_empleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_empleados.Location = New System.Drawing.Point(12, 140)
        Me.DataGridView_empleados.Name = "DataGridView_empleados"
        Me.DataGridView_empleados.ReadOnly = True
        Me.DataGridView_empleados.Size = New System.Drawing.Size(953, 298)
        Me.DataGridView_empleados.TabIndex = 121
        '
        'DateTime_rango1
        '
        Me.DateTime_rango1.Location = New System.Drawing.Point(194, 72)
        Me.DateTime_rango1.Name = "DateTime_rango1"
        Me.DateTime_rango1.Size = New System.Drawing.Size(246, 20)
        Me.DateTime_rango1.TabIndex = 122
        '
        'DateTime_rango2
        '
        Me.DateTime_rango2.Location = New System.Drawing.Point(500, 72)
        Me.DateTime_rango2.Name = "DateTime_rango2"
        Me.DateTime_rango2.Size = New System.Drawing.Size(246, 20)
        Me.DateTime_rango2.TabIndex = 123
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(396, 99)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(152, 34)
        Me.btnBuscar.TabIndex = 184
        Me.btnBuscar.Text = "Buscar Registros"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Image = Global.NucleosAve.My.Resources.Resources.icons8_basura_100
        Me.btn_eliminar.Location = New System.Drawing.Point(921, 99)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(44, 38)
        Me.btn_eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminar.TabIndex = 185
        Me.btn_eliminar.TabStop = False
        '
        'Busquedas_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(977, 450)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DateTime_rango2)
        Me.Controls.Add(Me.DateTime_rango1)
        Me.Controls.Add(Me.DataGridView_empleados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Busquedas_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busquedas_Empleados"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_empleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_empleados As DataGridView
    Friend WithEvents DateTime_rango1 As DateTimePicker
    Friend WithEvents DateTime_rango2 As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btn_eliminar As PictureBox
End Class
