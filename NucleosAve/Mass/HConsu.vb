Imports System.Data.SqlClient

Public Class HConsu
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub HConsu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Datos()
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
        Dim Fech1 As String = DTF1.Value.ToString("yyyy-MM-dd")
        Dim Fech2 As String = DTF2.Value.ToString("yyyy-MM-dd")

        Dim Consulta As String = "SELECT C.Id_Consulta, (e.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Paterno) AS Nombre,
                                        P.Nombre_Proceso, c.Fecha, c.Hora, c.STPS
                                  From TB_Consultas As c
                                  INNER Join TB_Empleados AS E ON E.Id_Empleado = C.Id_Empleado
                                  INNER Join TB_Procesos AS P ON P.Id_Proceso = C.Id_Proceso
                                  WHERE c.Estado = 'Activo' AND
                                C.Created between '" & Fech1 & "' AND '" & Fech2 & "'"

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

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = "" Then
            Datos()
        Else
            Dim Consulta As String = "SELECT C.Id_Consulta, (e.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Materno) AS Nombre,
                                        P.Nombre_Proceso, c.Fecha, c.Hora, c.STPS
                                  From TB_Consultas As c
                                  INNER Join TB_Empleados AS E ON E.Id_Empleado = C.Id_Empleado
                                  INNER Join TB_Procesos AS P ON P.Id_Proceso = C.Id_Proceso
                                  WHERE c.Estado = 'Activo' AND
                                        (e.Nombre_Empleado like '%'+@Busqueda+'%' OR
                                        E.Ape_Paterno like '%'+@Busqueda+'%' OR
                                        E.Ape_Materno like '%'+@Busqueda+'%' OR
                                        P.Nombre_Proceso like '%'+@Busqueda+'%' OR
                                        E.Numero_Nomina like '%'+@Busqueda+'%')"

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

    Private Sub Datos()
        Dim Consulta As String = "SELECT C.Id_Consulta, (E.Nombre_Empleado + ' ' + E.Ape_Paterno + ' ' + E.Ape_Paterno) AS Nombre,
		                                P.Nombre_Proceso, C.Fecha, C.Hora, C.STPS
                                  FROM TB_Consultas AS C
                                  INNER JOIN TB_Empleados AS E ON E.Id_Empleado = C.Id_Empleado
                                  INNER JOIN TB_Procesos AS P ON P.Id_Proceso = C.Id_Proceso
                                  WHERE C.Estado = 'Activo'"

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

    Private Sub DataView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataView.CellContentClick
        Dim FilaID As Integer
        Dim row As DataGridViewRow = DataView.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        Consultas.LC1.Text = FilaID

        WindowState = FormWindowState.Minimized
        Consultas.BGEntrega.Visible = False
        Consultas.CProceso.Visible = False
        Consultas.BEliminar.Visible = True
        Consultas.BE1.Visible = False
        Consultas.BE2.Visible = False
        Consultas.BE3.Visible = False
        Consultas.BE4.Visible = False

        Consultas.BB1.Visible = False
        Consultas.BB2.Visible = False
        Consultas.BB3.Visible = False
        Consultas.BB4.Visible = False
    End Sub

End Class