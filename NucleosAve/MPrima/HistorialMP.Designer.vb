<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialMP
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
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.POpc = New System.Windows.Forms.Panel()
        Me.LCS = New System.Windows.Forms.Label()
        Me.DVMP = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumRollo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Calibre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ancho = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Peso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaLlegada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtBOC = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BBOC1 = New System.Windows.Forms.Button()
        Me.DTF2 = New System.Windows.Forms.DateTimePicker()
        Me.DTF1 = New System.Windows.Forms.DateTimePicker()
        Me.LBOD = New System.Windows.Forms.Label()
        Me.LBOC = New System.Windows.Forms.Label()
        Me.POpc.SuspendLayout()
        CType(Me.DVMP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(792, 0)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 4
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(848, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 5
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Controls.Add(Me.LCS)
        Me.POpc.Location = New System.Drawing.Point(-2, 53)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(920, 10)
        Me.POpc.TabIndex = 6
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(225, 0)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 60
        Me.LCS.Visible = False
        '
        'DVMP
        '
        Me.DVMP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DVMP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NumRollo, Me.Calibre, Me.Ancho, Me.Peso, Me.Observaciones, Me.OCompra, Me.FechaLlegada, Me.Proveedor})
        Me.DVMP.Location = New System.Drawing.Point(22, 247)
        Me.DVMP.Name = "DVMP"
        Me.DVMP.Size = New System.Drawing.Size(849, 301)
        Me.DVMP.TabIndex = 7
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_MPrim"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Width = 50
        '
        'NumRollo
        '
        Me.NumRollo.DataPropertyName = "Num_Interno"
        Me.NumRollo.HeaderText = "Número de Rollo"
        Me.NumRollo.Name = "NumRollo"
        '
        'Calibre
        '
        Me.Calibre.DataPropertyName = "Calibre"
        Me.Calibre.HeaderText = "Calibre"
        Me.Calibre.Name = "Calibre"
        '
        'Ancho
        '
        Me.Ancho.DataPropertyName = "Ancho"
        Me.Ancho.HeaderText = "Ancho"
        Me.Ancho.Name = "Ancho"
        '
        'Peso
        '
        Me.Peso.DataPropertyName = "Peso"
        Me.Peso.HeaderText = "Peso (KG)"
        Me.Peso.Name = "Peso"
        '
        'Observaciones
        '
        Me.Observaciones.DataPropertyName = "Descripcion"
        Me.Observaciones.HeaderText = "Observaciones"
        Me.Observaciones.Name = "Observaciones"
        Me.Observaciones.Width = 200
        '
        'OCompra
        '
        Me.OCompra.DataPropertyName = "OCompra"
        Me.OCompra.HeaderText = "Orden de Compra"
        Me.OCompra.Name = "OCompra"
        '
        'FechaLlegada
        '
        Me.FechaLlegada.DataPropertyName = "Fecha_Llegada"
        Me.FechaLlegada.HeaderText = "Fecha de Llegada"
        Me.FechaLlegada.Name = "FechaLlegada"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'TxtBOC
        '
        Me.TxtBOC.Location = New System.Drawing.Point(628, 90)
        Me.TxtBOC.Name = "TxtBOC"
        Me.TxtBOC.Size = New System.Drawing.Size(104, 20)
        Me.TxtBOC.TabIndex = 74
        Me.TxtBOC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BBOC1)
        Me.GroupBox1.Controls.Add(Me.DTF2)
        Me.GroupBox1.Controls.Add(Me.DTF1)
        Me.GroupBox1.Location = New System.Drawing.Point(179, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 138)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda por Fecha"
        '
        'BBOC1
        '
        Me.BBOC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.BBOC1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BBOC1.Location = New System.Drawing.Point(180, 75)
        Me.BBOC1.Name = "BBOC1"
        Me.BBOC1.Size = New System.Drawing.Size(75, 23)
        Me.BBOC1.TabIndex = 72
        Me.BBOC1.Text = "Buscar"
        Me.BBOC1.UseVisualStyleBackColor = False
        '
        'DTF2
        '
        Me.DTF2.Location = New System.Drawing.Point(220, 43)
        Me.DTF2.Name = "DTF2"
        Me.DTF2.Size = New System.Drawing.Size(200, 20)
        Me.DTF2.TabIndex = 71
        '
        'DTF1
        '
        Me.DTF1.Location = New System.Drawing.Point(7, 43)
        Me.DTF1.Name = "DTF1"
        Me.DTF1.Size = New System.Drawing.Size(200, 20)
        Me.DTF1.TabIndex = 70
        '
        'LBOD
        '
        Me.LBOD.AutoSize = True
        Me.LBOD.BackColor = System.Drawing.Color.Transparent
        Me.LBOD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBOD.Location = New System.Drawing.Point(624, 69)
        Me.LBOD.Name = "LBOD"
        Me.LBOD.Size = New System.Drawing.Size(115, 16)
        Me.LBOD.TabIndex = 75
        Me.LBOD.Text = "Orden de Compra"
        '
        'LBOC
        '
        Me.LBOC.AutoSize = True
        Me.LBOC.BackColor = System.Drawing.Color.Transparent
        Me.LBOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBOC.Location = New System.Drawing.Point(285, 16)
        Me.LBOC.Name = "LBOC"
        Me.LBOC.Size = New System.Drawing.Size(233, 24)
        Me.LBOC.TabIndex = 76
        Me.LBOC.Text = "Materia Prima En Almacen"
        '
        'HistorialMP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(898, 560)
        Me.Controls.Add(Me.LBOC)
        Me.Controls.Add(Me.TxtBOC)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBOD)
        Me.Controls.Add(Me.DVMP)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.POpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistorialMP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HistorialMP"
        Me.POpc.ResumeLayout(False)
        Me.POpc.PerformLayout()
        CType(Me.DVMP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents POpc As Panel
    Friend WithEvents LCS As Label
    Friend WithEvents DVMP As DataGridView
    Friend WithEvents TxtBOC As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BBOC1 As Button
    Friend WithEvents DTF2 As DateTimePicker
    Friend WithEvents DTF1 As DateTimePicker
    Friend WithEvents LBOD As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NumRollo As DataGridViewTextBoxColumn
    Friend WithEvents Calibre As DataGridViewTextBoxColumn
    Friend WithEvents Ancho As DataGridViewTextBoxColumn
    Friend WithEvents Peso As DataGridViewTextBoxColumn
    Friend WithEvents Observaciones As DataGridViewTextBoxColumn
    Friend WithEvents OCompra As DataGridViewTextBoxColumn
    Friend WithEvents FechaLlegada As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents LBOC As Label
End Class
