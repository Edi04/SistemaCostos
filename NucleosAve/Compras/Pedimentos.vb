Imports System.Data.SqlClient

Public Class Pedimentos
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Private Sub Pedimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generarcodigo()
    End Sub
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



    Sub llenarorden()
        Try
            Dim tabla As New DataTable
            Dim facturas As String
            Dim conexxo As New SqlConnection(conexioncita)
            Dim adaptador As New SqlDataAdapter
            Dim Rs As SqlDataReader
            facturas = ComboFactura.Text
            conexxo.Open()
            Dim comando As New SqlCommand("select codigoOrden from TB_Facturas where codigo='" + facturas + "'", conexxo)
            Rs = comando.ExecuteReader()
            Rs.Read()
            TexOrdenC.Text = Rs(0).ToString
            Rs.Close()
            conexxo.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub llenarProveedor()
        Try
            Dim tabla As New DataTable
            Dim facturas As String
            Dim conexxo As New SqlConnection(conexioncita)
            Dim adaptador As New SqlDataAdapter
            Dim Rs As SqlDataReader
            facturas = ComboFactura.Text
            conexxo.Open()
            Dim comando As New SqlCommand("select Nombre_emi from TB_Facturas where codigo='" + facturas + "'", conexxo)
            Rs = comando.ExecuteReader()
            Rs.Read()
            textprove.Text = Rs(0).ToString
            Rs.Close()
            conexxo.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardarFac_Click(sender As Object, e As EventArgs) Handles BtnGuardarFac.Click


        If MessageBox.Show("Estas Seguro Que Quieres Agregar " + txtCodigoPedimento.Text, "Nuevo Pedimento", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassPedimentos


                logica.Peid_provedor = Me.textprove.Text
                logica.Peorden_comprao = Me.TexOrdenC.Text
                logica.Peid_factura = Me.ComboFactura.Text
                logica.Pecove = Me.txtCove.Text
                logica.Pefecha = Me.DateTimeFecha.Value
                logica.Pecantidad = Me.TxtCantidad.Text
                logica.Peunidad = Me.txtUnidad.Text
                logica.PeprecioP = Me.txtppagado.Text
                logica.Petotal = Me.txtTotal.Text
                logica.Pevalor_Aduana = Me.txtValorAduana.Text
                logica.Pepedimento = Me.txtCodigoPedimento1.Text

                logica.Pecodigo_pedimento = Me.txtCodigoPedimento.Text

                logica.Peclave = Me.txtclave.Text
                logica.Peaduana = Me.txtAduana.Text
                logica.Petipo_cambio = Me.txttipocambio.Text
                logica.Pepeso_bruto = Me.txtpesobruto.Text
                logica.Petipo = Me.txttipoo.Text
                logica.Pet_cantidad = Me.txtcantidadt.Text
                logica.Peiva_RG_terceros1 = Me.TextIvaTotalll.Text
                logica.Petotal_RG_terceros1 = Me.txttotal_gastosterceros.Text
                logica.Peiva_custombokerage = Me.textivaCB.Text
                logica.Petotal_custombokerage = Me.texttotalCB.Text

                logica.PeimporteTGAG = Me.importeTGAG.Text
                logica.PeivaTGAG = Me.ivaTGAG.Text
                logica.PeTotalTGAG = Me.TotalTGAG.Text
                logica.PeimporteRC = Me.importeRC.Text
                logica.PepesoRC = Me.pesoRC.Text
                logica.PecostoRC = Me.costoRC.Text
                logica.PetcRC = Me.tcRC.Text
                logica.Pemxn1RC = Me.mxn1RC.Text
                logica.Pemxn2RC = Me.mxn2RC.Text
                logica.Peotrosgastos = Me.otrosgastos.Text
                logica.PeimporteCT = Me.importeCT.Text
                logica.PeivaCT = Me.ivaCT.Text
                logica.Pecodigobueno = Me.Textbox_codigo_pedimento.Text

                If funciones.FN_InsertarPedimentos(logica) Then
                    MsgBox("Datos Insertados Correctamente pedimento", MessageBoxIcon.Information)
                    Generarcodigo()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            '---------------------------------------registro de Mercancia------------------------------------------------
            '---------------------------------------registro 1------------------------------------------------
            If (TextNum1.Text = "" Or txtMercancia1.Text = "" Or txtfraccion1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias


                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia1.Text
                    mercancia.Merc_fraccion = Me.txtfraccion1.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia1.Clear()
            txtfraccion1.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 2------------------------------------------------
            If (TextNum2.Text = "" Or txtMercancia2.Text = "" Or txtfraccion2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia2.Text
                    mercancia.Merc_fraccion = Me.txtfraccion2.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia2.Clear()
            txtfraccion2.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 3------------------------------------------------
            If (TextNum3.Text = "" Or txtMercancia3.Text = "" Or txtfraccion3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia3.Text
                    mercancia.Merc_fraccion = Me.txtfraccion3.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia3.Clear()
            txtfraccion3.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 4------------------------------------------------
            If (TextNum4.Text = "" Or txtMercancia4.Text = "" Or txtfraccion4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia4.Text
                    mercancia.Merc_fraccion = Me.txtfraccion4.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia4.Clear()
            txtfraccion4.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 5------------------------------------------------
            If (TextNum5.Text = "" Or txtMercancia5.Text = "" Or txtfraccion5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia5.Text
                    mercancia.Merc_fraccion = Me.txtfraccion5.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia5.Clear()
            txtfraccion5.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 3------------------------------------------------
            If (TextNum6.Text = "" Or txtMercancia6.Text = "" Or txtfraccion6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia6.Text
                    mercancia.Merc_fraccion = Me.txtfraccion6.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia6.Clear()
            txtfraccion6.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 7------------------------------------------------
            If (TextNum7.Text = "" Or txtMercancia7.Text = "" Or txtfraccion7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia7.Text
                    mercancia.Merc_fraccion = Me.txtfraccion7.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia7.Clear()
            txtfraccion7.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 8------------------------------------------------
            If (TextNum8.Text = "" Or txtMercancia8.Text = "" Or txtfraccion8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia8.Text
                    mercancia.Merc_fraccion = Me.txtfraccion8.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia8.Clear()
            txtfraccion8.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 9------------------------------------------------
            If (TextNum9.Text = "" Or txtMercancia9.Text = "" Or txtfraccion9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia9.Text
                    mercancia.Merc_fraccion = Me.txtfraccion9.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia9.Clear()
            txtfraccion9.Clear()
            '-------------<<<<<>>>-------
            '---------------------------------------registro 10------------------------------------------------
            If (TextNum10.Text = "" Or txtMercancia10.Text = "" Or txtfraccion10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia10.Text
                    mercancia.Merc_fraccion = Me.txtfraccion10.Text
                    mercancia.Merc_codigoPed = Me.txtCodigoPedimento.Text
                    mercancia.Merc_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarPedimentosMercancia(mercancia) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia10.Clear()
            txtfraccion10.Clear()
            '-------------<<<<<>>>-------
            '<<<<<<<<<<<<<<<<<<<<<<<<< Termina >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            '------------------------Relacion de gastos por terceros-------------------------------------------------------------------------
            '------------------------Registro 1-------------------------------------------------------------------------
            If (txtcodigo1.Text = "" Or txtdescripcion1.Text = "" Or txtimporte1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo1.Text
                    gastos.GT_descripcion = Me.txtdescripcion1.Text
                    gastos.GT_importe = Me.txtimporte1.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.txtIva_gastosterceros.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            'txtcodigo1.Clear()
            'txtdescripcion1.Clear()
            txtimporte1.Clear()
            '-------------<<<<<>>>-------

            '------------------------Registro 2-------------------------------------------------------------------------
            If (txtcodigo2.Text = "" Or txtdescripcion2.Text = "" Or txtimporte2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo2.Text
                    gastos.GT_descripcion = Me.txtdescripcion2.Text
                    gastos.GT_importe = Me.txtimporte2.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp1.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo2.Clear()
            txtdescripcion2.Clear()
            txtimporte2.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 3-------------------------------------------------------------------------
            If (txtcodigo3.Text = "" Or txtdescripcion3.Text = "" Or txtimporte3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo3.Text
                    gastos.GT_descripcion = Me.txtdescripcion3.Text
                    gastos.GT_importe = Me.txtimporte3.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp2.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo3.Clear()
            txtdescripcion3.Clear()
            txtimporte3.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 4-------------------------------------------------------------------------
            If (txtcodigo4.Text = "" Or txtdescripcion4.Text = "" Or txtimporte4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo4.Text
                    gastos.GT_descripcion = Me.txtdescripcion4.Text
                    gastos.GT_importe = Me.txtimporte4.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp3.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo4.Clear()
            txtdescripcion4.Clear()
            txtimporte4.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 5-------------------------------------------------------------------------
            If (txtcodigo5.Text = "" Or txtdescripcion5.Text = "" Or txtimporte5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo5.Text
                    gastos.GT_descripcion = Me.txtdescripcion5.Text
                    gastos.GT_importe = Me.txtimporte5.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp4.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo5.Clear()
            txtdescripcion5.Clear()
            txtimporte5.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 6-------------------------------------------------------------------------
            If (txtcodigo6.Text = "" Or txtdescripcion6.Text = "" Or txtimporte6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo6.Text
                    gastos.GT_descripcion = Me.txtdescripcion6.Text
                    gastos.GT_importe = Me.txtimporte6.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp5.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo6.Clear()
            txtdescripcion6.Clear()
            txtimporte6.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 7-------------------------------------------------------------------------
            If (txtcodigo7.Text = "" Or txtdescripcion7.Text = "" Or txtimporte7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo7.Text
                    gastos.GT_descripcion = Me.txtdescripcion7.Text
                    gastos.GT_importe = Me.txtimporte7.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp6.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo7.Clear()
            txtdescripcion7.Clear()
            txtimporte7.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 8-------------------------------------------------------------------------
            If (txtcodigo8.Text = "" Or txtdescripcion8.Text = "" Or txtimporte8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo8.Text
                    gastos.GT_descripcion = Me.txtdescripcion8.Text
                    gastos.GT_importe = Me.txtimporte8.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp7.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo8.Clear()
            txtdescripcion8.Clear()
            txtimporte7.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 9-------------------------------------------------------------------------
            If (txtcodigo9.Text = "" Or txtdescripcion9.Text = "" Or txtimporte9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo9.Text
                    gastos.GT_descripcion = Me.txtdescripcion9.Text
                    gastos.GT_importe = Me.txtimporte9.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp8.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo9.Clear()
            txtdescripcion9.Clear()
            txtimporte9.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 10-------------------------------------------------------------------------
            If (txtcodigo10.Text = "" Or txtdescripcion10.Text = "" Or txtimporte10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo10.Text
                    gastos.GT_descripcion = Me.txtdescripcion10.Text
                    gastos.GT_importe = Me.txtimporte10.Text
                    gastos.GT_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT_iva = Me.TexIvaOp9.Text
                    gastos.GT_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros1(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo10.Clear()
            txtdescripcion10.Clear()
            txtimporte10.Clear()
            '-------------<<<<<>>>-------
            '<<<<<<<<<<<<<<<<<<<<<<<<< Termina >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            '------------------------Registro 1 gastos terceros2-------------------------------------------------------------------------
            If (numtext1.Text = "" Or txtdesc1.Text = "" Or textgravado1.Text = "" Or textIva_GT2_1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc1.Text
                    gastos.GT2_concepto = Me.txtconcepto1.Text
                    gastos.GT2_exento = Me.txtexento1.Text
                    gastos.GT2_gravado = Me.textgravado1.Text
                    gastos.GT2_iva = Me.textIva_GT2_1.Text
                    gastos.GT2_total = Me.txtTotalGT_1.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text


                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc1.Clear()
            txtconcepto1.Clear()
            txtexento1.Clear()
            textgravado1.Clear()
            textIva_GT2_1.Clear()
            txtTotalGT_1.Clear()
            '-------------<<<<<>>>-------

            '------------------------Registro 2 gastos terceros2-------------------------------------------------------------------------
            If (numtext2.Text = "" Or txtdesc2.Text = "" Or textgravado2.Text = "" Or textIva_GT2_2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc2.Text
                    gastos.GT2_concepto = Me.txtconcepto2.Text
                    gastos.GT2_exento = Me.txtexento2.Text
                    gastos.GT2_gravado = Me.textgravado2.Text
                    gastos.GT2_iva = Me.textIva_GT2_2.Text
                    gastos.GT2_total = Me.txtTotalGT_2.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc2.Clear()
            txtconcepto2.Clear()
            txtexento2.Clear()
            textgravado2.Clear()
            textIva_GT2_2.Clear()
            txtTotalGT_2.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 3 gastos terceros2-------------------------------------------------------------------------
            If (numtext3.Text = "" Or txtdesc3.Text = "" Or textgravado3.Text = "" Or textIva_GT2_3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc3.Text
                    gastos.GT2_concepto = Me.txtconcepto3.Text
                    gastos.GT2_exento = Me.txtexento3.Text
                    gastos.GT2_gravado = Me.textgravado3.Text
                    gastos.GT2_iva = Me.textIva_GT2_3.Text
                    gastos.GT2_total = Me.txtTotalGT_3.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc3.Clear()
            txtconcepto3.Clear()
            txtexento3.Clear()
            textgravado3.Clear()
            textIva_GT2_3.Clear()
            txtTotalGT_3.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 4 gastos terceros2-------------------------------------------------------------------------
            If (numtext4.Text = "" Or txtdesc4.Text = "" Or textgravado4.Text = "" Or textIva_GT2_4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc4.Text
                    gastos.GT2_concepto = Me.txtconcepto4.Text
                    gastos.GT2_exento = Me.txtexento4.Text
                    gastos.GT2_gravado = Me.textgravado4.Text
                    gastos.GT2_iva = Me.textIva_GT2_4.Text
                    gastos.GT2_total = Me.txtTotalGT_4.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc4.Clear()
            txtconcepto4.Clear()
            txtexento4.Clear()
            textgravado4.Clear()
            textIva_GT2_4.Clear()
            txtTotalGT_4.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 5 gastos terceros2-------------------------------------------------------------------------
            If (numtext5.Text = "" Or txtdesc5.Text = "" Or textgravado5.Text = "" Or textIva_GT2_5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc5.Text
                    gastos.GT2_concepto = Me.txtconcepto5.Text
                    gastos.GT2_exento = Me.txtexento5.Text
                    gastos.GT2_gravado = Me.textgravado5.Text
                    gastos.GT2_iva = Me.textIva_GT2_5.Text
                    gastos.GT2_total = Me.txtTotalGT_5.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc5.Clear()
            txtconcepto5.Clear()
            txtexento5.Clear()
            textgravado5.Clear()
            textIva_GT2_5.Clear()
            txtTotalGT_5.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 6 gastos terceros2-------------------------------------------------------------------------
            If (numtext6.Text = "" Or txtdesc6.Text = "" Or textgravado6.Text = "" Or textIva_GT2_6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc6.Text
                    gastos.GT2_concepto = Me.txtconcepto6.Text
                    gastos.GT2_exento = Me.txtexento6.Text
                    gastos.GT2_gravado = Me.textgravado6.Text
                    gastos.GT2_iva = Me.textIva_GT2_6.Text
                    gastos.GT2_total = Me.txtTotalGT_6.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc6.Clear()
            txtconcepto6.Clear()
            txtexento6.Clear()
            textgravado6.Clear()
            textIva_GT2_6.Clear()
            txtTotalGT_6.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 7 gastos terceros2-------------------------------------------------------------------------
            If (numtext7.Text = "" Or txtdesc7.Text = "" Or textgravado7.Text = "" Or textIva_GT2_7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc7.Text
                    gastos.GT2_concepto = Me.txtconcepto7.Text
                    gastos.GT2_exento = Me.txtexento7.Text
                    gastos.GT2_gravado = Me.textgravado7.Text
                    gastos.GT2_iva = Me.textIva_GT2_7.Text
                    gastos.GT2_total = Me.txtTotalGT_7.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc7.Clear()
            txtconcepto7.Clear()
            txtexento7.Clear()
            textgravado7.Clear()
            textIva_GT2_7.Clear()
            txtTotalGT_7.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 8 gastos terceros2-------------------------------------------------------------------------
            If (numtext8.Text = "" Or txtdesc8.Text = "" Or textgravado8.Text = "" Or textIva_GT2_8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc8.Text
                    gastos.GT2_concepto = Me.txtconcepto8.Text
                    gastos.GT2_exento = Me.txtexento8.Text
                    gastos.GT2_gravado = Me.textgravado8.Text
                    gastos.GT2_iva = Me.textIva_GT2_8.Text
                    gastos.GT2_total = Me.txtTotalGT_8.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc8.Clear()
            txtconcepto8.Clear()
            txtexento8.Clear()
            textgravado8.Clear()
            textIva_GT2_8.Clear()
            txtTotalGT_8.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 4 gastos terceros2-------------------------------------------------------------------------
            If (numtext9.Text = "" Or txtdesc9.Text = "" Or textgravado9.Text = "" Or textIva_GT2_9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc9.Text
                    gastos.GT2_concepto = Me.txtconcepto9.Text
                    gastos.GT2_exento = Me.txtexento9.Text
                    gastos.GT2_gravado = Me.textgravado9.Text
                    gastos.GT2_iva = Me.textIva_GT2_9.Text
                    gastos.GT2_total = Me.txtTotalGT_9.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc9.Clear()
            txtconcepto9.Clear()
            txtexento9.Clear()
            textgravado9.Clear()
            textIva_GT2_9.Clear()
            txtTotalGT_9.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 10 gastos terceros2-------------------------------------------------------------------------
            If (numtext10.Text = "" Or txtdesc10.Text = "" Or textgravado10.Text = "" Or textIva_GT2_10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc10.Text
                    gastos.GT2_concepto = Me.txtconcepto10.Text
                    gastos.GT2_exento = Me.txtexento10.Text
                    gastos.GT2_gravado = Me.textgravado10.Text
                    gastos.GT2_iva = Me.textIva_GT2_10.Text
                    gastos.GT2_total = Me.txtTotalGT_10.Text
                    gastos.GT2_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.GT2_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarGastosTerceros2(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc10.Clear()
            txtconcepto10.Clear()
            txtexento10.Clear()
            textgravado10.Clear()
            textIva_GT2_10.Clear()
            txtTotalGT_10.Clear()
            '-------------<<<<<>>>-------
            '<<<<<<<<<<<<<<<<<<<<<<<<< Termina >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
            '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////  

            '_--------------inicia Customs Brokerage--------------------------------------
            '-.----------------customs Brokerage -----------
            'registro 1

            If (textDescripcion1.Text = "" Or textimporte1.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion1.Text
                    gastos.CB_importe = Me.textimporte1.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion1.Clear()
            textimporte1.Clear()

            'registro 2

            If (textDescripcion2.Text = "" Or textimporte2.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion2.Text
                    gastos.CB_importe = Me.textimporte2.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion2.Clear()
            textimporte2.Clear()

            'registro 3

            If (textDescripcion3.Text = "" Or textimporte3.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion3.Text
                    gastos.CB_importe = Me.textimporte3.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion3.Clear()
            textimporte3.Clear()

            'registro 4

            If (textDescripcion4.Text = "" Or textimporte4.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion4.Text
                    gastos.CB_importe = Me.textimporte4.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion4.Clear()
            textimporte4.Clear()

            'registro 5

            If (textDescripcion5.Text = "" Or textimporte5.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion5.Text
                    gastos.CB_importe = Me.textimporte5.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion5.Clear()
            textimporte5.Clear()

            'registro 6

            If (textDescripcion6.Text = "" Or textimporte6.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion6.Text
                    gastos.CB_importe = Me.textimporte6.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion6.Clear()
            textimporte6.Clear()

            'registro 7

            If (textDescripcion7.Text = "" Or textimporte7.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion7.Text
                    gastos.CB_importe = Me.textimporte7.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion7.Clear()
            textimporte7.Clear()

            'registro 8

            If (textDescripcion8.Text = "" Or textimporte8.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion8.Text
                    gastos.CB_importe = Me.textimporte8.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion8.Clear()
            textimporte8.Clear()

            'registro 9

            If (textDescripcion9.Text = "" Or textimporte9.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion9.Text
                    gastos.CB_importe = Me.textimporte9.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion9.Clear()
            textimporte9.Clear()

            'registro 10

            If (textDescripcion10.Text = "" Or textimporte10.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion10.Text
                    gastos.CB_importe = Me.textimporte10.Text
                    gastos.CB_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.CB_codigo_bueno = Me.Textbox_codigo_pedimento.Text

                    If funciones.FN_InsertarCustomsBrokerage(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion10.Clear()
            textimporte10.Clear()
            '-----------------------------------------------------Termina custom bokerage----------------------------------------------------------------------------------
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            '-------------------Scion de Fletes y Seguros-------------------------------------------------------------
            ''registro1
            If (textdescripFS1.Text = "" Or txtimporteFS1.Text = "" Or txtIvaFS1.Text = "" Or txtTotalFS1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS1.Text
                    gastos.FS_importe = Me.txtimporteFS1.Text
                    gastos.FS_iva = Me.txtIvaFS1.Text
                    gastos.FS_total = Me.txtTotalFS1.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones1.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones1.Text
                    End If

                    If txtTCFlete1.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete1.Text
                    End If

                    If TextUSDFLE1.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE1.Text
                    End If

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS1.Clear()
            txtimporteFS1.Clear()
            txtIvaFS1.Clear()
            txtTotalFS1.Clear()
            txtRetenciones1.Clear()
            txtTCFlete1.Clear()
            TextUSDFLE1.Clear()

            ''registro2
            If (textdescripFS2.Text = "" Or txtimporteFS2.Text = "" Or txtIvaFS2.Text = "" Or txtTotalFS2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS2.Text
                    gastos.FS_importe = Me.txtimporteFS2.Text
                    gastos.FS_iva = Me.txtIvaFS2.Text
                    gastos.FS_total = Me.txtTotalFS2.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones2.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones2.Text
                    End If

                    If txtTCFlete2.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete2.Text
                    End If

                    If TextUSDFLE2.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE2.Text
                    End If


                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS2.Clear()
            txtimporteFS2.Clear()
            txtIvaFS2.Clear()
            txtTotalFS2.Clear()
            txtRetenciones2.Clear()
            txtTCFlete2.Clear()
            TextUSDFLE2.Clear()




            ''registro3
            If (textdescripFS3.Text = "" Or txtimporteFS3.Text = "" Or txtIvaFS3.Text = "" Or txtTotalFS3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS3.Text
                    gastos.FS_importe = Me.txtimporteFS3.Text
                    gastos.FS_iva = Me.txtIvaFS3.Text
                    gastos.FS_total = Me.txtTotalFS3.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones3.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones3.Text
                    End If

                    If txtTCFlete3.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete3.Text
                    End If

                    If TextUSDFLE3.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE3.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete3.Text
                    'gastos.FS_usd = Me.TextUSDFLE3.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS3.Clear()
            txtimporteFS3.Clear()
            txtIvaFS3.Clear()
            txtTotalFS3.Clear()
            txtRetenciones3.Clear()
            txtTCFlete3.Clear()
            TextUSDFLE3.Clear()

            ''registro4
            If (textdescripFS4.Text = "" Or txtimporteFS4.Text = "" Or txtIvaFS4.Text = "" Or txtTotalFS4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS4.Text
                    gastos.FS_importe = Me.txtimporteFS4.Text
                    gastos.FS_iva = Me.txtIvaFS4.Text
                    gastos.FS_total = Me.txtTotalFS4.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones4.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones4.Text
                    End If

                    If txtTCFlete4.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete4.Text
                    End If

                    If TextUSDFLE4.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE4.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete4.Text
                    'gastos.FS_usd = Me.TextUSDFLE4.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS4.Clear()
            txtimporteFS4.Clear()
            txtIvaFS4.Clear()
            txtTotalFS4.Clear()
            txtRetenciones4.Clear()
            txtTCFlete4.Clear()
            TextUSDFLE4.Clear()

            ''registro5
            If (textdescripFS5.Text = "" Or txtimporteFS5.Text = "" Or txtIvaFS5.Text = "" Or txtTotalFS5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS5.Text
                    gastos.FS_importe = Me.txtimporteFS5.Text
                    gastos.FS_iva = Me.txtIvaFS5.Text
                    gastos.FS_total = Me.txtTotalFS5.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones5.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones5.Text
                    End If

                    If txtTCFlete5.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete5.Text
                    End If

                    If TextUSDFLE5.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE5.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete5.Text
                    'gastos.FS_usd = Me.TextUSDFLE5.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS5.Clear()
            txtimporteFS5.Clear()
            txtIvaFS5.Clear()
            txtTotalFS5.Clear()
            txtRetenciones5.Clear()
            txtTCFlete5.Clear()
            TextUSDFLE5.Clear()

            ''registro6
            If (textdescripFS6.Text = "" Or txtimporteFS6.Text = "" Or txtIvaFS6.Text = "" Or txtTotalFS6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS6.Text
                    gastos.FS_importe = Me.txtimporteFS6.Text
                    gastos.FS_iva = Me.txtIvaFS6.Text
                    gastos.FS_total = Me.txtTotalFS6.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones6.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones6.Text
                    End If

                    If txtTCFlete6.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete6.Text
                    End If

                    If TextUSDFLE6.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE6.Text
                    End If
                    'gastos.FS_tc = Me.txtTCFlete6.Text
                    'gastos.FS_usd = Me.TextUSDFLE6.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS6.Clear()
            txtimporteFS6.Clear()
            txtIvaFS6.Clear()
            txtTotalFS6.Clear()
            txtRetenciones6.Clear()
            txtTCFlete6.Clear()
            TextUSDFLE6.Clear()

            ''registro7
            If (textdescripFS7.Text = "" Or txtimporteFS7.Text = "" Or txtIvaFS7.Text = "" Or txtTotalFS7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS7.Text
                    gastos.FS_importe = Me.txtimporteFS7.Text
                    gastos.FS_iva = Me.txtIvaFS7.Text
                    gastos.FS_total = Me.txtTotalFS7.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones7.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones7.Text
                    End If

                    If txtTCFlete7.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete7.Text
                    End If

                    If TextUSDFLE7.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE7.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete7.Text
                    'gastos.FS_usd = Me.TextUSDFLE7.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS7.Clear()
            txtimporteFS7.Clear()
            txtIvaFS7.Clear()
            txtTotalFS7.Clear()
            txtRetenciones7.Clear()
            txtTCFlete7.Clear()
            TextUSDFLE7.Clear()

            ''registro8
            If (textdescripFS8.Text = "" Or txtimporteFS8.Text = "" Or txtIvaFS8.Text = "" Or txtTotalFS8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS8.Text
                    gastos.FS_importe = Me.txtimporteFS8.Text
                    gastos.FS_iva = Me.txtIvaFS8.Text
                    gastos.FS_total = Me.txtTotalFS8.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones8.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones8.Text
                    End If

                    If txtTCFlete8.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete8.Text
                    End If

                    If TextUSDFLE8.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE8.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete8.Text
                    'gastos.FS_usd = Me.TextUSDFLE8.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS8.Clear()
            txtimporteFS8.Clear()
            txtIvaFS8.Clear()
            txtTotalFS8.Clear()
            txtRetenciones8.Clear()
            txtTCFlete8.Clear()
            TextUSDFLE8.Clear()

            ''registro9
            If (textdescripFS9.Text = "" Or txtimporteFS9.Text = "" Or txtIvaFS9.Text = "" Or txtTotalFS9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS9.Text
                    gastos.FS_importe = Me.txtimporteFS9.Text
                    gastos.FS_iva = Me.txtIvaFS9.Text
                    gastos.FS_total = Me.txtTotalFS9.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones9.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones9.Text
                    End If

                    If txtTCFlete9.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete9.Text
                    End If

                    If TextUSDFLE9.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE9.Text
                    End If

                    'gastos.FS_tc = Me.txtTCFlete9.Text
                    'gastos.FS_usd = Me.TextUSDFLE9.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS9.Clear()
            txtimporteFS9.Clear()
            txtIvaFS9.Clear()
            txtTotalFS9.Clear()
            txtRetenciones9.Clear()
            txtTCFlete9.Clear()
            TextUSDFLE9.Clear()

            ''registro10
            If (textdescripFS10.Text = "" Or txtimporteFS10.Text = "" Or txtIvaFS10.Text = "" Or txtTotalFS10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS10.Text
                    gastos.FS_importe = Me.txtimporteFS10.Text
                    gastos.FS_iva = Me.txtIvaFS10.Text
                    gastos.FS_total = Me.txtTotalFS10.Text
                    gastos.FS_codigoPed = Me.txtCodigoPedimento.Text
                    gastos.FS_codigo_bueno = Me.Textbox_codigo_pedimento.Text
                    If txtRetenciones10.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones10.Text
                    End If

                    If txtTCFlete10.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete10.Text
                    End If

                    If TextUSDFLE10.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE10.Text
                    End If
                    'gastos.FS_tc = Me.txtTCFlete10.Text
                    'gastos.FS_usd = Me.TextUSDFLE10.Text

                    If funciones.FN_InsertarFletesSeguros(gastos) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS10.Clear()
            txtimporteFS10.Clear()
            txtIvaFS10.Clear()
            txtTotalFS10.Clear()
            txtRetenciones10.Clear()
            txtTCFlete10.Clear()
            TextUSDFLE10.Clear()
            '-------------------------------------------------termino fletes y seguros---------------------------------------------
            '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            'inicio de resumen de costos

            '----------------------------------------------------------------------------------
            '----------------------------limpiar Cajas ---------------------------------
            textprove.Clear()
            TexOrdenC.Clear()
            txtCove.Clear()
            TxtCantidad.Clear()
            txtUnidad.Clear()
            txtppagado.Clear()
            txtTotal.Clear()
            txtValorAduana.Clear()
            txtCodigoPedimento.Clear()
            txtCodigoPedimento1.Clear()
            txtclave.Clear()
            txtAduana.Clear()
            txttipocambio.Clear()
            txtpesobruto.Clear()
            txttipoo.Clear()
            txtcantidadt.Clear()
            txtIva_gastosterceros.Clear()
            txttotal_gastosterceros.Clear()
            textivaCB.Clear()
            texttotalCB.Clear()
            importeTGAG.Clear()
            ivaTGAG.Clear()
            TotalTGAG.Clear()
            importeRC.Clear()
            pesoRC.Clear()
            costoRC.Clear()
            tcRC.Clear()
            mxn1RC.Clear()
            mxn2RC.Clear()
            otrosgastos.Clear()
            importeCT.Clear()
            ivaCT.Clear()
            '----------------------------------------------------------------------------------
        End If
    End Sub

    Private Sub ComboFactura_SelectionChangeCommitted_1(sender As Object, e As EventArgs)
        llenarorden()
        llenarProveedor()
    End Sub



    ''----------------------Combo Facturas------------------------------
    'Sub combo_facturas() 'combo para mostrar los productos
    '    Dim conexxo As New SqlConnection(conexioncita)
    '    conexxo.Open()
    '    comando = New SqlCommand("select * from TB_Facturas where estado='Activo'", conexxo)
    '    adaptador = New SqlDataAdapter(comando)
    '    tabla = New DataTable()
    '    adaptador.Fill(tabla)
    '    ComboFactura.DataSource = tabla
    '    ComboFactura.DisplayMember = "codigo"
    '    ComboFactura.ValueMember = "id_fact"
    '    conexxo.Close()
    'End Sub




    '--------------botones de mas y menos-----------

    Private Sub ImgAgregarTxt_Click(sender As Object, e As EventArgs) Handles ImgAgregarTxt.Click
        If TextNum2.Visible = False Then
            TextNum2.Visible = True
            txtMercancia2.Visible = True
            txtfraccion2.Visible = True
        Else
            If TextNum3.Visible = False Then
                TextNum3.Visible = True
                txtMercancia3.Visible = True
                txtfraccion3.Visible = True
            Else
                If TextNum4.Visible = False Then
                    TextNum4.Visible = True
                    txtMercancia4.Visible = True
                    txtfraccion4.Visible = True
                Else
                    If TextNum5.Visible = False Then
                        TextNum5.Visible = True
                        txtMercancia5.Visible = True
                        txtfraccion5.Visible = True
                    Else
                        If TextNum6.Visible = False Then
                            TextNum6.Visible = True
                            txtMercancia6.Visible = True
                            txtfraccion6.Visible = True
                        Else
                            If TextNum7.Visible = False Then
                                TextNum7.Visible = True
                                txtMercancia7.Visible = True
                                txtfraccion7.Visible = True
                            Else
                                If TextNum8.Visible = False Then
                                    TextNum8.Visible = True
                                    txtMercancia8.Visible = True
                                    txtfraccion8.Visible = True
                                Else
                                    If TextNum9.Visible = False Then
                                        TextNum9.Visible = True
                                        txtMercancia9.Visible = True
                                        txtfraccion9.Visible = True
                                    Else
                                        If TextNum10.Visible = False Then
                                            TextNum10.Visible = True
                                            txtMercancia10.Visible = True
                                            txtfraccion10.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btn_Agregar2_Click(sender As Object, e As EventArgs) Handles btn_Agregar2.Click
        If txtcodigo2.Visible = False Then
            txtcodigo2.Visible = True
            txtdescripcion2.Visible = True
            txtimporte2.Visible = True

            TexIvaOp1.Visible = True
            iVACheck1.Visible = True
            Label61.Visible = True

        Else
            If txtcodigo3.Visible = False Then
                txtcodigo3.Visible = True
                txtdescripcion3.Visible = True
                txtimporte3.Visible = True
                TexIvaOp2.Visible = True
                iVACheck2.Visible = True

            Else
                If txtcodigo4.Visible = False Then
                    txtcodigo4.Visible = True
                    txtdescripcion4.Visible = True
                    txtimporte4.Visible = True
                    TexIvaOp3.Visible = True
                    iVACheck3.Visible = True
                Else
                    If txtcodigo5.Visible = False Then
                        txtcodigo5.Visible = True
                        txtdescripcion5.Visible = True
                        txtimporte5.Visible = True
                        TexIvaOp4.Visible = True
                        iVACheck4.Visible = True
                    Else
                        If txtcodigo6.Visible = False Then
                            txtcodigo6.Visible = True
                            txtdescripcion6.Visible = True
                            txtimporte6.Visible = True
                            TexIvaOp5.Visible = True
                            iVACheck5.Visible = True
                        Else
                            If txtcodigo7.Visible = False Then
                                txtcodigo7.Visible = True
                                txtdescripcion7.Visible = True
                                txtimporte7.Visible = True
                                TexIvaOp6.Visible = True
                                iVACheck6.Visible = True
                            Else
                                If txtcodigo8.Visible = False Then
                                    txtcodigo8.Visible = True
                                    txtdescripcion8.Visible = True
                                    txtimporte8.Visible = True
                                    TexIvaOp7.Visible = True
                                    iVACheck7.Visible = True
                                Else
                                    If txtcodigo9.Visible = False Then
                                        txtcodigo9.Visible = True
                                        txtdescripcion9.Visible = True
                                        txtimporte9.Visible = True
                                        TexIvaOp8.Visible = True
                                        iVACheck8.Visible = True
                                    Else
                                        If txtcodigo10.Visible = False Then
                                            txtcodigo10.Visible = True
                                            txtdescripcion10.Visible = True
                                            txtimporte10.Visible = True
                                            TexIvaOp9.Visible = True
                                            iVACheck9.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub btn_agregarmas_Click(sender As Object, e As EventArgs) Handles btn_agregarmas.Click
        If numtext2.Visible = False Then
            numtext2.Visible = True
            txtdesc2.Visible = True
            txtconcepto2.Visible = True
            txtexento2.Visible = True
            textgravado2.Visible = True
            textIva_GT2_2.Visible = True
            txtTotalGT_2.Visible = True
        Else
            If numtext3.Visible = False Then
                numtext3.Visible = True
                txtdesc3.Visible = True
                txtconcepto3.Visible = True
                txtexento3.Visible = True
                textgravado3.Visible = True
                textIva_GT2_3.Visible = True
                txtTotalGT_3.Visible = True
            Else
                If numtext4.Visible = False Then
                    numtext4.Visible = True
                    txtdesc4.Visible = True
                    txtconcepto4.Visible = True
                    txtexento4.Visible = True
                    textgravado4.Visible = True
                    textIva_GT2_4.Visible = True
                    txtTotalGT_4.Visible = True
                Else
                    If numtext5.Visible = False Then
                        numtext5.Visible = True
                        txtdesc5.Visible = True
                        txtconcepto5.Visible = True
                        txtexento5.Visible = True
                        textgravado5.Visible = True
                        textIva_GT2_5.Visible = True
                        txtTotalGT_5.Visible = True
                    Else
                        If numtext6.Visible = False Then
                            numtext6.Visible = True
                            txtdesc6.Visible = True
                            txtconcepto6.Visible = True
                            txtexento6.Visible = True
                            textgravado6.Visible = True
                            textIva_GT2_6.Visible = True
                            txtTotalGT_6.Visible = True
                        Else
                            If numtext7.Visible = False Then
                                numtext7.Visible = True
                                txtdesc7.Visible = True
                                txtconcepto7.Visible = True
                                txtexento7.Visible = True
                                textgravado7.Visible = True
                                textIva_GT2_7.Visible = True
                                txtTotalGT_7.Visible = True
                            Else
                                If numtext8.Visible = False Then
                                    numtext8.Visible = True
                                    txtdesc8.Visible = True
                                    txtconcepto8.Visible = True
                                    txtexento8.Visible = True
                                    textgravado8.Visible = True
                                    textIva_GT2_8.Visible = True
                                    txtTotalGT_8.Visible = True

                                Else
                                    If numtext9.Visible = False Then
                                        numtext9.Visible = True
                                        txtdesc9.Visible = True
                                        txtconcepto9.Visible = True
                                        txtexento9.Visible = True
                                        textgravado9.Visible = True
                                        textIva_GT2_9.Visible = True
                                        txtTotalGT_9.Visible = True
                                    Else
                                        If numtext10.Visible = False Then
                                            numtext10.Visible = True
                                            txtdesc10.Visible = True
                                            txtconcepto10.Visible = True
                                            txtexento10.Visible = True
                                            textgravado10.Visible = True
                                            textIva_GT2_10.Visible = True
                                            txtTotalGT_10.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Btn_CBrok_Mas_Click(sender As Object, e As EventArgs) Handles Btn_CBrok_Mas.Click
        If txtNumero2.Visible = False Then
            txtNumero2.Visible = True
            textDescripcion2.Visible = True
            textimporte2.Visible = True
        Else
            If txtNumero3.Visible = False Then
                txtNumero3.Visible = True
                textDescripcion3.Visible = True
                textimporte3.Visible = True
            Else
                If txtNumero4.Visible = False Then
                    txtNumero4.Visible = True
                    textDescripcion4.Visible = True
                    textimporte4.Visible = True
                Else
                    If txtNumero5.Visible = False Then
                        txtNumero5.Visible = True
                        textDescripcion5.Visible = True
                        textimporte5.Visible = True
                    Else
                        If txtNumero6.Visible = False Then
                            txtNumero6.Visible = True
                            textDescripcion6.Visible = True
                            textimporte6.Visible = True
                        Else
                            If txtNumero7.Visible = False Then
                                txtNumero7.Visible = True
                                textDescripcion7.Visible = True
                                textimporte7.Visible = True
                            Else
                                If txtNumero8.Visible = False Then
                                    txtNumero8.Visible = True
                                    textDescripcion8.Visible = True
                                    textimporte8.Visible = True

                                Else
                                    If txtNumero9.Visible = False Then
                                        txtNumero9.Visible = True
                                        textDescripcion9.Visible = True
                                        textimporte9.Visible = True
                                    Else
                                        If txtNumero10.Visible = False Then
                                            txtNumero10.Visible = True
                                            textDescripcion10.Visible = True
                                            textimporte10.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_masSF_Click(sender As Object, e As EventArgs) Handles btn_masSF.Click
        If textNumFS2.Visible = False Then
            textNumFS2.Visible = True
            textdescripFS2.Visible = True
            txtimporteFS2.Visible = True
            txtIvaFS2.Visible = True
            txtTotalFS2.Visible = True
            txtRetenciones2.Visible = True
            retencionCheck2.Visible = True
            txtTCFlete2.Visible = True
            TextUSDFLE2.Visible = True

        Else
            If textNumFS3.Visible = False Then
                textNumFS3.Visible = True
                textdescripFS3.Visible = True
                txtimporteFS3.Visible = True
                txtIvaFS3.Visible = True
                txtTotalFS3.Visible = True
                txtRetenciones3.Visible = True
                retencionCheck3.Visible = True
                txtTCFlete3.Visible = True
                TextUSDFLE3.Visible = True
            Else
                If textNumFS4.Visible = False Then
                    textNumFS4.Visible = True
                    textdescripFS4.Visible = True
                    txtimporteFS4.Visible = True
                    txtIvaFS4.Visible = True
                    txtTotalFS4.Visible = True
                    txtRetenciones4.Visible = True
                    retencionCheck4.Visible = True
                    txtTCFlete4.Visible = True
                    TextUSDFLE4.Visible = True
                Else
                    If textNumFS5.Visible = False Then
                        textNumFS5.Visible = True
                        textdescripFS5.Visible = True
                        txtimporteFS5.Visible = True
                        txtIvaFS5.Visible = True
                        txtTotalFS5.Visible = True
                        txtRetenciones5.Visible = True
                        retencionCheck5.Visible = True
                        txtTCFlete5.Visible = True
                        TextUSDFLE5.Visible = True
                    Else
                        If textNumFS6.Visible = False Then
                            textNumFS6.Visible = True
                            textdescripFS6.Visible = True
                            txtimporteFS6.Visible = True
                            txtIvaFS6.Visible = True
                            txtTotalFS6.Visible = True
                            txtRetenciones6.Visible = True
                            retencionCheck6.Visible = True
                            txtTCFlete6.Visible = True
                            TextUSDFLE6.Visible = True
                        Else
                            If textNumFS7.Visible = False Then
                                textNumFS7.Visible = True
                                textdescripFS7.Visible = True
                                txtimporteFS7.Visible = True
                                txtIvaFS7.Visible = True
                                txtTotalFS7.Visible = True
                                txtRetenciones7.Visible = True
                                retencionCheck7.Visible = True
                                txtTCFlete7.Visible = True
                                TextUSDFLE7.Visible = True
                            Else
                                If textNumFS8.Visible = False Then
                                    textNumFS8.Visible = True
                                    textdescripFS8.Visible = True
                                    txtimporteFS8.Visible = True
                                    txtIvaFS8.Visible = True
                                    txtTotalFS8.Visible = True
                                    txtRetenciones8.Visible = True
                                    retencionCheck8.Visible = True
                                    txtTCFlete8.Visible = True
                                    TextUSDFLE8.Visible = True

                                Else
                                    If textNumFS9.Visible = False Then
                                        textNumFS9.Visible = True
                                        textdescripFS9.Visible = True
                                        txtimporteFS9.Visible = True
                                        txtIvaFS9.Visible = True
                                        txtTotalFS9.Visible = True
                                        txtRetenciones9.Visible = True
                                        retencionCheck9.Visible = True
                                        txtTCFlete9.Visible = True
                                        TextUSDFLE9.Visible = True
                                    Else
                                        If textNumFS10.Visible = False Then
                                            textNumFS10.Visible = True
                                            textdescripFS10.Visible = True
                                            txtimporteFS10.Visible = True
                                            txtIvaFS10.Visible = True
                                            txtTotalFS10.Visible = True
                                            txtRetenciones10.Visible = True
                                            retencionCheck10.Visible = True
                                            txtTCFlete10.Visible = True
                                            TextUSDFLE10.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_menosSF_Click(sender As Object, e As EventArgs) Handles btn_menosSF.Click
        If textNumFS10.Visible = True Then
            textNumFS10.Visible = False
            textdescripFS10.Visible = False
            txtimporteFS10.Visible = False
            txtIvaFS10.Visible = False
            txtTotalFS10.Visible = False
            txtRetenciones10.Visible = False
            retencionCheck10.Visible = False
            txtTCFlete10.Visible = False
            TextUSDFLE10.Visible = False
        Else
            If textNumFS9.Visible = True Then
                textNumFS9.Visible = False
                textdescripFS9.Visible = False
                txtimporteFS9.Visible = False
                txtIvaFS9.Visible = False
                txtTotalFS9.Visible = False
                txtRetenciones9.Visible = False
                retencionCheck9.Visible = False
                txtTCFlete9.Visible = False
                TextUSDFLE9.Visible = False
            Else
                If textNumFS8.Visible = True Then
                    textNumFS8.Visible = False
                    textdescripFS8.Visible = False
                    txtimporteFS8.Visible = False
                    txtIvaFS8.Visible = False
                    txtTotalFS8.Visible = False
                    txtRetenciones8.Visible = False
                    retencionCheck8.Visible = False
                    txtTCFlete8.Visible = False
                    TextUSDFLE8.Visible = False
                Else
                    If textNumFS7.Visible = True Then
                        textNumFS7.Visible = False
                        textdescripFS7.Visible = False
                        txtimporteFS7.Visible = False
                        txtIvaFS7.Visible = False
                        txtTotalFS7.Visible = False
                        txtRetenciones7.Visible = False
                        retencionCheck7.Visible = False
                        txtTCFlete7.Visible = False
                        TextUSDFLE7.Visible = False
                    Else
                        If textNumFS6.Visible = True Then
                            textNumFS6.Visible = False
                            textdescripFS6.Visible = False
                            txtimporteFS6.Visible = False
                            txtIvaFS6.Visible = False
                            txtTotalFS6.Visible = False
                            txtRetenciones6.Visible = False
                            retencionCheck6.Visible = False
                            txtTCFlete6.Visible = False
                            TextUSDFLE6.Visible = False
                        Else
                            If textNumFS5.Visible = True Then
                                textNumFS5.Visible = False
                                textdescripFS5.Visible = False
                                txtimporteFS5.Visible = False
                                txtIvaFS5.Visible = False
                                txtTotalFS5.Visible = False
                                txtRetenciones5.Visible = False
                                retencionCheck5.Visible = False
                                txtTCFlete5.Visible = False
                                TextUSDFLE5.Visible = False
                            Else
                                If textNumFS4.Visible = True Then
                                    textNumFS4.Visible = False
                                    textdescripFS4.Visible = False
                                    txtimporteFS4.Visible = False
                                    txtIvaFS4.Visible = False
                                    txtTotalFS4.Visible = False
                                    txtRetenciones4.Visible = False
                                    retencionCheck4.Visible = False
                                    txtTCFlete4.Visible = False
                                    TextUSDFLE4.Visible = False
                                Else
                                    If textNumFS3.Visible = True Then
                                        textNumFS3.Visible = False
                                        textdescripFS3.Visible = False
                                        txtimporteFS3.Visible = False
                                        txtIvaFS3.Visible = False
                                        txtTotalFS3.Visible = False
                                        txtRetenciones3.Visible = False
                                        retencionCheck3.Visible = False
                                        txtTCFlete3.Visible = False
                                        TextUSDFLE3.Visible = False
                                    Else
                                        If textNumFS2.Visible = True Then
                                            textNumFS2.Visible = False
                                            textdescripFS2.Visible = False
                                            txtimporteFS2.Visible = False
                                            txtIvaFS2.Visible = False
                                            txtTotalFS2.Visible = False
                                            txtRetenciones2.Visible = False
                                            retencionCheck2.Visible = False
                                            txtTCFlete2.Visible = False
                                            TextUSDFLE2.Visible = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Btn_CBrok_Menos_Click(sender As Object, e As EventArgs) Handles Btn_CBrok_Menos.Click
        If txtNumero10.Visible = True Then
            txtNumero10.Visible = False
            textDescripcion10.Visible = False
            textimporte10.Visible = False
        Else
            If txtNumero9.Visible = True Then
                txtNumero9.Visible = False
                textDescripcion9.Visible = False
                textimporte9.Visible = False
            Else
                If txtNumero8.Visible = True Then
                    txtNumero8.Visible = False
                    textDescripcion8.Visible = False
                    textimporte8.Visible = False
                Else
                    If txtNumero7.Visible = True Then
                        txtNumero7.Visible = False
                        textDescripcion7.Visible = False
                        textimporte7.Visible = False
                    Else
                        If txtNumero6.Visible = True Then
                            txtNumero6.Visible = False
                            textDescripcion6.Visible = False
                            textimporte6.Visible = False
                        Else
                            If txtNumero5.Visible = True Then
                                txtNumero5.Visible = False
                                textDescripcion5.Visible = False
                                textimporte5.Visible = False
                            Else
                                If txtNumero4.Visible = True Then
                                    txtNumero4.Visible = False
                                    textDescripcion4.Visible = False
                                    textimporte4.Visible = False
                                Else
                                    If txtNumero3.Visible = True Then
                                        txtNumero3.Visible = False
                                        textDescripcion3.Visible = False
                                        textimporte3.Visible = False
                                    Else
                                        If txtNumero2.Visible = True Then
                                            txtNumero2.Visible = False
                                            textDescripcion2.Visible = False
                                            textimporte2.Visible = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_agregarmenos_Click(sender As Object, e As EventArgs) Handles btn_agregarmenos.Click
        If numtext10.Visible = True Then
            numtext10.Visible = False
            txtdesc10.Visible = False
            txtconcepto10.Visible = False
            txtexento10.Visible = False
            textgravado10.Visible = False
            textIva_GT2_10.Visible = False
            txtTotalGT_10.Visible = False
        Else
            If numtext9.Visible = True Then
                numtext9.Visible = False
                txtdesc9.Visible = False
                txtconcepto9.Visible = False
                txtexento9.Visible = False
                textgravado9.Visible = False
                textIva_GT2_9.Visible = False
                txtTotalGT_9.Visible = False
            Else
                If numtext8.Visible = True Then
                    numtext8.Visible = False
                    txtdesc8.Visible = False
                    txtconcepto8.Visible = False
                    txtexento8.Visible = False
                    textgravado8.Visible = False
                    textIva_GT2_8.Visible = False
                    txtTotalGT_8.Visible = False
                Else
                    If numtext7.Visible = True Then
                        numtext7.Visible = False
                        txtdesc7.Visible = False
                        txtconcepto7.Visible = False
                        txtexento7.Visible = False
                        textgravado7.Visible = False
                        textIva_GT2_7.Visible = False
                        txtTotalGT_7.Visible = False
                    Else
                        If numtext6.Visible = True Then
                            numtext6.Visible = False
                            txtdesc6.Visible = False
                            txtconcepto6.Visible = False
                            txtexento6.Visible = False
                            textgravado6.Visible = False
                            textIva_GT2_6.Visible = False
                            txtTotalGT_6.Visible = False
                        Else
                            If numtext5.Visible = True Then
                                numtext5.Visible = False
                                txtdesc5.Visible = False
                                txtconcepto5.Visible = False
                                txtexento5.Visible = False
                                textgravado5.Visible = False
                                textIva_GT2_5.Visible = False
                                txtTotalGT_5.Visible = False
                            Else
                                If numtext4.Visible = True Then
                                    numtext4.Visible = False
                                    txtdesc4.Visible = False
                                    txtconcepto4.Visible = False
                                    txtexento4.Visible = False
                                    textgravado4.Visible = False
                                    textIva_GT2_4.Visible = False
                                    txtTotalGT_4.Visible = False
                                Else
                                    If numtext3.Visible = True Then
                                        numtext3.Visible = False
                                        txtdesc3.Visible = False
                                        txtconcepto3.Visible = False
                                        txtexento3.Visible = False
                                        textgravado3.Visible = False
                                        textIva_GT2_3.Visible = False
                                        txtTotalGT_3.Visible = False
                                    Else
                                        If numtext2.Visible = True Then
                                            numtext2.Visible = False
                                            txtdesc2.Visible = False
                                            txtconcepto2.Visible = False
                                            txtexento2.Visible = False
                                            textgravado2.Visible = False
                                            textIva_GT2_2.Visible = False
                                            txtTotalGT_2.Visible = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_quitar2_Click(sender As Object, e As EventArgs) Handles btn_quitar2.Click
        If txtcodigo10.Visible = True Then
            txtcodigo10.Visible = False
            txtdescripcion10.Visible = False
            txtimporte10.Visible = False
            TexIvaOp9.Visible = False
            iVACheck9.Visible = False

        Else
            If txtcodigo9.Visible = True Then
                txtcodigo9.Visible = False
                txtdescripcion9.Visible = False
                txtimporte9.Visible = False
                TexIvaOp8.Visible = False
                iVACheck8.Visible = False
            Else
                If txtcodigo8.Visible = True Then
                    txtcodigo8.Visible = False
                    txtdescripcion8.Visible = False
                    txtimporte8.Visible = False
                    TexIvaOp7.Visible = False
                    iVACheck7.Visible = False
                Else
                    If txtcodigo7.Visible = True Then
                        txtcodigo7.Visible = False
                        txtdescripcion7.Visible = False
                        txtimporte7.Visible = False
                        TexIvaOp6.Visible = False
                        iVACheck6.Visible = False
                    Else
                        If txtcodigo6.Visible = True Then
                            txtcodigo6.Visible = False
                            txtdescripcion6.Visible = False
                            txtimporte6.Visible = False
                            TexIvaOp5.Visible = False
                            iVACheck5.Visible = False
                        Else
                            If txtcodigo5.Visible = True Then
                                txtcodigo5.Visible = False
                                txtdescripcion5.Visible = False
                                txtimporte5.Visible = False
                                TexIvaOp4.Visible = False
                                iVACheck4.Visible = False
                            Else
                                If txtcodigo4.Visible = True Then
                                    txtcodigo4.Visible = False
                                    txtdescripcion4.Visible = False
                                    txtimporte4.Visible = False
                                    TexIvaOp3.Visible = False
                                    iVACheck3.Visible = False
                                Else
                                    If txtcodigo3.Visible = True Then
                                        txtcodigo3.Visible = False
                                        txtdescripcion3.Visible = False
                                        txtimporte3.Visible = False
                                        TexIvaOp2.Visible = False
                                        iVACheck2.Visible = False
                                    Else
                                        If txtcodigo2.Visible = True Then
                                            txtcodigo2.Visible = False
                                            txtdescripcion2.Visible = False
                                            txtimporte2.Visible = False
                                            Label62.Visible = False
                                            TexIvaOp1.Visible = False
                                            iVACheck1.Visible = False
                                            Label61.Visible = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub imgMenosFila_Click(sender As Object, e As EventArgs) Handles imgMenosFila.Click
        If TextNum10.Visible = True Then
            TextNum10.Visible = False
            txtMercancia10.Visible = False
            txtfraccion10.Visible = False
        Else
            If TextNum9.Visible = True Then
                TextNum9.Visible = False
                txtMercancia9.Visible = False
                txtfraccion9.Visible = False
            Else
                If TextNum8.Visible = True Then
                    TextNum8.Visible = False
                    txtMercancia8.Visible = False
                    txtfraccion8.Visible = False
                Else
                    If TextNum7.Visible = True Then
                        TextNum7.Visible = False
                        txtMercancia7.Visible = False
                        txtfraccion7.Visible = False
                    Else
                        If TextNum6.Visible = True Then
                            TextNum6.Visible = False
                            txtMercancia6.Visible = False
                            txtfraccion6.Visible = False
                        Else
                            If TextNum5.Visible = True Then
                                TextNum5.Visible = False
                                txtMercancia5.Visible = False
                                txtfraccion5.Visible = False
                            Else
                                If TextNum4.Visible = True Then
                                    TextNum4.Visible = False
                                    txtMercancia4.Visible = False
                                    txtfraccion4.Visible = False
                                Else
                                    If TextNum3.Visible = True Then
                                        TextNum3.Visible = False
                                        txtMercancia3.Visible = False
                                        txtfraccion3.Visible = False
                                    Else
                                        If TextNum2.Visible = True Then
                                            TextNum2.Visible = False
                                            txtMercancia2.Visible = False
                                            txtfraccion2.Visible = False
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    '////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '-------------------------------Operaciones1-------------------------------------------
    Public Sub ValorAduana() Handles txttipocambio.TextChanged, txtTotal.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0

        If txttipocambio.Text <> Nothing Then
            cu1 = (txttipocambio.Text)
        End If

        If txtTotal.Text <> Nothing Then
            cu2 = (txtTotal.Text)
        End If

        txtValorAduana.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    '-------------------------------Operaciones2-------------------------------------------
    Public Sub IvaRelacionGastos1() Handles txtValorAduana.TextChanged, txtimporte1.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0
        If txtValorAduana.Text <> Nothing Then
            cu1 = (txtValorAduana.Text)
        End If

        If txtimporte1.Text <> Nothing Then
            cu2 = (txtimporte1.Text)
        End If
        resultado = (cu1 + cu2)
        txtIva_gastosterceros.Text = FormatCurrency((resultado * 0.16), 4)

    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '-------------------------------Operaciones2-------------------------------------------
    Public Sub suma_IvasRelacionGAstos1() Handles txtIva_gastosterceros.TextChanged, TexIvaOp1.TextChanged, TexIvaOp2.TextChanged,
            TexIvaOp7.TextChanged, TexIvaOp6.TextChanged, TexIvaOp5.TextChanged, TexIvaOp4.TextChanged, TexIvaOp3.TextChanged,
            TexIvaOp8.TextChanged, TexIvaOp9.TextChanged
        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim resultado As Double = 0
        If txtIva_gastosterceros.Text <> Nothing Then
            cu1 = (txtIva_gastosterceros.Text)
        End If
        If TexIvaOp1.Text <> Nothing Then
            cu2 = (TexIvaOp1.Text)
        End If
        If TexIvaOp2.Text <> Nothing Then
            cu3 = (TexIvaOp2.Text)
        End If
        If TexIvaOp3.Text <> Nothing Then
            cu4 = (TexIvaOp3.Text)
        End If
        If TexIvaOp4.Text <> Nothing Then
            cu5 = (TexIvaOp4.Text)
        End If
        If TexIvaOp5.Text <> Nothing Then
            cu6 = (TexIvaOp5.Text)
        End If
        If TexIvaOp6.Text <> Nothing Then
            cu7 = (TexIvaOp6.Text)
        End If
        If TexIvaOp7.Text <> Nothing Then
            cu8 = (TexIvaOp7.Text)
        End If
        If TexIvaOp8.Text <> Nothing Then
            cu9 = (TexIvaOp8.Text)
        End If
        If TexIvaOp9.Text <> Nothing Then
            cu10 = (TexIvaOp9.Text)
        End If

        TextIvaTotalll.Text = FormatCurrency((cu1), 4)

    End Sub
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '-------------------------------Operaciones7-------------------------------------------
    Public Sub ivasopcionales() Handles txtimporte2.TextChanged, txtimporte3.TextChanged, txtimporte4.TextChanged, txtimporte5.TextChanged,
            txtimporte6.TextChanged, txtimporte7.TextChanged, txtimporte8.TextChanged, txtimporte9.TextChanged, txtimporte10.TextChanged,
            iVACheck1.CheckedChanged, iVACheck2.CheckedChanged, iVACheck3.CheckedChanged, iVACheck4.CheckedChanged, iVACheck5.CheckedChanged,
            iVACheck6.CheckedChanged, iVACheck7.CheckedChanged, iVACheck8.CheckedChanged, iVACheck9.CheckedChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0

        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0

        Dim resultado As Double = 0

        If txtimporte2.Text <> Nothing Then
            cu1 = (txtimporte2.Text)
        End If
        If txtimporte3.Text <> Nothing Then
            cu2 = (txtimporte3.Text)
        End If
        If txtimporte4.Text <> Nothing Then
            cu3 = (txtimporte4.Text)
        End If
        If txtimporte5.Text <> Nothing Then
            cu4 = (txtimporte5.Text)
        End If
        If txtimporte6.Text <> Nothing Then
            cu5 = (txtimporte6.Text)
        End If
        If txtimporte7.Text <> Nothing Then
            cu6 = (txtimporte7.Text)
        End If
        If txtimporte8.Text <> Nothing Then
            cu7 = (txtimporte8.Text)
        End If
        If txtimporte9.Text <> Nothing Then
            cu8 = (txtimporte9.Text)
        End If
        If txtimporte10.Text <> Nothing Then
            cu9 = (txtimporte10.Text)
        End If

        '::::::::::::::::::::::::::::::::Cheked::::::::::::::::::::::::::::::::::::
        If iVACheck1.Checked = True Then
            TexIvaOp1.Text = FormatCurrency((cu1 * 0.16), 4)
        Else
            TexIvaOp1.Text = "0"
        End If

        If iVACheck2.Checked = True Then
            TexIvaOp2.Text = FormatCurrency((cu2 * 0.16), 4)
        Else
            TexIvaOp2.Text = "0"
        End If

        If iVACheck3.Checked = True Then
            TexIvaOp3.Text = FormatCurrency((cu3 * 0.16), 4)
        Else
            TexIvaOp3.Text = "0"
        End If

        If iVACheck4.Checked = True Then
            TexIvaOp4.Text = FormatCurrency((cu4 * 0.16), 4)
        Else
            TexIvaOp4.Text = "0"
        End If

        If iVACheck5.Checked = True Then
            TexIvaOp5.Text = FormatCurrency((cu5 * 0.16), 4)
        Else
            TexIvaOp5.Text = "0"
        End If

        If iVACheck6.Checked = True Then
            TexIvaOp6.Text = FormatCurrency((cu6 * 0.16), 4)
        Else
            TexIvaOp6.Text = "0"
        End If

        If iVACheck7.Checked = True Then
            TexIvaOp7.Text = FormatCurrency((cu7 * 0.16), 4)
        Else
            TexIvaOp7.Text = "0"
        End If

        If iVACheck8.Checked = True Then
            TexIvaOp8.Text = FormatCurrency((cu8 * 0.16), 4)
        Else
            TexIvaOp8.Text = "0"
        End If

        If iVACheck9.Checked = True Then
            TexIvaOp9.Text = FormatCurrency((cu9 * 0.16), 4)
        Else
            TexIvaOp9.Text = "0"
        End If

    End Sub

    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '-------------------------------Operaciones3-------------------------------------------
    Public Sub TotalRelacionGastos1() Handles txtimporte1.TextChanged, txtimporte2.TextChanged, txtimporte3.TextChanged,
        txtimporte4.TextChanged, txtimporte5.TextChanged, txtimporte6.TextChanged, txtimporte7.TextChanged, txtimporte8.TextChanged,
        txtimporte9.TextChanged, txtimporte10.TextChanged, TextIvaTotalll.TextChanged, TexIvaOp1.TextChanged, TexIvaOp2.TextChanged, TexIvaOp3.TextChanged, TexIvaOp4.TextChanged, TexIvaOp5.TextChanged, TexIvaOp6.TextChanged, TexIvaOp7.TextChanged, TexIvaOp8.TextChanged, TexIvaOp9.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim cu11 As Double = 0
        Dim resultado As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0

        If txtimporte1.Text <> Nothing Then
            cu1 = (txtimporte1.Text)
        End If
        If txtimporte2.Text <> Nothing Then
            cu2 = (txtimporte2.Text)
        End If
        If txtimporte3.Text <> Nothing Then
            cu3 = (txtimporte3.Text)
        End If
        If txtimporte4.Text <> Nothing Then
            cu4 = (txtimporte4.Text)
        End If
        If txtimporte5.Text <> Nothing Then
            cu5 = (txtimporte5.Text)
        End If
        If txtimporte6.Text <> Nothing Then
            cu6 = (txtimporte6.Text)
        End If
        If txtimporte7.Text <> Nothing Then
            cu7 = (txtimporte7.Text)
        End If
        If txtimporte8.Text <> Nothing Then
            cu8 = (txtimporte8.Text)
        End If
        If txtimporte9.Text <> Nothing Then
            cu9 = (txtimporte9.Text)
        End If
        If txtimporte10.Text <> Nothing Then
            cu10 = (txtimporte10.Text)
        End If
        If TextIvaTotalll.Text <> Nothing Then
            cu11 = (TextIvaTotalll.Text)
        End If
        If TexIvaOp1.Text <> Nothing Then
            cu12 = (TexIvaOp1.Text)
        End If
        If TexIvaOp2.Text <> Nothing Then
            cu13 = (TexIvaOp2.Text)
        End If
        If TexIvaOp3.Text <> Nothing Then
            cu14 = (TexIvaOp3.Text)
        End If
        If TexIvaOp4.Text <> Nothing Then
            cu15 = (TexIvaOp4.Text)
        End If
        If TexIvaOp5.Text <> Nothing Then
            cu16 = (TexIvaOp5.Text)
        End If
        If TexIvaOp6.Text <> Nothing Then
            cu17 = (TexIvaOp6.Text)
        End If
        If TexIvaOp7.Text <> Nothing Then
            cu18 = (TexIvaOp7.Text)
        End If
        If TexIvaOp8.Text <> Nothing Then
            cu19 = (TexIvaOp8.Text)
        End If
        If TexIvaOp9.Text <> Nothing Then
            cu20 = (TexIvaOp9.Text)
        End If



        txttotal_gastosterceros.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20), 4)

    End Sub

    '-------------------------------Operaciones4-------------------------------------------
    Public Sub IvaRelacionGastos2() Handles textgravado1.TextChanged, textgravado2.TextChanged, textgravado3.TextChanged, textgravado4.TextChanged, textgravado5.TextChanged, textgravado6.TextChanged, textgravado7.TextChanged, textgravado8.TextChanged, textgravado9.TextChanged, textgravado10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim resultado As Double = 0
        If textgravado1.Text <> Nothing Then
            cu1 = (textgravado1.Text)
        End If

        If textgravado2.Text <> Nothing Then
            cu2 = (textgravado2.Text)
        End If

        If textgravado3.Text <> Nothing Then
            cu3 = (textgravado3.Text)
        End If

        If textgravado4.Text <> Nothing Then
            cu4 = (textgravado4.Text)
        End If

        If textgravado5.Text <> Nothing Then
            cu5 = (textgravado5.Text)
        End If

        If textgravado6.Text <> Nothing Then
            cu6 = (textgravado6.Text)
        End If

        If textgravado7.Text <> Nothing Then
            cu7 = (textgravado7.Text)
        End If

        If textgravado8.Text <> Nothing Then
            cu8 = (textgravado8.Text)
        End If

        If textgravado9.Text <> Nothing Then
            cu9 = (textgravado9.Text)
        End If

        If textgravado10.Text <> Nothing Then
            cu10 = (textgravado10.Text)
        End If

        textIva_GT2_1.Text = FormatCurrency((cu1 * 0.16), 4)
        textIva_GT2_2.Text = FormatCurrency((cu2 * 0.16), 4)
        textIva_GT2_3.Text = FormatCurrency((cu3 * 0.16), 4)
        textIva_GT2_4.Text = FormatCurrency((cu4 * 0.16), 4)
        textIva_GT2_5.Text = FormatCurrency((cu5 * 0.16), 4)
        textIva_GT2_6.Text = FormatCurrency((cu6 * 0.16), 4)
        textIva_GT2_7.Text = FormatCurrency((cu7 * 0.16), 4)
        textIva_GT2_8.Text = FormatCurrency((cu8 * 0.16), 4)
        textIva_GT2_9.Text = FormatCurrency((cu9 * 0.16), 4)
        textIva_GT2_10.Text = FormatCurrency((cu10 * 0.16), 4)

    End Sub

    '-------------------------------Operaciones5-------------------------------------------
    Public Sub totalRelacionGastos2() Handles textgravado1.TextChanged,
        textgravado2.TextChanged, textgravado3.TextChanged, textgravado4.TextChanged,
        textgravado5.TextChanged, textgravado6.TextChanged, textgravado7.TextChanged,
        textgravado8.TextChanged, textgravado9.TextChanged, textgravado10.TextChanged,
        textIva_GT2_1.TextChanged, textIva_GT2_2.TextChanged, textIva_GT2_3.TextChanged,
        textIva_GT2_4.TextChanged, textIva_GT2_5.TextChanged, textIva_GT2_6.TextChanged,
        textIva_GT2_9.TextChanged, textIva_GT2_8.TextChanged, textIva_GT2_7.TextChanged,
        textIva_GT2_10.TextChanged, txtexento1.TextChanged, txtexento2.TextChanged, txtexento3.TextChanged,
        txtexento4.TextChanged, txtexento5.TextChanged, txtexento6.TextChanged, txtexento7.TextChanged,
        txtexento8.TextChanged, txtexento9.TextChanged, txtexento10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0
        Dim resultado As Double = 0

        Dim cu21 As Double = 0
        Dim cu22 As Double = 0
        Dim cu23 As Double = 0
        Dim cu24 As Double = 0
        Dim cu25 As Double = 0
        Dim cu26 As Double = 0
        Dim cu27 As Double = 0
        Dim cu28 As Double = 0
        Dim cu29 As Double = 0
        Dim cu30 As Double = 0

        If textgravado1.Text <> Nothing Then
            cu1 = (textgravado1.Text)
        End If

        If textgravado2.Text <> Nothing Then
            cu2 = (textgravado2.Text)
        End If

        If textgravado3.Text <> Nothing Then
            cu3 = (textgravado3.Text)
        End If

        If textgravado4.Text <> Nothing Then
            cu4 = (textgravado4.Text)
        End If

        If textgravado5.Text <> Nothing Then
            cu5 = (textgravado5.Text)
        End If

        If textgravado6.Text <> Nothing Then
            cu6 = (textgravado6.Text)
        End If

        If textgravado7.Text <> Nothing Then
            cu7 = (textgravado7.Text)
        End If

        If textgravado8.Text <> Nothing Then
            cu8 = (textgravado8.Text)
        End If

        If textgravado9.Text <> Nothing Then
            cu9 = (textgravado9.Text)
        End If

        If textgravado10.Text <> Nothing Then
            cu10 = (textgravado10.Text)
        End If

        If textIva_GT2_1.Text <> Nothing Then
            cu11 = (textIva_GT2_1.Text)
        End If

        If textIva_GT2_2.Text <> Nothing Then
            cu12 = (textIva_GT2_2.Text)
        End If

        If textIva_GT2_3.Text <> Nothing Then
            cu13 = (textIva_GT2_3.Text)
        End If

        If textIva_GT2_4.Text <> Nothing Then
            cu14 = (textIva_GT2_4.Text)
        End If

        If textIva_GT2_5.Text <> Nothing Then
            cu15 = (textIva_GT2_5.Text)
        End If

        If textIva_GT2_6.Text <> Nothing Then
            cu16 = (textIva_GT2_6.Text)
        End If

        If textIva_GT2_7.Text <> Nothing Then
            cu17 = (textIva_GT2_7.Text)
        End If

        If textIva_GT2_8.Text <> Nothing Then
            cu18 = (textIva_GT2_8.Text)
        End If

        If textIva_GT2_9.Text <> Nothing Then
            cu19 = (textIva_GT2_9.Text)
        End If

        If textIva_GT2_10.Text <> Nothing Then
            cu20 = (textIva_GT2_10.Text)
        End If


        If txtexento1.Text <> Nothing Then
            cu21 = (txtexento1.Text)
        End If

        If txtexento2.Text <> Nothing Then
            cu22 = (txtexento2.Text)
        End If

        If txtexento3.Text <> Nothing Then
            cu23 = (txtexento3.Text)
        End If

        If txtexento4.Text <> Nothing Then
            cu24 = (txtexento4.Text)
        End If

        If txtexento5.Text <> Nothing Then
            cu25 = (txtexento5.Text)
        End If

        If txtexento6.Text <> Nothing Then
            cu26 = (txtexento6.Text)
        End If

        If txtexento7.Text <> Nothing Then
            cu27 = (txtexento7.Text)
        End If

        If txtexento8.Text <> Nothing Then
            cu28 = (txtexento8.Text)
        End If

        If txtexento9.Text <> Nothing Then
            cu29 = (txtexento9.Text)
        End If

        If txtexento10.Text <> Nothing Then
            cu30 = (txtexento10.Text)
        End If

        txtTotalGT_1.Text = FormatCurrency((cu1 + cu11 + cu21), 4)
        txtTotalGT_2.Text = FormatCurrency((cu2 + cu12 + cu22), 4)
        txtTotalGT_3.Text = FormatCurrency((cu3 + cu13 + cu23), 4)
        txtTotalGT_4.Text = FormatCurrency((cu4 + cu14 + cu24), 4)
        txtTotalGT_5.Text = FormatCurrency((cu5 + cu15 + cu25), 4)
        txtTotalGT_6.Text = FormatCurrency((cu6 + cu16 + cu26), 4)
        txtTotalGT_7.Text = FormatCurrency((cu7 + cu17 + cu27), 4)
        txtTotalGT_8.Text = FormatCurrency((cu8 + cu18 + cu28), 4)
        txtTotalGT_9.Text = FormatCurrency((cu9 + cu19 + cu29), 4)
        txtTotalGT_10.Text = FormatCurrency((cu10 + cu20 + cu30), 4)

    End Sub

    '-------------------------------Operaciones6-------------------------------------------
    Public Sub sumaimportebokerage() Handles textimporte1.TextChanged, textimporte2.TextChanged, textimporte3.TextChanged,
            textimporte4.TextChanged, textimporte5.TextChanged, textimporte6.TextChanged,
            textimporte9.TextChanged, textimporte8.TextChanged, textimporte7.TextChanged,
            textimporte10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim resultado As Double = 0
        Dim operacion2 As Double = 0

        If textimporte1.Text <> Nothing Then
            cu1 = (textimporte1.Text)
        End If

        If textimporte2.Text <> Nothing Then
            cu2 = (textimporte2.Text)
        End If

        If textimporte3.Text <> Nothing Then
            cu3 = (textimporte3.Text)
        End If

        If textimporte4.Text <> Nothing Then
            cu4 = (textimporte4.Text)
        End If

        If textimporte5.Text <> Nothing Then
            cu5 = (textimporte5.Text)
        End If

        If textimporte6.Text <> Nothing Then
            cu6 = (textimporte6.Text)
        End If

        If textimporte7.Text <> Nothing Then
            cu7 = (textimporte7.Text)
        End If

        If textimporte8.Text <> Nothing Then
            cu8 = (textimporte8.Text)
        End If

        If textimporte9.Text <> Nothing Then
            cu9 = (textimporte9.Text)
        End If

        If textimporte10.Text <> Nothing Then
            cu10 = (textimporte10.Text)
        End If


        resultado = (cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10)
        textivaCB.Text = FormatCurrency((resultado * 0.16), 4)

        operacion2 = (resultado * 0.16)
        texttotalCB.Text = FormatCurrency((resultado + operacion2), 4)
    End Sub

    '-------------------------------Operaciones7-------------------------------------------
    Public Sub ivaFletesSeguros() Handles txtimporteFS1.TextChanged, txtimporteFS2.TextChanged, txtimporteFS3.TextChanged,
            txtimporteFS4.TextChanged, txtimporteFS5.TextChanged, txtimporteFS6.TextChanged,
            txtimporteFS9.TextChanged, txtimporteFS8.TextChanged, txtimporteFS7.TextChanged,
            txtimporteFS10.TextChanged, retencionCheck1.CheckedChanged, retencionCheck2.CheckedChanged, retencionCheck3.CheckedChanged,
            retencionCheck4.CheckedChanged, retencionCheck5.CheckedChanged, retencionCheck6.CheckedChanged, retencionCheck7.CheckedChanged,
            retencionCheck8.CheckedChanged, retencionCheck9.CheckedChanged, retencionCheck10.CheckedChanged, txtRetenciones1.TextChanged,
            txtRetenciones2.TextChanged, txtRetenciones3.TextChanged, txtRetenciones4.TextChanged, txtRetenciones5.TextChanged, txtRetenciones6.TextChanged,
        txtRetenciones7.TextChanged, txtRetenciones8.TextChanged, txtRetenciones9.TextChanged, txtRetenciones10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0

        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0
        Dim resultado As Double = 0

        If txtimporteFS1.Text <> Nothing Then
            cu1 = (txtimporteFS1.Text)
        End If

        If txtimporteFS2.Text <> Nothing Then
            cu2 = (txtimporteFS2.Text)
        End If

        If txtimporteFS3.Text <> Nothing Then
            cu3 = (txtimporteFS3.Text)
        End If

        If txtimporteFS4.Text <> Nothing Then
            cu4 = (txtimporteFS4.Text)
        End If

        If txtimporteFS5.Text <> Nothing Then
            cu5 = (txtimporteFS5.Text)
        End If

        If txtimporteFS6.Text <> Nothing Then
            cu6 = (txtimporteFS6.Text)
        End If

        If txtimporteFS7.Text <> Nothing Then
            cu7 = (txtimporteFS7.Text)
        End If

        If txtimporteFS8.Text <> Nothing Then
            cu8 = (txtimporteFS8.Text)
        End If

        If txtimporteFS9.Text <> Nothing Then
            cu9 = (txtimporteFS9.Text)
        End If

        If txtimporteFS10.Text <> Nothing Then
            cu10 = (txtimporteFS10.Text)
        End If

        If txtRetenciones1.Text <> Nothing Then
            cu11 = (txtRetenciones1.Text)
        End If

        If txtRetenciones2.Text <> Nothing Then
            cu12 = (txtRetenciones2.Text)
        End If

        If txtRetenciones3.Text <> Nothing Then
            cu13 = (txtRetenciones3.Text)
        End If

        If txtRetenciones4.Text <> Nothing Then
            cu14 = (txtRetenciones4.Text)
        End If
        If txtRetenciones5.Text <> Nothing Then
            cu15 = (txtRetenciones5.Text)
        End If
        If txtRetenciones6.Text <> Nothing Then
            cu16 = (txtRetenciones6.Text)
        End If

        If txtRetenciones7.Text <> Nothing Then
            cu17 = (txtRetenciones7.Text)
        End If

        If txtRetenciones8.Text <> Nothing Then
            cu18 = (txtRetenciones8.Text)
        End If

        If txtRetenciones9.Text <> Nothing Then
            cu19 = (txtRetenciones9.Text)
        End If

        If txtRetenciones10.Text <> Nothing Then
            cu20 = (txtRetenciones10.Text)
        End If

        txtIvaFS1.Text = FormatCurrency((cu1 * 0.16), 4)
        txtIvaFS2.Text = FormatCurrency((cu2 * 0.16), 4)
        txtIvaFS3.Text = FormatCurrency((cu3 * 0.16), 4)
        txtIvaFS4.Text = FormatCurrency((cu4 * 0.16), 4)
        txtIvaFS5.Text = FormatCurrency((cu5 * 0.16), 4)
        txtIvaFS6.Text = FormatCurrency((cu6 * 0.16), 4)
        txtIvaFS7.Text = FormatCurrency((cu7 * 0.16), 4)
        txtIvaFS8.Text = FormatCurrency((cu8 * 0.16), 4)
        txtIvaFS9.Text = FormatCurrency((cu9 * 0.16), 4)
        txtIvaFS10.Text = FormatCurrency((cu10 * 0.16), 4)

        If retencionCheck1.Checked = True Then
            txtRetenciones1.Text = FormatCurrency((cu1 * 0.04), 4)
        Else
            txtRetenciones1.Clear()
        End If


        If retencionCheck2.Checked = True Then
            txtRetenciones2.Text = FormatCurrency((cu2 * 0.04), 4)
        Else
            txtRetenciones2.Clear()
        End If


        If retencionCheck3.Checked = True Then
            txtRetenciones3.Text = FormatCurrency((cu3 * 0.04), 4)
        Else
            txtRetenciones3.Clear()
        End If

        If retencionCheck4.Checked = True Then
            txtRetenciones4.Text = FormatCurrency((cu4 * 0.04), 4)
        Else
            txtRetenciones4.Clear()
        End If

        If retencionCheck5.Checked = True Then
            txtRetenciones5.Text = FormatCurrency((cu5 * 0.04), 4)
        Else
            txtRetenciones5.Clear()
        End If

        If retencionCheck6.Checked = True Then
            txtRetenciones6.Text = FormatCurrency((cu6 * 0.04), 4)
        Else
            txtRetenciones6.Clear()
        End If

        If retencionCheck7.Checked = True Then
            txtRetenciones7.Text = FormatCurrency((cu7 * 0.04), 4)
        Else
            txtRetenciones7.Clear()
        End If

        If retencionCheck8.Checked = True Then
            txtRetenciones8.Text = FormatCurrency((cu8 * 0.04), 4)
        Else
            txtRetenciones8.Clear()
        End If

        If retencionCheck9.Checked = True Then
            txtRetenciones9.Text = FormatCurrency((cu9 * 0.04), 4)
        Else
            txtRetenciones9.Clear()
        End If

        If retencionCheck10.Checked = True Then
            txtRetenciones10.Text = FormatCurrency((cu10 * 0.04), 4)
        Else
            txtRetenciones10.Clear()
        End If

    End Sub

    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd() Handles txtTCFlete1.TextChanged, TextUSDFLE1.TextChanged

        Dim cu1 As Double = 0

        Dim cu11 As Double = 0

        If txtTCFlete1.Text <> Nothing Then
            cu1 = (txtTCFlete1.Text)
        End If

        If TextUSDFLE1.Text <> Nothing Then
            cu11 = (TextUSDFLE1.Text)
        End If


        txtimporteFS1.Text = (cu11 * cu1)

    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd2() Handles txtTCFlete2.TextChanged, TextUSDFLE2.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete2.Text <> Nothing Then
            cu2 = (txtTCFlete2.Text)
        End If
        If TextUSDFLE2.Text <> Nothing Then
            cu12 = (TextUSDFLE2.Text)
        End If
        txtimporteFS2.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd3() Handles txtTCFlete3.TextChanged, TextUSDFLE3.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete3.Text <> Nothing Then
            cu2 = (txtTCFlete3.Text)
        End If
        If TextUSDFLE3.Text <> Nothing Then
            cu12 = (TextUSDFLE3.Text)
        End If
        txtimporteFS3.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd4() Handles txtTCFlete4.TextChanged, TextUSDFLE4.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete4.Text <> Nothing Then
            cu2 = (txtTCFlete4.Text)
        End If
        If TextUSDFLE4.Text <> Nothing Then
            cu12 = (TextUSDFLE4.Text)
        End If
        txtimporteFS4.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd5() Handles txtTCFlete5.TextChanged, TextUSDFLE5.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete5.Text <> Nothing Then
            cu2 = (txtTCFlete5.Text)
        End If
        If TextUSDFLE5.Text <> Nothing Then
            cu12 = (TextUSDFLE5.Text)
        End If
        txtimporteFS5.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd6() Handles txtTCFlete6.TextChanged, TextUSDFLE6.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete6.Text <> Nothing Then
            cu2 = (txtTCFlete6.Text)
        End If
        If TextUSDFLE6.Text <> Nothing Then
            cu12 = (TextUSDFLE6.Text)
        End If
        txtimporteFS6.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd7() Handles txtTCFlete7.TextChanged, TextUSDFLE7.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete7.Text <> Nothing Then
            cu2 = (txtTCFlete7.Text)
        End If
        If TextUSDFLE7.Text <> Nothing Then
            cu12 = (TextUSDFLE7.Text)
        End If
        txtimporteFS7.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd8() Handles txtTCFlete8.TextChanged, TextUSDFLE8.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete8.Text <> Nothing Then
            cu2 = (txtTCFlete8.Text)
        End If
        If TextUSDFLE8.Text <> Nothing Then
            cu12 = (TextUSDFLE8.Text)
        End If
        txtimporteFS8.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd9() Handles txtTCFlete9.TextChanged, TextUSDFLE9.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete9.Text <> Nothing Then
            cu2 = (txtTCFlete9.Text)
        End If
        If TextUSDFLE9.Text <> Nothing Then
            cu12 = (TextUSDFLE9.Text)
        End If
        txtimporteFS9.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------
    ':::::::::::::::::::::::___________-----------------------------------------
    Public Sub importeFletesUsd10() Handles txtTCFlete10.TextChanged, TextUSDFLE10.TextChanged
        Dim cu2 As Double = 0
        Dim cu12 As Double = 0
        If txtTCFlete10.Text <> Nothing Then
            cu2 = (txtTCFlete10.Text)
        End If
        If TextUSDFLE10.Text <> Nothing Then
            cu12 = (TextUSDFLE10.Text)
        End If
        txtimporteFS10.Text = (cu12 * cu2)
    End Sub
    ':::::::::::::::::::::::___________-----------------------------------------


    '-------------------------------cONTINUIDAD DE FLETES Y SEGUROS-------------------------------------------
    Public Sub fletesysegurosTotalfinal() Handles txtimporteFS1.TextChanged, txtimporteFS2.TextChanged, txtimporteFS3.TextChanged,
            txtimporteFS4.TextChanged, txtimporteFS5.TextChanged, txtimporteFS6.TextChanged,
            txtimporteFS9.TextChanged, txtimporteFS8.TextChanged, txtimporteFS7.TextChanged,
            txtimporteFS10.TextChanged, txtRetenciones1.TextChanged,
            txtRetenciones2.TextChanged, txtRetenciones3.TextChanged, txtRetenciones4.TextChanged, txtRetenciones5.TextChanged, txtRetenciones6.TextChanged,
        txtRetenciones7.TextChanged, txtRetenciones8.TextChanged, txtRetenciones9.TextChanged, txtRetenciones10.TextChanged,
        txtIvaFS1.TextChanged, txtIvaFS2.TextChanged, txtIvaFS3.TextChanged, txtIvaFS4.TextChanged, txtIvaFS5.TextChanged,
        txtIvaFS6.TextChanged, txtIvaFS7.TextChanged, txtIvaFS8.TextChanged, txtIvaFS9.TextChanged, txtIvaFS10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0

        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0

        Dim cu21 As Double = 0
        Dim cu22 As Double = 0
        Dim cu23 As Double = 0
        Dim cu24 As Double = 0
        Dim cu25 As Double = 0
        Dim cu26 As Double = 0
        Dim cu27 As Double = 0
        Dim cu28 As Double = 0
        Dim cu29 As Double = 0
        Dim cu30 As Double = 0
        Dim suma As Double = 0
        Dim suma2 As Double = 0
        Dim suma3 As Double = 0
        Dim suma4 As Double = 0
        Dim suma5 As Double = 0
        Dim suma6 As Double = 0
        Dim suma7 As Double = 0
        Dim suma8 As Double = 0
        Dim suma9 As Double = 0
        Dim suma10 As Double = 0



        If txtimporteFS1.Text <> Nothing Then
            cu1 = (txtimporteFS1.Text)
        End If

        If txtimporteFS2.Text <> Nothing Then
            cu2 = (txtimporteFS2.Text)
        End If

        If txtimporteFS3.Text <> Nothing Then
            cu3 = (txtimporteFS3.Text)
        End If

        If txtimporteFS4.Text <> Nothing Then
            cu4 = (txtimporteFS4.Text)
        End If

        If txtimporteFS5.Text <> Nothing Then
            cu5 = (txtimporteFS5.Text)
        End If

        If txtimporteFS6.Text <> Nothing Then
            cu6 = (txtimporteFS6.Text)
        End If

        If txtimporteFS7.Text <> Nothing Then
            cu7 = (txtimporteFS7.Text)
        End If

        If txtimporteFS8.Text <> Nothing Then
            cu8 = (txtimporteFS8.Text)
        End If

        If txtimporteFS9.Text <> Nothing Then
            cu9 = (txtimporteFS9.Text)
        End If

        If txtimporteFS10.Text <> Nothing Then
            cu10 = (txtimporteFS10.Text)
        End If

        If txtRetenciones1.Text <> Nothing Then
            cu11 = (txtRetenciones1.Text)
        End If

        If txtRetenciones2.Text <> Nothing Then
            cu12 = (txtRetenciones2.Text)
        End If

        If txtRetenciones3.Text <> Nothing Then
            cu13 = (txtRetenciones3.Text)
        End If

        If txtRetenciones4.Text <> Nothing Then
            cu14 = (txtRetenciones4.Text)
        End If
        If txtRetenciones5.Text <> Nothing Then
            cu15 = (txtRetenciones5.Text)
        End If
        If txtRetenciones6.Text <> Nothing Then
            cu16 = (txtRetenciones6.Text)
        End If

        If txtRetenciones7.Text <> Nothing Then
            cu17 = (txtRetenciones7.Text)
        End If

        If txtRetenciones8.Text <> Nothing Then
            cu18 = (txtRetenciones8.Text)
        End If

        If txtRetenciones9.Text <> Nothing Then
            cu19 = (txtRetenciones9.Text)
        End If

        If txtRetenciones10.Text <> Nothing Then
            cu20 = (txtRetenciones10.Text)
        End If

        If txtIvaFS1.Text <> Nothing Then
            cu21 = (txtIvaFS1.Text)
        End If
        If txtIvaFS2.Text <> Nothing Then
            cu22 = (txtIvaFS2.Text)
        End If
        If txtIvaFS3.Text <> Nothing Then
            cu23 = (txtIvaFS3.Text)
        End If
        If txtIvaFS4.Text <> Nothing Then
            cu24 = (txtIvaFS4.Text)
        End If
        If txtIvaFS5.Text <> Nothing Then
            cu25 = (txtIvaFS5.Text)
        End If
        If txtIvaFS6.Text <> Nothing Then
            cu26 = (txtIvaFS6.Text)
        End If
        If txtIvaFS7.Text <> Nothing Then
            cu27 = (txtIvaFS7.Text)
        End If
        If txtIvaFS8.Text <> Nothing Then
            cu28 = (txtIvaFS8.Text)
        End If
        If txtIvaFS9.Text <> Nothing Then
            cu29 = (txtIvaFS9.Text)
        End If
        If txtIvaFS10.Text <> Nothing Then
            cu30 = (txtIvaFS10.Text)
        End If
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma = (cu1 + cu11)
        txtTotalFS1.Text = FormatCurrency((suma + cu21), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma2 = (cu2 + cu12)
        txtTotalFS2.Text = FormatCurrency((suma2 + cu22), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma3 = (cu3 + cu13)
        txtTotalFS3.Text = FormatCurrency((suma3 + cu23), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma4 = (cu4 + cu14)
        txtTotalFS4.Text = FormatCurrency((suma4 + cu24), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma5 = (cu5 + cu15)
        txtTotalFS5.Text = FormatCurrency((suma5 + cu25), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma6 = (cu6 + cu16)
        txtTotalFS6.Text = FormatCurrency((suma6 + cu26), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma7 = (cu7 + cu17)
        txtTotalFS7.Text = FormatCurrency((suma7 + cu27), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma8 = (cu8 + cu18)
        txtTotalFS8.Text = FormatCurrency((suma8 + cu28), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma9 = (cu9 + cu19)
        txtTotalFS9.Text = FormatCurrency((suma9 + cu29), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::..
        suma10 = (cu10 + cu20)
        txtTotalFS10.Text = FormatCurrency((suma10 + cu30), 4)
        '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    End Sub
    '-------------------------------Operaciones3-------------------------------------------

    '-------------------------------Operaciones8-------------------------------------------
    Public Sub TotalGastosGenerales_Importe() Handles txtimporte1.TextChanged, txtimporte2.TextChanged, txtimporte3.TextChanged, txtimporte4.TextChanged, txtimporte5.TextChanged,
    txtimporte6.TextChanged, txtimporte7.TextChanged, txtimporte8.TextChanged, txtimporte9.TextChanged, txtimporte10.TextChanged, textgravado1.TextChanged,
        textgravado2.TextChanged, textgravado3.TextChanged, textgravado4.TextChanged,
        textgravado5.TextChanged, textgravado6.TextChanged, textgravado7.TextChanged,
        textgravado8.TextChanged, textgravado9.TextChanged, textgravado10.TextChanged, textimporte1.TextChanged, textimporte2.TextChanged, textimporte3.TextChanged,
            textimporte4.TextChanged, textimporte5.TextChanged, textimporte6.TextChanged,
            textimporte9.TextChanged, textimporte8.TextChanged, textimporte7.TextChanged,
            textimporte10.TextChanged, txtimporteFS1.TextChanged, txtimporteFS2.TextChanged, txtimporteFS3.TextChanged,
            txtimporteFS4.TextChanged, txtimporteFS5.TextChanged, txtimporteFS6.TextChanged,
            txtimporteFS9.TextChanged, txtimporteFS8.TextChanged, txtimporteFS7.TextChanged,
            txtimporteFS10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0
        Dim cu21 As Double = 0
        Dim cu22 As Double = 0
        Dim cu23 As Double = 0
        Dim cu24 As Double = 0
        Dim cu25 As Double = 0
        Dim cu26 As Double = 0
        Dim cu27 As Double = 0
        Dim cu28 As Double = 0
        Dim cu29 As Double = 0
        Dim cu30 As Double = 0
        Dim cu31 As Double = 0
        Dim cu32 As Double = 0
        Dim cu33 As Double = 0
        Dim cu34 As Double = 0
        Dim cu35 As Double = 0
        Dim cu36 As Double = 0
        Dim cu37 As Double = 0
        Dim cu38 As Double = 0
        Dim cu39 As Double = 0
        Dim cu40 As Double = 0
        Dim resultado As Double = 0

        If txtimporte1.Text <> Nothing Then
            cu1 = (txtimporte1.Text)
        End If
        If txtimporte2.Text <> Nothing Then
            cu2 = (txtimporte2.Text)
        End If
        If txtimporte3.Text <> Nothing Then
            cu3 = (txtimporte3.Text)
        End If
        If txtimporte4.Text <> Nothing Then
            cu4 = (txtimporte4.Text)
        End If
        If txtimporte5.Text <> Nothing Then
            cu5 = (txtimporte5.Text)
        End If
        If txtimporte6.Text <> Nothing Then
            cu6 = (txtimporte6.Text)
        End If
        If txtimporte7.Text <> Nothing Then
            cu7 = (txtimporte7.Text)
        End If
        If txtimporte8.Text <> Nothing Then
            cu8 = (txtimporte8.Text)
        End If
        If txtimporte9.Text <> Nothing Then
            cu9 = (txtimporte9.Text)
        End If
        If txtimporte10.Text <> Nothing Then
            cu10 = (txtimporte10.Text)
        End If


        If textgravado1.Text <> Nothing Then
            cu11 = (textgravado1.Text)
        End If

        If textgravado2.Text <> Nothing Then
            cu12 = (textgravado2.Text)
        End If

        If textgravado3.Text <> Nothing Then
            cu13 = (textgravado3.Text)
        End If

        If textgravado4.Text <> Nothing Then
            cu14 = (textgravado4.Text)
        End If

        If textgravado5.Text <> Nothing Then
            cu15 = (textgravado5.Text)
        End If

        If textgravado6.Text <> Nothing Then
            cu16 = (textgravado6.Text)
        End If

        If textgravado7.Text <> Nothing Then
            cu17 = (textgravado7.Text)
        End If

        If textgravado8.Text <> Nothing Then
            cu18 = (textgravado8.Text)
        End If

        If textgravado9.Text <> Nothing Then
            cu19 = (textgravado9.Text)
        End If

        If textgravado10.Text <> Nothing Then
            cu20 = (textgravado10.Text)
        End If


        If textimporte1.Text <> Nothing Then
            cu21 = (textimporte1.Text)
        End If

        If textimporte2.Text <> Nothing Then
            cu22 = (textimporte2.Text)
        End If

        If textimporte3.Text <> Nothing Then
            cu23 = (textimporte3.Text)
        End If

        If textimporte4.Text <> Nothing Then
            cu24 = (textimporte4.Text)
        End If

        If textimporte5.Text <> Nothing Then
            cu25 = (textimporte5.Text)
        End If

        If textimporte6.Text <> Nothing Then
            cu26 = (textimporte6.Text)
        End If

        If textimporte7.Text <> Nothing Then
            cu27 = (textimporte7.Text)
        End If

        If textimporte8.Text <> Nothing Then
            cu28 = (textimporte8.Text)
        End If

        If textimporte9.Text <> Nothing Then
            cu29 = (textimporte9.Text)
        End If

        If textimporte10.Text <> Nothing Then
            cu30 = (textimporte10.Text)
        End If

        If txtimporteFS1.Text <> Nothing Then
            cu31 = (txtimporteFS1.Text)
        End If

        If txtimporteFS2.Text <> Nothing Then
            cu32 = (txtimporteFS2.Text)
        End If

        If txtimporteFS3.Text <> Nothing Then
            cu33 = (txtimporteFS3.Text)
        End If

        If txtimporteFS4.Text <> Nothing Then
            cu34 = (txtimporteFS4.Text)
        End If

        If txtimporteFS5.Text <> Nothing Then
            cu35 = (txtimporteFS5.Text)
        End If

        If txtimporteFS6.Text <> Nothing Then
            cu36 = (txtimporteFS6.Text)
        End If

        If txtimporteFS7.Text <> Nothing Then
            cu37 = (txtimporteFS7.Text)
        End If

        If txtimporteFS8.Text <> Nothing Then
            cu38 = (txtimporteFS8.Text)
        End If

        If txtimporteFS9.Text <> Nothing Then
            cu39 = (txtimporteFS9.Text)
        End If

        If txtimporteFS10.Text <> Nothing Then
            cu40 = (txtimporteFS10.Text)
        End If



        importeTGAG.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20 + cu21 + cu22 + cu23 + cu24 + cu25 + cu26 + cu27 + cu28 + cu29 + cu30 + cu31 + cu32 + cu33 + cu34 + cu35 + cu36 + cu37 + cu38 + cu39 + cu40), 4)


    End Sub


    '-------------------------------Operaciones9-------------------------------------------
    Public Sub TotalGastosGenerales_IVA() Handles txtIva_gastosterceros.TextChanged,
        textIva_GT2_1.TextChanged, textIva_GT2_2.TextChanged, textIva_GT2_3.TextChanged,
        textIva_GT2_4.TextChanged, textIva_GT2_5.TextChanged, textIva_GT2_6.TextChanged,
        textIva_GT2_9.TextChanged, textIva_GT2_8.TextChanged, textIva_GT2_7.TextChanged,
        textIva_GT2_10.TextChanged,
        textivaCB.TextChanged,
        txtIvaFS1.TextChanged, txtIvaFS2.TextChanged, txtIvaFS3.TextChanged, txtIvaFS4.TextChanged,
         txtIvaFS8.TextChanged, txtIvaFS7.TextChanged, txtIvaFS6.TextChanged, txtIvaFS5.TextChanged,
          txtIvaFS9.TextChanged, txtIvaFS10.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0
        Dim cu21 As Double = 0
        Dim cu22 As Double = 0

        Dim cu23 As Double = 0
        Dim cu24 As Double = 0
        Dim cu25 As Double = 0
        Dim cu26 As Double = 0
        Dim cu27 As Double = 0
        Dim cu28 As Double = 0
        Dim cu29 As Double = 0
        Dim cu30 As Double = 0
        Dim cu31 As Double = 0

        Dim resultado As Double = 0
        '---------GATOS POR TERCEROS 2
        If textIva_GT2_1.Text <> Nothing Then
            cu1 = (textIva_GT2_1.Text)
        End If

        If textIva_GT2_2.Text <> Nothing Then
            cu2 = (textIva_GT2_2.Text)
        End If

        If textIva_GT2_3.Text <> Nothing Then
            cu3 = (textIva_GT2_3.Text)
        End If

        If textIva_GT2_4.Text <> Nothing Then
            cu4 = (textIva_GT2_4.Text)
        End If

        If textIva_GT2_5.Text <> Nothing Then
            cu5 = (textIva_GT2_5.Text)
        End If

        If textIva_GT2_6.Text <> Nothing Then
            cu6 = (textIva_GT2_6.Text)
        End If

        If textIva_GT2_7.Text <> Nothing Then
            cu7 = (textIva_GT2_7.Text)
        End If

        If textIva_GT2_8.Text <> Nothing Then
            cu8 = (textIva_GT2_8.Text)
        End If

        If textIva_GT2_9.Text <> Nothing Then
            cu9 = (textIva_GT2_9.Text)
        End If

        If textIva_GT2_10.Text <> Nothing Then
            cu10 = (textIva_GT2_10.Text)
        End If

        '----------------------GASTOS TERCEROS
        If txtIva_gastosterceros.Text <> Nothing Then
            cu11 = (txtIva_gastosterceros.Text)
        End If

        If TexIvaOp1.Text <> Nothing Then
            cu23 = (TexIvaOp1.Text)
        End If
        If TexIvaOp2.Text <> Nothing Then
            cu24 = (TexIvaOp2.Text)
        End If
        If TexIvaOp3.Text <> Nothing Then
            cu25 = (TexIvaOp3.Text)
        End If
        If TexIvaOp4.Text <> Nothing Then
            cu26 = (TexIvaOp4.Text)
        End If
        If TexIvaOp5.Text <> Nothing Then
            cu27 = (TexIvaOp5.Text)
        End If
        If TexIvaOp6.Text <> Nothing Then
            cu28 = (TexIvaOp6.Text)
        End If
        If TexIvaOp7.Text <> Nothing Then
            cu29 = (TexIvaOp7.Text)
        End If
        If TexIvaOp8.Text <> Nothing Then
            cu30 = (TexIvaOp8.Text)
        End If
        If TexIvaOp9.Text <> Nothing Then
            cu31 = (TexIvaOp9.Text)
        End If




        '--------------CUSTOM BROKERAGE
        If textivaCB.Text <> Nothing Then
            cu12 = (textivaCB.Text)
        End If

        '---------FLETES Y SEGUROS

        If txtIvaFS1.Text <> Nothing Then
            cu13 = (txtIvaFS1.Text)
        End If

        If txtIvaFS2.Text <> Nothing Then
            cu14 = (txtIvaFS2.Text)
        End If

        If txtIvaFS3.Text <> Nothing Then
            cu15 = (txtIvaFS3.Text)
        End If

        If txtIvaFS4.Text <> Nothing Then
            cu16 = (txtIvaFS4.Text)
        End If

        If txtIvaFS5.Text <> Nothing Then
            cu17 = (txtIvaFS5.Text)
        End If

        If txtIvaFS6.Text <> Nothing Then
            cu18 = (txtIvaFS6.Text)
        End If

        If txtIvaFS7.Text <> Nothing Then
            cu19 = (txtIvaFS7.Text)
        End If

        If txtIvaFS8.Text <> Nothing Then
            cu20 = (txtIvaFS8.Text)
        End If

        If txtIvaFS9.Text <> Nothing Then
            cu21 = (txtIvaFS9.Text)
        End If

        If txtIvaFS10.Text <> Nothing Then
            cu22 = (txtIvaFS10.Text)
        End If
        '-----------------------------------
        ivaTGAG.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20 + cu21 + cu22 + cu23 + cu24 + cu25 + cu26 + cu27 + cu28 + cu29 + cu30 + cu31), 4)

    End Sub


    '-------------------------------Operaciones10-------------------------------------------
    Public Sub TotalGastosGenerales_Total() Handles txttotal_gastosterceros.TextChanged,
        txtTotalGT_1.TextChanged, txtTotalGT_2.TextChanged, txtTotalGT_3.TextChanged, txtTotalGT_4.TextChanged, txtTotalGT_5.TextChanged,
        txtTotalGT_10.TextChanged, txtTotalGT_9.TextChanged, txtTotalGT_8.TextChanged, txtTotalGT_7.TextChanged, txtTotalGT_6.TextChanged,
        texttotalCB.TextChanged,
        txtTotalFS1.TextChanged, txtTotalFS2.TextChanged, txtTotalFS3.TextChanged, txtTotalFS4.TextChanged, txtTotalFS5.TextChanged,
        txtTotalFS10.TextChanged, txtTotalFS9.TextChanged, txtTotalFS8.TextChanged, txtTotalFS7.TextChanged, txtTotalFS6.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim cu3 As Double = 0
        Dim cu4 As Double = 0
        Dim cu5 As Double = 0
        Dim cu6 As Double = 0
        Dim cu7 As Double = 0
        Dim cu8 As Double = 0
        Dim cu9 As Double = 0
        Dim cu10 As Double = 0
        Dim cu11 As Double = 0
        Dim cu12 As Double = 0
        Dim cu13 As Double = 0
        Dim cu14 As Double = 0
        Dim cu15 As Double = 0
        Dim cu16 As Double = 0
        Dim cu17 As Double = 0
        Dim cu18 As Double = 0
        Dim cu19 As Double = 0
        Dim cu20 As Double = 0
        Dim cu21 As Double = 0
        Dim cu22 As Double = 0

        Dim resultado As Double = 0

        If txttotal_gastosterceros.Text <> Nothing Then
            cu1 = (txttotal_gastosterceros.Text)
        End If
        If txtTotalGT_1.Text <> Nothing Then
            cu2 = (txtTotalGT_1.Text)
        End If
        If txtTotalGT_2.Text <> Nothing Then
            cu3 = (txtTotalGT_2.Text)
        End If
        If txtTotalGT_3.Text <> Nothing Then
            cu4 = (txtTotalGT_3.Text)
        End If
        If txtTotalGT_4.Text <> Nothing Then
            cu5 = (txtTotalGT_4.Text)
        End If
        If txtTotalGT_5.Text <> Nothing Then
            cu6 = (txtTotalGT_5.Text)
        End If
        If txtTotalGT_6.Text <> Nothing Then
            cu7 = (txtTotalGT_6.Text)
        End If
        If txtTotalGT_7.Text <> Nothing Then
            cu8 = (txtTotalGT_7.Text)
        End If
        If txtTotalGT_8.Text <> Nothing Then
            cu9 = (txtTotalGT_8.Text)
        End If
        If txtTotalGT_9.Text <> Nothing Then
            cu10 = (txtTotalGT_9.Text)
        End If

        If txtTotalGT_10.Text <> Nothing Then
            cu11 = (txtTotalGT_10.Text)
        End If



        If txtTotalFS1.Text <> Nothing Then
            cu12 = (txtTotalFS1.Text)
        End If

        If txtTotalFS2.Text <> Nothing Then
            cu13 = (txtTotalFS2.Text)
        End If

        If txtTotalFS3.Text <> Nothing Then
            cu14 = (txtTotalFS3.Text)
        End If

        If txtTotalFS4.Text <> Nothing Then
            cu15 = (txtTotalFS4.Text)
        End If

        If txtTotalFS5.Text <> Nothing Then
            cu16 = (txtTotalFS5.Text)
        End If

        If txtTotalFS6.Text <> Nothing Then
            cu17 = (txtTotalFS6.Text)
        End If

        If txtTotalFS7.Text <> Nothing Then
            cu18 = (txtTotalFS7.Text)
        End If

        If txtTotalFS8.Text <> Nothing Then
            cu19 = (txtTotalFS8.Text)
        End If

        If txtTotalFS9.Text <> Nothing Then
            cu20 = (txtTotalFS9.Text)
        End If


        If txtTotalFS10.Text <> Nothing Then
            cu21 = (txtTotalFS10.Text)
        End If

        If texttotalCB.Text <> Nothing Then
            cu22 = (texttotalCB.Text)
        End If



        TotalTGAG.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20 + cu21 + cu22), 4)


    End Sub

    '-------------------------------Operaciones11-------------------------------------------
    Public Sub Importe_ResumenCostos() Handles txtTotal.TextChanged

        Dim cu1 As Double = 0

        If txtTotal.Text <> Nothing Then
            cu1 = (txtTotal.Text)
        End If

        importeRC.Text = FormatCurrency((cu1), 4)

    End Sub

    '-------------------------------Operaciones12-------------------------------------------
    Public Sub peso_ResumenCostos() Handles txtpesobruto.TextChanged

        Dim cu1 As Double = 0

        If txtpesobruto.Text <> Nothing Then
            cu1 = (txtpesobruto.Text)
        End If

        pesoRC.Text = FormatCurrency((cu1), 4)

    End Sub

    '-------------------------------Operaciones13-------------------------------------------
    Public Sub costo_ResumenCostos() Handles importeRC.TextChanged, pesoRC.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If importeRC.Text <> Nothing Then
            cu1 = (importeRC.Text)
        End If

        If pesoRC.Text <> Nothing Then
            cu2 = (pesoRC.Text)
        End If


        costoRC.Text = FormatCurrency((cu1 / cu2), 4)
    End Sub

    '-------------------------------Operaciones14-------------------------------------------
    Public Sub TC_ResumenCostos() Handles txttipocambio.TextChanged

        Dim cu1 As Double = 0

        If txttipocambio.Text <> Nothing Then
            cu1 = (txttipocambio.Text)
        End If

        tcRC.Text = FormatCurrency((cu1), 4)

    End Sub

    '-------------------------------Operaciones15-------------------------------------------
    Public Sub Mxn1_ResumenCostos() Handles importeRC.TextChanged, tcRC.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If importeRC.Text <> Nothing Then
            cu1 = (importeRC.Text)
        End If

        If tcRC.Text <> Nothing Then
            cu2 = (tcRC.Text)
        End If

        mxn1RC.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    '-------------------------------Operaciones16-------------------------------------------
    Public Sub Mxn2_ResumenCostos() Handles costoRC.TextChanged, tcRC.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If costoRC.Text <> Nothing Then
            cu1 = (costoRC.Text)
        End If

        If tcRC.Text <> Nothing Then
            cu2 = (tcRC.Text)
        End If

        mxn2RC.Text = FormatCurrency((cu1 * cu2), 4)

    End Sub

    '-------------------------------Operaciones17-------------------------------------------
    Public Sub OtrosGastos_Final() Handles importeTGAG.TextChanged, pesoRC.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If importeTGAG.Text <> Nothing Then
            cu1 = (importeTGAG.Text)
        End If

        If pesoRC.Text <> Nothing Then
            cu2 = (pesoRC.Text)
        End If

        otrosgastos.Text = FormatCurrency((cu1 / cu2), 4)

    End Sub

    '-------------------------------Operaciones17-------------------------------------------
    Public Sub Total_Final1() Handles mxn1RC.TextChanged, importeTGAG.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If mxn1RC.Text <> Nothing Then
            cu1 = (mxn1RC.Text)
        End If

        If importeTGAG.Text <> Nothing Then
            cu2 = (importeTGAG.Text)
        End If

        importeCT.Text = FormatCurrency((cu1 + cu2), 4)

    End Sub



    '-------------------------------Operaciones17-------------------------------------------
    Public Sub Total_Final2() Handles mxn2RC.TextChanged, otrosgastos.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0

        If mxn2RC.Text <> Nothing Then
            cu1 = (mxn2RC.Text)
        End If

        If otrosgastos.Text <> Nothing Then
            cu2 = (otrosgastos.Text)
        End If

        ivaCT.Text = FormatCurrency((cu1 + cu2), 4)

    End Sub


    Public Sub correccion() Handles txtppagado.TextChanged

        Dim cu1 As Double = 0
        If txtppagado.Text <> Nothing Then
            cu1 = (txtppagado.Text)
        End If

        txtTotal.Text = FormatCurrency((cu1), 4)

    End Sub


    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click
        RegistrosPedimentos.Show()
    End Sub


    '----------------------------------------------------------------------------------------
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal com As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(com.KeyChar) Then
            com.Handled = False
        ElseIf Char.IsControl(com.KeyChar) Then
            com.Handled = False
        ElseIf com.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            com.Handled = True
        ElseIf com.KeyChar = "." Then
            com.Handled = False
        Else
            com.Handled = True
            MsgBox("Solo se puede ingresar numeros y punto", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    '-----------------------------------------------------------------------------------------

    Private Sub txttipocambio_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txttipocambio.KeyPress
        NumerosyDecimal(txttipocambio, com)
    End Sub
    Private Sub TxtCantidad_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        NumerosyDecimal(TxtCantidad, com)
    End Sub
    Private Sub txtppagado_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtppagado.KeyPress
        NumerosyDecimal(txtppagado, com)
    End Sub
    Private Sub txtpesobruto_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtpesobruto.KeyPress
        NumerosyDecimal(txtpesobruto, com)
    End Sub
    Private Sub txtTotal_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTotal.KeyPress
        NumerosyDecimal(txtTotal, com)
    End Sub
    Private Sub txtcantidadt_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtcantidadt.KeyPress
        NumerosyDecimal(txtcantidadt, com)
    End Sub
    Private Sub txtimporte1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte1.KeyPress
        NumerosyDecimal(txtimporte1, com)
    End Sub
    Private Sub txtimporte2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte2.KeyPress
        NumerosyDecimal(txtimporte2, com)
    End Sub
    Private Sub txtimporte3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte3.KeyPress
        NumerosyDecimal(txtimporte3, com)
    End Sub
    Private Sub txtimporte4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte4.KeyPress
        NumerosyDecimal(txtimporte4, com)
    End Sub
    Private Sub txtimporte5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte5.KeyPress
        NumerosyDecimal(txtimporte5, com)
    End Sub
    Private Sub txtimporte6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte6.KeyPress
        NumerosyDecimal(txtimporte6, com)
    End Sub
    Private Sub txtimporte7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte7.KeyPress
        NumerosyDecimal(txtimporte7, com)
    End Sub
    Private Sub txtimporte8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte8.KeyPress
        NumerosyDecimal(txtimporte8, com)
    End Sub
    Private Sub txtimporte9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte9.KeyPress
        NumerosyDecimal(txtimporte9, com)
    End Sub
    Private Sub txtimporte10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporte10.KeyPress
        NumerosyDecimal(txtimporte10, com)
    End Sub
    '-------------------------------EXENTO
    Private Sub txtexento1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento1.KeyPress
        NumerosyDecimal(txtexento1, com)
    End Sub
    Private Sub txtexento2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento2.KeyPress
        NumerosyDecimal(txtexento2, com)
    End Sub
    Private Sub txtexento3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento3.KeyPress
        NumerosyDecimal(txtexento3, com)
    End Sub
    Private Sub txtexento4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento4.KeyPress
        NumerosyDecimal(txtexento4, com)
    End Sub
    Private Sub txtexento5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento5.KeyPress
        NumerosyDecimal(txtexento5, com)
    End Sub
    Private Sub txtexento6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento6.KeyPress
        NumerosyDecimal(txtexento6, com)
    End Sub
    Private Sub txtexento7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento7.KeyPress
        NumerosyDecimal(txtexento7, com)
    End Sub
    Private Sub txtexento8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento8.KeyPress
        NumerosyDecimal(txtexento8, com)
    End Sub
    Private Sub txtexento9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento9.KeyPress
        NumerosyDecimal(txtexento9, com)
    End Sub
    Private Sub txtexento10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtexento10.KeyPress
        NumerosyDecimal(txtexento10, com)
    End Sub
    '----------------------------gRAVADO
    Private Sub textgravado1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado1.KeyPress
        NumerosyDecimal(textgravado1, com)
    End Sub
    Private Sub textgravado2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado2.KeyPress
        NumerosyDecimal(textgravado2, com)
    End Sub
    Private Sub textgravado3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado3.KeyPress
        NumerosyDecimal(textgravado3, com)
    End Sub
    Private Sub textgravado4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado4.KeyPress
        NumerosyDecimal(textgravado4, com)
    End Sub
    Private Sub textgravado5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado5.KeyPress
        NumerosyDecimal(textgravado5, com)
    End Sub
    Private Sub textgravado6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado6.KeyPress
        NumerosyDecimal(textgravado6, com)
    End Sub
    Private Sub textgravado7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado7.KeyPress
        NumerosyDecimal(textgravado7, com)
    End Sub
    Private Sub textgravado8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado8.KeyPress
        NumerosyDecimal(textgravado8, com)
    End Sub
    Private Sub textgravado9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado9.KeyPress
        NumerosyDecimal(textgravado9, com)
    End Sub
    Private Sub textgravado10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textgravado10.KeyPress
        NumerosyDecimal(textgravado10, com)
    End Sub
    '---------------------------------------------IMPORTES
    Private Sub textimporte1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte1.KeyPress
        NumerosyDecimal(textimporte1, com)
    End Sub
    Private Sub textimporte2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte2.KeyPress
        NumerosyDecimal(textimporte2, com)
    End Sub
    Private Sub textimporte3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte3.KeyPress
        NumerosyDecimal(textimporte3, com)
    End Sub
    Private Sub textimporte4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte4.KeyPress
        NumerosyDecimal(textimporte4, com)
    End Sub
    Private Sub textimporte5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte5.KeyPress
        NumerosyDecimal(textimporte5, com)
    End Sub
    Private Sub textimporte6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte6.KeyPress
        NumerosyDecimal(textimporte6, com)
    End Sub
    Private Sub textimporte7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte7.KeyPress
        NumerosyDecimal(textimporte7, com)
    End Sub
    Private Sub textimporte8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte8.KeyPress
        NumerosyDecimal(textimporte8, com)
    End Sub
    Private Sub textimporte9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte9.KeyPress
        NumerosyDecimal(textimporte9, com)
    End Sub
    Private Sub textimporte10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles textimporte10.KeyPress
        NumerosyDecimal(textimporte10, com)
    End Sub
    '---------------------------------IMPORTE
    Private Sub txtimporteFS1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS1.KeyPress
        NumerosyDecimal(txtimporteFS1, com)
    End Sub
    Private Sub txtimporteFS2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS2.KeyPress
        NumerosyDecimal(txtimporteFS2, com)
    End Sub
    Private Sub txtimporteFS3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS3.KeyPress
        NumerosyDecimal(txtimporteFS3, com)
    End Sub
    Private Sub txtimporteFS4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS4.KeyPress
        NumerosyDecimal(txtimporteFS4, com)
    End Sub
    Private Sub txtimporteFS5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS5.KeyPress
        NumerosyDecimal(txtimporteFS5, com)
    End Sub
    Private Sub txtimporteFS6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS6.KeyPress
        NumerosyDecimal(txtimporteFS6, com)
    End Sub
    Private Sub txtimporteFS7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS7.KeyPress
        NumerosyDecimal(txtimporteFS7, com)
    End Sub
    Private Sub txtimporteFS8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS8.KeyPress
        NumerosyDecimal(txtimporteFS8, com)
    End Sub
    Private Sub txtimporteFS9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS9.KeyPress
        NumerosyDecimal(txtimporteFS9, com)
    End Sub

    Private Sub txtimporteFS10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtimporteFS10.KeyPress
        NumerosyDecimal(txtimporteFS10, com)
    End Sub

    Private Sub sumaimportebokerage(sender As Object, e As EventArgs) Handles textimporte9.TextChanged, textimporte8.TextChanged, textimporte7.TextChanged, textimporte6.TextChanged, textimporte5.TextChanged, textimporte4.TextChanged, textimporte3.TextChanged, textimporte2.TextChanged, textimporte10.TextChanged, textimporte1.TextChanged

    End Sub



    Private Sub btn_clean_Click(sender As Object, e As EventArgs) Handles btn_clean.Click
        'limpiamos las cajas de texto al dar clic ala celda-------------------------------
        '----------------------------limpiar Cajas ---------------------------------
        textprove.Clear()
        TexOrdenC.Clear()
        txtCove.Clear()
        TxtCantidad.Clear()
        txtUnidad.Clear()
        txtppagado.Clear()
        txtTotal.Clear()
        txtValorAduana.Clear()
        txtCodigoPedimento.Clear()
        txtCodigoPedimento1.Clear()
        txtclave.Clear()
        txtAduana.Clear()
        txttipocambio.Clear()
        txtpesobruto.Clear()
        txttipoo.Clear()
        txtcantidadt.Clear()
        txtIva_gastosterceros.Clear()
        txttotal_gastosterceros.Clear()
        textivaCB.Clear()
        texttotalCB.Clear()
        importeTGAG.Clear()
        ivaTGAG.Clear()
        TotalTGAG.Clear()
        importeRC.Clear()
        pesoRC.Clear()
        costoRC.Clear()
        tcRC.Clear()
        mxn1RC.Clear()
        mxn2RC.Clear()
        otrosgastos.Clear()
        importeCT.Clear()
        ivaCT.Clear()
        txtMercancia1.Clear()
        txtfraccion1.Clear()
        Textid1_1.Clear()
        txtMercancia2.Clear()
        txtfraccion2.Clear()
        Textid1_2.Clear()
        txtMercancia3.Clear()
        txtfraccion3.Clear()
        Textid1_3.Clear()
        txtMercancia4.Clear()
        txtfraccion4.Clear()
        Textid1_4.Clear()
        txtMercancia5.Clear()
        txtfraccion5.Clear()
        Textid1_5.Clear()
        txtMercancia6.Clear()
        txtfraccion6.Clear()
        Textid1_6.Clear()
        txtMercancia7.Clear()
        txtfraccion7.Clear()
        Textid1_7.Clear()
        txtMercancia8.Clear()
        txtfraccion8.Clear()
        Textid1_8.Clear()
        txtMercancia9.Clear()
        txtfraccion9.Clear()
        Textid1_9.Clear()
        txtMercancia10.Clear()
        txtfraccion10.Clear()
        Textid1_10.Clear()
        Generarcodigo()
        '--------------------gastos terceros 1----------------------------------------
        'txtcodigo1.Clear()
        'txtdescripcion1.Clear()
        txtimporte1.Clear()
        txtcodigo2.Clear()
        txtdescripcion2.Clear()
        txtimporte2.Clear()
        txtcodigo3.Clear()
        txtdescripcion3.Clear()
        txtimporte3.Clear()
        txtcodigo4.Clear()
        txtdescripcion4.Clear()
        txtimporte4.Clear()
        txtcodigo5.Clear()
        txtdescripcion5.Clear()
        txtimporte5.Clear()
        txtcodigo6.Clear()
        txtdescripcion6.Clear()
        txtimporte6.Clear()
        txtcodigo7.Clear()
        txtdescripcion7.Clear()
        txtimporte7.Clear()
        txtcodigo8.Clear()
        txtdescripcion8.Clear()
        txtimporte8.Clear()
        txtcodigo9.Clear()
        txtdescripcion9.Clear()
        txtimporte9.Clear()
        txtcodigo10.Clear()
        txtdescripcion10.Clear()
        txtimporte10.Clear()
        iVACheck1.Checked = False
        iVACheck2.Checked = False
        iVACheck3.Checked = False
        iVACheck4.Checked = False
        iVACheck5.Checked = False
        iVACheck6.Checked = False
        iVACheck7.Checked = False
        iVACheck8.Checked = False
        iVACheck9.Checked = False
        ' ------------------------------------------------------------
        '----------------GASTOS POR TERCEROS 2----------------------------------------------
        txtdesc1.Clear()
        txtconcepto1.Clear()
        txtexento1.Clear()
        textgravado1.Clear()
        textIva_GT2_1.Clear()
        txtTotalGT_1.Clear()
        txtdesc2.Clear()
        txtconcepto2.Clear()
        txtexento2.Clear()
        textgravado2.Clear()
        textIva_GT2_2.Clear()
        txtTotalGT_2.Clear()
        txtdesc3.Clear()
        txtconcepto3.Clear()
        txtexento3.Clear()
        textgravado3.Clear()
        textIva_GT2_3.Clear()
        txtTotalGT_3.Clear()
        txtdesc4.Clear()
        txtconcepto4.Clear()
        txtexento4.Clear()
        textgravado4.Clear()
        textIva_GT2_4.Clear()
        txtTotalGT_4.Clear()
        txtdesc5.Clear()
        txtconcepto5.Clear()
        txtexento5.Clear()
        textgravado5.Clear()
        textIva_GT2_5.Clear()
        txtTotalGT_5.Clear()
        txtdesc6.Clear()
        txtconcepto6.Clear()
        txtexento6.Clear()
        textgravado6.Clear()
        textIva_GT2_6.Clear()
        txtTotalGT_6.Clear()
        txtdesc7.Clear()
        txtconcepto7.Clear()
        txtexento7.Clear()
        textgravado7.Clear()
        textIva_GT2_7.Clear()
        txtTotalGT_7.Clear()
        txtdesc8.Clear()
        txtconcepto8.Clear()
        txtexento8.Clear()
        textgravado8.Clear()
        textIva_GT2_8.Clear()
        txtTotalGT_8.Clear()
        txtdesc9.Clear()
        txtconcepto9.Clear()
        txtexento9.Clear()
        textgravado9.Clear()
        textIva_GT2_9.Clear()
        txtTotalGT_9.Clear()
        txtdesc10.Clear()
        txtconcepto10.Clear()
        txtexento10.Clear()
        textgravado10.Clear()
        textIva_GT2_10.Clear()
        txtTotalGT_10.Clear()
        ''------------------------------------------------------------------------
        ''------------------------------Custom Brokerage--------------------------
        textDescripcion1.Clear()
        textimporte1.Clear()
        textDescripcion2.Clear()
        textimporte2.Clear()
        textDescripcion3.Clear()
        textimporte3.Clear()
        textDescripcion4.Clear()
        textimporte4.Clear()
        textDescripcion5.Clear()
        textimporte5.Clear()
        textDescripcion6.Clear()
        textimporte6.Clear()
        textDescripcion7.Clear()
        textimporte7.Clear()
        textDescripcion8.Clear()
        textimporte8.Clear()
        textDescripcion9.Clear()
        textimporte9.Clear()
        textDescripcion10.Clear()
        textimporte10.Clear()
        '------------------------------Fletes y seguros------------------------------------------
        textdescripFS1.Clear()
        txtimporteFS1.Clear()
        txtIvaFS1.Clear()
        txtTotalFS1.Clear()
        textdescripFS2.Clear()
        txtimporteFS2.Clear()
        txtIvaFS2.Clear()
        txtTotalFS2.Clear()
        textdescripFS3.Clear()
        txtimporteFS3.Clear()
        txtIvaFS3.Clear()
        txtTotalFS3.Clear()
        textdescripFS4.Clear()
        txtimporteFS4.Clear()
        txtIvaFS4.Clear()
        txtTotalFS4.Clear()
        textdescripFS5.Clear()
        txtimporteFS5.Clear()
        txtIvaFS5.Clear()
        txtTotalFS5.Clear()
        textdescripFS6.Clear()
        txtimporteFS6.Clear()
        txtIvaFS6.Clear()
        txtTotalFS6.Clear()
        textdescripFS7.Clear()
        txtimporteFS7.Clear()
        txtIvaFS7.Clear()
        txtTotalFS7.Clear()
        textdescripFS8.Clear()
        txtimporteFS8.Clear()
        txtIvaFS8.Clear()
        txtTotalFS8.Clear()
        textdescripFS9.Clear()
        txtimporteFS9.Clear()
        txtIvaFS9.Clear()
        txtTotalFS9.Clear()
        textdescripFS10.Clear()
        txtimporteFS10.Clear()
        txtIvaFS10.Clear()
        txtTotalFS10.Clear()

        txtTCFlete1.Clear()
        TextUSDFLE1.Clear()
        txtRetenciones1.Clear()
        retencionCheck1.Checked = False

        txtTCFlete2.Clear()
        TextUSDFLE2.Clear()
        txtRetenciones2.Clear()
        retencionCheck2.Checked = False

        txtTCFlete3.Clear()
        TextUSDFLE3.Clear()
        txtRetenciones3.Clear()
        retencionCheck3.Checked = False

        txtTCFlete4.Clear()
        TextUSDFLE4.Clear()
        txtRetenciones4.Clear()
        retencionCheck4.Checked = False

        txtTCFlete5.Clear()
        TextUSDFLE5.Clear()
        txtRetenciones5.Clear()
        retencionCheck5.Checked = False

        txtTCFlete6.Clear()
        TextUSDFLE6.Clear()
        txtRetenciones6.Clear()
        retencionCheck6.Checked = False

        txtTCFlete7.Clear()
        TextUSDFLE7.Clear()
        txtRetenciones7.Clear()
        retencionCheck7.Checked = False

        txtTCFlete8.Clear()
        TextUSDFLE8.Clear()
        txtRetenciones8.Clear()
        retencionCheck8.Checked = False

        txtTCFlete9.Clear()
        TextUSDFLE9.Clear()
        txtRetenciones9.Clear()
        retencionCheck9.Checked = False

        txtTCFlete10.Clear()
        TextUSDFLE10.Clear()
        txtRetenciones10.Clear()
        retencionCheck10.Checked = False

        BtnGuardarFac.Enabled = True

    End Sub

    Private Sub TotalGastosGenerales_Total(sender As Object, e As EventArgs) Handles txtTotalGT_9.TextChanged, txtTotalGT_8.TextChanged, txtTotalGT_7.TextChanged, txtTotalGT_6.TextChanged, txtTotalGT_5.TextChanged, txtTotalGT_4.TextChanged, txtTotalGT_3.TextChanged, txtTotalGT_2.TextChanged, txtTotalGT_10.TextChanged, txtTotalGT_1.TextChanged, txtTotalFS9.TextChanged, txtTotalFS8.TextChanged, txtTotalFS7.TextChanged, txtTotalFS6.TextChanged, txtTotalFS5.TextChanged, txtTotalFS4.TextChanged, txtTotalFS3.TextChanged, txtTotalFS2.TextChanged, txtTotalFS10.TextChanged, txtTotalFS1.TextChanged, txttotal_gastosterceros.TextChanged, texttotalCB.TextChanged

    End Sub



    '---------------Modificar Pedimentos
    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Modificar el " + txtCodigoPedimento1.Text, "Modificar Pedimentos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassPedimentos

                logica.Peid_provedor = Me.textprove.Text
                logica.Peorden_comprao = Me.TexOrdenC.Text
                logica.Peid_factura = Me.ComboFactura.Text
                logica.Pecove = Me.txtCove.Text
                logica.Pefecha = Me.DateTimeFecha.Value
                logica.Pecantidad = Me.TxtCantidad.Text
                logica.Peunidad = Me.txtUnidad.Text
                logica.PeprecioP = Me.txtppagado.Text
                logica.Petotal = Me.txtTotal.Text
                logica.Pevalor_Aduana = Me.txtValorAduana.Text
                logica.Pepedimento = Me.txtCodigoPedimento1.Text

                logica.Pecodigo_pedimento = Me.txtCodigoPedimento.Text

                logica.Peclave = Me.txtclave.Text
                logica.Peaduana = Me.txtAduana.Text
                logica.Petipo_cambio = Me.txttipocambio.Text
                logica.Pepeso_bruto = Me.txtpesobruto.Text
                logica.Petipo = Me.txttipoo.Text
                logica.Pet_cantidad = Me.txtcantidadt.Text
                logica.Peiva_RG_terceros1 = Me.txtIva_gastosterceros.Text
                logica.Petotal_RG_terceros1 = Me.txttotal_gastosterceros.Text
                logica.Peiva_custombokerage = Me.textivaCB.Text
                logica.Petotal_custombokerage = Me.texttotalCB.Text

                logica.PeimporteTGAG = Me.importeTGAG.Text
                logica.PeivaTGAG = Me.ivaTGAG.Text
                logica.PeTotalTGAG = Me.TotalTGAG.Text
                logica.PeimporteRC = Me.importeRC.Text
                logica.PepesoRC = Me.pesoRC.Text
                logica.PecostoRC = Me.costoRC.Text
                logica.PetcRC = Me.tcRC.Text
                logica.Pemxn1RC = Me.mxn1RC.Text
                logica.Pemxn2RC = Me.mxn2RC.Text
                logica.Peotrosgastos = Me.otrosgastos.Text
                logica.PeimporteCT = Me.importeCT.Text
                logica.PeivaCT = Me.ivaCT.Text

                logica.Peidpedimento = Me.TextIDPEdimento.Text

                If funciones.FN_ModificarPedimentos(logica) Then
                    MsgBox("Pedimento Modificado Correctamente", MessageBoxIcon.Information)
                    Generarcodigo()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---------------------------------------Modificacion de Mercancia------------------------------------------------
            '---------------------------------------registro 1------------------------------------------------
            If (TextNum1.Text = "" Or txtMercancia1.Text = "" Or txtfraccion1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia1.Text
                    mercancia.Merc_fraccion = Me.txtfraccion1.Text
                    mercancia.Merc_id_productos = Me.Textid1_1.Text


                    If funciones.FN_ModificarMercancias(mercancia) Then
                        ' MsgBox("mercancia 1 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------

            txtMercancia1.Clear()
            txtfraccion1.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 2------------------------------------------------
            If (TextNum2.Text = "" Or txtMercancia2.Text = "" Or txtfraccion2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia2.Text
                    mercancia.Merc_fraccion = Me.txtfraccion2.Text
                    mercancia.Merc_id_productos = Me.Textid1_2.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 2 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia2.Clear()
            txtfraccion2.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 3------------------------------------------------
            If (TextNum3.Text = "" Or txtMercancia3.Text = "" Or txtfraccion3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia3.Text
                    mercancia.Merc_fraccion = Me.txtfraccion3.Text
                    mercancia.Merc_id_productos = Me.Textid1_3.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 3  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia3.Clear()
            txtfraccion3.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 4------------------------------------------------
            If (TextNum4.Text = "" Or txtMercancia4.Text = "" Or txtfraccion4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia4.Text
                    mercancia.Merc_fraccion = Me.txtfraccion4.Text
                    mercancia.Merc_id_productos = Me.Textid1_4.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 4  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia4.Clear()
            txtfraccion4.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 5------------------------------------------------
            If (TextNum5.Text = "" Or txtMercancia5.Text = "" Or txtfraccion5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia5.Text
                    mercancia.Merc_fraccion = Me.txtfraccion5.Text
                    mercancia.Merc_id_productos = Me.Textid1_5.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 5 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia5.Clear()
            txtfraccion5.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 6------------------------------------------------
            If (TextNum6.Text = "" Or txtMercancia6.Text = "" Or txtfraccion6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia6.Text
                    mercancia.Merc_fraccion = Me.txtfraccion6.Text
                    mercancia.Merc_id_productos = Me.Textid1_6.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 6  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia6.Clear()
            txtfraccion6.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 7------------------------------------------------
            If (TextNum7.Text = "" Or txtMercancia7.Text = "" Or txtfraccion7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia7.Text
                    mercancia.Merc_fraccion = Me.txtfraccion7.Text
                    mercancia.Merc_id_productos = Me.Textid1_7.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 7  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia7.Clear()
            txtfraccion7.Clear()
            '-------------<<<<<>>>-----

            '---------------------------------------registro 8------------------------------------------------
            If (TextNum8.Text = "" Or txtMercancia8.Text = "" Or txtfraccion8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia8.Text
                    mercancia.Merc_fraccion = Me.txtfraccion8.Text
                    mercancia.Merc_id_productos = Me.Textid1_8.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 8  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia8.Clear()
            txtfraccion8.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 9------------------------------------------------
            If (TextNum9.Text = "" Or txtMercancia9.Text = "" Or txtfraccion9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia9.Text
                    mercancia.Merc_fraccion = Me.txtfraccion9.Text
                    mercancia.Merc_id_productos = Me.Textid1_9.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 9  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia9.Clear()
            txtfraccion9.Clear()
            '-------------<<<<<>>>-----
            '---------------------------------------registro 10------------------------------------------------
            If (TextNum10.Text = "" Or txtMercancia10.Text = "" Or txtfraccion10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim mercancia As New ClassPedimentosMercancias

                    mercancia.Merc_pedimento = Me.txtCodigoPedimento1.Text
                    mercancia.Merc_mercancia = Me.txtMercancia10.Text
                    mercancia.Merc_fraccion = Me.txtfraccion10.Text
                    mercancia.Merc_id_productos = Me.Textid1_10.Text

                    If funciones.FN_ModificarMercancias(mercancia) Then
                        'MsgBox("mercancia 10 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtMercancia10.Clear()
            txtfraccion10.Clear()
            '-------------<<<<<>>>----

            '----------------------------------------------------------------------------------
            '<<<<<<<<<<<<<<<<<<<<<<<<<gastos terceros 1
            '------------------------Relacion de gastos por terceros-------------------------------------------------------------------------
            '------------------------Registro 1-------------------------------------------------------------------------
            If (txtcodigo1.Text = "" Or txtdescripcion1.Text = "" Or txtimporte1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo1.Text
                    gastos.GT_descripcion = Me.txtdescripcion1.Text
                    gastos.GT_importe = Me.txtimporte1.Text
                    gastos.GT_idgastos1 = Me.Textid2_1.Text
                    gastos.GT_iva = Me.txtIva_gastosterceros.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos1 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo1.Clear()
            txtdescripcion1.Clear()
            txtimporte1.Clear()
            '-------------<<<<<>>>-------

            '------------------------Registro 2-------------------------------------------------------------------------
            If (txtcodigo2.Text = "" Or txtdescripcion2.Text = "" Or txtimporte2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo2.Text
                    gastos.GT_descripcion = Me.txtdescripcion2.Text
                    gastos.GT_importe = Me.txtimporte2.Text
                    gastos.GT_idgastos1 = Me.Textid2_2.Text
                    gastos.GT_iva = Me.TexIvaOp1.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos2 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo2.Clear()
            txtdescripcion2.Clear()
            txtimporte2.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 3 -------------------------------------------------------------------------
            If (txtcodigo3.Text = "" Or txtdescripcion3.Text = "" Or txtimporte3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo3.Text
                    gastos.GT_descripcion = Me.txtdescripcion3.Text
                    gastos.GT_importe = Me.txtimporte3.Text
                    gastos.GT_idgastos1 = Me.Textid2_3.Text
                    gastos.GT_iva = Me.TexIvaOp2.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos3  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo3.Clear()
            txtdescripcion3.Clear()
            txtimporte3.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 4-------------------------------------------------------------------------
            If (txtcodigo4.Text = "" Or txtdescripcion4.Text = "" Or txtimporte4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo4.Text
                    gastos.GT_descripcion = Me.txtdescripcion4.Text
                    gastos.GT_importe = Me.txtimporte4.Text
                    gastos.GT_idgastos1 = Me.Textid2_4.Text
                    gastos.GT_iva = Me.TexIvaOp3.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        ' MsgBox("gastos4  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo4.Clear()
            txtdescripcion4.Clear()
            txtimporte4.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 5-------------------------------------------------------------------------
            If (txtcodigo5.Text = "" Or txtdescripcion5.Text = "" Or txtimporte5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo5.Text
                    gastos.GT_descripcion = Me.txtdescripcion5.Text
                    gastos.GT_importe = Me.txtimporte5.Text
                    gastos.GT_idgastos1 = Me.Textid2_5.Text
                    gastos.GT_iva = Me.TexIvaOp4.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos5 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo5.Clear()
            txtdescripcion5.Clear()
            txtimporte5.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 6-------------------------------------------------------------------------
            If (txtcodigo6.Text = "" Or txtdescripcion6.Text = "" Or txtimporte6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo6.Text
                    gastos.GT_descripcion = Me.txtdescripcion6.Text
                    gastos.GT_importe = Me.txtimporte6.Text
                    gastos.GT_idgastos1 = Me.Textid2_6.Text
                    gastos.GT_iva = Me.TexIvaOp5.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        ' MsgBox("gastos6  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo6.Clear()
            txtdescripcion6.Clear()
            txtimporte6.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 7-------------------------------------------------------------------------
            If (txtcodigo7.Text = "" Or txtdescripcion7.Text = "" Or txtimporte7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo7.Text
                    gastos.GT_descripcion = Me.txtdescripcion7.Text
                    gastos.GT_importe = Me.txtimporte7.Text
                    gastos.GT_idgastos1 = Me.Textid2_7.Text
                    gastos.GT_iva = Me.TexIvaOp6.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos7 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo7.Clear()
            txtdescripcion7.Clear()
            txtimporte7.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 8-------------------------------------------------------------------------
            If (txtcodigo8.Text = "" Or txtdescripcion8.Text = "" Or txtimporte8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo8.Text
                    gastos.GT_descripcion = Me.txtdescripcion8.Text
                    gastos.GT_importe = Me.txtimporte8.Text
                    gastos.GT_idgastos1 = Me.Textid2_8.Text
                    gastos.GT_iva = Me.TexIvaOp7.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        'MsgBox("gastos8 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo8.Clear()
            txtdescripcion8.Clear()
            txtimporte8.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 9-------------------------------------------------------------------------
            If (txtcodigo9.Text = "" Or txtdescripcion9.Text = "" Or txtimporte9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo9.Text
                    gastos.GT_descripcion = Me.txtdescripcion9.Text
                    gastos.GT_importe = Me.txtimporte9.Text
                    gastos.GT_idgastos1 = Me.Textid2_9.Text
                    gastos.GT_iva = Me.TexIvaOp8.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        ' MsgBox("gastos9  ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo9.Clear()
            txtdescripcion9.Clear()
            txtimporte9.Clear()
            '-------------<<<<<>>>-------
            '------------------------Registro 10-------------------------------------------------------------------------
            If (txtcodigo10.Text = "" Or txtdescripcion10.Text = "" Or txtimporte10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros1

                    gastos.GT_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT_codigo = Me.txtcodigo10.Text
                    gastos.GT_descripcion = Me.txtdescripcion10.Text
                    gastos.GT_importe = Me.txtimporte10.Text
                    gastos.GT_idgastos1 = Me.Textid2_10.Text
                    gastos.GT_iva = Me.TexIvaOp9.Text


                    If funciones.FN_ModificarGastosTerceros1(gastos) Then
                        ' MsgBox("gastos10 ok")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtcodigo10.Clear()
            txtdescripcion10.Clear()
            txtimporte10.Clear()
            '-------------<<<<<>>>-------
            '///////////////////////////////////
            '------------------------omenzamos con los gastos por terceros 2-----------------------

            '------------------------Modificacion 1 gastos terceros2-------------------------------------------------------------------------
            If (numtext1.Text = "" Or txtdesc1.Text = "" Or textgravado1.Text = "" Or textIva_GT2_1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc1.Text
                    gastos.GT2_concepto = Me.txtconcepto1.Text
                    gastos.GT2_exento = Me.txtexento1.Text
                    gastos.GT2_gravado = Me.textgravado1.Text
                    gastos.GT2_iva = Me.textIva_GT2_1.Text
                    gastos.GT2_total = Me.txtTotalGT_1.Text
                    gastos.GT2_idgastos2 = Me.Textid3_1.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc1.Clear()
            txtconcepto1.Clear()
            txtexento1.Clear()
            textgravado1.Clear()
            textIva_GT2_1.Clear()
            txtTotalGT_1.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------

            '------------------------Modificacion 1 gastos terceros2---------------------modifica2----------------------------------------------------
            If (numtext2.Text = "" Or txtdesc2.Text = "" Or textgravado2.Text = "" Or textIva_GT2_2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc2.Text
                    gastos.GT2_concepto = Me.txtconcepto2.Text
                    gastos.GT2_exento = Me.txtexento2.Text
                    gastos.GT2_gravado = Me.textgravado2.Text
                    gastos.GT2_iva = Me.textIva_GT2_2.Text
                    gastos.GT2_total = Me.txtTotalGT_2.Text
                    gastos.GT2_idgastos2 = Me.Textid3_2.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc2.Clear()
            txtconcepto2.Clear()
            txtexento2.Clear()
            textgravado2.Clear()
            textIva_GT2_2.Clear()
            txtTotalGT_2.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 2 gastos terceros2---------------------modifica3----------------------------------------------------
            If (numtext3.Text = "" Or txtdesc3.Text = "" Or textgravado3.Text = "" Or textIva_GT2_3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc3.Text
                    gastos.GT2_concepto = Me.txtconcepto3.Text
                    gastos.GT2_exento = Me.txtexento3.Text
                    gastos.GT2_gravado = Me.textgravado3.Text
                    gastos.GT2_iva = Me.textIva_GT2_3.Text
                    gastos.GT2_total = Me.txtTotalGT_3.Text
                    gastos.GT2_idgastos2 = Me.Textid3_3.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        '  MsgBox("gastos3")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc3.Clear()
            txtconcepto3.Clear()
            txtexento3.Clear()
            textgravado3.Clear()
            textIva_GT2_3.Clear()
            txtTotalGT_3.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 4 gastos terceros2--------------------------------------------------------
            If (numtext4.Text = "" Or txtdesc4.Text = "" Or textgravado4.Text = "" Or textIva_GT2_4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc4.Text
                    gastos.GT2_concepto = Me.txtconcepto4.Text
                    gastos.GT2_exento = Me.txtexento4.Text
                    gastos.GT2_gravado = Me.textgravado4.Text
                    gastos.GT2_iva = Me.textIva_GT2_4.Text
                    gastos.GT2_total = Me.txtTotalGT_4.Text
                    gastos.GT2_idgastos2 = Me.Textid3_4.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc4.Clear()
            txtconcepto4.Clear()
            txtexento4.Clear()
            textgravado4.Clear()
            textIva_GT2_4.Clear()
            txtTotalGT_4.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 5 gastos terceros2---------------------modifica2----------------------------------------------------
            If (numtext5.Text = "" Or txtdesc5.Text = "" Or textgravado5.Text = "" Or textIva_GT2_5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc5.Text
                    gastos.GT2_concepto = Me.txtconcepto5.Text
                    gastos.GT2_exento = Me.txtexento5.Text
                    gastos.GT2_gravado = Me.textgravado5.Text
                    gastos.GT2_iva = Me.textIva_GT2_5.Text
                    gastos.GT2_total = Me.txtTotalGT_5.Text
                    gastos.GT2_idgastos2 = Me.Textid3_5.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        'MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc5.Clear()
            txtconcepto5.Clear()
            txtexento5.Clear()
            textgravado5.Clear()
            textIva_GT2_5.Clear()
            txtTotalGT_5.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------

            '------------------------Modificacion 6 gastos terceros2-----------------------------------------------------------------
            If (numtext6.Text = "" Or txtdesc6.Text = "" Or textgravado6.Text = "" Or textIva_GT2_6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc6.Text
                    gastos.GT2_concepto = Me.txtconcepto6.Text
                    gastos.GT2_exento = Me.txtexento6.Text
                    gastos.GT2_gravado = Me.textgravado6.Text
                    gastos.GT2_iva = Me.textIva_GT2_6.Text
                    gastos.GT2_total = Me.txtTotalGT_6.Text
                    gastos.GT2_idgastos2 = Me.Textid3_6.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc6.Clear()
            txtconcepto6.Clear()
            txtexento6.Clear()
            textgravado6.Clear()
            textIva_GT2_6.Clear()
            txtTotalGT_6.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 7 gastos terceros2----------------------------------------------------------------
            If (numtext7.Text = "" Or txtdesc7.Text = "" Or textgravado7.Text = "" Or textIva_GT2_7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc7.Text
                    gastos.GT2_concepto = Me.txtconcepto7.Text
                    gastos.GT2_exento = Me.txtexento7.Text
                    gastos.GT2_gravado = Me.textgravado7.Text
                    gastos.GT2_iva = Me.textIva_GT2_7.Text
                    gastos.GT2_total = Me.txtTotalGT_7.Text
                    gastos.GT2_idgastos2 = Me.Textid3_7.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        'MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc7.Clear()
            txtconcepto7.Clear()
            txtexento7.Clear()
            textgravado7.Clear()
            textIva_GT2_7.Clear()
            txtTotalGT_7.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 8 gastos terceros2---------------------modifica2----------------------------------------------------
            If (numtext8.Text = "" Or txtdesc8.Text = "" Or textgravado8.Text = "" Or textIva_GT2_8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc8.Text
                    gastos.GT2_concepto = Me.txtconcepto8.Text
                    gastos.GT2_exento = Me.txtexento8.Text
                    gastos.GT2_gravado = Me.textgravado8.Text
                    gastos.GT2_iva = Me.textIva_GT2_8.Text
                    gastos.GT2_total = Me.txtTotalGT_8.Text
                    gastos.GT2_idgastos2 = Me.Textid3_8.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc8.Clear()
            txtconcepto8.Clear()
            txtexento8.Clear()
            textgravado8.Clear()
            textIva_GT2_8.Clear()
            txtTotalGT_8.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 9 gastos terceros2---------------------modifica2----------------------------------------------------
            If (numtext9.Text = "" Or txtdesc9.Text = "" Or textgravado9.Text = "" Or textIva_GT2_9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc9.Text
                    gastos.GT2_concepto = Me.txtconcepto9.Text
                    gastos.GT2_exento = Me.txtexento9.Text
                    gastos.GT2_gravado = Me.textgravado9.Text
                    gastos.GT2_iva = Me.textIva_GT2_9.Text
                    gastos.GT2_total = Me.txtTotalGT_9.Text
                    gastos.GT2_idgastos2 = Me.Textid3_9.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        ' MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc9.Clear()
            txtconcepto9.Clear()
            txtexento9.Clear()
            textgravado9.Clear()
            textIva_GT2_9.Clear()
            txtTotalGT_9.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '------------------------Modificacion 10 gastos terceros2---------------------modifica2----------------------------------------------------
            If (numtext10.Text = "" Or txtdesc10.Text = "" Or textgravado10.Text = "" Or textIva_GT2_10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassGastosTerceros2

                    gastos.GT2_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.GT2_descripcion = Me.txtdesc10.Text
                    gastos.GT2_concepto = Me.txtconcepto10.Text
                    gastos.GT2_exento = Me.txtexento10.Text
                    gastos.GT2_gravado = Me.textgravado10.Text
                    gastos.GT2_iva = Me.textIva_GT2_10.Text
                    gastos.GT2_total = Me.txtTotalGT_10.Text
                    gastos.GT2_idgastos2 = Me.Textid3_10.Text


                    If funciones.FN_ModificarGastosTerceros2(gastos) Then
                        'MsgBox("gastos2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            txtdesc10.Clear()
            txtconcepto10.Clear()
            txtexento10.Clear()
            textgravado10.Clear()
            textIva_GT2_10.Clear()
            txtTotalGT_10.Clear()
            '-------------<<<<<-------------------------------------------------------->>>-------
            '_--------------inicia Customs Brokerage--------------------------------------
            '-.----------------customs Brokerage -----------
            'modificar 1

            If (textDescripcion1.Text = "" Or textimporte1.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion1.Text
                    gastos.CB_importe = Me.textimporte1.Text
                    gastos.CB_idcustoms = Me.Textid4_1.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        'MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion1.Clear()
            textimporte1.Clear()

            If (textDescripcion2.Text = "" Or textimporte2.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion2.Text
                    gastos.CB_importe = Me.textimporte2.Text
                    gastos.CB_idcustoms = Me.Textid4_2.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion2.Clear()
            textimporte2.Clear()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion3.Text = "" Or textimporte3.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion3.Text
                    gastos.CB_importe = Me.textimporte3.Text
                    gastos.CB_idcustoms = Me.Textid4_3.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion3.Clear()
            textimporte3.Clear()

            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion4.Text = "" Or textimporte4.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion4.Text
                    gastos.CB_importe = Me.textimporte4.Text
                    gastos.CB_idcustoms = Me.Textid4_4.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        'MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion4.Clear()
            textimporte4.Clear()

            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion5.Text = "" Or textimporte5.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion5.Text
                    gastos.CB_importe = Me.textimporte5.Text
                    gastos.CB_idcustoms = Me.Textid4_5.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion5.Clear()
            textimporte5.Clear()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion6.Text = "" Or textimporte6.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion6.Text
                    gastos.CB_importe = Me.textimporte6.Text
                    gastos.CB_idcustoms = Me.Textid4_6.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        'MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion6.Clear()
            textimporte6.Clear()

            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion7.Text = "" Or textimporte7.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion7.Text
                    gastos.CB_importe = Me.textimporte7.Text
                    gastos.CB_idcustoms = Me.Textid4_7.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion7.Clear()
            textimporte7.Clear()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion8.Text = "" Or textimporte8.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion8.Text
                    gastos.CB_importe = Me.textimporte8.Text
                    gastos.CB_idcustoms = Me.Textid4_8.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion8.Clear()
            textimporte8.Clear()

            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion9.Text = "" Or textimporte9.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion9.Text
                    gastos.CB_importe = Me.textimporte9.Text
                    gastos.CB_idcustoms = Me.Textid4_9.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        'MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion9.Clear()
            textimporte9.Clear()
            '--------------------------------------------------------------------------------------------------------------------------------------------------------

            If (textDescripcion10.Text = "" Or textimporte10.Text = "" Or textivaCB.Text = "" Or texttotalCB.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassCustomsBrokerage

                    gastos.CB_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.CB_descripcion = Me.textDescripcion10.Text
                    gastos.CB_importe = Me.textimporte10.Text
                    gastos.CB_idcustoms = Me.Textid4_10.Text

                    If funciones.FN_ModificarCustomsBrokerage(gastos) Then
                        ' MsgBox("custom1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textDescripcion10.Clear()
            textimporte10.Clear()
            '////////////////////////////////////////////////////////////////777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777777
            '-------------------Scion de Fletes y Seguros Modificacion-------------------------------------------------------------
            ''modificacion1

            If (textdescripFS1.Text = "" Or txtimporteFS1.Text = "" Or txtIvaFS1.Text = "" Or txtTotalFS1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS1.Text
                    gastos.FS_importe = Me.txtimporteFS1.Text
                    gastos.FS_iva = Me.txtIvaFS1.Text
                    gastos.FS_total = Me.txtTotalFS1.Text
                    gastos.FS_idflete = Me.Textid5_1.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones1.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones1.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete1.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete1.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE1.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE1.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::


                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        'MsgBox("flete1")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS1.Clear()
            txtimporteFS1.Clear()
            txtIvaFS1.Clear()
            txtTotalFS1.Clear()
            txtRetenciones1.Clear()
            txtTCFlete1.Clear()
            TextUSDFLE1.Clear()

            '//////////////////////////////////////////////////////////////////////////////////////////////////////////

            ''modificacion2

            If (textdescripFS2.Text = "" Or txtimporteFS2.Text = "" Or txtIvaFS2.Text = "" Or txtTotalFS2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS2.Text
                    gastos.FS_importe = Me.txtimporteFS2.Text
                    gastos.FS_iva = Me.txtIvaFS2.Text
                    gastos.FS_total = Me.txtTotalFS2.Text
                    gastos.FS_idflete = Me.Textid5_2.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones2.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones2.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete2.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete2.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE2.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE2.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::

                    'gastos.FS_retenciones = Me.txtRetenciones2.Text
                    'gastos.FS_tc = Me.txtTCFlete2.Text
                    'gastos.FS_usd = Me.TextUSDFLE2.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        ' MsgBox("flete2")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS2.Clear()
            txtimporteFS2.Clear()
            txtIvaFS2.Clear()
            txtTotalFS2.Clear()
            txtRetenciones2.Clear()
            txtTCFlete2.Clear()
            TextUSDFLE2.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion3

            If (textdescripFS3.Text = "" Or txtimporteFS3.Text = "" Or txtIvaFS3.Text = "" Or txtTotalFS3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS3.Text
                    gastos.FS_importe = Me.txtimporteFS3.Text
                    gastos.FS_iva = Me.txtIvaFS3.Text
                    gastos.FS_total = Me.txtTotalFS3.Text
                    gastos.FS_idflete = Me.Textid5_3.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones3.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones3.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete3.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete3.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE3.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE3.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::

                    'gastos.FS_retenciones = Me.txtRetenciones3.Text
                    'gastos.FS_tc = Me.txtTCFlete3.Text
                    'gastos.FS_usd = Me.TextUSDFLE3.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        ' MsgBox("flete3  ")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS3.Clear()
            txtimporteFS3.Clear()
            txtIvaFS3.Clear()
            txtTotalFS3.Clear()
            txtRetenciones3.Clear()
            txtTCFlete3.Clear()
            TextUSDFLE3.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion4

            If (textdescripFS4.Text = "" Or txtimporteFS4.Text = "" Or txtIvaFS4.Text = "" Or txtTotalFS4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS4.Text
                    gastos.FS_importe = Me.txtimporteFS4.Text
                    gastos.FS_iva = Me.txtIvaFS4.Text
                    gastos.FS_total = Me.txtTotalFS4.Text
                    gastos.FS_idflete = Me.Textid5_4.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones4.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones4.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete4.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete4.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE4.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE4.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::
                    'gastos.FS_retenciones = Me.txtRetenciones4.Text
                    'gastos.FS_tc = Me.txtTCFlete4.Text
                    'gastos.FS_usd = Me.TextUSDFLE4.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        ' MsgBox("flete4  ")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS4.Clear()
            txtimporteFS4.Clear()
            txtIvaFS4.Clear()
            txtTotalFS4.Clear()
            txtRetenciones4.Clear()
            txtTCFlete4.Clear()
            TextUSDFLE4.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion1

            If (textdescripFS5.Text = "" Or txtimporteFS5.Text = "" Or txtIvaFS5.Text = "" Or txtTotalFS5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS5.Text
                    gastos.FS_importe = Me.txtimporteFS5.Text
                    gastos.FS_iva = Me.txtIvaFS5.Text
                    gastos.FS_total = Me.txtTotalFS5.Text
                    gastos.FS_idflete = Me.Textid5_5.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones5.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones5.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete5.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete5.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE5.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE5.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::
                    'gastos.FS_retenciones = Me.txtRetenciones5.Text
                    'gastos.FS_tc = Me.txtTCFlete5.Text
                    'gastos.FS_usd = Me.TextUSDFLE5.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        ' MsgBox("flete5")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS5.Clear()
            txtimporteFS5.Clear()
            txtIvaFS5.Clear()
            txtTotalFS5.Clear()
            txtRetenciones5.Clear()
            txtTCFlete5.Clear()
            TextUSDFLE5.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion6

            If (textdescripFS6.Text = "" Or txtimporteFS6.Text = "" Or txtIvaFS6.Text = "" Or txtTotalFS6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS6.Text
                    gastos.FS_importe = Me.txtimporteFS6.Text
                    gastos.FS_iva = Me.txtIvaFS6.Text
                    gastos.FS_total = Me.txtTotalFS6.Text
                    gastos.FS_idflete = Me.Textid5_6.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones6.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones6.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete6.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete6.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE6.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE6.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::
                    'gastos.FS_retenciones = Me.txtRetenciones6.Text
                    'gastos.FS_tc = Me.txtTCFlete6.Text
                    'gastos.FS_usd = Me.TextUSDFLE6.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        'MsgBox("flete6  ")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS6.Clear()
            txtimporteFS6.Clear()
            txtIvaFS6.Clear()
            txtTotalFS6.Clear()
            txtRetenciones6.Clear()
            txtTCFlete6.Clear()
            TextUSDFLE6.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion1

            If (textdescripFS7.Text = "" Or txtimporteFS7.Text = "" Or txtIvaFS7.Text = "" Or txtTotalFS7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS7.Text
                    gastos.FS_importe = Me.txtimporteFS7.Text
                    gastos.FS_iva = Me.txtIvaFS7.Text
                    gastos.FS_total = Me.txtTotalFS7.Text
                    gastos.FS_idflete = Me.Textid5_7.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones7.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones7.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete7.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete7.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE7.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE7.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::
                    'gastos.FS_retenciones = Me.txtRetenciones7.Text
                    'gastos.FS_tc = Me.txtTCFlete7.Text
                    'gastos.FS_usd = Me.TextUSDFLE7.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        'MsgBox("flete7  ")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS7.Clear()
            txtimporteFS7.Clear()
            txtIvaFS7.Clear()
            txtTotalFS7.Clear()
            txtRetenciones7.Clear()
            txtTCFlete7.Clear()
            TextUSDFLE7.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion1

            If (textdescripFS8.Text = "" Or txtimporteFS8.Text = "" Or txtIvaFS8.Text = "" Or txtTotalFS8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS8.Text
                    gastos.FS_importe = Me.txtimporteFS8.Text
                    gastos.FS_iva = Me.txtIvaFS8.Text
                    gastos.FS_total = Me.txtTotalFS8.Text
                    gastos.FS_idflete = Me.Textid5_8.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones8.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones8.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete8.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete8.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE8.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE8.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::

                    'gastos.FS_retenciones = Me.txtRetenciones8.Text
                    'gastos.FS_tc = Me.txtTCFlete8.Text
                    'gastos.FS_usd = Me.TextUSDFLE8.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        'MsgBox("flete8")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS8.Clear()
            txtimporteFS8.Clear()
            txtIvaFS8.Clear()
            txtTotalFS8.Clear()
            txtRetenciones8.Clear()
            txtTCFlete8.Clear()
            TextUSDFLE8.Clear()
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion9

            If (textdescripFS9.Text = "" Or txtimporteFS9.Text = "" Or txtIvaFS9.Text = "" Or txtTotalFS9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS9.Text
                    gastos.FS_importe = Me.txtimporteFS9.Text
                    gastos.FS_iva = Me.txtIvaFS9.Text
                    gastos.FS_total = Me.txtTotalFS9.Text
                    gastos.FS_idflete = Me.Textid5_9.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones9.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones9.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete9.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete9.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE9.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE9.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::
                    'gastos.FS_retenciones = Me.txtRetenciones9.Text
                    'gastos.FS_tc = Me.txtTCFlete9.Text
                    'gastos.FS_usd = Me.TextUSDFLE9.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        'MsgBox("flete9")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS9.Clear()
            txtimporteFS9.Clear()
            txtIvaFS9.Clear()
            txtTotalFS9.Clear()
            txtRetenciones9.Clear()
            txtTCFlete9.Clear()
            TextUSDFLE9.Clear()



            '//////////////////////////////////////////////////////////////////////////////////////////////////////////
            ''modificacion10

            If (textdescripFS10.Text = "" Or txtimporteFS10.Text = "" Or txtIvaFS10.Text = "" Or txtTotalFS10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim gastos As New ClassFletesSeguros

                    gastos.FS_pedimento = Me.txtCodigoPedimento1.Text
                    gastos.FS_descripcion = Me.textdescripFS10.Text
                    gastos.FS_importe = Me.txtimporteFS10.Text
                    gastos.FS_iva = Me.txtIvaFS10.Text
                    gastos.FS_total = Me.txtTotalFS10.Text
                    gastos.FS_idflete = Me.Textid5_10.Text
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtRetenciones10.Text = "" Then
                        gastos.FS_retenciones = "0"
                    Else
                        gastos.FS_retenciones = Me.txtRetenciones10.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::
                    If txtTCFlete10.Text = "" Then
                        gastos.FS_tc = "0"
                    Else
                        gastos.FS_tc = Me.txtTCFlete10.Text
                    End If
                    '::::::::::::::::::::::::::::::::::::::::::::::::::::
                    If TextUSDFLE10.Text = "" Then
                        gastos.FS_usd = "0"
                    Else
                        gastos.FS_usd = Me.TextUSDFLE10.Text
                    End If
                    ':::::::::::::::::::::::::::::::::::::::::::::::::::::

                    'gastos.FS_retenciones = Me.txtRetenciones10.Text
                    'gastos.FS_tc = Me.txtTCFlete10.Text
                    'gastos.FS_usd = Me.TextUSDFLE10.Text

                    If funciones.FN_ModificarFletesSeguros(gastos) Then
                        ' MsgBox("flete10")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            textdescripFS10.Clear()
            txtimporteFS10.Clear()
            txtIvaFS10.Clear()
            txtTotalFS10.Clear()
            txtRetenciones10.Clear()
            txtTCFlete10.Clear()
            TextUSDFLE10.Clear()

        End If
    End Sub


    Private Sub txtTCFlete1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete1.KeyPress
        NumerosyDecimall(txtTCFlete1, com)
    End Sub
    Private Sub txtTCFlete2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete2.KeyPress
        NumerosyDecimall(txtTCFlete2, com)
    End Sub
    Private Sub txtTCFlete3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete3.KeyPress
        NumerosyDecimall(txtTCFlete3, com)
    End Sub
    Private Sub txtTCFlete4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete4.KeyPress
        NumerosyDecimall(txtTCFlete4, com)
    End Sub
    Private Sub txtTCFlete5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete5.KeyPress
        NumerosyDecimall(txtTCFlete5, com)
    End Sub
    Private Sub txtTCFlete6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete6.KeyPress
        NumerosyDecimall(txtTCFlete6, com)
    End Sub
    Private Sub txtTCFlete7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete7.KeyPress
        NumerosyDecimall(txtTCFlete7, com)
    End Sub
    Private Sub txtTCFlete8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete8.KeyPress
        NumerosyDecimall(txtTCFlete8, com)

    End Sub
    Private Sub txtTCFlete9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete9.KeyPress
        NumerosyDecimall(txtTCFlete9, com)

    End Sub
    Private Sub txtTCFlete10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles txtTCFlete10.KeyPress
        NumerosyDecimall(txtTCFlete10, com)
    End Sub

    Private Sub TextUSDFLE1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE1.KeyPress
        NumerosyDecimall(TextUSDFLE1, com)
    End Sub
    Private Sub TextUSDFLE2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE2.KeyPress
        NumerosyDecimall(TextUSDFLE2, com)
    End Sub

    Private Sub TextUSDFLE3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE3.KeyPress
        NumerosyDecimall(TextUSDFLE3, com)
    End Sub

    Private Sub TextUSDFLE4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE4.KeyPress
        NumerosyDecimall(TextUSDFLE4, com)
    End Sub

    Private Sub TextUSDFLE5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE5.KeyPress
        NumerosyDecimall(TextUSDFLE5, com)
    End Sub

    Private Sub TextUSDFLE6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE6.KeyPress
        NumerosyDecimall(TextUSDFLE6, com)
    End Sub

    Private Sub TextUSDFLE7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE7.KeyPress
        NumerosyDecimall(TextUSDFLE7, com)
    End Sub

    Private Sub TextUSDFLE8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE8.KeyPress
        NumerosyDecimall(TextUSDFLE8, com)
    End Sub
    Private Sub TextUSDFLE9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE9.KeyPress
        NumerosyDecimall(TextUSDFLE9, com)
    End Sub

    Private Sub TextUSDFLE10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUSDFLE10.KeyPress
        NumerosyDecimall(TextUSDFLE10, com)
    End Sub

    Public Sub NumerosyDecimall(ByVal CajaTexto As Windows.Forms.TextBox, ByVal com As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(com.KeyChar) Then
            com.Handled = False
        ElseIf Char.IsControl(com.KeyChar) Then
            com.Handled = False
        ElseIf com.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            com.Handled = True
        ElseIf com.KeyChar = "." Then
            com.Handled = False
        Else
            com.Handled = True
            MsgBox("Solo se puede ingresar numeros y punto", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    ':::::::::::::::::::::::::::::::::::::::::::::::::-------->>>>Buscar_Pedimentos>>>>>----------:::::::::::::::::::::::::::::
    Private Sub btn_BuscarPdf_Click(sender As Object, e As EventArgs) Handles btn_BuscarPdf.Click
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
                    Dim pathDefinitivo As String = "\\ANTUA-PC\Servidor_de_Archivos\Facturas_Pedimentos\Pdf"
                    Dim fichero As New System.IO.FileInfo(pathDefinitivo & "\" & textpdf.Text)
                    ComboFactura.Text = pathDefinitivo & "\" & textpdf.Text
                    If fichero.Exists Then
                        If MessageBox.Show("El archivo seleccionado ya está incluido" & ControlChars.NewLine & "¿Desea sobreescribirlo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                            cancelado = True
                            ComboFactura.Clear()
                        Else
                            System.IO.File.Delete(fichero.FullName)
                        End If
                    End If
                    If Not cancelado Then
                        System.IO.File.Copy(.FileName, fichero.FullName)
                        MsgBox("Archivo Almacenado Correctamente", MessageBoxIcon.Exclamation)
                    End If

                Else
                    ComboFactura.Clear()
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TotalRelacionGastos1(sender As Object, e As EventArgs) Handles txtIva_gastosterceros.TextChanged, txtimporte9.TextChanged, txtimporte8.TextChanged, txtimporte7.TextChanged, txtimporte6.TextChanged, txtimporte5.TextChanged, txtimporte4.TextChanged, txtimporte3.TextChanged, txtimporte2.TextChanged, txtimporte10.TextChanged, TextIvaTotalll.TextChanged

    End Sub

    Private Sub IvaRelacionGastos1(sender As Object, e As EventArgs) Handles txtValorAduana.TextChanged, txtimporte1.TextChanged

    End Sub

    Private Sub suma_IvasRelacionGAstos1(sender As Object, e As EventArgs) Handles txtIva_gastosterceros.TextChanged, TexIvaOp9.TextChanged, TexIvaOp8.TextChanged, TexIvaOp7.TextChanged, TexIvaOp6.TextChanged, TexIvaOp5.TextChanged, TexIvaOp4.TextChanged, TexIvaOp3.TextChanged, TexIvaOp2.TextChanged, TexIvaOp1.TextChanged

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_BuscarOc_Click(sender As Object, e As EventArgs) Handles btn_BuscarOc.Click
        RegistrosOrdCom.Show()
    End Sub

    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    Sub Generarcodigo()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_pedimento)from TB_Pedimentos", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        Textbox_codigo_pedimento.Text = "PED-" + Format(id + 1, "0000") + "/20"
    End Sub
End Class