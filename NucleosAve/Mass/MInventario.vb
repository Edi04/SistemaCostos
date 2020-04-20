Imports System.Data.SqlClient

Public Class MInventario
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    'ComboBoxs
    Dim UMedida As New SqlCommand
    Dim DTUMedida As DataTable
    Dim DAUMedida As New SqlDataAdapter

    Dim Marca As New SqlCommand
    Dim DTMarca As DataTable
    Dim DAMarca As New SqlDataAdapter

    Private Sub MInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
        Consultas()
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

    '   Eliminar
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Eliminar()
        AgregarExistencias.Visible = False
    End Sub

    '   Modificar
    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        AModif()
        BInvisiblesCRUD()
        AgregarExistencias.Visible = False
        BOrdenC.Visible = False
    End Sub

    '   Guardar Modificación
    Private Sub BGuardarMo_Click(sender As Object, e As EventArgs) Handles BGuardarMo.Click
        If (CMedida.SelectedValue = Nothing) Then
            MessageBox.Show("Seleccione la Unidad de Medida", "Advertencia", MessageBoxButtons.OK)
        Else
            Modif()
            BOrdenC.Visible = True
            CargaInfpRO()
        End If
    End Sub

    Private Sub BRetorno_Click(sender As Object, e As EventArgs) Handles BRetorno.Click
        CargaInfpRO()
        BVisiblesCRUD()
        DModif()
        BOrdenC.Visible = True
    End Sub

    '   Agregar Existencia
    Private Sub BAgregarExistencia_Click(sender As Object, e As EventArgs) Handles BAgregarExistencia.Click
        If Tickets.LCS.Text <> Nothing Then
            LCS.Text = Tickets.LCS.Text
        Else
            Dim Fecha = DateTime.Now.ToString("yy")
            Dim cmd As New SqlCommand("SELECT COUNT(Id_DProducto)
                                        FROM TB_EDetalleProductos", Conex)
            Dim strCodigo As String
            Conex.Open()
            strCodigo = cmd.ExecuteScalar
            Conex.Close()

            Dim id As Integer = CType(strCodigo.Substring(0), Integer)

            LCS.Text = "CSM-" + Format(id + 1, "0000") + "/" + Fecha
        End If

        '/////
        AgregarExistencias.Visible = True
        Tickets.Show()
        DatosB()
        BInvisiblesCRUD()
    End Sub

    '   NExistencia
    Private Sub BGExistencia_Click(sender As Object, e As EventArgs) Handles BGExistencia.Click
        If TxtNExistencia.Text = Nothing Then
            MessageBox.Show("Ingresar Cantidad", "Advertencia", MessageBoxButtons.OK)
        Else
            Datos()
            CargaInfpRO()
        End If
    End Sub

    Private Sub BCerrarN_Click(sender As Object, e As EventArgs) Handles BCerrarN.Click
        AgregarExistencias.Visible = False
        BVisiblesCRUD()
    End Sub

    '   Detalles Productos
    Private Sub BMostrarHist_Click(sender As Object, e As EventArgs) Handles BMostrarHist.Click
        HistorialM.Producto.Text = Me.TxtNombreP.Text
        HistorialM.IDP.Text = Me.IDP.Text

        HistorialM.Show()
        Close()
    End Sub

    Private Sub BOrdenC_Click(sender As Object, e As EventArgs) Handles BOrdenC.Click
        Dim OC As New ODC()
        OC.Show()
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub


    'Selección de Datos
    '   Selección de un Dato en el DataGridView
    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim FilaProducto As Integer
        Dim row As DataGridViewRow = DataView.Rows(e.RowIndex)

        FilaProducto = row.Cells(0).Value
        IDP.Text = FilaProducto

        CargaInfpRO()
        DModif()
        BVisiblesCRUD()
        BOrdenC.Visible = True
        AgregarExistencias.Visible = False
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_BMInventa", Conex)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DataView.DataSource = Ds.Tables(0)
            Da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    '   Mostrar Inf en TextBox
    Private Sub CargaInfpRO()
        Dim Consulta As New SqlCommand("SP_BPRODUCTO", Conex)
        Consulta.CommandType = CommandType.StoredProcedure
        Consulta.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        Dim dr As SqlDataReader
        Try
            Conex.Open()
            dr = Consulta.ExecuteReader
            Do While dr.Read
                TxtClaveP.Text = Trim(dr("Clave_Producto"))
                TxtNombreP.Text = Trim(dr("Nombre_Producto"))
                TxtDescripcion.Text = Trim(dr("Descripcion"))
                TxtExistencia.Text = Trim(dr("Existencia"))
                TxtMinimo.Text = Trim(dr("Minimo"))
                TxtMaximo.Text = Trim(dr("Maximo"))
                TxtMedida.Text = Trim(dr("Medida"))
                TxtPrecio.Text = Trim(dr("PU_Total"))

                LM.Text = Trim(dr("Id_Medida"))
                LMa.Text = Trim(dr("Id_Marca"))
                LC.Text = Trim(dr("Id_Categoria"))
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    '   NExistencia
    Public Sub Datos()
        Dim DateE = DateTime.Now

        Dim GDatos As New SqlCommand("SP_GDEProductos", Conex)

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        GDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtNExistencia.Text))
        GDatos.Parameters.AddWithValue("@Producto", Trim(TxtNombreP.Text))
        GDatos.Parameters.AddWithValue("@Precio_Unitario_PZA", 0)
        GDatos.Parameters.AddWithValue("@Tipo_Cambio", 0)
        GDatos.Parameters.AddWithValue("@PU_Corte_PZA", 0)
        GDatos.Parameters.AddWithValue("@PU_Total", Trim(TxtUTotal.Text))
        GDatos.Parameters.AddWithValue("@Precio_Total", Trim(TxtTotal.Text))
        GDatos.Parameters.AddWithValue("@Created", DateE)
        GDatos.Parameters.AddWithValue("@Orden_Compra", "")
        GDatos.Parameters.AddWithValue("@PUUSD", 0)
        GDatos.Parameters.AddWithValue("@FUSD", 0)
        GDatos.Parameters.AddWithValue("@TUSD", 0)
        GDatos.Parameters.AddWithValue("@Id_Empleado", Trim(LIDE.Text))
        GDatos.Parameters.AddWithValue("@Empleado", Trim(LUsuario.Text))

        If Tickets.LCS.Text <> Nothing Then
            GDatos.Parameters.AddWithValue("@CodiS", Trim(Tickets.LCS.Text))
        Else
            MR()
            GDatos.Parameters.AddWithValue("@CodiS", Trim(LCS.Text))
        End If

        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()
            AgregarExistencias.Visible = False
            BVisiblesCRUD()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar", MessageBoxButtons.OK)
        End Try
        Conex.Close()

        Conex.Open()
        Dim Prod As String = TxtNombreP.Text
        Dim CodS As String = LCS.Text
        Dim CanS As Double = CDec(TxtNExistencia.Text)
        Dim PrecE As Double = TxtUTotal.Text

        Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS, Created)
                                   VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, " & PrecE & ", 0, SYSDATETIME())"

        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub

    Private Sub MR()
        Dim CodS As String = LCS.Text
        Dim Emple As String = LUsuario.Text

        Conex.Open()
        Dim CONSULTA As String = "INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                                VALUES ( 'Entrada', 'Entrada', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        Conex.Close()
    End Sub


    'Consultas
    '   Eliminar Datos
    Private Sub Eliminar()
        Try
            Dim ID As Integer = IDP.Text

            Conex.Open()
            Dim CONSULTA As String = "UPDATE TB_Productos SET
	                                     Estado = 'IMass',
                                         Deleted = SYSDATETIME()
	                              Where Id_Producto = '" & ID & "'"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()

            DatosGV()
            DataB()
            BInvisiblesCRUD()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Eliminar Datos", MessageBoxButtons.OK)
        End Try
    End Sub

    '   Modifi
    Private Sub Modif()
        Try
            Dim ID As Integer = IDP.Text
            Dim CP As String = TxtClaveP.Text
            Dim NP As String = TxtNombreP.Text
            Dim De As String = TxtDescripcion.Text
            Dim IM As Integer = CMedida.SelectedValue
            Dim Ma As Double = TxtMinimo.Text
            Dim Mx As Double = TxtMaximo.Text

            Conex.Open()
            Dim CONSULTA As String = "UPDATE TB_Productos SET
	                                    Clave_Producto = '" & CP & "',
	                                    Nombre_Producto = '" & NP & "',
	                                    Descripcion = '" & De & "',
	                                    Id_Medida = '" & IM & "',
	                                    Minimo = '" & Ma & "',
	                                    Maximo = '" & Mx & "',
	                                    Id_Categoria = 5,
	                                    Id_Area = 24,
	                                    Id_Proceso = 36,
	                                    Updated = SYSDATETIME()
	                                    Where Id_Producto = '" & ID & "'"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()

            DatosGV()
            BVisiblesCRUD()
            DModif()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Modificar Datos", MessageBoxButtons.OK)
        End Try

    End Sub

    Private Sub Consultas()
        'Combos
        With UMedida
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Medidas
                            WHERE Estado = 'Activo'
                            ORDER BY Medida ASC"
            .Connection = Conex
        End With

        DAUMedida.SelectCommand = UMedida
        DTUMedida = New DataTable
        DAUMedida.Fill(DTUMedida)
        With CMedida
            .DataSource = DTUMedida
            .DisplayMember = "Medida"
            .ValueMember = "Id_Medida"
        End With
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
            LIDE.Text = Da.Item("Id_Empleado").ToString()
        End If
        Da.Close()
        Conex.Close()
    End Sub

    '   Búsqueda en DataView
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "SELECT P.Id_Producto, P.Clave_Producto, P.Nombre_Producto
                                      FROM TB_Productos AS P
                                           INNER JOIN TB_Marcas AS Ma ON Ma.Id_Marca = P.Id_Marca
                                      WHERE (P.Clave_Producto LIKE '%'+@Busqueda+'%' OR
                                             P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                             Ma.Marca LIKE '%'+@Busqueda+'%') AND
                                             P.Estado = 'AMass'
	                                  ORDER BY Nombre_Producto ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DataView.DataSource = Ds.Tables(0)
                Da.Dispose()
            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub


    Private Sub Total(sender As Object, e As EventArgs) Handles TxtNExistencia.TextChanged, TxtUTotal.TextChanged
        Dim TE As Decimal = 0
        Dim NE As Decimal = 0

        If TxtNExistencia.Text <> Nothing Then
            TE = CDec(TxtNExistencia.Text)
        End If

        If TxtUTotal.Text <> Nothing Then
            NE = CDec(TxtUTotal.Text)
        End If
        TxtTotal.Text = CDec(TE * NE).ToString
    End Sub


    'Validacion
    Private Sub TxtNExistenciaPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNExistencia.KeyPress
        NumerosyDecimal(TxtNExistencia, e)
    End Sub

    Private Sub TxtUTotalPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUTotal.KeyPress
        NumerosyDecimal(TxtUTotal, e)
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

    'Botones -TF
    Private Sub DModif()
        TxtClaveP.ReadOnly = True
        TxtNombreP.ReadOnly = True
        CMedida.Visible = False
        TxtDescripcion.ReadOnly = True
        TxtMinimo.ReadOnly = True
        TxtMaximo.ReadOnly = True

        TxtClaveP.BackColor = Color.Gainsboro
        TxtNombreP.BackColor = Color.Gainsboro
        TxtDescripcion.BackColor = Color.Gainsboro
        TxtMinimo.BackColor = Color.Gainsboro
        TxtMaximo.BackColor = Color.Gainsboro

        BRetorno.Visible = False
        BGuardarMo.Visible = False
    End Sub

    Private Sub BVisiblesCRUD()
        BNuevoProducto.Visible = True
        BMostrarHist.Visible = True
        BAgregarExistencia.Visible = True
        BModificar.Visible = True
        BEliminar.Visible = True
    End Sub

    Public Sub DataB()
        TxtClaveP.Text = ""
        TxtNombreP.Text = ""
        TxtDescripcion.Text = ""
        TxtExistencia.Text = ""
        TxtMinimo.Text = ""
        TxtMaximo.Text = ""
        TxtMedida.Text = ""
        TxtPrecio.Text = ""

        BAgregarExistencia.Visible = False
        BModificar.Visible = False
        BEliminar.Visible = False
    End Sub

    Private Sub BInvisiblesCRUD()
        BNuevoProducto.Visible = False
        BMostrarHist.Visible = False
        BAgregarExistencia.Visible = False
        BModificar.Visible = False
        BEliminar.Visible = False
    End Sub

    Private Sub AModif()
        CMedida.Visible = True
        CMedida.SelectedValue = LM.Text
        TxtDescripcion.ReadOnly = False
        TxtMinimo.ReadOnly = False
        TxtMaximo.ReadOnly = False

        TxtDescripcion.BackColor = Color.LightCoral
        TxtMinimo.BackColor = Color.LightCoral
        TxtMaximo.BackColor = Color.LightCoral

        BGuardarMo.Visible = True
        BRetorno.Visible = True

        If TxtClaveP.Text = Nothing Then
            TxtClaveP.ReadOnly = False
            TxtClaveP.BackColor = Color.LightCoral
            TxtNombreP.ReadOnly = False
            TxtNombreP.BackColor = Color.LightCoral
        End If
    End Sub

    Public Sub DatosB()
        TxtNExistencia.Text = ""
        TxtUTotal.Text = ""
        TxtTotal.Text = ""
        LTExistencias.Text = ""
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

    Private Sub GDatos_Generales_Enter(sender As Object, e As EventArgs) Handles GDatos_Generales.Enter


    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
    End Sub
End Class