<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rastreo
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LOT = New System.Windows.Forms.Label()
        Me.DST = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.OT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trabajador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtOT = New System.Windows.Forms.TextBox()
        Me.LIFec = New System.Windows.Forms.Label()
        Me.TxtIH = New System.Windows.Forms.TextBox()
        Me.LIH = New System.Windows.Forms.Label()
        Me.LIT = New System.Windows.Forms.Label()
        Me.TxtIT = New System.Windows.Forms.TextBox()
        Me.LProceso = New System.Windows.Forms.Label()
        Me.GInicio = New System.Windows.Forms.GroupBox()
        Me.DTIF = New System.Windows.Forms.DateTimePicker()
        Me.LITr = New System.Windows.Forms.Label()
        Me.TxtITr = New System.Windows.Forms.TextBox()
        Me.BInicio = New System.Windows.Forms.Button()
        Me.CProceso = New System.Windows.Forms.ComboBox()
        Me.GPausar = New System.Windows.Forms.GroupBox()
        Me.DTPF = New System.Windows.Forms.DateTimePicker()
        Me.LPTr = New System.Windows.Forms.Label()
        Me.BPausar = New System.Windows.Forms.Button()
        Me.TxtPTr = New System.Windows.Forms.TextBox()
        Me.LPH = New System.Windows.Forms.Label()
        Me.LPT = New System.Windows.Forms.Label()
        Me.TxtPT = New System.Windows.Forms.TextBox()
        Me.LPF = New System.Windows.Forms.Label()
        Me.TxtPH = New System.Windows.Forms.TextBox()
        Me.GContinuar = New System.Windows.Forms.GroupBox()
        Me.DTCF = New System.Windows.Forms.DateTimePicker()
        Me.LCTr = New System.Windows.Forms.Label()
        Me.BContinuar = New System.Windows.Forms.Button()
        Me.TxtCTr = New System.Windows.Forms.TextBox()
        Me.FCH = New System.Windows.Forms.Label()
        Me.LCT = New System.Windows.Forms.Label()
        Me.TxtCT = New System.Windows.Forms.TextBox()
        Me.LCF = New System.Windows.Forms.Label()
        Me.TxtCH = New System.Windows.Forms.TextBox()
        Me.GFinalizar = New System.Windows.Forms.GroupBox()
        Me.DTFF = New System.Windows.Forms.DateTimePicker()
        Me.LFTr = New System.Windows.Forms.Label()
        Me.BFinalizar = New System.Windows.Forms.Button()
        Me.TxtFTr = New System.Windows.Forms.TextBox()
        Me.LFH = New System.Windows.Forms.Label()
        Me.LFT = New System.Windows.Forms.Label()
        Me.TxtFT = New System.Windows.Forms.TextBox()
        Me.LFF = New System.Windows.Forms.Label()
        Me.TxtFH = New System.Windows.Forms.TextBox()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.GBusqueda = New System.Windows.Forms.GroupBox()
        Me.LEspecific = New System.Windows.Forms.Label()
        Me.PBusqueda = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.LEstado = New System.Windows.Forms.Label()
        CType(Me.DST, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GInicio.SuspendLayout()
        Me.GPausar.SuspendLayout()
        Me.GContinuar.SuspendLayout()
        Me.GFinalizar.SuspendLayout()
        Me.GBusqueda.SuspendLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BMinimizar
        '
        Me.BMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.BMinimizar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.BMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BMinimizar.Location = New System.Drawing.Point(994, 1)
        Me.BMinimizar.Name = "BMinimizar"
        Me.BMinimizar.Size = New System.Drawing.Size(50, 50)
        Me.BMinimizar.TabIndex = 174
        Me.BMinimizar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.Color.Transparent
        Me.BCerrar.BackgroundImage = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.BCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BCerrar.Location = New System.Drawing.Point(1050, 1)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(50, 50)
        Me.BCerrar.TabIndex = 175
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'POpc
        '
        Me.POpc.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.POpc.BackColor = System.Drawing.Color.SteelBlue
        Me.POpc.Location = New System.Drawing.Point(79, 57)
        Me.POpc.Name = "POpc"
        Me.POpc.Size = New System.Drawing.Size(961, 10)
        Me.POpc.TabIndex = 173
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Seguimiento de Trabajo"
        '
        'LOT
        '
        Me.LOT.AutoSize = True
        Me.LOT.BackColor = System.Drawing.Color.Transparent
        Me.LOT.Location = New System.Drawing.Point(22, 29)
        Me.LOT.Name = "LOT"
        Me.LOT.Size = New System.Drawing.Size(90, 13)
        Me.LOT.TabIndex = 177
        Me.LOT.Text = "Orden de Trabajo"
        '
        'DST
        '
        Me.DST.AllowUserToAddRows = False
        Me.DST.AllowUserToDeleteRows = False
        Me.DST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DST.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.OT, Me.Estado, Me.FechaInicio, Me.Hora, Me.Turno, Me.Trabajador})
        Me.DST.Location = New System.Drawing.Point(635, 163)
        Me.DST.Name = "DST"
        Me.DST.ReadOnly = True
        Me.DST.Size = New System.Drawing.Size(447, 383)
        Me.DST.TabIndex = 178
        '
        'ID
        '
        Me.ID.DataPropertyName = "Id_SPlan"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ID.Width = 50
        '
        'OT
        '
        Me.OT.DataPropertyName = "OrdenTrabajo"
        Me.OT.HeaderText = "Orden de Trabajo"
        Me.OT.Name = "OT"
        Me.OT.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'FechaInicio
        '
        Me.FechaInicio.DataPropertyName = "Fecha"
        Me.FechaInicio.HeaderText = "Fecha de Inicio"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = True
        Me.FechaInicio.Width = 150
        '
        'Hora
        '
        Me.Hora.DataPropertyName = "Hora"
        Me.Hora.HeaderText = "Hora"
        Me.Hora.Name = "Hora"
        Me.Hora.ReadOnly = True
        Me.Hora.Visible = False
        '
        'Turno
        '
        Me.Turno.DataPropertyName = "Turno"
        Me.Turno.HeaderText = "Turno"
        Me.Turno.Name = "Turno"
        Me.Turno.ReadOnly = True
        Me.Turno.Visible = False
        '
        'Trabajador
        '
        Me.Trabajador.DataPropertyName = "Responsable"
        Me.Trabajador.HeaderText = "Trabajador"
        Me.Trabajador.Name = "Trabajador"
        Me.Trabajador.ReadOnly = True
        Me.Trabajador.Visible = False
        '
        'TxtOT
        '
        Me.TxtOT.Location = New System.Drawing.Point(118, 26)
        Me.TxtOT.Name = "TxtOT"
        Me.TxtOT.Size = New System.Drawing.Size(165, 20)
        Me.TxtOT.TabIndex = 179
        '
        'LIFec
        '
        Me.LIFec.AutoSize = True
        Me.LIFec.BackColor = System.Drawing.Color.Transparent
        Me.LIFec.Location = New System.Drawing.Point(75, 57)
        Me.LIFec.Name = "LIFec"
        Me.LIFec.Size = New System.Drawing.Size(37, 13)
        Me.LIFec.TabIndex = 180
        Me.LIFec.Text = "Fecha"
        '
        'TxtIH
        '
        Me.TxtIH.Location = New System.Drawing.Point(118, 80)
        Me.TxtIH.Name = "TxtIH"
        Me.TxtIH.Size = New System.Drawing.Size(165, 20)
        Me.TxtIH.TabIndex = 182
        '
        'LIH
        '
        Me.LIH.AutoSize = True
        Me.LIH.BackColor = System.Drawing.Color.Transparent
        Me.LIH.Location = New System.Drawing.Point(81, 82)
        Me.LIH.Name = "LIH"
        Me.LIH.Size = New System.Drawing.Size(30, 13)
        Me.LIH.TabIndex = 183
        Me.LIH.Text = "Hora"
        '
        'LIT
        '
        Me.LIT.AutoSize = True
        Me.LIT.BackColor = System.Drawing.Color.Transparent
        Me.LIT.Location = New System.Drawing.Point(76, 109)
        Me.LIT.Name = "LIT"
        Me.LIT.Size = New System.Drawing.Size(35, 13)
        Me.LIT.TabIndex = 185
        Me.LIT.Text = "Turno"
        '
        'TxtIT
        '
        Me.TxtIT.Location = New System.Drawing.Point(118, 106)
        Me.TxtIT.Name = "TxtIT"
        Me.TxtIT.Size = New System.Drawing.Size(165, 20)
        Me.TxtIT.TabIndex = 184
        '
        'LProceso
        '
        Me.LProceso.AutoSize = True
        Me.LProceso.BackColor = System.Drawing.Color.Transparent
        Me.LProceso.Location = New System.Drawing.Point(111, 123)
        Me.LProceso.Name = "LProceso"
        Me.LProceso.Size = New System.Drawing.Size(46, 13)
        Me.LProceso.TabIndex = 186
        Me.LProceso.Text = "Proceso"
        '
        'GInicio
        '
        Me.GInicio.BackColor = System.Drawing.Color.Transparent
        Me.GInicio.Controls.Add(Me.DTIF)
        Me.GInicio.Controls.Add(Me.LITr)
        Me.GInicio.Controls.Add(Me.TxtITr)
        Me.GInicio.Controls.Add(Me.BInicio)
        Me.GInicio.Controls.Add(Me.LIH)
        Me.GInicio.Controls.Add(Me.LOT)
        Me.GInicio.Controls.Add(Me.TxtOT)
        Me.GInicio.Controls.Add(Me.LIT)
        Me.GInicio.Controls.Add(Me.TxtIT)
        Me.GInicio.Controls.Add(Me.LIFec)
        Me.GInicio.Controls.Add(Me.TxtIH)
        Me.GInicio.Location = New System.Drawing.Point(21, 147)
        Me.GInicio.Name = "GInicio"
        Me.GInicio.Size = New System.Drawing.Size(306, 188)
        Me.GInicio.TabIndex = 187
        Me.GInicio.TabStop = False
        Me.GInicio.Text = "Inicio"
        '
        'DTIF
        '
        Me.DTIF.Enabled = False
        Me.DTIF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTIF.Location = New System.Drawing.Point(118, 54)
        Me.DTIF.Name = "DTIF"
        Me.DTIF.Size = New System.Drawing.Size(165, 20)
        Me.DTIF.TabIndex = 192
        '
        'LITr
        '
        Me.LITr.AutoSize = True
        Me.LITr.BackColor = System.Drawing.Color.Transparent
        Me.LITr.Location = New System.Drawing.Point(56, 136)
        Me.LITr.Name = "LITr"
        Me.LITr.Size = New System.Drawing.Size(58, 13)
        Me.LITr.TabIndex = 188
        Me.LITr.Text = "Trabajador"
        '
        'TxtITr
        '
        Me.TxtITr.Location = New System.Drawing.Point(118, 132)
        Me.TxtITr.Name = "TxtITr"
        Me.TxtITr.Size = New System.Drawing.Size(165, 20)
        Me.TxtITr.TabIndex = 187
        '
        'BInicio
        '
        Me.BInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BInicio.Enabled = False
        Me.BInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BInicio.Location = New System.Drawing.Point(137, 158)
        Me.BInicio.Name = "BInicio"
        Me.BInicio.Size = New System.Drawing.Size(75, 23)
        Me.BInicio.TabIndex = 186
        Me.BInicio.Text = "Inicio"
        Me.BInicio.UseVisualStyleBackColor = False
        Me.BInicio.Visible = False
        '
        'CProceso
        '
        Me.CProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CProceso.FormattingEnabled = True
        Me.CProceso.Location = New System.Drawing.Point(165, 120)
        Me.CProceso.Name = "CProceso"
        Me.CProceso.Size = New System.Drawing.Size(165, 21)
        Me.CProceso.TabIndex = 188
        '
        'GPausar
        '
        Me.GPausar.BackColor = System.Drawing.Color.Transparent
        Me.GPausar.Controls.Add(Me.DTPF)
        Me.GPausar.Controls.Add(Me.LPTr)
        Me.GPausar.Controls.Add(Me.BPausar)
        Me.GPausar.Controls.Add(Me.TxtPTr)
        Me.GPausar.Controls.Add(Me.LPH)
        Me.GPausar.Controls.Add(Me.LPT)
        Me.GPausar.Controls.Add(Me.TxtPT)
        Me.GPausar.Controls.Add(Me.LPF)
        Me.GPausar.Controls.Add(Me.TxtPH)
        Me.GPausar.Location = New System.Drawing.Point(362, 169)
        Me.GPausar.Name = "GPausar"
        Me.GPausar.Size = New System.Drawing.Size(247, 166)
        Me.GPausar.TabIndex = 188
        Me.GPausar.TabStop = False
        Me.GPausar.Text = "Pausar"
        Me.GPausar.Visible = False
        '
        'DTPF
        '
        Me.DTPF.Enabled = False
        Me.DTPF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPF.Location = New System.Drawing.Point(70, 29)
        Me.DTPF.Name = "DTPF"
        Me.DTPF.Size = New System.Drawing.Size(165, 20)
        Me.DTPF.TabIndex = 193
        '
        'LPTr
        '
        Me.LPTr.AutoSize = True
        Me.LPTr.BackColor = System.Drawing.Color.Transparent
        Me.LPTr.Location = New System.Drawing.Point(7, 110)
        Me.LPTr.Name = "LPTr"
        Me.LPTr.Size = New System.Drawing.Size(58, 13)
        Me.LPTr.TabIndex = 190
        Me.LPTr.Text = "Trabajador"
        '
        'BPausar
        '
        Me.BPausar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BPausar.Location = New System.Drawing.Point(78, 139)
        Me.BPausar.Name = "BPausar"
        Me.BPausar.Size = New System.Drawing.Size(75, 23)
        Me.BPausar.TabIndex = 186
        Me.BPausar.Text = "Pausar"
        Me.BPausar.UseVisualStyleBackColor = False
        '
        'TxtPTr
        '
        Me.TxtPTr.Location = New System.Drawing.Point(69, 106)
        Me.TxtPTr.Name = "TxtPTr"
        Me.TxtPTr.Size = New System.Drawing.Size(165, 20)
        Me.TxtPTr.TabIndex = 189
        '
        'LPH
        '
        Me.LPH.AutoSize = True
        Me.LPH.BackColor = System.Drawing.Color.Transparent
        Me.LPH.Location = New System.Drawing.Point(33, 56)
        Me.LPH.Name = "LPH"
        Me.LPH.Size = New System.Drawing.Size(30, 13)
        Me.LPH.TabIndex = 183
        Me.LPH.Text = "Hora"
        '
        'LPT
        '
        Me.LPT.AutoSize = True
        Me.LPT.BackColor = System.Drawing.Color.Transparent
        Me.LPT.Location = New System.Drawing.Point(28, 84)
        Me.LPT.Name = "LPT"
        Me.LPT.Size = New System.Drawing.Size(35, 13)
        Me.LPT.TabIndex = 185
        Me.LPT.Text = "Turno"
        '
        'TxtPT
        '
        Me.TxtPT.Location = New System.Drawing.Point(70, 80)
        Me.TxtPT.Name = "TxtPT"
        Me.TxtPT.Size = New System.Drawing.Size(165, 20)
        Me.TxtPT.TabIndex = 184
        '
        'LPF
        '
        Me.LPF.AutoSize = True
        Me.LPF.BackColor = System.Drawing.Color.Transparent
        Me.LPF.Location = New System.Drawing.Point(27, 31)
        Me.LPF.Name = "LPF"
        Me.LPF.Size = New System.Drawing.Size(37, 13)
        Me.LPF.TabIndex = 180
        Me.LPF.Text = "Fecha"
        '
        'TxtPH
        '
        Me.TxtPH.Location = New System.Drawing.Point(70, 54)
        Me.TxtPH.Name = "TxtPH"
        Me.TxtPH.Size = New System.Drawing.Size(165, 20)
        Me.TxtPH.TabIndex = 182
        '
        'GContinuar
        '
        Me.GContinuar.BackColor = System.Drawing.Color.Transparent
        Me.GContinuar.Controls.Add(Me.DTCF)
        Me.GContinuar.Controls.Add(Me.LCTr)
        Me.GContinuar.Controls.Add(Me.BContinuar)
        Me.GContinuar.Controls.Add(Me.TxtCTr)
        Me.GContinuar.Controls.Add(Me.FCH)
        Me.GContinuar.Controls.Add(Me.LCT)
        Me.GContinuar.Controls.Add(Me.TxtCT)
        Me.GContinuar.Controls.Add(Me.LCF)
        Me.GContinuar.Controls.Add(Me.TxtCH)
        Me.GContinuar.Location = New System.Drawing.Point(28, 363)
        Me.GContinuar.Name = "GContinuar"
        Me.GContinuar.Size = New System.Drawing.Size(247, 166)
        Me.GContinuar.TabIndex = 191
        Me.GContinuar.TabStop = False
        Me.GContinuar.Text = "Continuar"
        Me.GContinuar.Visible = False
        '
        'DTCF
        '
        Me.DTCF.Enabled = False
        Me.DTCF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTCF.Location = New System.Drawing.Point(70, 28)
        Me.DTCF.Name = "DTCF"
        Me.DTCF.Size = New System.Drawing.Size(165, 20)
        Me.DTCF.TabIndex = 193
        '
        'LCTr
        '
        Me.LCTr.AutoSize = True
        Me.LCTr.BackColor = System.Drawing.Color.Transparent
        Me.LCTr.Location = New System.Drawing.Point(7, 110)
        Me.LCTr.Name = "LCTr"
        Me.LCTr.Size = New System.Drawing.Size(58, 13)
        Me.LCTr.TabIndex = 190
        Me.LCTr.Text = "Trabajador"
        '
        'BContinuar
        '
        Me.BContinuar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BContinuar.Location = New System.Drawing.Point(78, 139)
        Me.BContinuar.Name = "BContinuar"
        Me.BContinuar.Size = New System.Drawing.Size(75, 23)
        Me.BContinuar.TabIndex = 186
        Me.BContinuar.Text = "Continuar"
        Me.BContinuar.UseVisualStyleBackColor = False
        '
        'TxtCTr
        '
        Me.TxtCTr.Location = New System.Drawing.Point(69, 106)
        Me.TxtCTr.Name = "TxtCTr"
        Me.TxtCTr.Size = New System.Drawing.Size(165, 20)
        Me.TxtCTr.TabIndex = 189
        '
        'FCH
        '
        Me.FCH.AutoSize = True
        Me.FCH.BackColor = System.Drawing.Color.Transparent
        Me.FCH.Location = New System.Drawing.Point(33, 56)
        Me.FCH.Name = "FCH"
        Me.FCH.Size = New System.Drawing.Size(30, 13)
        Me.FCH.TabIndex = 183
        Me.FCH.Text = "Hora"
        '
        'LCT
        '
        Me.LCT.AutoSize = True
        Me.LCT.BackColor = System.Drawing.Color.Transparent
        Me.LCT.Location = New System.Drawing.Point(28, 84)
        Me.LCT.Name = "LCT"
        Me.LCT.Size = New System.Drawing.Size(35, 13)
        Me.LCT.TabIndex = 185
        Me.LCT.Text = "Turno"
        '
        'TxtCT
        '
        Me.TxtCT.Location = New System.Drawing.Point(70, 80)
        Me.TxtCT.Name = "TxtCT"
        Me.TxtCT.Size = New System.Drawing.Size(165, 20)
        Me.TxtCT.TabIndex = 184
        '
        'LCF
        '
        Me.LCF.AutoSize = True
        Me.LCF.BackColor = System.Drawing.Color.Transparent
        Me.LCF.Location = New System.Drawing.Point(27, 31)
        Me.LCF.Name = "LCF"
        Me.LCF.Size = New System.Drawing.Size(37, 13)
        Me.LCF.TabIndex = 180
        Me.LCF.Text = "Fecha"
        '
        'TxtCH
        '
        Me.TxtCH.Location = New System.Drawing.Point(70, 54)
        Me.TxtCH.Name = "TxtCH"
        Me.TxtCH.Size = New System.Drawing.Size(165, 20)
        Me.TxtCH.TabIndex = 182
        '
        'GFinalizar
        '
        Me.GFinalizar.BackColor = System.Drawing.Color.Transparent
        Me.GFinalizar.Controls.Add(Me.DTFF)
        Me.GFinalizar.Controls.Add(Me.LFTr)
        Me.GFinalizar.Controls.Add(Me.BFinalizar)
        Me.GFinalizar.Controls.Add(Me.TxtFTr)
        Me.GFinalizar.Controls.Add(Me.LFH)
        Me.GFinalizar.Controls.Add(Me.LFT)
        Me.GFinalizar.Controls.Add(Me.TxtFT)
        Me.GFinalizar.Controls.Add(Me.LFF)
        Me.GFinalizar.Controls.Add(Me.TxtFH)
        Me.GFinalizar.Location = New System.Drawing.Point(335, 363)
        Me.GFinalizar.Name = "GFinalizar"
        Me.GFinalizar.Size = New System.Drawing.Size(259, 166)
        Me.GFinalizar.TabIndex = 191
        Me.GFinalizar.TabStop = False
        Me.GFinalizar.Text = "Finalizar"
        Me.GFinalizar.Visible = False
        '
        'DTFF
        '
        Me.DTFF.Enabled = False
        Me.DTFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFF.Location = New System.Drawing.Point(84, 24)
        Me.DTFF.Name = "DTFF"
        Me.DTFF.Size = New System.Drawing.Size(165, 20)
        Me.DTFF.TabIndex = 193
        '
        'LFTr
        '
        Me.LFTr.AutoSize = True
        Me.LFTr.BackColor = System.Drawing.Color.Transparent
        Me.LFTr.Location = New System.Drawing.Point(21, 103)
        Me.LFTr.Name = "LFTr"
        Me.LFTr.Size = New System.Drawing.Size(58, 13)
        Me.LFTr.TabIndex = 190
        Me.LFTr.Text = "Trabajador"
        '
        'BFinalizar
        '
        Me.BFinalizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFinalizar.Location = New System.Drawing.Point(92, 132)
        Me.BFinalizar.Name = "BFinalizar"
        Me.BFinalizar.Size = New System.Drawing.Size(75, 23)
        Me.BFinalizar.TabIndex = 186
        Me.BFinalizar.Text = "Finalizar"
        Me.BFinalizar.UseVisualStyleBackColor = False
        '
        'TxtFTr
        '
        Me.TxtFTr.Location = New System.Drawing.Point(83, 99)
        Me.TxtFTr.Name = "TxtFTr"
        Me.TxtFTr.Size = New System.Drawing.Size(165, 20)
        Me.TxtFTr.TabIndex = 189
        '
        'LFH
        '
        Me.LFH.AutoSize = True
        Me.LFH.BackColor = System.Drawing.Color.Transparent
        Me.LFH.Location = New System.Drawing.Point(47, 49)
        Me.LFH.Name = "LFH"
        Me.LFH.Size = New System.Drawing.Size(30, 13)
        Me.LFH.TabIndex = 183
        Me.LFH.Text = "Hora"
        '
        'LFT
        '
        Me.LFT.AutoSize = True
        Me.LFT.BackColor = System.Drawing.Color.Transparent
        Me.LFT.Location = New System.Drawing.Point(42, 77)
        Me.LFT.Name = "LFT"
        Me.LFT.Size = New System.Drawing.Size(35, 13)
        Me.LFT.TabIndex = 185
        Me.LFT.Text = "Turno"
        '
        'TxtFT
        '
        Me.TxtFT.Location = New System.Drawing.Point(84, 73)
        Me.TxtFT.Name = "TxtFT"
        Me.TxtFT.Size = New System.Drawing.Size(165, 20)
        Me.TxtFT.TabIndex = 184
        '
        'LFF
        '
        Me.LFF.AutoSize = True
        Me.LFF.BackColor = System.Drawing.Color.Transparent
        Me.LFF.Location = New System.Drawing.Point(41, 24)
        Me.LFF.Name = "LFF"
        Me.LFF.Size = New System.Drawing.Size(37, 13)
        Me.LFF.TabIndex = 180
        Me.LFF.Text = "Fecha"
        '
        'TxtFH
        '
        Me.TxtFH.Location = New System.Drawing.Point(84, 47)
        Me.TxtFH.Name = "TxtFH"
        Me.TxtFH.Size = New System.Drawing.Size(165, 20)
        Me.TxtFH.TabIndex = 182
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Location = New System.Drawing.Point(660, 100)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(0, 13)
        Me.LUsuario.TabIndex = 192
        Me.LUsuario.Visible = False
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
        Me.GBusqueda.Location = New System.Drawing.Point(701, 95)
        Me.GBusqueda.Name = "GBusqueda"
        Me.GBusqueda.Size = New System.Drawing.Size(339, 65)
        Me.GBusqueda.TabIndex = 193
        Me.GBusqueda.TabStop = False
        Me.GBusqueda.Text = "Búsqueda"
        '
        'LEspecific
        '
        Me.LEspecific.AutoSize = True
        Me.LEspecific.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEspecific.Location = New System.Drawing.Point(83, 9)
        Me.LEspecific.Name = "LEspecific"
        Me.LEspecific.Size = New System.Drawing.Size(129, 13)
        Me.LEspecific.TabIndex = 0
        Me.LEspecific.Text = "Orden de Trabajo, Estado"
        '
        'PBusqueda
        '
        Me.PBusqueda.Image = Global.NucleosAve.My.Resources.Resources.file_1911
        Me.PBusqueda.Location = New System.Drawing.Point(293, 12)
        Me.PBusqueda.Name = "PBusqueda"
        Me.PBusqueda.Size = New System.Drawing.Size(44, 46)
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
        Me.TxtBusqueda.Size = New System.Drawing.Size(256, 31)
        Me.TxtBusqueda.TabIndex = 1
        Me.TxtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtBusqueda.WordWrap = False
        '
        'LEstado
        '
        Me.LEstado.AutoSize = True
        Me.LEstado.Location = New System.Drawing.Point(669, 46)
        Me.LEstado.Name = "LEstado"
        Me.LEstado.Size = New System.Drawing.Size(0, 13)
        Me.LEstado.TabIndex = 194
        Me.LEstado.Visible = False
        '
        'Rastreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NucleosAve.My.Resources.Resources.Fondo
        Me.ClientSize = New System.Drawing.Size(1100, 553)
        Me.Controls.Add(Me.LEstado)
        Me.Controls.Add(Me.GContinuar)
        Me.Controls.Add(Me.GBusqueda)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.GFinalizar)
        Me.Controls.Add(Me.GPausar)
        Me.Controls.Add(Me.CProceso)
        Me.Controls.Add(Me.GInicio)
        Me.Controls.Add(Me.LProceso)
        Me.Controls.Add(Me.DST)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BMinimizar)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.POpc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rastreo"
        Me.Text = "Rastreo"
        CType(Me.DST, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GInicio.ResumeLayout(False)
        Me.GInicio.PerformLayout()
        Me.GPausar.ResumeLayout(False)
        Me.GPausar.PerformLayout()
        Me.GContinuar.ResumeLayout(False)
        Me.GContinuar.PerformLayout()
        Me.GFinalizar.ResumeLayout(False)
        Me.GFinalizar.PerformLayout()
        Me.GBusqueda.ResumeLayout(False)
        Me.GBusqueda.PerformLayout()
        CType(Me.PBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BMinimizar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents POpc As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LOT As Label
    Friend WithEvents DST As DataGridView
    Friend WithEvents TxtOT As TextBox
    Friend WithEvents LIFec As Label
    Friend WithEvents TxtIH As TextBox
    Friend WithEvents LIH As Label
    Friend WithEvents LIT As Label
    Friend WithEvents TxtIT As TextBox
    Friend WithEvents LProceso As Label
    Friend WithEvents GInicio As GroupBox
    Friend WithEvents CProceso As ComboBox
    Friend WithEvents LITr As Label
    Friend WithEvents TxtITr As TextBox
    Friend WithEvents BInicio As Button
    Friend WithEvents GPausar As GroupBox
    Friend WithEvents LPTr As Label
    Friend WithEvents BPausar As Button
    Friend WithEvents TxtPTr As TextBox
    Friend WithEvents LPH As Label
    Friend WithEvents LPT As Label
    Friend WithEvents TxtPT As TextBox
    Friend WithEvents LPF As Label
    Friend WithEvents TxtPH As TextBox
    Friend WithEvents GFinalizar As GroupBox
    Friend WithEvents LFTr As Label
    Friend WithEvents BFinalizar As Button
    Friend WithEvents TxtFTr As TextBox
    Friend WithEvents LFH As Label
    Friend WithEvents LFT As Label
    Friend WithEvents TxtFT As TextBox
    Friend WithEvents LFF As Label
    Friend WithEvents TxtFH As TextBox
    Friend WithEvents GContinuar As GroupBox
    Friend WithEvents LCTr As Label
    Friend WithEvents BContinuar As Button
    Friend WithEvents TxtCTr As TextBox
    Friend WithEvents FCH As Label
    Friend WithEvents LCT As Label
    Friend WithEvents TxtCT As TextBox
    Friend WithEvents LCF As Label
    Friend WithEvents TxtCH As TextBox
    Friend WithEvents DTIF As DateTimePicker
    Friend WithEvents LUsuario As Label
    Friend WithEvents GBusqueda As GroupBox
    Friend WithEvents LEspecific As Label
    Friend WithEvents PBusqueda As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents DTPF As DateTimePicker
    Friend WithEvents DTCF As DateTimePicker
    Friend WithEvents DTFF As DateTimePicker
    Friend WithEvents LEstado As Label
    Friend WithEvents ID As DataGridViewLinkColumn
    Friend WithEvents OT As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents Hora As DataGridViewTextBoxColumn
    Friend WithEvents Turno As DataGridViewTextBoxColumn
    Friend WithEvents Trabajador As DataGridViewTextBoxColumn
End Class
