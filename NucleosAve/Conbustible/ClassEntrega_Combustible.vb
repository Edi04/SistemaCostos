Public Class ClassEntrega_Combustible
    Dim codigo, trasporte, tipo, entrego, recibio As String
    Dim fecha As Date
    Dim litros_entregados As Double

    Public Property Con_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
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

    Public Property Con_tipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property

    Public Property Con_entrego
        Get
            Return entrego
        End Get
        Set(value)
            entrego = value
        End Set
    End Property

    Public Property Con_recibio
        Get
            Return recibio
        End Get
        Set(value)
            recibio = value
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

    Public Property Con_litros_entregados
        Get
            Return litros_entregados
        End Get
        Set(value)
            litros_entregados = value
        End Set
    End Property
End Class
