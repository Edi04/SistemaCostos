<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InicioSesion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InicioSesion))
        Me.BMinimizar = New System.Windows.Forms.PictureBox()
        Me.BCerrar = New System.Windows.Forms.PictureBox()
        Me.PLogo = New System.Windows.Forms.PictureBox()
        Me.PLogin = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.CUsuarios = New System.Windows.Forms.ComboBox()
        Me.LPassword = New System.Windows.Forms.Label()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.BInicioSesion = New System.Windows.Forms.Button()
        Me.CProceso = New System.Windows.Forms.ComboBox()
        Me.LV = New System.Windows.Forms.Label()
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BMinimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.Location = New System.Drawing.Point(446, 0)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(53, 52)
        Me.BMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BMinimizar.TabIndex = 108
        Me.BMinimizar.TabStop = False
        '
        'BCerrar
        '
        Me.BCerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.BCerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.Location = New System.Drawing.Point(500, 0)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(55, 52)
        Me.BCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BCerrar.TabIndex = 107
        Me.BCerrar.TabStop = False
        '
        'PLogo
        '
        Me.PLogo.Image = Global.NucleosAve.My.Resources.Resources.Logo_Nucleos1
        Me.PLogo.Location = New System.Drawing.Point(12, 338)
        Me.PLogo.Name = "PLogo"
        Me.PLogo.Size = New System.Drawing.Size(105, 102)
        Me.PLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PLogo.TabIndex = 109
        Me.PLogo.TabStop = False
        '
        'PLogin
        '
        Me.PLogin.BackColor = System.Drawing.Color.White
        Me.PLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PLogin.Controls.Add(Me.PictureBox1)
        Me.PLogin.Controls.Add(Me.LUsuario)
        Me.PLogin.Controls.Add(Me.CUsuarios)
        Me.PLogin.Controls.Add(Me.LPassword)
        Me.PLogin.Controls.Add(Me.LProceso)
        Me.PLogin.Controls.Add(Me.TxtContrasena)
        Me.PLogin.Controls.Add(Me.BInicioSesion)
        Me.PLogin.Controls.Add(Me.CProceso)
        Me.PLogin.Location = New System.Drawing.Point(144, 69)
        Me.PLogin.Name = "PLogin"
        Me.PLogin.Size = New System.Drawing.Size(293, 280)
        Me.PLogin.TabIndex = 110
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NucleosAve.My.Resources.Resources.Icono_Usuario1
        Me.PictureBox1.Location = New System.Drawing.Point(110, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 76)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LUsuario.Location = New System.Drawing.Point(20, 149)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(50, 13)
        Me.LUsuario.TabIndex = 0
        Me.LUsuario.Text = "Usuario"
        '
        'CUsuarios
        '
        Me.CUsuarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CUsuarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CUsuarios.DropDownWidth = 194
        Me.CUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CUsuarios.ForeColor = System.Drawing.Color.Gray
        Me.CUsuarios.FormattingEnabled = True
        Me.CUsuarios.Location = New System.Drawing.Point(76, 146)
        Me.CUsuarios.Name = "CUsuarios"
        Me.CUsuarios.Size = New System.Drawing.Size(194, 21)
        Me.CUsuarios.TabIndex = 2
        '
        'LPassword
        '
        Me.LPassword.AutoSize = True
        Me.LPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LPassword.Location = New System.Drawing.Point(9, 176)
        Me.LPassword.Name = "LPassword"
        Me.LPassword.Size = New System.Drawing.Size(61, 13)
        Me.LPassword.TabIndex = 0
        Me.LPassword.Text = "Password"
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.LProceso.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LProceso.Location = New System.Drawing.Point(17, 122)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(53, 13)
        Me.LProceso.TabIndex = 0
        Me.LProceso.Text = "Proceso"
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.ForeColor = System.Drawing.Color.Gray
        Me.TxtContrasena.Location = New System.Drawing.Point(76, 173)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContrasena.Size = New System.Drawing.Size(194, 29)
        Me.TxtContrasena.TabIndex = 3
        Me.TxtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BInicioSesion
        '
        Me.BInicioSesion.BackColor = System.Drawing.Color.Tan
        Me.BInicioSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.BInicioSesion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BInicioSesion.Location = New System.Drawing.Point(0, 240)
        Me.BInicioSesion.Name = "BInicioSesion"
        Me.BInicioSesion.Size = New System.Drawing.Size(292, 40)
        Me.BInicioSesion.TabIndex = 4
        Me.BInicioSesion.Text = "Iniciar Sesión"
        Me.BInicioSesion.UseVisualStyleBackColor = False
        '
        'CProceso
        '
        Me.CProceso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CProceso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CProceso.DropDownWidth = 194
        Me.CProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CProceso.ForeColor = System.Drawing.Color.Gray
        Me.CProceso.FormattingEnabled = True
        Me.CProceso.Location = New System.Drawing.Point(76, 119)
        Me.CProceso.Name = "CProceso"
        Me.CProceso.Size = New System.Drawing.Size(194, 21)
        Me.CProceso.TabIndex = 1
        '
        'LV
        '
        Me.LV.AutoSize = True
        Me.LV.Location = New System.Drawing.Point(459, 358)
        Me.LV.Name = "LV"
        Me.LV.Size = New System.Drawing.Size(0, 13)
        Me.LV.TabIndex = 111
        Me.LV.Visible = False
        '
        'InicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(555, 452)
        Me.Controls.Add(Me.LV)
        Me.Controls.Add(Me.PLogin)
        Me.Controls.Add(Me.PLogo)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "InicioSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        CType(Me.BMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PLogin.ResumeLayout(False)
        Me.PLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As PictureBox
    Friend WithEvents BCerrar As PictureBox
    Friend WithEvents PLogo As PictureBox
    Friend WithEvents PLogin As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LUsuario As Label
    Friend WithEvents CUsuarios As ComboBox
    Friend WithEvents LPassword As Label
    Friend WithEvents LProceso As Label
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents BInicioSesion As Button
    Friend WithEvents CProceso As ComboBox
    Friend WithEvents LV As Label
End Class
