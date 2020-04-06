Public Class CRegistroOC
    Dim ID, L_ID As Integer
    Dim CEnt As Double
    Dim Producto, COrdenC, LUsuario, CodS As String

    Public Property GID
        Get
            Return ID
        End Get
        Set(value)
            ID = value
        End Set
    End Property

    'Public Property GL_ID
    '    Get
    '        Return L_ID
    '    End Get
    '    Set(value)
    '        L_ID = value
    '    End Set
    'End Property

    Public Property GCEnt
        Get
            Return CEnt
        End Get
        Set(value)
            CEnt = value
        End Set
    End Property

    Public Property GProducto
        Get
            Return Producto
        End Get
        Set(value)
            Producto = value
        End Set
    End Property

    'Public Property GCOrdenC
    '    Get
    '        Return COrdenC
    '    End Get
    '    Set(value)
    '        COrdenC = value
    '    End Set
    'End Property

    'Public Property GLUsuario
    '    Get
    '        Return LUsuario
    '    End Get
    '    Set(value)
    '        LUsuario = value
    '    End Set
    'End Property

    Public Property GCOrdenT
        Get
            Return CodS
        End Get
        Set(value)
            CodS = value
        End Set
    End Property
End Class
