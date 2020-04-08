Public Class ClassPedimentos
    Dim fecha As Date
    Dim id As Integer
    Dim cove, codigo_pedimento, orden_compra, pedimento, clave, aduana, tipo, t_cantidad, id_provedor, unidad, id_factura As String
    Dim cantidad, precioP, total, valor_Aduana,
        tipo_cambio, peso_bruto, iva_RG_terceros1,
        total_RG_terceros1, iva_custombokerage, total_custombokerage,
        importeTGAG, ivaTGAG, TotalTGAG, importeRC, pesoRC, costoRC, tcRC, mxn1RC, mxn2RC, otrosgastos, importeCT, ivaCT, idpedimento As Double


    Public Property Peid
        Get
            Return id
        End Get
        Set(value)
            id = value
        End Set
    End Property
    Public Property Peidpedimento
        Get
            Return idpedimento
        End Get
        Set(value)
            idpedimento = value
        End Set
    End Property
    Public Property PeivaCT
        Get
            Return ivaCT
        End Get
        Set(value)
            ivaCT = value
        End Set
    End Property
    Public Property PeimporteCT
        Get
            Return importeCT
        End Get
        Set(value)
            importeCT = value
        End Set
    End Property
    Public Property Peotrosgastos
        Get
            Return otrosgastos
        End Get
        Set(value)
            otrosgastos = value
        End Set
    End Property
    Public Property Pemxn2RC
        Get
            Return mxn2RC
        End Get
        Set(value)
            mxn2RC = value
        End Set
    End Property
    Public Property Pemxn1RC
        Get
            Return mxn1RC
        End Get
        Set(value)
            mxn1RC = value
        End Set
    End Property
    Public Property PetcRC
        Get
            Return tcRC
        End Get
        Set(value)
            tcRC = value
        End Set
    End Property
    Public Property PecostoRC
        Get
            Return costoRC
        End Get
        Set(value)
            costoRC = value
        End Set
    End Property
    Public Property PepesoRC
        Get
            Return pesoRC
        End Get
        Set(value)
            pesoRC = value
        End Set
    End Property
    Public Property PeimporteRC
        Get
            Return importeRC
        End Get
        Set(value)
            importeRC = value
        End Set
    End Property
    Public Property PeTotalTGAG
        Get
            Return TotalTGAG
        End Get
        Set(value)
            TotalTGAG = value
        End Set
    End Property
    Public Property PeivaTGAG
        Get
            Return ivaTGAG
        End Get
        Set(value)
            ivaTGAG = value
        End Set
    End Property
    Public Property PeimporteTGAG
        Get
            Return importeTGAG
        End Get
        Set(value)
            importeTGAG = value
        End Set
    End Property
    Public Property Peiva_custombokerage
        Get
            Return iva_custombokerage
        End Get
        Set(value)
            iva_custombokerage = value
        End Set
    End Property
    Public Property Petotal_custombokerage
        Get
            Return total_custombokerage
        End Get
        Set(value)
            total_custombokerage = value
        End Set
    End Property
    Public Property Peiva_RG_terceros1
        Get
            Return iva_RG_terceros1
        End Get
        Set(value)
            iva_RG_terceros1 = value
        End Set
    End Property
    Public Property Petotal_RG_terceros1
        Get
            Return total_RG_terceros1
        End Get
        Set(value)
            total_RG_terceros1 = value
        End Set
    End Property
    Public Property Peid_provedor
        Get
            Return id_provedor
        End Get
        Set(value)
            id_provedor = value
        End Set
    End Property
    Public Property Peid_factura
        Get
            Return id_factura
        End Get
        Set(value)
            id_factura = value
        End Set
    End Property

    Public Property Pefecha
        Get
            Return fecha
        End Get
        Set(value)
            fecha = value
        End Set
    End Property
    Public Property Pecodigo_pedimento
        Get
            Return codigo_pedimento
        End Get
        Set(value)
            codigo_pedimento = value
        End Set
    End Property
    Public Property Peorden_comprao
        Get
            Return orden_compra
        End Get
        Set(value)
            orden_compra = value
        End Set
    End Property
    Public Property Pepedimento
        Get
            Return pedimento
        End Get
        Set(value)
            pedimento = value
        End Set
    End Property
    Public Property Peclave
        Get
            Return clave
        End Get
        Set(value)
            clave = value
        End Set
    End Property
    Public Property Peaduana
        Get
            Return aduana
        End Get
        Set(value)
            aduana = value
        End Set
    End Property
    Public Property Petipo
        Get
            Return tipo
        End Get
        Set(value)
            tipo = value
        End Set
    End Property
    Public Property Pet_cantidad
        Get
            Return t_cantidad
        End Get
        Set(value)
            t_cantidad = value
        End Set
    End Property
    Public Property Pecantidad
        Get
            Return cantidad
        End Get
        Set(value)
            cantidad = value
        End Set
    End Property
    Public Property Peunidad
        Get
            Return unidad
        End Get
        Set(value)
            unidad = value
        End Set
    End Property
    Public Property PeprecioP
        Get
            Return precioP
        End Get
        Set(value)
            precioP = value
        End Set
    End Property
    Public Property Petotal
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property
    Public Property Pevalor_Aduana
        Get
            Return valor_Aduana
        End Get
        Set(value)
            valor_Aduana = value
        End Set
    End Property
    Public Property Petipo_cambio
        Get
            Return tipo_cambio
        End Get
        Set(value)
            tipo_cambio = value
        End Set
    End Property

    Public Property Pepeso_bruto
        Get
            Return peso_bruto
        End Get
        Set(value)
            peso_bruto = value
        End Set
    End Property

    Public Property Pecove
        Get
            Return cove
        End Get
        Set(value)
            cove = value
        End Set
    End Property



End Class

