<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NMMarca
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
        Me.LMedida = New System.Windows.Forms.Label()
        Me.LNombre = New System.Windows.Forms.Label()
        Me.LClaveP = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.LArea = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.PictureBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LMedida
        '
        Me.LMedida.AutoSize = True
        Me.LMedida.Location = New System.Drawing.Point(157, 127)
        Me.LMedida.Name = "LMedida"
        Me.LMedida.Size = New System.Drawing.Size(0, 13)
        Me.LMedida.TabIndex = 138
        Me.LMedida.Visible = False
        '
        'LNombre
        '
        Me.LNombre.AutoSize = True
        Me.LNombre.Location = New System.Drawing.Point(157, 108)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(0, 13)
        Me.LNombre.TabIndex = 137
        Me.LNombre.Visible = False
        '
        'LClaveP
        '
        Me.LClaveP.AutoSize = True
        Me.LClaveP.Location = New System.Drawing.Point(154, 91)
        Me.LClaveP.Name = "LClaveP"
        Me.LClaveP.Size = New System.Drawing.Size(0, 13)
        Me.LClaveP.TabIndex = 136
        Me.LClaveP.Visible = False
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.Location = New System.Drawing.Point(154, 78)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(0, 13)
        Me.LCategoria.TabIndex = 135
        Me.LCategoria.Visible = False
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.Location = New System.Drawing.Point(154, 62)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(0, 13)
        Me.LProceso.TabIndex = 134
        Me.LProceso.Visible = False
        '
        'LArea
        '
        Me.LArea.AutoSize = True
        Me.LArea.Location = New System.Drawing.Point(154, 45)
        Me.LArea.Name = "LArea"
        Me.LArea.Size = New System.Drawing.Size(0, 13)
        Me.LArea.TabIndex = 133
        Me.LArea.Visible = False
        '
        'BGuardar
        '
        Me.BGuardar.Image = Global.NucleosAve.My.Resources.Resources.file_1411
        Me.BGuardar.Location = New System.Drawing.Point(66, 102)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(42, 36)
        Me.BGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BGuardar.TabIndex = 132
        Me.BGuardar.TabStop = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(21, 75)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(134, 20)
        Me.TxtMarca.TabIndex = 131
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.BackColor = System.Drawing.Color.Transparent
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.Location = New System.Drawing.Point(34, 49)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(111, 16)
        Me.LMarca.TabIndex = 130
        Me.LMarca.Text = "Agregar Marca"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(-2, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 10)
        Me.Panel2.TabIndex = 129
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(133, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(34, 31)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 128
        Me.BCerrar.TabStop = False
        '
        'NMMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(167, 145)
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
        Me.Name = "NMMarca"
        Me.Text = "NMMarca"
        CType(Me.BGuardar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LMedida As Label
    Friend WithEvents LNombre As Label
    Friend WithEvents LClaveP As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents LArea As Label
    Friend WithEvents BGuardar As PictureBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents LMarca As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCerrar As PictureBox
End Class
