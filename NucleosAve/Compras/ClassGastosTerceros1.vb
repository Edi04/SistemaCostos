Public Class ClassGastosTerceros1
    Dim codigo, descripcion, pedimento, codigoPed As String
    Dim importe, iva, total As Double
    Dim idgastos1 As Integer
    Public Property GT_codigoPed
        Get
            Return codigoPed
        End Get
        Set(value)
            codigoPed = value
        End Set
    End Property
    Public Property GT_idgastos1
        Get
            Return idgastos1
        End Get
        Set(value)
            idgastos1 = value
        End Set
    End Property
    Public Property GT_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property GT_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property GT_importe
        Get
            Return importe
        End Get
        Set(value)
            importe = value
        End Set
    End Property
    Public Property GT_iva
        Get
            Return iva
        End Get
        Set(value)
            iva = value
        End Set
    End Property
    Public Property GT_total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property GT_pedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property
End Class
