Imports System.Data.SqlClient '<---para poder realizar la coneccion con la bd importar esta linea
Imports System.Globalization
Imports System.Web.Mail
Public Class OrdCompra
    'coneccion de Bd y direcctivas para poder conectar y poder ejecutar consultas
    '----Directivas-->
    Dim ejecutar As SqlDataReader
    Dim comando As SqlCommand
    Dim consulta As String
    Dim tabla As DataTable
    Dim adaptador As SqlDataAdapter
    Dim conexioncita As String = My.Settings.Conexxx
    '<--directivas termino-->
    Public Sub OrdCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combo_provee() 'se pone para poder traer ala funcion princila los provedores combo1
        combo_productos1() 'se pone para poder traer ala funcion para mostrar productos
        combo_productos2()
        combo_productos3()
        combo_productos4()
        combo_productos5()
        combo_productos6()
        combo_productos7()
        combo_productos8()
        combo_productos9()
        combo_productos10()
        combo_productos11() 'se pone para poder traer ala funcion para mostrar productos
        combo_productos12()
        combo_productos13()
        combo_productos14()
        combo_productos15()
        combo_productos16()
        combo_productos17()
        combo_productos18()
        combo_productos19()
        combo_productos20()
        nuevo(False)
        conectarBD()
        'GenerarCodigo()
        'FechaActual()
        EsperatePlis.Enabled = True
        GenerarCS()
        combo_SECCION()
    End Sub

    '--------cOMBO sECCION-----------------
    Sub combo_SECCION() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Procesos order by Nombre_Proceso asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 1 --------------
        ComboBox_AREA.DataSource = tabla
        ComboBox_AREA.DisplayMember = "Nombre_Proceso"
        ComboBox_AREA.ValueMember = "Id_Proceso"
    End Sub
    '------------------------------------------

    '---------------------<<<<<<<<<<<<<<<<<<<<Combo de proveedores>>>>>>-----------------------------------
    Sub combo_provee() 'combo para mostrar los proveedores
        Try
            Dim connection As New SqlConnection("Data Source=SISTEMAS-PC\;Initial Catalog=SISUT020;User ID=N_ave;Password=ave123")
            comando = New SqlCommand("select * from tb_Proveedores ", connection)
            adaptador = New SqlDataAdapter(comando)
            tabla = New DataTable()
            adaptador.Fill(tabla)
            ComboBoxProveedores.DataSource = tabla
            ComboBoxProveedores.DisplayMember = "nombre"
            ComboBoxProveedores.ValueMember = "id_p"

        Catch ex As Exception
            MsgBox("Ocurrio un error en combo Proveedores")
        End Try
    End Sub
    '------------------------------------<<<<<<Combo de productos1>>>>>>-------------------------------------------------
    Sub combo_productos1() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 1 --------------
        ComboBoxProducto1.DataSource = tabla
        ComboBoxProducto1.DisplayMember = "Nombre_Producto"
        ComboBoxProducto1.ValueMember = "Id_Producto"

    End Sub
    Sub combo_productos2() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 2 --------------
        ComboBoxProducto2.DataSource = tabla
        ComboBoxProducto2.DisplayMember = "Nombre_Producto"
        ComboBoxProducto2.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos3() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 3 --------------
        ComboBoxProducto3.DataSource = tabla
        ComboBoxProducto3.DisplayMember = "Nombre_Producto"
        ComboBoxProducto3.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos4() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 4 --------------
        ComboBoxProducto4.DataSource = tabla
        ComboBoxProducto4.DisplayMember = "Nombre_Producto"
        ComboBoxProducto4.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos5() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo'  or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 5 --------------
        ComboBoxProducto5.DataSource = tabla
        ComboBoxProducto5.DisplayMember = "Nombre_Producto"
        ComboBoxProducto5.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos6() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 6 --------------
        ComboBoxProducto6.DataSource = tabla
        ComboBoxProducto6.DisplayMember = "Nombre_Producto"
        ComboBoxProducto6.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos7() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 7   --------------
        ComboBoxProducto7.DataSource = tabla
        ComboBoxProducto7.DisplayMember = "Nombre_Producto"
        ComboBoxProducto7.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos8() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 8 --------------
        ComboBoxProducto8.DataSource = tabla
        ComboBoxProducto8.DisplayMember = "Nombre_Producto"
        ComboBoxProducto8.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos9() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 9 --------------
        ComboBoxProducto9.DataSource = tabla
        ComboBoxProducto9.DisplayMember = "Nombre_Producto"
        ComboBoxProducto9.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos10() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo'  or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 10 --------------
        ComboBoxProducto10.DataSource = tabla
        ComboBoxProducto10.DisplayMember = "Nombre_Producto"
        ComboBoxProducto10.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos11() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 11 --------------
        ComboBoxProducto11.DataSource = tabla
        ComboBoxProducto11.DisplayMember = "Nombre_Producto"
        ComboBoxProducto11.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos12() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 12 --------------
        ComboBoxProducto12.DataSource = tabla
        ComboBoxProducto12.DisplayMember = "Nombre_Producto"
        ComboBoxProducto12.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos13() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 13 --------------
        ComboBoxProducto13.DataSource = tabla
        ComboBoxProducto13.DisplayMember = "Nombre_Producto"
        ComboBoxProducto13.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos14() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 14 --------------
        ComboBoxProducto14.DataSource = tabla
        ComboBoxProducto14.DisplayMember = "Nombre_Producto"
        ComboBoxProducto14.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos15() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 15  --------------
        ComboBoxProducto15.DataSource = tabla
        ComboBoxProducto15.DisplayMember = "Nombre_Producto"
        ComboBoxProducto15.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos16() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 16   --------------
        ComboBoxProducto16.DataSource = tabla
        ComboBoxProducto16.DisplayMember = "Nombre_Producto"
        ComboBoxProducto16.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos17() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 17  --------------
        ComboBoxProducto17.DataSource = tabla
        ComboBoxProducto17.DisplayMember = "Nombre_Producto"
        ComboBoxProducto17.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos18() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo' or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 18 --------------
        ComboBoxProducto18.DataSource = tabla
        ComboBoxProducto18.DisplayMember = "Nombre_Producto"
        ComboBoxProducto18.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos19() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo'  or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 19--------------
        ComboBoxProducto19.DataSource = tabla
        ComboBoxProducto19.DisplayMember = "Nombre_Producto"
        ComboBoxProducto19.ValueMember = "Id_Producto"
    End Sub
    Sub combo_productos20() 'combo para mostrar los productos
        Dim conexxo As New SqlConnection(conexioncita)
        conexxo.Open()
        comando = New SqlCommand("select * from TB_Productos where Estado='Activo' Or Estado = 'MPActivo' or Estado ='AMass' or Estado = 'MaqActivo'  or Estado = 'AArmado' ORDER BY Nombre_Producto asc", conexxo)
        adaptador = New SqlDataAdapter(comando)
        tabla = New DataTable()
        adaptador.Fill(tabla)
        '-------PRODUCTO 20--------------
        ComboBoxProducto20.DataSource = tabla
        ComboBoxProducto20.DisplayMember = "Nombre_Producto"
        ComboBoxProducto20.ValueMember = "Id_Producto"
    End Sub
    '-------------------------------------------------------------------
    '--<<<<<<<<<<<<<<<<<<<<<<<<<<<pasar bandera a formulario al dar click en agregar>>>>>>>>>>>>>>>>>>---------------
    Sub nuevo(ByVal bandera As Boolean)
        TextCodigo.Enabled = bandera
        DateFechaOrden.Enabled = bandera
        ComboBoxProveedores.Enabled = bandera
        TextPurchase.Enabled = bandera
        TexReqCompra.Enabled = bandera
        TextPlaceDelivery.Enabled = bandera
        TextCif.Enabled = bandera
        TextDeliverytime.Enabled = bandera
        TextBoarding.Enabled = bandera
        TextPaymentConditions.Enabled = bandera
        TextNum1.Enabled = bandera
        TextQuantity1.Enabled = bandera
        ComboBoxProducto1.Enabled = bandera
        TextTotal1.Enabled = bandera
        TextNum2.Enabled = bandera
        TextQuantity2.Enabled = bandera
        ComboBoxProducto2.Enabled = bandera
        TextTotal2.Enabled = bandera
        TextNum3.Enabled = bandera
        TextQuantity3.Enabled = bandera
        ComboBoxProducto3.Enabled = bandera
        TextTotal3.Enabled = bandera
        TextNum4.Enabled = bandera
        TextQuantity4.Enabled = bandera
        ComboBoxProducto4.Enabled = bandera
        TextTotal4.Enabled = bandera
        TextNum5.Enabled = bandera
        TextQuantity5.Enabled = bandera
        ComboBoxProducto5.Enabled = bandera
        TextTotal5.Enabled = bandera
        TextNum6.Enabled = bandera
        TextQuantity6.Enabled = bandera
        ComboBoxProducto6.Enabled = bandera
        TextTotal6.Enabled = bandera
        TextNum7.Enabled = bandera
        TextQuantity7.Enabled = bandera
        ComboBoxProducto7.Enabled = bandera
        TextTotal7.Enabled = bandera
        TextNum8.Enabled = bandera
        TextQuantity8.Enabled = bandera
        ComboBoxProducto8.Enabled = bandera
        TextTotal8.Enabled = bandera
        TextNum9.Enabled = bandera
        TextQuantity9.Enabled = bandera
        ComboBoxProducto9.Enabled = bandera
        TextTotal9.Enabled = bandera
        TextNum10.Enabled = bandera
        TextQuantity10.Enabled = bandera
        ComboBoxProducto10.Enabled = bandera
        TextTotal10.Enabled = bandera
        TextTotalLetra.Enabled = bandera
        TextSubtotal.Enabled = bandera
        TextIva.Enabled = bandera
        TextTotalFinal.Enabled = bandera
        TextBuyer.Enabled = bandera
        TextApproved.Enabled = bandera
        TextPersonalSeller.Enabled = bandera
        TextUnitPrice1.Enabled = bandera
        TextUnitPrice2.Enabled = bandera
        TextUnitPrice3.Enabled = bandera
        TextUnitPrice4.Enabled = bandera
        TextUnitPrice5.Enabled = bandera
        TextUnitPrice6.Enabled = bandera
        TextUnitPrice7.Enabled = bandera
        TextUnitPrice8.Enabled = bandera
        TextUnitPrice9.Enabled = bandera
        TextUnitPrice10.Enabled = bandera
        ComboBoxProducto11.Enabled = bandera
        TextTotal11.Enabled = bandera
        TextNum11.Enabled = bandera
        TextQuantity11.Enabled = bandera
        ComboBoxProducto12.Enabled = bandera
        TextTotal12.Enabled = bandera
        TextNum12.Enabled = bandera
        TextQuantity12.Enabled = bandera
        ComboBoxProducto13.Enabled = bandera
        TextTotal13.Enabled = bandera
        TextNum13.Enabled = bandera
        TextQuantity13.Enabled = bandera
        ComboBoxProducto14.Enabled = bandera
        TextTotal14.Enabled = bandera
        TextNum14.Enabled = bandera
        TextQuantity14.Enabled = bandera
        ComboBoxProducto15.Enabled = bandera
        TextTotal15.Enabled = bandera
        TextNum15.Enabled = bandera
        TextQuantity15.Enabled = bandera
        ComboBoxProducto16.Enabled = bandera
        TextTotal16.Enabled = bandera
        TextNum16.Enabled = bandera
        TextQuantity16.Enabled = bandera
        ComboBoxProducto17.Enabled = bandera
        TextTotal17.Enabled = bandera
        TextNum17.Enabled = bandera
        TextQuantity17.Enabled = bandera
        ComboBoxProducto18.Enabled = bandera
        TextTotal18.Enabled = bandera
        TextNum18.Enabled = bandera
        TextQuantity18.Enabled = bandera
        ComboBoxProducto19.Enabled = bandera
        TextTotal19.Enabled = bandera
        TextNum19.Enabled = bandera
        TextQuantity19.Enabled = bandera
        ComboBoxProducto20.Enabled = bandera
        TextTotal20.Enabled = bandera
        TextNum20.Enabled = bandera
        TextQuantity20.Enabled = bandera
    End Sub
    '-----------------------------------------------------------------------------------------------------------------
    '-------..--------------------<<<Boton Pasa La BAndera Al Formulario>>>>>>>>>>>>>>>-------------------------------
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click 'al dar click a este boton pasamos la bandera al primero campo y habilitamos todas las cajas de texto
        Call nuevo(True)
        TextCodigo.Select()

        TextCodigo.Clear()
        TextPurchase.Clear()
        TexReqCompra.Clear()
        TextPaymentConditions.Clear()
        TextCif.Clear()
        TextDeliverytime.Clear()
        TextBoarding.Clear()
        TextPersonalSeller.Clear()
        TextSubtotal.Clear()
        TextTotalFinal.Clear()

        TextTotalLetra.Clear()

        TextQuantity1.Clear()
        TextUnitPrice1.Clear()
        TextTotal1.Clear()
        TId1.Clear()

        TextQuantity2.Clear()
        TextUnitPrice2.Clear()
        TextTotal2.Clear()
        TId2.Clear()

        TextQuantity3.Clear()
        TextUnitPrice3.Clear()
        TextTotal3.Clear()
        TId3.Clear()

        TextQuantity4.Clear()
        TextUnitPrice4.Clear()
        TextTotal4.Clear()
        TId4.Clear()

        TextQuantity5.Clear()
        TextUnitPrice5.Clear()
        TextTotal5.Clear()
        TId5.Clear()

        TextQuantity6.Clear()
        TextUnitPrice6.Clear()
        TextTotal6.Clear()
        TId6.Clear()

        TextQuantity7.Clear()
        TextUnitPrice7.Clear()
        TextTotal7.Clear()
        TId7.Clear()

        TextQuantity8.Clear()
        TextUnitPrice8.Clear()
        TextTotal8.Clear()
        TId8.Clear()

        TextQuantity9.Clear()
        TextUnitPrice9.Clear()
        TextTotal9.Clear()
        TId9.Clear()

        TextQuantity10.Clear()
        TextUnitPrice10.Clear()
        TextTotal10.Clear()
        TId10.Clear()

        TextQuantity11.Clear()
        TextUnitPrice11.Clear()
        TextTotal11.Clear()
        TId11.Clear()

        TextQuantity12.Clear()
        TextUnitPrice12.Clear()
        TextTotal12.Clear()
        TId12.Clear()

        TextQuantity13.Clear()
        TextUnitPrice13.Clear()
        TextTotal13.Clear()
        TId13.Clear()

        TextQuantity14.Clear()
        TextUnitPrice14.Clear()
        TextTotal14.Clear()
        TId14.Clear()

        TextQuantity15.Clear()
        TextUnitPrice15.Clear()
        TextTotal15.Clear()
        TId15.Clear()

        TextQuantity16.Clear()
        TextUnitPrice16.Clear()
        TextTotal16.Clear()
        TId16.Clear()

        TextQuantity17.Clear()
        TextUnitPrice17.Clear()
        TextTotal17.Clear()
        TId17.Clear()

        TextQuantity18.Clear()
        TextUnitPrice18.Clear()
        TextTotal18.Clear()
        TId18.Clear()

        TextQuantity19.Clear()
        TextUnitPrice19.Clear()
        TextTotal19.Clear()
        TId19.Clear()

        TextQuantity20.Clear()
        TextUnitPrice20.Clear()
        TextTotal20.Clear()
        TId20.Clear()

        TextBox_detalles1.Clear()
        TextBox_detalles2.Clear()
        TextBox_detalles3.Clear()
        TextBox_detalles5.Clear()
        TextBox_detalles4.Clear()
        TextBox_detalles6.Clear()
        TextBox_detalles7.Clear()
        TextBox_detalles8.Clear()
        TextBox_detalles9.Clear()
        TextBox_detalles10.Clear()
        TextBox_detalles11.Clear()
        TextBox_detalles12.Clear()
        TextBox_detalles13.Clear()
        TextBox_detalles14.Clear()
        TextBox_detalles15.Clear()
        TextBox_detalles16.Clear()
        TextBox_detalles17.Clear()
        TextBox_detalles18.Clear()
        TextBox_detalles19.Clear()
        TextBox_detalles20.Clear()
        'GenerarCodigo()
        GenerarCS()
        btnEliminar.Visible = False
        Label6.Visible = False
        btnModificar.Visible = False
        Label5.Visible = False

        PictureBox5.Visible = True
        Label8.Visible = True
        btn_enviarmail.Visible = False
    End Sub

    '----------------------------------------------------------------------------------------------------------------------------
    '--------------------------------Boton Para Agregar  Nuevo Registro--------------------------------
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If MessageBox.Show("Estas seguro que todos tus campos ingresados son correctos " + TextCodigo.Text, "Nueva Orden De Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            '---------------comiienza codigo
            '-----------------agregar ala base orden de compra primero 
            '1-classRegistrosOrdC
            '2--Funcion_registros nos vamos a clase FN_InsertarPersonas/creamos el procedimietnorp almacenado
            '3--traemos todo aqui
            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosOrdC

                logica.G_codigo = Me.TextCodigo.Text
                logica.G_fecha2Nota = Me.DateFechaOrden.Value 'de esta manera recibimos ala fecha y si queremos solo ala fecha agregamos .DAte
                logica.G_id_pro = Me.ComboBoxProveedores.SelectedValue 'obtemos el id del valor el cual se esta mostrando en el combo
                logica.G_purchaseOrder = Me.TextPurchase.Text
                logica.G_req_compra = Me.TexReqCompra.Text
                logica.G_place_delivery = Me.TextPlaceDelivery.Text
                logica.G_cif = Me.TextCif.Text
                logica.G_delivery_time = Me.TextDeliverytime.Text
                logica.G_boarding_instr = Me.TextBoarding.Text
                logica.G_payment_c = Me.TextPaymentConditions.Text
                logica.G_buyer = Me.TextBuyer.Text
                logica.G_aproved = Me.TextApproved.Text
                logica.G_personal_seller = Me.TextPersonalSeller.Text
                logica.G_subtotall = Me.TextSubtotal.Text
                logica.G_ivaaaa = Me.TextIva.Text
                logica.G_Total = Me.TextTotalFinal.Text
                logica.G_total_letter = Me.TextTotalLetra.Text
                logica.G_CS = Me.Text_Cs.Text
                logica.G_observaciones = Me.TextBox_observaciones.Text
                logica.G_Categoria = Me.ComboBox_AREA.Text

                If check_Mxn.Checked = True Then
                    logica.G_moneda = "Mxn".ToString
                Else
                    If check_Usd.Checked = True Then
                        logica.G_moneda = "Usd".ToString
                    Else

                        If check_Euro.Checked = True Then
                            logica.G_moneda = "Euro".ToString
                        Else
                        End If
                    End If
                End If

                If funciones.FN_InsertarPersonas(logica) Then
                    MsgBox("Orden Insertada Correctamente", MessageBoxIcon.Information)
                    combo_SECCION()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '----------------------------limpiar Cajas ---------------------------------
            TextPurchase.Clear()
            TexReqCompra.Clear()

            TextCif.Clear()
            TextDeliverytime.Clear()
            TextBoarding.Clear()
            TextPaymentConditions.Clear()
            TextPersonalSeller.Clear()
            TextSubtotal.Clear()
            TextTotalFinal.Clear()
            TextTotalLetra.Clear()
            TextBox_observaciones.Clear()
            '---------------------------------------------------------------------------
            '-----------------Agregar ala base productos de orden compra primero 
            '1-classRegistrosProdOrdCompra
            '2--Funcion_registros nos vamos a clase Fn_insertar_productosOrdC/creamos el procedimietnorp almacenado
            '3--traemos todo aqui
            '---------------------------------------registro de tabla 1------------------------------------------------
            If (TextNum1.Text = "" Or TextQuantity1.Text = "" Or TextTotal1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    'logica1.Gdescripcion = Me.TextDescription1.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto1.Text
                    logica1.GCantidad = Me.TextQuantity1.Text
                    If TextUnitPrice1.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice1.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal1.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm1.Text
                    logica1.Gdetalles = Me.TextBox_detalles1.Text

                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        MsgBox("Productos Insertados Correctamente", MessageBoxIcon.Information)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity1.Clear()
            TextUnitPrice1.Clear()
            TextTotal1.Clear()
            TextUm1.Clear()
            TextBox_detalles1.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 2------------------------------------------------
            If (TextNum2.Text = "" Or TextQuantity2.Text = "" Or TextTotal2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto2.Text
                    logica1.GCantidad = Me.TextQuantity2.Text
                    If TextUnitPrice2.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice2.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal2.Text
                        logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm2.Text
                    logica1.Gdetalles = Me.TextBox_detalles2.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity2.Clear()
            TextUnitPrice2.Clear()
            TextTotal2.Clear()
            TextUm2.Clear()
            TextBox_detalles2.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 3------------------------------------------------
            If (TextNum3.Text = "" Or TextQuantity3.Text = "" Or TextTotal3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto3.Text
                    logica1.GCantidad = Me.TextQuantity3.Text
                    If TextUnitPrice3.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice3.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal3.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm3.Text
                    logica1.Gdetalles = Me.TextBox_detalles3.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        ' MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity3.Clear()
            TextUnitPrice3.Clear()
            TextTotal3.Clear()
            TextUm3.Clear()
            TextBox_detalles3.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 4------------------------------------------------
            If (TextNum4.Text = "" Or TextQuantity4.Text = "" Or TextTotal4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto4.Text
                    logica1.GCantidad = Me.TextQuantity4.Text
                    If TextUnitPrice4.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice4.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal4.Text
                        logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm4.Text
                    logica1.Gdetalles = Me.TextBox_detalles4.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity4.Clear()
            TextUnitPrice4.Clear()
            TextTotal4.Clear()
            TextUm4.Clear()
            TextBox_detalles4.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 5------------------------------------------------
            If (TextNum5.Text = "" Or TextQuantity5.Text = "" Or TextTotal5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto5.Text
                    logica1.GCantidad = Me.TextQuantity5.Text
                    If TextUnitPrice5.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice5.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal5.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm5.Text
                    logica1.Gdetalles = Me.TextBox_detalles5.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity5.Clear()
            TextUnitPrice5.Clear()
            TextTotal5.Clear()
            TextUm5.Clear()
            TextBox_detalles5.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 6------------------------------------------------
            If (TextNum6.Text = "" Or TextQuantity6.Text = "" Or TextTotal6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto6.Text
                    logica1.GCantidad = Me.TextQuantity6.Text
                    If TextUnitPrice6.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice6.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal6.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm6.Text
                    logica1.Gdetalles = Me.TextBox_detalles6.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity6.Clear()
            TextUnitPrice6.Clear()
            TextTotal6.Clear()
            TextUm6.Clear()
            TextBox_detalles6.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 7------------------------------------------------
            If (TextNum7.Text = "" Or TextQuantity7.Text = "" Or TextTotal7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto7.Text
                    logica1.GCantidad = Me.TextQuantity7.Text
                    If TextUnitPrice7.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice7.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal7.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm7.Text
                    logica1.Gdetalles = Me.TextBox_detalles7.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity7.Clear()
            TextUnitPrice7.Clear()
            TextTotal7.Clear()
            TextUm7.Clear()
            TextBox_detalles7.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 8------------------------------------------------
            If (TextNum8.Text = "" Or TextQuantity8.Text = "" Or TextTotal8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto8.Text
                    logica1.GCantidad = Me.TextQuantity8.Text
                    If TextUnitPrice8.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice8.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal8.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm8.Text
                    logica1.Gdetalles = Me.TextBox_detalles8.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity8.Clear()
            TextUnitPrice8.Clear()
            TextTotal8.Clear()
            TextUm8.Clear()
            TextBox_detalles8.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------


            '---------------------------------------registro de tabla ¿9------------------------------------------------
            If (TextNum9.Text = "" Or TextQuantity9.Text = "" Or TextTotal9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto9.Text
                    logica1.GCantidad = Me.TextQuantity9.Text
                    If TextUnitPrice9.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice9.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal9.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm9.Text
                    logica1.Gdetalles = Me.TextBox_detalles9.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '--------LIMPIAR CAJAS-------
            TextQuantity9.Clear()
            TextUnitPrice9.Clear()
            TextTotal9.Clear()
            TextUm9.Clear()
            TextBox_detalles9.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (TextNum10.Text = "" Or TextQuantity10.Text = "" Or TextTotal10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto10.Text
                    logica1.GCantidad = Me.TextQuantity10.Text
                    If TextUnitPrice10.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice10.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal10.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm10.Text
                    logica1.Gdetalles = Me.TextBox_detalles10.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity10.Clear()
            TextUnitPrice10.Clear()
            TextTotal10.Clear()
            TextUm10.Clear()
            TextBox_detalles10.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------


            '---------------------------------------registro de tabla 11------------------------------------------------
            If (TextNum11.Text = "" Or TextQuantity11.Text = "" Or TextTotal11.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto11.Text
                    logica1.GCantidad = Me.TextQuantity11.Text
                    If TextUnitPrice11.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice11.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal11.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm11.Text
                    logica1.Gdetalles = Me.TextBox_detalles11.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity11.Clear()
            TextUnitPrice11.Clear()
            TextTotal11.Clear()
            TextUm11.Clear()
            TextBox_detalles11.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 12    ------------------------------------------------
            If (TextNum12.Text = "" Or TextQuantity12.Text = "" Or TextTotal12.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto12.Text
                    logica1.GCantidad = Me.TextQuantity12.Text
                    If TextUnitPrice12.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice12.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal12.Text
                        logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm12.Text
                    logica1.Gdetalles = Me.TextBox_detalles12.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity12.Clear()
            TextUnitPrice12.Clear()
            TextTotal12.Clear()
            TextUm12.Clear()
            TextBox_detalles12.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 13------------------------------------------------
            If (TextNum13.Text = "" Or TextQuantity13.Text = "" Or TextTotal13.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto13.Text
                    logica1.GCantidad = Me.TextQuantity13.Text
                    If TextUnitPrice13.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice13.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal13.Text
                        logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm13.Text
                    logica1.Gdetalles = Me.TextBox_detalles13.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity13.Clear()
            TextUnitPrice13.Clear()
            TextTotal13.Clear()
            TextUm13.Clear()
            TextBox_detalles13.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 14    ------------------------------------------------
            If (TextNum10.Text = "" Or TextQuantity10.Text = "" Or TextTotal10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto14.Text
                    logica1.GCantidad = Me.TextQuantity14.Text
                    If TextUnitPrice10.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice14.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal14.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm14.Text
                    logica1.Gdetalles = Me.TextBox_detalles14.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity14.Clear()
            TextUnitPrice14.Clear()
            TextTotal14.Clear()
            TextUm14.Clear()
            TextBox_detalles14.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 15------------------------------------------------
            If (TextNum15.Text = "" Or TextQuantity15.Text = "" Or TextTotal15.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto15.Text
                    logica1.GCantidad = Me.TextQuantity15.Text
                    If TextUnitPrice15.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice15.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal15.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm15.Text
                    logica1.Gdetalles = Me.TextBox_detalles15.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity15.Clear()
            TextUnitPrice15.Clear()
            TextTotal15.Clear()
            TextUm15.Clear()
            TextBox_detalles15.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 16    ------------------------------------------------
            If (TextNum16.Text = "" Or TextQuantity16.Text = "" Or TextTotal16.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto16.Text
                    logica1.GCantidad = Me.TextQuantity16.Text
                    If TextUnitPrice16.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice16.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal16.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm16.Text
                    logica1.Gdetalles = Me.TextBox_detalles16.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity16.Clear()
            TextUnitPrice16.Clear()
            TextTotal16.Clear()
            TextUm16.Clear()
            TextBox_detalles16.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 17    ------------------------------------------------
            If (TextNum17.Text = "" Or TextQuantity17.Text = "" Or TextTotal17.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto17.Text
                    logica1.GCantidad = Me.TextQuantity17.Text
                    If TextUnitPrice17.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice17.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal17.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm17.Text
                    logica1.Gdetalles = Me.TextBox_detalles17.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity17.Clear()
            TextUnitPrice17.Clear()
            TextTotal17.Clear()
            TextUm17.Clear()
            TextBox_detalles17.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (TextNum18.Text = "" Or TextQuantity18.Text = "" Or TextTotal18.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto18.Text
                    logica1.GCantidad = Me.TextQuantity18.Text
                    If TextUnitPrice18.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice18.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal18.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm18.Text
                    logica1.Gdetalles = Me.TextBox_detalles18.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity18.Clear()
            TextUnitPrice18.Clear()
            TextTotal18.Clear()
            TextUm18.Clear()
            TextBox_detalles18.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (TextNum19.Text = "" Or TextQuantity19.Text = "" Or TextTotal19.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto19.Text
                    logica1.GCantidad = Me.TextQuantity19.Text
                    If TextUnitPrice19.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice19.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal19.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm19.Text
                    logica1.Gdetalles = Me.TextBox_detalles19.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity19.Clear()
            TextUnitPrice19.Clear()
            TextTotal19.Clear()
            TextUm19.Clear()
            TextBox_detalles19.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

            '---------------------------------------registro de tabla 20------------------------------------------------
            If (TextNum20.Text = "" Or TextQuantity20.Text = "" Or TextTotal20.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto20.Text
                    logica1.GCantidad = Me.TextQuantity20.Text
                    If TextUnitPrice20.Text = "" Then
                        logica1.Gprecio = "0"
                    Else
                        logica1.Gprecio = Me.TextUnitPrice20.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    End If
                    logica1.Gsubtotal = Me.TextTotal20.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GUm = Me.TextUm20.Text
                    logica1.Gdetalles = Me.TextBox_detalles20.Text


                    If funciones.Fn_insertar_productosOrdC(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
            '-------------------------------------------------------------------------------------

            '--------LIMPIAR CAJAS-------
            TextQuantity20.Clear()
            TextUnitPrice20.Clear()
            TextTotal20.Clear()
            TextUm20.Clear()
            TextBox_detalles20.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------

        End If

        '--------------------------recargar codigo Orden------------------------------
        'GenerarCodigo()
        GenerarCS()
        '------------------------------------------------------------------------------
    End Sub
    '.....................................................................................................

    Public Sub Total_1() Handles TextQuantity1.TextChanged, TextUnitPrice1.TextChanged

        Dim cu1 As Double = 0
        Dim cu2 As Double = 0
        Dim resultado As Double = 0

        If TextQuantity1.Text <> Nothing Then
            cu1 = (TextQuantity1.Text)

        End If

        If TextUnitPrice1.Text <> Nothing Then
            cu2 = (TextUnitPrice1.Text)
        End If
        TextTotal1.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_2() Handles TextQuantity2.TextChanged, TextUnitPrice2.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity2.Text <> Nothing Then
            cu1 = CDec(TextQuantity2.Text)
        End If

        If TextUnitPrice2.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice2.Text)
        End If
        TextTotal2.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_3() Handles TextQuantity3.TextChanged, TextUnitPrice3.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity3.Text <> Nothing Then
            cu1 = CDec(TextQuantity3.Text)
        End If

        If TextUnitPrice3.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice3.Text)
        End If
        TextTotal3.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_4() Handles TextQuantity4.TextChanged, TextUnitPrice4.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity4.Text <> Nothing Then
            cu1 = CDec(TextQuantity4.Text)
        End If

        If TextUnitPrice4.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice4.Text)
        End If
        TextTotal4.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_5() Handles TextQuantity5.TextChanged, TextUnitPrice5.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity5.Text <> Nothing Then
            cu1 = CDec(TextQuantity5.Text)
        End If

        If TextUnitPrice5.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice5.Text)
        End If
        TextTotal5.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_6() Handles TextQuantity6.TextChanged, TextUnitPrice6.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity6.Text <> Nothing Then
            cu1 = CDec(TextQuantity6.Text)
        End If

        If TextUnitPrice6.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice6.Text)
        End If
        TextTotal6.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_7() Handles TextQuantity7.TextChanged, TextUnitPrice7.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity7.Text <> Nothing Then
            cu1 = CDec(TextQuantity7.Text)
        End If

        If TextUnitPrice7.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice7.Text)
        End If
        TextTotal7.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_8() Handles TextQuantity8.TextChanged, TextUnitPrice8.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity8.Text <> Nothing Then
            cu1 = CDec(TextQuantity8.Text)
        End If

        If TextUnitPrice8.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice8.Text)
        End If
        TextTotal8.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_9() Handles TextQuantity9.TextChanged, TextUnitPrice9.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity9.Text <> Nothing Then
            cu1 = CDec(TextQuantity9.Text)
        End If

        If TextUnitPrice9.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice9.Text)
        End If
        TextTotal9.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_10() Handles TextQuantity10.TextChanged, TextUnitPrice10.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity10.Text <> Nothing Then
            cu1 = CDec(TextQuantity10.Text)
        End If

        If TextUnitPrice10.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice10.Text)
        End If
        TextTotal10.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub


    '---------------------TOTALES DE LAS OTRAS 110-----------------------
    Public Sub Total_11() Handles TextQuantity11.TextChanged, TextUnitPrice11.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0


        If TextQuantity11.Text <> Nothing Then
            cu1 = CDec(TextQuantity11.Text)
        End If

        If TextUnitPrice11.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice11.Text)
        End If
        TextTotal11.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_12() Handles TextQuantity12.TextChanged, TextUnitPrice12.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity12.Text <> Nothing Then
            cu1 = CDec(TextQuantity12.Text)
        End If

        If TextUnitPrice12.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice12.Text)
        End If
        TextTotal12.Text = FormatCurrency((cu1 * cu2).ToString, 2)

    End Sub

    Public Sub Total_13() Handles TextQuantity13.TextChanged, TextUnitPrice13.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity13.Text <> Nothing Then
            cu1 = CDec(TextQuantity13.Text)
        End If

        If TextUnitPrice13.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice13.Text)
        End If
        TextTotal13.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub

    Public Sub Total_14() Handles TextQuantity14.TextChanged, TextUnitPrice14.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity14.Text <> Nothing Then
            cu1 = CDec(TextQuantity14.Text)
        End If

        If TextUnitPrice14.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice14.Text)
        End If
        TextTotal14.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub
    Public Sub Total_15() Handles TextQuantity15.TextChanged, TextUnitPrice15.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity15.Text <> Nothing Then
            cu1 = CDec(TextQuantity15.Text)
        End If

        If TextUnitPrice15.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice15.Text)
        End If
        TextTotal15.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub

    Public Sub Total_16() Handles TextQuantity16.TextChanged, TextUnitPrice16.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity16.Text <> Nothing Then
            cu1 = CDec(TextQuantity16.Text)
        End If

        If TextUnitPrice16.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice16.Text)
        End If
        TextTotal16.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub

    Public Sub Total_17() Handles TextQuantity17.TextChanged, TextUnitPrice17.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity17.Text <> Nothing Then
            cu1 = CDec(TextQuantity17.Text)
        End If

        If TextUnitPrice17.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice17.Text)
        End If
        TextTotal17.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub
    Public Sub Total_18() Handles TextQuantity18.TextChanged, TextUnitPrice18.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity18.Text <> Nothing Then
            cu1 = CDec(TextQuantity18.Text)
        End If

        If TextUnitPrice18.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice18.Text)
        End If
        TextTotal18.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub
    Public Sub Total_19() Handles TextQuantity19.TextChanged, TextUnitPrice19.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity19.Text <> Nothing Then
            cu1 = CDec(TextQuantity19.Text)
        End If

        If TextUnitPrice19.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice19.Text)
        End If
        TextTotal19.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub
    Public Sub Total_20() Handles TextQuantity20.TextChanged, TextUnitPrice20.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0

        If TextQuantity20.Text <> Nothing Then
            cu1 = CDec(TextQuantity20.Text)
        End If

        If TextUnitPrice20.Text <> Nothing Then
            cu2 = CDec(TextUnitPrice20.Text)
        End If
        TextTotal20.Text = FormatCurrency((cu1 * cu2).ToString, 2)
    End Sub
    '---------------------------------------------------------------
    Public Sub SumaSubtotal() Handles TextTotal1.TextChanged, TextTotal2.TextChanged, TextTotal3.TextChanged, TextTotal4.TextChanged, TextTotal5.TextChanged,
            TextTotal6.TextChanged, TextTotal7.TextChanged, TextTotal8.TextChanged, TextTotal9.TextChanged, TextTotal10.TextChanged, TextTotal11.TextChanged,
            TextTotal12.TextChanged, TextTotal13.TextChanged, TextTotal14.TextChanged, TextTotal15.TextChanged, TextTotal16.TextChanged, TextTotal17.TextChanged,
            TextTotal18.TextChanged, TextTotal19.TextChanged, TextTotal20.TextChanged
        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim cu5 As Decimal = 0
        Dim cu6 As Decimal = 0
        Dim cu7 As Decimal = 0
        Dim cu8 As Decimal = 0
        Dim cu9 As Decimal = 0
        Dim cu10 As Decimal = 0

        Dim cu11 As Decimal = 0
        Dim cu12 As Decimal = 0
        Dim cu13 As Decimal = 0
        Dim cu14 As Decimal = 0
        Dim cu15 As Decimal = 0
        Dim cu16 As Decimal = 0
        Dim cu17 As Decimal = 0
        Dim cu18 As Decimal = 0
        Dim cu19 As Decimal = 0
        Dim cu20 As Decimal = 0

        If TextTotal1.Text <> Nothing Then
            cu1 = CDec(TextTotal1.Text)
        End If

        If TextTotal2.Text <> Nothing Then
            cu2 = CDec(TextTotal2.Text)
        End If

        If TextTotal3.Text <> Nothing Then
            cu3 = CDec(TextTotal3.Text)
        End If

        If TextTotal4.Text <> Nothing Then
            cu4 = CDec(TextTotal4.Text)
        End If

        If TextTotal5.Text <> Nothing Then
            cu5 = CDec(TextTotal5.Text)
        End If

        If TextTotal6.Text <> Nothing Then
            cu6 = CDec(TextTotal6.Text)
        End If

        If TextTotal7.Text <> Nothing Then
            cu7 = CDec(TextTotal7.Text)
        End If

        If TextTotal8.Text <> Nothing Then
            cu8 = CDec(TextTotal8.Text)
        End If

        If TextTotal9.Text <> Nothing Then
            cu9 = CDec(TextTotal9.Text)
        End If

        If TextTotal10.Text <> Nothing Then
            cu10 = CDec(TextTotal10.Text)
        End If

        If TextTotal11.Text <> Nothing Then
            cu11 = CDec(TextTotal11.Text)
        End If

        If TextTotal12.Text <> Nothing Then
            cu12 = CDec(TextTotal12.Text)
        End If

        If TextTotal13.Text <> Nothing Then
            cu13 = CDec(TextTotal13.Text)
        End If

        If TextTotal14.Text <> Nothing Then
            cu14 = CDec(TextTotal14.Text)
        End If

        If TextTotal15.Text <> Nothing Then
            cu15 = CDec(TextTotal15.Text)
        End If

        If TextTotal16.Text <> Nothing Then
            cu16 = CDec(TextTotal16.Text)
        End If

        If TextTotal17.Text <> Nothing Then
            cu17 = CDec(TextTotal17.Text)
        End If

        If TextTotal18.Text <> Nothing Then
            cu18 = CDec(TextTotal18.Text)
        End If

        If TextTotal19.Text <> Nothing Then
            cu19 = CDec(TextTotal19.Text)
        End If

        If TextTotal20.Text <> Nothing Then
            cu20 = CDec(TextTotal20.Text)
        End If

        TextSubtotal.Text = FormatCurrency((cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20).ToString, 2)

    End Sub

    Public Sub SumaTotal_Iva() Handles TextTotal1.TextChanged, TextTotal2.TextChanged, TextTotal3.TextChanged, TextTotal4.TextChanged, TextTotal5.TextChanged,
            TextTotal6.TextChanged, TextTotal7.TextChanged, TextTotal8.TextChanged, TextTotal9.TextChanged, TextTotal10.TextChanged, TextIva.TextChanged, TextIva.TextChanged, TextSubtotal.TextChanged, TextTotal11.TextChanged,
            TextTotal12.TextChanged, TextTotal13.TextChanged, TextTotal14.TextChanged, TextTotal15.TextChanged, TextTotal16.TextChanged, TextTotal17.TextChanged,
            TextTotal18.TextChanged, TextTotal19.TextChanged, TextTotal20.TextChanged

        Dim cu1 As Decimal = 0
        Dim cu2 As Decimal = 0
        Dim cu3 As Decimal = 0
        Dim cu4 As Decimal = 0
        Dim cu5 As Decimal = 0
        Dim cu6 As Decimal = 0
        Dim cu7 As Decimal = 0
        Dim cu8 As Decimal = 0
        Dim cu9 As Decimal = 0
        Dim cu10 As Decimal = 0

        Dim cu11 As Decimal = 0
        Dim cu12 As Decimal = 0
        Dim cu13 As Decimal = 0
        Dim cu14 As Decimal = 0
        Dim cu15 As Decimal = 0
        Dim cu16 As Decimal = 0
        Dim cu17 As Decimal = 0
        Dim cu18 As Decimal = 0
        Dim cu19 As Decimal = 0
        Dim cu20 As Decimal = 0

        Dim iva As Decimal = 0
        Dim suma As Decimal = 0
        Dim subtotal As Decimal = 0




        If TextTotal1.Text <> Nothing Then
            cu1 = CDec(TextTotal1.Text)
        End If

        If TextTotal2.Text <> Nothing Then
            cu2 = CDec(TextTotal2.Text)
        End If

        If TextTotal3.Text <> Nothing Then
            cu3 = CDec(TextTotal3.Text)
        End If

        If TextTotal4.Text <> Nothing Then
            cu4 = CDec(TextTotal4.Text)
        End If

        If TextTotal5.Text <> Nothing Then
            cu5 = CDec(TextTotal5.Text)
        End If

        If TextTotal6.Text <> Nothing Then
            cu6 = CDec(TextTotal6.Text)
        End If

        If TextTotal7.Text <> Nothing Then
            cu7 = CDec(TextTotal7.Text)
        End If

        If TextTotal8.Text <> Nothing Then
            cu8 = CDec(TextTotal8.Text)
        End If

        If TextTotal9.Text <> Nothing Then
            cu9 = CDec(TextTotal9.Text)
        End If

        If TextTotal10.Text <> Nothing Then
            cu10 = CDec(TextTotal10.Text)
        End If

        If TextTotal11.Text <> Nothing Then
            cu11 = CDec(TextTotal11.Text)
        End If

        If TextTotal12.Text <> Nothing Then
            cu12 = CDec(TextTotal12.Text)
        End If

        If TextTotal13.Text <> Nothing Then
            cu13 = CDec(TextTotal13.Text)
        End If

        If TextTotal14.Text <> Nothing Then
            cu14 = CDec(TextTotal14.Text)
        End If

        If TextTotal15.Text <> Nothing Then
            cu15 = CDec(TextTotal15.Text)
        End If

        If TextTotal16.Text <> Nothing Then
            cu16 = CDec(TextTotal16.Text)
        End If

        If TextTotal17.Text <> Nothing Then
            cu17 = CDec(TextTotal17.Text)
        End If

        If TextTotal18.Text <> Nothing Then
            cu18 = CDec(TextTotal18.Text)
        End If

        If TextTotal19.Text <> Nothing Then
            cu19 = CDec(TextTotal19.Text)
        End If

        If TextTotal20.Text <> Nothing Then
            cu20 = CDec(TextTotal20.Text)
        End If

        If TextIva.Text <> Nothing Then
            iva = CDec(TextIva.Text)
        End If

        If TextSubtotal.Text <> Nothing Then
            subtotal = CDec(TextSubtotal.Text)
        End If
        suma = (cu1 + cu2 + cu3 + cu4 + cu5 + cu6 + cu7 + cu8 + cu9 + cu10 + cu11 + cu12 + cu13 + cu14 + cu15 + cu16 + cu17 + cu18 + cu19 + cu20) * iva.ToString


        TextTotalFinal.Text = FormatCurrency((subtotal + suma), 2)

    End Sub



    '---------------ocultamos las cajas de texto y aparecemos------------

    Private Sub ImgAgregarTxt_Click(sender As Object, e As EventArgs) Handles ImgAgregarTxt.Click
        'TextNum2.Visible = True
        'TextDescription2.Visible = True
        'TextQuantity2.Visible = True
        'TextUnitPrice2.Visible = True
        'TextTotal2.Visible = True

        If TextNum2.Visible = False Then
            TextNum2.Visible = True
            ComboBoxProducto2.Visible = True
            TextQuantity2.Visible = True
            TextUnitPrice2.Visible = True
            TextTotal2.Visible = True
            TextUm2.Visible = True
            TextBox_detalles2.Visible = True

        Else
            If TextNum3.Visible = False Then
                TextNum3.Visible = True
                ComboBoxProducto3.Visible = True
                TextQuantity3.Visible = True
                TextUnitPrice3.Visible = True
                TextTotal3.Visible = True
                TextUm3.Visible = True
                TextBox_detalles3.Visible = True
            Else
                If TextNum4.Visible = False Then
                    TextNum4.Visible = True
                    ComboBoxProducto4.Visible = True
                    TextQuantity4.Visible = True
                    TextUnitPrice4.Visible = True
                    TextTotal4.Visible = True
                    TextUm4.Visible = True
                    TextBox_detalles4.Visible = True
                Else
                    If TextNum5.Visible = False Then
                        TextNum5.Visible = True
                        ComboBoxProducto5.Visible = True
                        TextQuantity5.Visible = True
                        TextUnitPrice5.Visible = True
                        TextTotal5.Visible = True
                        TextUm5.Visible = True
                        TextBox_detalles5.Visible = True
                    Else
                        If TextNum6.Visible = False Then
                            TextNum6.Visible = True
                            ComboBoxProducto6.Visible = True
                            TextQuantity6.Visible = True
                            TextUnitPrice6.Visible = True
                            TextTotal6.Visible = True
                            TextUm6.Visible = True
                            TextBox_detalles6.Visible = True
                        Else
                            If TextNum7.Visible = False Then
                                TextNum7.Visible = True
                                ComboBoxProducto7.Visible = True
                                TextQuantity7.Visible = True
                                TextUnitPrice7.Visible = True
                                TextTotal7.Visible = True
                                TextUm7.Visible = True
                                TextBox_detalles7.Visible = True
                            Else
                                If TextNum8.Visible = False Then
                                    TextNum8.Visible = True
                                    ComboBoxProducto8.Visible = True
                                    TextQuantity8.Visible = True
                                    TextUnitPrice8.Visible = True
                                    TextTotal8.Visible = True
                                    TextUm8.Visible = True
                                    TextBox_detalles8.Visible = True
                                Else
                                    If TextNum9.Visible = False Then
                                        TextNum9.Visible = True
                                        ComboBoxProducto9.Visible = True
                                        TextQuantity9.Visible = True
                                        TextUnitPrice9.Visible = True
                                        TextTotal9.Visible = True
                                        TextUm9.Visible = True
                                        TextBox_detalles9.Visible = True
                                    Else
                                        If TextNum10.Visible = False Then
                                            TextNum10.Visible = True
                                            ComboBoxProducto10.Visible = True
                                            TextQuantity10.Visible = True
                                            TextUnitPrice10.Visible = True
                                            TextTotal10.Visible = True
                                            TextUm10.Visible = True
                                            TextBox_detalles10.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub imgMenosFila_Click(sender As Object, e As EventArgs) Handles imgMenosFila.Click
        'TextNum2.Visible = True
        'TextDescription2.Visible = True
        'TextQuantity2.Visible = True
        'TextUnitPrice2.Visible = True
        'TextTotal2.Visible = True

        If TextNum10.Visible = True Then
            TextNum10.Visible = False
            ComboBoxProducto10.Visible = False
            TextQuantity10.Visible = False
            TextUnitPrice10.Visible = False
            TextTotal10.Visible = False
            TextUm10.Visible = False
            TextBox_detalles10.Visible = False
        Else
            If TextNum9.Visible = True Then
                TextNum9.Visible = False
                ComboBoxProducto9.Visible = False
                TextQuantity9.Visible = False
                TextUnitPrice9.Visible = False
                TextTotal9.Visible = False
                TextUm9.Visible = False
                TextBox_detalles9.Visible = False
            Else
                If TextNum8.Visible = True Then
                    TextNum8.Visible = False
                    ComboBoxProducto8.Visible = False
                    TextQuantity8.Visible = False
                    TextUnitPrice8.Visible = False
                    TextTotal8.Visible = False
                    TextUm8.Visible = False
                    TextBox_detalles8.Visible = False
                Else
                    If TextNum7.Visible = True Then
                        TextNum7.Visible = False
                        ComboBoxProducto7.Visible = False
                        TextQuantity7.Visible = False
                        TextUnitPrice7.Visible = False
                        TextTotal7.Visible = False
                        TextUm7.Visible = False
                        TextBox_detalles7.Visible = False
                    Else
                        If TextNum6.Visible = True Then
                            TextNum6.Visible = False
                            ComboBoxProducto6.Visible = False
                            TextQuantity6.Visible = False
                            TextUnitPrice6.Visible = False
                            TextTotal6.Visible = False
                            TextUm6.Visible = False
                            TextBox_detalles6.Visible = False
                        Else
                            If TextNum5.Visible = True Then
                                TextNum5.Visible = False
                                ComboBoxProducto5.Visible = False
                                TextQuantity5.Visible = False
                                TextUnitPrice5.Visible = False
                                TextTotal5.Visible = False
                                TextUm5.Visible = False
                                TextBox_detalles5.Visible = False
                            Else
                                If TextNum4.Visible = True Then
                                    TextNum4.Visible = False
                                    ComboBoxProducto4.Visible = False
                                    TextQuantity4.Visible = False
                                    TextUnitPrice4.Visible = False
                                    TextTotal4.Visible = False
                                    TextUm4.Visible = False
                                    TextBox_detalles4.Visible = False
                                Else
                                    If TextNum3.Visible = True Then
                                        TextNum3.Visible = False
                                        ComboBoxProducto3.Visible = False
                                        TextQuantity3.Visible = False
                                        TextUnitPrice3.Visible = False
                                        TextTotal3.Visible = False
                                        TextUm3.Visible = False
                                        TextBox_detalles3.Visible = False
                                    Else
                                        If TextNum2.Visible = True Then
                                            TextNum2.Visible = False
                                            ComboBoxProducto2.Visible = False
                                            TextQuantity2.Visible = False
                                            TextUnitPrice2.Visible = False
                                            TextTotal2.Visible = False
                                            TextUm2.Visible = False
                                            TextBox_detalles2.Visible = False

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    '--------------------------------Generar codigo de seguimiento -------------------------
    Sub GenerarCS()
        Dim conexxo As New SqlConnection(conexioncita)
        Dim cmd As New SqlCommand("select MAX(id_orden)from TB_Ordenes_Compra", conexxo)
        Dim strCodigo As String
        conexxo.Open()
        strCodigo = cmd.ExecuteScalar
        conexxo.Close()

        Dim id As Integer = CType(strCodigo.Substring(0), Integer)

        Text_Cs.Text = "CS-OC-" + Format(id + 1, "0000") + "/20"
    End Sub
    '--------------------------------Generar codigo de orden de compra -------------------------
    'Sub GenerarCodigo()
    '    Dim conexxo As New SqlConnection(conexioncita)
    '    Dim cmd As New SqlCommand("select MAX(id_orden)from TB_Ordenes_Compra", conexxo)
    '    Dim strCodigo As String
    '    conexxo.Open()
    '    strCodigo = cmd.ExecuteScalar
    '    conexxo.Close()

    '    Dim id As Integer = CType(strCodigo.Substring(0), Integer)

    '    TextCodigo.Text = "OC-" + Format(id + 1, "0000") + "/20"
    'End Sub

    Private Sub btnview_Click(sender As Object, e As EventArgs) Handles btnview.Click
        RegistrosOrdCom.Show()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        '-----------------modificar en la base orden de compra primero 
        '1-classRegistrosOrdC
        '2--Funcion_registros nos vamos a clase FN_InsertarPersonas/creamos el procedimietnorp almacenado
        '3--traemos todo aqui

        If MessageBox.Show("Estas Seguro Que Quieres Modificar La " + TextCodigo.Text, "Modificar Orden de Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            '---------------comiienza codigo
            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosOrdC

                logica.G_codigo = Me.TextCodigo.Text
                logica.G_fecha2Nota = Me.DateFechaOrden.Value 'de esta manera recibimos ala fecha y si queremos solo ala fecha agregamos .DAte
                logica.G_id_pro = Me.ComboBoxProveedores.SelectedValue 'obtemos el id del valor el cual se esta mostrando en el combo
                logica.G_purchaseOrder = Me.TextPurchase.Text
                logica.G_req_compra = Me.TexReqCompra.Text
                logica.G_place_delivery = Me.TextPlaceDelivery.Text
                logica.G_cif = Me.TextCif.Text
                logica.G_delivery_time = Me.TextDeliverytime.Text
                logica.G_boarding_instr = Me.TextBoarding.Text
                logica.G_payment_c = Me.TextPaymentConditions.Text
                logica.G_buyer = Me.TextBuyer.Text
                logica.G_aproved = Me.TextApproved.Text
                logica.G_personal_seller = Me.TextPersonalSeller.Text
                logica.G_subtotall = Me.TextSubtotal.Text
                logica.G_ivaaaa = Me.TextIva.Text
                logica.G_Total = Me.TextTotalFinal.Text
                logica.G_total_letter = Me.TextTotalLetra.Text
                logica.G_observaciones = Me.TextBox_observaciones.Text
                logica.G_Categoria = Me.ComboBox_AREA.Text
                If check_Mxn.Checked = True Then
                    logica.G_moneda = "Mxn".ToString
                Else
                    If check_Usd.Checked = True Then
                        logica.G_moneda = "Usd".ToString
                    Else

                        If check_Euro.Checked = True Then
                            logica.G_moneda = "Euro".ToString
                        Else
                        End If
                    End If
                End If

                If funciones.FN_ModificarOrdenes(logica) Then
                    MsgBox("Orden Modificada Correctamente", MessageBoxIcon.Information)
                    combo_SECCION()
                    TextCodigo.Clear()
                    TextPurchase.Clear()
                    TexReqCompra.Clear()
                    TextCif.Clear()
                    TextDeliverytime.Clear()
                    TextBoarding.Clear()
                    TextPaymentConditions.Clear()
                    TextBuyer.Clear()
                    TextApproved.Clear()
                    TextPersonalSeller.Clear()
                    TextSubtotal.Clear()
                    TextIva.Clear()
                    TextTotalFinal.Clear()
                    TextTotalLetra.Clear()
                    TextBox_observaciones.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            '---------------------LIMPIAR TEXTBOX----------------

            '---------------------TERMINA LIMPIAR TEXTBOX----------------
            '--------------------------recargar codigo Orden------------------------------
            'GenerarCodigo()
            '------------------------------------------------------------------------------

            '-------------------------------------------Modificar Lista de productos------------------------------
            '-----------------agregar ala base productos de orden compra primero 
            '1-classRegistrosProdOrdCompra
            '2--Funcion_registros nos vamos a clase Fn_insertar_productosOrdC/creamos el procedimietnorp almacenado
            '3--traemos todo aqui
            '---------------------------------------registro de tabla 1------------------------------------------------
            If (TextNum1.Text = "" Or TextQuantity1.Text = "" Or TextUnitPrice1.Text = "" Or TextTotal1.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto1.Text
                    logica1.GCantidad = Me.TextQuantity1.Text
                    logica1.Gprecio = Me.TextUnitPrice1.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal1.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId1.Text
                    logica1.GUm = Me.TextUm1.Text
                    logica1.Gdetalles = Me.TextBox_detalles1.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity1.Clear()
                        TextUnitPrice1.Clear()
                        TextTotal1.Clear()
                        TextUm1.Clear()
                        TextBox_detalles1.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 2------------------------------------------------
            If (TextNum2.Text = "" Or TextQuantity2.Text = "" Or TextUnitPrice2.Text = "" Or TextTotal2.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto2.Text
                    logica1.GCantidad = Me.TextQuantity2.Text
                    logica1.Gprecio = Me.TextUnitPrice2.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal2.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId2.Text
                    logica1.GUm = Me.TextUm2.Text
                    logica1.Gdetalles = Me.TextBox_detalles2.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity2.Clear()
                        TextUnitPrice2.Clear()
                        TextTotal2.Clear()
                        TextUm2.Clear()
                        TextBox_detalles2.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 3------------------------------------------------
            If (TextNum3.Text = "" Or TextQuantity3.Text = "" Or TextUnitPrice3.Text = "" Or TextTotal3.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto3.Text
                    logica1.GCantidad = Me.TextQuantity3.Text
                    logica1.Gprecio = Me.TextUnitPrice3.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal3.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId3.Text
                    logica1.GUm = Me.TextUm3.Text
                    logica1.Gdetalles = Me.TextBox_detalles3.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        ' MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity3.Clear()
                        TextUnitPrice3.Clear()
                        TextTotal3.Clear()
                        TextUm3.Clear()
                        TextBox_detalles3.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 4------------------------------------------------
            If (TextNum4.Text = "" Or TextQuantity4.Text = "" Or TextUnitPrice4.Text = "" Or TextTotal4.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto4.Text
                    logica1.GCantidad = Me.TextQuantity4.Text
                    logica1.Gprecio = Me.TextUnitPrice4.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal4.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId4.Text
                    logica1.GUm = Me.TextUm4.Text
                    logica1.Gdetalles = Me.TextBox_detalles4.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity4.Clear()
                        TextUnitPrice4.Clear()
                        TextTotal4.Clear()
                        TextUm4.Clear()
                        TextBox_detalles4.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 5------------------------------------------------
            If (TextNum5.Text = "" Or TextQuantity5.Text = "" Or TextUnitPrice5.Text = "" Or TextTotal5.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto5.Text
                    logica1.GCantidad = Me.TextQuantity5.Text
                    logica1.Gprecio = Me.TextUnitPrice5.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal5.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId5.Text
                    logica1.GUm = Me.TextUm5.Text
                    logica1.Gdetalles = Me.TextBox_detalles5.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity5.Clear()
                        TextUnitPrice5.Clear()
                        TextTotal5.Clear()
                        TextUm5.Clear()
                        TextBox_detalles5.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 6------------------------------------------------
            If (TextNum6.Text = "" Or TextQuantity6.Text = "" Or TextUnitPrice6.Text = "" Or TextTotal6.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto6.Text
                    logica1.GCantidad = Me.TextQuantity6.Text
                    logica1.Gprecio = Me.TextUnitPrice6.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal6.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId6.Text
                    logica1.GUm = Me.TextUm6.Text
                    logica1.Gdetalles = Me.TextBox_detalles6.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity6.Clear()
                        TextUnitPrice6.Clear()
                        TextTotal6.Clear()
                        TextUm6.Clear()
                        TextBox_detalles6.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 7------------------------------------------------
            If (TextNum7.Text = "" Or TextQuantity7.Text = "" Or TextUnitPrice7.Text = "" Or TextTotal7.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto7.Text
                    logica1.GCantidad = Me.TextQuantity7.Text
                    logica1.Gprecio = Me.TextUnitPrice7.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal7.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId7.Text
                    logica1.GUm = Me.TextUm7.Text
                    logica1.Gdetalles = Me.TextBox_detalles7.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity7.Clear()
                        TextUnitPrice7.Clear()
                        TextTotal7.Clear()
                        TextUm7.Clear()
                        TextBox_detalles7.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla 8------------------------------------------------
            If (TextNum8.Text = "" Or TextQuantity8.Text = "" Or TextUnitPrice8.Text = "" Or TextTotal8.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto8.Text
                    logica1.GCantidad = Me.TextQuantity8.Text
                    logica1.Gprecio = Me.TextUnitPrice8.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal8.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId8.Text
                    logica1.GUm = Me.TextUm8.Text
                    logica1.Gdetalles = Me.TextBox_detalles8.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity8.Clear()
                        TextUnitPrice8.Clear()
                        TextTotal8.Clear()
                        TextUm8.Clear()
                        TextBox_detalles8.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla ¿9------------------------------------------------
            If (TextNum9.Text = "" Or TextQuantity9.Text = "" Or TextUnitPrice9.Text = "" Or TextTotal9.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto9.Text
                    logica1.GCantidad = Me.TextQuantity9.Text
                    logica1.Gprecio = Me.TextUnitPrice9.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal9.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId9.Text
                    logica1.GUm = Me.TextUm9.Text
                    logica1.Gdetalles = Me.TextBox_detalles9.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity9.Clear()
                        TextUnitPrice9.Clear()
                        TextTotal9.Clear()
                        TextUm9.Clear()
                        TextBox_detalles9.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 10------------------------------------------------
            If (TextNum10.Text = "" Or TextQuantity10.Text = "" Or TextUnitPrice10.Text = "" Or TextTotal10.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto10.Text
                    logica1.GCantidad = Me.TextQuantity10.Text
                    logica1.Gprecio = Me.TextUnitPrice10.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal10.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId10.Text
                    logica1.GUm = Me.TextUm10.Text
                    logica1.Gdetalles = Me.TextBox_detalles10.Text


                    If funciones.Fn_ModificarProductos(logica1) Then
                        MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity10.Clear()
                        TextUnitPrice10.Clear()
                        TextTotal10.Clear()
                        TextUm10.Clear()
                        TextBox_detalles10.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                        '-------termina codigo---------
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 11------------------------------------------------
            If (TextNum11.Text = "" Or TextQuantity11.Text = "" Or TextUnitPrice11.Text = "" Or TextTotal11.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto11.Text
                    logica1.GCantidad = Me.TextQuantity11.Text
                    logica1.Gprecio = Me.TextUnitPrice11.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal11.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId11.Text
                    logica1.GUm = Me.TextUm11.Text
                    logica1.Gdetalles = Me.TextBox_detalles11.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity11.Clear()
                        TextUnitPrice11.Clear()
                        TextTotal11.Clear()
                        TextUm11.Clear()
                        TextBox_detalles11.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 12------------------------------------------------
            If (TextNum12.Text = "" Or TextQuantity12.Text = "" Or TextUnitPrice12.Text = "" Or TextTotal12.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto12.Text
                    logica1.GCantidad = Me.TextQuantity12.Text
                    logica1.Gprecio = Me.TextUnitPrice12.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal12.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId12.Text
                    logica1.GUm = Me.TextUm12.Text
                    logica1.Gdetalles = Me.TextBox_detalles12.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity12.Clear()
                        TextUnitPrice12.Clear()
                        TextTotal12.Clear()
                        TextUm12.Clear()
                        TextBox_detalles12.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '---------------------------------------registro de tabla 13------------------------------------------------
            If (TextNum13.Text = "" Or TextQuantity13.Text = "" Or TextUnitPrice13.Text = "" Or TextTotal13.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto13.Text
                    logica1.GCantidad = Me.TextQuantity13.Text
                    logica1.Gprecio = Me.TextUnitPrice13.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal13.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId13.Text
                    logica1.GUm = Me.TextUm13.Text
                    logica1.Gdetalles = Me.TextBox_detalles13.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        ' MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity13.Clear()
                        TextUnitPrice13.Clear()
                        TextTotal13.Clear()
                        TextUm13.Clear()
                        TextBox_detalles13.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 14------------------------------------------------
            If (TextNum14.Text = "" Or TextQuantity14.Text = "" Or TextUnitPrice14.Text = "" Or TextTotal14.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto14.Text
                    logica1.GCantidad = Me.TextQuantity14.Text
                    logica1.Gprecio = Me.TextUnitPrice14.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal14.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId14.Text
                    logica1.GUm = Me.TextUm14.Text
                    logica1.Gdetalles = Me.TextBox_detalles14.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity14.Clear()
                        TextUnitPrice14.Clear()
                        TextTotal14.Clear()
                        TextUm14.Clear()
                        TextBox_detalles14.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 15------------------------------------------------
            If (TextNum15.Text = "" Or TextQuantity15.Text = "" Or TextUnitPrice15.Text = "" Or TextTotal15.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto15.Text
                    logica1.GCantidad = Me.TextQuantity15.Text
                    logica1.Gprecio = Me.TextUnitPrice15.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal15.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId15.Text
                    logica1.GUm = Me.TextUm15.Text
                    logica1.Gdetalles = Me.TextBox_detalles15.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity15.Clear()
                        TextUnitPrice15.Clear()
                        TextTotal15.Clear()
                        TextUm15.Clear()
                        TextBox_detalles15.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------

                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla 16------------------------------------------------
            If (TextNum16.Text = "" Or TextQuantity16.Text = "" Or TextUnitPrice16.Text = "" Or TextTotal16.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto16.Text
                    logica1.GCantidad = Me.TextQuantity16.Text
                    logica1.Gprecio = Me.TextUnitPrice16.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal16.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId16.Text
                    logica1.GUm = Me.TextUm16.Text
                    logica1.Gdetalles = Me.TextBox_detalles16.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity16.Clear()
                        TextUnitPrice16.Clear()
                        TextTotal16.Clear()
                        TextUm16.Clear()
                        TextBox_detalles16.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla 7------------------------------------------------
            If (TextNum17.Text = "" Or TextQuantity17.Text = "" Or TextUnitPrice17.Text = "" Or TextTotal17.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto17.Text
                    logica1.GCantidad = Me.TextQuantity17.Text
                    logica1.Gprecio = Me.TextUnitPrice17.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal17.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId17.Text
                    logica1.GUm = Me.TextUm17.Text
                    logica1.Gdetalles = Me.TextBox_detalles17.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity17.Clear()
                        TextUnitPrice17.Clear()
                        TextTotal17.Clear()
                        TextUm17.Clear()
                        TextBox_detalles17.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            '---------------------------------------registro de tabla 8------------------------------------------------
            If (TextNum18.Text = "" Or TextQuantity18.Text = "" Or TextUnitPrice18.Text = "" Or TextTotal18.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto18.Text
                    logica1.GCantidad = Me.TextQuantity18.Text
                    logica1.Gprecio = Me.TextUnitPrice18.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal18.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId18.Text
                    logica1.GUm = Me.TextUm18.Text
                    logica1.Gdetalles = Me.TextBox_detalles18.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity18.Clear()
                        TextUnitPrice18.Clear()
                        TextTotal18.Clear()
                        TextUm18.Clear()
                        TextBox_detalles18.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

            '---------------------------------------registro de tabla ¿9------------------------------------------------
            If (TextNum19.Text = "" Or TextQuantity19.Text = "" Or TextUnitPrice19.Text = "" Or TextTotal19.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto19.Text
                    logica1.GCantidad = Me.TextQuantity19.Text
                    logica1.Gprecio = Me.TextUnitPrice19.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal19.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId19.Text
                    logica1.GUm = Me.TextUm19.Text
                    logica1.Gdetalles = Me.TextBox_detalles19.Text

                    If funciones.Fn_ModificarProductos(logica1) Then
                        'MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity19.Clear()
                        TextUnitPrice19.Clear()
                        TextTotal19.Clear()
                        TextUm19.Clear()
                        TextBox_detalles19.Clear()
                        '-------------TERMINA LIMPIAR CAJAS----------
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


            '---------------------------------------registro de tabla 10------------------------------------------------
            If (TextNum20.Text = "" Or TextQuantity20.Text = "" Or TextUnitPrice20.Text = "" Or TextTotal20.Text = "") Then

            Else
                Try
                    Dim funciones As New Funcion_Registros
                    Dim logica1 As New ClassRegistrosProdOrdCompra
                    Dim logica As New ClassRegistrosOrdC

                    logica1.G_codigo_pro = Me.TextCodigo.Text
                    logica1.Gdescripcion = Me.ComboBoxProducto20.Text
                    logica1.GCantidad = Me.TextQuantity20.Text
                    logica1.Gprecio = Me.TextUnitPrice20.Text 'obtemos el id del valor el cual se esta mostrando en el combo
                    logica1.Gsubtotal = Me.TextTotal20.Text
                    logica1.G_id_pro_pro = Me.ComboBoxProveedores.SelectedValue
                    logica1.GId_pro = Me.TId20.Text
                    logica1.GUm = Me.TextUm20.Text
                    logica1.Gdetalles = Me.TextBox_detalles20.Text


                    If funciones.Fn_ModificarProductos(logica1) Then
                        MsgBox("Datos Insertados Correctamente")
                        '--------LIMPIAR CAJAS-------
                        TextQuantity20.Clear()
                        TextUnitPrice20.Clear()
                        TextTotal20.Clear()
                        TextUm20.Clear()
                        TextBox_detalles20.Clear()

                        '-------------TERMINA LIMPIAR CAJAS----------
                        '-------termina codigo---------
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                End Try
            End If
        End If
        GenerarCS()
        combo_SECCION()
    End Sub


    Sub MUESTRALO()
        Me.WindowState = FormWindowState.Maximized
    End Sub
    '-----------------------------Botonera minimizar y Cerrar-------------------------------
    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_minimizar_Click(sender As Object, e As EventArgs) Handles btn_minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '-----------------------------------------trmina botonera------------------------------
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    '---------------------------------coidigo para poder mover formulario------------------------------
    Private Sub Inicio_Od_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub
    Private Sub Inicio_Od_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        'Si el formulario no tiene borde (FormBorderStyle = none) la siguiente linea funciona bien
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        'pero si quieres dejar los bordes y la barra de titulo entonces es necesario descomentar la siguiente linea y comentar la anterior, osea ponerle el apostrofe
        'If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex - 8, Me.MousePosition.Y - Me.Location.Y - ey - 60))
    End Sub


    Private Sub Inicio_Od_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    '--------------------zzzzz BOTON gregar cajas de texto.----------------------
    Private Sub ImgAgregarTxt2_Click(sender As Object, e As EventArgs) Handles ImgAgregarTxt2.Click
        'TextNum2.Visible = True
        'TextDescription2.Visible = True
        'TextQuantity2.Visible = True
        'TextUnitPrice2.Visible = True
        'TextTotal2.Visible = True

        If TextNum12.Visible = False Then
            TextNum12.Visible = True
            ComboBoxProducto12.Visible = True
            TextQuantity12.Visible = True
            TextUnitPrice12.Visible = True
            TextTotal12.Visible = True
            TextUm12.Visible = True
            TextBox_detalles12.Visible = True
        Else
            If TextNum13.Visible = False Then
                TextNum13.Visible = True
                ComboBoxProducto13.Visible = True
                TextQuantity13.Visible = True
                TextUnitPrice13.Visible = True
                TextTotal13.Visible = True
                TextUm13.Visible = True
                TextBox_detalles13.Visible = True
            Else
                If TextNum14.Visible = False Then
                    TextNum14.Visible = True
                    ComboBoxProducto14.Visible = True
                    TextQuantity14.Visible = True
                    TextUnitPrice14.Visible = True
                    TextTotal14.Visible = True
                    TextUm14.Visible = True
                    TextBox_detalles14.Visible = True
                Else
                    If TextNum15.Visible = False Then
                        TextNum15.Visible = True
                        ComboBoxProducto15.Visible = True
                        TextQuantity15.Visible = True
                        TextUnitPrice15.Visible = True
                        TextTotal15.Visible = True
                        TextUm15.Visible = True
                        TextBox_detalles15.Visible = True
                    Else
                        If TextNum16.Visible = False Then
                            TextNum16.Visible = True
                            ComboBoxProducto16.Visible = True
                            TextQuantity16.Visible = True
                            TextUnitPrice16.Visible = True
                            TextTotal16.Visible = True
                            TextUm16.Visible = True
                            TextBox_detalles16.Visible = True
                        Else
                            If TextNum17.Visible = False Then
                                TextNum17.Visible = True
                                ComboBoxProducto17.Visible = True
                                TextQuantity17.Visible = True
                                TextUnitPrice17.Visible = True
                                TextTotal17.Visible = True
                                TextUm17.Visible = True
                                TextBox_detalles17.Visible = True
                            Else
                                If TextNum18.Visible = False Then
                                    TextNum18.Visible = True
                                    ComboBoxProducto18.Visible = True
                                    TextQuantity18.Visible = True
                                    TextUnitPrice18.Visible = True
                                    TextTotal18.Visible = True
                                    TextUm18.Visible = True
                                    TextBox_detalles18.Visible = True
                                Else
                                    If TextNum19.Visible = False Then
                                        TextNum19.Visible = True
                                        ComboBoxProducto19.Visible = True
                                        TextQuantity19.Visible = True
                                        TextUnitPrice19.Visible = True
                                        TextTotal19.Visible = True
                                        TextUm19.Visible = True
                                        TextBox_detalles19.Visible = True
                                    Else
                                        If TextNum20.Visible = False Then
                                            TextNum20.Visible = True
                                            ComboBoxProducto20.Visible = True
                                            TextQuantity20.Visible = True
                                            TextUnitPrice20.Visible = True
                                            TextTotal20.Visible = True
                                            TextUm20.Visible = True
                                            TextBox_detalles20.Visible = True
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    '------------------------------------------------------------------------------
    '--------------------zzzzz BOTON quitar cajas de texto.----------------------
    Private Sub imgMenosFila2_Click(sender As Object, e As EventArgs) Handles imgMenosFila2.Click
        'TextNum2.Visible = True
        'TextDescription2.Visible = True
        'TextQuantity2.Visible = True
        'TextUnitPrice2.Visible = True
        'TextTotal2.Visible = True

        If TextNum20.Visible = True Then
            TextNum20.Visible = False
            ComboBoxProducto20.Visible = False
            TextQuantity20.Visible = False
            TextUnitPrice20.Visible = False
            TextTotal20.Visible = False
            TextUm20.Visible = False
            TextBox_detalles20.Visible = False
        Else
            If TextNum19.Visible = True Then
                TextNum19.Visible = False
                ComboBoxProducto19.Visible = False
                TextQuantity19.Visible = False
                TextUnitPrice19.Visible = False
                TextTotal19.Visible = False
                TextUm19.Visible = False
                TextBox_detalles19.Visible = False
            Else
                If TextNum18.Visible = True Then
                    TextNum18.Visible = False
                    ComboBoxProducto18.Visible = False
                    TextQuantity18.Visible = False
                    TextUnitPrice18.Visible = False
                    TextTotal18.Visible = False
                    TextUm18.Visible = False
                    TextBox_detalles18.Visible = False
                Else
                    If TextNum17.Visible = True Then
                        TextNum17.Visible = False
                        ComboBoxProducto17.Visible = False
                        TextQuantity17.Visible = False
                        TextUnitPrice17.Visible = False
                        TextTotal17.Visible = False
                        TextUm17.Visible = False
                        TextBox_detalles17.Visible = False
                    Else
                        If TextNum16.Visible = True Then
                            TextNum16.Visible = False
                            ComboBoxProducto16.Visible = False
                            TextQuantity16.Visible = False
                            TextUnitPrice16.Visible = False
                            TextTotal16.Visible = False
                            TextUm16.Visible = False
                            TextBox_detalles16.Visible = False
                        Else
                            If TextNum15.Visible = True Then
                                TextNum15.Visible = False
                                ComboBoxProducto15.Visible = False
                                TextQuantity15.Visible = False
                                TextUnitPrice15.Visible = False
                                TextTotal15.Visible = False
                                TextUm15.Visible = False
                                TextBox_detalles15.Visible = False
                            Else
                                If TextNum14.Visible = True Then
                                    TextNum14.Visible = False
                                    ComboBoxProducto14.Visible = False
                                    TextQuantity14.Visible = False
                                    TextUnitPrice14.Visible = False
                                    TextTotal14.Visible = False
                                    TextUm14.Visible = False
                                    TextBox_detalles14.Visible = False
                                Else
                                    If TextNum13.Visible = True Then
                                        TextNum13.Visible = False
                                        ComboBoxProducto13.Visible = False
                                        TextQuantity13.Visible = False
                                        TextUnitPrice13.Visible = False
                                        TextTotal13.Visible = False
                                        TextUm13.Visible = False
                                        TextBox_detalles13.Visible = False
                                    Else
                                        If TextNum12.Visible = True Then
                                            TextNum12.Visible = False
                                            ComboBoxProducto12.Visible = False
                                            TextQuantity12.Visible = False
                                            TextUnitPrice12.Visible = False
                                            TextTotal12.Visible = False
                                            TextUm12.Visible = False
                                            TextBox_detalles12.Visible = False

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    '------------------------------------------------------------------------



    '---------------------------------termina coidigo para poder mover formulario------------------------------
    '------------------------------------Eliminar---------------------------------------------
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If MessageBox.Show("Estas Seguro Que Quieres Eliminar La " + TextCodigo.Text, "Eliminar Ordenes Compra", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            '---------------comiienza codigo
            '-----------------modificar en la base orden de compra primero 
            '1-classRegistrosOrdC
            '2--Funcion_registros nos vamos a clase FN_InsertarPersonas/creamos el procedimietnorp almacenado
            '3--traemos todo aqui
            Try
                Dim funciones As New Funcion_Registros
                Dim logica As New ClassRegistrosOrdC

                logica.G_codigo = Me.TextCodigo.Text

                If funciones.FN_EliminarOrdenes(logica) Then
                    MsgBox("Orden Eliminada Correctamente", MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            '----------------------------limpiar Cajas ---------------------------------
            TextCodigo.Clear()
            TextPurchase.Clear()
            TexReqCompra.Clear()
            TextPlaceDelivery.Clear()
            TextCif.Clear()
            TextDeliverytime.Clear()
            TextBoarding.Clear()
            TextPaymentConditions.Clear()
            TextBuyer.Clear()
            TextApproved.Clear()
            TextPersonalSeller.Clear()
            TextSubtotal.Clear()
            TextIva.Clear()
            TextTotalFinal.Clear()
            TextTotalLetra.Clear()
            '---------------------------------------------------------------------------
            '--------LIMPIAR CAJAS-------
            TextQuantity1.Clear()
            TextUnitPrice1.Clear()
            TextTotal1.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity2.Clear()
            TextUnitPrice2.Clear()
            TextTotal2.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity3.Clear()
            TextUnitPrice3.Clear()
            TextTotal3.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity4.Clear()
            TextUnitPrice4.Clear()
            TextTotal4.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity5.Clear()
            TextUnitPrice5.Clear()
            TextTotal5.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity6.Clear()
            TextUnitPrice6.Clear()
            TextTotal6.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity7.Clear()
            TextUnitPrice7.Clear()
            TextTotal7.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity8.Clear()
            TextUnitPrice8.Clear()
            TextTotal8.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity9.Clear()
            TextUnitPrice9.Clear()
            TextTotal9.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------LIMPIAR CAJAS-------
            TextQuantity10.Clear()
            TextUnitPrice1.Clear()
            TextTotal10.Clear()
            '-------------TERMINA LIMPIAR CAJAS----------
            '--------------------------recargar codigo Orden------------------------------
            'GenerarCodigo()
            GenerarCS()
            '------------------------------------------------------------------------------
        End If
    End Sub
    '---------------------Realizacion de cambio moneda Usd ---Mx ----------------------



    ''---------------------Terminacion--------------------------------------------------
    ''Búsqueda en la Página del SAT
    ''   Creación de Link para el SAT  - Fecha y Tipo de Cambio Actual
    ''Tipo de Cambio con SAT
    'Dim wsat As WebBrowser 'Actual
    'Dim sat As WebBrowser  'Modificado
    'Private Sub FechaActual()
    '    Dim D = DateTime.Now.ToString("dd")
    '    Dim M = DateTime.Now.ToString("MM")
    '    Dim Y = DateTime.Now.ToString("yyyy")

    '    Dim URLS As String = ("https://dof.gob.mx/indicadores_detalle.php?cod_tipo_indicador=158&&dfecha=" & D & "%2F" & M + "%2F" & Y & "&&hfecha=" & D & "%2F" & M & "%2F" & Y)

    '    wsat = New WebBrowser()

    '    wsat.ScriptErrorsSuppressed = True

    '    direccionUrl.Text = URLS
    '    wsat.Navigate(New Uri(URLS)) ' Carga la página web creando un nuevo documento HTML
    '    AddHandler wsat.DocumentCompleted, New WebBrowserDocumentCompletedEventHandler(AddressOf TipoCambioHoy)
    'End Sub




    'Private Sub TipoCambioHoy()
    '    If (wsat.Document IsNot Nothing) Then ' En caso de que la página no halla cargado bien el documento
    '        Dim divs = wsat.Document.Body.GetElementsByTagName("td") ' Obtiene todos los elementos <div> de la página web
    '        For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
    '            Dim className As String = div.GetAttribute("width") ' Obtiene el atributo [class] (nos servirá de filtro)

    '            If className = "52%" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
    '                TxtTipoCambio.Text = div.InnerText ' Se obtiene el valor del dólar
    '            End If
    '        Next
    '    End If
    'End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    System.Diagnostics.Process.Start("https://dof.gob.mx/indicadores.php")
    'End Sub

    '-------------------------timer que se espera para mostrar mensaje error---------------------
    Private Sub mensajeError_Tick(sender As Object, e As EventArgs) Handles mensajeError.Tick

    End Sub

    '-------------------------timer que se espera hasta que cargue tipo de cambio para sumar---------------------

    '--------------Validaciones-----------------
    Private Sub TextQuantity1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity1.KeyPress
        NumerosyDecimal(TextQuantity1, com)
    End Sub

    Private Sub TextQuantity2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity2.KeyPress
        NumerosyDecimal(TextQuantity2, com)
    End Sub

    Private Sub TextQuantity3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity3.KeyPress
        NumerosyDecimal(TextQuantity3, com)
    End Sub

    Private Sub TextQuantity4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity4.KeyPress
        NumerosyDecimal(TextQuantity4, com)
    End Sub

    Private Sub TextQuantity5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity5.KeyPress
        NumerosyDecimal(TextQuantity5, com)
    End Sub

    Private Sub TextQuantity6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity6.KeyPress
        NumerosyDecimal(TextQuantity6, com)
    End Sub

    Private Sub TextQuantity7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity7.KeyPress
        NumerosyDecimal(TextQuantity7, com)
    End Sub

    Private Sub TextQuantity8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity8.KeyPress
        NumerosyDecimal(TextQuantity8, com)
    End Sub

    Private Sub TextQuantity9_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity9.KeyPress
        NumerosyDecimal(TextQuantity9, com)
    End Sub

    Private Sub TextQuantity10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity10.KeyPress
        NumerosyDecimal(TextQuantity10, com)
    End Sub

    Private Sub TextUnitPrice1_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice1.KeyPress
        NumerosyDecimal(TextUnitPrice1, com)
    End Sub

    Private Sub TextUnitPrice2_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice2.KeyPress
        NumerosyDecimal(TextUnitPrice2, com)
    End Sub

    Private Sub TextUnitPrice3_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice3.KeyPress
        NumerosyDecimal(TextUnitPrice3, com)
    End Sub

    Private Sub TextUnitPrice4_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice4.KeyPress
        NumerosyDecimal(TextUnitPrice4, com)
    End Sub

    Private Sub TextUnitPrice5_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice5.KeyPress
        NumerosyDecimal(TextUnitPrice5, com)
    End Sub

    Private Sub TextUnitPrice6_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice6.KeyPress
        NumerosyDecimal(TextUnitPrice6, com)
    End Sub

    Private Sub TextUnitPrice7_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice7.KeyPress
        NumerosyDecimal(TextUnitPrice7, com)
    End Sub

    Private Sub TextUnitPrice8_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice8.KeyPress
        NumerosyDecimal(TextUnitPrice8, com)
    End Sub

    Private Sub TextUnitPrice9_KeyPress_1(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice9.KeyPress
        NumerosyDecimal(TextUnitPrice9, com)
    End Sub
    Private Sub TextUnitPrice10_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice10.KeyPress
        NumerosyDecimal(TextUnitPrice10, com)
    End Sub

    Private Sub TextQuantity11_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity11.KeyPress
        NumerosyDecimal(TextQuantity11, com)
    End Sub

    Private Sub TextQuantity12_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity12.KeyPress
        NumerosyDecimal(TextQuantity12, com)
    End Sub

    Private Sub TextQuantity13_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity13.KeyPress
        NumerosyDecimal(TextQuantity13, com)
    End Sub

    Private Sub TextQuantity14_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity14.KeyPress
        NumerosyDecimal(TextQuantity14, com)
    End Sub

    Private Sub TextQuantity15_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity15.KeyPress
        NumerosyDecimal(TextQuantity15, com)
    End Sub

    Private Sub TextQuantity16_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity16.KeyPress
        NumerosyDecimal(TextQuantity16, com)
    End Sub

    Private Sub TextQuantity17_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity17.KeyPress
        NumerosyDecimal(TextQuantity17, com)
    End Sub

    Private Sub TextQuantity18_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity18.KeyPress
        NumerosyDecimal(TextQuantity18, com)
    End Sub

    Private Sub TextQuantity19_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity19.KeyPress
        NumerosyDecimal(TextQuantity19, com)

    End Sub

    Private Sub TextQuantity20_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextQuantity20.KeyPress
        NumerosyDecimal(TextQuantity20, com)
    End Sub

    Private Sub TextUnitPrice11_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice11.KeyPress
        NumerosyDecimal(TextUnitPrice11, com)
    End Sub

    Private Sub TextUnitPrice12_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice12.KeyPress
        NumerosyDecimal(TextUnitPrice12, com)
    End Sub

    Private Sub TextUnitPrice13_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice13.KeyPress
        NumerosyDecimal(TextUnitPrice13, com)
    End Sub

    Private Sub TextUnitPrice14_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice14.KeyPress
        NumerosyDecimal(TextUnitPrice14, com)
    End Sub

    Private Sub TextUnitPrice15_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice15.KeyPress
        NumerosyDecimal(TextUnitPrice15, com)
    End Sub

    Private Sub TextUnitPrice16_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice16.KeyPress
        NumerosyDecimal(TextUnitPrice16, com)
    End Sub

    Private Sub TextUnitPrice17_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice17.KeyPress
        NumerosyDecimal(TextUnitPrice17, com)
    End Sub

    Private Sub TextUnitPrice18_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice18.KeyPress
        NumerosyDecimal(TextUnitPrice18, com)
    End Sub

    Private Sub TextUnitPrice19_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice19.KeyPress
        NumerosyDecimal(TextUnitPrice19, com)
    End Sub

    Private Sub TextUnitPrice20_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextUnitPrice20.KeyPress
        NumerosyDecimal(TextUnitPrice20, com)
    End Sub

    Private Sub TextIva_KeyPress(sender As Object, com As KeyPressEventArgs) Handles TextIva.KeyPress
        NumerosyDecimal(TextIva, com)
    End Sub




    '-------------------------<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>---------------------
    '<<<-----------------------Funcion Usada por las validaciones <<<<<<<<<<<<<<<<<<<<<<<<<
    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar numeros", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal com As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(com.KeyChar) Then
            com.Handled = False
        ElseIf Char.IsControl(com.KeyChar) Then
            com.Handled = False
        ElseIf com.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            com.Handled = True
        ElseIf com.KeyChar = "." Then
            com.Handled = False
        Else
            com.Handled = True
            MsgBox("Solo se puede ingresar numeros y punto", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub


    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Dim Msg As MsgBoxResult
        Msg = MsgBox("Esta Seguro Que ¿Desea salir?", vbYesNo, MessageBoxIcon.Warning)
        If Msg = MsgBoxResult.Yes Then
            Application.ExitThread()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub BtnagregarProvedor_Click(sender As Object, e As EventArgs) Handles BtnagregarProvedor.Click
        NuevoProveedor.ShowDialog()
    End Sub


    Private Sub btnCerrarPrograma_Click(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        Me.Hide()
        Index.Show()
    End Sub

    Private Sub Total_10(sender As Object, e As EventArgs) Handles TextUnitPrice10.TextChanged, TextQuantity10.TextChanged

    End Sub

    Private Sub Total_9(sender As Object, e As EventArgs) Handles TextUnitPrice9.TextChanged, TextQuantity9.TextChanged

    End Sub

    Private Sub Total_8(sender As Object, e As EventArgs) Handles TextUnitPrice8.TextChanged, TextQuantity8.TextChanged

    End Sub

    Private Sub Total_7(sender As Object, e As EventArgs) Handles TextUnitPrice7.TextChanged, TextQuantity7.TextChanged

    End Sub

    Private Sub Total_6(sender As Object, e As EventArgs) Handles TextUnitPrice6.TextChanged, TextQuantity6.TextChanged

    End Sub

    Private Sub Total_5(sender As Object, e As EventArgs) Handles TextUnitPrice5.TextChanged, TextQuantity5.TextChanged

    End Sub

    Private Sub Total_4(sender As Object, e As EventArgs) Handles TextUnitPrice4.TextChanged, TextQuantity4.TextChanged

    End Sub

    Private Sub Total_3(sender As Object, e As EventArgs) Handles TextUnitPrice3.TextChanged, TextQuantity3.TextChanged

    End Sub

    Private Sub Total_2(sender As Object, e As EventArgs) Handles TextUnitPrice2.TextChanged, TextQuantity2.TextChanged

    End Sub

    Private Sub Total_1(sender As Object, e As EventArgs) Handles TextUnitPrice1.TextChanged, TextQuantity1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextUm18.TextChanged

    End Sub

    Private Sub btn_enviarmail_Click(sender As Object, e As EventArgs) Handles btn_enviarmail.Click
        Dim smtp As New System.Net.Mail.SmtpClient
        Dim correo As New System.Net.Mail.MailMessage
        Dim P1 As String
        Dim P2 As String
        Dim P3 As String
        Dim P4 As String
        Dim P5 As String
        Dim P6 As String
        Dim P7 As String
        Dim P8 As String
        Dim P9 As String
        Dim P10 As String
        Dim P11 As String
        Dim P12 As String
        Dim P13 As String
        Dim P14 As String
        Dim P15 As String
        Dim P16 As String
        Dim P17 As String
        Dim P18 As String
        Dim P19 As String
        Dim P20 As String

        Dim c1 As String
        Dim c2 As String
        Dim c3 As String
        Dim c4 As String
        Dim c5 As String
        Dim c6 As String
        Dim c7 As String
        Dim c8 As String
        Dim c9 As String
        Dim c10 As String
        Dim c11 As String
        Dim c12 As String
        Dim c13 As String
        Dim c14 As String
        Dim c15 As String
        Dim c16 As String
        Dim c17 As String
        Dim c18 As String
        Dim c19 As String
        Dim c20 As String
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity1.Text = "" Or TextUnitPrice1.Text = "" Or TextTotal1.Text = "" Then
            P1 = Nothing
            c1 = Nothing
        Else
            P1 = ComboBoxProducto1.Text
            c1 = TextQuantity1.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity2.Text = "" Or TextUnitPrice2.Text = "" Or TextTotal2.Text = "" Then
            P2 = Nothing
            c2 = Nothing
        Else
            P2 = ComboBoxProducto2.Text
            c2 = TextQuantity2.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity3.Text = "" Or TextUnitPrice3.Text = "" Or TextTotal3.Text = "" Then
            P3 = Nothing
            c3 = Nothing
        Else
            P3 = ComboBoxProducto3.Text
            c3 = TextQuantity3.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity4.Text = "" Or TextUnitPrice4.Text = "" Or TextTotal4.Text = "" Then
            P4 = Nothing
            c4 = Nothing
        Else
            P4 = ComboBoxProducto4.Text
            c4 = TextQuantity4.Text

        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity5.Text = "" Or TextUnitPrice5.Text = "" Or TextTotal5.Text = "" Then
            P5 = Nothing
            c5 = Nothing
        Else
            P5 = ComboBoxProducto5.Text
            c5 = TextQuantity5.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity6.Text = "" Or TextUnitPrice6.Text = "" Or TextTotal6.Text = "" Then
            P6 = Nothing
            c6 = Nothing
        Else
            P6 = ComboBoxProducto6.Text
            c6 = TextQuantity6.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity7.Text = "" Or TextUnitPrice7.Text = "" Or TextTotal7.Text = "" Then
            P7 = Nothing
            c7 = Nothing
        Else
            P7 = ComboBoxProducto7.Text
            c7 = TextQuantity7.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity8.Text = "" Or TextUnitPrice8.Text = "" Or TextTotal8.Text = "" Then
            P8 = Nothing
            c8 = Nothing
        Else
            P8 = ComboBoxProducto8.Text
            c8 = TextQuantity8.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity9.Text = "" Or TextUnitPrice9.Text = "" Or TextTotal9.Text = "" Then
            P9 = Nothing
            c9 = Nothing
        Else
            P9 = ComboBoxProducto9.Text
            c9 = TextQuantity9.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity10.Text = "" Or TextUnitPrice10.Text = "" Or TextTotal10.Text = "" Then
            P10 = Nothing
            c10 = Nothing
        Else
            P10 = ComboBoxProducto10.Text
            c10 = TextQuantity10.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity11.Text = "" Or TextUnitPrice11.Text = "" Or TextTotal11.Text = "" Then
            P11 = Nothing
            c11 = Nothing
        Else
            P11 = ComboBoxProducto11.Text
            c11 = TextQuantity11.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity12.Text = "" Or TextUnitPrice12.Text = "" Or TextTotal12.Text = "" Then
            P12 = Nothing
            c12 = Nothing
        Else
            P12 = ComboBoxProducto12.Text
            c12 = TextQuantity12.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity13.Text = "" Or TextUnitPrice13.Text = "" Or TextTotal13.Text = "" Then
            P13 = Nothing
            c13 = Nothing
        Else
            P13 = ComboBoxProducto13.Text
            c13 = TextQuantity13.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity14.Text = "" Or TextUnitPrice14.Text = "" Or TextTotal14.Text = "" Then
            P14 = Nothing
            c14 = Nothing
        Else
            P14 = ComboBoxProducto14.Text
            c14 = TextQuantity14.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity15.Text = "" Or TextUnitPrice15.Text = "" Or TextTotal15.Text = "" Then
            P15 = Nothing
            c15 = Nothing
        Else
            P15 = ComboBoxProducto15.Text
            c15 = TextQuantity15.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity16.Text = "" Or TextUnitPrice16.Text = "" Or TextTotal16.Text = "" Then
            P16 = Nothing
            c16 = Nothing
        Else
            P16 = ComboBoxProducto16.Text
            c16 = TextQuantity16.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity17.Text = "" Or TextUnitPrice17.Text = "" Or TextTotal17.Text = "" Then
            P17 = Nothing
            c17 = Nothing
        Else
            P17 = ComboBoxProducto17.Text
            c17 = TextQuantity17.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity18.Text = "" Or TextUnitPrice18.Text = "" Or TextTotal18.Text = "" Then
            P18 = Nothing
            c18 = Nothing
        Else
            P18 = ComboBoxProducto18.Text
            c18 = TextQuantity18.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity19.Text = "" Or TextUnitPrice19.Text = "" Or TextTotal19.Text = "" Then
            P19 = Nothing
            c19 = Nothing
        Else
            P19 = ComboBoxProducto19.Text
            c19 = TextQuantity19.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::
        If TextQuantity20.Text = "" Or TextUnitPrice20.Text = "" Or TextTotal20.Text = "" Then
            P20 = Nothing
            c20 = Nothing
        Else
            P20 = ComboBoxProducto20.Text
            c20 = TextQuantity20.Text
        End If
        ':::::::::::::::::::::::::::::::::_IF_::::::::::::::::::::::::::::::::::::::::::::::::::

        With smtp
            .Port = 25
            .Host = "mail.nucleosave.com.mx"
            .Credentials = New System.Net.NetworkCredential("Sistemas01@nucleosave.com.mx", "Sistemas01")
            .EnableSsl = False
        End With
        With correo
            .From = New System.Net.Mail.MailAddress("Sistemas01@nucleosave.com.mx")
            .To.Add("Sistemas01@nucleosave.com.mx")
            .Subject = "Orden de Compra" & TextCodigo.Text
            .Body = "<img src ='\\ANTUA-PC\Servidor_de_Archivos\Imagenes\logo_correo\logo.png'>" & "<p align='right'>Orden de Compra : " & TextCodigo.Text & "</p><br />" &
                    "Fecha: " & DateFechaOrden.Value.Date & "<br />" &
                    "Proveedor: " & ComboBoxProveedores.Text & "<br />" &
                    "La Compra se Realizara con Los Siguientes Productos " & "<br />" &
                     "<center><p>Listado de Productos:</p></center>" &
                     "<center><table>
                       <tr>
                        <th>Producto</th>
                        <th>Cantidad</th>
                      </tr> <tr>" &
                    "<td>" & P1 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c1 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P2 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c2 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P3 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c3 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P4 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c4 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P5 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c5 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P6 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c6 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P7 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c7 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P8 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c8 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P9 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c9 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P10 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c10 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P11 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c11 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P12 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c12 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P13 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c13 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P14 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c14 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P15 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c15 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P16 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c16 & "&nbsp;&nbsp;</td></tr><tr>" &
                    "<td>" & P17 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c17 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P18 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c18 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P19 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c19 & "&nbsp;&nbsp;</td></tr><tr>" &
                     "<td>" & P20 & "&nbsp;&nbsp;</td>" &
                    "<td style='text-align: center;'>" & c20 & "&nbsp;&nbsp;</td></tr><tr></table></center>" &
            "<font color='red'>Nota : Por Favor visite el sistema de ordenes de compra para más detalles e introduzca el codigó de la orden que ha recibido</font>"
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
        End With

        Try
            smtp.Send(correo)
            MessageBox.Show("Su mensaje de correo ha sido enviado.",
                            "Correo enviado",
                             MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message,
                            "Error al enviar correo",
                             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub cambio_casita1() Handles TextMoneda.TextChanged

        Dim Usd As String = "Usd"
        If TextMoneda.Text = Usd Then
            check_Mxn.Checked = False
            check_Euro.Checked = False
            check_Usd.Checked = True
        Else
        End If

    End Sub

    Sub cambio_casita2() Handles TextMoneda.TextChanged

        Dim Mxn As String = "Mxn"
        If TextMoneda.Text = Mxn Then
            check_Usd.Checked = False
            check_Euro.Checked = False
            check_Mxn.Checked = True
        Else
        End If
    End Sub

    Sub cambio_casita3() Handles TextMoneda.TextChanged

        Dim Euro As String = "Euro"
        If TextMoneda.Text = "Euro" Then
            check_Usd.Checked = False
            check_Mxn.Checked = False
            check_Euro.Checked = True
        Else
        End If
    End Sub

    Sub checkboxxx() Handles check_Mxn.CheckedChanged, check_Euro.CheckedChanged, check_Usd.CheckedChanged

        If check_Mxn.Checked = True Then
            check_Usd.Checked = False
            check_Euro.Checked = False
        Else
        End If
    End Sub
    Sub checkboxxx2() Handles check_Mxn.CheckedChanged, check_Euro.CheckedChanged, check_Usd.CheckedChanged

        If check_Usd.Checked = True Then
            check_Mxn.Checked = False
            check_Euro.Checked = False
        Else
        End If
    End Sub


    Sub checkboxxx3() Handles check_Mxn.CheckedChanged, check_Euro.CheckedChanged, check_Usd.CheckedChanged

        If check_Euro.Checked = True Then
            check_Mxn.Checked = False
            check_Usd.Checked = False
        Else
        End If
    End Sub



    Private Sub Btn_masProductos_Click(sender As Object, e As EventArgs) Handles Btn_masProductos.Click
        NProductos.Show()
    End Sub
End Class
