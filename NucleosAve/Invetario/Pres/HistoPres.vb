Imports System.Data.SqlClient

Public Class HistoPres
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub HistoPres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosGV()
    End Sub

    'Botones
    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
        Prestamos.Show()
    End Sub

    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Me.Close()
        Prestamos.Show()
    End Sub


    'TextBox
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        BuscarDatos()
    End Sub


    'Procedimientos
    '   Llenar DataView
    Private Sub DatosGV()
        Dim Consulta As New SqlCommand("SP_HPrest", Conex)
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


    'Consultas
    '   Búsqueda en DataView
    Private Sub BuscarDatos()
        If TxtBusqueda.Text = "" Then
            DatosGV()
        Else
            Dim Consulta As String = "SELECT Pr.Id_Prestamo, E.Numero_Nomina, (E.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Paterno) As Nombre, 
                                        P.Nombre_Producto, Pr.Cantidad, Pr.Fecha_Prestamo, Pr.Descripcion, Pr.Con_Salida, Pr.ResponsableS, Pr.Ingreso, 
                                        Pr.ResponsableI, Pr.Con_Ingreso
                                      FROM TB_Prestamos As Pr
	                                    INNER JOIN TB_Empleados AS E ON Pr.Id_Empleado = E.Id_Empleado
	                                    INNER JOIN TB_Productos AS P ON Pr.Id_Producto = P.Id_Producto
                                      WHERE Pr.Estado = 'Finalizado'  AND
                                             (E.Numero_Nomina LIKE '%'+@Busqueda+'%' OR
                                              P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                              P.Clave_Producto LIKE '%'+@Busqueda+'%')
                                      ORDER BY Pr.Ingreso DESC"

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