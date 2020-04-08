Imports System.Data.SqlClient

Public Class Entregas
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Dim PProceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub Entregas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
        DatosGVP()
        DatosGVT()
    End Sub

    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        If ETickets.DatosDG.Item(0, 0).Value <> Nothing Then
            Close()
            ETickets.Impresion_Click(sender, e)
        Else
            Close()
            ETickets.Close()
        End If
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BNuevoPrestamo_Click(sender As Object, e As EventArgs) Handles BNuevoPrestamo.Click
        Consultas()
        If Tickets.LCS.Text <> Nothing Then
            LCS.Text = Tickets.LCS.Text
        Else
            'Crear Código
            Dim Fecha = DateTime.Now.ToString("yy")
            Dim cmd As New SqlCommand("SELECT Id_S
                                       FROM TB_CodigS
                                       ORDER BY Id_S DESC", Conex)
            Dim strCodigo As String

            Conex.Open()
            strCodigo = cmd.ExecuteScalar
            Conex.Close()

            Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

            LCS.Text = "CSAE-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario
            Tickets.LCS.Text = "CSAE-" + Format(Id + 1, "0000") + "/" + Fecha 'Tickets

            'Insertar Código
            If ETickets.LCS.Text <> Nothing Then
                Dim CodS As String = LCS.Text

                Conex.Open()
                Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
                Dim COMANDO As New SqlCommand(CONSULTA, Conex)

                COMANDO.ExecuteNonQuery()
                Conex.Close()
            End If
        End If

        ETickets.Show()

        TxtFEntrega.Text = DateTime.Now.ToString("yyyy/MM/dd")

        Nombres()
        TxtCantidad.ReadOnly = False
        TxtDescripcion.ReadOnly = False
        TxtCantidad.BackColor = Color.LightCoral
        TxtDescripcion.BackColor = Color.LightCoral

        BEliminar.Visible = False
        BGEntrega.Visible = True
        BRIngreso.Visible = True
        BBProducto.Visible = True
        BBTrabajador.Visible = True
        CProceso.Visible = True

        DatosB()
        TxtBMaterial.Text = ""
    End Sub

    Private Sub BBTrabajador_Click(sender As Object, e As EventArgs) Handles BBTrabajador.Click
        PMaterial.Visible = False
        If PTrabajador.Visible = False Then
            PTrabajador.Visible = True
            ANuevoT.Visible = True
        Else
            If PTrabajador.Visible = True Then
                PTrabajador.Visible = False
                ANuevoT.Visible = False
            End If
        End If
    End Sub

    Private Sub BBProducto_Click(sender As Object, e As EventArgs) Handles BBProducto.Click
        If PMaterial.Visible = False Then
            PMaterial.Visible = True
        Else
            If PMaterial.Visible = True Then
                PMaterial.Visible = False
            End If
        End If
    End Sub

    Private Sub BRIngreso_Click(sender As Object, e As EventArgs) Handles BRIngreso.Click
        DatosB()
        BGEntrega.Visible = False
        BRIngreso.Visible = False
        PTrabajador.Visible = False
        PMaterial.Visible = False
        BBProducto.Visible = False
        BBTrabajador.Visible = False
        ANuevoT.Visible = False
        TxtFEntrega.Text = ""
        txtResponsable.Text = ""
        TxtTrabajador.Visible = True
        TxtFEntrega.BackColor = Color.Gainsboro
        TxtDescripcion.BackColor = Color.Gainsboro
        TxtCantidad.BackColor = Color.Gainsboro
    End Sub

    Private Sub BGEntrega_Click(sender As Object, e As EventArgs) Handles BGEntrega.Click
        Dim Nombre As String = TxtNN.Text & " - " & TxtTrabajador.Text

        If ETickets.LTrabajador.Text = "" Then
            ETickets.Show()
            If IDE.Text = "" Or IDP.Text = "" Then
                MessageBox.Show("Seleccione al Trabajador y/o Material", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                'ElseIf LEx.Text < TxtCantidad.Text Then
                '    MessageBox.Show("Verifique Existencias", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Datos()
            End If
        Else
            If ETickets.LTrabajador.Text <> Nombre Then
                ETickets.Impresion_Click(sender, e)
                ETickets.Show()
                If IDE.Text = "" Or IDP.Text = "" Then
                    MessageBox.Show("Seleccione al Trabajador y/o Material", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'ElseIf LEx.Text < TxtCantidad.Text Then
                    '    MessageBox.Show("Verifique Existencias", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Datos()
                End If
            ElseIf ETickets.LTrabajador.Text = Nombre Then
                If IDE.Text = "" Or IDP.Text = "" Then
                    MessageBox.Show("Seleccione al Trabajador y/o Material", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    'ElseIf LEx.Text < TxtCantidad.Text Then
                    '    MessageBox.Show("Verifique Existencias", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Datos()
                End If
            End If
        End If
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        'Crear Código
        Dim Fecha = DateTime.Now.ToString("yy")
        Dim cmd As New SqlCommand("SELECT Id_S
                                       FROM TB_CodigS
                                       ORDER BY Id_S DESC", Conex)
        Dim strCodigo As String

        Conex.Open()
        strCodigo = cmd.ExecuteScalar
        Conex.Close()

        Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

        LCS.Text = "CSAEE-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario
        Tickets.LCS.Text = "CSAEE-" + Format(Id + 1, "0000") + "/" + Fecha 'Tickets

        'Insertar Código
        If ETickets.LCS.Text <> Nothing Then
            Dim CodS As String = LCS.Text

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()
        End If

        Eliminar()
    End Sub

    Private Sub DatosPM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosPM.CellContentClick
        Dim row As DataGridViewRow = DatosPM.CurrentRow()

        'Mostrar Inf en TextBox
        IDD.Text = row.Cells(0).Value
        TxtNN.Text = row.Cells(1).Value
        TxtTrabajador.Text = row.Cells(2).Value
        TxtMaterial.Text = row.Cells(3).Value
        TxtCantidad.Text = row.Cells(4).Value
        TxtFEntrega.Text = row.Cells(5).Value
        TxtDescripcion.Text = row.Cells(6).Value
        txtResponsable.Text = row.Cells(7).Value
        TxtProceso.Text = row.Cells(8).Value

        BEliminar.Visible = True
        BRIngreso.Visible = False
        BGEntrega.Visible = False


        TxtCantidad.ReadOnly = True
        TxtDescripcion.ReadOnly = True
        TxtCantidad.BackColor = Color.Gainsboro
        TxtDescripcion.BackColor = Color.Gainsboro
        PMaterial.Visible = False
        BBProducto.Visible = False
        PTrabajador.Visible = False
        BBTrabajador.Visible = False
        CProceso.Visible = False
    End Sub

    Private Sub ANuevoT_Click(sender As Object, e As EventArgs) Handles ANuevoT.Click
        PNT.Visible = True
        PTrabajador.Visible = False
        TxtNNN.Text = ""
        TxtNombre.Text = ""
        TxtAP.Text = ""
        TxtAM.Text = ""
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim Exis As Double
        Dim row As DataGridViewRow = DGProducto.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDP.Text = FilaID

        FilaP = row.Cells(1).Value
        TxtMaterial.Text = FilaP

        Exis = row.Cells(3).Value
        LEx.Text = Exis

        PMaterial.Visible = False
    End Sub

    Private Sub BRNT_Click(sender As Object, e As EventArgs) Handles BRNT.Click
        PNT.Visible = False
        PTrabajador.Visible = True
    End Sub

    Private Sub BGNT_Click(sender As Object, e As EventArgs) Handles BGNT.Click
        If TxtNombre.Text = "" Or TxtAP.Text = "" Or TxtAM.Text = "" Then
            MessageBox.Show("Ingrese el Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            DatosNT()
        End If
    End Sub

    Private Sub DGTrabajador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTrabajador.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim NN As String
        Dim row As DataGridViewRow = DGTrabajador.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDE.Text = FilaID

        NN = row.Cells(1).Value
        TxtNN.Text = NN

        FilaP = row.Cells(2).Value
        TxtTrabajador.Text = FilaP

        PTrabajador.Visible = False
        ANuevoT.Visible = False
    End Sub


    'Textbox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        DatosGPP()
    End Sub

    Private Sub TxtBMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtBMaterial.TextChanged
        ConDMa()
    End Sub

    Private Sub TxtBusT_TextChanged(sender As Object, e As EventArgs) Handles TxtBusT.TextChanged
        ConDTra()
    End Sub


    'Combo
    Private Sub CProceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CProceso.SelectedValueChanged
        TxtProceso.Text = CProceso.Text
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_BEntregas", Conex)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DatosPM.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try

        Conex.Close()
    End Sub

    Private Sub DatosGVT()
        Dim Consulta As New SqlCommand("SP_BTrabajador", Conex)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DGTrabajador.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try

        Conex.Close()
    End Sub

    '   Guardar
    Public Sub Datos()
        Dim GDatos As New SqlCommand("SP_GNEntrega", Conex)
        Dim DateA = DateTime.Now
        Dim Fecha = DateTime.Now.ToString("yyyy/MM/dd")

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Id_Empleado", Trim(IDE.Text))
        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        GDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtCantidad.Text))
        GDatos.Parameters.AddWithValue("@Fecha_Entrega", Fecha)
        GDatos.Parameters.AddWithValue("@Descripcion ", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@ResponsableS", Trim(txtResponsable.Text))
        GDatos.Parameters.AddWithValue("@IdProceso", CProceso.SelectedValue)
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader

        MR()
        Conex.Open()
        Dim Prod As String = TxtMaterial.Text
        Dim CodS As String = LCS.Text
        Dim CanS As Double = CDec(TxtCantidad.Text)

        Dim CONSULTA As String = "IF NOT EXISTS(SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                 INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS)
                                                                VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, 0,0)"

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
        Try
            Conex.Open()
            Ticktss()
            RData = GDatos.ExecuteReader()

            DatosB()
            BRIngreso.Visible = False
            BGEntrega.Visible = False
            txtResponsable.Text = ""
            TxtFEntrega.Text = ""

            TxtDescripcion.BackColor = Color.Gainsboro
            TxtCantidad.BackColor = Color.Gainsboro
            TxtCantidad.ReadOnly = True
            TxtDescripcion.ReadOnly = True
            CProceso.Visible = False

            TxtTrabajador.Visible = True
            BBProducto.Visible = False
            BBTrabajador.Visible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
        DatosGV()
    End Sub

    '   Eliminar Datos
    Private Sub Eliminar()
        MRB()

        Conex.Open()
        Dim Prod As String = TxtMaterial.Text
        Dim CodS As String = LCS.Text
        Dim CanS As Double = CDec(TxtCantidad.Text)

        Dim CONSULTA As String = "IF NOT EXISTS(SELECT CodiS, Producto FROM TB_DetalleSeguimiento WHERE CodiS = '" & CodS & "' AND Producto = '" & Prod & "')
	                                 INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS)
                                                                VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, 0,0)"

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()

        Dim DateE = DateTime.Now

        Dim EDatos As New SqlCommand("SP_DesacEntrega", Conex)

        EDatos.CommandType = CommandType.StoredProcedure

        EDatos.Parameters.AddWithValue("@Id_Entrega", Trim(IDD.Text))
        EDatos.Parameters.AddWithValue("@FechaEliminacion", DateE)
        EDatos.Parameters.AddWithValue("@REliminacion", Trim(txtResponsable.Text))
        EDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtCantidad.Text))

        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = EDatos.ExecuteReader()

            DatosB()
            txtResponsable.Text = ""
            TxtFEntrega.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Eliminar Registro", MessageBoxButtons.OK)
        End Try

        Conex.Close()
        DatosGV()
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
        DatosGVT()
    End Sub


    'Consultas
    Private Sub DatosGPP()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "SELECT E.Id_Entrega, Em.Numero_Nomina, (Em.Nombre_Empleado + ' ' + 
			                                    Em.Ape_Paterno + ' ' + Em.Ape_Materno ) AS Nombre,
			                                    P.Nombre_Producto ,E.Cantidad, E.Fecha_Entrega,
			                                    E.Descripcion, E.ResponsableS, Pr.Nombre_Proceso
  
                                      FROM TB_Entregas AS E
                                      INNER JOIN TB_Empleados AS Em ON E.Id_Empleado = Em.Id_Empleado
                                      inner join TB_Productos AS P ON e.Id_Producto = P.Id_Producto
                                      inner join TB_Procesos AS Pr ON e.Proceso = Pr.Id_Proceso
                                      WHERE E.Estado = 'Activo' AND
                                            (Em.Numero_Nomina LIKE '%'+@Busqueda+'%' OR
                                            P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                            P.Codigo_Barras LIKE '%'+@Busqueda+'%')
                                      ORDER BY E.Fecha_Entrega ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DatosPM.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub DatosGVP()
        Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                  FROM TB_Productos
                                  WHERE Estado = 'Activo' AND
									    Existencia > 0
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

    Private Sub Nombres()
        Dim Consulta As String = "SELECT ( E.Nombre_Empleado+ ' ' + E.Ape_Paterno+' ' +  E.Ape_Materno) AS Nombre
                                  FROM TB_Usuarios AS U
                                    INNER JOIN TB_Empleados AS E ON U.Id_Empleado = E.Id_Empleado
                                  WHERE  U.Id_Usuario = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(Index.L_ID.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            txtResponsable.Text = Da.Item("Nombre").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub ConDMa()
        If TxtBMaterial.Text = "" Then
            DatosGVP()
        Else
            Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                        FROM TB_Productos
                                        WHERE Estado = 'Activo' AND
                                                (Nombre_Producto  LIKE '%'+@Busqueda+'%' OR
                                                Clave_Producto  LIKE '%'+@Busqueda+'%' OR
                                                Codigo_Barras LIKE '%'+@Busqueda+'%') AND
									            Existencia > 0
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

    Private Sub ConDTra()
        If TxtBusT.Text = "" Then
            DatosGVT()
        Else
            Dim Consulta As String = "Select Id_Empleado, Numero_Nomina, (Nombre_Empleado + ' ' + Ape_Paterno + ' ' + Ape_Materno) As Nombre
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

    '   Insertar en Moviemiento Rastreo
    Private Sub MR()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = LCS.Text
        Dim Emple As String = txtResponsable.Text

        Conex.Open()
        Dim CONSULTA As String = "INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Entrega', 'Entrega', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub

    '   Insertar en Moviemiento Rastreo Baja
    Private Sub MRB()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = LCS.Text
        Dim Emple As String = txtResponsable.Text

        Conex.Open()
        Dim CONSULTA As String = "IF NOT EXISTS(SELECT CodiS FROM TB_MovimientoRastreo WHERE CodiS = '" & CodS & "')
                                    INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Cancelacion', 'Cancelacion', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub

    Private Sub Consultas()
        With PProceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = PProceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With CProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub


    'Otros
    Public Sub Ticktss()
        If CStr(Len(TxtMaterial.Text)) > 25 Then
            Dim NPr As String = TxtMaterial.Text
            ETickets.DatosDG.Rows.Add(IDP.Text.Trim(), NPr.Substring(0, 25), TxtCantidad.Text.Trim())
            ETickets.LTrabajador.Text = TxtNN.Text & " - " & TxtTrabajador.Text
        Else
            ETickets.DatosDG.Rows.Add(IDP.Text.Trim(), TxtMaterial.Text, TxtCantidad.Text.Trim())
            ETickets.LTrabajador.Text = TxtNN.Text & " - " & TxtTrabajador.Text
        End If

        ETickets.LCS.Text = LCS.Text
    End Sub


    'Validación
    Private Sub TxtCalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        NumerosyDecimal(TxtCantidad, e)
    End Sub

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


    Private Sub DatosB()
        TxtNN.Text = ""
        TxtTrabajador.Text = ""
        TxtMaterial.Text = ""
        TxtCantidad.Text = ""
        TxtDescripcion.Text = ""
        TxtProceso.Text = ""
    End Sub


    'Movimiento
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

'Base de Datos
'Agregar a TB_Entregas campo proceso

'USE [SISUT021]
'GO
'/****** Object:  StoredProcedure [dbo].[SP_BEntregas]    Script Date: 08/04/2020 12:56:04 a. m. ******/
'SET ANSI_NULLS ON
'GO
'SET QUOTED_IDENTIFIER ON
'GO
'ALTER PROCEDURE [dbo].[SP_BEntregas]
'AS
'BEGIN
'	SELECT E.Id_Entrega, Em.Numero_Nomina, (Em.Nombre_Empleado + ' ' + 
'			Em.Ape_Paterno + ' ' + Em.Ape_Materno ) AS Nombre,
'			P.Nombre_Producto ,E.Cantidad, E.Fecha_Entrega,
'			E.Descripcion, E.ResponsableS, Pr.Nombre_Proceso

'  FROM TB_Entregas AS E
'  INNER JOIN TB_Empleados AS Em ON E.Id_Empleado = Em.Id_Empleado
'  inner join TB_Productos AS P ON e.Id_Producto = P.Id_Producto
'  inner join TB_Procesos AS Pr ON e.Proceso = Pr.Id_Proceso

'  WHERE E.Estado = 'Activo'
'  Order by E.Fecha_Entrega asc

'end

'USE [SISUT021]
'GO
'/****** Object:  StoredProcedure [dbo].[SP_GNEntrega]    Script Date: 08/04/2020 01:07:21 a. m. ******/
'SET ANSI_NULLS ON
'GO
'SET QUOTED_IDENTIFIER ON
'GO
'ALTER PROCEDURE [dbo].[SP_GNEntrega]

'	@Id_Empleado int,
'	@Id_Producto int,
'    @Cantidad float,
'    @Fecha_Entrega date,
'    @Descripcion varchar(200),
'    @ResponsableS Varchar(50),
'    @Created datetime,
'	@IdProceso int

'AS
'BEGIN
'	INSERT INTO TB_Entregas
'           (Id_Empleado
'			,Id_Producto
'			,Cantidad
'			,Fecha_Entrega
'			,Descripcion
'			,Estado
'			,Created
'			,ResponsableS
'			,ExiA
'			,ExiD
'			,Proceso
'           )
'     VALUES
'           (@Id_Empleado,
'            @Id_Producto,
'            @Cantidad,
'            @Fecha_Entrega,
'            @Descripcion,
'            'Activo',
'            @Created,
'            @ResponsableS,
'           (SELECT TOP 1 Existencia FROM TB_Productos Where Id_Producto = @Id_Producto ORDER BY Id_Producto DESC),
'           (SELECT TOP 1 (Existencia - @Cantidad) FROM TB_Productos Where Id_Producto = @Id_Producto ORDER BY Id_Producto DESC),
'		   @IdProceso
'    )

'	SET NOCOUNT ON;
'	UPDATE Tb_productos
'		Set Existencia = (SELECT TOP 1 (Existencia - @Cantidad) FROM TB_Productos Where Id_Producto = @Id_Producto ORDER BY Id_Producto DESC)
'		Where   Id_Producto = @Id_Producto
'END


'USE [SISUT021]
'GO
'/****** Object:  StoredProcedure [dbo].[SP_GDEProductos]    Script Date: 07/04/2020 10:57:51 p. m. ******/
'SET ANSI_NULLS ON
'GO
'SET QUOTED_IDENTIFIER ON
'GO
'ALTER PROCEDURE [dbo].[SP_GDEProductos]

'	@Id_Producto INT,
'	@Cantidad float,
'	@Precio_Unitario_PZA FLOAT,
'    @Tipo_Cambio FLOAT,
'    @PU_Corte_PZA FLOAT,
'    @PU_Total FLOAT,
'    @Precio_Total FLOAT,
'    @Created DATETIME,
'    @Orden_Compra VARCHAR(50),
'    @PUUSD FLOAT,
'    @FUSD FLOAT,
'    @TUSD FLOAT,
'    @Id_Empleado FLOAT,
'    @CodiS varchar(50),
'    @Producto varchar(250),
'    @Empleado varchar(50)

'AS
'BEGIN
'	INSERT INTO TB_EDetalleProductos
'	(Id_Producto
'	  ,Cantidad
'      ,Precio_Unitario_PZA
'      ,Tipo_Cambio
'      ,PU_Corte_PZA
'      ,PU_Total
'      ,Precio_Total
'      ,Created
'      ,Orden_Compra
'      ,PUUSD
'      ,FUSD
'      ,TUSD
'      ,Id_Empleado
'      ,CodiS)

'     VALUES
'           (@Id_Producto,
'			@Cantidad,
'			@Precio_Unitario_PZA,
'			@Tipo_Cambio,
'			@PU_Corte_PZA,
'			@PU_Total,
'			@Precio_Total,
'			@Created,
'			@Orden_Compra,
'			@PUUSD,
'			@FUSD,
'			@TUSD,
'			@Id_Empleado,
'			@CodiS
'    )


'    SET NOCOUNT ON;
'	UPDATE Tb_productos
'		set Existencia = (SELECT (Existencia + @Cantidad)
'							FROM TB_Productos
'							Where Id_Producto = @Id_Producto), 
'		PU_Total = @PU_Total,
'		Updated = @Created
'		Where   Id_Producto = @Id_Producto



'    SET NOCOUNT ON;
'	If not exists (Select CodS From TB_CodigS WHERE CodS = @CodiS)

'	INSERT INTO TB_CodigS
'	(CodS
'	,Created)

'     VALUES
'           (@CodiS,
'			@Created)




'	If exists(Select CodiS, Producto From TB_DetalleSeguimiento WHERE CodiS = @CodiS AND Producto = @Producto)
'	Update TB_DetalleSeguimiento Set
'	CanE = (Select (CanE + @Cantidad)From TB_DetalleSeguimiento WHERE CodiS = @CodiS AND Producto = @Producto)
'	WHERE CodiS = @CodiS AND Producto = @Producto

'SET NOCOUNT ON;
'update TB_Ordenes_Detalle SET
'estatus = (Select (COALESCE(estatus, 0) + @Cantidad) From TB_Ordenes_Detalle WHERE codigo = @Orden_Compra and estado = @Id_Producto)
'WHERE codigo = @Orden_Compra and estado = @Id_Producto
'END


