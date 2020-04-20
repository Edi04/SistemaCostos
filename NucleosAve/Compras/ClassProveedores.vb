Public Class ClassProveedores
    Dim nombre, direccion, telefono, categoria As String


    Public Property pro_categoria
        Get
            Return categoria
        End Get
        Set(value)
            categoria = value
        End Set
    End Property
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
