Imports System.Data.SqlClient

Public Class Rastreo
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Dim PProceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub Rastreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultas()
        Nombres()
        DatosG()
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

    Private Sub BInicio_Click(sender As Object, e As EventArgs) Handles BInicio.Click
        If MsgBox("Desea Guardar la Información de Inicio ", vbYesNo) = vbYes Then
            If TxtOT.Text = "" Or TxtIH.Text = "" Or TxtIT.Text = "" Or TxtITr.Text = "" Then
                MessageBox.Show("Ingrese Todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Datos()
            End If
        End If
    End Sub

    Private Sub BPausar_Click(sender As Object, e As EventArgs) Handles BPausar.Click
        If MsgBox("Desea Pausar la Producción ", vbYesNo) = vbYes Then
            If TxtOT.Text = "" Or TxtPH.Text = "" Or TxtPT.Text = "" Or TxtPTr.Text = "" Then
                MessageBox.Show("Ingrese Todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosP()
            End If
        End If
    End Sub

    Private Sub BContinuar_Click(sender As Object, e As EventArgs) Handles BContinuar.Click
        If MsgBox("Desea Continuar la Producción ", vbYesNo) = vbYes Then
            If TxtOT.Text = "" Or TxtCH.Text = "" Or TxtCT.Text = "" Or TxtCTr.Text = "" Then
                MessageBox.Show("Ingrese Todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosC()
            End If
        End If
    End Sub

    Private Sub BFinalizar_Click(sender As Object, e As EventArgs) Handles BFinalizar.Click
        If MsgBox("Desea Finalizar la Producción ", vbYesNo) = vbYes Then
            If TxtOT.Text = "" Or TxtFH.Text = "" Or TxtFT.Text = "" Or TxtFTr.Text = "" Then
                MessageBox.Show("Ingrese Todos los datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosF()
            End If
        End If
    End Sub

    Private Sub DST_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DST.CellContentClick
        LEstado.Text = ""
        Dim row As DataGridViewRow = DST.CurrentRow()

        'Mostrar Inf en TextBox
        TxtOT.Text = row.Cells(4).Value

        TxtOT.ReadOnly = True
        Da()
        Da1()

        BInicio.Visible = False
        If LEstado.Text = Nothing Then
            GPausar.Visible = True
            GContinuar.Visible = False
            GFinalizar.Visible = True
            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""
            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
        End If
    End Sub


    Private Sub CProceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CProceso.SelectedIndexChanged
        BInicio.Visible = True
        BInicio.Enabled = True
        DatosG()

        GPausar.Visible = False
        GContinuar.Visible = False
        GFinalizar.Visible = False

        TxtOT.Text = ""
        TxtIH.Text = ""
        TxtIT.Text = ""
        TxtITr.Text = ""
        TxtIH.ReadOnly = False
        TxtIT.ReadOnly = False
        TxtITr.ReadOnly = False
        TxtOT.ReadOnly = False
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        DatosGPP()
    End Sub


    Private Sub Consultas()
        With PProceso
            .CommandType = CommandType.Text
            .CommandText = "SELECT *
                            FROM TB_Procesos
                            WHERE Estado = 'Activo'
                            ORDER BY Nombre_Proceso ASC"
            .Connection = Conex
        End With

        DAProceso.SelectCommand = PProceso
        DTProceso = New DataTable
        DAProceso.Fill(DTProceso)
        With CProceso
            .DataSource = DTProceso
            .DisplayMember = "Nombre_Proceso"
            .ValueMember = "Id_Proceso"
        End With
    End Sub

    Private Sub Datos()
        Dim Proceso As String = CProceso.Text
        Dim OT As String = TxtOT.Text
        Dim HOR As String = TxtIH.Text
        Dim Tur As String = TxtIT.Text
        Dim Res As String = TxtITr.Text
        Dim RI As String = LUsuario.Text

        Dim GDatos As New SqlCommand("SP_GSPl", Conex)
        Dim DateA = DateTime.Now
        Dim Fecha = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Proceso", Proceso)
        GDatos.Parameters.AddWithValue("@OrdenTrabajo", OT)
        GDatos.Parameters.AddWithValue("@Fecha", DateA)
        GDatos.Parameters.AddWithValue("@Hora", HOR)
        GDatos.Parameters.AddWithValue("@Turno", Tur)
        GDatos.Parameters.AddWithValue("@Responsable", Res)
        GDatos.Parameters.AddWithValue("@ResponsableI", RI)
        GDatos.Parameters.AddWithValue("@Created", Fecha)

        Dim RData As SqlDataReader

        Conex.Open()
        Try
            RData = GDatos.ExecuteReader()

            TxtOT.ReadOnly = True
            TxtIH.ReadOnly = True
            TxtIT.ReadOnly = True
            TxtITr.ReadOnly = True
            BInicio.Visible = False

            GPausar.Visible = True
            GFinalizar.Visible = True

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()

        DatosG()
    End Sub

    Private Sub DatosP()
        Dim Proceso As String = CProceso.Text
        Dim OT As String = TxtOT.Text
        Dim HOR As String = TxtPH.Text
        Dim Tur As String = TxtPT.Text
        Dim Res As String = TxtPTr.Text
        Dim RI As String = LUsuario.Text

        Dim GDatos As New SqlCommand("SP_DGSPl", Conex)
        Dim DateA = DateTime.Now
        Dim Fecha = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Proceso", Proceso)
        GDatos.Parameters.AddWithValue("@OrdenTrabajo", OT)
        GDatos.Parameters.AddWithValue("@Fecha", DateA)
        GDatos.Parameters.AddWithValue("@Hora", HOR)
        GDatos.Parameters.AddWithValue("@Turno", Tur)
        GDatos.Parameters.AddWithValue("@Responsable", Res)
        GDatos.Parameters.AddWithValue("@ResponsableI", RI)
        GDatos.Parameters.AddWithValue("@Estado", "Pausado")
        GDatos.Parameters.AddWithValue("@Created", Fecha)

        Dim RData As SqlDataReader

        Conex.Open()
        Try
            RData = GDatos.ExecuteReader()

            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            GPausar.Visible = False
            GContinuar.Visible = True
            GFinalizar.Visible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()

    End Sub

    Private Sub DatosC()
        Dim Proceso As String = CProceso.Text
        Dim OT As String = TxtOT.Text
        Dim HOR As String = TxtCH.Text
        Dim Tur As String = TxtCT.Text
        Dim Res As String = TxtCTr.Text
        Dim RI As String = LUsuario.Text

        Dim GDatos As New SqlCommand("SP_DGSPl", Conex)
        Dim DateA = DateTime.Now
        Dim Fecha = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Proceso", Proceso)
        GDatos.Parameters.AddWithValue("@OrdenTrabajo", OT)
        GDatos.Parameters.AddWithValue("@Fecha", DateA)
        GDatos.Parameters.AddWithValue("@Hora", HOR)
        GDatos.Parameters.AddWithValue("@Turno", Tur)
        GDatos.Parameters.AddWithValue("@Responsable", Res)
        GDatos.Parameters.AddWithValue("@ResponsableI", RI)
        GDatos.Parameters.AddWithValue("@Estado", "Continuacion")
        GDatos.Parameters.AddWithValue("@Created", Fecha)

        Dim RData As SqlDataReader

        Conex.Open()
        Try
            RData = GDatos.ExecuteReader()

            GPausar.Visible = True
            GFinalizar.Visible = True
            GContinuar.Visible = False
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()

    End Sub

    Private Sub DatosF()
        Dim Proceso As String = CProceso.Text
        Dim OT As String = TxtOT.Text
        Dim HOR As String = TxtFH.Text
        Dim Tur As String = TxtFT.Text
        Dim Res As String = TxtFTr.Text
        Dim RI As String = LUsuario.Text

        Dim GDatos As New SqlCommand("SP_DGSPl", Conex)
        Dim DateA = DateTime.Now
        Dim Fecha = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Proceso", Proceso)
        GDatos.Parameters.AddWithValue("@OrdenTrabajo", OT)
        GDatos.Parameters.AddWithValue("@Fecha", DateA)
        GDatos.Parameters.AddWithValue("@Hora", HOR)
        GDatos.Parameters.AddWithValue("@Turno", Tur)
        GDatos.Parameters.AddWithValue("@Responsable", Res)
        GDatos.Parameters.AddWithValue("@ResponsableI", RI)
        GDatos.Parameters.AddWithValue("@Estado", "Finalizado")
        GDatos.Parameters.AddWithValue("@Created", Fecha)

        Dim RData As SqlDataReader

        Conex.Open()
        Try
            RData = GDatos.ExecuteReader()

            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
            GFinalizar.Visible = False
            GPausar.Visible = False
            GContinuar.Visible = False

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Conex.Close()

        Conex.Open()
        Dim CONSULTA As String = "UPDATE TB_SPlanta SET Estado = 'Finalizado',
					                                Responsablef = '" & LUsuario.Text & "',
                                                    Finished = SYSDATETIME()
				                    WHERE OrdenTrabajo = '" & TxtOT.Text & "' AND
						            Proceso = '" & CProceso.Text & "'"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()
        Conex.Close()

        DatosG()
    End Sub

    Private Sub DatosGPP()
        If TxtBusqueda.Text = "" Then
            DatosG()
        Else
            Dim Consulta As String = "SELECT Id_SPlan, OrdenTrabajo, Estado, Fecha
                                        FROM TB_SPlanta
                                      WHERE (OrdenTrabajo LIKE '%'+@Busqueda+'%' OR
                                            Estado LIKE '%'+@Busqueda+'%') AND
                                            Proceso = @Pro
                                      ORDER BY Fecha ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusqueda.Text))
            cmd.Parameters.AddWithValue("@Pro", CProceso.Text)
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DST.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub DatosG()
        Dim Consulta As String = "SELECT Id_SPlan, OrdenTrabajo, Estado, Fecha
                                    FROM TB_SPlanta
                                    WHERE Proceso = '" & Trim(CProceso.Text) & "'
                                    ORDER BY Fecha ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DST.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
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

    Private Sub Da()
        Dim Consulta As String = "SELECT Fecha, Hora, Turno, Responsable
                                    FROM TB_SPlanta
                                    WHERE Proceso = @Proce and
                                    OrdenTrabajo = @Busqueda"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtOT.Text))
        cmd.Parameters.AddWithValue("@Proce", Trim(CProceso.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            DTIF.Value = Da.Item("Fecha").ToString()
            TxtIH.Text = Da.Item("Hora").ToString()
            TxtIT.Text = Da.Item("Turno").ToString()
            TxtITr.Text = Da.Item("Responsable").ToString()
        End If

        Da.Close()
        Conex.Close()

        TxtIH.ReadOnly = True
        TxtIT.ReadOnly = True
        TxtITr.ReadOnly = True
    End Sub

    Private Sub Da1()
        Dim Consulta As String = "SELECT Estado
                                    FROM TB_DSPlanta
                                    WHERE OrdenTrabajo =  @Busqueda AND
		                                    Proceso = @Proce
                                    ORDER BY Id_DSPlan desc"

        Dim cmd As New SqlCommand(Consulta, Conex)
        cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtOT.Text))
        cmd.Parameters.AddWithValue("@Proce", Trim(CProceso.Text))

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()

        If Da.Read() Then
            LEstado.Text = Da.Item("Estado").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub LEstado_TextChanged(sender As Object, e As EventArgs) Handles LEstado.TextChanged
        If LEstado.Text = Nothing Then
            GPausar.Visible = True
            GContinuar.Visible = False
            GFinalizar.Visible = True
            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""
            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
        ElseIf LEstado.Text = "Pausado" Then
            GContinuar.Visible = True
            GFinalizar.Visible = False
            GPausar.Visible = False
            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""
            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
        ElseIf LEstado.Text = "Continuacion" Then
            GPausar.Visible = True
            GFinalizar.Visible = True
            GContinuar.Visible = False
            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""
            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
        ElseIf LEstado.Text = "Finalizado" Then
            GPausar.Visible = False
            GFinalizar.Visible = False
            GContinuar.Visible = False
            TxtPH.Text = ""
            TxtPT.Text = ""
            TxtPTr.Text = ""
            TxtCH.Text = ""
            TxtCT.Text = ""
            TxtCTr.Text = ""
            TxtFH.Text = ""
            TxtFT.Text = ""
            TxtFTr.Text = ""
        End If
    End Sub
End Class