Public Class ClassReportesEmpleados
    Dim id As Integer
    Dim empleado, quien_reporta, motivo, descripcion As String
    Dim fecha As Date
    Public Property RE_id
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property RE_empleado
        Get
            Return empleado
        End Get
        Set(value)
            empleado = value
        End Set
    End Property
    Public Property RE_quien_reporta
        Get
            Return quien_reporta
        End Get
        Set(value)
            quien_reporta = value
        End Set
    End Property
    Public Property RE_motivo
        Get
            Return motivo
        End Get
        Set(value)
            motivo = value
        End Set
    End Property
    Public Property RE_descripcion
        Get
            Return descripcion
        End Get
        Set(value)
            descripcion = value
        End Set
    End Property

    Public Property RE_fecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
End Class
