Public Class ClassProveedores
    Dim nombre, direccion, telefono As String
    Public Property pro_nombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property

    Public Property pro_direccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property

    Public Property pro_telefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property


End Class
