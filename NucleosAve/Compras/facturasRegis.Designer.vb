<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturasRegis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturasRegis))
        Me.DataGridFacturas = New System.Windows.Forms.DataGridView()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DateTimeRango1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeRango2 = New System.Windows.Forms.DateTimePicker()
        Me.id_fac = New System.Windows.Forms.Label()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_tiposfactu = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridFacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridFacturas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridFacturas.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridFacturas.Location = New System.Drawing.Point(12, 114)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.Size = New System.Drawing.Size(882, 324)
        Me.DataGridFacturas.TabIndex = 0
        '
        'btn_Buscar
        '
        Me.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_Buscar.Location = New System.Drawing.Point(393, 72)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(204, 35)
        Me.btn_Buscar.TabIndex = 115
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.NucleosAve.My.Resources.Resources.icons8_basura_100
        Me.PictureBox1.Location = New System.Drawing.Point(57, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 185
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.NucleosAve.My.Resources.Resources.icons8_izquierda_64__1_
        Me.PictureBox2.Location = New System.Drawing.Point(12, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(39, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 186
        Me.PictureBox2.TabStop = False
        '
        'DateTimeRango1
        '
        Me.DateTimeRango1.Location = New System.Drawing.Point(169, 43)
        Me.DateTimeRango1.Name = "DateTimeRango1"
        Me.DateTimeRango1.Size = New System.Drawing.Size(219, 20)
        Me.DateTimeRango1.TabIndex = 187
        Me.DateTimeRango1.Value = New Date(2020, 1, 1, 0, 0, 0, 0)
        '
        'DateTimeRango2
        '
        Me.DateTimeRango2.Location = New System.Drawing.Point(403, 43)
        Me.DateTimeRango2.Name = "DateTimeRango2"
        Me.DateTimeRango2.Size = New System.Drawing.Size(214, 20)
        Me.DateTimeRango2.TabIndex = 188
        Me.DateTimeRango2.Value = New Date(2020, 2, 4, 16, 9, 5, 0)
        '
        'id_fac
        '
        Me.id_fac.AutoSize = True
        Me.id_fac.Location = New System.Drawing.Point(57, 64)
        Me.id_fac.Name = "id_fac"
        Me.id_fac.Size = New System.Drawing.Size(39, 13)
        Me.id_fac.TabIndex = 189
        Me.id_fac.Text = "Label1"
        Me.id_fac.Visible = False
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(793, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 191
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(848, 1)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 190
        Me.btn_Cerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(630, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 194
        Me.Label1.Text = "Tipo Factura"
        '
        'ComboBox_tiposfactu
        '
        Me.ComboBox_tiposfactu.FormattingEnabled = True
        Me.ComboBox_tiposfactu.Items.AddRange(New Object() {"Compra", "Venta"})
        Me.ComboBox_tiposfactu.Location = New System.Drawing.Point(633, 42)
        Me.ComboBox_tiposfactu.Name = "ComboBox_tiposfactu"
        Me.ComboBox_tiposfactu.Size = New System.Drawing.Size(140, 21)
        Me.ComboBox_tiposfactu.TabIndex = 193
        '
        'facturasRegis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(906, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox_tiposfactu)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.id_fac)
        Me.Controls.Add(Me.DateTimeRango1)
        Me.Controls.Add(Me.DateTimeRango2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.DataGridFacturas)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "facturasRegis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "facturasRegis"
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridFacturas As DataGridView
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DateTimeRango1 As DateTimePicker
    Friend WithEvents DateTimeRango2 As DateTimePicker
    Friend WithEvents id_fac As Label
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_tiposfactu As ComboBox
End Class
