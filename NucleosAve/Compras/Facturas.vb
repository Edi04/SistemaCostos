Imports System.Xml
Imports System.Data.SqlClient
Public Class factura
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    '-----------------------------Botonera minimizar y Cerrar-------------------------------
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '-----------------------------------------trmina botonera------------------------------
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    '---------------------------------coidigo para poder mover formulario------------------------------
    Private Sub Inicio_Od_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Inicio_Od_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub

    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    '-------------------<<<<<<<<<<Subir Archivo>>>>>>>>>>>>-------------------------


    Private Sub btn_SubirArchivo_Click(sender As Object, e As EventArgs) Handles btn_SubirArchivo.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            txt_direccion.Text = openFileDialog1.FileName()

        End If

        btn_leerXml.Enabled = True
        GenerarCodigo()

    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub productosfac()
        Dim ruta As String 'VARIABLE PARA DIRECCION DEL ARCHIVO<<<<--------------
        Dim Version_xml As String
        Dim implocaltraladados As Decimal
        Dim implocalretenidos As Decimal
        Dim retenidos As Decimal
        Dim trasladados As Decimal
        Dim Subtotal As String
        Dim valor_noIdentificacion As String
        Dim preciounitarioxml As Decimal
        Dim importeconcepto As Decimal
        Dim cantidadvendida As Decimal
        Dim subtotalclave As Decimal = 0
        Dim descripcionxml As String
        Dim Emisor_Nombre As String
        Dim version As String
        Dim folio As String
        Dim fecha As String
        Dim total As String
        Dim sello As String
        Dim formaPago As String
        Dim Ncertificado As String
        Dim certificado As String
        Dim condicionesPago As String
        Dim Moneda As String
        Dim tipodeCambio As String
        Dim UUID As String
        Dim tipoCambio As String
        Dim TipoComprobante As String
        Dim MetodoPago As String
        Dim LugarExpedicion As String
        Dim rfcEmi As String
        Dim nombreemi As String
        Dim regimenfiscal As String
        Dim rfcRecep As String
        Dim nombreRep As String
        Dim usoCFDI As String
        Dim unidadvar As String
        Dim impuestosTraslados As String
        Dim tasacuota As String
        Dim tipoFactor As String
        Dim impuesto As String
        Dim VarConceptos As XmlNodeList
        On Error Resume Next
        Dim VarDocumentoXML As XmlDocument = New XmlDocument()
        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(VarDocumentoXML.NameTable)
        ruta = txt_direccion.Text 'asigana valor de caja de texto ala variable
        VarDocumentoXML.Load(ruta)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML
        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
        Version_xml = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
        If Version_xml = "3.3" Then
            total = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText
            Emisor_Nombre = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Nombre", VarManager).InnerText
            UUID = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/tfd:TimbreFiscalDigital/@UUID", VarManager).InnerText
            version = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
            folio = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Folio", VarManager).InnerText
            fecha = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Fecha", VarManager).InnerText
            sello = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Sello", VarManager).InnerText
            formaPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@FormaPago", VarManager).InnerText
            Ncertificado = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@NoCertificado", VarManager).InnerText
            certificado = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Certificado", VarManager).InnerText
            condicionesPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@CondicionesDePago", VarManager).InnerText
            Subtotal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText.Replace(".", ",")
            Moneda = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Moneda", VarManager).InnerText
            tipoCambio = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoCambio", VarManager).InnerText.Replace(".", ",")
            total = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText.Replace(".", ",")
            TipoComprobante = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoDeComprobante", VarManager).InnerText
            MetodoPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@MetodoPago", VarManager).InnerText
            LugarExpedicion = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@LugarExpedicion", VarManager).InnerText
            rfcEmi = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Rfc", VarManager).InnerText
            nombreemi = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Nombre", VarManager).InnerText
            regimenfiscal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@RegimenFiscal", VarManager).InnerText
            rfcRecep = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Rfc", VarManager).InnerText
            nombreRep = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Nombre", VarManager).InnerText
            usoCFDI = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@UsoCFDI", VarManager).InnerText
            impuestosTraslados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosTrasladados", VarManager).InnerText.Replace(".", ",")
            tasacuota = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TasaOCuota", VarManager).InnerText.Replace(".", ",")
            tipoFactor = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TipoFactor", VarManager).InnerText
            impuesto = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Impuesto", VarManager).InnerText


            implocalretenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeRetenciones", VarManager).InnerText
            implocaltraladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeTraslados", VarManager).InnerText
            retenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosRetenidos", VarManager).InnerText
            trasladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosTrasladados", VarManager).InnerText
            Subtotal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText
            VarConceptos = VarDocumentoXML.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", VarManager)
            MsgBox("Los Siguientes Productos Forman Parte de Tu Factura", MessageBoxIcon.Exclamation)
            For Each node In VarConceptos
                valor_noIdentificacion = node.attributes("NoIdentificacion").value
                preciounitarioxml = node.attributes("ValorUnitario").value.Replace(".", ",")
                importeconcepto = node.attributes("Importe").value.Replace(".", ",")
                cantidadvendida = node.attributes("Cantidad").value
                subtotalclave = node.attributes("Importe").value.Replace(".", ",")
                descripcionxml = node.attributes("Descripcion").value
                unidadvar = node.attributes("Unidad").value
                NIdentificacionlab.Text = valor_noIdentificacion
                ValorUnitariolab.Text = preciounitarioxml
                importelab.Text = importeconcepto
                cantidadlab.Text = cantidadvendida
                importe2lab.Text = subtotalclave
                descripcionlab.Text = descripcionxml
                unidadlab.Text = unidadvar
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosFactuProd

                logica.FPcodigo = Me.txtCodigo.Text
                logica.FPcodigo_identificacion = Me.NIdentificacionlab.Text
                logica.FPvalorunitario = Me.ValorUnitariolab.Text
                logica.FPimporte = Me.importelab.Text
                logica.FPcantidad = Me.cantidadlab.Text
                logica.FPdescripcion = descripcionxml
                logica.FPunidad = Me.unidadlab.Text

                If funciones.FN_InsertarProdFacturas(logica) Then
                    'MsgBox("Producto Añadido A la Factura", MessageBoxIcon.Information)
                End If
                MsgBox("Producto: " & descripcionxml, MessageBoxIcon.Information)

            Next
        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If

    End Sub

    Private Sub btn_leerXml_Click(sender As Object, e As EventArgs) Handles btn_leerXml.Click
        Dim ruta As String 'VARIABLE PARA DIRECCION DEL ARCHIVO<<<<--------------
        Dim Version_xml As String
        Dim implocaltraladados As Decimal
        Dim implocalretenidos As Decimal
        Dim retenidos As Decimal
        Dim trasladados As Decimal
        Dim Subtotal As String
        Dim valor_noIdentificacion As String
        Dim preciounitarioxml As Decimal
        Dim importeconcepto As Decimal
        Dim cantidadvendida As Decimal
        Dim subtotalclave As Decimal = 0
        Dim descripcionxml As String
        Dim Emisor_Nombre As String
        Dim version As String
        Dim folio As String
        Dim fecha As String
        Dim total As String
        Dim sello As String
        Dim formaPago As String
        Dim Ncertificado As String
        Dim certificado As String
        Dim condicionesPago As String
        Dim Moneda As String
        Dim tipodeCambio As String
        Dim UUID As String
        Dim tipoCambio As String
        Dim TipoComprobante As String
        Dim MetodoPago As String
        Dim LugarExpedicion As String
        Dim rfcEmi As String
        Dim nombreemi As String
        Dim regimenfiscal As String
        Dim rfcRecep As String
        Dim nombreRep As String
        Dim usoCFDI As String
        Dim unidadvar As String
        Dim impuestosTraslados As String
        Dim tasacuota As String
        Dim tipoFactor As String
        Dim impuesto As String
        Dim VarConceptos As XmlNodeList
        On Error Resume Next
        Dim VarDocumentoXML As XmlDocument = New XmlDocument()
        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(VarDocumentoXML.NameTable)
        ruta = txt_direccion.Text 'asigana valor de caja de texto ala variable
        VarDocumentoXML.Load(ruta)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML
        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
        Version_xml = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
        If Version_xml = "3.3" Then
            total = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText
            Emisor_Nombre = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Nombre", VarManager).InnerText
            UUID = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/tfd:TimbreFiscalDigital/@UUID", VarManager).InnerText
            version = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
            folio = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Folio", VarManager).InnerText
            fecha = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Fecha", VarManager).InnerText
            sello = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Sello", VarManager).InnerText
            formaPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@FormaPago", VarManager).InnerText
            Ncertificado = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@NoCertificado", VarManager).InnerText
            certificado = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Certificado", VarManager).InnerText
            condicionesPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@CondicionesDePago", VarManager).InnerText
            Subtotal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText.Replace(".", ",")
            Moneda = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Moneda", VarManager).InnerText
            tipoCambio = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoCambio", VarManager).InnerText.Replace(".", ",")
            total = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText.Replace(".", ",")
            TipoComprobante = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoDeComprobante", VarManager).InnerText
            MetodoPago = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@MetodoPago", VarManager).InnerText
            LugarExpedicion = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@LugarExpedicion", VarManager).InnerText
            rfcEmi = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Rfc", VarManager).InnerText
            nombreemi = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Nombre", VarManager).InnerText
            regimenfiscal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@RegimenFiscal", VarManager).InnerText
            rfcRecep = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Rfc", VarManager).InnerText
            nombreRep = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@Nombre", VarManager).InnerText
            usoCFDI = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Receptor/@UsoCFDI", VarManager).InnerText
            impuestosTraslados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosTrasladados", VarManager).InnerText.Replace(".", ",")
            tasacuota = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TasaOCuota", VarManager).InnerText.Replace(".", ",")
            tipoFactor = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@TipoFactor", VarManager).InnerText
            impuesto = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado/@Impuesto", VarManager).InnerText


            FolioFIscal.Text = UUID
            versionlab.Text = version
            FolioLab.Text = folio
            FechaLab.Text = fecha
            sellolab.Text = sello
            fpagolab.Text = formaPago
            ncertificadolab.Text = Ncertificado
            CertificadoLab.Text = certificado
            CondicionesLab.Text = condicionesPago
            SubtotalLab.Text = Subtotal
            MonedaLab.Text = Moneda
            TipoCambioLab.Text = tipoCambio
            TotalLab.Text = total
            TComprobanteLab.Text = TipoComprobante
            MetodoPLab.Text = MetodoPago
            LugarExpLab.Text = LugarExpedicion
            RfcEmisorLab.Text = rfcEmi
            NombreEmLab.Text = nombreemi
            RegFiscalLab.Text = regimenfiscal
            RFCReceptorLab.Text = rfcRecep
            NombreRecLab.Text = nombreRep
            UsoCFDIlab.Text = usoCFDI
            impurestrosTrasladosLAB.Text = impuestosTraslados
            TipofactorLAb.Text = tipoFactor
            impuestolab.Text = impuesto
            tasacuotalab.Text = tasacuota

            implocalretenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeRetenciones", VarManager).InnerText
            implocaltraladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeTraslados", VarManager).InnerText
            retenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosRetenidos", VarManager).InnerText
            trasladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosTrasladados", VarManager).InnerText
            Subtotal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText
            VarConceptos = VarDocumentoXML.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", VarManager)

            ' For Each node In VarConceptos
            'valor_noIdentificacion = node.attributes("NoIdentificacion").value
            'preciounitarioxml = node.attributes("ValorUnitario").value
            'importeconcepto = node.attributes("Importe").value
            'cantidadvendida = node.attributes("Cantidad").value
            'subtotalclave = node.attributes("Importe").value
            ''descripcionxml = node.attributes("Descripcion").value
            'unidadvar = node.attributes("Unidad").value
            'NIdentificacionlab.Text = valor_noIdentificacion
            'ValorUnitariolab.Text = preciounitarioxml
            ''importelab.Text = importeconcepto
            'cantidadlab.Text = cantidadvendida
            'importe2lab.Text = subtotalclave
            'descripcionlab.Text = descripcionxml
            ''unidadlab.Text = unidadvar
            'Dim funciones As New Funcion_Registros
            'Dim logica As New ClassRegistrosFactuProd

            'logica.FPcodigo = Me.txtCodigo.Text
            'logica.FPcodigo_identificacion = Me.NIdentificacionlab.Text
            'logica.FPvalorunitario = Me.ValorUnitariolab.Text
            'logica.FPimporte = Me.importelab.Text
            'logica.FPcantidad = Me.cantidadlab.Text
            ''logica.FPdescripcion = descripcionxml
            'logica.FPunidad = Me.unidadlab.Text

            'If funciones.FN_InsertarProdFacturas(logica) Then
            'MsgBox("Factura Agregada Correctamente", MessageBoxIcon.Information)
            'End If
            '   MsgBox("Producto: " & descripcionxml)

            'Next
            BtnGuardarFac.Enabled = True
        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If

    End Sub

    '-------------------<<<<<<<<<<FIN>>>>>>>>>>>>-------------------------
    '-------------------------codigo Factura-------------------
    Sub GenerarCodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_fact)from TB_Facturas", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        txtCodigo.Text = "FAC-" + Format(id + 1, "0000") + "/20"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegistrosOrdCom.ShowDialog()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
        Index.Show()
    End Sub

    Private Sub btnCerrarPrograma_Click(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Esta Seguro Que ¿Desea salir?", vbYesNo, MessageBoxIcon.Warning)
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        facturasRegis.ShowDialog()
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        Try
            Dim cancelado As Boolean = False
            Dim openFD As New OpenFileDialog()
            With openFD
                .Title = "Factura PDF"
                .Filter = "Documento Digital (*.pdf)|*.pdf"
                .Multiselect = False
                '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
                .InitialDirectory = "c:\"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    textpdf.Text = IO.Path.GetFileName(.FileName)
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Documentos\PDF"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & textpdf.Text)
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                        btn_SubirArchivo.Enabled = True

                    End If
                End If
            End With

        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try


    End Sub

    'Private Sub btn_xml_Click(sender As Object, e As EventArgs) Handles btn_xml.Click
    '    Try
    '        Dim cancelado As Boolean = False
    '        Dim openFD As New OpenFileDialog()
    '        With openFD
    '            .Title = "Factura XML"
    '            .Filter = "Factura Digital (*.xml)|*.xml"
    '            .Multiselect = False
    '            '.InitialDirectory = My.Computer.FileSystem.CurrentDirectory //abrir en carpeta de ejecucion del programa
    '            .InitialDirectory = "c:\"
    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                text_xml.Text = IO.Path.GetFileName(.FileName)
    '                Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Documentos\XML"
    '                Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & text_xml.Text)
    '                If fichero.Exists Then
    '                    If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
    '                        cancelado = True
    '                    Else
    '                        System.IO.File.Delete(fichero.FullName)
    '                    End If
    '                End If
    '                If Not cancelado Then
    '                    MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
    '                    System.IO.File.Copy(.FileName, fichero.FullName)
    '                End If
    '            End If
    '            btn_SubirArchivo.Enabled = True
    '        End With

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MessageBoxIcon.Warning)
    '    End Try

    'End Sub

    Private Sub btn_descargapdf_Click(sender As Object, e As EventArgs) Handles btn_descargapdf.Click
        ArchivosPDF.Show()
    End Sub

    Private Sub btn_descargaxml_Click(sender As Object, e As EventArgs) Handles btn_descargaxml.Click
        ArchivosXML.Show()
    End Sub


    '----------------------------------------------------------
    '-------------------<<<<<<<<<<Leer Factura>>>>>>>>>>>>-------------------------

    '-------------------<<<<<<<<<<--------Guardar Factura-------->>>>>>>>>>>>-------------------------
    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click
        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + txtCodigo.Text, "Nuevo Pedimento", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                productosfac()
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosFacturas

                logica.Fcodigo = Me.txtCodigo.Text
                logica.Fnombre_emi = Me.NombreEmLab.Text
                logica.Frfc_emi = Me.RfcEmisorLab.Text
                logica.Fregimenfiscal_emi = Me.RegFiscalLab.Text
                logica.Ffolio_fiscal = Me.FolioFIscal.Text
                logica.Fncertificado = Me.ncertificadolab.Text
                logica.Ffecha = Me.FechaLab.Text
                logica.Flugardeexpedicion = Me.LugarExpLab.Text
                logica.FNombre_rep = Me.NombreRecLab.Text
                logica.FRfc_rep = Me.RFCReceptorLab.Text
                logica.FUsoCfdi_rep = Me.UsoCFDIlab.Text
                logica.FTasa_cuota = Me.tasacuotalab.Text
                logica.FTipofactor = Me.TipofactorLAb.Text
                logica.FImpuesto = Me.impuestolab.Text
                logica.FTipoComprobante = Me.TComprobanteLab.Text
                logica.FFormadepago = Me.fpagolab.Text
                logica.FMetododePago = Me.MetodoPLab.Text
                logica.FCondicionesPago = Me.CondicionesLab.Text
                logica.FMoneda = Me.MonedaLab.Text
                logica.Ffolio = Me.FolioLab.Text
                logica.Fversion = Me.versionlab.Text
                logica.Fsello = Me.sellolab.Text
                logica.Fcertificado = Me.CertificadoLab.Text
                logica.FcodigoOrden = Me.txtOrdenCompra.Text
                logica.FTipodeCambio = Me.TipoCambioLab.Text
                logica.FSubtotal = Me.SubtotalLab.Text
                logica.FImpuestostraslados = Me.impurestrosTrasladosLAB.Text
                logica.FTotalFactura = Me.TotalLab.Text
                logica.Ftipo_factura = Me.ComboBox_tiposfactu.Text

                If funciones.FN_InsertarFacturas(logica) Then
                    MsgBox("Factura Agregada Correctamente", MessageBoxIcon.Information)
                    '----------------------------limpiar Cajas ---------------------------------
                    txtCodigo.Clear()
                    NombreEmLab.ResetText()
                    RfcEmisorLab.ResetText()
                    RegFiscalLab.ResetText()
                    FolioFIscal.ResetText()
                    ncertificadolab.ResetText()
                    FechaLab.ResetText()
                    LugarExpLab.ResetText()
                    LugarExpLab.ResetText()
                    RFCReceptorLab.ResetText()
                    UsoCFDIlab.ResetText()
                    tasacuotalab.ResetText()
                    TipofactorLAb.ResetText()
                    impuestolab.ResetText()
                    TComprobanteLab.ResetText()
                    fpagolab.ResetText()
                    MetodoPLab.ResetText()
                    CondicionesLab.ResetText()
                    MonedaLab.ResetText()
                    FolioLab.ResetText()
                    versionlab.ResetText()
                    sellolab.ResetText()
                    CertificadoLab.ResetText()
                    txtOrdenCompra.ResetText()
                    TipoCambioLab.ResetText()
                    SubtotalLab.ResetText()
                    impurestrosTrasladosLAB.ResetText()
                    TotalLab.ResetText()
                    NombreRecLab.ResetText()
                    GenerarCodigo()
                    '---------------------------------------------------------------------------
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
End Class