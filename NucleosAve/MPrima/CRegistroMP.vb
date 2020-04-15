Public Class CRegistroMP
    Dim Num_RI, Num_RE, IdOD As Integer
    Dim Ancho, Peso, CE As Double
    Dim Proveedor, Calibre, Descripcion, OCompra, LCS, Trabaja, Pedimento As String
    Dim FLlegada, FRegistro As Date

    Public Property Proveedor_
        Get
            Return Proveedor
        End Get
        Set(value)
            Proveedor = value
        End Set
    End Property

    Public Property Num_RIn
        Get
            Return Num_RI
        End Get
        Set(value)
            Num_RI = value
        End Set
    End Property

    Public Property Num_REx
        Get
            Return Num_RE
        End Get
        Set(value)
            Num_RE = value
        End Set
    End Property

    Public Property Calibre_
        Get
            Return Calibre
        End Get
        Set(value)
            Calibre = value
        End Set
    End Property

    Public Property Ancho_
        Get
            Return Ancho
        End Get
        Set(value)
            Ancho = value
        End Set
    End Property

    Public Property Peso_
        Get
            Return Peso
        End Get
        Set(value)
            Peso = value
        End Set
    End Property

    Public Property Descripcion_
        Get
            Return Descripcion
        End Get
        Set(value)
            Descripcion = value
        End Set
    End Property

    Public Property FechaLlegada
        Get
            Return FLlegada
        End Get
        Set(value)
            FLlegada = value
        End Set
    End Property

    Public Property FechaRegistro
        Get
            Return FRegistro
        End Get
        Set(value)
            FRegistro = value
        End Set
    End Property

    Public Property OCompra_
        Get
            Return OCompra
        End Get
        Set(value)
            OCompra = value
        End Set
    End Property

    Public Property LCS_
        Get
            Return LCS
        End Get
        Set(value)
            LCS = value
        End Set
    End Property

    Public Property Trabaj
        Get
            Return Trabaja
        End Get
        Set(value)
            Trabaja = value
        End Set
    End Property

    Public Property CE_
        Get
            Return CE
        End Get
        Set(value)
            CE = value
        End Set
    End Property

    Public Property IDDO_
        Get
            Return IdOD
        End Get
        Set(value)
            IdOD = value
        End Set
    End Property

    Public Property Pedimento_
        Get
            Return Pedimento
        End Get
        Set(value)
            Pedimento = value
        End Set
    End Property
End Class
