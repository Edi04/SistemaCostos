Imports System.Data.SqlClient

Public Class NProductos
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub


    'Maquinaria
    Private Sub BMaquina_Click(sender As Object, e As EventArgs) Handles BMaquina.Click
        If PAMaq.Visible = True Then
            PAMaq.Visible = False
        ElseIf PAMaq.Visible = False Then
            PAMaq.Visible = True

            PAMP.Visible = False
            PAMass.Visible = False
            PAAlmac.Visible = False
            MMedida()
            MCMarca()
        End If
    End Sub

    Dim MUMedida As New SqlCommand
    Dim MDTUMedida As DataTable
    Dim MDAUMedida As New SqlDataAdapter

    Dim MMarca As New SqlCommand
    Dim MDTMarca As DataTable
    Dim MDAMarca As New SqlDataAdapter

    Private Sub MMedida()
        With MUMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        MDAUMedida.SelectCommand = MUMedida
        MDTUMedida = New DataTable
        MDAUMedida.Fill(MDTUMedida)
        With CUMMa
            .DataSource = MDTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
    End Sub

    Private Sub MCMarca()
        With MMarca
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Marcas
                            WHERE Estado = 'AMaquin'
                            ORDER BY Marca ASC"
            .Connection = Conex
        End With

        MDAMarca.SelectCommand = MMarca
        MDTMarca = New DataTable
        MDAMarca.Fill(MDTMarca)
        With CMaMa
            .DataSource = MDTMarca
            .DisplayMember = "Marca"
            .ValueMember = "Id_Marca"
        End With
    End Sub

    Private Sub BMarcMa_Click(sender As Object, e As EventArgs) Handles BMarcMa.Click
        If PNMarca.Visible = False Then
            PNMarca.Visible = True

            TxtMarca.Text = ""
        ElseIf PNMarca.Visible = True Then
            PNMarca.Visible = False
        End If
    End Sub

    Private Sub BGNM_Click(sender As Object, e As EventArgs) Handles BGNM.Click
        If TxtMarca.Text = "" Then
            MessageBox.Show("Ingrese el Dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conex.Open()
                Dim M As String = TxtMarca.Text
                Dim CONSULTA As String = "INSERT INTO TB_Marcas
                                            (Marca, Estado)
                                        VALUES ('" & M & "', 'AMaquin' )"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()

                MCMarca()
                PNMarca.Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al Guardar", "ERROR", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub BGMa_Click(sender As Object, e As EventArgs) Handles BGMa.Click
        If TxtNPMa.Text = "" Then
            MessageBox.Show("Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            MDatos()
        End If
    End Sub

    Public Sub MDatos()
        Dim GDatos As New SqlCommand("SP_GCNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtCPMa.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNPMa.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", "")
        GDatos.Parameters.AddWithValue("@Minimo", "")
        GDatos.Parameters.AddWithValue("@Maximo ", "")
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(CUMMa.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", Trim(CMaMa.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Categoria", 3)
        GDatos.Parameters.AddWithValue("@Id_Area", 35)
        GDatos.Parameters.AddWithValue("@Id_Proceso", 49)
        GDatos.Parameters.AddWithValue("@Codigo_Barras", "")
        GDatos.Parameters.AddWithValue("@Imagen", "")
        GDatos.Parameters.AddWithValue("@Estado", "MaqActivo")
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()

            RData = GDatos.ExecuteReader()

            TxtCPMa.Text = ""
            TxtNPMa.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
        If OrdCompra.TextQuantity1.Text = "" And OrdCompra.TextUm1.Text = "" And OrdCompra.TextUnitPrice1.Text = "" Then
            OrdCompra.combo_productos1()
        End If

        If OrdCompra.TextQuantity2.Text = "" And OrdCompra.TextUm2.Text = "" And OrdCompra.TextUnitPrice2.Text = "" Then
            OrdCompra.combo_productos2()
        End If

        If OrdCompra.TextQuantity3.Text = "" And OrdCompra.TextUm3.Text = "" And OrdCompra.TextUnitPrice3.Text = "" Then
            OrdCompra.combo_productos3()
        End If

        If OrdCompra.TextQuantity4.Text = "" And OrdCompra.TextUm4.Text = "" And OrdCompra.TextUnitPrice4.Text = "" Then
            OrdCompra.combo_productos4()
        End If

        If OrdCompra.TextQuantity5.Text = "" And OrdCompra.TextUm5.Text = "" And OrdCompra.TextUnitPrice5.Text = "" Then
            OrdCompra.combo_productos5()
        End If

        If OrdCompra.TextQuantity6.Text = "" And OrdCompra.TextUm6.Text = "" And OrdCompra.TextUnitPrice6.Text = "" Then
            OrdCompra.combo_productos6()
        End If

        If OrdCompra.TextQuantity7.Text = "" And OrdCompra.TextUm7.Text = "" And OrdCompra.TextUnitPrice7.Text = "" Then
            OrdCompra.combo_productos7()
        End If

        If OrdCompra.TextQuantity8.Text = "" And OrdCompra.TextUm8.Text = "" And OrdCompra.TextUnitPrice8.Text = "" Then
            OrdCompra.combo_productos8()
        End If

        If OrdCompra.TextQuantity9.Text = "" And OrdCompra.TextUm9.Text = "" And OrdCompra.TextUnitPrice9.Text = "" Then
            OrdCompra.combo_productos9()
        End If

        If OrdCompra.TextQuantity10.Text = "" And OrdCompra.TextUm10.Text = "" And OrdCompra.TextUnitPrice10.Text = "" Then
            OrdCompra.combo_productos10()
        End If

        If OrdCompra.TextQuantity11.Text = "" And OrdCompra.TextUm11.Text = "" And OrdCompra.TextUnitPrice11.Text = "" Then
            OrdCompra.combo_productos11()
        End If

        If OrdCompra.TextQuantity12.Text = "" And OrdCompra.TextUm12.Text = "" And OrdCompra.TextUnitPrice12.Text = "" Then
            OrdCompra.combo_productos12()
        End If

        If OrdCompra.TextQuantity13.Text = "" And OrdCompra.TextUm13.Text = "" And OrdCompra.TextUnitPrice13.Text = "" Then
            OrdCompra.combo_productos13()
        End If

        If OrdCompra.TextQuantity14.Text = "" And OrdCompra.TextUm14.Text = "" And OrdCompra.TextUnitPrice14.Text = "" Then
            OrdCompra.combo_productos14()
        End If

        If OrdCompra.TextQuantity15.Text = "" And OrdCompra.TextUm15.Text = "" And OrdCompra.TextUnitPrice15.Text = "" Then
            OrdCompra.combo_productos15()
        End If

        If OrdCompra.TextQuantity16.Text = "" And OrdCompra.TextUm16.Text = "" And OrdCompra.TextUnitPrice16.Text = "" Then
            OrdCompra.combo_productos16()
        End If

        If OrdCompra.TextQuantity17.Text = "" And OrdCompra.TextUm17.Text = "" And OrdCompra.TextUnitPrice17.Text = "" Then
            OrdCompra.combo_productos17()
        End If

        If OrdCompra.TextQuantity18.Text = "" And OrdCompra.TextUm18.Text = "" And OrdCompra.TextUnitPrice18.Text = "" Then
            OrdCompra.combo_productos18()
        End If

        If OrdCompra.TextQuantity19.Text = "" And OrdCompra.TextUm19.Text = "" And OrdCompra.TextUnitPrice19.Text = "" Then
            OrdCompra.combo_productos19()
        End If

        If OrdCompra.TextQuantity20.Text = "" And OrdCompra.TextUm20.Text = "" And OrdCompra.TextUnitPrice20.Text = ""  Then
            OrdCompra.combo_productos20()
        End If
    End Sub



    'Materia Prima
    Private Sub BMPrim_Click(sender As Object, e As EventArgs) Handles BMPrim.Click
        If PAMP.Visible = True Then
            PAMP.Visible = False
        ElseIf PAMP.Visible = False Then
            PAMP.Visible = True

            PAMaq.Visible = False
            PAMass.Visible = False
            PAAlmac.Visible = False
            MaMedida()
            MaCMarca()
        End If
    End Sub

    Dim MaUMedida As New SqlCommand
    Dim MaDTUMedida As DataTable
    Dim MaDAUMedida As New SqlDataAdapter

    Dim MaMarca As New SqlCommand
    Dim MaDTMarca As DataTable
    Dim MaDAMarca As New SqlDataAdapter

    Private Sub MaMedida()
        With MaUMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        MaDAUMedida.SelectCommand = MaUMedida
        MaDTUMedida = New DataTable
        MaDAUMedida.Fill(MaDTUMedida)
        With CUMMP
            .DataSource = MaDTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
    End Sub

    Private Sub MaCMarca()
        With MaMarca
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Marcas
                            WHERE Estado = 'MPActivo'
                            ORDER BY Marca ASC"
            .Connection = Conex
        End With

        MaDAMarca.SelectCommand = MaMarca
        MaDTMarca = New DataTable
        MaDAMarca.Fill(MaDTMarca)
        With CMMP
            .DataSource = MaDTMarca
            .DisplayMember = "Marca"
            .ValueMember = "Id_Marca"
        End With
    End Sub

    Private Sub BNMMP_Click(sender As Object, e As EventArgs) Handles BNMMP.Click
        If PAMMP.Visible = False Then
            PAMMP.Visible = True

            TxtNMMP.Text = ""
        ElseIf PAMMP.Visible = True Then
            PAMMP.Visible = False
        End If
    End Sub

    Private Sub BGMMP_Click(sender As Object, e As EventArgs) Handles BGMMP.Click
        If TxtNMMP.Text = "" Then
            MessageBox.Show("Ingrese el Dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conex.Open()
                Dim M As String = TxtNMMP.Text
                Dim CONSULTA As String = "INSERT INTO TB_Marcas
                                            (Marca, Estado)
                                        VALUES ('" & M & "', 'MPActivo' )"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()

                MaCMarca()
                PAMMP.Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al Guardar", "ERROR", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub BGMP_Click(sender As Object, e As EventArgs) Handles BGMP.Click
        If TxtNPMP.Text = "" Then
            MessageBox.Show("Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            MPDatos()
        End If
    End Sub

    Public Sub MPDatos()
        Dim GDatos As New SqlCommand("SP_GCNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtCMMP.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNPMP.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", "")
        GDatos.Parameters.AddWithValue("@Minimo", "")
        GDatos.Parameters.AddWithValue("@Maximo ", "")
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(CUMMP.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", Trim(CMMP.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Categoria", 1)
        GDatos.Parameters.AddWithValue("@Id_Area", 35)
        GDatos.Parameters.AddWithValue("@Id_Proceso", 49)
        GDatos.Parameters.AddWithValue("@Codigo_Barras", "")
        GDatos.Parameters.AddWithValue("@Imagen", "")
        GDatos.Parameters.AddWithValue("@Estado", "MPActivo")
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()

            RData = GDatos.ExecuteReader()

            TxtCMMP.Text = ""
            TxtNPMP.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()

        If OrdCompra.TextQuantity1.Text = "" And OrdCompra.TextUm1.Text = "" And OrdCompra.TextUnitPrice1.Text = "" Then
            OrdCompra.combo_productos1()
        End If

        If OrdCompra.TextQuantity2.Text = "" And OrdCompra.TextUm2.Text = "" And OrdCompra.TextUnitPrice2.Text = "" Then
            OrdCompra.combo_productos2()
        End If

        If OrdCompra.TextQuantity3.Text = "" And OrdCompra.TextUm3.Text = "" And OrdCompra.TextUnitPrice3.Text = "" Then
            OrdCompra.combo_productos3()
        End If

        If OrdCompra.TextQuantity4.Text = "" And OrdCompra.TextUm4.Text = "" And OrdCompra.TextUnitPrice4.Text = "" Then
            OrdCompra.combo_productos4()
        End If

        If OrdCompra.TextQuantity5.Text = "" And OrdCompra.TextUm5.Text = "" And OrdCompra.TextUnitPrice5.Text = "" Then
            OrdCompra.combo_productos5()
        End If

        If OrdCompra.TextQuantity6.Text = "" And OrdCompra.TextUm6.Text = "" And OrdCompra.TextUnitPrice6.Text = "" Then
            OrdCompra.combo_productos6()
        End If

        If OrdCompra.TextQuantity7.Text = "" And OrdCompra.TextUm7.Text = "" And OrdCompra.TextUnitPrice7.Text = "" Then
            OrdCompra.combo_productos7()
        End If

        If OrdCompra.TextQuantity8.Text = "" And OrdCompra.TextUm8.Text = "" And OrdCompra.TextUnitPrice8.Text = "" Then
            OrdCompra.combo_productos8()
        End If

        If OrdCompra.TextQuantity9.Text = "" And OrdCompra.TextUm9.Text = "" And OrdCompra.TextUnitPrice9.Text = "" Then
            OrdCompra.combo_productos9()
        End If

        If OrdCompra.TextQuantity10.Text = "" And OrdCompra.TextUm10.Text = "" And OrdCompra.TextUnitPrice10.Text = "" Then
            OrdCompra.combo_productos10()
        End If

        If OrdCompra.TextQuantity11.Text = "" And OrdCompra.TextUm11.Text = "" And OrdCompra.TextUnitPrice11.Text = "" Then
            OrdCompra.combo_productos11()
        End If

        If OrdCompra.TextQuantity12.Text = "" And OrdCompra.TextUm12.Text = "" And OrdCompra.TextUnitPrice12.Text = "" Then
            OrdCompra.combo_productos12()
        End If

        If OrdCompra.TextQuantity13.Text = "" And OrdCompra.TextUm13.Text = "" And OrdCompra.TextUnitPrice13.Text = "" Then
            OrdCompra.combo_productos13()
        End If

        If OrdCompra.TextQuantity14.Text = "" And OrdCompra.TextUm14.Text = "" And OrdCompra.TextUnitPrice14.Text = "" Then
            OrdCompra.combo_productos14()
        End If

        If OrdCompra.TextQuantity15.Text = "" And OrdCompra.TextUm15.Text = "" And OrdCompra.TextUnitPrice15.Text = "" Then
            OrdCompra.combo_productos15()
        End If

        If OrdCompra.TextQuantity16.Text = "" And OrdCompra.TextUm16.Text = "" And OrdCompra.TextUnitPrice16.Text = "" Then
            OrdCompra.combo_productos16()
        End If

        If OrdCompra.TextQuantity17.Text = "" And OrdCompra.TextUm17.Text = "" And OrdCompra.TextUnitPrice17.Text = "" Then
            OrdCompra.combo_productos17()
        End If

        If OrdCompra.TextQuantity18.Text = "" And OrdCompra.TextUm18.Text = "" And OrdCompra.TextUnitPrice18.Text = "" Then
            OrdCompra.combo_productos18()
        End If

        If OrdCompra.TextQuantity19.Text = "" And OrdCompra.TextUm19.Text = "" And OrdCompra.TextUnitPrice19.Text = "" Then
            OrdCompra.combo_productos19()
        End If

        If OrdCompra.TextQuantity20.Text = "" And OrdCompra.TextUm20.Text = "" And OrdCompra.TextUnitPrice20.Text = "" Then
            OrdCompra.combo_productos20()
        End If
    End Sub



    'Mass
    Private Sub BMasD_Click(sender As Object, e As EventArgs) Handles BMas.Click
        If PAMass.Visible = True Then
            PAMass.Visible = False
        ElseIf PAMass.Visible = False Then
            PAMass.Visible = True

            PAMaq.Visible = False
            PAMP.Visible = False
            PAAlmac.Visible = False
            MasMedida()
            MasCMarca()
        End If
    End Sub

    Dim MasUMedida As New SqlCommand
    Dim MasDTUMedida As DataTable
    Dim MasDAUMedida As New SqlDataAdapter

    Dim MasMarca As New SqlCommand
    Dim MasDTMarca As DataTable
    Dim MasDAMarca As New SqlDataAdapter


    Private Sub MasMedida()
        With MasUMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        MasDAUMedida.SelectCommand = MasUMedida
        MasDTUMedida = New DataTable
        MasDAUMedida.Fill(MasDTUMedida)
        With CMedidaM
            .DataSource = MasDTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
    End Sub

    Private Sub MasCMarca()
        With MasMarca
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Marcas
                            WHERE Estado = 'AMass'
                            ORDER BY Marca ASC"
            .Connection = Conex
        End With

        MasDAMarca.SelectCommand = MasMarca
        MasDTMarca = New DataTable
        MasDAMarca.Fill(MasDTMarca)
        With CMaM
            .DataSource = MasDTMarca
            .DisplayMember = "Marca"
            .ValueMember = "Id_Marca"
        End With
    End Sub

    Private Sub BAMar_Click(sender As Object, e As EventArgs) Handles BAMar.Click
        If PAMMA.Visible = False Then
            PAMMA.Visible = True

            TxtAMarcaM.Text = ""
        ElseIf PAMMA.Visible = True Then
            PAMMA.Visible = False
        End If
    End Sub

    Private Sub BGAMA_Click(sender As Object, e As EventArgs) Handles BGAMA.Click
        If TxtAMarcaM.Text = "" Then
            MessageBox.Show("Ingrese el Dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conex.Open()
                Dim M As String = TxtAMarcaM.Text
                Dim CONSULTA As String = "INSERT INTO TB_Marcas
                                            (Marca, Estado)
                                        VALUES ('" & M & "', 'AMass' )"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()

                MasCMarca()
                PAMMA.Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al Guardar", "ERROR", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub BGuardarMoM_Click(sender As Object, e As EventArgs) Handles BGuardarMoM.Click
        If TxtNPM.Text = "" Then
            MessageBox.Show("Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            MsDatos()
        End If

    End Sub

    Public Sub MsDatos()
        Dim GDatos As New SqlCommand("SP_GCNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtCPM.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNPM.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", "")
        GDatos.Parameters.AddWithValue("@Minimo", "")
        GDatos.Parameters.AddWithValue("@Maximo ", "")
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(CMedidaM.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", Trim(CMaM.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Categoria", 5)
        GDatos.Parameters.AddWithValue("@Id_Area", 24)
        GDatos.Parameters.AddWithValue("@Id_Proceso", 39)
        GDatos.Parameters.AddWithValue("@Codigo_Barras", "")
        GDatos.Parameters.AddWithValue("@Imagen", "")
        GDatos.Parameters.AddWithValue("@Estado", "AMass")
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()

            RData = GDatos.ExecuteReader()

            TxtCPM.Text = ""
            TxtNPM.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()

        If OrdCompra.TextQuantity1.Text = "" And OrdCompra.TextUm1.Text = "" And OrdCompra.TextUnitPrice1.Text = "" Then
            OrdCompra.combo_productos1()
        End If

        If OrdCompra.TextQuantity2.Text = "" And OrdCompra.TextUm2.Text = "" And OrdCompra.TextUnitPrice2.Text = "" Then
            OrdCompra.combo_productos2()
        End If

        If OrdCompra.TextQuantity3.Text = "" And OrdCompra.TextUm3.Text = "" And OrdCompra.TextUnitPrice3.Text = "" Then
            OrdCompra.combo_productos3()
        End If

        If OrdCompra.TextQuantity4.Text = "" And OrdCompra.TextUm4.Text = "" And OrdCompra.TextUnitPrice4.Text = "" Then
            OrdCompra.combo_productos4()
        End If

        If OrdCompra.TextQuantity5.Text = "" And OrdCompra.TextUm5.Text = "" And OrdCompra.TextUnitPrice5.Text = "" Then
            OrdCompra.combo_productos5()
        End If

        If OrdCompra.TextQuantity6.Text = "" And OrdCompra.TextUm6.Text = "" And OrdCompra.TextUnitPrice6.Text = "" Then
            OrdCompra.combo_productos6()
        End If

        If OrdCompra.TextQuantity7.Text = "" And OrdCompra.TextUm7.Text = "" And OrdCompra.TextUnitPrice7.Text = "" Then
            OrdCompra.combo_productos7()
        End If

        If OrdCompra.TextQuantity8.Text = "" And OrdCompra.TextUm8.Text = "" And OrdCompra.TextUnitPrice8.Text = "" Then
            OrdCompra.combo_productos8()
        End If

        If OrdCompra.TextQuantity9.Text = "" And OrdCompra.TextUm9.Text = "" And OrdCompra.TextUnitPrice9.Text = "" Then
            OrdCompra.combo_productos9()
        End If

        If OrdCompra.TextQuantity10.Text = "" And OrdCompra.TextUm10.Text = "" And OrdCompra.TextUnitPrice10.Text = "" Then
            OrdCompra.combo_productos10()
        End If

        If OrdCompra.TextQuantity11.Text = "" And OrdCompra.TextUm11.Text = "" And OrdCompra.TextUnitPrice11.Text = "" Then
            OrdCompra.combo_productos11()
        End If

        If OrdCompra.TextQuantity12.Text = "" And OrdCompra.TextUm12.Text = "" And OrdCompra.TextUnitPrice12.Text = "" Then
            OrdCompra.combo_productos12()
        End If

        If OrdCompra.TextQuantity13.Text = "" And OrdCompra.TextUm13.Text = "" And OrdCompra.TextUnitPrice13.Text = "" Then
            OrdCompra.combo_productos13()
        End If

        If OrdCompra.TextQuantity14.Text = "" And OrdCompra.TextUm14.Text = "" And OrdCompra.TextUnitPrice14.Text = "" Then
            OrdCompra.combo_productos14()
        End If

        If OrdCompra.TextQuantity15.Text = "" And OrdCompra.TextUm15.Text = "" And OrdCompra.TextUnitPrice15.Text = "" Then
            OrdCompra.combo_productos15()
        End If

        If OrdCompra.TextQuantity16.Text = "" And OrdCompra.TextUm16.Text = "" And OrdCompra.TextUnitPrice16.Text = "" Then
            OrdCompra.combo_productos16()
        End If

        If OrdCompra.TextQuantity17.Text = "" And OrdCompra.TextUm17.Text = "" And OrdCompra.TextUnitPrice17.Text = "" Then
            OrdCompra.combo_productos17()
        End If

        If OrdCompra.TextQuantity18.Text = "" And OrdCompra.TextUm18.Text = "" And OrdCompra.TextUnitPrice18.Text = "" Then
            OrdCompra.combo_productos18()
        End If

        If OrdCompra.TextQuantity19.Text = "" And OrdCompra.TextUm19.Text = "" And OrdCompra.TextUnitPrice19.Text = "" Then
            OrdCompra.combo_productos19()
        End If

        If OrdCompra.TextQuantity20.Text = "" And OrdCompra.TextUm20.Text = "" And OrdCompra.TextUnitPrice20.Text = "" Then
            OrdCompra.combo_productos20()
        End If
    End Sub


    'Almacen
    Private Sub BAlma_Click(sender As Object, e As EventArgs) Handles BAlma.Click
        If PAAlmac.Visible = True Then
            PAAlmac.Visible = False
        ElseIf PAAlmac.Visible = False Then
            PAAlmac.Visible = True

            PAMaq.Visible = False
            PAMP.Visible = False
            PAMass.Visible = False
            AMMMedida()
            AMCMarca()
            Other()
        End If
    End Sub

    Dim AMUMedida As New SqlCommand
    Dim AMDTUMedida As DataTable
    Dim AMDAUMedida As New SqlDataAdapter

    Dim AMMarca As New SqlCommand
    Dim AMDTMarca As DataTable
    Dim AMDAMarca As New SqlDataAdapter

    Dim Area As New SqlCommand
    Dim DTArea As DataTable
    Dim DAArea As New SqlDataAdapter

    Dim Categoria As New SqlCommand
    Dim DTCategoria As DataTable
    Dim DACategoria As New SqlDataAdapter

    Dim Proceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub AMMMedida()
        With AMUMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        AMDAUMedida.SelectCommand = AMUMedida
        AMDTUMedida = New DataTable
        AMDAUMedida.Fill(AMDTUMedida)
        With CBUMedida
            .DataSource = AMDTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
    End Sub

    Private Sub AMCMarca()
        With AMMarca
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Marcas
                            WHERE Estado = 'Activo'
                            ORDER BY Marca ASC"
            .Connection = Conex
        End With

        AMDAMarca.SelectCommand = AMMarca
        AMDTMarca = New DataTable
        AMDAMarca.Fill(AMDTMarca)
        With CMarca
            .DataSource = AMDTMarca
            .DisplayMember = "Marca"
            .ValueMember = "Id_Marca"
        End With
    End Sub

    Private Sub Other()
        With Area
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Areas
                            WHERE Estado = 'Activo'
                            ORDER BY Area ASC"
            .Connection = Conex
        End With

        DAArea.SelectCommand = Area
        DTArea = New DataTable
        DAArea.Fill(DTArea)
        With CBArea
            .DataSource = DTArea
            .DisplayMember = "Area"
            .ValueMember = "Id_Area"
        End With

        '/////////////
        With Categoria
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Categorias
                            WHERE Estado = 'Activo'
                            ORDER BY Categoria ASC"
            .Connection = Conex
        End With

        DACategoria.SelectCommand = Categoria
        DTCategoria = New DataTable
        DACategoria.Fill(DTCategoria)
        With CBCategoria
            .DataSource = DTCategoria
            .DisplayMember = "Categoria"
            .ValueMember = "Id_Categoria"
        End With

        '///////////
        With Proceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = Proceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With CBProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub

    Private Sub BNMarca_Click(sender As Object, e As EventArgs) Handles BNMarca.Click
        If PAMA.Visible = False Then
            PAMA.Visible = True

            TxtNMA.Text = ""
        ElseIf PAMA.Visible = True Then
            PAMA.Visible = False
        End If
    End Sub

    Private Sub BNMA_Click(sender As Object, e As EventArgs) Handles BNMA.Click
        If TxtNMA.Text = "" Then
            MessageBox.Show("Ingrese el Dato", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Conex.Open()
                Dim M As String = TxtNMA.Text
                Dim CONSULTA As String = "INSERT INTO TB_Marcas
                                            (Marca, Estado)
                                        VALUES ('" & M & "', 'Activo' )"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()

                AMCMarca()
                PAMA.Visible = False
            Catch ex As Exception
                MessageBox.Show("Error al Guardar", "ERROR", MessageBoxButtons.OK)
            End Try
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If TxtNombreP.Text = "" Then
            MessageBox.Show("Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            AMDatos()
        End If
    End Sub

    Public Sub AMDatos()
        Dim GDatos As New SqlCommand("SP_GNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TxtClaveP.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TxtNombreP.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", "")
        GDatos.Parameters.AddWithValue("@Minimo", "")
        GDatos.Parameters.AddWithValue("@Maximo ", "")
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(CBUMedida.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", Trim(CMarca.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Categoria", Trim(CBCategoria.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Area", Trim(CBArea.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Proceso", Trim(CBProceso.SelectedValue))
        GDatos.Parameters.AddWithValue("@Codigo_Barras", "")
        GDatos.Parameters.AddWithValue("@Imagen", "")
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()

            RData = GDatos.ExecuteReader()

            TxtClaveP.Text = ""
            TxtNombreP.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()

        If OrdCompra.TextQuantity1.Text = "" And OrdCompra.TextUm1.Text = "" And OrdCompra.TextUnitPrice1.Text = "" Then
            OrdCompra.combo_productos1()
        End If

        If OrdCompra.TextQuantity2.Text = "" And OrdCompra.TextUm2.Text = "" And OrdCompra.TextUnitPrice2.Text = "" Then
            OrdCompra.combo_productos2()
        End If

        If OrdCompra.TextQuantity3.Text = "" And OrdCompra.TextUm3.Text = "" And OrdCompra.TextUnitPrice3.Text = "" Then
            OrdCompra.combo_productos3()
        End If

        If OrdCompra.TextQuantity4.Text = "" And OrdCompra.TextUm4.Text = "" And OrdCompra.TextUnitPrice4.Text = "" Then
            OrdCompra.combo_productos4()
        End If

        If OrdCompra.TextQuantity5.Text = "" And OrdCompra.TextUm5.Text = "" And OrdCompra.TextUnitPrice5.Text = "" Then
            OrdCompra.combo_productos5()
        End If

        If OrdCompra.TextQuantity6.Text = "" And OrdCompra.TextUm6.Text = "" And OrdCompra.TextUnitPrice6.Text = "" Then
            OrdCompra.combo_productos6()
        End If

        If OrdCompra.TextQuantity7.Text = "" And OrdCompra.TextUm7.Text = "" And OrdCompra.TextUnitPrice7.Text = "" Then
            OrdCompra.combo_productos7()
        End If

        If OrdCompra.TextQuantity8.Text = "" And OrdCompra.TextUm8.Text = "" And OrdCompra.TextUnitPrice8.Text = "" Then
            OrdCompra.combo_productos8()
        End If

        If OrdCompra.TextQuantity9.Text = "" And OrdCompra.TextUm9.Text = "" And OrdCompra.TextUnitPrice9.Text = "" Then
            OrdCompra.combo_productos9()
        End If

        If OrdCompra.TextQuantity10.Text = "" And OrdCompra.TextUm10.Text = "" And OrdCompra.TextUnitPrice10.Text = "" Then
            OrdCompra.combo_productos10()
        End If

        If OrdCompra.TextQuantity11.Text = "" And OrdCompra.TextUm11.Text = "" And OrdCompra.TextUnitPrice11.Text = "" Then
            OrdCompra.combo_productos11()
        End If

        If OrdCompra.TextQuantity12.Text = "" And OrdCompra.TextUm12.Text = "" And OrdCompra.TextUnitPrice12.Text = "" Then
            OrdCompra.combo_productos12()
        End If

        If OrdCompra.TextQuantity13.Text = "" And OrdCompra.TextUm13.Text = "" And OrdCompra.TextUnitPrice13.Text = "" Then
            OrdCompra.combo_productos13()
        End If

        If OrdCompra.TextQuantity14.Text = "" And OrdCompra.TextUm14.Text = "" And OrdCompra.TextUnitPrice14.Text = "" Then
            OrdCompra.combo_productos14()
        End If

        If OrdCompra.TextQuantity15.Text = "" And OrdCompra.TextUm15.Text = "" And OrdCompra.TextUnitPrice15.Text = "" Then
            OrdCompra.combo_productos15()
        End If

        If OrdCompra.TextQuantity16.Text = "" And OrdCompra.TextUm16.Text = "" And OrdCompra.TextUnitPrice16.Text = "" Then
            OrdCompra.combo_productos16()
        End If

        If OrdCompra.TextQuantity17.Text = "" And OrdCompra.TextUm17.Text = "" And OrdCompra.TextUnitPrice17.Text = "" Then
            OrdCompra.combo_productos17()
        End If

        If OrdCompra.TextQuantity18.Text = "" And OrdCompra.TextUm18.Text = "" And OrdCompra.TextUnitPrice18.Text = "" Then
            OrdCompra.combo_productos18()
        End If

        If OrdCompra.TextQuantity19.Text = "" And OrdCompra.TextUm19.Text = "" And OrdCompra.TextUnitPrice19.Text = "" Then
            OrdCompra.combo_productos19()
        End If

        If OrdCompra.TextQuantity20.Text = "" And OrdCompra.TextUm20.Text = "" And OrdCompra.TextUnitPrice20.Text = "" Then
            OrdCompra.combo_productos20()
        End If
    End Sub

    'Herraje
    Private Sub BBH_Click(sender As Object, e As EventArgs) Handles BBH.Click
        If Panel3.Visible = True Then
            Panel3.Visible = False
        ElseIf Panel3.Visible = False Then
            Panel3.Visible = True

            PAMaq.Visible = False
            PAMP.Visible = False
            PAMass.Visible = False
            PAAlmac.Visible = False

            HMMMedida()
            HOther()
        End If
    End Sub

    Dim HMUMedida As New SqlCommand
    Dim HMDTUMedida As DataTable
    Dim HMDAUMedida As New SqlDataAdapter

    Dim HMMarca As New SqlCommand
    Dim HMDTMarca As DataTable
    Dim HMDAMarca As New SqlDataAdapter

    Dim HArea As New SqlCommand
    Dim HDTArea As DataTable
    Dim HDAArea As New SqlDataAdapter

    Dim HCategoria As New SqlCommand
    Dim HDTCategoria As DataTable
    Dim HDACategoria As New SqlDataAdapter

    Dim HProceso As New SqlCommand
    Dim HDTProceso As DataTable
    Dim HDAProceso As New SqlDataAdapter

    Private Sub HMMMedida()
        With AMUMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        AMDAUMedida.SelectCommand = AMUMedida
        AMDTUMedida = New DataTable
        AMDAUMedida.Fill(AMDTUMedida)
        With ComboBox5
            .DataSource = AMDTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
    End Sub

    Private Sub HOther()
        With Area
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Areas
                            WHERE Estado = 'Activo'
                            ORDER BY Area ASC"
            .Connection = Conex
        End With

        DAArea.SelectCommand = Area
        DTArea = New DataTable
        DAArea.Fill(DTArea)
        With ComboBox1
            .DataSource = DTArea
            .DisplayMember = "Area"
            .ValueMember = "Id_Area"
        End With

        '/////////////
        With Categoria
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Categorias
                            WHERE Estado = 'Activo'
                            ORDER BY Categoria ASC"
            .Connection = Conex
        End With

        DACategoria.SelectCommand = Categoria
        DTCategoria = New DataTable
        DACategoria.Fill(DTCategoria)
        With ComboBox2
            .DataSource = DTCategoria
            .DisplayMember = "Categoria"
            .ValueMember = "Id_Categoria"
        End With

        '///////////
        With Proceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = Proceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With ComboBox3
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox2.Text = "" Then
            MessageBox.Show("Ingrese los Datos", "Advertencia", MessageBoxButtons.OK)
        Else
            HMDatos()
        End If
    End Sub

    Public Sub HMDatos()

        Dim GDatos As New SqlCommand("SP_GCNuevo_Producto", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Clave_Producto", UCase(Trim(TextBox3.Text)))
        GDatos.Parameters.AddWithValue("@Nombre_Producto", UCase(Trim(TextBox2.Text)))
        GDatos.Parameters.AddWithValue("@Descripcion", "")
        GDatos.Parameters.AddWithValue("@Minimo", "")
        GDatos.Parameters.AddWithValue("@Maximo ", "")
        GDatos.Parameters.AddWithValue("@Id_Medida", Trim(ComboBox5.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Marca", 1)
        GDatos.Parameters.AddWithValue("@Id_Categoria", Trim(ComboBox2.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Area", Trim(ComboBox1.SelectedValue))
        GDatos.Parameters.AddWithValue("@Id_Proceso", Trim(ComboBox3.SelectedValue))
        GDatos.Parameters.AddWithValue("@Codigo_Barras", "")
        GDatos.Parameters.AddWithValue("@Imagen", "")
        GDatos.Parameters.AddWithValue("@Estado", "AArmado")
        GDatos.Parameters.AddWithValue("@Created", DateA)


        Dim RData As SqlDataReader
        Try
            Conex.Open()

            RData = GDatos.ExecuteReader()

            TextBox3.Text = ""
            TextBox2.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()

        If OrdCompra.TextQuantity1.Text = "" And OrdCompra.TextUm1.Text = "" And OrdCompra.TextUnitPrice1.Text = "" Then
            OrdCompra.combo_productos1()
        End If

        If OrdCompra.TextQuantity2.Text = "" And OrdCompra.TextUm2.Text = "" And OrdCompra.TextUnitPrice2.Text = "" Then
            OrdCompra.combo_productos2()
        End If

        If OrdCompra.TextQuantity3.Text = "" And OrdCompra.TextUm3.Text = "" And OrdCompra.TextUnitPrice3.Text = "" Then
            OrdCompra.combo_productos3()
        End If

        If OrdCompra.TextQuantity4.Text = "" And OrdCompra.TextUm4.Text = "" And OrdCompra.TextUnitPrice4.Text = "" Then
            OrdCompra.combo_productos4()
        End If

        If OrdCompra.TextQuantity5.Text = "" And OrdCompra.TextUm5.Text = "" And OrdCompra.TextUnitPrice5.Text = "" Then
            OrdCompra.combo_productos5()
        End If

        If OrdCompra.TextQuantity6.Text = "" And OrdCompra.TextUm6.Text = "" And OrdCompra.TextUnitPrice6.Text = "" Then
            OrdCompra.combo_productos6()
        End If

        If OrdCompra.TextQuantity7.Text = "" And OrdCompra.TextUm7.Text = "" And OrdCompra.TextUnitPrice7.Text = "" Then
            OrdCompra.combo_productos7()
        End If

        If OrdCompra.TextQuantity8.Text = "" And OrdCompra.TextUm8.Text = "" And OrdCompra.TextUnitPrice8.Text = "" Then
            OrdCompra.combo_productos8()
        End If

        If OrdCompra.TextQuantity9.Text = "" And OrdCompra.TextUm9.Text = "" And OrdCompra.TextUnitPrice9.Text = "" Then
            OrdCompra.combo_productos9()
        End If

        If OrdCompra.TextQuantity10.Text = "" And OrdCompra.TextUm10.Text = "" And OrdCompra.TextUnitPrice10.Text = "" Then
            OrdCompra.combo_productos10()
        End If

        If OrdCompra.TextQuantity11.Text = "" And OrdCompra.TextUm11.Text = "" And OrdCompra.TextUnitPrice11.Text = "" Then
            OrdCompra.combo_productos11()
        End If

        If OrdCompra.TextQuantity12.Text = "" And OrdCompra.TextUm12.Text = "" And OrdCompra.TextUnitPrice12.Text = "" Then
            OrdCompra.combo_productos12()
        End If

        If OrdCompra.TextQuantity13.Text = "" And OrdCompra.TextUm13.Text = "" And OrdCompra.TextUnitPrice13.Text = "" Then
            OrdCompra.combo_productos13()
        End If

        If OrdCompra.TextQuantity14.Text = "" And OrdCompra.TextUm14.Text = "" And OrdCompra.TextUnitPrice14.Text = "" Then
            OrdCompra.combo_productos14()
        End If

        If OrdCompra.TextQuantity15.Text = "" And OrdCompra.TextUm15.Text = "" And OrdCompra.TextUnitPrice15.Text = "" Then
            OrdCompra.combo_productos15()
        End If

        If OrdCompra.TextQuantity16.Text = "" And OrdCompra.TextUm16.Text = "" And OrdCompra.TextUnitPrice16.Text = "" Then
            OrdCompra.combo_productos16()
        End If

        If OrdCompra.TextQuantity17.Text = "" And OrdCompra.TextUm17.Text = "" And OrdCompra.TextUnitPrice17.Text = "" Then
            OrdCompra.combo_productos17()
        End If

        If OrdCompra.TextQuantity18.Text = "" And OrdCompra.TextUm18.Text = "" And OrdCompra.TextUnitPrice18.Text = "" Then
            OrdCompra.combo_productos18()
        End If

        If OrdCompra.TextQuantity19.Text = "" And OrdCompra.TextUm19.Text = "" And OrdCompra.TextUnitPrice19.Text = "" Then
            OrdCompra.combo_productos19()
        End If

        If OrdCompra.TextQuantity20.Text = "" And OrdCompra.TextUm20.Text = "" And OrdCompra.TextUnitPrice20.Text = "" Then
            OrdCompra.combo_productos20()
        End If
    End Sub


    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class