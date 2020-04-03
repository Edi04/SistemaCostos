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
            where MP.pedimento='" + codigo + "' and MP.codigoPed='" + codigo_principal + "'", conexxo)
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
                Pedimentos.TextNum2.Visible = True
                Pedimentos.txtMercancia2.Visible = True
                Pedimentos.txtfraccion2.Visible = True

            Else
                Pedimentos.TextNum2.Visible = False
                Pedimentos.txtMercancia2.Visible = False
                Pedimentos.txtfraccion2.Visible = False
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.txtMercancia3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtfraccion3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.Textid1_3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.TextNum3.Visible = True
                Pedimentos.txtMercancia3.Visible = True
                Pedimentos.txtfraccion3.Visible = True

            Else
                Pedimentos.TextNum3.Visible = False
                Pedimentos.txtMercancia3.Visible = False
                Pedimentos.txtfraccion3.Visible = False
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.txtMercancia4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtfraccion4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.Textid1_4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.TextNum4.Visible = True
                Pedimentos.txtMercancia4.Visible = True
                Pedimentos.txtfraccion4.Visible = True
            Else
                Pedimentos.TextNum4.Visible = False
                Pedimentos.txtMercancia4.Visible = False
                Pedimentos.txtfraccion4.Visible = False
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.txtMercancia5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtfraccion5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.Textid1_5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.txtMercancia5.Visible = True
                Pedimentos.txtfraccion5.Visible = True
                Pedimentos.TextNum5.Visible = True
            Else
                Pedimentos.TextNum5.Visible = False
                Pedimentos.txtMercancia5.Visible = False
                Pedimentos.txtfraccion5.Visible = False
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.txtMercancia6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtfraccion6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.Textid1_6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.TextNum6.Visible = True
                Pedimentos.txtMercancia6.Visible = True
                Pedimentos.txtfraccion6.Visible = True
            Else
                Pedimentos.TextNum6.Visible = False
                Pedimentos.txtMercancia6.Visible = False
                Pedimentos.txtfraccion6.Visible = False
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.txtMercancia7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtfraccion7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.Textid1_7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.TextNum7.Visible = True
                Pedimentos.txtMercancia7.Visible = True
                Pedimentos.txtfraccion7.Visible = True
            Else
                Pedimentos.TextNum7.Visible = False
                Pedimentos.txtMercancia7.Visible = False
                Pedimentos.txtfraccion7.Visible = False
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.txtMercancia8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtfraccion8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.Textid1_8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.TextNum8.Visible = True
                Pedimentos.txtMercancia8.Visible = True
                Pedimentos.txtfraccion8.Visible = True
            Else
                Pedimentos.TextNum8.Visible = False
                Pedimentos.txtMercancia8.Visible = False
                Pedimentos.txtfraccion8.Visible = False
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.txtMercancia9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtfraccion9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.Textid1_9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.TextNum9.Visible = True
                Pedimentos.txtMercancia9.Visible = True
                Pedimentos.txtfraccion9.Visible = True
            Else
                Pedimentos.TextNum9.Visible = False
                Pedimentos.txtMercancia9.Visible = False
                Pedimentos.txtfraccion9.Visible = False
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.txtMercancia10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtfraccion10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.Textid1_10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.TextNum10.Visible = True
                Pedimentos.txtMercancia10.Visible = True
                Pedimentos.txtfraccion10.Visible = True
            Else
                Pedimentos.TextNum10.Visible = False
                Pedimentos.txtMercancia10.Visible = False
                Pedimentos.txtfraccion10.Visible = False
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
            where CP.seccion='Relacion de Gastos por Terceros 1' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
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
                Pedimentos.txtcodigo2.Visible = True
                Pedimentos.txtdescripcion2.Visible = True
                Pedimentos.txtimporte2.Visible = True
                Pedimentos.TexIvaOp1.Visible = True
                Pedimentos.iVACheck1.Visible = True
            Else
                Pedimentos.txtcodigo2.Visible = False
                Pedimentos.txtdescripcion2.Visible = False
                Pedimentos.txtimporte2.Visible = False
                Pedimentos.TexIvaOp1.Visible = False
                Pedimentos.iVACheck1.Visible = False

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
                Pedimentos.txtcodigo3.Visible = True
                Pedimentos.txtdescripcion3.Visible = True
                Pedimentos.txtimporte3.Visible = True
                Pedimentos.TexIvaOp2.Visible = True
                Pedimentos.iVACheck2.Visible = True

            Else
                Pedimentos.txtcodigo3.Visible = False
                Pedimentos.txtdescripcion3.Visible = False
                Pedimentos.txtimporte3.Visible = False
                Pedimentos.TexIvaOp2.Visible = False
                Pedimentos.iVACheck2.Visible = False

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
                Pedimentos.txtcodigo4.Visible = True
                Pedimentos.txtdescripcion4.Visible = True
                Pedimentos.txtimporte4.Visible = True
                Pedimentos.TexIvaOp3.Visible = True
                Pedimentos.iVACheck3.Visible = True

            Else
                Pedimentos.txtcodigo4.Visible = False
                Pedimentos.txtdescripcion4.Visible = False
                Pedimentos.txtimporte4.Visible = False
                Pedimentos.TexIvaOp1.Visible = False
                Pedimentos.iVACheck1.Visible = False

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
                Pedimentos.txtcodigo5.Visible = True
                Pedimentos.txtdescripcion5.Visible = True
                Pedimentos.txtimporte5.Visible = True
                Pedimentos.TexIvaOp4.Visible = True
                Pedimentos.iVACheck4.Visible = True

            Else
                Pedimentos.txtcodigo5.Visible = False
                Pedimentos.txtdescripcion5.Visible = False
                Pedimentos.txtimporte5.Visible = False
                Pedimentos.TexIvaOp4.Visible = False
                Pedimentos.iVACheck4.Visible = False

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
                Pedimentos.txtcodigo6.Visible = True
                Pedimentos.txtdescripcion6.Visible = True
                Pedimentos.txtimporte6.Visible = True
                Pedimentos.TexIvaOp5.Visible = True
                Pedimentos.iVACheck5.Visible = True

            Else
                Pedimentos.txtcodigo6.Visible = False
                Pedimentos.txtdescripcion6.Visible = False
                Pedimentos.txtimporte6.Visible = False
                Pedimentos.TexIvaOp5.Visible = False
                Pedimentos.iVACheck5.Visible = False

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
                Pedimentos.txtcodigo7.Visible = True
                Pedimentos.txtdescripcion7.Visible = True
                Pedimentos.txtimporte7.Visible = True
                Pedimentos.TexIvaOp6.Visible = True
                Pedimentos.iVACheck6.Visible = True

            Else
                Pedimentos.txtcodigo7.Visible = False
                Pedimentos.txtdescripcion7.Visible = False
                Pedimentos.txtimporte7.Visible = False
                Pedimentos.TexIvaOp6.Visible = False
                Pedimentos.iVACheck6.Visible = False

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
                Pedimentos.txtcodigo8.Visible = True
                Pedimentos.txtdescripcion8.Visible = True
                Pedimentos.txtimporte8.Visible = True
                Pedimentos.TexIvaOp7.Visible = True
                Pedimentos.iVACheck7.Visible = True

            Else
                Pedimentos.txtcodigo8.Visible = False
                Pedimentos.txtdescripcion8.Visible = False
                Pedimentos.txtimporte8.Visible = False
                Pedimentos.TexIvaOp7.Visible = False
                Pedimentos.iVACheck7.Visible = False

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
                Pedimentos.txtcodigo9.Visible = True
                Pedimentos.txtdescripcion9.Visible = True
                Pedimentos.txtimporte9.Visible = True
                Pedimentos.TexIvaOp8.Visible = True
                Pedimentos.iVACheck8.Visible = True

            Else
                Pedimentos.txtcodigo9.Visible = False
                Pedimentos.txtdescripcion9.Visible = False
                Pedimentos.txtimporte9.Visible = False
                Pedimentos.TexIvaOp8.Visible = False
                Pedimentos.iVACheck8.Visible = False

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
                Pedimentos.txtcodigo10.Visible = True
                Pedimentos.txtdescripcion10.Visible = True
                Pedimentos.txtimporte10.Visible = True
                Pedimentos.TexIvaOp9.Visible = True
                Pedimentos.iVACheck9.Visible = True

            Else
                Pedimentos.txtcodigo10.Visible = False
                Pedimentos.txtdescripcion10.Visible = False
                Pedimentos.txtimporte10.Visible = False
                Pedimentos.TexIvaOp9.Visible = True
                Pedimentos.iVACheck9.Visible = True

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
            where CP.seccion='Relacion de Gastos por Terceros 2' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
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
                Pedimentos.numtext2.Visible = True
                Pedimentos.txtdesc2.Visible = True
                Pedimentos.txtconcepto2.Visible = True
                Pedimentos.txtexento2.Visible = True
                Pedimentos.textgravado2.Visible = True
                Pedimentos.textIva_GT2_2.Visible = True
                Pedimentos.txtTotalGT_2.Visible = True
            Else
                Pedimentos.numtext2.Visible = False
                Pedimentos.txtdesc2.Visible = False
                Pedimentos.txtconcepto2.Visible = False
                Pedimentos.txtexento2.Visible = False
                Pedimentos.textgravado2.Visible = False
                Pedimentos.textIva_GT2_2.Visible = False
                Pedimentos.txtTotalGT_2.Visible = False
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.txtdesc3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtconcepto3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.txtexento3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.textgravado3.Text = tabla2.Rows(2)(3).ToString
                Pedimentos.textIva_GT2_3.Text = tabla2.Rows(2)(4).ToString
                Pedimentos.txtTotalGT_3.Text = tabla2.Rows(2)(5).ToString
                Pedimentos.Textid3_3.Text = tabla2.Rows(2)(7).ToString
                Pedimentos.numtext3.Visible = True
                Pedimentos.txtdesc3.Visible = True
                Pedimentos.txtconcepto3.Visible = True
                Pedimentos.txtexento3.Visible = True
                Pedimentos.textgravado3.Visible = True
                Pedimentos.textIva_GT2_3.Visible = True
                Pedimentos.txtTotalGT_3.Visible = True
            Else
                Pedimentos.numtext3.Visible = False
                Pedimentos.txtdesc3.Visible = False
                Pedimentos.txtconcepto3.Visible = False
                Pedimentos.txtexento3.Visible = False
                Pedimentos.textgravado3.Visible = False
                Pedimentos.textIva_GT2_3.Visible = False
                Pedimentos.txtTotalGT_3.Visible = False
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.txtdesc4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtconcepto4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.txtexento4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.textgravado4.Text = tabla2.Rows(3)(3).ToString
                Pedimentos.textIva_GT2_4.Text = tabla2.Rows(3)(4).ToString
                Pedimentos.txtTotalGT_4.Text = tabla2.Rows(3)(5).ToString
                Pedimentos.Textid3_4.Text = tabla2.Rows(3)(7).ToString
                Pedimentos.numtext4.Visible = True
                Pedimentos.txtdesc4.Visible = True
                Pedimentos.txtconcepto4.Visible = True
                Pedimentos.txtexento4.Visible = True
                Pedimentos.textgravado4.Visible = True
                Pedimentos.textIva_GT2_4.Visible = True
                Pedimentos.txtTotalGT_4.Visible = True
            Else
                Pedimentos.numtext4.Visible = False
                Pedimentos.txtdesc4.Visible = False
                Pedimentos.txtconcepto4.Visible = False
                Pedimentos.txtexento4.Visible = False
                Pedimentos.textgravado4.Visible = False
                Pedimentos.textIva_GT2_4.Visible = False
                Pedimentos.txtTotalGT_4.Visible = False
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.txtdesc5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtconcepto5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.txtexento5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.textgravado5.Text = tabla2.Rows(4)(3).ToString
                Pedimentos.textIva_GT2_5.Text = tabla2.Rows(4)(4).ToString
                Pedimentos.txtTotalGT_5.Text = tabla2.Rows(4)(5).ToString
                 Pedimentos.Textid3_5.Text = tabla2.Rows(4)(7).ToString
                Pedimentos.numtext5.Visible = True
                Pedimentos.txtdesc5.Visible = True
                Pedimentos.txtconcepto5.Visible = True
                Pedimentos.txtexento5.Visible = True
                Pedimentos.textgravado5.Visible = True
                Pedimentos.textIva_GT2_5.Visible = True
                Pedimentos.txtTotalGT_5.Visible = True
            Else
                Pedimentos.numtext5.Visible = False
                Pedimentos.txtdesc5.Visible = False
                Pedimentos.txtconcepto5.Visible = False
                Pedimentos.txtexento5.Visible = False
                Pedimentos.textgravado5.Visible = False
                Pedimentos.textIva_GT2_5.Visible = False
                Pedimentos.txtTotalGT_5.Visible = False
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.txtdesc6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtconcepto6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.txtexento6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.textgravado6.Text = tabla2.Rows(5)(3).ToString
                Pedimentos.textIva_GT2_6.Text = tabla2.Rows(5)(4).ToString
                Pedimentos.txtTotalGT_6.Text = tabla2.Rows(5)(5).ToString
                Pedimentos.Textid3_6.Text = tabla2.Rows(5)(7).ToString
                Pedimentos.numtext6.Visible = True
                Pedimentos.txtdesc6.Visible = True
                Pedimentos.txtconcepto6.Visible = True
                Pedimentos.txtexento6.Visible = True
                Pedimentos.textgravado6.Visible = True
                Pedimentos.textIva_GT2_6.Visible = True
                Pedimentos.txtTotalGT_6.Visible = True
            Else
                Pedimentos.numtext6.Visible = False
                Pedimentos.txtdesc6.Visible = False
                Pedimentos.txtconcepto6.Visible = False
                Pedimentos.txtexento6.Visible = False
                Pedimentos.textgravado6.Visible = False
                Pedimentos.textIva_GT2_6.Visible = False
                Pedimentos.txtTotalGT_6.Visible = False
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.txtdesc7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtconcepto7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.txtexento7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.textgravado7.Text = tabla2.Rows(6)(3).ToString
                Pedimentos.textIva_GT2_7.Text = tabla2.Rows(6)(4).ToString
                Pedimentos.txtTotalGT_7.Text = tabla2.Rows(6)(5).ToString
                Pedimentos.Textid3_7.Text = tabla2.Rows(6)(7).ToString
                Pedimentos.numtext7.Visible = True
                Pedimentos.txtdesc7.Visible = True
                Pedimentos.txtconcepto7.Visible = True
                Pedimentos.txtexento7.Visible = True
                Pedimentos.textgravado7.Visible = True
                Pedimentos.textIva_GT2_7.Visible = True
                Pedimentos.txtTotalGT_7.Visible = True
            Else
                Pedimentos.numtext7.Visible = False
                Pedimentos.txtdesc7.Visible = False
                Pedimentos.txtconcepto7.Visible = False
                Pedimentos.txtexento7.Visible = False
                Pedimentos.textgravado7.Visible = False
                Pedimentos.textIva_GT2_7.Visible = False
                Pedimentos.txtTotalGT_7.Visible = False
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.txtdesc8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtconcepto8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.txtexento8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.textgravado8.Text = tabla2.Rows(7)(3).ToString
                Pedimentos.textIva_GT2_8.Text = tabla2.Rows(7)(4).ToString
                Pedimentos.txtTotalGT_8.Text = tabla2.Rows(7)(5).ToString
                Pedimentos.Textid3_8.Text = tabla2.Rows(7)(7).ToString
                Pedimentos.numtext8.Visible = True
                Pedimentos.txtdesc8.Visible = True
                Pedimentos.txtconcepto8.Visible = True
                Pedimentos.txtexento8.Visible = True
                Pedimentos.textgravado8.Visible = True
                Pedimentos.textIva_GT2_8.Visible = True
                Pedimentos.txtTotalGT_8.Visible = True
            Else
                Pedimentos.numtext8.Visible = False
                Pedimentos.txtdesc8.Visible = False
                Pedimentos.txtconcepto8.Visible = False
                Pedimentos.txtexento8.Visible = False
                Pedimentos.textgravado8.Visible = False
                Pedimentos.textIva_GT2_8.Visible = False
                Pedimentos.txtTotalGT_8.Visible = False
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.txtdesc9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtconcepto9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.txtexento9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.textgravado9.Text = tabla2.Rows(8)(3).ToString
                Pedimentos.textIva_GT2_9.Text = tabla2.Rows(8)(4).ToString
                Pedimentos.txtTotalGT_9.Text = tabla2.Rows(8)(5).ToString
                Pedimentos.Textid3_9.Text = tabla2.Rows(8)(7).ToString
                Pedimentos.numtext9.Visible = True
                Pedimentos.txtdesc9.Visible = True
                Pedimentos.txtconcepto9.Visible = True
                Pedimentos.txtexento9.Visible = True
                Pedimentos.textgravado9.Visible = True
                Pedimentos.textIva_GT2_9.Visible = True
                Pedimentos.txtTotalGT_9.Visible = True
            Else
                Pedimentos.numtext9.Visible = False
                Pedimentos.txtdesc9.Visible = False
                Pedimentos.txtconcepto9.Visible = False
                Pedimentos.txtexento9.Visible = False
                Pedimentos.textgravado9.Visible = False
                Pedimentos.textIva_GT2_9.Visible = False
                Pedimentos.txtTotalGT_9.Visible = False
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.txtdesc10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtconcepto10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.txtexento10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.textgravado10.Text = tabla2.Rows(9)(3).ToString
                Pedimentos.textIva_GT2_10.Text = tabla2.Rows(9)(4).ToString
                Pedimentos.txtTotalGT_10.Text = tabla2.Rows(9)(5).ToString
                Pedimentos.Textid3_10.Text = tabla2.Rows(9)(7).ToString
                Pedimentos.numtext10.Visible = True
                Pedimentos.txtdesc10.Visible = True
                Pedimentos.txtconcepto10.Visible = True
                Pedimentos.txtexento10.Visible = True
                Pedimentos.textgravado10.Visible = True
                Pedimentos.textIva_GT2_10.Visible = True
                Pedimentos.txtTotalGT_10.Visible = True
            Else
                Pedimentos.numtext10.Visible = False
                Pedimentos.txtdesc10.Visible = False
                Pedimentos.txtconcepto10.Visible = False
                Pedimentos.txtexento10.Visible = False
                Pedimentos.textgravado10.Visible = False
                Pedimentos.textIva_GT2_10.Visible = False
                Pedimentos.txtTotalGT_10.Visible = False
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
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.descripcion,
            CP.importe,
            CP.id_concepto
            from TB_Conceptos_Ped as CP
            where CP.seccion='Customs Brokerage' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
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
                Pedimentos.txtNumero2.Visible = True
                Pedimentos.textDescripcion2.Visible = True
                Pedimentos.textimporte2.Visible = True
            Else
                Pedimentos.txtNumero2.Visible = False
                Pedimentos.textDescripcion2.Visible = False
                Pedimentos.textimporte2.Visible = False
            End If
            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.textDescripcion3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.textimporte3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.Textid4_3.Text = tabla2.Rows(2)(2).ToString
                Pedimentos.txtNumero3.Visible = True
                Pedimentos.textDescripcion3.Visible = True
                Pedimentos.textimporte3.Visible = True
            Else
                Pedimentos.txtNumero3.Visible = False
                Pedimentos.textDescripcion3.Visible = False
                Pedimentos.textimporte3.Visible = False
            End If
            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.textDescripcion4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.textimporte4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.Textid4_4.Text = tabla2.Rows(3)(2).ToString
                Pedimentos.txtNumero4.Visible = True
                Pedimentos.textDescripcion4.Visible = True
                Pedimentos.textimporte4.Visible = True
            Else
                Pedimentos.txtNumero4.Visible = False
                Pedimentos.textDescripcion4.Visible = False
                Pedimentos.textimporte4.Visible = False
            End If
            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.textDescripcion5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.textimporte5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.Textid4_5.Text = tabla2.Rows(4)(2).ToString
                Pedimentos.txtNumero5.Visible = True
                Pedimentos.textDescripcion5.Visible = True
                Pedimentos.textimporte5.Visible = True
            Else
                Pedimentos.txtNumero5.Visible = False
                Pedimentos.textDescripcion5.Visible = False
                Pedimentos.textimporte5.Visible = False
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.textDescripcion6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.textimporte6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.Textid4_6.Text = tabla2.Rows(5)(2).ToString
                Pedimentos.txtNumero6.Visible = True
                Pedimentos.textDescripcion6.Visible = True
                Pedimentos.textimporte6.Visible = True
            Else
                Pedimentos.txtNumero6.Visible = False
                Pedimentos.textDescripcion6.Visible = False
                Pedimentos.textimporte6.Visible = False
            End If
            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.textDescripcion7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.textimporte7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.Textid4_7.Text = tabla2.Rows(6)(2).ToString
                Pedimentos.txtNumero7.Visible = True
                Pedimentos.textDescripcion7.Visible = True
                Pedimentos.textimporte7.Visible = True
            Else
                Pedimentos.txtNumero7.Visible = False
                Pedimentos.textDescripcion7.Visible = False
                Pedimentos.textimporte7.Visible = False
            End If
            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.textDescripcion8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.textimporte8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.Textid4_8.Text = tabla2.Rows(7)(2).ToString
                Pedimentos.txtNumero8.Visible = True
                Pedimentos.textDescripcion8.Visible = True
                Pedimentos.textimporte8.Visible = True
            Else
                Pedimentos.txtNumero8.Visible = False
                Pedimentos.textDescripcion8.Visible = False
                Pedimentos.textimporte8.Visible = False
            End If
            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.textDescripcion9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.textimporte9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.Textid4_9.Text = tabla2.Rows(8)(2).ToString
                Pedimentos.txtNumero9.Visible = True
                Pedimentos.textDescripcion9.Visible = True
                Pedimentos.textimporte9.Visible = True
            Else
                Pedimentos.txtNumero9.Visible = False
                Pedimentos.textDescripcion9.Visible = False
                Pedimentos.textimporte9.Visible = False
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.textDescripcion10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.textimporte10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.Textid4_10.Text = tabla2.Rows(9)(2).ToString
                Pedimentos.txtNumero10.Visible = True
                Pedimentos.textDescripcion10.Visible = True
                Pedimentos.textimporte10.Visible = True
            Else
                Pedimentos.txtNumero10.Visible = False
                Pedimentos.textDescripcion10.Visible = False
                Pedimentos.textimporte10.Visible = False
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
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da2 As New SqlDataAdapter
            conexxo.Open()

            Dim comando2 As New SqlCommand("select
            CP.descripcion,
            CP.importe,
            CP.id_concepto,
            CP.retenciones,
            CP.tc_flete,
            CP.usd_flete
            from TB_Conceptos_Ped as CP
            where CP.seccion='Fletes y Seguros' and CP.pedimento='" + codigo + "' and CP.codigoPed='" + codigo_principal + "'", conexxo)
            da2.SelectCommand = comando2
            da2.Fill(tabla2)

            If (tabla2.Rows.Count >= 1) Then
                Pedimentos.textdescripFS1.Text = tabla2.Rows(0)(0).ToString
                Pedimentos.txtimporteFS1.Text = tabla2.Rows(0)(1).ToString
                Pedimentos.Textid5_1.Text = tabla2.Rows(0)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(0)(3).ToString = 0 Then
                    Pedimentos.retencionCheck1.Checked = False
                    Pedimentos.txtRetenciones1.Text = tabla2.Rows(0)(3).ToString
                Else
                    Pedimentos.retencionCheck1.Checked = True
                    Pedimentos.txtRetenciones1.Text = tabla2.Rows(0)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Pedimentos.txtTCFlete1.Text = tabla2.Rows(0)(4).ToString
                Pedimentos.TextUSDFLE1.Text = tabla2.Rows(0)(5).ToString
            End If

            If (tabla2.Rows.Count >= 2) Then
                Pedimentos.textdescripFS2.Text = tabla2.Rows(1)(0).ToString
                Pedimentos.txtimporteFS2.Text = tabla2.Rows(1)(1).ToString
                Pedimentos.Textid5_2.Text = tabla2.Rows(1)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(1)(3).ToString = 0 Then
                    Pedimentos.retencionCheck2.Checked = False
                    Pedimentos.txtRetenciones2.Text = tabla2.Rows(1)(3).ToString

                Else
                    Pedimentos.retencionCheck2.Checked = True
                    Pedimentos.txtRetenciones2.Text = tabla2.Rows(1)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Pedimentos.txtTCFlete2.Text = tabla2.Rows(1)(4).ToString
                Pedimentos.TextUSDFLE2.Text = tabla2.Rows(1)(5).ToString
                Pedimentos.textNumFS2.Visible = True
                Pedimentos.textdescripFS2.Visible = True
                Pedimentos.txtimporteFS2.Visible = True
                Pedimentos.txtIvaFS2.Visible = True
                Pedimentos.txtTotalFS2.Visible = True
                Pedimentos.txtRetenciones2.Visible = True
                Pedimentos.txtTCFlete2.Visible = True
                Pedimentos.TextUSDFLE2.Visible = True
                Pedimentos.retencionCheck2.Visible = True
            Else
                Pedimentos.textNumFS2.Visible = False
                Pedimentos.textdescripFS2.Visible = False
                Pedimentos.txtimporteFS2.Visible = False
                Pedimentos.txtIvaFS2.Visible = False
                Pedimentos.txtTotalFS2.Visible = False
                Pedimentos.txtRetenciones2.Visible = False
                Pedimentos.txtTCFlete2.Visible = False
                Pedimentos.TextUSDFLE2.Visible = False
                Pedimentos.retencionCheck2.Visible = False
            End If

            If (tabla2.Rows.Count >= 3) Then
                Pedimentos.textdescripFS3.Text = tabla2.Rows(2)(0).ToString
                Pedimentos.txtimporteFS3.Text = tabla2.Rows(2)(1).ToString
                Pedimentos.Textid5_3.Text = tabla2.Rows(2)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(2)(3).ToString = 0 Then
                    Pedimentos.retencionCheck3.Checked = False
                    Pedimentos.txtRetenciones3.Text = tabla2.Rows(2)(3).ToString
                Else
                    Pedimentos.retencionCheck3.Checked = True
                    Pedimentos.txtRetenciones3.Text = tabla2.Rows(2)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                ' Pedimentos.txtRetenciones3.Text = tabla2.Rows(2)(3).ToString
                Pedimentos.txtTCFlete3.Text = tabla2.Rows(2)(4).ToString
                Pedimentos.TextUSDFLE3.Text = tabla2.Rows(2)(5).ToString
                Pedimentos.textNumFS3.Visible = True
                Pedimentos.textdescripFS3.Visible = True
                Pedimentos.txtimporteFS3.Visible = True
                Pedimentos.txtIvaFS3.Visible = True
                Pedimentos.txtTotalFS3.Visible = True
                Pedimentos.txtRetenciones3.Visible = True
                Pedimentos.txtTCFlete3.Visible = True
                Pedimentos.TextUSDFLE3.Visible = True
                Pedimentos.retencionCheck3.Visible = True
            Else
                Pedimentos.textNumFS3.Visible = False
                Pedimentos.textdescripFS3.Visible = False
                Pedimentos.txtimporteFS3.Visible = False
                Pedimentos.txtIvaFS3.Visible = False
                Pedimentos.txtTotalFS3.Visible = False
                Pedimentos.txtRetenciones3.Visible = False
                Pedimentos.txtTCFlete3.Visible = False
                Pedimentos.TextUSDFLE3.Visible = False
                Pedimentos.retencionCheck3.Visible = False
            End If

            If (tabla2.Rows.Count >= 4) Then
                Pedimentos.textdescripFS4.Text = tabla2.Rows(3)(0).ToString
                Pedimentos.txtimporteFS4.Text = tabla2.Rows(3)(1).ToString
                Pedimentos.Textid5_4.Text = tabla2.Rows(3)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(3)(3).ToString = 0 Then
                    Pedimentos.retencionCheck4.Checked = False
                    Pedimentos.txtRetenciones4.Text = tabla2.Rows(3)(3).ToString
                Else
                    Pedimentos.retencionCheck4.Checked = True
                    Pedimentos.txtRetenciones4.Text = tabla2.Rows(3)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                'Pedimentos.txtRetenciones4.Text = tabla2.Rows(3)(3).ToString
                Pedimentos.txtTCFlete4.Text = tabla2.Rows(3)(4).ToString
                Pedimentos.TextUSDFLE4.Text = tabla2.Rows(3)(5).ToString
                Pedimentos.textNumFS4.Visible = True
                Pedimentos.textdescripFS4.Visible = True
                Pedimentos.txtimporteFS4.Visible = True
                Pedimentos.txtIvaFS4.Visible = True
                Pedimentos.txtTotalFS4.Visible = True
                Pedimentos.txtRetenciones4.Visible = True
                Pedimentos.txtTCFlete4.Visible = True
                Pedimentos.TextUSDFLE4.Visible = True
                Pedimentos.retencionCheck4.Visible = True
            Else
                Pedimentos.textNumFS4.Visible = False
                Pedimentos.textdescripFS4.Visible = False
                Pedimentos.txtimporteFS4.Visible = False
                Pedimentos.txtIvaFS4.Visible = False
                Pedimentos.txtTotalFS4.Visible = False
                Pedimentos.txtRetenciones4.Visible = False
                Pedimentos.txtTCFlete4.Visible = False
                Pedimentos.TextUSDFLE4.Visible = False
                Pedimentos.retencionCheck4.Visible = False
            End If

            If (tabla2.Rows.Count >= 5) Then
                Pedimentos.textdescripFS5.Text = tabla2.Rows(4)(0).ToString
                Pedimentos.txtimporteFS5.Text = tabla2.Rows(4)(1).ToString
                Pedimentos.Textid5_5.Text = tabla2.Rows(4)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(4)(3).ToString = 0 Then
                    Pedimentos.retencionCheck5.Checked = False
                    Pedimentos.txtRetenciones5.Text = tabla2.Rows(4)(3).ToString
                Else
                    Pedimentos.retencionCheck5.Checked = True
                    Pedimentos.txtRetenciones5.Text = tabla2.Rows(4)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                'Pedimentos.txtRetenciones5.Text = tabla2.Rows(4)(3).ToString
                Pedimentos.txtTCFlete5.Text = tabla2.Rows(4)(4).ToString
                Pedimentos.TextUSDFLE5.Text = tabla2.Rows(4)(5).ToString
                Pedimentos.textNumFS5.Visible = True
                Pedimentos.textdescripFS5.Visible = True
                Pedimentos.txtimporteFS5.Visible = True
                Pedimentos.txtIvaFS5.Visible = True
                Pedimentos.txtTotalFS5.Visible = True
                Pedimentos.txtRetenciones5.Visible = True
                Pedimentos.txtTCFlete5.Visible = True
                Pedimentos.TextUSDFLE5.Visible = True
                Pedimentos.retencionCheck5.Visible = True
            Else
                Pedimentos.textNumFS5.Visible = False
                Pedimentos.textdescripFS5.Visible = False
                Pedimentos.txtimporteFS5.Visible = False
                Pedimentos.txtIvaFS5.Visible = False
                Pedimentos.txtTotalFS5.Visible = False
                Pedimentos.txtRetenciones5.Visible = False
                Pedimentos.txtTCFlete5.Visible = False
                Pedimentos.TextUSDFLE5.Visible = False
                Pedimentos.retencionCheck5.Visible = False
            End If
            If (tabla2.Rows.Count >= 6) Then
                Pedimentos.textdescripFS6.Text = tabla2.Rows(5)(0).ToString
                Pedimentos.txtimporteFS6.Text = tabla2.Rows(5)(1).ToString
                Pedimentos.Textid5_6.Text = tabla2.Rows(5)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(5)(3).ToString = 0 Then
                    Pedimentos.retencionCheck6.Checked = False
                    Pedimentos.txtRetenciones6.Text = tabla2.Rows(5)(3).ToString
                Else
                    Pedimentos.retencionCheck6.Checked = True
                    Pedimentos.txtRetenciones6.Text = tabla2.Rows(5)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                'Pedimentos.txtRetenciones6.Text = tabla2.Rows(5)(3).ToString
                Pedimentos.txtTCFlete6.Text = tabla2.Rows(5)(4).ToString
                Pedimentos.TextUSDFLE6.Text = tabla2.Rows(5)(5).ToString
                Pedimentos.textNumFS6.Visible = True
                Pedimentos.textdescripFS6.Visible = True
                Pedimentos.txtimporteFS6.Visible = True
                Pedimentos.txtIvaFS6.Visible = True
                Pedimentos.txtTotalFS6.Visible = True
                Pedimentos.txtRetenciones6.Visible = True
                Pedimentos.txtTCFlete6.Visible = True
                Pedimentos.TextUSDFLE6.Visible = True
                Pedimentos.retencionCheck6.Visible = True
            Else
                Pedimentos.textNumFS6.Visible = False
                Pedimentos.textdescripFS6.Visible = False
                Pedimentos.txtimporteFS6.Visible = False
                Pedimentos.txtIvaFS6.Visible = False
                Pedimentos.txtTotalFS6.Visible = False
                Pedimentos.txtRetenciones6.Visible = False
                Pedimentos.txtTCFlete6.Visible = False
                Pedimentos.TextUSDFLE6.Visible = False
                Pedimentos.retencionCheck6.Visible = False
            End If

            If (tabla2.Rows.Count >= 7) Then
                Pedimentos.textdescripFS7.Text = tabla2.Rows(6)(0).ToString
                Pedimentos.txtimporteFS7.Text = tabla2.Rows(6)(1).ToString
                Pedimentos.Textid5_7.Text = tabla2.Rows(6)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(6)(3).ToString = 0 Then
                    Pedimentos.retencionCheck7.Checked = False
                    Pedimentos.txtRetenciones7.Text = tabla2.Rows(6)(3).ToString
                Else
                    Pedimentos.retencionCheck7.Checked = True
                    Pedimentos.txtRetenciones7.Text = tabla2.Rows(6)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                ' Pedimentos.txtRetenciones7.Text = tabla2.Rows(6)(3).ToString
                Pedimentos.txtTCFlete7.Text = tabla2.Rows(6)(4).ToString
                Pedimentos.TextUSDFLE7.Text = tabla2.Rows(6)(5).ToString
                Pedimentos.textNumFS7.Visible = True
                Pedimentos.textdescripFS7.Visible = True
                Pedimentos.txtimporteFS7.Visible = True
                Pedimentos.txtIvaFS7.Visible = True
                Pedimentos.txtTotalFS7.Visible = True
                Pedimentos.txtRetenciones7.Visible = True
                Pedimentos.txtTCFlete7.Visible = True
                Pedimentos.TextUSDFLE7.Visible = True
                Pedimentos.retencionCheck7.Visible = True
            Else
                Pedimentos.textNumFS7.Visible = False
                Pedimentos.textdescripFS7.Visible = False
                Pedimentos.txtimporteFS7.Visible = False
                Pedimentos.txtIvaFS7.Visible = False
                Pedimentos.txtTotalFS7.Visible = False
                Pedimentos.txtRetenciones7.Visible = False
                Pedimentos.txtTCFlete7.Visible = False
                Pedimentos.TextUSDFLE7.Visible = False
                Pedimentos.retencionCheck7.Visible = False
            End If

            If (tabla2.Rows.Count >= 8) Then
                Pedimentos.textdescripFS8.Text = tabla2.Rows(7)(0).ToString
                Pedimentos.txtimporteFS8.Text = tabla2.Rows(7)(1).ToString
                Pedimentos.Textid5_8.Text = tabla2.Rows(7)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(7)(3).ToString = 0 Then
                    Pedimentos.retencionCheck8.Checked = False
                    Pedimentos.txtRetenciones8.Text = tabla2.Rows(7)(3).ToString
                Else
                    Pedimentos.retencionCheck8.Checked = True
                    Pedimentos.txtRetenciones8.Text = tabla2.Rows(7)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                ' Pedimentos.txtRetenciones8.Text = tabla2.Rows(7)(3).ToString
                Pedimentos.txtTCFlete8.Text = tabla2.Rows(7)(4).ToString
                Pedimentos.TextUSDFLE8.Text = tabla2.Rows(7)(5).ToString
                Pedimentos.textNumFS8.Visible = True
                Pedimentos.textdescripFS8.Visible = True
                Pedimentos.txtimporteFS8.Visible = True
                Pedimentos.txtIvaFS8.Visible = True
                Pedimentos.txtTotalFS8.Visible = True
                Pedimentos.txtRetenciones8.Visible = True
                Pedimentos.txtTCFlete8.Visible = True
                Pedimentos.TextUSDFLE8.Visible = True
                Pedimentos.retencionCheck8.Visible = True
            Else
                Pedimentos.textNumFS8.Visible = False
                Pedimentos.textdescripFS8.Visible = False
                Pedimentos.txtimporteFS8.Visible = False
                Pedimentos.txtIvaFS8.Visible = False
                Pedimentos.txtTotalFS8.Visible = False
                Pedimentos.txtRetenciones8.Visible = False
                Pedimentos.txtTCFlete8.Visible = False
                Pedimentos.TextUSDFLE8.Visible = False
                Pedimentos.retencionCheck8.Visible = False
            End If

            If (tabla2.Rows.Count >= 9) Then
                Pedimentos.textdescripFS9.Text = tabla2.Rows(8)(0).ToString
                Pedimentos.txtimporteFS9.Text = tabla2.Rows(8)(1).ToString
                Pedimentos.Textid5_9.Text = tabla2.Rows(8)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(8)(3).ToString = 0 Then
                    Pedimentos.retencionCheck9.Checked = False
                    Pedimentos.txtRetenciones9.Text = tabla2.Rows(8)(3).ToString
                Else
                    Pedimentos.retencionCheck9.Checked = True
                    Pedimentos.txtRetenciones9.Text = tabla2.Rows(8)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Pedimentos.txtRetenciones9.Text = tabla2.Rows(8)(3).ToString
                Pedimentos.txtTCFlete9.Text = tabla2.Rows(8)(4).ToString
                Pedimentos.TextUSDFLE9.Text = tabla2.Rows(8)(5).ToString
                Pedimentos.textNumFS9.Visible = True
                Pedimentos.textdescripFS9.Visible = True
                Pedimentos.txtimporteFS9.Visible = True
                Pedimentos.txtIvaFS9.Visible = True
                Pedimentos.txtTotalFS9.Visible = True
                Pedimentos.txtRetenciones9.Visible = True
                Pedimentos.txtTCFlete9.Visible = True
                Pedimentos.TextUSDFLE9.Visible = True
                Pedimentos.retencionCheck9.Visible = True
            Else
                Pedimentos.textNumFS9.Visible = False
                Pedimentos.textdescripFS9.Visible = False
                Pedimentos.txtimporteFS9.Visible = False
                Pedimentos.txtIvaFS9.Visible = False
                Pedimentos.txtTotalFS9.Visible = False
                Pedimentos.txtRetenciones9.Visible = False
                Pedimentos.txtTCFlete9.Visible = False
                Pedimentos.TextUSDFLE9.Visible = False
                Pedimentos.retencionCheck9.Visible = False
            End If
            If (tabla2.Rows.Count >= 10) Then
                Pedimentos.textdescripFS10.Text = tabla2.Rows(9)(0).ToString
                Pedimentos.txtimporteFS10.Text = tabla2.Rows(9)(1).ToString
                Pedimentos.Textid5_10.Text = tabla2.Rows(9)(2).ToString
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                If tabla2.Rows(9)(3).ToString = 0 Then
                    Pedimentos.retencionCheck10.Checked = False
                    Pedimentos.txtRetenciones10.Text = tabla2.Rows(9)(3).ToString
                Else
                    Pedimentos.retencionCheck10.Checked = True
                    Pedimentos.txtRetenciones10.Text = tabla2.Rows(9)(3).ToString
                End If
                ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
                Pedimentos.txtRetenciones10.Text = tabla2.Rows(9)(3).ToString
                Pedimentos.txtTCFlete10.Text = tabla2.Rows(9)(4).ToString
                Pedimentos.TextUSDFLE10.Text = tabla2.Rows(9)(5).ToString
                Pedimentos.textNumFS10.Visible = True
                Pedimentos.textdescripFS10.Visible = True
                Pedimentos.txtimporteFS10.Visible = True
                Pedimentos.txtIvaFS10.Visible = True
                Pedimentos.txtTotalFS10.Visible = True
                Pedimentos.txtRetenciones10.Visible = True
                Pedimentos.txtTCFlete10.Visible = True
                Pedimentos.TextUSDFLE10.Visible = True
                Pedimentos.retencionCheck10.Visible = True
            Else
                Pedimentos.textNumFS10.Visible = False
                Pedimentos.textdescripFS10.Visible = False
                Pedimentos.txtimporteFS10.Visible = False
                Pedimentos.txtIvaFS10.Visible = False
                Pedimentos.txtTotalFS10.Visible = False
                Pedimentos.txtRetenciones10.Visible = False
                Pedimentos.txtTCFlete10.Visible = False
                Pedimentos.TextUSDFLE10.Visible = False
                Pedimentos.retencionCheck10.Visible = False
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '------------------------------------------------------------------------------------------------------------------
    End Sub

    Private Sub btn_BuscarOc_Click(sender As Object, e As EventArgs) Handles btn_BuscarOc.Click
        RegistrosOrdCom.ShowDialog()
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

End Class