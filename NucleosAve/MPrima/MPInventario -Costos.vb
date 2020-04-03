Imports System.Data.SqlClient

Public Class MPInventario
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub MPInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BBOC_Click(sender As Object, e As EventArgs) Handles BBOC.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        ElseIf Panel2.Visible = True Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub BBOC1_Click(sender As Object, e As EventArgs) 
        BuscarOC()
    End Sub

    Private Sub DVOC_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 
        Dim OC As String
        Dim Prove As String
        Dim Exis As Double
        Dim UMS As String
        Dim Mat As String
        Dim row As DataGridViewRow = DVOC.Rows(e.RowIndex)

        OC = row.Cells(1).Value
        TxtOC.Text = OC

        Prove = row.Cells(2).Value
        TxtProveedor.Text = Prove

        Exis = row.Cells(3).Value
        TxtCS.Text = Exis

        UMS = row.Cells(4).Value
        If UMS = "Toneladas" Then
            LKGS.Text = "TON"
            LKGE.Text = "TON"
        End If

        Mat = row.Cells(6).Value
        TxtMaterial.Text = Mat

        Panel2.Visible = False
    End Sub

    Private Sub BBOC_Click5(sender As Object, e As EventArgs)
        If TxtPeso1.Text <> Nothing Then
            Try
                Dim Funcion As New RegistroMP
                Dim Datos As New CRegistroMP

                Datos.Proveedor_ = TxtProveedor.Text
                Datos.Num_RIn = TxtNRolI1.Text
                Datos.Num_REx = TxtNumRollo1.Text
                Datos.Calibre_ = TxtCalibre1.Text
                Datos.Ancho_ = TxtAncho1.Text
                Datos.Peso_ = TxtPeso1.Text
                Datos.Descripcion_ = TxtObser1.Text
                Datos.FechaLlegada = DTFechaLl.Value
                Datos.FechaRegistro = DTFechaR.Value
                Datos.OCompra_ = TxtOC.Text

                If Funcion.R(Datos) Then
                    TxtObser1.Text = "0"
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub


    'Procedimientos
    Private Sub BuscarOC()
        Dim Consulta As New SqlCommand("SP_BOCMPrima", Conex)

        Consulta.Parameters.AddWithValue("Fech1", DTF1.Value)
        Consulta.Parameters.AddWithValue("Fech2", DTF2.Value)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet


        Try
            Conex.Open()
            Da.Fill(Ds)

            DVOC.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
        End Try
        Conex.Close()
    End Sub


End Class