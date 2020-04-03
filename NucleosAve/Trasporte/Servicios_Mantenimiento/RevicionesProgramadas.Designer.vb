<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RevicionesProgramadas
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
        Me.DataGridView_Reviciones = New System.Windows.Forms.DataGridView()
        Me.Btn_Realizada = New System.Windows.Forms.Button()
        Me.daterango2 = New System.Windows.Forms.DateTimePicker()
        Me.daterango1 = New System.Windows.Forms.DateTimePicker()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.TextBox_Realizado = New System.Windows.Forms.TextBox()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView_Reviciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(691, 1)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 112
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(747, 1)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 111
        Me.btn_Cerrar.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(300, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 15)
        Me.Label2.TabIndex = 114
        Me.Label2.Text = "Reviciones Programadas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(214, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 15)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "CORTE DE NUCLEOS Y MAQUILADOS AVE, S.A. DE C.V."
        '
        'DataGridView_Reviciones
        '
        Me.DataGridView_Reviciones.AllowUserToAddRows = False
        Me.DataGridView_Reviciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Reviciones.Location = New System.Drawing.Point(25, 128)
        Me.DataGridView_Reviciones.Name = "DataGridView_Reviciones"
        Me.DataGridView_Reviciones.ReadOnly = True
        Me.DataGridView_Reviciones.Size = New System.Drawing.Size(587, 262)
        Me.DataGridView_Reviciones.TabIndex = 115
        '
        'Btn_Realizada
        '
        Me.Btn_Realizada.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Btn_Realizada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Realizada.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Realizada.Location = New System.Drawing.Point(626, 220)
        Me.Btn_Realizada.Name = "Btn_Realizada"
        Me.Btn_Realizada.Size = New System.Drawing.Size(170, 39)
        Me.Btn_Realizada.TabIndex = 194
        Me.Btn_Realizada.Text = "Realizada"
        Me.Btn_Realizada.UseVisualStyleBackColor = False
        '
        'daterango2
        '
        Me.daterango2.Location = New System.Drawing.Point(314, 85)
        Me.daterango2.Name = "daterango2"
        Me.daterango2.Size = New System.Drawing.Size(212, 20)
        Me.daterango2.TabIndex = 195
        '
        'daterango1
        '
        Me.daterango1.Location = New System.Drawing.Point(80, 85)
        Me.daterango1.Name = "daterango1"
        Me.daterango1.Size = New System.Drawing.Size(212, 20)
        Me.daterango1.TabIndex = 196
        '
        'btn_buscar
        '
        Me.btn_buscar.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_buscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_buscar.Location = New System.Drawing.Point(541, 81)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(86, 30)
        Me.btn_buscar.TabIndex = 197
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = False
        '
        'TextBox_Realizado
        '
        Me.TextBox_Realizado.Location = New System.Drawing.Point(661, 265)
        Me.TextBox_Realizado.Name = "TextBox_Realizado"
        Me.TextBox_Realizado.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Realizado.TabIndex = 198
        Me.TextBox_Realizado.Visible = False
        '
        'RevicionesProgramadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(808, 450)
        Me.Controls.Add(Me.TextBox_Realizado)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.daterango1)
        Me.Controls.Add(Me.daterango2)
        Me.Controls.Add(Me.Btn_Realizada)
        Me.Controls.Add(Me.DataGridView_Reviciones)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RevicionesProgramadas"
        Me.Text = "RevicionesProgramadas"
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView_Reviciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView_Reviciones As DataGridView
    Friend WithEvents Btn_Realizada As Button
    Friend WithEvents daterango2 As DateTimePicker
    Friend WithEvents daterango1 As DateTimePicker
    Friend WithEvents btn_buscar As Button
    Friend WithEvents TextBox_Realizado As TextBox
End Class
