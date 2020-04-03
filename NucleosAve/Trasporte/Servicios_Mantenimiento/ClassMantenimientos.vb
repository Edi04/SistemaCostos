Public Class ClassMantenimientos
    Dim orden_servicio, Kilometraje_Actual, Tipo_de_Servicio, Prestador_del_Servicio, Descripcion_Mantenimiento, Sobre_Servicio, Servicio_Extraordinario, Descripcion_ServicioEX, Refacciones, Reviciones_Programadas, Observaciones_Generales, Recomendaciones, Recibio_Recomendaciones, Autorizo, realizo_servicio, Chofer, trasportes, producto, nombre_proveedor_refacciones, comprobantes, estado_revision, codigomantenimiento As String
    Dim Costo_Refacciones, Costo_servicio, costo_traslado, costo_total As Double
    Dim Fecha_os, Fecha_Solicitud, Fecha_Aplicacion, Fecha_Entrega_Estimada, Fecha_Kilometraje, ProximoServicio, Programadas_fecha_reviciones As Date
    Dim id_refac As Integer

    Public Property T_codigomantenimiento
        Get
            Return codigomantenimiento
        End Get
        Set(value)
            codigomantenimiento = value
        End Set
    End Property

    Public Property T_estado_revision
        Get
            Return estado_revision
        End Get
        Set(value)
            estado_revision = value
        End Set
    End Property

    Public Property T_id_refac
        Get
            Return id_refac
        End Get
        Set(value)
            id_refac = value
        End Set
    End Property
    Public Property T_comprobantes
        Get
            Return comprobantes
        End Get
        Set(value)
            comprobantes = value
        End Set
    End Property
    Public Property T_Programadas_fecha_reviciones
        Get
            Return Programadas_fecha_reviciones
        End Get
        Set(value)
            Programadas_fecha_reviciones = value
        End Set
    End Property
    Public Property T_trasportes
        Get
            Return trasportes
        End Get
        Set(value)
            trasportes = value
        End Set
    End Property
    Public Property T_Chofer
        Get
            Return Chofer
        End Get
        Set(value)
            Chofer = value
        End Set
    End Property
    Public Property T_realizo_servicio
        Get
            Return realizo_servicio
        End Get
        Set(value)
            realizo_servicio = value
        End Set
    End Property
    Public Property T_Autorizo
        Get
            Return Autorizo
        End Get
        Set(value)
            Autorizo = value
        End Set
    End Property
    Public Property T_costo_total
        Get
            Return costo_total
        End Get
        Set(value)
            costo_total = value
        End Set
    End Property
    Public Property T_costo_traslado
        Get
            Return costo_traslado
        End Get
        Set(value)
            costo_traslado = value
        End Set
    End Property
    Public Property T_Costo_servicio
        Get
            Return Costo_servicio
        End Get
        Set(value)
            Costo_servicio = value
        End Set
    End Property
    Public Property T_Costo_Refacciones
        Get
            Return Costo_Refacciones
        End Get
        Set(value)
            Costo_Refacciones = value
        End Set
    End Property
    Public Property T_Recibio_Recomendaciones
        Get
            Return Recibio_Recomendaciones
        End Get
        Set(value)
            Recibio_Recomendaciones = value
        End Set
    End Property
    Public Property T_Recomendaciones
        Get
            Return Recomendaciones
        End Get
        Set(value)
            Recomendaciones = value
        End Set
    End Property
    Public Property T_ProximoServicio
        Get
            Return ProximoServicio
        End Get
        Set(value)
            ProximoServicio = value
        End Set
    End Property
    Public Property T_Observaciones_Generales
        Get
            Return Observaciones_Generales
        End Get
        Set(value)
            Observaciones_Generales = value
        End Set
    End Property
    Public Property T_Reviciones_Programadas
        Get
            Return Reviciones_Programadas
        End Get
        Set(value)
            Reviciones_Programadas = value
        End Set
    End Property
    Public Property T_Refacciones
        Get
            Return Refacciones
        End Get
        Set(value)
            Refacciones = value
        End Set
    End Property
    Public Property T_Descripcion_ServicioEX
        Get
            Return Descripcion_ServicioEX
        End Get
        Set(value)
            Descripcion_ServicioEX = value
        End Set
    End Property
    Public Property T_Servicio_Extraordinario
        Get
            Return Servicio_Extraordinario
        End Get
        Set(value)
            Servicio_Extraordinario = value
        End Set
    End Property
    Public Property T_Sobre_Servicio
        Get
            Return Sobre_Servicio
        End Get
        Set(value)
            Sobre_Servicio = value
        End Set
    End Property
    Public Property T_Descripcion_Mantenimiento
        Get
            Return Descripcion_Mantenimiento
        End Get
        Set(value)
            Descripcion_Mantenimiento = value
        End Set
    End Property
    Public Property T_Prestador_del_Servicio
        Get
            Return Prestador_del_Servicio
        End Get
        Set(value)
            Prestador_del_Servicio = value
        End Set
    End Property
    Public Property T_Tipo_de_Servicio
        Get
            Return Tipo_de_Servicio
        End Get
        Set(value)
            Tipo_de_Servicio = value
        End Set
    End Property
    Public Property T_Fecha_Kilometraje
        Get
            Return Fecha_Kilometraje
        End Get
        Set(value)
            Fecha_Kilometraje = value
        End Set
    End Property
    Public Property T_Kilometraje_Actual
        Get
            Return Kilometraje_Actual
        End Get
        Set(value)
            Kilometraje_Actual = value
        End Set
    End Property
    Public Property T_orden_servicio
        Get
            Return orden_servicio
        End Get
        Set(value)
            orden_servicio = value
        End Set
    End Property
    Public Property T_Fecha_os
        Get
            Return Fecha_os
        End Get
        Set(value)
            Fecha_os = value
        End Set
    End Property
    Public Property T_Fecha_Solicitud
        Get
            Return Fecha_Solicitud
        End Get
        Set(value)
            Fecha_Solicitud = value
        End Set
    End Property
    Public Property T_Fecha_Aplicacion
        Get
            Return Fecha_Aplicacion
        End Get
        Set(value)
            Fecha_Aplicacion = value
        End Set
    End Property
    Public Property T_Fecha_Entrega_Estimada
        Get
            Return Fecha_Entrega_Estimada
        End Get
        Set(value)
            Fecha_Entrega_Estimada = value
        End Set
    End Property


    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    '///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    '                                      .....::::: Refacciones ::::.......
    Public Property T_producto
        Get
            Return producto
        End Get
        Set(value)
            producto = value
        End Set
    End Property

    Public Property T_nombre_proveedor_refacciones
        Get
            Return nombre_proveedor_refacciones
        End Get
        Set(value)
            nombre_proveedor_refacciones = value
        End Set
    End Property
    '---------------------------------------------------------------------------------------------------------------------------
End Class
