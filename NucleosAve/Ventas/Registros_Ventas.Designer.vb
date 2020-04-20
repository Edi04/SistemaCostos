<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registros_Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registros_Ventas))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView_registros = New System.Windows.Forms.DataGridView()
        Me.DateTime_Rango1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_rago2 = New System.Windows.Forms.DateTimePicker()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btn_trash = New System.Windows.Forms.PictureBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_registros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_trash, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btn_minimizar.TabIndex = 120
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
        Me.btn_Cerrar.TabIndex = 119
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(339, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 15)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Registros Ventas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(218, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DataGridView_registros
        '
        Me.DataGridView_registros.AllowUserToAddRows = False
        Me.DataGridView_registros.AllowUserToDeleteRows = False
        Me.DataGridView_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_registros.Location = New System.Drawing.Point(12, 140)
        Me.DataGridView_registros.Name = "DataGridView_registros"
        Me.DataGridView_registros.ReadOnly = True
        Me.DataGridView_registros.Size = New System.Drawing.Size(776, 298)
        Me.DataGridView_registros.TabIndex = 123
        '
        'DateTime_Rango1
        '
        Me.DateTime_Rango1.Location = New System.Drawing.Point(70, 65)
        Me.DateTime_Rango1.Name = "DateTime_Rango1"
        Me.DateTime_Rango1.Size = New System.Drawing.Size(285, 20)
        Me.DateTime_Rango1.TabIndex = 124
        '
        'DateTimePicker_rago2
        '
        Me.DateTimePicker_rago2.Location = New System.Drawing.Point(434, 65)
        Me.DateTimePicker_rago2.Name = "DateTimePicker_rago2"
        Me.DateTimePicker_rago2.Size = New System.Drawing.Size(267, 20)
        Me.DateTimePicker_rago2.TabIndex = 125
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(330, 100)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(152, 34)
        Me.btnBuscar.TabIndex = 184
        Me.btnBuscar.Text = "Buscar Registros"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btn_trash
        '
        Me.btn_trash.BackColor = System.Drawing.Color.Transparent
        Me.btn_trash.Image = Global.NucleosAve.My.Resources.Resources.icons8_basura_100
        Me.btn_trash.Location = New System.Drawing.Point(730, 89)
        Me.btn_trash.Name = "btn_trash"
        Me.btn_trash.Size = New System.Drawing.Size(44, 45)
        Me.btn_trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_trash.TabIndex = 185
        Me.btn_trash.TabStop = False
        '
        'Registros_Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_trash)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DateTimePicker_rago2)
        Me.Controls.Add(Me.DateTime_Rango1)
        Me.Controls.Add(Me.DataGridView_registros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registros_Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registros_Ventas"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_registros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_trash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_registros As DataGridView
    Friend WithEvents DateTime_Rango1 As DateTimePicker
    Friend WithEvents DateTimePicker_rago2 As DateTimePicker
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btn_trash As PictureBox
End Class
