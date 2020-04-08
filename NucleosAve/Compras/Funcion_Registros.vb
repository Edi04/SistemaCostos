Imports System.Data.SqlClient
Public Class Funcion_Registros
    Dim comando As SqlCommand
    Dim conexioncita As String = My.Settings.Conexxx
    '--------------------------------------------Insertar ordenes de compra------------------------
    Public Function FN_InsertarPersonas(ByVal dts As ClassRegistrosOrdC) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("Insertar_ordCompra")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo


            comando.Parameters.AddWithValue("@codigo", dts.G_codigo)
            comando.Parameters.AddWithValue("@fecha2_nota", dts.G_fecha2Nota)
            comando.Parameters.AddWithValue("@id_pro", dts.G_id_pro)
            comando.Parameters.AddWithValue("@purchase_order", dts.G_purchaseOrder)
            comando.Parameters.AddWithValue("@req_compra", dts.G_req_compra)
            comando.Parameters.AddWithValue("@place_delivery", dts.G_place_delivery)
            comando.Parameters.AddWithValue("@cif", dts.G_cif)
            comando.Parameters.AddWithValue("@delivery_time", dts.G_delivery_time)
            comando.Parameters.AddWithValue("@boarding", dts.G_boarding_instr)
            comando.Parameters.AddWithValue("@payment_conditions", dts.G_payment_c)
            comando.Parameters.AddWithValue("@buyer", dts.G_buyer)
            comando.Parameters.AddWithValue("@approved", dts.G_aproved)
            comando.Parameters.AddWithValue("@personal_seller", dts.G_personal_seller)
            comando.Parameters.AddWithValue("@subtotal", dts.G_subtotall)
            comando.Parameters.AddWithValue("@iva", dts.G_ivaaaa)
            comando.Parameters.AddWithValue("@total", dts.G_Total)
            comando.Parameters.AddWithValue("@total_letter", dts.G_total_letter)
            comando.Parameters.AddWithValue("@estado", "Activo")
            comando.Parameters.AddWithValue("@Cs", dts.G_CS)
            comando.Parameters.AddWithValue("@Moneda", dts.G_moneda)
            comando.Parameters.AddWithValue("@observaciones", dts.G_observaciones)
            comando.Parameters.AddWithValue("@Categoria", dts.G_Categoria)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '----------------------------------insertar los productos--------------------------
    Public Function Fn_insertar_productosOrdC(ByRef dts As ClassRegistrosProdOrdCompra) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("Insertar_ordProductos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@nombre", dts.G_codigo_pro)
            comando.Parameters.AddWithValue("@descripcion", dts.Gdescripcion)
            comando.Parameters.AddWithValue("@cantidad", dts.GCantidad)
            comando.Parameters.AddWithValue("@precio", dts.Gprecio)
            comando.Parameters.AddWithValue("@subtotal", dts.Gsubtotal)
            comando.Parameters.AddWithValue("@id_p", dts.G_id_pro_pro)
            comando.Parameters.AddWithValue("@Um", dts.GUm)
            comando.Parameters.AddWithValue("@detalles", dts.Gdetalles)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '----------------------------------mostramos la tabla con los regoistros --------------------------
    Public Function FnMostrarORDcompra() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP38_Mostrar_OrdCom")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", RegistrosOrdCom.DateTimeRango1.Value)
            comando.Parameters.AddWithValue("@rango2", RegistrosOrdCom.DateTimeRango2.Value)
            If comando.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(tabla)
                Return tabla

            Else
                Return Nothing

            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function
    '----------------------------------mostramos la tabla con los regoistros de las facturas--------------------------
    Public Function FnMostrarFacturas() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("Mostrar_Facturas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", facturasRegis.DateTimeRango1.Value)
            comando.Parameters.AddWithValue("@rango2", facturasRegis.DateTimeRango2.Value)
            If comando.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(tabla)
                Return tabla

            Else
                Return Nothing

            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    '--------------------------------------Modificar registros-------------------------------------
    Public Function FN_ModificarOrdenes(ByVal dts As ClassRegistrosOrdC) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP38_Modificar_ordCompra")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo


            comando.Parameters.AddWithValue("@codigo", dts.G_codigo)
            comando.Parameters.AddWithValue("@fecha2_nota", dts.G_fecha2Nota)
            comando.Parameters.AddWithValue("@id_pro", dts.G_id_pro)
            comando.Parameters.AddWithValue("@purchase_order", dts.G_purchaseOrder)
            comando.Parameters.AddWithValue("@req_compra", dts.G_req_compra)
            comando.Parameters.AddWithValue("@place_delivery", dts.G_place_delivery)
            comando.Parameters.AddWithValue("@cif", dts.G_cif)
            comando.Parameters.AddWithValue("@delivery_time", dts.G_delivery_time)
            comando.Parameters.AddWithValue("@boarding", dts.G_boarding_instr)
            comando.Parameters.AddWithValue("@payment_conditions", dts.G_payment_c)
            comando.Parameters.AddWithValue("@buyer", dts.G_buyer)
            comando.Parameters.AddWithValue("@approved", dts.G_aproved)
            comando.Parameters.AddWithValue("@personal_seller", dts.G_personal_seller)
            comando.Parameters.AddWithValue("@subtotal", dts.G_subtotall)
            comando.Parameters.AddWithValue("@iva", dts.G_ivaaaa)
            comando.Parameters.AddWithValue("@total", dts.G_Total)
            comando.Parameters.AddWithValue("@total_letter", dts.G_total_letter)
            comando.Parameters.AddWithValue("@Moneda", dts.G_moneda)
            comando.Parameters.AddWithValue("@observaciones", dts.G_observaciones)
            comando.Parameters.AddWithValue("@Categoria", dts.G_Categoria)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function


    '-------------------------Modificar Registros de Productos-------------------------------
    Public Function Fn_ModificarProductos(ByRef dts As ClassRegistrosProdOrdCompra) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP38_Modificar_ordProductos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@nombre", dts.G_codigo_pro)
            comando.Parameters.AddWithValue("@descripcion", dts.Gdescripcion)
            comando.Parameters.AddWithValue("@cantidad", dts.GCantidad)
            comando.Parameters.AddWithValue("@precio", dts.Gprecio)
            comando.Parameters.AddWithValue("@subtotal", dts.Gsubtotal)
            comando.Parameters.AddWithValue("@id_p", dts.G_id_pro_pro)
            comando.Parameters.AddWithValue("@id_pro", dts.GId_pro)
            comando.Parameters.AddWithValue("@Um", dts.GUm)
            comando.Parameters.AddWithValue("@detalles", dts.Gdetalles)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '--------------------------------------Eliminar registros-------------------------------------
    Public Function FN_EliminarOrdenes(ByVal dts As ClassRegistrosOrdC) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP38_EliminarOrdenes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo


            comando.Parameters.AddWithValue("@codigo", dts.G_codigo)
            comando.Parameters.AddWithValue("@estado", "Inactivo")

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    '--------------------------------------Eliminar factura-------------------------------------
    Public Function FN_EliminarFactura(ByVal dts As ClassRegistrosFacturas) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Eliminar_Facturas")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo


            comando.Parameters.AddWithValue("@codigo", dts.Fcodigo)
            comando.Parameters.AddWithValue("@estado", "Inactivo")

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function


    '--------------------------------------------Insertar Facturas------------------------
    Public Function FN_InsertarFacturas(ByVal fact As ClassRegistrosFacturas) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("Insertar_Factura")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@codigo", fact.Fcodigo)
            comando.Parameters.AddWithValue("@Nombre_emi", fact.Fnombre_emi)
            comando.Parameters.AddWithValue("@Rfc_emi", fact.Frfc_emi)
            comando.Parameters.AddWithValue("@RegimenFiscal_emi", fact.Fregimenfiscal_emi)
            comando.Parameters.AddWithValue("@Folio_fiscal", fact.Ffolio_fiscal)
            comando.Parameters.AddWithValue("@NCertificado", fact.Fncertificado)
            comando.Parameters.AddWithValue("@Fecha", fact.Ffecha)
            comando.Parameters.AddWithValue("@LugarExpedicion", fact.Flugardeexpedicion)
            comando.Parameters.AddWithValue("@Nombre_rep", fact.FNombre_rep)
            comando.Parameters.AddWithValue("@Rfc_rep", fact.FRfc_rep)
            comando.Parameters.AddWithValue("@UsoCfdi_rep", fact.FUsoCfdi_rep)
            comando.Parameters.AddWithValue("@Tasa_cuota", fact.FTasa_cuota)
            comando.Parameters.AddWithValue("@Tipofactor", fact.FTipofactor)
            comando.Parameters.AddWithValue("@Impuesto", fact.FImpuesto)
            comando.Parameters.AddWithValue("@TipoComprobante", fact.FTipoComprobante)
            comando.Parameters.AddWithValue("@Formadepago", fact.FFormadepago)
            comando.Parameters.AddWithValue("@MetododePago", fact.FMetododePago)
            comando.Parameters.AddWithValue("@CondicionesPago", fact.FCondicionesPago)
            comando.Parameters.AddWithValue("@Moneda", fact.FMoneda)
            comando.Parameters.AddWithValue("@folio", fact.Ffolio)
            comando.Parameters.AddWithValue("@version", fact.Fversion)
            comando.Parameters.AddWithValue("@sello", fact.Fsello)
            comando.Parameters.AddWithValue("@certificado", fact.Fcertificado)
            comando.Parameters.AddWithValue("@codigoOrden", fact.FcodigoOrden)
            comando.Parameters.AddWithValue("@estado", "Activo")
            comando.Parameters.AddWithValue("@TipodeCambio", fact.FTipodeCambio)
            comando.Parameters.AddWithValue("@Subtotal", fact.FSubtotal)
            comando.Parameters.AddWithValue("@Impuestostraslados", fact.FImpuestostraslados)
            comando.Parameters.AddWithValue("@TotalFactura", fact.FTotalFactura)
            Dim hora2 As String = DateTime.Now.ToString("dd/MM/yyyy")
            comando.Parameters.AddWithValue("@HRegistro", hora2)
            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    '--------------------------------------------Insertar productos Facturas------------------------
    Public Function FN_InsertarProdFacturas(ByVal fact As ClassRegistrosFactuProd) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("Insertar_FacturaProductos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@codigo", fact.FPcodigo)
            comando.Parameters.AddWithValue("@codigo_identificacion", fact.FPcodigo_identificacion)
            comando.Parameters.AddWithValue("@cantidad", fact.FPcantidad)
            comando.Parameters.AddWithValue("@descripcion", fact.FPdescripcion)
            comando.Parameters.AddWithValue("@valorunitario", fact.FPvalorunitario)
            comando.Parameters.AddWithValue("@unidad", fact.FPunidad)
            comando.Parameters.AddWithValue("@importe", fact.FPimporte)



            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '-------<<<<<<<<<<<<<<<<<<<<<<<<<<<<<--------------------Insertar Pedimentos-----------<<<<<<<<<<<<<<<<<<----------------------------
    Public Function FN_InsertarPedimentos(ByVal dts As ClassPedimentos) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("Insertar_pedimentos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo


            comando.Parameters.AddWithValue("@id_provedor", dts.Peid_provedor)
            comando.Parameters.AddWithValue("@orden_compra", dts.Peorden_comprao)
            comando.Parameters.AddWithValue("@id_factura", dts.Peid_factura)
            comando.Parameters.AddWithValue("@cove", dts.Pecove)
            comando.Parameters.AddWithValue("@fecha", dts.Pefecha)
            comando.Parameters.AddWithValue("@cantidad", dts.Pecantidad)
            comando.Parameters.AddWithValue("@unidad", dts.Peunidad)
            comando.Parameters.AddWithValue("@precio_pagado", dts.PeprecioP)
            comando.Parameters.AddWithValue("@total", dts.Petotal)

            comando.Parameters.AddWithValue("@valor_Aduana", dts.Pevalor_Aduana)
            comando.Parameters.AddWithValue("@pedimento", dts.Pepedimento)
            comando.Parameters.AddWithValue("@clave", dts.Peclave)
            comando.Parameters.AddWithValue("@aduana", dts.Peaduana)
            comando.Parameters.AddWithValue("@tipo_cambio", dts.Petipo_cambio)
            comando.Parameters.AddWithValue("@peso_bruto", dts.Pepeso_bruto)
            comando.Parameters.AddWithValue("@tipo", dts.Petipo)
            comando.Parameters.AddWithValue("@t_cantidad", dts.Pet_cantidad)

            comando.Parameters.AddWithValue("@iva_RG_terceros1", dts.Peiva_RG_terceros1)
            comando.Parameters.AddWithValue("@total_RG_terceros1", dts.Petotal_RG_terceros1)
            comando.Parameters.AddWithValue("@iva_custombokerage", dts.Peiva_custombokerage)
            comando.Parameters.AddWithValue("@total_custombokerage", dts.Petotal_custombokerage)

            comando.Parameters.AddWithValue("@importeTGAG", dts.PeimporteTGAG)
            comando.Parameters.AddWithValue("@ivaTGAG", dts.PeivaTGAG)
            comando.Parameters.AddWithValue("@TotalTGAG", dts.PeTotalTGAG)
            comando.Parameters.AddWithValue("@importeRC", dts.PeimporteRC)
            comando.Parameters.AddWithValue("@pesoRC", dts.PepesoRC)
            comando.Parameters.AddWithValue("@costoRC", dts.PecostoRC)
            comando.Parameters.AddWithValue("@tcRC", dts.PetcRC)
            comando.Parameters.AddWithValue("@mxn1RC", dts.Pemxn1RC)
            comando.Parameters.AddWithValue("@mxn2RC", dts.Pemxn2RC)
            comando.Parameters.AddWithValue("@otrosgastos", dts.Peotrosgastos)
            comando.Parameters.AddWithValue("@importeCT", dts.PeimporteCT)
            comando.Parameters.AddWithValue("@ivaCT", dts.PeivaCT)

            comando.Parameters.AddWithValue("@pedimentoclave", dts.Pecodigo_pedimento)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    Public Function FN_InsertarPedimentosMercancia(ByVal dts As ClassPedimentosMercancias) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_pedimentos_mercancias")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@mercancia", dts.Merc_mercancia)
            comando.Parameters.AddWithValue("@fraccion", dts.Merc_fraccion)
            comando.Parameters.AddWithValue("@pedimento", dts.Merc_pedimento)
            comando.Parameters.AddWithValue("@codigoPed", dts.Merc_codigoPed)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function FN_InsertarGastosTerceros1(ByVal dts As ClassGastosTerceros1) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_pedimentos_GTerceros1")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.GT_pedimento)
            comando.Parameters.AddWithValue("@codigo", dts.GT_codigo)
            comando.Parameters.AddWithValue("@descripcion", dts.GT_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.GT_importe)
            comando.Parameters.AddWithValue("@seccion", "Relacion de Gastos por Terceros 1")
            comando.Parameters.AddWithValue("@codigoPed", dts.GT_codigoPed)
            comando.Parameters.AddWithValue("@iva", dts.GT_iva)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function FN_InsertarGastosTerceros2(ByVal dts As ClassGastosTerceros2) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_pedimentos_GTerceros2")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.GT2_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.GT2_descripcion)
            comando.Parameters.AddWithValue("@concepto", dts.GT2_concepto)
            comando.Parameters.AddWithValue("@exento", dts.GT2_exento)
            comando.Parameters.AddWithValue("@gravado", dts.GT2_gravado)
            comando.Parameters.AddWithValue("@iva", dts.GT2_iva)
            comando.Parameters.AddWithValue("@total", dts.GT2_total)
            comando.Parameters.AddWithValue("@seccion", "Relacion de Gastos por Terceros 2")
            comando.Parameters.AddWithValue("@codigoPed", dts.GT2_codigoPed)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function FN_InsertarCustomsBrokerage(ByVal dts As ClassCustomsBrokerage) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_CustomsBrokerage")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.CB_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.CB_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.CB_importe)
            comando.Parameters.AddWithValue("@seccion", "Customs Brokerage")
            comando.Parameters.AddWithValue("@codigoPed", dts.CB_codigoPed)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    Public Function FN_InsertarFletesSeguros(ByVal dts As ClassFletesSeguros) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_FletesSeguros")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.FS_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.FS_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.FS_importe)
            comando.Parameters.AddWithValue("@iva", dts.FS_iva)
            comando.Parameters.AddWithValue("@total", dts.FS_total)
            comando.Parameters.AddWithValue("@seccion", "Fletes y Seguros")
            comando.Parameters.AddWithValue("@codigoPed", dts.FS_codigoPed)
            comando.Parameters.AddWithValue("@retenciones", dts.FS_retenciones)
            comando.Parameters.AddWithValue("@tc", dts.FS_tc)
            comando.Parameters.AddWithValue("@usd", dts.FS_usd)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    '----------------------------------mostramos la tabla con los registros Pedimentos --------------------------
    Public Function FnMostrarPedimentos() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Pedimentos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@parametro", RegistrosPedimentos.textBuscar.Text)
            If comando.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing
            End If
            conexxo.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    '..............................................................................................................
    Public Function FN_InsertarProvedor(ByVal dts As ClassProveedores) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Provedores")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@nombre", dts.pro_nombre)
            comando.Parameters.AddWithValue("@direccion", dts.pro_direccion)
            comando.Parameters.AddWithValue("@telefono", dts.pro_telefono)
            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    '-----------------------------Modificar Pedimentos
    Public Function FN_ModificarPedimentos(ByVal dts As ClassPedimentos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_ModificarPedimentos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@id_provedor", dts.Peid_provedor)
            comando.Parameters.AddWithValue("@orden_compra", dts.Peorden_comprao)
            comando.Parameters.AddWithValue("@id_factura", dts.Peid_factura)
            comando.Parameters.AddWithValue("@cove", dts.Pecove)
            comando.Parameters.AddWithValue("@fecha", dts.Pefecha)
            comando.Parameters.AddWithValue("@cantidad", dts.Pecantidad)
            comando.Parameters.AddWithValue("@unidad", dts.Peunidad)
            comando.Parameters.AddWithValue("@precio_pagado", dts.PeprecioP)
            comando.Parameters.AddWithValue("@total", dts.Petotal)

            comando.Parameters.AddWithValue("@valor_Aduana", dts.Pevalor_Aduana)
            comando.Parameters.AddWithValue("@pedimento", dts.Pepedimento)
            comando.Parameters.AddWithValue("@clave", dts.Peclave)
            comando.Parameters.AddWithValue("@aduana", dts.Peaduana)
            comando.Parameters.AddWithValue("@tipo_cambio", dts.Petipo_cambio)
            comando.Parameters.AddWithValue("@peso_bruto", dts.Pepeso_bruto)
            comando.Parameters.AddWithValue("@tipo", dts.Petipo)
            comando.Parameters.AddWithValue("@t_cantidad", dts.Pet_cantidad)

            comando.Parameters.AddWithValue("@iva_RG_terceros1", dts.Peiva_RG_terceros1)
            comando.Parameters.AddWithValue("@total_RG_terceros1", dts.Petotal_RG_terceros1)
            comando.Parameters.AddWithValue("@iva_custombokerage", dts.Peiva_custombokerage)
            comando.Parameters.AddWithValue("@total_custombokerage", dts.Petotal_custombokerage)

            comando.Parameters.AddWithValue("@importeTGAG", dts.PeimporteTGAG)
            comando.Parameters.AddWithValue("@ivaTGAG", dts.PeivaTGAG)
            comando.Parameters.AddWithValue("@TotalTGAG", dts.PeTotalTGAG)
            comando.Parameters.AddWithValue("@importeRC", dts.PeimporteRC)
            comando.Parameters.AddWithValue("@pesoRC", dts.PepesoRC)
            comando.Parameters.AddWithValue("@costoRC", dts.PecostoRC)
            comando.Parameters.AddWithValue("@tcRC", dts.PetcRC)
            comando.Parameters.AddWithValue("@mxn1RC", dts.Pemxn1RC)
            comando.Parameters.AddWithValue("@mxn2RC", dts.Pemxn2RC)
            comando.Parameters.AddWithValue("@otrosgastos", dts.Peotrosgastos)
            comando.Parameters.AddWithValue("@importeCT", dts.PeimporteCT)
            comando.Parameters.AddWithValue("@ivaCT", dts.PeivaCT)


            comando.Parameters.AddWithValue("@idpedimento", dts.Peidpedimento)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '-----------------------------------Termina Modificacon Pedimentos---------------
    '------------modificacion de mercancias
    Public Function FN_ModificarMercancias(ByVal dts As ClassPedimentosMercancias) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_ModificarMercancias")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@mercancia", dts.Merc_mercancia)
            comando.Parameters.AddWithValue("@fraccion", dts.Merc_fraccion)
            comando.Parameters.AddWithValue("@pedimento", dts.Merc_pedimento)
            comando.Parameters.AddWithValue("@idmercancia", dts.Merc_id_productos)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '--------------------------------------
    '--------Modificaion de gastos por terceros 1
    Public Function FN_ModificarGastosTerceros1(ByVal dts As ClassGastosTerceros1) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_pedimentos_GTerceros1")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.GT_pedimento)
            comando.Parameters.AddWithValue("@codigo", dts.GT_codigo)
            comando.Parameters.AddWithValue("@descripcion", dts.GT_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.GT_importe)
            comando.Parameters.AddWithValue("@idterceros", dts.GT_idgastos1)
            comando.Parameters.AddWithValue("@iva", dts.GT_iva)
            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function

    '--------Modificaion de gastos por terceros 2
    '--------Modificaion1
    Public Function FN_ModificarGastosTerceros2(ByVal dts As ClassGastosTerceros2) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_pedimentos_GTerceros2")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.GT2_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.GT2_descripcion)
            comando.Parameters.AddWithValue("@concepto", dts.GT2_concepto)
            comando.Parameters.AddWithValue("@exento", dts.GT2_exento)
            comando.Parameters.AddWithValue("@gravado", dts.GT2_gravado)
            comando.Parameters.AddWithValue("@iva", dts.GT2_iva)
            comando.Parameters.AddWithValue("@total", dts.GT2_total)
            comando.Parameters.AddWithValue("@idgastos2", dts.GT2_idgastos2)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '-------------------------------------------------------------------------------------
    '<<<<<<<<<<<<<<<<<<<<<-------------modifica customs brokerage---------------->>>>>>>>>>>>>>>>>> 
    Public Function FN_ModificarCustomsBrokerage(ByVal dts As ClassCustomsBrokerage) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_CustomsBrokerage")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.CB_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.CB_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.CB_importe)
            comando.Parameters.AddWithValue("@idcustom", dts.CB_idcustoms)


            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '______________________________________________________________________________________________
    '------------------------------------------------------------------------------------------------
    Public Function FN_ModificarFletesSeguros(ByVal dts As ClassFletesSeguros) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_FletesSeguros")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@pedimento", dts.FS_pedimento)
            comando.Parameters.AddWithValue("@descripcion", dts.FS_descripcion)
            comando.Parameters.AddWithValue("@importe", dts.FS_importe)
            comando.Parameters.AddWithValue("@iva", dts.FS_iva)
            comando.Parameters.AddWithValue("@total", dts.FS_total)
            comando.Parameters.AddWithValue("@idflete", dts.FS_idflete)
            comando.Parameters.AddWithValue("@retenciones", dts.FS_retenciones)
            comando.Parameters.AddWithValue("@tc", dts.FS_tc)
            comando.Parameters.AddWithValue("@usd", dts.FS_usd)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
    '_________________________________________________________________________________________________
    '----------------------------Eliminar Pedimentos----------------------------
    Public Function FN_EliminarPedimentos(ByVal dts As ClassPedimentos) As Boolean
        Try


            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_EliminarPedimentos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@id", dts.Peid)
            comando.Parameters.AddWithValue("@Estado", "Inactivo")

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            con.Close()
        End Try
    End Function
End Class
