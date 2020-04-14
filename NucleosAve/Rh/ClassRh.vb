Public Class ClassRh
    Dim verificado_calidad, clave, nombre_empleado, departamento, puesto, proceso, observaciones, n_seguro_social, dias, verdadero_falso As String
    Dim ingreso As Date
    Dim salario_diario, sueldo, compensacion, tiempo_extra,
        aguinaldo, vacaciones, prima_vacacional, ptu, bono_productividad,
        prima_dominical, subsidio_incapacidad, sueldo_retroactivo,
        prestamo_personal, vacaciones_pagadas, gratificacion_anual, indemnizacion, prima_antiguedad,
        premio_puntualidad, prestamo_personal_percepcion, total_percepciones_sin_prestamo,
        sdi, inc, aus, uma_diaria, uma_mensual, factor_mensual, cuota_pat, cuota_diaria, cf, exc_pat,
        pd_pat, gmp_pat, rt, iv_pat, gps, retiro, cesantia_vejes, aportacion_patronal, total_carga_social,
        impuestos_nominas, mano_de_obra, horas_trabajadas_mes, costoxhora, costoxminuto As Double

    Public Property RH_costoxminuto
        Get
            Return costoxminuto
        End Get
        Set(value)
            costoxminuto = value
        End Set
    End Property
    Public Property RH_costoxhora
        Get
            Return costoxhora
        End Get
        Set(value)
            costoxhora = value
        End Set
    End Property
    Public Property RH_horas_trabajadas_mes
        Get
            Return horas_trabajadas_mes
        End Get
        Set(value)
            horas_trabajadas_mes = value
        End Set
    End Property
    Public Property RH_mano_de_obra
        Get
            Return mano_de_obra
        End Get
        Set(value)
            mano_de_obra = value
        End Set
    End Property
    Public Property RH_impuestos_nominas
        Get
            Return impuestos_nominas
        End Get
        Set(value)
            impuestos_nominas = value
        End Set
    End Property
    Public Property RH_total_carga_social
        Get
            Return total_carga_social
        End Get
        Set(value)
            total_carga_social = value
        End Set
    End Property
    Public Property RH_aportacion_patronal
        Get
            Return aportacion_patronal
        End Get
        Set(value)
            aportacion_patronal = value
        End Set
    End Property
    Public Property RH_cesantia_vejes
        Get
            Return cesantia_vejes
        End Get
        Set(value)
            cesantia_vejes = value
        End Set
    End Property
    Public Property RH_retiro
        Get
            Return retiro
        End Get
        Set(value)
            retiro = value
        End Set
    End Property
    Public Property RH_gps
        Get
            Return gps
        End Get
        Set(value)
            gps = value
        End Set
    End Property
    Public Property RH_iv_pat
        Get
            Return iv_pat
        End Get
        Set(value)
            iv_pat = value
        End Set
    End Property
    Public Property RH_rt
        Get
            Return rt
        End Get
        Set(value)
            rt = value
        End Set
    End Property
    Public Property RH_gmp_pat
        Get
            Return gmp_pat
        End Get
        Set(value)
            gmp_pat = value
        End Set
    End Property
    Public Property RH_pd_pat
        Get
            Return pd_pat
        End Get
        Set(value)
            pd_pat = value
        End Set
    End Property
    Public Property RH_exc_pat
        Get
            Return exc_pat
        End Get
        Set(value)
            exc_pat = value
        End Set
    End Property
    Public Property RH_cf
        Get
            Return cf
        End Get
        Set(value)
            cf = value
        End Set
    End Property
    Public Property RH_cuota_diaria
        Get
            Return cuota_diaria
        End Get
        Set(value)
            cuota_diaria = value
        End Set
    End Property
    Public Property RH_cuota_pat
        Get
            Return cuota_pat
        End Get
        Set(value)
            cuota_pat = value
        End Set
    End Property
    Public Property RH_factor_mensual
        Get
            Return factor_mensual
        End Get
        Set(value)
            factor_mensual = value
        End Set
    End Property
    Public Property RH_uma_mensual
        Get
            Return uma_mensual
        End Get
        Set(value)
            uma_mensual = value
        End Set
    End Property
    Public Property RH_uma_diaria
        Get
            Return uma_diaria
        End Get
        Set(value)
            uma_diaria = value
        End Set
    End Property
    Public Property RH_aus
        Get
            Return aus
        End Get
        Set(value)
            aus = value
        End Set
    End Property
    Public Property RH_inc
        Get
            Return inc
        End Get
        Set(value)
            inc = value
        End Set
    End Property
    Public Property RH_sdi
        Get
            Return sdi
        End Get
        Set(value)
            sdi = value
        End Set
    End Property
    Public Property RH_total_percepciones_sin_prestamo
        Get
            Return total_percepciones_sin_prestamo
        End Get
        Set(value)
            total_percepciones_sin_prestamo = value
        End Set
    End Property
    Public Property RH_prestamo_personal_percepcion
        Get
            Return prestamo_personal_percepcion
        End Get
        Set(value)
            prestamo_personal_percepcion = value
        End Set
    End Property
    Public Property RH_premio_puntualidad
        Get
            Return premio_puntualidad
        End Get
        Set(value)
            premio_puntualidad = value
        End Set
    End Property
    Public Property RH_prima_antiguedad
        Get
            Return prima_antiguedad
        End Get
        Set(value)
            prima_antiguedad = value
        End Set
    End Property
    Public Property RH_indemnizacion
        Get
            Return indemnizacion
        End Get
        Set(value)
            indemnizacion = value
        End Set
    End Property
    Public Property RH_gratificacion_anual
        Get
            Return gratificacion_anual
        End Get
        Set(value)
            gratificacion_anual = value
        End Set
    End Property
    Public Property RH_vacaciones_pagadas
        Get
            Return vacaciones_pagadas
        End Get
        Set(value)
            vacaciones_pagadas = value
        End Set
    End Property
    Public Property RH_prestamo_personal
        Get
            Return prestamo_personal
        End Get
        Set(value)
            prestamo_personal = value
        End Set
    End Property
    Public Property RH_sueldo_retroactivo
        Get
            Return sueldo_retroactivo
        End Get
        Set(value)
            sueldo_retroactivo = value
        End Set
    End Property
    Public Property RH_subsidio_incapacidad
        Get
            Return subsidio_incapacidad
        End Get
        Set(value)
            subsidio_incapacidad = value
        End Set
    End Property
    Public Property RH_prima_dominical
        Get
            Return prima_dominical
        End Get
        Set(value)
            prima_dominical = value
        End Set
    End Property
    Public Property RH_bono_productividad
        Get
            Return bono_productividad
        End Get
        Set(value)
            bono_productividad = value
        End Set
    End Property
    Public Property RH_ptu
        Get
            Return ptu
        End Get
        Set(value)
            ptu = value
        End Set
    End Property
    Public Property RH_prima_vacacional
        Get
            Return prima_vacacional
        End Get
        Set(value)
            prima_vacacional = value
        End Set
    End Property
    Public Property RH_vacaciones
        Get
            Return vacaciones
        End Get
        Set(value)
            vacaciones = value
        End Set
    End Property
    Public Property RH_aguinaldo
        Get
            Return aguinaldo
        End Get
        Set(value)
            aguinaldo = value
        End Set
    End Property
    Public Property RH_tiempo_extra
        Get
            Return tiempo_extra
        End Get
        Set(value)
            tiempo_extra = value
        End Set
    End Property
    Public Property RH_compensacion
        Get
            Return compensacion
        End Get
        Set(value)
            compensacion = value
        End Set
    End Property
    Public Property RH_sueldo
        Get
            Return sueldo
        End Get
        Set(value)
            sueldo = value
        End Set
    End Property
    Public Property RH_salario_diario
        Get
            Return salario_diario
        End Get
        Set(value)
            salario_diario = value
        End Set
    End Property
    Public Property RH_ingreso
        Get
            Return ingreso
        End Get
        Set(value)
            ingreso = value
        End Set
    End Property
    Public Property RH_verdadero_falso
        Get
            Return verdadero_falso
        End Get
        Set(value)
            verdadero_falso = value
        End Set
    End Property
    Public Property RH_dias
        Get
            Return dias
        End Get
        Set(value)
            dias = value
        End Set
    End Property
    Public Property RH_n_seguro_social
        Get
            Return n_seguro_social
        End Get
        Set(value)
            n_seguro_social = value
        End Set
    End Property
    Public Property RH_observaciones
        Get
            Return observaciones
        End Get
        Set(value)
            observaciones = value
        End Set
    End Property
    Public Property RH_proceso
        Get
            Return proceso
        End Get
        Set(value)
            proceso = value
        End Set
    End Property
    Public Property RH_puesto
        Get
            Return puesto
        End Get
        Set(value)
            puesto = value
        End Set
    End Property
    Public Property RH_departamento
        Get
            Return departamento
        End Get
        Set(value)
            departamento = value
        End Set
    End Property
    Public Property RH_nombre_empleado
        Get
            Return nombre_empleado
        End Get
        Set(value)
            nombre_empleado = value
        End Set
    End Property
    Public Property RH_clave
        Get
            Return clave
        End Get
        Set(value)
            clave = value
        End Set
    End Property
    Public Property RH_verificado_calidad
        Get
            Return verificado_calidad
        End Get
        Set(value)
            verificado_calidad = value
        End Set
    End Property
End Class
