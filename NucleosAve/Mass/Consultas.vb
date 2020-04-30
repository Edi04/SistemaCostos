Imports System.Data.SqlClient

Public Class Consultas
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Dim Proceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LFec.Text = Date.Now.ToLongDateString
        LHo.Text = DateTime.Now.ToShortTimeString
        Procesos()
        Codigo()
        Nombres()
    End Sub


    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BBTrabajador_Click(sender As Object, e As EventArgs) Handles BBTrabajador.Click
        If PTrabajador.Visible = False Then
            DatosGVT()
            PTrabajador.Visible = True
            ANuevoT.Visible = True
        Else
            If PTrabajador.Visible = True Then
                PTrabajador.Visible = False
                ANuevoT.Visible = False
            End If
        End If
    End Sub

    Private Sub ANuevoT_Click(sender As Object, e As EventArgs) Handles ANuevoT.Click
        PNT.Visible = True
        PTrabajador.Visible = False
        TxtNNN.Text = ""
        TxtNombre.Text = ""
        TxtAP.Text = ""
        TxtAM.Text = ""
    End Sub

    Private Sub BGNT_Click(sender As Object, e As EventArgs) Handles BGNT.Click
        If MsgBox("Desea Guardar la Información: " & TxtNNN.Text & " " & TxtNombre.Text & " " & TxtAP.Text & " " & TxtAM.Text, vbYesNo) = vbYes Then
            If TxtNombre.Text = "" Or TxtAP.Text = "" Or TxtAM.Text = "" Then
                MessageBox.Show("Ingrese el Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosNT()
            End If
        End If
    End Sub

    Private Sub BB1_Click(sender As Object, e As EventArgs) Handles BB1.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "1"
            TxtBMaterial.Text = TextM1.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = TextM1.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "1"
            M()
        End If
    End Sub

    Private Sub BB2_Click(sender As Object, e As EventArgs) Handles BB2.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "2"
            TxtBMaterial.Text = TextM2.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = TextM2.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "2"
            M()
        End If
    End Sub

    Private Sub BB3_Click(sender As Object, e As EventArgs) Handles BB3.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "3"
            TxtBMaterial.Text = TextM3.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = TextM3.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "3"
            M()
        End If
    End Sub

    Private Sub BB4_Click(sender As Object, e As EventArgs) Handles BB4.Click
        If PMaterial.Visible = True And LDGP.Text <> "" Then
            LDGP.Text = "4"
            TxtBMaterial.Text = TextM4.Text
        ElseIf PMaterial.Visible = True Then
            PMaterial.Visible = False
            LDGP.Text = ""
            TxtBMaterial.Text = TextM4.Text
        ElseIf PMaterial.Visible = False Then
            PMaterial.Visible = True
            LDGP.Text = "4"
            M()
        End If
    End Sub

    Private Sub BRNT_Click(sender As Object, e As EventArgs) Handles BRNT.Click
        PNT.Visible = False
        PTrabajador.Visible = True
    End Sub

    Private Sub BE1_Click(sender As Object, e As EventArgs) Handles BE1.Click
        TextM1.Text = ""
        IDP1.Text = ""
        LA1.Visible = False
        LUM1.Text = ""
        BE1.Visible = False
    End Sub

    Private Sub BE2_Click(sender As Object, e As EventArgs) Handles BE2.Click
        TextM2.Text = ""
        IDP2.Text = ""
        LA2.Visible = False
        LUM2.Text = ""
        BE2.Visible = False
    End Sub

    Private Sub BE3_Click(sender As Object, e As EventArgs) Handles BE3.Click
        TextM3.Text = ""
        IDP3.Text = ""
        LA3.Visible = False
        LUM3.Text = ""
        BE3.Visible = False
    End Sub

    Private Sub BE4_Click(sender As Object, e As EventArgs) Handles BE4.Click
        TextM4.Text = ""
        IDP4.Text = ""
        LA4.Visible = False
        BE4.Visible = False
        LUM4.Text = ""
    End Sub

    Private Sub BCM_Click(sender As Object, e As EventArgs) Handles BCM.Click
        PMaterial.Visible = False
    End Sub


    Private Sub DGTrabajador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTrabajador.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim NN As String
        Dim NNS As String
        Dim Aler As String
        Dim row As DataGridViewRow = DGTrabajador.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDE.Text = FilaID

        NN = row.Cells(1).Value
        TxtNN.Text = NN

        FilaP = row.Cells(2).Value
        TxtTrabajador.Text = FilaP

        NNS = row.Cells(3).Value
        If NNS <> "" Then
            TxtNNN.Text = NNS
        Else
            TxtNNN.Text = ""
        End If

        Aler = row.Cells(4).Value
        If Aler <> "" Then
            TxtAlergias.Text = Aler
        Else
            TxtAlergias.ReadOnly = False
            TxtAlergias.BackColor = Color.White
        End If

        PTrabajador.Visible = False
        ANuevoT.Visible = False
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim row As DataGridViewRow = DGProducto.Rows(e.RowIndex)

        If LDGP.Text = "1" Then
            FilaID = row.Cells(0).Value
            IDP1.Text = FilaID

            FilaP = row.Cells(1).Value
            TextM1.Text = FilaP

            BP1()

            BE1.Visible = True
            PMaterial.Visible = False
            TxtCE1.ReadOnly = False

        ElseIf LDGP.Text = "2" Then
            FilaID = row.Cells(0).Value
            IDP2.Text = FilaID

            FilaP = row.Cells(1).Value
            TextM2.Text = FilaP

            BP2()

            BE2.Visible = True
            PMaterial.Visible = False
            TxtCE2.ReadOnly = False

        ElseIf LDGP.Text = "3" Then
            FilaID = row.Cells(0).Value
            IDP3.Text = FilaID

            FilaP = row.Cells(1).Value
            TextM3.Text = FilaP

            BP3()

            BE3.Visible = True
            PMaterial.Visible = False
            TxtCE3.ReadOnly = False

        ElseIf LDGP.Text = "4" Then
            FilaID = row.Cells(0).Value
            IDP4.Text = FilaID

            FilaP = row.Cells(1).Value
            TextM4.Text = FilaP

            BP4()

            BE4.Visible = True
            PMaterial.Visible = False
            TxtCE4.ReadOnly = False
        End If
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGEntrega.Click
        If MsgBox("Desea Guardar la Información de la Consulta", vbYesNo) = vbYes Then
            Datos()
        End If
    End Sub

    Private Sub BNuevaC_Click(sender As Object, e As EventArgs) Handles BNuevaC.Click
        LFec.Text = Date.Now.ToLongDateString
        LHo.Text = DateTime.Now.ToShortTimeString
        Codigo()
        DT()
    End Sub

    Private Sub TxtBusT_TextChanged(sender As Object, e As EventArgs) Handles TxtBusT.TextChanged
        ConDTra()
    End Sub

    Private Sub TxtBMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtBMaterial.TextChanged
        If TxtBMaterial.Text = "" Then
            M()
        Else
            Dim Consulta As String = "SELECT P.Id_Producto, P.Nombre_Producto, P.Existencia, M.Medida
                                      FROM TB_Productos AS P
                                           LEFT JOIN TB_Medidas AS M ON M.Id_Medida = P.Id_Medida 
                                      WHERE (P.Nombre_Producto LIKE '%'+@Busqueda+'%') AND
                                             P.Estado = 'AMass' AND 
		                                P.Nombre_Producto NOT LIKE '%MANTENIMIENTO%' AND 
		                                P.Nombre_Producto NOT LIKE '%Señalamiento%' AND 
		                                P.Nombre_Producto NOT LIKE '%NOM-%' AND
		                                P.Nombre_Producto NOT LIKE '%CURSO%' AND 
		                                P.Nombre_Producto NOT LIKE '%CAPACITACION%' AND 
		                                P.Nombre_Producto NOT LIKE '%SERVICIO%' AND 
		                                P.Nombre_Producto NOT LIKE '%EXTINTOR%' AND
		                                P.Id_Marca <> 52  AND
                                        P.Existencia > 0
                                   ORDER BY Nombre_Producto ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBMaterial.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DGProducto.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub


    Public Sub DatosNT()
        Dim GDatos As New SqlCommand("SP_NTrabajador", Conex)

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@NNomina", Trim(TxtNNN.Text))
        GDatos.Parameters.AddWithValue("@Nombre", Trim(TxtNombre.Text))
        GDatos.Parameters.AddWithValue("@APaterno", Trim(TxtAP.Text))
        GDatos.Parameters.AddWithValue("@AMaterno", Trim(TxtAM.Text))

        Try
            Conex.Open()
            GDatos.ExecuteReader()
            PNT.Visible = False
            PTrabajador.Visible = True

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
        TxtBusT.Text = TxtNombre.Text
    End Sub

    Private Sub Procesos()
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
        With CProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub

    Private Sub DatosGVT()
        Dim Consulta As String = "Select Id_Empleado, Numero_Nomina, (Nombre_Empleado + ' ' + Ape_Paterno + ' ' + Ape_Materno) As Nombre, NNS, Alerg_Enfe
                                  FROM TB_Empleados
                                  WHERE Estado = 'Activo'
                                  ORDER BY Numero_Nomina ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DGTrabajador.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub ConDTra()
        If TxtBusT.Text = "" Then
            DatosGVT()
        Else
            Dim Consulta As String = "Select Id_Empleado, Numero_Nomina, (Nombre_Empleado + ' ' + Ape_Paterno + ' ' + Ape_Materno) As Nombre, NNS, Alerg_Enfe
                                      FROM TB_Empleados
                                      WHERE Estado = 'Activo' AND
                                            (Numero_Nomina  LIKE '%'+@Busqueda+'%' OR
                                             Nombre_Empleado  LIKE '%'+@Busqueda+'%' or
                                             Ape_Paterno  LIKE '%'+@Busqueda+'%' OR
                                             Ape_Materno  LIKE '%'+@Busqueda+'%')
                                      ORDER BY Numero_Nomina ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusT.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DGTrabajador.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub M()
        Dim Consulta As String = "SELECT P.Id_Producto, P.Nombre_Producto, P.Existencia, M.Medida
                                      FROM TB_Productos AS P
                                           LEFT JOIN TB_Medidas AS M ON M.Id_Medida = P.Id_Medida 
                                  WHERE P.Estado = 'AMass' AND 
		                                P.Nombre_Producto NOT LIKE '%MANTENIMIENTO%' AND 
		                                P.Nombre_Producto NOT LIKE '%Señalamiento%' AND 
		                                P.Nombre_Producto NOT LIKE '%NOM-%' AND
		                                P.Nombre_Producto NOT LIKE '%CURSO%' AND 
		                                P.Nombre_Producto NOT LIKE '%CAPACITACION%' AND 
		                                P.Nombre_Producto NOT LIKE '%SERVICIO%' AND 
		                                P.Nombre_Producto NOT LIKE '%EXTINTOR%' AND
		                                P.Id_Marca <> 52 AND
                                        P.Existencia > 0
                                   ORDER BY Nombre_Producto ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DGProducto.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub BP1()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP1.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TextM1.Text = Da.Item("Nombre_Producto").ToString()
            LUM1.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()

        If LUM1.Text = "" Then
            LA1.Visible = True
        ElseIf LUM1.Text <> "" Then
            LA1.Visible = False
        End If
    End Sub

    Private Sub BP2()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP2.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TextM2.Text = Da.Item("Nombre_Producto").ToString()
            LUM2.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()

        If LUM2.Text = "" Then
            LA2.Visible = True
        ElseIf LUM2.Text <> "" Then
            LA2.Visible = False
        End If
    End Sub

    Private Sub BP3()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP3.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TextM3.Text = Da.Item("Nombre_Producto").ToString()
            LUM3.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()

        If LUM3.Text = "" Then
            LA3.Visible = True
        ElseIf LUM3.Text <> "" Then
            LA3.Visible = False
        End If
    End Sub

    Private Sub BP4()
        Dim Consulta As String = "SELECT P.Nombre_Producto, M.Medida
                                          FROM TB_Productos AS P
                                            INNER JOIN TB_Medidas AS M ON P.Id_Medida = M.Id_Medida
                                          WHERE  P.Id_Producto = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", CInt(IDP4.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            TextM4.Text = Da.Item("Nombre_Producto").ToString()
            LUM4.Text = Da.Item("Medida").ToString()
        End If

        Da.Close()
        Conex.Close()

        If LUM4.Text = "" Then
            LA4.Visible = True
        ElseIf LUM4.Text <> "" Then
            LA4.Visible = False
        End If
    End Sub

    Private Sub Codigo()
        'Crear Código
        Dim Fecha = DateTime.Now.ToString("yy")
        Dim cmd As New SqlCommand("SELECT Id_Consulta
                                       FROM TB_Consultas
                                       ORDER BY Id_Consulta DESC", Conex)
        Dim strCodigo As String

        Conex.Open()
        strCodigo = cmd.ExecuteScalar
        Conex.Close()

        Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

        LCS.Text = "CSMNC-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario

        'Insertar Código

        Dim CodS As String = LCS.Text

        Conex.Open()
        Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()
        Conex.Close()
    End Sub

    Public Sub Datos()
        Conex.Open()
        Dim CONSULTA As String = "UPDATE TB_Empleados
                                        SET Alerg_Enfe = '" & TxtAlergias.Text & "'
                                         WHERE Id_Empleado = " & IDE.Text & ""
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()
        Conex.Close()

        Dim DateE = DateTime.Now
        Dim GDatos As New SqlCommand("SP_GConsulta", Conex)

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Id_Empleado", Trim(IDE.Text))
        GDatos.Parameters.AddWithValue("@Id_Proceso", CProceso.SelectedValue)
        GDatos.Parameters.AddWithValue("@Fecha", Trim(LFec.Text))
        GDatos.Parameters.AddWithValue("@Hora", Trim(LHo.Text))
        GDatos.Parameters.AddWithValue("@Temperatura", Trim(TxtTemperatura.Text))
        GDatos.Parameters.AddWithValue("@Presion", Trim(TxtPrecion.Text))
        GDatos.Parameters.AddWithValue("@Diagnostico", Trim(TxtDiagnostico.Text))
        GDatos.Parameters.AddWithValue("@Observarciones", Trim(TxtObservaciones.Text))
        If CSTPS.Checked = True Then
            GDatos.Parameters.AddWithValue("@STPS", "SI")
        Else
            GDatos.Parameters.AddWithValue("@STPS", "NO")
        End If
        GDatos.Parameters.AddWithValue("@MObser", Trim(TxtObser2.Text))
        GDatos.Parameters.AddWithValue("@Empleado", Trim(LUsuario.Text))
        GDatos.Parameters.AddWithValue("@Created", DateE)
        GDatos.Parameters.AddWithValue("@Codis", Trim(LCS.Text))
        GDatos.Parameters.AddWithValue("@Medic1", Trim(IDP1.Text))
        GDatos.Parameters.AddWithValue("@CMed1", Trim(TxtCE1.Text))
        GDatos.Parameters.AddWithValue("@Medic2", Trim(IDP2.Text))
        GDatos.Parameters.AddWithValue("@CMed2", Trim(TxtCE2.Text))
        GDatos.Parameters.AddWithValue("@Medic3", Trim(IDP3.Text))
        GDatos.Parameters.AddWithValue("@CMed3", Trim(TxtCE3.Text))
        GDatos.Parameters.AddWithValue("@Medic4", Trim(IDP4.Text))
        GDatos.Parameters.AddWithValue("@CMed4", Trim(TxtCE4.Text))


        MR()
        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()

            DB()
            BGEntrega.Visible = False
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString() & "Error al Guardar", "Error", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    Private Sub Nombres()
        Dim Consulta As String = "SELECT ( E.Nombre_Empleado+ ' ' + E.Ape_Paterno+' ' +  E.Ape_Materno) AS Nombre, E.Id_Empleado
                                  FROM TB_Usuarios AS U
                                    INNER JOIN TB_Empleados AS E ON U.Id_Empleado = E.Id_Empleado
                                  WHERE  U.Id_Usuario = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(Index.L_ID.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            LUsuario.Text = Da.Item("Nombre").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    '   Insertar en Moviemiento Rastreo Alta
    Private Sub MR()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = LCS.Text
        Dim Emple As String = LUsuario.Text

        Conex.Open()
        Dim CONSULTA As String = "IF NOT EXISTS(SELECT CodiS FROM TB_MovimientoRastreo WHERE CodiS = '" & CodS & "')
                                        INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Consulta', 'Consulta', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub


    Private Sub CEn4(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCE1.KeyPress, TxtCE2.KeyPress, TxtCE3.KeyPress, TxtCE4.KeyPress
        NumerosyDecimal(TxtCE1, e)
        NumerosyDecimal(TxtCE2, e)
        NumerosyDecimal(TxtCE3, e)
        NumerosyDecimal(TxtCE4, e)
    End Sub

    '   Numeros y Punto Decimal
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DB()
        LFec.Text = ""
        LHo.Text = ""
        IDE.Text = ""
        TxtNN.Text = ""
        TxtNNN.Text = ""
        TxtTrabajador.Text = ""
        CProceso.Visible = False
        TxtTemperatura.Text = ""
        TxtPrecion.Text = ""
        TxtDiagnostico.Text = ""
        TxtObservaciones.Text = ""
        CSTPS.Checked = False
        TxtObser2.Text = ""
        LCS.Text = ""
        IDP1.Text = ""
        TxtCE1.Text = ""
        IDP2.Text = ""
        TxtCE2.Text = ""
        IDP3.Text = ""
        TxtCE3.Text = ""
        IDP4.Text = ""
        TxtCE4.Text = ""
        TxtAlergias.Text = ""
        TxtCE1.Text = ""
        TxtCE2.Text = ""
        TxtCE3.Text = ""
        TxtCE4.Text = ""
        TextM1.Text = ""
        TextM2.Text = ""
        TextM3.Text = ""
        TextM4.Text = ""
        LUM1.Text = ""
        LUM2.Text = ""
        LUM3.Text = ""
        LUM4.Text = ""

        TxtTemperatura.ReadOnly = True
        TxtPrecion.ReadOnly = True
        TxtDiagnostico.ReadOnly = True
        TxtObservaciones.ReadOnly = True
        TxtObser2.ReadOnly = True
        TxtCE1.ReadOnly = True
        TxtCE2.ReadOnly = True
        TxtCE3.ReadOnly = True
        TxtCE4.ReadOnly = True
        TxtAlergias.ReadOnly = True
        TxtCE1.ReadOnly = True
        TxtCE2.ReadOnly = True
        TxtCE3.ReadOnly = True
        TxtCE4.ReadOnly = True
        TxtTemperatura.BackColor = Color.Gainsboro
        TxtPrecion.BackColor = Color.Gainsboro
        TxtDiagnostico.BackColor = Color.Gainsboro
        TxtObservaciones.BackColor = Color.Gainsboro
        TxtObser2.BackColor = Color.Gainsboro
        TxtCE1.BackColor = Color.Gainsboro
        TxtCE2.BackColor = Color.Gainsboro
        TxtCE3.BackColor = Color.Gainsboro
        TxtCE4.BackColor = Color.Gainsboro
        TxtAlergias.BackColor = Color.Gainsboro

        LA1.Visible = False
        LA2.Visible = False
        LA3.Visible = False
        LA4.Visible = False

    End Sub

    Private Sub DT()
        LFec.Text = ""
        LHo.Text = ""
        IDE.Text = ""
        TxtNN.Text = ""
        TxtNNN.Text = ""
        TxtTrabajador.Text = ""
        CProceso.Visible = False
        TxtTemperatura.Text = ""
        TxtPrecion.Text = ""
        TxtDiagnostico.Text = ""
        TxtObservaciones.Text = ""
        CSTPS.Checked = False
        TxtObser2.Text = ""
        LCS.Text = ""
        IDP1.Text = ""
        TxtCE1.Text = ""
        IDP2.Text = ""
        TxtCE2.Text = ""
        IDP3.Text = ""
        TxtCE3.Text = ""
        IDP4.Text = ""
        TxtCE4.Text = ""
        TxtAlergias.Text = ""
        TxtCE1.Text = ""
        TxtCE2.Text = ""
        TxtCE3.Text = ""
        TxtCE4.Text = ""
        TextM1.Text = ""
        TextM2.Text = ""
        TextM3.Text = ""
        TextM4.Text = ""

        TxtTemperatura.ReadOnly = False
        TxtPrecion.ReadOnly = False
        TxtDiagnostico.ReadOnly = False
        TxtObservaciones.ReadOnly = False
        TxtObser2.ReadOnly = False
        TxtCE1.ReadOnly = False
        TxtCE2.ReadOnly = False
        TxtCE3.ReadOnly = False
        TxtCE4.ReadOnly = False
        TxtAlergias.ReadOnly = False
        TxtCE1.ReadOnly = False
        TxtCE2.ReadOnly = False
        TxtCE3.ReadOnly = False
        TxtCE4.ReadOnly = False

        TxtTemperatura.BackColor = Color.White
        TxtPrecion.BackColor = Color.White
        TxtDiagnostico.BackColor = Color.White
        TxtObservaciones.BackColor = Color.White
        TxtObser2.BackColor = Color.White
        TxtCE1.BackColor = Color.White
        TxtCE2.BackColor = Color.White
        TxtCE3.BackColor = Color.White
        TxtCE4.BackColor = Color.White

        LUM1.Text = ""
        LUM2.Text = ""
        LUM3.Text = ""
        LUM4.Text = ""

        BGEntrega.Visible = True
        CProceso.Visible = True

        LFec.Text = Date.Now.ToLongDateString
        LHo.Text = DateTime.Now.ToShortTimeString
    End Sub

    Private Sub BMostrarHist_Click(sender As Object, e As EventArgs) Handles BMostrarHist.Click
        HConsu.Show()
    End Sub

    Private Sub Bt_Click(sender As Object, e As EventArgs) Handles LC1.TextChanged
        Dim Consulta As String = "SELECT  (E.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Paterno) AS Nombre, P.Nombre_Proceso, C.Fecha, 
                                            C.Hora, C.Temperatura, C.Presion, C.Diagnostico, C.Observaciones, C.STPS, C.MObser, DC.Medica1, DC.CMed1, 
                                            DC.Medica2, DC.CMed2, DC.Medica3, DC.CMed3, DC.Medica4, DC.CMed4, E.Numero_Nomina, E.Alerg_Enfe
                                  FROM TB_Consultas AS C
                                      INNER JOIN TB_Empleados AS E ON c.Id_Empleado = e.Id_Empleado
                                      INNER JOIN TB_Procesos AS P ON c.Id_Proceso = p.Id_Proceso
                                      INNER JOIN TB_DetaConsultas AS DC ON C.Codis = DC.Codis
                                  WHERE C.Estado = 'Activo' AND
		                                DC.Estado = 'Activo' AND
                                        C.Id_Consulta  = @Busqueda
                                  Group by c.Id_Consulta, e.Nombre_Empleado, E.Ape_Paterno, E.Ape_Paterno,P.Nombre_Proceso, C.Fecha, 
                                            C.Hora, C.Temperatura, C.Presion, C.Diagnostico, C.Observaciones, C.STPS, C.MObser, DC.Medica1, DC.CMed1, 
                                            DC.Medica2, DC.CMed2, DC.Medica3, DC.CMed3, DC.Medica4, DC.CMed4, E.Numero_Nomina, E.Alerg_Enfe"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(LC1.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()
        If Da.Read() Then

            LFec.Text = Da.Item("Fecha").ToString()
            LHo.Text = Da.Item("Hora").ToString()
            TxtNN.Text = Da.Item("Numero_Nomina").ToString()
            TxtTrabajador.Text = Da.Item("Nombre").ToString()
            TxtProceso.Text = Da.Item("Nombre_Proceso").ToString()
            TxtTemperatura.Text = Da.Item("Temperatura").ToString()
            TxtPrecion.Text = Da.Item("Presion").ToString()
            TxtDiagnostico.Text = Da.Item("Diagnostico").ToString()
            TxtObservaciones.Text = Da.Item("Observaciones").ToString()
            If Da.Item("STPS").ToString() = "SI" Then
                CSTPS.Checked = True
            Else
                CSTPS.Checked = False
            End If
            TxtObser2.Text = Da.Item("MObser").ToString()
            TxtCE1.Text = Da.Item("CMed1").ToString()
            TxtCE2.Text = Da.Item("CMed2").ToString()
            TxtCE3.Text = Da.Item("CMed3").ToString()
            TxtCE4.Text = Da.Item("CMed4").ToString()
            TxtAlergias.Text = Da.Item("Alerg_Enfe").ToString()
            IDP1.Text = Da.Item("Medica1").ToString()
            IDP2.Text = Da.Item("Medica2").ToString()
            IDP3.Text = Da.Item("Medica3").ToString()
            IDP4.Text = Da.Item("Medica4").ToString()

        End If
        Da.Close()
        Conex.Close()

        If IDP1.Text <> "" Then
            BP1()
        End If

        If IDP2.Text <> "" Then
            BP2()
        End If

        If IDP3.Text <> "" Then
            BP3()
        End If

        If IDP4.Text <> "" Then
            BP4()
        End If

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        If MsgBox("Desea Eliminar la consulta ", vbYesNo) = vbYes Then
            BDatos()
        End If
    End Sub

    Public Sub BDatos()

        Dim DateE = DateTime.Now
        Dim GDatos As New SqlCommand("SP_CConsulta", Conex)

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Empleado", Trim(LUsuario.Text))
        GDatos.Parameters.AddWithValue("@DELATED", DateE)
        GDatos.Parameters.AddWithValue("@Codis", Trim(LCS.Text))
        GDatos.Parameters.AddWithValue("@Medic1", Trim(IDP1.Text))
        GDatos.Parameters.AddWithValue("@CMed1", Trim(TxtCE1.Text))
        GDatos.Parameters.AddWithValue("@Medic2", Trim(IDP2.Text))
        GDatos.Parameters.AddWithValue("@CMed2", Trim(TxtCE2.Text))
        GDatos.Parameters.AddWithValue("@Medic3", Trim(IDP3.Text))
        GDatos.Parameters.AddWithValue("@CMed3", Trim(TxtCE3.Text))
        GDatos.Parameters.AddWithValue("@Medic4", Trim(IDP4.Text))
        GDatos.Parameters.AddWithValue("@CMed4", Trim(TxtCE4.Text))


        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()

            DB()
            BGEntrega.Visible = False
            TxtProceso.Text = ""
            BEliminar.Visible = ""
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString() & "Error al Guardar", "Error", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub
End Class