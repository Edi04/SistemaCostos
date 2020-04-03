Public Class ClassGastosTerceros2
    Dim descripcion, concepto, pedimento, codigoPed As String
    Dim exento, gravado, iva, total As Double
    Dim idgastos2 As Integer

    Public Property GT2_codigoPed
        Get
            Return codigoPed
        End Get
        Set(value)
            codigoPed = value
        End Set
    End Property
    Public Property GT2_idgastos2
        Get
            Return idgastos2
        End Get
        Set(value)
            idgastos2 = value
        End Set
    End Property
    Public Property GT2_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property GT2_concepto
        Get
            Return concepto
        End Get
        Set(value)
            concepto = value
        End Set
    End Property
    Public Property GT2_exento
        Get
            Return exento
        End Get
        Set(value)
            exento = value
        End Set
    End Property
    Public Property GT2_gravado
        Get
            Return gravado
        End Get
        Set(value)
            gravado = value
        End Set
    End Property
    Public Property GT2_iva
        Get
            Return iva
        End Get
        Set(value)
            iva = value
        End Set
    End Property
    Public Property GT2_total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property

    Public Property GT2_pedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property


End Class
