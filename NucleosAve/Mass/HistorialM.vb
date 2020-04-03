Imports System.Data.SqlClient

Public Class HistorialM
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub HistorialM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosDG()
    End Sub

    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
        MInventario.Show()
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
        MInventario.Show()
    End Sub


    'TextBox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub


    'Procedimientos Almacenados
    Private Sub DatosDG()
        Dim Consulta As New SqlCommand("SP_BDetallePro", Conex)
        Consulta.CommandType = CommandType.StoredProcedure

        Consulta.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        Dim da As New SqlDataAdapter(Consulta)
        Dim ds As New DataSet

        Try
            Conex.Open()
            da.Fill(ds)

            DataView.DataSource = ds.Tables(0)
            da.Dispose()
        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()
    End Sub

    'Búsqueda
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosDG()
        Else
            Dim SQL As String = "SELECT Id_DProducto, Cantidad, Precio_Unitario_PZA,
			                        PU_Corte_PZA, PU_Total, Precio_Total, Tipo_Cambio, 
			                        Created, Orden_Compra
                                FROM TB_EDetalleProductos 
	                            WHERE Orden_Compra LIKE '%'+@Busqueda+'%' AND
                                      Id_Producto = @Id
                                ORDER BY Created DESC"

            Dim cmd As New SqlCommand(SQL, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))
            cmd.Parameters.AddWithValue("@Id", Trim(IDP.Text))
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