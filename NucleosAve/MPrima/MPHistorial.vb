Imports System.Data.SqlClient

Public Class MPHistorial
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub MPHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBusqueda.Text = "-"
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

    Private Sub DTF1_ValueChanged(sender As Object, e As EventArgs) Handles DTF1.ValueChanged
        Dim Fech1 As String = DTF1.Value.ToString("yyyy-MM-dd")

        Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
                                      Fecha_Registro, OCompra, CSeguimiento
                                      FROM TB_MateriaPrima
                                      WHERE Estado = 'Almacen MP' AND
                                            Fecha_Registro like '" & Fech1 & "'"

        Dim cmd As New SqlCommand(Consulta, Conex)

        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DGHR.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub BPMPr_Click(sender As Object, e As EventArgs) Handles BPMPr.Click
        MPInventario.Show()
        MPInventario.TxtOC.Text = TxtBusqueda.Text
        WindowState = FormWindowState.Minimized
    End Sub


    'Text
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = "" Then
        Else
            Dim Consulta As String = "SELECT Id_MPrim, Proveedor, Num_Interno, Num_Externo, Calibre, Ancho, Peso, UMedida, Descripcion, Fecha_Llegada,
		                                    Fecha_Registro, OCompra, CSeguimiento
                                      FROM TB_MateriaPrima
                                      WHERE Estado = 'Almacen MP' AND
                                            OCompra like '%'+@Busqueda+'%'"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))

            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()
                Da.Fill(Ds)

                DGHR.DataSource = Ds.Tables(0)
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


