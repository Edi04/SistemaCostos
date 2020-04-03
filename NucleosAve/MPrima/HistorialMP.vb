Imports System.Data.SqlClient

Public Class HistorialMP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub HistorialMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    Private Sub BBOC1_Click(sender As Object, e As EventArgs) Handles BBOC1.Click
        BuscarOC()
    End Sub

    'Text
    Private Sub TxtBOC_TextChanged(sender As Object, e As EventArgs) Handles TxtBOC.TextChanged

        If TxtBOC.Text = "" Then

        Else
            Dim Consulta As String = "SELECT Id_MPrim, Num_Interno, Calibre, Ancho, Peso, Descripcion, Fecha_Llegada,
                                        OCompra, Estado, Proveedor
	                                    FROM TB_MateriaPrima
                                            where OCompra like '%'+@Busqueda+'%' AND
                                            Estado = 'Almacen MP'"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBOC.Text))

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DVMP.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    'Procedimientos
    Private Sub BuscarOC()
        Dim Consulta As New SqlCommand("SP_BMPrima", Conex)

        Consulta.Parameters.AddWithValue("Fech1", DTF1.Value)
        Consulta.Parameters.AddWithValue("Fech2", DTF2.Value)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet


        Try
            Conex.Open()
            Da.Fill(Ds)

            DVMP.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
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