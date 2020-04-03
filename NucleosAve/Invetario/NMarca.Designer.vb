<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NMarca
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.BGuardar = New System.Windows.Forms.PictureBox()
        Me.LArea = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LClaveP = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LMedida = New System.Windows.Forms.Label()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(1, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(156, 10)
        Me.Panel2.TabIndex = 74
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(124, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 72
        Me.BCerrar.TabStop = False
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.BackColor = System.Drawing.Color.Transparent
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.Location = New System.Drawing.Point(26, 48)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(111, 16)
        Me.LMarca.TabIndex = 75
        Me.LMarca.Text = "Agregar Marca"
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(15, 77)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(134, 20)
        Me.TxtMarca.TabIndex = 76
        '
        'BGuardar
        '
        Me.BGuardar.Image = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardar.Location = New System.Drawing.Point(61, 103)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(42, 36)
        Me.BGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BGuardar.TabIndex = 77
        Me.BGuardar.TabStop = False
        '
        'LArea
        '
        Me.LArea.AutoSize = True
        Me.LArea.Location = New System.Drawing.Point(140, 44)
        Me.LArea.Name = "LArea"
        Me.LArea.Size = New System.Drawing.Size(0, 13)
        Me.LArea.TabIndex = 78
        Me.LArea.Visible = False
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.Location = New System.Drawing.Point(140, 61)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(0, 13)
        Me.LProceso.TabIndex = 79
        Me.LProceso.Visible = False
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(140, 77)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(0, 13)
        Me.LCategoria.TabIndex = 80
        Me.LCategoria.Visible = False
        '
        'LClaveP
        '
        Me.LClaveP.AutoSize = True
        Me.LClaveP.Location = New System.Drawing.Point(140, 90)
        Me.LClaveP.Name = "LClaveP"
        Me.LClaveP.Size = New System.Drawing.Size(0, 13)
        Me.LClaveP.TabIndex = 81
        Me.LClaveP.Visible = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(143, 107)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(0, 13)
        Me.LNombre.TabIndex = 82
        Me.LNombre.Visible = False
        '
        'LMedida
        '
        Me.LMedida.AutoSize = True
        Me.LMedida.Location = New System.Drawing.Point(143, 126)
        Me.LMedida.Name = "LMedida"
        Me.LMedida.Size = New System.Drawing.Size(0, 13)
        Me.LMedida.TabIndex = 83
        Me.LMedida.Visible = False
        '
        'NMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(158, 151)
        Me.Controls.Add(Me.LMedida)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.LClaveP)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.LProceso)
        Me.Controls.Add(Me.LArea)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.TxtMarca)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NMarca"
        Me.Text = "NMarca"
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents LMarca As Label
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents BGuardar As PictureBox
    Friend WithEvents LArea As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LClaveP As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LMedida As Label
End Class
