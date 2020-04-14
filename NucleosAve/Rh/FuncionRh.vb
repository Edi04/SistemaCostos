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

    '<.........................fIN lISTADO----------------------------------------->
End Class
