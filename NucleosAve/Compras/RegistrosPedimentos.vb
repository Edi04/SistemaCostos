Imports System.Data.SqlClient
Public Class RegistrosPedimentos
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Private Sub RegistrosPedimentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub MostrarRegPedimentos()
        Try
            Dim Func As New Funcion_Registros
            tabla = Func.FnMostrarPedimentos
            If tabla.Rows.Count <> 0 Then
                DataGridRegistrosPedimentos.DataSource = tabla
            Else
                DataGridRegistrosPedimentos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegPedimentos()
    End Sub

    Private Sub DataGridRegistrosPedimentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRegistrosPedimentos.CellClick

        'limpiamos las cajas de texto al dar clic ala celda-------------------------------
        Pedimentos.txtMercancia1.Clear()
        Pedimentos.txtfraccion1.Clear()
        Pedimentos.Textid1_1.Clear()
        Pedimentos.txtMercancia2.Clear()
        Pedimentos.txtfraccion2.Clear()
        Pedimentos.Textid1_2.Clear()
        Pedimentos.txtMercancia3.Clear()
        Pedimentos.txtfraccion3.Clear()
        Pedimentos.Textid1_3.Clear()
        Pedimentos.txtMercancia4.Clear()
        Pedimentos.txtfraccion4.Clear()
        Pedimentos.Textid1_4.Clear()
        Pedimentos.txtMercancia5.Clear()
        Pedimentos.txtfraccion5.Clear()
        Pedimentos.Textid1_5.Clear()
        Pedimentos.txtMercancia6.Clear()
        Pedimentos.txtfraccion6.Clear()
        Pedimentos.Textid1_6.Clear()
        Pedimentos.txtMercancia7.Clear()
        Pedimentos.txtfraccion7.Clear()
        Pedimentos.Textid1_7.Clear()
        Pedimentos.txtMercancia8.Clear()
        Pedimentos.txtfraccion8.Clear()
        Pedimentos.Textid1_8.Clear()
        Pedimentos.txtMercancia9.Clear()
        Pedimentos.txtfraccion9.Clear()
        Pedimentos.Textid1_9.Clear()
        Pedimentos.txtMercancia10.Clear()
        Pedimentos.txtfraccion10.Clear()
        Pedimentos.Textid1_10.Clear()
        '------------------------------gastos terceros 1----------------------------------------
        'Pedimentos.txtcodigo1.Clear()
        'Pedimentos.txtdescripcion1.Clear()
        Pedimentos.txtimporte1.Clear()
        Pedimentos.txtcodigo2.Clear()
        Pedimentos.txtdescripcion2.Clear()
        Pedimentos.txtimporte2.Clear()
        Pedimentos.txtcodigo3.Clear()
        Pedimentos.txtdescripcion3.Clear()
        Pedimentos.txtimporte3.Clear()
        Pedimentos.txtcodigo4.Clear()
        Pedimentos.txtdescripcion4.Clear()
        Pedimentos.txtimporte4.Clear()
        Pedimentos.txtcodigo5.Clear()
        Pedimentos.txtdescripcion5.Clear()
        Pedimentos.txtimporte5.Clear()
        Pedimentos.txtcodigo6.Clear()
        Pedimentos.txtdescripcion6.Clear()
        Pedimentos.txtimporte6.Clear()
        Pedimentos.txtcodigo7.Clear()
        Pedimentos.txtdescripcion7.Clear()
        Pedimentos.txtimporte7.Clear()
        Pedimentos.txtcodigo8.Clear()
        Pedimentos.txtdescripcion8.Clear()
        Pedimentos.txtimporte8.Clear()
        Pedimentos.txtcodigo9.Clear()
        Pedimentos.txtdescripcion9.Clear()
        Pedimentos.txtimporte9.Clear()
        Pedimentos.txtcodigo10.Clear()
        Pedimentos.txtdescripcion10.Clear()
        Pedimentos.txtimporte10.Clear()
        '----------------------------------------------------------------------
        '--------------------------GASTOS POR TERCEROS 2----------------------------------------------
        Pedimentos.txtdesc1.Clear()
        Pedimentos.txtconcepto1.Clear()
        Pedimentos.txtexento1.Clear()
        Pedimentos.textgravado1.Clear()
        Pedimentos.textIva_GT2_1.Clear()
        Pedimentos.txtTotalGT_1.Clear()
        Pedimentos.txtdesc2.Clear()
        Pedimentos.txtconcepto2.Clear()
        Pedimentos.txtexento2.Clear()
        Pedimentos.textgravado2.Clear()
        Pedimentos.textIva_GT2_2.Clear()
        Pedimentos.txtTotalGT_2.Clear()
        Pedimentos.txtdesc3.Clear()
        Pedimentos.txtconcepto3.Clear()
        Pedimentos.txtexento3.Clear()
        Pedimentos.textgravado3.Clear()
        Pedimentos.textIva_GT2_3.Clear()
        Pedimentos.txtTotalGT_3.Clear()
        Pedimentos.txtdesc4.Clear()
        Pedimentos.txtconcepto4.Clear()
        Pedimentos.txtexento4.Clear()
        Pedimentos.textgravado4.Clear()
        Pedimentos.textIva_GT2_4.Clear()
        Pedimentos.txtTotalGT_4.Clear()
        Pedimentos.txtdesc5.Clear()
        Pedimentos.txtconcepto5.Clear()
        Pedimentos.txtexento5.Clear()
        Pedimentos.textgravado5.Clear()
        Pedimentos.textIva_GT2_5.Clear()
        Pedimentos.txtTotalGT_5.Clear()
        Pedimentos.txtdesc6.Clear()
        Pedimentos.txtconcepto6.Clear()
        Pedimentos.txtexento6.Clear()
        Pedimentos.textgravado6.Clear()
        Pedimentos.textIva_GT2_6.Clear()
        Pedimentos.txtTotalGT_6.Clear()
        Pedimentos.txtdesc7.Clear()
        Pedimentos.txtconcepto7.Clear()
        Pedimentos.txtexento7.Clear()
        Pedimentos.textgravado7.Clear()
        Pedimentos.textIva_GT2_7.Clear()
        Pedimentos.txtTotalGT_7.Clear()
        Pedimentos.txtdesc8.Clear()
        Pedimentos.txtconcepto8.Clear()
        Pedimentos.txtexento8.Clear()
        Pedimentos.textgravado8.Clear()
        Pedimentos.textIva_GT2_8.Clear()
        Pedimentos.txtTotalGT_8.Clear()
        Pedimentos.txtdesc9.Clear()
        Pedimentos.txtconcepto9.Clear()
        Pedimentos.txtexento9.Clear()
        Pedimentos.textgravado9.Clear()
        Pedimentos.textIva_GT2_9.Clear()
        Pedimentos.txtTotalGT_9.Clear()
        Pedimentos.txtdesc10.Clear()
        Pedimentos.txtconcepto10.Clear()
        Pedimentos.txtexento10.Clear()
        Pedimentos.textgravado10.Clear()
        Pedimentos.textIva_GT2_10.Clear()
        Pedimentos.txtTotalGT_10.Clear()

        Pedimentos.Textbox_codigo_pedimento.Clear()
        '------------------------------------------------------------------------
        '------------------------------Custom Brokerage--------------------------
        Pedimentos.textDescripcion1.Clear()
        Pedimentos.textimporte1.Clear()
        Pedimentos.textDescripcion2.Clear()
        Pedimentos.textimporte2.Clear()
        Pedimentos.textDescripcion3.Clear()
        Pedimentos.textimporte3.Clear()
        Pedimentos.textDescripcion4.Clear()
        Pedimentos.textimporte4.Clear()
        Pedimentos.textDescripcion5.Clear()
        Pedimentos.textimporte5.Clear()
        Pedimentos.textDescripcion6.Clear()
        Pedimentos.textimporte6.Clear()
        Pedimentos.textDescripcion7.Clear()
        Pedimentos.textimporte7.Clear()
        Pedimentos.textDescripcion8.Clear()
        Pedimentos.textimporte8.Clear()
        Pedimentos.textDescripcion9.Clear()
        Pedimentos.textimporte9.Clear()
        Pedimentos.textDescripcion10.Clear()
        Pedimentos.textimporte10.Clear()
        '------------------------------------------------------------------------
        Pedimentos.textdescripFS1.Clear()
        Pedimentos.txtimporteFS1.Clear()
        Pedimentos.txtIvaFS1.Clear()
        Pedimentos.txtTotalFS1.Clear()
        Pedimentos.textdescripFS2.Clear()
        Pedimentos.txtimporteFS2.Clear()
        Pedimentos.txtIvaFS2.Clear()
        Pedimentos.txtTotalFS2.Clear()
        Pedimentos.textdescripFS3.Clear()
        Pedimentos.txtimporteFS3.Clear()
        Pedimentos.txtIvaFS3.Clear()
        Pedimentos.txtTotalFS3.Clear()
        Pedimentos.textdescripFS4.Clear()
        Pedimentos.txtimporteFS4.Clear()
        Pedimentos.txtIvaFS4.Clear()
        Pedimentos.txtTotalFS4.Clear()
        Pedimentos.textdescripFS5.Clear()
        Pedimentos.txtimporteFS5.Clear()
        Pedimentos.txtIvaFS5.Clear()
        Pedimentos.txtTotalFS5.Clear()
        Pedimentos.textdescripFS6.Clear()
        Pedimentos.txtimporteFS6.Clear()
        Pedimentos.txtIvaFS6.Clear()
        Pedimentos.txtTotalFS6.Clear()
        Pedimentos.textdescripFS7.Clear()
        Pedimentos.txtimporteFS7.Clear()
        Pedimentos.txtIvaFS7.Clear()
        Pedimentos.txtTotalFS7.Clear()
        Pedimentos.textdescripFS8.Clear()
        Pedimentos.txtimporteFS8.Clear()
        Pedimentos.txtIvaFS8.Clear()
        Pedimentos.txtTotalFS8.Clear()
        Pedimentos.textdescripFS9.Clear()
        Pedimentos.txtimporteFS9.Clear()
        Pedimentos.txtIvaFS9.Clear()
        Pedimentos.txtTotalFS9.Clear()
        Pedimentos.textdescripFS10.Clear()
        Pedimentos.txtimporteFS10.Clear()
        Pedimentos.txtIvaFS10.Clear()
        Pedimentos.txtTotalFS10.Clear()
        Pedimentos.txtRetenciones1.Clear()
        Pedimentos.retencionCheck1.Checked = False
        Pedimentos.txtRetenciones2.Clear()
        Pedimentos.retencionCheck2.Checked = False
        Pedimentos.txtRetenciones3.Clear()
        Pedimentos.retencionCheck3.Checked = False
        Pedimentos.txtRetenciones4.Clear()
        Pedimentos.retencionCheck4.Checked = False
        Pedimentos.txtRetenciones5.Clear()
        Pedimentos.retencionCheck5.Checked = False
        Pedimentos.txtRetenciones6.Clear()
        Pedimentos.retencionCheck6.Checked = False
        Pedimentos.txtRetenciones7.Clear()
        Pedimentos.retencionCheck7.Checked = False
        Pedimentos.txtRetenciones8.Clear()
        Pedimentos.retencionCheck8.Checked = False
        Pedimentos.txtRetenciones9.Clear()
        Pedimentos.retencionCheck9.Checked = False
        Pedimentos.txtRetenciones10.Clear()
        Pedimentos.retencionCheck10.Checked = False

        Pedimentos.btn_modificar.Enabled = True
        Pedimentos.BtnGuardarFac.Enabled = False
        Dim tabla As New DataTable
        Pedimentos.txtCodigoPedimento1.Text = DataGridRegistrosPedimentos.CurrentRow.Cells(1).Value
        Pedimentos.txtCodigoPedimento.Text = DataGridRegistrosPedimentos.CurrentRow.Cells(0).Value
        Pedimentos.Textbox_codigo_pedimento.Text = DataGridRegistrosPedimentos.CurrentRow.Cells(34).Value
        Dim codigo_principal As String
        Dim codigo As String
        codigo_principal = Pedimentos.txtCodigoPedimento.Text
        codigo = Pedimentos.txtCodigoPedimento1.Text
        Dim conexxo As New SqlConnection(conexioncita)
        Dim da As New SqlDataAdapter
        conexxo.Open()
        Dim comando As New SqlCommand("select
         p.id_pedimento,
         p.pedimento_codigo,
         p.pedimento,
         p.provedor,
         p.orden_compra,
         p.id_factura,
         p.cove,
         p.fecha,
         p.cantidad,
         p.unidad,
         p.precio_pagado,
         p.total,
         p.valor_aduana,
         p.clave,
         p.aduana,
         p.t_cambio,
         p.peso_bruto,
         p.tipo,
         p.n_tipo,
         p.iva_RG_terceros1,
         p.total_RG_terceros1,
         p.iva_custombokerage,
         p.total_custombokerage,
         p.importe_total,
         p.iva_total,
         p.total_total,
         p.importe,
         p.peso,
         p.costo,
         p.tipo_cambio_res,
         p.moneda_nacional,
         p.moneda_nacional2,
         p.otros_gastos,
         p.Costo_total,
         p.costo_total2
         from TB_Pedimentos as p
         where p.pedimento ='" + codigo + "' and p.pedimento_codigo='" + codigo_principal + "'", conexxo)
        da.SelectCommand = comando
        da.Fill(tabla)
        If (tabla.Rows.Count <> 0) Then
            TextBox_id.Text = tabla.Rows(0)(0).ToString
            codigo_eliminar.Text = tabla.Rows(0)(1).ToString
            Pedimentos.TextIDPEdimento.Text = tabla.Rows(0)(0).ToString
            Pedimentos.txtCodigoPedimento.Text = tabla.Rows(0)(1).ToString
            Pedimentos.textprove.Text = tabla.Rows(0)(3).ToString
            Pedimentos.TexOrdenC.Text = tabla.Rows(0)(4).ToString
            Pedimentos.ComboFactura.Text = tabla.Rows(0)(5).ToString
            Pedimentos.txtCove.Text = tabla.Rows(0)(6).ToString
            Pedimentos.DateTimeFecha.Text = tabla.Rows(0)(7).ToString
            Pedimentos.TxtCantidad.Text = tabla.Rows(0)(8).ToString
            Pedimentos.txtUnidad.Text = tabla.Rows(0)(9).ToString
            Pedimentos.txtppagado.Text = tabla.Rows(0)(10).ToString
            Pedimentos.txtTotal.Text = tabla.Rows(0)(11).ToString
            Pedimentos.txtValorAduana.Text = tabla.Rows(0)(12).ToString
            Pedimentos.txtclave.Text = tabla.Rows(0)(13).ToString
            Pedimentos.txtAduana.Text = tabla.Rows(0)(14).ToString
            Pedimentos.txttipocambio.Text = tabla.Rows(0)(15).ToString
            Pedimentos.txtpesobruto.Text = tabla.Rows(0)(16).ToString
            Pedimentos.txttipoo.Text = tabla.Rows(0)(17).ToString
            Pedimentos.txtcantidadt.Text = tabla.Rows(0)(18).ToString

        End If
        conexxo.Close()
        '------------------------------------------------------------------------------------------------------------------
        llenar_campos()
        llenar_campos2()
        llenar_campos3()
        llenar_campos4()
        llenar_camposterceros2()
    End Sub

    Sub llenar_campos()
        Try
            Dim codigo As String
            Dim codigo_principal As String
            Dim tabla2 As New DataTable
            Dim codigo_bueno As String
            codigo_bueno = Pedimentos.Textbox_codigo_pedimento.Text
            codigo = Pedimentos.txtCodigoPedimento1.Text
            codigo_principal = Pedimentos.txtCodigoPedimento.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            MP.mercancia,
            MP.fraccion,
            MP.id_productos,
            MP.codigoPed
            from TB_Mercancia_Pedimentos as MP
            where MP.codigo_bueno='" + codigo_bueno + "' and MP.pedimento='" + codigo + "' and MP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)

            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.txtMercancia1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.txtfraccion1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.Textid1_1.Text = tabla2.Rows(0)(2).ToString

            End If
            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.txtMercancia2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.txtfraccion2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.Textid1_2.Text = tabla2.Rows(1)(2).ToString
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.txtMercancia3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtfraccion3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.Textid1_3.Text = tabla2.Rows(2)(2).ToString
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.txtMercancia4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtfraccion4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.Textid1_4.Text = tabla2.Rows(3)(2).ToString
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.txtMercancia5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtfraccion5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.Textid1_5.Text = tabla2.Rows(4)(2).ToString
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.txtMercancia6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtfraccion6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.Textid1_6.Text = tabla2.Rows(5)(2).ToString
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.txtMercancia7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtfraccion7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.Textid1_7.Text = tabla2.Rows(6)(2).ToString
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.txtMercancia8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtfraccion8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.Textid1_8.Text = tabla2.Rows(7)(2).ToString
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.txtMercancia9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtfraccion9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.Textid1_9.Text = tabla2.Rows(8)(2).ToString
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.txtMercancia10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtfraccion10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.Textid1_10.Text = tabla2.Rows(9)(2).ToString
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    Sub llenar_campos2()
        Try
            Dim codigo As String
            Dim codigo_principal As String
            Dim tabla2 As New DataTable
            codigo = Pedimentos.txtCodigoPedimento1.Text
            codigo_principal = Pedimentos.txtCodigoPedimento.Text
            Dim codigo_bueno As String
            codigo_bueno = Pedimentos.Textbox_codigo_pedimento.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.codigo,
            CP.descripcion,
            CP.importe,
            CP.id_concepto,
            CP.iva
            from TB_Conceptos_Ped as CP
            where CP.codigo_bueno='" + codigo_bueno + "' and CP.seccion='Relacion de Gastos por Terceros 1' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)

            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.txtcodigo1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.txtdescripcion1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.txtimporte1.Text = tabla2.Rows(0)(2).ToString
                Pedimentos.Textid2_1.Text = tabla2.Rows(0)(3).ToString
                Pedimentos.txtIva_gastosterceros.Text = tabla2.Rows(0)(4).ToString

            End If
            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.txtcodigo2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.txtdescripcion2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.txtimporte2.Text = tabla2.Rows(1)(2).ToString
                Pedimentos.Textid2_2.Text = tabla2.Rows(1)(3).ToString

                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(1)(4).ToString = 0 Then
                    Pedimentos.iVACheck1.Checked = False
                    Pedimentos.TexIvaOp1.Text = tabla2.Rows(1)(4).ToString
                Else
                    Pedimentos.iVACheck1.Checked = True
                    Pedimentos.TexIvaOp1.Text = tabla2.Rows(1)(4).ToString
                End If
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.txtcodigo3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtdescripcion3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.txtimporte3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.Textid2_3.Text = tabla2.Rows(2)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(2)(4).ToString = 0 Then
                    Pedimentos.iVACheck2.Checked = False
                    Pedimentos.TexIvaOp2.Text = tabla2.Rows(2)(4).ToString
                Else
                    Pedimentos.iVACheck2.Checked = True
                    Pedimentos.TexIvaOp2.Text = tabla2.Rows(2)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::               
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.txtcodigo4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtdescripcion4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.txtimporte4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.Textid2_4.Text = tabla2.Rows(3)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(3)(4).ToString = 0 Then
                    Pedimentos.iVACheck3.Checked = False
                    Pedimentos.TexIvaOp3.Text = tabla2.Rows(3)(4).ToString
                Else
                    Pedimentos.iVACheck3.Checked = True
                    Pedimentos.TexIvaOp3.Text = tabla2.Rows(3)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.txtcodigo5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtdescripcion5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.txtimporte5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.Textid2_5.Text = tabla2.Rows(4)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(4)(4).ToString = 0 Then
                    Pedimentos.iVACheck4.Checked = False
                    Pedimentos.TexIvaOp4.Text = tabla2.Rows(4)(4).ToString
                Else
                    Pedimentos.iVACheck4.Checked = True
                    Pedimentos.TexIvaOp4.Text = tabla2.Rows(4)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.txtcodigo6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtdescripcion6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.txtimporte6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.Textid2_6.Text = tabla2.Rows(5)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(5)(4).ToString = 0 Then
                    Pedimentos.iVACheck5.Checked = False
                    Pedimentos.TexIvaOp5.Text = tabla2.Rows(5)(4).ToString
                Else
                    Pedimentos.iVACheck5.Checked = True
                    Pedimentos.TexIvaOp5.Text = tabla2.Rows(5)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.txtcodigo7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtdescripcion7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.txtimporte7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.Textid2_7.Text = tabla2.Rows(6)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(6)(4).ToString = 0 Then
                    Pedimentos.iVACheck6.Checked = False
                    Pedimentos.TexIvaOp6.Text = tabla2.Rows(6)(4).ToString
                Else
                    Pedimentos.iVACheck6.Checked = True
                    Pedimentos.TexIvaOp6.Text = tabla2.Rows(6)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.txtcodigo8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtdescripcion8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.txtimporte8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.Textid2_8.Text = tabla2.Rows(7)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(7)(4).ToString = 0 Then
                    Pedimentos.iVACheck7.Checked = False
                    Pedimentos.TexIvaOp7.Text = tabla2.Rows(7)(4).ToString
                Else
                    Pedimentos.iVACheck7.Checked = True
                    Pedimentos.TexIvaOp7.Text = tabla2.Rows(7)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.txtcodigo9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtdescripcion9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.txtimporte9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.Textid2_9.Text = tabla2.Rows(8)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(8)(4).ToString = 0 Then
                    Pedimentos.iVACheck8.Checked = False
                    Pedimentos.TexIvaOp8.Text = tabla2.Rows(8)(4).ToString
                Else
                    Pedimentos.iVACheck8.Checked = True
                    Pedimentos.TexIvaOp8.Text = tabla2.Rows(8)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.txtcodigo10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtdescripcion10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.txtimporte10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.Textid2_10.Text = tabla2.Rows(9)(3).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(9)(4).ToString = 0 Then
                    Pedimentos.iVACheck9.Checked = False
                    Pedimentos.TexIvaOp9.Text = tabla2.Rows(9)(4).ToString
                Else
                    Pedimentos.iVACheck9.Checked = True
                    Pedimentos.TexIvaOp9.Text = tabla2.Rows(9)(4).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::             
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    '---------------------------------------------------------------------------------------------------------------
    Sub llenar_camposterceros2()
        Try
            Dim codigo As String
            Dim codigo_principal As String
            Dim tabla2 As New DataTable
            codigo = Pedimentos.txtCodigoPedimento1.Text
            codigo_principal = Pedimentos.txtCodigoPedimento.Text
            Dim codigo_bueno As String
            codigo_bueno = Pedimentos.Textbox_codigo_pedimento.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.descripcion,
            CP.concepto,
            CP.exento,
            CP.importe,
            CP.iva,
            CP.total,
            CP.seccion,
            CP.id_concepto
            from TB_Conceptos_Ped as CP
            where CP.codigo_bueno='" + codigo_bueno + "' and CP.seccion='Relacion de Gastos por Terceros 2' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)

            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.txtdesc1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.txtconcepto1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.txtexento1.Text = tabla2.Rows(0)(2).ToString
                Pedimentos.textgravado1.Text = tabla2.Rows(0)(3).ToString
                Pedimentos.textIva_GT2_1.Text = tabla2.Rows(0)(4).ToString
                Pedimentos.txtTotalGT_1.Text = tabla2.Rows(0)(5).ToString
                Pedimentos.Textid3_1.Text = tabla2.Rows(0)(7).ToString

            End If
            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.txtdesc2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.txtconcepto2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.txtexento2.Text = tabla2.Rows(1)(2).ToString
                Pedimentos.textgravado2.Text = tabla2.Rows(1)(3).ToString
                Pedimentos.textIva_GT2_2.Text = tabla2.Rows(1)(4).ToString
                Pedimentos.txtTotalGT_2.Text = tabla2.Rows(1)(5).ToString
                Pedimentos.Textid3_2.Text = tabla2.Rows(1)(7).ToString
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.txtdesc3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtconcepto3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.txtexento3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.textgravado3.Text = tabla2.Rows(2)(3).ToString
                Pedimentos.textIva_GT2_3.Text = tabla2.Rows(2)(4).ToString
                Pedimentos.txtTotalGT_3.Text = tabla2.Rows(2)(5).ToString
                Pedimentos.Textid3_3.Text = tabla2.Rows(2)(7).ToString
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.txtdesc4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtconcepto4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.txtexento4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.textgravado4.Text = tabla2.Rows(3)(3).ToString
                Pedimentos.textIva_GT2_4.Text = tabla2.Rows(3)(4).ToString
                Pedimentos.txtTotalGT_4.Text = tabla2.Rows(3)(5).ToString
                Pedimentos.Textid3_4.Text = tabla2.Rows(3)(7).ToString
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.txtdesc5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtconcepto5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.txtexento5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.textgravado5.Text = tabla2.Rows(4)(3).ToString
                Pedimentos.textIva_GT2_5.Text = tabla2.Rows(4)(4).ToString
                Pedimentos.txtTotalGT_5.Text = tabla2.Rows(4)(5).ToString
                Pedimentos.Textid3_5.Text = tabla2.Rows(4)(7).ToString
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.txtdesc6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtconcepto6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.txtexento6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.textgravado6.Text = tabla2.Rows(5)(3).ToString
                Pedimentos.textIva_GT2_6.Text = tabla2.Rows(5)(4).ToString
                Pedimentos.txtTotalGT_6.Text = tabla2.Rows(5)(5).ToString
                Pedimentos.Textid3_6.Text = tabla2.Rows(5)(7).ToString
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.txtdesc7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtconcepto7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.txtexento7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.textgravado7.Text = tabla2.Rows(6)(3).ToString
                Pedimentos.textIva_GT2_7.Text = tabla2.Rows(6)(4).ToString
                Pedimentos.txtTotalGT_7.Text = tabla2.Rows(6)(5).ToString
                Pedimentos.Textid3_7.Text = tabla2.Rows(6)(7).ToString
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.txtdesc8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtconcepto8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.txtexento8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.textgravado8.Text = tabla2.Rows(7)(3).ToString
                Pedimentos.textIva_GT2_8.Text = tabla2.Rows(7)(4).ToString
                Pedimentos.txtTotalGT_8.Text = tabla2.Rows(7)(5).ToString
                Pedimentos.Textid3_8.Text = tabla2.Rows(7)(7).ToString
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.txtdesc9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtconcepto9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.txtexento9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.textgravado9.Text = tabla2.Rows(8)(3).ToString
                Pedimentos.textIva_GT2_9.Text = tabla2.Rows(8)(4).ToString
                Pedimentos.txtTotalGT_9.Text = tabla2.Rows(8)(5).ToString
                Pedimentos.Textid3_9.Text = tabla2.Rows(8)(7).ToString
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.txtdesc10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtconcepto10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.txtexento10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.textgravado10.Text = tabla2.Rows(9)(3).ToString
                Pedimentos.textIva_GT2_10.Text = tabla2.Rows(9)(4).ToString
                Pedimentos.txtTotalGT_10.Text = tabla2.Rows(9)(5).ToString
                Pedimentos.Textid3_10.Text = tabla2.Rows(9)(7).ToString
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    '---------------------------------------------------------------------------------------------------------------




    Sub llenar_campos3()
        Try
            Dim codigo As String
            Dim codigo_principal As String
            Dim tabla2 As New DataTable
            codigo = Pedimentos.txtCodigoPedimento1.Text
            codigo_principal = Pedimentos.txtCodigoPedimento.Text
            Dim codigo_bueno As String
            codigo_bueno = Pedimentos.Textbox_codigo_pedimento.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.descripcion,
            CP.importe,
            CP.id_concepto
            from TB_Conceptos_Ped as CP
            where CP.codigo_bueno='" + codigo_bueno + "' and CP.seccion='Customs Brokerage' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)

            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.textDescripcion1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.textimporte1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.Textid4_1.Text = tabla2.Rows(0)(2).ToString
            End If
            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.textDescripcion2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.textimporte2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.Textid4_2.Text = tabla2.Rows(1)(2).ToString
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.textDescripcion3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.textimporte3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.Textid4_3.Text = tabla2.Rows(2)(2).ToString
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.textDescripcion4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.textimporte4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.Textid4_4.Text = tabla2.Rows(3)(2).ToString
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.textDescripcion5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.textimporte5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.Textid4_5.Text = tabla2.Rows(4)(2).ToString
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.textDescripcion6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.textimporte6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.Textid4_6.Text = tabla2.Rows(5)(2).ToString
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.textDescripcion7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.textimporte7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.Textid4_7.Text = tabla2.Rows(6)(2).ToString
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.textDescripcion8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.textimporte8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.Textid4_8.Text = tabla2.Rows(7)(2).ToString
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.textDescripcion9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.textimporte9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.Textid4_9.Text = tabla2.Rows(8)(2).ToString
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.textDescripcion10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.textimporte10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.Textid4_10.Text = tabla2.Rows(9)(2).ToString
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    Sub llenar_campos4()
        Try
            Dim codigo As String
            Dim codigo_principal As String
            Dim tabla2 As New DataTable
            codigo_principal = Pedimentos.txtCodigoPedimento.Text
            codigo = Pedimentos.txtCodigoPedimento1.Text
            Dim codigo_bueno As String
            codigo_bueno = Pedimentos.Textbox_codigo_pedimento.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.descripcion,
            CP.tc_flete,
            CP.usd_flete,
            CP.importe,
            CP.iva,
            CP.retenciones,
            CP.total,
            CP.id_concepto   
            from TB_Conceptos_Ped as CP
            where CP.codigo_bueno='" + codigo_bueno + "' and CP.seccion='Fletes y Seguros' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)
            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.textdescripFS1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.txtTCFlete1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.TextUSDFLE1.Text = tabla2.Rows(0)(2).ToString
                Pedimentos.txtimporteFS1.Text = tabla2.Rows(0)(3).ToString
                Pedimentos.txtIvaFS1.Text = tabla2.Rows(0)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(0)(5).ToString = 0 Then
                    Pedimentos.retencionCheck1.Checked = False
                    Pedimentos.txtRetenciones1.Text = tabla2.Rows(0)(5).ToString
                Else
                    Pedimentos.retencionCheck1.Checked = True
                    Pedimentos.txtRetenciones1.Text = tabla2.Rows(0)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS1.Text = tabla2.Rows(0)(6).ToString
                Pedimentos.Textid5_1.Text = tabla2.Rows(0)(7).ToString
            End If
            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.textdescripFS2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.txtTCFlete2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.TextUSDFLE2.Text = tabla2.Rows(1)(2).ToString
                Pedimentos.txtimporteFS2.Text = tabla2.Rows(1)(3).ToString
                Pedimentos.txtIvaFS2.Text = tabla2.Rows(1)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(1)(5).ToString = 0 Then
                    Pedimentos.retencionCheck2.Checked = False
                    Pedimentos.txtRetenciones2.Text = tabla2.Rows(1)(5).ToString
                Else
                    Pedimentos.retencionCheck2.Checked = True
                    Pedimentos.txtRetenciones2.Text = tabla2.Rows(1)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS2.Text = tabla2.Rows(1)(6).ToString
                Pedimentos.Textid5_2.Text = tabla2.Rows(1)(7).ToString

            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.textdescripFS3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtTCFlete3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.TextUSDFLE3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.txtimporteFS3.Text = tabla2.Rows(2)(3).ToString
                Pedimentos.txtIvaFS3.Text = tabla2.Rows(2)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(2)(5).ToString = 0 Then
                    Pedimentos.retencionCheck3.Checked = False
                    Pedimentos.txtRetenciones3.Text = tabla2.Rows(2)(5).ToString
                Else
                    Pedimentos.retencionCheck3.Checked = True
                    Pedimentos.txtRetenciones3.Text = tabla2.Rows(2)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS3.Text = tabla2.Rows(2)(6).ToString
                Pedimentos.Textid5_3.Text = tabla2.Rows(2)(7).ToString

            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.textdescripFS4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtTCFlete4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.TextUSDFLE4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.txtimporteFS4.Text = tabla2.Rows(3)(3).ToString
                Pedimentos.txtIvaFS4.Text = tabla2.Rows(3)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(3)(5).ToString = 0 Then
                    Pedimentos.retencionCheck4.Checked = False
                    Pedimentos.txtRetenciones4.Text = tabla2.Rows(3)(5).ToString
                Else
                    Pedimentos.retencionCheck4.Checked = True
                    Pedimentos.txtRetenciones4.Text = tabla2.Rows(3)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS4.Text = tabla2.Rows(3)(6).ToString
                Pedimentos.Textid5_4.Text = tabla2.Rows(3)(7).ToString

            End If

            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.textdescripFS5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtTCFlete5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.TextUSDFLE5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.txtimporteFS5.Text = tabla2.Rows(4)(3).ToString
                Pedimentos.txtIvaFS5.Text = tabla2.Rows(4)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(4)(5).ToString = 0 Then
                    Pedimentos.retencionCheck5.Checked = False
                    Pedimentos.txtRetenciones5.Text = tabla2.Rows(4)(5).ToString
                Else
                    Pedimentos.retencionCheck5.Checked = True
                    Pedimentos.txtRetenciones5.Text = tabla2.Rows(4)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS5.Text = tabla2.Rows(4)(6).ToString
                Pedimentos.Textid5_5.Text = tabla2.Rows(4)(7).ToString

            End If

            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.textdescripFS6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtTCFlete6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.TextUSDFLE6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.txtimporteFS6.Text = tabla2.Rows(5)(3).ToString
                Pedimentos.txtIvaFS6.Text = tabla2.Rows(5)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(5)(5).ToString = 0 Then
                    Pedimentos.retencionCheck6.Checked = False
                    Pedimentos.txtRetenciones6.Text = tabla2.Rows(5)(5).ToString
                Else
                    Pedimentos.retencionCheck6.Checked = True
                    Pedimentos.txtRetenciones6.Text = tabla2.Rows(5)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS6.Text = tabla2.Rows(5)(6).ToString
                Pedimentos.Textid5_6.Text = tabla2.Rows(5)(7).ToString
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.textdescripFS7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtTCFlete7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.TextUSDFLE7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.txtimporteFS7.Text = tabla2.Rows(6)(3).ToString
                Pedimentos.txtIvaFS7.Text = tabla2.Rows(6)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(6)(5).ToString = 0 Then
                    Pedimentos.retencionCheck7.Checked = False
                    Pedimentos.txtRetenciones7.Text = tabla2.Rows(6)(5).ToString
                Else
                    Pedimentos.retencionCheck7.Checked = True
                    Pedimentos.txtRetenciones7.Text = tabla2.Rows(6)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS7.Text = tabla2.Rows(6)(6).ToString
                Pedimentos.Textid5_7.Text = tabla2.Rows(6)(7).ToString

            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.textdescripFS8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtTCFlete8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.TextUSDFLE8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.txtimporteFS8.Text = tabla2.Rows(7)(3).ToString
                Pedimentos.txtIvaFS8.Text = tabla2.Rows(7)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(7)(5).ToString = 0 Then
                    Pedimentos.retencionCheck8.Checked = False
                    Pedimentos.txtRetenciones8.Text = tabla2.Rows(7)(5).ToString
                Else
                    Pedimentos.retencionCheck8.Checked = True
                    Pedimentos.txtRetenciones8.Text = tabla2.Rows(7)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS8.Text = tabla2.Rows(7)(6).ToString
                Pedimentos.Textid5_8.Text = tabla2.Rows(7)(7).ToString

            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.textdescripFS9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtTCFlete9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.TextUSDFLE9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.txtimporteFS9.Text = tabla2.Rows(8)(3).ToString
                Pedimentos.txtIvaFS9.Text = tabla2.Rows(8)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(8)(5).ToString = 0 Then
                    Pedimentos.retencionCheck9.Checked = False
                    Pedimentos.txtRetenciones9.Text = tabla2.Rows(8)(5).ToString
                Else
                    Pedimentos.retencionCheck9.Checked = True
                    Pedimentos.txtRetenciones9.Text = tabla2.Rows(8)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS9.Text = tabla2.Rows(8)(6).ToString
                Pedimentos.Textid5_9.Text = tabla2.Rows(8)(7).ToString

            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.textdescripFS10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtTCFlete10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.TextUSDFLE10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.txtimporteFS10.Text = tabla2.Rows(9)(3).ToString
                Pedimentos.txtIvaFS10.Text = tabla2.Rows(9)(4).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(9)(5).ToString = 0 Then
                    Pedimentos.retencionCheck10.Checked = False
                    Pedimentos.txtRetenciones10.Text = tabla2.Rows(9)(5).ToString
                Else
                    Pedimentos.retencionCheck10.Checked = True
                    Pedimentos.txtRetenciones10.Text = tabla2.Rows(9)(5).ToString
                End If
                '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::: 
                Pedimentos.txtTotalFS10.Text = tabla2.Rows(9)(6).ToString
                Pedimentos.Textid5_10.Text = tabla2.Rows(9)(7).ToString

            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub btn_BuscarOc_Click(sender As Object, e As EventArgs) Handles btn_BuscarOc.Click
        RegistrosOrdCom.Show()
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

    Private Sub DataGridRegistrosPedimentos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRegistrosPedimentos.CellContentClick

    End Sub

    Private Sub btn_eliminnar_Click(sender As Object, e As EventArgs) Handles btn_eliminnar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Eliminar " + codigo_eliminar.Text, "Eliminar Pedimentos", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassPedimentos

                logica.Peid = Me.TextBox_id.Text

                If funciones.FN_EliminarPedimentos(logica) Then
                    MsgBox("Pedimento Eliminado Correctamente", MessageBoxIcon.Information)
                     MostrarRegPedimentos()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class