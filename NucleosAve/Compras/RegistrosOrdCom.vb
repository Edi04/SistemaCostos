Imports System.Data.SqlClient '<---para poder realizar la coneccion con la bd importar esta linea
Public Class RegistrosOrdCom
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Private Sub RegistrosOrdCom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuevo(False)
    End Sub

    Sub MostrarRegOrdC()
        Try
            Dim Func As New Funcion_Registros
            tabla = Func.FnMostrarORDcompra
            If tabla.Rows.Count <> 0 Then
                DataGridRegistrosOd.DataSource = tabla
            Else
                DataGridRegistrosOd.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
    'para comensar la modificacion lo que nesesit6amos es irnos a propiedades del data grid 
    'al rayito y seleccionar el cell click en donde al seleccionar nos dara los datos de la 
    'fila que seleccionemos
    Public Sub DataGridRegistrosOd_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRegistrosOd.CellClick
        OrdCompra.TextMoneda.Clear()
        OrdCompra.check_Mxn.Checked = False
        OrdCompra.check_Euro.Checked = False
        OrdCompra.check_Usd.Checked = False

        OrdCompra.btn_enviarmail.Visible = True
        OrdCompra.btnEliminar.Visible = True
        OrdCompra.Label6.Visible = True
        OrdCompra.btnModificar.Visible = True
        OrdCompra.Label5.Visible = True

        OrdCompra.PictureBox5.Visible = False
        OrdCompra.Label8.Visible = False

        OrdCompra.TextCodigo.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value
        RegistrosPedimentos.textBuscar.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value
        OrdCompra.TextCodigo.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value
        ReporteOrd.Textbuscar.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value
        factura.txtOrdenCompra.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value
        Pedimentos.TexOrdenC.Text = DataGridRegistrosOd.CurrentRow.Cells(0).Value

        Try
            Call nuevo(True)
            Dim tabla As New DataTable
            Dim codigo As String
            codigo = OrdCompra.TextCodigo.Text
            Dim conexxo As New SqlConnection(conexioncita)
            Dim da As New SqlDataAdapter
            conexxo.Open()
            Dim comando As New SqlCommand("select 
            O.codigo,
            O.fecha2_nota,
            O.id_pro,
            O.purchase_order,
            O.place_delivery,
            O.req_compra,cif,
            O.delivery_time,
            O.boarding,
            O.payment_conditions,
            O.buyer,
            O.approved,
            O.personal_seller,
            O.subtotal,
            O.iva,
            O.total,
            O.total_letter,
            od.id_pro,
            od.descripcion,
            od.cantidad,
            od.precio,
            od.subtotal,
            od.Um,
            O.Moneda,
            od.detalles,
            O.observaciones
            from TB_Ordenes_Compra AS O
            INNER JOIN TB_Ordenes_Detalle as od on o.codigo=od.codigo
            where od.codigo='" + codigo + "'", conexxo)
            da.SelectCommand = comando
            da.Fill(tabla)
            If (tabla.Rows.Count <> 0) Then
                OrdCompra.DateFechaOrden.Value = tabla.Rows(0)(1).ToString
                OrdCompra.ComboBoxProveedores.SelectedValue = tabla.Rows(0)(2).ToString
                OrdCompra.TextPurchase.Text = tabla.Rows(0)(3).ToString
                OrdCompra.TextPlaceDelivery.Text = tabla.Rows(0)(4).ToString
                OrdCompra.TexReqCompra.Text = tabla.Rows(0)(5).ToString
                OrdCompra.TextCif.Text = tabla.Rows(0)(6).ToString
                OrdCompra.TextDeliverytime.Text = tabla.Rows(0)(7).ToString
                OrdCompra.TextBoarding.Text = tabla.Rows(0)(8).ToString
                OrdCompra.TextPaymentConditions.Text = tabla.Rows(0)(9).ToString
                OrdCompra.TextBuyer.Text = tabla.Rows(0)(10).ToString
                OrdCompra.TextApproved.Text = tabla.Rows(0)(11).ToString
                OrdCompra.TextPersonalSeller.Text = tabla.Rows(0)(12).ToString
                OrdCompra.TextSubtotal.Text = tabla.Rows(0)(13).ToString
                OrdCompra.TextIva.Text = tabla.Rows(0)(14).ToString
                OrdCompra.TextTotalFinal.Text = tabla.Rows(0)(15).ToString
                OrdCompra.TextTotalLetra.Text = tabla.Rows(0)(16).ToString
                OrdCompra.TextMoneda.Text = tabla.Rows(0)(23).ToString
                OrdCompra.TextBox_observaciones.Text = tabla.Rows(0)(25).ToString

            End If
            If (tabla.Rows.Count >= 1) Then
                'producto 1
                OrdCompra.ComboBoxProducto1.Text = tabla.Rows(0)(18).ToString
                OrdCompra.TextQuantity1.Text = tabla.Rows(0)(19).ToString
                OrdCompra.TextUnitPrice1.Text = tabla.Rows(0)(20).ToString
                OrdCompra.TextTotal1.Text = tabla.Rows(0)(21).ToString
                OrdCompra.TextUm1.Text = tabla.Rows(0)(22).ToString
                OrdCompra.TextBox_detalles1.Text = tabla.Rows(0)(24).ToString
                'id del producto
                OrdCompra.TId1.Text = tabla.Rows(0)(17).ToString

                OrdCompra.TextNum1.Visible = True
                OrdCompra.ComboBoxProducto1.Visible = True
                OrdCompra.TextQuantity1.Visible = True
                OrdCompra.TextUnitPrice1.Visible = True
                OrdCompra.TextTotal1.Visible = True
                OrdCompra.TextUm1.Visible = True
                OrdCompra.TextBox_detalles1.Visible = True


                OrdCompra.TextNum2.Visible = False
                OrdCompra.ComboBoxProducto2.Visible = False
                OrdCompra.TextQuantity2.Visible = False
                OrdCompra.TextUnitPrice2.Visible = False
                OrdCompra.TextTotal2.Visible = False
                OrdCompra.TextUm2.Visible = False
                OrdCompra.TextBox_detalles2.Visible = False


                OrdCompra.TextQuantity2.Clear()
                OrdCompra.TextUnitPrice2.Clear()
                OrdCompra.TextTotal2.Clear()
                OrdCompra.TextUm2.Clear()
                OrdCompra.TextBox_detalles2.Clear()


                OrdCompra.TextNum3.Visible = False
                OrdCompra.ComboBoxProducto3.Visible = False
                OrdCompra.TextQuantity3.Visible = False
                OrdCompra.TextUnitPrice3.Visible = False
                OrdCompra.TextTotal3.Visible = False
                OrdCompra.TextUm3.Visible = False
                OrdCompra.TextBox_detalles3.Visible = False


                OrdCompra.TextQuantity3.Clear()
                OrdCompra.TextUnitPrice3.Clear()
                OrdCompra.TextTotal3.Clear()
                OrdCompra.TextUm3.Clear()
                 OrdCompra.TextBox_detalles3.Clear()


                OrdCompra.TextNum4.Visible = False
                OrdCompra.ComboBoxProducto4.Visible = False
                OrdCompra.TextQuantity4.Visible = False
                OrdCompra.TextUnitPrice4.Visible = False
                OrdCompra.TextTotal4.Visible = False
                OrdCompra.TextUm4.Visible = False
                OrdCompra.TextBox_detalles4.Visible = False


                OrdCompra.TextQuantity4.Clear()
                OrdCompra.TextUnitPrice4.Clear()
                OrdCompra.TextTotal4.Clear()
                OrdCompra.TextUm4.Clear()
                OrdCompra.TextBox_detalles4.Clear()

                OrdCompra.TextNum5.Visible = False
                OrdCompra.ComboBoxProducto5.Visible = False
                OrdCompra.TextQuantity5.Visible = False
                OrdCompra.TextUnitPrice5.Visible = False
                OrdCompra.TextTotal5.Visible = False
                OrdCompra.TextUm5.Visible = False
                OrdCompra.TextBox_detalles5.Visible = False

                OrdCompra.TextQuantity5.Clear()
                OrdCompra.TextUnitPrice5.Clear()
                OrdCompra.TextTotal5.Clear()
                OrdCompra.TextUm5.Clear()
                OrdCompra.TextBox_detalles5.Clear()

                OrdCompra.TextNum6.Visible = False
                OrdCompra.ComboBoxProducto6.Visible = False
                OrdCompra.TextQuantity6.Visible = False
                OrdCompra.TextUnitPrice6.Visible = False
                OrdCompra.TextTotal6.Visible = False
                OrdCompra.TextUm6.Visible = False
                OrdCompra.TextBox_detalles6.Visible = False

                OrdCompra.TextQuantity6.Clear()
                OrdCompra.TextUnitPrice6.Clear()
                OrdCompra.TextTotal6.Clear()
                OrdCompra.TextUm6.Clear()
                OrdCompra.TextBox_detalles6.Clear()


                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()



            End If

            If (tabla.Rows.Count >= 2) Then
                'producto 2
                OrdCompra.ComboBoxProducto2.Text = tabla.Rows(1)(18).ToString
                OrdCompra.TextQuantity2.Text = tabla.Rows(1)(19).ToString
                OrdCompra.TextUnitPrice2.Text = tabla.Rows(1)(20).ToString
                OrdCompra.TextTotal2.Text = tabla.Rows(1)(21).ToString
                OrdCompra.TextUm2.Text = tabla.Rows(1)(22).ToString
                OrdCompra.TextBox_detalles2.Text = tabla.Rows(1)(24).ToString
                'id del producto
                OrdCompra.TId2.Text = tabla.Rows(1)(17).ToString

                OrdCompra.TextNum2.Visible = True
                OrdCompra.ComboBoxProducto2.Visible = True
                OrdCompra.TextQuantity2.Visible = True
                OrdCompra.TextUnitPrice2.Visible = True
                OrdCompra.TextTotal2.Visible = True
                OrdCompra.TextUm2.Visible = True
                OrdCompra.TextBox_detalles2.Visible = True


                OrdCompra.TextNum3.Visible = False
                OrdCompra.ComboBoxProducto3.Visible = False
                OrdCompra.TextQuantity3.Visible = False
                OrdCompra.TextUnitPrice3.Visible = False
                OrdCompra.TextTotal3.Visible = False
                OrdCompra.TextUm3.Visible = False
                OrdCompra.TextBox_detalles3.Visible = False


                OrdCompra.TextQuantity3.Clear()
                OrdCompra.TextUnitPrice3.Clear()
                OrdCompra.TextTotal3.Clear()
                OrdCompra.TextUm3.Clear()
                OrdCompra.TextBox_detalles3.Clear()


                OrdCompra.TextNum4.Visible = False
                OrdCompra.ComboBoxProducto4.Visible = False
                OrdCompra.TextQuantity4.Visible = False
                OrdCompra.TextUnitPrice4.Visible = False
                OrdCompra.TextTotal4.Visible = False
                OrdCompra.TextUm4.Visible = False
                OrdCompra.TextBox_detalles4.Visible = False


                OrdCompra.TextQuantity4.Clear()
                OrdCompra.TextUnitPrice4.Clear()
                OrdCompra.TextTotal4.Clear()
                OrdCompra.TextUm4.Clear()
                OrdCompra.TextBox_detalles4.Clear()

                OrdCompra.TextNum5.Visible = False
                OrdCompra.ComboBoxProducto5.Visible = False
                OrdCompra.TextQuantity5.Visible = False
                OrdCompra.TextUnitPrice5.Visible = False
                OrdCompra.TextTotal5.Visible = False
                OrdCompra.TextUm5.Visible = False
                OrdCompra.TextBox_detalles5.Visible = False

                OrdCompra.TextQuantity5.Clear()
                OrdCompra.TextUnitPrice5.Clear()
                OrdCompra.TextTotal5.Clear()
                OrdCompra.TextUm5.Clear()
                OrdCompra.TextBox_detalles5.Clear()

                OrdCompra.TextNum6.Visible = False
                OrdCompra.ComboBoxProducto6.Visible = False
                OrdCompra.TextQuantity6.Visible = False
                OrdCompra.TextUnitPrice6.Visible = False
                OrdCompra.TextTotal6.Visible = False
                OrdCompra.TextUm6.Visible = False
                OrdCompra.TextBox_detalles6.Visible = False

                OrdCompra.TextQuantity6.Clear()
                OrdCompra.TextUnitPrice6.Clear()
                OrdCompra.TextTotal6.Clear()
                OrdCompra.TextUm6.Clear()
                OrdCompra.TextBox_detalles6.Clear()


                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If


            If (tabla.Rows.Count >= 3) Then
                'producto 3
                OrdCompra.ComboBoxProducto3.Text = tabla.Rows(2)(18).ToString
                OrdCompra.TextQuantity3.Text = tabla.Rows(2)(19).ToString
                OrdCompra.TextUnitPrice3.Text = tabla.Rows(2)(20).ToString
                OrdCompra.TextTotal3.Text = tabla.Rows(2)(21).ToString
                OrdCompra.TextUm3.Text = tabla.Rows(2)(22).ToString
                OrdCompra.TextBox_detalles3.Text = tabla.Rows(2)(24).ToString
                'id del producto
                OrdCompra.TId3.Text = tabla.Rows(2)(17).ToString

                OrdCompra.TextNum3.Visible = True
                OrdCompra.ComboBoxProducto3.Visible = True
                OrdCompra.TextQuantity3.Visible = True
                OrdCompra.TextUnitPrice3.Visible = True
                OrdCompra.TextTotal3.Visible = True
                OrdCompra.TextUm3.Visible = True
                OrdCompra.TextBox_detalles3.Visible = True

                OrdCompra.TextNum4.Visible = False
                OrdCompra.ComboBoxProducto4.Visible = False
                OrdCompra.TextQuantity4.Visible = False
                OrdCompra.TextUnitPrice4.Visible = False
                OrdCompra.TextTotal4.Visible = False
                OrdCompra.TextUm4.Visible = False
                OrdCompra.TextBox_detalles4.Visible = False


                OrdCompra.TextQuantity4.Clear()
                OrdCompra.TextUnitPrice4.Clear()
                OrdCompra.TextTotal4.Clear()
                OrdCompra.TextUm4.Clear()
                OrdCompra.TextBox_detalles4.Clear()

                OrdCompra.TextNum5.Visible = False
                OrdCompra.ComboBoxProducto5.Visible = False
                OrdCompra.TextQuantity5.Visible = False
                OrdCompra.TextUnitPrice5.Visible = False
                OrdCompra.TextTotal5.Visible = False
                OrdCompra.TextUm5.Visible = False
                OrdCompra.TextBox_detalles5.Visible = False

                OrdCompra.TextQuantity5.Clear()
                OrdCompra.TextUnitPrice5.Clear()
                OrdCompra.TextTotal5.Clear()
                OrdCompra.TextUm5.Clear()
                OrdCompra.TextBox_detalles5.Clear()

                OrdCompra.TextNum6.Visible = False
                OrdCompra.ComboBoxProducto6.Visible = False
                OrdCompra.TextQuantity6.Visible = False
                OrdCompra.TextUnitPrice6.Visible = False
                OrdCompra.TextTotal6.Visible = False
                OrdCompra.TextUm6.Visible = False
                OrdCompra.TextBox_detalles6.Visible = False

                OrdCompra.TextQuantity6.Clear()
                OrdCompra.TextUnitPrice6.Clear()
                OrdCompra.TextTotal6.Clear()
                OrdCompra.TextUm6.Clear()
                OrdCompra.TextBox_detalles6.Clear()


                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 4) Then
                'producto 4
                OrdCompra.ComboBoxProducto4.Text = tabla.Rows(3)(18).ToString
                OrdCompra.TextQuantity4.Text = tabla.Rows(3)(19).ToString
                OrdCompra.TextUnitPrice4.Text = tabla.Rows(3)(20).ToString
                OrdCompra.TextTotal4.Text = tabla.Rows(3)(21).ToString
                OrdCompra.TextUm4.Text = tabla.Rows(3)(22).ToString
                OrdCompra.TextBox_detalles4.Text = tabla.Rows(3)(24).ToString
                'id del producto
                OrdCompra.TId4.Text = tabla.Rows(3)(17).ToString

                OrdCompra.TextNum4.Visible = True
                OrdCompra.ComboBoxProducto4.Visible = True
                OrdCompra.TextQuantity4.Visible = True
                OrdCompra.TextUnitPrice4.Visible = True
                OrdCompra.TextTotal4.Visible = True
                OrdCompra.TextUm4.Visible = True
                OrdCompra.TextBox_detalles4.Visible = True

                OrdCompra.TextNum5.Visible = False
                OrdCompra.ComboBoxProducto5.Visible = False
                OrdCompra.TextQuantity5.Visible = False
                OrdCompra.TextUnitPrice5.Visible = False
                OrdCompra.TextTotal5.Visible = False
                OrdCompra.TextUm5.Visible = False
                OrdCompra.TextBox_detalles5.Visible = False

                OrdCompra.TextQuantity5.Clear()
                OrdCompra.TextUnitPrice5.Clear()
                OrdCompra.TextTotal5.Clear()
                OrdCompra.TextUm5.Clear()
                OrdCompra.TextBox_detalles5.Clear()

                OrdCompra.TextNum6.Visible = False
                OrdCompra.ComboBoxProducto6.Visible = False
                OrdCompra.TextQuantity6.Visible = False
                OrdCompra.TextUnitPrice6.Visible = False
                OrdCompra.TextTotal6.Visible = False
                OrdCompra.TextUm6.Visible = False
                OrdCompra.TextBox_detalles6.Visible = False

                OrdCompra.TextQuantity6.Clear()
                OrdCompra.TextUnitPrice6.Clear()
                OrdCompra.TextTotal6.Clear()
                OrdCompra.TextUm6.Clear()
                OrdCompra.TextBox_detalles6.Clear()


                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 5) Then
                'producto 5
                OrdCompra.ComboBoxProducto5.Text = tabla.Rows(4)(18).ToString
                OrdCompra.TextQuantity5.Text = tabla.Rows(4)(19).ToString
                OrdCompra.TextUnitPrice5.Text = tabla.Rows(4)(20).ToString
                OrdCompra.TextTotal5.Text = tabla.Rows(4)(21).ToString
                OrdCompra.TextUm5.Text = tabla.Rows(4)(22).ToString
                OrdCompra.TextBox_detalles5.Text = tabla.Rows(4)(24).ToString
                'id del producto
                OrdCompra.TId5.Text = tabla.Rows(4)(17).ToString

                OrdCompra.TextNum5.Visible = True
                OrdCompra.ComboBoxProducto5.Visible = True
                OrdCompra.TextQuantity5.Visible = True
                OrdCompra.TextUnitPrice5.Visible = True
                OrdCompra.TextTotal5.Visible = True
                OrdCompra.TextUm5.Visible = True
                OrdCompra.TextBox_detalles5.Visible = True

                OrdCompra.TextNum6.Visible = False
                OrdCompra.ComboBoxProducto6.Visible = False
                OrdCompra.TextQuantity6.Visible = False
                OrdCompra.TextUnitPrice6.Visible = False
                OrdCompra.TextTotal6.Visible = False
                OrdCompra.TextUm6.Visible = False
                OrdCompra.TextBox_detalles6.Visible = False

                OrdCompra.TextQuantity6.Clear()
                OrdCompra.TextUnitPrice6.Clear()
                OrdCompra.TextTotal6.Clear()
                OrdCompra.TextUm6.Clear()
                OrdCompra.TextBox_detalles6.Clear()


                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 6) Then
                'producto 6
                OrdCompra.ComboBoxProducto6.Text = tabla.Rows(5)(18).ToString
                OrdCompra.TextQuantity6.Text = tabla.Rows(5)(19).ToString
                OrdCompra.TextUnitPrice6.Text = tabla.Rows(5)(20).ToString
                OrdCompra.TextTotal6.Text = tabla.Rows(5)(21).ToString
                OrdCompra.TextUm6.Text = tabla.Rows(5)(22).ToString
                OrdCompra.TextBox_detalles6.Text = tabla.Rows(5)(24).ToString
                'id del producto
                OrdCompra.TId6.Text = tabla.Rows(5)(17).ToString


                OrdCompra.TextNum6.Visible = True
                OrdCompra.ComboBoxProducto6.Visible = True
                OrdCompra.TextQuantity6.Visible = True
                OrdCompra.TextUnitPrice6.Visible = True
                OrdCompra.TextTotal6.Visible = True
                OrdCompra.TextUm6.Visible = True
                OrdCompra.TextBox_detalles6.Visible = True

                OrdCompra.TextNum7.Visible = False
                OrdCompra.ComboBoxProducto7.Visible = False
                OrdCompra.TextQuantity7.Visible = False
                OrdCompra.TextUnitPrice7.Visible = False
                OrdCompra.TextTotal7.Visible = False
                OrdCompra.TextUm7.Visible = False
                OrdCompra.TextBox_detalles7.Visible = False

                OrdCompra.TextQuantity7.Clear()
                OrdCompra.TextUnitPrice7.Clear()
                OrdCompra.TextTotal7.Clear()
                OrdCompra.TextUm7.Clear()
                OrdCompra.TextBox_detalles7.Clear()


                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 7) Then
                'producto 7
                OrdCompra.ComboBoxProducto7.Text = tabla.Rows(6)(18).ToString
                OrdCompra.TextQuantity7.Text = tabla.Rows(6)(19).ToString
                OrdCompra.TextUnitPrice7.Text = tabla.Rows(6)(20).ToString
                OrdCompra.TextTotal7.Text = tabla.Rows(6)(21).ToString
                OrdCompra.TextUm7.Text = tabla.Rows(6)(22).ToString
                OrdCompra.TextBox_detalles7.Text = tabla.Rows(6)(24).ToString
                'id del producto
                OrdCompra.TId7.Text = tabla.Rows(6)(17).ToString


                OrdCompra.TextNum7.Visible = True
                OrdCompra.ComboBoxProducto7.Visible = True
                OrdCompra.TextQuantity7.Visible = True
                OrdCompra.TextUnitPrice7.Visible = True
                OrdCompra.TextTotal7.Visible = True
                OrdCompra.TextUm7.Visible = True
                OrdCompra.TextBox_detalles7.Visible = True

                OrdCompra.TextNum8.Visible = False
                OrdCompra.ComboBoxProducto8.Visible = False
                OrdCompra.TextQuantity8.Visible = False
                OrdCompra.TextUnitPrice8.Visible = False
                OrdCompra.TextTotal8.Visible = False
                OrdCompra.TextUm8.Visible = False
                OrdCompra.TextBox_detalles8.Visible = False

                OrdCompra.TextQuantity8.Clear()
                OrdCompra.TextUnitPrice8.Clear()
                OrdCompra.TextTotal8.Clear()
                OrdCompra.TextUm8.Clear()
                OrdCompra.TextBox_detalles8.Clear()


                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 8) Then
                'producto 8
                OrdCompra.ComboBoxProducto8.Text = tabla.Rows(7)(18).ToString
                OrdCompra.TextQuantity8.Text = tabla.Rows(7)(19).ToString
                OrdCompra.TextUnitPrice8.Text = tabla.Rows(7)(20).ToString
                OrdCompra.TextTotal8.Text = tabla.Rows(7)(21).ToString
                OrdCompra.TextUm8.Text = tabla.Rows(7)(22).ToString
                OrdCompra.TextBox_detalles8.Text = tabla.Rows(7)(24).ToString
                'id del producto
                OrdCompra.TId8.Text = tabla.Rows(7)(17).ToString

                OrdCompra.TextNum8.Visible = True
                OrdCompra.ComboBoxProducto8.Visible = True
                OrdCompra.TextQuantity8.Visible = True
                OrdCompra.TextUnitPrice8.Visible = True
                OrdCompra.TextTotal8.Visible = True
                OrdCompra.TextUm8.Visible = True
                OrdCompra.TextBox_detalles8.Visible = True

                OrdCompra.TextNum9.Visible = False
                OrdCompra.ComboBoxProducto9.Visible = False
                OrdCompra.TextQuantity9.Visible = False
                OrdCompra.TextUnitPrice9.Visible = False
                OrdCompra.TextTotal9.Visible = False
                OrdCompra.TextUm9.Visible = False
                OrdCompra.TextBox_detalles9.Visible = False


                OrdCompra.TextQuantity9.Clear()
                OrdCompra.TextUnitPrice9.Clear()
                OrdCompra.TextTotal9.Clear()
                OrdCompra.TextUm9.Clear()
                OrdCompra.TextBox_detalles9.Clear()


                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 9) Then
                'producto 9
                OrdCompra.ComboBoxProducto9.Text = tabla.Rows(8)(18).ToString
                OrdCompra.TextQuantity9.Text = tabla.Rows(8)(19).ToString
                OrdCompra.TextUnitPrice9.Text = tabla.Rows(8)(20).ToString
                OrdCompra.TextTotal9.Text = tabla.Rows(8)(21).ToString
                OrdCompra.TextUm9.Text = tabla.Rows(8)(22).ToString
                OrdCompra.TextBox_detalles9.Text = tabla.Rows(8)(24).ToString
                'id del producto
                OrdCompra.TId9.Text = tabla.Rows(8)(17).ToString


                OrdCompra.TextNum9.Visible = True
                OrdCompra.ComboBoxProducto9.Visible = True
                OrdCompra.TextQuantity9.Visible = True
                OrdCompra.TextUnitPrice9.Visible = True
                OrdCompra.TextTotal9.Visible = True
                OrdCompra.TextUm9.Visible = True
                OrdCompra.TextBox_detalles9.Visible = True

                OrdCompra.TextNum10.Visible = False
                OrdCompra.ComboBoxProducto10.Visible = False
                OrdCompra.TextQuantity10.Visible = False
                OrdCompra.TextUnitPrice10.Visible = False
                OrdCompra.TextTotal10.Visible = False
                OrdCompra.TextUm10.Visible = False
                OrdCompra.TextBox_detalles10.Visible = False

                OrdCompra.TextQuantity10.Clear()
                OrdCompra.TextUnitPrice10.Clear()
                OrdCompra.TextTotal10.Clear()
                OrdCompra.TextUm10.Clear()
                OrdCompra.TextBox_detalles10.Clear()

                'OrdCompra.TextNum11.Visible = False
                'OrdCompra.ComboBoxProducto11.Visible = False
                'OrdCompra.TextQuantity11.Visible = False
                'OrdCompra.TextUnitPrice11.Visible = False
                'OrdCompra.TextTotal11.Visible = False
                'OrdCompra.TextUm11.Visible = False

                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 10) Then
                'producto 10
                OrdCompra.ComboBoxProducto10.Text = tabla.Rows(9)(18).ToString
                OrdCompra.TextQuantity10.Text = tabla.Rows(9)(19).ToString
                OrdCompra.TextUnitPrice10.Text = tabla.Rows(9)(20).ToString
                OrdCompra.TextTotal10.Text = tabla.Rows(9)(21).ToString
                OrdCompra.TextUm10.Text = tabla.Rows(9)(22).ToString
                OrdCompra.TextBox_detalles10.Text = tabla.Rows(9)(24).ToString
                'id del producto
                OrdCompra.TId10.Text = tabla.Rows(9)(17).ToString

                OrdCompra.TextNum10.Visible = True
                OrdCompra.ComboBoxProducto10.Visible = True
                OrdCompra.TextQuantity10.Visible = True
                OrdCompra.TextUnitPrice10.Visible = True
                OrdCompra.TextTotal10.Visible = True
                OrdCompra.TextUm10.Visible = True
                OrdCompra.TextBox_detalles10.Visible = False

                '-------------------------------------------------------------
                OrdCompra.TextNum11.Visible = True
                OrdCompra.ComboBoxProducto11.Visible = True
                OrdCompra.TextQuantity11.Visible = True
                OrdCompra.TextUnitPrice11.Visible = True
                OrdCompra.TextTotal11.Visible = True
                OrdCompra.TextUm11.Visible = True
                OrdCompra.TextBox_detalles11.Visible = False


                OrdCompra.TextQuantity11.Clear()
                OrdCompra.TextUnitPrice11.Clear()
                OrdCompra.TextTotal11.Clear()
                OrdCompra.TextUm11.Clear()
                OrdCompra.TextBox_detalles11.Clear()

                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 11) Then
                'producto 11
                OrdCompra.ComboBoxProducto11.Text = tabla.Rows(10)(18).ToString
                OrdCompra.TextQuantity11.Text = tabla.Rows(10)(19).ToString
                OrdCompra.TextUnitPrice11.Text = tabla.Rows(10)(20).ToString
                OrdCompra.TextTotal11.Text = tabla.Rows(10)(21).ToString
                OrdCompra.TextUm11.Text = tabla.Rows(10)(22).ToString
                OrdCompra.TextBox_detalles11.Text = tabla.Rows(10)(24).ToString
                'id del producto
                OrdCompra.TId11.Text = tabla.Rows(10)(17).ToString

                OrdCompra.TextNum11.Visible = True
                OrdCompra.ComboBoxProducto11.Visible = True
                OrdCompra.TextQuantity11.Visible = True
                OrdCompra.TextUnitPrice11.Visible = True
                OrdCompra.TextTotal11.Visible = True
                OrdCompra.TextUm11.Visible = True
                OrdCompra.TextBox_detalles11.Visible = True


                OrdCompra.TextNum12.Visible = False
                OrdCompra.ComboBoxProducto12.Visible = False
                OrdCompra.TextQuantity12.Visible = False
                OrdCompra.TextUnitPrice12.Visible = False
                OrdCompra.TextTotal12.Visible = False
                OrdCompra.TextUm12.Visible = False
                OrdCompra.TextBox_detalles12.Visible = False

                OrdCompra.TextQuantity12.Clear()
                OrdCompra.TextUnitPrice12.Clear()
                OrdCompra.TextTotal12.Clear()
                OrdCompra.TextUm12.Clear()
                OrdCompra.TextBox_detalles12.Clear()

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 12) Then
                'producto 12
                OrdCompra.ComboBoxProducto12.Text = tabla.Rows(11)(18).ToString
                OrdCompra.TextQuantity12.Text = tabla.Rows(11)(19).ToString
                OrdCompra.TextUnitPrice12.Text = tabla.Rows(11)(20).ToString
                OrdCompra.TextTotal12.Text = tabla.Rows(11)(21).ToString
                OrdCompra.TextUm12.Text = tabla.Rows(11)(22).ToString
                OrdCompra.TextBox_detalles12.Text = tabla.Rows(11)(24).ToString
                'id del producto
                OrdCompra.TId12.Text = tabla.Rows(11)(17).ToString

                OrdCompra.TextNum12.Visible = True
                OrdCompra.ComboBoxProducto12.Visible = True
                OrdCompra.TextQuantity12.Visible = True
                OrdCompra.TextUnitPrice12.Visible = True
                OrdCompra.TextTotal12.Visible = True
                OrdCompra.TextUm12.Visible = True
                OrdCompra.TextBox_detalles12.Visible = True

                OrdCompra.TextNum13.Visible = False
                OrdCompra.ComboBoxProducto13.Visible = False
                OrdCompra.TextQuantity13.Visible = False
                OrdCompra.TextUnitPrice13.Visible = False
                OrdCompra.TextTotal13.Visible = False
                OrdCompra.TextUm13.Visible = False
                OrdCompra.TextBox_detalles13.Visible = False

                OrdCompra.TextQuantity13.Clear()
                OrdCompra.TextUnitPrice13.Clear()
                OrdCompra.TextTotal13.Clear()
                OrdCompra.TextUm13.Clear()
                OrdCompra.TextBox_detalles13.Clear()

                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()
            End If

            If (tabla.Rows.Count >= 13) Then
                'producto 13
                OrdCompra.ComboBoxProducto13.Text = tabla.Rows(12)(18).ToString
                OrdCompra.TextQuantity13.Text = tabla.Rows(12)(19).ToString
                OrdCompra.TextUnitPrice13.Text = tabla.Rows(12)(20).ToString
                OrdCompra.TextTotal13.Text = tabla.Rows(12)(21).ToString
                OrdCompra.TextUm13.Text = tabla.Rows(12)(22).ToString
                OrdCompra.TextBox_detalles13.Text = tabla.Rows(12)(24).ToString
                'id del producto
                OrdCompra.TId13.Text = tabla.Rows(12)(17).ToString

                OrdCompra.TextNum13.Visible = True
                OrdCompra.ComboBoxProducto13.Visible = True
                OrdCompra.TextQuantity13.Visible = True
                OrdCompra.TextUnitPrice13.Visible = True
                OrdCompra.TextTotal13.Visible = True
                OrdCompra.TextUm13.Visible = True
                OrdCompra.TextBox_detalles13.Visible = True



                OrdCompra.TextNum14.Visible = False
                OrdCompra.ComboBoxProducto14.Visible = False
                OrdCompra.TextQuantity14.Visible = False
                OrdCompra.TextUnitPrice14.Visible = False
                OrdCompra.TextTotal14.Visible = False
                OrdCompra.TextUm14.Visible = False
                OrdCompra.TextBox_detalles14.Visible = False

                OrdCompra.TextQuantity14.Clear()
                OrdCompra.TextUnitPrice14.Clear()
                OrdCompra.TextTotal14.Clear()
                OrdCompra.TextUm14.Clear()
                OrdCompra.TextBox_detalles14.Clear()


                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 14) Then
                'producto 14
                OrdCompra.ComboBoxProducto14.Text = tabla.Rows(13)(18).ToString
                OrdCompra.TextQuantity14.Text = tabla.Rows(13)(19).ToString
                OrdCompra.TextUnitPrice14.Text = tabla.Rows(13)(20).ToString
                OrdCompra.TextTotal14.Text = tabla.Rows(13)(21).ToString
                OrdCompra.TextUm14.Text = tabla.Rows(13)(22).ToString
                OrdCompra.TextBox_detalles14.Text = tabla.Rows(13)(24).ToString
                'id del producto
                OrdCompra.TId14.Text = tabla.Rows(13)(17).ToString

                OrdCompra.TextNum14.Visible = True
                OrdCompra.ComboBoxProducto14.Visible = True
                OrdCompra.TextQuantity14.Visible = True
                OrdCompra.TextUnitPrice14.Visible = True
                OrdCompra.TextTotal14.Visible = True
                OrdCompra.TextUm14.Visible = True
                OrdCompra.TextBox_detalles14.Visible = True

                OrdCompra.TextNum15.Visible = False
                OrdCompra.ComboBoxProducto15.Visible = False
                OrdCompra.TextQuantity15.Visible = False
                OrdCompra.TextUnitPrice15.Visible = False
                OrdCompra.TextTotal15.Visible = False
                OrdCompra.TextUm15.Visible = False
                OrdCompra.TextBox_detalles15.Visible = False


                OrdCompra.TextQuantity15.Clear()
                OrdCompra.TextUnitPrice15.Clear()
                OrdCompra.TextTotal15.Clear()
                OrdCompra.TextUm15.Clear()
                OrdCompra.TextBox_detalles15.Clear()


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()


            End If
            If (tabla.Rows.Count >= 15) Then
                'producto 15
                OrdCompra.ComboBoxProducto15.Text = tabla.Rows(14)(18).ToString
                OrdCompra.TextQuantity15.Text = tabla.Rows(14)(19).ToString
                OrdCompra.TextUnitPrice15.Text = tabla.Rows(14)(20).ToString
                OrdCompra.TextTotal15.Text = tabla.Rows(14)(21).ToString
                OrdCompra.TextUm15.Text = tabla.Rows(14)(22).ToString
                OrdCompra.TextBox_detalles15.Text = tabla.Rows(14)(24).ToString
                'id del producto
                OrdCompra.TId15.Text = tabla.Rows(14)(17).ToString

                OrdCompra.TextNum15.Visible = True
                OrdCompra.ComboBoxProducto15.Visible = True
                OrdCompra.TextQuantity15.Visible = True
                OrdCompra.TextUnitPrice15.Visible = True
                OrdCompra.TextTotal15.Visible = True
                OrdCompra.TextUm15.Visible = True
                OrdCompra.TextBox_detalles15.Visible = True


                OrdCompra.TextNum16.Visible = False
                OrdCompra.ComboBoxProducto16.Visible = False
                OrdCompra.TextQuantity16.Visible = False
                OrdCompra.TextUnitPrice16.Visible = False
                OrdCompra.TextTotal16.Visible = False
                OrdCompra.TextUm16.Visible = False
                OrdCompra.TextBox_detalles16.Visible = False


                OrdCompra.TextQuantity16.Clear()
                OrdCompra.TextUnitPrice16.Clear()
                OrdCompra.TextTotal16.Clear()
                OrdCompra.TextUm16.Clear()
                OrdCompra.TextBox_detalles16.Clear()


                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 16) Then
                'producto 16
                OrdCompra.ComboBoxProducto16.Text = tabla.Rows(15)(18).ToString
                OrdCompra.TextQuantity16.Text = tabla.Rows(15)(19).ToString
                OrdCompra.TextUnitPrice16.Text = tabla.Rows(15)(20).ToString
                OrdCompra.TextTotal16.Text = tabla.Rows(15)(21).ToString
                OrdCompra.TextUm16.Text = tabla.Rows(15)(22).ToString
                OrdCompra.TextBox_detalles16.Text = tabla.Rows(15)(24).ToString
                'id del producto
                OrdCompra.TId16.Text = tabla.Rows(15)(17).ToString


                OrdCompra.TextNum16.Visible = True
                OrdCompra.ComboBoxProducto16.Visible = True
                OrdCompra.TextQuantity16.Visible = True
                OrdCompra.TextUnitPrice16.Visible = True
                OrdCompra.TextTotal16.Visible = True
                OrdCompra.TextUm16.Visible = True
                OrdCompra.TextBox_detalles16.Visible = True

                OrdCompra.TextNum17.Visible = False
                OrdCompra.ComboBoxProducto17.Visible = False
                OrdCompra.TextQuantity17.Visible = False
                OrdCompra.TextUnitPrice17.Visible = False
                OrdCompra.TextTotal17.Visible = False
                OrdCompra.TextUm17.Visible = False
                OrdCompra.TextBox_detalles17.Visible = False


                OrdCompra.TextQuantity17.Clear()
                OrdCompra.TextUnitPrice17.Clear()
                OrdCompra.TextTotal17.Clear()
                OrdCompra.TextUm17.Clear()
                OrdCompra.TextBox_detalles17.Clear()

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 17) Then
                'producto 17
                OrdCompra.ComboBoxProducto17.Text = tabla.Rows(16)(18).ToString
                OrdCompra.TextQuantity17.Text = tabla.Rows(16)(19).ToString
                OrdCompra.TextUnitPrice17.Text = tabla.Rows(16)(20).ToString
                OrdCompra.TextTotal17.Text = tabla.Rows(16)(21).ToString
                OrdCompra.TextUm17.Text = tabla.Rows(16)(22).ToString
                OrdCompra.TextBox_detalles17.Text = tabla.Rows(16)(24).ToString
                'id del producto
                OrdCompra.TId17.Text = tabla.Rows(16)(17).ToString


                OrdCompra.TextNum17.Visible = True
                OrdCompra.ComboBoxProducto17.Visible = True
                OrdCompra.TextQuantity17.Visible = True
                OrdCompra.TextUnitPrice17.Visible = True
                OrdCompra.TextTotal17.Visible = True
                OrdCompra.TextUm17.Visible = True
                OrdCompra.TextBox_detalles17.Visible = True

                OrdCompra.TextNum18.Visible = False
                OrdCompra.ComboBoxProducto18.Visible = False
                OrdCompra.TextQuantity18.Visible = False
                OrdCompra.TextUnitPrice18.Visible = False
                OrdCompra.TextTotal18.Visible = False
                OrdCompra.TextUm18.Visible = False
                OrdCompra.TextBox_detalles18.Visible = False


                OrdCompra.TextQuantity18.Clear()
                OrdCompra.TextUnitPrice18.Clear()
                OrdCompra.TextTotal18.Clear()
                OrdCompra.TextUm18.Clear()
                OrdCompra.TextBox_detalles18.Clear()


                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 18) Then
                'producto 18
                OrdCompra.ComboBoxProducto18.Text = tabla.Rows(17)(18).ToString
                OrdCompra.TextQuantity18.Text = tabla.Rows(17)(19).ToString
                OrdCompra.TextUnitPrice18.Text = tabla.Rows(17)(20).ToString
                OrdCompra.TextTotal18.Text = tabla.Rows(17)(21).ToString
                OrdCompra.TextUm18.Text = tabla.Rows(17)(22).ToString
                OrdCompra.TextBox_detalles18.Text = tabla.Rows(17)(24).ToString
                'id del producto
                OrdCompra.TId18.Text = tabla.Rows(17)(17).ToString

                OrdCompra.TextNum18.Visible = True
                OrdCompra.ComboBoxProducto18.Visible = True
                OrdCompra.TextQuantity18.Visible = True
                OrdCompra.TextUnitPrice18.Visible = True
                OrdCompra.TextTotal18.Visible = True
                OrdCompra.TextUm18.Visible = True
                OrdCompra.TextBox_detalles18.Visible = True

                OrdCompra.TextNum19.Visible = False
                OrdCompra.ComboBoxProducto19.Visible = False
                OrdCompra.TextQuantity19.Visible = False
                OrdCompra.TextUnitPrice19.Visible = False
                OrdCompra.TextTotal19.Visible = False
                OrdCompra.TextUm19.Visible = False
                OrdCompra.TextBox_detalles19.Visible = False


                OrdCompra.TextQuantity19.Clear()
                OrdCompra.TextUnitPrice19.Clear()
                OrdCompra.TextTotal19.Clear()
                OrdCompra.TextUm19.Clear()
                OrdCompra.TextBox_detalles19.Clear()

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 19) Then
                'producto 19
                OrdCompra.ComboBoxProducto19.Text = tabla.Rows(18)(18).ToString
                OrdCompra.TextQuantity19.Text = tabla.Rows(18)(19).ToString
                OrdCompra.TextUnitPrice19.Text = tabla.Rows(18)(20).ToString
                OrdCompra.TextTotal19.Text = tabla.Rows(18)(21).ToString
                OrdCompra.TextUm19.Text = tabla.Rows(18)(22).ToString
                OrdCompra.TextBox_detalles19.Text = tabla.Rows(18)(24).ToString
                'id del producto
                OrdCompra.TId19.Text = tabla.Rows(18)(17).ToString


                OrdCompra.TextNum19.Visible = True
                OrdCompra.ComboBoxProducto19.Visible = True
                OrdCompra.TextQuantity19.Visible = True
                OrdCompra.TextUnitPrice19.Visible = True
                OrdCompra.TextTotal19.Visible = True
                OrdCompra.TextUm19.Visible = True
                OrdCompra.TextBox_detalles19.Visible = True

                OrdCompra.TextNum20.Visible = False
                OrdCompra.ComboBoxProducto20.Visible = False
                OrdCompra.TextQuantity20.Visible = False
                OrdCompra.TextUnitPrice20.Visible = False
                OrdCompra.TextTotal20.Visible = False
                OrdCompra.TextUm20.Visible = False
                OrdCompra.TextBox_detalles20.Visible = False



                OrdCompra.TextQuantity20.Clear()
                OrdCompra.TextUnitPrice20.Clear()
                OrdCompra.TextTotal20.Clear()
                OrdCompra.TextUm20.Clear()
                OrdCompra.TextBox_detalles20.Clear()

            End If

            If (tabla.Rows.Count >= 20) Then
                'producto 20
                OrdCompra.ComboBoxProducto20.Text = tabla.Rows(19)(18).ToString
                OrdCompra.TextQuantity20.Text = tabla.Rows(19)(19).ToString
                OrdCompra.TextUnitPrice20.Text = tabla.Rows(19)(20).ToString
                OrdCompra.TextTotal20.Text = tabla.Rows(19)(21).ToString
                OrdCompra.TextUm20.Text = tabla.Rows(19)(22).ToString
                OrdCompra.TextBox_detalles20.Text = tabla.Rows(19)(24).ToString
                'id del producto
                OrdCompra.TId20.Text = tabla.Rows(19)(17).ToString

                OrdCompra.TextNum20.Visible = True
                OrdCompra.ComboBoxProducto20.Visible = True
                OrdCompra.TextQuantity20.Visible = True
                OrdCompra.TextUnitPrice20.Visible = True
                OrdCompra.TextTotal20.Visible = True
                OrdCompra.TextUm20.Visible = True
                OrdCompra.TextBox_detalles20.Visible = True

            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub nuevo(ByVal bandera As Boolean)
        OrdCompra.TextCodigo.Enabled = bandera
        OrdCompra.DateFechaOrden.Enabled = bandera
        OrdCompra.ComboBoxProveedores.Enabled = bandera
        OrdCompra.TextPurchase.Enabled = bandera
        OrdCompra.TexReqCompra.Enabled = bandera
        OrdCompra.TextPlaceDelivery.Enabled = bandera
        OrdCompra.TextCif.Enabled = bandera
        OrdCompra.TextDeliverytime.Enabled = bandera
        OrdCompra.TextBoarding.Enabled = bandera
        OrdCompra.TextPaymentConditions.Enabled = bandera
        OrdCompra.TextNum1.Enabled = bandera
        OrdCompra.TextQuantity1.Enabled = bandera
        OrdCompra.ComboBoxProducto1.Enabled = bandera
        OrdCompra.TextTotal1.Enabled = bandera
        OrdCompra.TextNum2.Enabled = bandera
        OrdCompra.TextQuantity2.Enabled = bandera
        OrdCompra.ComboBoxProducto2.Enabled = bandera
        OrdCompra.TextTotal2.Enabled = bandera
        OrdCompra.TextNum3.Enabled = bandera
        OrdCompra.TextQuantity3.Enabled = bandera
        OrdCompra.ComboBoxProducto3.Enabled = bandera
        OrdCompra.TextTotal3.Enabled = bandera
        OrdCompra.TextNum4.Enabled = bandera
        OrdCompra.TextQuantity4.Enabled = bandera
        OrdCompra.ComboBoxProducto4.Enabled = bandera
        OrdCompra.TextTotal4.Enabled = bandera
        OrdCompra.TextNum5.Enabled = bandera
        OrdCompra.TextQuantity5.Enabled = bandera
        OrdCompra.ComboBoxProducto5.Enabled = bandera
        OrdCompra.TextTotal5.Enabled = bandera
        OrdCompra.TextNum6.Enabled = bandera
        OrdCompra.TextQuantity6.Enabled = bandera
        OrdCompra.ComboBoxProducto6.Enabled = bandera
        OrdCompra.TextTotal6.Enabled = bandera
        OrdCompra.TextNum7.Enabled = bandera
        OrdCompra.TextQuantity7.Enabled = bandera
        OrdCompra.ComboBoxProducto7.Enabled = bandera
        OrdCompra.TextTotal7.Enabled = bandera
        OrdCompra.TextNum8.Enabled = bandera
        OrdCompra.TextQuantity8.Enabled = bandera
        OrdCompra.ComboBoxProducto8.Enabled = bandera
        OrdCompra.TextTotal8.Enabled = bandera
        OrdCompra.TextNum9.Enabled = bandera
        OrdCompra.TextQuantity9.Enabled = bandera
        OrdCompra.ComboBoxProducto9.Enabled = bandera
        OrdCompra.TextTotal9.Enabled = bandera
        OrdCompra.TextNum10.Enabled = bandera
        OrdCompra.TextQuantity10.Enabled = bandera
        OrdCompra.ComboBoxProducto10.Enabled = bandera
        OrdCompra.TextTotal10.Enabled = bandera
        OrdCompra.TextTotalLetra.Enabled = bandera
        OrdCompra.TextSubtotal.Enabled = bandera
        OrdCompra.TextIva.Enabled = bandera
        OrdCompra.TextTotalFinal.Enabled = bandera
        OrdCompra.TextBuyer.Enabled = bandera
        OrdCompra.TextApproved.Enabled = bandera
        OrdCompra.TextPersonalSeller.Enabled = bandera
        OrdCompra.TextUnitPrice1.Enabled = bandera
        OrdCompra.TextUnitPrice2.Enabled = bandera
        OrdCompra.TextUnitPrice3.Enabled = bandera
        OrdCompra.TextUnitPrice4.Enabled = bandera
        OrdCompra.TextUnitPrice5.Enabled = bandera
        OrdCompra.TextUnitPrice6.Enabled = bandera
        OrdCompra.TextUnitPrice7.Enabled = bandera
        OrdCompra.TextUnitPrice8.Enabled = bandera
        OrdCompra.TextUnitPrice9.Enabled = bandera
        OrdCompra.TextUnitPrice10.Enabled = bandera
        OrdCompra.ComboBoxProducto11.Enabled = bandera
        OrdCompra.TextTotal11.Enabled = bandera
        OrdCompra.TextNum11.Enabled = bandera
        OrdCompra.TextQuantity11.Enabled = bandera
        OrdCompra.ComboBoxProducto12.Enabled = bandera
        OrdCompra.TextTotal12.Enabled = bandera
        OrdCompra.TextNum12.Enabled = bandera
        OrdCompra.TextQuantity12.Enabled = bandera
        OrdCompra.ComboBoxProducto13.Enabled = bandera
        OrdCompra.TextTotal13.Enabled = bandera
        OrdCompra.TextNum13.Enabled = bandera
        OrdCompra.TextQuantity13.Enabled = bandera
        OrdCompra.ComboBoxProducto14.Enabled = bandera
        OrdCompra.TextTotal14.Enabled = bandera
        OrdCompra.TextNum14.Enabled = bandera
        OrdCompra.TextQuantity14.Enabled = bandera
        OrdCompra.ComboBoxProducto15.Enabled = bandera
        OrdCompra.TextTotal15.Enabled = bandera
        OrdCompra.TextNum15.Enabled = bandera
        OrdCompra.TextQuantity15.Enabled = bandera
        OrdCompra.ComboBoxProducto16.Enabled = bandera
        OrdCompra.TextTotal16.Enabled = bandera
        OrdCompra.TextNum16.Enabled = bandera
        OrdCompra.TextQuantity16.Enabled = bandera
        OrdCompra.ComboBoxProducto17.Enabled = bandera
        OrdCompra.TextTotal17.Enabled = bandera
        OrdCompra.TextNum17.Enabled = bandera
        OrdCompra.TextQuantity17.Enabled = bandera
        OrdCompra.ComboBoxProducto18.Enabled = bandera
        OrdCompra.TextTotal18.Enabled = bandera
        OrdCompra.TextNum18.Enabled = bandera
        OrdCompra.TextQuantity18.Enabled = bandera
        OrdCompra.ComboBoxProducto19.Enabled = bandera
        OrdCompra.TextTotal19.Enabled = bandera
        OrdCompra.TextNum19.Enabled = bandera
        OrdCompra.TextQuantity19.Enabled = bandera
        OrdCompra.ComboBoxProducto20.Enabled = bandera
        OrdCompra.TextTotal20.Enabled = bandera
        OrdCompra.TextNum20.Enabled = bandera
        OrdCompra.TextQuantity20.Enabled = bandera
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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        MostrarRegOrdC()
    End Sub

    Private Sub btn_pdf_Click(sender As Object, e As EventArgs) Handles btn_pdf.Click
        ReporteOrd.Show()
    End Sub

    Private Sub DataGridRegistrosOd_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRegistrosOd.CellEndEdit
        If e.ColumnIndex = 0 Then 'Mi columna es la primera, posición 0
            Dim celda = DataGridRegistrosOd(e.ColumnIndex, e.RowIndex)

            If String.IsNullOrEmpty(CStr(celda.Value)) Then 'Valido el valor
                celda.Value = 0
            End If
        End If
    End Sub



    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    '---------------------------------termina coidigo para poder mover formulario------------------------------
End Class