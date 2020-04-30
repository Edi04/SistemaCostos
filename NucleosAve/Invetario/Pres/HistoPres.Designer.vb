<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoPres
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
        Me.PLinea = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.DatosPM = New System.Windows.Forms.DataGridView()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.BMinimizar = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Numero_Nomina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Prestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Con_Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResponsableI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Con_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLinea
        '
        Me.PLinea.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PLinea.BackColor = System.Drawing.Color.SteelBlue
        Me.PLinea.Location = New System.Drawing.Point(71, 54)
        Me.PLinea.Name = "PLinea"
        Me.PLinea.Size = New System.Drawing.Size(466, 11)
        Me.PLinea.TabIndex = 78
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(148, 71)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(190, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Historial de Prestamos"
        '
        'DatosPM
        '
        Me.DatosPM.AllowUserToAddRows = False
        Me.DatosPM.AllowUserToDeleteRows = False
        Me.DatosPM.BackgroundColor = System.Drawing.Color.SteelBlue
        Me.DatosPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Numero_Nomina, Me.NombreE, Me.NombreP, Me.Cantidad, Me.Fecha_Prestamo, Me.Descripcion, Me.Con_Salida, Me.ResponsableS, Me.Ingreso, Me.ResponsableI, Me.Con_Ingreso})
        Me.DatosPM.Location = New System.Drawing.Point(5, 172)
        Me.DatosPM.Name = "DatosPM"
        Me.DatosPM.ReadOnly = True
        Me.DatosPM.Size = New System.Drawing.Size(601, 367)
        Me.DatosPM.TabIndex = 2
        '
        'GBusqueda
        '
        Me.GBusqueda.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.GBusqueda.Controls.Add(Me.LEspecific)
        Me.GBusqueda.Controls.Add(Me.PBusqueda)
        Me.GBusqueda.Controls.Add(Me.TxtBusqueda)
        Me.GBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBusqueda.ForeColor = System.Drawing.Color.Black
        Me.GBusqueda.Location = New System.Drawing.Point(71, 101)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(454, 65)
        Me.GBusqueda.TabIndex = 1
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(85, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(220, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Nombre o Código de Producto, Núm. Nómina"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(403, 9)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(51, 54)
        Me.PBusqueda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBusqueda.TabIndex = 26
        Me.PBusqueda.TabStop = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.BackColor = System.Drawing.Color.Gainsboro
        Me.TxtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(22, 26)
        Me.TxtBusqueda.Multiline = True
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(375, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(556, 1)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 0
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(505, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 0
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_Prestamo"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 35
        '
        'Numero_Nomina
        '
        Me.Numero_Nomina.DataPropertyName = "Numero_Nomina"
        Me.Numero_Nomina.HeaderText = "Núm. Nómina"
        Me.Numero_Nomina.Name = "Numero_Nomina"
        Me.Numero_Nomina.ReadOnly = True
        Me.Numero_Nomina.Width = 80
        '
        'NombreE
        '
        Me.NombreE.DataPropertyName = "Nombre"
        Me.NombreE.HeaderText = "Trabajador"
        Me.NombreE.Name = "NombreE"
        Me.NombreE.ReadOnly = True
        Me.NombreE.Width = 150
        '
        'NombreP
        '
        Me.NombreP.DataPropertyName = "Nombre_Producto"
        Me.NombreP.HeaderText = "Material"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.ReadOnly = True
        Me.NombreP.Width = 150
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'Fecha_Prestamo
        '
        Me.Fecha_Prestamo.DataPropertyName = "Fecha_Prestamo"
        Me.Fecha_Prestamo.HeaderText = "Fecha Prestamo"
        Me.Fecha_Prestamo.Name = "Fecha_Prestamo"
        Me.Fecha_Prestamo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Con_Salida
        '
        Me.Con_Salida.DataPropertyName = "Con_Salida"
        Me.Con_Salida.HeaderText = "Con. Salida"
        Me.Con_Salida.Name = "Con_Salida"
        Me.Con_Salida.ReadOnly = True
        '
        'ResponsableS
        '
        Me.ResponsableS.DataPropertyName = "ResponsableS"
        Me.ResponsableS.HeaderText = "ResponsableS"
        Me.ResponsableS.Name = "ResponsableS"
        Me.ResponsableS.ReadOnly = True
        '
        'Ingreso
        '
        Me.Ingreso.DataPropertyName = "Ingreso"
        Me.Ingreso.HeaderText = "Ingreso"
        Me.Ingreso.Name = "Ingreso"
        Me.Ingreso.ReadOnly = True
        '
        'ResponsableI
        '
        Me.ResponsableI.DataPropertyName = "ResponsableI"
        Me.ResponsableI.HeaderText = "ResponsableI"
        Me.ResponsableI.Name = "ResponsableI"
        Me.ResponsableI.ReadOnly = True
        '
        'Con_Ingreso
        '
        Me.Con_Ingreso.DataPropertyName = "Con_Ingreso"
        Me.Con_Ingreso.HeaderText = "Con. Ingreso"
        Me.Con_Ingreso.Name = "Con_Ingreso"
        Me.Con_Ingreso.ReadOnly = True
        '
        'HistoPres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(608, 544)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.DatosPM)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LTitulo)
        Me.Controls.Add(Me.PLinea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HistoPres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HistoPres"
        CType(Me.DatosPM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PLinea As Panel
    Friend WithEvents LTitulo As Label
    Friend WithEvents DatosPM As DataGridView
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents BCerrar As Button
    Friend WithEvents BMinimizar As Button
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents Numero_Nomina As DataGridViewTextBoxColumn
    Friend WithEvents NombreE As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Prestamo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Con_Salida As DataGridViewTextBoxColumn
    Friend WithEvents ResponsableS As DataGridViewTextBoxColumn
    Friend WithEvents Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents ResponsableI As DataGridViewTextBoxColumn
    Friend WithEvents Con_Ingreso As DataGridViewTextBoxColumn
End Class
