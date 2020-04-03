<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tickets
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
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.LLinea = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LLinea1 = New System.Windows.Forms.Label()
        Me.LLinea2 = New System.Windows.Forms.Label()
        Me.Impresion = New System.Windows.Forms.PictureBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.PLogo = New System.Windows.Forms.PictureBox()
        Me.LResponsable = New System.Windows.Forms.Label()
        Me.LProveedor = New System.Windows.Forms.Label()
        Me.CProveedor = New System.Windows.Forms.ComboBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.DatosDG = New System.Windows.Forms.DataGridView()
        Me.IDD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LCS = New System.Windows.Forms.Label()
        CType(Me.Impresion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.AutoSize = True
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.Location = New System.Drawing.Point(52, 9)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(137, 20)
        Me.LTitulo.TabIndex = 0
        Me.LTitulo.Text = "Entrada de Producto"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.Location = New System.Drawing.Point(43, 49)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(37, 16)
        Me.LFecha.TabIndex = 0
        Me.LFecha.Text = "Fecha:"
        '
        'LLinea
        '
        Me.LLinea.AutoSize = True
        Me.LLinea.BackColor = System.Drawing.Color.Transparent
        Me.LLinea.Location = New System.Drawing.Point(28, 57)
        Me.LLinea.Name = "LLinea"
        Me.LLinea.Size = New System.Drawing.Size(205, 13)
        Me.LLinea.TabIndex = 0
        Me.LLinea.Text = "_________________________________"
        '
        'Fecha
        '
        Me.Fecha.AutoSize = True
        Me.Fecha.BackColor = System.Drawing.Color.Transparent
        Me.Fecha.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(86, 49)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(34, 16)
        Me.Fecha.TabIndex = 0
        Me.Fecha.Text = "Fecha"
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.Location = New System.Drawing.Point(184, 87)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LCantidad.TabIndex = 0
        Me.LCantidad.Text = "Cantidad"
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.BackColor = System.Drawing.Color.Transparent
        Me.LProducto.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProducto.Location = New System.Drawing.Point(70, 84)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(50, 16)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Producto"
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LUsuario.Location = New System.Drawing.Point(22, 573)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(43, 13)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Usuario"
        '
        'LLinea1
        '
        Me.LLinea1.AutoSize = True
        Me.LLinea1.BackColor = System.Drawing.Color.Transparent
        Me.LLinea1.Location = New System.Drawing.Point(28, 98)
        Me.LLinea1.Name = "LLinea1"
        Me.LLinea1.Size = New System.Drawing.Size(205, 13)
        Me.LLinea1.TabIndex = 7
        Me.LLinea1.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "
        '
        'LLinea2
        '
        Me.LLinea2.AutoSize = True
        Me.LLinea2.BackColor = System.Drawing.Color.Transparent
        Me.LLinea2.Location = New System.Drawing.Point(11, 540)
        Me.LLinea2.Name = "LLinea2"
        Me.LLinea2.Size = New System.Drawing.Size(205, 13)
        Me.LLinea2.TabIndex = 8
        Me.LLinea2.Text = "_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ "
        '
        'Impresion
        '
        Me.Impresion.BackColor = System.Drawing.Color.Transparent
        Me.Impresion.Image = Global.NucleosAve.My.Resources.Resources.icons8_imprimir_481
        Me.Impresion.Location = New System.Drawing.Point(188, 614)
        Me.Impresion.Name = "Impresion"
        Me.Impresion.Size = New System.Drawing.Size(45, 50)
        Me.Impresion.TabIndex = 9
        Me.Impresion.TabStop = False
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.BackColor = System.Drawing.Color.Transparent
        Me.ID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(28, 85)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(19, 16)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'PLogo
        '
        Me.PLogo.BackColor = System.Drawing.Color.Transparent
        Me.PLogo.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PLogo.Location = New System.Drawing.Point(205, -1)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(45, 50)
        Me.PLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PLogo.TabIndex = 31
        Me.PLogo.TabStop = False
        '
        'LResponsable
        '
        Me.LResponsable.AutoSize = True
        Me.LResponsable.BackColor = System.Drawing.Color.Transparent
        Me.LResponsable.Location = New System.Drawing.Point(-2, 556)
        Me.LResponsable.Name = "LResponsable"
        Me.LResponsable.Size = New System.Drawing.Size(125, 13)
        Me.LResponsable.TabIndex = 0
        Me.LResponsable.Text = "Responsable de Ingreso:"
        '
        'LProveedor
        '
        Me.LProveedor.AutoSize = True
        Me.LProveedor.BackColor = System.Drawing.Color.Transparent
        Me.LProveedor.Location = New System.Drawing.Point(3, 598)
        Me.LProveedor.Name = "LProveedor"
        Me.LProveedor.Size = New System.Drawing.Size(59, 13)
        Me.LProveedor.TabIndex = 56
        Me.LProveedor.Text = "Proveedor:"
        '
        'CProveedor
        '
        Me.CProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CProveedor.FormattingEnabled = True
        Me.CProveedor.Location = New System.Drawing.Point(1, 614)
        Me.CProveedor.Name = "CProveedor"
        Me.CProveedor.Size = New System.Drawing.Size(181, 21)
        Me.CProveedor.TabIndex = 58
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(1, 614)
        Me.TxtProveedor.Multiline = True
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(181, 45)
        Me.TxtProveedor.TabIndex = 59
        Me.TxtProveedor.Visible = False
        '
        'DatosDG
        '
        Me.DatosDG.BackgroundColor = System.Drawing.Color.White
        Me.DatosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDD, Me.Producto, Me.Cantidad})
        Me.DatosDG.Location = New System.Drawing.Point(-19, 114)
        Me.DatosDG.Name = "DatosDG"
        Me.DatosDG.ReadOnly = True
        Me.DatosDG.Size = New System.Drawing.Size(252, 420)
        Me.DatosDG.TabIndex = 60
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
        'LCS
        '
        Me.LCS.AutoSize = True
        Me.LCS.BackColor = System.Drawing.Color.Transparent
        Me.LCS.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCS.Location = New System.Drawing.Point(9, 12)
        Me.LCS.Name = "LCS"
        Me.LCS.Size = New System.Drawing.Size(0, 16)
        Me.LCS.TabIndex = 61
        Me.LCS.Visible = False
        '
        'Tickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(251, 677)
        Me.Controls.Add(Me.LCS)
        Me.Controls.Add(Me.DatosDG)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.CProveedor)
        Me.Controls.Add(Me.LProveedor)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LResponsable)
        Me.Controls.Add(Me.PLogo)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Impresion)
        Me.Controls.Add(Me.LLinea2)
        Me.Controls.Add(Me.LLinea1)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.LProducto)
        Me.Controls.Add(Me.LCantidad)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.LLinea)
        Me.Controls.Add(Me.LTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tickets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tickets"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.Impresion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTitulo As Label
    Friend WithEvents LFecha As Label
    Friend WithEvents LLinea As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents LCantidad As Label
    Friend WithEvents LProducto As Label
    Friend WithEvents LUsuario As Label
    Friend WithEvents LLinea1 As Label
    Friend WithEvents LLinea2 As Label
    Friend WithEvents Impresion As PictureBox
    Friend WithEvents ID As Label
    Friend WithEvents PLogo As PictureBox
    Friend WithEvents LResponsable As Label
    Friend WithEvents LProveedor As Label
    Friend WithEvents CProveedor As ComboBox
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents DatosDG As DataGridView
    Friend WithEvents IDD As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents LCS As Label
End Class
