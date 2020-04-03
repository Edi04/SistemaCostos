Public Class ClassRegistrosFactuProd
    Dim id_fact_prod As Integer
    Dim codigo, codigo_identificacion, unidad, descripcion As String
    Dim cantidad, valorunitario, importe As Double

    Public Property FPid_fact_prod
        Get
            Return id_fact_prod
        End Get
        Set(value)
            id_fact_prod = value
        End Set
    End Property
    Public Property FPcodigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property
    Public Property FPcodigo_identificacion
        Get
            Return codigo_identificacion
        End Get
        Set(value)
            codigo_identificacion = value
        End Set
    End Property
    Public Property FPcantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property FPdescripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property FPvalorunitario
        Get
            Return valorunitario
        End Get
        Set(value)
            valorunitario = value
        End Set
    End Property
    Public Property FPunidad
        Get
            Return unidad
        End Get
        Set(value)
            unidad = value
        End Set
    End Property
    Public Property FPimporte
        Get
            Return importe
        End Get
        Set(value)
            importe = value
        End Set
    End Property
End Class
