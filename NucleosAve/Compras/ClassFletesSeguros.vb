Public Class ClassFletesSeguros
    Dim pedimento, descripcion, seccion, codigoPed As String
    Dim importe, total, iva, retenciones, tc, usd As Double
    Dim idflete As Integer

    Public Property FS_usd
        Get
            Return usd
        End Get
        Set(value)
            usd = value
        End Set
    End Property
    Public Property FS_tc
        Get
            Return tc
        End Get
        Set(value)
            tc = value
        End Set
    End Property
    Public Property FS_retenciones
        Get
            Return retenciones
        End Get
        Set(value)
            retenciones = value
        End Set
    End Property
    Public Property FS_codigoPed
        Get
            Return codigoPed
        End Get
        Set(value)
            codigoPed = value
        End Set
    End Property
    Public Property FS_idflete
        Get
            Return idflete
        End Get
        Set(value)
            idflete = value
        End Set
    End Property
    Public Property FS_pedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property
    Public Property FS_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property
    Public Property FS_seccion
        Get
            Return seccion
        End Get
        Set(value)
            seccion = value
        End Set
    End Property
    Public Property FS_importe
        Get
            Return importe
        End Get
        Set(value)
            importe = value
        End Set
    End Property
    Public Property FS_total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property FS_iva
        Get
            Return iva
        End Get
        Set(value)
            iva = value
        End Set
    End Property


End Class
