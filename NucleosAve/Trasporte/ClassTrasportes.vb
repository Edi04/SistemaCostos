Public Class ClassTrasportes
    Dim marca, modelo, tipo, Ano, n_serie, placas, n_seguro, codigo, cargaKg, oc, factura_trasporte, factura_trasporte2, estado_revision, nombre_prestador, direccion_prestador, telefono_prestador, email_prestador, marca_nueva As String
    Dim vigencia, Fecha_Adqui As Date
    Dim Tasa_Depreciacion, MO_de_Inversio, PN_Deducible, MO_MaxDed, M_D_Acumulada, M_C_de_uso_C_Dep, D_Acumulada, Monto_Actual_Del_Activo As Double


    Public Property Tmarca_nueva
        Get
            Return marca_nueva
        End Get
        Set(value)
            marca_nueva = value
        End Set
    End Property
    Public Property Temail_prestador
        Get
            Return email_prestador
        End Get
        Set(value)
            email_prestador = value
        End Set
    End Property
    Public Property Ttelefono_prestador
        Get
            Return telefono_prestador
        End Get
        Set(value)
            telefono_prestador = value
        End Set
    End Property
    Public Property Tdireccion_prestador
        Get
            Return direccion_prestador
        End Get
        Set(value)
            direccion_prestador = value
        End Set
    End Property
    Public Property Tnombre_prestador
        Get
            Return nombre_prestador
        End Get
        Set(value)
            nombre_prestador = value
        End Set
    End Property
    Public Property Testado_revision
        Get
            Return estado_revision
        End Get
        Set(value)
            estado_revision = value
        End Set
    End Property
    Public Property Tfactura_trasporte2
        Get
            Return factura_trasporte2
        End Get
        Set(value)
            factura_trasporte2 = value
        End Set
    End Property
    Public Property Tfactura_trasporte
        Get
            Return factura_trasporte
        End Get
        Set(value)
            factura_trasporte = value
        End Set
    End Property
    Public Property T_oc
        Get
            Return oc
        End Get
        Set(value)
            oc = value
        End Set
    End Property
    Public Property T_Monto_Actual_Del_Activo
        Get
            Return Monto_Actual_Del_Activo
        End Get
        Set(value)
            Monto_Actual_Del_Activo = value
        End Set
    End Property
    Public Property T_D_Acumulada
        Get
            Return D_Acumulada
        End Get
        Set(value)
            D_Acumulada = value
        End Set
    End Property
    Public Property T_M_C_de_uso_C_Dep
        Get
            Return M_C_de_uso_C_Dep
        End Get
        Set(value)
            M_C_de_uso_C_Dep = value
        End Set
    End Property
    Public Property T_M_D_Acumulada
        Get
            Return M_D_Acumulada
        End Get
        Set(value)
            M_D_Acumulada = value
        End Set
    End Property
    Public Property T_MO_MaxDed
        Get
            Return MO_MaxDed
        End Get
        Set(value)
            MO_MaxDed = value
        End Set
    End Property

    Public Property T_PN_Deducible
        Get
            Return PN_Deducible
        End Get
        Set(value)
            PN_Deducible = value
        End Set
    End Property

    Public Property T_MO_de_Inversio
        Get
            Return MO_de_Inversio
        End Get
        Set(value)
            MO_de_Inversio = value
        End Set
    End Property

    Public Property T_Fecha_Adqui
        Get
            Return Fecha_Adqui
        End Get
        Set(value)
            Fecha_Adqui = value
        End Set
    End Property
    Public Property T_Tasa_Depreciacion
        Get
            Return Tasa_Depreciacion
        End Get
        Set(value)
            Tasa_Depreciacion = value
        End Set
    End Property
    Public Property T_cargaKg
        Get
            Return cargaKg
        End Get
        Set(value)
            cargaKg = value
        End Set
    End Property
    Public Property T_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property T_vigencia
        Get
            Return vigencia
        End Get
        Set(value)
            vigencia = value
        End Set
    End Property
    Public Property T_n_seguro
        Get
            Return n_seguro
        End Get
        Set(value)
            n_seguro = value
        End Set
    End Property
    Public Property T_placas
        Get
            Return placas
        End Get
        Set(value)
            placas = value
        End Set
    End Property
    Public Property T_n_serie
        Get
            Return n_serie
        End Get
        Set(value)
            n_serie = value
        End Set
    End Property
    Public Property T_Ano
        Get
            Return Ano
        End Get
        Set(value)
            Ano = value
        End Set
    End Property

    Public Property T_marca
        Get
            Return marca
        End Get
        Set(value)
            marca = value
        End Set
    End Property

    Public Property T_modelo
        Get
            Return modelo
        End Get
        Set(value)
            modelo = value
        End Set
    End Property

    Public Property T_tipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property

End Class
