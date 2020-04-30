Imports System.Data.SqlClient

Public Class EntregaEPP
    Dim Conex As New SqlConnection(My.Settings.Conexxx)
    Private Sub EntregaEPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DI()
        Nombres()
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

    Private Sub DatosPM_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DatosPM.CellContentClick
        Dim row As DataGridViewRow = DatosPM.CurrentRow()

        'Mostrar Inf en TextBox
        IDD.Text = row.Cells(0).Value
        TxtNN.Text = row.Cells(1).Value
        TxtTrabajador.Text = row.Cells(2).Value
        IDP.Text = row.Cells(3).Value
        TxtMaterial.Text = row.Cells(4).Value
        TxtCantidad.Text = row.Cells(5).Value
        TxtDescripcion.Text = row.Cells(6).Value
        TxtProceso.Text = row.Cells(7).Value

        BEntrega.Visible = True
    End Sub

    Private Sub BEntrega_Click(sender As Object, e As EventArgs) Handles BEntrega.Click
        'Crear Código
        Dim Fecha = DateTime.Now.ToString("yy")
        Dim cmd As New SqlCommand("SELECT Id_Entrega
                                       FROM TB_Entregas
                                       ORDER BY Id_Entrega DESC", Conex)
        Dim strCodigo As String

        Conex.Open()
        strCodigo = cmd.ExecuteScalar
        Conex.Close()

        Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

        LCS.Text = "CSAEEPP-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario

        If MsgBox("Desea Entregar a: " & TxtTrabajador.Text, vbYesNo) = vbYes Then
            Dim CodS As String = LCS.Text

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()

            Datos()
        End If
    End Sub


    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        DatosGPP()
    End Sub

    Public Sub Datos()
        Dim DateTime As Date = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")
        Dim CodS As String = LCS.Text
        Dim Emple As String = TxtResponsable.Text

        Conex.Open()
        Dim CONSULTA As String = "INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Entrega', 'Entrega', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
        Dim COMANDO As New SqlCommand(CONSULTA, Conex)

        COMANDO.ExecuteNonQuery()

        '////

        Dim Prod As String = TxtMaterial.Text
        Dim CanS As Double = CDec(TxtCantidad.Text)

        Dim CONSULTAA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS, Created)
                                                                VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, 0, 0, SYSDATETIME())"

        Dim COMANDOA As New SqlCommand(CONSULTAA, Conex)

        COMANDOA.ExecuteNonQuery()

        '////
        Dim Id As Integer = IDP.Text
        Dim En As Integer = IDD.Text
        Dim CONSULTAAa As String = "UPDATE TB_Entregas
                                        SET Fecha_Entrega = SYSDATETIME(),
                                            Estado = 'Activo',
                                            ResponsableS = '" & Emple & "',
                                            ExiA = (SELECT TOP 1 Existencia FROM TB_Productos Where Id_Producto = " & Id & "),
                                            ExiD = (SELECT TOP 1 (Existencia - " & CanS & ") FROM TB_Productos Where Id_Producto = " & Id & ")
                                        WHERE Id_Entrega = " & En & "
                                            
SET NOCOUNT ON;
	UPDATE Tb_productos
		Set Existencia = (SELECT TOP 1 (Existencia - " & CanS & ") FROM TB_Productos Where Id_Producto = " & Id & ")
		Where   Id_Producto = " & Id & ""

        Dim COMANDOAa As New SqlCommand(CONSULTAAa, Conex)

        COMANDOAa.ExecuteNonQuery()
        Conex.Close()

        IDD.Text = ""
        TxtNN.Text = ""
        TxtTrabajador.Text = ""
        IDP.Text = ""
        TxtMaterial.Text = ""
        TxtCantidad.Text = ""
        TxtDescripcion.Text = ""
        TxtProceso.Text = ""
        BEntrega.Visible = False
        DI()


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

    Private Sub DatosGPP()
        If TxtBusqueda.Text <> "" Then
            Dim Consulta As String = "SELECT E.Id_Entrega, Em.Numero_Nomina, (Em.Nombre_Empleado + ' ' + 
			                             Em.Ape_Paterno + ' ' + Em.Ape_Materno ) AS Nombre,
			                             P.Id_Producto, P.Nombre_Producto, E.Cantidad, E.Descripcion, Pr.Nombre_Proceso
                                      FROM TB_Entregas AS E
                                          INNER JOIN TB_Empleados AS Em ON E.Id_Empleado = Em.Id_Empleado
                                          INNER JOIN TB_Productos AS P ON e.Id_Producto = P.Id_Producto
                                          INNER JOIN TB_Procesos AS Pr ON e.Proceso = Pr.Id_Proceso
                                      WHERE E.Estado = 'Pendiente' AND
                                            (Em.Numero_Nomina LIKE '%'+@Busqueda+'%' OR
                                            P.Nombre_Producto LIKE '%'+@Busqueda+'%' OR
                                            P.Codigo_Barras LIKE '%'+@Busqueda+'%')
                                      ORDER BY E.Created ASC"

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

End Class