Imports System.Data.SqlClient

Public Class MIEPP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub MIEPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDatos()
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

    Private Sub BEPP_Click(sender As Object, e As EventArgs) Handles BEPP.Click
        EntregasEPP.Show()
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub


    'Consultas
    '   Búsqueda en DataView
    Private Sub BDatos()
        Dim Consulta As String = "SELECT P.Id_Producto, P.Clave_Producto, P.Nombre_Producto, P.Existencia
                                    FROM TB_Productos AS P
                                    INNER JOIN TB_Marcas AS Ma ON Ma.Id_Marca = P.Id_Marca
                                    WHERE P.Estado = 'Activo' AND
	                                    (P.Nombre_Producto LIKE '%EPP%' OR
	                                    P.Nombre_Producto LIKE '%Zapato%')
                                    ORDER BY P.Nombre_Producto ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)

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
    End Sub

    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            BDatos()
        Else
            Dim Consulta As String = "SELECT P.Id_Producto, P.Clave_Producto, P.Nombre_Producto, P.Existencia
                                    FROM TB_Productos AS P
                                    INNER JOIN TB_Marcas AS Ma ON Ma.Id_Marca = P.Id_Marca
                                    WHERE P.Estado = 'Activo' AND
	                                    (P.Nombre_Producto LIKE '%EPP%' OR
	                                    P.Nombre_Producto LIKE '%Zapato%') AND
                                        (P.Clave_Producto LIKE '%'+@Busqueda+'%' OR
                                             P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                             Ma.Marca LIKE '%'+@Busqueda+'%' OR
                                             P.Codigo_Barras LIKE '%'+@Busqueda+'%')
                                        ORDER BY P.Nombre_Producto ASC"

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