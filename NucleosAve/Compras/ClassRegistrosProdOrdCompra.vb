Public Class ClassRegistrosProdOrdCompra
    Dim id_pro, id_Ocom, id_p As Integer
    Dim descripcion, codigo, Um, detalles As String
    Dim cantidad, precio, subtotal As Double


    Public Property Gdetalles
        Get
            Return detalles
        End Get
        Set(value)
            detalles = value
        End Set
    End Property

    Public Property GUm
        Get
            Return Um
        End Get
        Set(value)
            Um = value
        End Set
    End Property
    Public Property GId_pro
        Get
            Return id_pro
        End Get
        Set(value)
            id_pro = value
        End Set
    End Property

    Public Property Gid_Ocom
        Get
            Return id_Ocom
        End Get
        Set(value)
            id_Ocom = value
        End Set
    End Property

    Public Property GId_p
        Get
            Return id_p
        End Get
        Set(value)
            id_p = value
        End Set
    End Property



    Public Property Gdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property GCantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property

    Public Property Gprecio
        Get
            Return precio
        End Get
        Set(value)
            precio = value
        End Set
    End Property

    Public Property Gsubtotal
        Get
            Return subtotal
        End Get
        Set(value)
            subtotal = value
        End Set
    End Property

    Public Property G_id_pro_pro
        Get
            Return id_pro
        End Get
        Set(value)
            id_pro = value
        End Set
    End Property

    Public Property G_codigo_pro
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property



End Class
