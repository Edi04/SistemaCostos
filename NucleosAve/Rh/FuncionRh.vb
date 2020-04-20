Imports System.Data.SqlClient
Public Class FuncionRh
    Dim comando As SqlCommand
    Dim conexioncita As String = My.Settings.Conexxx

    '-------------->Alta de RH<------------
    Public Function FN_InsertarRh(ByVal dts As ClassRh) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_RH")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@verificado_calidad", dts.RH_verificado_calidad)
            comando.Parameters.AddWithValue("@clave", dts.RH_clave)
            comando.Parameters.AddWithValue("@nombre", dts.RH_nombre_empleado)
            comando.Parameters.AddWithValue("@departamento", dts.RH_departamento)
            comando.Parameters.AddWithValue("@puesto", dts.RH_puesto)
            comando.Parameters.AddWithValue("@proceso", dts.RH_proceso)
            comando.Parameters.AddWithValue("@observaciones", dts.RH_observaciones)
            comando.Parameters.AddWithValue("@ingreso", dts.RH_ingreso)
            comando.Parameters.AddWithValue("@salario_diaro", dts.RH_salario_diario)
            comando.Parameters.AddWithValue("@numseguro", dts.RH_n_seguro_social)
            comando.Parameters.AddWithValue("@sueldo", dts.RH_sueldo)
            comando.Parameters.AddWithValue("@compensasion", dts.RH_compensacion)
            comando.Parameters.AddWithValue("@tiempo_extra", dts.RH_tiempo_extra)
            comando.Parameters.AddWithValue("@aguinaldo", dts.RH_aguinaldo)
            comando.Parameters.AddWithValue("@vacaciones", dts.RH_vacaciones)
            comando.Parameters.AddWithValue("@prima_vacacional", dts.RH_prima_vacacional)
            comando.Parameters.AddWithValue("@ptu", dts.RH_ptu)
            comando.Parameters.AddWithValue("@bono_productividad", dts.RH_bono_productividad)
            comando.Parameters.AddWithValue("@prima_dominical", dts.RH_prima_dominical)
            comando.Parameters.AddWithValue("@subcidio_incapaciodad", dts.RH_subsidio_incapacidad)
            comando.Parameters.AddWithValue("@sueldo_retroactivo", dts.RH_sueldo_retroactivo)
            comando.Parameters.AddWithValue("@prestamo_personal", dts.RH_prestamo_personal)
            comando.Parameters.AddWithValue("@vacaciones_pagadas", dts.RH_vacaciones_pagadas)
            comando.Parameters.AddWithValue("@gratificacion_anual", dts.RH_gratificacion_anual)
            comando.Parameters.AddWithValue("@indemnizacion", dts.RH_indemnizacion)
            comando.Parameters.AddWithValue("@prima_antiguedad", dts.RH_prima_antiguedad)
            comando.Parameters.AddWithValue("@premio_puntualidad", dts.RH_premio_puntualidad)
            comando.Parameters.AddWithValue("@prestamo_personal_persepcion", dts.RH_prestamo_personal_percepcion)
            comando.Parameters.AddWithValue("@total_persepciones_sinprestamo", dts.RH_total_percepciones_sin_prestamo)
            comando.Parameters.AddWithValue("@dias", dts.RH_dias)
            comando.Parameters.AddWithValue("@sdi", dts.RH_sdi)
            comando.Parameters.AddWithValue("@inc", dts.RH_inc)
            comando.Parameters.AddWithValue("@aus", dts.RH_aus)
            comando.Parameters.AddWithValue("@uma_diaria", dts.RH_uma_diaria)
            comando.Parameters.AddWithValue("@uma_mensual", dts.RH_uma_mensual)
            comando.Parameters.AddWithValue("@factor_mensual", dts.RH_factor_mensual)
            comando.Parameters.AddWithValue("@cuotapat", dts.RH_cuota_pat)
            comando.Parameters.AddWithValue("@cuota_diaria", dts.RH_cuota_diaria)
            comando.Parameters.AddWithValue("@cf", dts.RH_cf)
            comando.Parameters.AddWithValue("@falso_verdadero", dts.RH_verdadero_falso)
            comando.Parameters.AddWithValue("@exc_pat", dts.RH_exc_pat)
            comando.Parameters.AddWithValue("@pd_pat", dts.RH_pd_pat)
            comando.Parameters.AddWithValue("@gmp_pat", dts.RH_gmp_pat)
            comando.Parameters.AddWithValue("@rt", dts.RH_rt)
            comando.Parameters.AddWithValue("@iv_pat", dts.RH_iv_pat)
            comando.Parameters.AddWithValue("@gps", dts.RH_gps)
            comando.Parameters.AddWithValue("@RETIRO", dts.RH_retiro)
            comando.Parameters.AddWithValue("@VEJESPATRONAL", dts.RH_cesantia_vejes)
            comando.Parameters.AddWithValue("@APORTACION_PATRONAL", dts.RH_aportacion_patronal)
            comando.Parameters.AddWithValue("@TOTAL_cARGA_SOCIAL", dts.RH_total_carga_social)
            comando.Parameters.AddWithValue("@impuestos_nominas", dts.RH_impuestos_nominas)
            comando.Parameters.AddWithValue("@manodeObra", dts.RH_mano_de_obra)
            comando.Parameters.AddWithValue("@horas_trabajadas_mes", dts.RH_horas_trabajadas_mes)
            comando.Parameters.AddWithValue("@costoporhora", dts.RH_costoxhora)
            comando.Parameters.AddWithValue("@costoxminuto", dts.RH_costoxminuto)
            comando.Parameters.AddWithValue("@estado", "Activo")
            Dim hora2 As String = DateTime.Now.ToString("dd/MM/yyyy")
            comando.Parameters.AddWithValue("@fecha", hora2)

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
    '<--------------Fin Alta--------------->

    '<------------------------Listado de Rh----------------------------->
    Public Function FnMostrarListadoRh() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_RHs")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", RegistrosRH.DateTimePicker_rango1.Value)
            comando.Parameters.AddWithValue("@rango2", RegistrosRH.DateTimePicker_rango2.Value)
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
    '<.........................fIN lISTADO----------------------------------------->

    '-------------->;Pdofocacion de RH<------------
    Public Function FN_MOdificarRh(ByVal dts As ClassRh) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_MOdificar_RH")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@verificado_calidad", dts.RH_verificado_calidad)
            comando.Parameters.AddWithValue("@clave", dts.RH_clave)
            comando.Parameters.AddWithValue("@nombre", dts.RH_nombre_empleado)
            comando.Parameters.AddWithValue("@departamento", dts.RH_departamento)
            comando.Parameters.AddWithValue("@puesto", dts.RH_puesto)
            comando.Parameters.AddWithValue("@proceso", dts.RH_proceso)
            comando.Parameters.AddWithValue("@observaciones", dts.RH_observaciones)
            comando.Parameters.AddWithValue("@ingreso", dts.RH_ingreso)
            comando.Parameters.AddWithValue("@salario_diaro", dts.RH_salario_diario)
            comando.Parameters.AddWithValue("@numseguro", dts.RH_n_seguro_social)
            comando.Parameters.AddWithValue("@sueldo", dts.RH_sueldo)
            comando.Parameters.AddWithValue("@compensasion", dts.RH_compensacion)
            comando.Parameters.AddWithValue("@tiempo_extra", dts.RH_tiempo_extra)
            comando.Parameters.AddWithValue("@aguinaldo", dts.RH_aguinaldo)
            comando.Parameters.AddWithValue("@vacaciones", dts.RH_vacaciones)
            comando.Parameters.AddWithValue("@prima_vacacional", dts.RH_prima_vacacional)
            comando.Parameters.AddWithValue("@ptu", dts.RH_ptu)
            comando.Parameters.AddWithValue("@bono_productividad", dts.RH_bono_productividad)
            comando.Parameters.AddWithValue("@prima_dominical", dts.RH_prima_dominical)
            comando.Parameters.AddWithValue("@subcidio_incapaciodad", dts.RH_subsidio_incapacidad)
            comando.Parameters.AddWithValue("@sueldo_retroactivo", dts.RH_sueldo_retroactivo)
            comando.Parameters.AddWithValue("@prestamo_personal", dts.RH_prestamo_personal)
            comando.Parameters.AddWithValue("@vacaciones_pagadas", dts.RH_vacaciones_pagadas)
            comando.Parameters.AddWithValue("@gratificacion_anual", dts.RH_gratificacion_anual)
            comando.Parameters.AddWithValue("@indemnizacion", dts.RH_indemnizacion)
            comando.Parameters.AddWithValue("@prima_antiguedad", dts.RH_prima_antiguedad)
            comando.Parameters.AddWithValue("@premio_puntualidad", dts.RH_premio_puntualidad)
            comando.Parameters.AddWithValue("@prestamo_personal_persepcion", dts.RH_prestamo_personal_percepcion)
            comando.Parameters.AddWithValue("@total_persepciones_sinprestamo", dts.RH_total_percepciones_sin_prestamo)
            comando.Parameters.AddWithValue("@dias", dts.RH_dias)
            comando.Parameters.AddWithValue("@sdi", dts.RH_sdi)
            comando.Parameters.AddWithValue("@inc", dts.RH_inc)
            comando.Parameters.AddWithValue("@aus", dts.RH_aus)
            comando.Parameters.AddWithValue("@uma_diaria", dts.RH_uma_diaria)
            comando.Parameters.AddWithValue("@uma_mensual", dts.RH_uma_mensual)
            comando.Parameters.AddWithValue("@factor_mensual", dts.RH_factor_mensual)
            comando.Parameters.AddWithValue("@cuotapat", dts.RH_cuota_pat)
            comando.Parameters.AddWithValue("@cuota_diaria", dts.RH_cuota_diaria)
            comando.Parameters.AddWithValue("@cf", dts.RH_cf)
            comando.Parameters.AddWithValue("@falso_verdadero", dts.RH_verdadero_falso)
            comando.Parameters.AddWithValue("@exc_pat", dts.RH_exc_pat)
            comando.Parameters.AddWithValue("@pd_pat", dts.RH_pd_pat)
            comando.Parameters.AddWithValue("@gmp_pat", dts.RH_gmp_pat)
            comando.Parameters.AddWithValue("@rt", dts.RH_rt)
            comando.Parameters.AddWithValue("@iv_pat", dts.RH_iv_pat)
            comando.Parameters.AddWithValue("@gps", dts.RH_gps)
            comando.Parameters.AddWithValue("@RETIRO", dts.RH_retiro)
            comando.Parameters.AddWithValue("@VEJESPATRONAL", dts.RH_cesantia_vejes)
            comando.Parameters.AddWithValue("@APORTACION_PATRONAL", dts.RH_aportacion_patronal)
            comando.Parameters.AddWithValue("@TOTAL_cARGA_SOCIAL", dts.RH_total_carga_social)
            comando.Parameters.AddWithValue("@impuestos_nominas", dts.RH_impuestos_nominas)
            comando.Parameters.AddWithValue("@manodeObra", dts.RH_mano_de_obra)
            comando.Parameters.AddWithValue("@horas_trabajadas_mes", dts.RH_horas_trabajadas_mes)
            comando.Parameters.AddWithValue("@costoporhora", dts.RH_costoxhora)
            comando.Parameters.AddWithValue("@costoxminuto", dts.RH_costoxminuto)
            comando.Parameters.AddWithValue("@id", dts.RH_id)
            'comando.Parameters.AddWithValue("@estado", "Activo")
            'Dim hora2 As String = DateTime.Now.ToString("dd/MM/yyyy")
            'comando.Parameters.AddWithValue("@fecha", hora2)

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
    '<--------------Fin Modificacion--------------->

    '-------------->Alta de Empleados<------------
    Public Function FN_InsertarEmpleados(ByVal dts As ClassEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Empleados")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@Numero_Nomina", dts.RH_Numero_Nomina)
            comando.Parameters.AddWithValue("@Nombre_Empleado", dts.RH_Nombre_Empleado)
            comando.Parameters.AddWithValue("@Ape_Paterno", dts.RH_Ape_Paterno)
            comando.Parameters.AddWithValue("@Ape_Materno", dts.RH_Ape_Materno)
            comando.Parameters.AddWithValue("@NNS", dts.RH_NSS)
            comando.Parameters.AddWithValue("@RFC", dts.RH_RFC)
            comando.Parameters.AddWithValue("@Nacionalidad", dts.RH_NAcionalidad)
            comando.Parameters.AddWithValue("@Area", dts.RH_Area)
            comando.Parameters.AddWithValue("@Estudios", dts.RH_Estudios)
            comando.Parameters.AddWithValue("@Correo", dts.RH_correo)
            comando.Parameters.AddWithValue("@Telefono", dts.RH_telefono)
            comando.Parameters.AddWithValue("@Telefono2", dts.RH_telefono2)
            comando.Parameters.AddWithValue("@Direccion", dts.RH_direccion)
            comando.Parameters.AddWithValue("@Perfil", dts.RH_perfil)
            comando.Parameters.AddWithValue("@Alerg_Enfe", dts.RH_alergis)
            comando.Parameters.AddWithValue("@F_Nacimiento", dts.RH_fecha_nacimiento)
            comando.Parameters.AddWithValue("@Edad", dts.RH_edad)
            comando.Parameters.AddWithValue("@Edo_Civil", dts.RH_estado_civil)
            comando.Parameters.AddWithValue("@Nombre_Familiar", dts.RH_NOmbre_Familiar)
            comando.Parameters.AddWithValue("@Telefono_F", dts.RH_telefono_fam)

            comando.Parameters.AddWithValue("@Direccion_F", dts.RH_direccion_fam)
            comando.Parameters.AddWithValue("@Fotografia", dts.RH_fotografia)
            comando.Parameters.AddWithValue("@F_Ingreso", dts.RH_fecha_ingreso)
            Dim hora2 As String = DateTime.Now.ToString("dd/MM/yyyy")
            comando.Parameters.AddWithValue("@Fecha_Ingreso", hora2)
            comando.Parameters.AddWithValue("@estado", "Activo")

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
    '<--------------Fin Alta--------------->
    '<------------------------Listado de Empleados----------------------------->
    Public Function FnMostrarListadoEmpleados() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Empleados")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", Busquedas_Empleados.DateTime_rango1.Value)
            comando.Parameters.AddWithValue("@rango2", Busquedas_Empleados.DateTime_rango2.Value)
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

    '-------------->Alta de Empleados<------------
    Public Function FN_MOdificarEmpleados(ByVal dts As ClassEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Empleados")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@Numero_Nomina", dts.RH_Numero_Nomina)
            comando.Parameters.AddWithValue("@Nombre_Empleado", dts.RH_Nombre_Empleado)
            comando.Parameters.AddWithValue("@Ape_Paterno", dts.RH_Ape_Paterno)
            comando.Parameters.AddWithValue("@Ape_Materno", dts.RH_Ape_Materno)
            comando.Parameters.AddWithValue("@NNS", dts.RH_NSS)
            comando.Parameters.AddWithValue("@RFC", dts.RH_RFC)
            comando.Parameters.AddWithValue("@Nacionalidad", dts.RH_NAcionalidad)
            comando.Parameters.AddWithValue("@Area", dts.RH_Area)
            comando.Parameters.AddWithValue("@Estudios", dts.RH_Estudios)
            comando.Parameters.AddWithValue("@Correo", dts.RH_correo)
            comando.Parameters.AddWithValue("@Telefono", dts.RH_telefono)
            comando.Parameters.AddWithValue("@Telefono2", dts.RH_telefono2)
            comando.Parameters.AddWithValue("@Direccion", dts.RH_direccion)
            comando.Parameters.AddWithValue("@Perfil", dts.RH_perfil)
            comando.Parameters.AddWithValue("@Alerg_Enfe", dts.RH_alergis)
            comando.Parameters.AddWithValue("@F_Nacimiento", dts.RH_fecha_nacimiento)
            comando.Parameters.AddWithValue("@Edad", dts.RH_edad)
            comando.Parameters.AddWithValue("@Edo_Civil", dts.RH_estado_civil)
            comando.Parameters.AddWithValue("@Nombre_Familiar", dts.RH_NOmbre_Familiar)
            comando.Parameters.AddWithValue("@Telefono_F", dts.RH_telefono_fam)
            comando.Parameters.AddWithValue("@Direccion_F", dts.RH_direccion_fam)
            comando.Parameters.AddWithValue("@Fotografia", dts.RH_fotografia)
            comando.Parameters.AddWithValue("@F_Ingreso", dts.RH_fecha_ingreso)
            comando.Parameters.AddWithValue("@id", dts.RH_id_empleado)

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
    '<--------------Fin Alta--------------->

    '-----------------Eliminar Empleado------------------>
    Public Function FN_EliminarEmpleado(ByVal dts As ClassEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_EliminarEmpleado")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@id", dts.RH_id_empleado)
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
    '----------------------------------------------------

    '-------------->Alta de Empleados<------------
    Public Function FN_InsertarReportes(ByVal dts As ClassReportesEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Insertar_Reportes_Empleados")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@empleado", dts.RE_empleado)
            comando.Parameters.AddWithValue("@Quien_Reporta", dts.RE_quien_reporta)
            comando.Parameters.AddWithValue("@fecha", dts.RE_fecha)
            comando.Parameters.AddWithValue("@motivo", dts.RE_motivo)
            comando.Parameters.AddWithValue("@descripcion", dts.RE_descripcion)
            comando.Parameters.AddWithValue("@estado", "Activo")

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

    '<------------------------Listado de Reportes----------------------------->
    Public Function FnMostrarReportes() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Reports")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", RegistrosReportes.rango1.Value)
            comando.Parameters.AddWithValue("@rango2", RegistrosReportes.rango2.Value)
            comando.Parameters.AddWithValue("@empleado", RegistrosReportes.ComboBox_empleado.Text)
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
    '<.........................fIN lISTADO----------------------------------------->
    '-------------->Modificaion Reportes<------------
    Public Function FN_ModificarReportes(ByVal dts As ClassReportesEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_Modificar_Reportes_Empleados")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@empleado", dts.RE_empleado)
            comando.Parameters.AddWithValue("@Quien_Reporta", dts.RE_quien_reporta)
            comando.Parameters.AddWithValue("@fecha", dts.RE_fecha)
            comando.Parameters.AddWithValue("@motivo", dts.RE_motivo)
            comando.Parameters.AddWithValue("@descripcion", dts.RE_descripcion)
            comando.Parameters.AddWithValue("@id", dts.RE_id)


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

    '<------------------------Listado de Entrega de Equipo de Seguridad----------------------------->
    Public Function FnMostrarEntregaEpp() As DataTable
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()

            comando = New SqlCommand("SP_Mostrar_Entregas_Equipo_Seguridad")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo
            comando.Parameters.AddWithValue("@rango1", Entregas_Equipo_Proteccion.rango1.Value)
            comando.Parameters.AddWithValue("@rango2", Entregas_Equipo_Proteccion.rango2.Value)
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
    '<.........................fIN lISTADO----------------------------------------->
    '-----------------Eliminar Reporte------------------>
    Public Function FN_EliminarReporte(ByVal dts As ClassReportesEmpleados) As Boolean
        Try
            Dim conexxo As New SqlConnection(conexioncita)
            conexxo.Open()
            comando = New SqlCommand("SP_EliminarReporte")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexxo

            comando.Parameters.AddWithValue("@id", dts.RE_id)
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
    '----------------------------------------------------
End Class
