<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ETickets
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
        Me.DatosDG = New System.Windows.Forms.DataGridView()
        Me.IDD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LResponsable = New System.Windows.Forms.Label()
        Me.PLogo = New System.Windows.Forms.PictureBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.LLinea2 = New System.Windows.Forms.Label()
        Me.LLinea1 = New System.Windows.Forms.Label()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.LLinea = New System.Windows.Forms.Label()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LTrabajador = New System.Windows.Forms.Label()
        Me.LTrabajado = New System.Windows.Forms.Label()
        Me.Impresion = New System.Windows.Forms.Button()
        Me.LCS = New System.Windows.Forms.Label()
        CType(Me.DatosDG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosDG
        '
        Me.DatosDG.BackgroundColor = System.Drawing.Color.White
        Me.DatosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDD, Me.Producto, Me.Cantidad})
        Me.DatosDG.Location = New System.Drawing.Point(-41, 117)
        Me.DatosDG.Name = "DatosDG"
        Me.DatosDG.ReadOnly = True
        Me.DatosDG.Size = New System.Drawing.Size(252, 420)
        Me.DatosDG.TabIndex = 1
        '
        'IDD
        '
        Me.IDD.HeaderText = ""
        Me.IDD.MaxInputLength = 25
        Me.IDD.MinimumWidth = 10
        Me.IDD.Name = "IDD"
        Me.IDD.ReadOnly = True
        Me.IDD.Width = 28
        '
        'Producto
        '
        Me.Producto.HeaderText = ""
        Me.Producto.MaxInputLength = 25
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 130
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = ""
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 50
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(28, 52)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(37, 16)
        Me.LFecha.TabIndex = 0
        Me.LFecha.Text = "Fecha:"
        '
        'LResponsable
        '
        Me.LResponsable.AutoSize = True
        Me.LResponsable.BackColor = System.Drawing.Color.Transparent
        Me.LResponsable.Location = New System.Drawing.Point(5, 559)
        Me.LResponsable.Name = "LResponsable"
        Me.LResponsable.Size = New System.Drawing.Size(127, 13)
        Me.LResponsable.TabIndex = 0
        Me.LResponsable.Text = "Responsable de Entrega:"
        '
        'PLogo
        '
        Me.PLogo.BackColor = System.Drawing.Color.Transparent
        Me.PLogo.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PLogo.Location = New System.Drawing.Point(178, 2)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(45, 50)
        Me.PLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PLogo.TabIndex = 71
        Me.PLogo.TabStop = False
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.Color.Transparent
        Me.ID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(3, 88)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(19, 16)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'LLinea2
        '
        Me.LLinea2.AutoSize = True
        Me.LLinea2.BackColor = System.Drawing.Color.Transparent
        Me.LLinea2.Location = New System.Drawing.Point(18, 543)
        Me.LLinea2.Name = "LLinea2"
        Me.LLinea2.Size = New System.Drawing.Size(205, 13)
        Me.LLinea2.TabIndex = 0
        Me.LLinea2.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "
        '
        'LLinea1
        '
        Me.LLinea1.AutoSize = True
        Me.LLinea1.BackColor = System.Drawing.Color.Transparent
        Me.LLinea1.Location = New System.Drawing.Point(15, 101)
        Me.LLinea1.Name = "LLinea1"
        Me.LLinea1.Size = New System.Drawing.Size(205, 13)
        Me.LLinea1.TabIndex = 0
        Me.LLinea1.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.BackColor = System.Drawing.Color.Transparent
        Me.LProducto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.Location = New System.Drawing.Point(45, 87)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(50, 16)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Producto"
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.Location = New System.Drawing.Point(159, 90)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LCantidad.TabIndex = 0
        Me.LCantidad.Text = "Cantidad"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.Transparent
        Me.Fecha.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(71, 52)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(34, 16)
        Me.Fecha.TabIndex = 0
        Me.Fecha.Text = "Fecha"
        '
        'LLinea
        '
        Me.LLinea.AutoSize = True
        Me.LLinea.BackColor = System.Drawing.Color.Transparent
        Me.LLinea.Location = New System.Drawing.Point(13, 60)
        Me.LLinea.Name = "LLinea"
        Me.LLinea.Size = New System.Drawing.Size(205, 13)
        Me.LLinea.TabIndex = 0
        Me.LLinea.Text = "_________________________________"
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(20, 12)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(137, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Entrega de Producto"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LUsuario.Location = New System.Drawing.Point(18, 578)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Usuario"
        '
        'LTrabajador
        '
        Me.LTrabajador.AutoSize = True
        Me.LTrabajador.BackColor = System.Drawing.Color.Transparent
        Me.LTrabajador.Location = New System.Drawing.Point(18, 625)
        Me.LTrabajador.Name = "LTrabajador"
        Me.LTrabajador.Size = New System.Drawing.Size(0, 13)
        Me.LTrabajador.TabIndex = 0
        '
        'LTrabajado
        '
        Me.LTrabajado.AutoSize = True
        Me.LTrabajado.BackColor = System.Drawing.Color.Transparent
        Me.LTrabajado.Location = New System.Drawing.Point(5, 603)
        Me.LTrabajado.Name = "LTrabajado"
        Me.LTrabajado.Size = New System.Drawing.Size(58, 13)
        Me.LTrabajado.TabIndex = 0
        Me.LTrabajado.Text = "Trabajador"
        '
        'Impresion
        '
        Me.Impresion.BackColor = System.Drawing.Color.Transparent
        Me.Impresion.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_imprimir_481
        Me.Impresion.Location = New System.Drawing.Point(163, 588)
        Me.Impresion.Name = "Impresion"
        Me.Impresion.Size = New System.Drawing.Size(48, 50)
        Me.Impresion.TabIndex = 2
        Me.Impresion.UseVisualStyleBackColor = False
        '
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.Location = New System.Drawing.Point(92, 54)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 13)
        Me.LCS.TabIndex = 72
        Me.LCS.Visible = False
        '
        'ETickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(231, 663)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.Impresion)
        Me.Controls.Add(Me.LTrabajador)
        Me.Controls.Add(Me.LTrabajado)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.DatosDG)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LResponsable)
        Me.Controls.Add(Me.PLogo)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.LLinea2)
        Me.Controls.Add(Me.LLinea1)
        Me.Controls.Add(Me.LProducto)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.LLinea)
        Me.Controls.Add(Me.LTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ETickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ETickets"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.DatosDG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatosDG As DataGridView
    Friend WithEvents IDD As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents LFecha As Label
    Friend WithEvents LResponsable As Label
    Friend WithEvents PLogo As PictureBox
    Friend WithEvents ID As Label
    Friend WithEvents LLinea2 As Label
    Friend WithEvents LLinea1 As Label
    Friend WithEvents LProducto As Label
    Friend WithEvents LCantidad As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents LLinea As Label
    Friend WithEvents LTitulo As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents LTrabajador As Label
    Friend WithEvents LTrabajado As Label
    Friend WithEvents Impresion As Button
    Friend WithEvents LCS As Label
End Class
