Imports System.Data.SqlClient

Public Class NPrestamo
    Dim Conex As New SqlConnection(My.Settings.Conexxx)

    Private Sub NPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nombres()
        DatosGVP()
        DatosGVT()


        'Crear Código
        Dim Fecha = DateTime.Now.ToString("yy")
        Dim cmd As New SqlCommand("SELECT Id_Prestamo
                                       FROM TB_Prestamos
                                       ORDER BY Id_Prestamo DESC", Conex)
        Dim strCodigo As String

        Conex.Open()
        strCodigo = cmd.ExecuteScalar
        Conex.Close()

        Dim Id As Integer = CType(strCodigo.Substring(0), Integer)

        LCS.Text = "CSAP-" + Format(Id + 1, "0000") + "/" + Fecha 'Inventario
        Tickets.LCS.Text = "CSAP-" + Format(Id + 1, "0000") + "/" + Fecha 'Tickets

        'Insertar Código
        If Tickets.LCS.Text <> Nothing Then
            Dim CodS As String = LCS.Text
            Dim Emple As String = LUsuario.Text

            Conex.Open()
            Dim CONSULTA As String = "IF NOT EXISTS (SELECT CodS FROM TB_CodigS WHERE CodS = '" & CodS & "')
		                                    INSERT INTO TB_CodigS (CodS, Created)
                                                           VALUES ( '" & CodS & "', SYSDATETIME())"
            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()
            Conex.Close()
        End If
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

    Private Sub BGuardarMo_Click(sender As Object, e As EventArgs) Handles BGuardarMo.Click
        If MsgBox("Desea Guardar el Prestamo", vbYesNo) = vbYes Then
            If IDE.Text = "" Or IDP.Text = "" Then
                MessageBox.Show("Seleccione al Trabajador y/o Material", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim Emple As String = LUsuario.Text
                Dim CodS As String = LCS.Text

                Conex.Open()
                Dim CONSULTAa As String = "IF NOT EXISTS(SELECT CodiS FROM TB_MovimientoRastreo WHERE CodiS = '" & CodS & "')
                                    INSERT INTO TB_MovimientoRastreo (Tipo, Estado, Responsable, CodiS , Created)
                                                            VALUES ( 'Prestamo', 'Entrega', '" & Emple & "', '" & CodS & "',SYSDATETIME() )"
                Dim COMANDOa As New SqlCommand(CONSULTAa, Conex)

                COMANDOa.ExecuteNonQuery()
                Conex.Close()

                Datos()
            End If
        End If
    End Sub

    Private Sub BBTrabajador_Click(sender As Object, e As EventArgs) Handles BBTrabajador.Click
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

    Private Sub BBProducto_Click(sender As Object, e As EventArgs) Handles BBProducto.Click
        If PMaterial.Visible = False Then
            PMaterial.Visible = True
        Else
            If PMaterial.Visible = True Then
                PMaterial.Visible = False
            End If
        End If
    End Sub

    Private Sub DGProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducto.CellContentClick
        Dim FilaID As Integer
        Dim FilaP As String
        Dim row As DataGridViewRow = DGProducto.Rows(e.RowIndex)

        FilaID = row.Cells(0).Value
        IDP.Text = FilaID

        FilaP = row.Cells(1).Value
        TxtMaterial.Text = FilaP

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

    Private Sub ANuevoT_Click(sender As Object, e As EventArgs) Handles ANuevoT.Click
        PNT.Visible = True
        PTrabajador.Visible = False
        TxtNNN.Text = ""
        TxtNombre.Text = ""
        TxtAP.Text = ""
        TxtAM.Text = ""
    End Sub

    Private Sub BRNT_Click(sender As Object, e As EventArgs) Handles BRNT.Click
        PNT.Visible = False
        PTrabajador.Visible = True
    End Sub

    Private Sub BGNT_Click(sender As Object, e As EventArgs) Handles BGNT.Click
        If MsgBox("Desea Guardar la Siguiente Información: " & TxtNNN.Text & " - " & TxtNombre.Text & " " & TxtAP.Text & " " & TxtAM.Text, vbYesNo) = vbYes Then
            If TxtNombre.Text = "" Or TxtAP.Text = "" Or TxtAM.Text = "" Then
                MessageBox.Show("Ingrese el Nombre Completo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                DatosNT()
            End If
        End If
    End Sub

    Private Sub TxtBMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtBMaterial.TextChanged
        ConDMa()
    End Sub

    Private Sub TxtBusT_TextChanged(sender As Object, e As EventArgs) Handles TxtBusT.TextChanged
        ConDTra()
    End Sub


    'Procedimientos
    '   Guardar
    Public Sub Datos()
        Dim GDatos As New SqlCommand("SP_GPrestamo", Conex)
        Dim DateA = DateTime.Now

        GDatos.CommandType = CommandType.StoredProcedure

        GDatos.Parameters.AddWithValue("@Id_Empleado", Trim(IDE.Text))
        GDatos.Parameters.AddWithValue("@Id_Producto", Trim(IDP.Text))
        GDatos.Parameters.AddWithValue("@Cantidad", Trim(TxtCantidad.Text))
        GDatos.Parameters.AddWithValue("@FPrestamo", DateA)
        GDatos.Parameters.AddWithValue("@FEntrega ", DTFEntrega.Value)
        GDatos.Parameters.AddWithValue("@Descripcion", Trim(TxtDescripcion.Text))
        GDatos.Parameters.AddWithValue("@Con_Salida", Trim(TxtDSalida.Text))
        GDatos.Parameters.AddWithValue("@ResponsableS", Trim(LUsuario.Text))
        GDatos.Parameters.AddWithValue("@Created", DateA)

        Dim RData As SqlDataReader
        Try
            Conex.Open()
            Dim Prod As String = TxtMaterial.Text
            Dim CodS As String = LCS.Text
            Dim CanS As Double = CDec(TxtCantidad.Text)

            Dim CONSULTA As String = "INSERT INTO TB_DetalleSeguimiento (CodiS, Producto, CanE, CanS, PrecioE, PrecioS, Created)
                                                                VALUES ('" & CodS & "', '" & Prod & "', '" & CanS & "', 0, 0, 0, SYSDATETIME())"

            Dim COMANDO As New SqlCommand(CONSULTA, Conex)

            COMANDO.ExecuteNonQuery()

            RData = GDatos.ExecuteReader()

            Me.Close()
            Prestamos.Show()

        Catch ex As Exception
            MessageBox.Show(Err.Description.ToString(), "Error al Guardar Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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


    'Consultas
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

    Private Sub DatosGVP()
        Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto
                                  FROM TB_Productos
                                  WHERE Estado = 'Activo' AND
                                        Existencia > 0
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

    Private Sub ConDMa()
        If TxtBMaterial.Text = "" Then
            DatosGVP()
        Else
            Dim Consulta As String = "SELECT Id_Producto, Nombre_Producto, Clave_Producto
                                      FROM TB_Productos
                                      WHERE Estado = 'Activo' AND
                                            (Nombre_Producto  LIKE '%'+@Busqueda+'%' OR
                                            Clave_Producto  LIKE '%'+@Busqueda+'%') AND
                                            Existencia > 0
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

    Private Sub ConDTra()
        If TxtBusT.Text = "" Then
            DatosGVT()
        Else
            Dim Consulta As String = "SELECT Id_Empleado, Numero_Nomina, (Nombre_Empleado + ' ' + Ape_Paterno + ' ' + Ape_Materno) AS Nombre
                                      FROM TB_Empleados
                                      WHERE Estado = 'Activo' AND
                                            (Numero_Nomina  LIKE '%'+@Busqueda+'%' OR
                                            Nombre_Empleado  LIKE '%'+@Busqueda+'%' OR
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


    'Validaciones
    Private Sub TxtCalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCantidad.KeyPress
        NumerosyDecimal(TxtCantidad, e)
    End Sub

    '   Numeros y Punto Decimal
    Public Sub NumerosyDecimal(ByVal CajaTexto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not CajaTexto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    'Mover
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