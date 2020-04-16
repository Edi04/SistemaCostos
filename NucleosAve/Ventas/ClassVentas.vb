Public Class ClassVentas
    Dim estatus, facturapdf, codigo, factura As String
    Dim total As Double
    Dim fecha As Date
    Dim id As Integer

    Public Property Vid
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property Vfactura
        Get
            Return factura
        End Get
        Set(value)
            factura = value
        End Set
    End Property
    Public Property Vestatus
        Get
            Return estatus
        End Get
        Set(value)
            estatus = value
        End Set
    End Property

    Public Property Vfacturapdf
        Get
            Return facturapdf
        End Get
        Set(value)
            facturapdf = value
        End Set
    End Property
    Public Property Vcodigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property Vtotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property Vfecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
End Class
