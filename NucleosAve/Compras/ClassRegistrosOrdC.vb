Public Class ClassRegistrosOrdC
    'paso 1 para realizar la insercion de datos
    'comenzamos con la declaracion de variables como en la BD
    Dim id_orden As Integer
    Dim fecha2_nota As Date
    Dim codigo, purchase_order, place_delivery,
        req_compra, cif, delivery_time, boarding_instructions,
        payment_conditions, observations, buyer,
        aproved, personal_seller, id_pro, total_letter, CS, moneda, observaciones, Categoria, almacen As String
    Dim total, subtotal, iva, totalusd As Double

    'comenzamos a realizar los sedders y los geders
    Public Property G_almacen
        Get
            Return almacen
        End Get
        Set(value)
            almacen = value
        End Set
    End Property
    Public Property G_Categoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value
        End Set
    End Property
    Public Property G_observaciones
        Get
            Return observaciones
        End Get
        Set(value)
            observaciones = value
        End Set
    End Property
    Public Property G_moneda
        Get
            Return moneda
        End Get
        Set(value)
            moneda = value
        End Set
    End Property

    Public Property G_CS
        Get
            Return CS
        End Get
        Set(value)
            CS = value
        End Set
    End Property

    Public Property G_totalusd
        Get
            Return totalusd
        End Get
        Set(value)
            totalusd = value
        End Set
    End Property

    Public Property G_ivaaaa
        Get
            Return iva
        End Get
        Set(value)
            iva = value
        End Set
    End Property

    Public Property G_Total
        Get
            Return total
        End Get
        Set(value)
            total = value
        End Set
    End Property



    Public Property G_subtotall
        Get
            Return subtotal
        End Get
        Set(value)
            subtotal = value
        End Set
    End Property

    Public Property G_total_letter
        Get
            Return total_letter
        End Get
        Set(value)
            total_letter = value
        End Set
    End Property

    Public Property G_id_orden
        Get
            Return id_orden
        End Get
        Set(value)
            id_orden = value
        End Set
    End Property

    Public Property G_id_pro
        Get
            Return id_pro
        End Get
        Set(value)
            id_pro = value
        End Set
    End Property


    Public Property G_fecha2Nota
        Get
            Return fecha2_nota
        End Get
        Set(value)
            fecha2_nota = value
        End Set
    End Property

    Public Property G_codigo
        Get
            Return codigo
        End Get
        Set(value)
            codigo = value
        End Set
    End Property



    Public Property G_purchaseOrder
        Get
            Return purchase_order
        End Get
        Set(value)
            purchase_order = value
        End Set
    End Property

    Public Property G_place_delivery
        Get
            Return place_delivery
        End Get
        Set(value)
            place_delivery = value
        End Set
    End Property

    Public Property G_req_compra
        Get
            Return req_compra
        End Get
        Set(value)
            req_compra = value
        End Set
    End Property

    Public Property G_cif
        Get
            Return cif
        End Get
        Set(value)
            cif = value
        End Set
    End Property

    Public Property G_delivery_time
        Get
            Return delivery_time
        End Get
        Set(value)
            delivery_time = value
        End Set
    End Property

    Public Property G_boarding_instr
        Get
            Return boarding_instructions
        End Get
        Set(value)
            boarding_instructions = value
        End Set
    End Property

    Public Property G_payment_c
        Get
            Return payment_conditions
        End Get
        Set(value)
            payment_conditions = value
        End Set
    End Property


    Public Property G_observations
        Get
            Return observations
        End Get
        Set(value)
            observations = value
        End Set
    End Property

    Public Property G_buyer
        Get
            Return buyer
        End Get
        Set(value)
            buyer = value
        End Set
    End Property

    Public Property G_aproved
        Get
            Return aproved
        End Get
        Set(value)
            aproved = value
        End Set
    End Property

    Public Property G_personal_seller
        Get
            Return personal_seller
        End Get
        Set(value)
            personal_seller = value
        End Set
    End Property

    'aqui crearemos un constructor en blanco
    Public Sub Now()

    End Sub
    'creamos otro constructor y como creamos nuestros sedeers con ejemplo: G_personal_seller los mandamos a traer con forme
    'a los datos solicitados abajo
    Public Sub Nuevo(ByVal id_orden As Integer, ByVal id_pro As String,
                     ByVal fecha2_nota As Date,
                     ByVal codigo As String, ByVal n_registros As String,
                     ByVal purchase_order As String, ByVal place_delivery As String,
                     ByVal req_compra As String, ByVal cif As String, ByVal delivery_time As String,
                     ByVal boarding_instructions As String, ByVal payment_conditions As String, ByVal buyer As String, ByVal aproved As String,
                     ByVal personal_seller As String, ByVal total_letter As String, ByVal total As Double, ByVal subtotal As Double,
                     ByVal iva As Double)

        G_id_orden = id_orden
        G_id_pro = id_pro
        G_fecha2Nota = fecha2_nota
        G_codigo = codigo
        G_purchaseOrder = purchase_order
        G_place_delivery = place_delivery
        G_req_compra = req_compra
        G_cif = cif
        G_delivery_time = delivery_time
        G_boarding_instr = boarding_instructions
        G_payment_c = payment_conditions
        G_buyer = buyer
        G_aproved = aproved
        G_personal_seller = personal_seller
        G_total_letter = total_letter
        G_Total = total
        G_subtotall = subtotal
        G_ivaaaa = iva


    End Sub
End Class
