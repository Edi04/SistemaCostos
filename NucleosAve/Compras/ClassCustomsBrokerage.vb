Public Class ClassCustomsBrokerage
    Dim pedimento, descripcion, seccion, codigoPed As String
    Dim importe, total, iva As Double
    Dim idcustoms As Integer
    Public Property CB_codigoPed
        Get
            Return codigoPed
        End Get
        Set(value)
            codigoPed = value
        End Set
    End Property
    Public Property CB_idcustoms
        Get
            Return idcustoms
        End Get
        Set(value)
            idcustoms = value
        End Set
    End Property
    Public Property CB_pedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property
    Public Property CB_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property CB_importe
        Get
            Return importe
        End Get
        Set(value)
            importe = value
        End Set
    End Property
    Public Property CB_iva
        Get
            Return iva
        End Get
        Set(value)
            iva = value
        End Set
    End Property
    Public Property CB_total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property CB_seccion
        Get
            Return seccion
        End Get
        Set(value)
            seccion = value
        End Set
    End Property
End Class
