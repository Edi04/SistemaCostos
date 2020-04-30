Imports System.Data.SqlClient

Public Class InicioSesion
    Private Sub InicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Abrir()
        C_Proceso()
        C_A()
    End Sub


    'Botones
    '   Cerrar
    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Close()
        Application.Exit()
    End Sub

    '   Minimizar
    Private Sub BMinimizar_Click(sender As Object, e As EventArgs) Handles BMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    '   Inicio de Sesión
    Private Sub BInicioSesion_Click(sender As Object, e As EventArgs) Handles BInicioSesion.Click
        Try
            If UsuarioRegistrado(CUsuarios.Text) = True Then
                Dim contra As String = Contrasena(CUsuarios.Text)
                If contra.Equals(TxtContrasena.Text) = True Then
                    Me.Hide()
                    Index.L_User.Text = CUsuarios.Text
                    Index.L_ID.Text = CUsuarios.SelectedValue

                    Index.Show()
                    'Sistemas
                    If Proceso(CUsuarios.Text) = 33 Then
                        Index.PCompras.Visible = True
                        Index.PCostos.Visible = True
                        Index.PTransporte.Visible = True
                        Index.PAGasolina.Visible = True
                        Index.PAlmacen.Visible = True
                        Index.PMass.Visible = True
                        Index.PPedidos.Visible = True
                        Index.PMaPrima.Visible = True
                        Index.Parh.Visible = True
                        Index.PA_R.Visible = True
                        Index.PSCRAP.Visible = True
                        Index.PProcesos.Visible = True
                        Index.PStatus.Visible = True

                        'Almacen
                    ElseIf Proceso(CUsuarios.Text) = 43 Then
                        Index.PAlmacen.Visible = True
                        Index.PAlmacen.Location = New Point(30, 138)
                        Index.PMAlmacen.Visible = True
                        Index.PCompras.Visible = False
                        Index.btn_pdf.Visible = False
                        Index.Lpdf.Visible = False
                        Index.PMPrima.Visible = False
                        Index.LAP.Visible = False
                        Index.btn_entrega_equipo_seguridad.Visible = False
                        Index.Label18.Visible = False
                        Index.btn_ventas.Visible = False
                        Index.Label13.Visible = False

                        If LV.Text = "0" Then
                            Index.PContabilizar.Visible = True
                        Else
                            Index.PContabilizar.Visible = False
                        End If


                        'Compras
                    ElseIf Proceso(CUsuarios.Text) = 35 Then
                        Index.PCompras.Visible = True
                        Index.PCompras.Location = New Point(30, 138)
                        Index.PMCompras.Visible = True


                        'Costos - Finanza
                    ElseIf Proceso(CUsuarios.Text) = 44 Then
                        Index.PCostos.Visible = True
                        Index.PCostos.Location = New Point(30, 138)

                        'TRASPORTE  
                    ElseIf Proceso(CUsuarios.Text) = 31 Then
                        Index.PTransporte.Location = New Point(30, 138)
                        Index.PAGasolina.Location = New Point(97, 138)

                        'Mass
                    ElseIf Proceso(CUsuarios.Text) = 36 Then
                        Index.PMass.Visible = True
                        Index.PMass.Location = New Point(30, 138)
                        Index.PMMass.Visible = True


                        'Materia Prima
                    ElseIf Proceso(CUsuarios.Text) = 50 Then
                        Index.PMaPrima.Visible = True
                        Index.PMaPrima.Location = New Point(30, 138)
                        Index.PMMPrima.Visible = True

                        'RH
                    ElseIf Proceso(CUsuarios.Text) = 34 Then
                        Index.Parh.Visible = True
                        Index.Parh.Location = New Point(30, 138)
                    End If
            Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + CUsuarios.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    'Combos
    Private Sub CProceso_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CProceso.SelectionChangeCommitted
        C_Usuarios()
        TxtContrasena.Text = ""
    End Sub


    'Funciones
    '   Combo para mostrar los procesos
    Sub C_Proceso()
        Dim Comando As SqlCommand
        Dim Tabla As DataTable
        Dim Adaptador As SqlDataAdapter
        Dim Conex As New SqlConnection(My.Settings.Conexxx)
        Conex.Open()

        Comando = New SqlCommand("SELECT * 
                                  FROM TB_Procesos 
                                  WHERE Estado = 'Activo' 
                                  ORDER BY Nombre_Proceso ASC", Conex)
        Adaptador = New SqlDataAdapter(Comando)
        Tabla = New DataTable()
        Adaptador.Fill(Tabla)

        '-------Area--------------
        CProceso.DataSource = Tabla
        CProceso.DisplayMember = "Nombre_Proceso"
        CProceso.ValueMember = "Id_Proceso"
    End Sub

    '   Combo Usuarios
    Sub C_Usuarios()
        Dim Comando As SqlCommand
        Dim Tabla As DataTable
        Dim Adaptador As SqlDataAdapter
        Dim Proceso As String
        Proceso = CProceso.SelectedValue
        Dim Conexxo As New SqlConnection(My.Settings.Conexxx)
        Conexxo.Open()
        Comando = New SqlCommand("SELECT * 
                                  FROM TB_Usuarios 
                                  WHERE Id_Proceso = '" + Proceso + "'
                                  AND Estado = 'Activo'", Conexxo)
        Adaptador = New SqlDataAdapter(Comando)
        Tabla = New DataTable()
        Adaptador.Fill(Tabla)

        '-------Area--------------
        CUsuarios.DataSource = Tabla
        CUsuarios.DisplayMember = "Usuario"
        CUsuarios.ValueMember = "Id_Usuario"
    End Sub

    Sub C_A()
        Dim Conex As New SqlConnection(My.Settings.Conexxx)

        Dim Consulta As String = "SELECT Id_Area
                                    FROM TB_Procesos 
                                    WHERE Estado = 'Activo' And Nombre_Proceso = 'Almacen'"

        Dim cmd As New SqlCommand(Consulta, Conex)

        Dim Da As SqlDataReader
        Conex.Open()
        Da = cmd.ExecuteReader()
        If Da.Read() Then
            LV.Text = Da.Item("Id_Area").ToString()
        End If
        Da.Close()
    End Sub
End Class
