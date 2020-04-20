Public Class ClassEmpleados
    Dim id_empleado, edad, Numero_Nomina As Integer
    Dim Nombre_Empleado, Ape_Paterno, Ape_Materno, NSS, RFC, NAcionalidad, Area, Estudios, correo, telefono,
        telefono2, direccion, perfil, alergis, estado_civil, NOmbre_Familiar, telefono_fam, direccion_fam, fotografia As String
    Dim fecha_nacimiento, fecha_ingreso As Date

    Public Property RH_fecha_ingreso
        Get
            Return fecha_ingreso
        End Get
        Set(value)
            fecha_ingreso = value
        End Set
    End Property
    Public Property RH_fecha_nacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(value)
            fecha_nacimiento = value
        End Set
    End Property
    Public Property RH_fotografia
        Get
            Return fotografia
        End Get
        Set(value)
            fotografia = value
        End Set
    End Property
    Public Property RH_direccion_fam
        Get
            Return direccion_fam
        End Get
        Set(value)
            direccion_fam = value
        End Set
    End Property
    Public Property RH_telefono_fam
        Get
            Return telefono_fam
        End Get
        Set(value)
            telefono_fam = value
        End Set
    End Property
    Public Property RH_NOmbre_Familiar
        Get
            Return NOmbre_Familiar
        End Get
        Set(value)
            NOmbre_Familiar = value
        End Set
    End Property
    Public Property RH_estado_civil
        Get
            Return estado_civil
        End Get
        Set(value)
            estado_civil = value
        End Set
    End Property
    Public Property RH_edad
        Get
            Return edad
        End Get
        Set(value)
            edad = value
        End Set
    End Property
    Public Property RH_alergis
        Get
            Return alergis
        End Get
        Set(value)
            alergis = value
        End Set
    End Property
    Public Property RH_perfil
        Get
            Return perfil
        End Get
        Set(value)
            perfil = value
        End Set
    End Property
    Public Property RH_direccion
        Get
            Return direccion
        End Get
        Set(value)
            direccion = value
        End Set
    End Property
    Public Property RH_telefono2
        Get
            Return telefono2
        End Get
        Set(value)
            telefono2 = value
        End Set
    End Property
    Public Property RH_telefono
        Get
            Return telefono
        End Get
        Set(value)
            telefono = value
        End Set
    End Property
    Public Property RH_correo
        Get
            Return correo
        End Get
        Set(value)
            correo = value
        End Set
    End Property
    Public Property RH_Estudios
        Get
            Return Estudios
        End Get
        Set(value)
            Estudios = value
        End Set
    End Property
    Public Property RH_Area
        Get
            Return Area
        End Get
        Set(value)
            Area = value
        End Set
    End Property
    Public Property RH_NAcionalidad
        Get
            Return NAcionalidad
        End Get
        Set(value)
            NAcionalidad = value
        End Set
    End Property
    Public Property RH_RFC
        Get
            Return RFC
        End Get
        Set(value)
            RFC = value
        End Set
    End Property
    Public Property RH_NSS
        Get
            Return NSS
        End Get
        Set(value)
            NSS = value
        End Set
    End Property
    Public Property RH_Ape_Materno
        Get
            Return Ape_Materno
        End Get
        Set(value)
            Ape_Materno = value
        End Set
    End Property
    Public Property RH_Ape_Paterno
        Get
            Return Ape_Paterno
        End Get
        Set(value)
            Ape_Paterno = value
        End Set
    End Property
    Public Property RH_Nombre_Empleado
        Get
            Return Nombre_Empleado
        End Get
        Set(value)
            Nombre_Empleado = value
        End Set
    End Property
    Public Property RH_Numero_Nomina
        Get
            Return Numero_Nomina
        End Get
        Set(value)
            Numero_Nomina = value
        End Set
    End Property
    Public Property RH_id_empleado
        Get
            Return id_empleado
        End Get
        Set(value)
            id_empleado = value
        End Set
    End Property
End Class
