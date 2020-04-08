Imports System.Data.SqlClient
Public Class Funcion_Controlador
    Dim comando As SqlCommand
    Dim conexioncita As String = My.Settings.Conexxx

    Public Function FN_InsertarTrasporte(ByVal dts As ClassTrasportes) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Trasporte")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@marca", dts.T_marca)
            comando.Parameters.AddWithValue("@modelo", dts.T_modelo)
            comando.Parameters.AddWithValue("@tipo", dts.T_tipo)
            comando.Parameters.AddWithValue("@Ano", dts.T_Ano)
            comando.Parameters.AddWithValue("@no_serie", dts.T_n_serie)
            comando.Parameters.AddWithValue("@placas", dts.T_placas)
            comando.Parameters.AddWithValue("@no_seguro", dts.T_n_seguro)
            comando.Parameters.AddWithValue("@vigencia", dts.T_vigencia)
            comando.Parameters.AddWithValue("@codigo", dts.T_codigo)
            '-----------------------------------------------------------
            comando.Parameters.AddWithValue("@cargaKg", dts.T_cargaKg)
            comando.Parameters.AddWithValue("@Tasa_Depreciacion", dts.T_Tasa_Depreciacion)
            comando.Parameters.AddWithValue("@Fecha_Adqui", dts.T_Fecha_Adqui)
            comando.Parameters.AddWithValue("@MO_de_Inversio", dts.T_MO_de_Inversio)
            comando.Parameters.AddWithValue("@PN_Deducible", dts.T_PN_Deducible)
            comando.Parameters.AddWithValue("@MO_MaxDed", dts.T_MO_MaxDed)
            comando.Parameters.AddWithValue("@M_D_Acumulada", dts.T_M_D_Acumulada)
            comando.Parameters.AddWithValue("@M_C_de_uso_C_Dep", dts.T_M_C_de_uso_C_Dep)
            comando.Parameters.AddWithValue("@D_Acumulada", dts.T_D_Acumulada)
            comando.Parameters.AddWithValue("@Monto_Actual_Del_Activo", dts.T_Monto_Actual_Del_Activo)
            comando.Parameters.AddWithValue("@Estado", "Activo")
            comando.Parameters.AddWithValue("@DateTime", DateTime.Now)
            comando.Parameters.AddWithValue("@oc", "N/A")
            If AltaTrasportes.Text_Url_Pdf.Text = "" Then
                comando.Parameters.AddWithValue("@factura_trasporte", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@factura_trasporte", dts.Tfactura_trasporte)
            End If
            If AltaTrasportes.Text_Url_Xml.Text = "" Then
                comando.Parameters.AddWithValue("@factura_trasporte2", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@factura_trasporte2", dts.Tfactura_trasporte2)
            End If
            'comando.Parameters.AddWithValue("@estado", "Activo")
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
    '----------------------------------Mostramos la tabla con los Registros --------------------------
    Public Function FnMostrarTrasportes() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_MostrarTrasportes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@buscar", AltaTrasportes.TextBuscar.Text)
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
    '---------------------------------------------------------------------------------------------------------
    '----------------------------------Mostramos la tabla con los Registros --------------------------
    Public Function FnMostrarTrasportesTodos() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_MostrarTrasportes2")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
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
    '---------------------------------------------------------------------------------------------------------
    '::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    '__________________________________________________________________________________________________________
    '..........................................................................................................
    '----------------------------------------------------------------------------------------------------------
    Public Function FN_ModificarTrasporte(ByVal dts As ClassTrasportes) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Trasporte")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@marca", dts.T_marca)
            comando.Parameters.AddWithValue("@modelo", dts.T_modelo)
            comando.Parameters.AddWithValue("@tipo", dts.T_tipo)
            comando.Parameters.AddWithValue("@Ano", dts.T_Ano)
            comando.Parameters.AddWithValue("@no_serie", dts.T_n_serie)
            comando.Parameters.AddWithValue("@placas", dts.T_placas)
            comando.Parameters.AddWithValue("@no_seguro", dts.T_n_seguro)
            comando.Parameters.AddWithValue("@vigencia", dts.T_vigencia)
            comando.Parameters.AddWithValue("@codigo", dts.T_codigo)
            '-----------------------------------------------------------
            comando.Parameters.AddWithValue("@cargaKg", dts.T_cargaKg)
            comando.Parameters.AddWithValue("@Tasa_Depreciacion", dts.T_Tasa_Depreciacion)
            comando.Parameters.AddWithValue("@Fecha_Adqui", dts.T_Fecha_Adqui)
            comando.Parameters.AddWithValue("@MO_de_Inversio", dts.T_MO_de_Inversio)
            comando.Parameters.AddWithValue("@PN_Deducible", dts.T_PN_Deducible)
            comando.Parameters.AddWithValue("@MO_MaxDed", dts.T_MO_MaxDed)
            comando.Parameters.AddWithValue("@M_D_Acumulada", dts.T_M_D_Acumulada)
            comando.Parameters.AddWithValue("@M_C_de_uso_C_Dep", dts.T_M_C_de_uso_C_Dep)
            comando.Parameters.AddWithValue("@D_Acumulada", dts.T_D_Acumulada)
            comando.Parameters.AddWithValue("@Monto_Actual_Del_Activo", dts.T_Monto_Actual_Del_Activo)
            comando.Parameters.AddWithValue("@Estado", "Activo")
            comando.Parameters.AddWithValue("@oc", dts.T_oc)
            If AltaTrasportes.Text_Url_Pdf.Text = "" Then
                comando.Parameters.AddWithValue("@factura_trasporte", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@factura_trasporte", dts.Tfactura_trasporte)
            End If
            If AltaTrasportes.Text_Url_Xml.Text = "" Then
                comando.Parameters.AddWithValue("@factura_trasporte2", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@factura_trasporte2", dts.Tfactura_trasporte2)
            End If
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
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    ':::::::::::::::
    ':::::::::
    ':::::
    '::
    ':
    '
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    '_________________________________________________________________________________________________________
    '                               .:::: Mantenimientos y Servicios ::::.

    '                              .::: Alta Mantenimientos o Servicios :::.

    Public Function FN_InsertarMantenimientos(ByVal dts As ClassMantenimientos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Mantenimientos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@orden_servicio", dts.T_orden_servicio)
            comando.Parameters.AddWithValue("@Fecha_os", dts.T_Fecha_os)
            comando.Parameters.AddWithValue("@Fecha_Solicitud", dts.T_Fecha_Solicitud)
            comando.Parameters.AddWithValue("@Fecha_Aplicacion", dts.T_Fecha_Aplicacion)
            comando.Parameters.AddWithValue("@Fecha_Entrega_Estimada", dts.T_Fecha_Entrega_Estimada)
            comando.Parameters.AddWithValue("@Kilometraje_Actual", dts.T_Kilometraje_Actual)
            comando.Parameters.AddWithValue("@Fecha_Kilometraje", dts.T_Fecha_Kilometraje)
            comando.Parameters.AddWithValue("@Tipo_de_Servicio", dts.T_Tipo_de_Servicio)
            comando.Parameters.AddWithValue("@Prestador_del_Servicio", dts.T_Prestador_del_Servicio)
            comando.Parameters.AddWithValue("@Descripcion_Mantenimiento", dts.T_Descripcion_Mantenimiento)
            comando.Parameters.AddWithValue("@Sobre_Servicio", dts.T_Sobre_Servicio)
            comando.Parameters.AddWithValue("@Servicio_Extraordinario", dts.T_Servicio_Extraordinario)
            comando.Parameters.AddWithValue("@Descripcion_ServicioEX", dts.T_Descripcion_ServicioEX)
            comando.Parameters.AddWithValue("@Refacciones", dts.T_Refacciones)
            comando.Parameters.AddWithValue("@Reviciones_Programadas", dts.T_Reviciones_Programadas)
            comando.Parameters.AddWithValue("@Observaciones_Generales", dts.T_Observaciones_Generales)
            comando.Parameters.AddWithValue("@ProximoServicio", dts.T_ProximoServicio)
            comando.Parameters.AddWithValue("@Recomendaciones", dts.T_Recomendaciones)
            comando.Parameters.AddWithValue("@Recibio_Recomendaciones", dts.T_Recibio_Recomendaciones)
            comando.Parameters.AddWithValue("@Costo_Refacciones", dts.T_Costo_Refacciones)
            comando.Parameters.AddWithValue("@Costo_servicio", dts.T_Costo_servicio)
            comando.Parameters.AddWithValue("@costo_traslado", dts.T_costo_traslado)
            comando.Parameters.AddWithValue("@costo_total", dts.T_costo_total)
            comando.Parameters.AddWithValue("@Autorizo", dts.T_Autorizo)
            comando.Parameters.AddWithValue("@realizo_servicio", dts.T_realizo_servicio)
            comando.Parameters.AddWithValue("@Chofer", dts.T_Chofer)
            comando.Parameters.AddWithValue("@trasporte", dts.T_trasportes)
            comando.Parameters.AddWithValue("@Programadas_fecha_reviciones", dts.T_Programadas_fecha_reviciones)
            If ServiciosMantenimiento.Text_Url_Pdf.Text = "" Then
                comando.Parameters.AddWithValue("@comprobantes", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@comprobantes", dts.T_comprobantes)
            End If
            comando.Parameters.AddWithValue("@Estado", "Activo")
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


    '                              .::: Alta Materiales :::.
    Public Function FN_InsertarRefacciones(ByVal dts As ClassMantenimientos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Refacciones")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@orden_servicio", dts.T_orden_servicio)
            comando.Parameters.AddWithValue("@producto", dts.T_producto)
            comando.Parameters.AddWithValue("@nombre_provedor", dts.T_nombre_proveedor_refacciones)

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
    '-------------------------------------------------------------------------------------------------
    '----------------------------------::::::::::::::::::Mostramos la tabla con los Registros:::::::::::::::::--------------------------
    Public Function FnMostrarMantenimientos() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_MostrarMantenimientos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", ServiciosMantenimiento.DateTimerango1.Value)
            comando.Parameters.AddWithValue("@rango2", ServiciosMantenimiento.DateTimerango2.Value)
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
    '--------------------------------------------------------------------------------------------------------
    ':::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

    '::::::::::::::::::::::::::::::::::::                     .....::::: Modificar Mantenimientos :::::.....
    Public Function FN_ModificarMantenimientos(ByVal dts As ClassMantenimientos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Mantenimientos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@orden_servicio", dts.T_orden_servicio)
            comando.Parameters.AddWithValue("@Fecha_os", dts.T_Fecha_os)
            comando.Parameters.AddWithValue("@Fecha_Solicitud", dts.T_Fecha_Solicitud)
            comando.Parameters.AddWithValue("@Fecha_Aplicacion", dts.T_Fecha_Aplicacion)
            comando.Parameters.AddWithValue("@Fecha_Entrega_Estimada", dts.T_Fecha_Entrega_Estimada)
            comando.Parameters.AddWithValue("@Kilometraje_Actual", dts.T_Kilometraje_Actual)
            comando.Parameters.AddWithValue("@Fecha_Kilometraje", dts.T_Fecha_Kilometraje)
            comando.Parameters.AddWithValue("@Tipo_de_Servicio", dts.T_Tipo_de_Servicio)
            comando.Parameters.AddWithValue("@Prestador_del_Servicio", dts.T_Prestador_del_Servicio)
            comando.Parameters.AddWithValue("@Descripcion_Mantenimiento", dts.T_Descripcion_Mantenimiento)
            comando.Parameters.AddWithValue("@Sobre_Servicio", dts.T_Sobre_Servicio)
            comando.Parameters.AddWithValue("@Servicio_Extraordinario", dts.T_Servicio_Extraordinario)
            comando.Parameters.AddWithValue("@Descripcion_ServicioEX", dts.T_Descripcion_ServicioEX)
            comando.Parameters.AddWithValue("@Refacciones", dts.T_Refacciones)
            comando.Parameters.AddWithValue("@Reviciones_Programadas", dts.T_Reviciones_Programadas)
            comando.Parameters.AddWithValue("@Observaciones_Generales", dts.T_Observaciones_Generales)
            comando.Parameters.AddWithValue("@ProximoServicio", dts.T_ProximoServicio)
            comando.Parameters.AddWithValue("@Recomendaciones", dts.T_Recomendaciones)
            comando.Parameters.AddWithValue("@Recibio_Recomendaciones", dts.T_Recibio_Recomendaciones)
            comando.Parameters.AddWithValue("@Costo_Refacciones", dts.T_Costo_Refacciones)
            comando.Parameters.AddWithValue("@Costo_servicio", dts.T_Costo_servicio)
            comando.Parameters.AddWithValue("@costo_traslado", dts.T_costo_traslado)
            comando.Parameters.AddWithValue("@costo_total", dts.T_costo_total)
            comando.Parameters.AddWithValue("@Autorizo", dts.T_Autorizo)
            comando.Parameters.AddWithValue("@realizo_servicio", dts.T_realizo_servicio)
            comando.Parameters.AddWithValue("@Chofer", dts.T_Chofer)
            comando.Parameters.AddWithValue("@trasporte", dts.T_trasportes)
            comando.Parameters.AddWithValue("@Programadas_fecha_reviciones", dts.T_Programadas_fecha_reviciones)
            If ServiciosMantenimiento.Text_Url_Pdf.Text = "" Then
                comando.Parameters.AddWithValue("@comprobantes", "Ningun Archivo Seleccionado")
            Else
                comando.Parameters.AddWithValue("@comprobantes", dts.T_comprobantes)
            End If

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

    '                              .::: Modificar refaciones :::.
    Public Function FN_Modificar_Refacciones(ByVal dts As ClassMantenimientos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Refacciones")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@producto", dts.T_producto)
            comando.Parameters.AddWithValue("@nombre_provedor", dts.T_nombre_proveedor_refacciones)
            comando.Parameters.AddWithValue("@id", dts.T_id_refac)
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
    '-------------------------------------------------------------------------------------------------
    '----------------------------   Mostrar Reviciones -----------------------------
    Public Function FnMostrar_RevicionesP() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Agendados_Servicios")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", RevicionesProgramadas.daterango1.Value)
            comando.Parameters.AddWithValue("@rango2", RevicionesProgramadas.daterango2.Value)
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

    Public Function FN_InsertarEstado_(ByVal dts As ClassMantenimientos) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_estado_prog")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@codigo", dts.T_estado_revision)
            comando.Parameters.AddWithValue("@estado", "Realizado")


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
    Public Function FN_InsertarP_Servicio(ByVal dts As ClassTrasportes) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Prestador")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@nombre", dts.Tnombre_prestador)
            comando.Parameters.AddWithValue("@direccion", dts.Tdireccion_prestador)
            comando.Parameters.AddWithValue("@telefono", dts.Ttelefono_prestador)
            comando.Parameters.AddWithValue("@email", dts.Temail_prestador)

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

    Public Function FN_Insertar_NMarca(ByVal dts As ClassTrasportes) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Marca")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@Marca", dts.Tmarca_nueva)

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

    Public Function FnMostrarEntregas() As DataTable
        Try
            Dim connection As New SqlConnection("Data Source=SISTEMAS-PC\;Initial Catalog=Nucleos;User ID=N_ave;Password=ave123")
            connection.Open()

            comando = New SqlCommand("SP_Mostrar_entregas_Sistema_Costos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = connection
            comando.Parameters.AddWithValue("@rango", Entregas_diarias.DateTime_hoy.Value)
            If comando.ExecuteNonQuery Then
                Dim tabla As New DataTable
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.Fill(tabla)
                Return tabla
            Else
                Return Nothing

            End If
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function


    '------------------------------------------- Agregar Fletes --------------------------------------
    Public Function FN_Insertar_flete_entregas(ByVal dts As ClassFletesYEntregas) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Inserta_fletes_entrega")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@Codigo", dts.FE_codigo)
            comando.Parameters.AddWithValue("@Vehiculo", dts.FE_vehiculo)
            comando.Parameters.AddWithValue("@salida", dts.FE_salida)
            comando.Parameters.AddWithValue("@regreso", dts.FE_regreso)
            comando.Parameters.AddWithValue("@km_recorridos", dts.FE_km_recorridos)
            comando.Parameters.AddWithValue("@dias_viaje", dts.FE_dias_viaje)
            comando.Parameters.AddWithValue("@Mantenimiento_promedio", dts.FE_mantenimiento_promedio)
            comando.Parameters.AddWithValue("@depreciacion", dts.FE_depresiacion)
            comando.Parameters.AddWithValue("@ot", dts.FE_ot)
            comando.Parameters.AddWithValue("@chofer", dts.FE_chofer)
            comando.Parameters.AddWithValue("@sueldo", dts.FE_sueldo)
            comando.Parameters.AddWithValue("@costo_diesel_sin_iva", dts.FE_costo_diesel)
            comando.Parameters.AddWithValue("@litros", dts.FE_litros)
            comando.Parameters.AddWithValue("@total_diesel_snIva", dts.FE_total_diesel)
            comando.Parameters.AddWithValue("@casetas", dts.FE_casetas)
            comando.Parameters.AddWithValue("@fumigacion", dts.FE_fumigacion)
            comando.Parameters.AddWithValue("@gastos_varios", dts.FE_gastos_varios)
            comando.Parameters.AddWithValue("@comidas", dts.FE_comidas)
            comando.Parameters.AddWithValue("@varios", dts.FE_varios)
            comando.Parameters.AddWithValue("@sueldos", dts.FE_sueldo2)
            comando.Parameters.AddWithValue("@mantenimiento", dts.FE_mantenimiento)
            comando.Parameters.AddWithValue("@depresiacion", dts.FE_depresiacion2)
            comando.Parameters.AddWithValue("@totalgastos_variable", dts.FE_total_gastos_variable_mas_fijos)
            comando.Parameters.AddWithValue("@porsentaje", dts.FE_porcentaje)
            comando.Parameters.AddWithValue("@utilidad_diaria", dts.FE_Utilidad_diaria)
            comando.Parameters.AddWithValue("@costo_servicion", dts.FE_costo_servicion)
            comando.Parameters.AddWithValue("@iva_aplicado", dts.FE_iva_aplicado)
            comando.Parameters.AddWithValue("@retencion_aplicada", dts.FE_retencion_aplicada)
            comando.Parameters.AddWithValue("@total_a_pagar", dts.FE_total_a_pagar)

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
    Public Function FnMostrar_Fletes_Entregas() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_FleEntre")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", registros_fletes_y_entregas.rango1.Value)
            comando.Parameters.AddWithValue("@rango2", registros_fletes_y_entregas.rango2.Value)
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



End Class

















