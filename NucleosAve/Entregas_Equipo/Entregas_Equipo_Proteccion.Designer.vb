<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entregas_Equipo_Proteccion
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
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGrid_rntregas_equipo_proteccion = New System.Windows.Forms.DataGridView()
        Me.rango1 = New System.Windows.Forms.DateTimePicker()
        Me.rango2 = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid_rntregas_equipo_proteccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(689, 0)
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(745, 0)
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
        Me.Label2.Location = New System.Drawing.Point(270, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 15)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Entregas de Equipo de Proteccion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(211, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DataGrid_rntregas_equipo_proteccion
        '
        Me.DataGrid_rntregas_equipo_proteccion.AllowUserToAddRows = False
        Me.DataGrid_rntregas_equipo_proteccion.AllowUserToDeleteRows = False
        Me.DataGrid_rntregas_equipo_proteccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid_rntregas_equipo_proteccion.Location = New System.Drawing.Point(12, 164)
        Me.DataGrid_rntregas_equipo_proteccion.Name = "DataGrid_rntregas_equipo_proteccion"
        Me.DataGrid_rntregas_equipo_proteccion.ReadOnly = True
        Me.DataGrid_rntregas_equipo_proteccion.Size = New System.Drawing.Size(776, 274)
        Me.DataGrid_rntregas_equipo_proteccion.TabIndex = 121
        '
        'rango1
        '
        Me.rango1.Location = New System.Drawing.Point(194, 88)
        Me.rango1.Name = "rango1"
        Me.rango1.Size = New System.Drawing.Size(200, 20)
        Me.rango1.TabIndex = 122
        '
        'rango2
        '
        Me.rango2.Location = New System.Drawing.Point(415, 88)
        Me.rango2.Name = "rango2"
        Me.rango2.Size = New System.Drawing.Size(200, 20)
        Me.rango2.TabIndex = 123
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(328, 118)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(152, 34)
        Me.btnBuscar.TabIndex = 185
        Me.btnBuscar.Text = "Buscar Registros"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'Entregas_Equipo_Proteccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.rango2)
        Me.Controls.Add(Me.rango1)
        Me.Controls.Add(Me.DataGrid_rntregas_equipo_proteccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Entregas_Equipo_Proteccion"
        Me.Text = "Entregas_Equipo_Proteccion"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid_rntregas_equipo_proteccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGrid_rntregas_equipo_proteccion As DataGridView
    Friend WithEvents rango1 As DateTimePicker
    Friend WithEvents rango2 As DateTimePicker
    Friend WithEvents btnBuscar As Button
End Class
