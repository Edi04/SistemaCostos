Public Class ClassConbustible
    Dim tipo, comprobante, responsable, trasporte, chofer, gasolinera, codigo, compania, area, quien_porta_unidad, numero_vale, mpn, entrego As String
    Dim fecha, vence As Date
    Dim precio, total, litros, valepor, cantidad_cuenta As Double

    Public Property Con_entrego
        Get
            Return entrego
        End Get
        Set(value)
            entrego = value
        End Set
    End Property
    Public Property Con_mpn
        Get
            Return mpn
        End Get
        Set(value)
            mpn = value
        End Set
    End Property
    Public Property Con_numero_vale
        Get
            Return numero_vale
        End Get
        Set(value)
            numero_vale = value
        End Set
    End Property
    Public Property Con_quien_porta_unidad
        Get
            Return quien_porta_unidad
        End Get
        Set(value)
            quien_porta_unidad = value
        End Set
    End Property
    Public Property Con_cantidad_cuenta
        Get
            Return cantidad_cuenta
        End Get
        Set(value)
            cantidad_cuenta = value
        End Set
    End Property
    Public Property Con_area
        Get
            Return area
        End Get
        Set(value)
            area = value
        End Set
    End Property
    Public Property Con_vence
        Get
            Return vence
        End Get
        Set(value)
            vence = value
        End Set
    End Property
    Public Property Con_valepor
        Get
            Return valepor
        End Get
        Set(value)
            valepor = value
        End Set
    End Property
    Public Property Con_compania
        Get
            Return compania
        End Get
        Set(value)
            compania = value
        End Set
    End Property
    Public Property Con_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property Con_gasolinera
        Get
            Return gasolinera
        End Get
        Set(value)
            gasolinera = value
        End Set
    End Property
    Public Property Con_chofer
        Get
            Return chofer
        End Get
        Set(value)
            chofer = value
        End Set
    End Property
    Public Property Con_trasporte
        Get
            Return trasporte
        End Get
        Set(value)
            trasporte = value
        End Set
    End Property

    Public Property Con_responsable
        Get
            Return responsable
        End Get
        Set(value)
            responsable = value
        End Set
    End Property

    Public Property Con_comprobante
        Get
            Return comprobante
        End Get
        Set(value)
            comprobante = value
        End Set
    End Property
    Public Property Con_tipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property
    Public Property Con_fecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
    Public Property Con_litros
        Get
            Return litros
        End Get
        Set(value)
            litros = value
        End Set
    End Property
    Public Property Con_precio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property
    Public Property Con_total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
End Class
