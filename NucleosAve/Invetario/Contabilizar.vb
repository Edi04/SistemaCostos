Imports System.Data.SqlClient

Public Class Contabilizar
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub Contabilizar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
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

    'Selección de Datos
    '   Selección de un Dato en el DataGridView
    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim FilaProducto As Integer
        Dim row As DataGridViewRow = DataView.Rows(e.RowIndex)

        FilaProducto = row.Cells(0).Value
        IDD.Text = FilaProducto

        CargaInfpRO()
        BGuardarMo.Visible = True
    End Sub

    'TextBox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub

    Private Sub BGuardarMo_Click(sender As Object, e As EventArgs) Handles BGuardarMo.Click
        If MsgBox("Desea Modificar la Existencia del Producto: " & TxtNombreP.Text, vbYesNo) = vbYes Then
            If TxtNE.Text <> Nothing Then
                Datos()
            Else
                MessageBox.Show("Ingresar Existencias", "Aviso", MessageBoxButtons.OK)
            End If
        End If
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_BInventa", Conex)
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
        Consulta.Parameters.AddWithValue("@Id_Producto", Trim(IDD.Text))
        Dim dr As SqlDataReader
        Try
            Conex.Open()
            dr = Consulta.ExecuteReader
            Do While dr.Read
                TxtClaveP.Text = Trim(dr("Clave_Producto"))
                TxtNombreP.Text = Trim(dr("Nombre_Producto"))
                TxtExistencia.Text = Trim(dr("Existencia"))
            Loop
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub

    'Consultas
    '   Búsqueda en DataView
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "SELECT P.Id_Producto, P.Clave_Producto, P.Nombre_Producto, P.Existencia
                                      FROM TB_Productos AS P
                                           INNER JOIN TB_Marcas AS Ma ON Ma.Id_Marca = P.Id_Marca
                                      WHERE (P.Clave_Producto LIKE '%'+@Busqueda+'%' OR
                                             P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                             Ma.Marca LIKE '%'+@Busqueda+'%' OR
                                             P.Codigo_Barras LIKE '%'+@Busqueda+'%') AND
                                             P.Estado = 'Activo'"

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


    '   NExistencia
    Public Sub Datos()
        Dim DateE = DateTime.Now

        Dim GDatos As New SqlCommand("SP_GNModificacion", Conex)

        GDatos.CommandType = CommandType.StoredProcedure
        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDD.Text))
        GDatos.Parameters.AddWithValue("@FechaMod", DateE)
        GDatos.Parameters.AddWithValue("@ExisD", Trim(TxtNE.Text))
        GDatos.Parameters.AddWithValue("@Descripcion", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@ResponsableM", Trim(txtResponsable.Text))


        Try
            Conex.Open()
            GDatos.ExecuteReader()
            TxtNE.Text = ""
            TxtDescripcion.Text = ""
            TxtNombreP.Text = ""
            TxtClaveP.Text = ""
            TxtExistencia.Text = ""
            BGuardarMo.Visible = False
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar", MessageBoxButtons.OK)
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
            txtResponsable.Text = Da.Item("Nombre").ToString()
        End If
        Da.Close()
        Conex.Close()
    End Sub

    Private Sub TxtNEPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNE.KeyPress
        NumerosyDecimal(TxtNE, e)
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