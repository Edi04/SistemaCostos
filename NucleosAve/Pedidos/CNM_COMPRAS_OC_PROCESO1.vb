Imports System.IO
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Math
Imports System.Xml
Imports System.Drawing.Printing
Public Class CNM_COMPRAS_OC_PROCESO1
    Dim con As String = My.Settings.Conexion
    Dim FILA As Integer
    Dim F1 As Integer
    Dim Dt As DataTable
    Dim Da As New SqlDataAdapter
    Dim Cmd As New SqlCommand
    Dim Consulta1 As New SqlCommand
    Dim Consulta2 As New SqlCommand
    Dim Consulta3 As New SqlCommand
    Dim Consulta4 As New SqlCommand
    Dim variable As SqlDataReader
    Dim variable1 As SqlDataReader
    Dim variable2 As SqlDataReader
    Dim conex As New SqlConnection(con)
    Dim ID_PROCESO1 As Integer
    Dim ID_PROCESO2 As Integer
    Dim ID_TRABAJADOR As Integer

    '    Private Function IsANonHeaderLinkCell(ByVal cellEvent As  _
    'DataGridViewCellEventArgs) As Boolean
    '        If TypeOf DGV_PROVEEDOR1.Columns(cellEvent.ColumnIndex) _
    '            Is DataGridViewLinkColumn _
    '            AndAlso Not cellEvent.RowIndex = -1 Then _
    '           Return True Else Return False
    '    End Function
    Private Function IsANonHeaderLinkCell2(ByVal cellEvent As _
DataGridViewCellEventArgs) As Boolean
        If TypeOf DATOS_ACT.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewLinkColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
           Return True Else Return False
    End Function
    Private Function IsANonHeaderLinkCell1(ByVal cellEvent As _
DataGridViewCellEventArgs) As Boolean
        If TypeOf TBPRODUCTO1.Columns(cellEvent.ColumnIndex) _
            Is DataGridViewLinkColumn _
            AndAlso Not cellEvent.RowIndex = -1 Then _
           Return True Else Return False
    End Function

    Private Sub SetBackGroundColorOfMDIForm()
        Dim ctl As Control
        For Each ctl In Me.Controls
            If TypeOf (ctl) Is MdiClient Then
                ctl.BackColor = System.Drawing.Color.White
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        FILAS()

        Label8.Visible = False
        Label6.Visible = False
        ID_PRODUCTO.Visible = False

        TBPRODUCTO1.Location = New Point(9, 205)
        TBPRODUCTO1.Size = New Size(907, 350)
        TBPRODUCTO1.Visible = False

        TBPRODUCTO2.Location = New Point(9, 205)
        TBPRODUCTO2.Size = New Size(907, 350)
        TBPRODUCTO2.Visible = False

        ALMACEN.Location = New Point(8, 120)
        ALMACEN.Size = New Size(1041, 70)
        ALMACEN.Visible = False

        ARMADO.Location = New Point(8, 120)
        ARMADO.Size = New Size(1041, 70)
        ARMADO.Visible = False

        MANTENIMIENTO.Location = New Point(8, 120)
        MANTENIMIENTO.Size = New Size(1041, 70)
        MANTENIMIENTO.Visible = False

        MASS.Location = New Point(8, 120)
        MASS.Size = New Size(1041, 70)
        MASS.Visible = False


        DATOS_ACT.Visible = False

        PictureBox2.Visible = False

        'llenar combo de PORCENTAJE......
        With Cmd
            .CommandType = CommandType.Text
            '.CommandText = "SELECT * FROM Tb_Clasificacion order by Nombre_Clas ASC"
            .CommandText = "SELECT Id_Unidad_Medida, nombre_unidad FROM tbl_unidad_medida  where Estado='activo' ORDER BY nombre_unidad ASC"
            .Connection = conex
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With UNIDADMEDIDAMASS
            .DataSource = Dt
            .DisplayMember = "nombre_unidad"
            .ValueMember = "Id_Unidad_Medida"
        End With
        'fin de llenado...................


        'llenar combo de PORCENTAJE......
        With Cmd
            .CommandType = CommandType.Text
            '.CommandText = "SELECT * FROM Tb_Clasificacion order by Nombre_Clas ASC"
            .CommandText = "SELECT Id_Unidad_Medida, nombre_unidad FROM tbl_unidad_medida  where Estado='activo' ORDER BY nombre_unidad ASC"
            .Connection = conex
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With MEDIDA3
            .DataSource = Dt
            .DisplayMember = "nombre_unidad"
            .ValueMember = "Id_Unidad_Medida"
        End With
        'fin de llenado...................


        'llenar combo de PORCENTAJE......
        With Cmd
            .CommandType = CommandType.Text
            '.CommandText = "SELECT * FROM Tb_Clasificacion order by Nombre_Clas ASC"
            .CommandText = "SELECT Id_Unidad_Medida, nombre_unidad FROM tbl_unidad_medida  where Estado='activo' ORDER BY nombre_unidad ASC"
            .Connection = conex
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With unidadmed2
            .DataSource = Dt
            .DisplayMember = "nombre_unidad"
            .ValueMember = "Id_Unidad_Medida"
        End With
        'fin de llenado...................


        'llenar combo de PORCENTAJE......
        With Cmd
            .CommandType = CommandType.Text
            '.CommandText = "SELECT * FROM Tb_Clasificacion order by Nombre_Clas ASC"
            .CommandText = "SELECT Id_Unidad_Medida, nombre_unidad FROM tbl_unidad_medida  where Estado='activo' ORDER BY nombre_unidad ASC"
            .Connection = conex
        End With
        Da.SelectCommand = Cmd
        Dt = New DataTable
        Da.Fill(Dt)
        With MEDIDA1
            .DataSource = Dt
            .DisplayMember = "nombre_unidad"
            .ValueMember = "Id_Unidad_Medida"
        End With
        'fin de llenado...................
        Consulta1.CommandType = CommandType.Text
        Consulta1.CommandText = ("SELECT numbre_area,id_area FROM A_PROCESOS_TBL WHERE estado='Activo' and numbre_area='Almacen' or numbre_area='Compras' or numbre_area='Mantenimiento' or numbre_area='Armado Rectangular' order by numbre_area asc")
        Consulta1.Connection = (conex)

        Consulta2.CommandType = CommandType.StoredProcedure
        Consulta2.Connection = (conex)
        Consulta2.CommandText = ("SP0_BUSCAR_PROCESO")
        Consulta2.Parameters.Add("@VAR1", SqlDbType.VarChar, 50)


        conex.Open()
        variable = Consulta1.ExecuteReader()
        While variable.Read = True
            Proceso1.Items.Add(variable.Item(0))
        End While
        conex.Close()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Proceso1.SelectedIndexChanged
        Consulta2.Parameters("@VAR1").Value = Proceso1.SelectedItem
        conex.Open()
        Trabajador.Items.Clear()
        variable = Consulta2.ExecuteReader()
        While variable.Read = True
            Trabajador.Items.Add(variable.Item(0))
        End While
        conex.Close()
    End Sub

    Private Sub UNNIDADIDMASS()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT nombre_unidad, Id_Unidad_Medida FROM tbl_unidad_medida where nombre_unidad=@Unidad_Medida and  Estado='Activo'"
        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@Unidad_Medida", Trim(UNIDADMEDIDAMASS.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                id_unidadmedidamass.Text = Trim(dr("Id_Unidad_Medida"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub UNNIDADID()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT nombre_unidad, Id_Unidad_Medida FROM tbl_unidad_medida where nombre_unidad=@Unidad_Medida and  Estado='Activo'"
        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@Unidad_Medida", Trim(MEDIDA1.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_UNIDADMEDIDA.Text = Trim(dr("Id_Unidad_Medida"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub
    Private Sub UNNIDADID1()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT nombre_unidad, Id_Unidad_Medida FROM tbl_unidad_medida where nombre_unidad=@Unidad_Medida and  Estado='Activo'"
        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@Unidad_Medida", Trim(unidadmed2.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_UNIDADMEDIDA.Text = Trim(dr("Id_Unidad_Medida"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub
    Private Sub UNNIDADID3()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT nombre_unidad, Id_Unidad_Medida FROM tbl_unidad_medida where nombre_unidad=@Unidad_Medida and  Estado='Activo'"
        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@Unidad_Medida", Trim(MEDIDA3.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_UNIDADMEDIDA.Text = Trim(dr("Id_Unidad_Medida"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub FILAS()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "select COUNT(*) AS FILAS from Tb_O_Compra"
        Dim cmd As New SqlCommand(sql, conex)
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    FILA = Trim(dr("FILAS"))
                    F1 = Val(FILA) + (1)
                    ID_OT.Text = Val(F1)
                Loop
            Else
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    'Private Sub DGV_PROVEEDOR_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    '    If IsANonHeaderLinkCell(e) = True Then
    '        Dim valuePROD As Object = DGV_PROVEEDOR1.SelectedCells(0).Value
    '        BUSCAR_DATOS_PROV(valuePROD)
    '        DGV_PROVEEDOR1.Visible = False
    '    End If
    'End Sub
    Private Sub BUSCAR_DATOS_PROV(ByVal valuePROD)
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT * FROM Tb_Proveedores WHERE NCOMERCIAL=@PROV"
        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@PROV", Trim(valuePROD))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                Do While dr.Read
                    ID_PROVEEDOR.Text = Trim(dr("Id_Proveedor"))
                    Proceso1.Text = Trim(dr("RSOCIAL"))
                Loop
            Else
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub NOMBRECOMERCIAL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


        ''DGV_PROVEEDOR.Visible = True
        ' buscar_PROV()
    End Sub
    'Private Sub buscar_PROV()
    '    Dim conex As New SqlConnection(con)
    '    Dim cmd As New SqlCommand("SP3_BUSCAR_PROVEEDOR1", conex)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.AddWithValue("@PROVEEDOR", Trim(Proceso1.Text))
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim ds As New DataSet
    '    Try
    '        conex.Open()
    '        da.Fill(ds)
    '        DGV_PROVEEDOR1.DataSource = ds.Tables(0)
    '        da.Dispose()
    '    Catch ex As Exception
    '        MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    '    conex.Close()
    'End Sub


    Private Sub PRODUCTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTOUNO1.TextChanged
        DATOS_ACT.Visible = False

        buscar_PRODUCTO_ALMACEN()
        TBPRODUCTO1.Visible = True
    End Sub





    Private Sub buscar_PRODUCTO_ALMACEN()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_BUSCAR_PRODUCTO", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTOUNO1.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conex.Open()
            da.Fill(ds)
            TBPRODUCTO1.DataSource = ds.Tables(0)
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub


    Private Sub buscar_PRODUCTO_MASS()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_BUSCAR_PRODUCTO_MASS", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTOMASS.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conex.Open()
            da.Fill(ds)
            TBPRODUCTO1.DataSource = ds.Tables(0)
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub buscar_PRODUCTO1()
        TBPRODUCTO2.Visible = True
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_BUSCAR_PRODUCTO1", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTO2.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conex.Open()
            da.Fill(ds)
            TBPRODUCTO2.Visible = True
            TBPRODUCTO2.DataSource = ds.Tables(0)
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub TBPRODUCTO_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TBPRODUCTO1.CellContentClick
        Dim FILAPRODUCTO As Integer
        Dim row As DataGridViewRow = TBPRODUCTO1.Rows(e.RowIndex)
        FILAPRODUCTO = row.Cells(0).Value
        TextBox1.Visible = False

        TextBox1.Enabled = False
        TextBox1.Text = FILAPRODUCTO
        BUSCAR_DATOS_PRODUCTO(FILAPRODUCTO)
        TBPRODUCTO1.Visible = False
        CANTIDAD1.Focus()
        If (ID_PRODUCTO.Text <> "") Then
            Label6.Visible = True
            Label8.Visible = False
        Else
            Label8.Visible = True
            Label6.Visible = False
        End If



        'If IsANonHeaderLinkCell1(e) = True Then
        '    Dim valuePROD As Object = TBPRODUCTO.SelectedCells(0).Value
        '    BUSCAR_DATOS_PRODUCTO(valuePROD)
        '    TBPRODUCTO.Visible = False
        '    CANTIDAD1.Focus()
        '    If (ID_PRODUCTO.Text <> "") Then
        '        Label6.Visible = True
        '        Label8.Visible = False
        '    Else
        '        Label8.Visible = True
        '        Label6.Visible = False
        '    End If
        'End If
    End Sub
    Private Sub Text1_Change()
        PRODUCTOUNO1.Text = UCase(PRODUCTOUNO1.Text)
        'PRODUCTO.SelStart = Len(PRODUCTO)
    End Sub
    Private Sub BUSCAR_DATOS_PRODUCTO(ByVal valuePROD)
        Dim DATO1 As String
        Dim DATO2 As String
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SELECT * FROM tbl_producto123 WHERE id_producto123=@PROD", conex)
        cmd.Parameters.AddWithValue("@PROD", Trim(valuePROD))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_PRODUCTO.Text = Trim(dr("ID_PRODUCTO123"))
                DATO1 = Trim(dr("DESCRIPCION"))
                DATO2 = Trim(dr("numero_producto"))
                PRODUCTOUNO1.Text = (DATO1 + " " + DATO2)
                Text1_Change()
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub BUSCAR_DATOS_PROCESO1()

        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SELECT numbre_area,id_area FROM A_PROCESOS_TBL WHERE estado='Activo' AND numbre_area=@PROCESO1", conex)
        cmd.Parameters.AddWithValue("@PROCESO1", Trim(Proceso1.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_PROCESO1 = Trim(dr("id_area"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub
    Private Sub BUSCAR_DATOS_PROCESO2()

        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SELECT numbre_area,id_area FROM A_PROCESOS_TBL WHERE estado='Activo' AND numbre_area=@PROCESO2", conex)
        cmd.Parameters.AddWithValue("@PROCESO2", Trim(proceso2.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_PROCESO2 = Trim(dr("id_area"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub
    Private Sub BUSCAR_DATOS_TRABAJADOR()

        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SELECT id_Empleado, nombre_Empleado FROM empleados_a WHERE estado='Activo' AND nombre_Empleado +' '+ ape_paterno+' '+ ape_materno=@TRABAJADOR", conex)
        cmd.Parameters.AddWithValue("@TRABAJADOR", Trim(Trabajador.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_TRABAJADOR = Trim(dr("id_Empleado"))

            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub

    Private Sub INICIO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        BUSCAR_DATOS_TRABAJADOR()
        BUSCAR_DATOS_PROCESO1()
        BUSCAR_DATOS_PROCESO2()

        FILAS()
        G_VENTA()
        Proceso_peticion.Enabled = False
        If Proceso1.Text = "Almacen" Then
            ALMACEN.Visible = True
            ARMADO.Visible = False
            MANTENIMIENTO.Visible = False
            MASS.Visible = False

        End If

        If Proceso1.Text = "Mantenimiento" Then
            ALMACEN.Visible = False
            ARMADO.Visible = False
            MANTENIMIENTO.Visible = True
            MASS.Visible = False
        End If

        If Proceso1.Text = "Armado Rectangular" Then
            ALMACEN.Visible = False
            ARMADO.Visible = True
            MANTENIMIENTO.Visible = False
            MASS.Visible = False
        End If

        If Proceso1.Text = "MASS" Then
            ALMACEN.Visible = False
            ARMADO.Visible = False
            MANTENIMIENTO.Visible = False
            MASS.Visible = True
        End If

        If Proceso1.Text <> "Armado Rectangular" Or Proceso1.Text <> "Mantenimiento" Or Proceso1.Text <> "Almacen" Then
            'ALMACEN.Visible = False
            'ARMADO.Visible = True
            'MANTENIMIENTO.Visible = False
        End If
        'If Proceso1.Text <> "Armado Rectangular" Or Proceso1.Text <> "Mantenimiento" Or Proceso1.Text <> "Almacen" Then
        '    SELECCIONARPRODUCTO.Visible = False
        '    ARMADO.Visible = True
        '    MANTENIMIENTO.Visible = False
        'End If
    End Sub
    Private Sub G_VENTA()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_COMPRA", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@Proceso1", Trim(Proceso1.Text))
        cmd.Parameters.AddWithValue("@Proceso2", Trim(proceso2.Text))
        cmd.Parameters.AddWithValue("@ID_PROCESO1", Trim(ID_PROCESO1))
        cmd.Parameters.AddWithValue("@ID_PROCESO2", Trim(ID_PROCESO2))
        cmd.Parameters.AddWithValue("@Trabajador", Trim(Trabajador.Text))
        cmd.Parameters.AddWithValue("@id_Trabajador", Trim(ID_TRABAJADOR))
        'cmd.Parameters.AddWithValue("@PAGO_LUGAR", Trim(PAGOENLUGAR.Text))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (PRODUCTOUNO1.Text <> "" And CANTIDAD1.Text <> "" And MEDIDA1.Text <> "" And ID_PRODUCTO.Text <> "") Then
            UNNIDADID()
            GUARDAR_DATOS_PEDIDO1()
            LLENAR_DATOS()


            Label6.Visible = False
            Label8.Visible = False
            PRODUCTOUNO1.Text = ""
            CANTIDAD1.Text = ""
            TBPRODUCTO1.Visible = False
            TBPRODUCTO2.Visible = False
            DATOS_ACT.Visible = True
        Else
            MessageBox.Show("LLENA TODOS LOS CAMPOS PORFAVOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub GUARDAR_DATOS_PEDIDO3()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_LISTA", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@ID_PRODUCTO", Trim("824"))
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTO3.Text))
        cmd.Parameters.AddWithValue("@CANTIDAD", Trim(CANTIDAD3.Text))
        cmd.Parameters.AddWithValue("@UNIDADMEDIDA", Trim(ID_UNIDADMEDIDA.Text))


        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub GUARDAR_DATOS_PEDIDO2()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_LISTA1", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@ID_PRODUCTO", Trim(ID_PRODUCTO.Text))
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTO2.Text))
        cmd.Parameters.AddWithValue("@CANTIDAD", Trim(CANTIDAD2.Text))
        cmd.Parameters.AddWithValue("@UNIDADMEDIDA", Trim(ID_UNIDADMEDIDA.Text))


        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GUARDAR_DATOS_PEDIDOMASS()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_LISTA_MASS", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@ID_PRODUCTO", Trim(ID_PRODUCTOMASS.Text))
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTOMASS.Text))
        cmd.Parameters.AddWithValue("@CANTIDAD", Trim(CANTIDADMASS.Text))
        cmd.Parameters.AddWithValue("@UNIDADMEDIDA", Trim(id_unidadmedidamass.Text))


        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LLENAR_DATOS()
        Dim conex As New SqlConnection(con)
        Dim sql As String = "SELECT Producto,Cantidad,Estado,Fecha,Id_Orden_Compra_Detalle FROM Tb_O_Compra_Detalle WHERE ID_ORDEN_COMPRA=@Id_OC"


        Dim cmd As New SqlCommand(sql, conex)
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        Try
            conex.Open()
            da.Fill(ds)
            DATOS_ACT.DataSource = ds.Tables(0)

            da.Dispose()
            For Each fila As DataGridViewRow In DATOS_ACT.Rows

                If fila.Cells("Estado").Value = "OC_INICIO" Then
                    fila.Cells("Estado").Style.BackColor = Color.DarkSalmon
                    fila.Cells("Estado").Style.ForeColor = Color.White
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub


    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If ID_DETALLE_OC.Text <> "" Then
            Dim result1 As DialogResult = MessageBox.Show(NOMBRE_EMPLEADO.Text & "¿QUIERES ELIMINAR EL REGISTRO NUMERO " & ID_DETALLE_OC.Text & " DE ORDEN DE COMPRA? ", "Importante", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result1 = Windows.Forms.DialogResult.Yes Then
                ELIMINAR_DE_ORDEN_COMPRA()
                LLENAR_DATOS()
                ID_DETALLE_OC.Text = ""
                ID_DETALLE_OC.Visible = False
                PictureBox2.Visible = False
            End If
        Else
            MessageBox.Show(NOMBRE_EMPLEADO.Text & "  DEBES SELECCIONAR UN REGISTRO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub
    Private Sub ELIMINAR_DE_ORDEN_COMPRA()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_LISTA_ELIMINAR", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@ID_PRODUCTO", Trim(ID_PRODUCTO.Text))
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTOUNO1.Text))
        cmd.Parameters.AddWithValue("@CANTIDAD", Trim(CANTIDAD1.Text))
        cmd.Parameters.AddWithValue("@UNIDADMEDIDA", Trim(ID_UNIDADMEDIDA.Text))
        cmd.Parameters.AddWithValue("@ID", Trim(ID_DETALLE_OC.Text))

        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub CBOUNIDADMEDIDA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MEDIDA1.SelectedIndexChanged
        Button2.Focus()
    End Sub


    Private Sub DATOS_OT_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim FILAPRODUCTO1 As Integer
        Dim row1 As DataGridViewRow = DATOS_ACT.Rows(e.RowIndex)
        FILAPRODUCTO1 = row1.Cells(0).Value




    End Sub


    Private Sub DATOS_ACT_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DATOS_ACT.CellContentClick
        Dim FILAPRODUCTO1 As Integer
        Dim row As DataGridViewRow = DATOS_ACT.Rows(e.RowIndex)
        FILAPRODUCTO1 = row.Cells(4).Value
        ID_DETALLE_OC.Visible = True
        ID_DETALLE_OC.Enabled = False
        ID_DETALLE_OC.Text = FILAPRODUCTO1
        PictureBox2.Visible = True
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (PRODUCTO2.Text <> "" And CANTIDAD2.Text <> "" And unidadmed2.Text <> "" And ID_PRODUCTO2.Text <> "") Then
            UNNIDADID1()
            GUARDAR_DATOS_PEDIDO2()
            LLENAR_DATOS()
            DATOS_ACT.Visible = True
            DATOS_ACT.Visible = True
            Label17.Visible = False
            Label18.Visible = False
            CANTIDAD2.Text = ""
            PRODUCTO2.Text = ""
            TBPRODUCTO2.Visible = False
            DATOS_ACT.Visible = True
        Else
            MessageBox.Show("LLENA TODOS LOS CAMPOS PORFAVOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTO2.TextChanged
        TBPRODUCTO2.Visible = True
        DATOS_ACT.Visible = False

        buscar_PRODUCTO1()


    End Sub

    Private Sub TBPRODUCTO2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TBPRODUCTO2.CellContentClick
        Dim FILAPRODUCTO As Integer
        Dim row As DataGridViewRow = TBPRODUCTO2.Rows(e.RowIndex)
        FILAPRODUCTO = row.Cells(0).Value
        TextBox1.Visible = False

        TextBox1.Enabled = False
        TextBox1.Text = FILAPRODUCTO
        BUSCAR_DATOS_PRODUCTO2(FILAPRODUCTO)
        TBPRODUCTO2.Visible = False
        CANTIDAD2.Focus()
        If (ID_PRODUCTO.Text <> "") Then
            Label18.Visible = True
            Label17.Visible = False
        Else
            Label17.Visible = True
            Label18.Visible = False
        End If
    End Sub

    Private Sub BUSCAR_DATOS_PRODUCTO2(ByVal valuePROD)
        Dim DATO1 As String
        Dim DATO2 As String
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SELECT * FROM tbl_producto123 WHERE id_producto123=@PROD", conex)
        cmd.Parameters.AddWithValue("@PROD", Trim(valuePROD))
        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader
            Do While dr.Read
                ID_PRODUCTO.Text = Trim(dr("ID_PRODUCTO123"))
                DATO1 = Trim(dr("DESCRIPCION"))
                DATO2 = Trim(dr("numero_producto"))
                PRODUCTO2.Text = (DATO1 + " " + DATO2)
                Text1_Change2()
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(".", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        conex.Close()
    End Sub
    Private Sub Text1_Change2()
        PRODUCTO2.Text = UCase(PRODUCTO2.Text)
        'PRODUCTO.SelStart = Len(PRODUCTO)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If (PRODUCTO3.Text <> "" And CANTIDAD3.Text <> "" And MEDIDA3.Text <> "") Then
            UNNIDADID3()
            GUARDAR_DATOS_PEDIDO3()
            LLENAR_DATOS()


            Label6.Visible = False
            Label8.Visible = False
            PRODUCTOUNO1.Text = ""
            CANTIDAD1.Text = ""
            TBPRODUCTO1.Visible = False
            TBPRODUCTO2.Visible = False
            DATOS_ACT.Visible = True
        Else
            MessageBox.Show("Hey, alguno de los datos que has ingresado esta incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub PRODUCTO3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTO3.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTOMASS.TextChanged
        DATOS_ACT.Visible = False

        buscar_PRODUCTO_MASS()
        TBPRODUCTO1.Visible = True
    End Sub

    Private Sub AGREGARMASS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGREGARMASS.Click
        If (PRODUCTOMASS.Text <> "" And CANTIDADMASS.Text <> "" And UNIDADMEDIDAMASS.Text <> "" And ID_PRODUCTOMASS.Text <> "") Then
            UNNIDADIDMASS()
            GUARDAR_DATOS_PEDIDOMASS()
            LLENAR_DATOS()


            MASSOK.Visible = False
            MASSOK.Visible = False
            PRODUCTOMASS.Text = ""
            CANTIDADMASS.Text = ""
            TBPRODUCTO1.Visible = False
            TBPRODUCTO2.Visible = False
            DATOS_ACT.Visible = False
            'TB_MASS.Visible = True

        Else
            MessageBox.Show("LLENA TODOS LOS CAMPOS PORFAVOR", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub GUARDAR_DATOS_PEDIDO1()
        Dim conex As New SqlConnection(con)
        Dim cmd As New SqlCommand("SP0_OT_LISTA1", conex)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@Id_OC", Trim(ID_OT.Text))
        cmd.Parameters.AddWithValue("@Id_Usuario", Trim(ID_EMPLEADO.Text))
        cmd.Parameters.AddWithValue("@ID_PRODUCTO", Trim(ID_PRODUCTO.Text))
        cmd.Parameters.AddWithValue("@PRODUCTO", Trim(PRODUCTOUNO1.Text))
        cmd.Parameters.AddWithValue("@CANTIDAD", Trim(CANTIDAD1.Text))
        cmd.Parameters.AddWithValue("@UNIDADMEDIDA", Trim(ID_UNIDADMEDIDA.Text))


        Dim dr As SqlDataReader
        Try
            conex.Open()
            dr = cmd.ExecuteReader()
            Do While dr.Read
            Loop
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TB_MASS_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        'Dim FILAPRODUCTO1 As Integer
        ''Dim row As DataGridViewRow = TB_MASS.Rows(e.RowIndex)
        'FILAPRODUCTO1 = row.Cells(4).Value
        'ID_DETALLE_OC.Visible = True
        'ID_DETALLE_OC.Enabled = False
        'ID_DETALLE_OC.Text = FILAPRODUCTO1
        'PictureBox2.Visible = True
    End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'CNM_COMPRAS_OC_PROCESO1
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "CNM_COMPRAS_OC_PROCESO1"
        Me.ResumeLayout(False)

    End Sub

    Private Sub CNM_COMPRAS_OC_PROCESO1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class