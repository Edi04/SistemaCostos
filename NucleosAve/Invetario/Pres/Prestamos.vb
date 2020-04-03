Imports System.Data.SqlClient

Public Class Prestamos
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
        Nombres()
    End Sub

    'Botones
    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
    End Sub

    Private Sub DatosPM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosPM.CellContentClick
        Dim FilaProducto As Integer
        Dim row As DataGridViewRow = DatosPM.Rows(e.RowIndex)

        FilaProducto = row.Cells(0).Value
        IDD.Text = FilaProducto

        CargaInfpRO()
        BotT()
        DatosNRead()
        BRetorno.Visible = False
        BGuardarMo.Visible = False
        BGIngreso.Visible = False
        BRIngreso.Visible = False
        PIngreso.Visible = False
        TxtConIngreso.Text = ""
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Eliminar()
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        DatosRead()
        BotF()

        BRetorno.Visible = True
        BGuardarMo.Visible = True
        BRetorno.Visible = True
    End Sub

    Private Sub BRetorno_Click(sender As Object, e As EventArgs) Handles BRetorno.Click
        BotT()

        BRetorno.Visible = False
        BGuardarMo.Visible = False
        DatosNRead()
        CargaInfpRO()
    End Sub

    Private Sub BGuardarM(sender As Object, e As EventArgs) Handles BGuardarMo.Click
        Modifi()
    End Sub

    Private Sub BNuevoPrestamo_Click(sender As Object, e As EventArgs) Handles BNuevoPrestamo.Click
        NPrestamo.Show()
        Close()
    End Sub

    Private Sub BIngreso_Click(sender As Object, e As EventArgs) Handles BIngreso.Click
        PIngreso.Visible = True
        BRIngreso.Visible = True
        BGIngreso.Visible = True
        BotF()
    End Sub

    Private Sub BRIngreso_Click(sender As Object, e As EventArgs) Handles BRIngreso.Click
        PIngreso.Visible = False
        BRIngreso.Visible = False
        BGIngreso.Visible = False
        BotT()
    End Sub

    Private Sub BGIngreso_Click(sender As Object, e As EventArgs) Handles BGIngreso.Click
        FPres()
    End Sub

    Private Sub BMostrarHist_Click(sender As Object, e As EventArgs) Handles BMostrarHist.Click
        HistoPres.Show()
        Close()
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_BPrestamo", Conex)
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

    '   Mostrar Inf en TextBox
    Private Sub CargaInfpRO()
        Dim Consulta As New SqlCommand("SP_BDPrestamo", Conex)
        Consulta.CommandType = CommandType.StoredProcedure
        Consulta.Parameters.AddWithValue("@Id_Prestamo", Trim(IDD.Text))
        Dim dr As SqlDataReader
        Try
            Conex.Open()
            dr = Consulta.ExecuteReader
            Do While dr.Read
                TxtNN.Text = Trim(dr("Numero_Nomina"))
                TxtTrabajador.Text = Trim(dr("Nombre"))
                TxtMaterial.Text = Trim(dr("Nombre_Producto"))
                TxtCantidad.Text = Trim(dr("Cantidad"))
                TxtFPrestamo.Text = Trim(dr("Fecha_Prestamo"))
                TxtFEntrega.Text = Trim(dr("Fecha_Entrega"))
                TxtDescripcion.Text = Trim(dr("Descripcion"))
                TxtDSalida.Text = Trim(dr("Con_Salida"))
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    '   Eliminar Datos
    Private Sub Eliminar()
        Dim DateE = DateTime.Now

        Dim EDatos As New SqlCommand("SP_DesactPrestamo", Conex)

        EDatos.CommandType = CommandType.StoredProcedure

        EDatos.Parameters.AddWithValue("@Id_Prestamo", Trim(IDD.Text))
        EDatos.Parameters.AddWithValue("@REliminacion", Trim(LUsuario.Text))
        EDatos.Parameters.AddWithValue("@FechaEliminacion", DateE)

        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = EDatos.ExecuteReader()

            DataB()
            BotF()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Eliminar Registro", MessageBoxButtons.OK)
        End Try
        Conex.Close()
        DatosGV()
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
            LUsuario.Text = Da.Item("Nombre").ToString()
        End If
        Da.Close()
        Conex.Close()
    End Sub

    Private Sub Modifi()
        Dim DateE = DateTime.Now

        Dim GDatos As New SqlCommand("SP_ModifPrestamo", Conex)

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Id_Prestamo", Trim(IDD.Text))
        GDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtCantidad.Text))
        GDatos.Parameters.AddWithValue("@FEntrega", Trim(DTFEntrega.Value.Date))
        GDatos.Parameters.AddWithValue("@Descripcion", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@CSalida", Trim(TxtDSalida.Text))
        GDatos.Parameters.AddWithValue("@Updated", DateE)
        GDatos.Parameters.AddWithValue("@ResponsableM", Trim(LUsuario.Text))

        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()
            BotT()
            BRetorno.Visible = False
            BGuardarMo.Visible = False
            DatosNRead()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Modificar Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
        DatosGV()
        CargaInfpRO()
    End Sub

    Private Sub FPres()
        Dim DateE = DateTime.Now

        Dim GDatos As New SqlCommand("SP_FPrestamo", Conex)

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Id_Prestamo", Trim(IDD.Text))
        GDatos.Parameters.AddWithValue("@Con_Ingreso", Trim(TxtConIngreso.Text))
        GDatos.Parameters.AddWithValue("@Ingreso", DateE)
        GDatos.Parameters.AddWithValue("@ResponsableI", Trim(LUsuario.Text))

        Dim RData As SqlDataReader

        Try
            Conex.Open()
            RData = GDatos.ExecuteReader()
            BotF()
            BRIngreso.Visible = False
            BGIngreso.Visible = False
            DatosNRead()
            DataB()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Modificar Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
        DatosGV()
    End Sub

    'Consultas
    '   Búsqueda en DataView
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "Select P.Id_Prestamo, (E.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Materno) AS Nombre,
			                            P.Fecha_Entrega, Pr.Nombre_Producto
	                                  From TB_Prestamos as P
		                                INNER JOIN TB_Empleados AS E ON E.Id_Empleado = P.Id_Empleado
		                                INNER JOIN TB_Productos as Pr on Pr.Id_Producto = P.Id_Producto
	                                  Where P.Estado = 'Activo' AND
                                             (E.Numero_Nomina LIKE '%'+@Busqueda+'%' OR
                                              Pr.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                              Pr.Clave_Producto LIKE '%'+@Busqueda+'%')
	                                  Order by Fecha_Entrega asc"

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


    'Validaciones y True - False
    Private Sub BotT()
        BEliminar.Visible = True
        BModificar.Visible = True
        BIngreso.Visible = True
    End Sub

    Private Sub BotF()
        BEliminar.Visible = False
        BModificar.Visible = False
        BIngreso.Visible = False
    End Sub

    Private Sub DataB()
        TxtNN.Text = ""
        TxtTrabajador.Text = ""
        TxtMaterial.Text = ""
        TxtCantidad.Text = ""
        TxtFPrestamo.Text = ""
        TxtFEntrega.Text = ""
        TxtDescripcion.Text = ""
        TxtDSalida.Text = ""
        TxtConIngreso.Text = ""
    End Sub

    Private Sub DatosRead()
        TxtCantidad.ReadOnly = False
        DTFEntrega.Visible = True
        TxtDescripcion.ReadOnly = False
        TxtDSalida.ReadOnly = False

        TxtCantidad.BackColor = Color.LightCoral
        TxtDescripcion.BackColor = Color.LightCoral
        TxtDSalida.BackColor = Color.LightCoral
    End Sub

    Private Sub DatosNRead()
        TxtCantidad.ReadOnly = True
        DTFEntrega.Visible = False
        TxtDescripcion.ReadOnly = True
        TxtDSalida.ReadOnly = True

        TxtCantidad.BackColor = Color.Gainsboro
        TxtDescripcion.BackColor = Color.Gainsboro
        TxtDSalida.BackColor = Color.Gainsboro
    End Sub

    'Validaciones
    Private Sub TxtCalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        NumerosyDecimal(TxtCantidad, e)
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