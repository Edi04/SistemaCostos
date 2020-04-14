Public Class ClassPedimentosMercancias
    Dim id_productos, idmercancia As Integer
    Dim mercancia, fraccion, pedimento, codigoPed, codigo_bueno As String

    Public Property Merc_codigo_bueno
        Get
            Return codigo_bueno
        End Get
        Set(value)
            codigo_bueno = value
        End Set
    End Property
    Public Property Merc_codigoPed
        Get
            Return codigoPed
        End Get
        Set(value)
            codigoPed = value
        End Set
    End Property
    Public Property Merc_idmercancia
        Get
            Return idmercancia
        End Get
        Set(value)
            idmercancia = value
        End Set
    End Property
    Public Property Merc_id_productos
        Get
            Return id_productos
        End Get
        Set(value)
            id_productos = value
        End Set
    End Property
    Public Property Merc_mercancia
        Get
            Return mercancia
        End Get
        Set(value)
            mercancia = value
        End Set
    End Property
    Public Property Merc_fraccion
        Get
            Return fraccion
        End Get
        Set(value)
            fraccion = value
        End Set
    End Property

    Public Property Merc_pedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property

End Class
