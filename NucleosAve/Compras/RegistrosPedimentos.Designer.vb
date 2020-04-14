<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrosPedimentos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrosPedimentos))
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.DataGridRegistrosPedimentos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textBuscar = New System.Windows.Forms.TextBox()
        Me.btn_BuscarOc = New System.Windows.Forms.PictureBox()
        Me.btn_eliminnar = New System.Windows.Forms.PictureBox()
        Me.codigo_eliminar = New System.Windows.Forms.TextBox()
        Me.TextBox_id = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridRegistrosPedimentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_BuscarOc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_eliminnar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(685, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 108
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(744, 1)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 107
        Me.btn_Cerrar.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(105, 92)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 179
        Me.PictureBox2.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Cornsilk
        Me.btnBuscar.Location = New System.Drawing.Point(286, 121)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(279, 33)
        Me.btnBuscar.TabIndex = 182
        Me.btnBuscar.Text = "Buscar Pedimentos"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'DataGridRegistrosPedimentos
        '
        Me.DataGridRegistrosPedimentos.AllowUserToAddRows = False
        Me.DataGridRegistrosPedimentos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridRegistrosPedimentos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridRegistrosPedimentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridRegistrosPedimentos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.DataGridRegistrosPedimentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridRegistrosPedimentos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistrosPedimentos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridRegistrosPedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DeepSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridRegistrosPedimentos.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridRegistrosPedimentos.GridColor = System.Drawing.Color.Maroon
        Me.DataGridRegistrosPedimentos.Location = New System.Drawing.Point(12, 170)
        Me.DataGridRegistrosPedimentos.Name = "DataGridRegistrosPedimentos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridRegistrosPedimentos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridRegistrosPedimentos.Size = New System.Drawing.Size(776, 268)
        Me.DataGridRegistrosPedimentos.TabIndex = 183
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(200, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 16)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(331, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 16)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "Registros Pedimentos"
        '
        'textBuscar
        '
        Me.textBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.textBuscar.Location = New System.Drawing.Point(326, 75)
        Me.textBuscar.Name = "textBuscar"
        Me.textBuscar.Size = New System.Drawing.Size(172, 23)
        Me.textBuscar.TabIndex = 186
        '
        'btn_BuscarOc
        '
        Me.btn_BuscarOc.BackColor = System.Drawing.Color.Transparent
        Me.btn_BuscarOc.Image = Global.NucleosAve.My.Resources.Resources.icons8_google_web_search_512
        Me.btn_BuscarOc.Location = New System.Drawing.Point(504, 74)
        Me.btn_BuscarOc.Name = "btn_BuscarOc"
        Me.btn_BuscarOc.Size = New System.Drawing.Size(28, 26)
        Me.btn_BuscarOc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_BuscarOc.TabIndex = 191
        Me.btn_BuscarOc.TabStop = False
        '
        'btn_eliminnar
        '
        Me.btn_eliminnar.BackColor = System.Drawing.Color.Transparent
        Me.btn_eliminnar.Image = Global.NucleosAve.My.Resources.Resources.icons8_basura_100
        Me.btn_eliminnar.Location = New System.Drawing.Point(749, 127)
        Me.btn_eliminnar.Name = "btn_eliminnar"
        Me.btn_eliminnar.Size = New System.Drawing.Size(39, 37)
        Me.btn_eliminnar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_eliminnar.TabIndex = 192
        Me.btn_eliminnar.TabStop = False
        '
        'codigo_eliminar
        '
        Me.codigo_eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.codigo_eliminar.Location = New System.Drawing.Point(571, 131)
        Me.codigo_eliminar.Name = "codigo_eliminar"
        Me.codigo_eliminar.Size = New System.Drawing.Size(172, 23)
        Me.codigo_eliminar.TabIndex = 193
        Me.codigo_eliminar.Visible = False
        '
        'TextBox_id
        '
        Me.TextBox_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.TextBox_id.Location = New System.Drawing.Point(393, 131)
        Me.TextBox_id.Name = "TextBox_id"
        Me.TextBox_id.Size = New System.Drawing.Size(172, 23)
        Me.TextBox_id.TabIndex = 194
        Me.TextBox_id.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 195
        Me.Label3.Text = "Ejemplo : OC-000/20"
        '
        'RegistrosPedimentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.TextBox_id)
        Me.Controls.Add(Me.codigo_eliminar)
        Me.Controls.Add(Me.btn_eliminnar)
        Me.Controls.Add(Me.btn_BuscarOc)
        Me.Controls.Add(Me.textBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridRegistrosPedimentos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistrosPedimentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "r"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridRegistrosPedimentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_BuscarOc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_eliminnar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridRegistrosPedimentos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents textBuscar As TextBox
    Friend WithEvents btn_BuscarOc As PictureBox
    Friend WithEvents btn_eliminnar As PictureBox
    Friend WithEvents codigo_eliminar As TextBox
    Friend WithEvents TextBox_id As TextBox
    Friend WithEvents Label3 As Label
End Class
