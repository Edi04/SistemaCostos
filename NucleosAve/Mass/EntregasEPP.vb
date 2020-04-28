Imports System.Data.SqlClient

Public Class EntregasEPP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Dim PProceso As New SqlCommand
    Dim DTProceso As DataTable
    Dim DAProceso As New SqlDataAdapter

    Private Sub EntregasEPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultas()
        DI()
        DatosGVP()
        DatosGVT()
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

    Private Sub BNuevoPrestamo_Click(sender As Object, e As EventArgs) Handles BNuevoPrestamo.Click
        'Crear Código
        Dim Fecha = DateTime.Now.ToString("yy")
        Dim cmd As New SqlCommand("SELECT Id_S
                                       FROM TB_CodigS
                                       ORDER BY Id_S DESC", Conex)
        Dim strCodigo As String

        Conex.Open()
        strCodigo = cmd.ExecuteScalar
        Conex.Close()

        Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

        LCS.Text = "CSAME-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario

        'Insertar Código
        If ETickets.LCS.Text <> Nothing Then
            Dim CodS As String = LCS.Text

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()
        End If


        Nombres()
        TxtCantidad.ReadOnly = False
        TxtDescripcion.ReadOnly = False
        TxtCantidad.BackColor = Color.LightCoral
        TxtDescripcion.BackColor = Color.LightCoral

        BEliminar.Visible = False
        BGEntrega.Visible = True
        BRIngreso.Visible = True
        BBTrabajador.Visible = True
        BBBMaterial.Visible = True
        CProceso.Visible = True

        DatosB()
        TxtBMaterial.Text = ""
    End Sub

    Private Sub BBTrabajador_Click(sender As Object, e As EventArgs) Handles BBTrabajador.Click
        PMaterial.Visible = False
        If PTrabajador.Visible = False Then
            PTrabajador.Visible = True
            ANuevoT.Visible = True
        Else
            If PTrabajador.Visible = True Then
                PTrabajador.Visible = False
                ANuevoT.Visible = False
            End If
        End If
    End Sub

    Private Sub BBBMaterial_Click(sender As Object, e As EventArgs) Handles BBBMaterial.Click
        If PMaterial.Visible = False Then
            PMaterial.Visible = True
        Else
            If PMaterial.Visible = True Then
                PMaterial.Visible = False
            End If
        End If
    End Sub

    Private Sub BRNT_Click(sender As Object, e As EventArgs) Handles BRNT.Click
        PNT.Visible = False
        PTrabajador.Visible = True
    End Sub

    Private Sub BGNT_Click(sender As Object, e As EventArgs) Handles BGNT.Click
        If MsgBox("Desea Guardar la Información: " & TxtNNN.Text & " " & TxtNombre.Text & " " & TxtAP.Text & " " & TxtAM.Text, vbYesNo) = vbYes Then
            If TxtNombre.Text = "" Or TxtAP.Text = "" Or TxtAM.Text = "" Then
                MessageBox.Show("Ingrese el Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosNT()
            End If
        End If
    End Sub

    Private Sub ANuevoT_Click(sender As Object, e As EventArgs) Handles ANuevoT.Click
        PNT.Visible = True
        PTrabajador.Visible = False
        TxtNNN.Text = ""
        TxtNombre.Text = ""
        TxtAP.Text = ""
        TxtAM.Text = ""
    End Sub


    Private Sub CEPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles CEPendientes.CheckedChanged
        If CEPendientes.Checked = True Then
            CEPendientes.Text = "Entregas Pendientes"
            DI()
        ElseIf CEPendientes.Checked = False Then
            CEPendientes.Text = "Entregas Finalizadas"
        End If
    End Sub

    Private Sub TxtBusT_TextChanged(sender As Object, e As EventArgs) Handles TxtBusT.TextAlignChanged
        ConDTra()
    End Sub

    Private Sub TxtBMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtBMaterial.TextAlignChanged
        ConDMa()
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim Exis As Double
        Dim row As DataGridViewRow = DGProducto.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDP.Text = FilaID

        FilaP = row.Cells(1).Value
        TxtMaterial.Text = FilaP

        Exis = row.Cells(3).Value
        LEx.Text = Exis

        PMaterial.Visible = False
    End Sub

    Private Sub DGTrabajador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTrabajador.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim NN As String
        Dim row As DataGridViewRow = DGTrabajador.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDE.Text = FilaID

        NN = row.Cells(1).Value
        TxtNN.Text = NN

        FilaP = row.Cells(2).Value
        TxtTrabajador.Text = FilaP

        PTrabajador.Visible = False
        ANuevoT.Visible = False
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

    Private Sub DI()
        Dim Consulta As String = "SELECT E.Id_Entrega, Em.Numero_Nomina, (Em.Nombre_Empleado + ' ' + 
			                             Em.Ape_Paterno + ' ' + Em.Ape_Materno ) AS Nombre,
			                             P.Id_Producto, P.Nombre_Producto, E.Cantidad, E.Descripcion, Pr.Nombre_Proceso
                                  FROM TB_Entregas AS E
                                      INNER JOIN TB_Empleados AS Em ON E.Id_Empleado = Em.Id_Empleado
                                      INNER JOIN TB_Productos AS P ON e.Id_Producto = P.Id_Producto
                                      INNER JOIN TB_Procesos AS Pr ON e.Proceso = Pr.Id_Proceso
                                  WHERE E.Estado = 'Pendiente'
                                  ORDER BY E.Fecha_Entrega asc"

        Dim cmd As New SqlCommand(Consulta, Conex)
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
    End Sub

    Private Sub DatosGVT()
        Dim Consulta As New SqlCommand("SP_BTrabajador", Conex)
        Consulta.CommandType = CommandType.StoredProcedure

        Dim Da As New SqlDataAdapter(Consulta)
        Dim Ds As New DataSet

        Try
            Conex.Open()
            Da.Fill(Ds)

            DGTrabajador.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error de Datos", MessageBoxButtons.OK)
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
            TxtResponsable.Text = Da.Item("Nombre").ToString()
        End If

        Da.Close()
        Conex.Close()
    End Sub

    Private Sub ConDTra()
        If TxtBusT.Text = "" Then
            DatosGVT()
        Else
            Dim Consulta As String = "Select Id_Empleado, Numero_Nomina, (Nombre_Empleado + ' ' + Ape_Paterno + ' ' + Ape_Materno) As Nombre
                                        FROM TB_Empleados
                                        WHERE Estado = 'Activo' AND
                                                (Numero_Nomina  LIKE '%'+@Busqueda+'%' OR
                                                Nombre_Empleado  LIKE '%'+@Busqueda+'%' or
                                                Ape_Paterno  LIKE '%'+@Busqueda+'%' OR
                                                Ape_Materno  LIKE '%'+@Busqueda+'%')
                                        ORDER BY Numero_Nomina ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBusT.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DGTrabajador.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Private Sub ConDMa()
        If TxtBMaterial.Text = "" Then
            DatosGVP()
        Else
            Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                        FROM TB_Productos
                                        WHERE Estado = 'Activo' AND
                                                (Nombre_Producto  LIKE '%'+@Busqueda+'%' OR
                                                Clave_Producto  LIKE '%'+@Busqueda+'%' OR
                                                Codigo_Barras LIKE '%'+@Busqueda+'%') AND
									            Existencia > 0 AND
                                                (Nombre_Producto LIKE '%EPP%' OR
	                                    Nombre_Producto LIKE '%Zapato%')

                                        ORDER BY Nombre_Producto ASC"

            Dim cmd As New SqlCommand(Consulta, Conex)
            cmd.Parameters.AddWithValue("@Busqueda", Trim(TxtBMaterial.Text))
            Dim Da As New SqlDataAdapter(cmd)
            Dim Ds As New DataSet

            Try
                Conex.Open()

                Da.Fill(Ds)
                DGProducto.DataSource = Ds.Tables(0)
                Da.Dispose()

            Catch ex As Exception
                MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Conex.Close()
        End If
    End Sub

    Public Sub DatosNT()
        Dim GDatos As New SqlCommand("SP_NTrabajador", Conex)

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@NNomina", Trim(TxtNNN.Text))
        GDatos.Parameters.AddWithValue("@Nombre", Trim(TxtNombre.Text))
        GDatos.Parameters.AddWithValue("@APaterno", Trim(TxtAP.Text))
        GDatos.Parameters.AddWithValue("@AMaterno", Trim(TxtAM.Text))

        Try
            Conex.Open()
            GDatos.ExecuteReader()
            PNT.Visible = False
            PTrabajador.Visible = True

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
        DatosGVT()
    End Sub


    Private Sub DatosGVP()
        Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto, Existencia
                                  FROM TB_Productos
                                  WHERE Estado = 'Activo' AND
									    Existencia > 0 AND
                                        (Nombre_Producto LIKE '%EPP%' OR
	                                    Nombre_Producto LIKE '%Zapato%')

                                  ORDER BY Nombre_Producto ASC"

        Dim cmd As New SqlCommand(Consulta, Conex)
        Dim Da As New SqlDataAdapter(cmd)
        Dim Ds As New DataSet

        Try
            Conex.Open()

            Da.Fill(Ds)
            DGProducto.DataSource = Ds.Tables(0)
            Da.Dispose()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Conex.Close()
    End Sub

    Private Sub DatosB()
        TxtNN.Text = ""
        TxtTrabajador.Text = ""
        TxtMaterial.Text = ""
        TxtCantidad.Text = ""
        TxtDescripcion.Text = ""
        TxtProceso.Text = ""
    End Sub


End Class