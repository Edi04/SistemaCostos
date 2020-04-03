<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReporteOrd
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteOrd))
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.reporteOrdC = New NucleosAve.reporteOrdC()
        Me.SP38_Combo_ReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.combito = New NucleosAve.combito()
        Me.TB_Ordenes_DetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.traerproductos = New NucleosAve.traerproductos()
        Me.SP38_REPORTES_ORDCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SISUT020DataSet2 = New NucleosAve.SISUT020DataSet2()
        Me.SP38_REPORTES_ORDCTableAdapter = New NucleosAve.SISUT020DataSet2TableAdapters.SP38_REPORTES_ORDCTableAdapter()
        Me.BTN_BUSCAR = New System.Windows.Forms.Button()
        Me.Textbuscar = New System.Windows.Forms.TextBox()
        Me.SP38_Combo_ReportesTableAdapter = New NucleosAve.combitoTableAdapters.SP38_Combo_ReportesTableAdapter()
        Me.DataTable1TableAdapter = New NucleosAve.reporteOrdCTableAdapters.DataTable1TableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TB_Ordenes_DetalleTableAdapter = New NucleosAve.traerproductosTableAdapters.TB_Ordenes_DetalleTableAdapter()
        Me.btn_minimizar = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnview = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrarPrograma = New System.Windows.Forms.PictureBox()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reporteOrdC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP38_Combo_ReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.combito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_Ordenes_DetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.traerproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP38_REPORTES_ORDCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SISUT020DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarPrograma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.reporteOrdC
        '
        'reporteOrdC
        '
        Me.reporteOrdC.DataSetName = "reporteOrdC"
        Me.reporteOrdC.EnforceConstraints = False
        Me.reporteOrdC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP38_Combo_ReportesBindingSource
        '
        Me.SP38_Combo_ReportesBindingSource.DataMember = "SP38_Combo_Reportes"
        Me.SP38_Combo_ReportesBindingSource.DataSource = Me.combito
        '
        'combito
        '
        Me.combito.DataSetName = "combito"
        Me.combito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TB_Ordenes_DetalleBindingSource
        '
        Me.TB_Ordenes_DetalleBindingSource.DataMember = "TB_Ordenes_Detalle"
        Me.TB_Ordenes_DetalleBindingSource.DataSource = Me.traerproductos
        '
        'traerproductos
        '
        Me.traerproductos.DataSetName = "traerproductos"
        Me.traerproductos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP38_REPORTES_ORDCBindingSource
        '
        Me.SP38_REPORTES_ORDCBindingSource.DataMember = "SP38_REPORTES_ORDC"
        Me.SP38_REPORTES_ORDCBindingSource.DataSource = Me.SISUT020DataSet2
        '
        'SISUT020DataSet2
        '
        Me.SISUT020DataSet2.DataSetName = "SISUT020DataSet2"
        Me.SISUT020DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP38_REPORTES_ORDCTableAdapter
        '
        Me.SP38_REPORTES_ORDCTableAdapter.ClearBeforeFill = True
        '
        'BTN_BUSCAR
        '
        Me.BTN_BUSCAR.BackColor = System.Drawing.Color.RoyalBlue
        Me.BTN_BUSCAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_BUSCAR.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BTN_BUSCAR.Location = New System.Drawing.Point(180, 23)
        Me.BTN_BUSCAR.Name = "BTN_BUSCAR"
        Me.BTN_BUSCAR.Size = New System.Drawing.Size(132, 33)
        Me.BTN_BUSCAR.TabIndex = 1
        Me.BTN_BUSCAR.Text = "Generar Reporte"
        Me.BTN_BUSCAR.UseVisualStyleBackColor = False
        '
        'Textbuscar
        '
        Me.Textbuscar.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Textbuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Textbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.75!)
        Me.Textbuscar.Location = New System.Drawing.Point(16, 25)
        Me.Textbuscar.Name = "Textbuscar"
        Me.Textbuscar.Size = New System.Drawing.Size(159, 30)
        Me.Textbuscar.TabIndex = 2
        '
        'SP38_Combo_ReportesTableAdapter
        '
        Me.SP38_Combo_ReportesTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ReportesOrdCompra"
        ReportDataSource1.Value = Me.DataTable1BindingSource
        ReportDataSource2.Name = "combo_reportes"
        ReportDataSource2.Value = Me.SP38_Combo_ReportesBindingSource
        ReportDataSource3.Name = "reportes_productos"
        ReportDataSource3.Value = Me.TB_Ordenes_DetalleBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NucleosAve.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 75)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(795, 356)
        Me.ReportViewer1.TabIndex = 3
        '
        'TB_Ordenes_DetalleTableAdapter
        '
        Me.TB_Ordenes_DetalleTableAdapter.ClearBeforeFill = True
        '
        'btn_minimizar
        '
        Me.btn_minimizar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_minimizar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_minimizar.BackColor = System.Drawing.Color.Transparent
        Me.btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_minimizar.Image = Global.NucleosAve.My.Resources.Resources.icons8_minimizar_la_ventana_5001
        Me.btn_minimizar.Location = New System.Drawing.Point(712, 0)
        Me.btn_minimizar.Name = "btn_minimizar"
        Me.btn_minimizar.Size = New System.Drawing.Size(53, 52)
        Me.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_minimizar.TabIndex = 106
        Me.btn_minimizar.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.AccessibleDescription = "dfghdfgdfhdhfd"
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Cerrar.Image = Global.NucleosAve.My.Resources.Resources.icons8_cerrar_ventana_5001
        Me.btn_Cerrar.Location = New System.Drawing.Point(771, 0)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(55, 52)
        Me.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Cerrar.TabIndex = 105
        Me.btn_Cerrar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(13, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Ejemplo : OC-00001/20"
        '
        'btnview
        '
        Me.btnview.Image = CType(resources.GetObject("btnview.Image"), System.Drawing.Image)
        Me.btnview.Location = New System.Drawing.Point(335, 26)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(31, 30)
        Me.btnview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnview.TabIndex = 108
        Me.btnview.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(316, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Buscar Orden"
        '
        'btnCerrarPrograma
        '
        Me.btnCerrarPrograma.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrarPrograma.Image = Global.NucleosAve.My.Resources.Resources.icons8_shutdown_50_2
        Me.btnCerrarPrograma.Location = New System.Drawing.Point(636, 20)
        Me.btnCerrarPrograma.Name = "btnCerrarPrograma"
        Me.btnCerrarPrograma.Size = New System.Drawing.Size(36, 32)
        Me.btnCerrarPrograma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarPrograma.TabIndex = 119
        Me.btnCerrarPrograma.TabStop = False
        '
        'ReporteOrd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(826, 443)
        Me.Controls.Add(Me.btnCerrarPrograma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_minimizar)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Textbuscar)
        Me.Controls.Add(Me.BTN_BUSCAR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteOrd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ReporteOrd"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reporteOrdC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP38_Combo_ReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.combito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_Ordenes_DetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.traerproductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP38_REPORTES_ORDCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SISUT020DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarPrograma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SP38_REPORTES_ORDCBindingSource As BindingSource
    Friend WithEvents SISUT020DataSet2 As SISUT020DataSet2
    Friend WithEvents SP38_REPORTES_ORDCTableAdapter As SISUT020DataSet2TableAdapters.SP38_REPORTES_ORDCTableAdapter
    Friend WithEvents BTN_BUSCAR As Button
    Friend WithEvents Textbuscar As TextBox
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents reporteOrdC As reporteOrdC
    Friend WithEvents SP38_Combo_ReportesBindingSource As BindingSource
    Friend WithEvents combito As combito
    Friend WithEvents DataTable1TableAdapter As reporteOrdCTableAdapters.DataTable1TableAdapter
    Friend WithEvents SP38_Combo_ReportesTableAdapter As combitoTableAdapters.SP38_Combo_ReportesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TB_Ordenes_DetalleBindingSource As BindingSource
    Friend WithEvents traerproductos As traerproductos
    Friend WithEvents TB_Ordenes_DetalleTableAdapter As traerproductosTableAdapters.TB_Ordenes_DetalleTableAdapter
    Friend WithEvents btn_minimizar As PictureBox
    Friend WithEvents btn_Cerrar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnview As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCerrarPrograma As PictureBox
End Class
